#pragma checksum "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Products\CreateProductComponent.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78b5456ee2b8efc3e1731928953ff083b932e1ea"
// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

namespace Inventory.Components.Products
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
#line 1 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
using Entities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
using Business;

#line default
#line hidden
#nullable disable
    public partial class CreateProductComponent : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 36 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Products\CreateProductComponent.razor"
       
    ProductEntity newProduct = new ProductEntity();
    List<CategoryEntity> categories = new List<CategoryEntity>();

    protected override async Task OnInitializedAsync()
    {
        categories = B_Category.CategoryList();
    }

    private void SaveProduct()
    {
        // Puse los métodos static
        B_Product.CreateProduct(newProduct);
        // Redireccionamiento
        NavManager.NavigateTo("product/list");
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager NavManager { get; set; }
    }
}
#pragma warning restore 1591
