// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class SqlBase
    {
        /// <summary>
        /// The extension
        /// </summary>
        public readonly EXT Extension = EXT.SQL;

        /// <summary>
        /// The connection builder
        /// </summary>
        public virtual IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// The command type
        /// </summary>
        public virtual SQL CommandType { get; set; }

        /// <summary>
        /// The arguments
        /// </summary>
        public virtual IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// The command text
        /// </summary>
        public virtual  string CommandText { get; set; }

        /// <summary>
        /// The file path
        /// </summary>
        public virtual string FilePath { get; set; }
        
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
                        _empty += $"{ _kvp.Key } = '{ _kvp.Value }' AND";
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
            if( dict?.Any( ) == true )
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
            if( dict?.Any( ) == true )
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
            if( dict?.Any( ) == true )
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

        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        public string GetFilePath( Provider provider )
        {
            if( Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    switch( provider )
                    {
                        case Provider.OleDb:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "OleDb" ];
                            break;
                        }
                        case Provider.Access:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "Access" ];
                            break;
                        }
                        case Provider.SQLite:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "SQLite" ];
                            break;
                        }
                        case Provider.SqlCe:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "SqlCe" ];
                            break;
                        }
                        case Provider.Excel:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "Excel" ];
                            break;
                        }
                        case Provider.SqlServer:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "SqlServer" ];
                            break;
                        }
                        case Provider.CSV:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "CSV" ];
                            break;
                        }
                        default:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "SQLite" ];
                            break;
                        }
                    }

                    return !string.IsNullOrEmpty( FilePath )
                        ? FilePath
                        : string.Empty;
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
        /// <param name="command">The provider.</param>
        /// <returns></returns>
        public string GetFilePath( SQL command )
        {
            if( Enum.IsDefined( typeof( SQL ), command ) )
            {
                try
                {
                    switch( command )
                    {
                        case SQL.ALTERTABLE:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "ALTERTABLE" ];
                            break;
                        }
                        case SQL.CREATETABLE:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "CREATETABLE" ];
                            break;
                        }
                        case SQL.CREATEDATABASE:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "CREATEDATABASE" ];
                            break;
                        }
                        case SQL.CREATEVIEW:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "CREATEVIEW" ];
                            break;
                        }
                        case SQL.DETACH:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "DETACH" ];
                            break;
                        }
                        case SQL.DELETE:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "DELETE" ];
                            break;
                        }
                        case SQL.SELECTALL:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "SELECTALL" ];
                            break;
                        }
                        case SQL.SELECT:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "SELECT" ];
                            break;
                        }
                        case SQL.INSERT:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "INSERT" ];
                            break;
                        }
                        case SQL.UPDATE:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "UPDATE" ];
                            break;
                        }
                        default:
                        {
                            FilePath = ConfigurationManager.AppSettings[ "SELECTALL" ];
                            break;
                        }
                    }

                    return !string.IsNullOrEmpty( FilePath )
                        ? FilePath
                        : string.Empty;
                }
                catch( Exception ex )
                {
                    Fail( ex );
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