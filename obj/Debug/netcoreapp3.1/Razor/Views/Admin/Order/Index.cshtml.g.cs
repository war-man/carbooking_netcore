#pragma checksum "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Order\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2e9292203cfcf160762c3a5368ae162fc6d3aaa"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Order_Index), @"mvc.1.0.view", @"/Views/Admin/Order/Index.cshtml")]
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
#line 1 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using CarBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2e9292203cfcf160762c3a5368ae162fc6d3aaa", @"/Views/Admin/Order/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cedbd1f6285209d22a8b3f0c52fa3e91d9eb4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Order_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<OrderViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Order\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Order";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<table id=""dtBasicExample"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
  <thead>
    <tr>
      <th class=""th-sm text-center"" >#ID
      </th>
      <th class=""th-sm"">Lộ Trình
      </th>
      <th class=""th-sm"">Xe
      </th>
      <th class=""th-sm"">Tổng tiền
      </th>
      <th class=""th-sm text-center"">Thời gian 
      </th>
    </tr>
  </thead>
  <tbody>   
");
#nullable restore
#line 24 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Order\Index.cshtml"
     foreach (var item in Model )
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("      <tr>\r\n          <td>\r\n              ");
#nullable restore
#line 28 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Order\Index.cshtml"
         Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </td>\r\n          <td>\r\n              ");
#nullable restore
#line 31 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Order\Index.cshtml"
         Write(item.Route.StartPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 31 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Order\Index.cshtml"
                                  Write(item.Route.EndPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </td>\r\n          <td>\r\n              ");
#nullable restore
#line 34 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Order\Index.cshtml"
         Write(item.Car.CarCode);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </td>\r\n          <td>\r\n              ");
#nullable restore
#line 37 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Order\Index.cshtml"
         Write(item.Amount.ToString("N2"));

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ \r\n          </td>\r\n          <td>\r\n              ");
#nullable restore
#line 40 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Order\Index.cshtml"
         Write(item.CreatedAt.ToString("d / M / yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n          </td>\r\n\r\n      </tr>\r\n");
#nullable restore
#line 44 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Order\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </tbody>
</table>
<div>
    <ol>
        <li>
         Một hóa đơn doanh thu được xác định sau khi kết thúc một chuyến xe -> lưu vào bảng Orders
        </li>
        <li>
         Vé xe được lưu vào bảng OrderDetails -> thuộc về 1 đơn hàng
        </li>
        <li>
            Sau khi có được đơn hàng -> Làm chức năng thống kê doanh thu theo tháng
        </li>
    </ol>
</div>
");
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
                 ""order"": [[ 0, ""desc"" ]],
                  ""columnDefs"": [
                    { ""width"": ""5%"", ""targets"": 0 },
                    { ""width"": ""15%"", ""targets"": 4 },
                  ]
               },
            );
            $('.dataTables_length').addClass('bs-select');
        });

        function detailList(id){
          window.location.href = ""ticket/list/"" + id;
        }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<OrderViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
