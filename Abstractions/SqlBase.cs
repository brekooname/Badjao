﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" )]
    public abstract class SqlBase
    {
        /// <summary>
        /// The connection builder
        /// </summary>
        public IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// The command type
        /// </summary>
        public SQL CommandType { get; set; }

        /// <summary>
        /// The arguments
        /// </summary>
        public IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// The command text
        /// </summary>
        public string CommandText { get; set; }

        /// <summary>
        /// Sets the connection builder.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        protected void SetConnectionBuilder( Source source, Provider provider )
        {
            try
            {
                ConnectionBuilder = Enum.IsDefined( typeof( Source ), source ) 
                    && Enum.IsDefined( typeof( Provider ), provider )
                        ? new ConnectionBuilder( source, provider )
                        : default( ConnectionBuilder );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the arguments.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        protected void SetArgs( IDictionary<string, object> dict )
        {
            try
            {
                Args = dict?.Any( ) == true
                    ? dict
                    : new Dictionary<string, object>( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the type of the command.
        /// </summary>
        /// <param name="commandType">Type of the command.</param>
        protected void SetCommandType( SQL commandType )
        {
            try
            {
                CommandType = Enum.IsDefined( typeof( SQL ), commandType )
                    && Enum.GetNames( typeof( SQL ) ).Contains( commandType.ToString( ) )
                        ? commandType
                        : SQL.SELECT;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the select statement.
        /// </summary>
        protected void SetSelectStatement( )
        {
            try
            {
                CommandText = !string.IsNullOrEmpty( ConnectionBuilder?.ConnectionString )
                    ? $"{ SQL.SELECT } * FROM { ConnectionBuilder?.TableName };"
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the select statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        protected void SetSelectStatement( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _empty = string.Empty;

                    foreach( var _kvp in dict )
                    {
                        _empty += $" { _kvp.Key } = '{ _kvp.Value }' AND";
                    }

                    var _values = _empty.TrimEnd( " AND".ToCharArray( ) );
                    var _tableName = ConnectionBuilder?.TableName;
                    CommandText = $"{ SQL.SELECT } * FROM { _tableName } WHERE { _values };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
            else if( dict == null )
            {
                CommandText = $"{ SQL.SELECT } * FROM { ConnectionBuilder?.TableName };";
            }
        }

        /// <summary>
        /// Sets the update statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        protected void SetUpdateStatement( IDictionary<string, object> dict )
        {
            if( Verify.IsMap( dict ) )
            {
                try
                {
                    var _update = string.Empty;

                    foreach( var kvp in dict )
                    {
                        _update += $" {kvp.Key} = '{kvp.Value}' AND";
                    }

                    var _vals = _update.TrimEnd( " AND".ToCharArray( ) );
                    CommandText = $"{ SQL.UPDATE } { ConnectionBuilder?.TableName } SET { _vals };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the insert statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        protected void SetInsertStatement( IDictionary<string, object> dict )
        {
            if( Verify.IsMap( dict ) )
            {
                try
                {
                    var _table = ConnectionBuilder?.TableName;
                    var _column = string.Empty;
                    var _values = string.Empty;

                    foreach( var kvp in dict )
                    {
                        _column += $"{ kvp.Key }, ";
                        _values += $"{ kvp.Value }, ";
                    }

                    var values =
                        $"({ _column.TrimEnd( ", ".ToCharArray( ) ) }) VALUES ({ _values.TrimEnd( ", ".ToCharArray( ) ) })";

                    CommandText = $"{ SQL.INSERT } INTO { _table } { values };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the delete statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        protected void SetDeleteStatement( IDictionary<string, object> dict )
        {
            if( Verify.IsMap( dict ) )
            {
                try
                {
                    var _columns = string.Empty;

                    foreach( var kvp in dict )
                    {
                        _columns += $" { kvp.Key } = '{ kvp.Value }' AND";
                    }

                    var _values = _columns.TrimEnd( " AND".ToCharArray( ) );
                    var _table = ConnectionBuilder?.TableName;
                    CommandText = $"{ SQL.DELETE } FROM { _table } WHERE { _values };";
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
            else if( dict == null )
            {
                CommandText = $"{ SQL.DELETE } * FROM { ConnectionBuilder?.TableName };";
            }
        }

        /// <summary>
        /// Sets the command text.
        /// </summary>
        /// <param name="sql">The SQL.</param>
        protected void SetCommandText( string sql )
        {
            try
            {
                CommandText = !string.IsNullOrEmpty( sql )
                    ? sql
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the command text.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        public void SetCommandText( IDictionary<string, object> dict, SQL commandType = SQL.SELECT )
        {
            if( dict == null
                && !string.IsNullOrEmpty( ConnectionBuilder?.ConnectionString ) )
            {
                SetSelectStatement( );
            }
            else if( Verify.IsMap( dict ) )
            {
                try
                {
                    switch( commandType )
                    {
                        case SQL.SELECT:
                        {
                            SetSelectStatement( dict );
                            break;
                        }

                        case SQL.UPDATE:
                        {
                            SetUpdateStatement( dict );
                            break;
                        }

                        case SQL.INSERT:
                        {
                            SetInsertStatement( dict );
                            break;
                        }

                        case SQL.DELETE:
                        {
                            SetDeleteStatement( dict );
                            break;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
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