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

        public DataMetric( BindingSource bindingSource, Numeric numeric = Numeric.Amount )
            : base( bindingSource, numeric)
        {
            Total = CalculateTotal( Data, Numeric );
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
        }

        public DataMetric( DataTable dataTable, Numeric numeric = Numeric.Amount )
            : base( dataTable, numeric )
        {
            Total = CalculateTotal( Data, Numeric );
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
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
            Total = CalculateTotal( Data, Numeric );
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
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
            Total = CalculateTotal( Data, Numeric );
            Variance = CalculateVariance( Data, Numeric );
            Deviation = CalculateDeviation( Data, Numeric );
        }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        public Source GetSource( )
        {
            try
            {
                var _source = Data
                    ?.Select( r => r )
                    ?.FirstOrDefault( );

                var _name = _source
                    ?.Table
                    ?.TableName;

                return !string.IsNullOrEmpty( _name )
                    ? _source != null
                        ? (Source)Enum.Parse( typeof( Source ), _name )
                        : Source.NS
                    : Source.NS;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( Source );
            }
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
        public double CalculateDeviations( IEnumerable<DataRow> dataRow, Field field,
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
        /// Calculates the statistics.
        /// </summary>
        /// <returns>
        /// </returns>
        public IDictionary<string, double> CalculateStats()
        {
            try
            {
                var _dict = new Dictionary<string, double>( );
                _dict.Add( "COUNT", double.Parse( Count.ToString( ) ) );
                _dict.Add( "TOTAL", Total );
                _dict.Add( "AVERAGE", Average );
                _dict.Add( "DEVIATION", Deviation );
                _dict.Add( "VARIANCE", Variance );

                return _dict?.Any( ) == true
                    ? _dict
                    : default( IDictionary<string, double> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, double> );
            }
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
        public double CalculateVariances( IEnumerable<DataRow> dataRow, Field field,
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
                    var _metrics = new Dictionary<string, double>(  );
                    _metrics.Add( "COUNT", GetCount( dataRow, numeric ) );
                    _metrics.Add( "TOTAL", CalculateTotal( dataRow, numeric ) );
                    _metrics.Add( "AVERAGE", CalculateAverage( dataRow, numeric ) );
                    _metrics.Add( "DEVIATION", CalculateDeviation( dataRow, numeric ) );
                    _metrics.Add( "VARIANCE", CalculateVariance( dataRow, numeric ) );

                    return _metrics?.Any( ) == true
                        ? _metrics
                        : default( IDictionary<string, double> );
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
                            var _select = dataRow
                                ?.Where( p => p.Field<string>( $"{ field }" ).Equals( filter ) )
                                ?.Select( p => p );

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

        public IDictionary<string, IEnumerable<double>> CalculateStatistics()
        {
            throw new NotImplementedException( );
        }
    }
}
