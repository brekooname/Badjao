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
        public virtual ConnectionStringSettingsCollection ConnectionPaths { get; } =
            ConfigurationManager.ConnectionStrings;

        public virtual NameValueCollection ClientPaths { get; } = ConfigurationManager.AppSettings;
        /// <summary>
        /// The source
        /// </summary>
        public virtual Source Source { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        public virtual Provider Provider { get; set; }

        /// <summary>
        /// The file extension
        /// </summary>
        public virtual EXT Extension { get; set; }

        /// <summary>
        /// Gets or sets the path extension.
        /// </summary>
        /// <value>
        /// The path extension.
        /// </value>
        public virtual string PathExtension { get; set; }

        /// <summary>
        /// The file path
        /// </summary>
        public virtual string FilePath { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        public virtual string FileName { get; set; }

        /// <summary>
        /// The table name
        /// </summary>
        public virtual string TableName { get; set; }

        /// <summary>
        /// The connection string
        /// </summary>
        public virtual string ConnectionString { get; set; }

        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        public virtual string GetClientPath( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    switch( provider )
                    {
                        case Provider.Access:
                        {
                            return ClientPaths[ "ACCDB" ];
                        }
                        case Provider.SQLite:
                        {
                            return ClientPaths[ "DB" ];
                        }
                        case Provider.SqlCe:
                        {
                            return ClientPaths[ "SDF" ];
                        }
                        case Provider.Excel:
                        {
                            return ClientPaths[ "XLSX" ];
                        }
                        case Provider.SqlServer:
                        {
                            return ClientPaths[ "MDF" ];
                        }
                        case Provider.CSV:
                        {
                            return ClientPaths[ "CSV" ];
                        }
                        default:
                        {
                            return ClientPaths[ "ACCDB" ];
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
        public virtual string GetFilePath( string filePath )
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
        public virtual string GetClientPath( string filePath )
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
                            var _clientPath = ClientPaths[ $"{ _extension }" ];

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
        public virtual string GetConnectionString( Provider provider )
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
                            var _connection = ConnectionPaths[ provider.ToString( ) ]?.ConnectionString;

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
                                ConnectionPaths[ $"{ _extension }" ].ConnectionString;

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