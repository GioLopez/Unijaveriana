#pragma checksum "/Users/giovanni.lopez/Projects/Dotnet/Unijaveriana/Dotnet/UserManage/Views/Home/Thanks.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9121413c171683e5c186ebc9adc4b580218d42d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Thanks), @"mvc.1.0.view", @"/Views/Home/Thanks.cshtml")]
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
#line 1 "/Users/giovanni.lopez/Projects/Dotnet/Unijaveriana/Dotnet/UserManage/Views/_ViewImports.cshtml"
using UserManage;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/giovanni.lopez/Projects/Dotnet/Unijaveriana/Dotnet/UserManage/Views/_ViewImports.cshtml"
using UserManage.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9121413c171683e5c186ebc9adc4b580218d42d6", @"/Views/Home/Thanks.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ae6d548f63f576cb50f9d394219a8a6a1f4189bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Thanks : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "/Users/giovanni.lopez/Projects/Dotnet/Unijaveriana/Dotnet/UserManage/Views/Home/Thanks.cshtml"
  
    var message = TempData["Message"] as String;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/Users/giovanni.lopez/Projects/Dotnet/Unijaveriana/Dotnet/UserManage/Views/Home/Thanks.cshtml"
 if (!String.IsNullOrEmpty(message))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Gracias Carnal!</h1>\n    <p>");
#nullable restore
#line 7 "/Users/giovanni.lopez/Projects/Dotnet/Unijaveriana/Dotnet/UserManage/Views/Home/Thanks.cshtml"
  Write(message);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\n");
#nullable restore
#line 8 "/Users/giovanni.lopez/Projects/Dotnet/Unijaveriana/Dotnet/UserManage/Views/Home/Thanks.cshtml"

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
