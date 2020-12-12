#pragma checksum "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93aca1331b6cac7c53dc0bc5b59d4a18797d5e2e"
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
    [Microsoft.AspNetCore.Components.RouteAttribute("/FetchData")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, @"<style>
    .row{
        margin-bottom: 10%;
    }
    #newsOutlet {
        text-align: center;
        font-size: 50px;
    }

    #newsAuthor {
        text-align: center;
    }

    #newsTitle{
        font-size: 30px;
    }

    #spacing{
        margin-bottom:10%;
    }

</style>
    <link href=""../wwwroot/css/news.css"" rel=""stylesheet"">
");
            __builder.AddMarkupContent(1, "<h1>News</h1>");
#nullable restore
#line 29 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
 if (news == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(2, "<p><em>Loading...</em></p>");
#nullable restore
#line 32 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 35 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
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
            __builder.AddAttribute(9, "id", "newsOutlet");
            __builder.AddContent(10, 
#nullable restore
#line 42 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
                                    rootdata.source.name

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n                ");
            __builder.OpenElement(12, "p");
            __builder.AddAttribute(13, "id", "newsAuthor");
            __builder.OpenElement(14, "small");
            __builder.AddContent(15, "Written by ");
            __builder.AddContent(16, 
#nullable restore
#line 43 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
                                                      rootdata.author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(17, "\r\n                ");
            __builder.OpenElement(18, "p");
            __builder.AddAttribute(19, "id", "newsTitle");
            __builder.AddContent(20, 
#nullable restore
#line 44 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
                                   rootdata.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(21, "\r\n                ");
            __builder.OpenElement(22, "p");
            __builder.AddContent(23, 
#nullable restore
#line 45 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
                    rootdata.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "img");
            __builder.AddAttribute(26, "class", "img-fluid");
            __builder.AddAttribute(27, "src", 
#nullable restore
#line 46 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
                                             rootdata.urlToImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(28, "alt", "No Image Found");
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "p");
            __builder.OpenElement(31, "small");
            __builder.AddContent(32, "Published At: ");
            __builder.AddContent(33, 
#nullable restore
#line 47 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
                                         rootdata.publishedAt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(34, "\r\n                ");
            __builder.OpenElement(35, "p");
            __builder.AddContent(36, 
#nullable restore
#line 48 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
                    rootdata.content

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(37, " ");
            __builder.OpenElement(38, "a");
            __builder.AddAttribute(39, "target", "_blank");
            __builder.AddAttribute(40, "href", 
#nullable restore
#line 48 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
                                                               rootdata.url

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(41, "Continue Reading ...");
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(42, "\r\n\r\n            <div class=\"col-2\"></div>");
            __builder.CloseElement();
#nullable restore
#line 54 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 88 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
                  



}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 94 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\FetchData.razor"
       

    private Response news;

    public async Task Find()
    {
        //This options is necessary because the serializer of GetFromJson not recognize null values throwing a exception, in this particular case somes Ids is null
        System.Text.Json.JsonSerializerOptions options = new System.Text.Json.JsonSerializerOptions() { IgnoreNullValues = true };

        news = await Http.GetFromJsonAsync<Response>("https://newsapi.org/v2/top-headlines?country=us&apiKey=a15cbcc05e814709a1749fbec881c2c2", options);
    }

    protected override async Task OnInitializedAsync()
    {
        await Find();
    }

    public class Response
    {
        public string status { get; set; }
        public int totalResults { get; set; }
        //Work with arrays, Lists etc... But, Interfaces is best because parsing only the features to property not a instance a List.
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
