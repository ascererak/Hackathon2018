#pragma checksum "C:\Users\vlad1\Downloads\Hackathon\Hackathon2018\Hakathon\Hakathon\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2d6fbff209879e95e771726988cc721ab87acf04"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_Layout.cshtml", typeof(AspNetCore.Views_Shared__Layout))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2d6fbff209879e95e771726988cc721ab87acf04", @"/Views/Shared/_Layout.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 35, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(35, 121, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "918b4edc5a974f748d2ca696bdc556a4", async() => {
                BeginContext(41, 108, true);
                WriteLiteral("\r\n    <meta charset=\"utf-8\">\r\n    <title>name</title>\r\n    <link rel=\"stylesheet\" href=\"styles/style.css\">\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(156, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(158, 2513, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6d0dc87ead64430c9f75b51d4d57768a", async() => {
                BeginContext(164, 736, true);
                WriteLiteral(@"
    <div class=""page-header"">
        <div class=""container"">
            <div class=""header-top clearfix"">
                <div class=""header-logo"">
                    <img src=""img/logo3.png"" alt=""name"" width=""210"" height=""55"">
                </div>
                <ul class=""main-nav clearfix"">
                    <li><a href=""#"">Menu</a></li>
                    <li><a href=""#"">Delivery</a></li>
                    <li><a href=""#"">Profile</a></li>
                </ul>
                <a class=""btn btn-quick-order"" href=""#"">Order</a>
            </div>
            <div class=""promo"">
                <a href=""#"">Special winter offers<br> Year 2018</a>
            </div>
        </div>
    </div>

    ");
                EndContext();
                BeginContext(901, 12, false);
#line 28 "C:\Users\vlad1\Downloads\Hackathon\Hackathon2018\Hakathon\Hakathon\Views\Shared\_Layout.cshtml"
Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(913, 1751, true);
                WriteLiteral(@"
    <div class=""page-footer"">
        <div class=""container"">
            <div class=""footer-top clearfix"">
                <div class=""footer-logo"">
                    <img src=""img/logo3.png"" alt="""" width=""205"" height=""55"">
                </div>
                <a href=""#"" class=""btn btn-quick-order"">Order</a>
            </div>
            <div class=""footer-middle clearfix"">
                <div class=""footer-menu"">
                    <h3>Menu</h3>
                    <ul>
                        <li><a href=""#"">Quick menu</a></li>
                        <li><a href=""#"">Full menu</a></li>
                        <li><a href=""#"">Special offers</a></li>
                    </ul>
                </div>
                <div class=""footer-menu"">
                    <h3>Reviews</h3>
                    <ul>
                        <li><a href=""#"">See</a></li>
                        <li><a href=""#"">Leave</a></li>
                    </ul>
                </div>
                <div");
                WriteLiteral(@" class=""footer-menu"">
                    <h3>Order</h3>
                    <ul>
                        <li><a href=""#"">Open the cart</a></li>
                    </ul>
                </div>
            </div>
            <div class=""footer-bottom clearfix"">
                <div class=""footer-social"">
                    <b>Join us!</b>
                    <a class=""social-btn social-btn-fb"" href=""#"">Facebook</a>
                    <a class=""social-btn social-btn-in"" href=""#"">Instagram</a>
                </div>
                <div class=""footer-copyright"">
                    With <span class=""heart"">love</span> for Hackathon
                </div>
            </div>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2671, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
