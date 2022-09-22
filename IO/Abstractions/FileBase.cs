// <copyright file = "FileBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Security.AccessControl;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public abstract class FileBase
    {
        /// <summary>
        /// The path
        /// </summary>
        public virtual string Buffer { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public virtual string Name { get; set; }
        
        /// <summary>
        /// Gets or sets the full path.
        /// </summary>
        /// <value>
        /// The full path.
        /// </value>
        public virtual string FullPath { get; set; }

        /// <summary>
        /// Gets or sets the changed date.
        /// </summary>
        /// <value>
        /// The changed date.
        /// </value>
        public virtual DateTime Modified { get; set; }

        /// <summary>
        /// Gets the information.
        /// </summary>
        /// <value>
        /// The information.
        /// </value>
        public virtual FileInfo FileInfo { get; set; }

        /// <summary>
        /// Gets or sets the extension.
        /// </summary>
        /// <value>
        /// The extension.
        /// </value>
        public virtual string Extension { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has parent.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has parent { get; set; } otherwise, <c>false</c>.
        /// </value>
        public virtual bool HasParent { get; set; }

        /// <summary>
        /// Gets or sets the creation date.
        /// </summary>
        /// <value>
        /// The creation date.p/// </value>
        public virtual DateTime Created { get; set; }

        /// <summary>
        /// Gets or sets the lengeth.
        /// </summary>
        /// <value>
        /// The lengeth.
        /// </value>
        public virtual long Length { get; set; }

        /// <summary>
        /// Gets or sets the attributes.
        /// </summary>
        /// <value>
        /// The attributes.
        /// </value>
        public virtual FileAttributes Attributes { get; set; }

        /// <summary>
        /// Gets or sets the security.
        /// </summary>
        /// <value>
        /// The security.
        /// </value>
        public virtual FileSecurity FileSecurity { get; set; }

        /// <summary>
        /// Initializes a new instance 
        /// of the <see cref="PathBase"/> class.
        /// </summary>
        protected FileBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FileBase"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        protected FileBase( string input )
        {
            Buffer = input;
            FullPath = System.IO.Path.GetFullPath( input );
            FileInfo = new FileInfo( FullPath );
            Name = FileInfo.Name;
            FullPath = FileInfo.FullName;
            Extension = FileInfo.Extension;
            Length = FileInfo.Length;
            Attributes = FileInfo.Attributes;
            FileSecurity = FileInfo.GetAccessControl( );
            Created = FileInfo.CreationTime;
            Modified = FileInfo.LastWriteTime;
        }

        /// <summary>
        /// Moves the specified destination.
        /// </summary>
        /// <param name="filePath">The destination.</param>
        public virtual void Move( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath ) )
            {
                try
                {
                    FileInfo?.MoveTo( filePath );
                }
                catch( IOException ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Copies the specified filePath.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        public virtual void Copy( string filePath )
        {
            try
            {
                if( !string.IsNullOrEmpty( filePath )
                    && !System.IO.File.Exists( filePath ) )
                {
                    FileInfo.CopyTo( filePath );
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Deletes this instance.
        /// </summary>
        public virtual void Delete( )
        {
            try
            {
                if( !string.IsNullOrEmpty( Buffer ) )
                {
                    string _file = System.IO.Path.GetFullPath( Buffer );

                    if( !string.IsNullOrEmpty( _file )
                        && System.IO.File.Exists( _file ) )
                    {
                        System.IO.File.Delete( _file );
                    }
                }
            }
            catch( IOException ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Determines whether [has parent folder].
        /// </summary>
        /// <returns>
        ///   <c>true</c> if [has parent folder]; otherwise, <c>false</c>.
        /// </returns>
        protected bool CheckParent( )
        {
            try
            {
                return !string.IsNullOrEmpty( FileInfo?.DirectoryName )
                    && Directory.Exists( FileInfo?.DirectoryName );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Gets the file security.
        /// </summary>
        /// <returns></returns>
        public FileSecurity GetFileSecurity( )
        {
            try
            {
                return FileSecurity ?? default( FileSecurity );
            }
            catch( IOException ex )
            {
                Fail( ex );
                return default( FileSecurity );
            }
        }

        /// <summary>
        /// Gets the base stream.
        /// </summary>
        /// <returns></returns>
        public FileStream GetBaseStream( )
        {
            try
            {
                if( !string.IsNullOrEmpty( Buffer ) )
                {
                    string _path = System.IO.Path.GetFullPath( Buffer );

                    return !string.IsNullOrEmpty( _path ) && System.IO.File.Exists( _path )
                        ? new FileInfo( _path )?.Create( )
                        : default( FileStream );
                }

                return default( FileStream );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( FileStream );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using( Error _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}