#pragma checksum "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9868a7cb0402c02d61c420268aa53590025777c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vehicles_Index), @"mvc.1.0.view", @"/Views/Vehicles/Index.cshtml")]
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
#line 1 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\_ViewImports.cshtml"
using AutoMarkt;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\_ViewImports.cshtml"
using AutoMarkt.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9868a7cb0402c02d61c420268aa53590025777c6", @"/Views/Vehicles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a2d0bcc3bada7bf25ad69453909f287fe283625c", @"/Views/_ViewImports.cshtml")]
    public class Views_Vehicles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AutoMarkt.Models.Vehicle>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Approve", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9868a7cb0402c02d61c420268aa53590025777c64556", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                Picture\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 19 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 22 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Colour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 25 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.cc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 28 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 31 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EnginePower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 34 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 37 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Fuel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 40 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.ChassisNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 43 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Approved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 57 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1520, "\"", 1565, 1);
#nullable restore
#line 60 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
WriteAttributeValue("", 1526, Html.DisplayFor(modelItem => item.pic), 1526, 39, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"25\" width=\"25\" alt=\"noImage\" />\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 63 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 66 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Colour));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 69 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.cc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 72 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 75 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EnginePower));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 78 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 81 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Fuel));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 84 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.ChassisNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 87 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
#nullable restore
#line 91 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.EmployeeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 94 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Approved));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9868a7cb0402c02d61c420268aa53590025777c613586", async() => {
                WriteLiteral("Approve");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 98 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
                                       WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9868a7cb0402c02d61c420268aa53590025777c615751", async() => {
                WriteLiteral("Approve_secondary button");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 99 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
                                          WriteLiteral(item.Id);

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
            WriteLiteral(" |\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9868a7cb0402c02d61c420268aa53590025777c617936", async() => {
                WriteLiteral("Decline");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 100 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
                                         WriteLiteral(item.Id);

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
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 103 "C:\Users\Filip\source\repos\AutoMarkt\AutoMarkt\Views\Vehicles\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AutoMarkt.Models.Vehicle>> Html { get; private set; }
    }
}
#pragma warning restore 1591
