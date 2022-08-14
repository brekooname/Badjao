// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "BadListLineBreaks" )]
    [SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" )]
    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class MetricBase 
    {
        /// <summary>
        /// Gets the source.
        /// </summary>
        public virtual Source Source { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        public virtual string TableName { get; set; }

        /// <summary>
        /// The field
        /// </summary>
        public virtual Field Field { get; set; }

        /// <summary>
        /// The numeric
        /// </summary>
        public virtual Numeric Numeric { get; set; }

        /// <summary>
        /// The dataRow
        /// </summary>
        public virtual IEnumerable<DataRow> Data { get; set; }

        /// <summary>
        /// The count
        /// </summary>
        public virtual int Count { get; set; }

        /// <summary>
        /// The total
        /// </summary>
        public virtual double Total { get; set; }

        /// <summary>
        /// The average
        /// </summary>
        public virtual double Average { get; set; }

        /// <summary>
        /// Gets or sets the categories.
        /// </summary>
        /// <value>
        /// The categories.
        /// </value>
        public virtual IEnumerable<string> Categories { get; set; }

        /// <summary>
        /// Gets or sets the amounts.
        /// </summary>
        /// <value>
        /// The amounts.
        /// </value>
        public virtual IEnumerable<double> Amounts { get; set; }
        
        /// <summary>
        /// The statistics
        /// </summary>
        public virtual IDictionary<string, double> Values { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        protected MetricBase( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="numeric">The numeric.</param>
        protected MetricBase( BindingSource bindingSource, Numeric numeric = Numeric.Amount  )
        {
            Data = ( (DataTable)bindingSource.DataSource ).AsEnumerable( )?.ToList( );
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ),( (DataTable)bindingSource.DataSource ).TableName );
            Numeric = numeric;
            Total = CalculateTotal( ( (DataTable)bindingSource.DataSource ).AsEnumerable( )?.ToList( ), numeric );
            Count = GetCount( ( (DataTable)bindingSource.DataSource ).AsEnumerable( )?.ToList( ), numeric );
            Average = CalculateAverage( ( (DataTable)bindingSource.DataSource ).AsEnumerable( )?.ToList( ), numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        /// <param name="bindingSource">The binding source.</param>
        /// <param name="field">The field.</param>
        /// <param name="numeric">The numeric.</param>
        protected MetricBase( BindingSource bindingSource, Field field, Numeric numeric = Numeric.Amount )
        {
            Data = ( (DataTable)bindingSource.DataSource ).AsEnumerable( )?.ToList( );
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), ( (DataTable)bindingSource.DataSource ).TableName );
            Numeric = numeric;
            Field = field;
            Total = CalculateTotal( ( (DataTable)bindingSource.DataSource ).AsEnumerable( )?.ToList( ), numeric );
            Count = GetCount( ( (DataTable)bindingSource.DataSource ).AsEnumerable( )?.ToList( ), numeric );
            Average = CalculateAverage( ( (DataTable)bindingSource.DataSource ).AsEnumerable( )?.ToList( ), numeric );
        }

        protected MetricBase( BindingSource bindingSource, IDictionary<string, object> dict, Numeric numeric = Numeric.Amount )
        {
            Data = ( (DataTable)bindingSource.DataSource ).Select( dict.ToCriteria( ));
            TableName = ( (DataTable)bindingSource.DataSource ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), ( (DataTable)bindingSource.DataSource ).TableName );
            Numeric = numeric;
            Total = CalculateTotal( ( (DataTable)bindingSource.DataSource ).AsEnumerable( )?.ToList( ), numeric );
            Count = GetCount( ( (DataTable)bindingSource.DataSource ).AsEnumerable( )?.ToList( ), numeric );
            Average = CalculateAverage( ( (DataTable)bindingSource.DataSource ).AsEnumerable( )?.ToList( ), numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        /// <param name="dataTable">The data row.</param>
        /// <param name="numeric">The numeric.</param>
        protected MetricBase( DataTable dataTable, Numeric numeric = Numeric.Amount )
        {
            Data = dataTable.AsEnumerable( );
            TableName = dataTable.TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataTable.TableName );
            Numeric = numeric;
            Count = Data.Count( );
            Total = CalculateTotal( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        protected MetricBase( DataSet dataSet, Numeric numeric = Numeric.Amount )
        {
            Data = dataSet.Tables[ 0 ].AsEnumerable( );
            TableName = dataSet.Tables[ 0 ].TableName;
            Source = (Source)Enum.Parse( typeof( Source ), TableName );
            Numeric = numeric;
            Count = Data.Count( );
            Total = CalculateTotal( Data, numeric );
            Average = CalculateAverage( Data, numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="numeric">The numeric.</param>
        protected MetricBase( IEnumerable<DataRow> dataRow, Numeric numeric = Numeric.Amount )
        {
            Data = dataRow;
            TableName = dataRow.CopyToDataTable( ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataRow.CopyToDataTable( ).TableName );
            Numeric = numeric;
            Count = dataRow.Count( );
            Total = CalculateTotal( dataRow, numeric );
            Average = CalculateAverage( dataRow, numeric );
        }

        protected MetricBase( IEnumerable<DataRow> dataRow, IDictionary<string, object> dict, Numeric numeric = Numeric.Amount )
        {
            Numeric = numeric;
            Data = dataRow.Filter( dict );
            TableName = dataRow.CopyToDataTable( ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataRow.CopyToDataTable( ).TableName );
            Count = Data.Count( );
            Total = CalculateTotal( Data, Numeric );
            Average = CalculateAverage( Data, Numeric );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="MetricBase"/> class.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name="field">The field.</param>
        /// <param name="numeric">The numeric.</param>
        protected MetricBase( IEnumerable<DataRow> dataRow, Field field, Numeric numeric = Numeric.Amount )
        {
            Field = field;
            Numeric = numeric;
            Data = dataRow;
            TableName = dataRow.CopyToDataTable( ).TableName;
            Source = (Source)Enum.Parse( typeof( Source ), dataRow.CopyToDataTable( ).TableName );
            Count = dataRow.Count( );
            Total = CalculateTotal( dataRow, numeric );
            Average = CalculateAverage( dataRow, Numeric );
        }

        /// <summary>
        /// Gets the codes.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="field">The field.</param>
        /// <returns></returns>
        public static IEnumerable<string> GetCodes( IEnumerable<DataRow> dataRow, Field field )
        {
            if( dataRow?.Any( ) == true
                && Enum.IsDefined( typeof( Field ), field ))
            {
                try
                {
                    var _query = dataRow
                        ?.Select( p => p.Field<string>( $"{ field }" ) )
                        ?.Distinct( )
                        ?.ToArray( );

                    return _query.Length > 0
                        ? _query
                        : default( string[ ] );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }

        /// <summary>
        /// Gets the codes.
        /// </summary>
        /// <param name="dataRow">The data row.</param>
        /// <param name = "dict" > </param>
        /// <returns></returns>
        public static IEnumerable<string> GetCodes( IEnumerable<DataRow> dataRow, IDictionary<string, object> dict )
        {
            if( dataRow?.Any( ) == true
                && dict?.Any( ) == true )
            {
                try
                {
                    var _criteria = dict?.ToCriteria( );
                    if( !string.IsNullOrEmpty( _criteria ) )
                    {
                        var _query = dataRow.CopyToDataTable( ).Select( _criteria );
                        var _columns = _query.CopyToDataTable( ).Columns;
                        var _names = new string[ _columns.Count ];

                        for( var i = 0; i < _columns.Count; i++ )
                        {
                            _names[ i ] = _columns[ i ].ColumnName;
                        }

                        return _names.Length > 0
                            ? _names
                            : default( string[ ] );
                    }

                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<string> );
                }
            }

            return default( IEnumerable<string> );
        }
        
        /// <summary>
        /// Gets the count.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public virtual int GetCount( IEnumerable<DataRow> dataRow, Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true )
            {
                try
                {
                    var _select = dataRow
                        ?.Where( p => p.Field<decimal>( $"{ numeric }" ) != 0 )
                        ?.Select( p => p );

                    return _select?.Any( ) == true
                        ? _select.Count( )
                        : default( int );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0;
                }
            }

            return 0;
        }

        /// <summary>
        /// Calculates the totals.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public virtual double CalculateTotal( IEnumerable<DataRow> dataRow, Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true )
            {
                try
                {
                    var _select = dataRow
                        ?.Select( p => p.Field<decimal>( $"{ numeric }" ) );

                    return _select?.Any( ) == true && _select?.Sum( ) > 0
                        ? double.Parse( _select.Sum( ).ToString( ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( double );
        }

        /// <summary>
        /// Calculates the totals.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="field">The field.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public virtual IDictionary<string, double> CalculateTotals( IEnumerable<DataRow> dataRow, Field field,
            Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true
                && Enum.IsDefined( typeof( Field ), field )
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    var _codes = GetCodes( dataRow, field );
                    var _dict = new Dictionary<string, double>( );

                    if( _codes?.Any( ) == true )
                    {
                        foreach( var filter in _codes )
                        {
                            var _sum = dataRow.Filter( field.ToString( ), filter )
                                ?.Sum( p => p.Field<decimal>( $"{ numeric }" ) );
                            
                            _dict.Add( filter, double.Parse( _sum.ToString( ) ) );
                        }
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
        /// Calculates the average.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        protected double CalculateAverage( IEnumerable<DataRow> dataRow, Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    var _query = dataRow
                        .Where( p => p.Field<decimal>( $"{ numeric }" ) != 0 )
                        ?.Select( p => p.Field<decimal>( $"{ numeric }" ) )
                        ?.Average( );

                    return _query > 0
                        ? double.Parse( _query?.ToString( ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return 0.0d;
        }

        /// <summary>
        /// Calculates the totals.
        /// </summary>
        /// <param name = "dataRow" >
        /// The dataRow.
        /// </param>
        /// <param name = "dict" > </param>
        /// <param name = "numeric" >
        /// The numeric.
        /// </param>
        /// <returns>
        /// </returns>
        public double CalculateTotal( IEnumerable<DataRow> dataRow, IDictionary<string, object> dict, Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true
                && dict?.Any( ) == true
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    var _query = dataRow.Filter( dict )
                        ?.Where( p => p.Field<decimal>( $"{ numeric }" ) != 0 )
                        ?.Select( p => p.Field<decimal>( $"{ numeric }" ) )
                        ?.Sum( );

                    return _query > 0
                        ? double.Parse( _query?.ToString( ) )
                        : 0.0d;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return 0.0d;
                }
            }

            return 0.0d;
        }

        /// <summary>
        /// Calculates the averages.
        /// </summary>
        /// <param name="dataRow">The dataRow.</param>
        /// <param name="field">The field.</param>
        /// <param name="numeric">The numeric.</param>
        /// <returns></returns>
        public virtual IDictionary<string, double> CalculateAverages( IEnumerable<DataRow> dataRow, Field field,
            Numeric numeric = Numeric.Amount )
        {
            if( dataRow?.Any( ) == true
                && Enum.IsDefined( typeof( Field ), field )
                && Enum.IsDefined( typeof( Numeric ), numeric ) )
            {
                try
                {
                    var _dictionary = new Dictionary<string, double>( );
                    var _filters = GetCodes( dataRow, field );

                    if( _filters.Any( ) )
                    {
                        foreach( var filter in _filters )
                        {
                            var _query = dataRow?.Filter( field.ToString( ), filter );

                            if( _query?.Any( ) == true )
                            {
                                var _value = CalculateAverage( _query, numeric );

                                if( _value > 0 )
                                {
                                    _dictionary?.Add( filter, _value );
                                }
                            }
                        }

                        return _dictionary?.Any( ) == true
                            ? _dictionary
                            : default( Dictionary<string, double> );
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
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}