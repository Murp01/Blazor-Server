#pragma checksum "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\Shared\NavMenu.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8f6b6f8facf08cc8a954af053fafa3feda714cf7"
// <auto-generated/>
#pragma warning disable 1591
namespace QuizManager.Shared
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\_Imports.razor"
using QuizManager;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\_Imports.razor"
using QuizManager.Shared;

#line default
#line hidden
#nullable disable
    public partial class NavMenu : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "// Shared/NavMenu.razor\r\n\r\n");
            __builder.OpenElement(1, "div");
            __builder.AddAttribute(2, "class", "top-row pl-4 navbar navbar-dark");
            __builder.AddMarkupContent(3, "\r\n    ");
            __builder.AddMarkupContent(4, "<a class=\"navbar-brand\" href>QuizManager</a>\r\n    ");
            __builder.OpenElement(5, "button");
            __builder.AddAttribute(6, "class", "navbar-toggler");
            __builder.AddAttribute(7, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 5 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\Shared\NavMenu.razor"
                                             ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(8, "\r\n        <span class=\"navbar-toggler-icon\"></span>\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n");
            __builder.CloseElement();
            __builder.AddMarkupContent(10, "\r\n\r\n");
            __builder.OpenElement(11, "div");
            __builder.AddAttribute(12, "class", 
#nullable restore
#line 10 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\Shared\NavMenu.razor"
             NavMenuCssClass

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(13, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 10 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\Shared\NavMenu.razor"
                                        ToggleNavMenu

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(14, "\r\n    ");
            __builder.OpenElement(15, "ul");
            __builder.AddAttribute(16, "class", "nav flex-column");
            __builder.AddMarkupContent(17, "\r\n        ");
            __builder.OpenElement(18, "li");
            __builder.AddAttribute(19, "class", "nav-item px-3");
            __builder.AddMarkupContent(20, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(21);
            __builder.AddAttribute(22, "class", "nav-link");
            __builder.AddAttribute(23, "href", "");
            __builder.AddAttribute(24, "Match", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.Routing.NavLinkMatch>(
#nullable restore
#line 13 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\Shared\NavMenu.razor"
                                                     NavLinkMatch.All

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(25, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(26, "\r\n                <span class=\"oi oi-home\" aria-hidden=\"true\"></span> Home\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(27, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(28, "\r\n        ");
            __builder.OpenElement(29, "li");
            __builder.AddAttribute(30, "class", "nav-item px-3");
            __builder.AddMarkupContent(31, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Routing.NavLink>(32);
            __builder.AddAttribute(33, "class", "nav-link");
            __builder.AddAttribute(34, "href", "quizViewer");
            __builder.AddAttribute(35, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment)((__builder2) => {
                __builder2.AddMarkupContent(36, "\r\n                <span class=\"oi oi-list-rich\" aria-hidden=\"true\"></span> Quiz\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(37, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(38, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(39, "\r\n");
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 25 "C:\Users\pmurp\source\repos\Blazor Server\QuizManager\Shared\NavMenu.razor"
       
   bool collapseNavMenu = true;
   string NavMenuCssClass => collapseNavMenu ? "collapse" : null;

   void ToggleNavMenu()
   {
       collapseNavMenu = !collapseNavMenu;
   }

#line default
#line hidden
#nullable disable
    }
}
#pragma warning restore 1591
