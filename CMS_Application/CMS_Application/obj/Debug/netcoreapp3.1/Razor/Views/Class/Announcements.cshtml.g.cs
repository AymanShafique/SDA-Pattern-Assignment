#pragma checksum "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\Announcements.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93b06f64c56c92a00ba8bf1521722a2bc0023c80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Class_Announcements), @"mvc.1.0.view", @"/Views/Class/Announcements.cshtml")]
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
#line 1 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\Announcements.cshtml"
using CMS_Applicaion.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93b06f64c56c92a00ba8bf1521722a2bc0023c80", @"/Views/Class/Announcements.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3912563fcd8986d795683f929b9587e95ed54566", @"/Views/_ViewImports.cshtml")]
    public class Views_Class_Announcements : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\Announcements.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 class=""ml-3 text-primary"">Announcements</h2>
<div class=""col-sm-10 col-md-10 col-lg-10 px-3"">
    <div class=""row"">
        <div class=""col-sm-12 col-md-12 col-lg-12"">
            <div class=""card my-2 bg-light"">
                <div class=""card-body text-dark"">
");
#nullable restore
#line 12 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\Announcements.cshtml"
                     foreach (Class c in Model.Courses)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h4>Course : ");
#nullable restore
#line 14 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\Announcements.cshtml"
                                Write(c.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h4>Instructor : ");
#nullable restore
#line 15 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\Announcements.cshtml"
                                    Write(c.Instructor.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        <h4>");
#nullable restore
#line 16 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\Announcements.cshtml"
                       Write(c.Announcement);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n");
#nullable restore
#line 17 "C:\Users\this pc\source\repos\BSEF18M021\CMS_Application\CMS_Application\Views\Class\Announcements.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n\r\n\r\n\r\n\r\n");
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
