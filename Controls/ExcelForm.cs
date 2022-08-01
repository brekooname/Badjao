
namespace BudgetExecution
{
    using System;
    using Syncfusion.Windows.Forms;

    public partial class ExcelForm : MetroForm
    {
        public ExcelForm()
        {
            InitializeComponent( );
            ToolStrip.Office12Mode = true;
        }
    }
}
