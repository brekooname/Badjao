namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Linq;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Microsoft.EntityFrameworkCore.Internal;
    using Syncfusion.Data.Extensions;
    using Syncfusion.Linq;
    using Syncfusion.Windows.Forms.Tools;

    [SuppressMessage( "ReSharper", "UnusedParameter.Global" )]
    public partial class EditDialog : EditBase
    {
        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Gets or sets the current.
        /// </summary>
        /// <value>
        /// The current.
        /// </value>
        public DataRow Current { get; set; }

        public DataTable DataTable { get; set; }

        public IEnumerable<string> Columns { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        public EditDialog( )
        {
            InitializeComponent( );
            TabPages = GetTabPages( );
            Labels = GetLabels( );
            TextBoxes = GetTextBoxes( );
            TabControl.TabPanelBackColor = Color.FromArgb( 15, 15, 15 );
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        public EditDialog( ToolType toolType ) 
            : this( )
        {
            ToolType = toolType;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="bindingSource">The binding source.</param>
        public EditDialog( ToolType toolType, BindingSource bindingSource )
            : this( )
        {
            ToolType = toolType;
            BindingSource = bindingSource;
            Current = BindingSource.GetCurrentDataRow( );
            DataTable = (DataTable)BindingSource.DataSource;
            Columns = DataTable.GetColumnNames(  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="dataModel">The data model.</param>
        public EditDialog( ToolType toolType, DataBuilder dataModel )
            : this( )
        {
            ToolType = toolType;
            DataModel = dataModel;
            Provider = dataModel.Provider;
            Source = dataModel.Source;
            CommandType = dataModel.SqlStatement.CommandType;
            BindingSource.DataSource = dataModel.DataTable;
            Current = BindingSource.GetCurrentDataRow( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        public EditDialog( ToolType toolType, Source source, Provider provider = Provider.Access )
            : this( )
        {
            ToolType = toolType;
            Provider = provider;
            Source = source;
            DataModel = new DataBuilder( source, provider );
            BindingSource.DataSource = DataModel.DataTable;
            Current = BindingSource.GetCurrentDataRow( );
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SetActivetTab( );
                SetBindings( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public void SetActivetTab( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    switch( ToolType )
                    {
                        case ToolType.EditRecordButton:
                        {
                            DataTab.Text = "Edit Data Record";
                            ActiveTab = DataTab;
                            SelectButton.Text = "Save";
                            SqlTab.TabVisible = false;

                            break;
                        }
                        case ToolType.CopyButton:
                        {
                            DataTab.Text = "Edit/Save Copied Data";
                            ActiveTab = DataTab;
                            SelectButton.Text = "Save";
                            SqlTab.TabVisible = false;

                            break;
                        }
                        case ToolType.DeleteRecordButton:
                        {
                            DataTab.Text = "Delete Data";
                            ActiveTab = DataTab;
                            SelectButton.Text = "Delete";
                            SqlTab.TabVisible = false;

                            break;
                        }
                        case ToolType.EditSqlButton:
                        {
                            SqlTab.Text = "Edit SQL";
                            ActiveTab = SqlTab;
                            SelectButton.Text = "Save";
                            DataTab.TabVisible = false;

                            break;
                        }
                        default:
                        {
                            DataTab.Text = "Edit Data Record";
                            ActiveTab = DataTab;
                            SelectButton.Text = "Save";
                            SqlTab.TabVisible = false;

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

        public void SetBindings( )
        {
            Label0.Text = "ID: " + Current[ 0 ];
            var _label = Labels.Skip( 1 )?.ToArray( );
            var _textBox = TextBoxes.ToArray( );
            var _items = Current.ItemArray.Skip( 1 ).ToArray(  );
            var _columns = Current.Table.GetColumnNames( ).Skip( 1 );
            var _header = _columns.ToArray( );

            for( var i = 0; i < _items.Length; i++ )
            {
                _label[ i ].Text = _header[ i ];
                _textBox[ i ].Text = _items[ i ].ToString( );
            }

        }

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        public virtual void SetDataSource( IEnumerable<DataRow> dataRows )
        {
            try
            {
                if( dataRows?.Any( ) == true )
                {
                    try
                    {
                        BindingSource.DataSource = dataRows;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the data source.
        /// </summary>
        /// <param name="source">The source.</param>
        public virtual void SetDataSource( IListSource source )
        {
            try
            {
                if( source?.ContainsListCollection == true )
                {
                    try
                    {
                        BindingSource.DataSource = source.GetList( );
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
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
        /// Gets the edit labels.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Label> GetLabels( )
        { 
            try
            {
                var _labels = new List<Label>( );
                foreach( var _control in TableFrame.Controls )
                {
                    if( _control.GetType(   ) == typeof( Label ) )
                    {
                        _labels.Add( _control as Label );
                    }
                }

                return _labels?.Any(  ) == true
                    ? _labels
                    : default( IEnumerable<Label> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<Label> );
            }
        }

        /// <summary>
        /// Gets the text boxes.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TextBox> GetTextBoxes()
        {
            try
            {
                var _textBoxes = new List<TextBox>( );
                foreach( var _control in TableFrame.Controls )
                {
                    if( _control.GetType( ) == typeof( TextBox ) )
                    {
                        _textBoxes.Add( _control as TextBox );
                    }
                }

                return _textBoxes?.Any( ) == true
                    ? _textBoxes
                    : default( IEnumerable<TextBox> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<TextBox> );
            }
        }
    }
}
