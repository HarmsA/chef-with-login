#pragma checksum "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\dishList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0377eb0a89079f823028a3dda4a794ef282ec5c7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_dishList), @"mvc.1.0.view", @"/Views/Post/dishList.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/dishList.cshtml", typeof(AspNetCore.Views_Post_dishList))]
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
#line 1 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\_ViewImports.cshtml"
using newlogin;

#line default
#line hidden
#line 2 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\_ViewImports.cshtml"
using newlogin.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0377eb0a89079f823028a3dda4a794ef282ec5c7", @"/Views/Post/dishList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca22d10c22b957b8ce289294b0dfba9746451aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_dishList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 136, true);
            WriteLiteral(" <h1><a href=\"home\">Chefs</a> | Dishes</h1>\r\n  <a href=\"createDish\">Add a Dish</a></p>\r\n\r\n\r\n<p>Check out our Awesome food options!</p>\r\n");
            EndContext();
            BeginContext(156, 221, true);
            WriteLiteral("<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Chef</th>\r\n            <th>Tastiness</th>\r\n            <th>Calories</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 17 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\dishList.cshtml"
         foreach (var user in Model.AllPosts)
        {

#line default
#line hidden
            BeginContext(435, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(474, 9, false);
#line 20 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\dishList.cshtml"
               Write(user.Dish);

#line default
#line hidden
            EndContext();
            BeginContext(483, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(511, 15, false);
#line 21 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\dishList.cshtml"
               Write(user.Chef.Fname);

#line default
#line hidden
            EndContext();
            BeginContext(526, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(554, 10, false);
#line 22 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\dishList.cshtml"
               Write(user.Taste);

#line default
#line hidden
            EndContext();
            BeginContext(564, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(592, 13, false);
#line 23 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\dishList.cshtml"
               Write(user.Calories);

#line default
#line hidden
            EndContext();
            BeginContext(605, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\dishList.cshtml"
        }

#line default
#line hidden
            BeginContext(642, 41, true);
            WriteLiteral("        <td></td>\r\n    </tbody>\r\n</table>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DashboardVM> Html { get; private set; }
    }
}
#pragma warning restore 1591