#pragma checksum "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9da90e3b0bee6d878456bc96e81c403ee302b614"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Calc_BagCalculate), @"mvc.1.0.view", @"/Views/Calc/BagCalculate.cshtml")]
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
#line 1 "C:\Users\Ksusha K\source\repos\lab1\Views\_ViewImports.cshtml"
using lab1;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ksusha K\source\repos\lab1\Views\_ViewImports.cshtml"
using lab1.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9da90e3b0bee6d878456bc96e81c403ee302b614", @"/Views/Calc/BagCalculate.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1b856ffc28bb915aac4f86c443e1a63cacffcc6", @"/Views/_ViewImports.cshtml")]
    public class Views_Calc_BagCalculate : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 2 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
   ViewData["Title"] = "PassUsingViewBag"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<h2>PassUsingViewBag</h2>\n\n<div><b>Rand Value First: ");
#nullable restore
#line 6 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
                     Write(ViewBag.data.first);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n<div><b>Rand Value Second: ");
#nullable restore
#line 7 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
                      Write(ViewBag.data.second);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b></div>\n<div>\n    <b>Add :</b>\n    <br />\n    <div> ");
#nullable restore
#line 11 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
     Write(ViewBag.data.first);

#line default
#line hidden
#nullable disable
            WriteLiteral(" + ");
#nullable restore
#line 11 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
                           Write(ViewBag.data.second);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 11 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
                                                  Write(ViewBag.data.resAdd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n   \n</div>\n<div>\n    <b>Sub :</b>\n    <br />\n    <div> ");
#nullable restore
#line 17 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
     Write(ViewBag.data.first);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 17 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
                           Write(ViewBag.data.second);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 17 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
                                                  Write(ViewBag.data.resSub);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n \n</div>\n<div>\n    <b>Mult :</b>\n    <br />\n    <div> ");
#nullable restore
#line 23 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
     Write(ViewBag.data.first);

#line default
#line hidden
#nullable disable
            WriteLiteral(" * ");
#nullable restore
#line 23 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
                           Write(ViewBag.data.second);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 23 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
                                                  Write(ViewBag.data.resMult);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n \n</div>\n<div>\n    <b>Div :</b>\n    <br />\n    <div>\n        ");
#nullable restore
#line 30 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
   Write(ViewBag.data.first);

#line default
#line hidden
#nullable disable
            WriteLiteral(" / ");
#nullable restore
#line 30 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
                         Write(ViewBag.data.second);

#line default
#line hidden
#nullable disable
            WriteLiteral(" = ");
#nullable restore
#line 30 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
                                                      if (ViewBag.data.resDiv == -1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            WriteLiteral(" error\n");
#nullable restore
#line 33 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
Write(ViewBag.data.resDiv);

#line default
#line hidden
#nullable disable
#nullable restore
#line 36 "C:\Users\Ksusha K\source\repos\lab1\Views\Calc\BagCalculate.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\n   \n</div>");
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