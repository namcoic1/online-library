#pragma checksum "E:\C#\Base-C#\PRN_Project_Self_Summer2022\LMS_Project\Views\Index\Reg_Log.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6f27946485be20b6c237dcc1e3f69db03dca035"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Index_Reg_Log), @"mvc.1.0.view", @"/Views/Index/Reg_Log.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6f27946485be20b6c237dcc1e3f69db03dca035", @"/Views/Index/Reg_Log.cshtml")]
    #nullable restore
    public class Views_Index_Reg_Log : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <!DOCTYPE html>\r\n    <html lang=\"en\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f27946485be20b6c237dcc1e3f69db03dca0352790", async() => {
                WriteLiteral(@"
        <meta charset=""UTF-8"" />
        <meta http-equiv=""X-UA-Compatible"" content=""IE=edge"" />
        <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"" />
        <title>Register/Login</title>
        <link rel=""stylesheet""
              href=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/css/bootstrap.min.css""
              integrity=""sha384-Gn5384xqQ1aoWXA+058RXPxPg6fy4IWvTNh0E263XmFcJlSAwiGgFAW/dAiS6JXm""
              crossorigin=""anonymous"" />
        <link rel=""stylesheet""
              href=""https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.1.1/css/all.min.css""
              integrity=""sha512-KfkfwYDsLkIlwQp6LFnl8zNdLGxu9YAA1QvwINks4PhcElQSvqcyVLLD9aMhXd13uQjoXtEKNosOWaZqXgel0g==""
              crossorigin=""anonymous""
              referrerpolicy=""no-referrer"" />
        <link href=""https://fonts.googleapis.com/css2?family=Jost:wght@500&display=swap""
              rel=""stylesheet"" />
        <style>
            body {
                margin: 0;
        ");
                WriteLiteral(@"        padding: 0;
                display: flex;
                justify-content: center;
                align-items: center;
                /* min-height: 100vh; */
                font-family: ""Jost"", sans-serif;
                background: linear-gradient(to bottom, #0f0c29, #302b63, #24243e);
            }

            .main {
                width: 500px;
                height: 850px;
                background: red;
                overflow: hidden;
                background: url(""https://doc-08-2c-docs.googleusercontent.com/docs/securesc/68c90smiglihng9534mvqmq1946dmis5/fo0picsp1nhiucmc0l25s29respgpr4j/1631524275000/03522360960922298374/03522360960922298374/1Sx0jhdpEpnNIydS4rnN4kHSJtU1EyWka?e=view&authuser=0&nonce=gcrocepgbb17m&user=03522360960922298374&hash=tfhgbs86ka6divo3llbvp93mg4csvb38"") no-repeat center/ cover;
                border-radius: 10px;
                box-shadow: 5px 20px 50px #000;
            }

            .signup {
                position: relative;
   ");
                WriteLiteral(@"             width: 100%;
                height: 100%;
            }

            .lab-log {
                color: #fff;
                font-size: 2em;
                justify-content: center;
                display: flex;
                margin: 180px 0 40px 0;
                font-weight: bold;
            }

            .lab-reg {
                color: #fff;
                font-size: 2em;
                justify-content: center;
                display: flex;
                margin: 130px 0 40px 0;
                font-weight: bold;
            }

            input {
                width: 60%;
                height: 20px;
                background: #e0dede;
                justify-content: center;
                display: flex;
                margin: 30px auto;
                padding: 23px;
                border: none;
                outline: none;
                border-radius: 5px;
            }

            button {
                width: 60%;
          ");
                WriteLiteral(@"      height: 40px;
                margin: 0 auto;
                justify-content: center;
                display: block;
                color: #fff;
                background: #573b8a;
                font-size: 1em;
                font-weight: bold;
                margin-top: 20px;
                outline: none;
                border: none;
                border-radius: 5px;
                transition: 0.2s ease-in;
                cursor: pointer;
            }

                button:hover {
                    background: #6d44b8;
                }

            .div-radio {
                color: white;
                margin: 15px 0px 15px 100px;
                font-size: 0.95em;
            }

            .radio {
                height: 17px;
                margin: 5px 0;
            }

            .tran-log {
                color: white;
                margin: 10px 0 39px 100px;
                cursor: pointer;
            }
            .mes {
       ");
                WriteLiteral("         width: 60%;\r\n                background-color: white;\r\n                color: palevioletred;\r\n                margin-left: 100px;\r\n                padding: 2px 5px;\r\n                border-radius: 4px;\r\n            }\r\n        </style>\r\n    ");
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
            WriteLiteral("\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6f27946485be20b6c237dcc1e3f69db03dca0358297", async() => {
                WriteLiteral("\r\n        <div class=\"main\">\r\n\r\n");
#nullable restore
#line 133 "E:\C#\Base-C#\PRN_Project_Self_Summer2022\LMS_Project\Views\Index\Reg_Log.cshtml"
             if (ViewBag.Log != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"signup\">\r\n                    <form action=\"/user/accesslogin\" method=\"post\">\r\n                        <label class=\"lab-log\">Login</label>\r\n");
#nullable restore
#line 138 "E:\C#\Base-C#\PRN_Project_Self_Summer2022\LMS_Project\Views\Index\Reg_Log.cshtml"
                         if (ViewBag.Err != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p class=\"mes\">");
#nullable restore
#line 140 "E:\C#\Base-C#\PRN_Project_Self_Summer2022\LMS_Project\Views\Index\Reg_Log.cshtml"
                                      Write(ViewBag.Err);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 141 "E:\C#\Base-C#\PRN_Project_Self_Summer2022\LMS_Project\Views\Index\Reg_Log.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <input type=""email"" name=""uemail"" placeholder=""Email"" required />
                        <input type=""password"" name=""upass"" placeholder=""Password"" required />
                        <p class=""tran-log"" onclick=""window.location.href='/user/account/reg'"">Create an account?</p>
                        <button type=""submit"">Sign in</button>
                        <button onclick=""window.location.href='/home/index'"">
                            Back to home
                        </button>
                    </form>
                </div>
");
#nullable restore
#line 151 "E:\C#\Base-C#\PRN_Project_Self_Summer2022\LMS_Project\Views\Index\Reg_Log.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 153 "E:\C#\Base-C#\PRN_Project_Self_Summer2022\LMS_Project\Views\Index\Reg_Log.cshtml"
             if (ViewBag.Reg != null)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"signup\">\r\n                    <form action=\"/user/accessregister\" method=\"post\">\r\n                        <label class=\"lab-reg\">Register</label>\r\n");
#nullable restore
#line 158 "E:\C#\Base-C#\PRN_Project_Self_Summer2022\LMS_Project\Views\Index\Reg_Log.cshtml"
                         if (ViewBag.Err != null)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <p class=\"mes\">");
#nullable restore
#line 160 "E:\C#\Base-C#\PRN_Project_Self_Summer2022\LMS_Project\Views\Index\Reg_Log.cshtml"
                                      Write(ViewBag.Err);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n");
#nullable restore
#line 161 "E:\C#\Base-C#\PRN_Project_Self_Summer2022\LMS_Project\Views\Index\Reg_Log.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral(@"                        <input type=""text"" name=""uname"" placeholder=""User name"" required />
                        <input type=""email"" name=""uemail"" placeholder=""Email"" required />
                        <input type=""password"" name=""upass"" placeholder=""Password"" required />
                        <div class=""w-50 d-flex justify-content-center div-radio"">
                            <span>Male</span>
                            <input class=""radio"" type=""radio"" name=""ugender"" value=""1"" checked required />
                            <span>Female</span><input class=""radio"" type=""radio"" name=""ugender"" value=""0"" required />
                        </div>
                        <p class=""tran-log"" onclick=""window.location.href='/user/account/log'"">Have an account?</p>
                        <button type=""submit"">Sign up</button>
                        <button onclick=""window.location.href='/home/index'"">
                            Back to home
                        </button>
                 ");
                WriteLiteral("   </form>\r\n                </div>\r\n");
#nullable restore
#line 177 "E:\C#\Base-C#\PRN_Project_Self_Summer2022\LMS_Project\Views\Index\Reg_Log.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n    ");
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
            WriteLiteral(@"
    <script src=""https://code.jquery.com/jquery-3.2.1.slim.min.js""
            integrity=""sha384-KJ3o2DKtIkvYIK3UENzmM7KCkRr/rE9/Qpg6aAZGJwFDMVNA/GpGFF93hXpG5KkN""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/popper.js@1.12.9/dist/umd/popper.min.js""
            integrity=""sha384-ApNbgh9B+Y1QKtv3Rn7W3mgPxhU9K/ScQsAP7hUibX39j7fakFPskvXusvfa0b4Q""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/bootstrap@4.0.0/dist/js/bootstrap.min.js""
            integrity=""sha384-JZR6Spejh4U02d8jOt6vLEHfe/JQGiRRSQQxSfFWpi1MquVdAyjUar5+76PVCmYl""
            crossorigin=""anonymous""></script>
    <script src=""https://cdn.jsdelivr.net/npm/select2@4.1.0-rc.0/dist/js/select2.min.js""></script>
</html>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
