#pragma checksum "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\CategoryGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3bd960e6ded35728d5aeb5871178b4181a98358b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_CategoryGetir), @"mvc.1.0.view", @"/Views/Category/CategoryGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3bd960e6ded35728d5aeb5871178b4181a98358b", @"/Views/Category/CategoryGetir.cshtml")]
    public class Views_Category_CategoryGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_100DerseCore.Models.Category>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\CategoryGetir.cshtml"
  
    ViewData["Title"] = "CategoryGetir";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h2>Kategori Bilgileri</h2>\r\n");
#nullable restore
#line 9 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\CategoryGetir.cshtml"
 using (Html.BeginForm("CategoryGuncelle", "Category", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"padding:10px;\">\r\n    ");
#nullable restore
#line 12 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\CategoryGetir.cshtml"
Write(Html.HiddenFor(x => x.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        <label>Ad: </label><br />\r\n        ");
#nullable restore
#line 15 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\CategoryGetir.cshtml"
   Write(Html.TextAreaFor(q => q.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>A????klama: </label><br />\r\n        ");
#nullable restore
#line 19 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\CategoryGetir.cshtml"
   Write(Html.TextAreaFor(q => q.Desc, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <!--<div>\r\n        <label>Durum: </label><br />-->\r\n");
            WriteLiteral("        <!--");
#nullable restore
#line 24 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\CategoryGetir.cshtml"
       Write(Html.TextAreaFor(q => q.CategoryStatus, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>-->\r\n    <div style=\"margin-top:15px;\">\r\n        <button class=\"btn btn-info\">G??ncelle</button>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 30 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\CategoryGetir.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_100DerseCore.Models.Category> Html { get; private set; }
    }
}
#pragma warning restore 1591
