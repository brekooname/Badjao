// <copyright file = "QueryBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SqlServerCe;
    using System.Data.SQLite;
    using System.Diagnostics.CodeAnalysis;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class QueryBase
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        public virtual Source Source { get; set; }

        /// <summary>
        /// Gets the Provider
        /// </summary>
        public virtual Provider Provider { get; set; }

        /// <summary>
        /// Gets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        public virtual IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// Gets the connection manager.
        /// </summary>
        /// <value>
        /// The connection manager.
        /// </value>
        public virtual IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// Gets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        public virtual ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Gets the connector.
        /// </summary>
        /// <value>
        /// The connector.
        /// </value>
        public virtual IConnectionFactory ConnectionFactory { get; set; }

        /// <summary>
        /// Gets the commander.
        /// </summary>
        /// <value>
        /// The commander.
        /// </value>
        public virtual ICommandBuilder CommandBuilder { get; set; }

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public virtual DbConnection DataConnection { get; set; }

        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <value>
        /// The command.
        /// </value>
        public virtual DbCommand DataCommand { get; set; }

        /// <summary>
        /// Gets the adapter.
        /// </summary>
        /// <value>
        /// The adapter.
        /// </value>
        public virtual DbDataAdapter DataAdapter { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is disposed.
        /// </summary>
        /// <value>
        /// <c>
        /// true
        /// </c>
        /// if this instance is disposed; otherwise,
        /// <c>
        /// false
        /// </c>
        /// .
        /// </value>
        public virtual bool IsDisposed { get; set; }

        /// <summary>
        /// Gets or sets the Data reader.
        /// </summary>
        /// <value>
        /// The Data reader.
        /// </value>
        public virtual DbDataReader DataReader { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        public QueryBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        public QueryBase( Source source, Provider provider = Provider.SQLite,
            SQL commandType = SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        public QueryBase( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType = SQL.SELECTALL )
        {
            Source = source;
            Provider = provider;
            Args = where;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, where, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name = "provider" > </param>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <param name = "source" > </param>
        public QueryBase( Source source, Provider provider, ISqlStatement sqlStatement )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            DataConnection = ConnectionBuilder.Connection;
            Args = sqlStatement.Criteria ?? null;
            SqlStatement = sqlStatement;
            CommandBuilder = new CommandBuilder( sqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="where">The dictionary.</param>
        public QueryBase( Source source, Provider provider, IDictionary<string, object> where )
        {
            Source = source;
            Provider = provider;
            Args = where;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, where, SQL.SELECT );
            CommandBuilder = new CommandBuilder( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name = "updates" > </param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public QueryBase( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            Source = source;
            Provider = provider;
            Args = where;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The having.</param>
        /// <param name="commandType">Type of the command.</param>
        public QueryBase( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            Source = source;
            Provider = provider;
            Args = where;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, columns, where, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public QueryBase( Source source, Provider provider, string sqlText )
        {
            Source = source;
            Provider = provider;
            Args = null;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( source, provider, sqlText );
            CommandBuilder = new CommandBuilder( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <param name = "sqlText" > </param>
        /// <param name="commandType">Type of the command.</param>
        public QueryBase( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
        {
            Args = null;
            ConnectionBuilder = new ConnectionBuilder( fullPath );
            Provider = ConnectionBuilder.Provider;
            Source = ConnectionBuilder.Source;
            DataConnection = ConnectionBuilder.Connection;

            SqlStatement = new SqlStatement( ConnectionBuilder.Source, ConnectionBuilder.Provider,
                sqlText );

            CommandBuilder = new CommandBuilder( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="where">The dictionary.</param>
        public QueryBase( string fullPath, SQL commandType, IDictionary<string, object> where )
        {
            Args = where;
            ConnectionBuilder = new ConnectionBuilder( fullPath );
            Source = ConnectionBuilder.Source;
            Provider = ConnectionBuilder.Provider;
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = new SqlStatement( Source, Provider, where, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        public QueryBase( ISqlStatement sqlStatement )
        {
            Args = null;
            Source = sqlStatement.Source;
            Provider = sqlStatement.Provider;
            ConnectionBuilder = new ConnectionBuilder( sqlStatement.Source, sqlStatement.Provider );
            DataConnection = ConnectionBuilder.Connection;
            SqlStatement = sqlStatement;
            CommandBuilder = new CommandBuilder( sqlStatement );
        }
        
        /// <inheritdoc/>
        /// <summary>
        /// Gets the adapter.
        /// </summary>
        /// <returns>
        /// </returns>
        public DbDataAdapter GetAdapter( )
        {
            if( Enum.IsDefined( typeof( Provider ), Provider )
                && !string.IsNullOrEmpty( SqlStatement?.CommandText )
                && DataConnection != null )
            {
                try
                {
                    string _commandText = SqlStatement.CommandText;

                    switch( Provider )
                    {
                        case Provider.Access:
                        {
                            OleDbConnection _connection = DataConnection as OleDbConnection;
                            return new OleDbDataAdapter( _commandText, _connection );
                        }
                        case Provider.SQLite:
                        {
                            SQLiteConnection _connection = DataConnection as SQLiteConnection;
                            return new SQLiteDataAdapter( _commandText, _connection );
                        }
                        case Provider.SqlCe:
                        {
                            SqlCeConnection _connection = DataConnection as SqlCeConnection;
                            return new SqlCeDataAdapter( _commandText, _connection );
                        }
                        case Provider.SqlServer:
                        {
                            SqlConnection _connection = DataConnection as SqlConnection;
                            return new SqlDataAdapter( _commandText, _connection );
                        }
                        default:
                        {
                            OleDbConnection _connection = DataConnection as OleDbConnection;
                            return new OleDbDataAdapter( _commandText, _connection );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbDataAdapter );
                }
            }

            return default( DbDataAdapter );
        }

        /// <summary>
        /// Get Error Dialog.
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