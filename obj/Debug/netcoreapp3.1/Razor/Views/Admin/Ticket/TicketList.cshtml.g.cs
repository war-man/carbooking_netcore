#pragma checksum "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "97657bf1fbc74b018abe5f7923c835d55835247a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Ticket_TicketList), @"mvc.1.0.view", @"/Views/Admin/Ticket/TicketList.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"97657bf1fbc74b018abe5f7923c835d55835247a", @"/Views/Admin/Ticket/TicketList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cedbd1f6285209d22a8b3f0c52fa3e91d9eb4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Ticket_TicketList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Ticket>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "List Ticket";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("<div class=\"row\">\r\n");
#nullable restore
#line 8 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
   foreach (var item in Model)
  {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"ticket mx-3 mb-3\">\r\n      <div class=\"ticket__content\"> \r\n");
#nullable restore
#line 12 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
         if((int)item.StatusTicket == 1){


#line default
#line hidden
#nullable disable
            WriteLiteral("        <p  class=\"status-ticket success \">\r\n          <a");
            BeginWriteAttribute("href", " href=\"", 328, "\"", 335, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 336, "\"", 344, 0);
            EndWriteAttribute();
            WriteLiteral(">Đã đặt</a>\r\n        </p>\r\n");
#nullable restore
#line 17 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"

        }
        else if( (int)item.StatusTicket == 0){

#line default
#line hidden
#nullable disable
            WriteLiteral("          <p  class=\"status-ticket warning \">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 494, "\"", 501, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 502, "\"", 510, 0);
            EndWriteAttribute();
            WriteLiteral(">Trống</a>\r\n          </p>\r\n");
#nullable restore
#line 23 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
        }
        else{

#line default
#line hidden
#nullable disable
            WriteLiteral("             <p  class=\"status-ticket danger \">\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 628, "\"", 635, 0);
            EndWriteAttribute();
            BeginWriteAttribute("class", " class=\"", 636, "\"", 644, 0);
            EndWriteAttribute();
            WriteLiteral(">Hủy</a>\r\n          </p>\r\n");
#nullable restore
#line 28 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p class=\"text-center pt-4\">");
#nullable restore
#line 29 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
                               Write(item.SeatNumberId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        <div class=\"px-3\">\r\n            <p >");
#nullable restore
#line 31 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" đ</p>\r\n            <p >");
#nullable restore
#line 32 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p >");
#nullable restore
#line 33 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
           Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p ></p>\r\n            <p >");
#nullable restore
#line 35 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
           Write(ViewBag.route.StartPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral(" - ");
#nullable restore
#line 35 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
                                       Write(ViewBag.route.EndPoint);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p style=\"font-size:14px\">");
#nullable restore
#line 36 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
                                  Write(ViewBag.route.TimeStart.ToString("HH:MM tt - dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n      </div>\r\n    </div>\r\n");
#nullable restore
#line 40 "C:\Users\Administrator\Desktop\carbooking_netcore\Views\Admin\Ticket\TicketList.cshtml"
  }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</div>\r\n</div>\r\n    \r\n    \r\n\r\n");
            DefineSection("Css", async() => {
                WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://cdn.datatables.net/1.10.21/css/jquery.dataTables.min.css"">
    <style>
        .ticket p{
            font-size: 14px;
        }
         .ticket {
        position: relative;
        box-sizing: border-box;
        width: 223px;
        height: 350px;  
        padding: 20px;
        border-radius: 10px;
        background: #fbfbfb;
    }
        .ticket:before, .ticket:after {
            content: '';
            position: absolute;
            left: 5px;
            height: 6px;
            width: 190px;
        }
        .ticket:before {
            top: -5px;
            background: radial-gradient(circle, transparent, transparent 50%, #fbfbfb 50%, #fbfbfb 100%) -7px -8px / 16px 16px repeat-x;
        }
        .ticket:after {
            bottom: -5px;
            background: radial-gradient(circle, transparent, transparent 50%, #fbfbfb 50%, #fbfbfb 100%) -7px -2px / 16px 16px repeat-x;
        }
        .ticket__content {
         ");
                WriteLiteral(@"   box-sizing: border-box;
            height: 100%;
            width: 100%;
            border: 6px solid #d8d8d8;
        }
        .status-ticket{
            display: inline-block;
            text-align: center;
            width: 50px;
            position: absolute;
            right: 20px;
            top: 20px; 
            padding: 0 10px;
            font-size: 10px;
        }
        .status-ticket.success{
            background: #20c997;

        }
        .status-ticket.warning{
            background: #ffc107 ;
        }

        .status-ticket.danger{
            background: #dc3545 ;
        }
        .status-ticket a{
            font-size: 10px;
            color: white;
        }
    </style>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Ticket>> Html { get; private set; }
    }
}
#pragma warning restore 1591
