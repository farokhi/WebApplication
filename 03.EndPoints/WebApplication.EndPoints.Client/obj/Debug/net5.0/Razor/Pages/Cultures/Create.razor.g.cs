#pragma checksum "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Pages\Cultures\Create.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6ee3b7939c5c5107c6fbb62d760c45740ad9fe8"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.EndPoints.Client.Pages.Cultures
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using WebApplication.EndPoints.Client;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using WebApplication.EndPoints.Client.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using Infrastructures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using Infrastructures.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using MudBlazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using MudBlazor.Dialog;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/culture/create")]
    public partial class Create : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Pages\Cultures\Create.razor"
  
    string strTitle =
        string.Format("{0} {1}",
        Resources.Actions.CreateOf,
        Resources.Models.Cultures.Culture);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12 grid-margin");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "card");
            __builder.OpenElement(4, "div");
            __builder.AddAttribute(5, "class", "card-body");
            __builder.OpenElement(6, "h4");
            __builder.AddAttribute(7, "class", "card-title");
            __builder.AddContent(8, 
#nullable restore
#line 14 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Pages\Cultures\Create.razor"
                                    strTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(9, "\r\n            ");
            __builder.OpenComponent<WebApplication.EndPoints.Client.Pages.Cultures.FormEditor>(10);
            __builder.AddAttribute(11, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<ViewModels.Culture.CreateViewModel>(
#nullable restore
#line 15 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Pages\Cultures\Create.razor"
                               Model

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(12, "OnValidSubmit", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, 
#nullable restore
#line 15 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Pages\Cultures\Create.razor"
                                                     Submit

#line default
#line hidden
#nullable disable
            )));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 20 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Pages\Cultures\Create.razor"
       

    int cultureId { get; set; }
    public ViewModels.Culture.CreateViewModel Model { get; set; }

    protected override void OnInitialized()
    {
        Model =
            new ViewModels.Culture.CreateViewModel();
    }

    private async Task Submit()
    {

        var response = 
            await client.PostAsJsonAsync("Cultures", Model);

        navigationManager.NavigateTo(uri: "/cultures", forceLoad: false);
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private NavigationManager navigationManager { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
