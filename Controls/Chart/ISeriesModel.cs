namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    public interface ISeriesModel
    {
        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <returns></returns>
        IEnumerable<double> GetSeriesValues( );

        /// <summary>
        /// Gets the source model.
        /// </summary>
        /// <returns></returns>
        ISeriesModel GetSeriesModel( );

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets or sets the chart binding.
        /// </summary>
        /// <value>
        /// The chart binding.
        /// </value>
        IChartBinding ChartBinding { get; set; }

        /// <summary>
        /// Gets the binding model.
        /// </summary>
        /// <value>
        /// The binding model.
        /// </value>
        ChartDataBindModel BindingModel { get; set; }

        /// <summary>
        /// Gets or sets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        IDataMetric DataMetric { get; set; }

        /// <summary>
        /// Gets the value.
        /// </summary>
        /// <value>
        /// The value.
        /// </value>
        STAT Stat { get; set; }

        /// <summary>
        /// Gets the series data.
        /// </summary>
        /// <value>
        /// The series data.
        /// </value>
        IDictionary<string, double> SeriesData { get; set; }

        /// <summary>
        /// Gets or sets the series values.
        /// </summary>
        /// <value>
        /// The series values.
        /// </value>
        IEnumerable<double> Values { get; set; }

        /// <summary>
        /// Gets or sets the series categories.
        /// </summary>
        /// <value>
        /// The series categories.
        /// </value>
        IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the index of the x.
        /// </summary>
        /// <value>
        /// The index of the x.
        /// </value>
        int XIndex { get; set; }

        /// <summary>
        /// Gets or sets the name of the x.
        /// </summary>
        /// <value>
        /// The name of the x.
        /// </value>
        string XName { get; set; }

        /// <summary>
        /// Gets or sets the y indexes.
        /// </summary>
        /// <value>
        /// The y indexes.
        /// </value>
        int[ ] YIndexes { get; set; }

        /// <summary>
        /// Gets or sets the y names.
        /// </summary>
        /// <value>
        /// The y names.
        /// </value>
        string[ ] YNames { get; set; }

        /// <summary>
        /// Gets or sets the data source.
        /// </summary>
        /// <value>
        /// The data source.
        /// </value>
        object DataSource { get; set; }

        /// <summary>
        /// Gets or sets the data member.
        /// </summary>
        /// <value>
        /// The data member.
        /// </value>
        string DataMember { get; set; }

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        int Count { get; }

        /// <summary>
        /// Called when [changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" />
        /// instance containing the event data.</param>
        void OnChanged( object sender, EventArgs e );

        /// <summary>
        /// Updates the data source.
        /// </summary>
        /// <param name="dataSource">The data source.</param>
        void UpdateDataSource( object dataSource );

        /// <summary>
        /// Raises the changed event.
        /// </summary>
        /// <param name="e">The <see cref="ListChangedEventArgs"/> instance containing the event data.</param>
        void RaiseChangedEvent( ListChangedEventArgs e );

        /// <summary>
        /// Gets the x.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        double GetX( int index );

        /// <summary>
        /// Gets the y.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        double[ ] GetY( int index );

        /// <summary>
        /// Gets the empty.
        /// </summary>
        /// <param name="index">The index.</param>
        /// <returns></returns>
        bool GetEmpty( int index );

        /// <summary>
        /// Sets the empty.
        /// </summary>
        /// <param name="xIndex">Index of the x.</param>
        /// <param name="isEmpty">if set to <c>true</c> [is empty].</param>
        void SetEmpty( int xIndex, bool isEmpty );
    }
}