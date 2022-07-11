﻿// <copyright file = "ConnectionFactory.cs" company = "Terry D. Eppler">
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
    public class ConnectionFactory : ISource, IConnectionFactory
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the connection builder.
        /// </summary>
        /// <value>
        /// The connection builder.
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
        public ConnectionFactory()
        {
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref = "ConnectionFactory"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The manager.
        /// </param>
        public ConnectionFactory( IConnectionBuilder builder )
        {
            ConnectionBuilder = GetConnectionBuilder( builder );
            Connection = SetConnection( ConnectionBuilder );
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref = "ConnectionFactory"/> class.
        /// </summary>
        /// <param name = "builder" >
        /// The connectionBuilder.
        /// </param>
        /// <param name = "sqlStatement" >
        /// The sqlStatement.
        /// </param>
        public ConnectionFactory( IConnectionBuilder builder, ISqlStatement sqlStatement )
        {
            ConnectionBuilder = GetConnectionBuilder( builder );
            Connection = SetConnection( ConnectionBuilder );
        }

        /// <summary>
        /// Sets the connection manager.
        /// </summary>
        /// <param name = "builder" >
        /// The manager.
        /// </param>
        /// <returns>
        /// </returns>
        private IConnectionBuilder GetConnectionBuilder( IConnectionBuilder builder )
        {
            try
            {
                return Verify.IsRef( builder )
                    ? builder
                    : default( IConnectionBuilder );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IConnectionBuilder );
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Gets the connection manager.
        /// </summary>
        /// <returns>
        /// </returns>
        public IConnectionBuilder GetConnectionBuilder()
        {
            try
            {
                return Verify.IsRef( ConnectionBuilder )
                    ? ConnectionBuilder
                    : default( IConnectionBuilder );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IConnectionBuilder );
            }
        }

        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns>
        /// </returns>
        private DbConnection SetConnection( IConnectionBuilder connectionBuilder )
        {
            if( Verify.IsRef( connectionBuilder ) )
            {
                try
                {
                    var _provider = connectionBuilder.Provider;

                    if( Validate.IsProvider( _provider ) )
                    {
                        switch( _provider )
                        {
                            case Provider.SQLite:
                            {
                                var _connectionString =
                                    ConfigurationManager.ConnectionStrings[ $"{Provider.SQLite}" ]?.ConnectionString;

                                return Verify.IsInput( _connectionString )
                                    ? new SQLiteConnection( _connectionString )
                                    : default( DbConnection );
                            }

                            case Provider.SqlCe:
                            {
                                var _connectionString =
                                    ConfigurationManager.ConnectionStrings[ $"{Provider.SqlCe}" ]?.ConnectionString;

                                return Verify.IsInput( _connectionString )
                                    ? new SqlCeConnection( _connectionString )
                                    : default( DbConnection );
                            }

                            case Provider.SqlServer:
                            {
                                var _connectionString =
                                    ConfigurationManager.ConnectionStrings[ $"{Provider.SqlServer}" ]?.ConnectionString;

                                return Verify.IsInput( _connectionString )
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

                                return Verify.IsInput( _connectionString )
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

        /// <inheritdoc/>
        /// <summary>
        /// Gets the connection.
        /// </summary>
        /// <returns>
        /// </returns>
        public DbConnection GetConnection()
        {
            try
            {
                return Verify.IsRef( Connection )
                    ? Connection
                    : default( DbConnection );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DbConnection );
            }
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

                return Verify.IsInput( _connectionString )
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
        /// Gets the provider.
        /// </summary>
        /// <returns>
        /// </returns>
        public Provider GetProvider()
        {
            try
            {
                var _provider = ConnectionBuilder.Provider;

                return Validate.IsProvider( _provider )
                    ? _provider
                    : Provider.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Provider.NS;
            }
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        public Source GetSource()
        {
            try
            {
                var _source = ConnectionBuilder.Source;

                return Validate.IsSource( _source )
                    ? _source
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Source.NS;
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
