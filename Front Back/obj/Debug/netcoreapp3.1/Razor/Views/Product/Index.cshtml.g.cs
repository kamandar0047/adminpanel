#pragma checksum "C:\Users\Ideapad\OneDrive\Documents\Front Back\Front Back\Views\Product\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1893827f504b6e41c52b903af4dfa74a6c63ae1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
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
#line 1 "C:\Users\Ideapad\OneDrive\Documents\Front Back\Front Back\Views\_ViewImports.cshtml"
using Front_Back.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ideapad\OneDrive\Documents\Front Back\Front Back\Views\_ViewImports.cshtml"
using Front_Back.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1893827f504b6e41c52b903af4dfa74a6c63ae1", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"47c68ee03f7945784b4f9eee8b7f517ebdc4e912", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Product>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Ideapad\OneDrive\Documents\Front Back\Front Back\Views\Product\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!-- PRODUCTS START -->\r\n\r\n<section id=\"products\">\r\n    <div class=\"container\">\r\n    \r\n                            \r\n        <div class=\"row parent\">\r\n            ");
#nullable restore
#line 13 "C:\Users\Ideapad\OneDrive\Documents\Front Back\Front Back\Views\Product\Index.cshtml"
       Write(await Component.InvokeAsync("Product",8));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n        </div>\r\n        <div class=\"row my-3 justify-content-center\">\r\n            <input type=\"hidden\" id=\"ProductCount\"");
            BeginWriteAttribute("value", " value=\"", 1329, "\"", 1358, 1);
#nullable restore
#line 42 "C:\Users\Ideapad\OneDrive\Documents\Front Back\Front Back\Views\Product\Index.cshtml"
WriteAttributeValue("", 1337, ViewBag.ProductCount, 1337, 21, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n            <button class=\"btn btn-primary\">LoadMore </button>        \r\n        </div>\r\n    </div>\r\n</section>\r\n\r\n<!-- PRODUCTS END -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591