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
            VisibleChanged += OnLoad;
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
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual void AddTextBox( )
        {
            try
            {
                var _textBox = new ToolStripTextBox( );
                Items?.Add( _textBox );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public virtual void AddComboBox( )
        {
            try
            {
                var _comboBox = new ToolStripComboBoxEx( );
                Items?.Add( _comboBox );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public virtual void AddDropDownItem( object item )
        {
            try
            {
                DropDown?.ComboBox?.Items.Add( item );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public virtual void ResetDropDownList( IEnumerable<object> items )
        {
            try
            {
                DropDown?.ComboBox.Items?.Clear( );
                if ( items?.Count( ) > 0 )
                {
                    foreach( var item in items )
                    {
                        DropDown?.ComboBox?.Items?.Add( item );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the toolbar ComboBox.
        /// </summary>
        public void PopulateComboBoxItems()
        {
            try
            {
                foreach( var _name in Enum.GetNames( typeof( SQL ) ) )
                {
                    if( !string.IsNullOrEmpty( _name )
                        && _name != "NS" )
                    {
                        DropDown?.ComboBox.Items.Add( _name );
                    }
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Creates the text box.
        /// </summary>
        /// <returns>
        /// </returns>
        public virtual void AddSeparator()
        {
            try
            {
                var _separator = new ToolSeparator( );
                Items?.Add( _separator );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Populates the tools.
        /// </summary>
        public virtual void PopulateTools( )
        {
            try
            {
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        public ToolStripButton CreateButton( ToolType tool )
        {
            try
            {
                var _assembly = Assembly.GetAssembly( GetType( ) );
                var _manager = new ResourceManager( $"ToolStrip.resx", _assembly );
                using( var _stream = _manager.GetStream( $"{ tool }.png" ) )
                {
                    if( _stream != null )
                    {
                        var _image = Bitmap.FromStream( _stream );
                        PreviousButton.Image = _image;
                    }
                }
            }
            catch ( Exception ex )
            {
                Fail( ex );
                return default( ToolStripButton );
            }

            return default( ToolStripButton );
        }

        /// <summary>
        /// Sets the button image.
        /// </summary>
        /// <param name="button">The button.</param>
        /// <returns></returns>
        public ToolStripButton SetButtonImage( ToolStripButton button )
        {
            if( button != null 
                && Enum.IsDefined( typeof( ToolType ), button.ToolType ) )
            {
                try
                {
                    var _assembly = Assembly.GetAssembly( GetType( ) );
                    var _manager = new ResourceManager( $"ToolStrip.resx", _assembly );
                    var _file = button.ToolType.ToString( );
                    var _toolButton = new ToolStripButton
                    {
                        ToolType = button.ToolType,
                        Name = button.ToolType.ToString( ),
                        Text = "",
                        HoverText = button.HoverText
                    };

                    using( var _stream = _manager?.GetStream( $"{ _file }.png" ) )
                    {
                        if( _stream != null )
                        {
                            var _image = Bitmap.FromStream( _stream );
                            _toolButton.Image = _image;
                        }
                    }

                    return _toolButton.Image != null 
                        ? _toolButton 
                        : default( ToolStripButton );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( ToolStripButton );
                }
            }

            return default( ToolStripButton );
        }
    }
}