// <copyright file = "LabelBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System.Collections.Generic;
    using System;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Linq;
    using System.Windows.Forms;
    using VisualPlus.Toolkit.Controls.Interactivity;

    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    public abstract class LabelBase : VisualLabel
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual MetroTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }
        
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
        /// <param name="bindingList">The bindingsource.</param>
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
        /// <typeparam name="T1"></typeparam>
        /// <typeparam name="T2">The type of the 2.</typeparam>
        /// <param name="bindingList">The bindingsource.</param>
        /// <param name="dict">The dictionary.</param>
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

                        foreach( KeyValuePair<string, object> kvp in dict )
                        {
                            if( !string.IsNullOrEmpty( kvp.Key )
                                && kvp.Value != null )
                            {
                                _filter += $"{kvp.Key} = {kvp.Value} AND";
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

                    foreach( KeyValuePair<string, object> kvp in dict )
                    {
                        if( !string.IsNullOrEmpty( kvp.Key )
                            && kvp.Value != null )
                        {
                            _filter += $"{kvp.Key} = {kvp.Value} AND";
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
        /// <typeparam name="T1">The type of T1.</typeparam>
        /// <typeparam name="T2">The type of T2.</typeparam>
        /// <typeparam name="T3">The type of T3.</typeparam>
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
        /// <param name="data">The data.</param>
        /// <param>The numeric.</param>
        /// <param name = "dict" > </param>
        public virtual void SetDataSource<T1, T2>( IEnumerable<T1> data, T2 dict )
            where T1 : IEnumerable<T1>
            where T2 : IDictionary<string, object>
        {
            if( data?.Any( ) == true
                && dict?.Any( ) == true )
            {
                try
                {
                    string filter = string.Empty;

                    foreach( KeyValuePair<string, object> kvp in dict )
                    {
                        if( !string.IsNullOrEmpty( kvp.Key )
                            && kvp.Value != null )
                        {
                            filter += $"{kvp.Key} = {kvp.Value} AND";
                        }
                    }

                    BindingSource.DataSource = data?.ToList( );
                    BindingSource.Filter = filter?.TrimEnd( " AND".ToCharArray( ) );
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
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.</param>
        public virtual void OnMouseOver( object sender, EventArgs e )
        {
            Label _budgetLabel = sender as Label;

            try
            {
                if( _budgetLabel != null
                    && !string.IsNullOrEmpty( HoverText ) )
                {
                    if( !string.IsNullOrEmpty( HoverText ) )
                    {
                        string _hoverText = _budgetLabel?.HoverText;
                        MetroTip _ = new MetroTip( _budgetLabel, _hoverText );
                    }
                    else
                    {
                        if( !string.IsNullOrEmpty( Tag?.ToString( ) ) )
                        {
                            string _text = Tag?.ToString( )?.SplitPascal( );
                            MetroTip _ = new MetroTip( _budgetLabel, _text );
                        }
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The
        /// <see cref="EventArgs" />
        /// instance containing the event data.
        /// </param>
        public virtual void OnMouseLeave( object sender, EventArgs e )
        {
            Label _budgetLabel = sender as Label;

            try
            {
                if( _budgetLabel != null )
                {
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Fails the specified ex.
        /// </summary>
        /// <param name="ex">The ex.</param>
        protected static void Fail( Exception ex )
        {
            using Error _error = new Error( ex );
            _error?.SetText( );
            _error?.ShowDialog( );
        }
    }
}