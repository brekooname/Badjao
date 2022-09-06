namespace BudgetExecution 
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
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


        public DataConfiguration()
        {
            InitializeComponent( );
            TabControl.TabPanelBackColor = Color.FromArgb( 15, 15, 15 );
            LookupSqliteRadioButton.ForeColor = Color.FromArgb( 0, 120, 212 );
            LookupSqliteRadioButton.BorderColor = Color.FromArgb( 0, 120, 212 );
            LookupSqliteRadioButton.CheckSignColor = Color.LimeGreen;
            LookupAccessRadioButton.ForeColor = Color.FromArgb( 0, 120, 212 );
            LookupAccessRadioButton.BorderColor = Color.FromArgb( 0, 120, 212 );
            LookupAccessRadioButton.CheckSignColor = Color.LimeGreen;
            LookupSqlServerRadioButton.ForeColor = Color.FromArgb( 0, 120, 212 );
            LookupSqlServerRadioButton.BorderColor = Color.FromArgb( 0, 120, 212 );
            LookupSqlServerRadioButton.CheckSignColor = Color.LimeGreen;
            LookupCloseButton.Click += OnCloseButtonClicked;
            LookupTableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
            LookupColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
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
                LookupTabPage.TabVisible = true;
                CreateTabPage.TabVisible = false;
                AlterTabPage.TabVisible = false;
                DropTabPage.TabVisible = false;
                SqlTabPage.TabVisible = false;
                PopulateTableListBoxItems(  );
                
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
                LookupTableListBox.Items.Clear( );
                var _names = Enum.GetNames( typeof( Source ) );
                foreach( var name in _names )
                {
                    if( name != "NS" )
                    {
                        LookupTableListBox.Items.Add( name );
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
                FormFilter?.Clear( );
                LookupColumnListBox?.Items.Clear( );
                LookupValueListBox?.Items.Clear( );
                LookupColumnGroupBox.Text = string.Empty;
                LookupValueGroupBox.Text = string.Empty;
                var _listBox = sender as VisualListBox;
                var _value = _listBox?.SelectedItem?.ToString( );
                if( !string.IsNullOrEmpty( _value ) )
                {
                    var _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;
                    LookupTableGroupBox.Text = TablePrefix + DataModel.DataTable.TableName?.SplitPascal( );

                    var _columns = DataModel.GetDataColumns( );

                    foreach( var col in _columns )
                    {
                        LookupColumnListBox?.Items.Add( col.ColumnName );
                    }

                    LookupColumnGroupBox.Text = ColumnPrefix + LookupColumnListBox?.Items.Count;
                    LookupValueGroupBox.Text = ValuePrefix;
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
                LookupValueListBox.Items.Clear( );
                var _listBox = sender as VisualListBox;
                var _column = _listBox?.SelectedItem?.ToString( );
                var _series = DataModel.DataElements;

                if( !string.IsNullOrEmpty( _column ) )
                {
                    foreach( var item in _series[ _column ] )
                    {
                        LookupValueListBox.Items.Add( item );
                    }
                }

                LookupValueGroupBox.Text = ValuePrefix + LookupValueListBox.Items.Count;
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
