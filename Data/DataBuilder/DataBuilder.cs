// <copyright file = "DataBuilder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    /// <summary> </summary>
    /// <seealso cref = "DataModel" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public class DataBuilder : DataModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        public DataBuilder( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        /// <param name = "source" > The source. </param>
        /// <param name = "provider" > The provider. </param>
        public DataBuilder( Source source, Provider provider = Provider.SQLite )
            : base( source, provider )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        /// <param name = "source" > The source. </param>
        /// <param name = "provider" > The provider. </param>
        /// <param name = "args" > The arguments. </param>
        public DataBuilder( Source source, Provider provider, IDictionary<string, object> args )
            : base( source, provider, args )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        /// <param name = "source" > The source. </param>
        /// <param name = "dict" > The dictionary. </param>
        public DataBuilder( Source source, IDictionary<string, object> dict )
            : base( source, dict )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        /// <param name = "query" > The query. </param>
        public DataBuilder( IQuery query )
            : base( query )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "DataBuilder" />
        /// class.
        /// </summary>
        /// <param name = "row" > The row. </param>
        public DataBuilder( DataRow row )
        {
            Record = row;
        }
        
        /// <summary> Filters the Data. </summary>
        /// <param name = "name" > The field. </param>
        /// <param name = "value" > The filter. </param>
        /// <returns> </returns>
        public IEnumerable<DataRow> FilterData( Field name, string value )
        {
            if( Enum.IsDefined( typeof( Field ), name.ToString( ) )
                && !string.IsNullOrEmpty( value ) )
            {
                try
                {
                    var _dataRows = GetData( )
                            ?.Where( p => p.Field<string>( $"{ name }" ).Equals( value ) )
                            ?.Select( p => p );

                    return _dataRows?.Any( ) == true
                        ? _dataRows.ToArray( )
                        : default( DataRow[ ] );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }

        public IEnumerable<DataRow> FilterData( IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    var _query = string.Empty;
                    
                    foreach( var kvp in dict )
                    {
                        _query += $"{ kvp.Key } = '{ kvp.Value }' AND ";
                    }
                     var _criteria = _query.TrimEnd( " AND ".ToCharArray(  ) );
                    var _data = DataTable?.Select( _criteria );

                    return _data?.Length > 0
                        ? _data
                        : default( IEnumerable<DataRow> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }

        /// <summary>
        /// Filters the data.
        /// </summary>
        /// <param name="name">The field.</param>
        /// <param name="value">The filter.</param>
        /// <returns></returns>
        public IEnumerable<DataRow> FilterData( string name, string value )
        {
            if( !string.IsNullOrEmpty( name ) 
                && !string.IsNullOrEmpty( value ) )
            {
                try
                {
                    var _dataRows = DataTable.Select( $"{ name } = { value }" );

                    return _dataRows?.Any( ) == true
                        ? _dataRows.ToArray( )
                        : default( DataRow[ ] );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }
    }
}