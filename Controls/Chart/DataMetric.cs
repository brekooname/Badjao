// <copyright file = "DataMetric.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>


namespace BudgetExecution
{
    using System.Diagnostics.CodeAnalysis;
    using LinqStatistics;
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref = "MetricBase"/>
    /// <seealso cref = "IDataMetric"/>
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    public class DataMetric : MetricBase, IDataMetric
    {
        /// <summary>
        /// Gets the variance.
        /// </summary>
        /// <value>
        /// The variance.
        /// </value>
        public double Variance { get; set; }

        /// <summary>
        /// Gets the deviation.
        /// </summary>
        /// <value>
        /// The deviation.
        /// </value>
        public double Deviation { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref = "DataMetric"/> class.
        /// </summary>
        public DataMetric( ) 
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMetric"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="numeric">The numeric.</param>
        public DataMetric( BindingSource bindingSource, Numeric numeric = Numeric.Amount )
            : base( bindingSource, numeric)
        {
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
            Values = CalculateStatistics( Data, Numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="DataMetric"/> class.
        /// </summary>
        /// <param name="dataTable">The data row.</param>
        /// <param name="numeric">The numeric.</param>
        public DataMetric( DataTable dataTable, Numeric numeric = Numeric.Amount )
            : base( dataTable, numeric )
        {
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
            Values = CalculateStatistics( Data, Numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "DataMetric"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        public DataMetric( IEnumerable<DataRow> dataRow, Numeric numeric = Numeric.Amount ) 
            : base( dataRow, numeric )
        {
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
            Values = CalculateStatistics( Data, Numeric  );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "DataMetric"/> class.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        public DataMetric( IEnumerable<DataRow> dataRow, Field field, Numeric numeric = Numeric.Amount )
            : base( dataRow, field, numeric )
        {
            Variance = CalculateVariance( Data, Field, Numeric );
            Deviation = CalculateDeviation( Data, Field, Numeric );
            Values = CalculateStatistics( Data, Field, Numeric );
        }

        /// <summary>
        /// Calculates the deviation.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public double CalculateDeviation( IEnumerable<DataRow> dataRow, Numeric numeric )
        {
            if( dataRow?.Any( ) == true
                && dataRow.HasNumeric( )
                && GetCount( dataRow, numeric ) > 30 )
            {
                try
                {
                    var _query = dataRow
                        ?.Where( p => p.Field<decimal>( $"{ numeric }" ) != 0 )
                        ?.StandardDeviation( p => p.Field<decimal>( $"{ numeric }" ) );

                    return _query > 0 
                        ? double.Parse( _query.ToString( ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the standard deviations.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public double CalculateDeviation( IEnumerable<DataRow> dataRow, Field field,
            Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true
                && Enum.IsDefined( typeof( Field ), field )
                && Enum.IsDefined( typeof( Numeric ), numeric ) )

            {
                if( dataRow?.Count( ) < 30 )
                {
                    return 0.0d;
                }

                if( dataRow.Count( ) > 30 )
                {
                    try
                    {
                        var _query = dataRow
                            ?.Where( p => p.Field<decimal>( $"{ numeric }" ) != 0 )
                            ?.StandardDeviation( p => p.Field<decimal>( $"{ numeric }" ) );

                        return _query > 0
                            ? double.Parse( _query.ToString( ) )
                            : 0.0d;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                        return 0.0d;
                    }
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the variance.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public double CalculateVariance( IEnumerable<DataRow> dataRow, Numeric numeric )
        {
            if( dataRow?.Any( ) == true
                && dataRow.HasNumeric( )
                && GetCount( dataRow, numeric ) > 30 )
            {
                var _table = dataRow.CopyToDataTable( );

                try
                {
                    var _query = _table?.AsEnumerable( )
                        ?.Where( p => p.Field<decimal>( $"{ numeric }" ) != 0 )
                        ?.Variance( p => p.Field<decimal>( $"{ numeric }" ) );

                    return _query > 0
                        ? double.Parse( _query.ToString( ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return default( double );
        }


        /// <summary>
        /// Calculates the variances.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public double CalculateVariance( IEnumerable<DataRow> dataRow, Field field,
            Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true
                && Enum.IsDefined( typeof( Field ), field )
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                var _table = dataRow.CopyToDataTable( );

                try
                {
                    var _query = _table?.AsEnumerable( )
                        ?.Where( p => p.Field<double>( $"{numeric}" ) != 0 )
                        ?.Variance( p => p.Field<double>( $"{ numeric }" ) );

                    return _query > 0
                        ? double.Parse( _query.ToString( ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        [ SuppressMessage( "ReSharper", "BadListLineBreaks" ) ]
        public IDictionary<string, double> CalculateStatistics( IEnumerable<DataRow> dataRow, Numeric numeric )
        {
            if( dataRow?.Any( ) == true
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {

                    if( CalculateTotal( dataRow, Field, numeric ) > 0 )
                    {
                        var _statistics = CalculateStatistics( dataRow, numeric );

                        return _statistics?.Count > 0.0
                            ? _statistics
                            : default( IDictionary<string, double> );
                    }

                    return default( IDictionary<string, double> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, double> );
                }
            }

            return default( IDictionary<string, double> );
        }

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name = "dict" > </param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public IDictionary<string, double> CalculateStatistics( IEnumerable<DataRow> dataRow,
            IDictionary<string, object> dict, Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true
                && dict?.Any( ) == true
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    var _criteria = dict.ToCriteria( );
                    var _table = dataRow.CopyToDataTable( );
                    var _select = _table.Select( _criteria );

                    if( CalculateTotal( _select, Field, numeric ) > 0 )
                    {
                        var _statistics = CalculateStatistics( _select, Field,  numeric );

                        return _statistics?.Count > 0.0
                            ? _statistics
                            : default( IDictionary<string, double> );
                    }

                    return default( IDictionary<string, double> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, double> );
                }
            }

            return default( IDictionary<string, double> );
        }

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "field" >
        /// The field.
        /// </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public IDictionary<string, double> CalculateStatistics( IEnumerable<DataRow> dataRow,
            Field field, Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true
                && Enum.IsDefined( typeof( Field ), field )
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    var _codes = GetCodes( dataRow, field );
                    if( _codes?.Any( ) == true )
                    {
                        foreach( var filter in _codes )
                        {
                            var _select = dataRow.Filter( field.ToString(), filter );
                            if( CalculateTotal( _select, numeric ) > 0 )
                            {
                                var _statistics = CalculateStatistics( _select, numeric );

                                return _statistics?.Count > 0.0
                                    ? _statistics
                                    : default( IDictionary<string, double> );
                            }
                        }
                        
                        return default( IDictionary<string, double> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, double> );
                }
            }

            return default( IDictionary<string, double> );
        }

        /// <summary>
        /// Calculates the statistics.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, double> CalculateStatistics()
        {
            try
            {
                var _stats = new Dictionary<string, double>(  );
                _stats.Add( "COUNT", Count );
                _stats.Add( "TOTAL", Total );
                _stats.Add( "AVERAGE", Average );

                return _stats?.Any(  ) == true
                    ? _stats
                    : default( IDictionary<string, double> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, double> );
            }
        }
    }
}
