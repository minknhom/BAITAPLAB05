#pragma checksum "D:\Nam 3\frame\DeThiCanHo-main\CanHo\Views\NhanVien\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "56793ab47e784bcb287c28d53c042e55ebd86d77"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_NhanVien_Edit), @"mvc.1.0.view", @"/Views/NhanVien/Edit.cshtml")]
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
#line 1 "D:\Nam 3\frame\DeThiCanHo-main\CanHo\Views\_ViewImports.cshtml"
using CanHo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Nam 3\frame\DeThiCanHo-main\CanHo\Views\_ViewImports.cshtml"
using CanHo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"56793ab47e784bcb287c28d53c042e55ebd86d77", @"/Views/NhanVien/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1d86ac4a13dd8bf8a598dcf471d449c46a09cba", @"/Views/_ViewImports.cshtml")]
    public class Views_NhanVien_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CanHo.Models.NV_BT>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "D:\Nam 3\frame\DeThiCanHo-main\CanHo\Views\NhanVien\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    var nv = ViewData["NV_BT"] as NV_BT;
    Layout = "/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n");
#nullable restore
#line 10 "D:\Nam 3\frame\DeThiCanHo-main\CanHo\Views\NhanVien\Edit.cshtml"
 using (Html.BeginForm("Edit", "NhanVien", new { style = "border:1px solid red; " }))
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div style=\"display: none\">\n        <label for=\"maNV\">mã nhân viên: </label>\n        <input type=\"text\" id=\"maNV\" name=\"maNV\"");
            BeginWriteAttribute("value", " value=\"", 377, "\"", 393, 1);
#nullable restore
#line 14 "D:\Nam 3\frame\DeThiCanHo-main\CanHo\Views\NhanVien\Edit.cshtml"
WriteAttributeValue("", 385, nv.MaNV, 385, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        </div>\n        <br>\n        <label for=\"maTB\">mã thiết bị: </label>\n        <input type=\"text\" id=\"maTB\" name=\"maTB\"");
            BeginWriteAttribute("value", " value=\"", 522, "\"", 538, 1);
#nullable restore
#line 18 "D:\Nam 3\frame\DeThiCanHo-main\CanHo\Views\NhanVien\Edit.cshtml"
WriteAttributeValue("", 530, nv.MaTB, 530, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled=\"disabled\" />\n        <br>\n        <label for=\"maCH\">mã căn hộ: </label>\n        <input type=\"text\" id=\"maCH\" name=\"maCH\"");
            BeginWriteAttribute("value", " value=\"", 670, "\"", 686, 1);
#nullable restore
#line 21 "D:\Nam 3\frame\DeThiCanHo-main\CanHo\Views\NhanVien\Edit.cshtml"
WriteAttributeValue("", 678, nv.MaCH, 678, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled=\"disabled\"/>\n        <br>\n        <label for=\"lanThu\">lần thứ: </label>\n        <input type=\"text\" id=\"lanThu\" name=\"lanThu\"");
            BeginWriteAttribute("value", " value=\"", 821, "\"", 839, 1);
#nullable restore
#line 24 "D:\Nam 3\frame\DeThiCanHo-main\CanHo\Views\NhanVien\Edit.cshtml"
WriteAttributeValue("", 829, nv.LanThu, 829, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" disabled=\"disabled\"/>\n        <br>\n        <label for=\"ngBT\">Ngày bảo trì: </label>\n        <input type=\"text\" id=\"ngBT\" name=\"ngBT\"");
            BeginWriteAttribute("value", " value=\"", 973, "\"", 989, 1);
#nullable restore
#line 27 "D:\Nam 3\frame\DeThiCanHo-main\CanHo\Views\NhanVien\Edit.cshtml"
WriteAttributeValue("", 981, nv.NgBT, 981, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\n        <br>\n        <input type=\"submit\" value=\"Cập nhật\">\n");
#nullable restore
#line 30 "D:\Nam 3\frame\DeThiCanHo-main\CanHo\Views\NhanVien\Edit.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CanHo.Models.NV_BT> Html { get; private set; }
    }
}
#pragma warning restore 1591
