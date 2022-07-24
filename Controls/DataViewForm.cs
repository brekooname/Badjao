namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System;
    using Syncfusion.Windows.Forms;


    [SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public partial class DataViewForm : MetroForm
    {
        public DataViewForm( )
        {
            InitializeComponent( );
            Load += OnLoad;
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
                using( var _calculator = new CalculationForm( ) )
                {
                    _calculator?.Show( );
                }
            }
            catch( Exception ex )
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
                using( var _calendar = new CalendarForm( ) )
                {
                    _calendar.Show( );
                }
            }
            catch( Exception ex )
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
                using( var _browse = new FileBrowser( ) )
                {
                    _browse.Show( );
                }
            }
            catch( Exception ex )
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
                using( var _charts = new ChartForm( ) )
                {

                    _charts.Show( );
                }
            }
            catch( Exception ex )
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
                using( var _menu = new MainForm( ) )
                {
                    _menu.Show( );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public void OnExcelButtonClicked( object sender, EventArgs e )
        {
            try
            {
                using( var _excel = new ExcelForm( ) )
                {
                    _excel.Show( );
                }
            }
            catch( Exception ex )
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
                var _data = new DataBuilder( Source.StatusOfFunds, Provider.Access );
                BindingSource.DataSource = _data?.Table;
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
