// // <copyright file = "Query.cs" company = "Terry D. Eppler">
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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
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
        public Query( Source source, Provider provider = Provider.SQLite, SQL commandType = SQL.SELECT ) 
            : base( source, provider, commandType )
        {
            DataCommand = CommandBuilder.Command;
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
        public Query( Source source, Provider provider, IDictionary<string, object> dict, SQL commandType ) 
            : base( source, provider, dict, commandType )
        {
            DataCommand = CommandBuilder.Command;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="dict">The dictionary.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public Query( Source source, Provider provider, IDictionary<string, object> dict,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
            : base( source, provider, dict, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "sqlStatement" >
        /// The sqlStatement.
        /// </param>
        public Query( ISqlStatement sqlStatement ) 
            : base( sqlStatement.Source, sqlStatement.Provider, sqlStatement )
        {
            DataCommand = CommandBuilder.Command;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Query"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public Query( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
            DataCommand = CommandBuilder.Command;
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
        public Query( Source source, Provider provider, IDictionary<string, object> dict ) : 
            base( source, provider, dict )
        {
            DataCommand = CommandBuilder.Command;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "Query"/> class.
        /// </summary>
        /// <param name = "fullPath" >
        /// The fullpath.
        /// </param>
        /// <param name = "sqlText" > </param>
        /// <param name = "commandType" >
        /// The commandType.
        /// </param>
        public Query( string fullPath, string sqlText, SQL commandType = SQL.SELECT ) 
            : base( fullPath, sqlText, commandType )
        {
            DataCommand = CommandBuilder.Command;
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
            : base( fullPath, commandType, dict)
        {
            DataCommand = CommandBuilder.Command;
        }

        /// <inheritdoc/>
        /// <summary>
        /// Sets the Data reader.
        /// </summary>
        /// <param name = "behavior" >
        /// The behavior.
        /// </param>
        /// <returns>
        /// </returns>
        public DbDataReader GetDataReader( CommandBehavior behavior = CommandBehavior.CloseConnection )
        {
            if( DataCommand?.Connection != null
               && !string.IsNullOrEmpty( DataCommand?.CommandText )
               && Enum.IsDefined( typeof( CommandBehavior ), behavior ) )
            {
                try
                {
                    if( DataCommand.Connection?.State != ConnectionState.Open )
                    {
                        DataCommand.Connection?.Open( );
                        return DataCommand.ExecuteReader( CommandBehavior.CloseConnection );
                    }

                    if( DataCommand.Connection?.State == ConnectionState.Open )
                    {
                        return DataCommand.ExecuteReader( CommandBehavior.CloseConnection );
                    }
                }
                catch( Exception ex )
                {
                    if( DataCommand.Connection?.State == ConnectionState.Open )
                    {
                        DataCommand.Connection?.Close( );
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
            if( ConnectionFactory?.Connection != null )
            {
                try
                {
                    ConnectionFactory?.Connection?.Close( );
                    ConnectionFactory?.Connection?.Dispose( );
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