#pragma checksum "C:\Users\USER\source\repos\ThriftShop\ThriftShop\Views\Category\AddCategory.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "04b2e6a27715241f6bb711871963eb204090642e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_AddCategory), @"mvc.1.0.view", @"/Views/Category/AddCategory.cshtml")]
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
#line 1 "C:\Users\USER\source\repos\ThriftShop\ThriftShop\Views\_ViewImports.cshtml"
using Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\USER\source\repos\ThriftShop\ThriftShop\Views\_ViewImports.cshtml"
using ThriftShop.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"04b2e6a27715241f6bb711871963eb204090642e", @"/Views/Category/AddCategory.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1f05e02f3836707edd15f6b325c43c9e04f9ac92", @"/Views/_ViewImports.cshtml")]
    public class Views_Category_AddCategory : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\USER\source\repos\ThriftShop\ThriftShop\Views\Category\AddCategory.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <table cellpadding=\"0\" cellspacing=\"0\">\r\n        <tr>\r\n            <th colspan=\"2\" align=\"center\">Category Description</th>\r\n        </tr>\r\n        <tr>\r\n            <td>Description: </td>\r\n            <td>\r\n                ");
#nullable restore
#line 13 "C:\Users\USER\source\repos\ThriftShop\ThriftShop\Views\Category\AddCategory.cshtml"
           Write(Html.TextBoxFor(m => m.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("            </td>\r\n        </tr>\r\n        <tr>\r\n            <td></td>\r\n            <td><input type=\"submit\" value=\"Submit\" /></td>\r\n        </tr>\r\n    </table>\r\n");
#nullable restore
#line 22 "C:\Users\USER\source\repos\ThriftShop\ThriftShop\Views\Category\AddCategory.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
