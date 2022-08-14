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
    using System.Threading;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Syncfusion.Windows.Forms.Chart.ChartSeries" />
    /// <seealso cref="IDataSeries" />
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class ChartData : Syncfusion.Windows.Forms.Chart.ChartSeries
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
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        public virtual IEnumerable<DataRow> Data { get; set; }

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
        /// Gets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        public IDictionary<string, double> DataValues { get; set; }

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
            BindingSource = bindingSource;
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

        protected ChartData( BindingSource bindingSource, Field field )
        {
            BindingSource = bindingSource;
            Name = ( (DataTable)bindingSource.DataSource ).TableName;
            Text = Name.SplitPascal(  );
            Type = ChartSeriesType.Column;
            STAT = STAT.Total;
            DataMetric = new DataMetric( bindingSource, field );
            DataValues = new DataMetric( bindingSource, field ).Values;

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

            BindingSource = new BindingSource
            {
                DataSource = dataRows.CopyToDataTable( )
            };

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

            BindingSource = new BindingSource
            {
                DataSource = dataTable
            };

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

            BindingSource = new BindingSource
            {
                DataSource = dataSet.Tables[ 0 ]
            };

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