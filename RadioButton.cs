namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    using MetroSet_UI.Controls;
    using MetroSet_UI.Design;
    using CheckState = MetroSet_UI.Enums.CheckState;

    public class RadioButton : MetroSetRadioButton
    {
        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public ToolTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the result.
        /// </summary>
        /// <value>
        /// The result.
        /// </value>
        public virtual string Result { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Initializes a new instance of the 
        /// <see cref="RadioButton"/> class.
        /// </summary>
        public RadioButton( )
        {
            BackgroundColor = Color.FromArgb( 15, 15, 15  );
            ForeColor = Color.FromArgb( 0, 120, 212 );
            CheckSignColor = Color.FromArgb( 0, 192, 0 );
            BorderColor = Color.FromArgb( 0, 120, 212 );
            Style = Style.Custom;
            Size = new Size( 125, 17 );
            ThemeAuthor = "Terry D. Eppler";
            ThemeName = "Budget Execution";
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Font = new Font( "Roboto", 8, FontStyle.Regular  );
            Dock = DockStyle.None;
            CheckState = CheckState.Unchecked;
        }


        /// <summary>
        /// Initializes a new instance of the <see cref="RadioButton"/> class.
        /// </summary>
        /// <param name="text">The text displayed by the control.</param>
        public RadioButton( string text ) : this( )
        {
            Text = text;
            CheckedChanged += OnCheckStateChanged;
        }

        /// <summary>
        /// Called when [check state changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        public void OnCheckStateChanged( object sender )
        {
            if( sender is RadioButton radioButton 
                && radioButton.Tag != null )
            {
                try
                {
                    Result = radioButton.Tag?.ToString( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The exception.</param>
        private static void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}
