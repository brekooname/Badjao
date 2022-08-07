// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;

    /// <summary> </summary>
    /// <seealso cref = "SqlStatement"/>
    [SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" )]
    public class SqlFactory : SqlBase
    {
        public ISqlStatement SqlStatement { get; set; }

        public IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "SqlFactory"/>
        /// class.
        /// </summary>
        /// <param name = "source" > </param>
        /// <param name = "provider" > </param>
        /// <param name = "command" > The command. </param>
        public SqlFactory( Source source, Provider provider, SQL command = SQL.SELECTALL )
        {
            Source = source;
            Provider = provider;
            CommandType = command;
            SqlStatement = new SqlStatement( source, provider, command );
            FilePath = Path.GetFullPath( ProviderPath[ Provider.ToString( ) ] );
            FileName = Path.GetFileNameWithoutExtension( FilePath );
        }

        public SqlFactory( IConnectionBuilder connectionBuilder, IEnumerable<DataColumn> columns, SQL command = SQL.SELECTALL )
        {
            Source = connectionBuilder.Source;
            Provider = connectionBuilder.Provider;
            CommandType = command;
            SqlStatement = new SqlStatement( connectionBuilder, command );
            FilePath = Path.GetFullPath( ProviderPath[ Provider.ToString( ) ] );
            FileName = Path.GetFileNameWithoutExtension( FilePath );
        }

        public SqlFactory( IConnectionBuilder conectionBuilder, SQL command = SQL.SELECTALL )
        {
            Source = conectionBuilder.Source;
            Provider = conectionBuilder.Provider;
            CommandType = command;
            ConnectionBuilder = conectionBuilder;
            SqlStatement = new SqlStatement( conectionBuilder, command );
            FilePath = SqlStatement.GetFilePath( conectionBuilder.Provider );
            FileName = Path.GetFileNameWithoutExtension( FilePath );
        }

        /// <summary>
        /// Initializes a new instance of the
        /// <see cref = "SqlFactory"/>
        /// class.
        /// </summary>
        /// <param name = "filePath" > The filePath. </param>
        /// <param name = "command" > The command. </param>
        public SqlFactory( string filePath, SQL command = SQL.SELECTALL )
        {
            ConnectionBuilder = new ConnectionBuilder( filePath );
            Source = ConnectionBuilder.Source;
            Provider = ConnectionBuilder.Provider;
            CommandType = command;
            SqlStatement = new SqlStatement( ConnectionBuilder, CommandType );
            FileName = ConnectionBuilder.FileName;
            FilePath = ConnectionBuilder.ProviderPath;
        }
    }
}