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
            Syncfusion.Windows.Forms.Grid.GridStyleInfo gridStyleInfo1 = new Syncfusion.Windows.Forms.Grid.GridStyleInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewForm));
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GridPanel = new System.Windows.Forms.Panel();
            this.ToolStrip = new BudgetExecution.ToolStrip();
            this.DropDown = new BudgetExecution.ToolStripDropDown();
            this.Separator1 = new BudgetExecution.ToolSeparator();
            this.TextBox = new BudgetExecution.ToolStripTextBox();
            this.Separator2 = new BudgetExecution.ToolSeparator();
            this.Label = new BudgetExecution.ToolStripLabel();
            this.Separator3 = new BudgetExecution.ToolSeparator();
            this.toolSeparator2 = new BudgetExecution.ToolSeparator();
            this.FirstButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator3 = new BudgetExecution.ToolSeparator();
            this.PreviousButton = new BudgetExecution.ToolStripButton();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.toolSeparator4 = new BudgetExecution.ToolSeparator();
            this.NextButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator6 = new BudgetExecution.ToolSeparator();
            this.LastButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator5 = new BudgetExecution.ToolSeparator();
            this.AddButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator8 = new BudgetExecution.ToolSeparator();
            this.DeleteButton = new BudgetExecution.ToolStripButton();
            this.toolSeparator9 = new BudgetExecution.ToolSeparator();
            this.SaveButton = new BudgetExecution.ToolStripButton();
            this.Separator7 = new BudgetExecution.ToolSeparator();
            this.RefreshButton = new BudgetExecution.ToolStripButton();
            this.Separator8 = new BudgetExecution.ToolSeparator();
            this.ExcelButton = new BudgetExecution.ToolStripButton();
            this.Separator9 = new BudgetExecution.ToolSeparator();
            this.CalculatorButton = new BudgetExecution.ToolStripButton();
            this.Separator10 = new BudgetExecution.ToolSeparator();
            this.ChartButton = new BudgetExecution.ToolStripButton();
            this.Separator11 = new BudgetExecution.ToolSeparator();
            this.HomeButton = new BudgetExecution.ToolStripButton();
            this.Separator13 = new BudgetExecution.ToolSeparator();
            this.ListBox = new BudgetExecution.ListBox();
            this.toolSeparator1 = new BudgetExecution.ToolSeparator();
            this.EditButton = new BudgetExecution.ToolStripButton();
            this.dataView1 = new BudgetExecution.DataView();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.GridPanel.SuspendLayout();
            this.ToolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).BeginInit();
            this.SuspendLayout();
            // 
            // GridPanel
            // 
            this.GridPanel.Controls.Add(this.dataView1);
            this.GridPanel.Location = new System.Drawing.Point(88, 82);
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Size = new System.Drawing.Size(919, 494);
            this.GridPanel.TabIndex = 2;
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
            this.ToolStrip.Field = BudgetExecution.Field.RpioActivityCode;
            this.ToolStrip.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStrip.ForeColor = System.Drawing.Color.MidnightBlue;
            this.ToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.ToolStrip.Image = null;
            this.ToolStrip.ImageDirectory = null;
            this.ToolStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.ToolStrip.ImageSize = new System.Drawing.Size(0, 0);
            this.ToolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Separator1,
            this.TextBox,
            this.Separator2,
            this.Label,
            this.Separator3,
            this.DropDown,
            this.toolSeparator2,
            this.FirstButton,
            this.toolSeparator3,
            this.PreviousButton,
            this.toolSeparator4,
            this.NextButton,
            this.toolSeparator6,
            this.LastButton,
            this.toolSeparator5,
            this.AddButton,
            this.toolSeparator8,
            this.DeleteButton,
            this.toolSeparator9,
            this.SaveButton,
            this.Separator7,
            this.RefreshButton,
            this.Separator8,
            this.ExcelButton,
            this.Separator9,
            this.CalculatorButton,
            this.Separator10,
            this.ChartButton,
            this.Separator11,
            this.HomeButton,
            this.Separator13});
            this.ToolStrip.Label = this.Label;
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
            this.ToolStrip.Size = new System.Drawing.Size(1388, 52);
            this.ToolStrip.TabIndex = 3;
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
            this.DropDown.Tag = "Make Selection";
            this.DropDown.ToolTipText = "Make Selection";
            // 
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.Black;
            this.Separator1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator1.Name = "Separator1";
            this.Separator1.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator1.Size = new System.Drawing.Size(6, 36);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextBox.BindingSource = this.BindingSource;
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.TextBox.ForeColor = System.Drawing.SystemColors.WindowText;
            this.TextBox.HoverText = "";
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(150, 26);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = null;
            // 
            // Separator2
            // 
            this.Separator2.ForeColor = System.Drawing.Color.Black;
            this.Separator2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator2.Name = "Separator2";
            this.Separator2.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator2.Size = new System.Drawing.Size(6, 36);
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Label.BindingSource = null;
            this.Label.DataFilter = null;
            this.Label.Field = BudgetExecution.Field.RpioActivityCode;
            this.Label.Font = new System.Drawing.Font("Roboto", 9F);
            this.Label.ForeColor = System.Drawing.Color.Black;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(5);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(33, 26);
            this.Label.Tag = "";
            this.Label.Text = "Data";
            this.Label.ToolTip = null;
            // 
            // Separator3
            // 
            this.Separator3.ForeColor = System.Drawing.Color.Black;
            this.Separator3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator3.Name = "Separator3";
            this.Separator3.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator3.Size = new System.Drawing.Size(6, 36);
            // 
            // toolSeparator2
            // 
            this.toolSeparator2.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator2.Name = "toolSeparator2";
            this.toolSeparator2.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator2.Size = new System.Drawing.Size(6, 36);
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
            this.FirstButton.HoverText = null;
            this.FirstButton.Image = global::BudgetExecution.Properties.Resources.FirstButton;
            this.FirstButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.FirstButton.Margin = new System.Windows.Forms.Padding(5);
            this.FirstButton.Name = "FirstButton";
            this.FirstButton.Size = new System.Drawing.Size(24, 26);
            this.FirstButton.Text = "toolStripButton1";
            this.FirstButton.ToolTip = null;
            this.FirstButton.ToolType = BudgetExecution.ToolType.FirstButton;
            // 
            // toolSeparator3
            // 
            this.toolSeparator3.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator3.Name = "toolSeparator3";
            this.toolSeparator3.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator3.Size = new System.Drawing.Size(6, 36);
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
            // toolSeparator4
            // 
            this.toolSeparator4.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator4.Name = "toolSeparator4";
            this.toolSeparator4.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator4.Size = new System.Drawing.Size(6, 36);
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
            this.NextButton.Text = "toolStripButton3";
            this.NextButton.ToolTip = this.ToolTip;
            this.NextButton.ToolType = BudgetExecution.ToolType.NextButton;
            // 
            // toolSeparator6
            // 
            this.toolSeparator6.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator6.Name = "toolSeparator6";
            this.toolSeparator6.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator6.Size = new System.Drawing.Size(6, 36);
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
            this.LastButton.Text = "toolStripButton4";
            this.LastButton.ToolTip = this.ToolTip;
            this.LastButton.ToolType = BudgetExecution.ToolType.LastButton;
            // 
            // toolSeparator5
            // 
            this.toolSeparator5.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator5.Name = "toolSeparator5";
            this.toolSeparator5.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator5.Size = new System.Drawing.Size(6, 36);
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
            this.AddButton.Text = "toolStripButton6";
            this.AddButton.ToolTip = this.ToolTip;
            this.AddButton.ToolType = BudgetExecution.ToolType.AddButton;
            // 
            // toolSeparator8
            // 
            this.toolSeparator8.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator8.Name = "toolSeparator8";
            this.toolSeparator8.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator8.Size = new System.Drawing.Size(6, 36);
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
            this.DeleteButton.Text = "toolStripButton7";
            this.DeleteButton.ToolTip = this.ToolTip;
            this.DeleteButton.ToolType = BudgetExecution.ToolType.DeleteButton;
            // 
            // toolSeparator9
            // 
            this.toolSeparator9.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator9.Name = "toolSeparator9";
            this.toolSeparator9.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator9.Size = new System.Drawing.Size(6, 36);
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
            this.SaveButton.HoverText = "Save Record/Changes";
            this.SaveButton.Image = global::BudgetExecution.Properties.Resources.SaveButton;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(24, 26);
            this.SaveButton.Text = "toolStripButton8";
            this.SaveButton.ToolTip = this.ToolTip;
            this.SaveButton.ToolType = BudgetExecution.ToolType.SaveButton;
            // 
            // Separator7
            // 
            this.Separator7.ForeColor = System.Drawing.Color.Black;
            this.Separator7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator7.Name = "Separator7";
            this.Separator7.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator7.Size = new System.Drawing.Size(6, 36);
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
            this.RefreshButton.Text = "toolStripButton9";
            this.RefreshButton.ToolTip = this.ToolTip;
            this.RefreshButton.ToolType = BudgetExecution.ToolType.RefreshButton;
            // 
            // Separator8
            // 
            this.Separator8.ForeColor = System.Drawing.Color.Black;
            this.Separator8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator8.Name = "Separator8";
            this.Separator8.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator8.Size = new System.Drawing.Size(6, 36);
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
            this.ExcelButton.Text = "toolStripButton10";
            this.ExcelButton.ToolTip = this.ToolTip;
            this.ExcelButton.ToolType = BudgetExecution.ToolType.ExcelButton;
            // 
            // Separator9
            // 
            this.Separator9.ForeColor = System.Drawing.Color.Black;
            this.Separator9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator9.Name = "Separator9";
            this.Separator9.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator9.Size = new System.Drawing.Size(6, 36);
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
            this.CalculatorButton.HoverText = "Launch Calculator";
            this.CalculatorButton.Image = global::BudgetExecution.Properties.Resources.CalculatorButton;
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(5);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Size = new System.Drawing.Size(24, 26);
            this.CalculatorButton.Text = "toolStripButton1";
            this.CalculatorButton.ToolTip = this.ToolTip;
            this.CalculatorButton.ToolType = BudgetExecution.ToolType.CalculatorButton;
            // 
            // Separator10
            // 
            this.Separator10.ForeColor = System.Drawing.Color.Black;
            this.Separator10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator10.Name = "Separator10";
            this.Separator10.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator10.Size = new System.Drawing.Size(6, 36);
            // 
            // ChartButton
            // 
            this.ChartButton.AutoToolTip = false;
            this.ChartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ChartButton.BindingSource = this.BindingSource;
            this.ChartButton.DataFilter = null;
            this.ChartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChartButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.ChartButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ChartButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ChartButton.HoverText = "Visualizations";
            this.ChartButton.Image = global::BudgetExecution.Properties.Resources.ChartButton;
            this.ChartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChartButton.Margin = new System.Windows.Forms.Padding(5);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(24, 26);
            this.ChartButton.Text = "toolStripButton2";
            this.ChartButton.ToolTip = this.ToolTip;
            this.ChartButton.ToolType = BudgetExecution.ToolType.ChartButton;
            // 
            // Separator11
            // 
            this.Separator11.ForeColor = System.Drawing.Color.Black;
            this.Separator11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator11.Name = "Separator11";
            this.Separator11.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator11.Size = new System.Drawing.Size(6, 36);
            // 
            // HomeButton
            // 
            this.HomeButton.AutoToolTip = false;
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.HomeButton.BindingSource = null;
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
            this.HomeButton.Text = "toolStripButton3";
            this.HomeButton.ToolTip = this.ToolTip;
            this.HomeButton.ToolType = BudgetExecution.ToolType.HomeButton;
            // 
            // Separator13
            // 
            this.Separator13.ForeColor = System.Drawing.Color.Black;
            this.Separator13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator13.Name = "Separator13";
            this.Separator13.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator13.Size = new System.Drawing.Size(6, 36);
            // 
            // ListBox
            // 
            this.ListBox.AlternateColors = false;
            this.ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListBox.BindingSource = null;
            this.ListBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.ListBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ListBox.Border.HoverVisible = true;
            this.ListBox.Border.Rounding = 6;
            this.ListBox.Border.Thickness = 1;
            this.ListBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ListBox.Border.Visible = true;
            this.ListBox.DataFilter = null;
            this.ListBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.ListBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.ListBox.ForeColor = System.Drawing.Color.White;
            this.ListBox.HoverText = null;
            this.ListBox.ItemAlternate = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListBox.ItemHeight = 30;
            this.ListBox.ItemLineAlignment = System.Drawing.StringAlignment.Center;
            this.ListBox.ItemNormal = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListBox.ItemSelected = System.Drawing.Color.SteelBlue;
            this.ListBox.Location = new System.Drawing.Point(1064, 82);
            this.ListBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ListBox.Name = "ListBox";
            this.ListBox.Numeric = BudgetExecution.Numeric.NS;
            this.ListBox.Size = new System.Drawing.Size(247, 494);
            this.ListBox.TabIndex = 1;
            this.ListBox.Text = "listBox1";
            this.ListBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ListBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ListBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ListBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ListBox.ToolTip = null;
            // 
            // toolSeparator1
            // 
            this.toolSeparator1.ForeColor = System.Drawing.Color.Black;
            this.toolSeparator1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.toolSeparator1.Name = "toolSeparator1";
            this.toolSeparator1.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.toolSeparator1.Size = new System.Drawing.Size(6, 34);
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
            this.EditButton.HoverText = null;
            this.EditButton.Image = global::BudgetExecution.Properties.Resources.EditButton;
            this.EditButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.EditButton.Margin = new System.Windows.Forms.Padding(5);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(24, 24);
            this.EditButton.Text = "toolStripButton5";
            this.EditButton.ToolTip = null;
            this.EditButton.ToolType = BudgetExecution.ToolType.EditButton;
            // 
            // dataView1
            // 
            this.dataView1.AllowDragSelectedCols = true;
            this.dataView1.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(1)))), ((int)(((byte)(115)))), ((int)(((byte)(199)))));
            this.dataView1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.dataView1.BindingSource = this.BindingSource;
            this.dataView1.CanOverrideStyle = true;
            this.dataView1.DataFilter = null;
            this.dataView1.DataSource = this.BindingSource;
            this.dataView1.DefaultRowHeight = 22;
            this.dataView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataView1.ExcelLikeAlignment = true;
            this.dataView1.ExcelLikeSelectionFrame = true;
            this.dataView1.Field = BudgetExecution.Field.RpioActivityCode;
            this.dataView1.Font = new System.Drawing.Font("Roboto", 8F);
            this.dataView1.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.dataView1.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2010;
            this.dataView1.HorizontalScrollTips = true;
            this.dataView1.HorizontalThumbTrack = true;
            this.dataView1.HoverText = null;
            this.dataView1.Location = new System.Drawing.Point(0, 0);
            this.dataView1.Name = "dataView1";
            this.dataView1.Numeric = BudgetExecution.Numeric.NS;
            this.dataView1.OptimizeInsertRemoveCells = true;
            this.dataView1.Properties.GridLineColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.dataView1.Properties.ThemedHeader = true;
            this.dataView1.Setting = null;
            this.dataView1.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.dataView1.Size = new System.Drawing.Size(919, 494);
            this.dataView1.SmartSizeBox = false;
            this.dataView1.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.dataView1.TabIndex = 0;
            gridStyleInfo1.AutoFit = Syncfusion.Windows.Forms.Grid.AutoFitOptions.Both;
            gridStyleInfo1.Font.Bold = false;
            gridStyleInfo1.Font.Facename = "Roboto";
            gridStyleInfo1.Font.Italic = false;
            gridStyleInfo1.Font.Size = 8F;
            gridStyleInfo1.Font.Strikeout = false;
            gridStyleInfo1.Font.Underline = false;
            gridStyleInfo1.HorizontalAlignment = Syncfusion.Windows.Forms.Grid.GridHorizontalAlignment.Center;
            gridStyleInfo1.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))));
            gridStyleInfo1.TextColor = System.Drawing.Color.LightSteelBlue;
            gridStyleInfo1.Themed = true;
            gridStyleInfo1.WrapText = false;
            this.dataView1.TableStyle = gridStyleInfo1;
            this.dataView1.Text = "dataView1";
            this.dataView1.ThemesEnabled = true;
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.dataView1.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.dataView1.ThemeStyle.VerticalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.dataView1.UseListChangedEvent = true;
            this.dataView1.UseRightToLeftCompatibleTextBox = true;
            this.dataView1.VerticalScrollTips = true;
            this.dataView1.VerticalThumbTrack = true;
            // 
            // DataViewForm
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
            this.ClientSize = new System.Drawing.Size(1388, 713);
            this.Controls.Add(this.ToolStrip);
            this.Controls.Add(this.GridPanel);
            this.Controls.Add(this.ListBox);
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
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.Panel GridPanel;
        public ListBox ListBox;
        private ToolStripDropDown DropDown;
        private ToolSeparator Separator1;
        public ToolStripTextBox TextBox;
        private ToolSeparator Separator2;
        public ToolStripLabel Label;
        private ToolSeparator Separator3;
        private ToolSeparator toolSeparator1;
        private ToolSeparator toolSeparator3;
        private ToolSeparator toolSeparator4;
        private ToolSeparator toolSeparator5;
        private ToolSeparator toolSeparator6;
        private ToolStripButton SaveButton;
        private ToolSeparator toolSeparator8;
        private ToolSeparator toolSeparator9;
        public ToolStripButton FirstButton;
        public ToolStripButton PreviousButton;
        public ToolStripButton NextButton;
        public ToolStripButton LastButton;
        public ToolStripButton EditButton;
        public ToolStripButton AddButton;
        public ToolStripButton DeleteButton;
        public ToolStripButton RefreshButton;
        public ToolStripButton ExcelButton;
        private ToolSeparator Separator7;
        private ToolSeparator Separator8;
        public ToolStripButton CalculatorButton;
        public ToolStripButton ChartButton;
        public ToolStripButton HomeButton;
        public ToolSeparator Separator9;
        public ToolSeparator Separator10;
        public ToolSeparator Separator11;
        public ToolSeparator Separator13;
        private ToolSeparator toolSeparator2;
        public ToolStrip ToolStrip;
        private ToolTip ToolTip;
        private System.Windows.Forms.BindingSource BindingSource;
        private DataView dataView1;
    }
}