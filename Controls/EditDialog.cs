﻿namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Microsoft.EntityFrameworkCore.Internal;
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

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        public IEnumerable<string> Columns { get; set; }

        /// <summary>
        /// Gets or sets the frames.
        /// </summary>
        /// <value>
        /// The frames.
        /// </value>
        public IEnumerable<Frame> Frames { get;set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        public EditDialog( )
        {
            InitializeComponent( );
            TabPages = GetTabPages( );
            Frames = GetFrames( );
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
            DataTable = (DataTable)bindingSource.DataSource;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataModel = new DataBuilder( Source, Provider.Access );
            Columns = DataTable.GetColumnNames( );
            Current = bindingSource.GetCurrentDataRow( );
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
            DataTable = dataModel.DataTable;
            Columns = DataTable.GetColumnNames( );
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
            DataTable = DataModel.DataTable;
            BindingSource.DataSource = DataModel.DataTable;
            Columns = DataTable.GetColumnNames( );
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
                SetFrameVisibility( );
                SetTableLocation( );
                BindRecordData( );
            }
            catch( Exception ex )
            {
                Fail( ex );
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
                        case ToolType.CopyButton:
                        case ToolType.EditRecordButton:
                        {
                            DataTab.Text = "Edit Data";
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
                            SqlTab.Text = "SQL Editor";
                            ActiveTab = SqlTab;
                            SelectButton.Text = "Save";
                            DataTab.TabVisible = false;
                            break;
                        }
                        default:
                        {
                            DataTab.Text = "Edit Data";
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

        /// <summary>
        /// Sets the frame visibility.
        /// </summary>
        public void SetFrameVisibility( )
        {
            try
            {
                var _cols = Columns.ToArray( );
                foreach( var _frame in Frames )
                {
                    if( _frame.Index > _cols.Length - 1 )
                    {
                        _frame.Visible = false;
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the row location.
        /// </summary>
        public void SetTableLocation(  )
        {
            if( FrameTable != null )
            {
                try
                {

                    var _cols = Columns.ToArray( );
                    if( _cols.Length >= 43 )
                    {
                        FrameTable.RowCount = 7;
                        FrameTable.Size = new Size( 1362, 399 );
                        FrameTable.Location = new Point( 12, 25 );
                    }
                    else if( _cols.Length < 43 && _cols.Length >= 35 )
                    {
                        FrameTable.RowCount = 6;
                        FrameTable.Size = new Size( 1362, 364 );
                        FrameTable.Location = new Point( 12, 45 );
                    }
                    else if( _cols.Length < 35 && _cols.Length >= 28 )
                    {
                        FrameTable.RowCount = 5;
                        FrameTable.Size = new Size( 1362, 300 );
                        FrameTable.Location = new Point( 12, 85 );
                    }
                    else if( _cols.Length < 28 && _cols.Length >= 21 )
                    {
                        FrameTable.RowCount = 4;
                        FrameTable.Size = new Size( 1362, 300 );
                        FrameTable.Location = new Point( 12, 105 );
                    }
                    else if( _cols.Length < 21 && _cols.Length >= 14 )
                    {
                        FrameTable.RowCount = 3;
                        FrameTable.Size = new Size( 1362, 225 );
                        FrameTable.Location = new Point( 12, 125 );
                    }
                    else if( _cols.Length < 14 && _cols.Length > 7 )
                    {
                        FrameTable.RowCount = 2;
                        FrameTable.Location = new Point( 12, 125 );
                        FrameTable.Size = new Size( 1362, 225 );
                    }
                    else if( _cols.Length <= 7 )
                    {
                        FrameTable.RowCount = 1;
                        FrameTable.Location = new Point( 12, 125 );
                        FrameTable.Size = new Size( 1362, 255 );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Binds the record data.
        /// </summary>
        public void BindRecordData( )
        {
            try
            {
                var _items = Current.ItemArray;
                var _frames = Frames.ToArray( );
                var _cols = Columns.ToArray( );
                for( var i = 0; i < _cols.Length; i++ )
                {
                    if( _frames[ i ].Index == i )
                    {
                        _frames[ i ].Label.Text = _cols[ i ].SplitPascal(  );
                        _frames[ i ].TextBox.Text = _items[ i ].ToString( );
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
        /// Gets the frames.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Frame> GetFrames( )
        {
            try
            {
                var _frames = new List<Frame>( );
                var _counter = 0;
                foreach( var _control in FrameTable.Controls )
                {
                    if( _control.GetType( ) == typeof( Frame ) )
                    {
                        if( _control is Frame _frame )
                        {
                            _frame.Index = _counter;
                            _frame.BindingSource = BindingSource;
                            _frames.Add( _control as Frame );
                            _counter++;
                        }

                    }
                }

                return _frames?.Any( ) == true
                    ? _frames
                    : default( IEnumerable<Frame> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<Frame> );
            }
        }
    }
}
