#pragma checksum "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\HomePage.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6ca09bae10ed2dfb4c5808cbef75b56d92724eda"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Post_HomePage), @"mvc.1.0.view", @"/Views/Post/HomePage.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Post/HomePage.cshtml", typeof(AspNetCore.Views_Post_HomePage))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6ca09bae10ed2dfb4c5808cbef75b56d92724eda", @"/Views/Post/HomePage.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ca22d10c22b957b8ce289294b0dfba9746451aa", @"/Views/_ViewImports.cshtml")]
    public class Views_Post_HomePage : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DashboardVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 88, true);
            WriteLiteral(" <h1>Chefs | <a href=\"dishes\">Dishes</a></h1>\r\n\r\n<p>Check out our roster of Chefs!</p>\r\n");
            EndContext();
            BeginContext(108, 225, true);
            WriteLiteral("<a href=\"addChef\">Add a Chef</a>\r\n<table class=\"table table-hover\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Age</th>\r\n            <th># of Dishes</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 15 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\HomePage.cshtml"
         foreach (var user in Model.AllPosts)
        {

#line default
#line hidden
            BeginContext(391, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(430, 15, false);
#line 18 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\HomePage.cshtml"
               Write(user.Chef.Fname);

#line default
#line hidden
            EndContext();
            BeginContext(445, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(473, 9, false);
#line 19 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\HomePage.cshtml"
               Write(user.Dish);

#line default
#line hidden
            EndContext();
            BeginContext(482, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 21 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\HomePage.cshtml"
        }

#line default
#line hidden
            BeginContext(519, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 23 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\HomePage.cshtml"
         foreach (var user in ViewBag.AllChefs)
        {

#line default
#line hidden
            BeginContext(581, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(620, 10, false);
#line 26 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\HomePage.cshtml"
               Write(user.Fname);

#line default
#line hidden
            EndContext();
            BeginContext(630, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(658, 10, false);
#line 27 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\HomePage.cshtml"
               Write(user.Fname);

#line default
#line hidden
            EndContext();
            BeginContext(668, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(696, 19, false);
#line 28 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\HomePage.cshtml"
               Write(user.Dishlist.Count);

#line default
#line hidden
            EndContext();
            BeginContext(715, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 30 "c:\Users\Adam\Desktop\dotnet\loginPost\Views\Post\HomePage.cshtml"
        }

#line default
#line hidden
            BeginContext(752, 22, true);
            WriteLiteral("    </tbody>\r\n</table>");
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
