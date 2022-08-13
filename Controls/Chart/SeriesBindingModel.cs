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
    /// <seealso cref="SourceModel" />
    /// <seealso cref="ISeriesModel" />
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" )]
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    public class SeriesModel : SeriesBase, ISeriesModel
    {
        /// <summary>
        /// Gets or sets the series values.
        /// </summary>
        /// <value>
        /// The series values.
        /// </value>
        public IEnumerable<double> Values { get; set; }

        /// <summary>
        /// Gets or sets the series categories.
        /// </summary>
        /// <value>
        /// The series categories.
        /// </value>
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the source model.
        /// </summary>
        /// <value>
        /// The source model.
        /// </value>
        public ISeries SourceModel { get; set; }

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
            ChartBinding = new ChartBinding( bindingSource );
            Data = ChartBinding.Data;
            SeriesConfig = ChartBinding.SeriesConfig;
            Stat = SeriesConfig.ValueMetric;
            DataMetric = new DataMetric( bindingSource );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            Values = GetSeriesValues( );
            BindingModel.Changed += OnChanged;
        }

        public SeriesModel( DataTable dataTable )
            : base( dataTable )
        {
            ChartBinding = new ChartBinding( dataTable );
            Data = ChartBinding.Data;
            SeriesConfig = ChartBinding.SeriesConfig;
            Stat = SeriesConfig.ValueMetric;
            DataMetric = new DataMetric( Data );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            Values = GetSeriesValues( );
            BindingModel.Changed += OnChanged;
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
            ChartBinding = chartBinding;
            Data = chartBinding.Data;
            SeriesConfig = chartBinding.SeriesConfig;
            Stat = SeriesConfig.ValueMetric;
            DataMetric = new DataMetric( Data );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            Values = GetSeriesValues( );
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesModel"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        public SeriesModel( IEnumerable<DataRow> dataRows )
            : base( dataRows )
        {
            ChartBinding = new ChartBinding( dataRows );
            Data = dataRows;
            SeriesConfig = ChartBinding.SeriesConfig;
            Stat = SeriesConfig.ValueMetric;
            DataMetric = new DataMetric( Data );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            Values = GetSeriesValues( );
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesModel" /> class.
        /// </summary>
        /// <param name="dataTable">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public SeriesModel( DataTable dataTable, ISeriesConfig seriesConfig )
            : base( dataTable, seriesConfig )
        {
            ChartBinding = new ChartBinding( dataTable, seriesConfig );
            Data = dataTable.AsEnumerable( )?.ToList( );
            SeriesConfig = seriesConfig;
            Stat = seriesConfig.ValueMetric;
            DataMetric = new DataMetric( Data );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            Values = GetSeriesValues( );
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesModel" /> class.
        /// </summary>
        /// <param name="dataRows">The data.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public SeriesModel( IEnumerable<DataRow> dataRows, ISeriesConfig seriesConfig )
            : base( dataRows, seriesConfig )
        {
            ChartBinding = new ChartBinding( dataRows, seriesConfig );
            Data = dataRows;
            SeriesConfig = ChartBinding.SeriesConfig;
            Stat = seriesConfig.ValueMetric;
            DataMetric = new DataMetric( Data );
            SeriesData = DataMetric.CalculateStatistics( );
            Categories = SeriesData.Keys;
            Values = GetSeriesValues( );
            BindingModel.Changed += OnChanged;
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
                    ?.SelectMany( v => v );

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
        public ISeries GetSourceModel( )
        {
            try
            {
                return (SeriesBase)MemberwiseClone( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ISeries );
            }
        }
    }
}