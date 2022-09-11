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
            this.Label = new BudgetExecution.Label();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.TextBox = new BudgetExecution.TextBox();
            this.Panel = new BudgetExecution.Layout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Label.BindingSource = this.BindingSource;
            this.Label.DataFilter = null;
            this.Label.Dock = System.Windows.Forms.DockStyle.Top;
            this.Label.Field = BudgetExecution.Field.AccountCode;
            this.Label.Font = new System.Drawing.Font("Roboto", 9F);
            this.Label.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Label.HoverText = null;
            this.Label.Location = new System.Drawing.Point(0, 0);
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
            this.Label.Size = new System.Drawing.Size(151, 23);
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
            this.Label.ToolTip = null;
            // 
            // TextBox
            // 
            this.TextBox.AlphaNumeric = false;
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.TextBox.BindingSource = this.BindingSource;
            this.TextBox.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TextBox.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.TextBox.Border.HoverVisible = true;
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
            this.TextBox.ButtonText = "visualButton";
            this.TextBox.ButtonVisible = false;
            this.TextBox.DataFilter = null;
            this.TextBox.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.TextBox.Field = BudgetExecution.Field.AccountCode;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.TextBox.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.TextBox.HoverText = null;
            this.TextBox.Image = null;
            this.TextBox.ImageSize = new System.Drawing.Size(16, 16);
            this.TextBox.ImageVisible = false;
            this.TextBox.ImageWidth = 35;
            this.TextBox.Location = new System.Drawing.Point(0, 29);
            this.TextBox.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.TextBox.Name = "TextBox";
            this.TextBox.Numeric = BudgetExecution.Numeric.Accepted;
            this.TextBox.PasswordChar = '\0';
            this.TextBox.ReadOnly = false;
            this.TextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.TextBox.Size = new System.Drawing.Size(151, 25);
            this.TextBox.TabIndex = 1;
            this.TextBox.TextBoxWidth = 141;
            this.TextBox.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.TextBox.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TextBox.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.TextBox.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.TextBox.ToolTip = null;
            this.TextBox.Watermark.Active = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.TextBox.Watermark.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.Watermark.Inactive = System.Drawing.Color.FromArgb(((int)(((byte)(211)))), ((int)(((byte)(211)))), ((int)(((byte)(211)))));
            this.TextBox.Watermark.Text = "Watermark text";
            this.TextBox.Watermark.Visible = false;
            this.TextBox.WordWrap = false;
            // 
            // Panel
            // 
            this.Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Panel.BackColorState.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Panel.BackColorState.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Panel.BindingSource = null;
            this.Panel.Border.Color = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Panel.Border.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(120)))), ((int)(((byte)(212)))));
            this.Panel.Border.HoverVisible = true;
            this.Panel.Border.Rounding = 6;
            this.Panel.Border.Thickness = 1;
            this.Panel.Border.Type = VisualPlus.Enumerators.ShapeTypes.Rounded;
            this.Panel.Border.Visible = true;
            this.Panel.Children = null;
            this.Panel.DataFilter = null;
            this.Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Panel.Field = BudgetExecution.Field.AccountCode;
            this.Panel.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Panel.HoverText = null;
            this.Panel.Location = new System.Drawing.Point(0, 0);
            this.Panel.MouseState = VisualPlus.Enumerators.MouseStates.Normal;
            this.Panel.Name = "Panel";
            this.Panel.Numeric = BudgetExecution.Numeric.Accepted;
            this.Panel.Padding = new System.Windows.Forms.Padding(1);
            this.Panel.Size = new System.Drawing.Size(151, 54);
            this.Panel.TabIndex = 2;
            this.Panel.TextStyle.Disabled = System.Drawing.Color.FromArgb(((int)(((byte)(131)))), ((int)(((byte)(129)))), ((int)(((byte)(129)))));
            this.Panel.TextStyle.Enabled = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel.TextStyle.Hover = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel.TextStyle.Pressed = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.Panel.TextStyle.TextAlignment = System.Drawing.StringAlignment.Center;
            this.Panel.TextStyle.TextLineAlignment = System.Drawing.StringAlignment.Center;
            this.Panel.TextStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            this.Panel.ToolTip = null;
            // 
            // Frame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Controls.Add(this.Label);
            this.Controls.Add(this.TextBox);
            this.Controls.Add(this.Panel);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.Name = "Frame";
            this.Size = new System.Drawing.Size(151, 54);
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Label Label;
        public TextBox TextBox;
        public System.Windows.Forms.BindingSource BindingSource;
        public Layout Panel;
    }
}
