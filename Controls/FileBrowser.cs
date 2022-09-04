// <copyright file = "FileBrowser.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Windows.Forms;
    using System.Linq;

    public partial class FileBrowser
    {
        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public EXT Extension { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public string FileExtension { get; set; }

        /// <summary>
        /// Gets or sets the initial path.
        /// </summary>
        /// <value>
        /// The initial path.
        /// </value>
        public IEnumerable<string> InitialDirPaths { get; set; }

        /// <summary>
        /// Gets or sets the initial path.
        /// </summary>
        /// <value>
        /// The initial path.
        /// </value>
        public List<string> FilePaths { get; set; }

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
            InitialDirPaths = GetInitialDirPaths( );
            CheckBoxes = GetCheckBoxes( );
            FileExtension = "xlsx";
            PictureBox.Image = GetImage( );
            FilePaths = GetListViewPaths( );

            FileDialog.DefaultExt = FileExtension;
            FileDialog.InitialDirectory = Environment.GetFolderPath( Environment.SpecialFolder.DesktopDirectory );
            FileDialog.CheckFileExists = true;

            CloseButton.Click += OnCloseButtonClicked;
            FileList.SelectedValueChanged += OnPathSelected;

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
                    InitCheckBoxes( );
                    PopulateListView( );
                    FoundLabel.Text = "Found : " + FilePaths.Count;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Initializes the check boxes.
        /// </summary>
        public void InitCheckBoxes( )
        {
            try
            {
                PdfCheckBox.CheckState = CheckState.Unchecked;
                PdfCheckBox.CheckStateChanged += OnCheckBoxSelected;
                SQLiteCheckBox.CheckState = CheckState.Unchecked;
                SQLiteCheckBox.CheckStateChanged += OnCheckBoxSelected;
                SqlCeCheckBox.CheckState = CheckState.Unchecked;
                SqlCeCheckBox.CheckStateChanged += OnCheckBoxSelected;
                SqlServerCheckBox.CheckState = CheckState.Unchecked;
                SqlServerCheckBox.CheckStateChanged += OnCheckBoxSelected;
                ExcelCheckBox.CheckState = CheckState.Checked;
                ExcelCheckBox.CheckStateChanged += OnCheckBoxSelected;
                CsvCheckBox.CheckState = CheckState.Unchecked;
                CsvCheckBox.CheckStateChanged += OnCheckBoxSelected;
                WordCheckBox.CheckState = CheckState.Unchecked;
                WordCheckBox.CheckStateChanged += OnCheckBoxSelected;
                AccessCheckBox.CheckState = CheckState.Unchecked;
                AccessCheckBox.CheckStateChanged += OnCheckBoxSelected;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the image.
        /// </summary>
        /// <returns></returns>
        public Image GetImage( )
        {
            if( !string.IsNullOrEmpty( FileExtension) )
            {
                var _path = ConfigurationManager.AppSettings[ "Extensions" ];
                var _files = Directory.GetFiles( _path );

                if ( _files?.Any( ) == true )
                {
                    var _file = _files
                        .Where( f => f.Contains( FileExtension.ToUpper( ) ) )
                        ?.Single( );

                    using( var stream = File.Open( _file, FileMode.Open ) )
                    {
                        var _img = Image.FromStream( stream );
                        return new Bitmap(  _img, 22, 22 );
                    }
                }
            }

            return default( Bitmap );
        }

        /// <summary>
        /// Gets the ListView file paths.
        /// </summary>
        /// <returns></returns>
        public List<string> GetListViewPaths( )
        {
            if( InitialDirPaths?.Any( ) == true )
            {
                try
                {
                    var _list = new List<string>( );
                    var _pattern = "." + FileExtension;
                    foreach( var path in InitialDirPaths )
                    {
                        var _first = Directory.EnumerateFiles( path )
                            ?.Where( f => f.EndsWith( _pattern ) )
                            ?.Select( f => Path.GetFullPath( f ) )
                            ?.ToArray( );

                        _list.AddRange( _first );

                        var _dirs = Directory.GetDirectories( path );
                        foreach( var dir in _dirs )
                        {
                            if( !dir.Contains( "My " ) )
                            {
                                var _second = Directory.EnumerateFiles( dir )
                                   ?.Where( s => s.EndsWith( _pattern ) )
                                   ?.Select( s => Path.GetFullPath( s ) )
                                   ?.ToArray( );

                                _list.AddRange( _second );

                                var _subdir = Directory.GetDirectories( dir );
                                foreach( var sub in _subdir )
                                {
                                    var _last = Directory.EnumerateFiles( sub )
                                        ?.Where( l => l.EndsWith( _pattern ) )
                                        ?.Select( l => Path.GetFullPath( l ) )
                                        ?.ToArray( );

                                    _list.AddRange( _last );
                                }

                            }
                            
                        }

                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( List<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( List<string> );
                }
            }

            return default( List<string> );
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
                    FileExtension = _checkBox?.Tag?.ToString(  );
                    FileList.Items.Clear(  );
                    FilePaths?.Clear(  );
                    SelectedPath = string.Empty;
                    var _paths = GetListViewPaths(   );
                    PopulateListView( _paths );
                    PictureBox.Image = GetImage(   );

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
        public virtual IEnumerable<CheckBox> GetCheckBoxes( )
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
                _list.Add( TextCheckBox );
                _list.Add( PowerPointCheckBox );
                _list.Add( WordCheckBox );
                _list.Add( ExecutableCheckBox );
                _list.Add( LibraryCheckBox );

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
                var _current = Environment.CurrentDirectory;
                var _list = new List<string>( );
                _list.Add( Environment.GetFolderPath( Environment.SpecialFolder.DesktopDirectory ) );
                _list.Add( Environment.GetFolderPath( Environment.SpecialFolder.Personal ) );
                _list.Add( Environment.GetFolderPath( Environment.SpecialFolder.Desktop ) );
                _list.Add( Environment.GetFolderPath( Environment.SpecialFolder.CommonDocuments ) );
                _list.Add( @"C:\Users\terry\source\repos\Badjao\Resources\Docs"  );
                _list.Add( _current );

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
        /// Populates the ListView.
        /// </summary>
        public virtual void PopulateListView( )
        {
            if( FilePaths?.Any( ) == true )
            {
                try
                {
                    foreach( var path in FilePaths )
                    {
                        FileList.Items.Add( path );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        public virtual void PopulateListView( IEnumerable<string> filePaths )
        {
            if( filePaths?.Any( ) == true )
            {
                try
                {
                    foreach( var path in filePaths )
                    {
                        FileList.Items.Add( path );
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
                    FileExtension = _checkBox.Tag?.ToString( ); 
                    FileDialog.Filter = FileExtension;
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
            if( sender is ListBox listBox 
                && !string.IsNullOrEmpty( listBox.SelectedItem?.ToString( ) )
                && e != null )
            {
                try
                {
                    SelectedPath = listBox.SelectedItem?.ToString(  );
                    MessageLabel.Text = SelectedPath;
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
