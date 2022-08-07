
namespace BudgetExecution
{
    using System;
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
            Chart = new ChartControl( bindingSource, new SeriesConfig( ) )
            {
                Dock = DockStyle.Fill
            };

            Controls.Add( Chart );
        }
    }
}
