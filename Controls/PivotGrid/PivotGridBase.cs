﻿// <copyright file = "PivotGridBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.PivotAnalysis;

    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    public abstract class PivotGridBase : PivotGridControl
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual SourceBinding BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual MetroTipBase ToolTip { get; set; }
        
        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">
        /// </typeparam>
        /// <param name="bindingList">
        /// The binding source.
        /// </param>
        public virtual void SetDataSource<T1>( T1 bindingList )
            where T1 : IBindingList
        {
            try
            {
                if( bindingList is BindingSource _binder
                    && _binder?.DataSource != null )
                {
                    try
                    {
                        BindingSource.DataSource = _binder.DataSource;
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">
        /// </typeparam>
        /// <typeparam name="T2">
        /// The type of the 2.
        /// </typeparam>
        /// <param name="bindingList">
        /// The binding source.
        /// </param>
        /// <param name="dict">
        /// The dictionary.
        /// </param>
        public virtual void SetDataSource<T1, T2>( T1 bindingList, T2 dict )
            where T1 : IBindingList
            where T2 : IDictionary<string, object>
        {
            try
            {
                if( bindingList != null
                    && dict?.Any( ) == true )
                {
                    try
                    {
                        BindingSource _list = bindingList as BindingSource;
                        string _filter = string.Empty;

                        foreach( KeyValuePair<string, object> _kvp in dict )
                        {
                            if( !string.IsNullOrEmpty( _kvp.Key )
                                && _kvp.Value != null )
                            {
                                _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                            }
                        }

                        if( _filter?.Length > 0
                            && _list?.DataSource != null )
                        {
                            BindingSource.DataSource = _list?.DataSource;
                            BindingSource.Filter = _filter?.TrimEnd( " AND".ToCharArray( ) );
                        }
                    }
                    catch( Exception ex )
                    {
                        Fail( ex );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1"></typeparam>
        /// <param name="data">The data.</param>
        public virtual void SetDataSource<T1>( IEnumerable<T1> data )
            where T1 : IEnumerable<T1>
        {
            if( data?.Any( ) == true )
            {
                try
                {
                    BindingSource.DataSource = data?.ToList( );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public virtual void SetDataSource<T1>( IEnumerable<T1> data,
            IDictionary<string, object> dict )
            where T1 : IEnumerable<T1>
        {
            if( data?.Any( ) == true )
            {
                try
                {
                    string _filter = string.Empty;

                    foreach( KeyValuePair<string, object> _kvp in dict )
                    {
                        if( !string.IsNullOrEmpty( _kvp.Key )
                            && _kvp.Value != null )
                        {
                            _filter += $"{_kvp.Key} = {_kvp.Value} AND";
                        }
                    }

                    BindingSource.DataSource = data?.ToList( );
                    BindingSource.Filter = _filter.TrimEnd( " AND".ToCharArray( ) );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <typeparam name="T3">The type of the 3.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The dictionary.</param>
        public virtual void SetDataSource<T1, T2, T3>( IEnumerable<T1> data, T2 field, T3 filter )
            where T1 : IEnumerable<T1>
            where T2 : struct
        {
            if( data?.Any( ) == true
                && Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    if( !string.IsNullOrEmpty( filter?.ToString( ) ) )
                    {
                        BindingSource.DataSource = data.ToList( );
                        BindingSource.DataMember = field.ToString( );
                        BindingSource.Filter = $"{field} = {filter}";
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList( );
                        BindingSource.DataMember = field.ToString( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        public virtual void SetDataSource<T1>( IEnumerable<T1> data, object field = null )
            where T1 : IEnumerable<T1>
        {
            if( data?.Any( ) == true )
            {
                try
                {
                    if( !string.IsNullOrEmpty( field?.ToString( ) ) )
                    {
                        BindingSource.DataSource = data.ToList( );
                        BindingSource.DataMember = field?.ToString( );
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the bindings.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="dict">The dictionary.</param>
        public virtual void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<T1>
            where T2 : IDictionary<string, object>
        {
            if( data?.Any( ) == true
                && dict?.Any( ) == true )
            {
                try
                {
                    string _filter = string.Empty;

                    foreach( KeyValuePair<string, object> kvp in dict )
                    {
                        if( !string.IsNullOrEmpty( kvp.Key )
                            && kvp.Value != null )
                        {
                            _filter += $"{kvp.Key} = {kvp.Value} AND";
                        }
                    }

                    BindingSource.DataSource = data?.ToList( );
                    BindingSource.Filter = _filter?.TrimEnd( " AND".ToCharArray( ) );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <typeparam name="T1">The type of the 1.</typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="data">The data.</param>
        /// <param name="field">The field.</param>
        /// <param name="filter">The filter.</param>
        public virtual void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 field,
            object filter = null )
            where T1 : IEnumerable<T1>
            where T2 : struct
        {
            if( data?.Any( ) == true
                && Enum.IsDefined( typeof( Field ), field ) )
            {
                try
                {
                    if( !string.IsNullOrEmpty( filter?.ToString( ) ) )
                    {
                        BindingSource.DataSource = data.ToList( );
                        BindingSource.DataMember = field.ToString( );
                        BindingSource.Filter = $"{field} = {filter}";
                    }
                    else
                    {
                        BindingSource.DataSource = data.ToList( );
                        BindingSource.DataMember = field.ToString( );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using( Error _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}