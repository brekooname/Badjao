﻿// <copyright file = "TitleInfo.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using Syncfusion.Windows.Forms.Chart;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ITitleInfo" />
    [ SuppressMessage( "ReSharper", "GCSuppressFinalizeForTypeWithoutDestructor" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class TitleInfo : ITitleInfo
    {
        /// <summary>
        /// Gets the main.
        /// </summary>
        /// <value>
        /// The main.
        /// </value>
        public string Main { get; }

        /// <summary>
        /// Gets the axis.
        /// </summary>
        /// <value>
        /// The axis.
        /// </value>
        public string Axis { get; }

        /// <summary>
        /// Initializes a new instance of the <see cref="TitleInfo"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        public TitleInfo( string main )
        {
            Main = main;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TitleInfo"/> class.
        /// </summary>
        /// <param name="main">The main.</param>
        /// <param name="axis">The axis.</param>
        public TitleInfo( string main, string axis )
            : this( main )
        {
            Axis = axis;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TitleInfo"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        public TitleInfo( IDictionary<string, string> title )
        {
            Main = title.ContainsKey( "Main" )
                ? title[ "Main" ]
                : default( string );

            Axis = title.ContainsKey( "Axis" )
                ? title[ "Main" ]
                : default( string );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="TitleInfo"/> class.
        /// </summary>
        /// <param name="title">The title.</param>
        public TitleInfo( IList<string> title )
        {
            Main = title[ 0 ] ?? string.Empty;
            Axis = title[ 1 ] ?? string.Empty;
        }

        /// <summary>
        /// Sets the main title.
        /// </summary>
        /// <returns></returns>
        public string GetMainText( )
        {
            if( !string.IsNullOrEmpty( Main ) )
            {
                try
                {
                    return Main;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary>
        /// Sets the axis title.
        /// </summary>
        /// <returns></returns>
        public string GetAxisText( )
        {
            if( !string.IsNullOrEmpty( Axis ) )
            {
                try
                {
                    return Axis;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary>
        /// Sets the data.
        /// </summary>
        /// <param name="main">The main.</param>
        /// <param name="axis">The axis.</param>
        /// <returns></returns>
        public IDictionary<string, string> SetData( string main, string axis )
        {
            if( !string.IsNullOrEmpty( main )
                && !string.IsNullOrEmpty( axis ) )
            {
                try
                {
                    Dictionary<string, string> data = new Dictionary<string, string>
                        { [ "Main" ] = main, [ "Axis" ] = axis };

                    return data;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, string> );
                }
            }

            return default( IDictionary<string, string> );
        }

        /// <summary>
        /// Gets the main title.
        /// </summary>
        /// <returns></returns>
        public ChartTitle GetChartMainTitle( )
        {
            if( !string.IsNullOrEmpty( Main ) )
            {
                try
                {
                    using ChartTitle _title = new ChartTitle( );
                    _title.Text = Main;
                    _title.ForeColor = Color.FromArgb( 141, 139, 138 );
                    _title.Visible = true;
                    _title.Font = new Font( "Roboto", 9 );
                    _title.BackColor = Color.FromArgb( 15, 15, 15 );
                    return _title;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( ChartTitle );
                }
            }

            return default( ChartTitle );
        }

        /// <summary>
        /// Gets the axis title.
        /// </summary>
        /// <returns></returns>
        public ChartTitle GetChartAxisTitle( )
        {
            if( !string.IsNullOrEmpty( Axis ) )
            {
                try
                {
                    using ChartTitle _title = new ChartTitle( );
                    _title.Text = Main;
                    _title.ForeColor = Color.FromArgb( 141, 139, 138 );
                    _title.Visible = true;
                    _title.Font = new Font( "Roboto", 9 );
                    _title.BackColor = Color.FromArgb( 15, 15, 15 );
                    return _title;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( ChartTitle );
                }
            }

            return default( ChartTitle );
        }

        /// <summary>
        /// Gets the main title.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="font">The font.</param>
        /// <returns></returns>
        public ChartTitle GetChartMainTitle( Color color, Font font )
        {
            if( !color.IsEmpty
                && font != null )
            {
                try
                {
                    using ChartTitle _title = new ChartTitle( );
                    _title.Text = Main;
                    _title.Visible = true;
                    _title.Font = font;
                    _title.ForeColor = color;
                    _title.BackColor = Color.FromArgb( 15, 15, 15 );
                    return _title;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( ChartTitle );
                }
            }

            return default( ChartTitle );
        }

        /// <summary>
        /// Gets the axis title.
        /// </summary>
        /// <param name="color">The color.</param>
        /// <param name="font">The font.</param>
        /// <returns></returns>
        public ChartTitle GetChartAxisTitle( Color color, Font font )
        {
            if( !color.IsEmpty
                && font != null )
            {
                try
                {
                    using ChartTitle _title = new ChartTitle( );
                    _title.Text = Main;
                    _title.Visible = true;
                    _title.Font = font;
                    _title.ForeColor = color;
                    _title.BackColor = Color.FromArgb( 15, 15, 15 );
                    return _title;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( ChartTitle );
                }
            }

            return default( ChartTitle );
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
        protected void Fail( Exception ex )
        {
            using Error _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}