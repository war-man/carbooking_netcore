#pragma checksum "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Route\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "493f622571a193b22af24cc27179c2dea6c1882e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Route_Index), @"mvc.1.0.view", @"/Views/Admin/Route/Index.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"493f622571a193b22af24cc27179c2dea6c1882e", @"/Views/Admin/Route/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cedbd1f6285209d22a8b3f0c52fa3e91d9eb4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Route_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Route>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Route\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Route";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-right mb-2"">
         <a href=""/admin/route/create"" class=""btn btn-primary btn-sm"">
             Thêm lộ trình
         </a>
</div>
<table id=""dtBasicExample"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
  <thead>
    <tr>
      <th class=""th-sm"" >#ID
      </th>
      <th class=""th-sm"">Điểm xuất phát
      </th>
      <th class=""th-sm"">Điểm đến
      </th>
      <th class=""th-sm"">Khoảng cách (km)
      </th>
      <th class=""th-sm"">Thời gian đi
      </th>
      <th class=""th-sm "">Thời gian đến
      </th>
      <th class=""th-sm text-center"">Thời gian tạo
      </th>
    </tr>
  </thead>
  <tbody>   
");
#nullable restore
#line 31 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Route\Index.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 34 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Route\Index.cshtml"
           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 35 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Route\Index.cshtml"
           Write(item.StartPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 36 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Route\Index.cshtml"
           Write(item.EndPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 37 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Route\Index.cshtml"
           Write(item.Range);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 38 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Route\Index.cshtml"
           Write(item.TimeStart);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 39 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Route\Index.cshtml"
           Write(item.TimeEnd);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 40 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Route\Index.cshtml"
           Write(item.CreatedAt);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 42 "C:\Users\Administrator\Desktop\C#\CarBooking-1\Views\Admin\Route\Index.cshtml"
          
      }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </tbody>\r\n</table>\r\n");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css\">\r\n");
            }
            );
            DefineSection("Script", async() => {
                WriteLiteral(@"
    <script src=""https://cdn.datatables.net/1.10.21/js/jquery.dataTables.min.js""></script>
        <script>
        $(document).ready(function () {
            $('#dtBasicExample').DataTable( 
               {  
                 ""order"": [[ 0, ""desc"" ]]
               },
            );
            $('.dataTables_length').addClass('bs-select');
        });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Route>> Html { get; private set; }
    }
}
#pragma warning restore 1591
