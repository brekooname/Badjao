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
    using Syncfusion.Data.Extensions;

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
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        public DataRow Record { get; set; }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        public ISeriesConfig SeriesConfig { get; set; }

        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public IDataMetric DataMetric { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

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
        public IDictionary<string, object> Criteria { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BindingSource" />
        /// class.
        /// </summary>
        public ChartBinding()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ChartBinding( BindingSource bindingSource )
        {
            BindingSource = bindingSource;
            Data = ( (DataTable)bindingSource.DataSource ).AsEnumerable(  );
            DataTable = (DataTable)bindingSource.DataSource;
            Source = (Source)Enum.Parse( typeof( Source ), ( (DataTable)bindingSource.DataSource ).TableName );
            DataSet = ( (DataTable)bindingSource.DataSource )?.DataSet;
            SeriesConfig = new SeriesConfig( );
            Record = bindingSource.GetCurrentDataRow( );
            AllowNew = true;
            Count = BindingSource.Count;
            SeriesConfig = new SeriesConfig( );
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding"/> class.
        /// </summary>
        /// <param name="bindingList">The binding list.</param>
        [SuppressMessage( "ReSharper", "SuggestBaseTypeForParameter" ) ]
        public ChartBinding( IBindingList bindingList )
        {
            BindingSource = new BindingSource
            {
                DataSource = bindingList
            };

            Data = ( (DataTable)BindingSource.DataSource ).AsEnumerable( );
            DataTable = (DataTable)BindingSource.DataSource;
            SeriesConfig = new SeriesConfig( );
            Source = (Source)Enum.Parse( typeof( Source ), ( (DataTable)BindingSource.DataSource ).TableName );
            DataSet = ( (DataTable)BindingSource.DataSource )?.DataSet;
            Record = BindingSource.GetCurrentDataRow( );
            AllowNew = true;
            Count = BindingSource.Count;
            SeriesConfig = new SeriesConfig( );
            Changed += OnCurrentChanged;
        }

        public ChartBinding( DataSet dataSet )
        {
            BindingSource = new BindingSource
            {
                DataSource = dataSet
            };

            Data = dataSet.Tables[ 0 ]?.Rows.ToList<DataRow>();
            DataTable = dataSet.Tables[ 0 ];
            SeriesConfig = new SeriesConfig( );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataSet = dataSet;
            Record = DataTable.Rows[ 0 ];
            AllowNew = true;
            SeriesConfig = new SeriesConfig( );
            Count = BindingSource.Count;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public ChartBinding( DataTable dataTable )
        {
            BindingSource = new BindingSource( );
            Data = dataTable.AsEnumerable( );
            SeriesConfig = new SeriesConfig( );
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            DataTable = dataTable;
            DataSet = dataTable.DataSet;
            BindingSource.DataSource = dataTable;
            DataSource = dataTable;
            Record = (DataRow)Current;
            AllowNew = true;
            Count = BindingSource.Count;
            Changed += OnCurrentChanged;
        }

        public ChartBinding( IEnumerable<DataRow> data )
        {
            BindingSource = new BindingSource( );
            Data = data;
            SeriesConfig = new SeriesConfig( );
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataTable = data.CopyToDataTable( );
            DataSet = DataTable.DataSet;
            BindingSource.DataSource = DataTable;
            DataSource = DataTable;
            Record = (DataRow)Current;
            AllowNew = true;
            Count = BindingSource.Count;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding" /> class.
        /// </summary>
        /// <param name="dataTable">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public ChartBinding( DataTable dataTable, ISeriesConfig seriesConfig ) 
            : this( dataTable )
        {
            SeriesConfig = seriesConfig;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartBinding" />
        /// class.
        /// </summary>
        /// <param name="dataRows">The data.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public ChartBinding( IEnumerable<DataRow> dataRows, ISeriesConfig seriesConfig ) 
            : this( dataRows )
        {
            SeriesConfig = seriesConfig;
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
                var _numeric = SeriesConfig?.Numeric;
                return double.Parse( Record[ $"{ _numeric }" ].ToString( ) ) > 0;
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
                var _numeric = SeriesConfig?.Numeric;

                return !GetEmpty( xIndex )
                    ? double.Parse( Record[ $"{ _numeric }" ].ToString( ) )
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
                var _numeric = SeriesConfig?.Numeric;

                return !GetEmpty( xIndex )
                    ? double.Parse( Record[ $@"{ _numeric }" ].ToString( ) )
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
                    var _message = new Message( "NOT YET IMPLEMENTED" );
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
        /// <param name="bindingSource">The bindingsource.</param>
        public void SetDataSource<T1>( T1 bindingSource )
            where T1 : IBindingList
        {
            try
            {
                if( bindingSource is BindingSource binding
                    && binding?.DataSource != null )
                {
                    try
                    {
                        BindingSource.DataSource = binding.DataSource;
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
                        var _list = bindingList as BindingSource;
                        var _filter = string.Empty;

                        foreach( var _kvp in dict )
                        {
                            if( !string.IsNullOrEmpty( _kvp.Key )
                                && Verify.IsRef( _kvp.Value ) )
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
                    var _filter = string.Empty;

                    foreach( var _kvp in dict )
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
        /// Sets the bindings.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param>The numeric.</param>
        /// <param name = "dict" > </param>
        public void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<DataRow>
            where T2 : IDictionary<string, object>
        {
            if( data?.Any( ) == true
                && dict?.Any( ) == true )
            {
                try
                {
                    var _filter = string.Empty;

                    foreach( var _kvp in dict )
                    {
                        if( !string.IsNullOrEmpty( _kvp.Key )
                            && _kvp.Value != null )
                        {
                            _filter += $"{ _kvp.Key } = { _kvp.Value } AND";
                        }
                    }

                    BindingSource.DataSource = data?.ToList( );
                    BindingSource.Filter = _filter?.TrimEnd( " AND".ToCharArray( ) );
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
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}