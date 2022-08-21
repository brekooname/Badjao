// // <copyright file = "ConnectionBuilder.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SqlServerCe;
    using System.Data.SQLite;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ConnectionBase" />
    /// <seealso cref="ISource" />
    /// <seealso cref="IProvider" />
    /// <seealso cref="IConnectionBuilder" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" )]
    [SuppressMessage( "ReSharper", "InconsistentNaming" )]
    [SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" )]
    public class ConnectionBuilder : ConnectionBase, ISource, IProvider, IConnectionBuilder
    {
        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public DbConnection Connection { get; set; }

        /// <summary>
        /// The provider path
        /// </summary>
        public string ProviderPath { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ConnectionBuilder" />
        /// class.
        /// </summary>
        public ConnectionBuilder()
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
            FilePath = GetClientPath( provider );
            PathExtension = Path.GetExtension( FilePath )?.Replace( ".", "" );
            FileName = Path.GetFileNameWithoutExtension( FilePath );
            Extension = (EXT)Enum.Parse( typeof( EXT ), PathExtension?.ToUpper( ) );
            TableName = source.ToString( );
            ProviderPath = ConfigurationManager.AppSettings[ Extension.ToString( ) ];
            ConnectionString = GetConnectionString( provider );
            Connection = GetConnection( );
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
            Extension = (EXT)Enum.Parse( typeof( EXT ), PathExtension?.ToUpper( ) );
            Provider = (Provider)Enum.Parse( typeof( Provider ), PathExtension?.ToUpper( ) );
            ProviderPath = ConfigurationManager.AppSettings[ Extension.ToString( ) ];
            TableName = FileName;
            ConnectionString = GetConnectionString( Provider );
            Connection = GetConnection( );
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
            Extension = (EXT)Enum.Parse( typeof( EXT ), PathExtension?.ToUpper( ) );
            ProviderPath = ConfigurationManager.AppSettings[ Extension.ToString( ) ];
            TableName = FileName;
            ConnectionString = GetConnectionString( provider );
            Connection = GetConnection( );
        }


        private DbConnection GetConnection(  )
        {
            if( Enum.IsDefined( typeof( Provider ), Provider ) )
            {
                try
                {
                    switch( Provider )
                    {
                        case Provider.SQLite:

                        {
                            var _connectionString = ConnectionPath[ $"{ Provider.SQLite }" ]
                                ?.ConnectionString;

                            return !string.IsNullOrEmpty( _connectionString )
                                ? new SQLiteConnection( _connectionString )
                                : default( DbConnection );
                        }

                        case Provider.SqlCe:

                        {
                            var _connectionString = ConnectionPath[ $"{ Provider.SqlCe }" ]
                                ?.ConnectionString;

                            return !string.IsNullOrEmpty( _connectionString )
                                ? new SqlCeConnection( _connectionString )
                                : default( DbConnection );
                        }

                        case Provider.SqlServer:

                        {
                            var _connectionString = ConnectionPath[ $"{ Provider.SqlServer }" ]
                                ?.ConnectionString;

                            return !string.IsNullOrEmpty( _connectionString )
                                ? new SqlConnection( _connectionString )
                                : default( DbConnection );
                        }

                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:

                        {
                            var _connectionString = ConnectionPath[ $"{ Provider.OleDb }" ]
                                ?.ConnectionString;

                            return !string.IsNullOrEmpty( _connectionString )
                                ? new OleDbConnection( _connectionString )
                                : default( DbConnection );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbConnection );
                }
            }

            return default( DbConnection );
        }
    }
}