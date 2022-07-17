// <copyright file = "ToolBarBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ToolStripBase : ToolStripEx
    {
        /// <summary>
        /// Gets or sets the setting.
        /// </summary>
        /// <value>
        /// The setting.
        /// </value>
        public virtual NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;
        
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the separator.
        /// </summary>
        /// <value>
        /// The separator.
        /// </value>
        public virtual IEnumerable<ToolSeparator> Separator { get; set; }

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
        /// Gets or sets the tool strip ComboBox.
        /// </summary>
        /// <value>
        /// The tool strip ComboBox.
        /// </value>
        public virtual ToolStripComboBox ToolStripComboBox { get; set; }

        /// <summary>
        /// Gets or sets the tool strip text box.
        /// </summary>
        /// <value>
        /// The tool strip text box.
        /// </value>
        public virtual ToolStripTextBox ToolStripTextBox { get; set; }

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
        /// Populates the tools.
        /// </summary>
        public virtual  void PopulateTools( )
        {
            try
            {
                var _firstRecord = Setting[ "ToolStripImages" ] + @"\FirstButton.png";
                var _previousRecord = Setting[ "ToolStripImages" ] + @"\PreviousButton.png";
                var _nextRecord = Setting[ "ToolStripImages" ] + @"\NextButton.png";
                var _lastRecord = Setting[ "ToolStripImages" ] + @"\LastButton.png";
                var _edit = Setting[ "ToolStripImages" ] + @"\EditButton.png";
                var _add = Setting[ "ToolStripImages" ] + @"\AddButton.png";
                var _delete = Setting[ "ToolStripImages" ] + @"\DeleteButton.png";
                var _refresh = Setting[ "ToolStripImages" ] + @"\RefreshButton.png";
                var _save = Setting[ "ToolStripImages" ] + @"\SaveButton.png";
                var _browse = Setting[ "ToolStripImages" ] + @"\BrowseButton.png";
                var _print = Setting[ "ToolStripImages" ] + @"\PrintButton.png";
                var _excelFile = Setting[ "ToolStripImages" ] + @"\ExcelButton.png";
                var _calculator = Setting[ "ToolStripImages" ] + @"\CalculatorButton.png";
                Items.Add( new ToolSeparator( ) );
                Items.Add( new ToolStripTextBox( ) );
                Items.Add( new ToolSeparator( ) );
                Items.Add( new ToolStripComboBox( ) );
                Items.Add( new ToolSeparator( ) );

                // First Button
                FirstButton = new ToolStripButton
                {
                    ToolType = ToolType.FirstButton,
                    Image = Image.FromFile( _firstRecord ),
                    BindingSource = BindingSource,
                    HoverText = "Go To Beginning"
                };

                Items.Add( FirstButton );
                Items.Add( new ToolSeparator( ) );

                // Previous Button
                PreviousButton = new ToolStripButton
                {
                    ToolType = ToolType.PreviousButton,
                    Image = Image.FromFile( _previousRecord ),
                    BindingSource = BindingSource,
                    HoverText = "Go To Previous"
                };

                Items.Add( PreviousButton );
                Items.Add( new ToolSeparator( ) );

                // Next Button
                NextButton = new ToolStripButton
                {
                    ToolType = ToolType.NextButton,
                    Image = Image.FromFile( _nextRecord ),
                    BindingSource = BindingSource,
                    HoverText = "Go To Next Record"
                };

                Items.Add( NextButton );
                Items.Add( new ToolSeparator( ) );

                // Last button
                LastButton = new ToolStripButton
                {
                    ToolType = ToolType.LastButton,
                    Image = Image.FromFile( _lastRecord ),
                    BindingSource = BindingSource,
                    HoverText = "Go To Last Record"
                };

                Items.Add( LastButton );
                Items.Add( new ToolSeparator( ) );

                // Edit Button
                EditButton = new ToolStripButton
                {
                    ToolType = ToolType.EditButton,
                    Image = Image.FromFile( _edit ),
                    HoverText = "Edit Record"
                };

                Items.Add( EditButton );
                Items.Add( new ToolSeparator( ) );

                // Add Button
                AddButton = new ToolStripButton
                {
                    ToolType = ToolType.AddButton,
                    Image = Image.FromFile( _add ),
                    HoverText = "Add Record"
                };

                Items.Add( AddButton );
                Items.Add( new ToolSeparator( ) );

                // Delete Button
                DeleteButton = new ToolStripButton
                {
                    ToolType = ToolType.DeleteButton,
                    Image = Image.FromFile( _delete ),
                    HoverText = "Delete Record"
                };

                Items.Add( DeleteButton );
                Items.Add( new ToolSeparator( ) );

                // Refresh Button
                RefreshButton = new ToolStripButton
                {
                    ToolType = ToolType.RefreshButton,
                    Image = Image.FromFile( _refresh ),
                    HoverText = "Refresh Data"
                };

                Items.Add( RefreshButton );
                Items.Add( new ToolSeparator( ) );

                // Save Button
                SaveButton = new ToolStripButton
                {
                    ToolType = ToolType.SaveButton,
                    Image = Image.FromFile( _save ),
                    HoverText = "Save Changes"
                };

                Items.Add( SaveButton );
                Items.Add( new ToolSeparator( ) );

                // Browse Button
                BrowseButton = new ToolStripButton
                {
                    ToolType = ToolType.BrowseButton,
                    Image = Image.FromFile( _browse ),
                    HoverText = "Browse for file"
                };

                Items.Add( BrowseButton );
                Items.Add( new ToolSeparator( ) );

                // Print Button
                PrintButton = new ToolStripButton
                {
                    ToolType = ToolType.PrintButton,
                    Image = Image.FromFile( _print ),
                    HoverText = "Print Data"
                };

                Items.Add( PrintButton );
                Items.Add( new ToolSeparator( ) );

                // Excel Button
                ExcelButton = new ToolStripButton
                {
                    ToolType = ToolType.ExcelButton,
                    Image = Image.FromFile( _excelFile ),
                    HoverText = "Export to Excel"
                };

                Items.Add( ExcelButton );
                Items.Add( new ToolSeparator( ) );

                // Calculator Button
                CalculatorButton = new ToolStripButton
                {
                    ToolType = ToolType.CalculatorButton,
                    Image = Image.FromFile( _calculator ),
                    HoverText = "Launch Calculator"
                };

                Items.Add( CalculatorButton );
                Items.Add( new ToolSeparator( ) );

                // Progress Bar
                ProgressBar = new ToolStripProgressBar
                {
                    Visible = false
                };

                Items.Add( ProgressBar );
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