#pragma checksum "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b19fa15bd12286a9da264d268ede834042573cec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_Details), @"mvc.1.0.view", @"/Views/Catalogs/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b19fa15bd12286a9da264d268ede834042573cec", @"/Views/Catalogs/Details.cshtml")]
    public class Views_Catalogs_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Catalog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Catalog Details</h2>\r\n<hr />\r\n<h3>");
#nullable restore
#line 9 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
Write(Html.DisplayNameFor(model => model.Ticket));

#line default
#line hidden
#nullable disable
            WriteLiteral(": ");
#nullable restore
#line 9 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
                                            Write(Html.DisplayFor(model => model.Ticket));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n\r\n");
#nullable restore
#line 11 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This Catalog does not contain any Books</p>\r\n");
#nullable restore
#line 14 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Books in this Catalog:</h4>\r\n  <ul>\r\n");
#nullable restore
#line 19 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 21 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
   Write(join.Book.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 22 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n");
#nullable restore
#line 24 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 26 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
Write(Html.ActionLink("Back To Catalogs", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 27 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
Write(Html.ActionLink("Edit This Catalog", "Edit", new { id = Model.CatalogId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 28 "C:\Users\ultra\desktop\Library\Views\Catalogs\Details.cshtml"
Write(Html.ActionLink("Delete This Catalog", "Delete", new { id = Model.CatalogId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Catalog> Html { get; private set; }
    }
}
#pragma warning restore 1591
