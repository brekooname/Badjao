// <copyright file = "DataSeries.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Chart;
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Drawing;
    using System.Linq;
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ChartSeries" />
    /// <seealso cref="IDataSeries" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ChartData : ChartSeries
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public virtual STAT STAT { get; set; }
        
        /// <summary>
        /// Gets the numeric.
        /// </summary>
        public virtual Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        public virtual IDataMetric DataMetric { get; set; }

        /// <summary>
        /// Gets the binding model.
        /// </summary>
        /// <value>
        /// The binding model.
        /// </value>
        public virtual ChartDataBindModel BindingModel { get; set; }

        /// <summary>
        /// Gets or sets the axis label model.
        /// </summary>
        /// <value>
        /// The axis label model.
        /// </value>
        public virtual ChartDataBindAxisLabelModel AxisLabelModel { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        protected ChartData( )
        {
            SmartLabels = true;
            Visible = true;
            ShowTicks = true;
            Rotate = true;
            EnableAreaToolTip = true;
            EnableStyles = true;
            OptimizePiePointPositions = true;
            LegendItemUseSeriesStyle = true;
            SmartLabelsBorderColor = Color.SteelBlue;
            SmartLabelsBorderWidth = 1;
            Numeric = Numeric.Amount;
            STAT = STAT.Total;
            Type = ChartSeriesType.Column;

            // Basic Properties
            SmartLabels = true;
            Visible = true;
            ShowTicks = true;
            Rotate = true;
            EnableAreaToolTip = true;
            EnableStyles = true;
            OptimizePiePointPositions = true;
            LegendItemUseSeriesStyle = true;
            SmartLabelsBorderColor = Color.SteelBlue;
            SmartLabelsBorderWidth = 1;

            // Callout Properties
            Style.DisplayText = true;
            Style.Callout.Enable = true;
            Style.Callout.Position = LabelPosition.Top;
            Style.Callout.DisplayTextAndFormat = "{0} : {2}";
            Style.Callout.Border.Color = Color.SteelBlue;
            Style.Callout.Color = Color.FromArgb( 15, 15, 15 );
            Style.Callout.Font = ChartConfig.SetFont( );
            Style.DisplayText = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        protected ChartData( BindingSource bindingSource )
            : this( )
        {
            Name = ( (DataTable)bindingSource.DataSource ).TableName;
            Type = ChartSeriesType.Column;
            STAT = STAT.Total;
            DataMetric = new DataMetric( bindingSource );

            BindingModel = new ChartDataBindModel
            {
                DataSource = bindingSource.DataSource
            };

            AxisLabelModel = new ChartDataBindAxisLabelModel
            {
                DataSource = bindingSource.DataSource
            };
        }
    
        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        /// <param name="dataRows">The data rows.</param>
        protected ChartData( IEnumerable<DataRow> dataRows )
            : this( )
        {
            Type = ChartSeriesType.Column;
            STAT = STAT.Total;
            DataMetric = new DataMetric( dataRows );

            BindingModel = new ChartDataBindModel
            {
                DataSource = dataRows.CopyToDataTable( )
            };

            AxisLabelModel = new ChartDataBindAxisLabelModel
            {
                DataSource = dataRows.CopyToDataTable( )
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        protected ChartData( DataTable dataTable )
            : this( )
        {
            Type = ChartSeriesType.Column;
            STAT = STAT.Total;
            DataMetric = new DataMetric( dataTable );

            BindingModel = new ChartDataBindModel
            {
                DataSource = dataTable
            };

            AxisLabelModel = new ChartDataBindAxisLabelModel
            {
                DataSource = dataTable
            };
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartData"/> class.
        /// </summary>
        /// <param name="dataSet">The data set.</param>
        protected ChartData( DataSet dataSet )
            : this( )
        {
            Type = ChartSeriesType.Column;
            STAT = STAT.Total;
            DataMetric = new DataMetric( );

            BindingModel = new ChartDataBindModel
            {
                DataSource = dataSet.Tables[ 0 ]
            };

            AxisLabelModel = new ChartDataBindAxisLabelModel
            {
                DataSource = dataSet.Tables[ 0 ]
            };
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingSource">The bindingsource.</param>
        public virtual void SetDataSource<T1>( T1 bindingSource )
            where T1 : IBindingList
        {
            try
            {
                if( bindingSource is BindingSource binder
                    && binder?.DataSource != null )
                {
                    try
                    {
                        BindingSource.DataSource = binder.DataSource;
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
        public virtual void SetDataSource<T1, T2>( T1 bindingList, T2 dict )
            where T1 : IBindingList
            where T2 : IDictionary<string, object>
        {
            try
            {
                if( Verify.IsBindable( bindingList )
                    && dict?.Any(  ) == true )
                {
                    try
                    {
                        var _list = bindingList as BindingSource;
                        var _filter = string.Empty;

                        foreach( var _kvp in dict )
                        {
                            if( !string.IsNullOrEmpty( _kvp.Key )
                                && _kvp.Value != null )
                            {
                                _filter += $"{ _kvp.Key } = { _kvp.Value } AND";
                            }
                        }

                        if( _filter?.Length > 0
                            && _list?.DataSource != null )
                        {
                            BindingSource.DataSource = _list?.DataSource;
                            BindingSource.Filter = _filter?.TrimEnd( " AND".ToCharArray(  ) );
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
        /// <param name="data">The data.</param>
        public virtual void SetDataSource<T1>( IEnumerable<T1> data )
            where T1 : IEnumerable<DataRow>
        {
            if( data?.Any(  ) == true )
            {
                try
                {
                    BindingSource.DataSource = data?.ToList(  );
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
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public virtual void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<DataRow>
        {
            if( data?.Any(  ) == true )
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

                    BindingSource.DataSource = data?.ToList(  );
                    BindingSource.Filter = _filter.TrimEnd( " AND".ToCharArray(  ) );
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
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <typeparam name="T3">The type of the 3.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The dictionary.</param>
        public virtual void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<DataRow>
            where T2 : struct
        {
            if( data?.Any(  ) == true
                && Enum.IsDefined( typeof( Field ), field )
                && !string.IsNullOrEmpty( filter?.ToString(  ) ) )
            {
                try
                {
                    if( !string.IsNullOrEmpty( filter?.ToString(  ) ) )
                    {
                        BindingSource.DataSource = data.ToList(  );
                        BindingSource.DataMember = field.ToString(  );
                        BindingSource.Filter = $"{ field } = { filter }";
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList(  );
                        BindingSource.DataMember = field.ToString(  );
                    }
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
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        public virtual void SetDataSource<T1>( IEnumerable<T1> data, object field = null )
            where T1 : IEnumerable<DataRow>
        {
            if( data?.Any(  ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( field?.ToString(  ) ) )
                    {
                        BindingSource.DataSource = data.ToList(  );
                        BindingSource.DataMember = field?.ToString(  );
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList(  );
                    }
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
        public virtual void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<DataRow>
            where T2 : IDictionary<string, object>
        {
            if( data?.Any(  ) == true
                && dict?.Any(  ) == true )
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

                    BindingSource.DataSource = data?.ToList(  );
                    BindingSource.Filter = _filter?.TrimEnd( " AND".ToCharArray(  ) );
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
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        public virtual void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<DataRow>
            where T2 : struct
        {
            if( data?.Any(  ) == true
                && Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    if( !string.IsNullOrEmpty( filter?.ToString(  ) ) )
                    {
                        BindingSource.DataSource = data.ToList(  );
                        BindingSource.DataMember = field.ToString(  );
                        BindingSource.Filter = $"{field} = {filter}";
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList(  );
                        BindingSource.DataMember = field.ToString(  );
                    }
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
        [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
        protected void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}