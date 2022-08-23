namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SqlServerCe;
    using System.Data.SQLite;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    [ SuppressMessage( "ReSharper", "MemberCanBeProtected.Global" ) ]
    public abstract class CommandBase
    {
        /// <summary>
        /// The command
        /// </summary>
        public DbCommand Command { get; set; }

        /// <summary>
        /// The connection builder
        /// </summary>
        public IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// The provider
        /// </summary>
        public Provider Provider { get; set; }

        /// <summary>
        /// The source
        /// </summary>
        public Source Source { get; set; }

        /// <summary>
        /// The SQL statement
        /// </summary>
        public ISqlStatement SqlStatement { get; set; }

        protected CommandBase( )
        {
        }

        protected CommandBase( Source source, Provider provider, IDictionary<string, object> dict, SQL commandType = SQL.SELECTALL )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, dict, commandType );
            Command = GetCommand( SqlStatement );
        }

        protected CommandBase( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> criteria, SQL commandType = SQL.UPDATE )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, updates, criteria, commandType );
            Command = GetCommand( SqlStatement );
        }

        protected CommandBase( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> criteria, SQL commandType = SQL.SELECTALL )
        {
            Source = source;
            Provider = provider;
            ConnectionBuilder = new ConnectionBuilder( source, provider );
            SqlStatement = new SqlStatement( source, provider, columns, criteria, commandType );
            Command = GetCommand( SqlStatement );
        }

        protected CommandBase( ISqlStatement sqlStatement )
        {
            SqlStatement = sqlStatement;
            Source = sqlStatement.Source;
            Provider = sqlStatement.Provider;
            ConnectionBuilder = new ConnectionBuilder( sqlStatement.Source, sqlStatement.Provider );
            Command = GetCommand( SqlStatement );
        }
        
        /// <summary>
        /// Sets the command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetCommand( ISqlStatement sqlStatement )
        {
            if( Enum.IsDefined( typeof( Provider ), sqlStatement.Provider ) )
            {
                try
                {
                    switch( sqlStatement.Provider )
                    {
                        case Provider.SQLite:
                        {
                            Command = GetSQLiteCommand( sqlStatement );
                            return Command;
                        }

                        case Provider.SqlCe:
                        {
                            Command = GetSQLiteCommand( sqlStatement );
                            return Command;
                        }

                        case Provider.SqlServer:
                        {
                            Command = GetSQLiteCommand( sqlStatement );
                            return Command;
                        }

                        case Provider.Excel:
                        case Provider.CSV:
                        case Provider.Access:
                        case Provider.OleDb:
                        {
                            Command = GetOleDbCommand( sqlStatement );
                            return Command;
                        }

                        default:
                        {
                            return default( DbCommand );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the sq lite command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSQLiteCommand( ISqlStatement sqlStatement )
        {
            if( sqlStatement != null 
                && Enum.IsDefined( typeof( SQL ), sqlStatement.CommandType ) 
                && ConnectionBuilder != null )
            {
                try
                {
                    var _connection = ConnectionBuilder?.Connection;

                    switch( sqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );
                            return new SQLiteCommand( _sql, _connection as SQLiteConnection );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = sqlStatement?.GetInsertStatement( );
                            return  new SQLiteCommand( _sql, _connection as SQLiteConnection );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = sqlStatement?.GetUpdateStatement( );
                            return  new SQLiteCommand( _sql, _connection as SQLiteConnection );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = sqlStatement?.GetDeleteStatement( );
                            return new SQLiteCommand( _sql, _connection as SQLiteConnection );
                        }
                        default:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );
                            return  new SQLiteCommand( _sql, _connection as SQLiteConnection );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the SQL ce command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSqlCeCommand( ISqlStatement sqlStatement )
        {
            if( sqlStatement != null
                && Enum.IsDefined( typeof( SQL ), sqlStatement.CommandType )
                && ConnectionBuilder != null )
            {
                try
                {
                    var _connection = ConnectionBuilder.Connection;

                    if( !string.IsNullOrEmpty( _connection?.ConnectionString ) )
                    {
                        switch( sqlStatement?.CommandType )
                        {
                            case SQL.SELECTALL:
                            case SQL.SELECT:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );
                                return new SqlCeCommand( _sql, _connection as SqlCeConnection );
                            }
                            case SQL.INSERT:
                            {
                                var _sql = sqlStatement?.GetInsertStatement( );
                                return new SqlCeCommand( _sql, _connection as SqlCeConnection );
                            }
                            case SQL.UPDATE:
                            {
                                var _sql = sqlStatement?.GetUpdateStatement( );
                                return new SqlCeCommand( _sql, _connection as SqlCeConnection );
                            }
                            case SQL.DELETE:
                            {
                                var _sql = sqlStatement?.GetDeleteStatement( );
                                return new SqlCeCommand( _sql, _connection as SqlCeConnection );
                            }
                            default:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );
                                return new SqlCeCommand( _sql, _connection as SqlCeConnection );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the SQL command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetSqlCommand( ISqlStatement sqlStatement )
        {
            if( sqlStatement != null
                && Enum.IsDefined( typeof( SQL ), sqlStatement.CommandType )
                && ConnectionBuilder != null )
            {
                try
                {
                    var _connection = ConnectionBuilder?.Connection;
                    using( _connection )
                    {
                        switch( sqlStatement?.CommandType )
                        {
                            case SQL.SELECTALL:
                            case SQL.SELECT:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );
                                return  new SqlCommand( _sql, _connection as SqlConnection );
                            }
                            case SQL.INSERT:
                            {
                                var _sql = sqlStatement?.GetInsertStatement( );
                                return new SqlCommand( _sql, _connection as SqlConnection );
                            }

                            case SQL.UPDATE:
                            {
                                var _sql = sqlStatement?.GetUpdateStatement( );
                                return new SqlCommand( _sql, _connection as SqlConnection );
                            }
                            case SQL.DELETE:
                            {
                                var _sql = sqlStatement?.GetDeleteStatement( );
                                return new SqlCommand( _sql, _connection as SqlConnection );
                            }
                            default:
                            {
                                var _sql = sqlStatement?.GetSelectStatement( );
                                return  new SqlCommand( _sql, _connection as SqlConnection );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
        }

        /// <summary>
        /// Gets the OLE database command.
        /// </summary>
        /// <param name="sqlStatement">The SQL statement.</param>
        /// <returns></returns>
        public DbCommand GetOleDbCommand( ISqlStatement sqlStatement )
        {
            if( sqlStatement != null
                && Enum.IsDefined( typeof( SQL ), sqlStatement.CommandType )
                && ConnectionBuilder != null )
            {
                try
                {
                    var _connection = ConnectionBuilder?.Connection;

                    switch( sqlStatement?.CommandType )
                    {
                        case SQL.SELECTALL:
                        case SQL.SELECT:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );
                            return new OleDbCommand( _sql, _connection as OleDbConnection );
                        }
                        case SQL.INSERT:
                        {
                            var _sql = sqlStatement?.GetInsertStatement( );
                            return new OleDbCommand( _sql, _connection as OleDbConnection );
                        }
                        case SQL.UPDATE:
                        {
                            var _sql = sqlStatement.GetUpdateStatement( );
                            return new OleDbCommand( _sql, _connection as OleDbConnection );
                        }
                        case SQL.DELETE:
                        {
                            var _sql = sqlStatement?.GetDeleteStatement( );
                            return new OleDbCommand( _sql, _connection as OleDbConnection );
                        }
                        default:
                        {
                            var _sql = sqlStatement?.GetSelectStatement( );
                            return new OleDbCommand( _sql, _connection as OleDbConnection );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DbCommand );
                }
            }

            return default( DbCommand );
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
