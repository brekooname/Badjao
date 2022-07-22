// <copyright file = "BudgetGridData.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Grid;

    [SuppressMessage( "ReSharper", "PublicConstructorInAbstractClass" )]
    public abstract class TableViewBase : GridDataBoundGrid
    {
        public TableViewBase( )
        {

            // Basic Properties
            ForeColor = Color.White;
            BackColor = ColorConfig.FormDarkBackColor;
            Font = new Font( "Roboto", 8, FontStyle.Bold );
            Margin = new Padding( 0 );
            Padding = new Padding( 0 );
            Size = SizeConfig.GetSize( 700, 400 );
            Location = ControlConfig.GetLocation( );
            Anchor = ControlConfig.GetAnchorStyle( );
            Dock = ControlConfig.GetDockStyle( );
            Font = FontConfig.FontSizeSmall;
            Visible = true;
            Enabled = true;

            // Model Properties
            Model.Rows.DefaultSize = 22;
            Model.ActiveGridView.PdfExport = true;
            Model.Properties.ThemedHeader = false;
            Model.Properties.GridLineColor = Color.FromArgb( 64, 64, 64 );

            // Style Properties
            ThemesEnabled = true;
            ApplyVisualStyles = true;
            EnableAddNew = true;
            EnableEdit = true;
            EnableRemove = true;
            AllowResizeToFit = true;
            ExcelLikeSelectionFrame = true;
            ExcelLikeAlignment = true;
            AlphaBlendSelectionColor = ColorConfig.BorderBlue;
            Properties.BackgroundColor = ColorConfig.FormDarkBackColor;
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
            TableStyle.Font.Facename = "consolas";
            TableStyle.Font.Size = 8;
        }
    }
}
