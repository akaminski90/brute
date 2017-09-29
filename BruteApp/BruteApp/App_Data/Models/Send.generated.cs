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
	/// <summary>Send</summary>
	[PublishedContentModel("send")]
	public partial class Send : PublishedContentModel, INavigation, ISEO
	{
#pragma warning disable 0109 // new is redundant
		public new const string ModelTypeAlias = "send";
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
#pragma warning restore 0109

		public Send(IPublishedContent content)
			: base(content)
		{ }

#pragma warning disable 0109 // new is redundant
		public new static PublishedContentType GetModelContentType()
		{
			return PublishedContentType.Get(ModelItemType, ModelTypeAlias);
		}
#pragma warning restore 0109

		public static PublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<Send, TValue>> selector)
		{
			return PublishedContentModelUtility.GetModelPropertyType(GetModelContentType(), selector);
		}

		///<summary>
		/// Upload
		///</summary>
		[ImplementPropertyType("upload")]
		public string Upload
		{
			get { return this.GetPropertyValue<string>("upload"); }
		}

		///<summary>
		/// Navigation Name: Page name for navbar
		///</summary>
		[ImplementPropertyType("navigationName")]
		public string NavigationName
		{
			get { return Umbraco.Web.PublishedContentModels.Navigation.GetNavigationName(this); }
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
