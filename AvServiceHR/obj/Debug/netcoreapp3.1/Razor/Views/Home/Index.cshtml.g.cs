#pragma checksum "C:\ProgettiVari\AvServiceHR\AvServiceHR\AvServiceHR\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef6a9469ae8474ff3933def185c13fc340428475"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\ProgettiVari\AvServiceHR\AvServiceHR\AvServiceHR\Views\_ViewImports.cshtml"
using AvServiceHR;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\ProgettiVari\AvServiceHR\AvServiceHR\AvServiceHR\Views\_ViewImports.cshtml"
using AvServiceHR.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef6a9469ae8474ff3933def185c13fc340428475", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"55822110f1df0eebd62e18a093694fba06bd2a0f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Person>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 4 "C:\ProgettiVari\AvServiceHR\AvServiceHR\AvServiceHR\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">AV SERVICE HR</h1>   \r\n\r\n    <hr />\r\n    \r\n</div>\r\n\r\n<div>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 19 "C:\ProgettiVari\AvServiceHR\AvServiceHR\AvServiceHR\Views\Home\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>");
#nullable restore
#line 21 "C:\ProgettiVari\AvServiceHR\AvServiceHR\AvServiceHR\Views\Home\Index.cshtml"
        Write(item.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>     \r\n        <br />\r\n");
#nullable restore
#line 23 "C:\ProgettiVari\AvServiceHR\AvServiceHR\AvServiceHR\Views\Home\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    \r\n\r\n\r\n\r\n\r\n</div>\r\n\r\n<script>\r\n    /*Implementare uno script javascript/jquery che converta in maiuscolo tutti i lastname che iniziano con la lettere A*/\r\n</script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Person>> Html { get; private set; }
    }
}
#pragma warning restore 1591
