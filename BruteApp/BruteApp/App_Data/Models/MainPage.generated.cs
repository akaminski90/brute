//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v3.0.7.99
//
//   Changes to this file will be lost if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Web;
using Umbraco.Core.Models;
using Umbraco.Core.Models.PublishedContent;
using Umbraco.Web;
using Umbraco.ModelsBuilder;
using Umbraco.ModelsBuilder.Umbraco;

namespace Umbraco.Web.PublishedContentModels
{
	/// <summary>Main Page</summary>
	[PublishedContentModel("mainPage")]
	public partial class MainPage : PublishedContentModel, ISEO
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "mainPage";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public MainPage(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<MainPage, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Bottom Title
		///</summary>
		[ImplementPropertyType("bottomTitle")]
		public string BottomTitle
		{
			get { return this.GetPropertyValue<string>("bottomTitle"); }
		}

		///<summary>
		/// Default Description: {0} - musician {1} - song
		///</summary>
		[ImplementPropertyType("defaultDescription")]
		public string DefaultDescription
		{
			get { return this.GetPropertyValue<string>("defaultDescription"); }
		}

		///<summary>
		/// DefaultImage
		///</summary>
		[ImplementPropertyType("defaultImage")]
		public IPublishedContent DefaultImage
		{
			get { return this.GetPropertyValue<IPublishedContent>("defaultImage"); }
		}

		///<summary>
		/// Default Link Caption: {0} - musician {1} - song
		///</summary>
		[ImplementPropertyType("defaultLinkCaption")]
		public string DefaultLinkCaption
		{
			get { return this.GetPropertyValue<string>("defaultLinkCaption"); }
		}

		///<summary>
		/// Meta Image
		///</summary>
		[ImplementPropertyType("metaImg")]
		public IPublishedContent MetaImg
		{
			get { return this.GetPropertyValue<IPublishedContent>("metaImg"); }
		}

		///<summary>
		/// Musician Default SEO Page Description: {0} - musician
		///</summary>
		[ImplementPropertyType("musicianDefaultSEOPageDescription")]
		public string MusicianDefaultSeopageDescription
		{
			get { return this.GetPropertyValue<string>("musicianDefaultSEOPageDescription"); }
		}

		///<summary>
		/// Musician Default SEO Page Title: {0} - musician
		///</summary>
		[ImplementPropertyType("musicianDefaultSEOPageTitle")]
		public string MusicianDefaultSeopageTitle
		{
			get { return this.GetPropertyValue<string>("musicianDefaultSEOPageTitle"); }
		}

		///<summary>
		/// Musician Page Text: Use {0} to show where you want to insert the name of a musician
		///</summary>
		[ImplementPropertyType("musicianPageText")]
		public string MusicianPageText
		{
			get { return this.GetPropertyValue<string>("musicianPageText"); }
		}

		///<summary>
		/// Musicians
		///</summary>
		[ImplementPropertyType("musicians")]
		public IEnumerable<IPublishedContent> Musicians
		{
			get { return this.GetPropertyValue<IEnumerable<IPublishedContent>>("musicians"); }
		}

		///<summary>
		/// og:locale: Site localization
		///</summary>
		[ImplementPropertyType("oglocale")]
		public string Oglocale
		{
			get { return this.GetPropertyValue<string>("oglocale"); }
		}

		///<summary>
		/// og:site_name: Site name
		///</summary>
		[ImplementPropertyType("ogsite_name")]
		public string Ogsite_name
		{
			get { return this.GetPropertyValue<string>("ogsite_name"); }
		}

		///<summary>
		/// og:type: Content type
		///</summary>
		[ImplementPropertyType("ogtype")]
		public string Ogtype
		{
			get { return this.GetPropertyValue<string>("ogtype"); }
		}

		///<summary>
		/// Song Default SEO Page Description: {0} - musician {1} - song
		///</summary>
		[ImplementPropertyType("songDefaultSEOPageDescription")]
		public string SongDefaultSeopageDescription
		{
			get { return this.GetPropertyValue<string>("songDefaultSEOPageDescription"); }
		}

		///<summary>
		/// Song Default SEO Page Title: {0} - musician {1} - song
		///</summary>
		[ImplementPropertyType("songDefaultSEOPageTitle")]
		public string SongDefaultSeopageTitle
		{
			get { return this.GetPropertyValue<string>("songDefaultSEOPageTitle"); }
		}

		///<summary>
		/// Songs On Page: Number of songs on page of a band/musician
		///</summary>
		[ImplementPropertyType("songsOnPage")]
		public int SongsOnPage
		{
			get { return this.GetPropertyValue<int>("songsOnPage"); }
		}

		///<summary>
		/// Top Title
		///</summary>
		[ImplementPropertyType("topTitle")]
		public string TopTitle
		{
			get { return this.GetPropertyValue<string>("topTitle"); }
		}

		///<summary>
		/// VK and Facebook
		///</summary>
		[ImplementPropertyType("vKAndFacebook")]
		public string VKandFacebook
		{
			get { return this.GetPropertyValue<string>("vKAndFacebook"); }
		}

		///<summary>
		/// PageDescription: For meta and social networks meta tags
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// Page Title: For meta and social networks meta tags
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetPageTitle(this); }
		}
	}
}
