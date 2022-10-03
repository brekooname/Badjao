// <copyright file = "DataWorker.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Windows.Forms;

    public class DataWorker : BackgroundWorker
    {
        public readonly DataModel unitBuilder = null;

        public DataWorker( )
        {
        }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public BindingSource BindingSource { get; set; }
    }
}