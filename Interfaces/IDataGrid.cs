﻿// <copyright file = "IDataGrid.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.ComponentModel;
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
        DataRow GetCurrentDataRow();

        /// <summary>
        /// Called when [right click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">
        /// The <see cref="DataGridViewCellMouseEventArgs" />
        /// instance containing the event data.</param>
        void OnRightClick( object sender, DataGridViewCellMouseEventArgs e );

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingSource">The bindingSource.</param>
        void SetDataSource<T1>( T1 bindingSource )
            where T1 : IBindingList;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="bindingList">The bindingSource.</param>
        /// <param name="dict">The dictionary.</param>
        void SetDataSource<T1, T2>( T1 bindingList, T2 dict )
            where T1 : IBindingList
            where T2 : IDictionary<string, object>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        void SetDataSource<T1>( IEnumerable<T1> data )
            where T1 : IEnumerable<DataRow>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        void SetDataSource<T1>( IEnumerable<T1> data, IDictionary<string, object> dict )
            where T1 : IEnumerable<DataRow>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <typeparam name="T3">The type of the 3.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The dictionary.</param>
        void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<DataRow>
            where T2 : struct;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        void SetDataSource<T1>( IEnumerable<T1> data, object field = null )
            where T1 : IEnumerable<DataRow>;

        /// <summary>
        /// Sets the bindings.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param>The numeric.</param>
        /// <param name = "dict" > </param>
        void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<DataRow>
            where T2 : IDictionary<string, object>;

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field, object filter = null )
            where T1 : IEnumerable<DataRow>
            where T2 : struct;
    }
}