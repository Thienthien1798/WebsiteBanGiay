#pragma checksum "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef25b7b9c1276c65563ee9107d3f44c5d611e9b5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Search_ListProductsSearchPartial), @"mvc.1.0.view", @"/Views/Search/ListProductsSearchPartial.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\g\Documents\OnlineMarket\Views\_ViewImports.cshtml"
using WebApplication1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\g\Documents\OnlineMarket\Views\_ViewImports.cshtml"
using WebApplication1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef25b7b9c1276c65563ee9107d3f44c5d611e9b5", @"/Views/Search/ListProductsSearchPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"03350a0a69106539bd5bc7a986cfffe7a4c319da", @"/Views/_ViewImports.cshtml")]
    public class Views_Search_ListProductsSearchPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-full"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml"
 if (Model != null && Model.Count() > 0)
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml"
     foreach (var item in Model)
    {
        string url = $"/{item.Alias}-{item.ProductId}";

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12\">\r\n            <div class=\"product-item\">\r\n                <div class=\"product-img img-zoom-effect\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 294, "\"", 305, 1);
#nullable restore
#line 9 "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml"
WriteAttributeValue("", 301, url, 301, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "ef25b7b9c1276c65563ee9107d3f44c5d611e9b54501", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 360, "~/images/products/", 360, 18, true);
#nullable restore
#line 10 "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml"
AddHtmlAttributeValue("", 378, item.Thumb, 378, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 10 "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml"
AddHtmlAttributeValue("", 396, item.Title, 396, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </a>
                    <div class=""product-add-action"">
                        <ul>
                            <li>
                                <a href=""cart.html"">
                                    <i class=""pe-7s-cart""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""compare.html"">
                                    <i class=""pe-7s-shuffle""></i>
                                </a>
                            </li>
                            <li>
                                <a href=""wishlist.html"">
                                    <i class=""pe-7s-like""></i>
                                </a>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""product-content align-self-center"">
                    <a class=""product-name pb-2""");
            BeginWriteAttribute("href", " href=\"", 1402, "\"", 1413, 1);
#nullable restore
#line 33 "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml"
WriteAttributeValue("", 1409, url, 1409, 4, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 33 "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml"
                                                        Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n                    <div class=\"price-box pb-1\">\r\n                        <span class=\"new-price\">");
#nullable restore
#line 35 "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml"
                                           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                    </div>
                    <div class=""rating-box pb-2"">
                        <ul>
                            <li><i class=""pe-7s-star""></i></li>
                            <li><i class=""pe-7s-star""></i></li>
                            <li><i class=""pe-7s-star""></i></li>
                            <li><i class=""pe-7s-star""></i></li>
                            <li><i class=""pe-7s-star""></i></li>
                        </ul>
                    </div>
                    <p class=""short-desc mb-0"">");
#nullable restore
#line 46 "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml"
                                          Write(item.ShortDesc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 50 "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 50 "C:\Users\g\Documents\OnlineMarket\Views\Search\ListProductsSearchPartial.cshtml"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
