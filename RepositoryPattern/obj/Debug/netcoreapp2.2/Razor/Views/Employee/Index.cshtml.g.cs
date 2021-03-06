#pragma checksum "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e8ce890eb6ed107e04b741b42acdb64323ff11b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Employee/Index.cshtml", typeof(AspNetCore.Views_Employee_Index))]
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
#line 1 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\_ViewImports.cshtml"
using RepositoryPattern;

#line default
#line hidden
#line 2 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\_ViewImports.cshtml"
using RepositoryPattern.Models;

#line default
#line hidden
#line 3 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\_ViewImports.cshtml"
using RepositoryPattern.ViewModels;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e8ce890eb6ed107e04b741b42acdb64323ff11b1", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8a75cc071d83ea2c1f140944ea22524f5f3251ae", @"/Views/_ViewImports.cshtml")]
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<EmployeeIndexViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(85, 1055, true);
            WriteLiteral(@"
    <div class=""content-wrapper"">
        <div class=""row"">
            <div class=""col-md-12 grid-margin"">
                <div class=""card-body"">
                    <div class=""row"">
                        <div class=""col-md-12 table-responsive-md"">
                            <table class=""table table-striped"">
                                <thead>
                                    <tr>
                                        <th>First Name</th>
                                        <th>Middle Name</th>
                                        <th>Last Name</th>
                                        <th>Gender</th>
                                        <th>DOB</th>
                                        <th>Email</th>
                                        <th>Phone</th>
                                        <th>Address</th>
                                        <th>City</th>
                                    </tr>
                                </thead>
          ");
            WriteLiteral("                      <tbody>\r\n");
            EndContext();
#line 27 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
            BeginContext(1245, 86, true);
            WriteLiteral("                                    <tr>\r\n                                        <td>");
            EndContext();
            BeginContext(1332, 14, false);
#line 30 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.FirstName);

#line default
#line hidden
            EndContext();
            BeginContext(1346, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1398, 15, false);
#line 31 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.MiddleName);

#line default
#line hidden
            EndContext();
            BeginContext(1413, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1465, 13, false);
#line 32 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.LastName);

#line default
#line hidden
            EndContext();
            BeginContext(1478, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1530, 11, false);
#line 33 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.Gender);

#line default
#line hidden
            EndContext();
            BeginContext(1541, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1593, 8, false);
#line 34 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.DOB);

#line default
#line hidden
            EndContext();
            BeginContext(1601, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1653, 10, false);
#line 35 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.Email);

#line default
#line hidden
            EndContext();
            BeginContext(1663, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1715, 10, false);
#line 36 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.Phone);

#line default
#line hidden
            EndContext();
            BeginContext(1725, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1777, 12, false);
#line 37 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.Address);

#line default
#line hidden
            EndContext();
            BeginContext(1789, 51, true);
            WriteLiteral("</td>\r\n                                        <td>");
            EndContext();
            BeginContext(1841, 9, false);
#line 38 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
                                       Write(item.City);

#line default
#line hidden
            EndContext();
            BeginContext(1850, 50, true);
            WriteLiteral("</td>\r\n                                    </tr>\r\n");
            EndContext();
#line 40 "D:\Projects\ASP .NET Core\RepositoryPattern\RepositoryPattern\Views\Employee\Index.cshtml"
                                    }

#line default
#line hidden
            BeginContext(1939, 224, true);
            WriteLiteral("                                </tbody>\r\n                            </table><br /><br />\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<EmployeeIndexViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
