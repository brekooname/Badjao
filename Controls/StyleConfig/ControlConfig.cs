﻿// <copyright file = "ControlConfig.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Drawing;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    public class ControlConfig
    {
        /// <summary>
        /// The margin
        /// </summary>
        public static readonly Padding Margin = new Padding( 5 );

        /// <summary>
        /// The padding
        /// </summary>
        public static readonly Padding Padding = new Padding( 1 );

        /// <summary>
        /// Gets or sets the parent.
        /// </summary>
        /// <value>
        /// The parent.
        /// </value>
        public static Control Parent { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "ControlConfig"/> class.
        /// </summary>
        public ControlConfig()
        {
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name = "tag" >
        /// The tag.
        /// </param>
        /// <returns>
        /// </returns>
        public static object GetTag( object tag )
        {
            if( tag != null )
            {
                try
                {
                    return !string.IsNullOrEmpty( tag.ToString() )
                        ? tag
                        : default( object );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( object );
                }
            }

            return default( object );
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name = "text" >
        /// The text.
        /// </param>
        public static string GetText( string text )
        {
            if( !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    return text;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return string.Empty;
                }
            }

            return string.Empty;
        }

        /// <summary>
        /// Sets the anchor.
        /// </summary>
        /// <param name = "anchor" >
        /// The anchor.
        /// </param>
        /// <returns>
        /// </returns>
        public static AnchorStyles GetAnchorStyle(
            AnchorStyles anchor = AnchorStyles.Left & AnchorStyles.Top & AnchorStyles.Right )
        {
            try
            {
                return Enum.IsDefined( typeof( AnchorStyles ), anchor )
                    ? anchor
                    : AnchorStyles.None;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( AnchorStyles );
            }
        }

        /// <summary>
        /// Sets the dock style.
        /// </summary>
        /// <param name = "doc" >
        /// The document.
        /// </param>
        /// <returns>
        /// </returns>
        public static DockStyle GetDockStyle( DockStyle doc = DockStyle.None )
        {
            if( Enum.IsDefined( typeof( DockStyle ), doc ) )
            {
                try
                {
                    return Enum.IsDefined( typeof( DockStyle ), doc )
                        ? doc
                        : DockStyle.None;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DockStyle );
                }
            }

            return default( DockStyle );
        }

        /// <summary>
        /// Sets the parent.
        /// </summary>
        /// <param name = "control" >
        /// The control.
        /// </param>
        /// <returns>
        /// </returns>
        public static Control GetParent( Control control )
        {
            if( control != null )
            {
                try
                {
                    Parent = control;
                    Parent.Controls.Add( control );

                    return Parent.Controls.Contains( control )
                        ? Parent
                        : default( Control );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Control );
                }
            }

            return default( Control );
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name = "x" >
        /// The x.
        /// </param>
        /// <param name = "y" >
        /// The y.
        /// </param>
        /// <returns>
        /// </returns>
        public static Point GetLocation( int x = 1, int y = 1 )
        {
            if( x    > -1
                && y > -1 )
            {
                try
                {
                    return new Point( x, y );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( Point );
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name = "point" >
        /// The point.
        /// </param>
        /// <returns>
        /// </returns>
        public static Point GetLocation( Point point )
        {
            if( point.X    > -1
                && point.Y > -1 )
            {
                try
                {
                    return point;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Point );
                }
            }

            return default( Point );
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name = "size" >
        /// The size.
        /// </param>
        /// <returns>
        /// </returns>
        public static Size GetSize( Size size )
        {
            if( size.Width     > 0
                && size.Width  < SizeConfig.FormMaximum.Width
                && size.Height > 0
                && size.Height < SizeConfig.FormMaximum.Height )
            {
                try
                {
                    return size;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return Size.Empty;
                }
            }

            return Size.Empty;
        }

        /// <summary>
        /// Gets the size.
        /// </summary>
        /// <param name = "width" >
        /// The width.
        /// </param>
        /// <param name = "height" >
        /// The height.
        /// </param>
        /// <returns>
        /// </returns>
        public static Size GetSize( int width, int height )
        {
            if( width     > 0
                && width  < SizeConfig.FormMaximum.Width
                && height > 0
                && height < SizeConfig.FormMaximum.Height )
            {
                try
                {
                    return new Size( width, height );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return Size.Empty;
                }
            }

            return Size.Empty;
        }

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name = "control" >
        /// </param>
        /// <param name = "text" >
        /// The text.
        /// </param>
        public static ToolTip GetToolTip( Control control, string text )
        {
            if( control != null
                && !string.IsNullOrEmpty( text ) )
            {
                try
                {
                    return new ToolTip( control, text );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( ToolTip );
                }
            }

            return default( ToolTip );
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
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