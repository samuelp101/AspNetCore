#pragma checksum "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "206803c2a43bcd37e41ab908d14e88b102d6c05d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Delete), @"mvc.1.0.view", @"/Views/Customers/Delete.cshtml")]
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
#line 1 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\_ViewImports.cshtml"
using NorthwindMVC.DBFirst;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\_ViewImports.cshtml"
using NorthwindMVC.DBFirst.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"206803c2a43bcd37e41ab908d14e88b102d6c05d", @"/Views/Customers/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7dcfd64a7e9b16228a9352358fa666794573413e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Customers_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<NorthwindMVC.DBFirst.Models.Customer>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Customer</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CompanyName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ContactName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ContactTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ContactTitle));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 52 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 55 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 58 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 61 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 64 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 67 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Phone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 70 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Fax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 73 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Fax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "206803c2a43bcd37e41ab908d14e88b102d6c05d11981", async() => {
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "206803c2a43bcd37e41ab908d14e88b102d6c05d12248", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 78 "E:\GitHub.Samuelp101\AspNetCore\src\Northwind.Projects\NorthwindMVC.DBFirst\Views\Customers\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.CustomerId);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "206803c2a43bcd37e41ab908d14e88b102d6c05d14069", async() => {
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
                WriteLiteral("\r\n    ");
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
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<NorthwindMVC.DBFirst.Models.Customer> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
