#pragma checksum "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e456e564bb14303700c748449563486a2f45c140"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Category_Listele), @"mvc.1.0.view", @"/Views/Category/Listele.cshtml")]
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
#line 1 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
using _100DerseCore.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
using X.PagedList;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
using X.PagedList.Mvc.Core;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e456e564bb14303700c748449563486a2f45c140", @"/Views/Category/Listele.cshtml")]
    public class Views_Category_Listele : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IPagedList<Category>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
  
    ViewData["Title"] = "Listele";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Kategori Listesi</h1>
<a href=""/Category/CategoryEkle/"" class=""btn btn-success"">Yeni Kategori Ekle</a>
<br />
<br />
<table class=""table table-bordered"">
    <thead>
        <tr>
            <th scope=""col"">Ad</th>
            <th scope=""col"">A????klama</th>
            <th scope=""col"">Durum</th>
            <th scope=""col"">Sil</th>
            <th scope=""col"">G??ncelle</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 26 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
         foreach (var x in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 29 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
               Write(x.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 30 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
               Write(x.Desc);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td><b>");
#nullable restore
#line 31 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
                   Write(x.CategoryStatus ? "Aktif":"Pasif");

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 856, "\"", 898, 2);
            WriteAttributeValue("", 863, "/Category/CategorySil/", 863, 22, true);
#nullable restore
#line 32 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
WriteAttributeValue("", 885, x.CategoryId, 885, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\" onclick=\"return confirm(\'Silmek istedi??inizden emin misiniz?\');\">Sil</a></td>\r\n                <td><a");
            BeginWriteAttribute("href", " href=\"", 1024, "\"", 1068, 2);
            WriteAttributeValue("", 1031, "/Category/CategoryGetir/", 1031, 24, true);
#nullable restore
#line 33 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
WriteAttributeValue("", 1055, x.CategoryId, 1055, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">G??ncelle</a></td>\r\n            </tr>\r\n");
#nullable restore
#line 35 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
#nullable restore
#line 38 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Category\Listele.cshtml"
Write(Html.PagedListPager((IPagedList)Model,page=>Url.Action("Listele",new { page })));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IPagedList<Category>> Html { get; private set; }
    }
}
#pragma warning restore 1591
