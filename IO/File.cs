// <copyright file = "FilePath.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PathBase" />
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class File : FileBase, IFile
    {
        /// <summary>
        /// Gets the dir sep.
        /// </summary>
        /// <value>
        /// The dir sep.
        /// </value>
        public char DirSep { get; } = System.IO.Path.DirectorySeparatorChar;

        /// <summary>
        /// Gets the path sep.
        /// </summary>
        /// <value>
        /// The path sep.
        /// </value>
        public char PathSep { get; } = System.IO.Path.PathSeparator;

        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class.
        /// </summary>
        public File( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="File"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public File( string input )
        {
            Buffer = input;
            FileInfo = new FileInfo( input );
            FullPath = FileInfo.FullName;
            HasParent = CheckParent( );
            Length = FileInfo.Length;
            Attributes = FileInfo.Attributes;
            FileSecurity = FileInfo.GetAccessControl( );
            Created = FileInfo.CreationTime;
            Modified = FileInfo.LastWriteTime;
            Extension = FileInfo.Extension;
        }

        /// <summary>
        /// Creates the specified file path.
        /// </summary>
        /// <param name="filePath">
        /// The file path.
        /// </param>
        /// <returns></returns>
        public static FileInfo Create( string filePath )
        {
            try
            {
                return !string.IsNullOrEmpty( filePath ) 
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
        public void Transfer( DirectoryInfo folder )
        {
            if( folder != null &&
                !Directory.Exists( folder.FullName ) )
            {
                Directory.CreateDirectory( folder.FullName );
            }

            try
            {
                FileInfo[ ] _files = folder?.GetFiles( );

                if( _files?.Any( ) == true )
                {
                    foreach( FileInfo _fileInfo in _files )
                    {
                        Directory.Move( _fileInfo.FullName, folder.Name );
                    }
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
                    && System.IO.File.Exists( search ) )
                {
                    using( FileStream _stream = System.IO.File.Open( search, FileMode.Open ) )
                    {
                        using( StreamReader _reader = new StreamReader( _stream ) )
                        {
                            if( _reader != null )
                            {
                                string _text = _reader?.ReadLine( );
                                bool _result = false;

                                while( _text == string.Empty )
                                {
                                    if( Regex.IsMatch( _text, search ) )
                                    {
                                        _result = true;
                                        break;
                                    }

                                    _text = _reader.ReadLine( );
                                }

                                return _result;
                            }
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
                    string _input = System.IO.Path.GetFullPath( Buffer );

                    if( !string.IsNullOrEmpty( _input )
                        && System.IO.File.Exists( _input ) )
                    {
                        IEnumerable<string> _enumerable =
                            Directory.EnumerateFiles( _input, pattern );

                        List<FileInfo> _list = new List<FileInfo>( );

                        foreach( string file in _enumerable )
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
        
        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <returns></returns>
        public string GetParentDirectory( )
        {
            if( !string.IsNullOrEmpty( Buffer ) )
            {
                try
                {
                    return CheckParent( )
                        ? Directory.GetParent( Buffer )?.FullName
                        : string.Empty;
                }
                catch( IOException ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Browses this instance.
        /// </summary>
        /// <returns></returns>
        public static string Browse( )
        {
            try
            {
                OpenFileDialog _dialog = new OpenFileDialog
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
                return !string.IsNullOrEmpty( Name )
                    ? Name
                    : string.Empty;
            }
            catch( IOException ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }
    }
}