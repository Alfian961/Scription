#pragma checksum "C:\Users\18033398\Desktop\Scription TS\C286 Advanced .NET\VS\Code\C286ProjectsAY20S2Final\RPAuto\Views\Shared\_TransPart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71678cf7d3eaa3042e8a33ddf07ba0e9a044e58f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TransPart), @"mvc.1.0.view", @"/Views/Shared/_TransPart.cshtml")]
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
#line 1 "C:\Users\18033398\Desktop\Scription TS\C286 Advanced .NET\VS\Code\C286ProjectsAY20S2Final\RPAuto\Views\_ViewImports.cshtml"
using RPAuto.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71678cf7d3eaa3042e8a33ddf07ba0e9a044e58f", @"/Views/Shared/_TransPart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b523b8a6793b0726eb2cb264074d1316674de0ec", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TransPart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<InvTransaction>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<table class=\"table\">\r\n    <tr>\r\n        <th>Id</th>\r\n        <th>Transaction Date111</th>\r\n        <th>Transaction Type</th>\r\n        <th>PartNumber</th>\r\n        <th>Qty</th>\r\n        <th>Document No</th>\r\n    </tr>\r\n");
#nullable restore
#line 14 "C:\Users\18033398\Desktop\Scription TS\C286 Advanced .NET\VS\Code\C286ProjectsAY20S2Final\RPAuto\Views\Shared\_TransPart.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 18 "C:\Users\18033398\Desktop\Scription TS\C286 Advanced .NET\VS\Code\C286ProjectsAY20S2Final\RPAuto\Views\Shared\_TransPart.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 21 "C:\Users\18033398\Desktop\Scription TS\C286 Advanced .NET\VS\Code\C286ProjectsAY20S2Final\RPAuto\Views\Shared\_TransPart.cshtml"
           Write(item.TransactionDate.ToString("MM-dd-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 24 "C:\Users\18033398\Desktop\Scription TS\C286 Advanced .NET\VS\Code\C286ProjectsAY20S2Final\RPAuto\Views\Shared\_TransPart.cshtml"
           Write(item.TransactionType);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 27 "C:\Users\18033398\Desktop\Scription TS\C286 Advanced .NET\VS\Code\C286ProjectsAY20S2Final\RPAuto\Views\Shared\_TransPart.cshtml"
           Write(item.PartNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 30 "C:\Users\18033398\Desktop\Scription TS\C286 Advanced .NET\VS\Code\C286ProjectsAY20S2Final\RPAuto\Views\Shared\_TransPart.cshtml"
           Write(item.Qty);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 33 "C:\Users\18033398\Desktop\Scription TS\C286 Advanced .NET\VS\Code\C286ProjectsAY20S2Final\RPAuto\Views\Shared\_TransPart.cshtml"
           Write(item.DocNo);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 36 "C:\Users\18033398\Desktop\Scription TS\C286 Advanced .NET\VS\Code\C286ProjectsAY20S2Final\RPAuto\Views\Shared\_TransPart.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<InvTransaction>> Html { get; private set; }
    }
}
#pragma warning restore 1591