#pragma checksum "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\CourseEnrollment.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "17e89e989ec9014174141bff2d84a8d182e2dfb5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Class_CourseEnrollment), @"mvc.1.0.view", @"/Views/Class/CourseEnrollment.cshtml")]
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
#line 1 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\_ViewImports.cshtml"
using CMS_Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\_ViewImports.cshtml"
using CMS_Application.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\CourseEnrollment.cshtml"
using CMS_Applicaion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"17e89e989ec9014174141bff2d84a8d182e2dfb5", @"/Views/Class/CourseEnrollment.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3912563fcd8986d795683f929b9587e95ed54566", @"/Views/_ViewImports.cshtml")]
    public class Views_Class_CourseEnrollment : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\CourseEnrollment.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

    <div class=""col-sm-10 col-md-10 col-lg-10 px-3"">
        <div class=""row"">
            <div class=""col-sm-12 col-md-12 col-lg-12"">
                <div class=""card my-2"">
                    <div class=""card-body"">
                        <h4 class=""card-title"">Announcements</h4>
                        <p>");
#nullable restore
#line 13 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\CourseEnrollment.cshtml"
                      Write(Model.Announcement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591