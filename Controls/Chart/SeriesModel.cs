// <copyright file = "SeriesModel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ISeriesModel" />
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" )]
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    public class SeriesModel : DataBindingModelBase, ISeriesModel
    {
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SeriesModel" />
        /// class.
        /// </summary>
        public SeriesModel( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SeriesModel" />
        /// class.
        /// </summary>
        public SeriesModel( BindingSource bindingSource ) 
            : base( bindingSource )
        {
            Categories = SeriesData.Keys;
            Values = GetSeriesValues( );
        }

        public SeriesModel( DataTable dataTable )
            : base( dataTable )
        {
            Values = GetSeriesValues( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SeriesModel" />
        /// class.
        /// </summary>
        /// <param name="chartBinding"></param>
        public SeriesModel( IChartBinding chartBinding ) 
            : base( chartBinding )
        {
            Values = GetSeriesValues( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesModel"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        public SeriesModel( IEnumerable<DataRow> dataRows )
            : base( dataRows )
        {
            Values = GetSeriesValues( );
        }
        
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<double> GetSeriesValues( )
        {
            try
            {
                var _values = SeriesData
                    ?.Values
                    ?.Select( v => v );

                return _values?.Any( ) == true
                    ? _values.ToArray( )
                    : default( double[ ] );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<double> );
            }
        }
        
        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <returns></returns>
        public ISeriesModel GetSeriesModel( )
        {
            try
            {
                return (SeriesModel)MemberwiseClone( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ISeriesModel );
            }
        }
    }
}