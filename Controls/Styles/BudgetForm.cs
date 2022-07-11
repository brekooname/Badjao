﻿// <copyright file = "BudgetForm.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="BudgetSetting" />
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" )]
    [SuppressMessage( "ReSharper", "AccessToStaticMemberViaDerivedType" )]
    [SuppressMessage( "ReSharper", "ConvertToConstant.Global" )]
    public class BudgetForm : BudgetSetting
    {
        /// <summary>
        /// Gets or sets the state of the minimized.
        /// </summary>
        /// <value>
        /// The state of the minimized.
        /// </value>
        public static FormWindowState MinimizedState { get; set; } = FormWindowState.Minimized;

        /// <summary>
        /// Gets or sets the state of the normal.
        /// </summary>
        /// <value>
        /// The state of the normal.
        /// </value>
        public static FormWindowState NormalState { get; set; } = FormWindowState.Normal;

        /// <summary>
        /// Gets or sets the state of the maximized.
        /// </summary>
        /// <value>
        /// The state of the maximized.
        /// </value>
        public static FormWindowState MaximizedState { get; set; } = FormWindowState.Maximized;

        /// <summary>
        /// Gets or sets the form centered.
        /// </summary>
        /// <value>
        /// The form centered.
        /// </value>
        public static FormStartPosition FormCentered { get; set; } = FormStartPosition.CenterScreen;

        /// <summary>
        /// Gets or sets the default location.
        /// </summary>
        /// <value>
        /// The default location.
        /// </value>
        public static FormStartPosition DefaultLocation { get; set; } = FormStartPosition.WindowsDefaultLocation;

        /// <summary>
        /// Gets or sets the form.
        /// </summary>
        /// <value>
        /// The form.
        /// </value>
        public MetroForm Form { get; set; }

        /// <summary>
        /// The caption height
        /// </summary>
        public static int CaptionHeight = 26;

        /// <summary>
        /// The start position
        /// </summary>
        public static FormStartPosition StartPosition = FormStartPosition.CenterScreen;

        /// <summary>
        /// Gets or sets the tag.
        /// </summary>
        /// <value>
        /// The tag.
        /// </value>
        public object Tag { get; set; }

        /// <summary>
        /// Gets or sets the size.
        /// </summary>
        /// <value>
        /// The size.
        /// </value>
        public Size Size { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets a value indicating whether this instance is visible.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is visible; otherwise, <c>false</c>.
        /// </value>
        public static bool IsVisible { get; set; } = true;

        /// <summary>
        /// Gets or sets a value indicating whether this instance is enabled.
        /// </summary>
        /// <value>
        ///   <c>true</c> if this instance is enabled; otherwise, <c>false</c>.
        /// </value>
        public static bool IsEnabled { get; set; } = true;

        /// <summary>
        /// Gets the budget execution icon.
        /// </summary>
        /// <value>
        /// The budget execution icon.
        /// </value>
        public static NameValueCollection AppSetting { get; set; } =
            ConfigurationManager.AppSettings;

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetForm"/> class.
        /// </summary>
        public BudgetForm( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BudgetForm"/> class.
        /// </summary>
        /// <param name="form">The form.</param>
        public BudgetForm( MetroForm form )
        {
            Form = form;
        }

        /// <summary>
        /// Gets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public static Field GetField( Field field )
        {
            if( Validate.IsField( field ) )
            {
                try
                {
                    return field;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Field );
                }
            }

            return default( Field );
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        public void Dispose()
        {
            try
            {
                GC.SuppressFinalize( this );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}