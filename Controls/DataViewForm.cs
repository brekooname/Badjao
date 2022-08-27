namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System;
    using Syncfusion.Windows.Forms;
    using System.Collections.Generic;
    using System.Windows.Forms;
    using VisualPlus.Toolkit.Controls.DataManagement;

    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public partial class DataViewForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> FormFilter { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DataViewForm"/> class.
        /// </summary>
        public DataViewForm( )
        {
            InitializeComponent( );
            Load += OnLoad;
            TableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
            ColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataViewForm"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public DataViewForm( Source source, Provider provider )
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
                BindingSource.DataSource = DataModel.DataTable;
                DataGrid.DataSource = BindingSource;
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

        /// <summary>
        /// Populates the tool bar drop down items.
        /// </summary>
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


        /// <summary>
        /// Called when [table ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnTableListBoxSelectionChanged( object sender, EventArgs e )
        {
            FormFilter.Clear( );
            ColumnListBox.Items.Clear( );
            ElementListBox.Items.Clear( );
            var _listBox = sender as VisualListBox;
            var _value = _listBox?.SelectedItem.ToString( );
            if( !string.IsNullOrEmpty( _value ) )
            {
                DataSourceLabel.Text = _value.SplitPascal(   );
                var _source = (Source)Enum.Parse( typeof( Source ), _value );
                DataModel = new DataBuilder( _source, Provider.Access );

                BindingSource = new BindingSource
                {
                    DataSource = DataModel.DataTable
                };
                
                var _columns = DataModel.GetDataColumns( );

                foreach( var col in _columns )
                {
                    ColumnListBox.Items.Add( col.ColumnName );
                }
            }
        }

        /// <summary>
        /// Called when [column ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
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

        private void DataViewForm_Load( object sender, EventArgs e )
        {

        }
    }
}
