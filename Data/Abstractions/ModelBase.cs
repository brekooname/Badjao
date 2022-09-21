// <copyright file = "ModelBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
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
                DataColumnCollection _columns = GetDataTable( )?.Columns;
                List<int> _values = new List<int>( );

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
                    DataColumnCollection _columns = Record.Table?.Columns;

                    if( _columns?.Count > 0 )
                    {
                        Dictionary<string, Type> _schema = new Dictionary<string, Type>( );

                        foreach( DataColumn col in _columns )
                        {
                            _schema.Add( col.ColumnName, col.DataType );
                        }

                        return _schema?.Any( ) == true
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
            if( Record != null )
            {
                try
                {
                    List<IElement> _elements = new List<IElement>( );
                    DataColumnCollection _columns = Record?.Table?.Columns;
                    string[ ] _fields = Enum.GetNames( typeof( Field ) );

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
                    string _criteria = dict.ToCriteria( );
                    DataTable _dataTable = dataRows.CopyToDataTable( );
                    DataRow[ ] _data = _dataTable.Select( _criteria );

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
                    List<DataColumn> _dataColumns = new List<DataColumn>( );
                    DataColumnCollection _data = dataTable?.Columns;

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
        public IEnumerable<DataColumn> GetDataColumns( )
        {
            if( DataTable != null
                && DataTable?.Columns?.Count > 0 )
            {
                try
                {
                    List<DataColumn> _dataColumns = new List<DataColumn>( );
                    DataColumnCollection _data = DataTable?.Columns;

                    if( _data?.Count > 0 )
                    {
                        foreach( DataColumn column in _data )
                        {
                            if( column != null )
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