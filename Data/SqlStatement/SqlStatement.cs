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

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public SqlStatement( Source source, Provider provider ) 
            : base( source, provider )
        {
            FilePath = GetDbClientPath( provider );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlStatement( Source source, Provider provider, SQL commandType = SQL.SELECTALL ) 
            : this( source, provider )
        {
            FilePath = GetDbClientPath( provider );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connectionBuilder.</param>
        /// <param name="commandType">The commandType.</param>
        public SqlStatement( IConnectionBuilder connectionBuilder, SQL commandType = SQL.SELECTALL ) 
            :base( connectionBuilder, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connectionBuilder.</param>
        /// <param name="dict">The dictionary.</param>
        public SqlStatement( IConnectionBuilder connectionBuilder, IDictionary<string, object> dict )
            : base( connectionBuilder, dict )
        {
        }

        public SqlStatement( IConnectionBuilder connectionBuilder, IEnumerable<DataColumn> columns, 
            IDictionary<string, object> dict ) 
            : base( connectionBuilder, columns, dict )
        {
        }

        public SqlStatement( Source source, Provider provider, IDictionary<string, object> dict ) 
            : base( source, provider, dict )
        {
        }

        public SqlStatement( Source source, Provider provider, SQL commandType, 
            IDictionary<string, object> dict ) 
            : base( source, provider, commandType, dict )
        {
            FilePath = GetDbClientPath( provider );
            CommandText = GetSelectStatement(  );
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
            FilePath = GetDbClientPath( connectionBuilder.Provider );
            CommandText = GetSelectStatement(  );
        }
        

        /// <summary>
        /// Gets the update statement.
        /// </summary>
        /// <returns></returns>
        public string GetUpdateStatement( ) 
        {
            if( Args != null )
            {
                try
                {
                    var _update = CreateUpdateStatement( Args );

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
                var _insert = CreateInsertStatement( Args );

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
                return Args?.Any( ) == true
                    ? CreateDeleteStatement( Args )
                    : $"DELETE * FROM { Source };";
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <param name="command">The provider.</param>
        /// <returns></returns>
        public string GetSqlFilePath( SQL command )
        {
            if( Enum.IsDefined( typeof( SQL ), command ) )
            {
                try
                {
                    return DbClientPath[ $"{ command }" ];
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return string.Empty;
        }


        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        public virtual string GetDbClientPath( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    return DbClientPath[ $"{ provider }" ];
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

                        case SQL.SELECTDISTINCT:
                        {
                            var _queryText = CreateSelectStatement( columns, dict );

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
                    switch( commandType )
                    {
                        case SQL.SELECT:

                        {
                            var _cols = columns?.Where( s => s.DataType == typeof( string ) )
                                ?.Select( p => p.ColumnName ).ToList( );

                            var _queryText = CreateSelectStatement( _cols, dict );

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