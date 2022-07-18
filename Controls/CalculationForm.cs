namespace BudgetExecution
{
    using System;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    public partial class CalculationForm : MetroForm
    {
        public CalculationForm()
        {
            InitializeComponent( );
            Calculator.BorderStyle = Border3DStyle.Adjust;
        }
    }
}
