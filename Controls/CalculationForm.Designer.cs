namespace BudgetExecution
{
    partial class CalculationForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculationForm));
            this.Calculator = new Syncfusion.Windows.Forms.Tools.CalculatorControl();
            this.SuspendLayout();
            // 
            // Calculator
            // 
            this.Calculator.AccessibleDescription = "Calculator control";
            this.Calculator.AccessibleName = "Calculator Control";
            this.Calculator.BeforeTouchSize = new System.Drawing.Size(398, 429);
            this.Calculator.ButtonStyle = Syncfusion.Windows.Forms.ButtonAppearance.Metro;
            this.Calculator.CanOverrideStyle = true;
            this.Calculator.Culture = new System.Globalization.CultureInfo("en-US");
            this.Calculator.DisplayTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.Calculator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Calculator.DoubleValue = 0D;
            this.Calculator.EnableTouchMode = true;
            this.Calculator.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator.ForeColor = System.Drawing.Color.LightGray;
            this.Calculator.Location = new System.Drawing.Point(0, 0);
            this.Calculator.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calculator.Name = "Calculator";
            this.Calculator.Office2007Theme = Syncfusion.Windows.Forms.Office2007Theme.Managed;
            this.Calculator.Office2010Theme = Syncfusion.Windows.Forms.Office2010Theme.Managed;
            this.Calculator.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Calculator.Size = new System.Drawing.Size(398, 429);
            this.Calculator.TabIndex = 0;
            this.Calculator.ThemeName = "Metro";
            this.Calculator.ThemesEnabled = false;
            this.Calculator.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calculator.ThemeStyle.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Calculator.ThemeStyle.BorderThickness = 0;
            this.Calculator.ThemeStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator.ThemeStyle.ForeColor = System.Drawing.Color.White;
            this.Calculator.ThemeStyle.TextBoxBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Calculator.ThemeStyle.ToolTipStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.Calculator.ThemeStyle.ToolTipStyle.BorderColor = System.Drawing.Color.SteelBlue;
            this.Calculator.ThemeStyle.ToolTipStyle.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Calculator.ThemeStyle.ToolTipStyle.ForeColor = System.Drawing.Color.SteelBlue;
            this.Calculator.UseVerticalAndHorizontalSpacing = true;
            this.Calculator.UseVisualStyle = true;
            // 
            // CalculationForm
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
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(398, 429);
            this.Controls.Add(this.Calculator);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MinimizeBox = false;
            this.Name = "CalculationForm";
            this.ShowIcon = false;
            this.ResumeLayout(false);

        }

        #endregion

        public Syncfusion.Windows.Forms.Tools.CalculatorControl Calculator;
    }
}