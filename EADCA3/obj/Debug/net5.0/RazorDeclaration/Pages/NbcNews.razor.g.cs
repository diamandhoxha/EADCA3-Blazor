// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    [Microsoft.AspNetCore.Components.RouteAttribute("/NbcNews")]
    public partial class NbcNews : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 57 "C:\Users\hhoxh\source\repos\EADCA3\EADCA3\Pages\NbcNews.razor"
       

    private Response news;

    public async Task Find()
    {
        System.Text.Json.JsonSerializerOptions options = new System.Text.Json.JsonSerializerOptions() { IgnoreNullValues = true };

        news = await Http.GetFromJsonAsync<Response>("https://newsapi.org/v2/top-headlines?sources=nbc-news&apiKey=a15cbcc05e814709a1749fbec881c2c2", options);
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
