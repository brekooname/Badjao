﻿// // <copyright file = "Query.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// </summary>
    /// <seealso cref = "IDisposable"/>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" )]
    public class Query : QueryBase, IQuery
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        public Query()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source.
        /// </param>
        /// <param name = "provider" >
        /// The provider.
        /// </param>
        /// <param name = "commandType" >
        /// The commandType.
        /// </param>
        public Query( Source source, Provider provider = Provider.SQLite,
            SQL commandType = SQL.SELECT )
        {
            SetConnectionBuilder( source, provider );
            ConnectionFactory = new ConnectionFactory( ConnectionBuilder );
            SqlStatement = new SqlStatement( ConnectionBuilder, commandType );
            CommandBuilder = new CommandBuilder( ConnectionBuilder, SqlStatement );
            Adapter = new AdapterFactory( ConnectionBuilder, SqlStatement )?.GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source Data.
        /// </param>
        /// <param name = "provider" >
        /// The provider used.
        /// </param>
        /// <param name = "dict" >
        /// The dictionary of parameters.
        /// </param>
        /// <param name = "commandType" >
        /// The type of sql command.
        /// </param>
        public Query( Source source, Provider provider, IDictionary<string, object> dict,
            SQL commandType )
        {
            SetConnectionBuilder( source, provider );
            ConnectionFactory = new ConnectionFactory( ConnectionBuilder );
            SqlStatement = new SqlStatement( ConnectionBuilder, dict, commandType );
            CommandBuilder = new CommandBuilder( ConnectionBuilder, SqlStatement );
            Adapter = new AdapterFactory( ConnectionBuilder, SqlStatement )?.GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "connectionBuilder" >
        /// The connectionBuilder.
        /// </param>
        /// <param name = "sqlStatement" >
        /// The sqlStatement.
        /// </param>
        public Query( IConnectionBuilder connectionBuilder, ISqlStatement sqlStatement )
        {
            ConnectionBuilder = connectionBuilder;
            ConnectionFactory = new ConnectionFactory( ConnectionBuilder );
            SqlStatement = sqlStatement;
            CommandBuilder = new CommandBuilder( ConnectionBuilder, SqlStatement );
            Adapter = new AdapterFactory( ConnectionBuilder, SqlStatement )?.GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source.
        /// </param>
        /// <param name = "provider" >
        /// The provider.
        /// </param>
        /// <param name = "dict" >
        /// The dictionary.
        /// </param>
        public Query( Source source, Provider provider, IDictionary<string, object> dict )
        {
            SetConnectionBuilder( source, provider );
            ConnectionFactory = new ConnectionFactory( ConnectionBuilder );
            SqlStatement = new SqlStatement( ConnectionBuilder, dict, SQL.SELECT );
            CommandBuilder = new CommandBuilder( ConnectionBuilder, SqlStatement );
            Adapter = new AdapterFactory( ConnectionBuilder, SqlStatement )?.GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "fullPath" >
        /// The fullpath.
        /// </param>
        /// <param name = "commandType" >
        /// The commandType.
        /// </param>
        public Query( string fullPath, SQL commandType = SQL.SELECT )
        {
            SetConnectionBuilder( fullPath );
            ConnectionFactory = new ConnectionFactory( ConnectionBuilder );
            SqlStatement = new SqlStatement( ConnectionBuilder, commandType );
            CommandBuilder = new CommandBuilder( ConnectionBuilder, SqlStatement );
            Adapter = new AdapterFactory( ConnectionBuilder, SqlStatement )?.GetAdapter( );
            IsDisposed = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "fullPath" >
        /// The fullpath.
        /// </param>
        /// <param name = "commandType" >
        /// The commandType.
        /// </param>
        /// <param name = "dict" >
        /// The dictionary.
        /// </param>
        public Query( string fullPath, SQL commandType, IDictionary<string, object> dict )
        {
            SetConnectionBuilder( fullPath );
            ConnectionFactory = new ConnectionFactory( ConnectionBuilder );
            SqlStatement = new SqlStatement( ConnectionBuilder, dict, commandType );
            CommandBuilder = new CommandBuilder( ConnectionBuilder, SqlStatement );
            Adapter = new AdapterFactory( ConnectionBuilder, SqlStatement )?.GetAdapter( );
            IsDisposed = false;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Sets the Data reader.
        /// </summary>
        /// <param name = "command" >
        /// The command.
        /// </param>
        /// <param name = "behavior" >
        /// The behavior.
        /// </param>
        /// <returns>
        /// </returns>
        public DbDataReader GetDataReader( DbCommand command,
            CommandBehavior behavior = CommandBehavior.CloseConnection )
        {
            if( Command?.Connection != null
               && !string.IsNullOrEmpty( command?.CommandText )
               && Enum.IsDefined( typeof( CommandBehavior ), behavior ) )
            {
                try
                {
                    if( command?.Connection?.State != ConnectionState.Open )
                    {
                        command?.Connection?.Open( );
                        return command?.ExecuteReader( CommandBehavior.CloseConnection );
                    }

                    if( command?.Connection?.State == ConnectionState.Open )
                    {
                        return command?.ExecuteReader( CommandBehavior.CloseConnection );
                    }
                }
                catch( Exception ex )
                {
                    if( command?.Connection?.State == ConnectionState.Open )
                    {
                        command?.Connection?.Close( );
                    }

                    Fail( ex );
                    return default( DbDataReader );
                }
            }

            return default( DbDataReader );
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name = "disposing" >
        /// <c>
        /// true
        /// </c>
        /// to release both managed and unmanaged resources;
        /// <c>
        /// false
        /// </c>
        /// to release only unmanaged resources.
        /// </param>
        [SuppressMessage( "ReSharper", "UnusedParameter.Global" )]
        protected virtual void Dispose( bool disposing )
        {
            if( ConnectionFactory?.GetConnection( ) != null )
            {
                try
                {
                    ConnectionFactory?.GetConnection( )?.Close( );
                    ConnectionFactory?.GetConnection( )?.Dispose( );
                    IsDisposed = true;
                }
                catch( Exception ex )
                {
                    IsDisposed = false;
                    Fail( ex );
                }
            }
        }

        /// <inheritdoc/>
        /// <summary>
        /// Performs application-defined tasks associated with freeing, releasing, or
        /// resetting unmanaged resources.
        /// </summary>
        public virtual void Dispose()
        {
            try
            {
                Dispose( true );
                GC.SuppressFinalize( this );
            }
            catch( Exception ex )
            {
                IsDisposed = false;
                Fail( ex );
            }
        }
    }
}