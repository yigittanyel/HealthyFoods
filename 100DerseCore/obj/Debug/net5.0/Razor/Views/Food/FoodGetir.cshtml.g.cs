#pragma checksum "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Food\FoodGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37060804e7ff8e6c88aaacead74791e53f78d6ec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_FoodGetir), @"mvc.1.0.view", @"/Views/Food/FoodGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37060804e7ff8e6c88aaacead74791e53f78d6ec", @"/Views/Food/FoodGetir.cshtml")]
    public class Views_Food_FoodGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<_100DerseCore.Models.Food>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Food\FoodGetir.cshtml"
  
    ViewData["Title"] = "FoodGetir";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Yiyecek Bilgileri</h2>\r\n");
#nullable restore
#line 9 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Food\FoodGetir.cshtml"
 using (Html.BeginForm("FoodGuncelle", "Food", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"padding:10px;\">\r\n    ");
#nullable restore
#line 12 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Food\FoodGetir.cshtml"
Write(Html.HiddenFor(x => x.FoodId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div>\r\n        <label>Adı: </label><br />\r\n        ");
#nullable restore
#line 15 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Food\FoodGetir.cshtml"
   Write(Html.TextAreaFor(q => q.FName, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Açıklama: </label><br />\r\n        ");
#nullable restore
#line 19 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Food\FoodGetir.cshtml"
   Write(Html.TextAreaFor(q => q.FoodDesc, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Image: </label><br />\r\n        ");
#nullable restore
#line 23 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Food\FoodGetir.cshtml"
   Write(Html.TextAreaFor(q => q.ImageUrl, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Price: </label><br />\r\n        ");
#nullable restore
#line 27 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Food\FoodGetir.cshtml"
   Write(Html.TextAreaFor(q => q.Price, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Stock: </label><br />\r\n        ");
#nullable restore
#line 31 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Food\FoodGetir.cshtml"
   Write(Html.TextAreaFor(q => q.Stock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div>\r\n        <label>Kategorisi: </label><br />\r\n        ");
#nullable restore
#line 35 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Food\FoodGetir.cshtml"
   Write(Html.DropDownListFor(q => q.CategoryId, (List<SelectListItem>)ViewBag.dr, "Lütfen seçiniz: ", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n    <div style=\"margin-top:15px;\">\r\n        <button class=\"btn btn-info\">Güncelle</button>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 41 "C:\Users\msi\source\repos\100DerseCore\100DerseCore\Views\Food\FoodGetir.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<_100DerseCore.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591
