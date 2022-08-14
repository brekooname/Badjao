
namespace BudgetExecution
{
    using System;
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
        public ChartForm()
        {
            InitializeComponent( );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="ChartForm"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        public ChartForm( BindingSource bindingSource ) 
            : this( )
        {
            ToolStrip.Office12Mode = true;
            BindingSource = bindingSource;
            ToolStrip.BindingSource = bindingSource;
            ToolStrip.BindingSource.DataSource = bindingSource.DataSource;
            Chart = new ChartControl( bindingSource, Field.ProgramProjectName )
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
            ToolStrip.Office12Mode = true;
            BindingSource = new BindingSource
            {
                DataSource = dataTable
            };

            ToolStrip.BindingSource = BindingSource;
            ToolStrip.BindingSource.DataSource = BindingSource.DataSource;
            Chart = new ChartControl( dataTable )
            {
                Dock = DockStyle.Fill
            };

            Chart.SetPoints( );
            Controls.Add( Chart );
        }
    }
}
