﻿// <copyright file = "LayoutBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Linq;
    using System.Windows.Forms;
    using VisualPlus.Toolkit.Controls.Layout;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="VisualPanel" />
    /// <seealso cref="ILayout" />
    /// 
    [ SuppressMessage( "ReSharper", "HeuristicUnreachableCode" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedType.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class LayoutBase : VisualPanel, ILayout
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual MetroTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public virtual Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the children.
        /// </summary>
        /// <value>
        /// The children.
        /// </value>
        public IEnumerable<Control> Children { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LayoutBase" />
        /// class.
        /// </summary>
        protected LayoutBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LayoutBase" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        protected LayoutBase( Size size, Point location )
            : this( )
        {
            Size = size;
            Location = Settings.ReLocate( location.X, location.Y );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LayoutBase" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        protected LayoutBase( Size size, Point location, Control parent )
            : this( )
        {
            Size = new Size( size.Width, size.Height );
            Location = new Point( location.X, location.Y );
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LayoutBase" />
        /// class.
        /// </summary>
        /// <param name="parent">The parent.</param>
        protected LayoutBase( Control parent )
            : this( )
        {
            Parent = parent;
            Parent.Controls.Add( this );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="LayoutBase" />
        /// class.
        /// </summary>
        /// <param name="size">The size.</param>
        /// <param name="location">The location.</param>
        /// <param name="parent">The parent.</param>
        /// <param name="hover">if set to
        /// <c> true </c>
        /// [hover].</param>
        protected LayoutBase( Size size, Point location, Control parent, bool hover )
            : this( )
        {
            Size = size;
            Location = location;
            Parent = parent;
            Parent.Controls.Add( this );
            Border.HoverVisible = hover;
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="hover">if set to <c>true</c> [hover].</param>
        public void SetBorderColor( Color color, bool hover = true )
        {
            if( color != Color.Empty )
            {
                try
                {
                    Border.Color = color;
                    Border.HoverVisible = hover;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the border.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="hover">if set to <c>true</c> [hover].</param>
        public void SetBorderHoverColor( Color color, bool hover = true )
        {
            if( color != Color.Empty )
            {
                try
                {
                    Border.HoverColor = color;
                    Border.HoverVisible = hover;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        public void SetBackColor( Color color )
        {
            if( color != Color.Empty )
            {
                try
                {
                    BackColor = color;
                    BackColorState.Enabled = BackColor;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <param name="item">The item.</param>
        /// <returns></returns>
        public IEnumerable<Control> AddChild( Control item )
        {
            if( item != null )
            {
                try
                {
                    List<Control> _list = new List<Control> { item };

                    return _list?.Any( ) == true
                        ? _list
                        : default( List<Control> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( IEnumerable<Control> );
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public void SetField( Field field )
        {
            if( Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    Field = field;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public void SetTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    Tag = tag;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Adds the control item.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Control> GetChildren( )
        {
            try
            {
                return Children?.Any( ) == true
                    ? Children
                    : default( IEnumerable<Control> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<Control> );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using( Error _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}