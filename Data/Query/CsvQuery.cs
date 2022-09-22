// <copyright file = "CsvQuery.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data;
    using System.Data.OleDb;
    using System.Diagnostics.CodeAnalysis;
    using System.IO;
    using System.Windows.Forms;
    using OfficeOpenXml;
    using DataTable = System.Data.DataTable;

    /// <summary>
    /// </summary>
    /// <seealso cref = "Query"/>
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public class CsvQuery : Query
    {
        /// <summary>
        /// Gets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public new Provider Provider { get; set; } = Provider.CSV;

        /// <summary>
        /// Initializes a new instance of the <see cref = "CsvQuery"/> class.
        /// </summary>
        public CsvQuery( )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "CsvQuery"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source.
        /// </param>
        public CsvQuery( Source source )
            : base( source, Provider.Access, SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "CsvQuery"/> class.
        /// </summary>
        /// <param name = "source" >
        /// The source.
        /// </param>
        /// <param name = "dict" >
        /// The dictionary.
        /// </param>
        public CsvQuery( Source source, IDictionary<string, object> dict )
            : base( source, Provider.Access, dict, SQL.SELECT )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvQuery"/> class.
        /// </summary>
        /// <param name="source">The source Data.</param>
        /// <param name="provider">The provider used.</param>
        /// <param name="dict">The dictionary of parameters.</param>
        /// <param name="commandType">The type of sql command.</param>
        public CsvQuery( Source source, Provider provider, IDictionary<string, object> dict,
            SQL commandType )
            : base( source, provider, dict, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="updates"></param>
        /// <param name="where">The where.</param>
        /// <param name="commandType">Type of the command.</param>
        public CsvQuery( Source source, Provider provider, IDictionary<string, object> updates,
            IDictionary<string, object> where, SQL commandType = SQL.UPDATE )
            : base( source, provider, updates, where, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="columns">The columns.</param>
        /// <param name="criteria">The criteria.</param>
        /// <param name="commandType">Type of the command.</param>
        public CsvQuery( Source source, Provider provider, IEnumerable<string> columns,
            IDictionary<string, object> criteria, SQL commandType = SQL.SELECT )
            : base( source, provider, columns, criteria, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref = "CsvQuery"/> class.
        /// </summary>
        /// <param name = "sqlStatement" >
        /// The sqlStatement.
        /// </param>
        public CsvQuery( ISqlStatement sqlStatement )
            : base( sqlStatement )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="sqlText">The SQL text.</param>
        public CsvQuery( Source source, Provider provider, string sqlText )
            : base( source, provider, sqlText )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvQuery"/> class.
        /// </summary>
        /// <param name="source">The source.</param>
        /// <param name="provider">The provider.</param>
        /// <param name="dict">The dictionary.</param>
        public CsvQuery( Source source, Provider provider, IDictionary<string, object> dict )
            : base( source, provider, dict )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvQuery"/> class.
        /// </summary>
        /// <param name="fullPath">The fullpath.</param>
        /// <param name="sqlText"></param>
        /// <param name="commandType">The commandType.</param>
        public CsvQuery( string fullPath, string sqlText, SQL commandType = SQL.SELECT )
            : base( fullPath, sqlText, commandType )
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="CsvQuery"/> class.
        /// </summary>
        /// <param name="fullPath">The fullpath.</param>
        /// <param name="commandType">The commandType.</param>
        /// <param name="dict">The dictionary.</param>
        public CsvQuery( string fullPath, SQL commandType, IDictionary<string, object> dict )
            : base( fullPath, commandType, dict )
        {
        }

        /// <summary>
        /// Saves the file.
        /// </summary>
        /// <param name = "workBook" >
        /// The workBook.
        /// </param>
        public void SaveFile( ExcelPackage workBook )
        {
            if( workBook != null )
            {
                try
                {
                    SaveFileDialog _fileDialog = new SaveFileDialog
                        { Filter = "CSV files (*.csv)|*.csv", FilterIndex = 1 };

                    if( _fileDialog.ShowDialog( ) == DialogResult.OK )
                    {
                        workBook.SaveAs( new FileInfo( _fileDialog.FileName ) );
                        const string _msg = "Save Successful!";

                        using( Message _message = new Message( _msg ) )
                        {
                            _message?.ShowDialog( );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// CSVs the import.
        /// </summary>
        /// <param name = "sheetName" >
        /// The sheetName.
        /// </param>
        /// <returns>
        /// </returns>
        public DataTable CsvImport( ref string sheetName )
        {
            if( !string.IsNullOrEmpty( sheetName )
                && !string.IsNullOrEmpty( sheetName ) )
            {
                try
                {
                    using( DataSet _dataSet = new DataSet( ) )
                    {
                        string _sql = "SELECT * FROM [" + sheetName + "]";

                        string _connectionString =
                            $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={
                                    System.IO.Path.GetDirectoryName( sheetName )
                                };" + "Extended Properties='Text;HDR=YES;FMT=Delimited'";

                        using( OleDbConnection _connection =
                            new OleDbConnection( _connectionString ) )
                        {
                            DataTable _schema =
                                _connection.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );

                            if( !string.IsNullOrEmpty( sheetName ) )
                            {
                                if( !SheetExists( sheetName, _schema ) )
                                {
                                    string _msg = $"{sheetName} in {sheetName} Does Not Exist!";

                                    using( Message _message = new Message( _msg ) )
                                    {
                                        _message?.ShowDialog( );
                                    }
                                }
                            }
                            else
                            {
                                sheetName = _schema?.Rows[ 0 ][ "TABLENAME" ].ToString( );
                            }

                            using( OleDbDataAdapter _dataAdapter =
                                new OleDbDataAdapter( _sql, _connection ) )
                            {
                                _dataAdapter.Fill( _dataSet );
                                return _dataSet.Tables[ 0 ];
                            }
                        }
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
        /// CSVs the import.
        /// </summary>
        /// <param name = "fileName" >
        /// The fileName.
        /// </param>
        /// <param name = "sheetName" >
        /// The sheetName.
        /// </param>
        /// <returns>
        /// </returns>
        public DataTable CsvImport( string fileName, ref string sheetName )
        {
            if( !string.IsNullOrEmpty( fileName )
                && !string.IsNullOrEmpty( sheetName ) )
            {
                try
                {
                    using( DataSet _dataSet = new DataSet( ) )
                    {
                        string _sql = "SELECT * FROM [" + sheetName + "]";

                        string _connectionString =
                            $@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={
                                    System.IO.Path.GetDirectoryName( fileName )
                                };Extended Properties='Text;HDR=YES;FMT=Delimited'";

                        using( OleDbConnection _connection =
                            new OleDbConnection( _connectionString ) )
                        {
                            DataTable _schema =
                                _connection.GetOleDbSchemaTable( OleDbSchemaGuid.Tables, null );

                            if( !string.IsNullOrEmpty( sheetName ) )
                            {
                                if( !SheetExists( sheetName, _schema ) )
                                {
                                    string _msg = $"{sheetName} in {fileName} Does Not Exist!";

                                    using( Message _message = new Message( _msg ) )
                                    {
                                        _message?.ShowDialog( );
                                    }
                                }
                            }
                            else
                            {
                                sheetName = _schema?.Rows[ 0 ][ "TABLENAME" ].ToString( );
                            }

                            using( OleDbDataAdapter _dataAdapter =
                                new OleDbDataAdapter( _sql, _connection ) )
                            {
                                _dataAdapter.Fill( _dataSet );
                                return _dataSet.Tables[ 0 ];
                            }
                        }
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
        /// CSVs the export.
        /// </summary>
        /// <param name = "table" >
        /// The table.
        /// </param>
        /// <param name = "filePath" >
        /// The filePath.
        /// </param>
        public void CsvExport( DataTable table, string filePath )
        {
            if( table?.Columns.Count > 0
                && table.Rows.Count > 0
                && !string.IsNullOrEmpty( filePath ) )
            {
                try
                {
                    using( ExcelPackage _excelPackage = CreateCsvFile( filePath ) )
                    {
                        string _withoutExtension = System.IO.Path.GetFileNameWithoutExtension( filePath );

                        ExcelWorksheet _excelWorksheet =
                            _excelPackage.Workbook.Worksheets.Add( _withoutExtension );

                        int _columns = table.Columns.Count;
                        int _rows = table.Rows.Count;

                        for( int column = 1; column <= _columns; column++ )
                        {
                            _excelWorksheet.Cells[ 1, column ].Value =
                                table.Columns[ column - 1 ].ColumnName;
                        }

                        for( int row = 1; row <= _rows; row++ )
                        {
                            for( int col = 0; col < _columns; col++ )
                            {
                                _excelWorksheet.Cells[ row + 1, col + 1 ].Value =
                                    table.Rows[ row - 1 ][ col ];
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// CSVs the export.
        /// </summary>
        /// <param name = "dataGrid" >
        /// The dataGrid.
        /// </param>
        public void CsvExport( DataGridView dataGrid )
        {
            if( dataGrid?.DataSource != null
                && ConnectionBuilder != null )
            {
                try
                {
                    string _filePath = ConnectionBuilder.DbPath;

                    using( ExcelPackage _excelPackage =
                        new ExcelPackage( new FileInfo( _filePath ) ) )
                    {
                        ExcelWorkbook _excelWorkbook = _excelPackage.Workbook;
                        ExcelWorksheet _excelWorksheet = _excelWorkbook.Worksheets[ 1 ];
                        int _rows = _excelWorksheet.SelectedRange.Rows;
                        int _columns = _excelWorksheet.SelectedRange.Columns;
                        dataGrid.ColumnCount = _columns;
                        dataGrid.RowCount = _rows;

                        for( int i = 1; i <= _rows; i++ )
                        {
                            for( int j = 1; j <= _columns; j++ )
                            {
                                if( _excelWorksheet.Cells[ i, j ] != null
                                    && _excelWorksheet.Cells[ i, j ].Value != null )
                                {
                                    dataGrid.Rows[ i - 1 ].Cells[ j - 1 ].Value =
                                        _excelWorksheet.Cells[ i, j ].Value.ToString( );
                                }
                            }
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Creates the CSV file.
        /// </summary>
        /// <param name = "filePath" >
        /// The filePath.
        /// </param>
        /// <returns>
        /// </returns>
        public ExcelPackage CreateCsvFile( string filePath )
        {
            if( !string.IsNullOrEmpty( filePath ) )
            {
                try
                {
                    FileInfo _fileInfo = new FileInfo( filePath );
                    return new ExcelPackage( _fileInfo );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( ExcelPackage );
                }
            }

            return default( ExcelPackage );
        }

        /// <summary>
        /// Gets the CSV file.
        /// </summary>
        /// <returns>
        /// </returns>
        public string GetCsvFile( )
        {
            try
            {
                string _fileName = "";

                OpenFileDialog _fileDialog = new OpenFileDialog
                {
                    Title = "CSV File Dialog", InitialDirectory = @"c:\",
                    Filter = "All files (*.*)|*.*|All files (*.*)|*.*", FilterIndex = 2,
                    RestoreDirectory = true
                };

                if( _fileDialog.ShowDialog( ) == DialogResult.OK )
                {
                    _fileName = _fileDialog.FileName;
                }

                return _fileName;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( string );
            }
        }

        /// <summary>
        /// Sheets the exists.
        /// </summary>
        /// <param name = "sheetName" >
        /// The sheetName.
        /// </param>
        /// <param name = "dataTable" >
        /// The dataTable.
        /// </param>
        /// <returns>
        /// </returns>
        private bool SheetExists( string sheetName, DataTable dataTable )
        {
            if( !string.IsNullOrEmpty( sheetName )
                && dataTable?.Columns.Count > 0
                && dataTable.Rows.Count > 0 )
            {
                try
                {
                    for( int i = 0; i < dataTable.Rows.Count; i++ )
                    {
                        DataRow _dataRow = dataTable.Rows[ i ];

                        if( sheetName == _dataRow[ "TABLENAME" ].ToString( ) )
                        {
                            return true;
                        }
                    }

                    return false;
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }

            return false;
        }
    }
}