#pragma checksum "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "402260d3966f6859ce04d8e860d3f3ca4c965263"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Create), @"mvc.1.0.view", @"/Views/Books/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"402260d3966f6859ce04d8e860d3f3ca4c965263", @"/Views/Books/Create.cshtml")]
    public class Views_Books_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h4>Add a new task</h4>\r\n\r\n");
#nullable restore
#line 9 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
 using (Html.BeginForm())
{
  

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
Write(Html.LabelFor(model => model.Title));

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
Write(Html.TextBoxFor(model => model.Title));

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
Write(Html.LabelFor(model => model.Author));

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
Write(Html.TextBoxFor(model => model.Author));

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
Write(Html.LabelFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
Write(Html.TextBoxFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
Write(Html.Label("Select catalog"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
Write(Html.DropDownList("CatalogId"));

#line default
#line hidden
#nullable disable
            WriteLiteral("  <input type=\"submit\" value=\"Add new book\" class=\"btn btn-success\" />\r\n");
#nullable restore
#line 24 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<p>");
#nullable restore
#line 25 "C:\Users\ultra\desktop\Library\Views\Books\Create.cshtml"
Write(Html.ActionLink("Back To Books", "Index"));

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Library.Models.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
