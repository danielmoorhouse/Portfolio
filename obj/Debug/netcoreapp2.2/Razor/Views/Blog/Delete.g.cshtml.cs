#pragma checksum "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "35ef899ce66f452874d0322017c9dcca108ebc16"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blog_Delete), @"mvc.1.0.view", @"/Views/Blog/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Blog/Delete.cshtml", typeof(AspNetCore.Views_Blog_Delete))]
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
#line 1 "/home/daniel/ASPProjects/danielmoorhouse/Views/_ViewImports.cshtml"
using danielmoorhouse;

#line default
#line hidden
#line 2 "/home/daniel/ASPProjects/danielmoorhouse/Views/_ViewImports.cshtml"
using danielmoorhouse.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35ef899ce66f452874d0322017c9dcca108ebc16", @"/Views/Blog/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d26f479516f9b93df6301e35cebe72ce90a5c1f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Blog_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<danielmoorhouse.Data.BlogPost>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(38, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(67, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(96, 101, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35ef899ce66f452874d0322017c9dcca108ebc164953", async() => {
                BeginContext(102, 88, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Delete</title>\r\n");
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
            BeginContext(197, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(199, 1989, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35ef899ce66f452874d0322017c9dcca108ebc166210", async() => {
                BeginContext(205, 159, true);
                WriteLiteral("\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>BlogPost</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n     \r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(365, 46, false);
#line 23 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
                EndContext();
                BeginContext(411, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(455, 42, false);
#line 26 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayFor(model => model.CategoryId));

#line default
#line hidden
                EndContext();
                BeginContext(497, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(541, 41, false);
#line 29 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
                EndContext();
                BeginContext(582, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(626, 37, false);
#line 32 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
                EndContext();
                BeginContext(663, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(707, 44, false);
#line 35 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PostedOn));

#line default
#line hidden
                EndContext();
                BeginContext(751, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(795, 40, false);
#line 38 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayFor(model => model.PostedOn));

#line default
#line hidden
                EndContext();
                BeginContext(835, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(879, 49, false);
#line 41 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.P1BlogContent));

#line default
#line hidden
                EndContext();
                BeginContext(928, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(972, 45, false);
#line 44 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayFor(model => model.P1BlogContent));

#line default
#line hidden
                EndContext();
                BeginContext(1017, 46, true);
                WriteLiteral("\r\n        </dd>\r\n           <dt>\r\n            ");
                EndContext();
                BeginContext(1064, 49, false);
#line 47 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.P2BlogContent));

#line default
#line hidden
                EndContext();
                BeginContext(1113, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1157, 45, false);
#line 50 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayFor(model => model.P2BlogContent));

#line default
#line hidden
                EndContext();
                BeginContext(1202, 46, true);
                WriteLiteral("\r\n        </dd>\r\n           <dt>\r\n            ");
                EndContext();
                BeginContext(1249, 49, false);
#line 53 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.P3BlogContent));

#line default
#line hidden
                EndContext();
                BeginContext(1298, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1342, 45, false);
#line 56 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayFor(model => model.P3BlogContent));

#line default
#line hidden
                EndContext();
                BeginContext(1387, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1431, 46, false);
#line 59 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.P1ImageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1477, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1521, 42, false);
#line 62 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayFor(model => model.P1ImageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1563, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1607, 46, false);
#line 65 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.P2ImageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1653, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1697, 42, false);
#line 68 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayFor(model => model.P2ImageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1739, 46, true);
                WriteLiteral("\r\n        </dd>\r\n           <dt>\r\n            ");
                EndContext();
                BeginContext(1786, 46, false);
#line 71 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.P3ImageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1832, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1876, 42, false);
#line 74 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
       Write(Html.DisplayFor(model => model.P3ImageUrl));

#line default
#line hidden
                EndContext();
                BeginContext(1918, 46, true);
                WriteLiteral("\r\n        </dd>\r\n      \r\n    </dl>\r\n    \r\n    ");
                EndContext();
                BeginContext(1964, 207, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35ef899ce66f452874d0322017c9dcca108ebc1613988", async() => {
                    BeginContext(1990, 10, true);
                    WriteLiteral("\r\n        ");
                    EndContext();
                    BeginContext(2000, 36, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "35ef899ce66f452874d0322017c9dcca108ebc1614396", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 80 "/home/daniel/ASPProjects/danielmoorhouse/Views/Blog/Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                    __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(2036, 84, true);
                    WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                    EndContext();
                    BeginContext(2120, 38, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "35ef899ce66f452874d0322017c9dcca108ebc1616344", async() => {
                        BeginContext(2142, 12, true);
                        WriteLiteral("Back to List");
                        EndContext();
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
                    EndContext();
                    BeginContext(2158, 6, true);
                    WriteLiteral("\r\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2171, 10, true);
                WriteLiteral("\r\n</div>\r\n");
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
            BeginContext(2188, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<danielmoorhouse.Data.BlogPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
