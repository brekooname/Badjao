﻿// <copyright file = "Arg.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
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
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnassignedGetOnlyAutoProperty" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeMadeStatic.Global" ) ]
    public abstract class Arg : DataUnit
    {
        /// <summary>
        /// The values
        /// </summary>
        public IEnumerable<object> Values { get; set; }

        /// <summary>
        /// The names
        /// </summary>
        public IEnumerable<string> Names { get; set; }

        /// <summary>
        /// The input
        /// </summary>
        public IDictionary<string, object> Input { get; set; }

        /// <summary>
        /// The output
        /// </summary>
        public IDictionary<string, object> Output { get; set; }

        /// <summary>
        /// Sets the input.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        protected void SetInput( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    Dictionary<string, object> _dict = new Dictionary<string, object>( );
                    string[ ] _fields = Enum.GetNames( typeof( Field ) );

                    foreach( KeyValuePair<string, object> kvp in dict )
                    {
                        if( !string.IsNullOrEmpty( kvp.Key )
                            && _fields?.Contains( kvp.Key ) == true )
                        {
                            _dict?.Add( kvp.Key, kvp.Value );
                        }
                    }

                    Input = _dict?.Any( ) == true && _dict != Output
                        ? _dict
                        : default( Dictionary<string, object> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the output.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        protected void SetOutput( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    Dictionary<string, object> _dictionary = new Dictionary<string, object>( );

                    if( Values?.Any( ) == true )
                    {
                        object[ ] data = Values.ToArray( );

                        foreach( KeyValuePair<string, object> kvp in dict )
                        {
                            for( int i = 0; i < data.Length; i++ )
                            {
                                if( kvp.Key.Contains( data[ i ].ToString( ) ) )
                                {
                                    _dictionary?.Add( kvp.Key, kvp.Value );
                                }
                            }
                        }

                        Output = _dictionary?.Any( ) == true
                            ? _dictionary
                            : default( Dictionary<string, object> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the values.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetValues( )
        {
            if( Output?.Any( ) == true )
            {
                try
                {
                    object[ ] _array = Output?.Values?.ToArray( );
                    IEnumerable<string> _enumerable = _array?.Select( o => o.ToString( ) );
                    string[ ] _fields = Enum.GetNames( typeof( Field ) );
                    List<string> _list = new List<string>( );

                    if( _enumerable?.Any( ) == true
                        && _fields?.Any( ) == true )
                    {
                        foreach( string value in _enumerable )
                        {
                            if( !string.IsNullOrEmpty( value )
                                && _fields.Contains( value ) )
                            {
                                _list.Add( value );
                            }
                        }
                    }

                    return _enumerable?.Any( ) == true
                        ? _enumerable
                        : default( IEnumerable<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }

        /// <summary>
        /// Gets the names.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetNames( )
        {
            if( Output?.Any( ) == true )
            {
                try
                {
                    ICollection<string> _keys = Output?.Keys;
                    string[ ] _fields = Enum.GetNames( typeof( Field ) );
                    List<string> _list = new List<string>( );

                    if( _keys?.Any( ) == true )
                    {
                        foreach( string key in _keys )
                        {
                            if( !string.IsNullOrEmpty( key )
                                && _fields.Contains( key ) )
                            {
                                _list.Add( key );
                            }
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list
                        : default( List<string> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }
    }
}