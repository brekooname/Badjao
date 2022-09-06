﻿namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    public interface IDataModel
    {
        /// <summary>
        /// Filters the data.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        IEnumerable<DataRow> FilterData( IDictionary<string, object> dict );

        /// <summary>
        /// Filters the data.
        /// </summary>
        /// <param name="name">The field.</param>
        /// <param name="value">The filter.</param>
        /// <returns></returns>
        IEnumerable<DataRow> FilterData( string name, string value );

        /// <summary>
        /// The program elements
        /// </summary>
        IDictionary<string, IEnumerable<string>> DataElements { get; }

        /// <summary>
        /// The source
        /// </summary>
        Source Source { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        Provider Provider { get; set; }

        /// <summary>
        /// The connection builder
        /// </summary>
        IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// The arguments
        /// </summary>
        IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// The SQL statement
        /// </summary>
        ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// The query
        /// </summary>
        IQuery Query { get; set; }

        /// <summary>
        /// The record
        /// </summary>
        DataRow Record { get; set; }

        /// <summary>
        /// The Data table
        /// </summary>
        DataTable DataTable { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        IEnumerable<DataColumn> DataColumns { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        string TableName { get; set; }

        /// <summary>
        /// Gets or sets the Data set.
        /// </summary>
        /// <value>
        /// The Data set.
        /// </value>
        DataSet DataSet { get; set; }

        /// <summary>
        /// Gets or sets the name of the data set.
        /// </summary>
        /// <value>
        /// The name of the data set.
        /// </value>
        string DataSetName { get; set; }

        /// <summary>
        /// Gets the column ordinals.
        /// </summary>
        /// <returns></returns>
        IEnumerable<int> GetColumnOrdinals( );

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Field> GetFields( );

        /// <summary>
        /// Gets the elements.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IElement> GetElements( );

        /// <summary>
        /// Gets the columns.
        /// </summary>
        /// <returns></returns>
        IEnumerable<DataColumn> GetDataColumns(  );

        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <returns></returns>
        IEnumerable<DataRow> GetData( );

        /// <summary>
        /// Gets the Data table.
        /// </summary>
        /// <returns></returns>
        DataTable GetDataTable( );

        /// <summary>
        /// Gets the Data set.
        /// </summary>
        /// <returns></returns>
        DataSet GetDataSet( );
        
        /// <summary>
        /// Sets the column captions.
        /// </summary>
        /// <param name="dataTable">The Data table.</param>
        void SetColumnCaptions( DataTable dataTable );

        /// <summary>
        /// Gets the column schema.
        /// </summary>
        /// <returns></returns>
        DataColumnCollection GetColumnSchema( );

        /// <summary>
        /// Gets the primary indexes.
        /// </summary>
        /// <param name="dataRows">The Data rows.</param>
        /// <returns></returns>
        IEnumerable<int> GetPrimaryIndexes( IEnumerable<DataRow> dataRows );
    }
}