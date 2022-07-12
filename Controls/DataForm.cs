
namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    ///   <br />
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public partial class DataForm : MetroForm
    {
        public DataForm()
        {
            InitializeComponent( );
            Load += OnLoad;
            HomeButton.Click += OnHomeMenuButtonClicked;
            ChartButton.Click += OnChartButtonClicked;
            BrowseButton.Click += OnBrowseButtonClicked;
            ExcelButton.Click += OnExcelButtonClicked;
            CalendarButton.Click += OnCalendarButtonClicked;
            CalculatorButton.Click += OnCalculatorButtonClicked;
        }


        /// <summary>Gets the table list.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public IEnumerable<string> GetTableList( )
        {
            try
            {
                var Tables = new List<string>( );
                var sources = Enum.GetNames( typeof( Source ) );

                foreach( var item in sources )
                {
                    Tables.Add( item );
                }

                return Tables.Count > 0
                    ? Tables
                    : default( List<string> );
            }
            catch ( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<string> );
            }
        }


        /// <summary>
        /// Populates the toolbar ComboBox.
        /// </summary>
        public void PopulateToolbarComboBox( )
        {
            try
            {
                var _comboBox = ToolBar.Items[ "ComboBox" ] as ToolStripComboBoxEx;
                var _tables = GetTableList(  );

                foreach( var table in _tables )
                {
                    _comboBox?.Items.Add( table );
                }
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }


        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                PopulateToolbarComboBox( );
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }


        /// <summary>
        /// Called when [calculator button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnCalculatorButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _calculator = new CalculationForm(  );
                _calculator.Show(  );
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [calendar button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnCalendarButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _calendar = new CalendarForm(  );
                _calendar.Show(  );
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [browse button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnBrowseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _browse = new FileBrowser(  );
                _browse.Show(  );
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [chart button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnChartButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _charts = new ChartForm(  );
                _charts.Show(  );
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [home menu button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnHomeMenuButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _menu = new MainForm(  );
                _menu.Show(  );
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }
        
        public void OnExcelButtonClicked( object sender, EventArgs e )
        {
            try
            {
                var _excel = new ExcelForm(  );
                _excel.Show(  );
            }
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }
        /// <summary>
        /// Get Error Dialog.
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
