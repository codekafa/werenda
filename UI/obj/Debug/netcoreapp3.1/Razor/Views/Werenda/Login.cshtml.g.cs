#pragma checksum "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "73f82862cab5671ef9d0d1bd5040f63368a9c289"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Werenda_Login), @"mvc.1.0.view", @"/Views/Werenda/Login.cshtml")]
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
#line 1 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\_ViewImports.cshtml"
using UI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Mvc.Localization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"73f82862cab5671ef9d0d1bd5040f63368a9c289", @"/Views/Werenda/Login.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4ec17d292d10c4b7d5b25b67a374b4aeff8bd5d6", @"/Views/_ViewImports.cshtml")]
    public class Views_Werenda_Login : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
  
    string antiForgeryToken = Xsrf.GetAndStoreTokens(Context).RequestToken;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
  
    ViewData["Title"] = "Login";
    Layout = "~/Views/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\">\r\n    <h1 class=\"page-title\">");
#nullable restore
#line 14 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                      Write(Localizer["login_header"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n</div>\r\n<div class=\"gap\"></div>\r\n<div class=\"container\">\r\n    <div class=\"row\" data-gutter=\"60\">\r\n        <div class=\"col-md-4\">\r\n            <h3>");
#nullable restore
#line 20 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
           Write(Localizer["welcome"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <p>");
#nullable restore
#line 21 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
          Write(Localizer["welcome_message_1"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n            <p>");
#nullable restore
#line 22 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
          Write(Localizer["welcome_message_2"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <h3>");
#nullable restore
#line 25 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
           Write(Localizer["login"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div id=\"login-form\">\r\n                <div class=\"form-group form-group-icon-left\">\r\n                    <i class=\"fa fa-user input-icon input-icon-show\"></i>\r\n                    <label>");
#nullable restore
#line 29 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                      Write(Localizer["email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <input class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 962, "\"", 976, 0);
            EndWriteAttribute();
            WriteLiteral(" name=\"Email\" id=\"Email\" data-serialize=\"true\" type=\"email\">\r\n                </div>\r\n                <div class=\"form-group form-group-icon-left\">\r\n                    <i class=\"fa fa-lock input-icon input-icon-show\"></i>\r\n                    <label>");
#nullable restore
#line 34 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                      Write(Localizer["password"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <input class=\"form-control\" type=\"password\" name=\"Password\" id=\"Password\" data-serialize=\"true\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1375, "\"", 1389, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <input class=\"btn btn-primary\" type=\"button\" id=\"loginBtn\"");
            BeginWriteAttribute("value", " value=\"", 1491, "\"", 1518, 1);
#nullable restore
#line 37 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
WriteAttributeValue("", 1499, Localizer["login"], 1499, 19, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <h3>");
#nullable restore
#line 41 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
           Write(Localizer["new"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n            <div id=\"register-form\">\r\n                <div class=\"form-group form-group-icon-left\">\r\n                    <i class=\"fa fa-user input-icon input-icon-show\"></i>\r\n                    <label>");
#nullable restore
#line 45 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                      Write(Localizer["first_name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <input class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 1914, "\"", 1928, 0);
            EndWriteAttribute();
            WriteLiteral(" data-serialize=\"true\" type=\"text\">\r\n                </div>\r\n                <div class=\"form-group form-group-icon-left\">\r\n                    <i class=\"fa fa-user input-icon input-icon-show\"></i>\r\n                    <label>");
#nullable restore
#line 50 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                      Write(Localizer["last_name"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <input class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2235, "\"", 2249, 0);
            EndWriteAttribute();
            WriteLiteral(" data-serialize=\"true\" type=\"text\">\r\n                </div>\r\n                <div class=\"form-group form-group-icon-left\">\r\n                    <i class=\"fa fa-envelope input-icon input-icon-show\"></i>\r\n                    <label>");
#nullable restore
#line 55 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                      Write(Localizer["email"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <input class=\"form-control\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2556, "\"", 2570, 0);
            EndWriteAttribute();
            WriteLiteral(" data-serialize=\"true\" type=\"text\">\r\n                </div>\r\n                <div class=\"form-group form-group-icon-left\">\r\n                    <i class=\"fa fa-lock input-icon input-icon-show\"></i>\r\n                    <label>");
#nullable restore
#line 60 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                      Write(Localizer["password"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <label>");
#nullable restore
#line 61 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                      Write(Localizer["password+"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n                    <input class=\"form-control\" type=\"password\" data-serialize=\"true\"");
            BeginWriteAttribute("placeholder", " placeholder=\"", 2974, "\"", 2988, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                </div>\r\n                <input class=\"btn btn-primary\" type=\"button\" id=\"registerBtn\"");
            BeginWriteAttribute("value", " value=\"", 3093, "\"", 3123, 1);
#nullable restore
#line 64 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
WriteAttributeValue("", 3101, Localizer["register"], 3101, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"gap\"></div>\r\n\r\n\r\n");
            DefineSection("scripts", async() => {
                WriteLiteral(@"

    <script>


        $(function () {

            $(""#loginBtn"").click(function (e) {
                e.preventDefault();
                var result = FormCreateSerializer(""login-form"");

                obj = new Object();
                obj.Email = result.Email;
                obj.Password = result.Password;
                $.ajax({
                    type: ""POST"",
                    url: ""/Werenda/LoginUserAsync"",
                    contentType: 'application/json', 
                    data: JSON.stringify(obj),
                    success: function (e) {
                        if (e == true) {
                            swal(""");
#nullable restore
#line 93 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                             Write(Localizer["success"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"");
#nullable restore
#line 93 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                                                      Write(Localizer["email_success"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"success\")\r\n                            setTimeout(function () {\r\n                                location.href = \"/\";\r\n                            }, 1200)\r\n                        } else {\r\n                            swal(\"");
#nullable restore
#line 98 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                             Write(Localizer["error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"");
#nullable restore
#line 98 "C:\Users\tayfu\source\repos\WERENDA\UI\Views\Werenda\Login.cshtml"
                                                    Write(Localizer["email_error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\", \"error\")\r\n                        }\r\n                    }\r\n                });\r\n            });\r\n\r\n\r\n            $(\"#registerBtn\").click(function () {\r\n\r\n\r\n            });\r\n\r\n        });\r\n\r\n\r\n    </script>\r\n\r\n\r\n\r\n");
            }
            );
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public Microsoft.AspNetCore.Antiforgery.IAntiforgery Xsrf { get; private set; }
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
