// <copyright file = "BudgetFile.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Security.AccessControl;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;
    using Microsoft.EntityFrameworkCore.Internal;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class DataFile : FileBase
    {
        /// <summary>
        /// The path
        /// </summary>
        public  override string Input { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public  override string Name { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public  override string FullName { get; set; }

        /// <summary>
        /// Gets or sets the changed date.
        /// </summary>
        /// <value>
        /// The changed date.
        /// </value>
        public  override DateTime Modified { get; set; }

        /// <summary>
        /// Gets the information.
        /// </summary>
        /// <value>
        /// The information.
        /// </value>
        public  override FileInfo FileInfo { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public  override string Extension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has parent.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has parent { get; set; } otherwise, <c>false</c>.
        /// </value>
        public  override bool HasParent { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.p/// </value>
        public  override DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the lengeth.
        /// </summary>
        /// <value>
        /// The lengeth.
        /// </value>
        public  override long Length { get; set; }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public  override FileAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets the security.
        /// </summary>
        /// <value>
        /// The security.
        /// </value>
        public  override FileSecurity FileSecurity { get; set; }

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

        /// <summary>
        /// Initializes a new instance of the <see cref="DataFile"/> class.
        /// </summary>
        public DataFile( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataFile"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public DataFile( string input ) 
            : base( input )
        {
        }

        /// <summary>
        /// Creates this instance.
        /// </summary>
        /// <returns></returns>
        public FileInfo Create( )
        {
            if ( !string.IsNullOrEmpty( Input ) )
            {
                try
                {
                    var _file = new FileInfo( Input );

                    return  _file.Exists
                        ? _file
                        : default( FileInfo );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( FileInfo );
                }
            }

            return default( FileInfo );
        }

        /// <summary>
        /// Creates the specified file path.
        /// </summary>
        /// <param name="filePath">
        /// The file path.
        /// </param>
        /// <returns> FileInfo </returns>
        public static FileInfo Create( string filePath )
        {
            try
            {
                return File.Exists( filePath )
                    ? new FileInfo( filePath )
                    : default( FileInfo );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( FileInfo );
            }
        }

        /// <summary>
        /// Transfers the specified folder.
        /// </summary>
        /// <param name="folder">The folder.</param>
        public static void Transfer( DirectoryInfo folder )
        {
            // Check if the target directory exists, if not, create it.
            if( !Directory.Exists( folder.FullName ) )
            {
                Directory.CreateDirectory( folder.FullName );
            }

            try
            {
                foreach( var _fileInfo in folder?.GetFiles() )
                {
                    Directory.Move( _fileInfo.FullName, folder.Name );
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Determines whether this instance contains the object.
        /// </summary>
        /// <param name="search">The search.</param>
        /// <returns>
        ///   <c>true</c> if [contains] [the specified search]; otherwise, <c>false</c>.
        /// </returns>
        public bool Contains( string search )
        {
            try
            {
                if( !string.IsNullOrEmpty( search )
                   && File.Exists( search ) )
                {
                    using( var _stream = File.Open( search, FileMode.Open ) )
                    {
                        using( var _reader = new StreamReader( _stream ) )
                        {
                            var _text = _reader?.ReadLine();
                            var _result = false;

                            while( _text == string.Empty )
                            {
                                if( Regex.IsMatch( _text, search ) )
                                {
                                    _result = true;
                                    break;
                                }

                                _text = _reader.ReadLine();
                            }

                            return _result;
                        }
                    }
                }

                return false;
            }
            catch( IOException ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Searches the specified pattern.
        /// </summary>
        /// <param name="pattern">The pattern.</param>
        /// <returns></returns>
        public IEnumerable<FileInfo> Search( string pattern )
        {
            if( !string.IsNullOrEmpty( pattern ) )
            {
                try
                {
                    var _input = Path.GetFullPath( Input ) ;

                    if( !string.IsNullOrEmpty( _input )
                        && File.Exists( _input ) )
                    {
                        var _files = 
                            Directory.EnumerateFiles( _input, pattern, SearchOption.AllDirectories );
                        var _list = new List<FileInfo>();

                        foreach( var file in _files )
                        {
                            _list.Add( new FileInfo( file ) );
                        }

                        return _list?.Any( ) == true
                            ? _list
                            : default( List<FileInfo> );
                    }
                }
                catch( IOException ex )
                {
                    Fail( ex );
                    return default( IEnumerable<FileInfo> );
                }
            }

            return default( IEnumerable<FileInfo> );
        }

        /// <summary>Returns a string that
        /// represents the current object.
        /// </summary>
        /// <returns>A string that represents
        /// the current object.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( FullName )
                    ? FullName
                    : string.Empty;
            }
            catch( IOException ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Gets the name.
        /// </summary>
        /// <returns></returns>
        public string GetFullName()
        {
            try
            {
                return !string.IsNullOrEmpty( FullName )
                    ? FullName
                    : default( string );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }
        

        /// <summary>
        /// Gets the extension.
        /// </summary>
        /// <returns></returns>
        public string GetFileExtension()
        {
            try
            {
                var _extension = Path.GetExtension( Input );

                return !string.IsNullOrEmpty( _extension )
                    ? _extension
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the full path.
        /// </summary>
        /// <returns></returns>
        public string GetFilePath()
        {
            try
            {
                var _input = Path.GetFullPath( Input );

                return !string.IsNullOrEmpty( _input )
                    ? _input
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <returns></returns>
        public string GetParentFolder( )
        {
            try
            {
                return CheckParent( )
                    ? Directory.GetParent( Input )?.FullName 
                    : string.Empty;
            }
            catch( IOException ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Browses this instance.
        /// </summary>
        /// <returns></returns>
        public static string Browse( )
        {
            try
            {
                var _dialog = new OpenFileDialog
                {
                    CheckFileExists = true,
                    CheckPathExists = true
                };

                return _dialog.FileName;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }
    }
}
