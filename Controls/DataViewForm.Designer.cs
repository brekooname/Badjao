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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewForm));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataGridGroupBox = new BudgetExecution.GroupBox();
            this.GridPanel = new BudgetExecution.Layout();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.ToolStrip = new BudgetExecution.ToolStrip();
            this.CalculatorButton = new BudgetExecution.ToolStripButton();
            this.ChartButton = new BudgetExecution.ToolStripButton();
            this.DeleteButton = new BudgetExecution.ToolStripButton();
            this.DropDown = new BudgetExecution.ToolStripDropDown();
            this.EditButton = new BudgetExecution.ToolStripButton();
            this.FirstButton = new BudgetExecution.ToolStripButton();
            this.HomeButton = new BudgetExecution.ToolStripButton();
            this.Separator1 = new BudgetExecution.ToolSeparator();
            this.Label = new BudgetExecution.ToolStripLabel();
            this.Separator2 = new BudgetExecution.ToolSeparator();
            this.TextBox = new BudgetExecution.ToolStripTextBox();
            this.Separator3 = new BudgetExecution.ToolSeparator();
            this.Separator4 = new BudgetExecution.ToolSeparator();
            this.Separator5 = new BudgetExecution.ToolSeparator();
            this.PreviousButton = new BudgetExecution.ToolStripButton();
            this.Separator6 = new BudgetExecution.ToolSeparator();
            this.NextButton = new BudgetExecution.ToolStripButton();
            this.Separator7 = new BudgetExecution.ToolSeparator();
            this.LastButton = new BudgetExecution.ToolStripButton();
            this.Separator8 = new BudgetExecution.ToolSeparator();
            this.Separator9 = new BudgetExecution.ToolSeparator();
            this.RefreshButton = new BudgetExecution.ToolStripButton();
            this.Separator10 = new BudgetExecution.ToolSeparator();
            this.Separator11 = new BudgetExecution.ToolSeparator();
            this.SaveButton = new BudgetExecution.ToolStripButton();
            this.Separator12 = new BudgetExecution.ToolSeparator();
            this.ExcelButton = new BudgetExecution.ToolStripButton();
            this.Separator13 = new BudgetExecution.ToolSeparator();
            this.Separator14 = new BudgetExecution.ToolSeparator();
            this.Separator15 = new BudgetExecution.ToolSeparator();
            this.TableGroupBox = new BudgetExecution.GroupBox();
            this.TableListPanel = new BudgetExecution.Layout();
            this.TableListBox = new BudgetExecution.ListBox();
            this.ColumnGroupBox = new BudgetExecution.GroupBox();
            this.ColumnListPanel = new BudgetExecution.Layout();
            this.ColumnListBox = new BudgetExecution.ListBox();
            this.ValueGroupBox = new BudgetExecution.GroupBox();
            this.ValueListPanel = new BudgetExecution.Layout();
            this.ValueListBox = new BudgetExecution.ListBox();
            this.DataGrid = new BudgetExecution.DataGrid();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.DataGridGroupBox.SuspendLayout();
            this.GridPanel.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            this.TableGroupBox.SuspendLayout();
            this.TableListPanel.SuspendLayout();
            this.ColumnGroupBox.SuspendLayout();
            this.ColumnListPanel.SuspendLayout();
            this.ValueGroupBox.SuspendLayout();
            this.ValueListPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridGroupBox
            // 
            this.DataGridGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DataGridGroupBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DataGridGroupBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DataGridGroupBox.BindingSource = null;
            this.DataGridGroupBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridGroupBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.DataGridGroupBox.Border.HoverVisible = true;
            this.DataGridGroupBox.Border.Rounding = 6;
            this.DataGridGroupBox.Border.Thickness = 1;
            this.DataGridGroupBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.DataGridGroupBox.Border.Visible = true;
            this.DataGridGroupBox.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.DataGridGroupBox.Controls.Add(this.GridPanel);
            this.DataGridGroupBox.DataFilter = null;
            this.DataGridGroupBox.Field = BudgetExecution.Field.AccountCode;
            this.DataGridGroupBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.DataGridGroupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DataGridGroupBox.HeaderText = null;
            this.DataGridGroupBox.HoverText = null;
            this.DataGridGroupBox.Image = null;
            this.DataGridGroupBox.Location = new System.Drawing.Point(50, 97);
            this.DataGridGroupBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.DataGridGroupBox.Name = "DataGridGroupBox";
            this.DataGridGroupBox.Numeric = BudgetExecution.Numeric.Accepted;
            this.DataGridGroupBox.Padding = new System.Windows.Forms.Padding(1);
            this.DataGridGroupBox.Separator = true;
            this.DataGridGroupBox.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.DataGridGroupBox.Size = new System.Drawing.Size(968, 557);
            this.DataGridGroupBox.TabIndex = 21;
            this.DataGridGroupBox.TextAlignment = System.Drawing.StringAlignment.Near;
            this.DataGridGroupBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.DataGridGroupBox.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.DataGridGroupBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.DataGridGroupBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DataGridGroupBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DataGridGroupBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DataGridGroupBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.DataGridGroupBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.DataGridGroupBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.DataGridGroupBox.TitleBoxHeight = 30;
            this.DataGridGroupBox.ToolTip = this.ToolTip;
            // 
            // GridPanel
            // 
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GridPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GridPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GridPanel.BindingSource = null;
            this.GridPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GridPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.GridPanel.Border.HoverVisible = false;
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
            this.GridPanel.Location = new System.Drawing.Point(14, 44);
            this.GridPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Numeric = BudgetExecution.Numeric.Accepted;
            this.GridPanel.Padding = new System.Windows.Forms.Padding(1);
            this.GridPanel.Size = new System.Drawing.Size(942, 497);
            this.GridPanel.TabIndex = 23;
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
            // ToolStrip
            // 
            this.ToolStrip.AddButton = null;
            this.ToolStrip.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ToolStrip.BindingSource = this.BindingSource;
            this.ToolStrip.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolStrip.CalculatorButton = this.CalculatorButton;
            this.ToolStrip.CanOverrideStyle = true;
            this.ToolStrip.CaptionAlignment = Syncfusion.Windows.Forms.Tools.CaptionAlignment.Near;
            this.ToolStrip.CaptionFont = new System.Drawing.Font("Roboto", 9F);
            this.ToolStrip.CaptionStyle = Syncfusion.Windows.Forms.Tools.CaptionStyle.Top;
            this.ToolStrip.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.ToolStrip.ChartButton = this.ChartButton;
            this.ToolStrip.DataFilter = null;
            this.ToolStrip.DeleteButton = this.DeleteButton;
            this.ToolStrip.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolStrip.DropDown = this.DropDown;
            this.ToolStrip.EditButton = this.EditButton;
            this.ToolStrip.ExcelButton = this.EditButton;
            this.ToolStrip.Field = BudgetExecution.Field.AccountCode;
            this.ToolStrip.FirstButton = this.FirstButton;
            this.ToolStrip.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.HomeButton = this.HomeButton;
            this.ToolStrip.Image = null;
            this.ToolStrip.ImageDirectory = null;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.ImageSize = new System.Drawing.Size(0, 0);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Separator1,
            this.Label,
            this.Separator2,
            this.TextBox,
            this.Separator3,
            this.DropDown,
            this.Separator4,
            this.FirstButton,
            this.Separator5,
            this.PreviousButton,
            this.Separator6,
            this.NextButton,
            this.Separator7,
            this.LastButton,
            this.Separator8,
            this.EditButton,
            this.Separator9,
            this.RefreshButton,
            this.Separator10,
            this.DeleteButton,
            this.Separator11,
            this.SaveButton,
            this.Separator12,
            this.ExcelButton,
            this.Separator13,
            this.CalculatorButton,
            this.Separator14,
            this.ChartButton,
            this.Separator15,
            this.HomeButton});
            this.ToolStrip.Label = this.Label;
            this.ToolStrip.LastButton = this.LastButton;
            this.ToolStrip.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Office12;
            this.ToolStrip.Location = new System.Drawing.Point(0, 711);
            this.ToolStrip.Margin = new System.Windows.Forms.Padding(1);
            this.ToolStrip.Name = "ToolStrip";
            this.ToolStrip.NextButton = this.NextButton;
            this.ToolStrip.Numeric = BudgetExecution.Numeric.Accepted;
            this.ToolStrip.Office12Mode = false;
            this.ToolStrip.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Blue;
            this.ToolStrip.Padding = new System.Windows.Forms.Padding(1);
            this.ToolStrip.PreviousButton = this.PreviousButton;
            this.ToolStrip.ProgressBar = null;
            this.ToolStrip.RefreshButton = this.RefreshButton;
            this.ToolStrip.SaveButton = this.SaveButton;
            this.ToolStrip.Separators = null;
            this.ToolStrip.ShowCaption = true;
            this.ToolStrip.ShowLauncher = true;
            this.ToolStrip.Size = new System.Drawing.Size(1388, 52);
            this.ToolStrip.TabIndex = 0;
            this.ToolStrip.TextBox = this.TextBox;
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
            // CalculatorButton
            // 
            this.CalculatorButton.AutoToolTip = false;
            this.CalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CalculatorButton.BindingSource = this.BindingSource;
            this.CalculatorButton.DataFilter = null;
            this.CalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatorButton.Field = BudgetExecution.Field.AccountCode;
            this.CalculatorButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.CalculatorButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CalculatorButton.HoverText = null;
            this.CalculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("CalculatorButton.Image")));
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(5);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(24, 26);
            this.CalculatorButton.ToolTip = this.ToolTip;
            this.CalculatorButton.ToolType = BudgetExecution.ToolType.CalculatorButton;
            // 
            // ChartButton
            // 
            this.ChartButton.AutoToolTip = false;
            this.ChartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ChartButton.BindingSource = this.BindingSource;
            this.ChartButton.DataFilter = null;
            this.ChartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChartButton.Field = BudgetExecution.Field.AccountCode;
            this.ChartButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ChartButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ChartButton.HoverText = null;
            this.ChartButton.Image = ((System.Drawing.Image)(resources.GetObject("ChartButton.Image")));
            this.ChartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChartButton.Margin = new System.Windows.Forms.Padding(5);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(24, 26);
            this.ChartButton.ToolTip = this.ToolTip;
            this.ChartButton.ToolType = BudgetExecution.ToolType.ChartButton;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoToolTip = false;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.DeleteButton.BindingSource = this.BindingSource;
            this.DeleteButton.DataFilter = null;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Field = BudgetExecution.Field.AccountCode;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DeleteButton.HoverText = null;
            this.DeleteButton.Image = ((System.Drawing.Image)(resources.GetObject("DeleteButton.Image")));
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(24, 26);
            this.DeleteButton.ToolTip = this.ToolTip;
            this.DeleteButton.ToolType = BudgetExecution.ToolType.DeleteButton;
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
            this.DropDown.ToolTipText = "Make Selection";
            // 
            // EditButton
            // 
            this.EditButton.AutoToolTip = false;
            this.EditButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.EditButton.BindingSource = this.BindingSource;
            this.EditButton.DataFilter = null;
            this.EditButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.EditButton.Field = BudgetExecution.Field.AccountCode;
            this.EditButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.EditButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.EditButton.HoverText = null;
            this.EditButton.Image = ((System.Drawing.Image)(resources.GetObject("EditButton.Image")));
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Margin = new System.Windows.Forms.Padding(5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(24, 26);
            this.EditButton.ToolTip = this.ToolTip;
            this.EditButton.ToolType = BudgetExecution.ToolType.EditButton;
            // 
            // FirstButton
            // 
            this.FirstButton.AutoToolTip = false;
            this.FirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.FirstButton.BindingSource = this.BindingSource;
            this.FirstButton.DataFilter = null;
            this.FirstButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.FirstButton.Field = BudgetExecution.Field.AccountCode;
            this.FirstButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.FirstButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.FirstButton.HoverText = null;
            this.FirstButton.Image = ((System.Drawing.Image)(resources.GetObject("FirstButton.Image")));
            this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstButton.Margin = new System.Windows.Forms.Padding(5);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(24, 26);
            this.FirstButton.ToolTip = this.ToolTip;
            this.FirstButton.ToolType = BudgetExecution.ToolType.FirstButton;
            // 
            // HomeButton
            // 
            this.HomeButton.AutoToolTip = false;
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.HomeButton.BindingSource = null;
            this.HomeButton.DataFilter = null;
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Field = BudgetExecution.Field.AccountCode;
            this.HomeButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.HomeButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.HomeButton.HoverText = null;
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Margin = new System.Windows.Forms.Padding(5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(24, 26);
            this.HomeButton.ToolTip = this.ToolTip;
            this.HomeButton.ToolType = BudgetExecution.ToolType.HomeButton;
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
            this.Label.Field = BudgetExecution.Field.AccountCode;
            this.Label.Font = new System.Drawing.Font("Roboto", 9F);
            this.Label.ForeColor = System.Drawing.Color.Black;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(5);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(80, 26);
            this.Label.Tag = "";
            this.Label.Text = "Data Tool Bar";
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
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TextBox.BindingSource = this.BindingSource;
            this.TextBox.Field = BudgetExecution.Field.AccountCode;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox.HoverText = "";
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(150, 26);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = this.ToolTip;
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
            // PreviousButton
            // 
            this.PreviousButton.AutoToolTip = false;
            this.PreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PreviousButton.BindingSource = this.BindingSource;
            this.PreviousButton.DataFilter = null;
            this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousButton.Field = BudgetExecution.Field.AccountCode;
            this.PreviousButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.PreviousButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.PreviousButton.HoverText = null;
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(24, 26);
            this.PreviousButton.ToolTip = this.ToolTip;
            this.PreviousButton.ToolType = BudgetExecution.ToolType.PreviousButton;
            // 
            // Separator6
            // 
            this.Separator6.ForeColor = System.Drawing.Color.Black;
            this.Separator6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator6.Name = "Separator6";
            this.Separator6.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator6.Size = new System.Drawing.Size(6, 36);
            // 
            // NextButton
            // 
            this.NextButton.AutoToolTip = false;
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.NextButton.BindingSource = this.BindingSource;
            this.NextButton.DataFilter = null;
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Field = BudgetExecution.Field.AccountCode;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.NextButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.NextButton.HoverText = null;
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(24, 26);
            this.NextButton.ToolTip = this.ToolTip;
            this.NextButton.ToolType = BudgetExecution.ToolType.NextButton;
            // 
            // Separator7
            // 
            this.Separator7.ForeColor = System.Drawing.Color.Black;
            this.Separator7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator7.Name = "Separator7";
            this.Separator7.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator7.Size = new System.Drawing.Size(6, 36);
            // 
            // LastButton
            // 
            this.LastButton.AutoToolTip = false;
            this.LastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.LastButton.BindingSource = this.BindingSource;
            this.LastButton.DataFilter = null;
            this.LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastButton.Field = BudgetExecution.Field.AccountCode;
            this.LastButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.LastButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.LastButton.HoverText = null;
            this.LastButton.Image = ((System.Drawing.Image)(resources.GetObject("LastButton.Image")));
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(5);
            this.LastButton.Name = "LastButton";
            this.LastButton.Size = new System.Drawing.Size(24, 26);
            this.LastButton.ToolTip = this.ToolTip;
            this.LastButton.ToolType = BudgetExecution.ToolType.LastButton;
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
            // RefreshButton
            // 
            this.RefreshButton.AutoToolTip = false;
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.RefreshButton.BindingSource = this.BindingSource;
            this.RefreshButton.DataFilter = null;
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Field = BudgetExecution.Field.AccountCode;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.RefreshButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshButton.HoverText = null;
            this.RefreshButton.Image = ((System.Drawing.Image)(resources.GetObject("RefreshButton.Image")));
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Size = new System.Drawing.Size(24, 26);
            this.RefreshButton.ToolTip = this.ToolTip;
            this.RefreshButton.ToolType = BudgetExecution.ToolType.RefreshButton;
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
            // SaveButton
            // 
            this.SaveButton.AutoToolTip = false;
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SaveButton.BindingSource = this.BindingSource;
            this.SaveButton.DataFilter = null;
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Field = BudgetExecution.Field.AccountCode;
            this.SaveButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.SaveButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.SaveButton.HoverText = null;
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(24, 26);
            this.SaveButton.ToolTip = this.ToolTip;
            this.SaveButton.ToolType = BudgetExecution.ToolType.SaveButton;
            // 
            // Separator12
            // 
            this.Separator12.ForeColor = System.Drawing.Color.Black;
            this.Separator12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator12.Name = "Separator12";
            this.Separator12.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator12.Size = new System.Drawing.Size(6, 36);
            // 
            // ExcelButton
            // 
            this.ExcelButton.AutoToolTip = false;
            this.ExcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ExcelButton.BindingSource = this.BindingSource;
            this.ExcelButton.DataFilter = null;
            this.ExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcelButton.Field = BudgetExecution.Field.AccountCode;
            this.ExcelButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ExcelButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ExcelButton.HoverText = null;
            this.ExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.Image")));
            this.ExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(24, 26);
            this.ExcelButton.ToolTip = this.ToolTip;
            this.ExcelButton.ToolType = BudgetExecution.ToolType.ExcelButton;
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
            // TableGroupBox
            // 
            this.TableGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableGroupBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableGroupBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableGroupBox.BindingSource = null;
            this.TableGroupBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TableGroupBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TableGroupBox.Border.HoverVisible = true;
            this.TableGroupBox.Border.Rounding = 6;
            this.TableGroupBox.Border.Thickness = 1;
            this.TableGroupBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TableGroupBox.Border.Visible = true;
            this.TableGroupBox.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.TableGroupBox.Controls.Add(this.TableListPanel);
            this.TableGroupBox.DataFilter = null;
            this.TableGroupBox.Field = BudgetExecution.Field.AccountCode;
            this.TableGroupBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.TableGroupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TableGroupBox.HeaderText = null;
            this.TableGroupBox.HoverText = null;
            this.TableGroupBox.Image = null;
            this.TableGroupBox.Location = new System.Drawing.Point(1039, 97);
            this.TableGroupBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TableGroupBox.Name = "TableGroupBox";
            this.TableGroupBox.Numeric = BudgetExecution.Numeric.Accepted;
            this.TableGroupBox.Padding = new System.Windows.Forms.Padding(1);
            this.TableGroupBox.Separator = true;
            this.TableGroupBox.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TableGroupBox.Size = new System.Drawing.Size(337, 163);
            this.TableGroupBox.TabIndex = 15;
            this.TableGroupBox.TextAlignment = System.Drawing.StringAlignment.Near;
            this.TableGroupBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.TableGroupBox.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TableGroupBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TableGroupBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableGroupBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableGroupBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableGroupBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TableGroupBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TableGroupBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TableGroupBox.TitleBoxHeight = 30;
            this.TableGroupBox.ToolTip = null;
            // 
            // TableListPanel
            // 
            this.TableListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TableListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListPanel.BindingSource = null;
            this.TableListPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.TableListPanel.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TableListPanel.Border.HoverVisible = true;
            this.TableListPanel.Border.Rounding = 6;
            this.TableListPanel.Border.Thickness = 1;
            this.TableListPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TableListPanel.Border.Visible = true;
            this.TableListPanel.Children = null;
            this.TableListPanel.Controls.Add(this.TableListBox);
            this.TableListPanel.DataFilter = null;
            this.TableListPanel.Field = BudgetExecution.Field.AccountCode;
            this.TableListPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.TableListPanel.HoverText = null;
            this.TableListPanel.Location = new System.Drawing.Point(3, 33);
            this.TableListPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TableListPanel.Name = "TableListPanel";
            this.TableListPanel.Numeric = BudgetExecution.Numeric.Accepted;
            this.TableListPanel.Padding = new System.Windows.Forms.Padding(1);
            this.TableListPanel.Size = new System.Drawing.Size(331, 127);
            this.TableListPanel.TabIndex = 19;
            this.TableListPanel.Text = "layout1";
            this.TableListPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TableListPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableListPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableListPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TableListPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TableListPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TableListPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TableListPanel.ToolTip = null;
            // 
            // TableListBox
            // 
            this.TableListBox.AlternateColors = false;
            this.TableListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.BindingSource = null;
            this.TableListBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TableListBox.Border.HoverVisible = false;
            this.TableListBox.Border.Rounding = 6;
            this.TableListBox.Border.Thickness = 1;
            this.TableListBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TableListBox.Border.Visible = false;
            this.TableListBox.DataFilter = null;
            this.TableListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TableListBox.Field = BudgetExecution.Field.AccountCode;
            this.TableListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TableListBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.TableListBox.HoverText = null;
            this.TableListBox.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.ItemHeight = 30;
            this.TableListBox.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.TableListBox.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TableListBox.ItemSelected = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.TableListBox.Location = new System.Drawing.Point(0, 0);
            this.TableListBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TableListBox.Name = "TableListBox";
            this.TableListBox.Numeric = BudgetExecution.Numeric.Accepted;
            this.TableListBox.Size = new System.Drawing.Size(331, 127);
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
            // ColumnGroupBox
            // 
            this.ColumnGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnGroupBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnGroupBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnGroupBox.BindingSource = null;
            this.ColumnGroupBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ColumnGroupBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ColumnGroupBox.Border.HoverVisible = true;
            this.ColumnGroupBox.Border.Rounding = 6;
            this.ColumnGroupBox.Border.Thickness = 1;
            this.ColumnGroupBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ColumnGroupBox.Border.Visible = true;
            this.ColumnGroupBox.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.ColumnGroupBox.Controls.Add(this.ColumnListPanel);
            this.ColumnGroupBox.DataFilter = null;
            this.ColumnGroupBox.Field = BudgetExecution.Field.AccountCode;
            this.ColumnGroupBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.ColumnGroupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ColumnGroupBox.HeaderText = null;
            this.ColumnGroupBox.HoverText = null;
            this.ColumnGroupBox.Image = null;
            this.ColumnGroupBox.Location = new System.Drawing.Point(1039, 294);
            this.ColumnGroupBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ColumnGroupBox.Name = "ColumnGroupBox";
            this.ColumnGroupBox.Numeric = BudgetExecution.Numeric.Accepted;
            this.ColumnGroupBox.Padding = new System.Windows.Forms.Padding(1);
            this.ColumnGroupBox.Separator = true;
            this.ColumnGroupBox.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ColumnGroupBox.Size = new System.Drawing.Size(337, 162);
            this.ColumnGroupBox.TabIndex = 16;
            this.ColumnGroupBox.TextAlignment = System.Drawing.StringAlignment.Near;
            this.ColumnGroupBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ColumnGroupBox.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnGroupBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ColumnGroupBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColumnGroupBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColumnGroupBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColumnGroupBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnGroupBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnGroupBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ColumnGroupBox.TitleBoxHeight = 30;
            this.ColumnGroupBox.ToolTip = null;
            // 
            // ColumnListPanel
            // 
            this.ColumnListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ColumnListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListPanel.BindingSource = null;
            this.ColumnListPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ColumnListPanel.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ColumnListPanel.Border.HoverVisible = true;
            this.ColumnListPanel.Border.Rounding = 6;
            this.ColumnListPanel.Border.Thickness = 1;
            this.ColumnListPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ColumnListPanel.Border.Visible = true;
            this.ColumnListPanel.Children = null;
            this.ColumnListPanel.Controls.Add(this.ColumnListBox);
            this.ColumnListPanel.DataFilter = null;
            this.ColumnListPanel.Field = BudgetExecution.Field.AccountCode;
            this.ColumnListPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.ColumnListPanel.HoverText = null;
            this.ColumnListPanel.Location = new System.Drawing.Point(3, 34);
            this.ColumnListPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ColumnListPanel.Name = "ColumnListPanel";
            this.ColumnListPanel.Numeric = BudgetExecution.Numeric.Accepted;
            this.ColumnListPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ColumnListPanel.Size = new System.Drawing.Size(331, 125);
            this.ColumnListPanel.TabIndex = 2;
            this.ColumnListPanel.Text = "layout2";
            this.ColumnListPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ColumnListPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColumnListPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColumnListPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ColumnListPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnListPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnListPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ColumnListPanel.ToolTip = null;
            // 
            // ColumnListBox
            // 
            this.ColumnListBox.AlternateColors = false;
            this.ColumnListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.BindingSource = null;
            this.ColumnListBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ColumnListBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ColumnListBox.Border.HoverVisible = false;
            this.ColumnListBox.Border.Rounding = 6;
            this.ColumnListBox.Border.Thickness = 1;
            this.ColumnListBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ColumnListBox.Border.Visible = false;
            this.ColumnListBox.DataFilter = null;
            this.ColumnListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ColumnListBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.ColumnListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ColumnListBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ColumnListBox.HoverText = null;
            this.ColumnListBox.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.ItemHeight = 30;
            this.ColumnListBox.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.ColumnListBox.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ColumnListBox.ItemSelected = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ColumnListBox.Location = new System.Drawing.Point(0, 0);
            this.ColumnListBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ColumnListBox.Name = "ColumnListBox";
            this.ColumnListBox.Numeric = BudgetExecution.Numeric.NS;
            this.ColumnListBox.Size = new System.Drawing.Size(331, 125);
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
            // ValueGroupBox
            // 
            this.ValueGroupBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueGroupBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ValueGroupBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ValueGroupBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ValueGroupBox.BindingSource = null;
            this.ValueGroupBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ValueGroupBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ValueGroupBox.Border.HoverVisible = true;
            this.ValueGroupBox.Border.Rounding = 6;
            this.ValueGroupBox.Border.Thickness = 1;
            this.ValueGroupBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ValueGroupBox.Border.Visible = true;
            this.ValueGroupBox.BoxStyle = VisualPlus.Toolkit.Controls.Layout.VisualGroupBox.GroupBoxStyle.Default;
            this.ValueGroupBox.Controls.Add(this.ValueListPanel);
            this.ValueGroupBox.DataFilter = null;
            this.ValueGroupBox.Field = BudgetExecution.Field.AccountCode;
            this.ValueGroupBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.ValueGroupBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ValueGroupBox.HeaderText = null;
            this.ValueGroupBox.HoverText = null;
            this.ValueGroupBox.Image = null;
            this.ValueGroupBox.Location = new System.Drawing.Point(1039, 474);
            this.ValueGroupBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ValueGroupBox.Name = "ValueGroupBox";
            this.ValueGroupBox.Numeric = BudgetExecution.Numeric.Accepted;
            this.ValueGroupBox.Padding = new System.Windows.Forms.Padding(1);
            this.ValueGroupBox.Separator = true;
            this.ValueGroupBox.SeparatorColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ValueGroupBox.Size = new System.Drawing.Size(337, 180);
            this.ValueGroupBox.TabIndex = 17;
            this.ValueGroupBox.TextAlignment = System.Drawing.StringAlignment.Near;
            this.ValueGroupBox.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.ValueGroupBox.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ValueGroupBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ValueGroupBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ValueGroupBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ValueGroupBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ValueGroupBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ValueGroupBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ValueGroupBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ValueGroupBox.TitleBoxHeight = 30;
            this.ValueGroupBox.ToolTip = null;
            // 
            // ValueListPanel
            // 
            this.ValueListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ValueListPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ValueListPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ValueListPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ValueListPanel.BindingSource = null;
            this.ValueListPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ValueListPanel.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ValueListPanel.Border.HoverVisible = true;
            this.ValueListPanel.Border.Rounding = 6;
            this.ValueListPanel.Border.Thickness = 1;
            this.ValueListPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ValueListPanel.Border.Visible = true;
            this.ValueListPanel.Children = null;
            this.ValueListPanel.Controls.Add(this.ValueListBox);
            this.ValueListPanel.DataFilter = null;
            this.ValueListPanel.Field = BudgetExecution.Field.AccountCode;
            this.ValueListPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.ValueListPanel.HoverText = null;
            this.ValueListPanel.Location = new System.Drawing.Point(3, 37);
            this.ValueListPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ValueListPanel.Name = "ValueListPanel";
            this.ValueListPanel.Numeric = BudgetExecution.Numeric.Accepted;
            this.ValueListPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ValueListPanel.Size = new System.Drawing.Size(331, 140);
            this.ValueListPanel.TabIndex = 2;
            this.ValueListPanel.Text = "layout3";
            this.ValueListPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ValueListPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ValueListPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ValueListPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ValueListPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ValueListPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ValueListPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ValueListPanel.ToolTip = null;
            // 
            // ValueListBox
            // 
            this.ValueListBox.AlternateColors = false;
            this.ValueListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ValueListBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ValueListBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ValueListBox.BindingSource = null;
            this.ValueListBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ValueListBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ValueListBox.Border.HoverVisible = false;
            this.ValueListBox.Border.Rounding = 6;
            this.ValueListBox.Border.Thickness = 1;
            this.ValueListBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ValueListBox.Border.Visible = false;
            this.ValueListBox.DataFilter = null;
            this.ValueListBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ValueListBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.ValueListBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ValueListBox.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.ValueListBox.HoverText = null;
            this.ValueListBox.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ValueListBox.ItemHeight = 30;
            this.ValueListBox.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.ValueListBox.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ValueListBox.ItemSelected = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.ValueListBox.Location = new System.Drawing.Point(0, 0);
            this.ValueListBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ValueListBox.Name = "ValueListBox";
            this.ValueListBox.Numeric = BudgetExecution.Numeric.NS;
            this.ValueListBox.Size = new System.Drawing.Size(331, 140);
            this.ValueListBox.TabIndex = 4;
            this.ValueListBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ValueListBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ValueListBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ValueListBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ValueListBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ValueListBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ValueListBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ValueListBox.ToolTip = this.ToolTip;
            // 
            // DataGrid
            // 
            this.DataGrid.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Roboto", 8F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            this.DataGrid.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.DataGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            this.DataGrid.BindingSource = null;
            this.DataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.DataGrid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Roboto", 9F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGrid.DataFilter = null;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Roboto", 8F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGrid.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataGrid.EnableHeadersVisualStyles = false;
            this.DataGrid.Font = new System.Drawing.Font("Roboto", 8F);
            this.DataGrid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.DataGrid.HoverText = null;
            this.DataGrid.Location = new System.Drawing.Point(0, 0);
            this.DataGrid.Name = "DataGrid";
            this.DataGrid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.BottomCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Roboto", 8F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.SteelBlue;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGrid.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGrid.RowHeadersWidth = 20;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(55)))), ((int)(((byte)(55)))), ((int)(((byte)(55)))));
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Roboto", 8F);
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LightSteelBlue;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(39)))), ((int)(((byte)(70)))));
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.Color.White;
            this.DataGrid.RowsDefaultCellStyle = dataGridViewCellStyle5;
            this.DataGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DataGrid.Size = new System.Drawing.Size(942, 497);
            this.DataGrid.TabIndex = 0;
            this.DataGrid.ToolTip = null;
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
            this.Controls.Add(this.DataGridGroupBox);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.TableGroupBox);
            this.Controls.Add(this.ColumnGroupBox);
            this.Controls.Add(this.ValueGroupBox);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
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
            this.DataGridGroupBox.ResumeLayout(false);
            this.GridPanel.ResumeLayout(false);
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.TableGroupBox.ResumeLayout(false);
            this.TableListPanel.ResumeLayout(false);
            this.TableListPanel.PerformLayout();
            this.ColumnGroupBox.ResumeLayout(false);
            this.ColumnListPanel.ResumeLayout(false);
            this.ColumnListPanel.PerformLayout();
            this.ValueGroupBox.ResumeLayout(false);
            this.ValueListPanel.ResumeLayout(false);
            this.ValueListPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private ToolTip ToolTip;
        public ToolStrip ToolStrip;
        public ToolSeparator Separator1;
        public ToolStripLabel Label;
        public ToolSeparator Separator2;
        public ToolStripTextBox TextBox;
        public ToolSeparator Separator3;
        public ToolStripDropDown DropDown;
        public ToolSeparator Separator4;
        public ToolStripButton FirstButton;
        public ToolSeparator Separator5;
        public ToolStripButton PreviousButton;
        public ToolSeparator Separator6;
        public ToolStripButton NextButton;
        public ToolSeparator Separator7;
        public ToolStripButton LastButton;
        public ToolSeparator Separator8;
        public ToolStripButton EditButton;
        public ToolSeparator Separator9;
        public ToolStripButton RefreshButton;
        public ToolSeparator Separator10;
        public ToolStripButton DeleteButton;
        public ToolSeparator Separator11;
        public ToolStripButton SaveButton;
        public ToolSeparator Separator12;
        public ToolStripButton ExcelButton;
        public ToolSeparator Separator13;
        public ToolStripButton CalculatorButton;
        public ToolSeparator Separator14;
        public ToolSeparator Separator15;
        public ToolStripButton HomeButton;
        public ListBox TableListBox;
        public ListBox ColumnListBox;
        public ListBox ValueListBox;
        public GroupBox TableGroupBox;
        public GroupBox ColumnGroupBox;
        public GroupBox ValueGroupBox;
        private Layout ColumnListPanel;
        public Layout ValueListPanel;
        public Layout TableListPanel;
        public GroupBox DataGridGroupBox;
        public Layout GridPanel;
        public ToolStripButton ChartButton;
        private System.Windows.Forms.BindingSource BindingSource;
        public DataGrid DataGrid;
    }
}