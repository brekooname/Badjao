// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data;
    using System.Data.Common;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="DbDataAdapter" />
    [SuppressMessage( "ReSharper", "MemberCanBeInternal" )]
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    public class AdapterBuilder : DbDataAdapter
    {
        /// <summary>
        /// The connection
        /// </summary>
        public DbConnection Connection { get; set; }

        /// <summary>
        /// The SQL statement
        /// </summary>
        public ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// The connection builder
        /// </summary>
        public IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// Gets the command builder.
        /// </summary>
        /// <value>
        /// The command builder.
        /// </value>
        public IDataCommand CommandBuilder { get; set; }

        /// <summary>
        /// Gets the command factory.
        /// </summary>
        /// <value>
        /// The command factory.
        /// </value>
        public ICommandFactory CommandFactory { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterBuilder"/> class.
        /// </summary>
        public AdapterBuilder( )
        {
            MissingMappingAction = MissingMappingAction.Passthrough;
            MissingSchemaAction = MissingSchemaAction.AddWithKey;
            MissingMappingAction = MissingMappingAction.Passthrough;
            ContinueUpdateOnError = true;
            AcceptChangesDuringFill = true;
            AcceptChangesDuringUpdate = true;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterBuilder"/> class.
        /// </summary>
        /// <param name="commandBuilder">The commandbuilder.</param>
        public AdapterBuilder( IDataCommand commandBuilder )
            : this( )
        {
            SqlStatement = commandBuilder.SqlStatement;
            ConnectionBuilder = new ConnectionBuilder( commandBuilder.Source, commandBuilder.Provider );
            CommandBuilder = new CommandBuilder( SqlStatement );
            CommandFactory = new CommandFactory( CommandBuilder );
            Connection = ConnectionBuilder.Connection;
            SelectCommand = CommandFactory.
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterBuilder"/> class.
        /// </summary>
        /// <param name="sqlStatement">The sqlstatement.</param>
        public AdapterBuilder( ISqlStatement sqlStatement )
            : this( )
        {
            SqlStatement = sqlStatement;
            ConnectionBuilder = new ConnectionBuilder( sqlStatement.Source, sqlStatement.Provider );
            CommandBuilder = new CommandBuilder( sqlStatement );
            CommandFactory = new CommandFactory( CommandBuilder );
            Connection = ConnectionBuilder.Connection;
        }
        
        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}