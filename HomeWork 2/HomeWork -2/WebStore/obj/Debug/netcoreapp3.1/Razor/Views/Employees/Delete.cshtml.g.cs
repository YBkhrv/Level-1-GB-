#pragma checksum "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49ef77470c4600e0e72670d02fb1ce799fc90516"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employees_Delete), @"mvc.1.0.view", @"/Views/Employees/Delete.cshtml")]
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
#line 1 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\_ViewImports.cshtml"
using WebStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\_ViewImports.cshtml"
using WebStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49ef77470c4600e0e72670d02fb1ce799fc90516", @"/Views/Employees/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"accc1dbc8201cb0af06ec1dd58486bc3bb35b91e", @"/Views/_ViewImports.cshtml")]
    public class Views_Employees_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebStore.Models.Employee>
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
            WriteLiteral("\n");
#nullable restore
#line 3 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
#nullable disable
            WriteLiteral("\n<div class=\"container\">\n    <h1>Delete</h1>\n\n    <h3>Are you sure you want to delete this?</h3>\n    <div>\n        <h4>Employee</h4>\n        <hr/>\n        <dl class=\"row\">\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 16 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 19 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.LastName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 22 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 25 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.FirstName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 28 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 31 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 34 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.TitleOfCourtesy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 37 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.TitleOfCourtesy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 40 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 43 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.BirthDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 46 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 49 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.HireDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 52 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 55 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Address));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 58 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 61 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.City));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 64 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 67 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Region));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 70 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 73 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PostalCode));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 76 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 79 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 82 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.HomePhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 85 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.HomePhone));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 88 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Extension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 91 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Extension));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 94 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 97 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Photo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 100 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 103 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.Notes));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 106 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.ReportsTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 109 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.ReportsTo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n            <dt class=\"col-sm-2\">\n                ");
#nullable restore
#line 112 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.PhotoPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dt>\n            <dd class=\"col-sm-10\">\n                ");
#nullable restore
#line 115 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
           Write(Html.DisplayFor(model => model.PhotoPath));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n            </dd>\n        </dl>\n\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ef77470c4600e0e72670d02fb1ce799fc9051620639", async() => {
                WriteLiteral("\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "49ef77470c4600e0e72670d02fb1ce799fc9051620908", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#nullable restore
#line 120 "Q:\Git\MyOpenCV\Migrane\GeekBrains\C# ASP.NET Core. Уровень 1\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\geekbrains-csharp-asp.net-core-level-1-HomeWork_2\WebStore\Views\Employees\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

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
                WriteLiteral("\n            <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\"/> |\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "49ef77470c4600e0e72670d02fb1ce799fc9051622820", async() => {
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
                WriteLiteral("\n        ");
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
            WriteLiteral("\n    </div>\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebStore.Models.Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
