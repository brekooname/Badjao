// <copyright file = "FileBrowser.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>
//

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;
    
    public partial class FileBrowser
    {
        /// <summary>Initializes a new instance of the 
        /// <see cref="FileBrowser" /> class.</summary>
        public FileBrowser( )
        {
            InitializeComponent( );
            Size = new Size( 700, 530 );
            FormBorderStyle = FormBorderStyle.FixedSingle;
            BackColor = Color.FromArgb( 15, 15, 15 );
            CloseButton.Click += OnCloseButtonClicked;
        }

        /// <summary>
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnCloseButtonClicked( object sender, EventArgs e )
        {
            if( sender is System.Windows.Forms.Button _button 
                && !string.IsNullOrEmpty( _button.Name ) 
                && e != null )
            {
                try
                {
                    Close( );
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
