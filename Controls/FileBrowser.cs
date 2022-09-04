// <copyright file = "FileBrowser.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System.Linq;
    using VisualPlus.Toolkit.Child;

    public partial class FileBrowser
    {
        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public string Extension { get; set; }

        /// <summary>
        /// Gets or sets the initial path.
        /// </summary>
        /// <value>
        /// The initial path.
        /// </value>
        public IEnumerable<string> InitialDirPaths { get; set; }

        /// <summary>
        /// Gets or sets the check boxes.
        /// </summary>
        /// <value>
        /// The check boxes.
        /// </value>
        public IEnumerable<CheckBox> CheckBoxes { get; set; }

        /// <summary>
        /// Gets or sets the selected path.
        /// </summary>
        /// <value>
        /// The selected path.
        /// </value>
        public string SelectedPath { get; set; }

        /// <summary>
        /// Gets or sets the selected file.
        /// </summary>
        /// <value>
        /// The selected file.
        /// </value>
        public string SelectedFile { get; set; }

        /// <summary>
        /// Gets the dir sep.
        /// </summary>
        /// <value>
        /// The dir sep.
        /// </value>
        public char DirSep { get; } = Path.DirectorySeparatorChar;

        /// <summary>
        /// Gets the path sep.
        /// </summary>
        /// <value>
        /// The path sep.
        /// </value>
        public char PathSep { get; } = Path.PathSeparator;

        /// <summary>
        /// Gets the invalid path character.
        /// </summary>
        /// <value>
        /// The invalid path character.
        /// </value>
        public char[ ] InvalidPathChars { get; } = Path.GetInvalidPathChars( );

        /// <summary>
        /// Gets the invalid namehar.
        /// </summary>
        /// <value>
        /// The invalid namehar.
        /// </value>
        public char[ ] InvalidNameChars { get; } = Path.GetInvalidFileNameChars( );

        /// <summary>Initializes a new instance of the 
        /// <see cref="FileBrowser" /> class.</summary>
        public FileBrowser( )
        {
            InitializeComponent( );
            Size = new Size( 700, 480);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = Color.FromArgb( 15, 15, 15 );
            CloseButton.Click += OnCloseButtonClicked;
            InitialDirPaths = GetInitialDirPaths( );
            FileDialog.DefaultExt = ".xlsx";
            FileDialog.InitialDirectory = 
                Environment.GetFolderPath( Environment.SpecialFolder.Desktop );
            FileDialog.CheckFileExists = true;
            Load += OnLoaded;
        }

        /// <summary>
        /// Called when [browser loaded].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
        public void OnLoaded( object sender, EventArgs e )
        {
            if ( FileDialog != null )
            {
                try
                {
                    PdfCheckBox.CheckState = CheckState.Unchecked;
                    SQLiteCheckBox.CheckState = CheckState.Unchecked;
                    SqlCeCheckBox.CheckState = CheckState.Unchecked;
                    SqlServerCheckBox.CheckState = CheckState.Unchecked;
                    ExcelCheckBox.CheckState = CheckState.Unchecked;
                    CsvCheckBox.CheckState = CheckState.Unchecked;
                    WordCheckBox.CheckState = CheckState.Unchecked;
                    AccessCheckBox.CheckState = CheckState.Unchecked;
                    CheckBoxes = GetCheckBoxex( );
                    //FileDialog.ShowDialog( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [selection].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnCheckBoxSelected( object sender, EventArgs e )
        {
            if( sender is CheckBox _checkBox
                && !string.IsNullOrEmpty( _checkBox.Tag?.ToString( ) )
                && e != null )
            {
                try
                {
                    Extension = _checkBox.Tag?.ToString( );
                    FileDialog.Filter = Extension;
                    Close( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the check boxex.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<CheckBox> GetCheckBoxex( )
        {
            try
            {
                var _list = new List<CheckBox>( );
                _list.Add( PdfCheckBox );
                _list.Add( AccessCheckBox );
                _list.Add( SQLiteCheckBox );
                _list.Add( SqlCeCheckBox );
                _list.Add( SqlServerCheckBox );
                _list.Add( ExcelCheckBox );
                _list.Add( CsvCheckBox );
                _list.Add( PowerPointCheckBox );
                _list.Add( WordCheckBox );

                return _list?.Any( ) == true
                    ? _list
                    : default( IEnumerable<CheckBox> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<CheckBox> );
            }
        }

        /// <summary>
        /// Gets the initial paths.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetInitialDirPaths( )
        {
            try
            {
                var _list = new List<string>( );
                var _myDocuments = Environment.GetFolderPath( Environment.SpecialFolder.MyDocuments );
                var _commonDocuments = Environment.GetFolderPath( Environment.SpecialFolder.CommonDocuments );
                var _desktop = Environment.GetFolderPath( Environment.SpecialFolder.Desktop );
                _list.Add( _myDocuments );
                _list.Add( _commonDocuments );
                _list.Add( _desktop );

                return _list?.Any( ) == true
                    ? _list
                    : default( IEnumerable<string> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        public virtual IEnumerable<string> SearchPath(  )
        {
            if( InitialDirPaths?.Any( ) == true )
            {
                try
                {
                    var _list = new List<string>( );
                    foreach( var path in InitialDirPaths )
                    {
                        if ( Path.HasExtension( path ) )
                        {
                            var _ext = Path.GetExtension( path );
                            if( !string.IsNullOrEmpty( _ext ) 
                                && FileDialog.DefaultExt.Contains( _ext ) )
                            {
                                _list.Add( Path.GetFullPath( path ) );
                            }
                        }
                    }

                    return _list?.Any(  ) == true
                        ? _list
                        : default( IEnumerable<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }

        public virtual void PopulateListView()
        {
            if( InitialDirPaths?.Any( ) == true )
            {
                try
                {
                    var _list = new List<VisualListViewItem>( );
                    foreach( var path in InitialDirPaths )
                    {
                        if( Path.HasExtension( path ) )
                        {
                            var _ext = Path.GetExtension( path );
                            if( !string.IsNullOrEmpty( _ext )
                                && FileDialog.DefaultExt.Contains( _ext ) )
                            {
                                _list.Add( path );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [exension selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnExensionSelected( object sender, EventArgs e )
        {
            if( sender is CheckBox _checkBox
                && !string.IsNullOrEmpty( _checkBox.Tag?.ToString( ) )
                && e != null )
            {
                try
                {
                    Extension = _checkBox.Tag?.ToString( ); 
                    FileDialog.Filter = Extension;
                    Close( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [path selected].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnPathSelected( object sender, EventArgs e )
        {
            if( sender is OpenFileDialog _fileDialog
                && !string.IsNullOrEmpty( _fileDialog.SafeFileName )
                && e != null )
            {
                try
                {
                    SelectedPath = _fileDialog.SafeFileName;
                    Close( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnCloseButtonClicked( object sender, EventArgs e )
        {
            if( sender is Button  )
            {
                try
                {
                    Close( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The exception.</param>
        private static void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}
