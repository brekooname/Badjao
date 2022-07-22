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
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle1 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle2 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle3 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridBaseStyle gridBaseStyle4 = new Syncfusion.Windows.Forms.Grid.GridBaseStyle();
            Syncfusion.Windows.Forms.Grid.GridStyleInfo gridStyleInfo1 = new Syncfusion.Windows.Forms.Grid.GridStyleInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataViewForm));
            this.AddButton = new BudgetExecution.ToolStripButton();
            this.BrowseButton = new BudgetExecution.ToolStripButton();
            this.CalculatorButton = new BudgetExecution.ToolStripButton();
            this.DeleteButton = new BudgetExecution.ToolStripButton();
            this.DropDown = new BudgetExecution.ToolStripDropDown();
            this.ExcelButton = new BudgetExecution.ToolStripButton();
            this.FirstButton = new BudgetExecution.ToolStripButton();
            this.TextBox = new BudgetExecution.ToolStripTextBox();
            this.Separator1 = new BudgetExecution.ToolSeparator();
            this.Label = new BudgetExecution.ToolStripLabel();
            this.Separator2 = new BudgetExecution.ToolSeparator();
            this.Separator3 = new BudgetExecution.ToolSeparator();
            this.Separator4 = new BudgetExecution.ToolSeparator();
            this.PreviousButton = new BudgetExecution.ToolStripButton();
            this.Separator5 = new BudgetExecution.ToolSeparator();
            this.NextButton = new BudgetExecution.ToolStripButton();
            this.Separator6 = new BudgetExecution.ToolSeparator();
            this.LastButton = new BudgetExecution.ToolStripButton();
            this.Separator7 = new BudgetExecution.ToolSeparator();
            this.Separator8 = new BudgetExecution.ToolSeparator();
            this.Separator9 = new BudgetExecution.ToolSeparator();
            this.RefreshButton = new BudgetExecution.ToolStripButton();
            this.Separator10 = new BudgetExecution.ToolSeparator();
            this.SaveButton = new BudgetExecution.ToolStripButton();
            this.Separator11 = new BudgetExecution.ToolSeparator();
            this.Separator12 = new BudgetExecution.ToolSeparator();
            this.Separator13 = new BudgetExecution.ToolSeparator();
            this.ChartButton = new BudgetExecution.ToolStripButton();
            this.Separator14 = new BudgetExecution.ToolSeparator();
            this.Separator15 = new BudgetExecution.ToolSeparator();
            this.HomeButton = new BudgetExecution.ToolStripButton();
            this.Separator16 = new BudgetExecution.ToolSeparator();
            this.GridPanel = new BudgetExecution.Layout();
            this.DataView = new Syncfusion.Windows.Forms.Grid.GridDataBoundGrid();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new BudgetExecution.DataSet();
            this.TableAdapter = new BudgetExecution.DataSetTableAdapters.StatusOfFundsTableAdapter();
            this.ListPanel = new BudgetExecution.Layout();
            this.ListBox = new BudgetExecution.ListBox();
            this.GridPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // AddButton
            // 
            this.AddButton.AutoToolTip = false;
            this.AddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.AddButton.BindingSource = null;
            this.AddButton.DataFilter = null;
            this.AddButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.AddButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.AddButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.AddButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.AddButton.HoverText = null;
            this.AddButton.Image = global::BudgetExecution.Properties.Resources.AddButton;
            this.AddButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.AddButton.Margin = new System.Windows.Forms.Padding(5);
            this.AddButton.Name = "AddButton";
            this.AddButton.Resource = null;
            this.AddButton.Size = new System.Drawing.Size(24, 24);
            this.AddButton.Text = "toolStripButton5";
            this.AddButton.ToolType = BudgetExecution.ToolType.AddButton;
            // 
            // BrowseButton
            // 
            this.BrowseButton.AutoToolTip = false;
            this.BrowseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.BrowseButton.BindingSource = null;
            this.BrowseButton.DataFilter = null;
            this.BrowseButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BrowseButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.BrowseButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.BrowseButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.BrowseButton.HoverText = null;
            this.BrowseButton.Image = global::BudgetExecution.Properties.Resources.BrowseButton;
            this.BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrowseButton.Margin = new System.Windows.Forms.Padding(5);
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Resource = null;
            this.BrowseButton.Size = new System.Drawing.Size(24, 24);
            this.BrowseButton.Text = "toolStripButton1";
            this.BrowseButton.ToolType = BudgetExecution.ToolType.BrowseButton;
            // 
            // CalculatorButton
            // 
            this.CalculatorButton.AutoToolTip = false;
            this.CalculatorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.CalculatorButton.BindingSource = null;
            this.CalculatorButton.DataFilter = null;
            this.CalculatorButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CalculatorButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.CalculatorButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.CalculatorButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CalculatorButton.HoverText = null;
            this.CalculatorButton.Image = global::BudgetExecution.Properties.Resources.CalculatorButton;
            this.CalculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalculatorButton.Margin = new System.Windows.Forms.Padding(5);
            this.CalculatorButton.Name = "CalculatorButton";
            this.CalculatorButton.Resource = null;
            this.CalculatorButton.Size = new System.Drawing.Size(24, 24);
            this.CalculatorButton.Text = "toolStripButton9";
            this.CalculatorButton.ToolType = BudgetExecution.ToolType.CalculatorButton;
            // 
            // DeleteButton
            // 
            this.DeleteButton.AutoToolTip = false;
            this.DeleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.DeleteButton.BindingSource = null;
            this.DeleteButton.DataFilter = null;
            this.DeleteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.DeleteButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.DeleteButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.DeleteButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.DeleteButton.HoverText = null;
            this.DeleteButton.Image = global::BudgetExecution.Properties.Resources.DeleteButton;
            this.DeleteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(5);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Resource = null;
            this.DeleteButton.Size = new System.Drawing.Size(24, 24);
            this.DeleteButton.Text = "toolStripButton6";
            this.DeleteButton.ToolType = BudgetExecution.ToolType.DeleteButton;
            // 
            // DropDown
            // 
            this.DropDown.AllowDrop = true;
            this.DropDown.Bar = BudgetExecution.ToolType.NS;
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
            this.DropDown.Size = new System.Drawing.Size(127, 24);
            this.DropDown.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            this.DropDown.Tag = "Make Selection";
            this.DropDown.ToolTipText = "Make Selection";
            // 
            // ExcelButton
            // 
            this.ExcelButton.AutoToolTip = false;
            this.ExcelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ExcelButton.BindingSource = null;
            this.ExcelButton.DataFilter = null;
            this.ExcelButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ExcelButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.ExcelButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ExcelButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ExcelButton.HoverText = null;
            this.ExcelButton.Image = global::BudgetExecution.Properties.Resources.ExcelButton;
            this.ExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelButton.Margin = new System.Windows.Forms.Padding(5);
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Resource = null;
            this.ExcelButton.Size = new System.Drawing.Size(24, 24);
            this.ExcelButton.Text = "toolStripButton10";
            this.ExcelButton.ToolType = BudgetExecution.ToolType.ExcelButton;
            // 
            // FirstButton
            // 
            this.FirstButton.AutoToolTip = false;
            this.FirstButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.FirstButton.BindingSource = null;
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
            this.FirstButton.Resource = null;
            this.FirstButton.Size = new System.Drawing.Size(24, 24);
            this.FirstButton.Text = "toolStripButton1";
            this.FirstButton.ToolType = BudgetExecution.ToolType.FirstButton;
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBox.Bar = BudgetExecution.ToolType.NS;
            this.TextBox.BindingSource = null;
            this.TextBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.TextBox.HoverText = "";
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(132, 24);
            this.TextBox.Tag = "";
            this.TextBox.ToolTip = null;
            // 
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.Black;
            this.Separator1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator1.Name = "Separator1";
            this.Separator1.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator1.Size = new System.Drawing.Size(6, 34);
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Label.Bar = BudgetExecution.ToolType.NS;
            this.Label.BindingSource = null;
            this.Label.DataFilter = null;
            this.Label.Field = BudgetExecution.Field.RpioActivityCode;
            this.Label.Font = new System.Drawing.Font("Roboto", 9F);
            this.Label.ForeColor = System.Drawing.Color.Black;
            this.Label.HoverText = null;
            this.Label.Margin = new System.Windows.Forms.Padding(5);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(111, 24);
            this.Label.Tag = "";
            this.Label.Text = "Record Information";
            // 
            // Separator2
            // 
            this.Separator2.ForeColor = System.Drawing.Color.Black;
            this.Separator2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator2.Name = "Separator2";
            this.Separator2.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator2.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator3
            // 
            this.Separator3.ForeColor = System.Drawing.Color.Black;
            this.Separator3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator3.Name = "Separator3";
            this.Separator3.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator3.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator4
            // 
            this.Separator4.ForeColor = System.Drawing.Color.Black;
            this.Separator4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator4.Name = "Separator4";
            this.Separator4.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator4.Size = new System.Drawing.Size(6, 34);
            // 
            // PreviousButton
            // 
            this.PreviousButton.AutoToolTip = false;
            this.PreviousButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.PreviousButton.BindingSource = null;
            this.PreviousButton.DataFilter = null;
            this.PreviousButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.PreviousButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.PreviousButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.PreviousButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.PreviousButton.HoverText = null;
            this.PreviousButton.Image = global::BudgetExecution.Properties.Resources.PreviousButton;
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Resource = null;
            this.PreviousButton.Size = new System.Drawing.Size(24, 24);
            this.PreviousButton.Text = "toolStripButton2";
            this.PreviousButton.ToolType = BudgetExecution.ToolType.PreviousButton;
            // 
            // Separator5
            // 
            this.Separator5.ForeColor = System.Drawing.Color.Black;
            this.Separator5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator5.Name = "Separator5";
            this.Separator5.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator5.Size = new System.Drawing.Size(6, 34);
            // 
            // NextButton
            // 
            this.NextButton.AutoToolTip = false;
            this.NextButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.NextButton.BindingSource = null;
            this.NextButton.DataFilter = null;
            this.NextButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.NextButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.NextButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.NextButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.NextButton.HoverText = null;
            this.NextButton.Image = global::BudgetExecution.Properties.Resources.NextButton;
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Resource = null;
            this.NextButton.Size = new System.Drawing.Size(24, 24);
            this.NextButton.Text = "toolStripButton3";
            this.NextButton.ToolType = BudgetExecution.ToolType.NextButton;
            // 
            // Separator6
            // 
            this.Separator6.ForeColor = System.Drawing.Color.Black;
            this.Separator6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator6.Name = "Separator6";
            this.Separator6.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator6.Size = new System.Drawing.Size(6, 34);
            // 
            // LastButton
            // 
            this.LastButton.AutoToolTip = false;
            this.LastButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.LastButton.BindingSource = null;
            this.LastButton.DataFilter = null;
            this.LastButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.LastButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.LastButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.LastButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.LastButton.HoverText = null;
            this.LastButton.Image = global::BudgetExecution.Properties.Resources.LastButton;
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(5);
            this.LastButton.Name = "LastButton";
            this.LastButton.Resource = null;
            this.LastButton.Size = new System.Drawing.Size(24, 24);
            this.LastButton.Text = "toolStripButton4";
            this.LastButton.ToolType = BudgetExecution.ToolType.LastButton;
            // 
            // Separator7
            // 
            this.Separator7.ForeColor = System.Drawing.Color.Black;
            this.Separator7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator7.Name = "Separator7";
            this.Separator7.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator7.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator8
            // 
            this.Separator8.ForeColor = System.Drawing.Color.Black;
            this.Separator8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator8.Name = "Separator8";
            this.Separator8.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator8.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator9
            // 
            this.Separator9.ForeColor = System.Drawing.Color.Black;
            this.Separator9.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator9.Name = "Separator9";
            this.Separator9.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator9.Size = new System.Drawing.Size(6, 34);
            // 
            // RefreshButton
            // 
            this.RefreshButton.AutoToolTip = false;
            this.RefreshButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.RefreshButton.BindingSource = null;
            this.RefreshButton.DataFilter = null;
            this.RefreshButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RefreshButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.RefreshButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.RefreshButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.RefreshButton.HoverText = null;
            this.RefreshButton.Image = global::BudgetExecution.Properties.Resources.RefreshButton;
            this.RefreshButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RefreshButton.Margin = new System.Windows.Forms.Padding(5);
            this.RefreshButton.Name = "RefreshButton";
            this.RefreshButton.Resource = null;
            this.RefreshButton.Size = new System.Drawing.Size(24, 24);
            this.RefreshButton.Text = "toolStripButton7";
            this.RefreshButton.ToolType = BudgetExecution.ToolType.RefreshButton;
            // 
            // Separator10
            // 
            this.Separator10.ForeColor = System.Drawing.Color.Black;
            this.Separator10.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator10.Name = "Separator10";
            this.Separator10.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator10.Size = new System.Drawing.Size(6, 34);
            // 
            // SaveButton
            // 
            this.SaveButton.AutoToolTip = false;
            this.SaveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.SaveButton.BindingSource = null;
            this.SaveButton.DataFilter = null;
            this.SaveButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SaveButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.SaveButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.SaveButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.SaveButton.HoverText = null;
            this.SaveButton.Image = global::BudgetExecution.Properties.Resources.SaveButton;
            this.SaveButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SaveButton.Margin = new System.Windows.Forms.Padding(5);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Resource = null;
            this.SaveButton.Size = new System.Drawing.Size(24, 24);
            this.SaveButton.Text = "toolStripButton8";
            this.SaveButton.ToolType = BudgetExecution.ToolType.SaveButton;
            // 
            // Separator11
            // 
            this.Separator11.ForeColor = System.Drawing.Color.Black;
            this.Separator11.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator11.Name = "Separator11";
            this.Separator11.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator11.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator12
            // 
            this.Separator12.ForeColor = System.Drawing.Color.Black;
            this.Separator12.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator12.Name = "Separator12";
            this.Separator12.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator12.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator13
            // 
            this.Separator13.ForeColor = System.Drawing.Color.Black;
            this.Separator13.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator13.Name = "Separator13";
            this.Separator13.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator13.Size = new System.Drawing.Size(6, 34);
            // 
            // ChartButton
            // 
            this.ChartButton.AutoToolTip = false;
            this.ChartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ChartButton.BindingSource = null;
            this.ChartButton.DataFilter = null;
            this.ChartButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ChartButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.ChartButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.ChartButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.ChartButton.HoverText = null;
            this.ChartButton.Image = global::BudgetExecution.Properties.Resources.ChartButton;
            this.ChartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChartButton.Margin = new System.Windows.Forms.Padding(5);
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Resource = null;
            this.ChartButton.Size = new System.Drawing.Size(24, 24);
            this.ChartButton.Text = "toolStripButton11";
            this.ChartButton.ToolType = BudgetExecution.ToolType.ChartButton;
            // 
            // Separator14
            // 
            this.Separator14.ForeColor = System.Drawing.Color.Black;
            this.Separator14.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator14.Name = "Separator14";
            this.Separator14.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator14.Size = new System.Drawing.Size(6, 34);
            // 
            // Separator15
            // 
            this.Separator15.ForeColor = System.Drawing.Color.Black;
            this.Separator15.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator15.Name = "Separator15";
            this.Separator15.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator15.Size = new System.Drawing.Size(6, 34);
            // 
            // HomeButton
            // 
            this.HomeButton.AutoToolTip = false;
            this.HomeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.HomeButton.BindingSource = null;
            this.HomeButton.DataFilter = null;
            this.HomeButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.HomeButton.Field = BudgetExecution.Field.RpioActivityCode;
            this.HomeButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.HomeButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.HomeButton.HoverText = null;
            this.HomeButton.Image = global::BudgetExecution.Properties.Resources.HomeButton;
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Margin = new System.Windows.Forms.Padding(5);
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Resource = null;
            this.HomeButton.Size = new System.Drawing.Size(24, 24);
            this.HomeButton.Text = "toolStripButton12";
            this.HomeButton.ToolType = BudgetExecution.ToolType.HomeButton;
            // 
            // Separator16
            // 
            this.Separator16.ForeColor = System.Drawing.Color.Black;
            this.Separator16.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator16.Name = "Separator16";
            this.Separator16.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator16.Size = new System.Drawing.Size(6, 34);
            // 
            // GridPanel
            // 
            this.GridPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GridPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.GridPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.GridPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.GridPanel.BindingSource = null;
            this.GridPanel.Border.Color = System.Drawing.Color.DimGray;
            this.GridPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.GridPanel.Border.HoverVisible = true;
            this.GridPanel.Border.Rounding = 6;
            this.GridPanel.Border.Thickness = 1;
            this.GridPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.GridPanel.Border.Visible = true;
            this.GridPanel.Children = null;
            this.GridPanel.Controls.Add(this.DataView);
            this.GridPanel.DataFilter = null;
            this.GridPanel.Field = BudgetExecution.Field.RpioActivityCode;
            this.GridPanel.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GridPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.GridPanel.HoverText = null;
            this.GridPanel.Location = new System.Drawing.Point(24, 141);
            this.GridPanel.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.GridPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.GridPanel.Name = "GridPanel";
            this.GridPanel.Numeric = BudgetExecution.Numeric.NS;
            this.GridPanel.Padding = new System.Windows.Forms.Padding(1);
            this.GridPanel.Size = new System.Drawing.Size(857, 429);
            this.GridPanel.TabIndex = 7;
            this.GridPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.GridPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GridPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GridPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.GridPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.GridPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.GridPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.GridPanel.ToolTip = null;
            // 
            // DataView
            // 
            this.DataView.AllowDragSelectedCols = true;
            this.DataView.AlphaBlendSelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(130)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))), ((int)(((byte)(80)))));
            this.DataView.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
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
            this.DataView.BaseStylesMap.AddRange(new Syncfusion.Windows.Forms.Grid.GridBaseStyle[] {
            gridBaseStyle1,
            gridBaseStyle2,
            gridBaseStyle3,
            gridBaseStyle4});
            this.DataView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DataView.CanOverrideStyle = true;
            this.DataView.ColorStyles = Syncfusion.Windows.Forms.ColorStyles.Office2016Black;
            this.DataView.DataMember = "StatusOfFunds";
            this.DataView.DataSource = this.BindingSource;
            this.DataView.DefaultRowHeight = 28;
            this.DataView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DataView.Font = new System.Drawing.Font("Roboto", 9F);
            this.DataView.GridOfficeScrollBars = Syncfusion.Windows.Forms.OfficeScrollBars.Office2016;
            this.DataView.GridVisualStyles = Syncfusion.Windows.Forms.GridVisualStyles.Office2016DarkGray;
            this.DataView.Location = new System.Drawing.Point(0, 0);
            this.DataView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DataView.Name = "DataView";
            this.DataView.Office2016ScrollBars = true;
            this.DataView.Office2016ScrollBarsColorScheme = Syncfusion.Windows.Forms.ScrollBarOffice2016ColorScheme.DarkGray;
            this.DataView.OptimizeInsertRemoveCells = true;
            this.DataView.Properties.GridLineColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(68)))));
            this.DataView.ShowCurrentCellBorderBehavior = Syncfusion.Windows.Forms.Grid.GridShowCurrentCellBorder.GrayWhenLostFocus;
            this.DataView.Size = new System.Drawing.Size(857, 429);
            this.DataView.SmartSizeBox = false;
            this.DataView.SortBehavior = Syncfusion.Windows.Forms.Grid.GridSortBehavior.DoubleClick;
            this.DataView.TabIndex = 0;
            gridStyleInfo1.Font.Bold = false;
            gridStyleInfo1.Font.Facename = "Roboto";
            gridStyleInfo1.Font.Italic = false;
            gridStyleInfo1.Font.Size = 9F;
            gridStyleInfo1.Font.Strikeout = false;
            gridStyleInfo1.Font.Underline = false;
            gridStyleInfo1.Interior = new Syncfusion.Drawing.BrushInfo(System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40))))));
            this.DataView.TableStyle = gridStyleInfo1;
            this.DataView.ThemesEnabled = true;
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DataView.ThemeStyle.HorizontalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ArrowButtonBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ArrowButtonDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(114)))), ((int)(((byte)(114)))), ((int)(((byte)(114)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ArrowButtonHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(94)))), ((int)(((byte)(94)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ArrowButtonPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ScrollBarBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ThumbBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ThumbColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ThumbDisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ThumbHoverBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ThumbHoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ThumbPressedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(150)))), ((int)(((byte)(150)))), ((int)(((byte)(150)))));
            this.DataView.ThemeStyle.VerticalScrollBarStyle.ThumbPressedColor = System.Drawing.Color.FromArgb(((int)(((byte)(197)))), ((int)(((byte)(197)))), ((int)(((byte)(197)))));
            this.DataView.UseListChangedEvent = true;
            this.DataView.UseRightToLeftCompatibleTextBox = true;
            // 
            // BindingSource
            // 
            this.BindingSource.DataSource = this.DataSet;
            this.BindingSource.Position = 0;
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "DataSet";
            this.DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // TableAdapter
            // 
            this.TableAdapter.ClearBeforeFill = true;
            // 
            // ListPanel
            // 
            this.ListPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ListPanel.BackColor = System.Drawing.Color.Transparent;
            this.ListPanel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListPanel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListPanel.BindingSource = null;
            this.ListPanel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ListPanel.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.ListPanel.Border.HoverVisible = false;
            this.ListPanel.Border.Rounding = 6;
            this.ListPanel.Border.Thickness = 1;
            this.ListPanel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ListPanel.Border.Visible = true;
            this.ListPanel.Children = null;
            this.ListPanel.DataFilter = null;
            this.ListPanel.Field = BudgetExecution.Field.RpioActivityCode;
            this.ListPanel.ForeColor = System.Drawing.Color.LightGray;
            this.ListPanel.HoverText = null;
            this.ListPanel.Location = new System.Drawing.Point(909, 141);
            this.ListPanel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ListPanel.Name = "ListPanel";
            this.ListPanel.Numeric = BudgetExecution.Numeric.NS;
            this.ListPanel.Padding = new System.Windows.Forms.Padding(1);
            this.ListPanel.Size = new System.Drawing.Size(247, 428);
            this.ListPanel.TabIndex = 8;
            this.ListPanel.Text = "layout1";
            this.ListPanel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ListPanel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListPanel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListPanel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListPanel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ListPanel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ListPanel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ListPanel.ToolTip = null;
            // 
            // ListBox
            // 
            this.ListBox.AlternateColors = false;
            this.ListBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ListBox.BindingSource = null;
            this.ListBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
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
            this.ListBox.Location = new System.Drawing.Point(941, 158);
            this.ListBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ListBox.Name = "ListBox";
            this.ListBox.Numeric = BudgetExecution.Numeric.NS;
            this.ListBox.Size = new System.Drawing.Size(186, 385);
            this.ListBox.TabIndex = 8;
            this.ListBox.Text = "ListBox";
            this.ListBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ListBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ListBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ListBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ListBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ListBox.ToolTip = null;
            // 
            // DataViewForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Maroon;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1188, 713);
            this.Controls.Add(this.ListBox);
            this.Controls.Add(this.ListPanel);
            this.Controls.Add(this.GridPanel);
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
            this.Load += new System.EventHandler(this.OnLoad);
            this.GridPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public ToolStripButton AddButton;
        public ToolStripButton BrowseButton;
        public ToolStripButton CalculatorButton;
        public ToolStripButton DeleteButton;
        public ToolStripDropDown DropDown;
        public ToolStripButton ExcelButton;
        public ToolStripButton FirstButton;
        public ToolStripTextBox TextBox;
        public ToolSeparator Separator1;
        public ToolStripLabel Label;
        public ToolSeparator Separator2;
        public ToolSeparator Separator3;
        public ToolSeparator Separator4;
        public ToolStripButton PreviousButton;
        public ToolSeparator Separator5;
        public ToolStripButton NextButton;
        public ToolSeparator Separator6;
        public ToolStripButton LastButton;
        public ToolSeparator Separator7;
        public ToolSeparator Separator8;
        public ToolSeparator Separator9;
        public ToolStripButton RefreshButton;
        public ToolSeparator Separator10;
        public ToolStripButton SaveButton;
        public ToolSeparator Separator11;
        public ToolSeparator Separator12;
        public ToolSeparator Separator13;
        public ToolStripButton ChartButton;
        public ToolSeparator Separator14;
        public ToolSeparator Separator15;
        public ToolStripButton HomeButton;
        public ToolSeparator Separator16;
        public Layout GridPanel;
        public Syncfusion.Windows.Forms.Grid.GridDataBoundGrid DataView;
        public DataSetTableAdapters.StatusOfFundsTableAdapter TableAdapter;
        public Layout ListPanel;
        private ListBox ListBox;
        private System.Windows.Forms.BindingSource BindingSource;
        public DataSet DataSet;
    }
}