// <copyright file = "BudgetChart.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Drawing.Drawing2D;
    using System.Windows.Forms;
    using Syncfusion.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    public class ChartControl : ChartBase, IChart
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public override ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public override string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public override BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public override Field Field { get; set; }
        
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

        /// <summary>
        /// Gets or sets the header.
        /// </summary>
        /// <value>
        /// The header.
        /// </value>
        public ChartTitle Header { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public override IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public override NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        // Initializes Properties
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ChartControl"/> class.
        /// </summary>
        public ChartControl()
        {
            //Basic Control Properties
            Size = new Size( 600, 400 );
            ShowLegend = false;
            ShowToolbar = true;
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
            SmoothingMode = SmoothingMode.AntiAlias;
            Spacing = 5;
            AutoHighlight = true;
            SpacingBetweenPoints = 5;
            SpacingBetweenSeries = 10;
            Style3D = true;
            TextAlignment = StringAlignment.Center ;
            TextPosition = ChartTextPosition.Top;
            Tilt = 5;
            ScrollPrecision = 100;
            RadarStyle = ChartRadarAxisStyle.Polygon;

            //Chart Legend Setting;
            ShowLegend = true;
            Legend.Font = new Font( "Roboto", 6 );
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

            Header = new ChartTitle(  );
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
            SeriesConfig = chartBinding.SeriesConfig;
            SeriesModel = new SeriesModel( chartBinding );
            DataMetric = SourceModel.DataMetric;
            TableName = chartBinding.DataTable.TableName;
            DataSeries = new ChartDataSeries( chartBinding.DataTable );
            Series.Add( DataSeries );
        }

        public ChartControl( DataTable dataTable )
            : this( )
        {
            SeriesModel = new SeriesModel( dataTable );
            DataSeries = new ChartDataSeries( dataTable );
            SeriesConfig = SeriesModel.SeriesConfig;
            DataMetric = new DataMetric( dataTable?.AsEnumerable( ));
            TableName = dataTable?.TableName;
            TitleInfo = new TitleInfo( TableName );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartControl"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ChartControl( BindingSource bindingSource )
            : this( )
        {
            SeriesModel = new SeriesModel( bindingSource );
            DataSeries = new ChartDataSeries( bindingSource );
            SeriesConfig = SeriesModel.SeriesConfig;
            DataMetric = new DataMetric( bindingSource );
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Header.Text = TableName;
            Titles.Add( Header );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartControl" />
        /// class.
        /// </summary>
        /// <param name="sourceModel">The sourceModel.</param>
        public ChartControl( ISeries sourceModel )
            : this( )
        {
            SeriesConfig = sourceModel.ChartBinding.SeriesConfig;
            SeriesModel = new SeriesModel( sourceModel.ChartBinding );
            TableName = sourceModel.ChartBinding.DataTable.TableName;
            Header.Text = TableName;
            Titles.Add( Header );
            DataMetric = new DataMetric( sourceModel.Data );
            DataSeries = new ChartDataSeries( sourceModel.Data );
            Series.Add( DataSeries );
        }
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartControl" /> class.
        /// </summary>
        /// <param name="dataTable">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public ChartControl( DataTable dataTable, ISeriesConfig seriesConfig )
            : this( )
        {
            SourceModel = new SeriesModel( dataTable, seriesConfig );
            SeriesConfig = seriesConfig;
            DataMetric = SourceModel.DataMetric;
            TableName = dataTable.TableName;
            Header.Text = TableName;
            Titles.Add( Header );
            DataSeries = new ChartDataSeries( dataTable );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartControl" /> class.
        /// </summary>
        /// <param name="dataRows">The data.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public ChartControl( IEnumerable<DataRow> dataRows, ISeriesConfig seriesConfig )
            : this( )
        {
            SeriesConfig = seriesConfig;
            SeriesModel = new SeriesModel( dataRows, seriesConfig );
            DataMetric = SeriesModel.DataMetric;
            TableName = dataRows.CopyToDataTable( ).TableName;
            Header.Text = TableName;
            Titles.Add( Header );
            DataSeries = new ChartDataSeries( dataRows );
            Series.Add( DataSeries );
        }
        
        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartControl" />
        /// class.
        /// </summary>
        /// <param name="sourceModel">The sourceModel.</param>
        /// <param name="titleInfo">The titleInfo.</param>
        public ChartControl( ISeries sourceModel, ITitleInfo titleInfo )
            : this( )
        {
            SourceModel = sourceModel;
            SeriesConfig = sourceModel.ChartBinding.SeriesConfig;
            TableName = sourceModel.ChartBinding.DataTable.TableName;
            Header.Text = titleInfo.GetMainText( ) ?? TableName;
            Titles.Add( Header );
            DataMetric = new DataMetric( sourceModel.Data );
            SeriesModel = new SeriesModel( sourceModel.ChartBinding );
            DataSeries = new ChartDataSeries( sourceModel.Data );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartControl" />
        /// class.
        /// </summary>
        /// <param name="seriesModel">The chartData.</param>
        /// <param name="titleInfo">The titleInfo.</param>
        public ChartControl( ISeriesModel seriesModel, ITitleInfo titleInfo )
            : this( )
        {
            SeriesModel = seriesModel;
            SeriesConfig = seriesModel.SeriesConfig;
            SourceModel = seriesModel.SourceModel;
            TableName = SourceModel.ChartBinding.DataTable.TableName;
            Header.Text = titleInfo.GetMainText( ) ?? TableName;
            Titles.Add( Header );
            DataMetric = new DataMetric( SourceModel.Data );
            DataSeries = new ChartDataSeries( SourceModel.Data );
            Series.Add( DataSeries );
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public void SetSize( int width = 600, int height = 400 )
        {
            if( width > 0
                && height > 0 )
            {
                try
                {
                    Size = new Size( width, height );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public void SetLocation( int x = 1, int y = 1 )
        {
            if( x > 0
                && y > 0 )
            {
                try
                {
                    Location = new Point( x, y );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name="parent">The parent.</param>
        public void SetParent( Control parent )
        {
            if( parent != null )
            {
                try
                {
                    Parent = parent;
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

        /// <summary>
        /// Sets the main titleInfo.
        /// </summary>
        /// <param name="text">The t.</param>
        /// <param name="font"></param>
        /// <param name="color"></param>
        public void SetMainTitle( string text, Font font, Color color )
        {
            try
            {
                if( Titles?.Count > 0 )
                {
                    Titles.Clear( );
                }

                using( var title = new ChartTitle(  ) )
                {
                    title.Visible = true;
                    title.Font = font;
                    title.BackColor = Color.FromArgb( 15, 15, 15 );
                    title.ForeColor = color;
                    title.Text = text;
                    Titles?.Add( title );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}