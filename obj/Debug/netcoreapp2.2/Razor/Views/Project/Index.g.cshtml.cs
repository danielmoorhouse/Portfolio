#pragma checksum "/home/daniel/ASPProjects/danielmoorhouse/Views/Project/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23209a6b0ffa0b9e4abeed30a38e0fca8031350c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Project_Index), @"mvc.1.0.view", @"/Views/Project/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Project/Index.cshtml", typeof(AspNetCore.Views_Project_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23209a6b0ffa0b9e4abeed30a38e0fca8031350c", @"/Views/Project/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d26f479516f9b93df6301e35cebe72ce90a5c1f0", @"/Views/_ViewImports.cshtml")]
    public class Views_Project_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<danielmoorhouse.Data.Projects>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(51, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/home/daniel/ASPProjects/danielmoorhouse/Views/Project/Index.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(80, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(109, 100, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23209a6b0ffa0b9e4abeed30a38e0fca8031350c3981", async() => {
                BeginContext(115, 87, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Index</title>\r\n");
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
            BeginContext(209, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(211, 480, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23209a6b0ffa0b9e4abeed30a38e0fca8031350c5236", async() => {
                BeginContext(217, 11, true);
                WriteLiteral("\r\n<p>\r\n    ");
                EndContext();
                BeginContext(228, 37, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23209a6b0ffa0b9e4abeed30a38e0fca8031350c5624", async() => {
                    BeginContext(251, 10, true);
                    WriteLiteral("Create New");
                    EndContext();
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
                EndContext();
                BeginContext(265, 78, true);
                WriteLiteral("\r\n</p>\r\n<div class=\"container-fluid body-content3\">\r\n    <div class=\"row\">\r\n\r\n");
                EndContext();
#line 21 "/home/daniel/ASPProjects/danielmoorhouse/Views/Project/Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
                BeginContext(375, 58, true);
                WriteLiteral("       <div class=\"col-md-4 text-center\">\r\n           <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 433, "\"", 452, 1);
#line 23 "/home/daniel/ASPProjects/danielmoorhouse/Views/Project/Index.cshtml"
WriteAttributeValue("", 439, item.PImage1, 439, 13, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(453, 43, true);
                WriteLiteral(" style=\"width: 100%;\" />\r\n             <h4>");
                EndContext();
                BeginContext(497, 10, false);
#line 24 "/home/daniel/ASPProjects/danielmoorhouse/Views/Project/Index.cshtml"
            Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(507, 26, true);
                WriteLiteral("</h4>  \r\n             <h4>");
                EndContext();
                BeginContext(534, 11, false);
#line 25 "/home/daniel/ASPProjects/danielmoorhouse/Views/Project/Index.cshtml"
            Write(item.Status);

#line default
#line hidden
                EndContext();
                BeginContext(545, 104, true);
                WriteLiteral("</h4> \r\n          \r\n          \r\n           \r\n                \r\n          \r\n               \r\n    </div>\r\n");
                EndContext();
#line 33 "/home/daniel/ASPProjects/danielmoorhouse/Views/Project/Index.cshtml"
}

#line default
#line hidden
                BeginContext(652, 32, true);
                WriteLiteral("        \r\n    </div>\r\n</div>\r\n\r\n");
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
            BeginContext(691, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<danielmoorhouse.Data.Projects>> Html { get; private set; }
    }
}
#pragma warning restore 1591
