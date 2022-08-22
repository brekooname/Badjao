// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Diagnostics.CodeAnalysis;

namespace BudgetExecution
{
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IProvider" />
    /// <seealso cref="ISource" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class SqlBase 
    {
        /// <summary>
        /// The extension
        /// </summary>
        public EXT Extension { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// The command type
        /// </summary>
        public virtual SQL CommandType { get; set; }

        /// <summary>
        /// The arguments
        /// </summary>
        public virtual IDictionary<string, object> Criteria { get; set; }
        
        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public virtual IEnumerable<string> Columns { get; set; }

        /// <summary>
        /// The command text
        /// </summary>
        public virtual string CommandText { get; set; }

        /// <summary>
        /// The command text
        /// </summary>
        public virtual string SelectCommand { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public virtual string TableName { get; set; }
        
        /// <summary>
        /// The provider path
        /// </summary>
        public virtual string DbClientPath { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        public virtual string FileName { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        protected SqlBase()
        {
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, SQL commandType = SQL.SELECTALL )
        {
            DbClientPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            TableName = source.ToString( );
            Provider = provider;
            Criteria = null;
            Columns = null;
            SelectCommand = GetSelectStatement( );
            CommandText = SelectCommand;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        protected SqlBase( Source source, Provider provider, string sqlText )
        {
            DbClientPath = new ConnectionBuilder( source, provider ).DbPath;
            Source = source;
            TableName = source.ToString( );
            Provider = provider;
            CommandType = SQL.NS;
            Criteria = null;
            Columns = null;
            CommandText = sqlText;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connection builder.</param>
        /// <param name = "sqlText" > </param>
        protected SqlBase( IConnectionBuilder connectionBuilder, string sqlText  )
        {
            DbClientPath = connectionBuilder.DbPath;
            Source = connectionBuilder.Source;
            TableName = connectionBuilder.Source.ToString( );
            Provider = connectionBuilder.Provider;
            CommandType = SQL.NS;
            Criteria = null;
            Columns = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connection builder.</param>
        /// <param name="dict">The dictionary.</param>
        /// <param name = "commandType" > </param>
        protected SqlBase( IConnectionBuilder connectionBuilder, IDictionary<string, object> dict,
            SQL commandType = SQL.SELECTALL )
        {
            DbClientPath = connectionBuilder.DbPath;
            CommandType = commandType;
            Source = connectionBuilder.Source;
            TableName = Source.ToString( );
            Provider = connectionBuilder.Provider;
            Criteria = dict;
            Columns = commandType == SQL.UPDATE
                ? dict.Keys
                : null;
        }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name = "dict" > </param>
        /// <param name = "commandType" > </param>
        protected SqlBase( Source source, Provider provider, IDictionary<string, object> dict,
            SQL commandType = SQL.SELECTALL )
        {
            DbClientPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = Source.ToString( );
            Criteria = dict;
            Columns = commandType == SQL.UPDATE
                ? dict.Keys
                : null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> dict, SQL commandType = SQL.SELECT )
        {
            DbClientPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = Source.ToString( );
            Criteria = dict;
            Columns = columns;
        }

        /// <summary>
        /// Sets the select statement.
        /// </summary>
        public virtual string GetSelectStatement( )
        {
            if( Columns?.Any( ) == true 
                && Criteria?.Any( ) == true )
            {
                try
                {
                    var _values = string.Empty;
                    var _columns = string.Empty;

                    foreach( var kvp in Criteria )
                    {
                        _values += $" {kvp.Key} = '{kvp.Value}' AND";
                    }

                    foreach( var col in Columns )
                    {
                        _columns += $" { col },";
                    }

                    _values = _values.TrimEnd( " AND".ToCharArray( ) );
                    CommandText = $"SELECT { _columns } FROM { Source } WHERE { _values };";

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
            else if( Columns == null
                && Criteria?.Any( ) != true )
            {
                return $"SELECT * FROM { Source };";
            }

            return default( string );
        }

        /// <summary>
        /// Sets the select statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        public virtual string CreateSelectStatement( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _empty = string.Empty;

                    foreach( var _kvp in dict )
                    {
                        _empty += $"{ _kvp.Key } = '{ _kvp.Value }' AND";
                    }

                    var _values = _empty.TrimEnd( " AND".ToCharArray( ) );
                    var _tableName = Source.ToString( );
                    return $"SELECT * FROM { _tableName } WHERE { _values };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the select statement.
        /// </summary>
        /// <param name="columnNames">The column names.</param>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public virtual string CreateSelectStatement( IEnumerable<string> columnNames, IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true 
                && columnNames?.Any( ) == true )
            {
                try
                {
                    var _empty = string.Empty;
                    var _columns = string.Empty;
                    foreach( var _kvp in dict )
                    {
                        _empty += $"{ _kvp.Key } = '{ _kvp.Value }' AND";
                    }

                    foreach( var name in columnNames )
                    {
                        _columns += $"{ name }, ";
                    }

                    var _criteria = _empty.TrimEnd( " AND".ToCharArray( ) );
                    var _tableName = TableName;
                    var _columnString = _columns.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT { _columnString } FROM { _tableName } WHERE { _criteria };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Gets the select statement.
        /// </summary>
        /// <param name="columns">The columns.</param>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public virtual string CreateSelectStatement( IEnumerable<DataColumn> columns, IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true
                && columns?.Any( ) == true )
            {
                try
                {
                    var _empty = string.Empty;
                    var _columns = string.Empty;
                    foreach( var _kvp in dict )
                    {
                        _empty += $"{ _kvp.Key } = '{ _kvp.Value }' AND";
                    }

                    foreach( var name in columns )
                    {
                        if( name.GetType(  ) == typeof( string ) )
                        {
                            _columns += $"{ name }, ";
                        }
                        else if( name.GetType(  ) == typeof( decimal ) )
                        {
                            _columns += $"SUM({ name }), ";
                        }
                    }

                    var _criteria = _empty.TrimEnd( " AND".ToCharArray( ) );
                    var _tableName = TableName;
                    var _columnString = _columns.TrimEnd( ", ".ToCharArray( ) );

                    return
                        $"SELECT DISTINCT { _columnString } FROM { _tableName } WHERE { _criteria } GROUP BY { _columnString }";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the update statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        public virtual string CreateUpdateStatement( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true
                && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    var _update = string.Empty;

                    foreach( var kvp in dict )
                    {
                        _update += $" {kvp.Key} = '{kvp.Value}' AND";
                    }

                    var _vals = _update.TrimEnd( " AND".ToCharArray( ) );
                    return $"{ SQL.UPDATE } { Source } SET { _vals };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the insert statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        public virtual string CreateInsertStatement( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true 
                && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    var _column = string.Empty;
                    var _values = string.Empty;

                    foreach( var kvp in dict )
                    {
                        _column += $"{ kvp.Key }, ";
                        _values += $"{ kvp.Value }, ";
                    }

                    var values =
                        $"({ _column.TrimEnd( ", ".ToCharArray( ) ) }) VALUES ({ _values.TrimEnd( ", ".ToCharArray( ) ) })";

                    return $"{ SQL.INSERT } INTO { Source } { values };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the delete statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        public virtual string CreateDeleteStatement( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true
                && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    var _columns = string.Empty;

                    foreach( var kvp in dict )
                    {
                        _columns += $" { kvp.Key } = '{ kvp.Value }' AND";
                    }

                    var _values = _columns.TrimEnd( " AND".ToCharArray( ) );
                    return $"{ SQL.DELETE } FROM { Source } WHERE { _values };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
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