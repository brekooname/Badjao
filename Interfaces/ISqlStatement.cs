// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;

    /// <summary>
    /// 
    /// </summary>
    public interface ISqlStatement
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        SQL CommandType { get; set; }

        /// <summary>
        /// Gets or sets the name of the file.
        /// </summary>
        /// <value>
        /// The name of the file.
        /// </value>
        string FileName { get; set; }

        /// <summary>
        /// Gets or sets the command text.
        /// </summary>
        /// <value>
        /// The command text.
        /// </value>
        string CommandText { get; set; }

        /// <summary>
        /// Gets or sets the columns.
        /// </summary>
        /// <value>
        /// The columns.
        /// </value>
        IEnumerable<string> Columns { get; set; }

        /// <summary>
        /// Gets or sets the updates.
        /// </summary>
        /// <value>
        /// The updates.
        /// </value>
        IDictionary<string, object> Updates { get; set; }

        /// <summary>
        /// Gets or sets the criteria.
        /// </summary>
        /// <value>
        /// The criteria.
        /// </value>
        IDictionary<string, object> Criteria { get; set; }

        /// <summary>
        /// Gets or sets the name of the table.
        /// </summary>
        /// <value>
        /// The name of the table.
        /// </value>
        string TableName { get; set; }

        /// <summary>
        /// Gets the select statement.
        /// </summary>
        /// <returns></returns>
        string GetSelectStatement( );

        /// <summary>
        /// Creates the select statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        string CreateSelectStatement( IDictionary<string, object> dict );

        /// <summary>
        /// Gets the update statement.
        /// </summary>
        /// <returns></returns>
        string GetUpdateStatement( );

        /// <summary>
        /// Creates the update statement.
        /// </summary>
        /// <param name = "updates" > </param>
        /// <param name="where">The where.</param>
        /// <returns></returns>
        string CreateUpdateStatement( IDictionary<string, object> updates, IDictionary<string, object> where );

        /// <summary>
        /// Gets the insert statement.
        /// </summary>
        /// <returns></returns>
        string GetInsertStatement( );

        /// <summary>
        /// Creates the insert statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        string CreateInsertStatement( IDictionary<string, object> dict);

        /// <summary>
        /// Gets the delete statement.
        /// </summary>
        /// <returns></returns>
        string GetDeleteStatement( );

        /// <summary>
        /// Creates the delete statement.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <returns></returns>
        string CreateDeleteStatement( IDictionary<string, object> dict );
    }
}