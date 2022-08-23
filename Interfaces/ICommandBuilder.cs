﻿// <copyright file = "ICommandBuilder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Data.Common;

    /// <summary>
    /// 
    /// </summary>
    public interface ICommandBuilder
    {
        /// <summary>
        /// The command
        /// </summary>
        DbCommand Command { get; set; }

        /// <summary>
        /// The connection builder
        /// </summary>
        IConnectionBuilder ConnectionBuilder { get; }

        /// <summary>
        /// The provider
        /// </summary>
        Provider Provider { get; }

        /// <summary>
        /// The source
        /// </summary>
        Source Source { get; }

        /// <summary>
        /// The SQL statement
        /// </summary>
        ISqlStatement SqlStatement { get; }

        /// <summary>
        /// Sets the command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        DbCommand GetCommand( ISqlStatement sqlStatement );

        /// <summary>
        /// Gets the sq lite command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        DbCommand GetSQLiteCommand( ISqlStatement sqlStatement );

        /// <summary>
        /// Gets the SQL ce command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        DbCommand GetSqlCeCommand( ISqlStatement sqlStatement );

        /// <summary>
        /// Gets the SQL command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        DbCommand GetSqlCommand( ISqlStatement sqlStatement );

        /// <summary>
        /// Gets the OLE database command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        DbCommand GetOleDbCommand( ISqlStatement sqlStatement );
    }
}