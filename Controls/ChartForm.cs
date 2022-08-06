
namespace BudgetExecution
{
    using System;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    public partial class ChartForm : MetroForm
    {
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
            ChartControl = new ChartControl( bindingSource );
        }
    }
}
