namespace BudgetExecution
{
    partial class Frame
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ToolTip = new BudgetExecution.ToolTip();
            this.Table = new System.Windows.Forms.TableLayoutPanel();
            this.Label = new BudgetExecution.Label();
            this.TextBox = new BudgetExecution.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.Table.SuspendLayout();
            this.SuspendLayout();
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
            // Table
            // 
            this.Table.AutoSize = true;
            this.Table.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Table.BackColor = System.Drawing.Color.Transparent;
            this.Table.ColumnCount = 1;
            this.Table.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Controls.Add(this.Label, 0, 0);
            this.Table.Controls.Add(this.TextBox, 0, 1);
            this.Table.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Table.Location = new System.Drawing.Point(1, 1);
            this.Table.Margin = new System.Windows.Forms.Padding(1);
            this.Table.Name = "Table";
            this.Table.Padding = new System.Windows.Forms.Padding(1);
            this.Table.RowCount = 2;
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.Table.Size = new System.Drawing.Size(173, 66);
            this.Table.TabIndex = 2;
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.Transparent;
            this.Label.BindingSource = this.BindingSource;
            this.Label.DataFilter = null;
            this.Label.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Label.Field = BudgetExecution.Field.AccountCode;
            this.Label.Font = new System.Drawing.Font("Roboto", 9F);
            this.Label.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Label.HoverText = null;
            this.Label.Location = new System.Drawing.Point(4, 6);
            this.Label.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Label.Name = "Label";
            this.Label.Numeric = BudgetExecution.Numeric.Accepted;
            this.Label.Orientation = System.Windows.Forms.Orientation.Horizontal;
            this.Label.Outline = false;
            this.Label.OutlineColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Label.OutlineLocation = new System.Drawing.Point(0, 0);
            this.Label.ReflectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.ReflectionSpacing = 0;
            this.Label.ShadowColor = System.Drawing.Color.Black;
            this.Label.ShadowDirection = 315;
            this.Label.ShadowLocation = new System.Drawing.Point(0, 0);
            this.Label.ShadowOpacity = 100;
            this.Label.Size = new System.Drawing.Size(165, 24);
            this.Label.TabIndex = 0;
            this.Label.Text = "Label";
            this.Label.TextAlignment = System.Drawing.StringAlignment.Near;
            this.Label.TextLineAlignment = System.Drawing.StringAlignment.Far;
            this.Label.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Label.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Label.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Label.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Label.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.Label.ToolTip = this.ToolTip;
            // 
            // TextBox
            // 
            this.TextBox.AlphaNumeric = false;
            this.TextBox.BackColor = System.Drawing.Color.Transparent;
            this.TextBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(40)))), ((int)(((byte)(40)))));
            this.TextBox.BindingSource = this.BindingSource;
            this.TextBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TextBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.TextBox.Border.HoverVisible = false;
            this.TextBox.Border.Rounding = 6;
            this.TextBox.Border.Thickness = 1;
            this.TextBox.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox.Border.Visible = true;
            this.TextBox.ButtonBorder.Color = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(180)))), ((int)(((byte)(180)))));
            this.TextBox.ButtonBorder.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(120)))), ((int)(((byte)(183)))), ((int)(((byte)(230)))));
            this.TextBox.ButtonBorder.HoverVisible = true;
            this.TextBox.ButtonBorder.Rounding = 6;
            this.TextBox.ButtonBorder.Thickness = 1;
            this.TextBox.ButtonBorder.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.TextBox.ButtonBorder.Visible = true;
            this.TextBox.ButtonColor.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox.ButtonColor.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(220)))), ((int)(((byte)(220)))), ((int)(((byte)(220)))));
            this.TextBox.ButtonColor.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.TextBox.ButtonColor.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.TextBox.ButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.ButtonIndent = 3;
            this.TextBox.ButtonText = "";
            this.TextBox.ButtonVisible = false;
            this.TextBox.DataFilter = null;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.TextBox.Field = BudgetExecution.Field.AccountCode;
            this.TextBox.Font = new System.Drawing.Font("Roboto Condensed", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TextBox.HoverText = null;
            this.TextBox.Image = null;
            this.TextBox.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox.ImageVisible = false;
            this.TextBox.ImageWidth = 35;
            this.TextBox.Location = new System.Drawing.Point(4, 36);
            this.TextBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox.Name = "TextBox";
            this.TextBox.Numeric = BudgetExecution.Numeric.Accepted;
            this.TextBox.PasswordChar = '\0';
            this.TextBox.ReadOnly = false;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox.Size = new System.Drawing.Size(165, 24);
            this.TextBox.TabIndex = 1;
            this.TextBox.TextBoxWidth = 155;
            this.TextBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox.ToolTip = this.ToolTip;
            this.TextBox.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox.Watermark.Text = "Watermark text";
            this.TextBox.Watermark.Visible = false;
            this.TextBox.WordWrap = false;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.Table);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Margin = new System.Windows.Forms.Padding(1);
            this.Name = "Frame";
            this.Padding = new System.Windows.Forms.Padding(1);
            this.Size = new System.Drawing.Size(175, 68);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.Table.ResumeLayout(false);
            this.Table.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.BindingSource BindingSource;
        public ToolTip ToolTip;
        public System.Windows.Forms.TableLayoutPanel Table;
        public Label Label;
        public TextBox TextBox;
    }
}
