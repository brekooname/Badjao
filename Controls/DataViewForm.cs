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
        public DataBuilder DataModel { get; set; }

        public IDictionary<string, object> FormFilter { get; set; }

        public DataViewForm( )
        {
            InitializeComponent( );
            Load += OnLoad;
            TableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
            ColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
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
                FormFilter = new Dictionary<string, object>(  );
                FormFilter.Add( "BFY", "2022"  );
                FormFilter.Add( "FundCode", "B" );
                DataModel = new DataBuilder( Source.StatusOfFunds, Provider.Access, FormFilter );
                DataGrid.DataSource = DataModel.GetDataTable(  );
                BindingSource.DataSource = DataGrid.DataSource;
                ToolStrip.BindingSource = BindingSource;
                DataSourceLabel.Text = DataModel.DataTable.TableName.SplitPascal(  );
                PopulateTableListBoxItems(  );
                PopulateToolBarDropDownItems(  );
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
        public void PopulateTableListBoxItems( )
        {
            TableListBox.Items.Clear();
            var _names = Enum.GetNames( typeof( Source ) );
            foreach( var name in _names )
            {
                if( name != "NS" )
                {
                    TableListBox.Items.Add( name );
                }
            }
        }

        public void PopulateToolBarDropDownItems( )
        {
            var _names = Enum.GetNames( typeof( SQL ) );
            foreach( var name in _names )
            {
                if( name != "NS" )
                {
                    ToolStrip.DropDown.Items.Add( name  );
                }
            }
        }

        public void OnTableListBoxSelectionChanged( object sender, EventArgs e )
        {
            ColumnListBox.Items.Clear( );
            ElementListBox.Items.Clear( );
            var _listBox = sender as VisualListBox;
            var _value = _listBox?.SelectedItem.ToString( );
            if( !string.IsNullOrEmpty( _value ) )
            {
                DataSourceLabel.Text = _value.SplitPascal(   );
                var _source = (Source)Enum.Parse( typeof( Source ), _value );
                DataModel = new DataBuilder( _source, Provider.Access );
                DataGrid.DataSource = DataModel.GetDataTable(  );
                var _columns = DataModel.GetDataColumns(   );

                foreach( var col in _columns )
                {
                    ColumnListBox.Items.Add( col.ColumnName );
                }
            }
        }

        public void OnColumnListBoxSelectionChanged( object sender, EventArgs e )
        {
            ElementListBox.Items.Clear(  );
            var _listBox = sender as VisualListBox;
            var _column = _listBox?.SelectedItem.ToString(  );
            var _series = DataModel.DataElements;

            if( !string.IsNullOrEmpty( _column ) )
            {
                foreach( var item in _series[ _column ] )
                {
                    ElementListBox.Items.Add( item );
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
