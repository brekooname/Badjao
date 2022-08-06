// <copyright file = "SourceModel.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ChartDataBindModel" />
    /// <seealso cref="ISeries" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class SeriesBase : ChartDataBindModel, ISeries
    {
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public virtual IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets or sets the chart binding.
        /// </summary>
        /// <value>
        /// The chart binding.
        /// </value>
        public virtual IChartBinding ChartBinding { get; set; }

        /// <summary>
        /// Gets the binding model.
        /// </summary>
        /// <value>
        /// The binding model.
        /// </value>
        public virtual ChartDataBindModel BindingModel { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public virtual IDataMetric DataMetric { get; set; }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public virtual ISeriesConfig SeriesConfig { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        public virtual STAT Stat { get; set; }

        /// <summary>
        /// Gets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        public virtual IDictionary<string, double> SeriesData { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="SeriesBase" /> class.
        /// </summary>
        protected SeriesBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesBase" /> struct.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        protected SeriesBase( BindingSource bindingSource )
        {
            ChartBinding = new ChartBinding( bindingSource );
            BindingModel = new ChartDataBindModel( bindingSource );
            Data = ChartBinding.Data;
            SeriesConfig = ChartBinding.SeriesConfig;
            Stat = SeriesConfig.ValueMetric;
            DataMetric = ChartBinding.DataMetric;
            SeriesData = DataMetric?.CalculateStatistics( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesBase"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        protected SeriesBase( DataTable dataTable )
        {
            ChartBinding = new ChartBinding( dataTable );
            BindingModel = new ChartDataBindModel( dataTable );
            Data = ChartBinding.Data;
            SeriesConfig = ChartBinding.SeriesConfig;
            Stat = SeriesConfig.ValueMetric;
            DataMetric = ChartBinding.DataMetric;
            SeriesData = DataMetric?.CalculateStatistics( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesBase"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        protected SeriesBase( IEnumerable<DataRow> dataRows )
        {
            ChartBinding = new ChartBinding( dataRows );
            BindingModel = new ChartDataBindModel( dataRows );
            Data = ChartBinding.Data;
            SeriesConfig = ChartBinding.SeriesConfig;
            Stat = SeriesConfig.ValueMetric;
            DataMetric = ChartBinding.DataMetric;
            SeriesData = DataMetric?.CalculateStatistics( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesBase" /> struct.
        /// </summary>
        /// <param name="chartBinding">The binding source.</param>
        protected SeriesBase( IChartBinding chartBinding )
        {
            ChartBinding = chartBinding;
            BindingModel = new ChartDataBindModel( chartBinding );
            Data = chartBinding.Data;
            SeriesConfig = chartBinding.SeriesConfig;
            Stat = SeriesConfig.ValueMetric;
            DataMetric = chartBinding.DataMetric;
            SeriesData = DataMetric?.CalculateStatistics( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesBase" /> class.
        /// </summary>
        /// <param name = "dataRows" > </param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        protected SeriesBase( IEnumerable<DataRow> dataRows, ISeriesConfig seriesConfig ) 
            : this( dataRows )
        {
            SeriesConfig = seriesConfig;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesBase" /> class.
        /// </summary>
        /// <param name="dataTable">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        protected SeriesBase( DataTable dataTable, ISeriesConfig seriesConfig )
        {
            SeriesConfig = seriesConfig;
        }

        /// <summary>
        /// Called when [changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public virtual void OnChanged( object sender, EventArgs e )
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