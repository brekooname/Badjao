﻿// <copyright file = "SeriesModel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SourceModel" />
    /// <seealso cref="ISeriesModel" />
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" )]
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    public class SeriesModel : SourceModel, ISeriesModel
    {
        /// <summary>
        /// Gets or sets the series configuration.
        /// </summary>
        /// <value>
        /// The series configuration.
        /// </value>
        public ISeriesConfig SeriesConfiguration { get; set; }

        /// <summary>
        /// Gets or sets the series metric.
        /// </summary>
        /// <value>
        /// The series metric.
        /// </value>
        public IDataMetric DataMetric { get; set; }

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
        public ISourceModel SourceModel { get; set; }

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
        public SeriesModel( System.Windows.Forms.BindingSource bindingSource )
        {
            ChartBinding = new ChartBinding( bindingSource );
            SourceModel = new SourceModel( ChartBinding );
            BindingModel = new ChartDataBindModel( ChartBinding );
            SourceData = SourceModel.SourceData;
            SeriesConfiguration = ChartBinding.SeriesConfiguration;
            Stat = SeriesConfiguration.Stat;
            DataMetric = new DataMetric( bindingSource );
            SeriesData = DataMetric.CalculateStatistics( );
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="SeriesModel" />
        /// class.
        /// </summary>
        /// <param name="chartBinding"></param>
        public SeriesModel( IChartBinding chartBinding )
        {
            ChartBinding = chartBinding;
            SourceModel = new SourceModel( chartBinding );
            BindingModel = new ChartDataBindModel( ChartBinding );
            SourceData = chartBinding.Data;
            SeriesConfiguration = chartBinding.SeriesConfiguration;
            Stat = SeriesConfiguration.Stat;
            DataMetric = new DataMetric( SourceData );
            SeriesData = DataMetric.CalculateStatistics( );
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
            BindingModel = new ChartDataBindModel( ChartBinding );
            SourceModel = new SourceModel( ChartBinding );
            SourceData = ChartBinding.Data;
            SeriesConfiguration = seriesConfig;
            Stat = seriesConfig.Stat;
            DataMetric = new DataMetric( SourceData );
            SeriesData = DataMetric.CalculateStatistics( );
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
            BindingModel = new ChartDataBindModel( ChartBinding );
            SourceModel = new SourceModel( ChartBinding );
            SourceData = ChartBinding.Data;
            SeriesConfiguration = ChartBinding.SeriesConfiguration;
            Stat = seriesConfig.Stat;
            DataMetric = ChartBinding.Metric;
            SeriesData = DataMetric.CalculateStatistics( );
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Gets the data metric.
        /// </summary>
        /// <returns></returns>
        public IDataMetric GetSeriesMetric()
        {
            try
            {
                return Metric;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDataMetric );
            }
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
        /// Gets the series categories.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetSeriesCategories( )
        {
            try
            {
                var _values = SeriesData?.Keys;

                return _values?.Any( ) == true
                    ? _values.ToArray( )
                    : default( string[ ] );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<string> );
            }
        }

        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <returns></returns>
        public ISourceModel GetSourceModel( )
        {
            try
            {
                return (SourceModel)MemberwiseClone( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ISourceModel );
            }
        }
    }
}