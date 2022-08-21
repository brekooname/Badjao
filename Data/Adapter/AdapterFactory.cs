// <copyright file = "AdapterFactory.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SqlClient;
    using System.Data.SQLite;
    using System.Data.SqlServerCe;
    using System.Diagnostics.CodeAnalysis;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="IDisposable" />
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "AssignNullToNotNullAttribute" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class AdapterFactory : IDisposable
    {
        public DbConnection Connection { get; set; }

        /// <summary>
        /// Gets or sets the SQL statement.
        /// </summary>
        /// <value>
        /// The SQL statement.
        /// </value>
        public ISqlStatement SqlStatement { get; set; }

        /// <summary>
        /// Gets or sets the command builder.
        /// </summary>
        /// <value>
        /// The command builder.
        /// </value>
        public IDataCommand CommandBuilder { get; set; }

        /// <summary>
        /// Gets or sets the connectionBuilder builder.
        /// </summary>
        /// <value>
        /// The connectionBuilder builder.
        /// </value>
        public IConnectionBuilder ConnectionBuilder { get; set; }

        /// <summary>
        /// Gets or sets the adapter builder.
        /// </summary>
        /// <value>
        /// The adapter builder.
        /// </value>
        public AdapterBuilder AdapterBuilder { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterFactory"/> class.
        /// </summary>
        /// <param name="adapterBuilder">The adapter builder.</param>
        public AdapterFactory( AdapterBuilder adapterBuilder )
        {
            AdapterBuilder = adapterBuilder;
            ConnectionBuilder = AdapterBuilder.ConnectionBuilder;
            Connection = ConnectionBuilder?.Connection;
            SqlStatement = new SqlStatement( ConnectionBuilder );
            CommandBuilder = new CommandBuilder( ConnectionBuilder, SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterFactory"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connectionBuilder builder.</param>
        /// <param name="sqlStatement">The SQL statement.</param>
        public AdapterFactory( IConnectionBuilder connectionBuilder, ISqlStatement sqlStatement )
        {
            ConnectionBuilder = connectionBuilder;
            SqlStatement = sqlStatement;
            AdapterBuilder = new AdapterBuilder( ConnectionBuilder, SqlStatement );
            CommandBuilder = new CommandBuilder( ConnectionBuilder, SqlStatement );
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="AdapterFactory"/> class.
        /// </summary>
        /// <param name="connectionBuilder">The connectionBuilder builder.</param>
        /// <param name="commandBuilder">The command builder.</param>
        public AdapterFactory( IConnectionBuilder connectionBuilder, IDataCommand commandBuilder )
        {
            ConnectionBuilder = connectionBuilder;
            CommandBuilder = commandBuilder;
            SqlStatement = commandBuilder.SqlStatement;
            AdapterBuilder = new AdapterBuilder( connectionBuilder, commandBuilder.SqlStatement );
            Connection = connectionBuilder?.Connection;
        }

        /// <summary>
        /// Gets the adapter.
        /// </summary>
        /// <returns></returns>
        public DbDataAdapter GetDataAdapter( )
        {
            if( !string.IsNullOrEmpty( Connection.ConnectionString )
                && !string.IsNullOrEmpty( SqlStatement.GetSelectStatement(  ) ) )
            {
                try
                {
                    var _provider = ConnectionBuilder.Provider;

                    if( Enum.IsDefined( typeof( Provider ), _provider ) )
                    {
                        switch( _provider )
                        {
                            case Provider.SQLite:

                            {
                                return GetSQLiteAdapter(  ) ?? default( SQLiteDataAdapter );
                            }

                            case Provider.SqlCe:

                            {
                                return GetSqlCeAdapter(  ) ?? default( SqlCeDataAdapter );
                            }

                            case Provider.SqlServer:

                            {
                                return GetSqlAdapter(  ) ?? default( SqlDataAdapter );
                            }

                            case Provider.CSV:
                            case Provider.OleDb:
                            case Provider.Access:
                            case Provider.Excel:

                            {
                                return GetOleDbDataAdapter(  ) ?? default( OleDbDataAdapter );
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return default( DbDataAdapter );
        }

        /// <summary>
        /// Gets the OLE database data adapter.
        /// </summary>
        /// <returns></returns>
        private OleDbDataAdapter GetOleDbDataAdapter( )
        {
            if( !string.IsNullOrEmpty( SqlStatement.GetSelectStatement(  ) ) )
            {
                try
                {
                    var _connectionString = Connection?.ConnectionString;

                    return !string.IsNullOrEmpty( _connectionString )
                        ? new OleDbDataAdapter( SqlStatement.GetSelectStatement(  ),
                            _connectionString )
                        : default( OleDbDataAdapter );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( OleDbDataAdapter );
                }
            }

            return default( OleDbDataAdapter );
        }

        /// <summary>
        /// Gets the SQL adapter.
        /// </summary>
        /// <returns></returns>
        private SqlDataAdapter GetSqlAdapter()
        {
            if( SqlStatement != null )
            {
                try
                {
                    var _connectionString = Connection?.ConnectionString;

                    return !string.IsNullOrEmpty( _connectionString )
                        ? new SqlDataAdapter( SqlStatement.GetSelectStatement(  ),
                            _connectionString )
                        : default( SqlDataAdapter );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( SqlDataAdapter );
                }
            }

            return default( SqlDataAdapter );
        }

        /// <summary>
        /// Gets the SQL ce adapter.
        /// </summary>
        /// <returns></returns>
        private SqlCeDataAdapter GetSqlCeAdapter( )
        {
            if( !string.IsNullOrEmpty( Connection?.ConnectionString )
                && !string.IsNullOrEmpty( SqlStatement?.GetSelectStatement(  ) ) )
            {
                try
                {
                    var _dataAdapter = new SqlCeDataAdapter( SqlStatement?.GetSelectStatement(  ),
                        Connection as SqlCeConnection );

                    return _dataAdapter ?? default( SqlCeDataAdapter );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( SqlCeDataAdapter );
                }
            }

            return default( SqlCeDataAdapter );
        }

        /// <summary>
        /// Gets the sq lite adapter.
        /// </summary>
        /// <returns></returns>
        private SQLiteDataAdapter GetSQLiteAdapter()
        {
            if( !string.IsNullOrEmpty( Connection?.ConnectionString )
                && !string.IsNullOrEmpty( SqlStatement?.GetSelectStatement(  ) ) )
            {
                try
                {
                    var _adapter = new SQLiteDataAdapter( SqlStatement.GetSelectStatement(  ),
                        Connection as SQLiteConnection );

                    return _adapter ?? default( SQLiteDataAdapter );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( SQLiteDataAdapter );
                }
            }

            return default( SQLiteDataAdapter );
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name="disposing"><c>true</c> 
        /// to release both managed and unmanaged resources; 
        /// <c>false</c> to release only unmanaged resources.
        /// </param>
        protected virtual void Dispose( bool disposing )
        {
            if( disposing )
            {
                try
                {
                    AdapterBuilder?.Dispose(  );
                    Connection?.Dispose(  );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Performs application-defined tasks associated with freeing, 
        /// releasing, or resetting unmanaged resources.
        /// </summary>
        public void Dispose()
        {
            try
            {
                Dispose( true );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText(  );
                _error?.ShowDialog(  );
            }
        }
    }
}