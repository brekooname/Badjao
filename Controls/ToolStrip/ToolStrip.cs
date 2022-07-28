// <copyright file = "ToolBarControl.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;
    using System.Collections.Generic;
    using System.Linq;
    using System.Reflection;
    using System.Resources;

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ToolStripBase" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "UnusedParameter.Global" )]
    [SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" )]
    [SuppressMessage( "ReSharper", "ObjectCreationAsStatement" )]
    [ SuppressMessage( "ReSharper", "UnassignedGetOnlyAutoProperty" ) ]
    public class ToolStrip : ToolStripBase, IToolStrip
    {
        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public Field Field { get; set; }

        /// <summary>
        /// Gets or sets the numeric.
        /// </summary>
        /// <value>
        /// The numeric.
        /// </value>
        public Numeric Numeric { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// The image path
        /// </summary>
        public virtual string ImageDirectory { get; set; }

        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <value>
        /// The buttons.
        /// </value>
        public IDictionary<string, ToolStripButton> Buttons { get; }

        /// <summary>
        /// Gets or sets the size of the image.
        /// </summary>
        /// <value>
        /// The size of the image.
        /// </value>
        public Size ImageSize { get; set; }

        /// <summary>
        /// Initializes a new instance of the <see cref="ToolStrip"/> class.
        /// </summary>
        public ToolStrip( )
        {
            Margin = new Padding( 1, 1, 1, 1 );
            Padding = new Padding( 1, 1, 1, 1 );
            BackColor = Color.FromArgb( 15, 15, 15 );
            ForeColor = Color.Black;
            Font = new Font( "Roboto", 9 );
            ShowCaption = true;
            CaptionFont = new Font( "Roboto", 9, FontStyle.Bold );
            CaptionStyle = CaptionStyle.Top;
            CaptionAlignment = CaptionAlignment.Near;
            CaptionTextStyle = CaptionTextStyle.Plain;
            Text = "";
            Anchor = AnchorStyles.Top | AnchorStyles.Left;
            Dock = DockStyle.Bottom;
            BorderStyle = ToolStripBorderStyle.StaticEdge;
            CanApplyTheme = true;
            CanOverrideStyle = true;
            ImageScalingSize = new Size( 20, 20 );
            Office12Mode = true;
            LauncherStyle = LauncherStyle.Office12;
            ShowLauncher = true;
            GripStyle = ToolStripGripStyle.Hidden;
            VisualStyle = ToolStripExStyle.Default;
            OfficeColorScheme = ColorScheme.Blue;
            ThemeStyle.BackColor = Color.FromArgb( 15, 15, 15 );
            ThemeStyle.ArrowColor = Color.SteelBlue;
            ThemeStyle.BottomToolStripBackColor = Color.FromArgb( 28, 28, 28 );
            ThemeStyle.CaptionBackColor = Color.FromArgb( 28, 28, 28 );
            ThemeStyle.CaptionForeColor = Color.Black;
            ThemeStyle.ComboBoxStyle.BorderColor = Color.FromArgb( 65, 65, 65 );
            ThemeStyle.ComboBoxStyle.HoverBorderColor = Color.SteelBlue;
            ThemeStyle.HoverItemBackColor = Color.SteelBlue;
            ThemeStyle.HoverItemForeColor = Color.White;
            VisibleChanged += OnVisible;
        }

        /// <summary>
        /// Gets the buttons.
        /// </summary>
        /// <returns></returns>
        public IDictionary<string, ToolStripButton> GetButtons()
        {
            var _buttons = new SortedList<string, ToolStripButton>( );

            if( Items?.Count > 0 )
            {
                foreach( var _control in Items )
                {
                    if( _control is ToolStripButton _item )
                    {
                        if( !string.IsNullOrEmpty( _item?.Name ) )
                        {
                            _buttons.Add( _item?.Name, _item );
                        }
                    }
                }

                return _buttons?.Count > 0
                    ? _buttons
                    : default( SortedList<string, ToolStripButton> );
            }

            return default( IDictionary<string, ToolStripButton> );
        }


        /// <summary>
        /// Called when [load].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the event data.</param>
        protected void OnVisible( object sender, EventArgs e )
        {
            if( sender is ToolStrip )
            {
                Items.Clear( );
                Items.Add( Label );
                Items.Add( new ToolSeparator( ) );
                Items.Add( TextBox );
                Items.Add( new ToolSeparator( ) );
                Items.Add( DropDown );
                Items.Add( new ToolSeparator( ) );
                FirstButton.SetImage( );
                Items.Add( FirstButton );
                Items.Add( new ToolSeparator( ) );
                PreviousButton.SetImage( );
                Items.Add( PreviousButton );
                Items.Add( new ToolSeparator( ) );
                NextButton.SetImage( );
                Items.Add( NextButton );
                Items.Add( new ToolSeparator( ) );
                LastButton.SetImage( );
                Items.Add( LastButton );
                Items.Add( new ToolSeparator( ) );
                EditButton.SetImage( );
                Items.Add( EditButton );
                Items.Add( new ToolSeparator( ) );
                AddButton.SetImage( );
                Items.Add( AddButton );
                Items.Add( new ToolSeparator( ) );
                DeleteButton.SetImage( );
                Items.Add( DeleteButton );
                Items.Add( new ToolSeparator( ) );
                SaveButton.SetImage( );
                Items.Add( SaveButton );
                Items.Add( new ToolSeparator( ) );
                RefreshButton.SetImage( );
                Items.Add( RefreshButton );
                Items.Add( new ToolSeparator( ) );
                BrowseButton.SetImage( );
                Items.Add( BrowseButton );
                Items.Add( new ToolSeparator( ) );
                PrintButton.SetImage( );
                Items.Add( PrintButton );
                Items.Add( new ToolSeparator( ) );
                ExcelButton.SetImage( );
                Items.Add( ExcelButton );
                Items.Add( new ToolSeparator( ) );
                CalculatorButton.SetImage( );
                Items.Add( CalculatorButton );
                Items.Add( new ToolSeparator( ) );
                HomeButton.SetImage( );
                Items.Add( HomeButton );
                Items.Add( new ToolSeparator( ) );
                Items.Add( ProgressBar );
                Items.Add( new ToolSeparator( ) );
            }
        }

        /// <summary>
        /// Populates the buttons on the toolstrip
        /// </summary>
        public virtual void CreateButtons( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}