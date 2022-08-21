﻿// <copyright file = "IConnectionBuilder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data.Common;

    /// <summary>
    /// </summary>
    public interface IConnectionBuilder
    {
        /// <summary>
        /// Gets or sets the connection.
        /// </summary>
        /// <value>
        /// The connection.
        /// </value>
        DbConnection Connection { get; set; }

        /// <summary>
        /// Gets the source.
        /// </summary>
        /// <returns>
        /// </returns>
        Source Source { get; set; }

        /// <summary>
        /// Gets the provider.
        /// </summary>
        /// <returns>
        /// </returns>
        Provider Provider { get; set; }

        /// <summary>
        /// Gets the name of the file.
        /// </summary>
        /// <returns>
        /// </returns>
        string FileName { get; set; }

        /// <summary>
        /// Gets the provider path.
        /// </summary>
        /// <returns>
        /// </returns>
        string ProviderPath { get; set; }

        /// <summary>
        /// Gets the connection string.
        /// </summary>
        /// <returns>
        /// </returns>
        string ConnectionString { get; set; }

        /// <summary>
        /// Gets the name of the table.
        /// </summary>
        /// <returns>
        /// </returns>
        string TableName { get; set; }
    }
}