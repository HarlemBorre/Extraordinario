#pragma checksum "C:\Users\Seele\Desktop\BBAPP\ExtraApp\Shared\MainLayout.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1e277c8d0fdcc592614ddb2291414bc8b18f01ce"
// <auto-generated/>
#pragma warning disable 1591
namespace ExtraApp.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\Seele\Desktop\BBAPP\ExtraApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Seele\Desktop\BBAPP\ExtraApp\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Seele\Desktop\BBAPP\ExtraApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\Seele\Desktop\BBAPP\ExtraApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\Seele\Desktop\BBAPP\ExtraApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Seele\Desktop\BBAPP\ExtraApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\Seele\Desktop\BBAPP\ExtraApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web.Virtualization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\Seele\Desktop\BBAPP\ExtraApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\Seele\Desktop\BBAPP\ExtraApp\_Imports.razor"
using ExtraApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "C:\Users\Seele\Desktop\BBAPP\ExtraApp\_Imports.razor"
using ExtraApp.Shared;

#line default
#line hidden
#nullable disable
    public partial class MainLayout : LayoutComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "page");
            __builder.AddAttribute(2, "b-ngfn0scunv");
            __builder.OpenElement(3, "div");
            __builder.AddAttribute(4, "class", "main");
            __builder.AddAttribute(5, "b-ngfn0scunv");
            __builder.AddMarkupContent(6, @"<nav class=""navbar navbar-light bg-light"" b-ngfn0scunv><div class=""container-fluid"" b-ngfn0scunv><a class=""navbar-brand"" b-ngfn0scunv>Navbar</a>
    <form class=""d-flex"" b-ngfn0scunv><input class=""form-control me-2"" type=""search"" placeholder=""Say my name"" aria-label=""Search"" b-ngfn0scunv>
      <button class=""btn btn-outline-success"" type=""submit"" b-ngfn0scunv>Search</button></form></div></nav>
        ");
            __builder.OpenElement(7, "div");
            __builder.AddAttribute(8, "class", "content px-4");
            __builder.AddAttribute(9, "b-ngfn0scunv");
            __builder.AddContent(10, 
#nullable restore
#line 15 "C:\Users\Seele\Desktop\BBAPP\ExtraApp\Shared\MainLayout.razor"
             Body

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
    }
}
#pragma warning restore 1591
