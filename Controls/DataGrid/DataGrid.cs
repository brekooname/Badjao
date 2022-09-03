﻿// <copyright file = "BudgetDataGrid.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DataGridView" />
    /// <seealso/>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    [SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" )]
    public class DataGrid : DataGridView, IDataGrid
    {
        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGrid" />
        /// class.
        /// </summary>
        public DataGrid()
        {
            EnableHeadersVisualStyles = false;
            ForeColor = Color.LightSteelBlue;
            Font = new Font( "Roboto", 8 );
            Margin = new Padding( 3 );
            Padding = new Padding( 1 );
            Size = new Size( 906, 527 );
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            BackColor = Color.FromArgb( 55, 55, 55 );
            BorderStyle = BorderStyle.None;
            CellBorderStyle = DataGridViewCellBorderStyle.Single;
            BackgroundColor = Color.FromArgb( 55, 55, 55 );
            GridColor = Color.FromArgb( 141, 139, 138 );
            SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.ColumnHeader;
            AllowUserToOrderColumns = true;

            // Default Cell Style
            DefaultCellStyle.BackColor = Color.FromArgb( 55, 55, 55 );
            DefaultCellStyle.ForeColor = Color.LightSteelBlue;
            DefaultCellStyle.SelectionBackColor = Color.FromArgb( 22, 39, 70 );
            DefaultCellStyle.SelectionForeColor = Color.White;
            DefaultCellStyle.Font = new Font( "Roboto", 8, FontStyle.Regular );

            // Column SeriesConfiguration
            ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ColumnHeadersHeight = 30;
            ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            ColumnHeadersDefaultCellStyle.BackColor = Color.SteelBlue;
            ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            ColumnHeadersDefaultCellStyle.SelectionBackColor = Color.FromArgb( 22, 39, 70 );
            ColumnHeadersDefaultCellStyle.SelectionForeColor = Color.White;
            ColumnHeadersDefaultCellStyle.Font = new Font( "Roboto", 8, FontStyle.Regular );


            // Row SeriesConfiguration
            RowHeadersWidth = 20;
            RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            RowHeadersDefaultCellStyle.BackColor = Color.FromArgb( 22, 39, 70 );
            RowHeadersDefaultCellStyle.Font = new Font( "Roboto", 8, FontStyle.Regular );
            RowHeadersDefaultCellStyle.ForeColor = Color.Black;
            RowHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.BottomCenter;
            RowHeadersDefaultCellStyle.SelectionBackColor = Color.SteelBlue;
            CellBorderStyle = DataGridViewCellBorderStyle.None;
            AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.None;
            RowsDefaultCellStyle.BackColor = Color.FromArgb( 55, 55, 55 );
            RowsDefaultCellStyle.Font = new Font( "Roboto", 8 );
            RowsDefaultCellStyle.ForeColor = Color.LightSteelBlue;
            RowsDefaultCellStyle.SelectionBackColor = Color.FromArgb( 22, 39, 70 );
            RowsDefaultCellStyle.SelectionForeColor = Color.White;
            RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb( 55, 55, 55 );
            AlternatingRowsDefaultCellStyle.ForeColor = Color.LightSteelBlue;
            AlternatingRowsDefaultCellStyle.Font = new Font( "Roboto", 8 );
            AlternatingRowsDefaultCellStyle.SelectionBackColor = Color.FromArgb( 22, 39, 70 );
            AlternatingRowsDefaultCellStyle.SelectionForeColor = Color.White;

            // Epilog
            Visible = true;
            Enabled = true;
            ColumnHeaderMouseClick += OnRightClick;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGrid" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        public DataGrid( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = location;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataGrid"/> class.
        /// </summary>
        /// <param name="dataGrid">The dataGrid.</param>
        [SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" )]
        public DataGrid( DataGridView dataGrid )
            : this( dataGrid.Size, dataGrid.Location )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="DataGrid" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        public DataGrid( Size size, Point location, Control parent )
            : this( size, location )
        {
            Parent = parent;
        }

        /// <summary>
        /// Sets the column configuration.
        /// </summary>
        public void SetColumnConfiguration( )
        {
            try
            {
                ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    Font = new Font( "Roboto", 11, FontStyle.Bold ),
                    Alignment = DataGridViewContentAlignment.MiddleCenter,
                    ForeColor = Color.Black,
                    BackColor = Color.SteelBlue
                };
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the row configuration.
        /// </summary>
        public void SetRowConfiguration( )
        {
            try
            {
                RowHeadersDefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.BottomCenter,
                    ForeColor = Color.Black,
                    Font = new Font( "Roboto", 9, FontStyle.Bold ),
                    BackColor = Color.FromArgb( 141, 139, 138 )
                };

                RowsDefaultCellStyle = new DataGridViewCellStyle
                {
                    Alignment = DataGridViewContentAlignment.BottomCenter,
                    SelectionForeColor = Color.Black,
                    SelectionBackColor = SystemColors.ControlLight,
                    ForeColor = Color.Black,
                    Font = new Font( "Roboto", 9 ),
                    BackColor = Color.LightSteelBlue
                };
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="dataRows">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetBindingSource( IEnumerable<DataRow> dataRows, IDictionary<string, object> dict )
        {
            if( dataRows?.Any( ) == true
                && dict?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( BindingSource.Filter ) )
                    {
                        BindingSource.RemoveFilter( );
                    }

                    BindingSource.DataSource = dataRows.CopyToDataTable( );
                    BindingSource.Filter = GetFilterValues( dict );
                    DataSource = BindingSource;
                    PascalizeHeaders( dataRows );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingSource">The bindingSource.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetBindingSource( BindingSource bindingSource, IDictionary<string, object> dict )
        {
            if( bindingSource?.DataSource != null
                && dict?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( bindingSource.Filter ) )
                    {
                        bindingSource.RemoveFilter( );
                    }

                    bindingSource.DataSource = ( bindingSource.DataSource as IEnumerable<DataRow> )
                        ?.CopyToDataTable( );

                    bindingSource.Filter = GetFilterValues( dict );
                    DataSource = BindingSource;
                    PascalizeHeaders( BindingSource.DataSource as IEnumerable<DataRow> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Pascalizes the headers.
        /// </summary>
        /// <param name="dataRows">The data.</param>
        public void PascalizeHeaders( IEnumerable<DataRow> dataRows )
        {
            if( dataRows?.Any( ) == true )
            {
                try
                {
                    if( dataRows?.CopyToDataTable( )?.Columns?.Count > 0 )
                    {
                        foreach( DataColumn _dataColumn in dataRows.CopyToDataTable( ).Columns )
                        {
                            foreach( DataGridViewColumn _gridViewColumn in Columns )
                            {
                                _gridViewColumn.HeaderText = _dataColumn.Caption;
                            }
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
        /// Gets the filter values.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public string GetFilterValues( IDictionary<string, object> dict )
        {
            {
                if( dict?.Any( ) == true )
                {
                    try
                    {
                        var _vals = string.Empty;

                        foreach( var _kvp in dict )
                        {
                            _vals += $"{ _kvp.Key } = '{ _kvp.Value }' AND ";
                        }

                        return _vals.Trim( ).Substring( 0, _vals.Length - 4 );
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                        return default( string );
                    }
                }

                return default( string );
            }
        }

        /// <summary>
        /// Gets the current data row.
        /// </summary>
        /// <returns></returns>
        public DataRow GetCurrentDataRow( )
        {
            try
            {
                using( var _message = new Message( "Not Yet Implemented." ) )
                {
                    _message?.ShowDialog( );
                }

                return default( DataRow );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DataRow );
            }
        }

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="DataGridViewCellMouseEventArgs" /> instance containing the event data.</param>
        public void OnRightClick( object sender, DataGridViewCellMouseEventArgs e )
        {
            if( e.Button == MouseButtons.Right )
            {
                try
                {
                   var _ = new ColumnConfiguration( this );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}