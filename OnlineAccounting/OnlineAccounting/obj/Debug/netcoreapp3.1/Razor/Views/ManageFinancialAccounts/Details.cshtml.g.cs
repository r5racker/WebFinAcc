#pragma checksum "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aebd7a8e4fd2d68e1b9cbcd02a3f8de054ded481"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ManageFinancialAccounts_Details), @"mvc.1.0.view", @"/Views/ManageFinancialAccounts/Details.cshtml")]
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
#line 1 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\_ViewImports.cshtml"
using OnlineAccounting;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\_ViewImports.cshtml"
using OnlineAccounting.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\_ViewImports.cshtml"
using OnlineAccounting.Models.User;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aebd7a8e4fd2d68e1b9cbcd02a3f8de054ded481", @"/Views/ManageFinancialAccounts/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8d48ecfb006b171ffe5997b8873f6cb1879d1952", @"/Views/_ViewImports.cshtml")]
    public class Views_ManageFinancialAccounts_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OnlineAccounting.Models.FinancialAccount>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Detail</h1>\r\n\r\n<div>\r\n    <h4>Financial Account</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 15 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 18 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 21 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 24 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.Type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class=\"col-sm-2\">\r\n            ");
#nullable restore
#line 27 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.AccountCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class=\"col-sm-10\">\r\n            ");
#nullable restore
#line 30 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
       Write(Html.DisplayFor(model => model.AccountCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n\r\n    <h4>Ledger Entry</h4>\r\n\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    ");
#nullable restore
#line 40 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.LedgerEntries[0].Account));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 43 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.LedgerEntries[0].TargetAccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 46 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.LedgerEntries[0].type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 49 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.LedgerEntries[0].Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 52 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.LedgerEntries[0].Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
#nullable restore
#line 55 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.LedgerEntries[0].Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 61 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
             foreach (var item in Model.LedgerEntries)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 65 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Account.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 68 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.TargetAccountId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 71 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.type));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 74 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Amount));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 77 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 80 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 83 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n</div>\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aebd7a8e4fd2d68e1b9cbcd02a3f8de054ded48112099", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 89 "C:\Users\RAHIL\source\repos\OnlineAccounting\OnlineAccounting\Views\ManageFinancialAccounts\Details.cshtml"
                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aebd7a8e4fd2d68e1b9cbcd02a3f8de054ded48114269", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OnlineAccounting.Models.FinancialAccount> Html { get; private set; }
    }
}
#pragma warning restore 1591
