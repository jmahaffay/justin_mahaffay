#pragma checksum "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d95e1249f6d26a99fe63a1c01c65a4629eb0938b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Author_Edit), @"mvc.1.0.view", @"/Views/Author/Edit.cshtml")]
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
#line 1 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\_ViewImports.cshtml"
using justin_mahaffay;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\_ViewImports.cshtml"
using justin_mahaffay.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d95e1249f6d26a99fe63a1c01c65a4629eb0938b", @"/Views/Author/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e7c0209cde3bf482ba2ea72bcd182c83d88a342", @"/Views/_ViewImports.cshtml")]
    public class Views_Author_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<justin_mahaffay.Models.Author>
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
  
    Layout = null;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d95e1249f6d26a99fe63a1c01c65a4629eb0938b3557", async() => {
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width = device-width\" />\r\n    <title>Edit</title>\r\n");
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
            WriteLiteral("\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d95e1249f6d26a99fe63a1c01c65a4629eb0938b4621", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 15 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
     using (Html.BeginForm())
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
                WriteLiteral("    <div class=\"form-horizontal\">\r\n        <h4>Author</h4>\r\n        <hr />\r\n        ");
#nullable restore
#line 21 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
   Write(Html.ValidationSummary(
           true, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        ");
#nullable restore
#line 24 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
   Write(Html.HiddenFor(model => model.ID));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
       Write(Html.LabelFor(
               model => model.author, htmlAttributes: new
                    {
                  @class = "control-label col-md-2"
                    }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 34 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
           Write(Html.EditorFor(model => model.author, new
                {
                   htmlAttributes = new
                    {
                      @class = "form-control"
                    }
                }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 42 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
           Write(Html.ValidationMessageFor(model => model.author, "", new
                {
                      @class = "text-danger"
                }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 51 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
       Write(Html.LabelFor(
               model => model.time, htmlAttributes: new
                    {
                  @class = "control-label col-md-2"
                    }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 58 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
           Write(Html.EditorFor(
                   model => model.time, new
                        {
                      htmlAttributes = new { @class = "form-control" }
                        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 64 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
           Write(Html.ValidationMessageFor(
                   model => model.time, "", new
                        {
                      @class = "text-danger"
                        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 74 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
       Write(Html.LabelFor(
               model => model.subject, htmlAttributes: new
                    {
                  @class = "control-label col-md-2"
                    }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 81 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
           Write(Html.EditorFor(
                   model => model.subject, new
                        {
                      htmlAttributes = new { @class = "form-control" }
                        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 87 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
           Write(Html.ValidationMessageFor(
                   model => model.subject, "", new
                        {
                      @class = "text-danger"
                        }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n\r\n        </div>\r\n\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 97 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
       Write(Html.LabelFor(
            model => model.body, htmlAttributes: new
            {
            @class = "control-label col-md-2"
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            <div class=\"col-md-10\">\r\n                ");
#nullable restore
#line 104 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
           Write(Html.EditorFor(
                model => model.body, new
                {
                htmlAttributes = new { @class = "form-control" }
                }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                ");
#nullable restore
#line 110 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
           Write(Html.ValidationMessageFor(
                model => model.body, "", new
                {
                @class = "text-danger"
                }));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"
            </div>

        </div>

        <div class=""form-group"">
            <div class=""col-md-offset-2 col-md-10"">
                <input type=""submit"" value=""Save"" class=""btn btn-default"" />
            </div>
        </div>

    </div>
");
#nullable restore
#line 126 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    <div>\r\n        ");
#nullable restore
#line 129 "C:\Users\Justin.Mahaffay\source\repos\justin_mahaffay\justin_mahaffay\Views\Author\Edit.cshtml"
   Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n    </div>\r\n\r\n");
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
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<justin_mahaffay.Models.Author> Html { get; private set; }
    }
}
#pragma warning restore 1591
