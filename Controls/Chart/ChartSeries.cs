// <copyright file = "ChartData.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
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
        /// Gets or sets the chart binding.
        /// </summary>
        /// <value>
        /// The chart binding.
        /// </value>
        public ChartBinding ChartBinding { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }
        
        /// <summary>
        /// Gets or sets the data points.
        /// </summary>
        /// <value>
        /// The data points.
        /// </value>
        public ChartPointIndexer DataPoints { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        public IDictionary<string, double> DataValues { get; set; }

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
        public ChartSeries()
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
            ChartBinding = new ChartBinding( bindingSource );
        }

        public ChartSeries( BindingSource bindingSource, Field field )
            : base( bindingSource, field )
        {
            BindingSource = bindingSource;
            ChartBinding = new ChartBinding( bindingSource );
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeries"/> class.
        /// </summary>
        /// <param name="chartBinding">The chart binding.</param>
        public ChartSeries( ChartBinding chartBinding )
            : base( chartBinding )
        {
            ChartBinding = chartBinding;
            BindingSource = ChartBinding.BindingSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeries"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public ChartSeries( DataTable dataTable )
            : base( dataTable )
        {
            ChartBinding = new ChartBinding( dataTable );
            BindingSource = ChartBinding.BindingSource;
        }

        public ChartSeries( DataSet dataSet )
            : base( dataSet )
        {
            ChartBinding = new ChartBinding( dataSet );
            BindingSource = ChartBinding.BindingSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeries"/> class.
        /// </summary>
        /// <param name="data">The data.</param>
        public ChartSeries( IEnumerable<DataRow> data )
        {
            ChartBinding = new ChartBinding(  );
            BindingSource = ChartBinding.BindingSource;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartSeries"/> class.
        /// </summary>
        /// <param name="bindingList">The binding list.</param>
        public ChartSeries( IBindingList bindingList )
        {
            ChartBinding = new ChartBinding( bindingList );
            BindingSource = ChartBinding.BindingSource;
        }
        
        /// <summary>
        /// Sets the point configuration.
        /// </summary>
        public void SetPointConfig(  )
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