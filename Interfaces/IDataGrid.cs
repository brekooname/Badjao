// <copyright file = "IDataGrid.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;

    public interface IDataGrid
    {
        /// <summary>
        /// Sets the column configuration.
        /// </summary>
        void SetColumnConfiguration();

        /// <summary>
        /// Sets the row configuration.
        /// </summary>
        void SetRowConfiguration();

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="dataRows">The data.</param>
        /// <param name="dict">The dictionary.</param>
        void SetBindingSource( IEnumerable<DataRow> dataRows, IDictionary<string, object> dict );

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingSource">The bindingSource.</param>
        /// <param name="dict">The dictionary.</param>
        void SetBindingSource( BindingSource bindingSource, IDictionary<string, object> dict );

        /// <summary>
        /// Pascalizes the headers.
        /// </summary>
        /// <param name="dataRows">The data.</param>
        void PascalizeHeaders( IEnumerable<DataRow> dataRows );

        /// <summary>
        /// Gets the filter values.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        string GetFilterValues( IDictionary<string, object> dict );

        /// <summary>
        /// Gets the current data row.
        /// </summary>
        /// <returns></returns>
        DataRow GetCurrentDataRow( );

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="DataGridViewCellMouseEventArgs" />
        /// instance containing the event data.</param>
        void OnRightClick( object sender, DataGridViewCellMouseEventArgs e );
    }
}