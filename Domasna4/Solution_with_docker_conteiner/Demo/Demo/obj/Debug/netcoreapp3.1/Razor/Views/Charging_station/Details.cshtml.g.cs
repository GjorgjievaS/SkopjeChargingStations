#pragma checksum "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "52e0d90c22744bc3e781e0d09676b5b56461a47a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Charging_station_Details), @"mvc.1.0.view", @"/Views/Charging_station/Details.cshtml")]
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
#line 1 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\_ViewImports.cshtml"
using Demo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\_ViewImports.cshtml"
using Demo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52e0d90c22744bc3e781e0d09676b5b56461a47a", @"/Views/Charging_station/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e18407c5b9dabc62761fc6cdd8f67817f22bc556", @"/Views/_ViewImports.cshtml")]
    public class Views_Charging_station_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Demo.Models.Charging_station>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Charging_station</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayFor(model => model.longitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayFor(model => model.latitude));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.amenity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayFor(model => model.amenity));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 33 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.fee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 36 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayFor(model => model.fee));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 39 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.openingHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 42 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayFor(model => model.openingHours));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 45 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.operatorCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 48 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayFor(model => model.operatorCS));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.socket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 54 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayFor(model => model.socket));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 57 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.tip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 60 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayFor(model => model.tip));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 63 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 66 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayFor(model => model.address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 69 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.municipality));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 72 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
       Write(Html.DisplayFor(model => model.municipality));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd>


    </dl>
</div>
<div id=""map""></div>
<script>

            var map = L.map('map').setView([41.9981, 21.4254], 12);
            L.tileLayer('https://api.mapbox.com/styles/v1/{id}/tiles/{z}/{x}/{y}?access_token={accessToken}', {
                attribution: 'Map data &copy; <a href=""https://www.openstreetmap.org/"">OpenStreetMap</a> contributors, <a href=""https://creativecommons.org/licenses/by-sa/2.0/"">CC-BY-SA</a>, Imagery © <a href=""https://www.mapbox.com/"">Mapbox</a>',
                maxZoom: 18,
                id: 'mapbox/streets-v11',
                tileSize: 512,
                zoomOffset: -1,
                accessToken: 'pk.eyJ1IjoiaWxpZXZhbCIsImEiOiJja2k4czcycHowOG94MnVsN2ZtbjJhZmEyIn0.a-nzOpBta_EYzu1CW8DXmg'
            }).addTo(map);

");
#nullable restore
#line 91 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
              
                var lat = Model.latitude;
                var lon = Model.longitude;
                

#line default
#line hidden
#nullable disable
            WriteLiteral("                var marker = L.marker([");
#nullable restore
#line 95 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
                                  Write(lat);

#line default
#line hidden
#nullable disable
            WriteLiteral(", ");
#nullable restore
#line 95 "C:\Users\Blagica\Desktop\New folder\SkopjeChargingStations\Domasna4\Demo\Demo\Views\Charging_station\Details.cshtml"
                                        Write(lon);

#line default
#line hidden
#nullable disable
            WriteLiteral("]).addTo(map);\r\n\r\n</script>\r\n<div>\r\n\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "52e0d90c22744bc3e781e0d09676b5b56461a47a13133", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Demo.Models.Charging_station> Html { get; private set; }
    }
}
#pragma warning restore 1591