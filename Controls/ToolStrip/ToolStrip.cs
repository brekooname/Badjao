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

    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="ToolStripBase" />
    [SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" )]
    [SuppressMessage( "ReSharper", "UnusedParameter.Global" )]
    [SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" )]
    [SuppressMessage( "ReSharper", "AutoPropertyCanBeMadeGetOnly.Local" )]
    [SuppressMessage( "ReSharper", "ObjectCreationAsStatement" )]
    [SuppressMessage( "ReSharper", "UnassignedGetOnlyAutoProperty" )]
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
        public ToolStrip()
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
            Text = "Budget Execution";
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
            ImageDirectory = Setting[ "ToolStripImages" ];
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
        public virtual void PopulateTools()
        {
            try
            {
                var _firstRecord = ImageDirectory + @"\FirstButton.png";
                var _previousRecord = ImageDirectory + @"\PreviousButton.png";
                var _nextRecord = ImageDirectory + @"\NextButton.png";
                var _lastRecord = ImageDirectory + @"\LastButton.png";
                var _edit = ImageDirectory + @"\EditButton.png";
                var _add = ImageDirectory + @"\AddButton.png";
                var _delete = ImageDirectory + @"\DeleteButton.png";
                var _refresh = ImageDirectory + @"\RefreshButton.png";
                var _save = ImageDirectory + @"\SaveButton.png";
                var _browse = ImageDirectory + @"\BrowseButton.png";
                var _print = ImageDirectory + @"\PrintButton.png";
                var _excelFile = ImageDirectory + @"\ExcelButton.png";
                var _calculator = ImageDirectory + @"\CalculatorButton.png";
                Items.Add( new ToolSeparator( ) );
                TextBox = new ToolStripTextBox( );
                Items.Add( TextBox );
                Items.Add( new ToolSeparator( ) );
                DropDown = new ToolStripDropDown( );
                Items.Add( DropDown );
                Items.Add( new ToolSeparator( ) );

                FirstButton = new ToolStripButton
                {
                    ToolType = ToolType.FirstButton,
                    Image = Image.FromFile( _firstRecord ),
                    BindingSource = BindingSource,
                    HoverText = "Go To Beginning"
                };

                Items.Add( FirstButton );
                Items.Add( new ToolSeparator( ) );

                PreviousButton = new ToolStripButton
                {
                    ToolType = ToolType.PreviousButton,
                    Image = Image.FromFile( _previousRecord ),
                    BindingSource = BindingSource,
                    HoverText = "Go To Previous"
                };

                Items.Add( PreviousButton );
                Items.Add( new ToolSeparator( ) );

                NextButton = new ToolStripButton
                {
                    ToolType = ToolType.NextButton,
                    Image = Image.FromFile( _nextRecord ),
                    BindingSource = BindingSource,
                    HoverText = "Go To Next Record"
                };

                Items.Add( NextButton );
                Items.Add( new ToolSeparator( ) );

                LastButton = new ToolStripButton
                {
                    ToolType = ToolType.LastButton,
                    Image = Image.FromFile( _lastRecord ),
                    BindingSource = BindingSource,
                    HoverText = "Go To Last Record"
                };

                Items.Add( LastButton );
                Items.Add( new ToolSeparator( ) );

                EditButton = new ToolStripButton
                {
                    ToolType = ToolType.EditButton,
                    Image = Image.FromFile( _edit ),
                    HoverText = "Edit Record"
                };

                Items.Add( EditButton );
                Items.Add( new ToolSeparator( ) );

                AddButton = new ToolStripButton
                {
                    ToolType = ToolType.AddButton,
                    Image = Image.FromFile( _add ),
                    HoverText = "Add Record"
                };

                Items.Add( AddButton );
                Items.Add( new ToolSeparator( ) );

                DeleteButton = new ToolStripButton
                {
                    ToolType = ToolType.DeleteButton,
                    Image = Image.FromFile( _delete ),
                    HoverText = "Delete Record"
                };

                Items.Add( DeleteButton );
                Items.Add( new ToolSeparator( ) );

                RefreshButton = new ToolStripButton
                {
                    ToolType = ToolType.RefreshButton,
                    Image = Image.FromFile( _refresh ),
                    HoverText = "Refresh Data"
                };

                Items.Add( RefreshButton );
                Items.Add( new ToolSeparator( ) );

                SaveButton = new ToolStripButton
                {
                    ToolType = ToolType.SaveButton,
                    Image = Image.FromFile( _save ),
                    HoverText = "Save Changes"
                };

                Items.Add( SaveButton );
                Items.Add( new ToolSeparator( ) );

                BrowseButton = new ToolStripButton
                {
                    ToolType = ToolType.BrowseButton,
                    Image = Image.FromFile( _browse ),
                    HoverText = "Browse for file"
                };

                Items.Add( BrowseButton );
                Items.Add( new ToolSeparator( ) );

                PrintButton = new ToolStripButton
                {
                    ToolType = ToolType.PrintButton,
                    Image = Image.FromFile( _print ),
                    HoverText = "Print Data"
                };

                Items.Add( PrintButton );
                Items.Add( new ToolSeparator( ) );

                ExcelButton = new ToolStripButton
                {
                    ToolType = ToolType.ExcelButton,
                    Image = Image.FromFile( _excelFile ),
                    HoverText = "Export to Excel"
                };

                Items.Add( ExcelButton );
                Items.Add( new ToolSeparator( ) );

                CalculatorButton = new ToolStripButton
                {
                    ToolType = ToolType.CalculatorButton,
                    Image = Image.FromFile( _calculator ),
                    HoverText = "Launch Calculator"
                };

                Items.Add( CalculatorButton );
                Items.Add( new ToolSeparator( ) );

                ProgressBar = new ToolStripProgressBar
                {
                    Visible = false
                };

                Items.Add( ProgressBar );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }
    }
}