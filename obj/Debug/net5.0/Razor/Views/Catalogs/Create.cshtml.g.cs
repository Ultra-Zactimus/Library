#pragma checksum "C:\Users\ultra\desktop\Library\Views\Catalogs\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "44e921e0a97e465343ad4ac3745221de10fe7b89"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalogs_Create), @"mvc.1.0.view", @"/Views/Catalogs/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"44e921e0a97e465343ad4ac3745221de10fe7b89", @"/Views/Catalogs/Create.cshtml")]
    public class Views_Catalogs_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Catalog>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ultra\desktop\Library\Views\Catalogs\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h4>Create A Catalog</h4>\r\n");
#nullable restore
#line 8 "C:\Users\ultra\desktop\Library\Views\Catalogs\Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\ultra\desktop\Library\Views\Catalogs\Create.cshtml"
Write(Html.LabelFor(model => model.Ticket));

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ultra\desktop\Library\Views\Catalogs\Create.cshtml"
Write(Html.TextBoxFor(model => model.Ticket));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add Catalog to Registry\" />\r\n");
#nullable restore
#line 13 "C:\Users\ultra\desktop\Library\Views\Catalogs\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 14 "C:\Users\ultra\desktop\Library\Views\Catalogs\Create.cshtml"
Write(Html.ActionLink("Back to Catalogs", "Index"));

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
