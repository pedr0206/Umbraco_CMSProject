//------------------------------------------------------------------------------
// <auto-generated>
//   This code was generated by a tool.
//
//    Umbraco.ModelsBuilder v8.6.1
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
using Umbraco.ModelsBuilder.Embedded;

namespace Umbraco.Web.PublishedModels
{
	/// <summary>HomePage</summary>
	[PublishedModel("homaePage")]
	public partial class HomaePage : PublishedContentModel, IMaster
	{
		// helpers
#pragma warning disable 0109 // new is redundant
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const string ModelTypeAlias = "homaePage";
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new const PublishedItemType ModelItemType = PublishedItemType.Content;
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public new static IPublishedContentType GetModelContentType()
			=> PublishedModelUtility.GetModelContentType(ModelItemType, ModelTypeAlias);
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		public static IPublishedPropertyType GetModelPropertyType<TValue>(Expression<Func<HomaePage, TValue>> selector)
			=> PublishedModelUtility.GetModelPropertyType(GetModelContentType(), selector);
#pragma warning restore 0109

		// ctor
		public HomaePage(IPublishedContent content)
			: base(content)
		{ }

		// properties

		///<summary>
		/// Footer
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("footer")]
		public string Footer => this.Value<string>("footer");

		///<summary>
		/// Logo: Choose a Logo for the site
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("logo")]
		public global::Umbraco.Core.Models.PublishedContent.IPublishedContent Logo => this.Value<global::Umbraco.Core.Models.PublishedContent.IPublishedContent>("logo");

		///<summary>
		/// Main Content
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("mainContent")]
		public global::System.Web.IHtmlString MainContent => this.Value<global::System.Web.IHtmlString>("mainContent");

		///<summary>
		/// Site Title: Give a title for the site
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("siteTitle")]
		public string SiteTitle => this.Value<string>("siteTitle");

		///<summary>
		/// Meta Description
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("metaDescription")]
		public string MetaDescription => global::Umbraco.Web.PublishedModels.Master.GetMetaDescription(this);

		///<summary>
		/// Meta Keywords
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("metaKeywords")]
		public string MetaKeywords => global::Umbraco.Web.PublishedModels.Master.GetMetaKeywords(this);

		///<summary>
		/// Hide from navigation
		///</summary>
		[global::System.CodeDom.Compiler.GeneratedCodeAttribute("Umbraco.ModelsBuilder", "8.6.1")]
		[ImplementPropertyType("umbracoNaviHide")]
		public bool UmbracoNaviHide => global::Umbraco.Web.PublishedModels.Master.GetUmbracoNaviHide(this);
	}
}