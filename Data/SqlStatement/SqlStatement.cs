// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    
    public class SqlStatement : SqlBase, ISqlStatement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        public SqlStatement()
        {
        }

        public SqlStatement( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, SQL commandType = SQL.SELECTALL ) 
            : base( source, provider, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connectionBuilder.</param>
        /// <param name="sqlText">The SQL Command Text.</param>
        public SqlStatement( IConnectionBuilder connectionBuilder, string sqlText ) 
            :base( connectionBuilder, sqlText )
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connection builder.</param>
        /// <param name="dict">The dictionary.</param>
        public SqlStatement( IConnectionBuilder connectionBuilder, IDictionary<string, object> dict ) 
            : base( connectionBuilder, dict )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connection builder.</param>
        /// <param name="dict">The dictionary.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( IConnectionBuilder connectionBuilder, IDictionary<string, object> dict,
            IDictionary<string, object> where, SQL commandType = SQL.SELECTALL )
            : base( connectionBuilder, dict, where, commandType )
        {

        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="dict"></param>
        /// <param name="commandType"></param>
        public SqlStatement( Source source, Provider provider, IDictionary<string, object> dict,
            SQL commandType = SQL.SELECTALL )
            : base( source, provider, dict, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="dict">The dictionary.</param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, IDictionary<string, object> dict,
            IDictionary<string, object> where, SQL commandType = SQL.SELECTALL ) 
            : base( source, provider, dict, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <param name="dict">The arguments.</param>
        public SqlStatement( Source source, Provider provider, SQL commandType, IDictionary<string, object> dict ) 
            : base( source, provider, dict, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connectionBuilder.</param>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the commandType.</param>
        public SqlStatement( IConnectionBuilder connectionBuilder, IDictionary<string, object> dict,
            SQL commandType = SQL.SELECTALL )
        {
        }
        

        /// <summary>
        /// Gets the update statement.
        /// </summary>
        /// <returns></returns>
        public string GetUpdateStatement( ) 
        {
            if( Criteria != null )
            {
                try
                {
                    var _update = CreateUpdateStatement( Criteria );

                    return !string.IsNullOrEmpty( _update )
                        ? _update
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary>
        /// Gets the insert statement.
        /// </summary>
        /// <returns></returns>
        public string GetInsertStatement( )
        {
            try
            {
                var _insert = CreateInsertStatement( Criteria );

                return !string.IsNullOrEmpty( _insert )
                    ? _insert
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the delete statement.
        /// </summary>
        /// <returns></returns>
        public string GetDeleteStatement( )
        {
            try
            {
                return Criteria?.Any( ) == true
                    ? CreateDeleteStatement( Criteria )
                    : $"DELETE * FROM { Source };";
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }
        
        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public string GetCommandText( IDictionary<string, object> dict, SQL commandType = SQL.SELECT )
        {
            if( dict?.Any( ) == true
                && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    switch( commandType )
                    {
                        case SQL.SELECT:
                        {
                            var _queryText = CreateSelectStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.SELECTALL:
                        {
                            var _queryText = CreateSelectStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.SELECTDISTINCT:
                        {
                            var _queryText = CreateSelectStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.INSERT:
                        {
                            var _queryText = CreateInsertStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.UPDATE:
                        {
                            var _queryText = CreateUpdateStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.DELETE:
                        {
                            var _queryText = CreateDeleteStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
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
        /// Gets the command text.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        public string GetCommandText( IEnumerable<string> columns, IDictionary<string, object> dict,
            SQL commandType = SQL.SELECT )
        {
            if( dict?.Any( ) == true
                && Enum.IsDefined( typeof( Source ), Source )
                && columns?.Any( ) == true )
            {
                try
                {
                    switch( commandType )
                    {
                        case SQL.SELECT:
                        {
                            var _queryText = CreateSelectStatement( columns, dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.SELECTALL:
                        {
                            var _queryText = CreateSelectStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.SELECTDISTINCT:
                        {
                            var _queryText = CreateSelectStatement( columns, dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.INSERT:
                        {
                            var _queryText = CreateInsertStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.UPDATE:
                        {
                            var _queryText = CreateUpdateStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.DELETE:
                        {
                            var _queryText = CreateDeleteStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
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
        /// Sets the command text.
        /// </summary>
        /// <param name = "columns" > </param>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        public string GetCommandText( IEnumerable<DataColumn> columns, IDictionary<string, object> dict,
            SQL commandType = SQL.SELECT )
        {
            if( dict?.Any( ) == true
                && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    var _cols = columns?.Where( s => s.DataType == typeof( string ) )
                        ?.Select( p => p.ColumnName ).ToList( );

                    switch( commandType )
                    {
                        case SQL.SELECT:
                        {
                            var _queryText = CreateSelectStatement( _cols, dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.SELECTALL:
                        {
                            var _queryText = CreateSelectStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.SELECTDISTINCT:
                        {
                            var _queryText = CreateSelectStatement( _cols, dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.INSERT:
                        {
                            var _queryText = CreateInsertStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.UPDATE:
                        {
                            var _queryText = CreateUpdateStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }
                        case SQL.DELETE:
                        {
                            var _queryText = CreateDeleteStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
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
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// A <see cref="System.String" /> that represents this instance.
        /// </returns>
        public override string ToString( )
        {
            try
            {
                return !string.IsNullOrEmpty( CommandText )
                    ? CommandText
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }


    }
}