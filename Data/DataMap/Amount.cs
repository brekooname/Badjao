﻿// <copyright file = "Amount.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IAmount" />
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "ArrangeModifiersOrder" ) ]
    public class Amount : DataUnit, IAmount
    {
        /// <summary>
        /// The default
        /// </summary>
        public static readonly IAmount Default = new Amount( Numeric.NS, 0.0 );

        /// <summary>
        /// The funding
        /// </summary>
        public double Funding { get; set; }

        /// <summary>
        /// The initial
        /// </summary>
        public double Initial { get; set; }

        /// <summary>
        /// The delta
        /// </summary>
        public double Delta { get; set; }

        /// <summary>
        /// The numeric
        /// </summary>
        public Numeric Numeric { get; set; } = Numeric.Amount;

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        public Amount( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        /// <param name="numeric">The numeric.</param>
        /// <param name="value">The value.</param>
        public Amount( Numeric numeric = Numeric.Amount, double value = 0.0 )
        {
            Funding = value;
            Numeric = numeric;
            Initial = Funding;
            Delta = Initial - Funding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        /// <param name="value">The value.</param>
        /// <param name="numeric">The numeric.</param>
        public Amount( double value = 0d, Numeric numeric = Numeric.Amount )
        {
            Funding = value;
            Numeric = numeric;
            Initial = Funding;
            Delta = Initial - Funding;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="Amount"/> class.
        /// </summary>
        /// <param name="dataRow">The Data row.</param>
        /// <param name="numeric">The numeric.</param>
        public Amount( DataRow dataRow, Numeric numeric = Numeric.Amount )
        {
            Funding = double.Parse( dataRow[ $"{numeric}" ].ToString( ) );
            Numeric = numeric;
            Initial = Funding;
            Delta = Initial - Funding;
        }

        /// <summary>
        /// Gets the numeric.
        /// </summary>
        /// <returns></returns>
        public Numeric GetNumeric( )
        {
            try
            {
                return Enum.IsDefined( typeof( Numeric ), Numeric )
                    ? Numeric
                    : Numeric.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Numeric );
            }
        }

        /// <summary>
        /// Gets the original.
        /// </summary>
        /// <returns></returns>
        public double GetOriginal( )
        {
            try
            {
                return Initial > 0
                    ? Initial
                    : Default.Funding;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return 0;
            }
        }

        /// <summary>
        /// Gets the delta.
        /// </summary>
        /// <returns></returns>
        public double GetDelta( )
        {
            try
            {
                return Delta != 0
                    ? Delta
                    : Default.Funding;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return Default.Funding;
            }
        }

        /// <summary>
        /// Increases the specified amount.
        /// </summary>
        /// <param name="increment">The amount.</param>
        public void Increase( double increment = 0d )
        {
            try
            {
                Delta = increment;
                Funding += Delta;

                if( Initial != Funding )
                {
                    //unfinished
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Decreases the specified amount.
        /// </summary>
        /// <param name="decrement">The amount.</param>
        public void Decrease( double decrement = 0d )
        {
            try
            {
                Delta = decrement;

                if( Funding > decrement )
                {
                    Funding -= decrement;
                }

                if( Initial != Funding )
                {
                    // Unfinished
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Determines whether the specified amount is equal.
        /// </summary>
        /// <param name="amount">The amount.</param>
        /// <returns>
        ///   <c>true</c> if the specified amount is equal; otherwise, <c>false</c>.
        /// </returns>
        public bool IsEqual( IAmount amount )
        {
            if( amount?.Funding != Default.Funding )
            {
                try
                {
                    if( amount?.Funding == Funding
                        && amount?.Numeric.ToString( )?.Equals( Numeric.ToString( ) ) == true )
                    {
                        return true;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Determines whether the specified first is equal.
        /// </summary>
        /// <param name="first">The first.</param>
        /// <param name="second">The second.</param>
        /// <returns>
        ///   <c>true</c> if the specified first is equal; otherwise, <c>false</c>.
        /// </returns>
        public static bool IsEqual( IAmount first, IAmount second )
        {
            if( first?.Funding != Default.Funding
                && second?.Funding != Default.Funding )
            {
                try
                {
                    if( first?.Funding.Equals( second?.Funding ) == true
                        && first?.Numeric.ToString( ).Equals( second?.Numeric.ToString( ) )
                        == true )
                    {
                        return true;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return false;
                }
            }

            return false;
        }

        /// <summary>
        /// Called when [changed].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event Data.</param>
        public void OnChanged( object sender, EventArgs e )
        {
            try
            {
                using Message _message = new Message( "Not Yet Implemented" );
                _message.Show( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}