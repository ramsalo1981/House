#pragma checksum "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0f6eec13ec582bb6bde19dbe5449fd836663ae48"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Apartments_Details), @"mvc.1.0.view", @"/Views/Apartments/Details.cshtml")]
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
#line 1 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\_ViewImports.cshtml"
using HousingQueueWebApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\_ViewImports.cshtml"
using HousingQueueWebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0f6eec13ec582bb6bde19dbe5449fd836663ae48", @"/Views/Apartments/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2fd0f6e4e701826ba096e5a1ae3d73befaa98eee", @"/Views/_ViewImports.cshtml")]
    public class Views_Apartments_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Repository.Models.Apartment>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Apartment</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 14 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Floor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 17 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Floor));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 20 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.HasElevator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 23 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
       Write(Html.DisplayFor(model => model.HasElevator));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 26 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 29 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 32 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.LivingArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 35 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
       Write(Html.DisplayFor(model => model.LivingArea));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 38 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.MonthlyCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 41 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
       Write(Html.DisplayFor(model => model.MonthlyCost));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 46 "C:\Users\ramis\Desktop\tuc\programering c# fördjubning\lektioner\HousingQueue v6\HousingQueueWebApp\Views\Apartments\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0f6eec13ec582bb6bde19dbe5449fd836663ae488072", async() => {
                WriteLiteral("Back to List");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Repository.Models.Apartment> Html { get; private set; }
    }
}
#pragma warning restore 1591
