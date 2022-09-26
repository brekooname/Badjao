﻿// <copyright file = "CarouselBase.cs" company = "Terry D. Eppler">
// Copyright (c) Terry D. Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Collections.Generic;
    using System.Collections.Specialized;
    using System.Configuration;
    using System.Diagnostics.CodeAnalysis;
    using System.Drawing;
    using System.IO;
    using System.Linq;
    using System.Windows.Forms;
    using Syncfusion.Windows.Forms.Tools;

    [ SuppressMessage( "ReSharper", "VirtualMemberNeverOverridden.Global" ) ]
    public abstract class CarouselBase : Carousel
    {
        /// <summary>
        /// Gets or sets the binding source.
        /// </summary>
        /// <value>
        /// The binding source.
        /// </value>
        public virtual SourceBinding BindingSource { get; set; }

        /// <summary>
        /// Gets or sets the images.
        /// </summary>
        /// <value>
        /// The images.
        /// </value>
        public virtual IEnumerable<Image> Images { get; set; }

        /// <summary>
        /// Gets or sets the tool tip.
        /// </summary>
        /// <value>
        /// The tool tip.
        /// </value>
        public virtual MetroTip ToolTip { get; set; }

        /// <summary>
        /// Gets or sets the field.
        /// </summary>
        /// <value>
        /// The field.
        /// </value>
        public virtual Field Field { get; set; }

        /// <summary>
        /// Gets or sets the filter.
        /// </summary>
        /// <value>
        /// The filter.
        /// </value>
        public virtual IDictionary<string, object> DataFilter { get; set; }

        /// <summary>
        /// Gets or sets the hover text.
        /// </summary>
        /// <value>
        /// The hover text.
        /// </value>
        public virtual string HoverText { get; set; }

        /// <summary>
        /// Gets or sets the settings.
        /// </summary>
        /// <value>
        /// The settings.
        /// </value>
        public virtual NameValueCollection Setting { get; set; } = ConfigurationManager.AppSettings;

        /// <summary>Initializes a new instance of the class.
        /// 	<see cref="CarouselBase" />
        /// </summary>
        protected CarouselBase( )
        {
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="size">The size.</param>
        public virtual void ReSize( Size size )
        {
            try
            {
                Size = size;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the size.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        public virtual void ReSize( int width, int height )
        {
            try
            {
                Size = new Size( width, height );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the text.
        /// </summary>
        /// <param name="text">The text.</param>
        public virtual void SetText( string text )
        {
            try
            {
                Text = text;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="point">The point.</param>
        public virtual void ReLocate( Point point )
        {
            try
            {
                Location = Settings.ReLocate( point );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the location.
        /// </summary>
        /// <param name="x">The x.</param>
        /// <param name="y">The y.</param>
        public virtual void ReLocate( int x, int y )
        {
            try
            {
                Location = Settings.ReLocate( x, y );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the color of the back.
        /// </summary>
        /// <param name="color">The color.</param>
        public virtual void SetBackColor( Color color )
        {
            try
            {
                BackColor = color;
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the anchor style.
        /// </summary>
        /// <param name="anchor">The anchor.</param>
        public virtual void ReAnchor( AnchorStyles anchor )
        {
            try
            {
                Anchor = Settings.ReAnchor( anchor );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the dock style.
        /// </summary>
        /// <param name="dock">The dock.</param>
        public virtual void ReDock( DockStyle dock )
        {
            try
            {
                Dock = Settings.ReDock( dock );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the field.
        /// </summary>
        /// <param name="field">The field.</param>
        public virtual void SetField( Field field )
        {
            try
            {
                Field = BudgetForm.GetField( field );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tag.
        /// </summary>
        /// <param name="tag">The tag.</param>
        public virtual void ReTag( object tag )
        {
            try
            {
                Tag = Settings.ReTag( tag );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the tool tip.
        /// </summary>
        /// <param name="tip">The tip.</param>
        public virtual void SetToolTip( string tip )
        {
            try
            {
                Tag = Settings.GetToolTip( this, tip );
            }
            catch( Exception ex )
            {
                Fail( ex );
            }
        }

        /// <summary>
        /// Sets the image.
        /// </summary>
        /// <param name="image">The image.</param>
        public virtual void AddImage( Image image )
        {
            if( image != null )
            {
                try
                {
                    ImageList.Images.Add( image );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                }
            }
        }

        /// <summary>
        /// Creates the image list.
        /// </summary>
        /// <param name="srcDir">The source dir.</param>
        /// <returns></returns>
        public virtual ImageList CreateImageList( string srcDir )
        {
            if( Directory.Exists( srcDir ) )
            {
                IEnumerable<string> _files = Directory.EnumerateFiles( srcDir );
                List<string> _paths = _files?.ToList( );
                ImageList _list = new ImageList( );

                for( int i = 0; i < _paths.Count; i++ )
                {
                    if( !string.IsNullOrEmpty( _paths[ i ] )
                        && File.Exists( _paths[ i ] ) )
                    {
                        using( FileStream _stream = File.Open( _paths[ i ], FileMode.Open ) )
                        {
                            Bitmap _img = new Bitmap( _stream );
                            _list?.Images?.Add( _img );
                        }
                    }
                }

                return _list?.Images?.Count > 0
                    ? _list
                    : default( ImageList );
            }

            return default( ImageList );
        }

        /// <summary>
        /// Creates the image list.
        /// </summary>
        /// <param name="srcDir">The source dir.</param>
        /// <param name = "size" > </param>
        /// <returns></returns>
        public virtual ImageList CreateImageList( string srcDir, Size size )
        {
            if( Directory.Exists( srcDir ) )
            {
                IEnumerable<string> _files = Directory.EnumerateFiles( srcDir );
                List<string> _paths = _files?.ToList( );
                ImageList _list = new ImageList( );

                for( int i = 0; i < _paths.Count; i++ )
                {
                    if( !string.IsNullOrEmpty( _paths[ i ] )
                        && File.Exists( _paths[ i ] ) )
                    {
                        string _name = Path.GetFileNameWithoutExtension( _paths[ i ] );

                        using( FileStream _stream = File.Open( _paths[ i ], FileMode.Open ) )
                        {
                            Bitmap _img = new Bitmap( _stream ) { Tag = _name };

                            _list.ImageSize = size;
                            _list?.Images?.Add( _img );
                        }
                    }
                }

                return _list?.Images?.Count > 0
                    ? _list
                    : default( ImageList );
            }

            return default( ImageList );
        }

        /// <summary>
        /// Creates the carousel items.
        /// </summary>
        /// <param name="paths">The images.</param>
        /// <returns></returns>
        public virtual IEnumerable<CarouselImage> CreateCarouselItems( IEnumerable<string> paths )
        {
            if( paths?.Any( ) == true )
            {
                List<string> _list = paths.ToList( );
                List<CarouselImage> _carouselImages = new List<CarouselImage>( );

                for( int i = 0; i < _list?.Count; i++ )
                {
                    if( !string.IsNullOrEmpty( _list[ i ] )
                        && File.Exists( _list[ i ] ) )
                    {
                        using( FileStream _stream = File.Open( _list[ i ], FileMode.Open ) )
                        {
                            using( Bitmap _img = new Bitmap( _stream ) )
                            {
                                CarouselImage _carouselImage = new CarouselImage
                                    { ItemImage = _img };

                                _carouselImages.Add( _carouselImage );
                            }
                        }
                    }
                }

                return _carouselImages.Any( )
                    ? _carouselImages
                    : default( IEnumerable<CarouselImage> );
            }

            return default( IEnumerable<CarouselImage> );
        }

        /// <summary>
        /// Get Error Dialog.
        /// </summary>
        /// <param name="ex">The ex.</param>
        [ SuppressMessage( "ReSharper", "MemberCanBePrivate.Global" ) ]
        protected void Fail( Exception ex )
        {
            using( Error _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}