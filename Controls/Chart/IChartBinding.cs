namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Data;
    using System.Windows.Forms;

    public interface IChartBinding : IChartSeriesModel
    {
        /// <summary>
        /// Gets or sets the chart handler.
        /// </summary>
        /// <value>
        /// The chart handler.
        /// </value>
        ListChangedEventHandler ChartHandler { get; set; }

        /// <summary>
        /// Gets or sets the count.
        /// </summary>
        /// <value>
        /// The count.
        /// </value>
        new int Count { get; set; }

        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        Source Source { get; set; }

        /// <summary>
        /// Gets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Gets or sets the data set.
        /// </summary>
        /// <value>
        /// The data set.
        /// </value>
        DataSet DataSet { get; set; }

        /// <summary>
        /// Gets or sets the data table.
        /// </summary>
        /// <value>
        /// The data table.
        /// </value>
        DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the record.
        /// </summary>
        /// <value>
        /// The record.
        /// </value>
        DataRow Record { get; set; }

        /// <summary>
        /// Gets the configuration.
        /// </summary>
        /// <value>
        /// The configuration.
        /// </value>
        ISeriesConfig SeriesConfiguration { get; set; }

        /// <summary>
        /// Gets the metric.
        /// </summary>
        /// <value>
        /// The metric.
        /// </value>
        IDataMetric Metric { get; set; }
        
        /// <summary>
        /// Gets the series configuration.
        /// </summary>
        /// <returns></returns>
        ISeriesConfig GetSeriesConfig();

        /// <summary>
        /// Gets the data metric.
        /// </summary>
        /// <returns></returns>
        IDataMetric GetDataMetric();

        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <returns></returns>
        int GetCount();
        
        /// <summary>
        /// Called when [current changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="ListChangedEventArgs" />
        /// instance containing the event data.</param>
        void OnCurrentChanged( object sender, ListChangedEventArgs e );

        /// <summary>
        /// Gets the related currency manager.
        /// </summary>
        /// <param name="dataMember">The data member.</param>
        /// <returns></returns>
        CurrencyManager GetRelatedCurrencyManager( string dataMember );

        /// <summary>
        /// Moves the first.
        /// </summary>
        void MoveFirst();

        /// <summary>
        /// Moves the last.
        /// </summary>
        void MoveLast();

        /// <summary>
        /// Moves the next.
        /// </summary>
        void MoveNext();

        /// <summary>
        /// Moves the previous.
        /// </summary>
        void MovePrevious();
    }
}