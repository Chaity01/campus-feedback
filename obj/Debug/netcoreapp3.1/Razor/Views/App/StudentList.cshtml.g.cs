#pragma checksum "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d6ebd2498143b83280e516373c88808446818be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_App_StudentList), @"mvc.1.0.view", @"/Views/App/StudentList.cshtml")]
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
#line 1 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\_ViewImports.cshtml"
using DutchTreat.Controllers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\_ViewImports.cshtml"
using DutchTreat.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\_ViewImports.cshtml"
using DutchTreat.Data.Entities;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d6ebd2498143b83280e516373c88808446818be", @"/Views/App/StudentList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cccdc618d180ae6818a9f5517f699d195c5dcebd", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_App_StudentList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DutchTreat.Data.Entities.Student>>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SurveyDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
  
    ViewData["Title"] = "Questions List";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""container-fluid"">
    <div class=""container mt-5"">
        <h1>Students that completed surveys </h1>

        <br/>
        <table class=""table table-dark"">
            <thead>
                <tr>
                    <th>
                        ");
#nullable restore
#line 18 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
                   Write(Html.DisplayNameFor(model => model.UniversityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
                   Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 24 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
                   Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 27 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
                   Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th></th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 33 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>\r\n                            ");
#nullable restore
#line 37 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UniversityId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 40 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 43 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
#nullable restore
#line 46 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9d6ebd2498143b83280e516373c88808446818be7412", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 49 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 52 "C:\Users\Chaity\Desktop\Campus Feeback 2 - Copy\Views\App\StudentList.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DutchTreat.Data.Entities.Student>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
