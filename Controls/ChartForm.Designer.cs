namespace BudgetExecution
{
    partial class ChartForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose( bool disposing )
        {
            if( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries2 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo2 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem chartToolBarSaveItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSaveItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem chartToolBarPaletteItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarPaletteItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem chartToolBarStyleItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarStyleItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem chartToolBarTypeItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarTypeItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem chartToolBarSeries3DItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarSeries3DItem();
            Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem chartToolBarShowLegendItem1 = new Syncfusion.Windows.Forms.Chart.ChartToolBarShowLegendItem();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.Chart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.DataSet = new BudgetExecution.DataModel();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.ToolStrip = new BudgetExecution.ToolStrip();
            this.TextBox = new BudgetExecution.ToolStripTextBox();
            this.Separator1 = new BudgetExecution.ToolSeparator();
            this.Label = new BudgetExecution.ToolStripLabel();
            this.Separator2 = new BudgetExecution.ToolSeparator();
            this.DropDown = new BudgetExecution.ToolStripDropDown();
            this.Separator3 = new BudgetExecution.ToolSeparator();
            this.Separator4 = new BudgetExecution.ToolSeparator();
            this.Separator5 = new BudgetExecution.ToolSeparator();
            this.Separator6 = new BudgetExecution.ToolSeparator();
            this.Separator7 = new BudgetExecution.ToolSeparator();
            this.Separator8 = new BudgetExecution.ToolSeparator();
            this.Separator9 = new BudgetExecution.ToolSeparator();
            this.Separator10 = new BudgetExecution.ToolSeparator();
            this.Separator11 = new BudgetExecution.ToolSeparator();
            this.Separator12 = new BudgetExecution.ToolSeparator();
            this.Separator13 = new BudgetExecution.ToolSeparator();
            this.Separator14 = new BudgetExecution.ToolSeparator();
            this.Separator15 = new BudgetExecution.ToolSeparator();
            this.Separator16 = new BudgetExecution.ToolSeparator();
            this.Separator17 = new BudgetExecution.ToolSeparator();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.FirstButton = new BudgetExecution.ToolStripButton();
            this.PreviousButton = new BudgetExecution.ToolStripButton();
            this.NextButton = new BudgetExecution.ToolStripButton();
            this.LastButton = new BudgetExecution.ToolStripButton();
            this.AddButton = new BudgetExecution.ToolStripButton();
            this.EditButton = new BudgetExecution.ToolStripButton();
            this.DeleteButton = new BudgetExecution.ToolStripButton();
            this.RefreshButton = new BudgetExecution.ToolStripButton();
            this.SaveButton = new BudgetExecution.ToolStripButton();
            this.BrowseButton = new BudgetExecution.ToolStripButton();
            this.ExcelButton = new BudgetExecution.ToolStripButton();
            this.CalculatorButton = new BudgetExecution.ToolStripButton();
            this.TableButton = new BudgetExecution.ToolStripButton();
            this.HomeButton = new BudgetExecution.ToolStripButton();
            this.Separator18 = new BudgetExecution.ToolSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.AllowUserEditStyles = true;
            this.Chart.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Chart.AutoHighlight = true;
            this.Chart.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.LightGray, System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))));
            this.Chart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.LightGray, System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))));
            this.Chart.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.Chart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart.ChartArea.CursorReDraw = false;
            this.Chart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.LightGray, System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))));
            this.Chart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(38)))))};
            this.Chart.DataSourceName = "BindingSource";
            this.Chart.Depth = 150F;
            this.Chart.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart.ForeColor = System.Drawing.Color.LightGray;
            this.Chart.HighlightSymbol = true;
            this.Chart.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart.Legend.Location = new System.Drawing.Point(68, 81);
            this.Chart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.Chart.Legend.Visible = false;
            this.Chart.Localize = null;
            this.Chart.Location = new System.Drawing.Point(89, 67);
            this.Chart.Name = "Chart";
            this.Chart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.Chart.PrimaryXAxis.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart.PrimaryXAxis.ForeColor = System.Drawing.Color.LightGray;
            this.Chart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.Chart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Chart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart.PrimaryXAxis.Margin = true;
            this.Chart.PrimaryXAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Chart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.Chart.PrimaryXAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Chart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart.PrimaryYAxis.Font = new System.Drawing.Font("Source Code Pro", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart.PrimaryYAxis.ForeColor = System.Drawing.Color.LightGray;
            this.Chart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.Chart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Chart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart.PrimaryYAxis.Margin = true;
            this.Chart.PrimaryYAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Chart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.Chart.PrimaryYAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Chart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart.RealMode3D = true;
            this.Chart.Rotation = 5F;
            chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries1.Name = "Default0";
            chartSeries1.Points.Add(1D, ((double)(55D)));
            chartSeries1.Points.Add(2D, ((double)(70D)));
            chartSeries1.Points.Add(3D, ((double)(80D)));
            chartSeries1.Points.Add(4D, ((double)(65D)));
            chartSeries1.Points.Add(5D, ((double)(75D)));
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.AltTagFormat = "";
            chartSeries1.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries1.Style.DrawTextShape = false;
            chartSeries1.Style.Font.Facename = "Microsoft Sans Serif";
            chartSeries1.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo1.DashPattern = null;
            chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo1.Width = 1F;
            chartCustomShapeInfo1.Border = chartLineInfo1;
            chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries1.Style.TextShape = chartCustomShapeInfo1;
            chartSeries1.Text = "Default0";
            chartSeries2.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries2.Name = "Default1";
            chartSeries2.Points.Add(1D, ((double)(70D)));
            chartSeries2.Points.Add(2D, ((double)(35D)));
            chartSeries2.Points.Add(3D, ((double)(65D)));
            chartSeries2.Points.Add(4D, ((double)(25D)));
            chartSeries2.Points.Add(5D, ((double)(50D)));
            chartSeries2.Resolution = 0D;
            chartSeries2.StackingGroup = "Default Group";
            chartSeries2.Style.AltTagFormat = "";
            chartSeries2.Style.Callout.Font.Facename = "Microsoft Sans Serif";
            chartSeries2.Style.DrawTextShape = false;
            chartSeries2.Style.Font.Facename = "Microsoft Sans Serif";
            chartSeries2.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            chartCustomShapeInfo2.Border = chartLineInfo1;
            chartCustomShapeInfo2.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo2.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries2.Style.TextShape = chartCustomShapeInfo2;
            chartSeries2.Text = "Default1";
            this.Chart.Series.Add(chartSeries1);
            this.Chart.Series.Add(chartSeries2);
            this.Chart.Series3D = true;
            this.Chart.SeriesHighlight = true;
            this.Chart.ShowToolbar = true;
            this.Chart.Size = new System.Drawing.Size(1227, 552);
            this.Chart.Spacing = 10F;
            this.Chart.Style3D = true;
            this.Chart.TabIndex = 0;
            this.Chart.Tilt = 15F;
            // 
            // 
            // 
            this.Chart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Chart.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Chart.Title.Name = "Default";
            this.Chart.ToolBar.Border.BackColor = System.Drawing.Color.Transparent;
            this.Chart.ToolBar.Border.ForeColor = System.Drawing.Color.Transparent;
            this.Chart.ToolBar.EnableDefaultItems = false;
            this.Chart.ToolBar.IncludeInExportedChart = false;
            this.Chart.ToolBar.Items.Add(chartToolBarSaveItem1);
            this.Chart.ToolBar.Items.Add(chartToolBarPaletteItem1);
            this.Chart.ToolBar.Items.Add(chartToolBarStyleItem1);
            this.Chart.ToolBar.Items.Add(chartToolBarTypeItem1);
            this.Chart.ToolBar.Items.Add(chartToolBarSeries3DItem1);
            this.Chart.ToolBar.Items.Add(chartToolBarShowLegendItem1);
            this.Chart.ToolBar.Orientation = Syncfusion.Windows.Forms.Chart.ChartOrientation.Vertical;
            this.Chart.ToolBar.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Right;
            this.Chart.ToolBar.ShowBorder = false;
            this.Chart.ToolBar.ShowDialog = true;
            this.Chart.ToolBar.ShowGrip = false;
            this.Chart.ToolBar.Visible = true;
            this.Chart.VisualTheme = "";
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "ChartData";
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ToolTip.Field = BudgetExecution.Field.RpioActivityCode;
            this.ToolTip.ForeColor = System.Drawing.Color.White;
            this.ToolTip.InitialDelay = 500;
            this.ToolTip.Name = null;
            this.ToolTip.OwnerDraw = true;
            this.ToolTip.ReshowDelay = 100;
            this.ToolTip.Style = MetroSet_UI.Design.Style.Custom;
            this.ToolTip.StyleManager = null;
            this.ToolTip.ThemeAuthor = "Terry D. Eppler";
            this.ToolTip.ThemeName = "Budget Execution";
            this.ToolTip.TipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.ToolTip.TipText = null;
            this.ToolTip.TipTitle = null;
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStrip.BindingSource = null;
            this.ToolStrip.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolStrip.CanOverrideStyle = true;
            this.ToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            this.ToolStrip.CaptionFont = new System.Drawing.Font("Roboto", 9F);
            this.ToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            this.ToolStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.ToolStrip.DataFilter = null;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.DropDown = null;
            this.ToolStrip.Field = BudgetExecution.Field.RpioActivityCode;
            this.ToolStrip.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.Image = null;
            this.ToolStrip.ImageDirectory = null;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.ImageSize = new System.Drawing.Size(0, 0);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TextBox,
            this.Separator1,
            this.Label,
            this.Separator2,
            this.DropDown,
            this.Separator3,
            this.FirstButton,
            this.Separator4,
            this.PreviousButton,
            this.Separator5,
            this.NextButton,
            this.Separator6,
            this.LastButton,
            this.Separator7,
            this.AddButton,
            this.Separator8,
            this.EditButton,
            this.Separator9,
            this.DeleteButton,
            this.Separator10,
            this.RefreshButton,
            this.Separator11,
            this.SaveButton,
            this.Separator12,
            this.BrowseButton,
            this.Separator13,
            this.ExcelButton,
            this.Separator14,
            this.CalculatorButton,
            this.Separator15,
            this.TableButton,
            this.Separator17,
            this.HomeButton,
            this.Separator18});
            this.ToolStrip.Label = null;
            this.ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.ToolStrip.Location = new System.Drawing.Point(0, 661);
            this.ToolStrip.Margin = new System.Windows.Forms.Padding(1);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Numeric = BudgetExecution.Numeric.NS;
            this.ToolStrip.Office12Mode = false;
            this.ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(1);
            this.ToolStrip.Separators = null;
            this.ToolStrip.ShowCaption = true;
            this.ToolStrip.ShowLauncher = true;
            this.ToolStrip.Size = new System.Drawing.Size(1385, 52);
            this.ToolStrip.TabIndex = 4;
            this.ToolStrip.TextBox = null;
            this.ToolStrip.ThemeName = "Office2016DarkGray";
            this.ToolStrip.ThemeStyle.ArrowColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStrip.ThemeStyle.BottomToolStripBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ToolStrip.ThemeStyle.CaptionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ToolStrip.ThemeStyle.CaptionForeColor = System.Drawing.Color.Black;
            this.ToolStrip.ThemeStyle.ComboBoxStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.ToolStrip.ThemeStyle.ComboBoxStyle.HoverBorderColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.HoverItemBackColor = System.Drawing.Color.SteelBlue;
            this.ToolStrip.ThemeStyle.HoverItemForeColor = System.Drawing.Color.White;
            this.ToolStrip.VisualStyle = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016DarkGray;
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TextBox.BindingSource = this.BindingSource;
            this.TextBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox.HoverText = "";
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(150, 26);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = this.ToolTip;
            // 
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.Black;
            this.Separator1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator1.Name = "Separator1";
            this.Separator1.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator1.Size = new System.Drawing.Size(6, 36);
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Label.BindingSource = this.BindingSource;
            this.Label.DataFilter = null;
            this.Label.Field = BudgetExecution.Field.RpioActivityCode;
            this.Label.Font = new System.Drawing.Font("Roboto", 9F);
            this.Label.ForeColor = System.Drawing.Color.Black;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(5);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(66, 26);
            this.Label.Tag = "";
            this.Label.Text = "Chart Data";
            this.Label.ToolTip = this.ToolTip;
            // 
            // Separator2
            // 
            this.Separator2.ForeColor = System.Drawing.Color.Black;
            this.Separator2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator2.Name = "Separator2";
            this.Separator2.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator2.Size = new System.Drawing.Size(6, 36);
            // 
            // DropDown
            // 
            this.DropDown.AllowDrop = true;
            this.DropDown.BindingSource = null;
            this.DropDown.DataFilter = null;
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.Field = BudgetExecution.Field.RpioActivityCode;
            this.DropDown.Font = new System.Drawing.Font("Roboto", 9F);
            this.DropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.DropDown.HoverText = "Make Selection";
            this.DropDown.Margin = new System.Windows.Forms.Padding(5);
            this.DropDown.MaxDropDownItems = 100;
            this.DropDown.MaxLength = 32767;
            this.DropDown.Name = "DropDown";
            this.DropDown.Numeric = BudgetExecution.Numeric.NS;
            this.DropDown.Size = new System.Drawing.Size(200, 26);
            this.DropDown.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            this.DropDown.Tag = "Selection";
            this.DropDown.ToolTip = this.ToolTip;
            this.DropDown.ToolTipText = "Selection";
            // 
            // Separator3
            // 
            this.Separator3.ForeColor = System.Drawing.Color.Black;
            this.Separator3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator3.Name = "Separator3";
            this.Separator3.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator3.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator4
            // 
            this.Separator4.ForeColor = System.Drawing.Color.Black;
            this.Separator4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator4.Name = "Separator4";
            this.Separator4.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator4.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator5
            // 
            this.Separator5.ForeColor = System.Drawing.Color.Black;
            this.Separator5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator5.Name = "Separator5";
            this.Separator5.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator5.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator6
            // 
            this.Separator6.ForeColor = System.Drawing.Color.Black;
            this.Separator6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator6.Name = "Separator6";
            this.Separator6.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator6.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator7
            // 
            this.Separator7.ForeColor = System.Drawing.Color.Black;
            this.Separator7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator7.Name = "Separator7";
            this.Separator7.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator7.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator8
            // 
            this.Separator8.ForeColor = System.Drawing.Color.Black;
            this.Separator8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator8.Name = "Separator8";
            this.Separator8.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator8.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator9
            // 
            this.Separator9.ForeColor = System.Drawing.Color.Black;
            this.Separator9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator9.Name = "Separator9";
            this.Separator9.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator9.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator10
            // 
            this.Separator10.ForeColor = System.Drawing.Color.Black;
            this.Separator10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator10.Name = "Separator10";
            this.Separator10.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator10.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator11
            // 
            this.Separator11.ForeColor = System.Drawing.Color.Black;
            this.Separator11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator11.Name = "Separator11";
            this.Separator11.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator11.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator12
            // 
            this.Separator12.ForeColor = System.Drawing.Color.Black;
            this.Separator12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator12.Name = "Separator12";
            this.Separator12.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator12.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator13
            // 
            this.Separator13.ForeColor = System.Drawing.Color.Black;
            this.Separator13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator13.Name = "Separator13";
            this.Separator13.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator13.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator14
            // 
            this.Separator14.ForeColor = System.Drawing.Color.Black;
            this.Separator14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator14.Name = "Separator14";
            this.Separator14.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator14.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator15
            // 
            this.Separator15.ForeColor = System.Drawing.Color.Black;
            this.Separator15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator15.Name = "Separator15";
            this.Separator15.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator15.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator16
            // 
            this.Separator16.ForeColor = System.Drawing.Color.Black;
            this.Separator16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator16.Name = "Separator16";
            this.Separator16.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator16.Size = new System.Drawing.Size(6, 36);
            // 
            // Separator17
            // 
            this.Separator17.ForeColor = System.Drawing.Color.Black;
            this.Separator17.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator17.Name = "Separator17";
            this.Separator17.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator17.Size = new System.Drawing.Size(6, 36);
            // 
            // FirstButton
            // 
            this.FirstButton.AutoToolTip = false;
            this.FirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FirstButton.BindingSource = this.BindingSource;
            this.FirstButton.DataFilter = null;
            this.FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.FirstButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.FirstButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FirstButton.HoverText = "First Record";
            this.FirstButton.Image = global::BudgetExecution.Properties.Resources.FirstButton;
            this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstButton.Margin = new System.Windows.Forms.Padding(5);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(24, 26);
            this.FirstButton.ToolTip = this.ToolTip;
            this.FirstButton.ToolType = BudgetExecution.ToolType.FirstButton;
            // 
            // PreviousButton
            // 
            this.PreviousButton.AutoToolTip = false;
            this.PreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PreviousButton.BindingSource = this.BindingSource;
            this.PreviousButton.DataFilter = null;
            this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.PreviousButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.PreviousButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.PreviousButton.HoverText = "Previous Record";
            this.PreviousButton.Image = global::BudgetExecution.Properties.Resources.PreviousButton;
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(24, 26);
            this.PreviousButton.ToolTip = this.ToolTip;
            this.PreviousButton.ToolType = BudgetExecution.ToolType.PreviousButton;
            // 
            // NextButton
            // 
            this.NextButton.AutoToolTip = false;
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.NextButton.BindingSource = this.BindingSource;
            this.NextButton.DataFilter = null;
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.NextButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.NextButton.HoverText = "Next Record";
            this.NextButton.Image = global::BudgetExecution.Properties.Resources.NextButton;
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(24, 26);
            this.NextButton.ToolTip = this.ToolTip;
            this.NextButton.ToolType = BudgetExecution.ToolType.NextButton;
            // 
            // LastButton
            // 
            this.LastButton.AutoToolTip = false;
            this.LastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LastButton.BindingSource = this.BindingSource;
            this.LastButton.DataFilter = null;
            this.LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.LastButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.LastButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.LastButton.HoverText = "Last Record";
            this.LastButton.Image = global::BudgetExecution.Properties.Resources.LastButton;
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(5);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(24, 26);
            this.LastButton.ToolTip = this.ToolTip;
            this.LastButton.ToolType = BudgetExecution.ToolType.LastButton;
            // 
            // AddButton
            // 
            this.AddButton.AutoToolTip = false;
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AddButton.BindingSource = this.BindingSource;
            this.AddButton.DataFilter = null;
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.AddButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AddButton.HoverText = "Add Record";
            this.AddButton.Image = global::BudgetExecution.Properties.Resources.AddButton;
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(24, 26);
            this.AddButton.ToolTip = this.ToolTip;
            this.AddButton.ToolType = BudgetExecution.ToolType.AddButton;
            // 
            // EditButton
            // 
            this.EditButton.AutoToolTip = false;
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.EditButton.BindingSource = this.BindingSource;
            this.EditButton.DataFilter = null;
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.EditButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.EditButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.EditButton.HoverText = "Edit Record";
            this.EditButton.Image = global::BudgetExecution.Properties.Resources.EditButton;
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Margin = new System.Windows.Forms.Padding(5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(24, 26);
            this.EditButton.ToolTip = this.ToolTip;
            this.EditButton.ToolType = BudgetExecution.ToolType.EditButton;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoToolTip = false;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DeleteButton.BindingSource = this.BindingSource;
            this.DeleteButton.DataFilter = null;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DeleteButton.HoverText = "Delete Record";
            this.DeleteButton.Image = global::BudgetExecution.Properties.Resources.DeleteButton;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(24, 26);
            this.DeleteButton.ToolTip = this.ToolTip;
            this.DeleteButton.ToolType = BudgetExecution.ToolType.DeleteButton;
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoToolTip = false;
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.RefreshButton.BindingSource = this.BindingSource;
            this.RefreshButton.DataFilter = null;
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.RefreshButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshButton.HoverText = "Refresh Data/Filters";
            this.RefreshButton.Image = global::BudgetExecution.Properties.Resources.RefreshButton;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(24, 26);
            this.RefreshButton.Text = "toolStripButton8";
            this.RefreshButton.ToolTip = this.ToolTip;
            this.RefreshButton.ToolType = BudgetExecution.ToolType.RefreshButton;
            // 
            // SaveButton
            // 
            this.SaveButton.AutoToolTip = false;
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SaveButton.BindingSource = this.BindingSource;
            this.SaveButton.DataFilter = null;
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.SaveButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.SaveButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.SaveButton.HoverText = "Save Record";
            this.SaveButton.Image = global::BudgetExecution.Properties.Resources.SaveButton;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(24, 26);
            this.SaveButton.ToolTip = this.ToolTip;
            this.SaveButton.ToolType = BudgetExecution.ToolType.SaveButton;
            // 
            // BrowseButton
            // 
            this.BrowseButton.AutoToolTip = false;
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BrowseButton.BindingSource = this.BindingSource;
            this.BrowseButton.DataFilter = null;
            this.BrowseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BrowseButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.BrowseButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.BrowseButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.BrowseButton.HoverText = "Browse File System";
            this.BrowseButton.Image = global::BudgetExecution.Properties.Resources.BrowseButton;
            this.BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(5);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(24, 26);
            this.BrowseButton.ToolTip = this.ToolTip;
            this.BrowseButton.ToolType = BudgetExecution.ToolType.BrowseButton;
            // 
            // ExcelButton
            // 
            this.ExcelButton.AutoToolTip = false;
            this.ExcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ExcelButton.BindingSource = this.BindingSource;
            this.ExcelButton.DataFilter = null;
            this.ExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcelButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.ExcelButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ExcelButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ExcelButton.HoverText = "Excel Export";
            this.ExcelButton.Image = global::BudgetExecution.Properties.Resources.ExcelButton;
            this.ExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(24, 26);
            this.ExcelButton.ToolTip = this.ToolTip;
            this.ExcelButton.ToolType = BudgetExecution.ToolType.ExcelButton;
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.AutoToolTip = false;
            this.CalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CalculatorButton.BindingSource = this.BindingSource;
            this.CalculatorButton.DataFilter = null;
            this.CalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatorButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.CalculatorButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.CalculatorButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CalculatorButton.HoverText = "Calculator";
            this.CalculatorButton.Image = global::BudgetExecution.Properties.Resources.CalculatorButton;
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(5);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(24, 26);
            this.CalculatorButton.Text = "toolStripButton2";
            this.CalculatorButton.ToolTip = this.ToolTip;
            this.CalculatorButton.ToolType = BudgetExecution.ToolType.CalculatorButton;
            // 
            // TableButton
            // 
            this.TableButton.AutoToolTip = false;
            this.TableButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableButton.BindingSource = this.BindingSource;
            this.TableButton.DataFilter = null;
            this.TableButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.TableButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.TableButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.TableButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TableButton.HoverText = "Data Table";
            this.TableButton.Image = global::BudgetExecution.Properties.Resources.TableButton;
            this.TableButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TableButton.Margin = new System.Windows.Forms.Padding(5);
            this.TableButton.Name = "TableButton";
            this.TableButton.Size = new System.Drawing.Size(24, 26);
            this.TableButton.Text = "toolStripButton11";
            this.TableButton.ToolTip = this.ToolTip;
            this.TableButton.ToolType = BudgetExecution.ToolType.TableButton;
            // 
            // HomeButton
            // 
            this.HomeButton.AutoToolTip = false;
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.HomeButton.BindingSource = this.BindingSource;
            this.HomeButton.DataFilter = null;
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.HomeButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.HomeButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.HomeButton.HoverText = "Main Menu";
            this.HomeButton.Image = global::BudgetExecution.Properties.Resources.HomeButton;
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Margin = new System.Windows.Forms.Padding(5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(24, 26);
            this.HomeButton.Text = "toolStripButton12";
            this.HomeButton.ToolTip = this.ToolTip;
            this.HomeButton.ToolType = BudgetExecution.ToolType.HomeButton;
            // 
            // Separator18
            // 
            this.Separator18.ForeColor = System.Drawing.Color.Black;
            this.Separator18.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator18.Name = "Separator18";
            this.Separator18.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator18.Size = new System.Drawing.Size(6, 36);
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Maroon;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1385, 713);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.Chart);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MinimizeBox = false;
            this.Name = "ChartForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolTip ToolTip;
        public Syncfusion.Windows.Forms.Chart.ChartControl Chart;
        public ToolStrip ToolStrip;
        private DataModel DataSet;
        public System.Windows.Forms.BindingSource BindingSource;
        public ToolStripTextBox TextBox;
        private ToolSeparator Separator1;
        public ToolStripLabel Label;
        private ToolSeparator Separator2;
        public ToolStripDropDown DropDown;
        private ToolSeparator Separator3;
        public ToolStripButton FirstButton;
        private ToolSeparator Separator4;
        private ToolSeparator Separator5;
        private ToolSeparator Separator6;
        private ToolSeparator Separator7;
        private ToolSeparator Separator8;
        private ToolSeparator Separator9;
        private ToolSeparator Separator10;
        private ToolSeparator Separator11;
        private ToolSeparator Separator12;
        private ToolSeparator Separator13;
        private ToolSeparator Separator14;
        public ToolStripButton ExcelButton;
        public ToolStripButton CalculatorButton;
        public ToolStripButton TableButton;
        private ToolSeparator Separator15;
        public ToolStripButton HomeButton;
        private ToolSeparator Separator16;
        public ToolStripButton PreviousButton;
        public ToolStripButton BrowseButton;
        public ToolStripButton SaveButton;
        public ToolStripButton RefreshButton;
        public ToolStripButton EditButton;
        public ToolStripButton DeleteButton;
        public ToolStripButton AddButton;
        public ToolStripButton LastButton;
        public ToolStripButton NextButton;
        private ToolSeparator Separator17;
        private ToolSeparator Separator18;
    }
}