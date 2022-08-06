﻿// <copyright file = "IDataSeries.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    public interface IDataSeries
    {
        /// <summary>
        /// Sets the call out.
        /// </summary>
        void SetCallOut( );
        
        /// <summary>
        /// Sets the point configuration.
        /// </summary>
        /// <param name="stat">The stat.</param>
        void SetPointConfig( STAT stat = STAT.Total );

        /// <summary>
        /// Sets the points.
        /// </summary>
        /// <param name="dict">The data.</param>
        /// <param name="type">The type.</param>
        /// <param name="stat">The stat.</param>
        void SetPoints( IDictionary<string, double> dict,
            ChartSeriesType type = ChartSeriesType.Column, STAT stat = STAT.Total );
    }
}