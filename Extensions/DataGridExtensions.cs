// // <copyright file = "DataGridExtensions.cs" company = "Terry D. Eppler">
// // Copyright (c) Terry D. Eppler. All rights reserved.
// // </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public static class DataGridExtensions
    {
        /// <summary>
        /// The GetCurrentDataRow
        /// </summary>
        /// <param name="bindingSource">The bindingSource
        /// <see cref="System.Windows.Forms.BindingSource" /></param>
        /// <returns>
        /// The
        /// <see cref="DataRow" />
        /// </returns>
        public static DataRow GetCurrentDataRow( this BindingSource bindingSource )
        {
            try
            {
                return ( (DataRowView)bindingSource?.Current )?.Row;
            }
            catch( Exception ex )
            {
                DataGridExtensions.Fail( ex );
                return default( DataRow );
            }
        }

        /// <summary>
        /// The GetDataTable
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        /// <returns>
        /// The
        /// <see cref="DataTable" />
        /// </returns>
        public static DataTable GetDataTable( this DataGridView dataGridView )
        {
            try
            {
                DataTable _table = new DataTable( );

                foreach( DataGridViewColumn _column in dataGridView.Columns )
                {
                    _table.Columns.Add( new DataColumn
                    {
                        ColumnName = _column.Name,
                        DataType = _column.ValueType
                    } );
                }

                foreach( DataGridViewRow row in dataGridView.Rows )
                {
                    var _values = new object[ row.Cells.Count ];

                    for( int i = 0; i < _values.Length; i++ )
                    {
                        _values[ i ] = row.Cells[ i ].Value;
                    }

                    _table.Rows.Add( _values );
                }

                return _table;
            }
            catch( Exception ex )
            {
                DataGridExtensions.Fail( ex );
                return default( DataTable );
            }
        }

        /// <summary>
        /// The SetColumns
        /// </summary>
        /// <param name="dataGridView">The dataGridView</param>
        /// <param name="columns">The fields
        /// <see><cref> string[] </cref></see></param>
        /// <returns>
        /// The
        /// <see cref="DataTable" />
        /// </returns>
        public static DataTable SetColumns( this DataGridView dataGridView, string[ ] columns )
        {
            if( dataGridView?.DataSource != null
               && columns?.Length > 0 )
            {
                try
                {
                    DataTable _grid = dataGridView.GetDataTable( );
                    System.Data.DataView _view = new System.Data.DataView( _grid );

                    if( _grid?.Columns.Count > 0 )
                    {
                        DataTable _table = _view.ToTable( true, columns );

                        return _table?.Columns?.Count > 0
                            ? _table
                            : default( DataTable );
                    }
                }
                catch( Exception ex )
                {
                    DataGridExtensions.Fail( ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <summary>
        /// The SetColumns
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        /// <param name="fields">The fields
        /// <see /></param>
        /// <returns>
        /// The
        /// <see cref="DataTable" />
        /// </returns>
        public static DataTable SetColumns( this DataGridView dataGridView, Field[ ] fields )
        {
            if( dataGridView?.DataSource != null
               && fields?.Length > 0 )
            {
                try
                {
                    using( DataTable _dataTable = dataGridView.GetDataTable( ) )
                    {
                        using( System.Data.DataView _view = new System.Data.DataView( _dataTable ) )
                        {
                            if( _dataTable?.Columns?.Count > 0 )
                            {
                                var _columns =
                                    fields?.Select( f => f.ToString( ) )?.ToArray( );

                                DataTable _table = _view?.ToTable( true, _columns );

                                return _table?.Columns?.Count > 0
                                    ? _table
                                    : default( DataTable );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    DataGridExtensions.Fail( ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <summary>
        /// The SetColumns
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        /// <param name="index">The index
        /// <see /></param>
        /// <returns>
        /// The
        /// <see cref="DataTable" />
        /// </returns>
        public static DataTable SetColumns( this DataGridView dataGridView, int[ ] index )
        {
            try
            {
                using( DataTable _dataTable = dataGridView?.GetDataTable( ) )
                {
                    if( _dataTable?.Columns?.Count > 0
                       && index?.Length > 0 )
                    {
                        DataColumnCollection _columns = _dataTable.Columns;
                        var _names = new string[ index.Length ];

                        if( _columns?.Count > 0
                           && _names?.Length > 0 )
                        {
                            for( int i = 0; i < index.Length; i++ )
                            {
                                _names[ i ] = _columns[ index[ i ] ].ColumnName;
                            }
                        }

                        using( System.Data.DataView _view = new System.Data.DataView( _dataTable ) )
                        {
                            DataTable _table = _view?.ToTable( true, _names );

                            return _table.Columns.Count > 0
                                ? _table
                                : default( DataTable );
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                DataGridExtensions.Fail( ex );
                return default( DataTable );
            }

            return default( DataTable );
        }

        /// <summary>
        /// The CommaDelimitedRows
        /// </summary>
        /// <param name="datagridview">The dataGridView
        /// <see cref="DataGridView" /></param>
        /// <returns>
        /// The
        /// <see />
        /// </returns>
        public static string[ ] CommaDelimitedRows( this DataGridView datagridview )
        {
            if( datagridview?.RowCount > 0 )
            {
                try
                {
                    var _list = new List<string>( );

                    foreach( object _row in datagridview.Rows )
                    {
                        if( !( (DataGridViewRow)_row )?.IsNewRow == true )
                        {
                            var _cells = ( (DataGridViewRow)_row )?.Cells
                                ?.Cast<DataGridViewCell>( )
                                ?.ToArray( );

                            var _array = ( (DataGridViewRow)_row )?.Cells
                                ?.Cast<DataGridViewCell>( )
                                ?.ToArray( );

                            if( _cells?.Any( ) == true )
                            {
                                string _item = string.Join( ",",
                                    Array.ConvertAll( _array, c => c.Value?.ToString( ) ) );

                                if( !string.IsNullOrEmpty( _item ) )
                                {
                                    _list?.Add( _item );
                                }
                            }
                        }
                    }

                    return _list?.Any( ) == true
                        ? _list.ToArray( )
                        : default( string[ ] );
                }
                catch( Exception ex )
                {
                    DataGridExtensions.Fail( ex );
                    return default( string[ ] );
                }
            }

            return default( string[ ] );
        }

        /// <summary>
        /// The ExportToCommaDelimitedFile
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        /// <param name="fileName">The fileName
        /// <see cref="string" /></param>
        public static void ExportToCommaDelimitedFile( this DataGridView dataGridView,
            string fileName )
        {
            if( !string.IsNullOrEmpty( fileName )
               && dataGridView != null )
            {
                try
                {
                    string _path = Path.Combine( AppDomain.CurrentDomain.BaseDirectory, fileName );

                    if( !string.IsNullOrEmpty( _path ) )
                    {
                        File.WriteAllLines( _path, dataGridView.CommaDelimitedRows( ) );
                    }
                }
                catch( Exception ex )
                {
                    DataGridExtensions.Fail( ex );
                }
            }
        }

        /// <summary>
        /// The ExpandColumns
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        public static void ExpandColumns( this DataGridView dataGridView )
        {
            try
            {
                foreach( DataGridViewColumn _column in dataGridView.Columns )
                {
                    _column.AutoSizeMode = DataGridViewAutoSizeColumnMode.DisplayedCells;
                }
            }
            catch( Exception ex )
            {
                DataGridExtensions.Fail( ex );
            }
        }

        /// <summary>
        /// The PascalizeHeaders
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        /// <param name="dataTable">The dataTable
        /// <see cref="DataTable" /></param>
        public static void PascalizeHeaders( this DataGridView dataGridView, DataTable dataTable )
        {
            if( dataGridView != null
               && dataTable?.Columns?.Count > 0 )
            {
                try
                {
                    foreach( DataGridViewColumn column in dataGridView.Columns )
                    {
                        if( !string.IsNullOrEmpty( dataTable.Columns[ column.Name ].Caption ) )
                        {
                            column.HeaderText = dataTable.Columns[ column.Name ].Caption;
                        }
                    }
                }
                catch( Exception ex )
                {
                    DataGridExtensions.Fail( ex );
                }
            }
        }

        /// <summary>
        /// The PascalizeHeaders
        /// </summary>
        /// <param name="dataGridView">The dataGridView
        /// <see cref="DataGridView" /></param>
        public static void PascalizeHeaders( this DataGridView dataGridView )
        {
            if( dataGridView?.DataSource != null )
            {
                try
                {
                    using( DataTable _table = dataGridView.GetDataTable( ) )
                    {
                        if( _table?.Columns?.Count > 0 )
                        {
                            foreach( DataGridViewColumn _column in dataGridView.Columns )
                            {
                                if( !string.IsNullOrEmpty( _table.Columns[ _column.Name ]
                                       .Caption ) )
                                {
                                    _column.HeaderText = _table.Columns[ _column.Name ].Caption;
                                }
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    DataGridExtensions.Fail( ex );
                }
            }
        }

        /// <summary>Fails the specified ex.</summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using( Error _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}