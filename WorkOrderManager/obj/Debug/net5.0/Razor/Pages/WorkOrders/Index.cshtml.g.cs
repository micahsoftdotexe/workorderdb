#pragma checksum "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "23cfa6ac607439f67f8bded4b06fc4a4332509c6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WorkOrderManager.Pages.WorkOrders.Pages_WorkOrders_Index), @"mvc.1.0.razor-page", @"/Pages/WorkOrders/Index.cshtml")]
namespace WorkOrderManager.Pages.WorkOrders
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
#line 1 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/_ViewImports.cshtml"
using WorkOrderManager;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23cfa6ac607439f67f8bded4b06fc4a4332509c6", @"/Pages/WorkOrders/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"38a36ba92a3edacf34e246e58f2eb6236c80801d", @"/Pages/_ViewImports.cshtml")]
    public class Pages_WorkOrders_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 4 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23cfa6ac607439f67f8bded4b06fc4a4332509c64406", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkOrder[0].Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkOrder[0].Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkOrder[0].Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkOrder[0].WorkOrderNotes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkOrder[0].AmountPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkOrder[0].PaidInFull));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkOrder[0].Automobile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayNameFor(model => model.WorkOrder[0].Customer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 44 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
 foreach (var item in Model.WorkOrder) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Subtotal));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Tax));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.WorkOrderNotes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 59 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.AmountPaid));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 62 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.PaidInFull));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 65 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Automobile.Make));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 68 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Customer.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23cfa6ac607439f67f8bded4b06fc4a4332509c611348", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 71 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
                                       WriteLiteral(item.WorkOrderId);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23cfa6ac607439f67f8bded4b06fc4a4332509c613508", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 72 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
                                          WriteLiteral(item.WorkOrderId);

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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "23cfa6ac607439f67f8bded4b06fc4a4332509c615674", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 73 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
                                         WriteLiteral(item.WorkOrderId);

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
#line 76 "/home/micaht/college_work/DB/workorder/workorderdb/WorkOrderManager/Pages/WorkOrders/Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WorkOrderManager.Pages.WorkOrders.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WorkOrderManager.Pages.WorkOrders.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<WorkOrderManager.Pages.WorkOrders.IndexModel>)PageContext?.ViewData;
        public WorkOrderManager.Pages.WorkOrders.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
