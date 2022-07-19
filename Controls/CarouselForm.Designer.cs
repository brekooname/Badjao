namespace BudgetExecution
{
    partial class CarouselForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CarouselForm));
            this.Toolbar = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.Selector = new BudgetExecution.Selector();
            this.Separator1 = new BudgetExecution.ToolSeparator();
            this.ToolStripTextBox = new BudgetExecution.ToolStripTextBox();
            this.Separator2 = new BudgetExecution.ToolSeparator();
            this.ToolStripLabel = new BudgetExecution.ToolStripLabel();
            this.Separator3 = new BudgetExecution.ToolSeparator();
            this.DropDown = new BudgetExecution.ToolStripDropDown();
            this.Separator4 = new BudgetExecution.ToolSeparator();
            this.Separator5 = new BudgetExecution.ToolSeparator();
            this.Separator6 = new BudgetExecution.ToolSeparator();
            this.Separator7 = new BudgetExecution.ToolSeparator();
            this.Separator8 = new BudgetExecution.ToolSeparator();
            this.FirstButton = new BudgetExecution.ToolStripButton();
            this.PreviousButton = new BudgetExecution.ToolStripButton();
            this.NextButton = new BudgetExecution.ToolStripButton();
            this.LastButton = new BudgetExecution.ToolStripButton();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Toolbar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Toolbar
            // 
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Toolbar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toolbar.ForeColor = System.Drawing.Color.Black;
            this.Toolbar.Image = null;
            this.Toolbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Separator1,
            this.ToolStripTextBox,
            this.Separator2,
            this.ToolStripLabel,
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
            this.Separator8});
            this.Toolbar.Location = new System.Drawing.Point(0, 667);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(1148, 46);
            this.Toolbar.TabIndex = 1;
            this.Toolbar.Text = "Selector";
            // 
            // Selector
            // 
            this.Selector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Selector.CanOverrideStyle = true;
            this.Selector.Font = new System.Drawing.Font("Roboto", 9F);
            this.Selector.ForeColor = System.Drawing.Color.White;
            this.Selector.FunctionalityPath = null;
            this.Selector.HighlightColor = System.Drawing.Color.SteelBlue;
            this.Selector.ImageshadeColor = System.Drawing.Color.Black;
            this.Selector.ImageSlides = true;
            this.Selector.Location = new System.Drawing.Point(56, 56);
            this.Selector.Name = "Selector";
            this.Selector.Padding = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.Selector.PadX = 0;
            this.Selector.PadY = 0;
            this.Selector.Perspective = 4F;
            this.Selector.ProviderPath = null;
            this.Selector.RotateAlways = false;
            this.Selector.ShowImagePreview = true;
            this.Selector.ShowImageShadow = true;
            this.Selector.Size = new System.Drawing.Size(1038, 537);
            this.Selector.TabIndex = 0;
            this.Selector.Text = "selector1";
            this.Selector.ThemeName = "Metro";
            this.Selector.ThemeStyle.BackColor = System.Drawing.Color.Transparent;
            this.Selector.ThemeStyle.Font = new System.Drawing.Font("Roboto", 9F);
            this.Selector.ThemeStyle.ForeColor = System.Drawing.Color.White;
            this.Selector.ThemeStyle.HoverImageBorderColor = System.Drawing.Color.SteelBlue;
            this.Selector.ThemeStyle.HoverImageBorderThickness = 2;
            this.Selector.ThemeStyle.ImageShadeColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Selector.TouchTransitionSpeed = 1F;
            this.Selector.UseOriginalImageinPreview = true;
            this.Selector.VisualStyle = Syncfusion.Windows.Forms.Tools.CarouselVisualStyle.Metro;
            // 
            // Separator1
            // 
            this.Separator1.ForeColor = System.Drawing.Color.Black;
            this.Separator1.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator1.Name = "Separator1";
            this.Separator1.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator1.Size = new System.Drawing.Size(6, 32);
            // 
            // ToolStripTextBox
            // 
            this.ToolStripTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.ToolStripTextBox.Bar = BudgetExecution.ToolType.NS;
            this.ToolStripTextBox.BindingSource = null;
            this.ToolStripTextBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.ToolStripTextBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.ToolStripTextBox.HoverText = "";
            this.ToolStripTextBox.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripTextBox.Name = "ToolStripTextBox";
            this.ToolStripTextBox.Size = new System.Drawing.Size(150, 22);
            this.ToolStripTextBox.Tag = "";
            this.ToolStripTextBox.ToolTip = null;
            // 
            // Separator2
            // 
            this.Separator2.ForeColor = System.Drawing.Color.Black;
            this.Separator2.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator2.Name = "Separator2";
            this.Separator2.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator2.Size = new System.Drawing.Size(6, 32);
            // 
            // ToolStripLabel
            // 
            this.ToolStripLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.ToolStripLabel.Bar = BudgetExecution.ToolType.NS;
            this.ToolStripLabel.BindingSource = null;
            this.ToolStripLabel.DataFilter = null;
            this.ToolStripLabel.Field = BudgetExecution.Field.RpioActivityCode;
            this.ToolStripLabel.Font = new System.Drawing.Font("Roboto", 9F);
            this.ToolStripLabel.ForeColor = System.Drawing.Color.Black;
            this.ToolStripLabel.HoverText = null;
            this.ToolStripLabel.Margin = new System.Windows.Forms.Padding(5);
            this.ToolStripLabel.Name = "ToolStripLabel";
            this.ToolStripLabel.Size = new System.Drawing.Size(104, 22);
            this.ToolStripLabel.Tag = "";
            this.ToolStripLabel.Text = "Chart Information";
            this.ToolStripLabel.ToolTip = null;
            // 
            // Separator3
            // 
            this.Separator3.ForeColor = System.Drawing.Color.Black;
            this.Separator3.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator3.Name = "Separator3";
            this.Separator3.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator3.Size = new System.Drawing.Size(6, 32);
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
            this.DropDown.Size = new System.Drawing.Size(175, 22);
            this.DropDown.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            this.DropDown.Tag = "Make Selection";
            this.DropDown.ToolTipText = "Make Selection";
            // 
            // Separator4
            // 
            this.Separator4.ForeColor = System.Drawing.Color.Black;
            this.Separator4.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator4.Name = "Separator4";
            this.Separator4.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator4.Size = new System.Drawing.Size(6, 32);
            // 
            // Separator5
            // 
            this.Separator5.ForeColor = System.Drawing.Color.Black;
            this.Separator5.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator5.Name = "Separator5";
            this.Separator5.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator5.Size = new System.Drawing.Size(6, 32);
            // 
            // Separator6
            // 
            this.Separator6.ForeColor = System.Drawing.Color.Black;
            this.Separator6.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator6.Name = "Separator6";
            this.Separator6.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator6.Size = new System.Drawing.Size(6, 32);
            // 
            // Separator7
            // 
            this.Separator7.ForeColor = System.Drawing.Color.Black;
            this.Separator7.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator7.Name = "Separator7";
            this.Separator7.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator7.Size = new System.Drawing.Size(6, 32);
            // 
            // Separator8
            // 
            this.Separator8.ForeColor = System.Drawing.Color.Black;
            this.Separator8.Margin = new System.Windows.Forms.Padding(1, 0, 1, 0);
            this.Separator8.Name = "Separator8";
            this.Separator8.Padding = new System.Windows.Forms.Padding(1, 5, 1, 5);
            this.Separator8.Size = new System.Drawing.Size(6, 32);
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
            this.FirstButton.Size = new System.Drawing.Size(23, 22);
            this.FirstButton.Text = "toolStripButton1";
            this.FirstButton.ToolTip = null;
            this.FirstButton.ToolType = BudgetExecution.ToolType.NS;
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
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Margin = new System.Windows.Forms.Padding(5);
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Resource = null;
            this.PreviousButton.Size = new System.Drawing.Size(23, 22);
            this.PreviousButton.Text = "toolStripButton2";
            this.PreviousButton.ToolTip = null;
            this.PreviousButton.ToolType = BudgetExecution.ToolType.NS;
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
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Margin = new System.Windows.Forms.Padding(5);
            this.NextButton.Name = "NextButton";
            this.NextButton.Resource = null;
            this.NextButton.Size = new System.Drawing.Size(23, 22);
            this.NextButton.Text = "toolStripButton3";
            this.NextButton.ToolTip = null;
            this.NextButton.ToolType = BudgetExecution.ToolType.NS;
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
            this.LastButton.Image = ((System.Drawing.Image)(resources.GetObject("LastButton.Image")));
            this.LastButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.LastButton.Margin = new System.Windows.Forms.Padding(5);
            this.LastButton.Name = "LastButton";
            this.LastButton.Resource = null;
            this.LastButton.Size = new System.Drawing.Size(23, 22);
            this.LastButton.Text = "toolStripButton4";
            this.LastButton.ToolTip = null;
            this.LastButton.ToolType = BudgetExecution.ToolType.NS;
            // 
            // CarouselForm
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
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.Selector);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Name = "CarouselForm";
            this.ShowIcon = false;
            this.Toolbar.ResumeLayout(false);
            this.Toolbar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Selector Selector;
        public System.Windows.Forms.BindingSource BindingSource;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx Toolbar;
        private ToolSeparator Separator1;
        private ToolStripTextBox ToolStripTextBox;
        private ToolSeparator Separator2;
        public ToolStripLabel ToolStripLabel;
        private ToolSeparator Separator3;
        public ToolStripDropDown DropDown;
        private ToolSeparator Separator4;
        private ToolStripButton FirstButton;
        private ToolSeparator Separator5;
        private ToolStripButton PreviousButton;
        private ToolSeparator Separator6;
        private ToolStripButton NextButton;
        private ToolSeparator Separator7;
        private ToolStripButton LastButton;
        private ToolSeparator Separator8;
    }
}