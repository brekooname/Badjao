﻿// <copyright file = "DataBuilder.cs" company = "Terry D. Eppler">
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
    /// <seealso cref = "Builder" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public class DataBuilder : Builder
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
        /// <param name = "field" > The field. </param>
        /// <param name = "filter" > The filter. </param>
        /// <returns> </returns>
        public IEnumerable<DataRow> FilterData( Field field, string filter )
        {
            if( Validate.IsField( field )
                && !string.IsNullOrEmpty( filter ) )
            {
                try
                {
                    var _dataRows = GetData( )
                            ?.Where( p => p.Field<string>( $"{field}" ).Equals( filter ) )
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
    }
}