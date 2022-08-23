// <copyright file = "QueryBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class QueryBase
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        public Source Source { get; set; }

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
        public IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// Gets the connection manager.
        /// </summary>
        /// <value>
        /// The connection manager.
        /// </value>
        public IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// Gets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        public ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Gets the connector.
        /// </summary>
        /// <value>
        /// The connector.
        /// </value>
        public IConnectionFactory ConnectionFactory { get; set; }

        /// <summary>
        /// Gets the commander.
        /// </summary>
        /// <value>
        /// The commander.
        /// </value>
        public IDataCommand CommandBuilder { get; set; }

        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        public DbConnection DataConnection { get; set; }

        /// <summary>
        /// Gets the command.
        /// </summary>
        /// <value>
        /// The command.
        /// </value>
        public DbCommand DataCommand { get; set; }
        
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
        public bool IsDisposed { get; set; }

        /// <summary>
        /// Gets or sets the Data reader.
        /// </summary>
        /// <value>
        /// The Data reader.
        /// </value>
        public DbDataReader DataReader { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        protected QueryBase()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        protected QueryBase( Source source, Provider provider = Provider.SQLite,
            SQL commandType = SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        protected QueryBase( Source source, Provider provider, IDictionary<string, object> dict,
            SQL commandType )
        {
            Source = source;
            Provider = provider;
            Args = dict;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, dict, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder );
            DataCommand = CommandBuilder.Command;
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name = "provider" > </param>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <param name = "source" > </param>
        protected QueryBase( Source source, Provider provider, ISqlStatement sqlStatement )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider);
            SqlStatement = sqlStatement;
            CommandBuilder = new CommandBuilder( sqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder );
            DataCommand = CommandBuilder.Command;
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="dict">The dictionary.</param>
        protected QueryBase( Source source, Provider provider, IDictionary<string, object> dict )
        {
            Source = source;
            Provider = provider;
            Args = dict;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, dict, SQL.SELECT );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name = "updates" > </param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        protected QueryBase( Source source, Provider provider, IDictionary<string, object> updates, 
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            Source = source;
            Provider = provider;
            Args = updates;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, updates, where, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder );
            IsDisposed = false;
        }

        protected QueryBase( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> criteria, SQL commandType = SQL.SELECT )
        {
            Source = source;
            Provider = provider;
            Args = criteria;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, columns, criteria, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder );
            IsDisposed = false;
        }

        protected QueryBase( Source source, Provider provider, string sqlText )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, sqlText );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder );
            IsDisposed = false;
            Args = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <param name = "sqlText" > </param>
        /// <param name="commandType">Type of the command.</param>
        protected QueryBase( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
        {
            ConnectionBuilder = new ConnectionBuilder( fullPath );
            Source = Source.External;
            Provider = ConnectionBuilder.Provider;
            SqlStatement = new SqlStatement( ConnectionBuilder.Source, ConnectionBuilder.Provider, sqlText );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="QueryBase"/> class.
        /// </summary>
        /// <param name="fullPath">The full path.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="dict">The dictionary.</param>
        protected QueryBase( string fullPath, SQL commandType, IDictionary<string, object> dict )
        {
            ConnectionBuilder = new ConnectionBuilder( fullPath );
            Source = ConnectionBuilder.Source;
            Provider = ConnectionBuilder.Provider;
            SqlStatement = new SqlStatement( Source, Provider, dict, commandType );
            CommandBuilder = new CommandBuilder( SqlStatement );
            DataAdapter = new AdapterBuilder( CommandBuilder );
            IsDisposed = false;
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
                return ConnectionBuilder?.Connection ?? default( DbConnection );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DbConnection );
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Gets the adapter.
        /// </summary>
        /// <returns>
        /// </returns>
        public DbDataAdapter GetAdapter()
        {
            try
            {
                return new AdapterBuilder( CommandBuilder );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DbDataAdapter );
            }
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
