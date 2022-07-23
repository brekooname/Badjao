// <copyright file = "BudgetFile.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Text.RegularExpressions;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="PathBase" />
    [ SuppressMessage( "ReSharper", "UseObjectOrCollectionInitializer" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class FilePath : PathBase, IFilePath
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="FilePath"/> class.
        /// </summary>
        public FilePath()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FilePath"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        public FilePath( string input )
        {
            Input = input;
            FileInfo = new FileInfo( input );
            FullName = FileInfo.FullName;
            HasParent = CheckParent();
            Length = FileInfo.Length;
            Attributes = FileInfo.Attributes;
            FileSecurity = FileInfo.GetAccessControl();
            CreationDate = FileInfo.CreationTime;
            ChangeDate = FileInfo.LastWriteTime;
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
                        var _enumerable = Directory.EnumerateFiles( _input, pattern );
                        var _list = new List<FileInfo>();

                        foreach( var file in _enumerable )
                        {
                            _list.Add( new FileInfo( file ) );
                        }

                        return Verify.IsSequence( _list )
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
        public override string ToString()
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
