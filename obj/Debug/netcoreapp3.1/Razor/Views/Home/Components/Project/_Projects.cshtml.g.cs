#pragma checksum "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\Project\_Projects.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "d0a1503ef3495b63acf42f2d2685dfe67c52e83e9ec576f15d66929417e45451"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Components_Project__Projects), @"mvc.1.0.view", @"/Views/Home/Components/Project/_Projects.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"d0a1503ef3495b63acf42f2d2685dfe67c52e83e9ec576f15d66929417e45451", @"/Views/Home/Components/Project/_Projects.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA256", @"39034af3b196f7af391de589abd6f1074b2bdbb0e86a627a4dc463ed4420aa2f", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Home_Components_Project__Projects : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DevCart.Models.Project>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<section class=\"featured-section p-3 p-lg-5\">\r\n\t<div class=\"container\">\r\n\t\t<h2 class=\"section-title font-weight-bold mb-5\">خاص ترین پروژه ها</h2>\r\n\t\t<div class=\"row\">\r\n");
#nullable restore
#line 6 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\Project\_Projects.cshtml"
             foreach(var project in Model)
			{

#line default
#line hidden
#nullable disable
            WriteLiteral("\t\t\t\t<div class=\"col-md-6 mb-5\">\r\n\t\t\t\t\t<div class=\"card project-card\">\r\n\t\t\t\t\t\t<div class=\"row no-gutters\">\r\n\t\t\t\t\t\t\t<div class=\"col-lg-4 card-img-holder\">\r\n\t\t\t\t\t\t\t\t<img");
            BeginWriteAttribute("src", " src=\"", 419, "\"", 461, 2);
            WriteAttributeValue("", 425, "assets/images/project/", 425, 22, true);
#nullable restore
#line 12 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\Project\_Projects.cshtml"
WriteAttributeValue("", 447, project.Image, 447, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"card-img\"");
            BeginWriteAttribute("alt", " alt=\"", 479, "\"", 498, 1);
#nullable restore
#line 12 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\Project\_Projects.cshtml"
WriteAttributeValue("", 485, project.Name, 485, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 499, "\"", 527, 1);
#nullable restore
#line 12 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\Project\_Projects.cshtml"
WriteAttributeValue("", 507, project.Description, 507, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t<div class=\"col-lg-8\">\r\n\t\t\t\t\t\t\t\t<div class=\"card-body\">\r\n\t\t\t\t\t\t\t\t\t<h5 class=\"card-title\">\r\n\t\t\t\t\t\t\t\t\t\t<a href=\"project.html\" class=\"theme-link\">\r\n\t\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 18 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\Project\_Projects.cshtml"
                                       Write(project.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 18 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\Project\_Projects.cshtml"
                                                    Write(project.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t\t</a>\r\n\t\t\t\t\t\t\t\t\t</h5>\r\n\t\t\t\t\t\t\t\t\t<p class=\"card-text\">\r\n\t\t\t\t\t\t\t\t\t\t");
#nullable restore
#line 22 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\Project\_Projects.cshtml"
                                   Write(project.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t\t\t\t\t\t\t\t</p>\r\n\t\t\t\t\t\t\t\t\t<p class=\"card-text\">\r\n\t\t\t\t\t\t\t\t\t\t<small class=\"text-muted\">Client: ");
#nullable restore
#line 25 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\Project\_Projects.cshtml"
                                                                     Write(project.Clinet);

#line default
#line hidden
#nullable disable
            WriteLiteral("</small></p>\r\n\t\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t\t</div>\r\n\t\t\t\t\t\t</div>\r\n\t\t\t\t\t</div>\r\n\t\t\t\t</div>\r\n");
#nullable restore
#line 31 "C:\Users\sohei\OneDrive\Desktop\ایمان تقوا وعمل صالح\csharp\DevCart\DevCart\Views\Home\Components\Project\_Projects.cshtml"

			}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\t\t</div>\r\n\t</div>\r\n</section>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DevCart.Models.Project>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
