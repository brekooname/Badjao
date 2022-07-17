﻿// <copyright file = "DataView.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using Syncfusion.WinForms.DataGrid.Enums;
    using Syncfusion.WinForms.GridCommon;

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
            BackColor = Color.FromArgb( 18, 18, 18 );
            ShowBusyIndicator = true;
            ShowErrorIcon = true;
            ShowGroupDropArea = true;
            ShowHeaderToolTip = true;
            ShowRowHeader = true;
            ShowPreviewRow = true;
            ShowToolTip = true;
            AllowDraggingColumns = true;
            AllowDeleting = true;
            AllowFiltering = true;
            AllowGrouping = true;
            FilterPopupMode = FilterPopupMode.AdvancedFilter;
            EditMode = EditMode.DoubleClick;
            CopyOption = CopyOptions.IncludeHeaders;
        }
    }
}
