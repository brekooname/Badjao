// <copyright file = "DataView.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DataViewBase" />
    public class DataView : DataViewBase
    {
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="DataView"/> class.
        /// </summary>
        public DataView()
        {
            BackColor = Color.FromArgb( 40, 40, 40 );
            ForeColor = Color.FromArgb( 240, 240, 240 );
            Font = new Font( "Roboto", 9, FontStyle.Regular );
            GridOfficeScrollBars = OfficeScrollBars.Office2016;
            Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.Black;
            ColorStyles = ColorStyles.Office2016Black;
            ThemeStyle.CellStyle.Font = new Font( "Roboto", 9, FontStyle.Regular );
            ThemeStyle.CellStyle.BackColor = Color.FromArgb( 40, 40, 40 );
            ThemeStyle.CellStyle.TextColor = Color.FromArgb( 240, 240, 240 );
            ThemeStyle.CheckBoxStyle.BackColor = Color.FromArgb( 40, 40, 40 );
            ThemeStyle.CheckBoxStyle.TickColor = Color.Lime;

            // Model Properties
            Model.Rows.DefaultSize = 22;
            Model.ActiveGridView.PdfExport = true;
            Model.Properties.ThemedHeader = false;
            Model.Properties.GridLineColor = Color.FromArgb( 64, 64, 64 );

            // Style Properties
            ThemesEnabled = true;
            ApplyVisualStyles = true;
            GridVisualStyles = GridVisualStyles.Office2010Black;
            EnableAddNew = true;
            EnableEdit = true;
            EnableRemove = true;
            AllowResizeToFit = true;
            ExcelLikeSelectionFrame = true;
            ExcelLikeAlignment = true;
            AlphaBlendSelectionColor = Color.SteelBlue;
            Properties.BackgroundColor = Color.FromArgb( 40, 40, 40 );
            Properties.CenterHorizontal = true;
            Properties.CenterVertical = true;
            Properties.ColHeaders = true;
            Properties.RowHeaders = true;
            Properties.Buttons3D = true;

            // Table Style Properties
            TableStyle.Themed = true;
            TableStyle.WrapText = false;
            TableStyle.HorizontalAlignment = GridHorizontalAlignment.Center;
            TableStyle.AutoFit = AutoFitOptions.Both;
            TableStyle.Font.Facename = "Roboto";
            TableStyle.Font.Size = 9;
        }
    }
}
