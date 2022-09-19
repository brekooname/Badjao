// <copyright file = "DefinitionDialog.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using Microsoft.EntityFrameworkCore.Internal;
    using Syncfusion.Windows.Forms.Tools;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="EditBase" />
    public partial class DefinitionDialog : EditBase
    {
        /// <summary>
        /// Gets or sets the sqlite data types.
        /// </summary>
        /// <value>
        /// The sqlite data types.
        /// </value>
        public override IEnumerable<string> DataTypes { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinitionDialog"/> class.
        /// </summary>
        public DefinitionDialog( )
        {
            InitializeComponent( );
            TabPages = GetTabPages( );
            GroupBoxes = GetGroupBoxes( );
            ListBoxes = GetListBoxes( );
            RadioButtons = GetRadioButtons( );
            TabControl.TabPanelBackColor = Color.FromArgb( 15, 15, 15 );
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
        }

        /// <summary>
        /// Initializes a new instance of 
        /// the <see cref="DefinitionDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        public DefinitionDialog( ToolType toolType )
            : this( )
        {
            ToolType = toolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinitionDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="bindingSource">The binding source.</param>
        public DefinitionDialog( ToolType toolType, BindingSource bindingSource )
            : this( )
        {
            ToolType = toolType;
            BindingSource = bindingSource;
            DataTable = (DataTable)bindingSource.DataSource;
            Provider = Provider.Access;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataModel = new DataBuilder( Source, Provider );
            Columns = DataTable.GetColumnNames( );
            DataTypes = GetDataTypes( Provider );
        }

        /// <summary>
        /// Called when [visible].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SetGroupBoxProperties( );
                SetRadioButtonProperties( );
                SetActivetTab( );
                PopulateTableListBoxItems( );
                PopulateComboBoxes( );
                CloseButton.Text = "Exit";
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Populates the table ListBox items.
        /// </summary>
        public void PopulateTableListBoxItems()
        {
            try
            {
                var _names = Enum.GetNames( typeof( Source ) );

                foreach( var name in _names )
                {
                    if( name != "NS" )
                    {
                        EditColumnTableNameListBox.Items.Add( name );
                        DeleteColumnTableListBox.Items.Add( name );
                        DeleteTableTablesListBox.Items.Add( name );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the data type combo boxes.
        /// </summary>
        public void PopulateComboBoxes( )
        {
            if( DataTypes?.Any( ) == true )
            {
                try
                {
                    EditColumnDataTypeComboBox.Items.Clear(  );
                    CreateTableDataTypeComboBox.Items.Clear(  );
                    foreach( var name in DataTypes )
                    {
                        EditColumnDataTypeComboBox.Items.Add( name );
                        CreateTableDataTypeComboBox.Items.Add( name );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [provider button checked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public virtual void OnProviderButtonChecked( object sender )
        {
            if( sender is RadioButton button )
            {
                try
                {
                    Provider = (Provider)Enum.Parse( typeof( Provider ), button.Tag.ToString( ) );
                    DataTypes = GetDataTypes( Provider );
                    PopulateComboBoxes( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }
        /// <summary>
        /// Sets the activet tab.
        /// </summary>
        public void SetActivetTab( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    switch( ToolType )
                    {
                        case ToolType.AddColumnButton:
                        {
                            EditColumnTabPage.Text = "Add Column";
                            ActiveTab = EditColumnTabPage;
                            EditColumnAccessRadioButton.Checked = true;
                            DeleteTableTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;
                            CreateTableTabPage.TabVisible = false;

                            break;
                        }
                        case ToolType.AddDatabaseButton:
                        {
                            CreateTableTabPage.Text = "Add Database";
                            ActiveTab = CreateTableTabPage;
                            CreateTableAccessRadioButton.Checked = true;
                            Provider = Provider.Access;
                            EditColumnTabPage.TabVisible = false;
                            DeleteTableTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;

                            break;
                        }
                        case ToolType.AddTableButton:
                        {
                            CreateTableTabPage.Text = "Add Table";
                            ActiveTab = CreateTableTabPage;
                            CreateTableAccessRadioButton.Checked = true;
                            Provider = Provider.Access;
                            EditColumnTabPage.TabVisible = false;
                            DeleteTableTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;

                            break;
                        }
                        case ToolType.EditColumnButton:
                        {
                            EditColumnTabPage.Text = "Rename Column";
                            ActiveTab = EditColumnTabPage;
                            EditColumnAccessRadioButton.Checked = true;
                            Provider = Provider.Access;
                            CreateTableTabPage.TabVisible = false;
                            DeleteTableTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;

                            break;
                        }
                        case ToolType.DeleteColumnButton:
                        {
                            DeleteColumnTabPage.Text = "Delete Column";
                            ActiveTab = DeleteColumnTabPage;
                            CreateTableTabPage.TabVisible = false;
                            DeleteTableTabPage.TabVisible = false;
                            EditColumnTabPage.TabVisible = false;

                            break;
                        }
                        case ToolType.DeleteTableButton:
                        {
                            DeleteTableTabPage.Text = "Delete Table";
                            ActiveTab = DeleteTableTabPage;
                            CreateTableTabPage.TabVisible = false;
                            EditColumnTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;

                            break;
                        }
                        case ToolType.DeleteDatabaseButton:
                        {
                            DeleteTableTabPage.Text = "Delete Database";
                            ActiveTab = DeleteTableTabPage;
                            CreateTableTabPage.TabVisible = false;
                            EditColumnTabPage.TabVisible = false;
                            DeleteColumnTabPage.TabVisible = false;

                            break;
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
            if( TabControl?.TabPages?.Count > 0 )
            {
                try
                {
                    var _listBoxes = new Dictionary<string, ListBox>( );

                    foreach( TabPageAdv _tabPage in TabControl.TabPages )
                    {
                        if( _tabPage?.Controls?.Any( ) == true )
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
                    Fail( ex );
                    return default( IDictionary<string, ListBox> );
                }
            }

            return default( IDictionary<string, ListBox> );
        }

        /// <summary>
        /// Gets the tab pages.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, TabPageAdv> GetTabPages( )
        {
            if( TabControl?.TabPages?.Any( ) == true )
            {
                try
                {
                    var _tabPages = new Dictionary<string, TabPageAdv>( );

                    foreach( TabPageAdv tabpage in TabControl.TabPages )
                    {
                        if( tabpage != null )
                        {
                            _tabPages.Add( tabpage.Name, tabpage );
                        }
                    }

                    return _tabPages?.Any( ) == true
                        ? _tabPages
                        : default( IDictionary<string, TabPageAdv> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, TabPageAdv> );
                }
            }

            return default( IDictionary<string, TabPageAdv> );
        }

        /// <summary>
        /// Gets the group boxes.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, GroupBox> GetGroupBoxes( )
        {
            if( TabControl?.TabPages?.Any( ) == true )
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
        /// Gets the radio buttons.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, RadioButton> GetRadioButtons( )
        {
            if( TabControl?.TabPages?.Any( ) == true )
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
                                            _radioButton.ForeColor = Color.FromArgb( 0, 120, 212 );
                                            _radioButton.CheckSignColor = Color.LimeGreen;
                                            _radioButton.CheckedChanged += OnProviderButtonChecked;
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
    }
}