#pragma checksum "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\LatestArticales\_LatestArticales.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "16ef0518590348c6694295da047eb18147497db1f09f96a266848acc085da94b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_LatestArticales__LatestArticales), @"mvc.1.0.view", @"/Views/Home/Components/LatestArticales/_LatestArticales.cshtml")]
namespace AspNetCore
{
    #line hidden
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\_ViewImports.cshtml"
using DevCart;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\_ViewImports.cshtml"
using DevCart.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"16ef0518590348c6694295da047eb18147497db1f09f96a266848acc085da94b", @"/Views/Home/Components/LatestArticales/_LatestArticales.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"39034af3b196f7af391de589abd6f1074b2bdbb0e86a627a4dc463ed4420aa2f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Components_LatestArticales__LatestArticales : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Article>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n\r\n<section class=\"latest-blog-section p-3 p-lg-5\">\r\n\t<div class=\"container\">\r\n\t\t<h2 class=\"section-title font-weight-bold mb-5\">آخرین مقالات</h2>\r\n\t\t<div class=\"row\">\r\n");
#nullable restore
#line 9 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\LatestArticales\_LatestArticales.cshtml"
             foreach(var artical in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-md-4 mb-5\">\r\n\t\t\t\t\t<div class=\"card blog-post-card\">\r\n\t\t\t\t\t\t");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "16ef0518590348c6694295da047eb18147497db1f09f96a266848acc085da94b4465", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 394, "~/assets/images/blog/", 394, 21, true);
#nullable restore
#line 13 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\LatestArticales\_LatestArticales.cshtml"
AddHtmlAttributeValue("", 415, artical.Image, 415, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "alt", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\LatestArticales\_LatestArticales.cshtml"
AddHtmlAttributeValue("", 436, artical.Title, 436, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "title", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 13 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\LatestArticales\_LatestArticales.cshtml"
AddHtmlAttributeValue("", 459, artical.Description, 459, 20, false);

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
            WriteLiteral("\r\n\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t\t<a class=\"theme-link\" href=\"blog-post.html\">\r\n\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 17 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\LatestArticales\_LatestArticales.cshtml"
                               Write(artical.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t<p class=\"card-text\">\r\n\t\t\t\t\t\t\t\t");
#nullable restore
#line 21 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\LatestArticales\_LatestArticales.cshtml"
                           Write(artical.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t<p class=\"mb-0\"><a class=\"more-link\" href=\"blog-post.html\">ادامه مطلب</a></p>\r\n\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 28 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\LatestArticales\_LatestArticales.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Article>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
