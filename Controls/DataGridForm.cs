﻿// <copyright file = "DataGridForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System;
    using Syncfusion.Windows.Forms;
    using System.Collections.Generic;
    using System.Data;
    using VisualPlus.Toolkit.Controls.DataManagement;

    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public partial class DataGridForm : MetroForm
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
        /// Gets or sets the selected table.
        /// </summary>
        /// <value>
        /// The selected table.
        /// </value>
        public string SelectedTable { get; set; }

        /// <summary>
        /// Gets or sets the selected column.
        /// </summary>
        /// <value>
        /// The selected column.
        /// </value>
        public string SelectedColumn { get; set; }

        /// <summary>
        /// Gets or sets the selected value.
        /// </summary>
        /// <value>
        /// The selected value.
        /// </value>
        public string SelectedValue { get; set; }

        /// <summary>
        /// Gets or sets the SQL query.
        /// </summary>
        /// <value>
        /// The SQL query.
        /// </value>
        public string SqlQuery { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridForm"/> class.
        /// </summary>
        public DataGridForm( )
        {
            InitializeComponent( );
            Load += OnLoad;
            TableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
            ColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
            ValueListBox.SelectedValueChanged += OnValueListBoxSelectionChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataGridForm"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public DataGridForm( Source source, Provider provider )
        {
            InitializeComponent( );
            Load += OnLoad;
            TableListBox.SelectedValueChanged += OnTableListBoxSelectionChanged;
            ColumnListBox.SelectedValueChanged += OnColumnListBoxSelectionChanged;
            ValueListBox.SelectedValueChanged += OnValueListBoxSelectionChanged;
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
                FormFilter = new Dictionary<string, object>
                {
                    { "BFY", "2022" },
                    { "FundCode", "B" }
                };
                DataModel = new DataBuilder( Source.StatusOfFunds, Provider.Access, FormFilter );
                BindingSource.DataSource = DataModel.DataTable;
                DataGrid.DataSource = BindingSource;
                PopulateTableListBoxItems( );
                PopulateToolBarDropDownItems( );
                ToolStrip.Office12Mode = true;
                TableGroupBox.Text = TablePrefix + TableListBox.Items.Count;
                ColumnGroupBox.Text = ColumnPrefix;
                DataGridGroupBox.Text = SourcePrefix + DataModel.DataTable.TableName.SplitPascal( );
                SelectedTable = string.Empty;
                SelectedColumn = string.Empty;
                SelectedValue = string.Empty;
                SqlQuery = string.Empty;
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
                TableListBox.Items.Clear( );
                string[ ] _names = Enum.GetNames( typeof( Source ) );

                foreach( string name in _names )
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
        /// Populates the tool bar drop down items.
        /// </summary>
        public void PopulateToolBarDropDownItems( )
        {
            try
            {
                string[ ] _names = Enum.GetNames( typeof( SQL ) );

                foreach( string name in _names )
                {
                    if( name != "NS" )
                    {
                        ToolStrip.DropDown.Items.Add( name );
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
                SqlQuery = string.Empty;
                HeaderLabel.Text = string.Empty;
                ColumnListBox.Items.Clear( );
                ValueListBox.Items.Clear( );
                ColumnGroupBox.Text = string.Empty;
                ValueGroupBox.Text = string.Empty;
                VisualListBox _listBox = sender as VisualListBox;
                string _value = _listBox?.SelectedItem.ToString( );
                SelectedTable = _value;

                if( !string.IsNullOrEmpty( _value ) )
                {
                    Source _source = (Source)Enum.Parse( typeof( Source ), _value );
                    DataModel = new DataBuilder( _source, Provider.Access );
                    BindingSource.DataSource = DataModel.DataTable;
                    DataGrid.DataSource = BindingSource;
                    ToolStrip.BindingSource = BindingSource;

                    DataGridGroupBox.Text =
                        SourcePrefix + DataModel.DataTable.TableName?.SplitPascal( );

                    IEnumerable<DataColumn> _columns = DataModel.GetDataColumns( );

                    foreach( DataColumn col in _columns )
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
        /// <param name="e">
        /// The <see cref="EventArgs"/> 
        /// instance containing the event data.</param>
        public void OnColumnListBoxSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                ValueListBox.Items.Clear( );
                SqlQuery = string.Empty;
                HeaderLabel.Text = string.Empty;
                VisualListBox _listBox = sender as VisualListBox;
                string _column = _listBox?.SelectedItem?.ToString( );
                IDictionary<string, IEnumerable<string>> _series = DataModel.DataElements;

                if( !string.IsNullOrEmpty( _column ) )
                {
                    SelectedColumn = _column?.Trim( );

                    foreach( string item in _series[ _column ] )
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

        public void OnValueListBoxSelectionChanged( object sender, EventArgs e )
        {
            try
            {
                SqlQuery = string.Empty;
                HeaderLabel.Text = string.Empty;
                VisualListBox _listBox = sender as VisualListBox;
                string _value = _listBox?.SelectedItem?.ToString( );
                SelectedValue = _value?.Trim( );
                string _query = string.Empty;

                if( !string.IsNullOrEmpty( SelectedTable )
                    & !string.IsNullOrEmpty( SelectedColumn ) )
                {
                    FormFilter.Add( SelectedColumn, SelectedValue );

                    _query = $"SELECT * FROM {SelectedTable} "
                        + $"WHERE {SelectedColumn} = '{SelectedValue}';";
                }

                SqlQuery = _query;
                HeaderLabel.Text = SqlQuery;
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
            using Error _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}