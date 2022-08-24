﻿namespace BudgetExecution
{
    partial class DataViewForm
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
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle5 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle6 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle7 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle8 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridStyleInfo gridStyleInfo2 = new Syncfusion.Windows.Forms.Grid.GridStyleInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewForm));
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridPanel = new System.Windows.Forms.Panel();
            this.DataGrid = new BudgetExecution.DataView();
            this.ElementListBox = new BudgetExecution.ListBox();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.ColumnListBox = new BudgetExecution.ListBox();
            this.ToolStrip = new BudgetExecution.ToolStrip();
            this.ToolStripDropDown = new BudgetExecution.ToolStripDropDown();
            this.ToolStripLabel = new BudgetExecution.ToolStripLabel();
            this.toolSeparator1 = new BudgetExecution.ToolSeparator();
            this.ToolStripTextBox = new BudgetExecution.ToolStripTextBox();
            this.toolSeparator2 = new BudgetExecution.ToolSeparator();
            this.toolSeparator3 = new BudgetExecution.ToolSeparator();
            this.ToolStripFirstButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator4 = new BudgetExecution.ToolSeparator();
            this.ToolStripPreviousButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator5 = new BudgetExecution.ToolSeparator();
            this.ToolStripNextButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator6 = new BudgetExecution.ToolSeparator();
            this.ToolStripLastButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator7 = new BudgetExecution.ToolSeparator();
            this.ToolStripEditButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator8 = new BudgetExecution.ToolSeparator();
            this.ToolStripAddButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator9 = new BudgetExecution.ToolSeparator();
            this.ToolStripDeleteButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator10 = new BudgetExecution.ToolSeparator();
            this.ToolStripRefreshButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator11 = new BudgetExecution.ToolSeparator();
            this.ToolStripSaveButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator12 = new BudgetExecution.ToolSeparator();
            this.ToolStripCalculatorButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator13 = new BudgetExecution.ToolSeparator();
            this.ToolStripExcelButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator15 = new BudgetExecution.ToolSeparator();
            this.ToolStripChartButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator14 = new BudgetExecution.ToolSeparator();
            this.ToolStripHomeButton = new BudgetExecution.ToolStripButton();
            this.TableListBox = new BudgetExecution.ListBox();
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.GridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // GridPanel
            // 
            this.GridPanel.Controls.Add(this.DataGrid);
            this.GridPanel.Location = new System.Drawing.Point(88, 68);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(919, 586);
            this.GridPanel.TabIndex = 2;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowDragSelectedCols = true;
            this.DataGrid.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.DataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            gridBaseStyle5.Name = "Column Header";
            gridBaseStyle5.StyleInfo.BaseStyle = "Header";
            gridBaseStyle5.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle5.StyleInfo.Enabled = false;
            gridBaseStyle5.StyleInfo.Font.Bold = true;
            gridBaseStyle5.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridBaseStyle6.Name = "Header";
            gridBaseStyle6.StyleInfo.Borders.Bottom = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Left = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Right = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.Borders.Top = new Syncfusion.Windows.Forms.Grid.GridBorder(Syncfusion.Windows.Forms.Grid.GridBorderStyle.None);
            gridBaseStyle6.StyleInfo.CellType = "Header";
            gridBaseStyle6.StyleInfo.Font.Bold = true;
            gridBaseStyle6.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Control);
            gridBaseStyle6.StyleInfo.VerticalAlignment = Syncfusion.Windows.Forms.Grid.GridVerticalAlignment.Middle;
            gridBaseStyle7.Name = "Standard";
            gridBaseStyle7.StyleInfo.CheckBoxOptions.CheckedValue = "True";
            gridBaseStyle7.StyleInfo.CheckBoxOptions.UncheckedValue = "False";
            gridBaseStyle7.StyleInfo.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.SystemColors.Window);
            gridBaseStyle8.Name = "Row Header";
            gridBaseStyle8.StyleInfo.BaseStyle = "Header";
            gridBaseStyle8.StyleInfo.CellType = "RowHeaderCell";
            gridBaseStyle8.StyleInfo.Enabled = true;
            gridBaseStyle8.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.DataGrid.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle5,
            gridBaseStyle6,
            gridBaseStyle7,
            gridBaseStyle8});
            this.DataGrid.BindingSource = this.BindingSource;
            this.DataGrid.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2016Black;
            this.DataGrid.DataFilter = null;
            this.DataGrid.DataSource = this.BindingSource;
            this.DataGrid.DefaultRowHeight = 20;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.ExcelLikeAlignment = true;
            this.DataGrid.ExcelLikeSelectionFrame = true;
            this.DataGrid.Field = BudgetExecution.Field.AccountCode;
            this.DataGrid.Font = new System.Drawing.Font("Roboto", 8F);
            this.DataGrid.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DataGrid.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Metro;
            this.DataGrid.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Metro;
            this.DataGrid.HorizontalScrollTips = true;
            this.DataGrid.HorizontalThumbTrack = true;
            this.DataGrid.HoverText = null;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.MetroScrollBars = true;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Numeric = BudgetExecution.Numeric.Accepted;
            this.DataGrid.Office2010ScrollBarsColorScheme = Syncfusion.Windows.Forms.Office2010ColorScheme.Black;
            this.DataGrid.OptimizeInsertRemoveCells = true;
            this.DataGrid.Properties.GridLineColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DataGrid.Properties.ThemedHeader = true;
            this.DataGrid.Setting = null;
            this.DataGrid.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.DataGrid.Size = new System.Drawing.Size(919, 586);
            this.DataGrid.SmartSizeBox = false;
            this.DataGrid.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.DataGrid.TabIndex = 0;
            gridStyleInfo2.AutoFit = Syncfusion.Windows.Forms.Grid.AutoFitOptions.Both;
            gridStyleInfo2.Font.Bold = false;
            gridStyleInfo2.Font.Facename = "Roboto";
            gridStyleInfo2.Font.Italic = false;
            gridStyleInfo2.Font.Size = 8F;
            gridStyleInfo2.Font.Strikeout = false;
            gridStyleInfo2.Font.Underline = false;
            gridStyleInfo2.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridStyleInfo2.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))));
            gridStyleInfo2.Themed = true;
            gridStyleInfo2.WrapText = false;
            this.DataGrid.TableStyle = gridStyleInfo2;
            this.DataGrid.Text = "dataView1";
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
            this.DataGrid.VerticalScrollTips = true;
            this.DataGrid.VerticalThumbTrack = true;
            // 
            // ElementListBox
            // 
            this.ElementListBox.AlternateColors = false;
            this.ElementListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ElementListBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ElementListBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ElementListBox.BindingSource = null;
            this.ElementListBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ElementListBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ElementListBox.Border.HoverVisible = true;
            this.ElementListBox.Border.Rounding = 6;
            this.ElementListBox.Border.Thickness = 1;
            this.ElementListBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ElementListBox.Border.Visible = true;
            this.ElementListBox.DataFilter = null;
            this.ElementListBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.ElementListBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.ElementListBox.ForeColor = System.Drawing.Color.White;
            this.ElementListBox.HoverText = null;
            this.ElementListBox.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ElementListBox.ItemHeight = 30;
            this.ElementListBox.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.ElementListBox.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ElementListBox.ItemSelected = System.Drawing.Color.SteelBlue;
            this.ElementListBox.Location = new System.Drawing.Point(1064, 522);
            this.ElementListBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ElementListBox.Name = "ElementListBox";
            this.ElementListBox.Numeric = BudgetExecution.Numeric.NS;
            this.ElementListBox.Size = new System.Drawing.Size(247, 132);
            this.ElementListBox.TabIndex = 4;
            this.ElementListBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ElementListBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ElementListBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ElementListBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ElementListBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ElementListBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ElementListBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ElementListBox.ToolTip = this.ToolTip;
            // 
            // ToolTip
            // 
            this.ToolTip.AutoPopDelay = 5000;
            this.ToolTip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.ToolTip.BindingSource = null;
            this.ToolTip.BorderColor = System.Drawing.SystemColors.Highlight;
            this.ToolTip.Field = BudgetExecution.Field.AccountCode;
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
            // ColumnListBox
            // 
            this.ColumnListBox.AlternateColors = false;
            this.ColumnListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.BindingSource = null;
            this.ColumnListBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ColumnListBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ColumnListBox.Border.HoverVisible = true;
            this.ColumnListBox.Border.Rounding = 6;
            this.ColumnListBox.Border.Thickness = 1;
            this.ColumnListBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ColumnListBox.Border.Visible = true;
            this.ColumnListBox.DataFilter = null;
            this.ColumnListBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.ColumnListBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.ColumnListBox.ForeColor = System.Drawing.Color.White;
            this.ColumnListBox.HoverText = null;
            this.ColumnListBox.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.ItemHeight = 30;
            this.ColumnListBox.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnListBox.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.ItemSelected = System.Drawing.Color.SteelBlue;
            this.ColumnListBox.Location = new System.Drawing.Point(1064, 315);
            this.ColumnListBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.Numeric = BudgetExecution.Numeric.NS;
            this.ColumnListBox.Size = new System.Drawing.Size(247, 145);
            this.ColumnListBox.TabIndex = 1;
            this.ColumnListBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ColumnListBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColumnListBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColumnListBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColumnListBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnListBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnListBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ColumnListBox.ToolTip = this.ToolTip;
            // 
            // ToolStrip
            // 
            this.ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStrip.BindingSource = this.BindingSource;
            this.ToolStrip.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolStrip.CanOverrideStyle = true;
            this.ToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            this.ToolStrip.CaptionFont = new System.Drawing.Font("Roboto", 9F);
            this.ToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            this.ToolStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.ToolStrip.DataFilter = null;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.DropDown = this.ToolStripDropDown;
            this.ToolStrip.Field = BudgetExecution.Field.AccountCode;
            this.ToolStrip.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.Image = null;
            this.ToolStrip.ImageDirectory = null;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.ImageSize = new System.Drawing.Size(0, 0);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripLabel,
            this.toolSeparator1,
            this.ToolStripTextBox,
            this.toolSeparator2,
            this.ToolStripDropDown,
            this.toolSeparator3,
            this.ToolStripFirstButton,
            this.toolSeparator4,
            this.ToolStripPreviousButton,
            this.toolSeparator5,
            this.ToolStripNextButton,
            this.toolSeparator6,
            this.ToolStripLastButton,
            this.toolSeparator7,
            this.ToolStripEditButton,
            this.toolSeparator8,
            this.ToolStripAddButton,
            this.toolSeparator9,
            this.ToolStripDeleteButton,
            this.toolSeparator10,
            this.ToolStripRefreshButton,
            this.toolSeparator11,
            this.ToolStripSaveButton,
            this.toolSeparator12,
            this.ToolStripCalculatorButton,
            this.toolSeparator13,
            this.ToolStripExcelButton,
            this.toolSeparator15,
            this.ToolStripChartButton,
            this.toolSeparator14,
            this.ToolStripHomeButton});
            this.ToolStrip.Label = this.ToolStripLabel;
            this.ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.ToolStrip.Location = new System.Drawing.Point(0, 711);
            this.ToolStrip.Margin = new System.Windows.Forms.Padding(1);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.Numeric = BudgetExecution.Numeric.Accepted;
            this.ToolStrip.Office12Mode = false;
            this.ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(1);
            this.ToolStrip.Separators = null;
            this.ToolStrip.ShowCaption = true;
            this.ToolStrip.ShowLauncher = true;
            this.ToolStrip.Size = new System.Drawing.Size(1388, 52);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.TextBox = this.ToolStripTextBox;
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
            // ToolStripDropDown
            // 
            this.ToolStripDropDown.AllowDrop = true;
            this.ToolStripDropDown.BindingSource = null;
            this.ToolStripDropDown.DataFilter = null;
            this.ToolStripDropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ToolStripDropDown.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripDropDown.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripDropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.ToolStripDropDown.HoverText = "Make Selection";
            this.ToolStripDropDown.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripDropDown.MaxDropDownItems = 100;
            this.ToolStripDropDown.MaxLength = 32767;
            this.ToolStripDropDown.Name = "ToolStripDropDown";
            this.ToolStripDropDown.Numeric = BudgetExecution.Numeric.Accepted;
            this.ToolStripDropDown.Size = new System.Drawing.Size(200, 26);
            this.ToolStripDropDown.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            this.ToolStripDropDown.Tag = "Make Selection";
            this.ToolStripDropDown.ToolTip = this.ToolTip;
            this.ToolStripDropDown.ToolTipText = "Make Selection";
            // 
            // ToolStripLabel
            // 
            this.ToolStripLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ToolStripLabel.BindingSource = null;
            this.ToolStripLabel.DataFilter = null;
            this.ToolStripLabel.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripLabel.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripLabel.ForeColor = System.Drawing.Color.White;
            this.ToolStripLabel.HoverText = null;
            this.ToolStripLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripLabel.Name = "ToolStripLabel";
            this.ToolStripLabel.Size = new System.Drawing.Size(89, 26);
            this.ToolStripLabel.Tag = "";
            this.ToolStripLabel.Text = "toolStripLabel1";
            this.ToolStripLabel.ToolTip = null;
            // 
            // toolSeparator1
            // 
            this.toolSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator1.Name = "toolSeparator1";
            this.toolSeparator1.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripTextBox
            // 
            this.ToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripTextBox.BindingSource = null;
            this.ToolStripTextBox.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripTextBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripTextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.ToolStripTextBox.HoverText = "";
            this.ToolStripTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripTextBox.Name = "ToolStripTextBox";
            this.ToolStripTextBox.Size = new System.Drawing.Size(150, 26);
            this.ToolStripTextBox.Tag = "";
            this.ToolStripTextBox.ToolTip = null;
            // 
            // toolSeparator2
            // 
            this.toolSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator2.Name = "toolSeparator2";
            this.toolSeparator2.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // toolSeparator3
            // 
            this.toolSeparator3.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator3.Name = "toolSeparator3";
            this.toolSeparator3.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripFirstButton
            // 
            this.ToolStripFirstButton.AutoToolTip = false;
            this.ToolStripFirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripFirstButton.BindingSource = this.BindingSource;
            this.ToolStripFirstButton.DataFilter = null;
            this.ToolStripFirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripFirstButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripFirstButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripFirstButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripFirstButton.HoverText = null;
            this.ToolStripFirstButton.Image = global::BudgetExecution.Properties.Resources.FirstButton;
            this.ToolStripFirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripFirstButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripFirstButton.Name = "ToolStripFirstButton";
            this.ToolStripFirstButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripFirstButton.Text = "toolStripButton1";
            this.ToolStripFirstButton.ToolTip = this.ToolTip;
            this.ToolStripFirstButton.ToolType = BudgetExecution.ToolType.FirstButton;
            // 
            // toolSeparator4
            // 
            this.toolSeparator4.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator4.Name = "toolSeparator4";
            this.toolSeparator4.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator4.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripPreviousButton
            // 
            this.ToolStripPreviousButton.AutoToolTip = false;
            this.ToolStripPreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripPreviousButton.BindingSource = this.BindingSource;
            this.ToolStripPreviousButton.DataFilter = null;
            this.ToolStripPreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripPreviousButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripPreviousButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripPreviousButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripPreviousButton.HoverText = null;
            this.ToolStripPreviousButton.Image = global::BudgetExecution.Properties.Resources.PreviousButton;
            this.ToolStripPreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripPreviousButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripPreviousButton.Name = "ToolStripPreviousButton";
            this.ToolStripPreviousButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripPreviousButton.Text = "toolStripButton2";
            this.ToolStripPreviousButton.ToolTip = null;
            this.ToolStripPreviousButton.ToolType = BudgetExecution.ToolType.PreviousButton;
            // 
            // toolSeparator5
            // 
            this.toolSeparator5.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator5.Name = "toolSeparator5";
            this.toolSeparator5.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator5.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripNextButton
            // 
            this.ToolStripNextButton.AutoToolTip = false;
            this.ToolStripNextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripNextButton.BindingSource = this.BindingSource;
            this.ToolStripNextButton.DataFilter = null;
            this.ToolStripNextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripNextButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripNextButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripNextButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripNextButton.HoverText = null;
            this.ToolStripNextButton.Image = global::BudgetExecution.Properties.Resources.NextButton;
            this.ToolStripNextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripNextButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripNextButton.Name = "ToolStripNextButton";
            this.ToolStripNextButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripNextButton.Text = "toolStripButton3";
            this.ToolStripNextButton.ToolTip = null;
            this.ToolStripNextButton.ToolType = BudgetExecution.ToolType.NextButton;
            // 
            // toolSeparator6
            // 
            this.toolSeparator6.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator6.Name = "toolSeparator6";
            this.toolSeparator6.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator6.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripLastButton
            // 
            this.ToolStripLastButton.AutoToolTip = false;
            this.ToolStripLastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripLastButton.BindingSource = this.BindingSource;
            this.ToolStripLastButton.DataFilter = null;
            this.ToolStripLastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripLastButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripLastButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripLastButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripLastButton.HoverText = null;
            this.ToolStripLastButton.Image = global::BudgetExecution.Properties.Resources.LastButton;
            this.ToolStripLastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripLastButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripLastButton.Name = "ToolStripLastButton";
            this.ToolStripLastButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripLastButton.Text = "toolStripButton4";
            this.ToolStripLastButton.ToolTip = null;
            this.ToolStripLastButton.ToolType = BudgetExecution.ToolType.LastButton;
            // 
            // toolSeparator7
            // 
            this.toolSeparator7.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator7.Name = "toolSeparator7";
            this.toolSeparator7.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator7.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripEditButton
            // 
            this.ToolStripEditButton.AutoToolTip = false;
            this.ToolStripEditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripEditButton.BindingSource = null;
            this.ToolStripEditButton.DataFilter = null;
            this.ToolStripEditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripEditButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripEditButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripEditButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripEditButton.HoverText = null;
            this.ToolStripEditButton.Image = global::BudgetExecution.Properties.Resources.EditButton;
            this.ToolStripEditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripEditButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripEditButton.Name = "ToolStripEditButton";
            this.ToolStripEditButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripEditButton.Text = "toolStripButton5";
            this.ToolStripEditButton.ToolTip = null;
            this.ToolStripEditButton.ToolType = BudgetExecution.ToolType.EditButton;
            // 
            // toolSeparator8
            // 
            this.toolSeparator8.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator8.Name = "toolSeparator8";
            this.toolSeparator8.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator8.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripAddButton
            // 
            this.ToolStripAddButton.AutoToolTip = false;
            this.ToolStripAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripAddButton.BindingSource = null;
            this.ToolStripAddButton.DataFilter = null;
            this.ToolStripAddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripAddButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripAddButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripAddButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripAddButton.HoverText = null;
            this.ToolStripAddButton.Image = global::BudgetExecution.Properties.Resources.AddButton;
            this.ToolStripAddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripAddButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripAddButton.Name = "ToolStripAddButton";
            this.ToolStripAddButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripAddButton.Text = "toolStripButton6";
            this.ToolStripAddButton.ToolTip = null;
            this.ToolStripAddButton.ToolType = BudgetExecution.ToolType.AddButton;
            // 
            // toolSeparator9
            // 
            this.toolSeparator9.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator9.Name = "toolSeparator9";
            this.toolSeparator9.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator9.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripDeleteButton
            // 
            this.ToolStripDeleteButton.AutoToolTip = false;
            this.ToolStripDeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripDeleteButton.BindingSource = null;
            this.ToolStripDeleteButton.DataFilter = null;
            this.ToolStripDeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripDeleteButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripDeleteButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripDeleteButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripDeleteButton.HoverText = null;
            this.ToolStripDeleteButton.Image = global::BudgetExecution.Properties.Resources.DeleteButton;
            this.ToolStripDeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripDeleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripDeleteButton.Name = "ToolStripDeleteButton";
            this.ToolStripDeleteButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripDeleteButton.Text = "toolStripButton7";
            this.ToolStripDeleteButton.ToolTip = null;
            this.ToolStripDeleteButton.ToolType = BudgetExecution.ToolType.DeleteButton;
            // 
            // toolSeparator10
            // 
            this.toolSeparator10.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator10.Name = "toolSeparator10";
            this.toolSeparator10.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator10.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripRefreshButton
            // 
            this.ToolStripRefreshButton.AutoToolTip = false;
            this.ToolStripRefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripRefreshButton.BindingSource = null;
            this.ToolStripRefreshButton.DataFilter = null;
            this.ToolStripRefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripRefreshButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripRefreshButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripRefreshButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripRefreshButton.HoverText = null;
            this.ToolStripRefreshButton.Image = global::BudgetExecution.Properties.Resources.RefreshButton;
            this.ToolStripRefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripRefreshButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripRefreshButton.Name = "ToolStripRefreshButton";
            this.ToolStripRefreshButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripRefreshButton.Text = "toolStripButton8";
            this.ToolStripRefreshButton.ToolTip = null;
            this.ToolStripRefreshButton.ToolType = BudgetExecution.ToolType.RefreshButton;
            // 
            // toolSeparator11
            // 
            this.toolSeparator11.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator11.Name = "toolSeparator11";
            this.toolSeparator11.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator11.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripSaveButton
            // 
            this.ToolStripSaveButton.AutoToolTip = false;
            this.ToolStripSaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripSaveButton.BindingSource = null;
            this.ToolStripSaveButton.DataFilter = null;
            this.ToolStripSaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripSaveButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripSaveButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripSaveButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripSaveButton.HoverText = null;
            this.ToolStripSaveButton.Image = global::BudgetExecution.Properties.Resources.SaveButton;
            this.ToolStripSaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripSaveButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripSaveButton.Name = "ToolStripSaveButton";
            this.ToolStripSaveButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripSaveButton.Text = "toolStripButton9";
            this.ToolStripSaveButton.ToolTip = null;
            this.ToolStripSaveButton.ToolType = BudgetExecution.ToolType.SaveButton;
            // 
            // toolSeparator12
            // 
            this.toolSeparator12.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator12.Name = "toolSeparator12";
            this.toolSeparator12.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator12.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripCalculatorButton
            // 
            this.ToolStripCalculatorButton.AutoToolTip = false;
            this.ToolStripCalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripCalculatorButton.BindingSource = null;
            this.ToolStripCalculatorButton.DataFilter = null;
            this.ToolStripCalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripCalculatorButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripCalculatorButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripCalculatorButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripCalculatorButton.HoverText = null;
            this.ToolStripCalculatorButton.Image = global::BudgetExecution.Properties.Resources.CalculatorButton;
            this.ToolStripCalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripCalculatorButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripCalculatorButton.Name = "ToolStripCalculatorButton";
            this.ToolStripCalculatorButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripCalculatorButton.Text = "toolStripButton10";
            this.ToolStripCalculatorButton.ToolTip = null;
            this.ToolStripCalculatorButton.ToolType = BudgetExecution.ToolType.CalculatorButton;
            // 
            // toolSeparator13
            // 
            this.toolSeparator13.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator13.Name = "toolSeparator13";
            this.toolSeparator13.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator13.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripExcelButton
            // 
            this.ToolStripExcelButton.AutoToolTip = false;
            this.ToolStripExcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripExcelButton.BindingSource = null;
            this.ToolStripExcelButton.DataFilter = null;
            this.ToolStripExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripExcelButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripExcelButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripExcelButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripExcelButton.HoverText = null;
            this.ToolStripExcelButton.Image = global::BudgetExecution.Properties.Resources.ExcelButton;
            this.ToolStripExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripExcelButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripExcelButton.Name = "ToolStripExcelButton";
            this.ToolStripExcelButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripExcelButton.Text = "toolStripButton11";
            this.ToolStripExcelButton.ToolTip = null;
            this.ToolStripExcelButton.ToolType = BudgetExecution.ToolType.ExcelButton;
            // 
            // toolSeparator15
            // 
            this.toolSeparator15.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator15.Name = "toolSeparator15";
            this.toolSeparator15.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator15.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripChartButton
            // 
            this.ToolStripChartButton.AutoToolTip = false;
            this.ToolStripChartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripChartButton.BindingSource = null;
            this.ToolStripChartButton.DataFilter = null;
            this.ToolStripChartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripChartButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripChartButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripChartButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripChartButton.HoverText = null;
            this.ToolStripChartButton.Image = global::BudgetExecution.Properties.Resources.ChartButton;
            this.ToolStripChartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripChartButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripChartButton.Name = "ToolStripChartButton";
            this.ToolStripChartButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripChartButton.Text = "toolStripButton12";
            this.ToolStripChartButton.ToolTip = null;
            this.ToolStripChartButton.ToolType = BudgetExecution.ToolType.ChartButton;
            // 
            // toolSeparator14
            // 
            this.toolSeparator14.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator14.Name = "toolSeparator14";
            this.toolSeparator14.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator14.Size = new System.Drawing.Size(6, 36);
            // 
            // ToolStripHomeButton
            // 
            this.ToolStripHomeButton.AutoToolTip = false;
            this.ToolStripHomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStripHomeButton.BindingSource = null;
            this.ToolStripHomeButton.DataFilter = null;
            this.ToolStripHomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ToolStripHomeButton.Field = BudgetExecution.Field.AccountCode;
            this.ToolStripHomeButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripHomeButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ToolStripHomeButton.HoverText = null;
            this.ToolStripHomeButton.Image = global::BudgetExecution.Properties.Resources.HomeButton;
            this.ToolStripHomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ToolStripHomeButton.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripHomeButton.Name = "ToolStripHomeButton";
            this.ToolStripHomeButton.Size = new System.Drawing.Size(24, 26);
            this.ToolStripHomeButton.Text = "toolStripButton13";
            this.ToolStripHomeButton.ToolTip = this.ToolTip;
            this.ToolStripHomeButton.ToolType = BudgetExecution.ToolType.HomeButton;
            // 
            // TableListBox
            // 
            this.TableListBox.AlternateColors = false;
            this.TableListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.BindingSource = null;
            this.TableListBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.TableListBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.TableListBox.Border.HoverVisible = true;
            this.TableListBox.Border.Rounding = 6;
            this.TableListBox.Border.Thickness = 1;
            this.TableListBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TableListBox.Border.Visible = true;
            this.TableListBox.DataFilter = null;
            this.TableListBox.Field = BudgetExecution.Field.AccountCode;
            this.TableListBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.TableListBox.ForeColor = System.Drawing.Color.White;
            this.TableListBox.HoverText = null;
            this.TableListBox.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.ItemHeight = 30;
            this.TableListBox.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.TableListBox.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.ItemSelected = System.Drawing.Color.SteelBlue;
            this.TableListBox.Location = new System.Drawing.Point(1064, 97);
            this.TableListBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TableListBox.Name = "TableListBox";
            this.TableListBox.Numeric = BudgetExecution.Numeric.Accepted;
            this.TableListBox.Size = new System.Drawing.Size(247, 155);
            this.TableListBox.TabIndex = 5;
            this.TableListBox.Text = "listBox1";
            this.TableListBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TableListBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableListBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableListBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableListBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TableListBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TableListBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TableListBox.ToolTip = null;
            // 
            // visualLabel1
            // 
            this.visualLabel1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualLabel1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.visualLabel1.Location = new System.Drawing.Point(1064, 68);
            this.visualLabel1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel1.Name = "visualLabel1";
            this.visualLabel1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel1.Outline = false;
            this.visualLabel1.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel1.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.ReflectionSpacing = 0;
            this.visualLabel1.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel1.ShadowDirection = 315;
            this.visualLabel1.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel1.ShadowOpacity = 100;
            this.visualLabel1.Size = new System.Drawing.Size(247, 23);
            this.visualLabel1.TabIndex = 6;
            this.visualLabel1.Text = "Data Tables";
            this.visualLabel1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabel1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualLabel1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualLabel2
            // 
            this.visualLabel2.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualLabel2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.visualLabel2.Location = new System.Drawing.Point(1064, 286);
            this.visualLabel2.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel2.Name = "visualLabel2";
            this.visualLabel2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel2.Outline = false;
            this.visualLabel2.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel2.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel2.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel2.ReflectionSpacing = 0;
            this.visualLabel2.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel2.ShadowDirection = 315;
            this.visualLabel2.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel2.ShadowOpacity = 100;
            this.visualLabel2.Size = new System.Drawing.Size(247, 23);
            this.visualLabel2.TabIndex = 7;
            this.visualLabel2.Text = "Data Columns";
            this.visualLabel2.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabel2.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel2.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualLabel2.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel2.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel2.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel2.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel2.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel2.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // visualLabel3
            // 
            this.visualLabel3.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.visualLabel3.ForeColor = System.Drawing.SystemColors.Highlight;
            this.visualLabel3.Location = new System.Drawing.Point(1064, 493);
            this.visualLabel3.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.visualLabel3.Name = "visualLabel3";
            this.visualLabel3.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.visualLabel3.Outline = false;
            this.visualLabel3.OutlineColor = System.Drawing.Color.Red;
            this.visualLabel3.OutlineLocation = new System.Drawing.Point(0, 0);
            this.visualLabel3.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel3.ReflectionSpacing = 0;
            this.visualLabel3.ShadowColor = System.Drawing.Color.Black;
            this.visualLabel3.ShadowDirection = 315;
            this.visualLabel3.ShadowLocation = new System.Drawing.Point(0, 0);
            this.visualLabel3.ShadowOpacity = 100;
            this.visualLabel3.Size = new System.Drawing.Size(247, 23);
            this.visualLabel3.TabIndex = 8;
            this.visualLabel3.Text = "Unique Values";
            this.visualLabel3.TextAlignment = System.Drawing.StringAlignment.Near;
            this.visualLabel3.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel3.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.visualLabel3.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel3.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel3.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.visualLabel3.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel3.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.visualLabel3.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // DataViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Maroon;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ClientSize = new System.Drawing.Size(1388, 763);
            this.Controls.Add(this.visualLabel3);
            this.Controls.Add(this.visualLabel2);
            this.Controls.Add(this.visualLabel1);
            this.Controls.Add(this.TableListBox);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.ElementListBox);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.ColumnListBox);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MinimizeBox = false;
            this.Name = "DataViewForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.GridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel GridPanel;
        public ListBox ColumnListBox;
        public ToolStrip ToolStrip;
        public ListBox ElementListBox;
        public DataView DataGrid;
        private ToolTip ToolTip;
        private System.Windows.Forms.BindingSource BindingSource;
        private ToolSeparator toolSeparator1;
        private ToolStripTextBox ToolStripTextBox;
        private ToolSeparator toolSeparator2;
        private ToolSeparator toolSeparator3;
        public ToolStripButton ToolStripFirstButton;
        private ToolSeparator toolSeparator4;
        public ToolStripButton ToolStripPreviousButton;
        private ToolSeparator toolSeparator5;
        public ToolStripButton ToolStripNextButton;
        private ToolSeparator toolSeparator6;
        public ToolStripButton ToolStripLastButton;
        private ToolSeparator toolSeparator7;
        public ToolStripButton ToolStripEditButton;
        private ToolSeparator toolSeparator8;
        public ToolStripButton ToolStripAddButton;
        private ToolSeparator toolSeparator9;
        public ToolStripButton ToolStripDeleteButton;
        private ToolSeparator toolSeparator10;
        public ToolStripButton ToolStripRefreshButton;
        private ToolSeparator toolSeparator11;
        public ToolStripButton ToolStripSaveButton;
        private ToolSeparator toolSeparator12;
        public ToolStripButton ToolStripCalculatorButton;
        private ToolSeparator toolSeparator13;
        public ToolStripButton ToolStripExcelButton;
        private ToolSeparator toolSeparator15;
        public ToolStripButton ToolStripChartButton;
        private ToolSeparator toolSeparator14;
        public ToolStripButton ToolStripHomeButton;
        public ToolStripLabel ToolStripLabel;
        public ToolStripDropDown ToolStripDropDown;
        public ListBox TableListBox;
        public VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
        public VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel2;
        public VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel3;
    }
}