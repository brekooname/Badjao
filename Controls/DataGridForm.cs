
namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using Syncfusion.Windows.Forms;

    /// <summary>
    ///   <br />
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public partial class DataGridForm : MetroForm
    {

        public DataGridForm( )
        {
            InitializeComponent( );
            Load += OnLoad;
        }


        /// <summary>Gets the table list.</summary>
        /// <returns>
        ///   <br />
        /// </returns>
        public IEnumerable<string> GetTableList( )
        {
            try
            {
                var _tables = new List<string>( );
                var _sources = Enum.GetNames( typeof( SQL ) );

                foreach( var item in _sources )
                {
                    _tables.Add( item );
                }

                return _tables.Count > 0
                    ? _tables 
                    : default( List<string> );
            }
            catch ( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<string> );
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
                if( Toolbar != null )
                {
                    var _items = GetTableList( );

                    foreach( var i in _items )
                    {
                        if( !string.IsNullOrEmpty( i )
                            && i != "NS" )
                        {
                            Toolbar.DropDown?.ComboBox?.Items.Add( i );
                        }
                    }
                }
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
                using( var _calculator = new CalculationForm(  ) )
                {
                    _calculator.Show(  );
                }
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
                using( var _calendar = new CalendarForm(  ) )
                {
                    _calendar.Show(  );
                }
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
                using( var _browse = new FileBrowser(  ) )
                {
                    _browse.Show(  );
                }
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
                using( var _charts = new ChartForm(  ) )
                {

                    _charts.Show(  );
                }
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
                using( var _menu = new MainForm(  ) )
                {
                    _menu.Show(  );
                }
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
                using( var _excel = new ExcelForm(  ) )
                {
                    _excel.Show(  );
                }
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

        private void DataGridForm_Load( object sender, EventArgs e )
        {
            // TODO: This line of code loads data into the 'dataSet.StatusOfFunds' table. You can move, or remove it, as needed.
            TableAdapter.Fill( DataSet.StatusOfFunds );

        }
    }
}
