#pragma checksum "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\Shared\Components\Comments\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "08aba790174a3db418458fc7f3062b4f04d185d7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_Comments_Default), @"mvc.1.0.view", @"/Views/Shared/Components/Comments/Default.cshtml")]
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
#line 1 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\_ViewImports.cshtml"
using BlogProject.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\_ViewImports.cshtml"
using BlogProject.Web.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\_ViewImports.cshtml"
using BlogProject.Web.Areas.Member.Models.DTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\_ViewImports.cshtml"
using BlogProject.Web.Areas.Member.Models.VMs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\_ViewImports.cshtml"
using BlogProject.Web.Areas.Member.Models.ViewEntity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\_ViewImports.cshtml"
using BlogProject.Model.Entities.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\_ViewImports.cshtml"
using BlogProject.Web.Models.VMs;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08aba790174a3db418458fc7f3062b4f04d185d7", @"/Views/Shared/Components/Comments/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2c701d57161ee853ecaf3c6eb848bb235d3bea5", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Shared_Components_Comments_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<UserCommentVM>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\Shared\Components\Comments\Default.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>");
#nullable restore
#line 5 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\Shared\Components\Comments\Default.cshtml"
  Write(item.UserId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n    <p>");
#nullable restore
#line 6 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\Shared\Components\Comments\Default.cshtml"
  Write(item.Text);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 7 "C:\Users\ESRA  ABLAK\Desktop\BlogProjectEsraOrji\BlogProject.Web\Views\Shared\Components\Comments\Default.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<UserCommentVM>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
