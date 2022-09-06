namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    public class ComboBox : ComboBoxBase
    {
        public ComboBox( )
        {
            ButtonColor = Color.FromArgb( 0, 120, 212 );
            BackColor = Color.FromArgb( 30, 30, 30 );
            ForeColor = Color.LightSteelBlue;
            FlatStyle = FlatStyle.Flat;
            DropDownStyle = ComboBoxStyle.DropDownList;
            ItemHeight = 24;
            Font = new Font( "Roboto", 9 );
            MenuItemHover = Color.FromArgb( 22, 39, 70  );
            MenuItemNormal = Color.FromArgb( 30, 30, 30 );
            MenuTextColor = Color.LightSteelBlue;
        }
    }
}
