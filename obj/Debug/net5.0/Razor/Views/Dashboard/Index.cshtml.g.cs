#pragma checksum "D:\ULearnupdate\ULearn\ULearn\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d010c953f201f35af1ecc07b06e1b275c1689f5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d010c953f201f35af1ecc07b06e1b275c1689f5", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fc26d9fc11d1278717b99987591352f3f3eaee74", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "D:\ULearnupdate\ULearn\ULearn\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Dashboard.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<link rel=""stylesheet"" href=""plugins/daterangepicker/daterangepicker.css"">

<br />
<section class=""mb-2"">
    <div class=""row"">
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-info"">
                <div class=""inner"">
                    <h3>150</h3>

                    <p>New Orders</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-bag""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-success"">
                <div class=""inner"">
                    <h3>53<sup style=""font-size: 20px"">%</sup></h3>

                    <p>Bounce Rate</p>
                </div>
                <div class=""icon"">
                    <i class=""ion i");
            WriteLiteral(@"on-stats-bars""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-warning"">
                <div class=""inner"">
                    <h3>44</h3>

                    <p>User Registrations</p>
                </div>
                <div class=""icon"">
                    <i class=""ion ion-person-add""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
        <div class=""col-lg-3 col-6"">
            <!-- small box -->
            <div class=""small-box bg-danger"">
                <div class=""inner"">
                    <h3>65</h3>

                    <p>Unique Visitors</p>
                </div>
     ");
            WriteLiteral(@"           <div class=""icon"">
                    <i class=""ion ion-pie-graph""></i>
                </div>
                <a href=""#"" class=""small-box-footer"">More info <i class=""fas fa-arrow-circle-right""></i></a>
            </div>
        </div>
        <!-- ./col -->
    </div>
</section>


<section>
    <div class=""row"">
        <div class=""col-md-6"">

            <div class=""card"">
                <div class=""card-header border-0"">
                    <h3 class=""card-title"">Online Store Overview</h3>
                    <div class=""card-tools"">
                        <a href=""#"" class=""btn btn-sm btn-tool"">
                            <i class=""fas fa-download""></i>
                        </a>
                        <a href=""#"" class=""btn btn-sm btn-tool"">
                            <i class=""fas fa-bars""></i>
                        </a>
                    </div>
                </div>
                <div class=""card-body"">
                    <div class=""d-flex justi");
            WriteLiteral(@"fy-content-between align-items-center border-bottom mb-3"">
                        <p class=""text-success text-xl"">
                            <i class=""ion ion-ios-refresh-empty""></i>
                        </p>
                        <p class=""d-flex flex-column text-right"">
                            <span class=""font-weight-bold"">
                                <i class=""ion ion-android-arrow-up text-success""></i> 12%
                            </span>
                            <span class=""text-muted"">CONVERSION RATE</span>
                        </p>
                    </div>
                    <!-- /.d-flex -->
                    <div class=""d-flex justify-content-between align-items-center border-bottom mb-3"">
                        <p class=""text-warning text-xl"">
                            <i class=""ion ion-ios-cart-outline""></i>
                        </p>
                        <p class=""d-flex flex-column text-right"">
                            <span class=""font-");
            WriteLiteral(@"weight-bold"">
                                <i class=""ion ion-android-arrow-up text-warning""></i> 0.8%
                            </span>
                            <span class=""text-muted"">SALES RATE</span>
                        </p>
                    </div>
                    <!-- /.d-flex -->
                    <div class=""d-flex justify-content-between align-items-center mb-0"">
                        <p class=""text-danger text-xl"">
                            <i class=""ion ion-ios-people-outline""></i>
                        </p>
                        <p class=""d-flex flex-column text-right"">
                            <span class=""font-weight-bold"">
                                <i class=""ion ion-android-arrow-down text-danger""></i> 1%
                            </span>
                            <span class=""text-muted"">REGISTRATION RATE</span>
                        </p>
                    </div>
                    <!-- /.d-flex -->
                </div>
      ");
            WriteLiteral(@"      </div>



        </div>
        <div class=""col-md-6"">
            <div class=""info-box mb-3 bg-info"">
                <span class=""info-box-icon""><i class=""far fa-comment""></i></span>

                <div class=""info-box-content"">
                    <span class=""info-box-text"">Direct Messages</span>
                    <span class=""info-box-number"">163,921</span>
                </div>
                <!-- /.info-box-content -->
            </div>
                <!-- Info Boxes Style 2 -->
                <div class=""info-box mb-3 bg-warning"">
                    <span class=""info-box-icon""><i class=""fas fa-tag""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Inventory</span>
                        <span class=""info-box-number"">5,200</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
                <div class=""info-");
            WriteLiteral(@"box mb-3 bg-success"">
                    <span class=""info-box-icon""><i class=""far fa-heart""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Mentions</span>
                        <span class=""info-box-number"">92,050</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
                <div class=""info-box mb-3 bg-danger"">
                    <span class=""info-box-icon""><i class=""fas fa-cloud-download-alt""></i></span>

                    <div class=""info-box-content"">
                        <span class=""info-box-text"">Downloads</span>
                        <span class=""info-box-number"">114,381</span>
                    </div>
                    <!-- /.info-box-content -->
                </div>
                <!-- /.info-box -->
                
                <!-- /.info-box -->
 
        </div>
    </div>
</section>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <!-- ChartJS -->\r\n \r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
