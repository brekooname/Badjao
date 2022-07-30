// <copyright file = "ToolBarBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
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
        /// Gets or sets the label.
        /// </summary>
        /// <value>
        /// The label.
        /// </value>
        public virtual ToolStripLabel Label { get; set; }

        /// <summary>
        /// Gets or sets the tool strip ComboBox.
        /// </summary>
        /// <value>
        /// The tool strip ComboBox.
        /// </value>
        public virtual ToolStripDropDown DropDown { get; set; }

        /// <summary>
        /// Gets or sets the tool strip text box.
        /// </summary>
        /// <value>
        /// The tool strip text box.
        /// </value>
        public virtual ToolStripTextBox TextBox { get; set; }
        
        /// <summary>
        /// Gets or sets the progress bar.
        /// </summary>
        /// <value>
        /// The progress bar.
        /// </value>
        public virtual ToolStripProgressBar ProgressBar { get; protected set; }

        /// <summary>
        /// Gets or sets the first button.
        /// </summary>
        /// <value>
        /// The first button.
        /// </value>
        public virtual ToolStripButton FirstButton { get; protected set; }

        /// <summary>
        /// Gets or sets the previous button.
        /// </summary>
        /// <value>
        /// The previous button.
        /// </value>
        public virtual ToolStripButton PreviousButton { get; protected set; }

        /// <summary>
        /// Gets or sets the next button.
        /// </summary>
        /// <value>
        /// The next button.
        /// </value>
        public virtual ToolStripButton NextButton { get; protected set; }

        /// <summary>
        /// Gets or sets the last button.
        /// </summary>
        /// <value>
        /// The last button.
        /// </value>
        public virtual ToolStripButton LastButton { get; protected set; }

        /// <summary>
        /// Gets or sets the edit button.
        /// </summary>
        /// <value>
        /// The edit button.
        /// </value>
        public virtual ToolStripButton EditButton { get; protected set; }

        /// <summary>
        /// Gets or sets the add button.
        /// </summary>
        /// <value>
        /// The add button.
        /// </value>
        public virtual ToolStripButton AddButton { get; protected set; }

        /// <summary>
        /// Gets or sets the delete button.
        /// </summary>
        /// <value>
        /// The delete button.
        /// </value>
        public virtual ToolStripButton DeleteButton { get; protected set; }

        /// <summary>
        /// Gets or sets the save button.
        /// </summary>
        /// <value>
        /// The save button.
        /// </value>
        public virtual ToolStripButton SaveButton { get; protected set; }

        /// <summary>
        /// Gets or sets the refresh button.
        /// </summary>
        /// <value>
        /// The refresh button.
        /// </value>
        public virtual ToolStripButton RefreshButton { get; protected set; }

        /// <summary>
        /// Gets or sets the excel button.
        /// </summary>
        /// <value>
        /// The excel button.
        /// </value>
        public virtual ToolStripButton ExcelButton { get; protected set; }

        /// <summary>
        /// Gets or sets the calculator button.
        /// </summary>
        /// <value>
        /// The calculator button.
        /// </value>
        public virtual ToolStripButton CalculatorButton { get; protected set; }

        /// <summary>
        /// Gets or sets the chart button.
        /// </summary>
        /// <value>
        /// The chart button.
        /// </value>
        public virtual ToolStripButton ChartButton { get; protected set; }

        /// <summary>
        /// Gets or sets the home button.
        /// </summary>
        /// <value>
        /// The home button.
        /// </value>
        public virtual ToolStripButton HomeButton { get; protected set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolStripBase"/> class.
        /// </summary>
        protected ToolStripBase( )
        {
            Label = new ToolStripLabel(  );
            TextBox = new ToolStripTextBox( );
            FirstButton = new ToolStripButton( ToolType.FirstButton );
            PreviousButton = new ToolStripButton( ToolType.PreviousButton );
            NextButton = new ToolStripButton( ToolType.NextButton );
            LastButton = new ToolStripButton( ToolType.LastButton );
            EditButton = new ToolStripButton( ToolType.EditButton );
            AddButton = new ToolStripButton( ToolType.AddButton );
            DeleteButton = new ToolStripButton( ToolType.DeleteButton );
            SaveButton = new ToolStripButton( ToolType.SaveButton );
            RefreshButton = new ToolStripButton( ToolType.RefreshButton );
            ExcelButton = new ToolStripButton( ToolType.ExcelButton );
            CalculatorButton = new ToolStripButton( ToolType.CalculatorButton );
            ChartButton = new ToolStripButton( ToolType.ChartButton );
            HomeButton = new ToolStripButton( ToolType.HomeButton );
        }

        
        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual void AddTextBox( )
        {
            try
            {
                var _textBox = new ToolStripTextBox( );
                Items?.Add( _textBox );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public virtual void AddComboBox()
        {
            try
            {
                var _comboBox = new ToolStripComboBoxEx( );
                Items?.Add( _comboBox );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public virtual void AddDropDownItem( object item )
        {
            try
            {
                DropDown?.ComboBox?.Items.Add( item );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public virtual void ResetDropDownList( IEnumerable<object> items )
        {
            try
            {
                DropDown?.ComboBox.Items?.Clear( );
                if( items?.Count( ) > 0 )
                {
                    foreach( var item in items )
                    {
                        DropDown?.ComboBox?.Items?.Add( item );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual void AddSeparator()
        {
            try
            {
                var _separator = new ToolSeparator( );
                Items?.Add( _separator );
            }
            catch( Exception ex )
            {
                Fail( ex );
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