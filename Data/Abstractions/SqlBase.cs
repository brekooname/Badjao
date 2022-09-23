// <copyright file = "SqlBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IProvider" />
    /// <seealso cref="ISource" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "ConvertIfStatementToSwitchStatement" ) ]
    public class SqlBase
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
        public SQL CommandType { get; set; }

        /// <summary>
        /// The arguments
        /// </summary>
        public IDictionary<string, object> Criteria { get; set; }

        /// <summary>
        /// Gets or sets the updates.
        /// </summary>
        /// <value>
        /// The updates.
        /// </value>
        public IDictionary<string, object> Updates { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public IEnumerable<string> Columns { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// The provider path
        /// </summary>
        public string DbPath { get; set; }

        /// <summary>
        /// The file name
        /// </summary>
        public string FileName { get; set; }

        /// <summary>
        /// Gets or sets the select statement.
        /// </summary>
        /// <value>
        /// The select statement.
        /// </value>
        public string CommandText { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        public SqlBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlBase( Source source, Provider provider, SQL commandType = SQL.SELECTALL )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            TableName = source.ToString( );
            Provider = provider;
            Criteria = null;
            Columns = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public SqlBase( Source source, Provider provider, string sqlText )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            Source = source;
            TableName = source.ToString( );
            Provider = provider;
            Criteria = null;
            Columns = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlBase( Source source, Provider provider, string sqlText,
            SQL commandType = SQL.SELECT )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            Source = source;
            TableName = source.ToString( );
            Provider = provider;
            CommandType = commandType;
            Updates = null;
            Criteria = null;
            Columns = null;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name = "where" > </param>
        /// <param name = "commandType" > </param>
        public SqlBase( Source source, Provider provider, IDictionary<string, object> where,
            SQL commandType = SQL.SELECTALL )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = Source.ToString( );
            Updates = null;
            Criteria = where;
            Columns = null;
        }

        public SqlBase( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = Source.ToString( );
            Updates = updates;
            Criteria = where;
            Columns = updates.Keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="where">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        public SqlBase( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> where, SQL commandType = SQL.SELECT )
        {
            DbPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = Source.ToString( );
            Updates = null;
            Criteria = where;
            Columns = columns;
        }

        /// <summary>
        /// Sets the select statement.
        /// </summary>
        public string GetSelectStatement( )
        {
            if( Columns?.Any( ) == true
                && Criteria?.Any( ) == true )
            {
                try
                {
                    string _columns = string.Empty;

                    foreach( string col in Columns )
                    {
                        _columns += $"{ col }, ";
                    }

                    string _cols = _columns.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT { _cols } FROM { Source } WHERE { Criteria.ToCriteria( ) };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }
            else if( Columns == null
                && Criteria?.Any( ) == true )
            {
                return $"SELECT * FROM { Source } WHERE { Criteria.ToCriteria( ) };";
            }
            else if( Columns == null
                && Criteria == null )
            {
                return $"SELECT * FROM { Source };";
            }

            return default( string );
        }

        /// <summary>
        /// Sets the select statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        public string CreateSelectStatement( IDictionary<string, object> dict )
        {
            if( Enum.IsDefined( typeof( Source ), Source )
                && dict?.Any( ) == true )
            {
                try
                {
                    string _criteria = dict.ToCriteria( );
                    return $"SELECT * FROM { Source } WHERE { _criteria };";
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
        public string CreateSelectStatement( IEnumerable<string> columnNames,
            IDictionary<string, object> dict )
        {
            if( Enum.IsDefined( typeof( Source ), Source )
                && dict?.Any( ) == true
                && columnNames?.Any( ) == true )
            {
                try
                {
                    string _cols = string.Empty;

                    foreach( string name in columnNames )
                    {
                        _cols += $"{name}, ";
                    }

                    string _criteria = dict.ToCriteria( );
                    string _columns = _cols.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT { _columns } FROM { Source } WHERE { _criteria} ;";
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
        /// <param name="updates">The dictionary.</param>
        /// <param name = "where" > </param>
        public string CreateUpdateStatement( IDictionary<string, object> updates,
            IDictionary<string, object> where )
        {
            if( updates?.Any( ) == true
                && where?.Any( ) == true
                && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    string _update = string.Empty;

                    if( updates.Count >= 2 )
                    {
                        foreach( KeyValuePair<string, object> kvp in updates )
                        {
                            _update += $"{ kvp.Key } = '{ kvp.Value }'";
                        }
                    }
                    else if( updates.Count == 1 )
                    {
                        foreach( KeyValuePair<string, object> kvp in updates )
                        {
                            _update += $"{ kvp.Key } = '{ kvp.Value }', ";
                        }
                    }

                    string _criteria = where.ToCriteria( );
                    string _values = _update.TrimEnd( ", ".ToCharArray( ) );
                    return $"{ SQL.UPDATE } { Source } SET { _values } WHERE { _criteria };";
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
        public string CreateInsertStatement( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true
                && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    string _column = string.Empty;
                    string _values = string.Empty;

                    foreach( KeyValuePair<string, object> kvp in dict )
                    {
                        _column += $"{ kvp.Key }, ";
                        _values += $"{ kvp.Value }, ";
                    }

                    string values =
                        $"({ _column.TrimEnd( ", ".ToCharArray( ) ) })" +
                        $" VALUES ({ _values.TrimEnd( ", ".ToCharArray( ) ) })";

                    return $"{ SQL.INSERT } INTO { Source } { values} ;";
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
        public string CreateDeleteStatement( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true
                && Enum.IsDefined( typeof( Source ), Source ) )
            {
                try
                {
                    string _columns = string.Empty;

                    foreach( KeyValuePair<string, object> kvp in dict )
                    {
                        _columns += $" { kvp.Key } = '{ kvp.Value }' AND";
                    }

                    string _values = _columns.TrimEnd( " AND".ToCharArray( ) );
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
            using( Error _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}