namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System;
    using Syncfusion.Windows.Forms;
    using System.Collections.Generic;
    using System.Data;

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
                var _filter = new Dictionary<string, object>(  );
                _filter.Add( "BFY", "2022"  );
                _filter.Add( "FundCode", "B" );
                _filter.Add( "RpioCode", "10"  );
                var _data = new DataBuilder( Source.StatusOfFunds, Provider.Access, _filter );
                BindingSource.DataSource = _data.DataTable;
                PopulateListBoxItems();
                ToolStrip.Office12Mode = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public void PopulateListBoxItems( )
        {
            PrimaryListBox.Items.Clear();
            var _names = Enum.GetNames( typeof( Source ) );
            foreach( var name in _names )
            {
                if( name != "NS" )
                {
                    PrimaryListBox.Items.Add( name.SplitPascal( ) );
                }
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
