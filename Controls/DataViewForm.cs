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
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                var _data = new DataBuilder( Source.StatusOfFunds, Provider.Access );
                BindingSource.DataSource = _data.Table;
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
