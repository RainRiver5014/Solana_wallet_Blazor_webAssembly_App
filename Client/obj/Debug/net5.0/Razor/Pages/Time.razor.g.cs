#pragma checksum "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Pages\Time.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "329b3beea6ba1febc0198cdc3cdc73180d9015c5"
// <auto-generated/>
#pragma warning disable 1591
namespace dapp.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Blazored.Modal;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Blazored.Modal.Services;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using Solnet.Rpc;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using dapp.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using dapp.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using dapp.Client.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\_Imports.razor"
using dapp.Client.Services;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/time")]
    public partial class Time : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "p-md-4");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "p-md-4");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "px-4 btn btn-primary");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 6 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Pages\Time.razor"
                                                        GetCurrentTime

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(7, "Get Current Time");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\n\n        ");
            __builder.OpenElement(9, "p");
            __builder.AddAttribute(10, "class", "p-md-4");
            __builder.AddContent(11, "Current Time: ");
#nullable restore
#line 8 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Pages\Time.razor"
__builder.AddContent(12, CurrentTime);

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(13, "\n    ");
            __builder.AddMarkupContent(14, "<p class=\"p-md-4\"> Attempt some other JS interop.</p>");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 14 "E:\VisualStudio\GitHub_Samples\blazor-wasm-dapp-scaffold\blazor-wasm-dapp-scaffold-main\dapp\Client\Pages\Time.razor"
       
    private MarkupString CurrentTime = new MarkupString("");
    private IJSObjectReference walletAdapter;

    async void GetCurrentTime()
    {
        var dateTime = await JsRunTime.InvokeAsync<string>("jsinterop.GetCurrentTime");

        CurrentTime = new MarkupString(dateTime);

        StateHasChanged();
    }

    async void GetPhantomWallet()
    {
        if (JsRunTime == null)
        {
            Console.WriteLine("JS Runtime is null");
            return;
        }
        Console.WriteLine($"Calling getPhantomWallet to get adapter");
        var wallet = await JsRunTime.InvokeAsync<IJSObjectReference>($"jsinterop.GetPhantomWallet", "./jsinterop.js");
        if (wallet == null)
        {
            Console.WriteLine("wallet is null");
            return;
        }
        var adapter = await wallet.InvokeAsync<IJSObjectReference>("adapter");
        if (wallet == null)
        {
            Console.WriteLine("wallet adapter is null");
            return;
        }

        try
        {
            await adapter.InvokeVoidAsync("connect");
        }
        catch (JSException jsEx)
        {
            Console.WriteLine($"JSExc: {jsEx.Message}");
        }

        StateHasChanged();
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JsRunTime { get; set; }
    }
}
#pragma warning restore 1591
