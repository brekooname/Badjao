// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.IO;
using System.Linq;
using System.Threading;
using System.Configuration;
using System.Diagnostics.CodeAnalysis;

namespace BudgetExecution
{
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
        public readonly EXT Extension = EXT.SQL;

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
        public virtual IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// The command text
        /// </summary>
        public virtual string CommandText { get; set; }

        /// <summary>
        /// The file path
        /// </summary>
        public virtual string FilePath { get; set; }

        /// <summary>
        /// The provider path
        /// </summary>
        public virtual NameValueCollection ProviderPath { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// The file name
        /// </summary>
        public virtual string FileName { get; set; }
        

        /// <summary>
        /// Gets the script files.
        /// </summary>
        /// <returns></returns>
        public virtual IDictionary<string, string> GetScriptFiles( )
        {
            if(  Enum.IsDefined( typeof( Provider ), Provider )
                && Enum.IsDefined( typeof( SQL ), CommandType ) )
            {
                try
                {
                    var _directory = ProviderPath[ $"{ Provider }" ] + $@"\{ CommandType }";
                    var _scriptFiles = new Dictionary<string, string>(  );
                    if( !string.IsNullOrEmpty( _directory )
                        && Directory.Exists( _directory ) )
                    {
                        var _scripts = Directory.GetFiles( _directory );
                        if( _scripts?.Any( ) == true )
                        {
                            foreach( var path in _scripts )
                            {
                                if( !string.IsNullOrEmpty( path ) )
                                {
                                    var _file = Path.GetFullPath( path );
                                    using( var stream = File.OpenRead( _file ) )
                                    {
                                        var _sqlText = new StreamReader( stream );
                                        _scriptFiles?.Add( Path.GetFileNameWithoutExtension( path ), _sqlText.ReadToEnd( ) );
                                    }
                                }
                            }

                            return _scriptFiles?.Any( ) == true
                                ? _scriptFiles
                                : default( IDictionary<string, string> );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, string> );
                }
            }

            return default( IDictionary<string, string> );
        }
        
        /// <summary>
        /// Sets the select statement.
        /// </summary>
        public virtual string GetSelectStatement( )
        {
            try
            {
                return CommandType == SQL.SELECTALL && Enum.IsDefined( typeof( Source ), Source )
                    ? $"SELECT * FROM { Source };"
                    : string.Empty;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return string.Empty;
            }
        }

        /// <summary>
        /// Sets the select statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        public virtual string GetSelectStatement( IDictionary<string, object> dict )
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
        /// Sets the update statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        public virtual string GetUpdateStatement( IDictionary<string, object> dict )
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
        public virtual string GetInsertStatement( IDictionary<string, object> dict )
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
        public virtual string GetDeleteStatement( IDictionary<string, object> dict )
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
        /// Sets the command text.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        public virtual string GetCommandText( IDictionary<string, object> dict, SQL commandType = SQL.SELECT )
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
                            var _queryText = GetSelectStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }

                        case SQL.UPDATE:
                        {
                            var _queryText = GetUpdateStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }

                        case SQL.INSERT:
                        {
                            var _queryText = GetInsertStatement( dict );

                            return !string.IsNullOrEmpty( _queryText )
                                ? _queryText
                                : string.Empty;
                        }

                        case SQL.DELETE:
                        {
                            var _queryText = GetDeleteStatement( dict );

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