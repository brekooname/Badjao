namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public partial class EditBase : MetroForm
    {
        /// <summary>
        /// Gets or sets the source.
        /// </summary>
        /// <value>
        /// The source.
        /// </value>
        public virtual Source Source { get; set; }

        /// <summary>
        /// Gets or sets the provider.
        /// </summary>
        /// <value>
        /// The provider.
        /// </value>
        public virtual Provider Provider { get; set; }

        /// <summary>
        /// Gets or sets the type of the command.
        /// </summary>
        /// <value>
        /// The type of the command.
        /// </value>
        public virtual SQL CommandType { get; set; }

        /// <summary>
        /// Gets or sets the type of the tool.
        /// </summary>
        /// <value>
        /// The type of the tool.
        /// </value>
        public virtual ToolType ToolType { get; set; }

        /// <summary>
        /// Gets or sets the current tab.
        /// </summary>
        /// <value>
        /// The current tab.
        /// </value>
        public virtual TabPageAdv ActiveTab { get; set; }

        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual BindingSource BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the form filter.
        /// </summary>
        /// <value>
        /// The form filter.
        /// </value>
        public virtual IDictionary<string, object> FormFilter { get; set; }

        /// <summary>
        /// Gets or sets the group boxes.
        /// </summary>
        /// <value>
        /// The group boxes.
        /// </value>
        public virtual IDictionary<string, GroupBox> GroupBoxes { get; set; }

        /// <summary>
        /// Gets or sets the list boxes.
        /// </summary>
        /// <value>
        /// The list boxes.
        /// </value>
        public virtual IDictionary<string, ListBox> ListBoxes { get; set; }

        /// <summary>
        /// Gets or sets the labels.
        /// </summary>
        /// <value>
        /// The labels.
        /// </value>
        public virtual IEnumerable<Label> Labels { get; set; }

        /// <summary>
        /// Gets or sets the tab pages.
        /// </summary>
        /// <value>
        /// The tab pages.
        /// </value>
        public virtual IDictionary<string, TabPageAdv> TabPages { get; set; }

        /// <summary>
        /// Gets or sets the radio buttons.
        /// </summary>
        /// <value>
        /// The radio buttons.
        /// </value>
        public virtual IDictionary<string, RadioButton> RadioButtons { get; set; }

        /// <summary>
        /// Gets or sets the text boxes.
        /// </summary>
        /// <value>
        /// The text boxes.
        /// </value>
        public virtual IEnumerable<TextBox> TextBoxes { get; set; }

        /// <summary>
        /// Initializes a new instance 
        /// of the <see cref="EditBase"/> class.
        /// </summary>
        public EditBase( )
        {
            InitializeComponent( );
            Text = string.Empty;
        }

        /// <summary>
        /// Sets the binding source.
        /// </summary>
        /// <param name="bindingList">The bindingsource.</param>
        public virtual void SetDataSource<T1>( T1 bindingList )
            where T1 : IBindingList
        {
            try
            {
                if( bindingList is BindingSource bindingSource
                    && bindingSource?.DataSource != null )
                {
                    try
                    {
                        BindingSource.DataSource = bindingSource.DataSource;
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
        /// Called when [close button clicked].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public virtual void OnCloseButtonClicked( object sender, EventArgs e )
        {
            try
            {
                Close( );
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
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}
