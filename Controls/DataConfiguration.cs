namespace BudgetExecution 
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using Microsoft.EntityFrameworkCore.Internal;
    using Syncfusion.Windows.Forms;
    using VisualPlus.Toolkit.Controls.DataManagement;

    public partial class DataConfiguration : MetroForm
    {
        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        public SQL CommandType { get; set; }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public IDictionary<string, object> FormFilter { get; set; }

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
        /// Gets or sets the group boxes.
        /// </summary>
        /// <value>
        /// The group boxes.
        /// </value>
        public IDictionary<string, GroupBox> GroupBoxes { get; set; }

        /// <summary>
        /// Gets or sets the list boxes.
        /// </summary>
        /// <value>
        /// The list boxes.
        /// </value>
        public IDictionary<string, ListBox> ListBoxes { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        public IDictionary<string, Label> Labels { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataConfiguration"/> class.
        /// </summary>
        public DataConfiguration()
        {
            InitializeComponent( );
            TabControl.TabPanelBackColor = Color.FromArgb( 15, 15, 15 );
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
                GroupBoxes = GetGroupBoxes( );
                ListBoxes = GetListBoxes( );
                SetLookupTabPage( );
                PopulateTableListBoxItems( );
                SetGroupBoxProperties( GroupBoxes );

            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public void SetLookupTabPage( )
        {
            try
            {
                LookupTabPage.TabVisible = true;
                CreateTabPage.TabVisible = false;
                AlterTabPage.TabVisible = false;
                DropTabPage.TabVisible = false;
                SqlTabPage.TabVisible = false;
                EditTabPage.TabVisible = false;
                CloseButton.Click += OnCloseButtonClicked;
                LookupTabTableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
                LookupTabColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the ListBox items.
        /// </summary>
        public void PopulateTableListBoxItems()
        {
            try
            {
                LookupTabTableListBox.Items.Clear( );
                var _names = Enum.GetNames( typeof( Source ) );
                foreach( var name in _names )
                {
                    if( name != "NS" )
                    {
                        LookupTabTableListBox.Items.Add( name );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the group box properties.
        /// </summary>
        public void SetGroupBoxProperties( IDictionary<string, GroupBox> groupBoxes )
        {
            if( groupBoxes?.Any( ) == true )
            {
                try
                {
                    foreach( var _box in groupBoxes.Values )
                    {
                        if( _box != null && 
                            _box.Separator != true )
                        {
                            _box.Separator = true;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the list boxes.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, ListBox> GetListBoxes( )
        {
            try
            {
                var _listBoxes = new Dictionary<string, ListBox>( );
                _listBoxes.Add( LookupTabTableListBox.Name, LookupTabTableListBox );
                _listBoxes.Add( LookupTabColumnListBox.Name, LookupTabColumnListBox );
                _listBoxes.Add( LookupTabValueListBox.Name, LookupTabValueListBox );
                _listBoxes.Add( CreateTabTableListBox.Name, CreateTabTableListBox );
                _listBoxes.Add( AlterTabTableListBox.Name, AlterTabTableListBox );
                _listBoxes.Add( DropTabTableListBox.Name, DropTabTableListBox );

                return _listBoxes?.Any(  ) == true
                    ? _listBoxes
                    : default( IDictionary<string, ListBox> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, ListBox> );
            }
        }

        /// <summary>
        /// Gets the group boxes.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, GroupBox> GetGroupBoxes()
        {
            try
            {
                var _groupBoxes = new Dictionary<string, GroupBox>(  );
                _groupBoxes.Add( LookupTabProviderGroupBox.Name, LookupTabProviderGroupBox );
                _groupBoxes.Add( LookupTabTableGroupBox.Name, LookupTabTableGroupBox );
                _groupBoxes.Add( LookupTabColumnGroupBox.Name, LookupTabColumnGroupBox );
                _groupBoxes.Add( CreateTabProviderGroupBox.Name, CreateTabProviderGroupBox );
                _groupBoxes.Add( CreateTabTableGroupBox.Name, CreateTabTableGroupBox );
                _groupBoxes.Add( CreateTabColumnGroupBox.Name, CreateTabColumnGroupBox );
                _groupBoxes.Add( AlterTabProviderGroupBox.Name, AlterTabProviderGroupBox );
                _groupBoxes.Add( AlterTabTableGroupBox.Name, AlterTabTableGroupBox );
                _groupBoxes.Add( AlterTabColumnGroupBox.Name, AlterTabColumnGroupBox );
                _groupBoxes.Add( DropTabProviderGroupBox.Name, DropTabProviderGroupBox );
                _groupBoxes.Add( DropTabTableGroupBox.Name, DropTabTableGroupBox );
                _groupBoxes.Add( DropTabColumnGroupBox.Name, DropTabColumnGroupBox );
                return default( IDictionary<string, GroupBox> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, GroupBox> );
            }
        }

        /// <summary>
        /// Gets the radio buttons.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<RadioButton> GetRadioButtons()
        {
            try
            {
                return default( IEnumerable<RadioButton> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<RadioButton> );
            }
        }

        public void GetEditLabels()
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public void GetEditBoxes()
        {
            try
            {
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
                FormFilter?.Clear( );
                LookupTabColumnListBox?.Items.Clear( );
                LookupTabValueListBox?.Items.Clear( );
                LookupTabColumnGroupBox.Text = string.Empty;
                LookupTabValueGroupBox.Text = string.Empty;
                var _listBox = sender as VisualListBox;
                var _value = _listBox?.SelectedItem?.ToString( );
                if( !string.IsNullOrEmpty( _value ) )
                {
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;
                    LookupTabTableGroupBox.Text = TablePrefix + DataModel.DataTable.TableName?.SplitPascal( );

                    var _columns = DataModel.GetDataColumns( );

                    foreach( var col in _columns )
                    {
                        LookupTabColumnListBox?.Items.Add( col.ColumnName );
                    }

                    LookupTabColumnGroupBox.Text = ColumnPrefix + LookupTabColumnListBox?.Items.Count;
                    LookupTabValueGroupBox.Text = ValuePrefix;
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
                LookupTabValueListBox.Items.Clear( );
                var _listBox = sender as VisualListBox;
                var _column = _listBox?.SelectedItem?.ToString( );
                var _series = DataModel.DataElements;

                if( !string.IsNullOrEmpty( _column ) )
                {
                    foreach( var item in _series[ _column ] )
                    {
                        LookupTabValueListBox.Items.Add( item );
                    }
                }

                LookupTabValueGroupBox.Text = ValuePrefix + LookupTabValueListBox.Items.Count;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public void OnCloseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Close( );
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
