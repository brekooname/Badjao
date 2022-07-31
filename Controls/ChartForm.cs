
namespace BudgetExecution
{
    using System;
    using Syncfusion.Windows.Forms;

    public partial class ChartForm : MetroForm
    {
        public ChartForm()
        {
            InitializeComponent( );
        }

        public ChartForm( System.Windows.Forms.BindingSource bindingSource ) 
            : this( )
        {
            ToolStrip.Office12Mode = true;
            BindingSource = bindingSource;
            ChartControl.BindingSource = bindingSource;
            ToolStrip.BindingSource = bindingSource;
        }
    }
}
