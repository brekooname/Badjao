namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System;
    using Syncfusion.Windows.Forms;
    using System.Collections.Generic;
    using VisualPlus.Toolkit.Controls.DataManagement;

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
                var _data = new DataBuilder( Source.StatusOfFunds, Provider.Access, _filter );
                var _columns = _data.GetDataColumns(   );
                BindingSource.DataSource = _data.DataTable;
                DataView.BindingSource = BindingSource;
                PopulateToolBarDropDownItems(  );
                PrimaryListBox.SelectedValueChanged += OnPrimaryListBoxSelectionChanged;
                foreach( var col in _columns )
                {
                    if( col?.ColumnName != null )
                    {
                        PrimaryListBox.Items.Add( col?.ColumnName );
                    }
                }
                ToolStrip.Office12Mode = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the ListBox items.
        /// </summary>
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

        public void PopulateToolBarDropDownItems( )
        {
            var _names = Enum.GetNames( typeof( Source ) );
            foreach( var name in _names )
            {
                if( name != "NS" )
                {
                    ToolStrip.DropDown.Items.Add( name  );
                }
            }
        }

        public void OnPrimaryListBoxSelectionChanged( object sender, EventArgs e )
        {
            var _listBox = sender as VisualListBox;
            var _column = _listBox?.SelectedValue.ToString(  );
            var _msg = $"The Selection made is:  { _column.SplitPascal(   ) } ";

            using( var msg  = new Message( _msg ) )
            {
                msg.ShowDialog(   );
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
