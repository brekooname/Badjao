namespace BudgetExecution
{
    partial class ExcelForm
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
            Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste spreadsheetCopyPaste1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetCopyPaste();
            Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController formulaRangeSelectionController1 = new Syncfusion.Windows.Forms.Spreadsheet.FormulaRangeSelectionController();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExcelForm));
            this.Ribbon = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon();
            this.spreadsheet1 = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            this.Toolbar = new Syncfusion.Windows.Forms.Tools.ToolStripEx();
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).BeginInit();
            this.Ribbon.SuspendLayout();
            this.SuspendLayout();
            // 
            // Ribbon
            // 
            this.Ribbon.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ribbon.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.Ribbon.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.Ribbon.HideMenuButtonToolTip = true;
            this.Ribbon.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.Ribbon.Location = new System.Drawing.Point(0, 0);
            this.Ribbon.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Ribbon.MenuButtonText = "FILE";
            this.Ribbon.MenuButtonWidth = 56;
            this.Ribbon.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.Ribbon.Name = "Ribbon";
            this.Ribbon.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;
            this.Ribbon.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.Black;
            this.Ribbon.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            // 
            // Ribbon.OfficeMenu
            // 
            this.Ribbon.OfficeMenu.Name = "OfficeMenu";
            this.Ribbon.OfficeMenu.ShowItemToolTips = true;
            this.Ribbon.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.Ribbon.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.Ribbon.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.Ribbon.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2010;
            this.Ribbon.ShowQuickItemsDropDownButton = false;
            this.Ribbon.ShowRibbonDisplayOptionButton = false;
            this.Ribbon.Size = new System.Drawing.Size(1148, 155);
            this.Ribbon.Spreadsheet = null;
            this.Ribbon.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.Ribbon.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.Ribbon.TabIndex = 0;
            this.Ribbon.Text = "spreadsheetRibbon1";
            this.Ribbon.ThemeName = "Default";
            this.Ribbon.TitleColor = System.Drawing.Color.White;
            this.Ribbon.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // spreadsheet1
            // 
            this.spreadsheet1.AllowCellContextMenu = true;
            this.spreadsheet1.AllowExtendRowColumnCount = true;
            this.spreadsheet1.AllowFiltering = false;
            this.spreadsheet1.AllowFormulaRangeSelection = true;
            this.spreadsheet1.AllowTabItemContextMenu = true;
            this.spreadsheet1.AllowZooming = true;
            this.spreadsheet1.BaseThemeName = "";
            spreadsheetCopyPaste1.AllowPasteOptionPopup = true;
            spreadsheetCopyPaste1.DefaultPasteOption = Syncfusion.Windows.Forms.Spreadsheet.PasteOptions.Paste;
            this.spreadsheet1.CopyPaste = spreadsheetCopyPaste1;
            this.spreadsheet1.DefaultColumnCount = 101;
            this.spreadsheet1.DefaultRowCount = 101;
            this.spreadsheet1.DisplayAlerts = true;
            this.spreadsheet1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spreadsheet1.FileName = "Book3";
            this.spreadsheet1.FormulaBarVisibility = true;
            formulaRangeSelectionController1.AllowMouseSelection = true;
            formulaRangeSelectionController1.AllowSelectionOnEditing = true;
            this.spreadsheet1.FormulaRangeSelectionController = formulaRangeSelectionController1;
            this.spreadsheet1.IsCustomTabItemContextMenuEnabled = false;
            this.spreadsheet1.Location = new System.Drawing.Point(0, 155);
            this.spreadsheet1.Name = "spreadsheet1";
            this.spreadsheet1.SelectedTabIndex = 0;
            this.spreadsheet1.SelectedTabItem = null;
            this.spreadsheet1.ShowBusyIndicator = true;
            this.spreadsheet1.Size = new System.Drawing.Size(1148, 517);
            this.spreadsheet1.TabIndex = 1;
            this.spreadsheet1.TabItemContextMenu = null;
            this.spreadsheet1.Text = "Spreadsheet";
            this.spreadsheet1.ThemeName = "Default";
            // 
            // Toolbar
            // 
            this.Toolbar.BorderStyle = Syncfusion.Windows.Forms.Tools.ToolStripBorderStyle.StaticEdge;
            this.Toolbar.CanOverrideStyle = true;
            this.Toolbar.CaptionFont = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Toolbar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Toolbar.ForeColor = System.Drawing.Color.Black;
            this.Toolbar.Image = null;
            this.Toolbar.Location = new System.Drawing.Point(0, 672);
            this.Toolbar.Name = "Toolbar";
            this.Toolbar.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Black;
            this.Toolbar.Size = new System.Drawing.Size(1148, 41);
            this.Toolbar.TabIndex = 2;
            this.Toolbar.Text = "Excel";
            // 
            // ExcelForm
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
            this.Controls.Add(this.spreadsheet1);
            this.Controls.Add(this.Toolbar);
            this.Controls.Add(this.Ribbon);
            this.Font = new System.Drawing.Font("Roboto", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Name = "ExcelForm";
            this.ShowIcon = false;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.Ribbon)).EndInit();
            this.Ribbon.ResumeLayout(false);
            this.Ribbon.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon Ribbon;
        private Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet spreadsheet1;
        public Syncfusion.Windows.Forms.Tools.ToolStripEx Toolbar;
    }
}