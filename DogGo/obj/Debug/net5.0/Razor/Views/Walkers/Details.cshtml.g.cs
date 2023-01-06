#pragma checksum "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "383751d6409c0524f4d4e7b76aa9e5ddcb79aed2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Walkers_Details), @"mvc.1.0.view", @"/Views/Walkers/Details.cshtml")]
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
#line 1 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\_ViewImports.cshtml"
using DogGo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\_ViewImports.cshtml"
using DogGo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"383751d6409c0524f4d4e7b76aa9e5ddcb79aed2", @"/Views/Walkers/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"12b50fd1f91f777ae09abf39d99992ea9d25da6c", @"/Views/_ViewImports.cshtml")]
    public class Views_Walkers_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DogGo.Models.ViewModels.ProfileViewModel>
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
#line 3 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Details</h1>\r\n\r\n<div>\r\n    <h4>Walker</h4>\r\n    <hr />\r\n   <div class=\"d-flex justify-content-around shadow-sm bg-light\">\r\n       <div class=\"col-md-4 px-0\">\r\n            <img class=\"bg-info rounded-circle img-fluid\"");
            BeginWriteAttribute("src", " src=\"", 316, "\"", 344, 1);
#nullable restore
#line 14 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
WriteAttributeValue("", 322, Model.Walker.ImageUrl, 322, 22, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"avatar\" />\r\n       </div>\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-3\">\r\n                ");
#nullable restore
#line 18 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Walker.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-7\">\r\n                ");
#nullable restore
#line 21 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Walker.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-3\">\r\n                ");
#nullable restore
#line 24 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Walker.neighborhood));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            \r\n            <dd class=\"col-sm-5\">\r\n                ");
#nullable restore
#line 28 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
           Write(Html.DisplayFor(model => model.Walker.neighborhood.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n   </div>\r\n    \r\n</div>\r\n<div class=\"d-flex justify-content-between \">\r\n<div>\r\n    <h4>Recent Walks</h4>\r\n    <dl class=\"row\">\r\n");
#nullable restore
#line 38 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
         foreach (Walk walk in Model.Walks)
        {
            if (walk.WalkerId == Model.Walker.Id)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <dt class=\"col-sm-3\">\r\n                    Date\r\n                </dt>\r\n                <dd class=\"col-sm-3\">");
#nullable restore
#line 45 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
                                Write(walk.Date.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</dd>\r\n                <dt class=\"col-sm-2\">Client</dt>\r\n                <dd class=\"col-sm-2\">\r\n                    Durration\r\n                </dd>\r\n                <dt class=\"col-sm-2\">\r\n                    ");
#nullable restore
#line 51 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
               Write(walk.Duration);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </dt>\r\n");
#nullable restore
#line 53 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
            }
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </dl>\r\n</div>\r\n<div>\r\n    \r\n    <dl>\r\n        Toatal Runtime:\r\n");
#nullable restore
#line 61 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
              
                List<Walk>  walks = new List<Walk>();
                foreach (Walk walk in Model.Walks)
                {
                    if (walk.WalkerId == Model.Walker.Id)
                    {
                        walks.Add(walk);
                    } 
                }      
                int runtime = walks.Sum(item => item.Duration);
              
            

#line default
#line hidden
#nullable disable
            WriteLiteral("        ");
#nullable restore
#line 73 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
   Write(runtime);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        seconds\r\n\r\n\r\n    </dl>\r\n</div>\r\n</div>\r\n<div>\r\n    ");
#nullable restore
#line 81 "C:\Users\Abigayle Jones\workspace\DogGoSol\DogGo\Views\Walkers\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { /* id = Model.PrimaryKey */ }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "383751d6409c0524f4d4e7b76aa9e5ddcb79aed28505", async() => {
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DogGo.Models.ViewModels.ProfileViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
