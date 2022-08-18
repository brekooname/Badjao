// <copyright file = "BudgetChart.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;

    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    public class ChartControl : ChartBase
    {
        /// <summary>
        /// Gets or sets the chart binding.
        /// </summary>
        /// <value>
        /// The chart binding.
        /// </value>
        public IChartBinding ChartBinding { get; set; }

        /// <summary>
        /// Gets or sets the data values.
        /// </summary>
        /// <value>
        /// The data values.
        /// </value>
        public IDictionary<string, double> DataValues { get; set; }
        
        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        /// <value>
        /// The data source.
        /// </value>
        public object DataSource { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        // Initializes Properties
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ChartControl"/> class.
        /// </summary>
        public ChartControl()
        {
            SmoothingMode = SmoothingMode.AntiAlias;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartControl"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ChartControl( BindingSource bindingSource )
            : this( )
        {
            ChartBinding = new ChartBinding( bindingSource );
            BindingSource = (BindingSource)ChartBinding;
            DataSource = BindingSource.DataSource;
            DataSeries = new ChartSeries( bindingSource );
            DataMetric = DataSeries.DataMetric;
            DataValues = DataSeries.DataValues;
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Header.Text = TableName;
            Text = Header.Text.SplitPascal( );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartControl"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name = "dict" > </param>
        public ChartControl( BindingSource bindingSource, IDictionary<string, object> dict )
            : this( )
        {
            ChartBinding = new ChartBinding( bindingSource );
            BindingSource = (BindingSource)ChartBinding;
            DataSource = BindingSource.DataSource;
            DataSeries = new ChartSeries( bindingSource );
            DataMetric = DataSeries.DataMetric;
            DataValues = DataSeries.DataValues;
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Header.Text = TableName;
            Text = Header.Text.SplitPascal( );
            Series.Add( DataSeries );
        }

        public ChartControl( DataTable dataTable )
            : this( )
        {
            ChartBinding = new ChartBinding( dataTable );
            BindingSource = (BindingSource)ChartBinding;
            DataSource = BindingSource.DataSource;
            SeriesModel = new SeriesBindingModel( dataTable );
            DataSeries = new ChartSeries( dataTable );
            DataMetric = DataSeries.DataMetric;
            TableName = dataTable?.TableName;
            Header.Text = TableName;
            Text = Header.Text.SplitPascal( );
            Series.Add( DataSeries );
        }

        public ChartControl( DataTable dataTable, IDictionary<string, object> dict )
            : this( )
        {
            ChartBinding = new ChartBinding( dataTable, dict );
            BindingSource = (BindingSource)ChartBinding;
            DataSource = BindingSource.DataSource;
            SeriesModel = new SeriesBindingModel( dataTable );
            DataSeries = new ChartSeries( dataTable );
            DataMetric = DataSeries.DataMetric;
            TableName = dataTable?.TableName;
            Header.Text = TableName;
            Text = Header.Text.SplitPascal( );
            Series.Add( DataSeries );
        }

        public ChartControl( IEnumerable<DataRow> dataRows )
            : this( )
        {
            ChartBinding = new ChartBinding( dataRows );
            BindingSource = (BindingSource)ChartBinding;
            DataSource = BindingSource.DataSource;
            SeriesModel = new SeriesBindingModel( dataRows );
            DataSeries = new ChartSeries( dataRows );
            DataMetric = DataSeries.DataMetric;
            TableName = dataRows.CopyToDataTable( ).TableName;
            Header.Text = TableName;
            Text = Header.Text.SplitPascal( );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Sets the points.
        /// </summary>
        public void SetPoints( )
        {
            if( Enum.IsDefined( typeof( ChartSeriesType ), DataSeries.Type ) 
                && DataValues?.Any( ) == true )
            {
                try
                {
                    if( Series[ 0 ].Points.Count > 0 )
                    {
                        Series[ 0 ].Points.Clear( );
                    }

                    switch( DataSeries.Type )
                    {
                        case ChartSeriesType.Pyramid:
                        case ChartSeriesType.Funnel:
                        case ChartSeriesType.Pie:
                        {
                            foreach( var kvp in DataValues )
                            {
                                DataSeries.Points.Add( kvp.Key, kvp.Value );

                                if( DataSeries.STAT != STAT.Percentage )
                                {
                                    DataSeries.Styles[ 0 ].TextFormat = $"{ kvp.Key } \n { kvp.Value:N01}";
                                }
                                else if( DataSeries.STAT == STAT.Percentage )
                                {
                                    DataSeries.Styles[ 0 ].TextFormat = $"{ kvp.Key } \n { kvp.Value:P}";
                                }
                            }

                            break;
                        }
                        default:
                        {
                            foreach( var kvp in DataValues )
                            {
                                DataSeries.Points.Add( kvp.Key, kvp.Value );
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
        /// Sets the primary axis titleInfo.
        /// </summary>
        /// <param name="text">The titleInfo.</param>
        /// <param name="font"></param>
        /// <param name="color">The color.</param>
        public void SetPrimaryAxisTitle( string text, Font font, Color color )
        {
            try
            {
                PrimaryXAxis.Title = text;
                PrimaryXAxis.TitleColor = color;
                PrimaryXAxis.TitleFont = font;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}