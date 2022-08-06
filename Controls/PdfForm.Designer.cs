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
            Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings messageBoxSettings1 = new Syncfusion.Windows.Forms.PdfViewer.MessageBoxSettings();
            Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings pdfViewerPrinterSettings1 = new Syncfusion.Windows.PdfViewer.PdfViewerPrinterSettings();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfForm));
            Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings textSearchSettings1 = new Syncfusion.Windows.Forms.PdfViewer.TextSearchSettings();
            this.pdfViewerControl1 = new Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl();
            this.BindingSource = new BudgetExecution.SourceBinding();
            this.ToolTip = new BudgetExecution.ToolTip();
            this.ToolStrip = new BudgetExecution.ToolStrip();
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
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).BeginInit();
            this.ToolStrip.SuspendLayout();
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
            messageBoxSettings1.EnableNotification = true;
            this.pdfViewerControl1.MessageBoxSettings = messageBoxSettings1;
            this.pdfViewerControl1.MinimumZoomPercentage = 50;
            this.pdfViewerControl1.Name = "pdfViewerControl1";
            this.pdfViewerControl1.PageBorderThickness = 1;
            pdfViewerPrinterSettings1.PageOrientation = Syncfusion.Windows.PdfViewer.PdfViewerPrintOrientation.Auto;
            pdfViewerPrinterSettings1.PageSize = Syncfusion.Windows.PdfViewer.PdfViewerPrintSize.ActualSize;
            pdfViewerPrinterSettings1.PrintLocation = ((System.Drawing.PointF)(resources.GetObject("pdfViewerPrinterSettings1.PrintLocation")));
            pdfViewerPrinterSettings1.ShowPrintStatusDialog = true;
            this.pdfViewerControl1.PrinterSettings = pdfViewerPrinterSettings1;
            this.pdfViewerControl1.ReferencePath = null;
            this.pdfViewerControl1.ScrollDisplacementValue = 0;
            this.pdfViewerControl1.ShowHorizontalScrollBar = true;
            this.pdfViewerControl1.ShowToolBar = true;
            this.pdfViewerControl1.ShowVerticalScrollBar = true;
            this.pdfViewerControl1.Size = new System.Drawing.Size(1188, 661);
            this.pdfViewerControl1.SpaceBetweenPages = 8;
            this.pdfViewerControl1.TabIndex = 0;
            this.pdfViewerControl1.Text = "DocumentViewer";
            textSearchSettings1.CurrentInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(255)))), ((int)(((byte)(171)))), ((int)(((byte)(64)))));
            textSearchSettings1.HighlightAllInstance = true;
            textSearchSettings1.OtherInstanceColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(254)))), ((int)(((byte)(255)))), ((int)(((byte)(0)))));
            this.pdfViewerControl1.TextSearchSettings = textSearchSettings1;
            this.pdfViewerControl1.ThemeName = "Default";
            this.pdfViewerControl1.UseWaitCursor = true;
            this.pdfViewerControl1.VerticalScrollOffset = 0;
            this.pdfViewerControl1.VisualStyle = Syncfusion.Windows.Forms.PdfViewer.VisualStyle.Default;
            this.pdfViewerControl1.ZoomMode = Syncfusion.Windows.Forms.PdfViewer.ZoomMode.Default;
            // 
            // BindingSource
            // 
            this.BindingSource.DataFilter = null;
            this.BindingSource.DataSet = null;
            this.BindingSource.DataTable = null;
            this.BindingSource.Field = BudgetExecution.Field.RpioActivityCode;
            this.BindingSource.Index = 0;
            this.BindingSource.Numeric = BudgetExecution.Numeric.NS;
            this.BindingSource.Record = null;
            this.BindingSource.Source = BudgetExecution.Source.NS;
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
            // DropDown
            // 
            this.DropDown.AllowDrop = true;
            this.DropDown.BindingSource = this.BindingSource;
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
            this.DropDown.Size = new System.Drawing.Size(172, 24);
            this.DropDown.Style = Syncfusion.Windows.Forms.Tools.ToolStripExStyle.Office2016Black;
            this.DropDown.Tag = "Make Selection";
            this.DropDown.ToolTip = this.ToolTip;
            this.DropDown.ToolTipText = "Make Selection";
            // 
            // TextBox
            // 
            this.TextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(18)))), ((int)(((byte)(18)))), ((int)(((byte)(18)))));
            this.TextBox.BindingSource = null;
            this.TextBox.Field = BudgetExecution.Field.RpioActivityCode;
            this.TextBox.Font = new System.Drawing.Font("Roboto", 9F);
            this.TextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(139)))), ((int)(((byte)(138)))));
            this.TextBox.HoverText = "";
            this.TextBox.Margin = new System.Windows.Forms.Padding(5);
            this.TextBox.Name = "TextBox";
            this.TextBox.Size = new System.Drawing.Size(150, 24);
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
            this.Label.BindingSource = this.BindingSource;
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
            this.Label.ToolTip = this.ToolTip;
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
            this.PreviousButton.BindingSource = this.BindingSource;
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
            this.PreviousButton.Size = new System.Drawing.Size(24, 24);
            this.PreviousButton.Text = "toolStripButton2";
            this.PreviousButton.ToolTip = this.ToolTip;
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
            this.NextButton.BindingSource = this.BindingSource;
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
            this.NextButton.Size = new System.Drawing.Size(24, 24);
            this.NextButton.Text = "toolStripButton3";
            this.NextButton.ToolTip = this.ToolTip;
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
            this.LastButton.BindingSource = this.BindingSource;
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
            this.LastButton.Size = new System.Drawing.Size(24, 24);
            this.LastButton.Text = "toolStripButton4";
            this.LastButton.ToolTip = this.ToolTip;
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
            this.RefreshButton.BindingSource = this.BindingSource;
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
            this.RefreshButton.Size = new System.Drawing.Size(24, 24);
            this.RefreshButton.Text = "toolStripButton7";
            this.RefreshButton.ToolTip = this.ToolTip;
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
            this.SaveButton.BindingSource = this.BindingSource;
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
            this.SaveButton.Size = new System.Drawing.Size(24, 24);
            this.SaveButton.Text = "toolStripButton8";
            this.SaveButton.ToolTip = this.ToolTip;
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
            this.ChartButton.BindingSource = this.BindingSource;
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
            this.ChartButton.Size = new System.Drawing.Size(24, 24);
            this.ChartButton.Text = "toolStripButton11";
            this.ChartButton.ToolTip = this.ToolTip;
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
            this.HomeButton.BindingSource = this.BindingSource;
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
            this.HomeButton.Size = new System.Drawing.Size(24, 24);
            this.HomeButton.Text = "toolStripButton12";
            this.HomeButton.ToolTip = this.ToolTip;
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
            // PdfForm
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
            this.Controls.Add(this.pdfViewerControl1);
            this.Controls.Add(this.ToolStrip);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.MinimizeBox = false;
            this.Name = "PdfForm";
            this.ShowIcon = false;
            this.ShowMaximizeBox = false;
            this.ShowMinimizeBox = false;
            this.ShowMouseOver = true;
            this.UseWaitCursor = true;
            ((System.ComponentModel.ISupportInitialize)(this.BindingSource)).EndInit();
            this.ToolStrip.ResumeLayout(false);
            this.ToolStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.PdfViewer.PdfViewerControl pdfViewerControl1;
        private SourceBinding BindingSource;
        private ToolTip ToolTip;
        public ToolStrip ToolStrip;
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
    }
}