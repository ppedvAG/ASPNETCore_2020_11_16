#pragma checksum "C:\Aktueller Kurs\ASPNETCore_2020_11_16\AspNetCore_2020_11_16\RazorPages_OverviewSample\Pages\Shared\_CarPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fee2eb1b7eab1c7e3e8c1d5efa3417da13648dd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RazorPages_OverviewSample.Pages.Shared.Pages_Shared__CarPartial), @"mvc.1.0.view", @"/Pages/Shared/_CarPartial.cshtml")]
namespace RazorPages_OverviewSample.Pages.Shared
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
#line 1 "C:\Aktueller Kurs\ASPNETCore_2020_11_16\AspNetCore_2020_11_16\RazorPages_OverviewSample\Pages\_ViewImports.cshtml"
using RazorPages_OverviewSample;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Aktueller Kurs\ASPNETCore_2020_11_16\AspNetCore_2020_11_16\RazorPages_OverviewSample\Pages\Shared\_CarPartial.cshtml"
using GoodDependencyLib.Service;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fee2eb1b7eab1c7e3e8c1d5efa3417da13648dd", @"/Pages/Shared/_CarPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"988a1cc32016671878d8dc3f3875b86c0c44dfa2", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared__CarPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<table class=\"table table-striped\">\r\n");
#nullable restore
#line 4 "C:\Aktueller Kurs\ASPNETCore_2020_11_16\AspNetCore_2020_11_16\RazorPages_OverviewSample\Pages\Shared\_CarPartial.cshtml"
     foreach (Car car in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 7 "C:\Aktueller Kurs\ASPNETCore_2020_11_16\AspNetCore_2020_11_16\RazorPages_OverviewSample\Pages\Shared\_CarPartial.cshtml"
           Write(car.Brandt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 8 "C:\Aktueller Kurs\ASPNETCore_2020_11_16\AspNetCore_2020_11_16\RazorPages_OverviewSample\Pages\Shared\_CarPartial.cshtml"
           Write(car.Model);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 9 "C:\Aktueller Kurs\ASPNETCore_2020_11_16\AspNetCore_2020_11_16\RazorPages_OverviewSample\Pages\Shared\_CarPartial.cshtml"
           Write(car.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>$");
#nullable restore
#line 10 "C:\Aktueller Kurs\ASPNETCore_2020_11_16\AspNetCore_2020_11_16\RazorPages_OverviewSample\Pages\Shared\_CarPartial.cshtml"
            Write(car.ConstructionYear);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 12 "C:\Aktueller Kurs\ASPNETCore_2020_11_16\AspNetCore_2020_11_16\RazorPages_OverviewSample\Pages\Shared\_CarPartial.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
