namespace BudgetExecution
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
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridStyleInfo gridStyleInfo1 = new Syncfusion.Windows.Forms.Grid.GridStyleInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewForm));
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGrid = new BudgetExecution.DataView();
            this.ElementListBox = new BudgetExecution.ListBox();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.ColumnListBox = new BudgetExecution.ListBox();
            this.TableListBox = new BudgetExecution.ListBox();
            this.visualLabel1 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel2 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.visualLabel3 = new VisualPlus.Toolkit.Controls.Interactivity.VisualLabel();
            this.GridPanel = new BudgetExecution.Layout();
            this.label1 = new BudgetExecution.Label();
            this.DataSourceLabel = new BudgetExecution.Label();
            this.ToolStrip = new BudgetExecution.ToolStrip();
            this.toolSeparator1 = new BudgetExecution.ToolSeparator();
            this.toolStripLabel1 = new BudgetExecution.ToolStripLabel();
            this.toolSeparator2 = new BudgetExecution.ToolSeparator();
            this.toolStripTextBox1 = new BudgetExecution.ToolStripTextBox();
            this.toolSeparator3 = new BudgetExecution.ToolSeparator();
            this.DropDown = new BudgetExecution.ToolStripDropDown();
            this.toolStripButton1 = new BudgetExecution.ToolStripButton();
            this.toolSeparator4 = new BudgetExecution.ToolSeparator();
            this.toolStripButton2 = new BudgetExecution.ToolStripButton();
            this.toolSeparator5 = new BudgetExecution.ToolSeparator();
            this.toolStripButton3 = new BudgetExecution.ToolStripButton();
            this.toolSeparator6 = new BudgetExecution.ToolSeparator();
            this.toolStripButton4 = new BudgetExecution.ToolStripButton();
            this.toolSeparator7 = new BudgetExecution.ToolSeparator();
            this.toolSeparator8 = new BudgetExecution.ToolSeparator();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.GridPanel.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // DataGrid
            // 
            this.DataGrid.AllowDragSelectedCols = true;
            this.DataGrid.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.DataGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DataGrid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            gridBaseStyle1.Name = "Column Header";
            gridBaseStyle1.StyleInfo.BaseStyle = "Header";
            gridBaseStyle1.StyleInfo.CellType = "ColumnHeaderCell";
            gridBaseStyle1.StyleInfo.Enabled = false;
            gridBaseStyle1.StyleInfo.Font.Bold = true;
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
            gridBaseStyle4.StyleInfo.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Left;
            this.DataGrid.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.DataGrid.BindingSource = this.BindingSource;
            this.DataGrid.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2016Black;
            this.DataGrid.DataFilter = null;
            this.DataGrid.DataMember = "";
            this.DataGrid.DefaultRowHeight = 20;
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
            this.DataGrid.Location = new System.Drawing.Point(15, 15);
            this.DataGrid.MetroScrollBars = true;
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.Numeric = BudgetExecution.Numeric.Accepted;
            this.DataGrid.Office2010ScrollBarsColorScheme = Syncfusion.Windows.Forms.Office2010ColorScheme.Black;
            this.DataGrid.OptimizeInsertRemoveCells = true;
            this.DataGrid.Properties.GridLineColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.DataGrid.Properties.ThemedHeader = true;
            this.DataGrid.Setting = null;
            this.DataGrid.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.DataGrid.Size = new System.Drawing.Size(985, 504);
            this.DataGrid.SmartSizeBox = false;
            this.DataGrid.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.DataGrid.TabIndex = 0;
            gridStyleInfo1.AutoFit = Syncfusion.Windows.Forms.Grid.AutoFitOptions.Both;
            gridStyleInfo1.Font.Bold = false;
            gridStyleInfo1.Font.Facename = "Roboto";
            gridStyleInfo1.Font.Italic = false;
            gridStyleInfo1.Font.Size = 8F;
            gridStyleInfo1.Font.Strikeout = false;
            gridStyleInfo1.Font.Underline = false;
            gridStyleInfo1.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridStyleInfo1.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30))))));
            gridStyleInfo1.Themed = true;
            gridStyleInfo1.WrapText = false;
            this.DataGrid.TableStyle = gridStyleInfo1;
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
            this.ElementListBox.Border.Color = System.Drawing.SystemColors.Highlight;
            this.ElementListBox.Border.HoverColor = System.Drawing.SystemColors.Highlight;
            this.ElementListBox.Border.HoverVisible = true;
            this.ElementListBox.Border.Rounding = 6;
            this.ElementListBox.Border.Thickness = 1;
            this.ElementListBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ElementListBox.Border.Visible = true;
            this.ElementListBox.DataFilter = null;
            this.ElementListBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.ElementListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ElementListBox.ForeColor = System.Drawing.Color.White;
            this.ElementListBox.HoverText = null;
            this.ElementListBox.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ElementListBox.ItemHeight = 30;
            this.ElementListBox.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.ElementListBox.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ElementListBox.ItemSelected = System.Drawing.Color.SteelBlue;
            this.ElementListBox.Location = new System.Drawing.Point(1110, 503);
            this.ElementListBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ElementListBox.Name = "ElementListBox";
            this.ElementListBox.Numeric = BudgetExecution.Numeric.NS;
            this.ElementListBox.Size = new System.Drawing.Size(299, 132);
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
            this.ColumnListBox.Border.Color = System.Drawing.SystemColors.Highlight;
            this.ColumnListBox.Border.HoverColor = System.Drawing.SystemColors.Highlight;
            this.ColumnListBox.Border.HoverVisible = true;
            this.ColumnListBox.Border.Rounding = 6;
            this.ColumnListBox.Border.Thickness = 1;
            this.ColumnListBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ColumnListBox.Border.Visible = true;
            this.ColumnListBox.DataFilter = null;
            this.ColumnListBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.ColumnListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnListBox.ForeColor = System.Drawing.Color.White;
            this.ColumnListBox.HoverText = null;
            this.ColumnListBox.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.ItemHeight = 30;
            this.ColumnListBox.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnListBox.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.ItemSelected = System.Drawing.Color.SteelBlue;
            this.ColumnListBox.Location = new System.Drawing.Point(1110, 305);
            this.ColumnListBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.Numeric = BudgetExecution.Numeric.NS;
            this.ColumnListBox.Size = new System.Drawing.Size(299, 145);
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
            // TableListBox
            // 
            this.TableListBox.AlternateColors = false;
            this.TableListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.BindingSource = null;
            this.TableListBox.Border.Color = System.Drawing.SystemColors.Highlight;
            this.TableListBox.Border.HoverColor = System.Drawing.SystemColors.Highlight;
            this.TableListBox.Border.HoverVisible = true;
            this.TableListBox.Border.Rounding = 6;
            this.TableListBox.Border.Thickness = 1;
            this.TableListBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TableListBox.Border.Visible = true;
            this.TableListBox.DataFilter = null;
            this.TableListBox.Field = BudgetExecution.Field.AccountCode;
            this.TableListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableListBox.ForeColor = System.Drawing.Color.White;
            this.TableListBox.HoverText = null;
            this.TableListBox.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.ItemHeight = 30;
            this.TableListBox.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.TableListBox.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.ItemSelected = System.Drawing.Color.SteelBlue;
            this.TableListBox.Location = new System.Drawing.Point(1110, 97);
            this.TableListBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TableListBox.Name = "TableListBox";
            this.TableListBox.Numeric = BudgetExecution.Numeric.Accepted;
            this.TableListBox.Size = new System.Drawing.Size(299, 155);
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
            this.visualLabel1.Location = new System.Drawing.Point(1110, 68);
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
            this.visualLabel1.Size = new System.Drawing.Size(275, 23);
            this.visualLabel1.TabIndex = 6;
            this.visualLabel1.Text = "Tables";
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
            this.visualLabel2.Location = new System.Drawing.Point(1110, 276);
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
            this.visualLabel2.Size = new System.Drawing.Size(275, 23);
            this.visualLabel2.TabIndex = 7;
            this.visualLabel2.Text = "Columns";
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
            this.visualLabel3.Location = new System.Drawing.Point(1110, 474);
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
            this.visualLabel3.Size = new System.Drawing.Size(275, 23);
            this.visualLabel3.TabIndex = 8;
            this.visualLabel3.Text = "Values";
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
            // GridPanel
            // 
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GridPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GridPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GridPanel.BindingSource = null;
            this.GridPanel.Border.Color = System.Drawing.SystemColors.Highlight;
            this.GridPanel.Border.HoverColor = System.Drawing.SystemColors.Highlight;
            this.GridPanel.Border.HoverVisible = true;
            this.GridPanel.Border.Rounding = 6;
            this.GridPanel.Border.Thickness = 1;
            this.GridPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.GridPanel.Border.Visible = true;
            this.GridPanel.Children = null;
            this.GridPanel.Controls.Add(this.DataGrid);
            this.GridPanel.DataFilter = null;
            this.GridPanel.Field = BudgetExecution.Field.AccountCode;
            this.GridPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.GridPanel.HoverText = null;
            this.GridPanel.Location = new System.Drawing.Point(50, 97);
            this.GridPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Numeric = BudgetExecution.Numeric.Accepted;
            this.GridPanel.Padding = new System.Windows.Forms.Padding(1);
            this.GridPanel.Size = new System.Drawing.Size(1019, 538);
            this.GridPanel.TabIndex = 9;
            this.GridPanel.Text = "layout1";
            this.GridPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.GridPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GridPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GridPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GridPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GridPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GridPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GridPanel.ToolTip = null;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.BindingSource = null;
            this.label1.DataFilter = null;
            this.label1.Field = BudgetExecution.Field.AccountCode;
            this.label1.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.HoverText = null;
            this.label1.Location = new System.Drawing.Point(50, 68);
            this.label1.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.label1.Name = "label1";
            this.label1.Numeric = BudgetExecution.Numeric.Accepted;
            this.label1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.label1.Outline = false;
            this.label1.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.label1.OutlineLocation = new System.Drawing.Point(0, 0);
            this.label1.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.ReflectionSpacing = 0;
            this.label1.ShadowColor = System.Drawing.Color.Black;
            this.label1.ShadowDirection = 315;
            this.label1.ShadowLocation = new System.Drawing.Point(0, 0);
            this.label1.ShadowOpacity = 100;
            this.label1.Size = new System.Drawing.Size(92, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Data Source: ";
            this.label1.TextAlignment = System.Drawing.StringAlignment.Near;
            this.label1.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.label1.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.label1.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label1.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.label1.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.label1.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.label1.ToolTip = null;
            // 
            // DataSourceLabel
            // 
            this.DataSourceLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DataSourceLabel.BindingSource = null;
            this.DataSourceLabel.DataFilter = null;
            this.DataSourceLabel.Field = BudgetExecution.Field.AccountCode;
            this.DataSourceLabel.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DataSourceLabel.ForeColor = System.Drawing.SystemColors.Highlight;
            this.DataSourceLabel.HoverText = null;
            this.DataSourceLabel.Location = new System.Drawing.Point(148, 68);
            this.DataSourceLabel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.DataSourceLabel.Name = "DataSourceLabel";
            this.DataSourceLabel.Numeric = BudgetExecution.Numeric.Accepted;
            this.DataSourceLabel.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.DataSourceLabel.Outline = false;
            this.DataSourceLabel.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DataSourceLabel.OutlineLocation = new System.Drawing.Point(0, 0);
            this.DataSourceLabel.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DataSourceLabel.ReflectionSpacing = 0;
            this.DataSourceLabel.ShadowColor = System.Drawing.Color.Black;
            this.DataSourceLabel.ShadowDirection = 315;
            this.DataSourceLabel.ShadowLocation = new System.Drawing.Point(0, 0);
            this.DataSourceLabel.ShadowOpacity = 100;
            this.DataSourceLabel.Size = new System.Drawing.Size(878, 23);
            this.DataSourceLabel.TabIndex = 11;
            this.DataSourceLabel.TextAlignment = System.Drawing.StringAlignment.Near;
            this.DataSourceLabel.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.DataSourceLabel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.DataSourceLabel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DataSourceLabel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DataSourceLabel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DataSourceLabel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.DataSourceLabel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.DataSourceLabel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.DataSourceLabel.ToolTip = null;
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
            this.ToolStrip.DropDown = this.DropDown;
            this.ToolStrip.Field = BudgetExecution.Field.AccountCode;
            this.ToolStrip.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.Image = null;
            this.ToolStrip.ImageDirectory = null;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.ImageSize = new System.Drawing.Size(0, 0);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolSeparator1,
            this.toolStripLabel1,
            this.toolSeparator2,
            this.toolStripTextBox1,
            this.toolSeparator3,
            this.DropDown,
            this.toolStripButton1,
            this.toolSeparator4,
            this.toolStripButton2,
            this.toolSeparator5,
            this.toolStripButton3,
            this.toolSeparator6,
            this.toolStripButton4,
            this.toolSeparator7});
            this.ToolStrip.Label = null;
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
            this.ToolStrip.Size = new System.Drawing.Size(1445, 52);
            this.ToolStrip.TabIndex = 12;
            this.ToolStrip.Text = "toolStrip1";
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
            // toolSeparator1
            // 
            this.toolSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator1.Name = "toolSeparator1";
            this.toolSeparator1.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator1.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.toolStripLabel1.BindingSource = null;
            this.toolStripLabel1.DataFilter = null;
            this.toolStripLabel1.Field = BudgetExecution.Field.AccountCode;
            this.toolStripLabel1.Font = new System.Drawing.Font("Roboto", 9F);
            this.toolStripLabel1.ForeColor = System.Drawing.Color.White;
            this.toolStripLabel1.HoverText = null;
            this.toolStripLabel1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(89, 26);
            this.toolStripLabel1.Tag = "";
            this.toolStripLabel1.Text = "toolStripLabel1";
            this.toolStripLabel1.ToolTip = null;
            // 
            // toolSeparator2
            // 
            this.toolSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator2.Name = "toolSeparator2";
            this.toolSeparator2.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator2.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.toolStripTextBox1.BindingSource = null;
            this.toolStripTextBox1.Field = BudgetExecution.Field.AccountCode;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Roboto", 9F);
            this.toolStripTextBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.toolStripTextBox1.HoverText = "";
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(150, 26);
            this.toolStripTextBox1.Tag = "";
            this.toolStripTextBox1.ToolTip = null;
            // 
            // toolSeparator3
            // 
            this.toolSeparator3.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator3.Name = "toolSeparator3";
            this.toolSeparator3.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator3.Size = new System.Drawing.Size(6, 36);
            // 
            // DropDown
            // 
            this.DropDown.AllowDrop = true;
            this.DropDown.BindingSource = null;
            this.DropDown.DataFilter = null;
            this.DropDown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DropDown.Field = BudgetExecution.Field.AccountCode;
            this.DropDown.Font = new System.Drawing.Font("Roboto", 9F);
            this.DropDown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.DropDown.HoverText = "Make Selection";
            this.DropDown.Margin = new System.Windows.Forms.Padding(5);
            this.DropDown.MaxDropDownItems = 100;
            this.DropDown.MaxLength = 32767;
            this.DropDown.Name = "DropDown";
            this.DropDown.Numeric = BudgetExecution.Numeric.Accepted;
            this.DropDown.Size = new System.Drawing.Size(200, 26);
            this.DropDown.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            this.DropDown.Tag = "Make Selection";
            this.DropDown.ToolTip = this.ToolTip;
            this.DropDown.ToolTipText = "Make Selection";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.AutoToolTip = false;
            this.toolStripButton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.toolStripButton1.BindingSource = null;
            this.toolStripButton1.DataFilter = null;
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton1.Field = BudgetExecution.Field.AccountCode;
            this.toolStripButton1.Font = new System.Drawing.Font("Roboto", 9F);
            this.toolStripButton1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripButton1.HoverText = null;
            this.toolStripButton1.Image = global::BudgetExecution.Properties.Resources.FirstButton;
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(24, 26);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.ToolTip = null;
            this.toolStripButton1.ToolType = BudgetExecution.ToolType.FirstButton;
            // 
            // toolSeparator4
            // 
            this.toolSeparator4.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator4.Name = "toolSeparator4";
            this.toolSeparator4.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator4.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.AutoToolTip = false;
            this.toolStripButton2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.toolStripButton2.BindingSource = null;
            this.toolStripButton2.DataFilter = null;
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton2.Field = BudgetExecution.Field.AccountCode;
            this.toolStripButton2.Font = new System.Drawing.Font("Roboto", 9F);
            this.toolStripButton2.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripButton2.HoverText = null;
            this.toolStripButton2.Image = global::BudgetExecution.Properties.Resources.PreviousButton;
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(24, 26);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.ToolTip = null;
            this.toolStripButton2.ToolType = BudgetExecution.ToolType.PreviousButton;
            // 
            // toolSeparator5
            // 
            this.toolSeparator5.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator5.Name = "toolSeparator5";
            this.toolSeparator5.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator5.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.AutoToolTip = false;
            this.toolStripButton3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.toolStripButton3.BindingSource = null;
            this.toolStripButton3.DataFilter = null;
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Field = BudgetExecution.Field.AccountCode;
            this.toolStripButton3.Font = new System.Drawing.Font("Roboto", 9F);
            this.toolStripButton3.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripButton3.HoverText = null;
            this.toolStripButton3.Image = global::BudgetExecution.Properties.Resources.NextButton;
            this.toolStripButton3.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton3.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.Size = new System.Drawing.Size(24, 26);
            this.toolStripButton3.Text = "toolStripButton3";
            this.toolStripButton3.ToolTip = null;
            this.toolStripButton3.ToolType = BudgetExecution.ToolType.NextButton;
            // 
            // toolSeparator6
            // 
            this.toolSeparator6.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator6.Name = "toolSeparator6";
            this.toolSeparator6.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator6.Size = new System.Drawing.Size(6, 36);
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.AutoToolTip = false;
            this.toolStripButton4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.toolStripButton4.BindingSource = null;
            this.toolStripButton4.DataFilter = null;
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Field = BudgetExecution.Field.AccountCode;
            this.toolStripButton4.Font = new System.Drawing.Font("Roboto", 9F);
            this.toolStripButton4.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.toolStripButton4.HoverText = null;
            this.toolStripButton4.Image = global::BudgetExecution.Properties.Resources.LastButton;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Margin = new System.Windows.Forms.Padding(5);
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(24, 26);
            this.toolStripButton4.Text = "toolStripButton4";
            this.toolStripButton4.ToolTip = null;
            this.toolStripButton4.ToolType = BudgetExecution.ToolType.LastButton;
            // 
            // toolSeparator7
            // 
            this.toolSeparator7.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator7.Name = "toolSeparator7";
            this.toolSeparator7.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator7.Size = new System.Drawing.Size(6, 36);
            // 
            // toolSeparator8
            // 
            this.toolSeparator8.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator8.Name = "toolSeparator8";
            this.toolSeparator8.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator8.Size = new System.Drawing.Size(6, 34);
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
            this.ClientSize = new System.Drawing.Size(1445, 763);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.DataSourceLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.visualLabel3);
            this.Controls.Add(this.visualLabel2);
            this.Controls.Add(this.visualLabel1);
            this.Controls.Add(this.TableListBox);
            this.Controls.Add(this.ElementListBox);
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
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.GridPanel.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ListBox ColumnListBox;
        public ListBox ElementListBox;
        public DataView DataGrid;
        private ToolTip ToolTip;
        public ListBox TableListBox;
        public VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel1;
        public VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel2;
        public VisualPlus.Toolkit.Controls.Interactivity.VisualLabel visualLabel3;
        private Layout GridPanel;
        public Label label1;
        public Label DataSourceLabel;
        public ToolStrip ToolStrip;
        private System.Windows.Forms.BindingSource BindingSource;
        private ToolSeparator toolSeparator1;
        private ToolStripLabel toolStripLabel1;
        private ToolSeparator toolSeparator2;
        private ToolStripTextBox toolStripTextBox1;
        private ToolSeparator toolSeparator3;
        private ToolStripDropDown DropDown;
        private ToolStripButton toolStripButton1;
        private ToolSeparator toolSeparator4;
        private ToolStripButton toolStripButton2;
        private ToolSeparator toolSeparator5;
        private ToolStripButton toolStripButton3;
        private ToolSeparator toolSeparator6;
        private ToolStripButton toolStripButton4;
        private ToolSeparator toolSeparator7;
        private ToolSeparator toolSeparator8;
    }
}