#pragma checksum "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\Home\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f373ab5f3b4ede40964b6c02fd58962296cae98"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Profile), @"mvc.1.0.view", @"/Views/Home/Profile.cshtml")]
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
#line 1 "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\_ViewImports.cshtml"
using AdditionBonusTask;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\_ViewImports.cshtml"
using AdditionBonusTask.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\Home\Profile.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\Home\Profile.cshtml"
using AdditionBonusTask.Areas.Identity.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f373ab5f3b4ede40964b6c02fd58962296cae98", @"/Views/Home/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3e05e5fa980dc9ee396195fb5670e9fe14747bd3", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Manage/Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("title", new global::Microsoft.AspNetCore.Html.HtmlString("Manage"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("text-decoration:none; font-size:19px;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\Home\Profile.cshtml"
  
    ViewData["Title"] = "Messages";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n");
            WriteLiteral("\r\n\r\n<div class=\"profile\">\r\n    <div class=\"card profile\">\r\n        <div class=\"row mt-2\">\r\n            <div class=\"col-3\">\r\n                <img src=\"https://image.freepik.com/free-vector/businessman-character-avatar-isolated_24877-60111.jpg\"");
            BeginWriteAttribute("alt", "  alt=\"", 480, "\"", 487, 0);
            EndWriteAttribute();
            WriteLiteral(" class=\"profile__image\" style=\" padding-left: 5%;\r\nwidth: 150px; border-radius:5px; object-fit: contain;\" />\r\n            </div>\r\n            <div class=\"col-8\">\r\n                <h3 class=\"profile__fullname\">");
#nullable restore
#line 21 "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\Home\Profile.cshtml"
                                         Write(UserManager.GetUserAsync(User).Result.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ");
#nullable restore
#line 21 "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\Home\Profile.cshtml"
                                                                                          Write(UserManager.GetUserAsync(User).Result.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                <h5>Email: ");
#nullable restore
#line 22 "C:\Users\YERLAN-PC\source\repos\AdditionBonusTask\Views\Home\Profile.cshtml"
                      Write(UserManager.GetUserAsync(User).Result.Email);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h5>\r\n                \r\n                <div style=\"display:flex; align-items:center;\" class=\"row\">\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f373ab5f3b4ede40964b6c02fd58962296cae987757", async() => {
                WriteLiteral("\r\n                        <i class=\"fas fa-edit\" style=\"font-size:20px\"></i>\r\n                        Edit profile\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        \r\n");
            WriteLiteral(@"                </div>

            </div>
        </div>
        <hr />

        <hr />

        <div class=""messageSender"">
            <div class=""messageSender__top"">
                <img src=""https://image.freepik.com/free-vector/businessman-character-avatar-isolated_24877-60111.jpg"" class=""post__avatar"" />
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7f373ab5f3b4ede40964b6c02fd58962296cae989991", async() => {
                WriteLiteral(@"
                    <input class=""messageSender__input""
                           placeholder=""Whats up?"" />
                    <input placeholder=""Image URL Optional"" />
                    <button type=""submit"">
                        Hidden submit
                    </button>
                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""messageSender__bottom"">

                <div class=""messageSender__option"">
                    <i class=""fas fa-photo-video"" style=""font-size:30px; color:green""></i>
                    <h3>Photo/Gif</h3>
                </div>

                <div class=""messageSender__option"">
                    <i class=""far fa-smile"" style=""font-size:30px; color:orange""></i>
                    <h3>Feeling/Activity</h3>
                </div>
            </div>
        </div>

        <div class=""post"">
            <div class=""post__top"">
                <img src=""https://image.freepik.com/free-vector/businessman-character-avatar-isolated_24877-60111.jpg"" class=""post__avatar"" />

                <div class=""post__topInfo"">
                    <h3>Username</h3>
");
            WriteLiteral(@"                    <p>Date</p>
                </div>
            </div>

            <div class=""post__bottom"">
                <p>Its message</p>
            </div>

            <div class=""post__image"">
                <img src=""https://static10.tgstat.ru/channels/_0/66/66de8dadec5fa9d4dbcc0a4beb1cfcf5.jpg""");
            BeginWriteAttribute("alt", " alt=\"", 3445, "\"", 3451, 0);
            EndWriteAttribute();
            WriteLiteral(@" />
            </div>

            <div class=""post__options"">
                <div class=""post__option"">
                    <i class=""fas fa-thumbs-up"" style=""font-size:35px""></i>
                    <p>Like</p>
                </div>

                <div class=""post__option"">
                    <i class=""far fa-comment-dots"" style=""font-size:35px""></i>
                    <p>Comment</p>
                </div>

            </div>
        </div>
    </div>

</div>");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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
