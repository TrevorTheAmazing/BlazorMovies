#pragma checksum "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\Pages\Counter.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a2fbf811512321910ac87fee220d7851d14cfe75"
// <auto-generated/>
#pragma warning disable 1591
namespace BlazorMovies.Client.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Client.Helpers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\_Imports.razor"
using BlazorMovies.Shared.Entities;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/counter")]
    public partial class Counter : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "p");
            __builder.AddAttribute(1, "b-xkepukfy0a");
            __builder.AddContent(2, "Current count: ");
            __builder.AddContent(3, 
#nullable restore
#line 3 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\Pages\Counter.razor"
                   currentCount

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n\r\n");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "btn btn-primary");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\Pages\Counter.razor"
                                          IncrementCount

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "b-xkepukfy0a");
            __builder.AddContent(9, "Click me");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "input");
            __builder.AddAttribute(12, "type", "number");
            __builder.AddAttribute(13, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 7 "C:\Users\Trevor\Desktop\code\bm\BlazorMovies\ASP.NET Core 5\Module 4 - Routing\Start\BlazorMovies\BlazorMovies\Client\Pages\Counter.razor"
                            currentCount

#line default
#line hidden
#nullable disable
            , culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.AddAttribute(14, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => currentCount = __value, currentCount, culture: global::System.Globalization.CultureInfo.InvariantCulture));
            __builder.SetUpdatesAttributeName("value");
            __builder.AddAttribute(15, "b-xkepukfy0a");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
