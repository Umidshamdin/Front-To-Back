#pragma checksum "C:\Users\Umid\Desktop\FrontBackend\AspIntro\AspIntro\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d6c218442dfc0fc74ee0581eab683db2f076db6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Login_Index), @"mvc.1.0.view", @"/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d6c218442dfc0fc74ee0581eab683db2f076db6", @"/Views/Login/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a9af4978b9c2bfca24ef48e96efe5f8573634464", @"/Views/_ViewImports.cshtml")]
    public class Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Umid\Desktop\FrontBackend\AspIntro\AspIntro\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<main>
    <section id=""login"">
        <div class=""container"">
            <div class=""row"">
                <div class=""login-all d-flex"">
                    <div class=""login"">
                        <h5>Login</h5>
                        <label");
            BeginWriteAttribute("for", " for=\"", 302, "\"", 308, 0);
            EndWriteAttribute();
            WriteLiteral(">Username or email address *</label><br>\r\n                        <input class=\"form-control\" type=\"text\"><br>\r\n                        <label");
            BeginWriteAttribute("for", " for=\"", 451, "\"", 457, 0);
            EndWriteAttribute();
            WriteLiteral(@">Password *</label><br>
                        <input class=""form-control"" type=""text""><br>
                        <input style=""cursor: pointer;"" type=""checkbox"">Remember me <br><br>

                        <input class=""submit"" type=""submit"" value=""Log In""><br><br>
                        <a");
            BeginWriteAttribute("href", " href=\"", 760, "\"", 767, 0);
            EndWriteAttribute();
            WriteLiteral(">Lost your password</a>\r\n                    </div>\r\n                    <div class=\"register\">\r\n                        <h5>Register</h5>\r\n                        <label");
            BeginWriteAttribute("for", " for=\"", 938, "\"", 944, 0);
            EndWriteAttribute();
            WriteLiteral(">Email address *</label><br>\r\n                        <input class=\"form-control\" type=\"text\"><br>\r\n                        <label");
            BeginWriteAttribute("for", " for=\"", 1075, "\"", 1081, 0);
            EndWriteAttribute();
            WriteLiteral(@">Password *</label><br>
                        <input class=""form-control"" type=""text""><br>

                        <p>
                            Your personal data will be used to support your experience throughout this website, to
                            manage access to your account, and for other purposes described in our <a style=""color: red;""");
            BeginWriteAttribute("href", "\r\n                                                                                                      href=\"", 1445, "\"", 1555, 0);
            EndWriteAttribute();
            WriteLiteral(@">privacy policy.</a>
                        </p>

                        <input class=""submit"" type=""submit"" value=""Register""><br><br>

                    </div>
                </div>
            </div>
        </div>
    </section>
</main>
");
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
