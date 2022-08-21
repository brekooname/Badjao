// <copyright file=" <File Name> .cs" company="Terry D. Eppler">
// Copyright (c) Terry Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Linq;

    /// <summary> </summary>
    /// <seealso cref = "SqlStatement"/>
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    public class SqlFactory : SqlBase
    {
        /// <summary>
        /// Gets or sets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        public ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Gets or sets the connection builder.
        /// </summary>
        /// <value>
        /// The connection builder.
        /// </value>
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
            FilePath = Path.GetFullPath( DbClientPath[ Provider.ToString( ) ] );
            FileName = Path.GetFileNameWithoutExtension( FilePath );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlFactory"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connection builder.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="command">The command.</param>
        public SqlFactory( IConnectionBuilder connectionBuilder, IEnumerable<DataColumn> columns, SQL command = SQL.SELECTALL )
        {
            Source = connectionBuilder.Source;
            Provider = connectionBuilder.Provider;
            CommandType = command;
            SqlStatement = new SqlStatement( connectionBuilder, command );
            FilePath = Path.GetFullPath( DbClientPath[ Provider.ToString( ) ] );
            FileName = Path.GetFileNameWithoutExtension( FilePath );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SqlFactory"/> class.
        /// </summary>
        /// <param name="conectionBuilder">The conection builder.</param>
        /// <param name="command">The command.</param>
        public SqlFactory( IConnectionBuilder conectionBuilder, SQL command = SQL.SELECTALL )
        {
            Source = conectionBuilder.Source;
            Provider = conectionBuilder.Provider;
            CommandType = command;
            ConnectionBuilder = conectionBuilder;
            SqlStatement = new SqlStatement( conectionBuilder, command );
            FilePath = SqlStatement.GetDbClientPath( conectionBuilder.Provider );
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
            FilePath = ConnectionBuilder.DbPath;
        }
        
        /// <summary>
        /// Gets the script files.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, string> GetScriptText( )
        {
            if( Enum.IsDefined( typeof( Provider ), Provider )
                && Enum.IsDefined( typeof( SQL ), CommandType ) )
            {
                try
                {
                    var _directory = DbClientPath[ $"{ Provider }" ] + $@"\{ CommandType }";
                    var _scriptFiles = new Dictionary<string, string>( );
                    if( !string.IsNullOrEmpty( _directory )
                        && Directory.Exists( _directory ) )
                    {
                        var _scripts = Directory.GetFiles( _directory );
                        if( _scripts?.Any( ) == true )
                        {
                            foreach( var path in _scripts )
                            {
                                if( !string.IsNullOrEmpty( path ) )
                                {
                                    var _file = Path.GetFullPath( path );
                                    using( var stream = File.OpenRead( _file ) )
                                    {
                                        var _sqlText = new StreamReader( stream );
                                        _scriptFiles?.Add( Path.GetFileNameWithoutExtension( path ), _sqlText.ReadToEnd( ) );
                                    }
                                }
                            }

                            return _scriptFiles?.Any( ) == true
                                ? _scriptFiles
                                : default( IDictionary<string, string> );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IDictionary<string, string> );
                }
            }

            return default( IDictionary<string, string> );
        }

    }
}