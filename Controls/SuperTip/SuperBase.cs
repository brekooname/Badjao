// <copyright file = "ToolTip.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public class SuperBase : SfToolTip
    {
        public virtual ToolTipInfo TipInfo { get; set; } = new ToolTipInfo( );

        public virtual ToolTipInfo.ToolTipItem TipItem { get; set; } 
        
        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ToolTip"/> class.
        /// </summary>
        public SuperBase( )
        {
            InitialDelay = 500;
            AutoPopDelay = 3000;
            ShadowVisible = true;
            CanApplyTheme = true;
            CanOverrideStyle = true;
            TipInfo.BackColor = Color.FromArgb( 40, 40, 40 );
            TipInfo.BorderColor = Color.FromArgb( 0, 120, 212 );
            TipInfo.ForeColor = Color.LightSteelBlue;
            TipInfo.Separator = true;
            TipInfo.Header.Font = new Font( "Roboto", 10, FontStyle.Regular );
            TipInfo.Header.ForeColor = Color.FromArgb( 0, 120, 212 );
            TipInfo.Header.TextAlign = ContentAlignment.TopLeft;
            TipInfo.Body.Font = new Font( "Roboto", 8, FontStyle.Regular );
            TipInfo.Body.ForeColor = Color.LightSteelBlue;
            TipInfo.Body.TextAlign = ContentAlignment.TopLeft;
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        public SuperBase( Control control )
        {
            InitialDelay = 500;
            AutoPopDelay = 3000;
            ShadowVisible = true;
            CanApplyTheme = true;
            CanOverrideStyle = true;
            TipInfo.BackColor = Color.FromArgb( 40, 40, 40 );
            TipInfo.BorderColor = Color.FromArgb( 0, 120, 212 );
            TipInfo.ForeColor = Color.LightSteelBlue;
            TipInfo.Separator = true;
            TipInfo.Header.Font = new Font( "Roboto", 10, FontStyle.Regular );
            TipInfo.Header.ForeColor = Color.FromArgb( 0, 120, 212 );
            TipInfo.Header.TextAlign = ContentAlignment.TopLeft;
            TipInfo.Body.Font = new Font( "Roboto", 8, FontStyle.Regular );
            TipInfo.Body.ForeColor = Color.LightSteelBlue;
            TipInfo.Body.TextAlign = ContentAlignment.TopLeft;
        }

        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="control">The control.</param>
        /// <param name="text">The text.</param>
        /// <param name = "title" > </param>
        public SuperBase( Control control, string text, string title = "" )
            : this( )
        {
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="component">The component.</param>
        /// <param name="text">The text.</param>
        /// <param name = "title" > </param>
        public SuperBase( Component component, string text, string title = "" )
            : this( )
        {
        }

        /// <summary>
        /// Initializes a new instance
        /// of the <see cref="ToolTip"/> class.
        /// </summary>
        /// <param name="toolItem">The toolItem.</param>
        public SuperBase( ToolStripItem toolItem )
            : this( )
        {
        }
    }
}