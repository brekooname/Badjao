// <copyright file = "SQLiteQuery.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.Common;
    using System.Data.OleDb;
    using System.Data.SQLite;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;

    /// <summary>
    /// </summary>
    /// <seealso cref = "Query"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBeInternal" ) ]
    [ SuppressMessage( "ReSharper", "ConvertToConstant.Local" ) ]
    [ SuppressMessage( "ReSharper", "BadListLineBreaks" ) ]
    public class SQLiteQuery : Query
    {
        /// <summary>
        /// Gets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        protected readonly Provider _provider = Provider.SQLite;

        /// <summary>
        /// Initializes a new instance of the <see cref = "SQLiteQuery"/> class.
        /// </summary>
        public SQLiteQuery( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SQLiteQuery"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source.
        /// </param>
        public SQLiteQuery( Source source )
            : base( source, Provider.SQLite, SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SQLiteQuery"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source.
        /// </param>
        /// <param name = "updates" >
        /// The dictionary.
        /// </param>
        public SQLiteQuery( Source source, IDictionary<string, object> updates )
            : base( source, Provider.SQLite, updates, SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        /// <param name="source">The source Data.</param>
        /// <param name="provider">The provider used.</param>
        /// <param name="dict">The dictionary of parameters.</param>
        /// <param name="commandType">The type of sql command.</param>
        public SQLiteQuery( Source source, Provider provider, IDictionary<string, object> dict,
            SQL commandType )
            : base( source, provider, dict, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="updates"></param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public SQLiteQuery( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="criteria">The criteria.</param>
        /// <param name="commandType">Type of the command.</param>
        public SQLiteQuery( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> criteria, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, criteria, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "SQLiteQuery"/> class.
        /// </summary>
        /// <param name = "sqlStatement" >
        /// The sqlStatement.
        /// </param>
        public SQLiteQuery( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public SQLiteQuery( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="dict">The dictionary.</param>
        public SQLiteQuery( Source source, Provider provider, IDictionary<string, object> dict )
            : base( source, provider, dict )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        /// <param name="fullPath">The fullpath.</param>
        /// <param name="sqlText"></param>
        /// <param name="commandType">The commandType.</param>
        public SQLiteQuery( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="SQLiteQuery"/> class.
        /// </summary>
        /// <param name="fullPath">The fullpath.</param>
        /// <param name="commandType">The commandType.</param>
        /// <param name="dict">The dictionary.</param>
        public SQLiteQuery( string fullPath, SQL commandType, IDictionary<string, object> dict )
            : base( fullPath, commandType, dict )
        {
        }

        /// <summary>
        /// </summary>
        public enum ColDataType
        {
            /// <summary>
            /// The default
            /// </summary>
            Default,

            Text,

            DateTime,

            Integer,

            Decimal,

            Blob
        }

        /// <summary>
        /// Gets the Data adapter.
        /// </summary>
        /// <param name = "command" >
        /// The command.
        /// </param>
        /// <returns>
        /// </returns>
        public SQLiteDataAdapter GetDataAdapter( SQLiteCommand command )
        {
            try
            {
                return new SQLiteDataAdapter( command );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( SQLiteDataAdapter );
            }
        }

        /// <summary>
        /// Gets the Data reader.
        /// </summary>
        /// <param name = "command" >
        /// The command.
        /// </param>
        /// <returns>
        /// </returns>
        public SQLiteDataReader GetDataReader( SQLiteCommand command )
        {
            try
            {
                return command.ExecuteReader( );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( SQLiteDataReader );
            }
        }

        /// <summary>
        /// Gets the command builder.
        /// </summary>
        /// <param name = "adapter" >
        /// The adapter.
        /// </param>
        /// <returns>
        /// </returns>
        private SQLiteCommandBuilder GetCommandBuilder( SQLiteDataAdapter adapter )
        {
            try
            {
                return new SQLiteCommandBuilder( adapter );
            }
            catch( SystemException ex )
            {
                Fail( ex );
                return default( SQLiteCommandBuilder );
            }
        }

        /// <summary>
        /// Gets the excel file path.
        /// </summary>
        /// <returns>
        /// </returns>
        private string GetExcelFilePath( )
        {
            try
            {
                string _fname = "";

                OpenFileDialog fdlg = new OpenFileDialog
                {
                    Title = "Excel File Dialog", InitialDirectory = @"c:\",
                    Filter = "All files (*.*)|*.*|All files (*.*)|*.*", FilterIndex = 2,
                    RestoreDirectory = true
                };

                if( fdlg.ShowDialog( ) == DialogResult.OK )
                {
                    _fname = fdlg.FileName;
                }

                return _fname;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Creates the table from excel file.
        /// </summary>
        /// <param name = "filePath" >
        /// The filePath.
        /// </param>
        /// <param name = "sheetName" >
        /// The sheetName.
        /// </param>
        /// <returns>
        /// </returns>
        public DataTable CreateTableFromExcelFile( string filePath, ref string sheetName )
        {
            if( !string.IsNullOrEmpty( filePath )
                && !string.IsNullOrEmpty( sheetName ) )
            {
                try
                {
                    DataSet _dataset = new DataSet( );
                    string _cstring = GetExcelFilePath( );
                    string _sql = "SELECT * FROM [" + sheetName + "]";
                    string _msg = "Sheet Does Not Exist!";
                    ExcelQuery _excelQuery = new ExcelQuery( _cstring, _sql );
                    OleDbConnection _connection = _excelQuery.GetConnection( ) as OleDbConnection;
                    _connection?.Open( );

                    DataTable _table =
                        _connection?.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );

                    if( _table?.Rows.Count > 0
                        && CheckIfSheetNameExists( sheetName, _table ) )
                    {
                        Message _message = new Message( _msg );
                        _message?.ShowDialog( );
                    }
                    else
                    {
                        sheetName = _table?.Rows[ 0 ][ "TABLENAME" ].ToString( );
                    }

                    OleDbDataAdapter _adapter = new OleDbDataAdapter( _sql, _connection );
                    _adapter.Fill( _dataset, sheetName );
                    return _dataset.Tables[ 0 ];
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <summary>
        /// Creates the table from CSV file.
        /// </summary>
        /// <param name = "fileName" >
        /// The fileName.
        /// </param>
        /// <param name = "sheetName" >
        /// The sheetName.
        /// </param>
        /// <returns>
        /// </returns>
        public DataTable CreateTableFromCsvFile( string fileName, ref string sheetName )
        {
            if( !string.IsNullOrEmpty( fileName )
                && !string.IsNullOrEmpty( sheetName ) )
            {
                try
                {
                    DataSet _dataSet = new DataSet( );
                    DataTable _dataTable = new DataTable( );
                    _dataSet.DataSetName = fileName;
                    _dataTable.TableName = sheetName;
                    _dataSet.Tables.Add( _dataTable );
                    string _sql = $"SELECT * FROM [{sheetName}]";
                    string _cstring = GetExcelFilePath( );

                    if( !string.IsNullOrEmpty( _cstring ) )
                    {
                        CsvQuery _csvquery = new CsvQuery( _cstring, _sql );
                        DbCommand _select = _csvquery.DataCommand;
                        OleDbConnection _connection = _csvquery.DataConnection as OleDbConnection;

                        OleDbDataAdapter _adapter =
                            new OleDbDataAdapter( _select.CommandText, _connection );

                        _adapter?.Fill( _dataSet, sheetName );

                        return _dataTable.Columns.Count > 0
                            ? _dataTable
                            : default( DataTable );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( DataTable );
                }
            }

            return default( DataTable );
        }

        /// <summary>
        /// Gets the parameters.
        /// </summary>
        /// <param name = "dict" >
        /// The dictionary.
        /// </param>
        /// <returns>
        /// </returns>
        public IEnumerable<DbParameter> GetParameters( Dictionary<string, object> dict )
        {
            if( dict?.Any( ) == true )
            {
                try
                {
                    return dict.Keys.Any( )
                        ? dict.ToSqlDbParameters( Provider )
                        : default( IEnumerable<DbParameter> );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( IEnumerable<DbParameter> );
                }
            }

            return default( IEnumerable<DbParameter> );
        }

        /// <summary>
        /// Checks if sheet name exists.
        /// </summary>
        /// <param name = "sheetName" >
        /// The sheetName.
        /// </param>
        /// <param name = "dataSchema" >
        /// The dataSchema.
        /// </param>
        /// <returns>
        /// </returns>
        private bool CheckIfSheetNameExists( string sheetName, DataTable dataSchema )
        {
            if( !string.IsNullOrEmpty( sheetName )
                && dataSchema != null
                && dataSchema.Columns.Count > 0 )
            {
                for( int i = 0; i < dataSchema.Rows.Count; i++ )
                {
                    DataRow _dataRow = dataSchema.Rows[ i ];

                    if( sheetName == _dataRow[ "TABLENAME" ].ToString( ) )
                    {
                        return true;
                    }
                }
            }

            return false;
        }

        /// <summary>
        /// Creates the database.
        /// </summary>
        private void CreateDatabase( )
        {
            string _commandText = @"CREATE TABLE IF NOT EXISTS [MyTable] (
                                    [ID] INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT,
                                    [Key] NVARCHAR(2048)  NULL,
                                    [Value] VARCHAR(2048)  NULL
                                    )";

            SQLiteConnection.CreateFile( "databaseFile.db3" );

            using( SQLiteConnection _connection =
                new SQLiteConnection( "Data source=databaseFile.db3" ) )
            {
                SQLiteCommand _command = new SQLiteCommand( _connection );
                _connection.Open( );
                _command.CommandText = _commandText;
                _command.ExecuteNonQuery( );

                _command.CommandText =
                    "INSERT INTO MyTable (Key,Value) Values ('key one','value one')";

                _command.ExecuteNonQuery( );

                _command.CommandText =
                    "INSERT INTO MyTable (Key,Value) Values ('key two','value value')";

                _command.ExecuteNonQuery( );
                _command.CommandText = "Select * FROM MyTable";
                SQLiteDataReader _reader = _command.ExecuteReader( );

                while( _reader.Read( ) )
                {
                    Console.WriteLine( _reader[ "Key" ] + " : " + _reader[ "Value" ] );
                }

                _connection.Close( );
            }
        }

        /// <summary>
        /// Releases unmanaged and - optionally - managed resources.
        /// </summary>
        /// <param name = "disposing" >
        /// <c>
        /// true
        /// </c>
        /// to release both managed and unmanaged resources;
        /// <c>
        /// false
        /// </c>
        /// to release only unmanaged resources.
        /// </param>
        protected override void Dispose( bool disposing )
        {
            if( disposing )
            {
                base.Dispose( );
            }

            IsDisposed = true;
        }
    }
}