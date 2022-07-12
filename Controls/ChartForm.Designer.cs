namespace BudgetExecution
{
    partial class ChartForm
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
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries1 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo1 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            Syncfusion.Windows.Forms.Chart.ChartLineInfo chartLineInfo1 = new Syncfusion.Windows.Forms.Chart.ChartLineInfo();
            Syncfusion.Windows.Forms.Chart.ChartSeries chartSeries2 = new Syncfusion.Windows.Forms.Chart.ChartSeries();
            Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo chartCustomShapeInfo2 = new Syncfusion.Windows.Forms.Chart.ChartCustomShapeInfo();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ChartForm));
            this.Chart = new Syncfusion.Windows.Forms.Chart.ChartControl();
            this.BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.DataSet = new System.Data.DataSet();
            this.ToolBar = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.SpaceLabel = new System.Windows.Forms.ToolStripLabel();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.PreviousButton = new System.Windows.Forms.ToolStripButton();
            this.ComboBox = new Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx();
            this.NextButton = new System.Windows.Forms.ToolStripButton();
            this.Separator3 = new System.Windows.Forms.ToolStripSeparator();
            this.BrowseButton = new System.Windows.Forms.ToolStripButton();
            this.Separator4 = new System.Windows.Forms.ToolStripSeparator();
            this.DatabaseButton = new System.Windows.Forms.ToolStripButton();
            this.Separator5 = new System.Windows.Forms.ToolStripSeparator();
            this.ExcelButton = new System.Windows.Forms.ToolStripButton();
            this.Separator6 = new System.Windows.Forms.ToolStripSeparator();
            this.CaculatorButton = new System.Windows.Forms.ToolStripButton();
            this.Separator7 = new System.Windows.Forms.ToolStripSeparator();
            this.GoogleButton = new System.Windows.Forms.ToolStripButton();
            this.Separator8 = new System.Windows.Forms.ToolStripSeparator();
            this.CalendarButton = new System.Windows.Forms.ToolStripButton();
            this.Separator9 = new System.Windows.Forms.ToolStripSeparator();
            this.PdfButton = new System.Windows.Forms.ToolStripButton();
            this.Separator10 = new System.Windows.Forms.ToolStripSeparator();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).BeginInit();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Chart
            // 
            this.Chart.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.LightGray, System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))));
            this.Chart.ChartArea.BackInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.None, System.Drawing.Color.LightGray, System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))));
            this.Chart.ChartArea.BorderColor = System.Drawing.Color.Transparent;
            this.Chart.ChartArea.CursorLocation = new System.Drawing.Point(0, 0);
            this.Chart.ChartArea.CursorReDraw = false;
            this.Chart.ChartInterior = new Syncfusion.Drawing.BrushInfo(Syncfusion.Drawing.GradientStyle.PathRectangle, System.Drawing.Color.LightGray, System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15))))));
            this.Chart.CustomPalette = new System.Drawing.Color[] {
        System.Drawing.Color.SteelBlue,
        System.Drawing.Color.Red,
        System.Drawing.Color.Lime,
        System.Drawing.Color.Yellow,
        System.Drawing.Color.FromArgb(((int)(((byte)(140)))), ((int)(((byte)(90)))), ((int)(((byte)(36))))),
        System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(72)))), ((int)(((byte)(38)))))};
            this.Chart.DataSourceName = "[none]";
            this.Chart.Depth = 100F;
            this.Chart.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Chart.ForeColor = System.Drawing.Color.LightGray;
            this.Chart.HighlightSymbol = true;
            this.Chart.IsWindowLess = false;
            // 
            // 
            // 
            this.Chart.Legend.Location = new System.Drawing.Point(58, 81);
            this.Chart.Legend.Position = Syncfusion.Windows.Forms.Chart.ChartDock.Floating;
            this.Chart.Legend.Visible = false;
            this.Chart.Localize = null;
            this.Chart.Location = new System.Drawing.Point(61, 77);
            this.Chart.Name = "Chart";
            this.Chart.Palette = Syncfusion.Windows.Forms.Chart.ChartColorPalette.Custom;
            this.Chart.PrimaryXAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Chart.PrimaryXAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.Chart.PrimaryXAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Chart.PrimaryXAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart.PrimaryXAxis.Margin = true;
            this.Chart.PrimaryXAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Chart.PrimaryXAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.Chart.PrimaryXAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Chart.PrimaryXAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart.PrimaryYAxis.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Chart.PrimaryYAxis.GridLineType.ForeColor = System.Drawing.Color.LightGray;
            this.Chart.PrimaryYAxis.LineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Chart.PrimaryYAxis.LogLabelsDisplayMode = Syncfusion.Windows.Forms.Chart.LogLabelsDisplayMode.Default;
            this.Chart.PrimaryYAxis.Margin = true;
            this.Chart.PrimaryYAxis.MinorGridLineType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(225)))), ((int)(((byte)(225)))), ((int)(((byte)(225)))));
            this.Chart.PrimaryYAxis.TickColor = System.Drawing.Color.FromArgb(((int)(((byte)(171)))), ((int)(((byte)(171)))), ((int)(((byte)(171)))));
            this.Chart.PrimaryYAxis.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Chart.PrimaryYAxis.TitleFont = new System.Drawing.Font("Segoe UI", 14F);
            this.Chart.RealMode3D = true;
            this.Chart.Rotation = 5F;
            chartSeries1.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries1.Name = "Default0";
            chartSeries1.Resolution = 0D;
            chartSeries1.StackingGroup = "Default Group";
            chartSeries1.Style.AltTagFormat = "";
            chartSeries1.Style.Border.Color = System.Drawing.Color.Transparent;
            chartSeries1.Style.DrawTextShape = false;
            chartSeries1.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            chartLineInfo1.Alignment = System.Drawing.Drawing2D.PenAlignment.Center;
            chartLineInfo1.Color = System.Drawing.SystemColors.ControlText;
            chartLineInfo1.DashPattern = null;
            chartLineInfo1.DashStyle = System.Drawing.Drawing2D.DashStyle.Solid;
            chartLineInfo1.Width = 1F;
            chartCustomShapeInfo1.Border = chartLineInfo1;
            chartCustomShapeInfo1.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo1.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries1.Style.TextShape = chartCustomShapeInfo1;
            chartSeries1.Text = "Default0";
            chartSeries2.FancyToolTip.ResizeInsideSymbol = true;
            chartSeries2.Name = "Default1";
            chartSeries2.Resolution = 0D;
            chartSeries2.StackingGroup = "Default Group";
            chartSeries2.Style.AltTagFormat = "";
            chartSeries2.Style.Border.Color = System.Drawing.Color.Transparent;
            chartSeries2.Style.DrawTextShape = false;
            chartSeries2.Style.TextColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            chartCustomShapeInfo2.Border = chartLineInfo1;
            chartCustomShapeInfo2.Color = System.Drawing.SystemColors.HighlightText;
            chartCustomShapeInfo2.Type = Syncfusion.Windows.Forms.Chart.ChartCustomShape.Square;
            chartSeries2.Style.TextShape = chartCustomShapeInfo2;
            chartSeries2.Text = "Default1";
            this.Chart.Series.Add(chartSeries1);
            this.Chart.Series.Add(chartSeries2);
            this.Chart.Series3D = true;
            this.Chart.SeriesHighlight = true;
            this.Chart.Size = new System.Drawing.Size(1052, 552);
            this.Chart.Spacing = 10F;
            this.Chart.Style3D = true;
            this.Chart.TabIndex = 0;
            this.Chart.Tilt = 15F;
            // 
            // 
            // 
            this.Chart.Title.Font = new System.Drawing.Font("Segoe UI", 16F);
            this.Chart.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.Chart.Title.Name = "Default";
            this.Chart.VisualTheme = "";
            // 
            // DataSet
            // 
            this.DataSet.DataSetName = "ChartData";
            // 
            // ToolBar
            // 
            this.ToolBar.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.ToolBar.CanOverrideStyle = true;
            this.ToolBar.CaptionFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBar.CaptionTextStyle = Syncfusion.Windows.Forms.Tools.CaptionTextStyle.Plain;
            this.ToolBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ToolBar.Font = new System.Drawing.Font("Roboto", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ToolBar.ForeColor = System.Drawing.Color.Black;
            this.ToolBar.Image = null;
            this.ToolBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SpaceLabel,
            this.Separator1,
            this.TextBox,
            this.Separator2,
            this.PreviousButton,
            this.ComboBox,
            this.NextButton,
            this.Separator3,
            this.BrowseButton,
            this.Separator4,
            this.DatabaseButton,
            this.Separator5,
            this.ExcelButton,
            this.Separator6,
            this.CaculatorButton,
            this.Separator7,
            this.GoogleButton,
            this.Separator8,
            this.CalendarButton,
            this.Separator9,
            this.PdfButton,
            this.Separator10,
            this.HomeButton});
            this.ToolBar.Location = new System.Drawing.Point(0, 671);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.ToolBar.Size = new System.Drawing.Size(1188, 41);
            this.ToolBar.TabIndex = 2;
            this.ToolBar.Text = "Charts";
            this.ToolBar.ThemeName = "Default";
            // 
            // SpaceLabel
            // 
            this.SpaceLabel.Name = "SpaceLabel";
            this.SpaceLabel.Size = new System.Drawing.Size(70, 22);
            this.SpaceLabel.Text = "                     ";
            // 
            // Separator1
            // 
            this.Separator1.Name = "Separator1";
            this.Separator1.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Separator1.Size = new System.Drawing.Size(6, 25);
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.TextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TextBox.ForeColor = System.Drawing.Color.LightGray;
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(150, 25);
            // 
            // Separator2
            // 
            this.Separator2.Name = "Separator2";
            this.Separator2.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.Separator2.Size = new System.Drawing.Size(6, 25);
            // 
            // PreviousButton
            // 
            this.PreviousButton.Image = ((System.Drawing.Image)(resources.GetObject("PreviousButton.Image")));
            this.PreviousButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PreviousButton.Name = "PreviousButton";
            this.PreviousButton.Size = new System.Drawing.Size(70, 22);
            this.PreviousButton.Text = "Previous";
            this.PreviousButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ComboBox
            // 
            this.ComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComboBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.ComboBox.MaxLength = 32767;
            this.ComboBox.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.ComboBox.Name = "ComboBox";
            this.ComboBox.Padding = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.ComboBox.Size = new System.Drawing.Size(160, 25);
            // 
            // NextButton
            // 
            this.NextButton.Image = ((System.Drawing.Image)(resources.GetObject("NextButton.Image")));
            this.NextButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.NextButton.Name = "NextButton";
            this.NextButton.Size = new System.Drawing.Size(53, 22);
            this.NextButton.Text = "Next ";
            this.NextButton.ToolTipText = "Next Record";
            // 
            // Separator3
            // 
            this.Separator3.Name = "Separator3";
            this.Separator3.Size = new System.Drawing.Size(6, 25);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Image = ((System.Drawing.Image)(resources.GetObject("BrowseButton.Image")));
            this.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(70, 22);
            this.BrowseButton.Text = "  Browse";
            this.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator4
            // 
            this.Separator4.Name = "Separator4";
            this.Separator4.Size = new System.Drawing.Size(6, 25);
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.Image = ((System.Drawing.Image)(resources.GetObject("DatabaseButton.Image")));
            this.DatabaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Size = new System.Drawing.Size(56, 22);
            this.DatabaseButton.Text = "  Data";
            this.DatabaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator5
            // 
            this.Separator5.Name = "Separator5";
            this.Separator5.Size = new System.Drawing.Size(6, 25);
            // 
            // ExcelButton
            // 
            this.ExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.Image")));
            this.ExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(56, 22);
            this.ExcelButton.Text = " Excel";
            this.ExcelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator6
            // 
            this.Separator6.Name = "Separator6";
            this.Separator6.Size = new System.Drawing.Size(6, 25);
            // 
            // CaculatorButton
            // 
            this.CaculatorButton.Image = ((System.Drawing.Image)(resources.GetObject("CaculatorButton.Image")));
            this.CaculatorButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CaculatorButton.Name = "CaculatorButton";
            this.CaculatorButton.Size = new System.Drawing.Size(78, 22);
            this.CaculatorButton.Text = "Calculator";
            this.CaculatorButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator7
            // 
            this.Separator7.Name = "Separator7";
            this.Separator7.Size = new System.Drawing.Size(6, 25);
            // 
            // GoogleButton
            // 
            this.GoogleButton.Image = ((System.Drawing.Image)(resources.GetObject("GoogleButton.Image")));
            this.GoogleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoogleButton.Name = "GoogleButton";
            this.GoogleButton.Size = new System.Drawing.Size(68, 22);
            this.GoogleButton.Text = "  Search";
            this.GoogleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator8
            // 
            this.Separator8.Name = "Separator8";
            this.Separator8.Size = new System.Drawing.Size(6, 25);
            // 
            // CalendarButton
            // 
            this.CalendarButton.Image = ((System.Drawing.Image)(resources.GetObject("CalendarButton.Image")));
            this.CalendarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(77, 22);
            this.CalendarButton.Text = "  Calendar";
            this.CalendarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator9
            // 
            this.Separator9.Name = "Separator9";
            this.Separator9.Size = new System.Drawing.Size(6, 25);
            // 
            // PdfButton
            // 
            this.PdfButton.Image = ((System.Drawing.Image)(resources.GetObject("PdfButton.Image")));
            this.PdfButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.PdfButton.Name = "PdfButton";
            this.PdfButton.Size = new System.Drawing.Size(84, 22);
            this.PdfButton.Text = "Documents";
            this.PdfButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // Separator10
            // 
            this.Separator10.Name = "Separator10";
            this.Separator10.Size = new System.Drawing.Size(6, 25);
            // 
            // HomeButton
            // 
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(63, 22);
            this.HomeButton.Text = "  Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // ChartForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonColor = System.Drawing.Color.DimGray;
            this.CaptionButtonHoverColor = System.Drawing.Color.DimGray;
            this.CaptionFont = new System.Drawing.Font("Roboto Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1188, 712);
            this.Controls.Add(this.ToolBar);
            this.Controls.Add(this.Chart);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Name = "ChartForm";
            this.ShowIcon = false;
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataSet)).EndInit();
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Chart.ChartControl Chart;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx ToolBar;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        public System.Windows.Forms.ToolStripTextBox TextBox;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        public Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx ComboBox;
        private System.Windows.Forms.ToolStripSeparator Separator3;
        private System.Windows.Forms.ToolStripButton BrowseButton;
        private System.Windows.Forms.ToolStripSeparator Separator4;
        private System.Windows.Forms.ToolStripButton DatabaseButton;
        private System.Windows.Forms.ToolStripSeparator Separator5;
        private System.Windows.Forms.ToolStripButton ExcelButton;
        private System.Windows.Forms.ToolStripSeparator Separator6;
        private System.Windows.Forms.ToolStripButton CaculatorButton;
        private System.Windows.Forms.ToolStripSeparator Separator7;
        private System.Windows.Forms.ToolStripButton GoogleButton;
        private System.Windows.Forms.ToolStripSeparator Separator8;
        private System.Windows.Forms.ToolStripButton CalendarButton;
        private System.Windows.Forms.ToolStripSeparator Separator9;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.ToolStripSeparator Separator10;
        private System.Windows.Forms.ToolStripButton PdfButton;
        private System.Windows.Forms.ToolStripLabel SpaceLabel;
        private System.Windows.Forms.BindingSource BindingSource;
        private System.Windows.Forms.ToolStripButton PreviousButton;
        private System.Windows.Forms.ToolStripButton NextButton;
        private System.Data.DataSet DataSet;
    }
}