#pragma checksum "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1713847a50cfe445c73b61ca166033803c42b410"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_GetFaculty), @"mvc.1.0.view", @"/Views/Home/GetFaculty.cshtml")]
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
#line 1 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/_ViewImports.cshtml"
using Project3_FinalExam;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/_ViewImports.cshtml"
using Project3_FinalExam.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1713847a50cfe445c73b61ca166033803c42b410", @"/Views/Home/GetFaculty.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5eb26fd86b6b4d21c48708c3be3589307986ac32", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_GetFaculty : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Project3_FinalExam.ViewModels.HomeViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jquery/jquery.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/themes/le-frog/jquery-ui.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/jqueryui/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 3 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n\r\n");
#nullable restore
#line 5 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
 for (var i = 0; i < Model.Faculty.Count; i++)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 219, "", 261, 1);
#nullable restore
#line 9 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 223, String.Concat("myDiv:", i.ToString()), 223, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 306, "\"", 339, 1);
#nullable restore
#line 10 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 312, Model.Faculty[i].imagePath, 312, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:160px;width:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 373, "\"", 379, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 14 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 18 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 849, "", 891, 1);
#nullable restore
#line 29 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 853, String.Concat("myDiv:", i.ToString()), 853, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 936, "\"", 969, 1);
#nullable restore
#line 30 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 942, Model.Faculty[i].imagePath, 942, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:160px;width:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 1003, "\"", 1009, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 34 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 38 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 1479, "", 1521, 1);
#nullable restore
#line 49 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 1483, String.Concat("myDiv:", i.ToString()), 1483, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 1566, "\"", 1599, 1);
#nullable restore
#line 50 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 1572, Model.Faculty[i].imagePath, 1572, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:160px;width:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 1633, "\"", 1639, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 54 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 58 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
          
            if (i < Model.Faculty.Count - 1)
            {
                i++;
            }
            else
            {
                break;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-sm-3\">\r\n            <div class=\"thumbnail\"");
            BeginWriteAttribute("id", " id=", 2109, "", 2151, 1);
#nullable restore
#line 69 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 2113, String.Concat("myDiv:", i.ToString()), 2113, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"getName(id)\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2196, "\"", 2229, 1);
#nullable restore
#line 70 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
WriteAttributeValue("", 2202, Model.Faculty[i].imagePath, 2202, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"height:160px;width:150px\"");
            BeginWriteAttribute("alt", " alt=\"", 2263, "\"", 2269, 0);
            EndWriteAttribute();
            WriteLiteral(" />\r\n            </div>\r\n            <div class=\"caption\">\r\n                <h3 style=\"font-size:medium\">\r\n                    ");
#nullable restore
#line 74 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
               Write(Model.Faculty[i].name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h3>\r\n            </div>\r\n        </div>\r\n        <div>&nbsp;</div>\r\n        <div>&nbsp;</div>\r\n    </div>\r\n");
#nullable restore
#line 81 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div id=\"dialog\"></div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1713847a50cfe445c73b61ca166033803c42b41012454", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "1713847a50cfe445c73b61ca166033803c42b41013480", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1713847a50cfe445c73b61ca166033803c42b41014581", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script>\r\n    var $j = jQuery.noConflict();\r\n    var facultyData = ");
#nullable restore
#line 89 "/Users/vsoler27/Documents/2205/ISTE340/ClientProg_Project3/Views/Home/GetFaculty.cshtml"
                 Write(Html.Raw(Json.Serialize(Model.Faculty)));

#line default
#line hidden
#nullable disable
            WriteLiteral(@";

    function getName(id) {
        console.log(facultyData);
        let facultyElement = (id).split(':')[1];

        var divContent = ""<div><ul>"";

        divContent += ""<li><font color='#18ADEA'><b><u>Title:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].title + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Username:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].username + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Email:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].email + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Phone:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].phone + ""</b></<li>""
        divContent += ""<li><font color='#18ADEA'><b><u>Office:</u>&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;</font>"" + facultyData[facultyElement].office + ""</b></<li>"";

        divContent += ""</ul></div>"";

  ");
            WriteLiteral(@"      console.log(divContent);

        let elmnt = document.getElementById(id);
        $j(""#dialog"").html(divContent);
        $j(""#dialog"").dialog({
            title: facultyData[facultyElement].name,
            width: 500,
            position: { my: ""center"", at: ""bottom+40%"", of: elmnt}
        });
        $j(""#dialog"").dialog(""open"")
    }
</script>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Project3_FinalExam.ViewModels.HomeViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
