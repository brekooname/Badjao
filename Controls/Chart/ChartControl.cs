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
    using Syncfusion.Drawing;
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
            //Basic Control Properties
            Size = new Size( 600, 400 );
            ShowToolbar = true;
            ShowToolTips = true;
            ToolBar.Orientation = ChartOrientation.Horizontal;
            ToolBar.ButtonBackColor = Color.FromArgb( 15, 15, 15 );
            ToolBar.Position = ChartDock.Bottom;
            ToolBar.ShowGrip = false;
            ToolBar.ShowBorder = false;
            ShowScrollBars = false;
            EnableMouseRotation = true;
            Padding = new Padding( 1 );
            Margin = new Padding( 3 );
            Anchor = AnchorStyles.Top & AnchorStyles.Left;
            AllowGapForEmptyPoints = true;
            AllowGradientPalette = true;
            AllowUserEditStyles = true;
            PrintColorMode = ChartPrintColorMode.CheckPrinter;
            BackInterior = new BrushInfo( Color.FromArgb( 15, 15, 15 ) );
            BackColor = Color.FromArgb( 15, 15, 15 );

            ChartInterior = new BrushInfo( GradientStyle.PathRectangle, Color.LightSteelBlue,
                Color.FromArgb( 15, 15, 15 ) );

            CalcRegions = true;

            //ChartArea Properties
            ChartArea.AdjustPlotAreaMargins = ChartSetMode.AutoSet;
            ChartArea.AutoScale = true;
            ChartArea.BackInterior = new BrushInfo( Color.FromArgb( 15, 15, 15 ) );
            ChartArea.BorderWidth = 1;
            ChartArea.BorderColor = Color.Transparent;
            ChartArea.BorderStyle = BorderStyle.FixedSingle;
            ChartAreaMargins = new ChartMargins( 3, 3, 3, 3 );

            //ChartSeries Properties
            DropSeriesPoints = false;
            AddRandomSeries = true;
            Series3D = true;
            SeriesHighlight = true;
            SeriesHighlightIndex = -1;
            ShadowWidth = 5;
            ShadowColor = new BrushInfo( GradientStyle.PathRectangle, Color.FromArgb( 15, 15, 15 ), Color.Silver );
            Depth = 250;
            ElementsSpacing = 10;
            ColumnDrawMode = ChartColumnDrawMode.InDepthMode;
            ColumnFixedWidth = 20;

            //Chart Appearance Setting
            Palette = ChartColorPalette.Metro;
            Skins = Skins.None;
            RealMode3D = true;
            Rotation = 0.1f;
            Spacing = 5;
            AutoHighlight = true;
            SpacingBetweenPoints = 5;
            SpacingBetweenSeries = 10;
            Style3D = true;
            TextAlignment = StringAlignment.Center;
            TextPosition = ChartTextPosition.Top;
            Tilt = 5;
            ScrollPrecision = 100;
            RadarStyle = ChartRadarAxisStyle.Polygon;

            //Chart Legend Setting;
            ShowLegend = true;
            Legend.Font = new Font( "Roboto", 8 );
            Legend.ItemsSize = new Size( 10, 10 );
            Legend.VisibleCheckBox = true;
            Legend.BackInterior = new BrushInfo( Color.FromArgb( 15, 15, 15 ) );
            Legend.ItemsAlignment = StringAlignment.Center;
            Legend.ItemsTextAligment = VerticalAlignment.Center;
            Legend.Orientation = ChartOrientation.Vertical;
            Legend.FloatingAutoSize = true;
            Legend.ShowSymbol = true;
            Legend.ShowItemsShadow = true;
            Legend.ShowBorder = false;
            Legend.Visible = true;

            Header = new ChartTitle( );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartControl" />
        /// class.
        /// </summary>
        /// <param name="chartBinding">The sourceBinding.</param>
        public ChartControl( IChartBinding chartBinding )
            : this( )
        {
            ChartBinding = chartBinding;
            BindingSource = (BindingSource)chartBinding;
            DataSource = BindingSource.DataSource;
            SeriesModel = new SeriesBindingModel( chartBinding );
            DataMetric = DataSeries.DataMetric;
            TableName = chartBinding.DataTable.TableName;
            Header.Text = TableName;
            DataSeries = new ChartSeries( chartBinding.DataTable );
            Series.Add( DataSeries );
            DataValues = DataSeries.DataValues;
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

        public ChartControl( BindingSource bindingSource, Field field )
            : this( )
        {
            Field = field;
            ChartBinding = new ChartBinding( bindingSource );
            BindingSource = (BindingSource)ChartBinding;
            DataSource = BindingSource.DataSource;
            DataSeries = new ChartSeries( bindingSource, field );
            DataValues = DataSeries?.DataValues;
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Header.Text = TableName;
            Text = Header.Text.SplitPascal( );
            Series.Add( DataSeries );
        }


        public ChartControl( DataSet dataSet )
            : this( )
        {
            ChartBinding = new ChartBinding( dataSet );
            BindingSource = (BindingSource)ChartBinding;
            DataSource = BindingSource.DataSource;
            DataSeries = new ChartSeries( dataSet );
            DataMetric = new DataMetric( dataSet );
            DataValues = DataSeries.DataValues;
            TableName = dataSet.Tables[ 0 ].TableName;
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