#pragma checksum "C:\Users\Strok\source\repos\Real_timeWebApp\ASC.Web\ASC.Web\Views\Shared\_TalkLayout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f812ffad00d4c278c3bbbccf5edfeeea36a14bdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__TalkLayout), @"mvc.1.0.view", @"/Views/Shared/_TalkLayout.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/_TalkLayout.cshtml", typeof(AspNetCore.Views_Shared__TalkLayout))]
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
#line 1 "C:\Users\Strok\source\repos\Real_timeWebApp\ASC.Web\ASC.Web\Views\_ViewImports.cshtml"
using ASC.Web;

#line default
#line hidden
#line 2 "C:\Users\Strok\source\repos\Real_timeWebApp\ASC.Web\ASC.Web\Views\_ViewImports.cshtml"
using ASC.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f812ffad00d4c278c3bbbccf5edfeeea36a14bdf", @"/Views/Shared/_TalkLayout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ace12d9fe341bcc7dc4c5fbf6edea1114adb1bf", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__TalkLayout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Talk", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Talk", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "School", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("collapsible-header"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Work", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Users\Strok\source\repos\Real_timeWebApp\ASC.Web\ASC.Web\Views\Shared\_TalkLayout.cshtml"
   
    Layout = "_MasterLayout";

#line default
#line hidden
            BeginContext(39, 1012, true);
            WriteLiteral(@"
    <header class=""secureLayout"">
        <nav class=""white top-nav"">
            <div class=""nav-wrapper row valign-wrapper"">
                <div class=""col s12 valign-wrapper"">
                    <h5 class=""center""><a class=""page-title black-text"">IT talk</a></h5>

                </div>
                <a href=""#"" data-target=""slide-out"" class=""sidenav-trigger right-aligned""><i class=""material-icons black-text top-nav full hide-on-large-only"">menu</i></a>
            </div>
        </nav>
        <ul id=""slide-out"" class=""side-nav fixed"">
            <li>
                <div class=""userView"">
                    <div class=""background blue-grey lighten-1""></div>
                    <a href=""#!user""><img class=""circle"" /></a>
                    <a href=""#!name""><span class=""white-text name"">name</span></a>
                    <a href=""#!email""><span class=""white-text email"">me@here.com</span></a>
                </div>
            </li>
            <li>
                ");
            EndContext();
            BeginContext(1051, 177, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7b13475232b4ef9a270807ba175ad45", async() => {
                BeginContext(1139, 85, true);
                WriteLiteral("\r\n                    <i class=\"material-icons\">dashboard</i>School\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1228, 153, true);
            WriteLiteral("\r\n            </li>\r\n            <li>\r\n                <ul class=\"collapsible collapsible-accordion\">\r\n                    <li>\r\n                        ");
            EndContext();
            BeginContext(1381, 221, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b7618ac68090466a85c14502a8b0ef56", async() => {
                BeginContext(1467, 131, true);
                WriteLiteral("\r\n                            Work\r\n                            <i class=\"material-icons\">Sup account</i>\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1602, 2357, true);
            WriteLiteral(@"
                        <div class=""collapsible-body"">
                            <ul>
                                <li>
                                    <a href=""#!"">
                                        Customers
                                        <i class=""material-icons"">account_box</i>
                                    </a>
                                </li>
                                <li>
                                    <a href=""#!"">
                                        Provision user
                                        <i class=""material-icons"">person_add</i>
                                    </a>
                                </li>
                                <li>
                                    <a href=""#!"">
                                        Deactivate User
                                        <i class=""material-icons"">remove_circle</i>
                                    </a>
                                </li>
        ");
            WriteLiteral(@"                    </ul>
                        </div>
                    </li>
                </ul>
            </li>
            <li>
                <a class=""collapsible-header"" href=""#!"">
                    <i class=""material-icons"">perm_data_setting</i>
                    Service Request
                </a>
            </li>
            <li>
                <a class=""collapsible-header"" href=""#!"">
                    <i class=""material-icons"">message</i>
                    Service Notification
                </a>
            </li>
            <li>
                <a class=""collapsible-header"" href=""#!"">
                    <i class=""material-icons"">inbox</i>
                    Promotions
                </a>
            </li>
            <li>
                <a class=""collapsible-header"" href=""#!"">
                    <i class=""material-icons"">settings</i>
                    Settings
                </a>
            </li>
            <li>
                <a class");
            WriteLiteral(@"=""collapsible-header"" href=""#!"">
                    <i class=""material-icons"">exit_to_app</i>
                    Logout
                </a>
            </li>
        </ul>
    </header>
<main class=""secureLayout"">
    <div class=""row margin-bottom-0pk"">
        <div class=""col s12"">
            ");
            EndContext();
            BeginContext(3960, 12, false);
#line 96 "C:\Users\Strok\source\repos\Real_timeWebApp\ASC.Web\ASC.Web\Views\Shared\_TalkLayout.cshtml"
       Write(RenderBody());

#line default
#line hidden
            EndContext();
            BeginContext(3972, 121, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</main>\r\n<footer class=\"page-footer white secureLayout\">\r\n    <div class=\"divider\"></div>\r\n");
            EndContext();
            BeginContext(5705, 11, true);
            WriteLiteral("</footer>\r\n");
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
