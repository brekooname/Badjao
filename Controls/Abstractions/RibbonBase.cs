﻿// <copyright file = "RibbonBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Spreadsheet;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="SpreadsheetRibbon" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public class RibbonBase : SpreadsheetRibbon
    {
        /// <summary>
        /// Gets or sets the grid.
        /// </summary>
        /// <value>
        /// The grid.
        /// </value>
        public virtual SpreadsheetGrid Grid { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public virtual Spreadsheet ActiveSheet { get; set; }

        /// <summary>
        /// Gets or sets the model.
        /// </summary>
        /// <value>
        /// The model.
        /// </value>
        public virtual SpreadsheetGridModel Model { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="RibbonBase"/> class.
        /// </summary>
        public RibbonBase( )
        {
            EnableRibbonCustomization = true;
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Font = new Font( "Roboto", 9 );
            ForeColor = Color.Black;
            BackColor = Color.FromArgb( 15, 15, 15 );
            BorderStyle = ToolStripBorderStyle.None;
            RibbonStyle = RibbonStyle.Office2010;
            OfficeColorScheme = ToolStripEx.ColorScheme.Black;
            TitleFont = new Font( "Roboto", 9 );

            // Office Menu Properties
            OfficeMenu.BackColor = Color.FromArgb( 15, 15, 15 );
            OfficeMenu.Font = new Font( "Roboto", 9 );
            OfficeMenu.AutoSize = true;
            OfficeMenu.LayoutStyle = ToolStripLayoutStyle.Flow;
            ShowQuickItemsDropDownButton = false;
            Ribbon.ScaleMenuButtonImage = true;
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using( Error _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}