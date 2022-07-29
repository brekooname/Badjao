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
        /// Gets or sets the calculator button.
        /// </summary>
        /// <value>
        /// The calculator button.
        /// </value>
        public virtual ToolStripButton HomeButton { get; set; }

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
            Items.Clear( );
            Label = new ToolStripLabel(  );
            Items.Add( Label );
            Items.Add( new ToolSeparator( ) );
            TextBox = new ToolStripTextBox( );
            Items.Add( TextBox );
            Items.Add( new ToolSeparator( ) );
            DropDown = new ToolStripDropDown( );
            Items.Add( DropDown );
            Items.Add( new ToolSeparator( ) );
            FirstButton = new ToolStripButton( ToolType.FirstButton );
            FirstButton.SetImage( );
            Items.Add( FirstButton );
            Items.Add( new ToolSeparator( ) );
            PreviousButton = new ToolStripButton( ToolType.PreviousButton );
            PreviousButton.SetImage( );
            Items.Add( PreviousButton );
            Items.Add( new ToolSeparator( ) );
            NextButton = new ToolStripButton( ToolType.NextButton );
            NextButton.SetImage( );
            Items.Add( NextButton );
            Items.Add( new ToolSeparator( ) );
            LastButton = new ToolStripButton( ToolType.LastButton );
            LastButton.SetImage( );
            Items.Add( LastButton );
            Items.Add( new ToolSeparator( ) );
            EditButton = new ToolStripButton( ToolType.EditButton );
            EditButton.SetImage( );
            Items.Add( EditButton );
            Items.Add( new ToolSeparator( ) );
            AddButton = new ToolStripButton( ToolType.AddButton );
            AddButton.SetImage( );
            Items.Add( AddButton );
            Items.Add( new ToolSeparator( ) );
            DeleteButton = new ToolStripButton( ToolType.DeleteButton );
            DeleteButton.SetImage( );
            Items.Add( DeleteButton );
            Items.Add( new ToolSeparator( ) );
            SaveButton = new ToolStripButton( ToolType.SaveButton );
            SaveButton.SetImage( );
            Items.Add( SaveButton );
            Items.Add( new ToolSeparator( ) );
            RefreshButton = new ToolStripButton( ToolType.RefreshButton );
            RefreshButton.SetImage( );
            Items.Add( RefreshButton );
            Items.Add( new ToolSeparator( ) );
            BrowseButton = new ToolStripButton( ToolType.BrowseButton );
            BrowseButton.SetImage( );
            Items.Add( BrowseButton );
            Items.Add( new ToolSeparator( ) );
            PrintButton = new ToolStripButton( ToolType.PrintButton );
            PrintButton.SetImage( );
            Items.Add( PrintButton );
            Items.Add( new ToolSeparator( ) );
            ExcelButton = new ToolStripButton( ToolType.ExcelButton );
            ExcelButton.SetImage( );
            Items.Add( ExcelButton );
            Items.Add( new ToolSeparator( ) );
            CalculatorButton = new ToolStripButton( ToolType.CalculatorButton );
            CalculatorButton.SetImage( );
            Items.Add( CalculatorButton );
            Items.Add( new ToolSeparator( ) );
            HomeButton = new ToolStripButton( ToolType.HomeButton );
            HomeButton.SetImage( );
            Items.Add( HomeButton );
            Items.Add( new ToolSeparator( ) );
            ProgressBar = new ToolStripProgressBar( );
            Items.Add( ProgressBar );
            Items.Add( new ToolSeparator( ) );
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