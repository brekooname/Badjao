﻿// <copyright file = "IDataMetric.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;

    /// <summary>
    /// 
    /// </summary>
    public interface IDataMetric : IMetric, ISource
    {
        /// <summary>
        /// Gets or sets the data.
        /// </summary>
        /// <value>
        /// The data.
        /// </value>
        IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// Calculates the deviation.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        double CalculateDeviation( IEnumerable<DataRow> dataRow, Numeric numeric );

        /// <summary>
        /// Calculates the standard deviations.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        double CalculateDeviation( IEnumerable<DataRow> dataRow, Field field, Numeric numeric = Numeric.Amount );

        /// <summary>
        /// Calculates the variance.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        double CalculateVariance( IEnumerable<DataRow> dataRow, Numeric numeric );

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <returns>
        /// </returns>
        IDictionary<string, IEnumerable<double>> CalculateStatistics();

        /// <summary>
        /// Calculates the totals.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="field">The field.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        IDictionary<string, double> CalculateTotals( IEnumerable<DataRow> dataRow, Field field,
            Numeric numeric = Numeric.Amount );

        /// <summary>
        /// Calculates the variances.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        double CalculateVariance( IEnumerable<DataRow> dataRow, Field field, Numeric numeric = Numeric.Amount );

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="dict">The dictionary.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        IDictionary<string, IEnumerable<double>> CalculateStatistics( IEnumerable<DataRow> dataRow, IDictionary<string, object> dict, Numeric numeric );

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        IDictionary<string, IEnumerable<double>> CalculateStatistics( IEnumerable<DataRow> dataRow, Numeric numeric );

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        IDictionary<string, IEnumerable<double>> CalculateStatistics( IEnumerable<DataRow> dataRow, Field field,
            Numeric numeric = Numeric.Amount );
    }
}
