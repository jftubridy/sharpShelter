#pragma checksum "/Users/Guest/Desktop/sharp-shelter/Shelter.Solution/Shelter/Views/Animal/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a9bb6422d4431a3cfab83e1ee570ef51ef7e3812"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Animal_Index), @"mvc.1.0.view", @"/Views/Animal/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Animal/Index.cshtml", typeof(AspNetCore.Views_Animal_Index))]
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
#line 5 "/Users/Guest/Desktop/sharp-shelter/Shelter.Solution/Shelter/Views/Animal/Index.cshtml"
using Shelter.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9bb6422d4431a3cfab83e1ee570ef51ef7e3812", @"/Views/Animal/Index.cshtml")]
    public class Views_Animal_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Shelter.Models.Animal>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "/Users/Guest/Desktop/sharp-shelter/Shelter.Solution/Shelter/Views/Animal/Index.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
            BeginContext(27, 1, true);
            WriteLiteral("\n");
            EndContext();
            BeginContext(87, 24, true);
            WriteLiteral("\n<h1>Animals</h1>\n\n<ul>\n");
            EndContext();
#line 11 "/Users/Guest/Desktop/sharp-shelter/Shelter.Solution/Shelter/Views/Animal/Index.cshtml"
   foreach(Animal animal in Model)
  {

#line default
#line hidden
            BeginContext(150, 10, true);
            WriteLiteral("      <li>");
            EndContext();
            BeginContext(161, 74, false);
#line 13 "/Users/Guest/Desktop/sharp-shelter/Shelter.Solution/Shelter/Views/Animal/Index.cshtml"
     Write(Html.ActionLink($"{animal.Name}", "Details", new { id = animal.AnimalId }));

#line default
#line hidden
            EndContext();
            BeginContext(235, 6, true);
            WriteLiteral("</li>\n");
            EndContext();
#line 14 "/Users/Guest/Desktop/sharp-shelter/Shelter.Solution/Shelter/Views/Animal/Index.cshtml"
  }

#line default
#line hidden
            BeginContext(245, 10, true);
            WriteLiteral("</ul>\n\n<p>");
            EndContext();
            BeginContext(256, 43, false);
#line 17 "/Users/Guest/Desktop/sharp-shelter/Shelter.Solution/Shelter/Views/Animal/Index.cshtml"
Write(Html.ActionLink("Add new Animal", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(299, 5, true);
            WriteLiteral("</p>\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Shelter.Models.Animal>> Html { get; private set; }
    }
}
#pragma warning restore 1591
