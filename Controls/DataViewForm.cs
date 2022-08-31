namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System;
    using Syncfusion.Windows.Forms;
    using System.Collections.Generic;
    using System.Drawing;
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
        /// Gets the source prefix.
        /// </summary>
        /// <value>
        /// The source prefix.
        /// </value>
        public string SourcePrefix { get; } = " Data Source : ";

        /// <summary>
        /// Gets the table prefix.
        /// </summary>
        /// <value>
        /// The table prefix.
        /// </value>
        public string TablePrefix { get; } = " Tables : ";

        /// <summary>
        /// Gets the column prefix.
        /// </summary>
        /// <value>
        /// The column prefix.
        /// </value>
        public string ColumnPrefix { get; } = " Columns : ";

        /// <summary>
        /// Gets the value prefix.
        /// </summary>
        /// <value>
        /// The value prefix.
        /// </value>
        public string ValuePrefix { get; } = " Values : ";
        
        /// <summary>
        /// Initializes a new instance of the <see cref="DataViewForm"/> class.
        /// </summary>
        public DataViewForm( )
        {
            InitializeComponent( );
            InitGrid( );
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
            InitGrid( );
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
                FormFilter = new Dictionary<string, object>( );
                FormFilter.Add( "BFY", "2022"  );
                FormFilter.Add( "FundCode", "B" );
                DataModel = new DataBuilder( Source.StatusOfFunds, Provider.Access, FormFilter );
                BindingSource.DataSource = DataModel.DataTable;
                DataGrid.DataSource = BindingSource.DataSource;
                DataGridLabel.Text = SourcePrefix + DataModel.DataTable.TableName.SplitPascal( );
                PopulateTableListBoxItems( );
                PopulateToolBarDropDownItems( );
                ToolStrip.Office12Mode = true;
                TableGroupBox.Text = TablePrefix + TableListBox.Items.Count;
                ColumnGroupBox.Text = ColumnPrefix;
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
            try
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
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        private void InitGrid(  )
        {
            try
            {
                DataGrid.ForeColor = Color.Black;
                DataGrid.Font = new Font( "Roboto", 9 );
                DataGrid.Margin = new Padding( 3 );
                DataGrid.Padding = new Padding( 1 );
                DataGrid.Size = new Size( 240, 150 );
                DataGrid.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                DataGrid.BackColor = Color.FromArgb( 40, 40, 40 );
                DataGrid.BorderStyle = BorderStyle.None;
                DataGrid.CellBorderStyle = DataGridViewCellBorderStyle.Single;
                DataGrid.BackgroundColor = Color.FromArgb( 40, 40, 40 );
                DataGrid.GridColor = Color.FromArgb( 141, 139, 138 );

                // Column SeriesConfiguration
                DataGrid.AllowUserToOrderColumns = true;
                DataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
                DataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
                DataGrid.ColumnHeadersHeight = 35;
                DataGrid.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                DataGrid.ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
                DataGrid.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
                DataGrid.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                DataGrid.ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                DataGrid.ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
                DataGrid.ColumnHeadersDefaultCellStyle.Font = new Font( "Roboto", 9, FontStyle.Bold );
                DataGrid.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

                // Row SeriesConfiguration
                DataGrid.RowHeadersWidth = 26;
                DataGrid.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
                DataGrid.RowHeadersDefaultCellStyle.BackColor = SystemColors.ControlDark;
                DataGrid.RowHeadersDefaultCellStyle.Font = new Font( "Roboto", 9 );
                DataGrid.RowHeadersDefaultCellStyle.ForeColor = Color.Black;
                DataGrid.RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
                DataGrid.CellBorderStyle = DataGridViewCellBorderStyle.None;
                DataGrid.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
                DataGrid.RowsDefaultCellStyle.BackColor = Color.FromArgb( 40, 40, 40 );
                DataGrid.RowsDefaultCellStyle.Font = new Font( "Roboto", 8 );
                DataGrid.RowsDefaultCellStyle.ForeColor = Color.LightSteelBlue;
                DataGrid.RowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                DataGrid.RowsDefaultCellStyle.SelectionForeColor = Color.White;
                DataGrid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGrid.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb( 40, 40, 40 );
                DataGrid.AlternatingRowsDefaultCellStyle.ForeColor = Color.FromArgb( 240, 240, 240 );
                DataGrid.AlternatingRowsDefaultCellStyle.Font = new Font( "Roboto", 8 );
                DataGrid.AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
                DataGrid.AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

                // Epilog
                DataGrid.Visible = true;
                DataGrid.Enabled = true;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the tool bar drop down items.
        /// </summary>
        public void PopulateToolBarDropDownItems( )
        {
            try
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
            catch ( Exception ex )
            {
                Fail( ex );
            }
        }


        /// <summary>
        /// Called when [table ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnTableListBoxSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                FormFilter.Clear( );
                ColumnListBox.Items.Clear( );
                ValueListBox.Items.Clear( );
                ColumnGroupBox.Text = string.Empty;
                ValueGroupBox.Text = string.Empty;
                var _listBox = sender as VisualListBox;
                var _value = _listBox?.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _value ) )
                {
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );

                    BindingSource = new BindingSource
                    {
                        DataSource = DataModel.DataTable
                    };

                    DataGrid.DataSource = BindingSource.DataSource;
                    DataGridLabel.Text = SourcePrefix + _value.SplitPascal( );

                    var _columns = DataModel.GetDataColumns( );

                    foreach( var col in _columns )
                    {
                        ColumnListBox.Items.Add( col.ColumnName );
                    }

                    ColumnGroupBox.Text = ColumnPrefix + ColumnListBox.Items.Count;
                    ValueGroupBox.Text = ValuePrefix;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [column ListBox selection changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnColumnListBoxSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                ValueListBox.Items.Clear(  );
                var _listBox = sender as VisualListBox;
                var _column = _listBox?.SelectedItem.ToString(  );
                var _series = DataModel.DataElements;

                if( !string.IsNullOrEmpty( _column ) )
                {
                    foreach( var item in _series[ _column ] )
                    {
                        ValueListBox.Items.Add( item );
                    }
                }

                ValueGroupBox.Text = ValuePrefix + ValueListBox.Items.Count;
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