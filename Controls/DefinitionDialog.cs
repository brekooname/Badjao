namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Linq;
    using Syncfusion.Windows.Forms.Tools;

    public partial class DefinitionDialog : ConfigBase
    {
        /// <summary>
        /// Gets or sets the data model.
        /// </summary>
        /// <value>
        /// The data model.
        /// </value>
        public DataBuilder DataModel { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="DefinitionDialog"/> class.
        /// </summary>
        public DefinitionDialog()
        {
            InitializeComponent( );
            TabPages = GetTabPages( );
            GroupBoxes = GetGroupBoxes( );
            ListBoxes = GetListBoxes( );
            RadioButtons = GetRadioButtons( );
            TabControl.TabPanelBackColor = Color.FromArgb( 15, 15, 15 );
            Load += OnLoad;
            CloseButton.Click += OnCloseButtonClicked;
        }

        /// <summary>
        /// Initializes a new instance of 
        /// the <see cref="DefinitionDialog"/> class.
        /// </summary>
        /// <param name="toolType">Type of the tool.</param>
        public DefinitionDialog( ToolType toolType ) 
            : this( )
        {
            ToolType = toolType;
        }

        /// <summary>
        /// Called when [visible].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        public void OnLoad( object sender, EventArgs e )
        {
            try
            {
                SetGroupBoxProperties( );
                SetRadioButtonProperties( );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the group box properties.
        /// </summary>
        public void SetGroupBoxProperties( )
        {
            try
            {
                foreach( var _groupBox in GroupBoxes.Values )
                {
                    _groupBox.SeparatorColor = Color.FromArgb( 64, 64, 64 );
                    _groupBox.Separate = true;
                    _groupBox.Separator = true;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the RadioButton properties.
        /// </summary>
        public void SetRadioButtonProperties( )
        {
            try
            {
                foreach( var _button in RadioButtons.Values )
                {
                    _button.ForeColor = Color.FromArgb( 0, 120, 212 );
                    _button.CheckSignColor = Color.FromArgb( 0, 120, 212 );
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Gets the list boxes.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, ListBox> GetListBoxes( )
        {
            try
            {
                var _listBoxes = new Dictionary<string, ListBox>( );
                foreach( TabPageAdv _tabPage in TabControl.TabPages )
                {
                    foreach( var _control in _tabPage.Controls )
                    {
                        if( _control is ListBox _listBox )
                        {
                            _listBoxes.Add( _listBox.Name, _listBox );
                        }
                    }
                }

                return _listBoxes?.Any( ) == true
                    ? _listBoxes
                    : default( IDictionary<string, ListBox> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, ListBox> );
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
                foreach( TabPageAdv tabpage in TabControl.TabPages )
                {
                    _tabPages.Add( tabpage.Name, tabpage );
                }

                return _tabPages?.Any( ) == true
                    ? _tabPages
                    : default( IDictionary<string, TabPageAdv> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, TabPageAdv> );
            }
        }

        /// <summary>
        /// Gets the group boxes.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, GroupBox> GetGroupBoxes( )
        {
            try
            {
                var _groupBoxes = new Dictionary<string, GroupBox>( );
                foreach( TabPageAdv _tabPage in TabControl.TabPages )
                {
                    foreach( var _control in _tabPage.Controls )
                    {
                        if( _control is GroupBox _groupBox )
                        {
                            _groupBoxes.Add( _groupBox.Name, _groupBox );
                        }
                    }
                }

                return _groupBoxes?.Any( ) == true
                    ? _groupBoxes
                    : default( IDictionary<string, GroupBox> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, GroupBox> );
            }
        }

        /// <summary>
        /// Gets the radio buttons.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, RadioButton> GetRadioButtons()
        {
            try
            {
                var _buttons = new Dictionary<string, RadioButton>( );
                foreach( var _tabPage in TabControl.TabPages )
                {
                    if( _tabPage is TabPageAdv _tab )
                    {
                        foreach( var _control in _tab.Controls )
                        {
                            if( _control is GroupBox _group )
                            {
                                foreach( var _item in _group.Controls )
                                {
                                    if( _item is RadioButton _radioButton )
                                    {
                                        _buttons.Add( _radioButton.Name, _radioButton );
                                    }
                                }
                            }
                        }
                    }
                }

                return _buttons?.Any( ) == true
                    ? _buttons
                    : default( IDictionary<string, RadioButton> );
            }
            catch( Exception ex )
            {
                Fail( ex );
                return default( IDictionary<string, RadioButton> );
            }
        }
    }
}
