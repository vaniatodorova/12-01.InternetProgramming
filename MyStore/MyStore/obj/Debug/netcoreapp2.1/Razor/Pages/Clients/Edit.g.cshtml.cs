#pragma checksum "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b22ef9507439664ec2e068afd81c64ea35561daf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(MyStore.Pages.Clients.Pages_Clients_Edit), @"mvc.1.0.razor-page", @"/Pages/Clients/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Clients/Edit.cshtml", typeof(MyStore.Pages.Clients.Pages_Clients_Edit), null)]
namespace MyStore.Pages.Clients
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\_ViewImports.cshtml"
using MyStore;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b22ef9507439664ec2e068afd81c64ea35561daf", @"/Pages/Clients/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1f20bcdfab133b6ecc62fd859baf09c01713465", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Clients_Edit : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(54, 32, true);
            WriteLiteral("\r\n<br>\r\n<h2>Edit Client</h2>\r\n\r\n");
            EndContext();
#line 9 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml"
 if (Model.errorMessage.Length > 0)
{

#line default
#line hidden
            BeginContext(126, 96, true);
            WriteLiteral("    <div class=\'alert alert-warning alert-dismissible fade show\' role=\'alert\'>\r\n        <strong>");
            EndContext();
            BeginContext(223, 18, false);
#line 12 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml"
           Write(Model.errorMessage);

#line default
#line hidden
            EndContext();
            BeginContext(241, 125, true);
            WriteLiteral("</strong>\r\n        <button type=\'button\' class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'Close\'></button>\r\n    </div>\r\n");
            EndContext();
#line 15 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml"
}

#line default
#line hidden
            BeginContext(369, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(371, 1870, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c15c4c2f8a6d4dfa9147bbb855e4c253", async() => {
                BeginContext(391, 36, true);
                WriteLiteral("\r\n    <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 427, "\"", 455, 1);
#line 18 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 435, Model.clientInfo.id, 435, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(456, 187, true);
                WriteLiteral(">\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Name</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"name\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 643, "\"", 673, 1);
#line 22 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 651, Model.clientInfo.name, 651, 22, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(674, 217, true);
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Email</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"email\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 891, "\"", 922, 1);
#line 28 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 899, Model.clientInfo.email, 899, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(923, 217, true);
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Phone</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"phone\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1140, "\"", 1171, 1);
#line 34 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 1148, Model.clientInfo.phone, 1148, 23, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1172, 221, true);
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n    <div class=\"row mb-3\">\r\n        <label class=\"col-sm-3 col-form-label\">Address</label>\r\n        <div class=\"col-sm-6\">\r\n            <input type=\"text\" class=\"form-control\" name=\"address\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 1393, "\"", 1426, 1);
#line 40 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml"
WriteAttributeValue("", 1401, Model.clientInfo.address, 1401, 25, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(1427, 31, true);
                WriteLiteral(">\r\n        </div>\r\n    </div>\r\n");
                EndContext();
#line 43 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml"
     if (Model.successMessage.Length > 0)
    {

#line default
#line hidden
                BeginContext(1508, 189, true);
                WriteLiteral("        <div class=\"row  mb-3\">\r\n            <div class=\"col-sm-9\">\r\n                <div class=\'alert alert-success alert-dismissible fade show\' role=\'alert\'>\r\n                    <strong>");
                EndContext();
                BeginContext(1698, 20, false);
#line 48 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml"
                       Write(Model.successMessage);

#line default
#line hidden
                EndContext();
                BeginContext(1718, 190, true);
                WriteLiteral("</strong>\r\n                    <button type=\'button\' class=\'btn-close\' data-bs-dismiss=\'alert\' aria-label=\'Close\'>Close</button>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
                EndContext();
#line 53 "G:\.Vania12a#4\01.InternetProgramming\MyStore\MyStore\Pages\Clients\Edit.cshtml"
    }

#line default
#line hidden
                BeginContext(1915, 319, true);
                WriteLiteral(@"    <div class=""row mb-3"">
        <div class=""offset-sm-3 col-sm-3 d-grid"">
            <button type=""submit"" class=""btn btn-primary"">Submit</button>
        </div>
        <div class=""col-sm-3 d-grid"">
            <a class=""btn btn-outline-primary"" href=""/"" role=""button"">Cancel</a>
        </div>
    </div>
");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MyStore.Pages.Clients.EditModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyStore.Pages.Clients.EditModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MyStore.Pages.Clients.EditModel>)PageContext?.ViewData;
        public MyStore.Pages.Clients.EditModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
