// <copyright file = "SourceModel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ChartDataBindModel" />
    /// <seealso cref="ISourceModel" />
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" )]
    public class SourceModel : ChartDataBindModel, ISourceModel
    {
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IEnumerable<DataRow> SourceData { get; set; }

        /// <summary>
        /// Gets or sets the chart binding.
        /// </summary>
        /// <value>
        /// The chart binding.
        /// </value>
        public IChartBinding ChartBinding { get; set; }

        /// <summary>
        /// Gets the binding model.
        /// </summary>
        /// <value>
        /// The binding model.
        /// </value>
        public ChartDataBindModel BindingModel { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public IDataMetric Metric { get; set; }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public ISeriesConfig Configuration { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public STAT Stat { get; set; }

        /// <summary>
        /// Gets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        public IDictionary<string, IEnumerable<double>> SeriesData { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="SourceModel" /> class.
        /// </summary>
        public SourceModel()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public SourceModel( IEnumerable<DataRow> data, ISeriesConfig seriesConfig )
        {
            ChartBinding = new ChartBinding( data, seriesConfig );
            BindingModel = new ChartDataBindModel( data, seriesConfig?.Field.ToString( ) );
            SourceData = ChartBinding.Data;
            Configuration = ChartBinding?.SeriesConfiguration;
            Stat = Configuration.Stat;
            Metric = ChartBinding?.Metric;
            SeriesData = Metric?.CalculateStatistics( );
            BindingModel.Changed += OnChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> class.
        /// </summary>
        /// <param name="dataTable">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public SourceModel( DataTable dataTable, ISeriesConfig seriesConfig )
        {
            ChartBinding = new ChartBinding( dataTable?.AsEnumerable( ), seriesConfig );
            BindingModel = new ChartDataBindModel( dataTable, seriesConfig?.Field.ToString( ) );
            SourceData = ChartBinding.Data;
            Configuration = ChartBinding?.SeriesConfiguration;
            Stat = Configuration.Stat;
            Metric = ChartBinding?.Metric;
            SeriesData = Metric?.CalculateStatistics( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> struct.
        /// </summary>
        /// <param name="chartBinding">The binding source.</param>
        public SourceModel( IChartBinding chartBinding )
        {
            ChartBinding = chartBinding;
            BindingModel = new ChartDataBindModel( chartBinding );
            SourceData = chartBinding.Data;
            Configuration = chartBinding.SeriesConfiguration;
            Stat = Configuration.Stat;
            Metric = chartBinding.Metric;
            SeriesData = Metric?.CalculateStatistics( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SourceModel" /> struct.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public SourceModel( System.Windows.Forms.BindingSource bindingSource )
        {
            ChartBinding = new ChartBinding( bindingSource );
            BindingModel = new ChartDataBindModel( bindingSource );
            SourceData = ChartBinding.Data;
            Configuration = ChartBinding.SeriesConfiguration;
            Stat = Configuration.Stat;
            Metric = ChartBinding.Metric;
            SeriesData = Metric?.CalculateStatistics( );
        }

        /// <summary>
        /// Called when [changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public void OnChanged( object sender, EventArgs e )
        {
            if( sender != null
                && e != null )
            {
                try
                {
                    var message = new Message( "NOT YET IMPLEMENTED" );
                    message?.ShowDialog( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        
        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
        protected void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}