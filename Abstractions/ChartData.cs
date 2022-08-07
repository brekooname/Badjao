// <copyright file = "DataSeries.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ChartSeries" />
    /// <seealso cref="IDataSeries" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ChartData : ChartSeries, IDataSeries
    {
        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public virtual ISeriesConfig SeriesConfig { get; set; }

        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public virtual STAT ValueMetric { get; set; }

        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <value>
        /// The source model.
        /// </value>
        public virtual ISeriesModel SeriesDataModel { get; set; }

        /// <summary>
        /// Gets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        public virtual IDictionary<string, double> DataValues { get; set; }

        /// <summary>
        /// Gets the series categories.
        /// </summary>
        /// <value>
        /// The series categories.
        /// </value>
        public virtual IEnumerable<string> Names { get; set; }

        /// <summary>
        /// Gets the series values.
        /// </summary>
        /// <value>
        /// The series values.
        /// </value>
        public virtual IEnumerable<double> Values { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        protected ChartData( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        protected ChartData( BindingSource bindingSource )
            : this( )
        {
            SeriesDataModel = new SeriesModel( bindingSource );
            SeriesConfig = SeriesDataModel.SeriesConfig;
            Name = SeriesConfig.Name;
            Type = SeriesConfig.Type;
            ValueMetric = SeriesConfig.ValueMetric;
            DataValues = SeriesDataModel?.DataMetric.CalculateStatistics( );
            Values = SeriesDataModel?.Values;
            Names = SeriesDataModel?.Categories;
            SmartLabels = SeriesConfig.SmartLabels;
            Visible = SeriesConfig.Visible;
            ShowTicks = SeriesConfig.ShowTicks;
            Rotate = SeriesConfig.Rotate;
            EnableAreaToolTip = SeriesConfig.EnableAreaToolTip;
            EnableStyles = SeriesConfig.EnableStyles;
            OptimizePiePointPositions = SeriesConfig.OptimizePiePointPositions;
            LegendItemUseSeriesStyle = SeriesConfig.LegendItemUseSeriesStyle;
            SmartLabelsBorderColor = Color.SteelBlue;
            SmartLabelsBorderWidth = 1;
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        protected ChartData( IEnumerable<DataRow> dataRows )
            : this( )
        {
            SeriesDataModel = new SeriesModel( dataRows );
            SeriesConfig = SeriesDataModel.SeriesConfig;
            Name = SeriesConfig.Name;
            Type = SeriesConfig.Type;
            ValueMetric = SeriesConfig.ValueMetric;
            DataValues = SeriesDataModel?.DataMetric.CalculateStatistics( );
            Values = SeriesDataModel?.Values;
            Names = SeriesDataModel?.Categories;
            SmartLabels = SeriesConfig.SmartLabels;
            Visible = SeriesConfig.Visible;
            ShowTicks = SeriesConfig.ShowTicks;
            Rotate = SeriesConfig.Rotate;
            EnableAreaToolTip = SeriesConfig.EnableAreaToolTip;
            EnableStyles = SeriesConfig.EnableStyles;
            OptimizePiePointPositions = SeriesConfig.OptimizePiePointPositions;
            LegendItemUseSeriesStyle = SeriesConfig.LegendItemUseSeriesStyle;
            SmartLabelsBorderColor = Color.SteelBlue;
            SmartLabelsBorderWidth = 1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        protected ChartData( DataTable dataTable )
            : this( )
        {
            SeriesDataModel = new SeriesModel( dataTable );
            SeriesConfig = SeriesDataModel.SeriesConfig;
            Name = SeriesConfig.Name;
            Type = SeriesConfig.Type;
            ValueMetric = SeriesConfig.ValueMetric;
            DataValues = SeriesDataModel?.DataMetric.CalculateStatistics( );
            Values = SeriesDataModel?.Values;
            Names = SeriesDataModel?.Categories;
            SmartLabels = SeriesConfig.SmartLabels;
            Visible = SeriesConfig.Visible;
            ShowTicks = SeriesConfig.ShowTicks;
            Rotate = SeriesConfig.Rotate;
            EnableAreaToolTip = SeriesConfig.EnableAreaToolTip;
            EnableStyles = SeriesConfig.EnableStyles;
            OptimizePiePointPositions = SeriesConfig.OptimizePiePointPositions;
            LegendItemUseSeriesStyle = SeriesConfig.LegendItemUseSeriesStyle;
            SmartLabelsBorderColor = Color.SteelBlue;
            SmartLabelsBorderWidth = 1;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        /// <param name="seriesModel">The chart data.</param>
        protected ChartData( ISeriesModel seriesModel )
            : this( )
        {
            SeriesConfig = seriesModel.SeriesConfig;
            Name = SeriesConfig.Name;
            Type = SeriesConfig.Type;
            ValueMetric = SeriesConfig.ValueMetric;
            SeriesDataModel = seriesModel;
            DataValues = SeriesDataModel?.DataMetric?.CalculateStatistics( );
            Values = seriesModel?.Values;
            Names = seriesModel?.Categories;
            SmartLabels = SeriesConfig.SmartLabels;
            Visible = SeriesConfig.Visible;
            ShowTicks = SeriesConfig.ShowTicks;
            Rotate = SeriesConfig.Rotate;
            EnableAreaToolTip = SeriesConfig.EnableAreaToolTip;
            EnableStyles = SeriesConfig.EnableStyles;
            OptimizePiePointPositions = SeriesConfig.OptimizePiePointPositions;
            LegendItemUseSeriesStyle = SeriesConfig.LegendItemUseSeriesStyle;
            SmartLabelsBorderColor = Color.SteelBlue;
            SmartLabelsBorderWidth = 1;
        }

        /// <summary>
        /// Sets the call out.
        /// </summary>
        public virtual void SetCallOut( )
        {
            try
            {
                Style.Callout.Enable = true;
                Style.Callout.Position = LabelPosition.Top;
                Style.Callout.DisplayTextAndFormat = "{0} : {2}";
                Style.Callout.Border.Color = Color.SteelBlue;
                Style.Callout.Color = Color.FromArgb( 15, 15, 15 );
                Style.Callout.Font = ChartConfig.SetFont( );
                Style.DisplayText = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Sets the point configuration.
        /// </summary>
        /// <param name="stat">The value.</param>
        public virtual void SetPointConfig( STAT stat = STAT.Total )
        {
            if( SeriesConfig != null )
            {
                try
                {
                    SeriesConfig?.SetPointConfig( stat );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the points.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="type">The type.</param>
        /// <param name="stat">The value.</param>
        public virtual void SetPoints( IDictionary<string, double> data, ChartSeriesType type = ChartSeriesType.Column,
            STAT stat = STAT.Total )
        {
            if( SeriesConfig != null 
                && data?.Any( ) == true )
            {
                try
                {
                    SeriesConfig?.SetPoints( data, type, stat );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        public virtual ChartPointIndexer GetDataPoints( )
        {
            if( DataValues?.Any( ) == true )
            {
                try
                {
                    var _points = new ChartPointIndexer( this );
                    Points.Clear( );
                    foreach( var kvp in DataValues )
                    {
                        Points.Add( kvp.Key, kvp.Value );
                        _points.Add( kvp.Key, kvp.Value );
                    }

                    return _points.Count > 0
                        ? _points
                        : default( ChartPointIndexer );
                }
                catch ( Exception ex )
                {
                    Fail( ex  );
                    return default( ChartPointIndexer );
                }
            }

            return default( ChartPointIndexer );
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