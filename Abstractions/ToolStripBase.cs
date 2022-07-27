// <copyright file = "ToolBarBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ToolStripBase : ToolStripEx
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual System.Windows.Forms.BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the separator.
        /// </summary>
        /// <value>
        /// The separator.
        /// </value>
        public virtual IEnumerable<ToolSeparator> Separators { get; set; }

        /// <summary>
        /// Gets or sets the separator.
        /// </summary>
        /// <value>
        /// The separator.
        /// </value>
        public virtual ToolSeparator Separator1 { get; set; }

        /// <summary>
        /// Gets or sets the separator2.
        /// </summary>
        /// <value>
        /// The separator2.
        /// </value>
        public virtual ToolSeparator Separator2 { get; set; }

        /// <summary>
        /// Gets or sets the separator3.
        /// </summary>
        /// <value>
        /// The separator3.
        /// </value>
        public virtual ToolSeparator Separator3 { get; set; }

        /// <summary>
        /// Gets or sets the separator4.
        /// </summary>
        /// <value>
        /// The separator4.
        /// </value>
        public virtual ToolSeparator Separator4 { get; set; }

        /// <summary>
        /// Gets or sets the separator5.
        /// </summary>
        /// <value>
        /// The separator5.
        /// </value>
        public virtual ToolSeparator Separator5 { get; set; }

        /// <summary>
        /// Gets or sets the separator6.
        /// </summary>
        /// <value>
        /// The separator6.
        /// </value>
        public virtual ToolSeparator Separator6 { get; set; }

        /// <summary>
        /// Gets or sets the separator7.
        /// </summary>
        /// <value>
        /// The separator7.
        /// </value>
        public virtual ToolSeparator Separator7 { get; set; }

        /// <summary>
        /// Gets or sets the separator8.
        /// </summary>
        /// <value>
        /// The separator8.
        /// </value>
        public virtual ToolSeparator Separator8 { get; set; }

        /// <summary>
        /// Gets or sets the separator9.
        /// </summary>
        /// <value>
        /// The separator9.
        /// </value>
        public virtual ToolSeparator Separator9 { get; set; }

        /// <summary>
        /// Gets or sets the separator10.
        /// </summary>
        /// <value>
        /// The separator10.
        /// </value>
        public virtual ToolSeparator Separator10 { get; set; }

        /// <summary>
        /// Gets or sets the separator11.
        /// </summary>
        /// <value>
        /// The separator11.
        /// </value>
        public virtual ToolSeparator Separator11 { get; set; }

        /// <summary>
        /// Gets or sets the separator12.
        /// </summary>
        /// <value>
        /// The separator12.
        /// </value>
        public virtual ToolSeparator Separator12 { get; set; }

        /// <summary>
        /// Gets or sets the separator13.
        /// </summary>
        /// <value>
        /// The separator13.
        /// </value>
        public virtual ToolSeparator Separator13 { get; set; }

        /// <summary>
        /// Gets or sets the separator14.
        /// </summary>
        /// <value>
        /// The separator14.
        /// </value>
        public virtual ToolSeparator Separator14 { get; set; }

        /// <summary>
        /// Gets or sets the separator15.
        /// </summary>
        /// <value>
        /// The separator15.
        /// </value>
        public virtual ToolSeparator Separator15 { get; set; }

        /// <summary>
        /// Gets or sets the separator16.
        /// </summary>
        /// <value>
        /// The separator16.
        /// </value>
        public virtual ToolSeparator Separator16 { get; set; }

        /// <summary>
        /// Gets or sets the tool strip ComboBox.
        /// </summary>
        /// <value>
        /// The tool strip ComboBox.
        /// </value>
        public virtual ToolStripDropDown DropDown { get; set; }

        /// <summary>
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public virtual ToolStripLabel Label { get; set; }

        /// <summary>
        /// Gets or sets the tool strip text box.
        /// </summary>
        /// <value>
        /// The tool strip text box.
        /// </value>
        public virtual ToolStripTextBox TextBox { get; set; }

        /// <summary>
        /// Gets or sets the first button.
        /// </summary>
        /// <value>
        /// The first button.
        /// </value>
        public virtual ToolStripButton FirstButton { get; set; }

        /// <summary>
        /// Gets or sets the previous button.
        /// </summary>
        /// <value>
        /// The previous button.
        /// </value>
        public virtual ToolStripButton PreviousButton { get; set; }

        /// <summary>
        /// Gets or sets the next button.
        /// </summary>
        /// <value>
        /// The next button.
        /// </value>
        public virtual ToolStripButton NextButton { get; set; }

        /// <summary>
        /// Gets or sets the last button.
        /// </summary>
        /// <value>
        /// The last button.
        /// </value>
        public virtual ToolStripButton LastButton { get; set; }

        /// <summary>
        /// Gets or sets the edit button.
        /// </summary>
        /// <value>
        /// The edit button.
        /// </value>
        public virtual ToolStripButton EditButton { get; set; }

        /// <summary>
        /// Gets or sets the add button.
        /// </summary>
        /// <value>
        /// The add button.
        /// </value>
        public virtual ToolStripButton AddButton { get; set; }

        /// <summary>
        /// Gets or sets the delete button.
        /// </summary>
        /// <value>
        /// The delete button.
        /// </value>
        public virtual ToolStripButton DeleteButton { get; set; }

        /// <summary>
        /// Gets or sets the refresh button.
        /// </summary>
        /// <value>
        /// The refresh button.
        /// </value>
        public virtual ToolStripButton RefreshButton { get; set; }

        /// <summary>
        /// Gets or sets the save button.
        /// </summary>
        /// <value>
        /// The save button.
        /// </value>
        public virtual ToolStripButton SaveButton { get; set; }

        /// <summary>
        /// Gets or sets the browse button.
        /// </summary>
        /// <value>
        /// The browse button.
        /// </value>
        public virtual ToolStripButton BrowseButton { get; set; }

        /// <summary>
        /// Gets or sets the print button.
        /// </summary>
        /// <value>
        /// The print button.
        /// </value>
        public virtual ToolStripButton PrintButton { get; set; }

        /// <summary>
        /// Gets or sets the excel button.
        /// </summary>
        /// <value>
        /// The excel button.
        /// </value>
        public virtual ToolStripButton ExcelButton { get; set; }

        /// <summary>
        /// Gets or sets the calculator button.
        /// </summary>
        /// <value>
        /// The calculator button.
        /// </value>
        public virtual ToolStripButton CalculatorButton { get; set; }

        /// <summary>
        /// Gets or sets the progress bar.
        /// </summary>
        /// <value>
        /// The progress bar.
        /// </value>
        public virtual ToolStripProgressBar ProgressBar { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolStripBase"/> class.
        /// </summary>
        protected ToolStripBase( )
        {
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void OnLoad( object sender, EventArgs e )
        {
            if ( sender is ToolStrip  )
            {
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}