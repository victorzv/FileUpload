#pragma checksum "D:\Projects\C#\Zheka\WebApplicationUploadV2\WebApplicationUploadV2\Views\Home\TableRow.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36683fa818b90798d42755438fa57f781e8d0b3d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_TableRow), @"mvc.1.0.view", @"/Views/Home/TableRow.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/TableRow.cshtml", typeof(AspNetCore.Views_Home_TableRow))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36683fa818b90798d42755438fa57f781e8d0b3d", @"/Views/Home/TableRow.cshtml")]
    public class Views_Home_TableRow : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApplicationUploadV2.Models.FileDownload>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 5, true);
            WriteLiteral("\r\n<tr");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 56, "\"", 70, 1);
#line 3 "D:\Projects\C#\Zheka\WebApplicationUploadV2\WebApplicationUploadV2\Views\Home\TableRow.cshtml"
WriteAttributeValue("", 61, Model.Id, 61, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(71, 47, true);
            WriteLiteral(">\r\n    <td><input type=\"checkbox\" class=\"check\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 118, "\"", 132, 1);
#line 4 "D:\Projects\C#\Zheka\WebApplicationUploadV2\WebApplicationUploadV2\Views\Home\TableRow.cshtml"
WriteAttributeValue("", 123, Model.Id, 123, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(133, 18, true);
            WriteLiteral(" /></td>\r\n    <td>");
            EndContext();
            BeginContext(152, 14, false);
#line 5 "D:\Projects\C#\Zheka\WebApplicationUploadV2\WebApplicationUploadV2\Views\Home\TableRow.cshtml"
   Write(Model.Filename);

#line default
#line hidden
            EndContext();
            BeginContext(166, 52, true);
            WriteLiteral("</td>\r\n    <td><input type=\"button\" value=\"Download\"");
            EndContext();
            BeginWriteAttribute("downloadId", " downloadId=\"", 218, "\"", 240, 1);
#line 6 "D:\Projects\C#\Zheka\WebApplicationUploadV2\WebApplicationUploadV2\Views\Home\TableRow.cshtml"
WriteAttributeValue("", 231, Model.Id, 231, 9, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(241, 37, true);
            WriteLiteral(" class=\"dowloadButton\" /></td>\r\n</tr>");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApplicationUploadV2.Models.FileDownload> Html { get; private set; }
    }
}
#pragma warning restore 1591
