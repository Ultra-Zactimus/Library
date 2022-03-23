#pragma checksum "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26d15fbf53bce77d9767cb9e4ad339392ff90a67"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Books_Details), @"mvc.1.0.view", @"/Views/Books/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26d15fbf53bce77d9767cb9e4ad339392ff90a67", @"/Views/Books/Details.cshtml")]
    public class Views_Books_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Library.Models.Book>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
  
  Layout = "_Layout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<h2>Book Details</h2>\r\n<hr />\r\n<h3>Title:</h3>\r\n<h5>");
#nullable restore
#line 10 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h3>Authored by:</h3>\r\n<h5>");
#nullable restore
#line 12 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n<h3>Published by:</h3>\r\n<h5>");
#nullable restore
#line 14 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
Write(Html.DisplayFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n\r\n");
#nullable restore
#line 16 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
 if(@Model.JoinEntities.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <p>This book has not been cataloged</p>\r\n");
#nullable restore
#line 19 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("  <h4>Catalogs the item belongs to:</h4>\r\n  <ul>\r\n");
#nullable restore
#line 24 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
   foreach(var join in Model.JoinEntities)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <li>");
#nullable restore
#line 26 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
   Write(join.Catalog.Ticket);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 27 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
     using (Html.BeginForm("DeleteCategory", "Items"))
    {
      

#line default
#line hidden
#nullable disable
#nullable restore
#line 29 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
 Write(Html.Hidden("joinId", @join.StorageId));

#line default
#line hidden
#nullable disable
            WriteLiteral("      <input type=\"submit\" value=\"Delete\"/>\r\n");
#nullable restore
#line 31 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
     
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </ul>\r\n");
#nullable restore
#line 34 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<p>");
#nullable restore
#line 36 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
Write(Html.ActionLink("Add A Catalog", "AddCatalog", new { id = Model.BookId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<p>");
#nullable restore
#line 38 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
Write(Html.ActionLink("Back To Books", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 39 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
Write(Html.ActionLink("Edit This Book", "Edit", new { id = Model.BookId }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p>");
#nullable restore
#line 40 "C:\Users\ultra\desktop\Library\Views\Books\Details.cshtml"
Write(Html.ActionLink("Delete This Book", "Delete", new { id = Model.BookId }));

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
