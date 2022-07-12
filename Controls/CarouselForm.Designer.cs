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
            this.Selector = new BudgetExecution.Selector();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Toolbar = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // Selector
            // 
            this.Selector.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.Selector.CanOverrideStyle = true;
            this.Selector.Font = new System.Drawing.Font("Roboto", 9F);
            this.Selector.ForeColor = System.Drawing.Color.White;
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
            // Toolbar
            // 
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Toolbar.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toolbar.ForeColor = System.Drawing.Color.Black;
            this.Toolbar.Image = null;
            this.Toolbar.Location = new System.Drawing.Point(0, 674);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.Size = new System.Drawing.Size(1148, 39);
            this.Toolbar.TabIndex = 1;
            this.Toolbar.Text = "Selector";
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
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public Selector Selector;
        public System.Windows.Forms.BindingSource BindingSource;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx Toolbar;
    }
}