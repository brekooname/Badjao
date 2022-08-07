﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ISource" />
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public interface IModelBuilder : ISource
    {
        /// <summary>
        /// Gets the record.
        /// </summary>
        /// <returns></returns>
        DataRow GetRecord( );

        /// <summary>
        /// Gets the column ordinals.
        /// </summary>
        /// <returns></returns>
        IEnumerable<int> GetColumnOrdinals( );

        /// <summary>
        /// Gets the fields.
        /// </summary>
        /// <returns></returns>
        IEnumerable<Field> GetFields( );

        /// <summary>
        /// Gets the elements.
        /// </summary>
        /// <returns></returns>
        IEnumerable<IElement> GetElements( );
        
        /// <summary>
        /// Gets the Data.
        /// </summary>
        /// <returns></returns>
        IEnumerable<DataRow> GetData( );

        /// <summary>
        /// Gets the Data table.
        /// </summary>
        /// <returns></returns>
        DataTable GetDataTable( );

        /// <summary>
        /// Gets the Data set.
        /// </summary>
        /// <returns></returns>
        DataSet GetDataSet( );

        /// <summary>
        /// Gets the column schema.
        /// </summary>
        /// <returns></returns>
        DataColumnCollection GetColumnSchema( );

        /// <summary>
        /// Gets the data columns.
        /// </summary>
        /// <returns></returns>
        IEnumerable<DataColumn> GetDataColumns( );

            /// <summary>
        /// Gets the primary indexes.
        /// </summary>
        /// <param name="data">The Data.</param>
        /// <returns></returns>
        IEnumerable<int> GetPrimaryIndexes( IEnumerable<DataRow> data );
    }
}