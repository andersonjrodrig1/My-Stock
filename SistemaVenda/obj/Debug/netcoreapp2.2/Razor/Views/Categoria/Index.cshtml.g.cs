#pragma checksum "E:\Desenvolvimento\Visual Studio\CSharp\Projetos\SistemaVenda\SistemaVenda\Views\Categoria\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0b18bf1afe2c5ef6021a1a83d426264fd0c359bf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Categoria_Index), @"mvc.1.0.view", @"/Views/Categoria/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Categoria/Index.cshtml", typeof(AspNetCore.Views_Categoria_Index))]
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
#line 1 "E:\Desenvolvimento\Visual Studio\CSharp\Projetos\SistemaVenda\SistemaVenda\Views\_ViewImports.cshtml"
using SistemaVenda;

#line default
#line hidden
#line 2 "E:\Desenvolvimento\Visual Studio\CSharp\Projetos\SistemaVenda\SistemaVenda\Views\_ViewImports.cshtml"
using SistemaVenda.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0b18bf1afe2c5ef6021a1a83d426264fd0c359bf", @"/Views/Categoria/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9542d2a040dc74eba97c4a394c73aefd7909e77c", @"/Views/_ViewImports.cshtml")]
    public class Views_Categoria_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<SistemaVenda.Models.CategoriaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Cadastro", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(61, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Desenvolvimento\Visual Studio\CSharp\Projetos\SistemaVenda\SistemaVenda\Views\Categoria\Index.cshtml"
  
    ViewData["Title"] = "Categorias";

#line default
#line hidden
            BeginContext(109, 6, true);
            WriteLiteral("\r\n<h2>");
            EndContext();
            BeginContext(116, 17, false);
#line 7 "E:\Desenvolvimento\Visual Studio\CSharp\Projetos\SistemaVenda\SistemaVenda\Views\Categoria\Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(133, 209, true);
            WriteLiteral("</h2>\r\n<hr />\r\n<table class=\"table table-striped\">\r\n    <thead>\r\n        <tr>\r\n            <th>Código</th>\r\n            <th>Descrição</th>\r\n            <th>Ação</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 18 "E:\Desenvolvimento\Visual Studio\CSharp\Projetos\SistemaVenda\SistemaVenda\Views\Categoria\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(391, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(430, 11, false);
#line 21 "E:\Desenvolvimento\Visual Studio\CSharp\Projetos\SistemaVenda\SistemaVenda\Views\Categoria\Index.cshtml"
               Write(item.Codigo);

#line default
#line hidden
            EndContext();
            BeginContext(441, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(469, 14, false);
#line 22 "E:\Desenvolvimento\Visual Studio\CSharp\Projetos\SistemaVenda\SistemaVenda\Views\Categoria\Index.cshtml"
               Write(item.Descricao);

#line default
#line hidden
            EndContext();
            BeginContext(483, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(510, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b18bf1afe2c5ef6021a1a83d426264fd0c359bf5874", async() => {
                BeginContext(563, 6, true);
                WriteLiteral("Editar");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 23 "E:\Desenvolvimento\Visual Studio\CSharp\Projetos\SistemaVenda\SistemaVenda\Views\Categoria\Index.cshtml"
                                               WriteLiteral(item.Codigo);

#line default
#line hidden
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
            EndContext();
            BeginContext(573, 26, true);
            WriteLiteral("</td>\r\n            </tr>\r\n");
            EndContext();
#line 25 "E:\Desenvolvimento\Visual Studio\CSharp\Projetos\SistemaVenda\SistemaVenda\Views\Categoria\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(610, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
            EndContext();
            BeginContext(634, 128, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0b18bf1afe2c5ef6021a1a83d426264fd0c359bf8549", async() => {
                BeginContext(662, 93, true);
                WriteLiteral("\r\n    <input class=\"btn btn-block btn-primary\" type=\"submit\" value=\"Cadastrar Categoria\" />\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(762, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(784, 2, true);
                WriteLiteral("\r\n");
                EndContext();
#line 33 "E:\Desenvolvimento\Visual Studio\CSharp\Projetos\SistemaVenda\SistemaVenda\Views\Categoria\Index.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<SistemaVenda.Models.CategoriaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
