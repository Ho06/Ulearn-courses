#pragma checksum "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d9e3e9920543245398ed6abf5e20c5a91b16179b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Video_Index), @"mvc.1.0.view", @"/Views/Video/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d9e3e9920543245398ed6abf5e20c5a91b16179b", @"/Views/Video/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc26d9fc11d1278717b99987591352f3f3eaee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Video_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<ULearn.DAL.DataBase.Entites.Video>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
            WriteLiteral(@"<script src=""https://player.vimeo.com/api/player.js""></script>


<style>
    iframe {
    }

    hr {
        border-top: 3px solid;
    }
</style>
<section class=""content"">
    <div class=""container-fluid"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card card-cyan"">
                    <div class=""card-header"">
                        <h3 class=""card-title"">VideosList</h3>
                    </div>
                    <!-- /.card-header -->

                    <div class=""sidebar overlay-menuv "" style=""overflow-y:auto; overflow-x:hidden;scroll-behavior:smooth;"">
");
#nullable restore
#line 33 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                         foreach (var item in Model)
                        {


#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"card-body text-center row\">\r\n                                <div class=\"col-sm-8 mt-1\"");
            BeginWriteAttribute("id", " id=\"", 1112, "\"", 1125, 1);
#nullable restore
#line 37 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
WriteAttributeValue("", 1117, item.Id, 1117, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-vimeo-id=\"");
#nullable restore
#line 37 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                                                                   Write(item.VidLink);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" data-vimeo-autoplay=\"false\" data-vimeo-loop=\"false\">\r\n                                </div>\r\n                                <div class=\"jumbotron col-sm-4\">\r\n                                    <h1 class=\"display-4\">  ");
#nullable restore
#line 40 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                                       Write(item.Course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n                                    <hr class=\"my-4\">\r\n                                    <input type=\"hidden\"");
            BeginWriteAttribute("value", " value=\"", 1512, "\"", 1528, 1);
#nullable restore
#line 42 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
WriteAttributeValue("", 1520, item.Id, 1520, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n\r\n");
#nullable restore
#line 44 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                     if (washlist.GetWashedByWashId(Context.Session.GetInt32("WashListId"), item.Id) == 1)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div style=\"float:left\" class=\"lead mt-2 alertDiv\">\r\n                                            <div");
            BeginWriteAttribute("class", " class=\"", 1840, "\"", 1862, 2);
#nullable restore
#line 47 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
WriteAttributeValue("", 1848, item.Id, 1848, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 1856, "alert", 1857, 6, true);
            EndWriteAttribute();
            WriteLiteral(@" role=""alert"">
                                                <i class=""fas fa-eye-slash""></i>
                                                <p class=""text-danger"">Not seen</p>
                                            </div>
                                        </div>
");
#nullable restore
#line 52 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                    }
                                    else
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <div style=\"float:left\" class=\"lead mt-2 alertDiv\">\r\n                                            <div");
            BeginWriteAttribute("class", " class=\"", 2407, "\"", 2429, 2);
#nullable restore
#line 56 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
WriteAttributeValue("", 2415, item.Id, 2415, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue(" ", 2423, "alert", 2424, 6, true);
            EndWriteAttribute();
            WriteLiteral(@" role=""alert"">
                                                <i class=""fas far fa-eye""></i>
                                                <p class=""text-success"">seen</p>
                                            </div>
                                        </div>
");
#nullable restore
#line 61 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </div>\r\n                                <script>\r\n                                    var videoPlayer = new Vimeo.Player(\'");
#nullable restore
#line 65 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                                                   Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');\r\n                                    videoPlayer.on(\'play\', function () {\r\n                                        //alert(\'Played the video\');\r\n");
            WriteLiteral("                                        $(\'.alertDiv .");
#nullable restore
#line 69 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" p\').text(\"seen\")\r\n                                        $(\'.alertDiv .");
#nullable restore
#line 70 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" p\').removeClass(\"text-danger\")\r\n                                        $(\'.alertDiv .");
#nullable restore
#line 71 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" p\').addClass(\"text-success\")\r\n                                        $(\'.alertDiv .");
#nullable restore
#line 72 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" i\').removeClass(\'fa-eye-slash\');\r\n                                        $(\'.alertDiv .");
#nullable restore
#line 73 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                                 Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(" i\').addClass(\'far fa-eye\');\r\n\r\n                                        var crsid = ");
#nullable restore
#line 75 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                        var VidLink = ");
#nullable restore
#line 76 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                                 Write(item.VidLink);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                        var wishid = ");
#nullable restore
#line 77 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                                                Write(Context.Session.GetInt32("WashListId"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";
                                            $.ajax({
                                                url: '/Video/AddtoWatchList',
                                                type: 'POST',
                                                data: {
                                                    'crsid': crsid,
                                                    'wishid': wishid,
                                                    'videolink': VidLink
                                                },
                                                dataType: 'json',
                                                success: function (data) {
                                                //alert(""send to data base"")
                                                },
                                                error: function (request, error) {
                                                //    alert(""Request: "" + JSON.stringify(request));
                                            ");
            WriteLiteral("    }\r\n                                            });\r\n\r\n\r\n\r\n\r\n                                    });\r\n                                </script>\r\n                            </div>\r\n                            <hr style=\"height:10px\" />\r\n");
#nullable restore
#line 102 "D:\ULearnupdate\ULearn\ULearn\Views\Video\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n                <!-- /.card-body -->\r\n            </div>\r\n            <!-- /.card -->\r\n        </div>\r\n        <!-- /.col -->\r\n    </div>\r\n    <!-- /.row -->\r\n    <!-- /.container-fluid -->\r\n</section>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d9e3e9920543245398ed6abf5e20c5a91b16179b13910", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://player.vimeo.com/api/player.js\"></script>\r\n<script src=\"{url}\"></script>\r\n");
            WriteLiteral("<script>\r\n    var videoPlayer = new Vimeo.Player(\'myVideo\');\r\n    videoPlayer.on(\'play\', function () {\r\n    //    console.log(\'Played the video\');\r\n    });\r\n</script>\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public ULearn.BL.Interface.IWashListRep washlist { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<ULearn.DAL.DataBase.Entites.Video>> Html { get; private set; }
    }
}
#pragma warning restore 1591
