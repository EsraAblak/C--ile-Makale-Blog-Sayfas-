#pragma checksum "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\Shared\Components\ArticleCategory\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6d3faa08746086ef631341521e39971b3c741ec9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Shared_Components_ArticleCategory_Default), @"mvc.1.0.view", @"/Areas/Member/Views/Shared/Components/ArticleCategory/Default.cshtml")]
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
#line 1 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Web.Areas.Member.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Web.Areas.Member.Models.VMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Model.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\_ViewImports.cshtml"
using BlogProject.Web.Areas.Member.Models.ViewEntity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6d3faa08746086ef631341521e39971b3c741ec9", @"/Areas/Member/Views/Shared/Components/ArticleCategory/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3d8951a1f708021447e0c8b621d2f783e82497b7", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Shared_Components_ArticleCategory_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ArticleCategoryVM>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<div class=\"row\">\r\n");
#nullable restore
#line 5 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\Shared\Components\ArticleCategory\Default.cshtml"
     for (int i = 0; i < Model.Count; i++)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-4\" style=\"margin:20px\">\r\n            <div class=\"card\" style=\"width:150px;\">\r\n                <div class=\"card-body\">\r\n                    ");
#nullable restore
#line 10 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\Shared\Components\ArticleCategory\Default.cshtml"
               Write(Html.CheckBoxFor(model=>model[i].IsSelected));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    <label>");
#nullable restore
#line 11 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\Shared\Components\ArticleCategory\Default.cshtml"
                      Write(Model[i].CategoryName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    ");
#nullable restore
#line 12 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\Shared\Components\ArticleCategory\Default.cshtml"
               Write(Html.HiddenFor(model=>model[i].CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    ");
#nullable restore
#line 13 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\Shared\Components\ArticleCategory\Default.cshtml"
               Write(Html.HiddenFor(model=>model[i].CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 18 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Areas\Member\Views\Shared\Components\ArticleCategory\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ArticleCategoryVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
