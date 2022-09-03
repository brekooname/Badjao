
namespace BudgetExecution
{
        using System;
        using System.ComponentModel;
        using System.Threading;
        using System.Windows.Forms;
        using VisualPlus.Toolkit.Controls.Editors;
        using VisualPlus.Toolkit.Controls.Interactivity;
        using VisualPlus.Toolkit.Controls.Layout;
        using Syncfusion.Windows.Forms;

        partial class FileBrowser : MetroForm
        {
            /// <summary>
            /// Required designer variable.
            /// </summary>
            private IContainer components = null;

            /// <summary>
            /// Clean up any resources being used.
            /// </summary>
            /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
            protected override void Dispose( bool disposing )
            {
                if( disposing && ( components != null ) )
                {
                    components.Dispose();
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FileBrowser));
            this.TextBoxLayout = new System.Windows.Forms.TableLayoutPanel();
            this.TextBox = new VisualPlus.Toolkit.Controls.Editors.VisualRichTextBox();
            this.CheckBoxLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SqlCeCheckBox = new BudgetExecution.CheckBox();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.CsvCheckBox = new BudgetExecution.CheckBox();
            this.PowerPointCheckBox = new BudgetExecution.CheckBox();
            this.SqlServerCheckBox = new BudgetExecution.CheckBox();
            this.ExcelCheckBox = new BudgetExecution.CheckBox();
            this.AccessCheckBox = new BudgetExecution.CheckBox();
            this.SQLiteCheckBox = new BudgetExecution.CheckBox();
            this.WordCheckBox = new BudgetExecution.CheckBox();
            this.PdfCheckBox = new BudgetExecution.CheckBox();
            this.FileDialog = new System.Windows.Forms.OpenFileDialog();
            this.TopTablePanel = new System.Windows.Forms.TableLayoutPanel();
            this.Header = new BudgetExecution.Label();
            this.PictureBox = new BudgetExecution.PictureBox();
            this.CloseButton = new BudgetExecution.Button();
            this.SelectButton = new BudgetExecution.Button();
            this.TextBoxLayout.SuspendLayout();
            this.CheckBoxLayout.SuspendLayout();
            this.TopTablePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // TextBoxLayout
            // 
            this.TextBoxLayout.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.TextBoxLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.TextBoxLayout.ColumnCount = 4;
            this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 13.26379F));
            this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 69.89568F));
            this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 13F));
            this.TextBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.70863F));
            this.TextBoxLayout.Controls.Add(this.TextBox, 1, 0);
            this.TextBoxLayout.Controls.Add(this.CheckBoxLayout, 3, 0);
            this.TextBoxLayout.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBoxLayout.GrowStyle = System.Windows.Forms.TableLayoutPanelGrowStyle.FixedSize;
            this.TextBoxLayout.Location = new System.Drawing.Point(0, 55);
            this.TextBoxLayout.Margin = new System.Windows.Forms.Padding(5);
            this.TextBoxLayout.Name = "TextBoxLayout";
            this.TextBoxLayout.Padding = new System.Windows.Forms.Padding(1);
            this.TextBoxLayout.RowCount = 1;
            this.TextBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.TextBoxLayout.Size = new System.Drawing.Size(688, 314);
            this.TextBoxLayout.TabIndex = 5;
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(5)))), ((int)(((byte)(5)))));
            this.TextBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(50)))), ((int)(((byte)(50)))));
            this.TextBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.TextBox.Border.HoverVisible = false;
            this.TextBox.Border.Rounding = 6;
            this.TextBox.Border.Thickness = 1;
            this.TextBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox.Border.Visible = true;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TextBox.Location = new System.Drawing.Point(95, 6);
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.MaxLength = 2147483647;
            this.TextBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox.Name = "TextBox";
            this.TextBox.ReadOnly = false;
            this.TextBox.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Both;
            this.TextBox.ShowSelectionMargin = false;
            this.TextBox.Size = new System.Drawing.Size(461, 302);
            this.TextBox.TabIndex = 0;
            this.TextBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // CheckBoxLayout
            // 
            this.CheckBoxLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CheckBoxLayout.ColumnCount = 1;
            this.CheckBoxLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.CheckBoxLayout.Controls.Add(this.SqlCeCheckBox, 0, 8);
            this.CheckBoxLayout.Controls.Add(this.CsvCheckBox, 0, 5);
            this.CheckBoxLayout.Controls.Add(this.PowerPointCheckBox, 0, 7);
            this.CheckBoxLayout.Controls.Add(this.SqlServerCheckBox, 0, 2);
            this.CheckBoxLayout.Controls.Add(this.ExcelCheckBox, 0, 6);
            this.CheckBoxLayout.Controls.Add(this.AccessCheckBox, 0, 4);
            this.CheckBoxLayout.Controls.Add(this.SQLiteCheckBox, 0, 3);
            this.CheckBoxLayout.Controls.Add(this.WordCheckBox, 0, 1);
            this.CheckBoxLayout.Controls.Add(this.PdfCheckBox, 0, 0);
            this.CheckBoxLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CheckBoxLayout.Location = new System.Drawing.Point(577, 4);
            this.CheckBoxLayout.Name = "CheckBoxLayout";
            this.CheckBoxLayout.RowCount = 9;
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.67728F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.04034F));
            this.CheckBoxLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.CheckBoxLayout.Size = new System.Drawing.Size(107, 306);
            this.CheckBoxLayout.TabIndex = 2;
            // 
            // SqlCeCheckBox
            // 
            this.SqlCeCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SqlCeCheckBox.BindingSource = null;
            this.SqlCeCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SqlCeCheckBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SqlCeCheckBox.Border.HoverVisible = true;
            this.SqlCeCheckBox.Border.Rounding = 3;
            this.SqlCeCheckBox.Border.Thickness = 1;
            this.SqlCeCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SqlCeCheckBox.Border.Visible = true;
            this.SqlCeCheckBox.Box = new System.Drawing.Size(14, 14);
            this.SqlCeCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SqlCeCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SqlCeCheckBox.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SqlCeCheckBox.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SqlCeCheckBox.BoxSpacing = 4;
            this.SqlCeCheckBox.CheckStyle.AutoSize = true;
            this.SqlCeCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.SqlCeCheckBox.CheckStyle.Character = '✔';
            this.SqlCeCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.SqlCeCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlCeCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image")));
            this.SqlCeCheckBox.CheckStyle.ShapeRounding = 3;
            this.SqlCeCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SqlCeCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.SqlCeCheckBox.CheckStyle.Thickness = 2F;
            this.SqlCeCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SqlCeCheckBox.DataFilter = null;
            this.SqlCeCheckBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlCeCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SqlCeCheckBox.HoverText = "Search  ( *.sdf ) Files";
            this.SqlCeCheckBox.IsBoxLarger = false;
            this.SqlCeCheckBox.Location = new System.Drawing.Point(3, 269);
            this.SqlCeCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.SqlCeCheckBox.Name = "SqlCeCheckBox";
            this.SqlCeCheckBox.Size = new System.Drawing.Size(101, 25);
            this.SqlCeCheckBox.TabIndex = 12;
            this.SqlCeCheckBox.Text = " SQL Compact";
            this.SqlCeCheckBox.TextSize = new System.Drawing.Size(76, 15);
            this.SqlCeCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.SqlCeCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlCeCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlCeCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlCeCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SqlCeCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.SqlCeCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.SqlCeCheckBox.ToolTip = this.ToolTip;
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
            // CsvCheckBox
            // 
            this.CsvCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CsvCheckBox.BindingSource = null;
            this.CsvCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CsvCheckBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CsvCheckBox.Border.HoverVisible = true;
            this.CsvCheckBox.Border.Rounding = 3;
            this.CsvCheckBox.Border.Thickness = 1;
            this.CsvCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CsvCheckBox.Border.Visible = true;
            this.CsvCheckBox.Box = new System.Drawing.Size(14, 14);
            this.CsvCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CsvCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.CsvCheckBox.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.CsvCheckBox.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.CsvCheckBox.BoxSpacing = 4;
            this.CsvCheckBox.CheckStyle.AutoSize = true;
            this.CsvCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.CsvCheckBox.CheckStyle.Character = '✔';
            this.CsvCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.CsvCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CsvCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image1")));
            this.CsvCheckBox.CheckStyle.ShapeRounding = 3;
            this.CsvCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CsvCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.CsvCheckBox.CheckStyle.Thickness = 2F;
            this.CsvCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CsvCheckBox.DataFilter = null;
            this.CsvCheckBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CsvCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CsvCheckBox.HoverText = "Search ( *.csv ) Files";
            this.CsvCheckBox.IsBoxLarger = false;
            this.CsvCheckBox.Location = new System.Drawing.Point(3, 170);
            this.CsvCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CsvCheckBox.Name = "CsvCheckBox";
            this.CsvCheckBox.Size = new System.Drawing.Size(101, 25);
            this.CsvCheckBox.TabIndex = 12;
            this.CsvCheckBox.Text = " CSV";
            this.CsvCheckBox.TextSize = new System.Drawing.Size(28, 15);
            this.CsvCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.CsvCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CsvCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CsvCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.CsvCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CsvCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.CsvCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.CsvCheckBox.ToolTip = this.ToolTip;
            // 
            // PowerPointCheckBox
            // 
            this.PowerPointCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PowerPointCheckBox.BindingSource = null;
            this.PowerPointCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PowerPointCheckBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.PowerPointCheckBox.Border.HoverVisible = true;
            this.PowerPointCheckBox.Border.Rounding = 3;
            this.PowerPointCheckBox.Border.Thickness = 1;
            this.PowerPointCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.PowerPointCheckBox.Border.Visible = true;
            this.PowerPointCheckBox.Box = new System.Drawing.Size(14, 14);
            this.PowerPointCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PowerPointCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PowerPointCheckBox.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.PowerPointCheckBox.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PowerPointCheckBox.BoxSpacing = 4;
            this.PowerPointCheckBox.CheckStyle.AutoSize = true;
            this.PowerPointCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.PowerPointCheckBox.CheckStyle.Character = '✔';
            this.PowerPointCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.PowerPointCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerPointCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image2")));
            this.PowerPointCheckBox.CheckStyle.ShapeRounding = 3;
            this.PowerPointCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.PowerPointCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.PowerPointCheckBox.CheckStyle.Thickness = 2F;
            this.PowerPointCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PowerPointCheckBox.DataFilter = null;
            this.PowerPointCheckBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PowerPointCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.PowerPointCheckBox.HoverText = "Search ( *.ppt ) Files";
            this.PowerPointCheckBox.IsBoxLarger = false;
            this.PowerPointCheckBox.Location = new System.Drawing.Point(3, 236);
            this.PowerPointCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.PowerPointCheckBox.Name = "PowerPointCheckBox";
            this.PowerPointCheckBox.Size = new System.Drawing.Size(101, 25);
            this.PowerPointCheckBox.TabIndex = 11;
            this.PowerPointCheckBox.Text = " Power Point";
            this.PowerPointCheckBox.TextSize = new System.Drawing.Size(68, 15);
            this.PowerPointCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.PowerPointCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PowerPointCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PowerPointCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PowerPointCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.PowerPointCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.PowerPointCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PowerPointCheckBox.ToolTip = this.ToolTip;
            // 
            // SqlServerCheckBox
            // 
            this.SqlServerCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SqlServerCheckBox.BindingSource = null;
            this.SqlServerCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SqlServerCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.SqlServerCheckBox.Border.HoverVisible = true;
            this.SqlServerCheckBox.Border.Rounding = 3;
            this.SqlServerCheckBox.Border.Thickness = 1;
            this.SqlServerCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SqlServerCheckBox.Border.Visible = true;
            this.SqlServerCheckBox.Box = new System.Drawing.Size(14, 14);
            this.SqlServerCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SqlServerCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SqlServerCheckBox.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SqlServerCheckBox.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SqlServerCheckBox.BoxSpacing = 4;
            this.SqlServerCheckBox.CheckStyle.AutoSize = true;
            this.SqlServerCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.SqlServerCheckBox.CheckStyle.Character = '✔';
            this.SqlServerCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.SqlServerCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlServerCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image3")));
            this.SqlServerCheckBox.CheckStyle.ShapeRounding = 3;
            this.SqlServerCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SqlServerCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.SqlServerCheckBox.CheckStyle.Thickness = 2F;
            this.SqlServerCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SqlServerCheckBox.DataFilter = null;
            this.SqlServerCheckBox.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SqlServerCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SqlServerCheckBox.HoverText = "Search ( *.mdf ) Files";
            this.SqlServerCheckBox.IsBoxLarger = false;
            this.SqlServerCheckBox.Location = new System.Drawing.Point(3, 71);
            this.SqlServerCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.SqlServerCheckBox.Name = "SqlServerCheckBox";
            this.SqlServerCheckBox.Size = new System.Drawing.Size(101, 25);
            this.SqlServerCheckBox.TabIndex = 11;
            this.SqlServerCheckBox.Text = " SQL Server";
            this.SqlServerCheckBox.TextSize = new System.Drawing.Size(55, 15);
            this.SqlServerCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.SqlServerCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlServerCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlServerCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SqlServerCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SqlServerCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.SqlServerCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.SqlServerCheckBox.ToolTip = this.ToolTip;
            // 
            // ExcelCheckBox
            // 
            this.ExcelCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ExcelCheckBox.BindingSource = null;
            this.ExcelCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ExcelCheckBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ExcelCheckBox.Border.HoverVisible = true;
            this.ExcelCheckBox.Border.Rounding = 3;
            this.ExcelCheckBox.Border.Thickness = 1;
            this.ExcelCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ExcelCheckBox.Border.Visible = true;
            this.ExcelCheckBox.Box = new System.Drawing.Size(14, 14);
            this.ExcelCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ExcelCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.ExcelCheckBox.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.ExcelCheckBox.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.ExcelCheckBox.BoxSpacing = 4;
            this.ExcelCheckBox.CheckStyle.AutoSize = true;
            this.ExcelCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.ExcelCheckBox.CheckStyle.Character = '✔';
            this.ExcelCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.ExcelCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image4")));
            this.ExcelCheckBox.CheckStyle.ShapeRounding = 3;
            this.ExcelCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.ExcelCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.ExcelCheckBox.CheckStyle.Thickness = 2F;
            this.ExcelCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ExcelCheckBox.DataFilter = null;
            this.ExcelCheckBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ExcelCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.ExcelCheckBox.HoverText = "Search ( *.xlsx ) Files";
            this.ExcelCheckBox.IsBoxLarger = false;
            this.ExcelCheckBox.Location = new System.Drawing.Point(3, 203);
            this.ExcelCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.ExcelCheckBox.Name = "ExcelCheckBox";
            this.ExcelCheckBox.Size = new System.Drawing.Size(101, 25);
            this.ExcelCheckBox.TabIndex = 10;
            this.ExcelCheckBox.Text = " Excel";
            this.ExcelCheckBox.TextSize = new System.Drawing.Size(33, 15);
            this.ExcelCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.ExcelCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExcelCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExcelCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.ExcelCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.ExcelCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.ExcelCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.ExcelCheckBox.ToolTip = this.ToolTip;
            // 
            // AccessCheckBox
            // 
            this.AccessCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AccessCheckBox.BindingSource = null;
            this.AccessCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.AccessCheckBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.AccessCheckBox.Border.HoverVisible = true;
            this.AccessCheckBox.Border.Rounding = 3;
            this.AccessCheckBox.Border.Thickness = 1;
            this.AccessCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.AccessCheckBox.Border.Visible = true;
            this.AccessCheckBox.Box = new System.Drawing.Size(14, 14);
            this.AccessCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.AccessCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.AccessCheckBox.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.AccessCheckBox.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.AccessCheckBox.BoxSpacing = 4;
            this.AccessCheckBox.CheckStyle.AutoSize = true;
            this.AccessCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.AccessCheckBox.CheckStyle.Character = '✔';
            this.AccessCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.AccessCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image5")));
            this.AccessCheckBox.CheckStyle.ShapeRounding = 3;
            this.AccessCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.AccessCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.AccessCheckBox.CheckStyle.Thickness = 2F;
            this.AccessCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.AccessCheckBox.DataFilter = null;
            this.AccessCheckBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AccessCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.AccessCheckBox.HoverText = "Search ( *.accdb ) Files";
            this.AccessCheckBox.IsBoxLarger = false;
            this.AccessCheckBox.Location = new System.Drawing.Point(3, 137);
            this.AccessCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.AccessCheckBox.Name = "AccessCheckBox";
            this.AccessCheckBox.Size = new System.Drawing.Size(101, 25);
            this.AccessCheckBox.TabIndex = 11;
            this.AccessCheckBox.Text = " Access";
            this.AccessCheckBox.TextSize = new System.Drawing.Size(43, 15);
            this.AccessCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.AccessCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AccessCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AccessCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.AccessCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.AccessCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.AccessCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.AccessCheckBox.ToolTip = this.ToolTip;
            // 
            // SQLiteCheckBox
            // 
            this.SQLiteCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SQLiteCheckBox.BindingSource = null;
            this.SQLiteCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SQLiteCheckBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SQLiteCheckBox.Border.HoverVisible = true;
            this.SQLiteCheckBox.Border.Rounding = 3;
            this.SQLiteCheckBox.Border.Thickness = 1;
            this.SQLiteCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SQLiteCheckBox.Border.Visible = true;
            this.SQLiteCheckBox.Box = new System.Drawing.Size(14, 14);
            this.SQLiteCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SQLiteCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.SQLiteCheckBox.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.SQLiteCheckBox.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.SQLiteCheckBox.BoxSpacing = 4;
            this.SQLiteCheckBox.CheckStyle.AutoSize = true;
            this.SQLiteCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.SQLiteCheckBox.CheckStyle.Character = '✔';
            this.SQLiteCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.SQLiteCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLiteCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image6")));
            this.SQLiteCheckBox.CheckStyle.ShapeRounding = 3;
            this.SQLiteCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SQLiteCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.SQLiteCheckBox.CheckStyle.Thickness = 2F;
            this.SQLiteCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SQLiteCheckBox.DataFilter = null;
            this.SQLiteCheckBox.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SQLiteCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SQLiteCheckBox.HoverText = "Search ( *.db ) Files";
            this.SQLiteCheckBox.IsBoxLarger = false;
            this.SQLiteCheckBox.Location = new System.Drawing.Point(3, 104);
            this.SQLiteCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.SQLiteCheckBox.Name = "SQLiteCheckBox";
            this.SQLiteCheckBox.Size = new System.Drawing.Size(101, 25);
            this.SQLiteCheckBox.TabIndex = 10;
            this.SQLiteCheckBox.Text = " SQLite";
            this.SQLiteCheckBox.TextSize = new System.Drawing.Size(40, 15);
            this.SQLiteCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.SQLiteCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SQLiteCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SQLiteCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.SQLiteCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SQLiteCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.SQLiteCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.SQLiteCheckBox.ToolTip = this.ToolTip;
            // 
            // WordCheckBox
            // 
            this.WordCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.WordCheckBox.BindingSource = null;
            this.WordCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.WordCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.WordCheckBox.Border.HoverVisible = true;
            this.WordCheckBox.Border.Rounding = 3;
            this.WordCheckBox.Border.Thickness = 1;
            this.WordCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.WordCheckBox.Border.Visible = true;
            this.WordCheckBox.Box = new System.Drawing.Size(14, 14);
            this.WordCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.WordCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.WordCheckBox.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.WordCheckBox.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.WordCheckBox.BoxSpacing = 4;
            this.WordCheckBox.CheckStyle.AutoSize = true;
            this.WordCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.WordCheckBox.CheckStyle.Character = '✔';
            this.WordCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.WordCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image7")));
            this.WordCheckBox.CheckStyle.ShapeRounding = 3;
            this.WordCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.WordCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.WordCheckBox.CheckStyle.Thickness = 2F;
            this.WordCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.WordCheckBox.DataFilter = null;
            this.WordCheckBox.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.WordCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.WordCheckBox.HoverText = "Search ( *.docx ) Files";
            this.WordCheckBox.IsBoxLarger = false;
            this.WordCheckBox.Location = new System.Drawing.Point(3, 38);
            this.WordCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.WordCheckBox.Name = "WordCheckBox";
            this.WordCheckBox.Size = new System.Drawing.Size(101, 25);
            this.WordCheckBox.TabIndex = 10;
            this.WordCheckBox.Text = "  Word";
            this.WordCheckBox.TextSize = new System.Drawing.Size(32, 15);
            this.WordCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.WordCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.WordCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.WordCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.WordCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.WordCheckBox.ToolTip = this.ToolTip;
            // 
            // PdfCheckBox
            // 
            this.PdfCheckBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PdfCheckBox.BindingSource = null;
            this.PdfCheckBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PdfCheckBox.Border.HoverColor = System.Drawing.Color.SteelBlue;
            this.PdfCheckBox.Border.HoverVisible = true;
            this.PdfCheckBox.Border.Rounding = 3;
            this.PdfCheckBox.Border.Thickness = 1;
            this.PdfCheckBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.PdfCheckBox.Border.Visible = true;
            this.PdfCheckBox.Box = new System.Drawing.Size(14, 14);
            this.PdfCheckBox.BoxColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.PdfCheckBox.BoxColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.PdfCheckBox.BoxColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(93)))), ((int)(((byte)(129)))));
            this.PdfCheckBox.BoxColorState.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.PdfCheckBox.BoxSpacing = 4;
            this.PdfCheckBox.CheckStyle.AutoSize = true;
            this.PdfCheckBox.CheckStyle.Bounds = new System.Drawing.Rectangle(0, 0, 125, 23);
            this.PdfCheckBox.CheckStyle.Character = '✔';
            this.PdfCheckBox.CheckStyle.CheckColor = System.Drawing.Color.Lime;
            this.PdfCheckBox.CheckStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdfCheckBox.CheckStyle.Image = ((System.Drawing.Image)(resources.GetObject("resource.Image8")));
            this.PdfCheckBox.CheckStyle.ShapeRounding = 3;
            this.PdfCheckBox.CheckStyle.ShapeType = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.PdfCheckBox.CheckStyle.Style = VisualPlus.Models.CheckStyle.CheckType.Checkmark;
            this.PdfCheckBox.CheckStyle.Thickness = 2F;
            this.PdfCheckBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.PdfCheckBox.DataFilter = null;
            this.PdfCheckBox.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PdfCheckBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.PdfCheckBox.HoverText = "Search ( *.pdf ) Files";
            this.PdfCheckBox.IsBoxLarger = false;
            this.PdfCheckBox.Location = new System.Drawing.Point(3, 3);
            this.PdfCheckBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.PdfCheckBox.Name = "PdfCheckBox";
            this.PdfCheckBox.Size = new System.Drawing.Size(101, 25);
            this.PdfCheckBox.TabIndex = 14;
            this.PdfCheckBox.Text = "  PDF ";
            this.PdfCheckBox.TextSize = new System.Drawing.Size(27, 15);
            this.PdfCheckBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.PdfCheckBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PdfCheckBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PdfCheckBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.PdfCheckBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.PdfCheckBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.PdfCheckBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.PdfCheckBox.ToolTip = this.ToolTip;
            // 
            // FileDialog
            // 
            this.FileDialog.Filter = "Document FIles | *.PDF | *.DOCX | *.DOC ";
            // 
            // TopTablePanel
            // 
            this.TopTablePanel.ColumnCount = 3;
            this.TopTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 15.38461F));
            this.TopTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 84.61539F));
            this.TopTablePanel.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 118F));
            this.TopTablePanel.Controls.Add(this.Header, 1, 0);
            this.TopTablePanel.Controls.Add(this.PictureBox, 0, 0);
            this.TopTablePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TopTablePanel.Location = new System.Drawing.Point(0, 0);
            this.TopTablePanel.Name = "TopTablePanel";
            this.TopTablePanel.RowCount = 1;
            this.TopTablePanel.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.TopTablePanel.Size = new System.Drawing.Size(688, 55);
            this.TopTablePanel.TabIndex = 9;
            // 
            // Header
            // 
            this.Header.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Header.BindingSource = null;
            this.Header.DataFilter = null;
            this.Header.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Header.Field = BudgetExecution.Field.RpioActivityCode;
            this.Header.Font = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Header.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Header.HoverText = null;
            this.Header.Location = new System.Drawing.Point(90, 3);
            this.Header.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Header.Name = "Header";
            this.Header.Numeric = BudgetExecution.Numeric.NS;
            this.Header.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Header.Outline = false;
            this.Header.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Header.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Header.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Header.ReflectionSpacing = 0;
            this.Header.ShadowColor = System.Drawing.Color.Black;
            this.Header.ShadowDirection = 315;
            this.Header.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Header.ShadowOpacity = 100;
            this.Header.Size = new System.Drawing.Size(476, 49);
            this.Header.TabIndex = 0;
            this.Header.Text = "File Search";
            this.Header.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Header.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Header.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Header.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Header.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Header.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Header.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Header.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Header.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.Header.ToolTip = null;
            // 
            // PictureBox
            // 
            this.PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.PictureBox.BindingSource = null;
            this.PictureBox.DataFilter = null;
            this.PictureBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.PictureBox.HoverText = null;
            this.PictureBox.Image = global::BudgetExecution.Properties.Resources.LookupButton;
            this.PictureBox.InitialImage = null;
            this.PictureBox.Location = new System.Drawing.Point(3, 3);
            this.PictureBox.Name = "PictureBox";
            this.PictureBox.Numeric = BudgetExecution.Numeric.NS;
            this.PictureBox.Padding = new System.Windows.Forms.Padding(1);
            this.PictureBox.Size = new System.Drawing.Size(29, 29);
            this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PictureBox.TabIndex = 1;
            this.PictureBox.TabStop = false;
            this.PictureBox.ToolTip = null;
            // 
            // CloseButton
            // 
            this.CloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.CloseButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.CloseButton.BindingSource = null;
            this.CloseButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.Border.HoverVisible = true;
            this.CloseButton.Border.Rounding = 6;
            this.CloseButton.Border.Thickness = 1;
            this.CloseButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.CloseButton.Border.Visible = true;
            this.CloseButton.DataFilter = null;
            this.CloseButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.CloseButton.Field = BudgetExecution.Field.AccountCode;
            this.CloseButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.CloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.HoverText = "Close Window";
            this.CloseButton.Image = null;
            this.CloseButton.Images = null;
            this.CloseButton.Location = new System.Drawing.Point(463, 383);
            this.CloseButton.Margin = new System.Windows.Forms.Padding(0);
            this.CloseButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Size = new System.Drawing.Size(187, 76);
            this.CloseButton.TabIndex = 10;
            this.CloseButton.Text = "Close";
            this.CloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.CloseButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CloseButton.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CloseButton.TextStyle.Hover = System.Drawing.Color.White;
            this.CloseButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.CloseButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.CloseButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.CloseButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.CloseButton.ToolTip = null;
            // 
            // SelectButton
            // 
            this.SelectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SelectButton.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SelectButton.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SelectButton.BackColorState.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.SelectButton.BackColorState.Pressed = System.Drawing.Color.SteelBlue;
            this.SelectButton.BindingSource = null;
            this.SelectButton.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SelectButton.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.Border.HoverVisible = true;
            this.SelectButton.Border.Rounding = 6;
            this.SelectButton.Border.Thickness = 1;
            this.SelectButton.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.SelectButton.Border.Visible = true;
            this.SelectButton.DataFilter = null;
            this.SelectButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SelectButton.Field = BudgetExecution.Field.AccountCode;
            this.SelectButton.Font = new System.Drawing.Font("Roboto", 9F);
            this.SelectButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.HoverText = "Select File";
            this.SelectButton.Image = null;
            this.SelectButton.Images = null;
            this.SelectButton.Location = new System.Drawing.Point(46, 383);
            this.SelectButton.Margin = new System.Windows.Forms.Padding(0);
            this.SelectButton.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.SelectButton.Name = "SelectButton";
            this.SelectButton.Size = new System.Drawing.Size(187, 76);
            this.SelectButton.TabIndex = 11;
            this.SelectButton.Text = "Select";
            this.SelectButton.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.SelectButton.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.SelectButton.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.SelectButton.TextStyle.Hover = System.Drawing.Color.White;
            this.SelectButton.TextStyle.Pressed = System.Drawing.Color.White;
            this.SelectButton.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.SelectButton.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.SelectButton.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.SelectButton.ToolTip = null;
            // 
            // FileBrowser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.CaptionButtonHoverColor = System.Drawing.Color.Red;
            this.CaptionFont = new System.Drawing.Font("Roboto", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ClientSize = new System.Drawing.Size(688, 468);
            this.ControlBox = false;
            this.Controls.Add(this.SelectButton);
            this.Controls.Add(this.CloseButton);
            this.Controls.Add(this.TextBoxLayout);
            this.Controls.Add(this.TopTablePanel);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(700, 550);
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MinimizeBox = false;
            this.Name = "FileBrowser";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TextBoxLayout.ResumeLayout(false);
            this.CheckBoxLayout.ResumeLayout(false);
            this.TopTablePanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
            this.ResumeLayout(false);

            }

            #endregion

            public TableLayoutPanel TextBoxLayout;

            public VisualRichTextBox TextBox;
            public TableLayoutPanel CheckBoxLayout;
            public OpenFileDialog FileDialog;
        public ToolTip ToolTip;
        public TableLayoutPanel TopTablePanel;
        public Label Header;
        private PictureBox PictureBox;
        public CheckBox PdfCheckBox;
        public CheckBox WordCheckBox;
        public CheckBox SqlServerCheckBox;
        public CheckBox SqlCeCheckBox;
        public CheckBox CsvCheckBox;
        public CheckBox PowerPointCheckBox;
        public CheckBox ExcelCheckBox;
        public CheckBox AccessCheckBox;
        public CheckBox SQLiteCheckBox;
        public Button CloseButton;
        public Button SelectButton;
    }
    
}
