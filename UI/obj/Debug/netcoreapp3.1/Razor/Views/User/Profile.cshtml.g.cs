#pragma checksum "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95ed9abd635120c52a8b0ae2afeff1fe023eb645"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_User_Profile), @"mvc.1.0.view", @"/Views/User/Profile.cshtml")]
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
#line 1 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\_ViewImports.cshtml"
using System.Security.Claims;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95ed9abd635120c52a8b0ae2afeff1fe023eb645", @"/Views/User/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ac279599a0caf7dfd39060e2a06d36dd24f4d88b", @"/Views/_ViewImports.cshtml")]
    public class Views_User_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entities.ConCreate.users>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/img/300x300.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Image Alternative text"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("AMaze"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/Profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/MyReservations"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/MyCredits"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/MyHomes"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/User/MyFavorites"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("user_profile"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("change_password"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"container\">\r\n        <h1 class=\"page-title\">");
#nullable restore
#line 9 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                          Write(Localizer["account_settings"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h1>
    </div>

    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-3"">
                <aside class=""user-profile-sidebar"">
                    <div class=""user-profile-avatar text-center"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "95ed9abd635120c52a8b0ae2afeff1fe023eb6457968", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        <h5>");
#nullable restore
#line 18 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                       Write(Context.User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                    </div>\r\n                    <ul class=\"list user-profile-nav\">\r\n                        <li>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95ed9abd635120c52a8b0ae2afeff1fe023eb6459597", async() => {
                WriteLiteral("<i class=\"fa fa-cog\"></i>");
#nullable restore
#line 22 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                                                         Write(Localizer["settings"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95ed9abd635120c52a8b0ae2afeff1fe023eb64511045", async() => {
                WriteLiteral("<i class=\"fa fa-clock-o\"></i>");
#nullable restore
#line 25 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                                                                    Write(Localizer["booking_history"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95ed9abd635120c52a8b0ae2afeff1fe023eb64512516", async() => {
                WriteLiteral("<i class=\"fa fa-credit-card\"></i>");
#nullable restore
#line 28 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                                                                   Write(Localizer["credits"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95ed9abd635120c52a8b0ae2afeff1fe023eb64513982", async() => {
                WriteLiteral("<i class=\"fa fa-heart-o\"></i>");
#nullable restore
#line 31 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                                                             Write(Localizer["my_homes"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                        <li>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95ed9abd635120c52a8b0ae2afeff1fe023eb64515439", async() => {
                WriteLiteral("<i class=\"fa fa-heart-o\"></i>");
#nullable restore
#line 34 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                                                                 Write(Localizer["favorites"]);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </li>\r\n                    </ul>\r\n                </aside>\r\n            </div>\r\n            <div class=\"col-md-9\">\r\n                <div class=\"row\">\r\n                    <div class=\"col-md-5\">\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95ed9abd635120c52a8b0ae2afeff1fe023eb64517071", async() => {
                WriteLiteral("\r\n                            <h4>");
#nullable restore
#line 43 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                           Write(Localizer["p_inf"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h4>\r\n                            <div class=\"form-group form-group-icon-left\">\r\n                                <i class=\"fa fa-user input-icon\"></i>\r\n                                <label>");
#nullable restore
#line 46 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                  Write(Localizer["first_name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2138, "\"", 2163, 1);
#nullable restore
#line 47 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
WriteAttributeValue("", 2146, Model.first_name, 2146, 17, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral("  type=\"text\">\r\n                            </div>\r\n                            <div class=\"form-group form-group-icon-left\">\r\n                                <i class=\"fa fa-user input-icon\"></i>\r\n                                <label>");
#nullable restore
#line 51 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                  Write(Localizer["last_name"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2493, "\"", 2517, 1);
#nullable restore
#line 52 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
WriteAttributeValue("", 2501, Model.last_name, 2501, 16, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\">\r\n                            </div>\r\n                            <div class=\"form-group form-group-icon-left\">\r\n                                <i class=\"fa fa-envelope input-icon\"></i>\r\n                                <label>");
#nullable restore
#line 56 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                  Write(Localizer["email"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 2846, "\"", 2866, 1);
#nullable restore
#line 57 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
WriteAttributeValue("", 2854, Model.email, 2854, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\">\r\n                            </div>\r\n                            <div class=\"form-group form-group-icon-left\">\r\n                                <i class=\"fa fa-phone input-icon\"></i>\r\n                                <label>");
#nullable restore
#line 61 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                  Write(Localizer["phone"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input class=\"form-control\"");
                BeginWriteAttribute("value", " value=\"", 3192, "\"", 3212, 1);
#nullable restore
#line 62 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
WriteAttributeValue("", 3200, Model.phone, 3200, 12, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" type=\"text\">\r\n                            </div>\r\n                            <div class=\"gap gap-small\"></div>\r\n");
                WriteLiteral("                            <hr>\r\n                            <input type=\"submit\" class=\"btn btn-primary\"");
                BeginWriteAttribute("value", " value=\"", 5083, "\"", 5119, 1);
#nullable restore
#line 92 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
WriteAttributeValue("", 5091, Localizer["update_profile"], 5091, 28, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                    <div class=\"col-md-4 col-md-offset-1\">\r\n                        <h4>");
#nullable restore
#line 96 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                       Write(Localizer["change_password"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95ed9abd635120c52a8b0ae2afeff1fe023eb64523512", async() => {
                WriteLiteral("\r\n                            <div class=\"form-group form-group-icon-left\">\r\n                                <i class=\"fa fa-lock input-icon\"></i>\r\n                                <label>");
#nullable restore
#line 100 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                  Write(Localizer["current_password"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                <input class=""form-control"" type=""password"">
                            </div>
                            <div class=""form-group form-group-icon-left"">
                                <i class=""fa fa-lock input-icon""></i>
                                <label>");
#nullable restore
#line 105 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                  Write(Localizer["new_password"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</label>
                                <input class=""form-control"" type=""password"">
                            </div>
                            <div class=""form-group form-group-icon-left"">
                                <i class=""fa fa-lock input-icon""></i>
                                <label>");
#nullable restore
#line 110 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
                                  Write(Localizer["new_password_again"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("</label>\r\n                                <input class=\"form-control\" type=\"password\">\r\n                            </div>\r\n                            <hr>\r\n                            <input class=\"btn btn-primary\" type=\"submit\"");
                BeginWriteAttribute("value", " value=\"", 6482, "\"", 6519, 1);
#nullable restore
#line 114 "C:\Users\tayfu\source\repos\codekafa\werenda\UI\Views\User\Profile.cshtml"
WriteAttributeValue("", 6490, Localizer["update_password"], 6490, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </div>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <div class=\"gap\"></div>\r\n\r\n\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IViewLocalizer Localizer { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entities.ConCreate.users> Html { get; private set; }
    }
}
#pragma warning restore 1591
