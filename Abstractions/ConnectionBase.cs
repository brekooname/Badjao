// // <copyright file = "ConnectionBase.cs" company = "Terry D. Eppler">
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
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ConnectionBase
    {
        /// <summary>
        /// The connector
        /// </summary>
        public virtual ConnectionStringSettingsCollection Connectors { get; } =
            ConfigurationManager.ConnectionStrings;

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
        public virtual EXT FileExtension { get; set; }

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
        /// Sets the file path.
        /// </summary>
        /// <param name="provider">The provider.</param>
        public virtual string GetFilePath( Provider provider )
        {
            if( Validate.IsProvider( provider ) )
            {
                try
                {
                    switch( provider )
                    {
                        case Provider.OleDb:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "OleDb" ];
                            break;
                        }
                        case Provider.Access:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "Access" ];
                            break;
                        }
                        case Provider.SQLite:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "SQLite" ];
                            break;
                        }
                        case Provider.SqlCe:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "SqlCe" ];
                            break;
                        }
                        case Provider.Excel:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "Excel" ];
                            break;
                        }
                        case Provider.SqlServer:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "SqlServer" ];
                            break;
                        }
                        case Provider.CSV:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "CSV" ];
                            break;
                        }
                        default:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "SQLite" ];
                            break;
                        }
                    }

                    return !string.IsNullOrEmpty( FilePath )
                        ? FilePath
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
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
        protected string GetProviderPath( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath )
               && File.Exists( filePath )
               && Path.HasExtension( filePath ) )
            {
                try
                {
                    var _extension = Path.GetExtension( filePath );

                    if( _extension != null )
                    {
                        var _provider = (EXT)Enum.Parse( typeof( EXT ), _extension );

                        switch( _provider )
                        {
                            case EXT.MDB:
                            {
                                var _path = ConfigurationManager.AppSettings[ "OleDbFilePath" ];
                                return _path?.Replace( "{FilePath}", filePath );
                            }
                            case EXT.ACCDB:

                            {
                                var _path = ConfigurationManager.AppSettings[ "Access" ];
                                return _path;
                            }
                            case EXT.DB:
                            {
                                var _path = ConfigurationManager.AppSettings[ "SQLite" ];
                                return _path?.Replace( "{FilePath}", filePath );
                            }
                            case EXT.XLSX:
                            {
                                var _path = ConfigurationManager.AppSettings[ "Excel" ];
                                return _path?.Replace( "{FilePath}", filePath );
                            }
                            case EXT.CSV:
                            {
                                var _path = ConfigurationManager.AppSettings[ "CSV" ];
                                return _path?.Replace( "{FilePath}", filePath );
                            }
                            case EXT.MDF:
                            {
                                var _path = ConfigurationManager.AppSettings[ "SqlServer" ];
                                return _path?.Replace( "{FilePath}", filePath );
                            }
                            case EXT.SDF:
                            {
                                var _path = ConfigurationManager.AppSettings[ "SqlCe" ];
                                return _path?.Replace( "{FilePath}", filePath );
                            }
                            case EXT.TXT:
                            {
                                var _path = ConfigurationManager.AppSettings[ "CSV" ];
                                return _path?.Replace( "{FilePath}", filePath );
                            }
                            default:
                            {
                                var _path = ConfigurationManager.AppSettings[ "SQLite" ];
                                return _path?.Replace( "{FilePath}", filePath );
                            }
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
                            var _connection = Connectors[ provider.ToString( ) ]?.ConnectionString;

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