// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
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
        public string DbClientPath { get; set; }

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
        protected SqlBase( Source source, Provider provider, string sqlText, SQL commandType = SQL.SELECT )
        {
            DbClientPath = new ConnectionBuilder( source, provider ).DbPath;
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
            Updates = null;
            Criteria = dict;
            Columns = null;
        }

        protected SqlBase( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> criteria, SQL commandType = SQL.UPDATE )
        {
            DbClientPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = Source.ToString( );
            Updates = updates;
            Criteria = criteria;
            Columns = updates.Keys;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlBase"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="criteria">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        protected SqlBase( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> criteria, SQL commandType = SQL.SELECT )
        {
            DbClientPath = new ConnectionBuilder( source, provider ).DbPath;
            CommandType = commandType;
            Source = source;
            Provider = provider;
            TableName = Source.ToString( );
            Updates = null;
            Criteria = criteria;
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
                    var _columns = string.Empty;

                    foreach( var col in Columns )
                    {
                        _columns += $"{ col }, ";
                    }
                    
                    var _cols = _columns.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT { _cols } FROM { Source } WHERE { Criteria.ToCriteria( ) };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }
            else if( Columns == null && Criteria?.Any( ) == true )
            {
                return $"SELECT * FROM { Source } WHERE { Criteria.ToCriteria( ) };";
            }
            else if( Columns == null && Criteria == null )
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
                    var _criteria = dict.ToCriteria(  );
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
        public string CreateSelectStatement( IEnumerable<string> columnNames, IDictionary<string, object> dict )
        {
            if( Enum.IsDefined( typeof( Source ), Source )
                && dict?.Any( ) == true 
                && columnNames?.Any( ) == true )
            {
                try
                {
                    var _cols = string.Empty;
                    foreach( var name in columnNames )
                    {
                        _cols += $"{ name }, ";
                    }

                    var _criteria = dict.ToCriteria(  );
                    var _columns = _cols.TrimEnd( ", ".ToCharArray( ) );
                    return $"SELECT { _columns } FROM { Source } WHERE { _criteria };";
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
                    var _update = string.Empty;
                    if ( updates.Count >= 2 )
                    {
                        foreach( var kvp in updates )
                        {
                            _update += $"{kvp.Key} = '{kvp.Value}'";
                        }
                    }
                    else if( updates.Count == 1 )
                    {
                        foreach( var kvp in updates )
                        {
                            _update += $"{kvp.Key} = '{kvp.Value}', ";
                        }
                    }

                    var _criteria = where.ToCriteria(  );
                    var _values = _update.TrimEnd( ", ".ToCharArray( ) );
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
        public string CreateDeleteStatement( IDictionary<string, object> dict )
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