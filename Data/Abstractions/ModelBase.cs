﻿// <copyright file="BuilderBase.cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DataAccess" />
    public abstract class ModelBase : DataAccess
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="ModelBase"/> class.
        /// </summary>
        protected ModelBase( )
        {
        }

        /// <summary>
        /// Gets the column ordinals.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<int> GetColumnOrdinals( )
        {
            try
            {
                var _columns = GetDataTable( )?.Columns;
                var _values = new List<int>( );

                if( _columns?.Count > 0 )
                {
                    foreach( DataColumn _dataColumn in _columns )
                    {
                        _values?.Add( _dataColumn.Ordinal );
                    }
                }

                return _values?.Any( ) == true
                    ? _values
                    : default( IEnumerable<int> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<int> );
            }
        }

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, Type> GetSchemaDictionary( )
        {
            if( Record != null )
            {
                try
                {
                    var _columns = Record.Table?.Columns;

                    if( _columns?.Count > 0 )
                    {
                        var _schema = new Dictionary<string, Type>( );

                        foreach( DataColumn col in _columns )
                        {
                            _schema.Add( col.ColumnName, col.DataType );
                        }

                        return _schema?.Any(   ) == true
                            ? _schema
                            : default( IDictionary<string, Type> );
                    }
                    else
                    {
                        return default( IDictionary<string, Type> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, Type> );
                }
            }

            return default( IDictionary<string, Type> );
        }

        /// <summary>
        /// Gets the elements.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<IElement> GetElements( )
        {
            if ( Record != null )
            {
                try
                {
                    var _elements = new List<IElement>( );
                    var _columns = Record?.Table?.Columns;
                    var _fields = Enum.GetNames( typeof( Field ) );

                    if( _columns?.Count > 0 )
                    {
                        foreach( DataColumn column in _columns )
                        {
                            if( column?.DataType == typeof( string )
                                && _fields?.Contains( column?.ColumnName ) == true )
                            {
                                _elements?.Add( new Element( Record, column?.ColumnName ) );
                            }
                        }

                        return _elements?.Any( ) == true
                            ? _elements
                            : default( IEnumerable<IElement> );
                    }
                    else
                    {
                        return default( IEnumerable<IElement> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<IElement> );
                }
            }

            return default( IEnumerable<IElement> );
        }

        /// <summary>
        /// Filters the data.
        /// </summary>
        /// <param name = "dataRows" > </param>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        public IEnumerable<DataRow> FilterData( IEnumerable<DataRow> dataRows, 
            IDictionary<string, object> dict )
        {
            if( dict?.Any( ) == true 
                && dataRows?.Any( ) == true )
            {
                try
                {
                    var _criteria = dict.ToCriteria( );
                    var _dataTable = dataRows.CopyToDataTable( );
                    var _data = _dataTable.Select( _criteria );

                    return _data?.Length > 0
                        ? _data
                        : default( IEnumerable<DataRow> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataRow> );
                }
            }

            return default( IEnumerable<DataRow> );
        }

        /// <summary>
        /// Gets the columns.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DataColumn> GetDataColumns( DataTable dataTable )
        {
            if( dataTable?.Columns?.Count > 0 )
            {
                try
                {
                    var _dataColumns = new List<DataColumn>( );
                    var _data = dataTable?.Columns;

                    if( _data?.Count > 0 )
                    {
                        foreach( DataColumn column in _data )
                        {
                            _dataColumns.Add( column );
                        }

                        return _dataColumns?.Any( ) == true
                            ? _dataColumns
                            : default( IEnumerable<DataColumn> );
                    }
                    else
                    {
                        return default( IEnumerable<DataColumn> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataColumn> );
                }
            }

            return default( IEnumerable<DataColumn> );
        }


        /// <summary>
        /// Gets the columns.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<DataColumn> GetDataColumns(  )
        {
            if( DataTable != null 
                && DataTable?.Columns?.Count > 0 )
            {
                try
                {
                    var _dataColumns = new List<DataColumn>( );
                    var _data = DataTable?.Columns;
                    if( _data?.Count > 0 )
                    {
                        foreach( DataColumn column in _data )
                        {
                            if ( column != null )
                            {
                                _dataColumns.Add( column );
                            }
                        }

                        return _dataColumns?.Any( ) == true
                            ? _dataColumns
                            : default( IEnumerable<DataColumn> );
                    }
                    else
                    {
                        return default( IEnumerable<DataColumn> );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DataColumn> );
                }
            }

            return default( IEnumerable<DataColumn> );
        }
    }
}