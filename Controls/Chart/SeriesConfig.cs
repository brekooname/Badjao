// <copyright file = "SeriesConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using Syncfusion.Windows.Forms.Chart;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class SeriesConfig : ChartSeries, ISeriesConfig
    {
        /// <summary>
        /// Gets the field.
        /// </summary>
        public Field Field { get; set; }

        /// <summary>
        /// Gets the statistic.
        /// </summary>
        public STAT ValueMetric { get; set; }

        /// <summary>
        /// Gets or sets the type of the chart.
        /// </summary>
        /// <value>
        /// The type of the chart.
        /// </value>
        public ChartSeriesType ChartType { get; set; }

        /// <summary>
        /// Gets the numeric.
        /// </summary>
        public Numeric Numeric { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesConfig"/> class.
        /// </summary>
        public SeriesConfig( )
        {
            // Basic Properties
            SmartLabels = true;
            Visible = true;
            ShowTicks = true;
            Rotate = true;
            EnableAreaToolTip = true;
            EnableStyles = true;
            OptimizePiePointPositions = true;
            LegendItemUseSeriesStyle = true;
            SmartLabelsBorderColor = Color.SteelBlue;
            SmartLabelsBorderWidth = 1;
            Numeric = Numeric.Amount;
            ValueMetric = STAT.Total;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SeriesConfig"/> class.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="type">The type.</param>
        public SeriesConfig( Field field, ChartSeriesType type = ChartSeriesType.Column )
            : this( )
        {
            Name = $"{ field }";
            Field = field;
            ChartType = type;
        }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public IDataMetric DataMetric { get; set; }

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
                Style.Callout.Font = ChartConfig.SetFont( "Roboto", 9, FontStyle.Regular );
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
        /// <param name="stat">The stat.</param>
        public void SetPointConfiguration( STAT stat = STAT.Total )
        {
            if( Enum.IsDefined( typeof( STAT ), stat ) )
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

                    if( ChartType != ChartSeriesType.Pie )
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
                                        Styles[ i ].TextFormat = $"{_keys[ i ]} \n {_vals[ i ]:N1}";
                                    }
                                }
                                else if( stat == STAT.Percentage )
                                {
                                    for( var i = 0; i < data.Keys.Count; i++ )
                                    {
                                        Styles[ i ].TextFormat = $"{_keys[ i ]} \n {_vals[ i ]:P}";
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