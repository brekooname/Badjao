﻿// <copyright file = "ChartForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    public partial class ChartForm : MetroForm
    {
        /// <summary>
        /// Gets or sets the chart.
        /// </summary>
        /// <value>
        /// The chart.
        /// </value>
        public ChartControl Chart { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        public ChartForm( )
        {
            InitializeComponent( );
            ToolStrip.Office12Mode = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ChartForm( BindingSource bindingSource )
            : this( )
        {
            BindingSource = bindingSource;
            ToolStrip.Office12Mode = true;
            ToolStrip.BindingSource = bindingSource;
            ToolStrip.BindingSource.DataSource = bindingSource.DataSource;
            Chart = new ChartControl( bindingSource )
            {
                Dock = DockStyle.Fill
            };

            Chart.SetPoints( );
            Controls.Add( Chart );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        /// <param name="dataTable">The data table.</param>
        public ChartForm( DataTable dataTable )
            : this( )
        {
            BindingSource = new BindingSource
            {
                DataSource = dataTable
            };

            ToolStrip.Office12Mode = true;
            ToolStrip.BindingSource = BindingSource;
            ToolStrip.BindingSource.DataSource = BindingSource.DataSource;
            Chart = new ChartControl( dataTable )
            {
                Dock = DockStyle.Fill
            };

            Chart.SetPoints( );
            Controls.Add( Chart );
        }

        public ChartForm( IEnumerable<DataRow> dataRows )
            : this( )
        {
            ToolStrip.Office12Mode = true;
            BindingSource = new BindingSource
            {
                DataSource = dataRows.CopyToDataTable( )
            };

            ToolStrip.BindingSource = BindingSource;
            ToolStrip.BindingSource.DataSource = BindingSource.DataSource;
            Chart = new ChartControl( dataRows )
            {
                Dock = DockStyle.Fill
            };

            Chart.SetPoints( );
            Controls.Add( Chart );
        }
    }
}