﻿// <copyright file = "DataSeries.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ChartSeries" />
    /// <seealso cref="IDataSeries" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class ChartData : ChartSeries, IDataSeries
    {
        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public ISeriesConfig SeriesConfig { get; set; }

        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public STAT ValueMetric { get; set; }

        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <value>
        /// The source model.
        /// </value>
        public ISeriesModel DataModel { get; set; }

        /// <summary>
        /// Gets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        public IDictionary<string, IEnumerable<double>> DataValues { get; set; }

        /// <summary>
        /// Gets the series categories.
        /// </summary>
        /// <value>
        /// The series categories.
        /// </value>
        public IEnumerable<string> Names { get; set; }

        /// <summary>
        /// Gets the series values.
        /// </summary>
        /// <value>
        /// The series values.
        /// </value>
        public IEnumerable<double> Values { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        public ChartData( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ChartData( BindingSource bindingSource )
            : this( )
        {
            DataModel = new SeriesModel( bindingSource );
            SeriesConfig = new SeriesModel( bindingSource ).SeriesConfig;
            Name = SeriesConfig.Name;
            Type = SeriesConfig.Type;
            ValueMetric = SeriesConfig.ValueMetric;
            DataValues = DataModel?.DataMetric.CalculateStatistics( );
            Values = DataModel?.Values;
            Names = DataModel?.Categories;
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


        public ChartData( IEnumerable<DataRow> dataRows )
            : this( )
        {
            DataModel = new SeriesModel( dataRows );
            SeriesConfig = DataModel.SeriesConfig;
            Name = SeriesConfig.Name;
            Type = SeriesConfig.Type;
            ValueMetric = SeriesConfig.ValueMetric;
            DataValues = DataModel?.DataMetric.CalculateStatistics( );
            Values = DataModel?.Values;
            Names = DataModel?.Categories;
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

        public ChartData( DataTable dataTable )
            : this( )
        {
            DataModel = new SeriesModel( dataTable );
            SeriesConfig = DataModel.SeriesConfig;
            Name = SeriesConfig.Name;
            Type = SeriesConfig.Type;
            ValueMetric = SeriesConfig.ValueMetric;
            DataValues = DataModel?.DataMetric.CalculateStatistics( );
            Values = DataModel?.Values;
            Names = DataModel?.Categories;
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
        public ChartData( ISeriesModel seriesModel )
            : this( )
        {
            SeriesConfig = seriesModel.SeriesConfig;
            Name = SeriesConfig.Name;
            Type = SeriesConfig.Type;
            ValueMetric = SeriesConfig.ValueMetric;
            DataModel = seriesModel;
            DataValues = DataModel?.DataMetric?.CalculateStatistics( );
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
        public void SetCallOut( )
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
        public void SetPointConfig( STAT stat = STAT.Total )
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
        public void SetPoints( IDictionary<string, double> data, ChartSeriesType type = ChartSeriesType.Column,
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