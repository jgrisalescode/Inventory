#pragma checksum "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2fd761ee3c882088000ffe6158dc19dab4f46706"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Inventory;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Inventory.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Exercises.BlazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Exercises.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\_Imports.razor"
using Inventory.Components.Warehouses;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(2, "\r\n    ");
            __builder.AddMarkupContent(3, "<a class=\"navbar-brand\" href>Inventory</a>\r\n    ");
            __builder.OpenElement(4, "button");
            __builder.AddAttribute(5, "class", "navbar-toggler");
            __builder.AddAttribute(6, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(7, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(8, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n\r\n");
            __builder.OpenElement(10, "div");
            __builder.AddAttribute(11, "class", 
#nullable restore
#line 8 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(12, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 8 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(13, "\r\n    ");
            __builder.OpenElement(14, "ul");
            __builder.AddAttribute(15, "class", "nav flex-column");
            __builder.AddMarkupContent(16, "\r\n        ");
            __builder.OpenElement(17, "li");
            __builder.AddAttribute(18, "class", "nav-item px-3");
            __builder.AddMarkupContent(19, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(20);
            __builder.AddAttribute(21, "class", "nav-link");
            __builder.AddAttribute(22, "href", "");
            __builder.AddAttribute(23, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 11 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(24, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(25, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(26, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.OpenElement(28, "li");
            __builder.AddAttribute(29, "class", "nav-item px-3");
            __builder.AddMarkupContent(30, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(31);
            __builder.AddAttribute(32, "class", "nav-link");
            __builder.AddAttribute(33, "href", "product/list");
            __builder.AddAttribute(34, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 16 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Shared\NavMenu.razor"
                                                                 NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Lista de productos\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n        ");
            __builder.OpenElement(39, "li");
            __builder.AddAttribute(40, "class", "nav-item px-3");
            __builder.AddMarkupContent(41, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(42);
            __builder.AddAttribute(43, "class", "nav-link");
            __builder.AddAttribute(44, "href", "category/list");
            __builder.AddAttribute(45, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 21 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Shared\NavMenu.razor"
                                                                  NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(46, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(47, "\r\n                <span class=\"oi oi-browser\" aria-hidden=\"true\"></span> Lista de categorías\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(48, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n        ");
            __builder.OpenElement(50, "li");
            __builder.AddAttribute(51, "class", "nav-item px-3");
            __builder.AddMarkupContent(52, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(53);
            __builder.AddAttribute(54, "class", "nav-link");
            __builder.AddAttribute(55, "href", "warehouse/list");
            __builder.AddAttribute(56, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 26 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Shared\NavMenu.razor"
                                                                   NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(57, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(58, "\r\n                <span class=\"oi oi-box\" aria-hidden=\"true\"></span> Lista de bodegas\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(59, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.OpenElement(61, "li");
            __builder.AddAttribute(62, "class", "nav-item px-3");
            __builder.AddMarkupContent(63, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(64);
            __builder.AddAttribute(65, "class", "nav-link");
            __builder.AddAttribute(66, "href", "counter");
            __builder.AddAttribute(67, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(68, "\r\n                <span class=\"oi oi-plus\" aria-hidden=\"true\"></span> Counter\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(69, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(70, "\r\n        ");
            __builder.OpenElement(71, "li");
            __builder.AddAttribute(72, "class", "nav-item px-3");
            __builder.AddMarkupContent(73, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(74);
            __builder.AddAttribute(75, "class", "nav-link");
            __builder.AddAttribute(76, "href", "fetchdata");
            __builder.AddAttribute(77, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(78, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Fetch data\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(79, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(80, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 43 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Shared\NavMenu.razor"
       
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
