﻿using System;

namespace EmbedIO.Routing
{
    partial class RoutingModuleExtensions
    {
        /// <summary>
        /// Adds a handler to a <see cref="RoutingModule"/>.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="verb">A <see cref="HttpVerb"/> constant representing the HTTP method
        /// to associate with <paramref name="handler"/>, or <see cref="HttpVerb.Any"/>
        /// if <paramref name="handler"/> can handle all HTTP methods.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        /// <seealso cref="RoutingModule.Add(HttpVerb,RouteMatcher,RouteHandlerCallback)"/>
        public static RoutingModule Handle(this RoutingModule @this, HttpVerb verb, RouteMatcher matcher, RouteHandlerCallback handler)
        {
            @this.Add(verb, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Adds a synchronous handler to a <see cref="RoutingModule"/>.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="verb">A <see cref="HttpVerb"/> constant representing the HTTP method
        /// to associate with <paramref name="handler"/>, or <see cref="HttpVerb.Any"/>
        /// if <paramref name="handler"/> can handle all HTTP methods.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        /// <seealso cref="RoutingModule.Add(HttpVerb,RouteMatcher,SyncRouteHandlerCallback)"/>
        public static RoutingModule Handle(this RoutingModule @this, HttpVerb verb, RouteMatcher matcher, SyncRouteHandlerCallback handler)
        {
            @this.Add(verb, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates all requests matching a route to a handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnAny(this RoutingModule @this, RouteMatcher matcher, RouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Any, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates all requests matching a route to a synchronous handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnAny(this RoutingModule @this, RouteMatcher matcher, SyncRouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Any, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>DELETE</c> requests matching a route to a handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnDelete(this RoutingModule @this, RouteMatcher matcher, RouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Delete, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>DELETE</c> requests matching a route to a synchronous handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnDelete(this RoutingModule @this, RouteMatcher matcher, SyncRouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Delete, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>GET</c> requests matching a route to a handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnGet(this RoutingModule @this, RouteMatcher matcher, RouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Get, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>GET</c> requests matching a route to a synchronous handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnGet(this RoutingModule @this, RouteMatcher matcher, SyncRouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Get, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>HEAD</c> requests matching a route to a handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnHead(this RoutingModule @this, RouteMatcher matcher, RouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Head, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>HEAD</c> requests matching a route to a synchronous handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnHead(this RoutingModule @this, RouteMatcher matcher, SyncRouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Head, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>OPTIONS</c> requests matching a route to a handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnOptions(this RoutingModule @this, RouteMatcher matcher, RouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Options, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>OPTIONS</c> requests matching a route to a synchronous handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnOptions(this RoutingModule @this, RouteMatcher matcher, SyncRouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Options, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>PATCH</c> requests matching a route to a handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnPatch(this RoutingModule @this, RouteMatcher matcher, RouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Patch, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>PATCH</c> requests matching a route to a synchronous handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnPatch(this RoutingModule @this, RouteMatcher matcher, SyncRouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Patch, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>POST</c> requests matching a route to a handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnPost(this RoutingModule @this, RouteMatcher matcher, RouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Post, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>POST</c> requests matching a route to a synchronous handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnPost(this RoutingModule @this, RouteMatcher matcher, SyncRouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Post, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>PUT</c> requests matching a route to a handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnPut(this RoutingModule @this, RouteMatcher matcher, RouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Put, matcher, handler);
            return @this;
        }

        /// <summary>
        /// Associates <c>PUT</c> requests matching a route to a synchronous handler.
        /// </summary>
        /// <param name="this">The <see cref="RoutingModule"/> on which this method is called.</param>
        /// <param name="matcher">The <see cref="RouteMatcher"/> used to match URL paths.</param>
        /// <param name="handler">A callback used to handle matching contexts.</param>
        /// <returns><paramref name="this"/> with the handler added.</returns>
        /// <exception cref="NullReferenceException"><paramref name="this"/> is <see langword="null"/>.</exception>
        /// <exception cref="ArgumentNullException">
        /// <para><paramref name="matcher"/> is <see langword="null"/>.</para>
        /// <para>- or -</para>
        /// <para><paramref name="handler"/> is <see langword="null"/>.</para>
        /// </exception>
        public static RoutingModule OnPut(this RoutingModule @this, RouteMatcher matcher, SyncRouteHandlerCallback handler)
        {
            @this.Add(HttpVerb.Put, matcher, handler);
            return @this;
        }
    }
}