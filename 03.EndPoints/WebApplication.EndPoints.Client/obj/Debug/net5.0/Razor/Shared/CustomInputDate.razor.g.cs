#pragma checksum "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Shared\CustomInputDate.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e80bc71889e1e22b5632054195714e0cde85987b"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.EndPoints.Client.Shared
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
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
    public partial class CustomInputDate : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 1 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Shared\CustomInputDate.razor"
 if (Dtx.Globalization.CultureInfo.GetCurrentCulture() == Dtx.Globalization.Cultures.Farsi)
{

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "input");
            __builder.AddAttribute(1, "type", "text");
            __builder.AddAttribute(2, "id", 
#nullable restore
#line 3 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Shared\CustomInputDate.razor"
                            Name

#line default
#line hidden
#nullable disable
            );
            __builder.AddAttribute(3, "class", "form-control datepicker");
            __builder.AddAttribute(4, "readonly");
            __builder.AddAttribute(5, "onblur", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 3 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Shared\CustomInputDate.razor"
                                                                                    setValue

#line default
#line hidden
#nullable disable
            ));
            __builder.CloseElement();
#nullable restore
#line 4 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Shared\CustomInputDate.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __Blazor.WebApplication.EndPoints.Client.Shared.CustomInputDate.TypeInference.CreateInputDate_0(__builder, 6, 7, 
#nullable restore
#line 7 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Shared\CustomInputDate.razor"
                    Name

#line default
#line hidden
#nullable disable
            , 8, "form-control", 9, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.FocusEventArgs>(this, 
#nullable restore
#line 7 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Shared\CustomInputDate.razor"
                                                                                setValue

#line default
#line hidden
#nullable disable
            ), 10, 
#nullable restore
#line 7 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Shared\CustomInputDate.razor"
                                                            DateValue

#line default
#line hidden
#nullable disable
            , 11, Microsoft.AspNetCore.Components.EventCallback.Factory.Create(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => DateValue = __value, DateValue)), 12, () => DateValue);
#nullable restore
#line 8 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Shared\CustomInputDate.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 10 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.Client\Shared\CustomInputDate.razor"
       

    [Parameter]
    public EventCallback<DateTime?> OnBlur { get; set; }

    public static string StringValue { get; set; }

    public static DateTime DateValue { get; set; }

    [Parameter]
    public string Name { get; set; }

    protected override async Task OnInitializedAsync()
    {
        await JSRuntime.InvokeVoidAsync("includeDatePicker");
    }

    [JSInvokable]
    public static void SetInputDateValue(string stringValue)
    {
        StringValue = stringValue;
    }

    private async Task setValue()
    {
        if (Dtx.Globalization.CultureInfo.GetCurrentCulture() == Dtx.Globalization.Cultures.Farsi &&
        !string.IsNullOrWhiteSpace(StringValue))
        {
            var date = Dtx.Calendar.Convert.PersionToCivil(StringValue);
            await OnBlur.InvokeAsync(date);
        }
        else
        {
            await OnBlur.InvokeAsync(DateValue);
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
namespace __Blazor.WebApplication.EndPoints.Client.Shared.CustomInputDate
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateInputDate_0<TValue>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, System.Object __arg0, int __seq1, System.Object __arg1, int __seq2, global::System.Object __arg2, int __seq3, TValue __arg3, int __seq4, global::Microsoft.AspNetCore.Components.EventCallback<TValue> __arg4, int __seq5, global::System.Linq.Expressions.Expression<global::System.Func<TValue>> __arg5)
        {
        __builder.OpenComponent<global::Microsoft.AspNetCore.Components.Forms.InputDate<TValue>>(seq);
        __builder.AddAttribute(__seq0, "id", __arg0);
        __builder.AddAttribute(__seq1, "class", __arg1);
        __builder.AddAttribute(__seq2, "onblur", __arg2);
        __builder.AddAttribute(__seq3, "Value", __arg3);
        __builder.AddAttribute(__seq4, "ValueChanged", __arg4);
        __builder.AddAttribute(__seq5, "ValueExpression", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
