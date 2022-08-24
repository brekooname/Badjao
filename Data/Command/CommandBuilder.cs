// <copyright file = "CommandBuilder.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ICommandBuilder" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Global" ) ]
    public class CommandBuilder : CommandBase, ICommandBuilder
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        public CommandBuilder()
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="dict">The dictionary.</param>
        public CommandBuilder( Source source, Provider provider, IDictionary<string, object> dict ) 
            : base( source, provider, dict )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CommandBuilder"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="updates">The updates.</param>
        /// <param name="criteria">The criteria.</param>
        public CommandBuilder( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> criteria ) 
            : base( source, provider, updates, criteria )
        {
        }

        public CommandBuilder( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> criteria ) 
            : base( source, provider, columns, criteria )
        {
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref="CommandBuilder"/> class.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        public CommandBuilder( ISqlStatement sqlStatement ) 
            : base( sqlStatement )
        {
        }
        
    }
}