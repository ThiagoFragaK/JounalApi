#pragma checksum "F:\Projekten\Under Works\JAPI\Views\Entries\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "801406af4ba3253c75e86006213f120660d8852a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Entries_Edit), @"mvc.1.0.view", @"/Views/Entries/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"801406af4ba3253c75e86006213f120660d8852a", @"/Views/Entries/Edit.cshtml")]
    public class Views_Entries_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<JAPI.Model.Entry>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "F:\Projekten\Under Works\JAPI\Views\Entries\Edit.cshtml"
  
    ViewData["Title"] = "Edit";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Entry</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""EntryId"" />
            <div class=""form-group"">
                <label asp-for=""EntryTitle"" class=""control-label""></label>
                <input asp-for=""EntryTitle"" class=""form-control"" />
                <span asp-validation-for=""EntryTitle"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EntryDescr"" class=""control-label""></label>
                <input asp-for=""EntryDescr"" class=""form-control"" />
                <span asp-validation-for=""EntryDescr"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""EntryDate"" class=""control-label""></label>
                <input asp-for=""EntryDate"" class=""form-control"" />
            ");
            WriteLiteral(@"    <span asp-validation-for=""EntryDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 43 "F:\Projekten\Under Works\JAPI\Views\Entries\Edit.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<JAPI.Model.Entry> Html { get; private set; }
    }
}
#pragma warning restore 1591
