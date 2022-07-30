// <copyright file = "BarButton.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Windows.Forms;
    using System.Drawing;
    using System.IO;

    [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
    [ SuppressMessage( "ReSharper", "UnusedParameter.Global" ) ]
    [ SuppressMessage( "ReSharper", "ClassNeverInstantiated.Global" ) ]
    [ SuppressMessage( "ReSharper", "UsePatternMatching" ) ]
    [ Serializable ]
    [ SuppressMessage( "ReSharper", "MergeConditionalExpression" ) ]
    public class ToolStripButton : ToolStripButtonBase, IToolStripButton
    {
        /// <summary>
        /// Initializes a new instance of
        /// the <see cref="ToolStripButton"/> class.
        /// </summary>
        public ToolStripButton( )
        {
            Margin = new Padding( 5, 5, 5, 5 );
            Padding = new Padding( 0 );
            DisplayStyle = ToolStripItemDisplayStyle.Image;
            BackColor = Color.FromArgb( 15, 15, 15 );
            ForeColor = Color.LightSteelBlue;
            Font = new Font( "Roboto", 9 );
            AutoToolTip = false;
            MouseHover += OnMouseHover;
            MouseLeave += OnMouseLeave;
            Click += OnClick;
            Text = string.Empty;
            Visible = true;
            Enabled = true;
        }

        /// <summary>
        /// Initializes a new instance
        /// Mof the <see cref="ToolStripButton"/> class.
        /// </summary>
        /// <param name="tool">The tool.</param>
        public ToolStripButton( ToolType tool )
            : this( )
        {
            ToolType = tool;
            Name = tool.ToString( );
            HoverText = GetHoverText( tool );
            Image = GetImage( tool );
        }


        /// <summary>
        /// Called when [mouse over].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public void OnMouseHover( object sender, EventArgs e )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    HoverText = GetHoverText( ToolType );
                    if( !string.IsNullOrEmpty( HoverText ) )
                    {
                       var _ = new ToolTip( this, HoverText );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Called when [mouse leave].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public void OnMouseLeave( object sender, EventArgs e )
        {
            try
            {
                if( ToolTip?.Active == true )
                {
                    ToolTip.RemoveAll( );
                    ToolTip = null;
                }
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Called when [click].
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The <see cref="EventArgs"/> instance containing the
        ///     event data.</param>
        public void OnClick( object sender, EventArgs e )
        {
            if( sender is ToolStripButton _button )
            {
                try
                {
                    switch( _button?.ToolType )
                    {
                        case ToolType.FirstButton:
                        {
                            BindingSource?.MoveFirst( );
                            break;
                        }

                        case ToolType.PreviousButton:
                        {
                            BindingSource?.MovePrevious( );
                            break;
                        }

                        case ToolType.NextButton:
                        {
                            BindingSource?.MoveNext( );
                            break;
                        }

                        case ToolType.LastButton:
                        {
                            BindingSource?.MoveLast( );
                            break;
                        }

                        case ToolType.ExcelButton:
                        {
                            using( var _excelForm = new ExcelForm(  ) )
                            {
                                _excelForm?.ShowDialog( );
                            }

                            break;
                        }

                        case ToolType.PdfButton:
                        {
                            using( var _message = new PdfForm(  ) )
                            {
                                _message?.ShowDialog( );
                            }

                            break;
                        }

                        case ToolType.PrintButton:
                        {
                            using( var _message = new Message( "NOT YET IMPLEMENTED!" ) )
                            {
                                _message?.ShowDialog( );
                            }

                            break;
                        }

                        case ToolType.AddButton:
                        {
                            using( var _message = new Message( "NOT YET IMPLEMENTED!" ) )
                            {
                                _message?.ShowDialog( );
                            }

                            break;
                        }

                        case ToolType.DeleteButton:
                        {
                            using( var _message = new Message( "NOT YET IMPLEMENTED!" ) )
                            {
                                _message?.ShowDialog( );
                            }

                            break;
                        }

                        case ToolType.RefreshButton:
                        {
                            using( var _message = new Message( "NOT YET IMPLEMENTED!" ) )
                            {
                                _message?.ShowDialog( );
                            }

                            break;
                        }

                        case ToolType.EditButton:
                        {
                            using( var _message = new Message( "NOT YET IMPLEMENTED!" ) )
                            {
                                _message?.ShowDialog( );
                            }

                            break;
                        }

                        case ToolType.ExitButton:
                        {
                            var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
                            break;
                        }

                        case ToolType.ExportButton:
                        {
                            var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
                            break;
                        }

                        case ToolType.ImportButton:
                        {
                            var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
                            break;
                        }

                        case ToolType.UpdateButton:
                        {
                            var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
                            break;
                        }

                        case ToolType.InsertButton:
                        {
                            var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
                            break;
                        }

                        case ToolType.CalculatorButton:
                        {
                            var _calculator = new CalculationForm( );
                            _calculator?.ShowDialog( );
                            break;
                        }

                        case ToolType.BrowseButton:
                        {
                            var _message = new FileBrowser( );
                            _message?.ShowDialog( );
                            break;
                        }

                        default:
                        {
                            var _message = new Message( "NOT YET IMPLEMENTED!" );
                            _message?.ShowDialog( );
                            break;
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        public void SetImage( )
        {
            if( Enum.IsDefined( typeof( ToolType ), ToolType ) )
            {
                try
                {
                    Setting = ConfigurationManager.AppSettings;
                    var _path = Setting[ "ToolStrip" ] + $"{ ToolType }.png";
                    using( var _stream = File.Open( _path, FileMode.Open ) )
                    {
                        if( _stream != null )
                        {
                            var _image = Image.FromStream( _stream );
                            Image = _image;
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
        /// Sets the button image.
        /// </summary>
        /// <returns></returns>
        public Image GetImage( ToolType toolType )
        {
            if( Enum.IsDefined( typeof( ToolType ), toolType ) )
            {
                try
                {
                    Setting = ConfigurationManager.AppSettings;
                    var _path = Setting[ "ToolStrip" ] + $"{ toolType }.png";
                    using( var _stream = File.Open( _path, FileMode.Open ))
                    {
                        if( _stream != null )
                        {
                            var _image = Image.FromStream( _stream );
                            return _image != null
                                ? _image
                                : default( Image );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( Image );
                }
            }

            return default( Image );
        }
    }
}
