#pragma checksum "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/Pages/FetchData.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e4cf07a3ce806e788af76c64c7782977c3fc2c49"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace BlazorLearningKickOff.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/_Imports.razor"
using BlazorLearningKickOff.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/_Imports.razor"
using BlazorLearningKickOff.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/Pages/FetchData.razor"
using BlazorLearningKickOff.Shared;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/fetchdata")]
    public partial class FetchData : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 55 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/Pages/FetchData.razor"
       
    private WeatherForecast[] forecasts;

    protected override async Task OnInitializedAsync()
    {
        forecasts = await Http.GetFromJsonAsync<WeatherForecast[]>("WeatherForecast");
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient Http { get; set; }
    }
}
#pragma warning restore 1591
