﻿// <copyright file = "FolderBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Security.AccessControl;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public abstract class FolderBase
    {
        /// <summary>
        /// Gets or sets the buffer.
        /// </summary>
        /// <value>
        /// The buffer.
        /// </value>
        public virtual string Buffer { get; set; }

        /// <summary>
        /// The base stream
        /// </summary>
        public virtual DirectoryInfo DirectoryInfo { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        public virtual string Name { get; set; }

        /// <summary>
        /// Gets or sets the full name.
        /// </summary>
        /// <value>
        /// The full name.
        /// </value>
        public virtual string FullName { get; set; }

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
        /// Gets or sets a value indicating whether this instance has sub files.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has sub files; otherwise, <c>false</c>.
        /// </value>
        public virtual bool HasSubFiles { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance has sub folders.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance has sub folders; otherwise, <c>false</c>.
        /// </value>
        public virtual bool HasSubFolders { get; set; }

        /// <summary>
        /// Gets or sets the security.
        /// </summary>
        /// <value>
        /// The security.
        /// </value>
        public virtual FileSecurity FileSecurity { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderBase"/> class.
        /// </summary>
        protected FolderBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="FolderBase"/> class.
        /// </summary>
        /// <param name="input">The input.</param>
        protected FolderBase( string input )
        {
            Buffer = input;
            FullPath = System.IO.Path.GetFullPath( input );
            DirectoryInfo = new DirectoryInfo( FullPath );
            Name = System.IO.Path.GetDirectoryName( input );
            FullName = DirectoryInfo.FullName;
            Created = DirectoryInfo.CreationTime;
            Modified = DirectoryInfo.LastWriteTime;
            HasParent = DirectoryInfo.Parent != null;
            HasSubFiles = Directory.GetFiles( input ).Length > 0;
            HasSubFolders = Directory.GetDirectories( input ).Length > 0;
        }

        /// <summary>
        /// Gets the parent.
        /// </summary>
        /// <returns></returns>
        protected virtual DirectoryInfo GetBaseDirectory( )
        {
            try
            {
                if( !string.IsNullOrEmpty( Buffer ) 
                    && Directory.Exists( Buffer ))
                {
                    DirectoryInfo _file = new DirectoryInfo( Buffer );
                    return _file?.Parent;
                }

                return default( DirectoryInfo );
            }
            catch( IOException ex )
            {
                Fail( ex );
                return default( DirectoryInfo );
            }
        }
        
        /// <summary>
        /// Gets the files.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetFileNames( )
        {
            if( HasSubFiles )
            {
                try
                {
                    string[ ] _files = Directory.GetFiles( FullPath );
                    return _files?.Any( ) == true
                        ? _files
                        : default( IEnumerable<string> );
                }
                catch( IOException ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }

        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<FileInfo> GetStreamData( )
        {
            if( !string.IsNullOrEmpty( FullPath ) )
            {
                try
                {
                    IEnumerable<FileInfo> _enumerable = DirectoryInfo?.EnumerateFiles( FullPath );

                    return  _enumerable?.Any( ) == true
                        ? _enumerable
                        : default( IEnumerable<FileInfo> );
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
        /// Gets the special folders.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<string> GetSpecialFolders( )
        {
            try
            {
                string[ ] _folders = Enum.GetNames( typeof( Environment.SpecialFolder ) );

                return _folders?.Any( ) == true
                    ? _folders
                    : default( string[ ] );
            }
            catch( IOException ex )
            {
                Fail( ex );
                return default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Gets the sub folders.
        /// </summary>
        /// <returns></returns>
        public virtual IEnumerable<DirectoryInfo> GetSubFolders( )
        {
            if( DirectoryInfo != null )
            {
                try
                {
                    DirectoryInfo[ ] _folders = DirectoryInfo?.GetDirectories( );

                    return _folders?.Any( ) != true
                        ? _folders
                        : default( DirectoryInfo[ ] );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DirectoryInfo> );
                }
            }

            return default( IEnumerable<DirectoryInfo> );
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