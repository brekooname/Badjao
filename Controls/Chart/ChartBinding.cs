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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BindingSource" />
    /// <seealso cref="IChartBinding" />
    /// <seealso cref="IChartSeriesModel" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "UnusedType.Global" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    public class ChartBinding : System.Windows.Forms.BindingSource, IChartBinding
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
        public ISeriesConfig SeriesConfiguration { get; set; }

        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public IDataMetric Metric { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="BindingSource" />
        /// class.
        /// </summary>
        public ChartBinding()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartBinding" /> class.
        /// </summary>
        /// <param name="dataTable">The table.</param>
        /// <param name="seriesConfig">The seriesConfig.</param>
        public ChartBinding( DataTable dataTable, ISeriesConfig seriesConfig )
        {
            Data = dataTable.AsEnumerable( );
            SeriesConfiguration = seriesConfig;
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
            SeriesConfiguration = seriesConfig;
            DataTable = data.CopyToDataTable( );
            DataSet = DataTable.DataSet;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable.TableName );
            DataSource = DataTable;
            Record = (DataRow)Current;
            AllowNew = true;
            Changed += OnCurrentChanged;
        }

        /// <summary>
        /// Gets the series configuration.
        /// </summary>
        /// <returns></returns>
        public ISeriesConfig GetSeriesConfig()
        {
            try
            {
                return SeriesConfiguration;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( ISeriesConfig );
            }
        }

        /// <summary>
        /// Gets the data metric.
        /// </summary>
        /// <returns></returns>
        public IDataMetric GetDataMetric()
        {
            try
            {
                return Metric;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDataMetric );
            }
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
                var _numeric = SeriesConfiguration?.Numeric;
                return double.Parse( Record[ $"{_numeric}" ].ToString( ) ) > 0;
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
                var _numeric = SeriesConfiguration?.Numeric;

                return !GetEmpty( xIndex )
                    ? double.Parse( Record[ $"{_numeric}" ].ToString( ) )
                    : 0;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
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
                var _numeric = SeriesConfiguration?.Numeric;

                return !GetEmpty( xIndex )
                    ? double.Parse( Record[ $@"{_numeric}" ].ToString( ) )
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