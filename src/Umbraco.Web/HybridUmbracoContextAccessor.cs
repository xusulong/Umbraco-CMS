﻿namespace Umbraco.Web
{
    internal class HybridUmbracoContextAccessor : HybridAccessorBase<UmbracoContext>, IUmbracoContextAccessor
    {
        protected override string ItemKey => "Umbraco.Web.UmbracoContext";

        public HybridUmbracoContextAccessor(IHttpContextAccessor httpContextAccessor)
            : base(httpContextAccessor)
        { }

        public UmbracoContext UmbracoContext
        {
            get { return Value; }
            set { Value = value; }
        }
    }
}