namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using Microsoft.EntityFrameworkCore.Internal;
    using Syncfusion.Windows.Forms.Tools;

    [SuppressMessage( "ReSharper", "UnusedParameter.Global" )]
    public partial class EditDialog : ConfigBase
    {
        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Gets or sets the text boxes.
        /// </summary>
        /// <value>
        /// The text boxes.
        /// </value>
        public IEnumerable<TextBox> TextBoxes { get; set; }
        
        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        public EditDialog( )
        {
            InitializeComponent( );
            TabPages = GetTabPages( );
            Labels = GetLabels( );
            TextBoxes = GetTextBoxes( );
            TabControl.TabPanelBackColor = Color.FromArgb( 15, 15, 15 );
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="EditDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        public EditDialog( ToolType toolType ) 
            : this( )
        {
            ToolType = toolType;
        }

        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs" /> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Initializes the edit tab page.
        /// </summary>
        public void InitializeEditTab( )
        {
            try
            {
                foreach( TabPageAdv tab in TabControl.TabPages )
                {

                    ActiveTab = DataTab;
                    if( tab != ActiveTab )
                    {
                        tab.TabVisible = false;
                    }

                    switch( ToolType )
                    {
                        case ToolType.EditRecordButton:
                        {
                            DataTab.Text = "Edit Record";
                            break;
                        }
                        case ToolType.CopyButton:
                        {
                            DataTab.Text = "Copy Record";
                            break;
                        }
                        case ToolType.AddRecordButton:
                        {
                            DataTab.Text = "Add Record";
                            break;
                        }
                        case ToolType.DeleteRecordButton:
                        {
                            DataTab.Text = "Delete Record";
                            break;
                        }
                        case ToolType.EditButton:
                        {
                            DataTab.Text = "Edit Data";
                            break;
                        }
                        default:
                        {
                            DataTab.Text = "Edit Record";
                            break;
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
        /// Initializes the SQL tab page.
        /// </summary>
        public void InitializeSqlTab( )
        {
            try
            {
                ActiveTab = SqlTab;
                foreach( TabPageAdv tab in TabControl.TabPages )
                {
                    if( tab != ActiveTab )
                    {
                        tab.TabVisible = false;
                    }
                }

            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
        
        /// <summary>
        /// Gets the tab pages.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, TabPageAdv> GetTabPages( )
        {
            try
            {
                var _tabPages = new Dictionary<string, TabPageAdv>( );
                _tabPages.Add( DataTab.Name, DataTab );
                _tabPages.Add( SqlTab.Name, SqlTab );

                return _tabPages;
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, TabPageAdv> );
            }
        }
        

        /// <summary>
        /// Gets the edit labels.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Label> GetLabels( )
        { 
            try
            {
                var _labels = new List<Label>( );
                foreach( var _control in TableFrame.Controls )
                {
                    if( _control.GetType(   ) == typeof( Label ) )
                    {
                        _labels.Add( _control as Label );
                    }
                }

                return _labels?.Any(  ) == true
                    ? _labels
                    : default( IEnumerable<Label> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<Label> );
            }
        }

        /// <summary>
        /// Gets the text boxes.
        /// </summary>
        /// <returns></returns>
        public IEnumerable<TextBox> GetTextBoxes()
        {
            try
            {
                var _textBoxes = new List<TextBox>( );
                foreach( var _control in TableFrame.Controls )
                {
                    if( _control.GetType( ) == typeof( TextBox ) )
                    {
                        _textBoxes.Add( _control as TextBox );
                    }
                }

                return _textBoxes?.Any( ) == true
                    ? _textBoxes
                    : default( IEnumerable<TextBox> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IEnumerable<TextBox> );
            }
        }
    }
}
