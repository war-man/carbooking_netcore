#pragma checksum "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\Admin\Car\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cd3142f904b1f24d5d85d5f920399c3f34fc516d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Admin_Car_Index), @"mvc.1.0.view", @"/Views/Admin/Car/Index.cshtml")]
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
#line 1 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\_ViewImports.cshtml"
using System;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking.Helper;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\_ViewImports.cshtml"
using CarBooking.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cd3142f904b1f24d5d85d5f920399c3f34fc516d", @"/Views/Admin/Car/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19cedbd1f6285209d22a8b3f0c52fa3e91d9eb4e", @"/Views/_ViewImports.cshtml")]
    public class Views_Admin_Car_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Car>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\Admin\Car\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    ViewBag.Title = "Xe";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- Card deck -->\r\n     <div class=\"text-right mb-2\">\r\n         <a href=\"/admin/car/create\" class=\"btn btn-primary btn-sm\">\r\n             Thêm xe\r\n         </a>\r\n     </div>\r\n<div class=\"card-deck\">\r\n    <div class=\"row w-100\">\r\n");
#nullable restore
#line 14 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\Admin\Car\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-4\">\r\n                <div class=\"card mb-4\">\r\n\r\n                    <!--Card image-->\r\n                    <div class=\"view overlay\">\r\n                    <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 569, "\"", 590, 1);
#nullable restore
#line 21 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\Admin\Car\Index.cshtml"
WriteAttributeValue("", 575, item.Thumbnail, 575, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("\r\n                        alt=\"Card image cap\" height=\"280px\">\r\n                    <a");
            BeginWriteAttribute("href", " href=\"", 677, "\"", 696, 2);
            WriteAttributeValue("", 684, "car/", 684, 4, true);
#nullable restore
#line 23 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\Admin\Car\Index.cshtml"
WriteAttributeValue("", 688, item.Id, 688, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@">
                        <div class=""mask rgba-white-slight""></div>
                    </a>
                    </div>

                    <!--Card content-->
                    <div class=""card-body"">
                    <!--Title-->    
                    <h4 class=""card-title"">Car #");
#nullable restore
#line 31 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\Admin\Car\Index.cshtml"
                                           Write(item.CarCode);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h4>\r\n                    <!--Text-->\r\n                    <p class=\"card-text\">");
#nullable restore
#line 33 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\Admin\Car\Index.cshtml"
                                    Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                    <p class=""card-text""><span class=""d-inline-block"" style=""width:80px""> Lái xe:  </span> Nguyễn Văn BB </p>
                    <p class=""card-text""><span class=""d-inline-block"" style=""width:80px""> Phụ xe:  </span> Nguyễn Văn B </p>
                    <p class=""card-text""><span class=""d-inline-block"" style=""width:80px""> Thời gian:  </span> 20 : 10 - 15 - 6 - 2020</p>
                    <p class=""card-text""><span class=""d-inline-block"" style=""width:80px""> Hành trình:  </span> Đà Nẵng Hà Nội</p>
                    <p class=""card-text""><span class=""d-inline-block"" style=""width:80px""> Trạng thái: </span>  Đã xuất phát </p>
                    <!-- Provides extra visual weight and identifies the primary action in a set of buttons -->
                    <a");
            BeginWriteAttribute("href", " href=\"", 1902, "\"", 1921, 2);
            WriteAttributeValue("", 1909, "car/", 1909, 4, true);
#nullable restore
#line 40 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\Admin\Car\Index.cshtml"
WriteAttributeValue("", 1913, item.Id, 1913, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-light-blue btn-md\">Chi tiết</a>\r\n\r\n                    </div>\r\n\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 46 "C:\Users\Administrator\Desktop\doan\carbooking_netcore\Views\Admin\Car\Index.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n\r\n  <!-- Card -->\r\n\r\n  <!-- Card -->\r\n\r\n\r\n\r\n</div>\r\n<!-- Card deck -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Car>> Html { get; private set; }
    }
}
#pragma warning restore 1591
