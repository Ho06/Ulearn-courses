#pragma checksum "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6b8ceec040a677af3bb4faa9c48cf74dfebcc7a5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyFavorite_Index), @"mvc.1.0.view", @"/Views/MyFavorite/Index.cshtml")]
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
#line 1 "D:\ULearnupdate\ULearn\ULearn\Views\_ViewImports.cshtml"
using ULearn;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\ULearnupdate\ULearn\ULearn\Views\_ViewImports.cshtml"
using ULearn.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\ULearnupdate\ULearn\ULearn\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6b8ceec040a677af3bb4faa9c48cf74dfebcc7a5", @"/Views/MyFavorite/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc26d9fc11d1278717b99987591352f3f3eaee74", @"/Views/_ViewImports.cshtml")]
    public class Views_MyFavorite_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ULearn.DataBase.Entites.LearningList>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row mt-2"">

    <!-- /.card-header -->
    <div class=""col-md-8"">
        <h3 class=""mb-3""> list of courses </h3>
    </div>
    <div class=""col-md-4"">
        <ol class=""breadcrumb float-sm-right"">
            <li class=""breadcrumb-item"">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8ceec040a677af3bb4faa9c48cf74dfebcc7a54663", async() => {
                WriteLiteral("Home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item\">");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6b8ceec040a677af3bb4faa9c48cf74dfebcc7a56069", async() => {
                WriteLiteral("Category");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</li>\r\n            <li class=\"breadcrumb-item active\">My List</li>\r\n        </ol>\r\n    </div>\r\n</div>\r\n");
#nullable restore
#line 23 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
 foreach (var item in Model)
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""card"">
        <div class=""card-header bg-cyan"">
            <h3 class=""card-title""> List </h3>
        </div>
        <div class=""card-body p-0 mt-2 mb-2"">
            <table class=""table table-sm"">
                <thead>
                    <tr>
                        <th>Course code</th>
                        <th> Course Name</th>
                        <th> Course Duration</th>
                        <th>Course Price</th>
                    </tr>
                </thead>
                <tbody>
                    <tr>
                    </tr>
");
#nullable restore
#line 42 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                     foreach (var subitem in item.LearnCrs)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td>");
#nullable restore
#line 45 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                           Write(subitem.CrsId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                            <td>\r\n");
#nullable restore
#line 47 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                                 foreach (var courseName in Course.GetNameById(subitem.CrsId))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 49 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                                  Write(courseName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 50 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n\r\n\r\n");
#nullable restore
#line 56 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                                 foreach (var CourseDuration in Course.GetDurationById(subitem.CrsId))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 58 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                                  Write(CourseDuration);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 59 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                            </td>\r\n                            <td>\r\n\r\n\r\n");
#nullable restore
#line 67 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                                 foreach (var CoursePrice in Course.GetPriceById(subitem.CrsId))
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <p>");
#nullable restore
#line 69 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                                  Write(CoursePrice);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 70 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 76 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 82 "D:\ULearnupdate\ULearn\ULearn\Views\MyFavorite\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<!-- /.card-body -->\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ULearn.BL.Interface.ICourseRep Course { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ULearn.DataBase.Entites.LearningList>> Html { get; private set; }
    }
}
#pragma warning restore 1591
