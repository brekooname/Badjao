﻿namespace BudgetExecution
{
    using System;
    using System.Windows.Forms;

    public class SyncTip : SyncTipBase
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        public SyncTip( )
        {
        }

        public SyncTip( Control control, string text, string title = "" )
            : this( )
        {
        }
    }
}
