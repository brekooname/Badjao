﻿// <copyright file = "BudgetBinding.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;

    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "UnusedType.Global" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" )]
    public class BindingSource : BindingData, IBindingSource
    {
        /// <summary>
        /// Initializes a new instance of the <see cref = "BindingSource"/> class.
        /// </summary>
        public BindingSource()
        {
        }

        [SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" )]
        public BindingSource( IEnumerable<DataRow> dataRows )
        {
            DataTable = dataRows?.CopyToDataTable( );
            DataSet = DataTable?.DataSet;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable?.TableName );
            DataSource = DataTable;
            Record = (DataRow)Current;
            Index = Position;
            AllowNew = false;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="BindingSource"/> class.
        /// </summary>
        /// <param name="dataTable">The dataTable.</param>
        [SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" )]
        public BindingSource( DataTable dataTable )
        {
            DataTable = dataTable;
            DataSet = DataTable?.DataSet;
            DataSource = DataTable;
            Source = (Source)Enum.Parse( typeof( Source ), DataTable?.TableName );
            Record = (DataRow)Current;
            Index = Position;
            AllowNew = false;
        }

        /// <summary>
        /// Sets the data filter.
        /// </summary>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        public void SetDataFilter( Field field, string filter )
        {
            if( Validate.IsField( field )
                && !string.IsNullOrEmpty( filter ) )
            {
                try
                {
                    var _dataFilter = new Dictionary<string, object>
                    {
                        {
                            $"{field}", filter
                        }
                    };

                    DataFilter = _dataFilter?.Any( ) == true
                        ? _dataFilter
                        : default( Dictionary<string, object> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the data filter.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        public void SetDataFilter( IDictionary<string, object> dict )
        {
            if( Verify.IsMap( dict ) )
            {
                try
                {
                    if( DataFilter?.Count > 0 )
                    {
                        DataFilter.Clear( );
                    }

                    foreach( var kvp in dict )
                    {
                        if( !string.IsNullOrEmpty( kvp.Key )
                            && kvp.Value != null )
                        {
                            DataFilter?.Add( kvp.Key, kvp.Value );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Gets the data set.
        /// </summary>
        /// <returns></returns>
        public DataSet GetDataSet()
        {
            try
            {
                return Verify.IsTable( DataSet )
                    ? DataSet
                    : default( DataSet );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( DataSet );
            }
        }
    }
}