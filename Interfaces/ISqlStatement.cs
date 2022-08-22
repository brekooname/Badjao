﻿// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;

    /// <summary> </summary>
    public interface ISqlStatement
    {
        /// <summary>
        /// The source
        /// </summary>
        Source Source { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
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
        /// Gets or sets the arguments.
        /// </summary>
        /// <value>
        /// The arguments.
        /// </value>
        IDictionary<string, object> Criteria { get; set; }
        
        /// <summary>
        /// Gets the select statement.
        /// </summary>
        /// <returns></returns>
        string GetSelectStatement( );

        /// <summary>
        /// Gets the select statement.
        /// </summary>
        /// <returns>
        /// </returns>
        string CreateSelectStatement( IDictionary<string, object> dict );

        /// <summary>
        /// Gets the update statement.
        /// </summary>
        /// <returns></returns>
        string GetUpdateStatement( ); 

        /// <summary> Gets the update statement. </summary>
        /// <returns> </returns>
        string CreateUpdateStatement( IDictionary<string, object> dict );

        /// <summary>
        /// Gets the insert statement.
        /// </summary>
        /// <returns></returns>
        string GetInsertStatement( );

        /// <summary> Gets the insert statement. </summary>
        /// <returns> </returns>
        string CreateInsertStatement( IDictionary<string, object> dict);

        /// <summary>
        /// Gets the delete statement.
        /// </summary>
        /// <returns></returns>
        string GetDeleteStatement( );

        /// <summary> Gets the delete statement. </summary>
        /// <returns> </returns>
        string CreateDeleteStatement( IDictionary<string, object> dict );
    }
}