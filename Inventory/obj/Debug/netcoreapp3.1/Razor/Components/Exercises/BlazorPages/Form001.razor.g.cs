#pragma checksum "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Exercises\BlazorPages\Form001.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f8460f3de002a50d6972d4808d9e6746242f83eb"
// <auto-generated/>
#pragma warning disable 1591
namespace Inventory.Components.Exercises.BlazorPages
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
    public partial class Form001 : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "text");
            __builder.AddAttribute(2, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 1 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Exercises\BlazorPages\Form001.razor"
                                 message

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(3, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => message = __value, message));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(4, "\r\n");
            __builder.OpenElement(5, "input");
            __builder.AddAttribute(6, "type", "text");
            __builder.AddAttribute(7, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 2 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Exercises\BlazorPages\Form001.razor"
                                 text

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(8, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => text = __value, text));
            __builder.SetUpdatesAttributeName("value");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.OpenElement(10, "input");
            __builder.AddAttribute(11, "type", "button");
            __builder.AddAttribute(12, "value", "Click");
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 3 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Exercises\BlazorPages\Form001.razor"
                                             ChangeText

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
            __builder.AddMarkupContent(14, "\r\n");
            __builder.OpenElement(15, "div");
            __builder.AddMarkupContent(16, "\r\n    ");
            __builder.AddContent(17, 
#nullable restore
#line 5 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Exercises\BlazorPages\Form001.razor"
     message

#line default
#line hidden
#nullable disable
            );
            __builder.AddMarkupContent(18, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 8 "D:\Documents\Cursos\Platsy\Desarrollo de Aplicaciones con ASP .NET\Desarrollo Web con Blazor y .NET\Inventory\Inventory\Components\Exercises\BlazorPages\Form001.razor"
       
    [Parameter]
    public string Message { get; set; }

    string message = "Un contenido";
    string text;

    // Quiero que cargue el mensaje al inicio del componente
    protected override async Task OnInitializedAsync()
    {
        message = Message;
    }

    private void ChangeText()
    {
        message = text;
    }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
