#pragma checksum "/home/codespace/workspace/C-/PizzaPlace/PizzaPlace/Client/Shared/NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d5d8d35d0753feb70a46cc2d07c527cdb2f7455b"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace PizzaPlace.Client.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "/home/codespace/workspace/C-/PizzaPlace/PizzaPlace/Client/_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "/home/codespace/workspace/C-/PizzaPlace/PizzaPlace/Client/_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "/home/codespace/workspace/C-/PizzaPlace/PizzaPlace/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "/home/codespace/workspace/C-/PizzaPlace/PizzaPlace/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "/home/codespace/workspace/C-/PizzaPlace/PizzaPlace/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "/home/codespace/workspace/C-/PizzaPlace/PizzaPlace/Client/_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "/home/codespace/workspace/C-/PizzaPlace/PizzaPlace/Client/_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "/home/codespace/workspace/C-/PizzaPlace/PizzaPlace/Client/_Imports.razor"
using PizzaPlace.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "/home/codespace/workspace/C-/PizzaPlace/PizzaPlace/Client/_Imports.razor"
using PizzaPlace.Client.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 28 "/home/codespace/workspace/C-/PizzaPlace/PizzaPlace/Client/Shared/NavMenu.razor"
       
    private bool collapseNavMenu = true;

    private string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

    private void ToggleNavMenu()
    {
        collapseNavMenu = !collapseNavMenu;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
