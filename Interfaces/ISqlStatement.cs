// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
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
        /// Gets or sets the file path.
        /// </summary>
        /// <value>
        /// The file path.
        /// </value>
        string FilePath { get; set; }

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
        IDictionary<string, object> Args { get; set; }

        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <param name="provider">The provider.</param>
        /// <returns></returns>
        string GetFilePath( Provider provider );

        /// <summary>
        /// Gets the file path.
        /// </summary>
        /// <param name="command">The command.</param>
        /// <returns></returns>
        string GetFilePath( SQL command );

        /// <summary>
        /// Gets the command text.
        /// </summary>
        /// <param name="dict">The dictionary.</param>
        /// <param name="commandType">Type of the command.</param>
        /// <returns></returns>
        string GetCommandText( IDictionary<string, object> dict, SQL commandType );

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