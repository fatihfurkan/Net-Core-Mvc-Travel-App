#pragma checksum "C:\Users\fatih\OneDrive\Masaüstü\Code\obilet\TravelApp\TravelApp\Views\Travel\Journey.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0cc6c10ad66460abf0a4217e0f312beea3a546c8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Travel_Journey), @"mvc.1.0.view", @"/Views/Travel/Journey.cshtml")]
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
#line 1 "C:\Users\fatih\OneDrive\Masaüstü\Code\obilet\TravelApp\TravelApp\Views\_ViewImports.cshtml"
using TravelApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\fatih\OneDrive\Masaüstü\Code\obilet\TravelApp\TravelApp\Views\_ViewImports.cshtml"
using TravelApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0cc6c10ad66460abf0a4217e0f312beea3a546c8", @"/Views/Travel/Journey.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"da187dedda1c7ad58e83a5ae2af086045cf73092", @"/Views/_ViewImports.cshtml")]
    public class Views_Travel_Journey : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n\r\n<div class=\"container\">\r\n\r\n");
#nullable restore
#line 7 "C:\Users\fatih\OneDrive\Masaüstü\Code\obilet\TravelApp\TravelApp\Views\Travel\Journey.cshtml"
     foreach (var item in @ViewBag.journeys)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""card bg-light mb-3"">
            <div class=""card-body"">
                <div class=""row"">
                    <div class=""col-9"">
                        <div class=""blue"">Kalkış &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;  Varış</div>
                        <div class=""card-title hour-text"">");
#nullable restore
#line 14 "C:\Users\fatih\OneDrive\Masaüstü\Code\obilet\TravelApp\TravelApp\Views\Travel\Journey.cshtml"
                                                     Write(item.Departure);

#line default
#line hidden
#nullable disable
            WriteLiteral(" &nbsp; <i class=\"fas fa-arrow-right ft12\"></i>&nbsp; ");
#nullable restore
#line 14 "C:\Users\fatih\OneDrive\Masaüstü\Code\obilet\TravelApp\TravelApp\Views\Travel\Journey.cshtml"
                                                                                                                          Write(item.Arrival);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                    </div>\r\n                    <div class=\"col-3\">\r\n                        <div class=\"price\">");
#nullable restore
#line 17 "C:\Users\fatih\OneDrive\Masaüstü\Code\obilet\TravelApp\TravelApp\Views\Travel\Journey.cshtml"
                                      Write(item.OriginalPrice);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </div>\r\n                    </div>\r\n                </div>\r\n                <div class=\"arrival-info\">");
#nullable restore
#line 20 "C:\Users\fatih\OneDrive\Masaüstü\Code\obilet\TravelApp\TravelApp\Views\Travel\Journey.cshtml"
                                     Write(item.Origin);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 20 "C:\Users\fatih\OneDrive\Masaüstü\Code\obilet\TravelApp\TravelApp\Views\Travel\Journey.cshtml"
                                                    Write(item.Destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 24 "C:\Users\fatih\OneDrive\Masaüstü\Code\obilet\TravelApp\TravelApp\Views\Travel\Journey.cshtml"

    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
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