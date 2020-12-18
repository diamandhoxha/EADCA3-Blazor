#pragma checksum "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00af925de9d0024839966e86865dd9b7889930f1"
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
#line 1 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\_Imports.razor"
using EADCA3;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\_Imports.razor"
using EADCA3.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/FoxNews")]
    public partial class FoxNews : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1>Fox News</h1>");
#nullable restore
#line 6 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
 if (news == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(1, "<p><em>Loading...</em></p>");
#nullable restore
#line 9 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
}
else
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
     foreach (var rootdata in news.articles.ToList())
    {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "row");
            __builder.AddMarkupContent(4, "<div class=\"col-2\"></div>\r\n\r\n            ");
            __builder.OpenElement(5, "div");
            __builder.AddAttribute(6, "class", "col-8");
            __builder.OpenElement(7, "p");
            __builder.AddAttribute(8, "id", "newsTitle");
            __builder.AddContent(9, 
#nullable restore
#line 19 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
                                   rootdata.title

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n                ");
            __builder.OpenElement(11, "p");
            __builder.AddContent(12, 
#nullable restore
#line 20 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
                    rootdata.description

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\r\n                ");
            __builder.OpenElement(14, "p");
            __builder.AddAttribute(15, "id", "newsAuthor");
            __builder.OpenElement(16, "small");
            __builder.AddContent(17, "Written by ");
            __builder.AddContent(18, 
#nullable restore
#line 21 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
                                                      rootdata.author

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(19, "\r\n                ");
            __builder.OpenElement(20, "img");
            __builder.AddAttribute(21, "class", "img-fluid");
            __builder.AddAttribute(22, "src", 
#nullable restore
#line 22 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
                                             rootdata.urlToImage

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(23, "alt", "No Image Found");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\r\n                ");
            __builder.OpenElement(25, "p");
            __builder.OpenElement(26, "small");
            __builder.AddContent(27, "Published At: ");
            __builder.AddContent(28, 
#nullable restore
#line 23 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
                                         rootdata.publishedAt

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(29, "\r\n                ");
            __builder.OpenElement(30, "p");
            __builder.AddAttribute(31, "id", "spacing");
            __builder.AddContent(32, 
#nullable restore
#line 24 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
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
#line 24 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
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
#line 30 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 30 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
     
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 33 "C:\Users\hhoxh\EADCA3-Blazor\EADCA3\Pages\FoxNews.razor"
       

    private Response news;

    public async Task Find()
    {
        System.Text.Json.JsonSerializerOptions options = new System.Text.Json.JsonSerializerOptions() { IgnoreNullValues = true };

        news = await Http.GetFromJsonAsync<Response>("https://newsapi.org/v2/top-headlines?sources=fox-news&apiKey=a15cbcc05e814709a1749fbec881c2c2", options);
    }

    protected override async Task OnInitializedAsync()
    {
        await Find();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
