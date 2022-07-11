﻿// <copyright file="{ClassName}.cs" company="Terry D. Eppler">
// Copyright (c) Eppler. All rights reserved.
// </copyright>

namespace BudgetExecution
{
    using System;
    using System.Diagnostics.CodeAnalysis;
    using System.Text;
    using System.Xml.Serialization;
    using System.IO;
    using System.Runtime.Serialization;
    using System.Runtime.Serialization.Formatters.Binary;
    using System.Runtime.Serialization.Json;
    using System.Web.Script.Serialization;

    /// <summary>
    /// 
    /// </summary>
    [SuppressMessage( "ReSharper", "CompareNonConstrainedGenericWithNull" )]
    public static class TypeObject
    {
        /// <summary>
        /// Copies the specified type.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static T Copy<T>( this T type ) where T : ISerializable
        {
            if( type != null )
            {
                try
                {
                    using( var _stream = new MemoryStream(  ) )
                    {
                        var _formatter = new BinaryFormatter( );
                        _formatter.Serialize( _stream, type );
                        _stream.Position = 0;
                        return (T)_formatter.Deserialize( _stream );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( T );
                }
            }

            return default( T );
        }

        /// <summary>
        /// Converts to json.
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="type">The type.</param>
        /// <returns></returns>
        public static string ToJson<T>( this T type )
        {
            if( type != null )
            {
                try
                {
                    var _encoding = Encoding.Default;
                    var _serializer = new DataContractJsonSerializer( typeof( T ) );

                    using( var stream = new MemoryStream(  ) )
                    {
                        _serializer.WriteObject( stream, type );
                        var json = _encoding.GetString( stream.ToArray( ) );
                        return json;
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary>
        /// An object extension method that serialize an object to binary.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="type">The @type to act on.</param>
        /// <returns>
        /// A string.
        /// </returns>
        public static string SerializeBinary<T>( this T type )
        {
            if( type != null )
            {
                try
                {
                    var _formatter = new BinaryFormatter( );

                    using(  var _stream = new MemoryStream(  ) )
                    {
                        _formatter.Serialize( _stream, type );
                        return Encoding.Default.GetString( _stream.ToArray( ) );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary>
        /// An object extension method that serialize an object to binary.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="type">The @type to act on.</param>
        /// <param name="encoding">The encoding.</param>
        /// <returns>
        /// A string.
        /// </returns>
        public static string SerializeBinary<T>( this T type, Encoding encoding )
        {
            if( type != null )
            {
                try
                {
                    var _formatter = new BinaryFormatter( );

                    using( var _stream = new MemoryStream(  ) )
                    {
                        _formatter.Serialize( _stream, type );
                        return encoding.GetString( _stream.ToArray( ) );
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary>
        /// An object extension method that serialize a string to XML.
        /// </summary>
        /// <param name="type">The @type to act on.</param>
        /// <returns>
        /// The string representation of the Xml Serialization.
        /// </returns>
        public static string SerializeXml( this object type )
        {
            if( type != null )
            {
                try
                {
                    var _serializer = new XmlSerializer( type.GetType( ) );

                    using( var _writer = new StringWriter( ) )
                    {
                        _serializer?.Serialize( _writer, type );
                        var _string = _writer?.GetStringBuilder( )?.ToString( );
                        using( var _reader = new StringReader( _string ) )
                        {
                            return _reader.ReadToEnd( );
                        }
                    }
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }

            return default( string );
        }

        /// <summary>
        ///     A T extension method that serialize java script.
        /// </summary>
        /// <typeparam name="T">Generic type parameter.</typeparam>
        /// <param name="type">The @type to act on.</param>
        /// <returns>A string.</returns>
        public static string SerializeJavaScript<T>( this T type )
        {
            if( type != null )
            {
                try
                {
                    var _serializer = new JavaScriptSerializer( );
                    return _serializer.Serialize( type );
                }
                catch( Exception ex )
                {
                    Fail( ex );
                    return default( string );
                }
            }

            return default( string );
        }
        
        /// <summary>Fails the specified ex.</summary>
        /// <param name="ex">The ex.</param>
        private static void Fail( Exception ex )
        {
            using( var _error = new Error( ex ) )
            {
                _error?.SetText( );
                _error?.ShowDialog( );
            }
        }
    }
}
