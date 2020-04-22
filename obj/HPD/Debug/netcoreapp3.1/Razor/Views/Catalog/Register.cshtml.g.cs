#pragma checksum "C:\Users\pinck03w\Desktop\index.html\110\ERP\Views\Catalog\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7c92618c57fff2c40dc44a1ddbb84ecc47c8ec5b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Catalog_Register), @"mvc.1.0.view", @"/Views/Catalog/Register.cshtml")]
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
#line 1 "C:\Users\pinck03w\Desktop\index.html\110\ERP\Views\_ViewImports.cshtml"
using ERP;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pinck03w\Desktop\index.html\110\ERP\Views\_ViewImports.cshtml"
using ERP.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7c92618c57fff2c40dc44a1ddbb84ecc47c8ec5b", @"/Views/Catalog/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"60a75ba6acbf59262aafe8919fa59d5c332bbb5b", @"/Views/_ViewImports.cshtml")]
    public class Views_Catalog_Register : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "Select", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "new", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "used", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\pinck03w\Desktop\index.html\110\ERP\Views\Catalog\Register.cshtml"
  
    ViewData["Title"] = "Register A New Car";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
            WriteLiteral("\r\n<div class=\"col-md-6 offset-md-3\">\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c92618c57fff2c40dc44a1ddbb84ecc47c8ec5b4508", async() => {
                WriteLiteral(@"

    <h3>Register New Car</h3>


  <div class=""form-group row"">
    <label for=""textMake"" class=""col-5 col-form-label"">Make</label> 
    <div class=""col-7"">
      <div class=""input-group"">
        <div class=""input-group-prepend"">
          <div class=""input-group-text"">
            <i class=""fa fa-address-card""></i>
          </div>
        </div> 
        <input id=""textMake"" name=""textMake"" placeholder=""Enter Car Make"" type=""text"" class=""form-control"">
      </div>
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""textModel"" class=""col-5 col-form-label"">Model</label> 
    <div class=""col-7"">
      <input id=""textModel"" name=""textModel"" placeholder=""Enter Car Model"" type=""text"" class=""form-control"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""textYear"" class=""col-5 col-form-label"">Year</label> 
    <div class=""col-7"">
      <input id=""textYear"" name=""textYear"" placeholder=""Enter Year"" type=""number"" class=""form-control"">
    </div>
  </div");
                WriteLiteral(@">
  <div class=""form-group row"">
    <label for=""textColor"" class=""col-5 col-form-label"">Color</label> 
    <div class=""col-7"">
      <input id=""textColor"" name=""textColor"" placeholder=""Describe Color"" type=""text"" class=""form-control"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""textModel"" class=""col-5 col-form-label"">Price</label> 
    <div class=""col-7"">
      <input id=""textPrice"" name=""textPrice"" placeholder=""Enter Vehicle Price"" type=""number"" class=""form-control"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""textMileage"" class=""col-5 col-form-label"">Mileage</label> 
    <div class=""col-7"">
      <input id=""textMileage"" name=""textMileage"" placeholder=""Enter Mileage"" type=""number"" class=""form-control"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""selectCondition"" class=""col-5 col-form-label"">Condition</label> 
    <div class=""col-7"">
      <select id=""selectCondition"" name=""selectCondition"" class=""custom-select"">
    ");
                WriteLiteral("    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c92618c57fff2c40dc44a1ddbb84ecc47c8ec5b7016", async() => {
                    WriteLiteral("-- Select Condition --");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c92618c57fff2c40dc44a1ddbb84ecc47c8ec5b8263", async() => {
                    WriteLiteral("New");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n        ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7c92618c57fff2c40dc44a1ddbb84ecc47c8ec5b9491", async() => {
                    WriteLiteral("Used");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
      </select>
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""textSeats"" class=""col-5 col-form-label"">Seats</label> 
    <div class=""col-7"">
      <input id=""textSeats"" name=""textSeats"" placeholder=""Number of Seats"" type=""number"" class=""form-control"">
    </div>
  </div>
  <div class=""form-group row"">
    <label for=""textMPG"" class=""col-5 col-form-label"">Miles Per Gallon</label> 
    <div class=""col-7"">
      <input id=""textMPG"" name=""textMPG"" placeholder=""Enter MPG"" type=""number"" class=""form-control"">
    </div>
  </div> 
   <div class=""form-group row"">
    <label for=""textSeats"" class=""col-5 col-form-label"">Image</label> 
    <div class=""col-7"">
      <input id=""textImage"" name=""textImage"" placeholder=""Enter Image"" type=""text"" class=""form-control"">
    </div>
  </div>
  <div class=""form-group row"">
    <div class=""offset-5 col-7"">
      <button id=""btnSave"" name=""submit"" type=""button"" class=""btn btn-primary"">
          <i class=""fa fa-save""></i>
          Regi");
                WriteLiteral("ster Car\r\n          </button>\r\n    </div>\r\n  </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n  <script src=\"/js/register.js\"></script>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
