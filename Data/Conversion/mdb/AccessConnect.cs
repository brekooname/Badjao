﻿// <copyright file = "AccessConnect.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Data.OleDb;
    using System.Data;
    using System.Linq;

    /// <summary>
    /// 
    /// </summary>
    public class AccessConnect
    {
        /// <summary>
        /// The connection
        /// </summary>
        private readonly OleDbConnection _connection;

        /// <summary>
        /// Initializes a new instance of the <see cref="AccessConnect"/> class.
        /// </summary>
        /// <param name="path">The path.</param>
        public AccessConnect( string path )
        {
            string connectionstring = "provider=microsoft.jet.oledb.4.0;Data source=" + path
                + ";Jet OLEDB:Database Password=h@#%^ein;";

            _connection = new OleDbConnection( connectionstring );
            _connection?.Open( );
        }

        /// <summary>
        /// Gets the table names.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> GetTableNames( )
        {
            List<string> _names = new List<string>( );
            string[ ] _restrictions = new string[ 4 ];
            _restrictions[ 3 ] = "Table";
            DataTable _schema = _connection.GetSchema( "Tables", _restrictions );

            for( int i = 0; i < _schema.Rows.Count; i++ )
            {
                _names.Add( _schema.Rows[ i ][ 2 ].ToString( ) );
            }

            return _names;
        }

        /// <summary>
        /// Gets the table.
        /// </summary>
        /// <param name="name">The name.</param>
        /// <returns></returns>
        public DataTable GetTable( string name )
        {
            try
            {
                DataTable _table = new DataTable( );

                OleDbDataAdapter _adapter =
                    new OleDbDataAdapter( "SELECT * FROM " + name, _connection );

                _adapter.Fill( _table );

                return _table.Rows.Count > 0
                    ? _table
                    : default( DataTable );
            }
            catch( Exception ex )
            {
                Console.WriteLine( ex );
                throw;
            }
        }

        /// <summary>
        /// Gets the column names.
        /// </summary>
        /// <param name="tableName">The tableName.</param>
        /// <returns></returns>
        public List<string> GetColumnNames( string tableName )
        {
            List<string> _names = new List<string>( );
            using OleDbCommand _command =
                new OleDbCommand( "select * from " + tableName, _connection );

            using OleDbDataReader _dataReader =
                _command.ExecuteReader( CommandBehavior.SchemaOnly );

            DataTable _dataTable = _dataReader.GetSchemaTable( );
            DataColumn _dataColumn = _dataTable?.Columns[ "ColumnName" ];

            if( _dataTable?.Rows != null )
            {
                foreach( DataRow row in _dataTable?.Rows )
                {
                    if( _dataColumn != null )
                    {
                        _names.Add( row[ _dataColumn ].ToString( ) );
                    }
                }
            }

            return _names?.Any( ) == true
                ? _names
                : default( List<string> );
        }
    }
}