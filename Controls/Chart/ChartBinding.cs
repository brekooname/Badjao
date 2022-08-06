﻿// <copyright file = "ChartBinding.cs" company = "Terry D. Eppler">
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
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        public new int Count { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public Source Source { get; set; }

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
        public IDataMetric Metric { get; set; }

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

        public ChartBinding( BindingSource bindingSource )
        {
            BindingSource = bindingSource;
            Data = ( (DataTable)bindingSource.DataSource ).AsEnumerable(  );
            DataTable = (DataTable)bindingSource.DataSource;
            Source = (Source)Enum.Parse( typeof( Source ), ( (DataTable)bindingSource.DataSource ).TableName );
            DataSet = ( (DataTable)bindingSource.DataSource )?.DataSet;
            Record = bindingSource.GetCurrentDataRow( );
            AllowNew = true;
            SeriesConfig = new SeriesConfig( );
            Changed += OnCurrentChanged;
        }

        public ChartBinding( DataTable dataTable )
        {
            Data = dataTable.AsEnumerable( );
            SeriesConfig = new SeriesConfig( );
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            DataTable = dataTable;
            DataSet = dataTable.DataSet;
            DataSource = dataTable;
            Record = (DataRow)Current;
            AllowNew = true;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding" /> class.
        /// </summary>
        /// <param name="dataTable">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public ChartBinding( DataTable dataTable, ISeriesConfig seriesConfig )
        {
            Data = dataTable.AsEnumerable( );
            SeriesConfig = seriesConfig;
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            DataTable = dataTable;
            DataSet = dataTable.DataSet;
            DataSource = dataTable;
            Record = (DataRow)Current;
            AllowNew = true;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="ChartBinding" />
        /// class.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public ChartBinding( IEnumerable<DataRow> data, ISeriesConfig seriesConfig )
        {
            Data = data;
            SeriesConfig = seriesConfig;
            DataTable = data.CopyToDataTable( );
            DataSet = data.CopyToDataTable( )?.DataSet;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataSource = DataTable;
            Record = (DataRow)Current;
            AllowNew = true;
            Changed += OnCurrentChanged;
        }
        
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <returns></returns>
        public int GetCount()
        {
            try
            {
                return Count;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
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