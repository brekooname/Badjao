﻿// <copyright file = "CommandBuilder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IDataCommand" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class CommandBuilder : IDataCommand
    {
        /// <summary>
        /// The command
        /// </summary>
        public DbCommand Command { get; set; }

        /// <summary>
        /// The connection builder
        /// </summary>
        public IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The SQL statement
        /// </summary>
        public ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        public CommandBuilder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="dict">The dictionary.</param>
        public CommandBuilder( Source source, Provider provider, IDictionary<string, object> dict )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, dict );
            Command = GetCommand( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandBuilder"/> class.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        public CommandBuilder( ISqlStatement sqlStatement )
        {
            SqlStatement = sqlStatement;
            Source = sqlStatement.Source;
            Provider = sqlStatement.Provider;
            ConnectionBuilder = new ConnectionBuilder( sqlStatement.Source, sqlStatement.Provider );
            Provider = ConnectionBuilder.Provider;
            Source = ConnectionBuilder.Source;
            Command = GetCommand( SqlStatement );
        }
        
        /// <summary>
        /// Sets the command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetCommand( ISqlStatement sqlStatement )
        {
            if( Enum.IsDefined( typeof( Provider ), ConnectionBuilder.Provider ) )
            {
                try
                {
                    switch( Provider )
                    {
                        case Provider.SQLite:
                        {
                            Command = GetSQLiteCommand( sqlStatement );
                            return Command;
                        }

                        case Provider.SqlCe:
                        {
                            Command = GetSQLiteCommand( sqlStatement );
                            return Command;
                        }

                        case Provider.SqlServer:
                        {
                            Command = GetSQLiteCommand( sqlStatement );
                            return Command;
                        }

                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            Command = GetOleDbCommand( sqlStatement );
                            return Command;
                        }

                        default:
                        {
                            return default( DbCommand );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the sq lite command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSQLiteCommand( ISqlStatement sqlStatement )
        {
            if( sqlStatement != null )
            {
                try
                {
                    var _connection = ConnectionBuilder?.Connection;

                    switch( sqlStatement?.CommandType )
                    {
                        case SQL.SELECT:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );

                            return !string.IsNullOrEmpty( _sql )
                                ? new SQLiteCommand( _sql, _connection as SQLiteConnection )
                                : default( SQLiteCommand );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = sqlStatement?.GetInsertStatement( );

                            return !string.IsNullOrEmpty( _sql )
                                ? new SQLiteCommand( _sql, _connection as SQLiteConnection )
                                : default( SQLiteCommand );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = sqlStatement?.GetUpdateStatement( );

                            return !string.IsNullOrEmpty( _sql )
                                ? new SQLiteCommand( _sql, _connection as SQLiteConnection )
                                : default( SQLiteCommand );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = sqlStatement?.GetDeleteStatement( );

                            return !string.IsNullOrEmpty( _sql )
                                ? new SQLiteCommand( _sql, _connection as SQLiteConnection )
                                : default( SQLiteCommand );
                        }
                        default:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );

                            return !string.IsNullOrEmpty( _sql )
                                ? new SQLiteCommand( _sql, _connection as SQLiteConnection )
                                : default( SQLiteCommand );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the SQL ce command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSqlCeCommand( ISqlStatement sqlStatement )
        {
            if( Verify.IsRef( sqlStatement ) )
            {
                try
                {
                    var _connection = ConnectionBuilder?.Connection;

                    if( !string.IsNullOrEmpty( _connection?.ConnectionString ) )
                    {
                        switch( sqlStatement?.CommandType )
                        {
                            case SQL.SELECT:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );

                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql, _connection as SqlCeConnection )
                                    : default( SqlCeCommand );
                            }

                            case SQL.INSERT:
                            {
                                var _sql = sqlStatement?.GetInsertStatement( );

                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql, _connection as SqlCeConnection )
                                    : default( SqlCeCommand );
                            }

                            case SQL.UPDATE:
                            {
                                var _sql = sqlStatement?.GetUpdateStatement( );

                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql, _connection as SqlCeConnection )
                                    : default( SqlCeCommand );
                            }

                            case SQL.DELETE:
                            {
                                var _sql = sqlStatement?.GetDeleteStatement( );

                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql, _connection as SqlCeConnection )
                                    : default( SqlCeCommand );
                            }

                            default:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );

                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCeCommand( _sql, _connection as SqlCeConnection )
                                    : default( DbCommand );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the SQL command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSqlCommand( ISqlStatement sqlStatement )
        {
            if( Verify.IsRef( sqlStatement ) )
            {
                try
                {
                    var _connection = ConnectionBuilder?.Connection;
                    using( _connection )
                    {
                        switch( sqlStatement?.CommandType )
                        {
                            case SQL.SELECT:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );

                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCommand( _sql, _connection as SqlConnection )
                                    : default( DbCommand );
                            }

                            case SQL.INSERT:
                            {
                                var _sql = sqlStatement?.GetInsertStatement( );

                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCommand( _sql, _connection as SqlConnection )
                                    : default( DbCommand );
                            }

                            case SQL.UPDATE:
                            {
                                var _sql = sqlStatement?.GetUpdateStatement( );

                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCommand( _sql, _connection as SqlConnection )
                                    : default( DbCommand );
                            }

                            case SQL.DELETE:
                            {
                                var _sql = sqlStatement?.GetDeleteStatement( );

                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCommand( _sql, _connection as SqlConnection )
                                    : default( DbCommand );
                            }

                            default:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );

                                return !string.IsNullOrEmpty( _sql )
                                    ? new SqlCommand( _sql, _connection as SqlConnection )
                                    : default( DbCommand );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the OLE database command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetOleDbCommand( ISqlStatement sqlStatement )
        {
            if( Verify.IsRef( sqlStatement ) )
            {
                try
                {
                    var _connection = ConnectionBuilder?.Connection;

                    switch( sqlStatement?.CommandType )
                    {
                        case SQL.SELECT:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );

                            return !string.IsNullOrEmpty( _sql )
                                ? new OleDbCommand( _sql, _connection as OleDbConnection )
                                : default( DbCommand );
                        }

                        case SQL.INSERT:
                        {
                            var _sql = sqlStatement?.GetInsertStatement( );

                            return !string.IsNullOrEmpty( _sql )
                                ? new OleDbCommand( _sql, _connection as OleDbConnection )
                                : default( DbCommand );
                        }

                        case SQL.UPDATE:
                        {
                            var _sql = sqlStatement.GetUpdateStatement( );

                            return !string.IsNullOrEmpty( _sql )
                                ? new OleDbCommand( _sql, _connection as OleDbConnection )
                                : default( DbCommand );
                        }

                        case SQL.DELETE:
                        {
                            var _sql = sqlStatement?.GetDeleteStatement( );

                            return !string.IsNullOrEmpty( _sql )
                                ? new OleDbCommand( _sql, _connection as OleDbConnection )
                                : default( DbCommand );
                        }

                        default:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );

                            return !string.IsNullOrEmpty( _sql )
                                ? new OleDbCommand( _sql, _connection as OleDbConnection )
                                : default( DbCommand );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
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