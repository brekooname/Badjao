namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using Syncfusion.Windows.Forms.Tools;

    public partial class LookupDialog : EditBase
    {
        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

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
        /// Initializes a new instance of the <see cref="LookupDialog"/> class.
        /// </summary>
        public LookupDialog( )
        {
            InitializeComponent( );
            GroupBoxes = GetGroupBoxes( );
            RadioButtons = GetRadioButtons( );
            TabControl.TabPanelBackColor = Color.FromArgb( 15, 15, 15 );
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
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
                FormFilter.Add( "BFY", "2022" );
                FormFilter.Add( "FundCode", "B" );
                DataModel = new DataBuilder( Source.StatusOfFunds, Provider.Access, FormFilter );
                BindingSource.DataSource = DataModel.DataTable;
                SetGroupBoxProperties( );
                SetRadioButtonProperties( );
                PopulateTableListBoxItems( );
                TableGroupBox.Text = TablePrefix + TableListBox.Items.Count;
                ColumnGroupBox.Text = ColumnPrefix;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the group box properties.
        /// </summary>
        public void SetGroupBoxProperties( )
        {
            try
            {
                foreach( var _groupBox in GroupBoxes.Values )
                {
                    _groupBox.SeparatorColor = Color.FromArgb( 64, 64, 64 );
                    _groupBox.Separate = true;
                    _groupBox.Separator = true;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the RadioButton properties.
        /// </summary>
        public void SetRadioButtonProperties( )
        {
            if ( RadioButtons?.Any( ) == true )
            {
                try
                {
                    foreach( var _button in RadioButtons.Values )
                    {
                        _button.ForeColor = Color.FromArgb( 0, 120, 212 );
                        _button.CheckSignColor = Color.FromArgb( 0, 120, 212 );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the group boxes.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, GroupBox> GetGroupBoxes()
        {
            if( TabControl?.TabPages?.Count > 0 )
            {
                try
                {
                    var _groupBoxes = new Dictionary<string, GroupBox>( );
                    foreach( TabPageAdv _tabPage in TabControl.TabPages )
                    {
                        foreach( var _control in _tabPage.Controls )
                        {
                            if( _control is GroupBox _groupBox )
                            {
                                _groupBoxes.Add( _groupBox.Name, _groupBox );
                            }
                        }
                    }

                    return _groupBoxes?.Any( ) == true
                        ? _groupBoxes
                        : default( IDictionary<string, GroupBox> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, GroupBox> );
                }
            }

            return default( IDictionary<string, GroupBox> );
        }

        /// <summary>
        /// Gets the list boxes.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, ListBox> GetListBoxes()
        {
            if( TabControl?.TabPages?.Count > 0 )
            {
                try
                {
                    var _listBoxes = new Dictionary<string, ListBox>( );
                    foreach( TabPageAdv _tabPage in TabControl.TabPages )
                    {
                        if( _tabPage?.Controls?.Count > 0 )
                        {
                            foreach( var _control in _tabPage.Controls )
                            {
                                if( _control is ListBox _listBox )
                                {
                                    _listBoxes.Add( _listBox.Name, _listBox );
                                }
                            }
                        }
                    }

                    return _listBoxes?.Any( ) == true
                        ? _listBoxes
                        : default( IDictionary<string, ListBox> );
                }
                catch( Exception ex )
                {
                    DefinitionDialog.Fail( ex );
                    return default( IDictionary<string, ListBox> );
                }
            }

            return default( IDictionary<string, ListBox> );
        }

        /// <summary>
        /// Gets the radio buttons.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, RadioButton> GetRadioButtons()
        {
            if( TabControl?.TabPages?.Count > 0 )
            {
                try
                {
                    var _buttons = new Dictionary<string, RadioButton>( );
                    foreach( var _tabPage in TabControl.TabPages )
                    {
                        if( _tabPage is TabPageAdv _tab )
                        {
                            foreach( var _control in _tab.Controls )
                            {
                                if( _control is GroupBox _group )
                                {
                                    foreach( var _item in _group.Controls )
                                    {
                                        if( _item is RadioButton _radioButton )
                                        {
                                            _buttons.Add( _radioButton.Name, _radioButton );
                                        }
                                    }
                                }
                            }
                        }
                    }

                    return _buttons?.Any( ) == true
                        ? _buttons
                        : default( IDictionary<string, RadioButton> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, RadioButton> );
                }
            }

            return default( IDictionary<string, RadioButton> );
        }

        /// <summary>
        /// Populates the table ListBox items.
        /// </summary>
        public void PopulateTableListBoxItems()
        {
            try
            {
                TableListBox.Items.Clear( );
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
                var _listBox = sender as ListBox;
                var _value = _listBox?.SelectedItem.ToString( );
                if( !string.IsNullOrEmpty( _value ) )
                {
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;

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
                ValueListBox.Items.Clear( );
                var _listBox = sender as ListBox;
                var _column = _listBox?.SelectedItem?.ToString( );
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
    }
}
