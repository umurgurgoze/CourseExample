#pragma checksum "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71728346edd4645606593006c12c78ecac2d4d9c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Doctor_Index), @"mvc.1.0.view", @"/Views/Doctor/Index.cshtml")]
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
#line 1 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\_ViewImports.cshtml"
using ExampleProject;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\_ViewImports.cshtml"
using ExampleProject.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71728346edd4645606593006c12c78ecac2d4d9c", @"/Views/Doctor/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c0844d313725603f708f01b70444c5c5ccf8bb82", @"/Views/_ViewImports.cshtml")]
    public class Views_Doctor_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Doctor>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table table-bordered"">
    <tr>
        <th>ID</th>
        <th>Doktor Unvanı</th>
        <th>Doktor Adı</th>
        <th>Doktor Soyadı</th>
        <th>Doktor Klinik</th>
        <th>Güncelle</th>
        <th>Sil</th>
    </tr>
");
#nullable restore
#line 18 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml"
           Write(item.DoctorId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml"
           Write(item.DoctorTitle);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml"
           Write(item.DoctorName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml"
           Write(item.DoctorSurname);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml"
           Write(item.ClinicId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 667, "\"", 703, 2);
            WriteAttributeValue("", 674, "/Doctor/Update/", 674, 15, true);
#nullable restore
#line 26 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 689, item.DoctorId, 689, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Güncelle</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 766, "\"", 802, 2);
            WriteAttributeValue("", 773, "/Doctor/Delete/", 773, 15, true);
#nullable restore
#line 27 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml"
WriteAttributeValue("", 788, item.DoctorId, 788, 14, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n\r\n        </tr>\r\n");
#nullable restore
#line 30 "C:\Users\STUDENT2\Desktop\Ek Çalışma\ExampleProject\ExampleProject\Views\Doctor\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<br />\r\n<a href=\"/Doctor/Add/\" class=\"btn btn-success\">Ekle</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Doctor>> Html { get; private set; }
    }
}
#pragma warning restore 1591
