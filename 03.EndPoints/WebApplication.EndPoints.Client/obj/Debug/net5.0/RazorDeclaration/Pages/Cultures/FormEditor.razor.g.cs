// <auto-generated/>
#pragma warning disable 1591
#pragma warning disable 0414
#pragma warning disable 0649
#pragma warning disable 0169

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
    public partial class FormEditor : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
        }
        #pragma warning restore 1998
#nullable restore
#line 82 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Pages\Cultures\FormEditor.razor"
 
    [Parameter]
    public EventCallback OnValidSubmit { get; set; }

    [Parameter]
    public ViewModels.Culture.CreateViewModel Model { get; set; }

    private void HandleValidSubmit()
    {
        OnValidSubmit.InvokeAsync(null);
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
#pragma warning restore 1591
