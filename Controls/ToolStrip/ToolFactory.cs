namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Drawing;

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
        public static NameValueCollection ImageDirectory { get; } = ConfigurationManager.AppSettings;

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ToolFactory"/> class.
        /// </summary>
        public ToolFactory()
        {
        }

        public static ToolSeparator CreateSeparator()
        {
            try
            {
                var _separator = new ToolSeparator( );
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
        public static ToolbarButton CreateFirstButton()
        {
            try
            {
                var _filename = ImageDirectory + "FirstButton.png";
                var _firstButton = new ToolbarButton( );
                _firstButton.Image = Image.FromFile( _filename );
                _firstButton.HoverText = "First Record";
                return _firstButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the previous record button.
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton CreatePreviousButton()
        {
            try
            {
                var _filename = ImageDirectory + "PreviousButton.png";
                var _previousButton = new ToolbarButton( );
                _previousButton.Image = Image.FromFile( _filename );
                _previousButton.HoverText = "Previous Record";
                return _previousButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the next record button.
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton CreateNextButton()
        {
            try
            {
                var _filename = ImageDirectory + "NextButton.png";
                var _nextButton = new ToolbarButton( );
                _nextButton.Image = Image.FromFile( _filename );
                _nextButton.HoverText = "Next Record";
                return _nextButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the last record button.
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton CreateLastButton()
        {
            try
            {
                var _filename = ImageDirectory + "LastButton.png";
                var _lastButton = new ToolbarButton( );
                _lastButton.Image = Image.FromFile( _filename );
                _lastButton.HoverText = "Last Record";
                return _lastButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the edit record button.
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton CreateEditButton()
        {
            try
            {
                var _filename = ImageDirectory + "EditButton.png";
                var _editButton = new ToolbarButton( );
                _editButton.Image = Image.FromFile( _filename );
                _editButton.HoverText = "Edit Record";
                return _editButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the add record button.
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton CreateAddButton()
        {
            try
            {
                var _filename = ImageDirectory + "AddButton.png";
                var _addButton = new ToolbarButton( );
                _addButton.Image = Image.FromFile( _filename );
                _addButton.HoverText = "Add Record";
                return _addButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the delete record button.
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton CreateDeleteButton()
        {
            try
            {
                var _filename = ImageDirectory + "DeleteButton.png";
                var _deleteButton = new ToolbarButton( );
                _deleteButton.Image = Image.FromFile( _filename );
                _deleteButton.HoverText = "Delete Record";
                return _deleteButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the refresh data button.
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton CreateRefreshButton()
        {
            try
            {
                var _filename = ImageDirectory + "RefreshButton.png";
                var _refreshButton = new ToolbarButton( );
                _refreshButton.Image = Image.FromFile( _filename );
                _refreshButton.HoverText = "Refresh Data";
                return _refreshButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the save changes button.
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton CreateSaveButton()
        {
            try
            {
                var _filename = ImageDirectory + "SaveButton.png";
                var _saveButton = new ToolbarButton( );
                _saveButton.Image = Image.FromFile( _filename );
                _saveButton.HoverText = "Save Changes";
                return _saveButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the print data button.
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton CreatePrintButton()
        {
            try
            {
                var _filename = ImageDirectory + "PrintButton.png";
                var _printButton = new ToolbarButton( );
                _printButton.Image = Image.FromFile( _filename );
                _printButton.HoverText = "Print Data";
                return _printButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the excel export button.
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton CreateExcelButton()
        {
            try
            {
                var _filename = ImageDirectory + "ExcelButton.png";
                var _excelButton = new ToolbarButton( );
                _excelButton.Image = Image.FromFile( _filename );
                _excelButton.HoverText = "Export to Excel";
                return _excelButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the calculator button.
        /// </summary>
        /// <returns></returns>
        public static ToolbarButton CreateCalculatorButton()
        {
            try
            {
                var _filename = ImageDirectory + "CalculatorButton.png";
                var _calculatorButton = new ToolbarButton( );
                _calculatorButton.Image = Image.FromFile( _filename );
                _calculatorButton.HoverText = "Launch Calculator";
                return _calculatorButton;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolbarButton );
            }
        }

        /// <summary>
        /// Creates the label.
        /// </summary>
        /// <returns>
        /// </returns>
        public static ToolStripLabel CreateLabel()
        {
            try
            {
                var _label = new ToolStripLabel( );
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
        public static ToolStripComboBox CreateComboBox()
        {
            try
            {
                var _comboBox = new ToolStripComboBox( );
                return _comboBox;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ToolStripComboBox );
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public static ToolStripProgressBar CreateProgressBar()
        {
            try
            {
                var _progress = new ToolStripProgressBar( );
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
        public static ToolStripTextBox CreateTextBox()
        {
            try
            {
                var _textBox = new ToolStripTextBox( );
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
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}
