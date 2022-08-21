// // <copyright file = "ConnectionBase.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ConnectionBase 
    {
        /// <summary>
        /// The connector
        /// </summary>
        public ConnectionStringSettingsCollection ConnectionPath { get; } =
            ConfigurationManager.ConnectionStrings;

        /// <summary>
        /// Gets the client path.
        /// </summary>
        /// <value>
        /// The client path.
        /// </value>
        public NameValueCollection DbClientPath { get; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// The file extension
        /// </summary>
        public EXT Extension { get; set; }

        /// <summary>
        /// Gets or sets the path extension.
        /// </summary>
        /// <value>
        /// The path extension.
        /// </value>
        public string PathExtension { get; set; }

        /// <summary>
        /// The file path
        /// </summary>
        public string FilePath { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// The table name
        /// </summary>
        public string TableName { get; set; }

        /// <summary>
        /// The connection string
        /// </summary>
        public string ConnectionString { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ConnectionBase"/> class.
        /// </summary>
        protected ConnectionBase( )
        {
        }

        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        public string GetClientPath( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    switch( provider )
                    {
                        case Provider.Access:
                        {
                            return DbClientPath[ "ACCDB" ];
                        }
                        case Provider.SQLite:
                        {
                            return DbClientPath[ "DB" ];
                        }
                        case Provider.SqlCe:
                        {
                            return DbClientPath[ "SDF" ];
                        }
                        case Provider.Excel:
                        {
                            return DbClientPath[ "XLSX" ];
                        }
                        case Provider.SqlServer:
                        {
                            return DbClientPath[ "MDF" ];
                        }
                        case Provider.CSV:
                        {
                            return DbClientPath[ "CSV" ];
                        }
                        default:
                        {
                            return DbClientPath[ "ACCDB" ];
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the file path.
        /// </summary>
        /// <param name="filePath">The filePath.</param>
        public string GetFilePath( string filePath )
        {
            try
            {
                return !string.IsNullOrEmpty( filePath ) && File.Exists( filePath )
                    ? Path.GetFullPath( filePath )
                    : default( string );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Sets the provider path.
        /// </summary>
        /// <param name="filePath">The file path.</param>
        public string GetClientPath( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath )
               && Path.HasExtension( filePath ) )
            {
                try
                {
                    var _file = Path.GetExtension( filePath )?.Replace( ".", "" );

                    if( _file != null )
                    {
                        var _extension = (EXT)Enum.Parse( typeof( EXT ), _file.ToUpper(  ) );
                        var _names = Enum.GetNames( typeof( EXT ) );
                        if( _names.Contains( _extension.ToString(    ) ) )
                        {
                            var _clientPath = DbClientPath[ $"{ _extension }" ];

                            return !string.IsNullOrEmpty( _clientPath )
                                ? _clientPath
                                : string.Empty;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the connection string.
        /// </summary>
        /// <param name="provider">The provider.</param>
        public string GetConnectionString( Provider provider )
        {
            if( Validate.IsProvider( provider ) )
            {
                try
                {
                    switch( provider )
                    {
                        case Provider.SQLite:
                        case Provider.Access:
                        case Provider.SqlCe:
                        case Provider.SqlServer:
                        case Provider.OleDb:
                        case Provider.Excel:
                        case Provider.CSV:
                        {
                            var _connection = ConnectionPath[ provider.ToString( ) ]?.ConnectionString;

                            return !string.IsNullOrEmpty( _connection )
                                ? _connection?.Replace( "{FilePath}", FilePath )
                                : string.Empty;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        protected string GetConnectionString( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath )
               && Path.HasExtension( filePath ) )
            {
                try
                {
                    var _file = Path.GetExtension( filePath );

                    if( _file != null )
                    {
                        var _extension = (EXT)Enum.Parse( typeof( EXT ), _file.ToUpper(  ) );
                        var _names = Enum.GetNames( typeof( EXT ) );

                        if ( _names?.Contains( _extension.ToString(  ) ) == true )
                        {
                            var _connectionString =
                                ConnectionPath[ $"{ _extension }" ].ConnectionString;

                            return !string.IsNullOrEmpty( _connectionString )
                                ? _connectionString
                                : string.Empty;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}