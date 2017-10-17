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
	/// <summary>Song</summary>
	[PublishedContentModel("song")]
	public partial class Song : PublishedContentModel, ISEO
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "song";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Song(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Song, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Song Name
		///</summary>
		[ImplementPropertyType("songName")]
		public string SongName
		{
			get { return this.GetPropertyValue<string>("songName"); }
		}

		///<summary>
		/// Song Name Translation
		///</summary>
		[ImplementPropertyType("songNameTranslation")]
		public string SongNameTranslation
		{
			get { return this.GetPropertyValue<string>("songNameTranslation"); }
		}

		///<summary>
		/// Song Text
		///</summary>
		[ImplementPropertyType("songText")]
		public Newtonsoft.Json.Linq.JToken SongText
		{
			get { return this.GetPropertyValue<Newtonsoft.Json.Linq.JToken>("songText"); }
		}

		///<summary>
		/// Translator
		///</summary>
		[ImplementPropertyType("translator")]
		public Umbraco.Web.Models.RelatedLinks Translator
		{
			get { return this.GetPropertyValue<Umbraco.Web.Models.RelatedLinks>("translator"); }
		}

		///<summary>
		/// PageDescription
		///</summary>
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetMetaDescription(this); }
		}

		///<summary>
		/// Page Title
		///</summary>
		[ImplementPropertyType("pageTitle")]
		public string PageTitle
		{
			get { return Umbraco.Web.PublishedContentModels.SEO.GetPageTitle(this); }
		}
	}
}
