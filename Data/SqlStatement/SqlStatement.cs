// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
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
            Provider = provider;
            FilePath = GetFilePath( provider );
            Args = null;
            CommandText = GetSelectStatement( );
        }

        public SqlStatement( Source source, Provider provider, SQL commandType = SQL.SELECTALL ) 
            : this( source, provider )
        {
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
            Provider = connectionBuilder.Provider;
            FilePath = GetFilePath( Provider );
            Args = null;
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
            Provider = connectionBuilder.Provider;
            Args = dict;
            CommandText = GetSelectStatement( );
        }

        public SqlStatement( Source source, Provider provider, IDictionary<string, object> dict )
        {
            CommandType = SQL.SELECTALL;
            Source = source;
            Provider = provider;
            Args = dict;
            CommandText = GetSelectStatement( );
        }

        public SqlStatement( Source source, Provider provider, SQL commandType, IDictionary<string, object> dict )
        {
            CommandType = commandType;
            Source = source;
            Provider = provider;
            Args = dict;
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
            Args = dict;
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
    }
}