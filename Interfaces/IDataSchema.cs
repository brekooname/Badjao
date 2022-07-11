﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;

    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    public interface IDataSchema
    {
        /// <summary> Sets the column names. </summary>
        /// <returns> </returns>
        IEnumerable<string> GetColumnNames();

        /// <summary> Gets the column captions. </summary>
        /// <returns> </returns>
        IEnumerable<string> GetColumnCaptions();

        /// <summary> Gets the column ordinals. </summary>
        /// <returns> </returns>
        IEnumerable<int> GetColumnOrdinals();

        /// <summary> Sets the column types. </summary>
        /// <returns> </returns>
        IEnumerable<Type> GetColumnTypes();

        /// <summary> Sets the primary keys. </summary>
        /// <returns> </returns>
        IEnumerable<int> GetIndexes();

        /// <summary> Gets the primary key columns. </summary>
        /// <returns> </returns>
        IEnumerable<DataColumn> GetPrimaryKeyColumn();

        /// <summary> Gets the column schema. </summary>
        /// <returns> </returns>
        DataColumnCollection GetColumnSchema();

        /// <summary> Gets the schema table. </summary>
        /// <returns> </returns>
        DataTable GetSchemaTable();

        /// <summary> Gets the Data Table. </summary>
        /// <returns> </returns>
        DataTable GetDataTable();

        /// <summary> Gets the name of the Table. </summary>
        /// <returns> </returns>
        string GetTableName();

        /// <summary> Gets the Data. </summary>
        /// <returns> </returns>
        IEnumerable<DataRow> GetData();
    }
}