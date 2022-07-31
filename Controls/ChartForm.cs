
namespace BudgetExecution
{
    using System;
    using Syncfusion.Windows.Forms;

    public partial class ChartForm : MetroForm
    {
        public ChartForm()
        {
            InitializeComponent( );
            ToolStrip.Office12Mode = true;
        }

        public ChartForm( System.Windows.Forms.BindingSource bindingSource ) 
            : this( )
        {
            InitializeComponent( );
            BindingSource = bindingSource;
            ToolStrip.BindingSource = bindingSource;
        }
    }
}
