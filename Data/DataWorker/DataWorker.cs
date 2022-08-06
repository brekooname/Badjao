// <copyright file = "DataWorker.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.ComponentModel;

    public class DataWorker : BackgroundWorker
    {
        public readonly Builder unitBuilder = null;

        public DataWorker()
        {
        }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public SourceBinding BindingSource { get; set; }
    }
}
