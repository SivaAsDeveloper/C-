#pragma checksum "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/Pages/Grid.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b07d5be1bde31ff66bb630fd123058182e7a2976"
// <auto-generated/>
#pragma warning disable 1591
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
    public partial class Grid<TItem> : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "table");
            __builder.AddAttribute(1, "border", "1");
            __builder.AddMarkupContent(2, "\n    ");
            __builder.OpenElement(3, "thead");
            __builder.AddMarkupContent(4, "\n        ");
            __builder.OpenElement(5, "tr");
            __builder.AddContent(6, 
#nullable restore
#line 4 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/Pages/Grid.razor"
             Header

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(7, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n    ");
            __builder.OpenElement(9, "tbody");
            __builder.AddMarkupContent(10, "\n");
#nullable restore
#line 7 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/Pages/Grid.razor"
         foreach (var item in Items)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(11, "            ");
            __builder.OpenElement(12, "tr");
            __builder.AddMarkupContent(13, "\n                ");
            __builder.AddContent(14, 
#nullable restore
#line 10 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/Pages/Grid.razor"
                 Row(item)

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(15, "\n\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(16, "\n");
#nullable restore
#line 13 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/Pages/Grid.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddMarkupContent(17, "\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(18, "\n    ");
            __builder.OpenElement(19, "tfoot");
            __builder.AddMarkupContent(20, "\n        ");
            __builder.OpenElement(21, "tr");
            __builder.AddContent(22, 
#nullable restore
#line 17 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/Pages/Grid.razor"
             Footer

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(23, "\n\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(24, "\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 21 "/home/codespace/workspace/C-/BlazorLearningKickOff/Client/Pages/Grid.razor"
      
    [Parameter]
    public RenderFragment Header { get; set; }
    [Parameter]
    public RenderFragment Footer { get; set; }
    [Parameter]
    public RenderFragment<TItem> Row { get; set; }
    [Parameter]
    public IReadOnlyList<TItem> Items { get; set; }



#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
