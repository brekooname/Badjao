// <copyright file = "ChartSeries.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class ChartSeries : ChartData
    {
        /// <summary>
        /// Gets or sets the data points.
        /// </summary>
        /// <value>
        /// The data points.
        /// </value>
        public ChartPointIndexer PointIndexer { get; set; }

        /// <summary>
        /// Gets the series categories.
        /// </summary>
        /// <value>
        /// The series categories.
        /// </value>
        public IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Gets the series values.
        /// </summary>
        /// <value>
        /// The series values.
        /// </value>
        public IEnumerable<double> Values { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeries"/> class.
        /// </summary>
        public ChartSeries( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeries"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ChartSeries( BindingSource bindingSource )
            : base( bindingSource )
        {
            BindingSource = bindingSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeries"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public ChartSeries( DataTable dataTable )
            : base( dataTable )
        {
            BindingSource.DataSource = dataTable;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeries"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public ChartSeries( IEnumerable<DataRow> data )
        {
            BindingSource.DataSource = data.CopyToDataTable( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeries"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name = "dict" > </param>
        public ChartSeries( BindingSource bindingSource, IDictionary<string, object> dict )
            : base( bindingSource )
        {
            DataFilter = dict;
            BindingSource = bindingSource;
        }

        /// <summary>
        /// Sets the point configuration.
        /// </summary>
        public void SetPointConfig( )
        {
            if( Enum.IsDefined( typeof( STAT ), STAT ) )
            {
                try
                {
                    switch( STAT )
                    {
                        case STAT.Total:
                        case STAT.Average:
                        {
                            Style.TextFormat = "{0:C}";
                            break;
                        }
                        case STAT.Variance:
                        case STAT.StandardDeviation:
                        {
                            Style.TextFormat = "{0:N1}";
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
                        default:
                        {
                            Style.TextFormat = "{0:N2}";
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
        public void SetPoints( IDictionary<string, double> data,
            ChartSeriesType type = ChartSeriesType.Column, STAT stat = STAT.Total )
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
                        default:
                        {
                            foreach( var _kvp in data )
                            {
                                Points.Add( _kvp.Key, _kvp.Value );
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
    }
}