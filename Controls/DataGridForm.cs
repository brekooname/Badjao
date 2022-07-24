
namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
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

            DataGrid.ForeColor = Color.Black;
            DataGrid.Font = new Font( "Roboto", 9 );
            DataGrid.Margin = new Padding( 3 );
            DataGrid.Padding = new Padding( 1 );
            DataGrid.Size = new Size( 240, 150 );
            DataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            DataGrid.BackColor = Color.FromArgb( 40, 40, 40 );
            DataGrid.BorderStyle = BorderStyle.None;
            DataGrid.BackColor = Color.FromArgb( 40, 40, 40 );
            DataGrid.ForeColor = Color.FromArgb( 240, 240, 240 );
            DataGrid.GridOfficeScrollBars = OfficeScrollBars.Office2016;
            DataGrid.Office2016ScrollBarsColorScheme = ScrollBarOffice2016ColorScheme.Black;
            DataGrid.ColorStyles = ColorStyles.Office2016Black;
            DataGrid.ThemeStyle.CellStyle.Font = new Font( "Roboto", 9, FontStyle.Regular );
            DataGrid.ThemeStyle.CellStyle.BackColor = Color.FromArgb( 40, 40, 40 );
            DataGrid.ThemeStyle.CellStyle.TextColor = Color.FromArgb( 240, 240, 240 );
            DataGrid.ThemeStyle.CheckBoxStyle.BackColor = Color.FromArgb( 40, 40, 40 );
            DataGrid.ThemeStyle.CheckBoxStyle.TickColor = Color.Lime;

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
                var _data = new DataBuilder( Source.StatusOfFunds, Provider.Access );
                DataGrid.DataSource = _data?.Table;
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
    }
}
