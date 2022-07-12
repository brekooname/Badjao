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
            this.spreadsheetRibbon1 = new Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon();
            this.spreadsheet1 = new Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet();
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetRibbon1)).BeginInit();
            this.SuspendLayout();
            // 
            // spreadsheetRibbon1
            // 
            this.spreadsheetRibbon1.CaptionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spreadsheetRibbon1.Dock = Syncfusion.Windows.Forms.Tools.DockStyleEx.Top;
            this.spreadsheetRibbon1.Font = new System.Drawing.Font("Segoe UI", 8.25F);
            this.spreadsheetRibbon1.HideMenuButtonToolTip = true;
            this.spreadsheetRibbon1.LauncherStyle = Syncfusion.Windows.Forms.Tools.LauncherStyle.Metro;
            this.spreadsheetRibbon1.Location = new System.Drawing.Point(0, 0);
            this.spreadsheetRibbon1.MenuButtonFont = new System.Drawing.Font("Microsoft Sans Serif", 8.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spreadsheetRibbon1.MenuButtonText = "FILE";
            this.spreadsheetRibbon1.MenuButtonWidth = 60;
            this.spreadsheetRibbon1.MenuColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(54)))), ((int)(((byte)(54)))));
            this.spreadsheetRibbon1.Name = "spreadsheetRibbon1";
            this.spreadsheetRibbon1.Office2013ColorScheme = Syncfusion.Windows.Forms.Tools.Office2013ColorScheme.DarkGray;
            this.spreadsheetRibbon1.Office2016ColorScheme = Syncfusion.Windows.Forms.Tools.Office2016ColorScheme.Black;
            this.spreadsheetRibbon1.OfficeColorScheme = Syncfusion.Windows.Forms.Tools.ToolStripEx.ColorScheme.Managed;
            // 
            // spreadsheetRibbon1.OfficeMenu
            // 
            this.spreadsheetRibbon1.OfficeMenu.Name = "OfficeMenu";
            this.spreadsheetRibbon1.OfficeMenu.ShowItemToolTips = true;
            this.spreadsheetRibbon1.OfficeMenu.Size = new System.Drawing.Size(12, 65);
            this.spreadsheetRibbon1.QuickPanelImageLayout = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.spreadsheetRibbon1.RibbonHeaderImage = Syncfusion.Windows.Forms.Tools.RibbonHeaderImage.None;
            this.spreadsheetRibbon1.RibbonStyle = Syncfusion.Windows.Forms.Tools.RibbonStyle.Office2016;
            this.spreadsheetRibbon1.ShowQuickItemsDropDownButton = false;
            this.spreadsheetRibbon1.ShowRibbonDisplayOptionButton = false;
            this.spreadsheetRibbon1.Size = new System.Drawing.Size(1156, 155);
            this.spreadsheetRibbon1.Spreadsheet = null;
            this.spreadsheetRibbon1.SystemText.QuickAccessDialogDropDownName = "Start menu";
            this.spreadsheetRibbon1.SystemText.RenameDisplayLabelText = "&Display Name:";
            this.spreadsheetRibbon1.TabIndex = 0;
            this.spreadsheetRibbon1.Text = "spreadsheetRibbon1";
            this.spreadsheetRibbon1.ThemeName = "Default";
            this.spreadsheetRibbon1.TitleColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(57)))), ((int)(((byte)(91)))));
            this.spreadsheetRibbon1.TitleFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.spreadsheet1.FileName = "Book1";
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
            this.spreadsheet1.Size = new System.Drawing.Size(1156, 610);
            this.spreadsheet1.TabIndex = 1;
            this.spreadsheet1.TabItemContextMenu = null;
            this.spreadsheet1.Text = "Spreadsheet";
            this.spreadsheet1.ThemeName = "Default";
            // 
            // ExcelForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.BorderColor = System.Drawing.Color.SteelBlue;
            this.CaptionBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.CaptionButtonColor = System.Drawing.Color.DimGray;
            this.CaptionButtonHoverColor = System.Drawing.Color.DimGray;
            this.CaptionFont = new System.Drawing.Font("Roboto Condensed", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CaptionForeColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(1156, 765);
            this.Controls.Add(this.spreadsheet1);
            this.Controls.Add(this.spreadsheetRibbon1);
            this.Font = new System.Drawing.Font("Roboto Condensed", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.LightGray;
            this.MetroColor = System.Drawing.Color.FromArgb(((int)(((byte)(15)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.Name = "ExcelForm";
            this.ShowIcon = false;
            this.Text = " ";
            ((System.ComponentModel.ISupportInitialize)(this.spreadsheetRibbon1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Spreadsheet.SpreadsheetRibbon spreadsheetRibbon1;
        private Syncfusion.Windows.Forms.Spreadsheet.Spreadsheet spreadsheet1;
    }
}