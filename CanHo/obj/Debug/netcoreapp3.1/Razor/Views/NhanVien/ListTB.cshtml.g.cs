#pragma checksum "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "368dda49e10ffeb1608c4679a66d60fbe878bb19"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_ListTB), @"mvc.1.0.view", @"/Views/NhanVien/ListTB.cshtml")]
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
#line 1 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\_ViewImports.cshtml"
using CanHo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\_ViewImports.cshtml"
using CanHo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"368dda49e10ffeb1608c4679a66d60fbe878bb19", @"/Views/NhanVien/ListTB.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1d86ac4a13dd8bf8a598dcf471d449c46a09cba", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_ListTB : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CanHo.Models.NV_BT>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
  
    ViewData["NV_TB"] = "ListTB";
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n");
            WriteLiteral(@"
<table class=""table"">
    <thead>
        <tr style=""text-align: center;"">
            <th>
                Mã thiết bị
            </th>
            <th>
                Mã căn hộ
            </th>
            <th>
                Lần thứ
            </th>
            <th>
                Ngày bảo trì
            </th>
            <th>
                Chức năng
            </th>
            <th></th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 31 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\n            <td>\n                ");
#nullable restore
#line 35 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
           Write(item.MaTB);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 38 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
           Write(item.MaCH);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 41 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
           Write(item.LanThu);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                ");
#nullable restore
#line 44 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
           Write(item.NgBT);

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </td>\n            <td>\n                <a");
            BeginWriteAttribute("href", " href=\"", 930, "\"", 1012, 8);
            WriteAttributeValue("", 937, "/NhanVien/Edit?id=", 937, 18, true);
#nullable restore
#line 47 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
WriteAttributeValue("", 955, item.MaNV, 955, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 965, "&id1=", 965, 5, true);
#nullable restore
#line 47 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
WriteAttributeValue("", 970, item.MaTB, 970, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 980, "&id2=", 980, 5, true);
#nullable restore
#line 47 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
WriteAttributeValue("", 985, item.MaCH, 985, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 995, "&id3=", 995, 5, true);
#nullable restore
#line 47 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
WriteAttributeValue("", 1000, item.LanThu, 1000, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">View</a> |\n                <a");
            BeginWriteAttribute("href", " href=\"", 1043, "\"", 1127, 8);
            WriteAttributeValue("", 1050, "/NhanVien/Delete?id=", 1050, 20, true);
#nullable restore
#line 48 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
WriteAttributeValue("", 1070, item.MaNV, 1070, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1080, "&id1=", 1080, 5, true);
#nullable restore
#line 48 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
WriteAttributeValue("", 1085, item.MaTB, 1085, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1095, "&id2=", 1095, 5, true);
#nullable restore
#line 48 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
WriteAttributeValue("", 1100, item.MaCH, 1100, 10, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1110, "&id3=", 1110, 5, true);
#nullable restore
#line 48 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
WriteAttributeValue("", 1115, item.LanThu, 1115, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\n            </td>\n        </tr>\n");
#nullable restore
#line 51 "D:\Nam 3\frame\th\TH5\buoi5\CanHo\Views\NhanVien\ListTB.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\n</table>\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CanHo.Models.NV_BT>> Html { get; private set; }
    }
}
#pragma warning restore 1591
