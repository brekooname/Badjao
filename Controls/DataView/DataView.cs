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
    using Syncfusion.Windows.Forms.Tools;

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
            // Control Properties
            ThemesEnabled = true;
            ApplyVisualStyles = true;
            TransparentBackground = true;
            EnableAddNew = true;
            EnableEdit = true;
            CanOverrideStyle = true;
            EnableRemove = true;
            AllowResizeToFit = true;
            ExcelLikeSelectionFrame = true;
            ExcelLikeAlignment = true;
            BackColor = SystemColors.GradientActiveCaption;
            ForeColor = Color.FromArgb( 64, 64, 64 );
            Font = new Font( "Roboto", 9, FontStyle.Regular );
            GridOfficeScrollBars = OfficeScrollBars.Office2016;
            Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.Colorful;
            ColorStyles = ColorStyles.SystemTheme;
            GridVisualStyles = GridVisualStyles.Custom;
            GridLineColor = SystemColors.ControlDark;
            HorizontalScrollTips = true;
            HorizontalThumbTrack = true;
            VerticalScrollTips = true;
            VerticalThumbTrack = true;
            DefaultGridBorderStyle = GridBorderStyle.Dotted;
            AlphaBlendSelectionColor = Color.FromArgb( 130, 1, 115, 199 );

            // ThemStyle Properties
            ThemeStyle.CellStyle.Font = new Font( "Roboto", 9, FontStyle.Regular );

            // Model Properties
            Model.Rows.DefaultSize = 22;
            Model.ActiveGridView.PdfExport = true;
            Model.Properties.ThemedHeader = false;

            // Style Properties
            Properties.ThemedHeader = true;
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
            TableStyle.BackColor = SystemColors.GradientActiveCaption;

            ThemeStyle.CellStyle.BackColor = SystemColors.GradientActiveCaption;
            ThemeStyle.CellStyle.TextColor = Color.LightSteelBlue;
            ThemeStyle.HeaderStyle.HoverTextColor = Color.White;
            ThemeStyle.HeaderStyle.HoverBackColor = Color.SteelBlue;
        }
    }
}
