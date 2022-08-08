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
        public virtual IDictionary<string, IEnumerable<double>> PointValues { get; set; }

        /// <summary>
        /// Gets the series categories.
        /// </summary>
        /// <value>
        /// The series categories.
        /// </value>
        public virtual IEnumerable<string> Categories { get; set; }

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
            PointValues = SeriesDataModel?.DataMetric.CalculateStatistics( );
            Values = SeriesDataModel?.Values;
            Categories = SeriesDataModel?.Categories;
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
            PointValues = SeriesDataModel?.DataMetric.CalculateStatistics( );
            Values = SeriesDataModel?.Values;
            Categories = SeriesDataModel?.Categories;
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
            PointValues = SeriesDataModel?.DataMetric.CalculateStatistics( );
            Values = SeriesDataModel?.Values;
            Categories = SeriesDataModel?.Categories;
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
            PointValues = SeriesDataModel?.DataMetric?.CalculateStatistics( );
            Values = seriesModel?.Values;
            Categories = seriesModel?.Categories;
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
        public void SetPointConfig( STAT stat = STAT.Total )
        {
            if( Validate.STAT( stat ) )
            {
                try
                {
                    switch( stat )
                    {
                        case STAT.Total:
                        case STAT.Average:
                        {
                            Style.TextFormat = "{0:C}";
                            break;
                        }

                        case STAT.Percentage:
                        {
                            Style.TextFormat = "{0:P}";
                            break;
                        }

                        case STAT.Count:
                        {
                            Style.TextFormat = "{0}";
                            break;
                        }
                    }

                    if( Type != ChartSeriesType.Pie )
                    {
                        SmartLabels = true;
                        SortPoints = true;
                        Style.DisplayText = true;
                        Style.TextOffset = 50.0F;
                        Style.TextOrientation = ChartTextOrientation.Up;
                        Style.DisplayShadow = true;
                        Style.TextColor = Color.White;
                        Style.Font.Size = 10F;
                        Style.Font.FontStyle = FontStyle.Bold;
                        Style.Font.Facename = "Roboto";
                        ShowTicks = true;
                        ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                        ConfigItems.ColumnItem.PhongAlpha = 20d;
                    }
                    else
                    {
                        SmartLabels = true;
                        SortPoints = true;
                        Style.DisplayText = true;
                        Style.TextOffset = 50.0F;
                        Style.TextOrientation = ChartTextOrientation.Up;
                        Style.DisplayShadow = true;
                        Style.TextColor = Color.White;
                        Style.Font.Size = 10F;
                        Style.Font.FontStyle = FontStyle.Bold;
                        Style.Font.Facename = "Roboto";
                        ShowTicks = true;
                        ConfigItems.ColumnItem.ShadingMode = ChartColumnShadingMode.PhongCylinder;
                        ConfigItems.ColumnItem.PhongAlpha = 20d;
                    }
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
        /// <param name="stat">The stat.</param>
        public void SetPoints( IDictionary<string, double> data, ChartSeriesType type = ChartSeriesType.Column,
            STAT stat = STAT.Total )
        {
            if( Enum.IsDefined( typeof( ChartSeriesType ), type ) )
            {
                try
                {
                    if( Points.Count > 0 )
                    {
                        Points.Clear( );
                    }

                    switch( type )
                    {
                        case ChartSeriesType.Column:
                        case ChartSeriesType.Line:
                        case ChartSeriesType.Spline:
                        case ChartSeriesType.SplineArea:
                        case ChartSeriesType.Area:
                        case ChartSeriesType.Bar:
                        case ChartSeriesType.BoxAndWhisker:
                        case ChartSeriesType.Bubble:
                        case ChartSeriesType.Candle:
                        case ChartSeriesType.ColumnRange:
                        case ChartSeriesType.HeatMap:
                        case ChartSeriesType.HiLo:
                        case ChartSeriesType.HiLoOpenClose:
                        case ChartSeriesType.Histogram:
                        case ChartSeriesType.Kagi:
                        case ChartSeriesType.PointAndFigure:
                        case ChartSeriesType.Polar:
                        case ChartSeriesType.Radar:
                        case ChartSeriesType.RangeArea:
                        case ChartSeriesType.RotatedSpline:
                        case ChartSeriesType.Scatter:
                        case ChartSeriesType.StackingArea:
                        case ChartSeriesType.StackingArea100:
                        case ChartSeriesType.StackingBar:
                        case ChartSeriesType.StackingBar100:
                        case ChartSeriesType.StackingColumn100:
                        case ChartSeriesType.StepArea:
                        case ChartSeriesType.StepLine:
                        case ChartSeriesType.ThreeLineBreak:
                        case ChartSeriesType.Tornado:
                        case ChartSeriesType.StackingColumn:
                        {
                            foreach( var _kvp in data )
                            {
                                Points.Add( _kvp.Key, _kvp.Value );
                            }

                            break;
                        }

                        case ChartSeriesType.Pyramid:
                        case ChartSeriesType.Funnel:
                        case ChartSeriesType.Pie:
                        {
                            foreach( var _kvp in data )
                            {
                                Points.Add( _kvp.Key, _kvp.Value );
                                var _keys = data.Keys.Select( k => k.ToString( ) ).ToArray( );
                                var _vals = data.Values.Select( v => v ).ToArray( );

                                if( stat != STAT.Percentage )
                                {
                                    for( var i = 0; i < data.Keys.Count; i++ )
                                    {
                                        Styles[ i ].TextFormat = $"{ _keys[ i ] } \n { _vals[ i ]:N1}";
                                    }
                                }
                                else if( stat == STAT.Percentage )
                                {
                                    for( var i = 0; i < data.Keys.Count; i++ )
                                    {
                                        Styles[ i ].TextFormat = $"{ _keys[ i ] } \n { _vals[ i ]:P}";
                                    }
                                }
                            }

                            break;
                        }
                    }
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