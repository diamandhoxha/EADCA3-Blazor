#pragma checksum "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f091fe823a5d8eac9c3bee8f35b04cbb2b68d3a7"
// <auto-generated/>
#pragma warning disable 1591
namespace EADCA3.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\_Imports.razor"
using EADCA3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\_Imports.razor"
using EADCA3.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/Espn")]
    public partial class Espn : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .row {
        margin-bottom: 10%;
    }

    h1 {
        text-align: center;
        margin-bottom: 5%;
    }

    #newsTitle {
        font-size: 30px;
    }

    #spacing {
        margin-bottom: 10%;
    }
</style>
<link href=""../wwwroot/css/news.css"" rel=""stylesheet"">
");
            __builder.AddMarkupContent(1, "<h1>ESPN</h1>");
#nullable restore
#line 25 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
 if (news == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 28 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 31 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
     foreach (var rootdata in news.articles.ToList())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "row");
            __builder.AddMarkupContent(5, "<div class=\"col-2\"></div>\r\n\r\n            ");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "col-8");
            __builder.OpenElement(8, "p");
            __builder.AddAttribute(9, "id", "newsTitle");
            __builder.AddContent(10, 
#nullable restore
#line 38 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
                                   rootdata.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "p");
            __builder.AddContent(13, 
#nullable restore
#line 39 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
                    rootdata.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n                ");
            __builder.OpenElement(15, "p");
            __builder.AddAttribute(16, "id", "newsAuthor");
            __builder.OpenElement(17, "small");
            __builder.AddContent(18, "Written by ");
            __builder.AddContent(19, 
#nullable restore
#line 40 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
                                                      rootdata.author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(20, "\r\n                ");
            __builder.OpenElement(21, "img");
            __builder.AddAttribute(22, "class", "img-fluid");
            __builder.AddAttribute(23, "src", 
#nullable restore
#line 41 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
                                             rootdata.urlToImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(24, "alt", "No Image Found");
            __builder.CloseElement();
            __builder.AddMarkupContent(25, "\r\n                ");
            __builder.OpenElement(26, "p");
            __builder.OpenElement(27, "small");
            __builder.AddContent(28, "Published At: ");
            __builder.AddContent(29, 
#nullable restore
#line 42 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
                                         rootdata.publishedAt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(30, "\r\n                ");
            __builder.OpenElement(31, "p");
            __builder.AddContent(32, 
#nullable restore
#line 43 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
                    rootdata.content

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(33, " ");
            __builder.OpenElement(34, "a");
            __builder.AddAttribute(35, "target", "_blank");
            __builder.AddAttribute(36, "href", 
#nullable restore
#line 43 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
                                                               rootdata.url

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, "Go To Source");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n\r\n            <div class=\"col-2\"></div>");
            __builder.CloseElement();
#nullable restore
#line 49 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 49 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 52 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\Espn.razor"
       

    private Response news;

    public async Task Find()
    {
        System.Text.Json.JsonSerializerOptions options = new System.Text.Json.JsonSerializerOptions() { IgnoreNullValues = true };

        news = await Http.GetFromJsonAsync<Response>("https://newsapi.org/v2/top-headlines?sources=espn&apiKey=a15cbcc05e814709a1749fbec881c2c2", options);
    }

    protected override async Task OnInitializedAsync()
    {
        await Find();
    }

    public class Response
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        public IEnumerable<Root> articles { get; set; }
    }

    public class Source
    {
        public string id { get; set; }
        public string name { get; set; }
    }

    public class Root
    {
        public Source source { get; set; }
        public string author { get; set; }
        public string title { get; set; }
        public string description { get; set; }
        public string url { get; set; }
        public string urlToImage { get; set; }
        public DateTime publishedAt { get; set; }
        public string content { get; set; }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
