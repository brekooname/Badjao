// // <copyright file = "ConnectionBuilder.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ConnectionBase" />
    /// <seealso cref="ISource" />
    /// <seealso cref="IProvider" />
    /// <seealso cref="IConnectionBuilder" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" ) ]
    [ SuppressMessage( "ReSharper", "InconsistentNaming" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class ConnectionBuilder : ConnectionBase, ISource, IProvider, IConnectionBuilder
    {
        /// <summary>
        /// The provider path
        /// </summary>
        public string ProviderPath { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        public ConnectionBuilder( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public ConnectionBuilder( Source source, Provider provider = Provider.SQLite )
        {
            Source = source;
            Provider = provider;
            FilePath = GetFilePath( provider );
            PathExtension = Path.GetExtension( FilePath )?.Replace( ".", "" );
            FileName = Path.GetFileNameWithoutExtension( FilePath );
            FileExtension = (EXT)Enum.Parse( typeof( EXT ), PathExtension?.ToUpper( ) );
            TableName = source.ToString( );
            ProviderPath = ConfigurationManager.AppSettings[ FileExtension.ToString( ) ];
            ConnectionString = GetConnectionString( provider );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        /// <param name="fullPath">The fullPath.</param>
        public ConnectionBuilder( string fullPath )
        {
            Source = Source.External;
            FilePath = fullPath;
            FileName = Path.GetFileNameWithoutExtension( fullPath );
            PathExtension = Path.GetExtension( fullPath )?.Replace( ".", "" );
            FileExtension = (EXT)Enum.Parse( typeof( EXT ), PathExtension?.ToUpper( ) );
            Provider = (Provider)Enum.Parse( typeof( Provider ), GetProviderPath( fullPath ) );
            ProviderPath = ConfigurationManager.AppSettings[ FileExtension.ToString( ) ];
            TableName = FileName;
            ConnectionString = GetConnectionString( Provider );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        /// <param name="fullPath">The fullPath.</param>
        /// <param name="provider">The provider.</param>
        public ConnectionBuilder( string fullPath, Provider provider = Provider.SQLite )
        {
            Source = Source.External;
            Provider = provider;
            FilePath = fullPath;
            FileName = Path.GetFileNameWithoutExtension( fullPath );
            PathExtension = Path.GetExtension( fullPath )?.Replace( ".", "" );
            FileExtension = (EXT)Enum.Parse( typeof( EXT ), PathExtension?.ToUpper( ) );
            ProviderPath = ConfigurationManager.AppSettings[ FileExtension.ToString( ) ];
            TableName = Source.ToString( );
            ConnectionString = GetConnectionString( provider );
        }
    }
}