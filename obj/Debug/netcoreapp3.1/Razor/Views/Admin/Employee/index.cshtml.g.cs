#pragma checksum "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0e0e68806355dcca95a5032fd78b3652cc7012a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Employee_index), @"mvc.1.0.view", @"/Views/Admin/Employee/index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0e0e68806355dcca95a5032fd78b3652cc7012a5", @"/Views/Admin/Employee/index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cedbd1f6285209d22a8b3f0c52fa3e91d9eb4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Employee_index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Employee";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""text-right mb-2"">
         <a href=""/admin/employee/create"" class=""btn btn-primary btn-sm"">
             Thêm nhân viên
         </a>
</div>
<table id=""dtBasicExample"" class=""table table-striped table-bordered"" cellspacing=""0"" width=""100%"">
  <thead>
    <tr>
      <th class=""th-sm"" >#ID
      </th>
      <th class=""th-sm"">Họ tên
      </th>
      <th class=""th-sm text-center"">Ảnh đại diện
      </th>
      <th class=""th-sm text-center"">Chức vụ
      </th>
      <th class=""th-sm"">Email
      </th>
      <th class=""th-sm"">Phone
      </th>
      <th class=""th-sm"">Hành động
      </th>
    </tr>
  </thead>
  <tbody>
");
#nullable restore
#line 31 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr style=\"cursor:pointer\">\r\n      <td");
            BeginWriteAttribute("onclick", "  onclick=\"", 835, "\"", 870, 3);
            WriteAttributeValue("", 846, "typeRoomDetail(", 846, 15, true);
#nullable restore
#line 34 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
WriteAttributeValue("", 861, item.Id, 861, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 869, ")", 869, 1, true);
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 34 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
                                          Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td");
            BeginWriteAttribute("onclick", "  onclick=\"", 897, "\"", 932, 3);
            WriteAttributeValue("", 908, "typeRoomDetail(", 908, 15, true);
#nullable restore
#line 35 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
WriteAttributeValue("", 923, item.Id, 923, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 931, ")", 931, 1, true);
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 35 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
                                          Write(item.FullName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td");
            BeginWriteAttribute("onclick", "  onclick=\"", 965, "\"", 1000, 3);
            WriteAttributeValue("", 976, "typeRoomDetail(", 976, 15, true);
#nullable restore
#line 36 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
WriteAttributeValue("", 991, item.Id, 991, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 999, ")", 999, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center\"><img");
            BeginWriteAttribute("src", " src=\"", 1026, "\"", 1044, 1);
#nullable restore
#line 36 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
WriteAttributeValue("", 1032, item.Avatar, 1032, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:50px\"></td>\r\n      <td");
            BeginWriteAttribute("onclick", "  onclick=\"", 1081, "\"", 1116, 3);
            WriteAttributeValue("", 1092, "typeRoomDetail(", 1092, 15, true);
#nullable restore
#line 37 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
WriteAttributeValue("", 1107, item.Id, 1107, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1115, ")", 1115, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"text-center\">");
#nullable restore
#line 37 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
                                                              Write(@item.Position == 0 ? "Lái Xe" : "Phụ Xe");

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td");
            BeginWriteAttribute("onclick", "  onclick=\"", 1198, "\"", 1233, 3);
            WriteAttributeValue("", 1209, "typeRoomDetail(", 1209, 15, true);
#nullable restore
#line 38 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
WriteAttributeValue("", 1224, item.Id, 1224, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1232, ")", 1232, 1, true);
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 38 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
                                          Write(item.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td");
            BeginWriteAttribute("onclick", "  onclick=\"", 1263, "\"", 1298, 3);
            WriteAttributeValue("", 1274, "typeRoomDetail(", 1274, 15, true);
#nullable restore
#line 39 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
WriteAttributeValue("", 1289, item.Id, 1289, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1297, ")", 1297, 1, true);
            EndWriteAttribute();
            WriteLiteral(" >");
#nullable restore
#line 39 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
                                          Write(item.Phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n      <td  style=\"width:30px\" class=\"text-center\">\r\n        <button data-delete-id=\"");
#nullable restore
#line 41 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
                           Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"button\" class=\"btn btn-danger btn-sm m-0 btn-delete\" data-toggle=\"modal\" data-target=\"#centralModalSm\">Xóa</button>\r\n      </td>\r\n    </tr>\r\n");
#nullable restore
#line 44 "C:\Users\HUY 4\Desktop\C#\CarBooking-1\Views\Admin\Employee\index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"  </tbody>
</table>
<!-- Central Modal Small -->
<div class=""modal fade"" id=""centralModalSm"" tabindex=""-1"" role=""dialog"" aria-labelledby=""myModalLabel""
  aria-hidden=""true"">

  <!-- Change class .modal-sm to change the size of the modal -->
  <div class=""modal-dialog modal-sm"" role=""document"">


    <div class=""modal-content"">
      <div class=""modal-header"">
        <h4 class=""modal-title w-100"" id=""myModalLabel"">Delete</h4>
        <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Đóng"">
          <span aria-hidden=""true"">&times;</span>
        </button>
      </div>
      <div class=""modal-body"">
        Bạn chắc chắn xóa loại phòng này ?
      </div>
      <div class=""modal-footer"">
        <button type=""button"" class=""btn btn-primary btn-sm "" data-dismiss=""modal"">ĐÓng</button>
        <a id=""delete-item"" href=""/"" class=""btn btn-danger btn-sm"">Xóa</a>
      </div>
    </div>
  </div>
</div>
");
            DefineSection("Css", async() => {
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css\">\r\n    <style>\r\n      .show-message{\r\n        cursor: pointer;\r\n      }\r\n      .show-message:hover{\r\n         color:blue;\r\n      }\r\n    </style>\r\n");
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
        <script>
        function typeRoomDetail(id){
          window.location.href = ""/admin/employee/"" +  id; 
        }
      
        let deleteButton = document.querySelectorAll('.btn-delete');
        let deleteItem = document.querySelector('#delete-item');
        deleteButton.forEach(function(item,index){
          item.addEventListener('click', function(){
              console.log(this.dataset.deleteId);
              deleteItem.setAttribute('href','/admin/employee/delete/' +this.dataset.deleteId);
          })
        })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; }
    }
}
#pragma warning restore 1591
