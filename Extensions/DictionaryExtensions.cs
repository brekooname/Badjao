// <copyright file = "DictionaryExtensions.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary> </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public static class DictionaryExtensions
    {
        /// <summary> Adds the or update. </summary>
        /// <typeparam name = "TKey" > The type of the key. </typeparam>
        /// <typeparam name = "TValue" > The type of the value. </typeparam>
        /// <param name = "dict" > The dictionary. </param>
        /// <param name = "key" > The key. </param>
        /// <param name = "value" > The value. </param>
        /// <returns> </returns>
        public static TValue AddOrUpdate<TKey, TValue>( this IDictionary<TKey, TValue> dict,
            TKey key, TValue value )
        {
            if( !dict.ContainsKey( key ) )
            {
                try
                {
                    dict.Add( new KeyValuePair<TKey, TValue>( key, value ) );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( TValue );
                }
            }
            else
            {
                dict[ key ] = value;
            }

            return dict[ key ];
        }

        /// <summary>
        /// Predicates the specified logic.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public static string ToCriteria( this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    string _criteria = "";

                    if( dict.HasPrimaryKey( ) )
                    {
                        KeyValuePair<string, object> _key = dict.GetPrimaryKey( );

                        if( !string.IsNullOrEmpty( _key.Key )
                            & int.Parse( _key.Value.ToString( ) ) > -1 )
                        {
                            foreach( KeyValuePair<string, object> kvp in dict )
                            {
                                _criteria += $"{kvp.Key} = '{kvp.Value}' AND ";
                            }

                            string _sql = _criteria.TrimEnd( " AND ".ToCharArray( ) );
                            _sql += $" WHERE {_key.Key} = {int.Parse( _key.Value.ToString( ) )};";

                            return !string.IsNullOrEmpty( _sql )
                                ? _sql
                                : string.Empty;
                        }
                    }
                    else if( !dict.HasPrimaryKey( ) )
                    {
                        foreach( KeyValuePair<string, object> kvp in dict )
                        {
                            _criteria += $"{kvp.Key} = '{kvp.Value}' AND ";
                        }

                        string _sql = _criteria.TrimEnd( " AND ".ToCharArray( ) );

                        return !string.IsNullOrEmpty( _sql )
                            ? _sql
                            : string.Empty;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary> Converts to sorteddictionary. </summary>
        /// <typeparam name = "TKey" > The type of the key. </typeparam>
        /// <typeparam name = "TValue" > The type of the value. </typeparam>
        /// <param name = "nvc" > The this. </param>
        /// <returns> </returns>
        public static SortedDictionary<TKey, TValue> ToSortedDictionary<TKey, TValue>(
            this IDictionary<TKey, TValue> nvc )
        {
            try
            {
                return new SortedDictionary<TKey, TValue>( nvc );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( SortedDictionary<TKey, TValue> );
            }
        }

        /// <summary>
        /// Converts to bindinglist.
        /// </summary>
        /// <param name="nvc">The NVC.</param>
        /// <returns></returns>
        public static BindingList<KeyValuePair<string, object>> ToBindingList(
            this IDictionary<string, object> nvc )
        {
            try
            {
                BindingList<KeyValuePair<string, object>> _bindingList =
                    new BindingList<KeyValuePair<string, object>>( );

                foreach( KeyValuePair<string, object> kvp in nvc )
                {
                    _bindingList.Add( kvp );
                }

                return _bindingList?.Any( ) == true
                    ? _bindingList
                    : default( BindingList<KeyValuePair<string, object>> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( BindingList<KeyValuePair<string, object>> );
            }
        }

        /// <summary> Converts to sorteddictionary. </summary>
        /// <typeparam name = "TKey" > The type of the key. </typeparam>
        /// <typeparam name = "TValue" > The type of the value. </typeparam>
        /// <param name = "dict" > The dictionary. </param>
        /// <returns> </returns>
        public static SortedList<TKey, TValue> ToSortedList<TKey, TValue>(
            this IDictionary<TKey, TValue> dict )
        {
            try
            {
                return new SortedList<TKey, TValue>( dict );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( SortedList<TKey, TValue> );
            }
        }

        /// <summary> Converts to sqldbparameters. </summary>
        /// <param name = "dict" > The dictionary. </param>
        /// <param name = "provider" > The provider. </param>
        /// <returns> </returns>
        public static IEnumerable<DbParameter> ToSqlDbParameters(
            this IDictionary<string, object> dict, Provider provider )
        {
            if( dict?.Keys?.Count > 0
                && Enum.IsDefined( typeof( Provider ), provider ) )
            {
                try
                {
                    string[ ] _columns = dict.Keys.ToArray( );
                    object[ ] _values = dict.Values.ToArray( );

                    switch( provider )
                    {
                        case Provider.NS:
                        case Provider.SQLite:

                        {
                            List<SQLiteParameter> _sqlite = new List<SQLiteParameter>( );

                            for( int i = 0; i < _columns.Length; i++ )
                            {
                                SQLiteParameter _parameter = new SQLiteParameter
                                    { SourceColumn = _columns[ i ], Value = _values[ i ] };

                                _sqlite.Add( _parameter );
                            }

                            return _sqlite.Any( )
                                ? _sqlite.ToArray( )
                                : default( SQLiteParameter[ ] );
                        }

                        case Provider.SqlCe:

                        {
                            List<SqlCeParameter> _sqlce = new List<SqlCeParameter>( );

                            for( int i = 0; i < _columns.Length; i++ )
                            {
                                SqlCeParameter _parameter = new SqlCeParameter
                                    { SourceColumn = _columns[ i ], Value = _values[ i ] };

                                _sqlce.Add( _parameter );
                            }

                            return _sqlce.Any( )
                                ? _sqlce.ToArray( )
                                : default( SqlCeParameter[ ] );
                        }

                        case Provider.OleDb:
                        case Provider.Excel:
                        case Provider.Access:

                        {
                            List<OleDbParameter> _oledb = new List<OleDbParameter>( );

                            for( int i = 0; i < _columns.Length; i++ )
                            {
                                OleDbParameter _parameter = new OleDbParameter
                                    { SourceColumn = _columns[ i ], Value = _values[ i ] };

                                _oledb.Add( _parameter );
                            }

                            return _oledb.Any( )
                                ? _oledb.ToArray( )
                                : default( OleDbParameter[ ] );
                        }

                        case Provider.SqlServer:

                        {
                            List<SqlParameter> _sqlserver = new List<SqlParameter>( );

                            for( int i = 0; i < _columns.Length; i++ )
                            {
                                SqlParameter _parameter = new SqlParameter
                                    { SourceColumn = _columns[ i ], Value = _values[ i ] };

                                _sqlserver.Add( _parameter );
                            }

                            return _sqlserver?.Any( ) == true
                                ? _sqlserver.ToArray( )
                                : default( SqlParameter[ ] );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DbParameter> );
                }

                return default( IEnumerable<DbParameter> );
            }

            return default( IEnumerable<DbParameter> );
        }

        /// <summary> Determines whether [has a primary key]. </summary>
        /// <param name = "dict" > The row. </param>
        /// <returns>
        /// <c> true </c>
        /// if [has primary key] [the specified row]; otherwise,
        /// <c> false </c>
        /// .
        /// </returns>
        public static bool HasPrimaryKey( this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    string[ ] _array = dict.Keys?.ToArray( );
                    string[ ] _names = Enum.GetNames( typeof( PrimaryKey ) );
                    int _count = 0;

                    for( int i = 1; i < _array.Length; i++ )
                    {
                        string _name = _array[ i ];

                        if( _names.Contains( _name ) )
                        {
                            _count++;
                        }
                    }

                    return _count > 0;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( bool );
                }
            }

            return false;
        }

        /// <summary>
        /// Gets the primary key.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public static KeyValuePair<string, object> GetPrimaryKey(
            this IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true
                && dict.HasPrimaryKey( ) )
            {
                try
                {
                    string[ ] _names = Enum.GetNames( typeof( PrimaryKey ) );

                    foreach( KeyValuePair<string, object> kvp in dict )
                    {
                        if( _names.Contains( kvp.Key ) )
                        {
                            return new KeyValuePair<string, object>( kvp.Key, kvp.Value );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( KeyValuePair<string, object> );
                }
            }

            return default( KeyValuePair<string, object> );
        }

        /// <summary>Fails the specified ex.</summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using( Error _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}