namespace BudgetExecution
{
    partial class DataForm
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
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridStyleInfo gridStyleInfo1 = new Syncfusion.Windows.Forms.Grid.GridStyleInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataForm));
            this.DataGrid = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new System.Data.DataSet();
            this.ToolBar = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.ComboBox = new Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BrowseButton = new System.Windows.Forms.ToolStripButton();
            this.Separator22 = new System.Windows.Forms.ToolStripSeparator();
            this.ChartButton = new System.Windows.Forms.ToolStripButton();
            this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExcelButton = new System.Windows.Forms.ToolStripButton();
            this.Separator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CalculatorButton = new System.Windows.Forms.ToolStripButton();
            this.Separator6 = new System.Windows.Forms.ToolStripSeparator();
            this.GoogleButton = new System.Windows.Forms.ToolStripButton();
            this.Separator7 = new System.Windows.Forms.ToolStripSeparator();
            this.CalendarButton = new System.Windows.Forms.ToolStripButton();
            this.Separator8 = new System.Windows.Forms.ToolStripSeparator();
            this.PdfButton = new System.Windows.Forms.ToolStripButton();
            this.Separator9 = new System.Windows.Forms.ToolStripSeparator();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.PreviousButton = new System.Windows.Forms.ToolStripButton();
            this.NextButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowDragSelectedCols = true;
            this.DataGrid.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.DataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            gridBaseStyle1.Name = "Column Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle1.StyleInfo.Enabled = false;
            gridBaseStyle1.StyleInfo.Font.Bold = true;
            gridBaseStyle1.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle1.StyleInfo.Font.Italic = false;
            gridBaseStyle1.StyleInfo.Font.Size = 9F;
            gridBaseStyle1.StyleInfo.Font.Strikeout = false;
            gridBaseStyle1.StyleInfo.Font.Underline = false;
            gridBaseStyle1.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridBaseStyle1.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle2.Name = "Header";
            gridBaseStyle2.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle2.StyleInfo.CellType = "Header";
            gridBaseStyle2.StyleInfo.Font.Bold = true;
            gridBaseStyle2.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle2.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle3.Name = "Standard";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle3.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle3.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle4.Name = "Row Header";
            gridBaseStyle4.StyleInfo.BaseStyle = "Header";
            gridBaseStyle4.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle4.StyleInfo.Enabled = true;
            gridBaseStyle4.StyleInfo.Font.Bold = true;
            gridBaseStyle4.StyleInfo.Font.Facename = "Segoe UI";
            gridBaseStyle4.StyleInfo.Font.Italic = false;
            gridBaseStyle4.StyleInfo.Font.Size = 9F;
            gridBaseStyle4.StyleInfo.Font.Strikeout = false;
            gridBaseStyle4.StyleInfo.Font.Underline = false;
            gridBaseStyle4.StyleInfo.Font.Unit = System.Drawing.GraphicsUnit.Point;
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.DataGrid.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.DataGrid.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2007Black;
            this.DataGrid.DataSource = this.BindingSource;
            this.DataGrid.DefaultRowHeight = 28;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2007;
            this.DataGrid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2016Black;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Office2007ScrollBars = true;
            this.DataGrid.Office2007ScrollBarsColorScheme = Syncfusion.Windows.Forms.Office2007ColorScheme.Black;
            this.DataGrid.Office2016ScrollBars = true;
            this.DataGrid.Office2016ScrollBarsColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.Black;
            this.DataGrid.OptimizeInsertRemoveCells = true;
            this.DataGrid.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.DataGrid.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.DataGrid.Size = new System.Drawing.Size(1148, 672);
            this.DataGrid.SmartSizeBox = false;
            this.DataGrid.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.DataGrid.TabIndex = 0;
            gridStyleInfo1.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20))))));
            gridStyleInfo1.VerticalScrollbar = true;
            this.DataGrid.TableStyle = gridStyleInfo1;
            this.DataGrid.Text = "gridDataBoundGrid1";
            this.DataGrid.ThemesEnabled = true;
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DataGrid.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DataGrid.ThemeStyle.VerticalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.DataGrid.TransparentBackground = true;
            this.DataGrid.UseListChangedEvent = true;
            this.DataGrid.UseRightToLeftCompatibleTextBox = true;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "Data";
            // 
            // ToolBar
            // 
            this.ToolBar.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolBar.CanOverrideStyle = true;
            this.ToolBar.CaptionFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBar.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolBar.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBar.ForeColor = System.Drawing.Color.Black;
            this.ToolBar.Image = null;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripLabel1,
            this.TextBox,
            this.PreviousButton,
            this.ComboBox,
            this.NextButton,
            this.toolStripSeparator1,
            this.BrowseButton,
            this.Separator22,
            this.ChartButton,
            this.Separator3,
            this.ExcelButton,
            this.Separator5,
            this.CalculatorButton,
            this.Separator6,
            this.GoogleButton,
            this.Separator7,
            this.CalendarButton,
            this.Separator8,
            this.PdfButton,
            this.Separator9,
            this.HomeButton});
            this.ToolBar.Location = new System.Drawing.Point(0, 672);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.ToolBar.Size = new System.Drawing.Size(1148, 41);
            this.ToolBar.TabIndex = 3;
            this.ToolBar.Text = "Data";
            this.ToolBar.ThemeName = "Default";
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(150, 25);
            // 
            // ComboBox
            // 
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.ComboBox.MaxLength = 32767;
            this.ComboBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
            this.ComboBox.Size = new System.Drawing.Size(156, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Image = ((System.Drawing.Image)(resources.GetObject("BrowseButton.Image")));
            this.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(70, 22);
            this.BrowseButton.Text = "  Browse";
            this.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator22
            // 
            this.Separator22.Name = "Separator22";
            this.Separator22.Size = new System.Drawing.Size(6, 25);
            // 
            // ChartButton
            // 
            this.ChartButton.Image = ((System.Drawing.Image)(resources.GetObject("ChartButton.Image")));
            this.ChartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(66, 22);
            this.ChartButton.Text = "  Charts";
            this.ChartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator3
            // 
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ExcelButton
            // 
            this.ExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.Image")));
            this.ExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(72, 22);
            this.ExcelButton.Text = "  Reports";
            this.ExcelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator5
            // 
            this.Separator5.Name = "Separator5";
            this.Separator5.Size = new System.Drawing.Size(6, 25);
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculatorButton.Image")));
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(81, 22);
            this.CalculatorButton.Text = " Calculator";
            this.CalculatorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator6
            // 
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(6, 25);
            // 
            // GoogleButton
            // 
            this.GoogleButton.Image = ((System.Drawing.Image)(resources.GetObject("GoogleButton.Image")));
            this.GoogleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoogleButton.Name = "GoogleButton";
            this.GoogleButton.Size = new System.Drawing.Size(65, 22);
            this.GoogleButton.Text = " Search";
            this.GoogleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator7
            // 
            this.Separator7.Name = "Separator7";
            this.Separator7.Size = new System.Drawing.Size(6, 25);
            // 
            // CalendarButton
            // 
            this.CalendarButton.Image = ((System.Drawing.Image)(resources.GetObject("CalendarButton.Image")));
            this.CalendarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(74, 22);
            this.CalendarButton.Text = " Calendar";
            this.CalendarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator8
            // 
            this.Separator8.Name = "Separator8";
            this.Separator8.Size = new System.Drawing.Size(6, 25);
            // 
            // PdfButton
            // 
            this.PdfButton.Image = ((System.Drawing.Image)(resources.GetObject("PdfButton.Image")));
            this.PdfButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PdfButton.Name = "PdfButton";
            this.PdfButton.Size = new System.Drawing.Size(90, 22);
            this.PdfButton.Text = "  Documents";
            this.PdfButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator9
            // 
            this.Separator9.Name = "Separator9";
            this.Separator9.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.Separator9.Size = new System.Drawing.Size(6, 25);
            // 
            // HomeButton
            // 
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(72, 22);
            this.HomeButton.Text = "     Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(37, 22);
            this.toolStripLabel1.Text = "          ";
            // 
            // PreviousButton
            // 
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(76, 22);
            this.PreviousButton.Text = "  Previous";
            this.PreviousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // NextButton
            // 
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(50, 22);
            this.NextButton.Text = "Next";
            this.NextButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // DataForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonColor = System.Drawing.Color.DimGray;
            this.CaptionButtonHoverColor = System.Drawing.Color.DimGray;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1148, 713);
            this.Controls.Add(this.DataGrid);
            this.Controls.Add(this.ToolBar);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Name = "DataForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Syncfusion.Windows.Forms.Grid.GridDataBoundGrid DataGrid;
        private System.Windows.Forms.BindingSource BindingSource;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx ToolBar;
        public System.Windows.Forms.ToolStripTextBox TextBox;
        public Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx ComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BrowseButton;
        private System.Windows.Forms.ToolStripSeparator Separator22;
        private System.Windows.Forms.ToolStripButton ChartButton;
        private System.Windows.Forms.ToolStripSeparator Separator3;
        private System.Windows.Forms.ToolStripButton ExcelButton;
        private System.Windows.Forms.ToolStripSeparator Separator5;
        private System.Windows.Forms.ToolStripButton CalculatorButton;
        private System.Windows.Forms.ToolStripSeparator Separator6;
        private System.Windows.Forms.ToolStripButton GoogleButton;
        private System.Windows.Forms.ToolStripSeparator Separator7;
        private System.Windows.Forms.ToolStripButton CalendarButton;
        private System.Windows.Forms.ToolStripSeparator Separator8;
        private System.Windows.Forms.ToolStripButton PdfButton;
        private System.Windows.Forms.ToolStripSeparator Separator9;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Data.DataSet DataSet;
        private System.Windows.Forms.ToolStripButton PreviousButton;
        private System.Windows.Forms.ToolStripButton NextButton;
    }
}