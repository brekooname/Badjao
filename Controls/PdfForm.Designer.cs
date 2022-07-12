namespace BudgetExecution
{
    partial class PdfForm
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
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings2 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings2 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfForm));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings2 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.pdfViewerControl1 = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            this.ToolBar = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            this.Separator1 = new System.Windows.Forms.ToolStripSeparator();
            this.TextBox = new System.Windows.Forms.ToolStripTextBox();
            this.Separator2 = new System.Windows.Forms.ToolStripSeparator();
            this.ComboBoxLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.ComboBox = new Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.BrowseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.DatabaseButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.ExcelButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.CaculatorButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.GoogleButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.CalendarButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.ChartButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
            this.HomeButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
            this.ToolBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // pdfViewerControl1
            // 
            this.pdfViewerControl1.CursorMode = Syncfusion.Windows.Forms.PdfViewer.PdfViewerCursorMode.SelectTool;
            this.pdfViewerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pdfViewerControl1.EnableContextMenu = true;
            this.pdfViewerControl1.EnableNotificationBar = true;
            this.pdfViewerControl1.HorizontalScrollOffset = 0;
            this.pdfViewerControl1.IsBookmarkEnabled = true;
            this.pdfViewerControl1.IsTextSearchEnabled = true;
            this.pdfViewerControl1.IsTextSelectionEnabled = true;
            this.pdfViewerControl1.Location = new System.Drawing.Point(0, 0);
            messageBoxSettings2.EnableNotification = true;
            this.pdfViewerControl1.MessageBoxSettings = messageBoxSettings2;
            this.pdfViewerControl1.MinimumZoomPercentage = 50;
            this.pdfViewerControl1.Name = "pdfViewerControl1";
            this.pdfViewerControl1.PageBorderThickness = 1;
            pdfViewerPrinterSettings2.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings2.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings2.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings2.PrintLocation")));
            pdfViewerPrinterSettings2.ShowPrintStatusDialog = true;
            this.pdfViewerControl1.PrinterSettings = pdfViewerPrinterSettings2;
            this.pdfViewerControl1.ReferencePath = null;
            this.pdfViewerControl1.ScrollDisplacementValue = 0;
            this.pdfViewerControl1.ShowHorizontalScrollBar = true;
            this.pdfViewerControl1.ShowToolBar = true;
            this.pdfViewerControl1.ShowVerticalScrollBar = true;
            this.pdfViewerControl1.Size = new System.Drawing.Size(1188, 672);
            this.pdfViewerControl1.SpaceBetweenPages = 8;
            this.pdfViewerControl1.TabIndex = 0;
            this.pdfViewerControl1.Text = "DocumentViewer";
            textSearchSettings2.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings2.HighlightAllInstance = true;
            textSearchSettings2.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pdfViewerControl1.TextSearchSettings = textSearchSettings2;
            this.pdfViewerControl1.ThemeName = "Default";
            this.pdfViewerControl1.UseWaitCursor = true;
            this.pdfViewerControl1.VerticalScrollOffset = 0;
            this.pdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            this.pdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
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
            this.Separator1,
            this.TextBox,
            this.Separator2,
            this.ComboBoxLabel,
            this.toolStripSeparator4,
            this.ComboBox,
            this.toolStripSeparator1,
            this.BrowseButton,
            this.toolStripSeparator2,
            this.DatabaseButton,
            this.toolStripSeparator3,
            this.ExcelButton,
            this.toolStripSeparator5,
            this.CaculatorButton,
            this.toolStripSeparator6,
            this.GoogleButton,
            this.toolStripSeparator7,
            this.CalendarButton,
            this.toolStripSeparator8,
            this.ChartButton,
            this.toolStripSeparator9,
            this.HomeButton,
            this.toolStripSeparator10});
            this.ToolBar.Location = new System.Drawing.Point(0, 672);
            this.ToolBar.Name = "ToolBar";
            this.ToolBar.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.ToolBar.Size = new System.Drawing.Size(1188, 41);
            this.ToolBar.TabIndex = 3;
            this.ToolBar.Text = "Data";
            this.ToolBar.ThemeName = "Default";
            this.ToolBar.UseWaitCursor = true;
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
            // ComboBoxLabel
            // 
            this.ComboBoxLabel.Name = "ComboBoxLabel";
            this.ComboBoxLabel.Size = new System.Drawing.Size(67, 22);
            this.ComboBoxLabel.Text = "                    ";
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 25);
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
            this.ComboBox.Size = new System.Drawing.Size(102, 25);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // BrowseButton
            // 
            this.BrowseButton.Image = ((System.Drawing.Image)(resources.GetObject("BrowseButton.Image")));
            this.BrowseButton.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BrowseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BrowseButton.Name = "BrowseButton";
            this.BrowseButton.Size = new System.Drawing.Size(64, 22);
            this.BrowseButton.Text = "Browse";
            this.BrowseButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BrowseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // DatabaseButton
            // 
            this.DatabaseButton.Image = ((System.Drawing.Image)(resources.GetObject("DatabaseButton.Image")));
            this.DatabaseButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.DatabaseButton.Name = "DatabaseButton";
            this.DatabaseButton.Size = new System.Drawing.Size(50, 22);
            this.DatabaseButton.Text = "Data";
            this.DatabaseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // ExcelButton
            // 
            this.ExcelButton.Image = ((System.Drawing.Image)(resources.GetObject("ExcelButton.Image")));
            this.ExcelButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ExcelButton.Name = "ExcelButton";
            this.ExcelButton.Size = new System.Drawing.Size(66, 22);
            this.ExcelButton.Text = "Reports";
            this.ExcelButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 25);
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
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(6, 25);
            // 
            // GoogleButton
            // 
            this.GoogleButton.Image = ((System.Drawing.Image)(resources.GetObject("GoogleButton.Image")));
            this.GoogleButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GoogleButton.Name = "GoogleButton";
            this.GoogleButton.Size = new System.Drawing.Size(62, 22);
            this.GoogleButton.Text = "Search";
            this.GoogleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(6, 25);
            // 
            // CalendarButton
            // 
            this.CalendarButton.Image = ((System.Drawing.Image)(resources.GetObject("CalendarButton.Image")));
            this.CalendarButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.CalendarButton.Name = "CalendarButton";
            this.CalendarButton.Size = new System.Drawing.Size(71, 22);
            this.CalendarButton.Text = "Calendar";
            this.CalendarButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(6, 25);
            // 
            // ChartButton
            // 
            this.ChartButton.Image = ((System.Drawing.Image)(resources.GetObject("ChartButton.Image")));
            this.ChartButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ChartButton.Name = "ChartButton";
            this.ChartButton.Size = new System.Drawing.Size(60, 22);
            this.ChartButton.Text = "Charts";
            this.ChartButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator9
            // 
            this.toolStripSeparator9.Name = "toolStripSeparator9";
            this.toolStripSeparator9.Size = new System.Drawing.Size(6, 25);
            // 
            // HomeButton
            // 
            this.HomeButton.Image = ((System.Drawing.Image)(resources.GetObject("HomeButton.Image")));
            this.HomeButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.HomeButton.Name = "HomeButton";
            this.HomeButton.Size = new System.Drawing.Size(57, 22);
            this.HomeButton.Text = "Home";
            this.HomeButton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            // 
            // toolStripSeparator10
            // 
            this.toolStripSeparator10.Name = "toolStripSeparator10";
            this.toolStripSeparator10.Size = new System.Drawing.Size(6, 25);
            // 
            // PdfForm
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
            this.ClientSize = new System.Drawing.Size(1188, 713);
            this.Controls.Add(this.pdfViewerControl1);
            this.Controls.Add(this.ToolBar);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Name = "PdfForm";
            this.ShowIcon = false;
            this.UseWaitCursor = true;
            this.ToolBar.ResumeLayout(false);
            this.ToolBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl pdfViewerControl1;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx ToolBar;
        private System.Windows.Forms.ToolStripSeparator Separator1;
        public System.Windows.Forms.ToolStripTextBox TextBox;
        private System.Windows.Forms.ToolStripSeparator Separator2;
        public System.Windows.Forms.ToolStripLabel ComboBoxLabel;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        public Syncfusion.Windows.Forms.Tools.ToolStripComboBoxEx ComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton BrowseButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton DatabaseButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton ExcelButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripButton CaculatorButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripButton GoogleButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripButton CalendarButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripButton ChartButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator9;
        private System.Windows.Forms.ToolStripButton HomeButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator10;
    }
}