// <copyright file = "ToolFactory.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Drawing;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    public class ToolFactory
    {
        /// <summary>
        /// Gets or sets the image directory.
        /// </summary>
        /// <value>
        /// The image directory.
        /// </value>
        public static string ImageDirectory { get; } =
            ConfigurationManager.AppSettings[ "ToolStrip" ];

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ToolFactory"/> class.
        /// </summary>
        public ToolFactory( )
        {
        }

        public static ToolSeparator CreateSeparator( )
        {
            try
            {
                ToolSeparator _separator = new ToolSeparator( );
                return _separator;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolSeparator );
            }
        }

        /// <summary>
        /// Creates the first record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateFirstButton( )
        {
            try
            {
                string _filename = ImageDirectory + "FirstButton.png";

                ToolStripButton _firstButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "First Record",
                    ToolType = ToolType.FirstButton
                };

                return _firstButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the previous record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreatePreviousButton( )
        {
            try
            {
                string _filename = ImageDirectory + "PreviousButton.png";

                ToolStripButton _previousButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Previous Record",
                    ToolType = ToolType.PreviousButton
                };

                return _previousButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the next record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateNextButton( )
        {
            try
            {
                string _filename = ImageDirectory + "NextButton.png";

                ToolStripButton _nextButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Next Record",
                    ToolType = ToolType.NextButton
                };

                return _nextButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the last record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateLastButton( )
        {
            try
            {
                string _filename = ImageDirectory + "LastButton.png";

                ToolStripButton _lastButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Last Record",
                    ToolType = ToolType.LastButton
                };

                return _lastButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the edit record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateEditButton( )
        {
            try
            {
                string _filename = ImageDirectory + "EditButton.png";

                ToolStripButton _editButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Edit Record",
                    ToolType = ToolType.EditButton
                };

                return _editButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the add record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateAddButton( )
        {
            try
            {
                string _filename = ImageDirectory + "AddButton.png";

                ToolStripButton _addButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Add Record",
                    ToolType = ToolType.AddButton
                };

                return _addButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the delete record button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateDeleteButton( )
        {
            try
            {
                string _filename = ImageDirectory + "DeleteButton.png";

                ToolStripButton _deleteButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Delete Record",
                    ToolType = ToolType.DeleteButton
                };

                return _deleteButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the refresh data button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateRefreshButton( )
        {
            try
            {
                string _filename = ImageDirectory + "RefreshButton.png";

                ToolStripButton _refreshButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Refresh Data",
                    ToolType = ToolType.RefreshButton
                };

                return _refreshButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the save changes button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateSaveButton( )
        {
            try
            {
                string _filename = ImageDirectory + "SaveButton.png";

                ToolStripButton _saveButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Save Changes",
                    ToolType = ToolType.SaveButton
                };

                return _saveButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the print data button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreatePrintButton( )
        {
            try
            {
                string _filename = ImageDirectory + "PrintButton.png";

                ToolStripButton _printButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Print Data",
                    ToolType = ToolType.PrintButton
                };

                return _printButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the excel export button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateExcelButton( )
        {
            try
            {
                string _filename = ImageDirectory + "ExcelButton.png";

                ToolStripButton _excelButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Export to Excel",
                    ToolType = ToolType.ExcelButton
                };

                return _excelButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the calculator button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateCalculatorButton( )
        {
            try
            {
                string _filename = ImageDirectory + "CalculatorButton.png";

                ToolStripButton _calculatorButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Launch Calculator",
                    ToolType = ToolType.CalculatorButton
                };

                return _calculatorButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the print data button.
        /// </summary>
        /// <returns></returns>
        public static ToolStripButton CreateHomeButton( )
        {
            try
            {
                string _filename = ImageDirectory + "HomeButton.png";

                ToolStripButton _homeButton = new ToolStripButton
                {
                    Image = Image.FromFile( _filename ), HoverText = "Main Menu",
                    ToolType = ToolType.HomeButton
                };

                return _homeButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }
        }

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <returns>
        /// </returns>
        public static ToolStripLabel CreateLabel( )
        {
            try
            {
                ToolStripLabel _label = new ToolStripLabel( );
                return _label;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripLabel );
            }
        }

        /// <summary>
        /// Creates the ComboBox.
        /// </summary>
        /// <returns>
        /// </returns>
        public static ToolStripComboBoxEx CreateComboBox( )
        {
            try
            {
                ToolStripComboBoxEx _comboBox = new ToolStripComboBoxEx( );
                return _comboBox;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripComboBoxEx );
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public static ToolStripProgressBar CreateProgressBar( )
        {
            try
            {
                ToolStripProgressBar _progress = new ToolStripProgressBar( );
                return _progress;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripProgressBar );
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public static ToolStripTextBox CreateTextBox( )
        {
            try
            {
                ToolStripTextBox _textBox = new ToolStripTextBox( );
                return _textBox;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripTextBox );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using( Error _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}