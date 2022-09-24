// <copyright file = "ChartBinding.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;
    using DataTable = System.Data.DataTable;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BindingSource" />
    /// <seealso cref="IChartBinding" />
    /// <seealso cref="IChartSeriesModel" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class ChartBinding : BindingSource, IChartBinding
    {
        /// <summary>
        /// Gets or sets the chart handler.
        /// </summary>
        /// <value>
        /// The chart handler.
        /// </value>
        public ListChangedEventHandler ChartHandler { get; set; }

        /// <summary>
        /// Occurs when [changed].
        /// </summary>
        public event ListChangedEventHandler Changed;

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

        /// <summary>
        /// Gets the total number of items in the underlying list, 
        /// taking the current 
        /// <see cref="P:System.Windows.Forms.BindingSource.Filter" /> value into consideration.
        /// </summary>
        public new int Count { get; set; }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets or sets the data set.
        /// </summary>
        /// <value>
        /// The data set.
        /// </value>
        public DataSet DataSet { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        public DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public string TableName { get; set; }

        /// <summary>
        /// Gets or sets the binding list.
        /// </summary>
        /// <value>
        /// The binding list.
        /// </value>
        public BindingList<DataRow> BindingList { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BindingSource" />
        /// class.
        /// </summary>
        public ChartBinding( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ChartBinding( BindingSource bindingSource )
        {
            BindingSource = bindingSource;
            DataTable = (DataTable)bindingSource.DataSource;
            DataSet = ( (DataTable)bindingSource.DataSource ).DataSet;

            Source = (Source)Enum.Parse( typeof( Source ),
                ( (DataTable)bindingSource.DataSource ).TableName );

            Data = ( (DataTable)bindingSource.DataSource ).AsEnumerable( );
            BindingList = Data.ToBindingList( );
            BindingSource.DataSource = BindingList;
            TableName = Source.ToString( );
            DataMember = TableName;
            Record = bindingSource.GetCurrentDataRow( );
            DataSource = bindingSource;
            AllowNew = true;
            Count = BindingSource.Count;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding"/> class.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        public ChartBinding( DataSet dataSet )
        {
            DataSet = dataSet;
            Source = (Source)Enum.Parse( typeof( Source ), dataSet.Tables[ 0 ].TableName );
            BindingSource = new BindingSource { DataSource = dataSet.Tables[ $"{Source}" ] };

            DataTable = dataSet.Tables[ $"{Source}" ];
            TableName = Source.ToString( );
            DataMember = TableName;
            DataSource = dataSet.Tables[ $"{Source}" ];
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            Data = dataSet.Tables[ $"{Source}" ]?.AsEnumerable( );
            BindingList = Data.ToBindingList( );
            Record = BindingSource.GetCurrentDataRow( );
            AllowNew = true;
            Count = BindingSource.Count;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public ChartBinding( DataTable dataTable )
        {
            BindingSource = new BindingSource { DataSource = dataTable };

            Data = dataTable.AsEnumerable( );
            BindingList = Data.ToBindingList( );
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            DataTable = dataTable;
            DataSource = dataTable;
            TableName = Source.ToString( );
            DataSource = DataTable;
            DataSet = dataTable.DataSet;
            Record = BindingSource.GetCurrentDataRow( );
            AllowNew = true;
            Count = BindingSource.Count;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        public ChartBinding( IEnumerable<DataRow> dataRows )
        {
            BindingSource = new BindingSource { DataSource = dataRows.CopyToDataTable( ) };

            Data = dataRows;
            BindingList = dataRows.ToBindingList( );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataTable = dataRows.CopyToDataTable( );
            TableName = Source.ToString( );
            DataSource = DataTable.ToBindingList( );
            DataSet = DataTable.DataSet;
            Record = BindingSource.GetCurrentDataRow( );
            AllowNew = true;
            Count = BindingSource.Count;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="dict">The dictionary.</param>
        public ChartBinding( BindingSource bindingSource, IDictionary<string, object> dict )
        {
            BindingSource = bindingSource;
            DataFilter = dict;

            Source = (Source)Enum.Parse( typeof( Source ),
                ( (DataTable)bindingSource.DataSource ).TableName );

            DataSet = ( (DataTable)bindingSource.DataSource ).DataSet;
            DataTable = (DataTable)bindingSource.DataSource;
            Data = DataTable.Select( dict.ToCriteria( ) );
            BindingList = Data.ToBindingList( );
            BindingSource.DataSource = BindingList;
            DataSource = (DataTable)bindingSource.DataSource;
            TableName = Source.ToString( );
            DataMember = TableName;

            Source = (Source)Enum.Parse( typeof( Source ),
                ( (DataTable)bindingSource.DataSource ).TableName );

            Record = bindingSource.GetCurrentDataRow( );
            AllowNew = true;
            Count = BindingSource.Count;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        /// <param name="dict">The dictionary.</param>
        public ChartBinding( DataTable dataTable, IDictionary<string, object> dict )
        {
            BindingSource = new BindingSource
                { DataSource = dataTable.Select( dict.ToCriteria( ) ) };

            DataFilter = dict;
            Data = dataTable.Select( dict.ToCriteria( ) );
            DataTable = Data.CopyToDataTable( );
            BindingList = Data.ToBindingList( );
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            DataSource = dataTable;
            TableName = dataTable.ToString( ) ?? Source.ToString( );
            DataSource = DataTable.ToBindingList( );
            DataSet = dataTable.DataSet;
            Record = BindingSource.GetCurrentDataRow( );
            AllowNew = true;
            Count = BindingSource.Count;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        /// <param name="dict">The dictionary.</param>
        public ChartBinding( IEnumerable<DataRow> dataRows, IDictionary<string, object> dict )
        {
            BindingSource = new BindingSource { DataSource = dataRows.CopyToDataTable( ) };

            DataFilter = dict;
            Data = dataRows.Filter( dict );
            BindingList = Data.ToBindingList( );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataTable = Data.CopyToDataTable( );
            TableName = Source.ToString( );
            DataSource = DataTable.ToBindingList( );
            DataSet = DataTable.DataSet;
            Record = BindingSource.GetCurrentDataRow( );
            AllowNew = true;
            Count = BindingSource.Count;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Gets the empty.
        /// </summary>
        /// <param name="xIndex">The xIndex.</param>
        /// <returns></returns>
        public bool GetEmpty( int xIndex )
        {
            try
            {
                return double.Parse( Record[ $"{Numeric}" ].ToString( ) ) > 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return false;
            }
        }

        /// <summary>
        /// Gets the x.
        /// </summary>
        /// <param name="xIndex">The xIndex.</param>
        /// <returns></returns>
        public double GetX( int xIndex )
        {
            try
            {
                return !GetEmpty( xIndex )
                    ? double.Parse( Record[ $"{Numeric}" ].ToString( ) )
                    : 0d;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0d;
            }
        }

        /// <summary>
        /// Gets the y.
        /// </summary>
        /// <param name="xIndex">The xIndex.</param>
        /// <returns></returns>
        public double GetY( int xIndex )
        {
            try
            {
                return !GetEmpty( xIndex )
                    ? double.Parse( Record[ $@"{Numeric}" ].ToString( ) )
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="ListChangedEventArgs" />
        /// instance containing the event data.</param>
        public void OnCurrentChanged( object sender, ListChangedEventArgs e )
        {
            if( sender != null
                && e != null )
            {
                try
                {
                    Message _message = new Message( "NOT YET IMPLEMENTED" );
                    _message?.ShowDialog( );
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
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="bindingList">The bindingsource.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetDataSource<T1, T2>( T1 bindingList, T2 dict )
            where T1 : IBindingList
            where T2 : IDictionary<string, object>
        {
            try
            {
                if( bindingList?.IsEmpty( ) != true
                    && dict?.Any( ) == true )
                {
                    try
                    {
                        BindingSource _list = bindingList as BindingSource;
                        string _filter = string.Empty;

                        foreach( KeyValuePair<string, object> _kvp in dict )
                        {
                            if( !string.IsNullOrEmpty( _kvp.Key )
                                && _kvp.Value != null )
                            {
                                _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                            }
                        }

                        if( _filter?.Length > 0
                            && _list?.DataSource != null )
                        {
                            BindingSource.DataSource = _list?.DataSource;
                            BindingSource.Filter = _filter?.TrimEnd( " AND".ToCharArray( ) );
                        }
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
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<DataRow>
        {
            if( data?.Any( ) == true )
            {
                try
                {
                    string _filter = string.Empty;

                    foreach( KeyValuePair<string, object> _kvp in dict )
                    {
                        if( !string.IsNullOrEmpty( _kvp.Key )
                            && _kvp.Value != null )
                        {
                            _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                        }
                    }

                    BindingSource.DataSource = data?.ToList( );
                    BindingSource.Filter = _filter.TrimEnd( " AND".ToCharArray( ) );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        private void Fail( Exception ex )
        {
            using( Error _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}