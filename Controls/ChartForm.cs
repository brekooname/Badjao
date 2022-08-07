
namespace BudgetExecution
{
    using System;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    public partial class ChartForm : MetroForm
    {
        public ChartControl Chart { get; set; }

        public ChartForm()
        {
            InitializeComponent( );
        }

        public ChartForm( BindingSource bindingSource ) 
            : this( )
        {
            ToolStrip.Office12Mode = true;
            BindingSource = bindingSource;
            ToolStrip.BindingSource = bindingSource;
            Chart = new ChartControl( bindingSource )
            {
                Dock = DockStyle.Fill
            };

            Controls.Add( Chart );
        }
    }
}
