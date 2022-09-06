namespace BudgetExecution
{
    using System;
    using System.Drawing;

    public class TextBox : TextBoxBase
    {

        public TextBox( )
        {

            BackColor = Color.FromArgb( 30, 30, 30 );
            ForeColor = Color.LightSteelBlue;
            Font = new Font( "Roboto", 9 );
        }
    }
}
