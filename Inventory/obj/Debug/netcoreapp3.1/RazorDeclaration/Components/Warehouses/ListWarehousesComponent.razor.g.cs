#pragma checksum "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Warehouses\ListWarehousesComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cf4485897ed0587190808695d55a2753dfa8a0be"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Components.Warehouses
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
#nullable restore
#line 1 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Warehouses\ListWarehousesComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Warehouses\ListWarehousesComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class ListWarehousesComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 30 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Warehouses\ListWarehousesComponent.razor"
       

    List<WarehouseEntity> warehouses = new List<WarehouseEntity>();

    protected override async Task OnInitializedAsync()
    {
        warehouses = B_Warehouse.WarehousesList();
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591