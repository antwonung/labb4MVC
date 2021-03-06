#pragma checksum "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3ea8e85f3ad0e0a2f008484ee3ccd177534cdbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customer_CustomerList), @"mvc.1.0.view", @"/Views/Customer/CustomerList.cshtml")]
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
#line 1 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\_ViewImports.cshtml"
using BookStore_MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\_ViewImports.cshtml"
using BookStore_MVC.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\_ViewImports.cshtml"
using BookStore_MVC.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3ea8e85f3ad0e0a2f008484ee3ccd177534cdbe", @"/Views/Customer/CustomerList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c2a213ef2d80db085f056f2c3c1e775ef75c30a", @"/Views/_ViewImports.cshtml")]
    public class Views_Customer_CustomerList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Customer", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<table class=\"table white-text-color bigger-p\">\r\n  <thead>\r\n    <tr>\r\n      <th class=\"col-md-4\" scope=\"col\">");
#nullable restore
#line 6 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
                                  Write(Html.DisplayNameFor(model => model.customerViewMdl.FirstOrDefault().CustomerId));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th class=\"col-md-5\" scope=\"col\">");
#nullable restore
#line 7 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
                                  Write(Html.DisplayNameFor(model => model.customerViewMdl.FirstOrDefault().FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th class=\"col-md-4\" scope=\"col\">");
#nullable restore
#line 8 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
                                  Write(Html.DisplayNameFor(model => model.customerViewMdl.FirstOrDefault().LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n      <th class=\"col-md-4\" scope=\"col\">");
#nullable restore
#line 9 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
                                  Write(Html.DisplayNameFor(model => model.customerViewMdl.FirstOrDefault().PhoneNumber));

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n    </tr>\r\n  </thead>\r\n  <tbody>\r\n");
#nullable restore
#line 13 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
       foreach(var customer in Model.customerViewMdl)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("         <tr>\r\n            <td>");
#nullable restore
#line 16 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
           Write(customer.CustomerId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
           Write(customer.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
           Write(customer.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
           Write(customer.PhoneNumber);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
           Write(Html.ActionLink("Edit","Edit",new {id=customer.CustomerId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 21 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
           Write(Html.ActionLink("Delete","DeleteCustomer",new {id=customer.CustomerId}));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 22 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
           Write(Html.ActionLink("Customers books","CustomersBooks","CustomerBook",new {id=customer.CustomerId}, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 24 "C:\Users\sjobe\source\repos\BookStore-MVC\BookStore-MVC\Views\Customer\CustomerList.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n  \r\n    </tbody>\r\n</table>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3ea8e85f3ad0e0a2f008484ee3ccd177534cdbe8226", async() => {
                WriteLiteral("Get back");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
