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
        public IEnumerable<string> FilePaths { get; set; }

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
            if( FilePaths?.Any( ) == true  ) 
            {
                try
                {
                    PopulateListView( );
                    FoundLabel.Text = "Found : " + FilePaths?.Count( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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
                try
                {
                    var _path = ConfigurationManager.AppSettings[ "Extensions" ];
                    var _files = Directory.GetFiles( _path );

                    if ( _files?.Any( ) == true )
                    {
                        var _file = _files
                            .Where( f => f.Contains( FileExtension ) )
                            ?.Single( );

                        using( var stream = File.Open( _file, FileMode.Open ) )
                        {
                            var _img = Image.FromStream( stream );
                            return new Bitmap(  _img, 22, 22 );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Bitmap );
                }
            }

            return default( Bitmap );
        }

        /// <summary>
        /// Clears the check boxes.
        /// </summary>
        public void ResetCheckBoxes( )
        {
            try
            {
                foreach( var box in CheckBoxes )
                {
                    box.CheckState = CheckState.Unchecked;
                    box.CheckStateChanged += OnCheckBoxSelected;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the ListView file paths.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetListViewPaths( )
        {
            if( InitialDirPaths?.Any( ) == true )
            {
                try
                {
                    var _list = new List<string>( );
                    foreach( var path in InitialDirPaths )
                    {
                        var _first = Directory.EnumerateFiles( path )
                            ?.Where( f => f.EndsWith( FileExtension ) )
                            ?.Select( f => Path.GetFullPath( f ) )
                            ?.ToList( );

                        _list.AddRange( _first );

                        var _dirs = Directory.GetDirectories( path );
                        foreach( var dir in _dirs )
                        {
                            if( !dir.Contains( "My " ) )
                            {
                                var _second = Directory.EnumerateFiles( dir )
                                   ?.Where( s => s.EndsWith( FileExtension ) )
                                   ?.Select( s => Path.GetFullPath( s ) )
                                   ?.ToList( );

                                _list.AddRange( _second );

                                var _subdir = Directory.GetDirectories( dir );
                                foreach( var sub in _subdir )
                                {
                                    var _last = Directory.EnumerateFiles( sub )
                                        ?.Where( l => l.EndsWith( FileExtension ) )
                                        ?.Select( l => Path.GetFullPath( l ) )
                                        ?.ToList( );

                                    _list.AddRange( _last );
                                }

                            }
                            
                        }

                    }

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

            return default( IEnumerable<string> );
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
                    FileList.Items.Clear( );
                    FileExtension = _checkBox?.Tag?.ToString( );
                    MessageLabel.Text = string.Empty;
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

        /// <summary>
        /// Populates the ListView.
        /// </summary>
        /// <param name="filePaths">The file paths.</param>
        public virtual void PopulateListView( IEnumerable<string> filePaths )
        {
            try
            {
                if( filePaths?.Any(  ) == true )
                {
                    foreach( var path in filePaths )
                    {
                        if( !string.IsNullOrEmpty( path ) )
                        {
                            FileList?.Items.Add( path );
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
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
