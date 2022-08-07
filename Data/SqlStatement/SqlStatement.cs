// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SqlBase" />
    /// <seealso cref="ISqlStatement" />
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    public class SqlStatement : SqlBase, ISqlStatement
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        public SqlStatement()
        {
        }

        public SqlStatement( Source source, Provider provider )
        {
            CommandType = SQL.SELECTALL;
            Source = source;
            TableName = source.ToString( );
            Provider = provider;
            FilePath = GetFilePath( provider );
            Args = null;
            Criteria = null;
            Columns = null;
        }

        public SqlStatement( Source source, Provider provider, SQL commandType = SQL.SELECTALL ) 
            : this( source, provider )
        {
            Source = source;
            TableName = source.ToString( );
            Provider = provider;
            FilePath = GetFilePath( provider );
            Args = null;
            Criteria = null;
            Columns = null;
            CommandType = commandType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connectionBuilder.</param>
        /// <param name="commandType">The commandType.</param>
        public SqlStatement( IConnectionBuilder connectionBuilder, SQL commandType = SQL.SELECTALL )
        {
            CommandType = commandType;
            Source = connectionBuilder.Source;
            TableName = Source.ToString( );
            Provider = connectionBuilder.Provider;
            FilePath = GetFilePath( Provider );
            Args = null;
            Criteria = null;
            Columns = null;
            CommandText = GetSelectStatement( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlStatement"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connectionBuilder.</param>
        /// <param name="dict">The dictionary.</param>
        public SqlStatement( IConnectionBuilder connectionBuilder, IDictionary<string, object> dict )
        {
            CommandType = SQL.SELECTALL;
            Source = connectionBuilder.Source;
            TableName = Source.ToString( );
            Provider = connectionBuilder.Provider;
            Args = dict;
            Columns = null;
            CommandText = GetSelectStatement( );
        }

        public SqlStatement( IConnectionBuilder connectionBuilder, IEnumerable<DataColumn> columns, IDictionary<string, object> dict )
        {
            CommandType = SQL.SELECTDISTINCT;
            Source = connectionBuilder.Source;
            TableName = Source.ToString( );
            Provider = connectionBuilder.Provider;
            Args = dict;
            Columns = columns;
            CommandText = GetSelectStatement( Columns, Args );
        }

        public SqlStatement( Source source, Provider provider, IDictionary<string, object> dict )
        {
            CommandType = SQL.SELECTALL;
            Source = source;
            Provider = provider;
            TableName = Source.ToString( );
            Args = dict;
            Columns = null;
            CommandText = GetSelectStatement( );
        }

        public SqlStatement( Source source, Provider provider, SQL commandType, IDictionary<string, object> dict )
        {
            CommandType = commandType;
            Source = source;
            Provider = provider;
            Args = dict;
            TableName = Source.ToString( );
            Columns = null;
            FilePath = GetFilePath( provider );
            CommandText = GetCommandText( Args );
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
            CommandType = commandType;
            Source = connectionBuilder.Source;
            Provider = connectionBuilder.Provider;
            TableName = Source.ToString( );
            Args = dict;
            Columns = null;
            FilePath = GetFilePath( connectionBuilder.Provider );
            CommandText = GetCommandText( Args );
        }
        
        /// <summary>
        /// Gets the select statement.
        /// </summary>
        /// <returns></returns>
        public override string GetSelectStatement( )
        {
            if( Args != null )
            {
                try
                {
                    var _values = string.Empty;

                    foreach( var kvp in Args )
                    {
                        _values += $"{kvp.Key} = '{kvp.Value}' AND ";
                    }

                    _values = _values.TrimEnd( " AND".ToCharArray( ) );
                    CommandText = $"SELECT * FROM { Source } WHERE { _values };";

                    return !string.IsNullOrEmpty( CommandText )
                        ? CommandText
                        : default( string );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }
            else if( Args == null )
            {
                return $"SELECT * FROM { Source };";
            }

            return default( string );
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
                    var _update = string.Empty;

                    foreach( var kvp in Args )
                    {
                        _update += $" {kvp.Key} = '{kvp.Value}' AND";
                    }

                    var _values = _update.TrimEnd( " AND".ToCharArray( ) );

                    return $"UPDATE { Source } SET { _values };";
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
                var _columnName = string.Empty;
                var _values = string.Empty;

                foreach( var kvp in Args )
                {
                    _columnName += $"{ kvp.Key }, ";
                    _values += $"{ kvp.Value }, ";
                }

                var values =
                    $"({ _columnName.TrimEnd( ", ".ToCharArray( ) ) }) VALUES ({ _values.TrimEnd( ", ".ToCharArray( ) ) })";

                return $"INSERT INTO { Source } { values };";
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
                    ? GetDeleteStatement( Args )
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
        public virtual string GetFilePath( SQL command )
        {
            if( Enum.IsDefined( typeof( SQL ), command ) )
            {
                try
                {
                    switch( command )
                    {
                        case SQL.ALTERTABLE:
                        {
                            return ConfigurationManager.AppSettings[ "ALTERTABLE" ];
                        }
                        case SQL.CREATETABLE:
                        {
                            return ConfigurationManager.AppSettings[ "CREATETABLE" ];
                        }
                        case SQL.CREATEDATABASE:
                        {
                            return ConfigurationManager.AppSettings[ "CREATEDATABASE" ];
                        }
                        case SQL.CREATEVIEW:
                        {
                            return ConfigurationManager.AppSettings[ "CREATEVIEW" ];
                        }
                        case SQL.DETACH:
                        {
                            return ConfigurationManager.AppSettings[ "DETACH" ];
                        }
                        case SQL.DELETE:
                        {
                            return ConfigurationManager.AppSettings[ "DELETE" ];
                        }
                        case SQL.SELECTALL:
                        {
                            return ConfigurationManager.AppSettings[ "SELECTALL" ];
                        }
                        case SQL.SELECT:
                        {
                            return ConfigurationManager.AppSettings[ "SELECT" ];
                        }
                        case SQL.INSERT:
                        {
                            return ConfigurationManager.AppSettings[ "INSERT" ];
                        }
                        case SQL.UPDATE:
                        {
                            return ConfigurationManager.AppSettings[ "UPDATE" ];
                        }
                        default:
                        {
                            return ConfigurationManager.AppSettings[ "SELECTALL" ];
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
        /// Gets the file path.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        public virtual string GetFilePath( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    switch( provider )
                    {
                        case Provider.OleDb:
                        {
                            return ConfigurationManager.AppSettings[ "OleDb" ];
                        }
                        case Provider.Access:
                        {
                            return ConfigurationManager.AppSettings[ "Access" ];
                        }
                        case Provider.SQLite:
                        {
                            return ConfigurationManager.AppSettings[ "SQLite" ];
                        }
                        case Provider.SqlCe:
                        {
                            return ConfigurationManager.AppSettings[ "SqlCe" ];
                        }
                        case Provider.Excel:
                        {
                            return ConfigurationManager.AppSettings[ "Excel" ];
                        }
                        case Provider.SqlServer:
                        {
                            return ConfigurationManager.AppSettings[ "SqlServer" ];
                        }
                        case Provider.CSV:
                        {
                            return ConfigurationManager.AppSettings[ "CSV" ];
                        }
                        default:
                        {
                            return ConfigurationManager.AppSettings[ "SQLite" ];
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
        public virtual string GetCommandText( IEnumerable<string> columns, IDictionary<string, object> dict,
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
                            var _queryText = GetSelectStatement( columns, dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }

                        case SQL.SELECTDISTINCT:
                        {
                            var _queryText = GetSelectStatement( columns, dict );

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
        public virtual string GetCommandText( IEnumerable<DataColumn> columns, IDictionary<string, object> dict, SQL commandType = SQL.SELECT )
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

                            var _queryText = GetSelectStatement( _cols, dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }

                        case SQL.SELECTDISTINCT:
                        {
                            var _queryText = GetSelectStatement( columns, dict );

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
        public override string ToString()
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