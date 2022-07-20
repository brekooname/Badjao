// <copyright file = "DataView.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using Syncfusion.Windows.Forms;

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
            Font = new Font( "Roboto Condensed", 9, FontStyle.Regular );
            GridOfficeScrollBars = OfficeScrollBars.Office2016;
            Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.Black;
            ColorStyles = ColorStyles.Office2016Black;
            ThemeStyle.CellStyle.Font = new Font( "Roboto Condensed", 9, FontStyle.Regular );
            ThemeStyle.CellStyle.BackColor = Color.FromArgb( 40, 40, 40 );
            ThemeStyle.CellStyle.TextColor = Color.FromArgb( 240, 240, 240 );
            ThemeStyle.CheckBoxStyle.BackColor = Color.FromArgb( 40, 40, 40 );
            ThemeStyle.CheckBoxStyle.TickColor = Color.Lime;
        }
    }
}
