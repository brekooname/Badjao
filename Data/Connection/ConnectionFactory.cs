// <copyright file = "ConnectionFactory.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;

    /// <inheritdoc/>
    /// <summary>
    /// </summary>
    /// <seealso cref = "T:BudgetExecution.ISource"/>
    /// <seealso cref = "T:BudgetExecution.IProvider"/>
    /// <seealso/>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Local" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class ConnectionFactory : ISource, IProvider, IConnectionFactory
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the connection connectionBuilder.
        /// </summary>
        /// <value>
        /// The connection connectionBuilder.
        /// </value>
        public IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public DbConnection Connection { get; set; }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref = "ConnectionFactory"/> class.
        /// </summary>
        public ConnectionFactory( )
        {
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref = "ConnectionFactory"/> class.
        /// </summary>
        /// <param name = "connectionBuilder" >
        /// The manager.
        /// </param>
        public ConnectionFactory( IConnectionBuilder connectionBuilder )
        {
            ConnectionBuilder = connectionBuilder;
            Connection = SetConnection( connectionBuilder );
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref = "ConnectionFactory"/> class.
        /// </summary>
        /// <param name = "connectionBuilder" >
        /// The connectionBuilder.
        /// </param>
        /// <param name = "sqlStatement" >
        /// The sqlStatement.
        /// </param>
        public ConnectionFactory( IConnectionBuilder connectionBuilder, ISqlStatement sqlStatement )
        {
            ConnectionBuilder = connectionBuilder;
            Connection = SetConnection( ConnectionBuilder );
        }
        

        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns>
        /// </returns>
        private DbConnection SetConnection( IConnectionBuilder connectionBuilder )
        {
            if( connectionBuilder != null )
            {
                try
                {
                    var _provider = connectionBuilder.Provider;

                    if( Enum.IsDefined( typeof( Provider ), _provider ) )
                    {
                        switch( _provider )
                        {
                            case Provider.SQLite:
                            {
                                var _connectionString =
                                    ConfigurationManager.ConnectionStrings[ $"{Provider.SQLite}" ]?.ConnectionString;

                                return !string.IsNullOrEmpty( _connectionString )
                                    ? new SQLiteConnection( _connectionString )
                                    : default( DbConnection );
                            }

                            case Provider.SqlCe:
                            {
                                var _connectionString =
                                    ConfigurationManager.ConnectionStrings[ $"{Provider.SqlCe}" ]?.ConnectionString;

                                return !string.IsNullOrEmpty( _connectionString )
                                    ? new SqlCeConnection( _connectionString )
                                    : default( DbConnection );
                            }

                            case Provider.SqlServer:
                            {
                                var _connectionString =
                                    ConfigurationManager.ConnectionStrings[ $"{Provider.SqlServer}" ]?.ConnectionString;

                                return !string.IsNullOrEmpty( _connectionString )
                                    ? new SqlConnection( _connectionString )
                                    : default( DbConnection );
                            }

                            case Provider.Excel:
                            case Provider.CSV:
                            case Provider.Access:
                            case Provider.OleDb:
                            {
                                var _connectionString =
                                    ConfigurationManager.ConnectionStrings[ $"{Provider.OleDb}" ]?.ConnectionString;

                                return !string.IsNullOrEmpty( _connectionString )
                                    ? new OleDbConnection( _connectionString )
                                    : default( DbConnection );
                            }
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

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref = "string"/> that represents this instance.
        /// </returns>
        public override string ToString()
        {
            try
            {
                var _connectionString = ConnectionBuilder?.ConnectionString;

                return !string.IsNullOrEmpty( _connectionString )
                    ? _connectionString
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }
        
        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}
