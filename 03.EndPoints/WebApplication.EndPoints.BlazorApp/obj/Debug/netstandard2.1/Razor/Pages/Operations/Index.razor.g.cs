#pragma checksum "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ff6ac09e3432c6f4e4ce591530e372e0fea8bbb9"
// <auto-generated/>
#pragma warning disable 1591
namespace WebApplication.EndPoints.BlazorApp.Pages.Operations
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using System.Net.Http.Json;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using Microsoft.AspNetCore.Components.WebAssembly.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using WebApplication.EndPoints.BlazorApp;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using WebApplication.EndPoints.BlazorApp.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using Infrastructures;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using Infrastructures.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using Telerik.Blazor;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\_Imports.razor"
using Telerik.Blazor.Components;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
using ViewModels.Operation;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/operations")]
    public partial class Index : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
#nullable restore
#line 4 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
  
    string strTitle =
        string.Format("{0} {1}",
        Resources.Actions.ListOf,
        Resources.Models.Operation.EntityName);

    string strCreate =
        string.Format("{0} {1}",
        Resources.Actions.CreateOf,
        Resources.Models.Operation.EntityName);

#line default
#line hidden
#nullable disable
            __builder.OpenElement(0, "div");
            __builder.AddAttribute(1, "class", "col-12");
            __builder.OpenElement(2, "div");
            __builder.AddAttribute(3, "class", "accordion basic-accordion");
            __builder.AddAttribute(4, "id", "accordion");
            __builder.AddAttribute(5, "role", "tablist");
            __builder.OpenElement(6, "div");
            __builder.AddAttribute(7, "class", "card");
            __builder.OpenElement(8, "div");
            __builder.AddAttribute(9, "class", "card-header");
            __builder.AddAttribute(10, "role", "tab");
            __builder.AddAttribute(11, "id", "heading");
            __builder.OpenElement(12, "h6");
            __builder.AddAttribute(13, "class", "mb-0");
            __builder.OpenElement(14, "a");
            __builder.AddAttribute(15, "class", "collapsed");
            __builder.AddAttribute(16, "data-toggle", "collapse");
            __builder.AddAttribute(17, "href", "#collapse");
            __builder.AddAttribute(18, "aria-expanded", "false");
            __builder.AddAttribute(19, "aria-controls", "collapse");
            __builder.AddMarkupContent(20, "<i class=\"card-icon mdi mdi-magnify\"></i>");
            __builder.AddContent(21, 
#nullable restore
#line 22 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                  Resources.Buttons.Search

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(22, "\r\n            ");
            __builder.OpenElement(23, "div");
            __builder.AddAttribute(24, "id", "collapse");
            __builder.AddAttribute(25, "class", "collapse");
            __builder.AddAttribute(26, "role", "tabpanel");
            __builder.AddAttribute(27, "aria-labelledby", "heading");
            __builder.AddAttribute(28, "data-parent", "#accordion");
            __builder.OpenElement(29, "div");
            __builder.AddAttribute(30, "class", "card-body");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Forms.EditForm>(31);
            __builder.AddAttribute(32, "Model", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Object>(
#nullable restore
#line 28 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                     request

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(33, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Forms.EditContext>)((context) => (__builder2) => {
                __builder2.OpenElement(34, "div");
                __builder2.AddAttribute(35, "class", "row");
                __builder2.OpenElement(36, "div");
                __builder2.AddAttribute(37, "class", "col-md-6");
                __builder2.OpenElement(38, "div");
                __builder2.AddAttribute(39, "class", "form-group");
                __builder2.OpenElement(40, "div");
                __builder2.AddAttribute(41, "class", "form-check form-check-flat");
                __builder2.OpenElement(42, "label");
                __builder2.AddAttribute(43, "class", "form-check-label");
                __builder2.OpenElement(44, "input");
                __builder2.AddAttribute(45, "type", "checkbox");
                __builder2.AddAttribute(46, "id", "isActive");
                __builder2.AddAttribute(47, "class", "form-check-input");
                __builder2.AddAttribute(48, "checked", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 36 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                                                 request.IsActive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(49, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => request.IsActive = __value, request.IsActive));
                __builder2.SetUpdatesAttributeName("checked");
                __builder2.CloseElement();
                __builder2.AddContent(50, 
#nullable restore
#line 36 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                                                                      Resources.DataDictionary.IsActive

#line default
#line hidden
#nullable disable
                );
                __builder2.AddMarkupContent(51, "<i class=\"input-helper\"></i>");
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(52, "\r\n\r\n                        ");
                __builder2.OpenElement(53, "div");
                __builder2.AddAttribute(54, "class", "row");
                __builder2.OpenElement(55, "div");
                __builder2.AddAttribute(56, "class", "col-md-6");
                __builder2.OpenElement(57, "div");
                __builder2.AddAttribute(58, "class", "form-group row");
                __builder2.OpenElement(59, "label");
                __builder2.AddAttribute(60, "class", "col-sm-3 col-form-label");
                __builder2.AddAttribute(61, "for", "name");
                __builder2.AddContent(62, 
#nullable restore
#line 47 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                       Resources.Models.Operation.Name

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(63, "\r\n                                    ");
                __builder2.OpenElement(64, "div");
                __builder2.AddAttribute(65, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(66);
                __builder2.AddAttribute(67, "id", "name");
                __builder2.AddAttribute(68, "class", "form-control");
                __builder2.AddAttribute(69, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 49 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                               request.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(70, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => request.Name = __value, request.Name))));
                __builder2.AddAttribute(71, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => request.Name));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(72, "\r\n\r\n                            ");
                __builder2.OpenElement(73, "div");
                __builder2.AddAttribute(74, "class", "col-md-6");
                __builder2.OpenElement(75, "div");
                __builder2.AddAttribute(76, "class", "form-group row");
                __builder2.OpenElement(77, "label");
                __builder2.AddAttribute(78, "class", "col-sm-3 col-form-label");
                __builder2.AddAttribute(79, "for", "displayName");
                __builder2.AddContent(80, 
#nullable restore
#line 56 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                              Resources.DataDictionary.DisplayName

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(81, "\r\n                                    ");
                __builder2.OpenElement(82, "div");
                __builder2.AddAttribute(83, "class", "col-sm-9");
                __builder2.OpenComponent<Microsoft.AspNetCore.Components.Forms.InputText>(84);
                __builder2.AddAttribute(85, "id", "displayName");
                __builder2.AddAttribute(86, "class", "form-control");
                __builder2.AddAttribute(87, "Value", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 58 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                                      request.DisplayName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(88, "ValueChanged", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<Microsoft.AspNetCore.Components.EventCallback<System.String>>(Microsoft.AspNetCore.Components.EventCallback.Factory.Create<System.String>(this, Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.CreateInferredEventCallback(this, __value => request.DisplayName = __value, request.DisplayName))));
                __builder2.AddAttribute(89, "ValueExpression", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.Linq.Expressions.Expression<System.Func<System.String>>>(() => request.DisplayName));
                __builder2.CloseComponent();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(90, "\r\n\r\n                        ");
                __builder2.OpenElement(91, "div");
                __builder2.AddAttribute(92, "class", "row");
                __builder2.OpenElement(93, "div");
                __builder2.AddAttribute(94, "class", "col-md-6");
                __builder2.OpenElement(95, "div");
                __builder2.AddAttribute(96, "class", "form-group row");
                __builder2.OpenElement(97, "label");
                __builder2.AddAttribute(98, "class", "col-sm-3 col-form-label");
                __builder2.AddAttribute(99, "for", "accessType");
                __builder2.AddContent(100, 
#nullable restore
#line 67 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                             Resources.Models.Operation.AccessType

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(101, "\r\n                                    ");
                __builder2.OpenElement(102, "div");
                __builder2.AddAttribute(103, "class", "col-sm-9");
                __builder2.OpenElement(104, "select");
                __builder2.AddAttribute(105, "id", "accessType");
                __builder2.AddAttribute(106, "class", "form-control");
                __builder2.AddAttribute(107, "value", Microsoft.AspNetCore.Components.BindConverter.FormatValue(
#nullable restore
#line 70 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                            request.AccessType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(108, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.CreateBinder(this, __value => request.AccessType = __value, request.AccessType));
                __builder2.SetUpdatesAttributeName("value");
                __builder2.OpenElement(109, "option");
                __builder2.CloseElement();
#nullable restore
#line 72 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                             foreach (var item in request.GetAccessTypes())
                                            {

#line default
#line hidden
#nullable disable
                __builder2.OpenElement(110, "option");
                __builder2.AddAttribute(111, "value", 
#nullable restore
#line 74 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                item.Value

#line default
#line hidden
#nullable disable
                );
                __builder2.AddContent(112, 
#nullable restore
#line 74 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                             item.Text

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
#nullable restore
#line 75 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                            }

#line default
#line hidden
#nullable disable
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.CloseElement();
                __builder2.AddMarkupContent(113, "\r\n\r\n                        ");
                __builder2.OpenElement(114, "button");
                __builder2.AddAttribute(115, "type", "button");
                __builder2.AddAttribute(116, "class", "btn btn-success mr-2");
                __builder2.AddAttribute(117, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 83 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                     search

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(118, 
#nullable restore
#line 83 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                              Resources.Buttons.Search

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
                __builder2.AddMarkupContent(119, "\r\n                        ");
                __builder2.OpenElement(120, "button");
                __builder2.AddAttribute(121, "type", "button");
                __builder2.AddAttribute(122, "class", "btn btn-light");
                __builder2.AddAttribute(123, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 84 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                              reset

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddContent(124, 
#nullable restore
#line 84 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                      Resources.Buttons.Cancel

#line default
#line hidden
#nullable disable
                );
                __builder2.CloseElement();
            }
            ));
            __builder.CloseComponent();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(125, "\r\n\r\n");
            __builder.OpenElement(126, "div");
            __builder.AddAttribute(127, "class", "col-12");
            __builder.OpenElement(128, "div");
            __builder.AddAttribute(129, "class", "card");
            __builder.OpenElement(130, "div");
            __builder.AddAttribute(131, "class", "card-body");
            __builder.OpenElement(132, "h4");
            __builder.AddAttribute(133, "class", "card-title");
            __builder.AddContent(134, 
#nullable restore
#line 97 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                    strTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(135, "<p class=\"card-description\"></p>");
#nullable restore
#line 98 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
             if (data.Result == null)
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(136, "p");
            __builder.OpenElement(137, "em");
            __builder.AddContent(138, 
#nullable restore
#line 100 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                        Resources.DataDictionary.Loading

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
#nullable restore
#line 101 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
            }
            else
            {

#line default
#line hidden
#nullable disable
            __builder.OpenElement(139, "p");
            __builder.AddAttribute(140, "class", "card-description");
            __builder.OpenElement(141, "a");
            __builder.AddAttribute(142, "class", "btn btn-primary btn-fw");
            __builder.AddAttribute(143, "href", "/Operation/Create");
            __builder.AddContent(144, 
#nullable restore
#line 105 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                strCreate

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.AddMarkupContent(145, "\r\n                ");
            __Blazor.WebApplication.EndPoints.BlazorApp.Pages.Operations.Index.TypeInference.CreateTelerikGrid_0(__builder, 146, 147, 
#nullable restore
#line 107 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                    data.Result

#line default
#line hidden
#nullable disable
            , 148, Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Telerik.Blazor.Components.GridReadEventArgs>(this, 
#nullable restore
#line 108 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                     ReadItems

#line default
#line hidden
#nullable disable
            ), 149, 
#nullable restore
#line 109 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                          data.TotalCount

#line default
#line hidden
#nullable disable
            , 150, 
#nullable restore
#line 110 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                       true

#line default
#line hidden
#nullable disable
            , 151, "no-scroll", 152, (__builder2) => {
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(153);
                __builder2.AddAttribute(154, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 113 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                            Resources.DataDictionary.IsActive

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(155, "Width", "50px");
                __builder2.AddAttribute(156, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.OpenElement(157, "input");
                    __builder3.AddAttribute(158, "type", "checkbox");
                    __builder3.AddAttribute(159, "checked", 
#nullable restore
#line 115 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                  (context as OperationDataViewModel).IsActive

#line default
#line hidden
#nullable disable
                    );
                    __builder3.AddAttribute(160, "disabled", true);
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(161, "\r\n                        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(162);
                __builder2.AddAttribute(163, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 118 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                            Resources.Models.Operation.Name

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(164, "Width", "200px");
                __builder2.AddAttribute(165, "Template", (Microsoft.AspNetCore.Components.RenderFragment<System.Object>)((context) => (__builder3) => {
                    __builder3.OpenElement(166, "div");
                    __builder3.AddAttribute(167, "class", "text-left");
                    __builder3.AddContent(168, 
#nullable restore
#line 121 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                      (context as OperationDataViewModel).Name

#line default
#line hidden
#nullable disable
                    );
                    __builder3.CloseElement();
                }
                ));
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(169, "\r\n                        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(170);
                __builder2.AddAttribute(171, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 125 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                             nameof(OperationDataViewModel.DisplayName)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(172, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 125 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                                  Resources.DataDictionary.DisplayName

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(173, "Width", "300px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(174, "\r\n                        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(175);
                __builder2.AddAttribute(176, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 126 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                             nameof(OperationDataViewModel.Parent)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(177, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 126 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                             Resources.Models.Operation.Parent

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(178, "Width", "200px");
                __builder2.CloseComponent();
                __builder2.AddMarkupContent(179, "\r\n                        ");
                __builder2.OpenComponent<Telerik.Blazor.Components.GridColumn>(180);
                __builder2.AddAttribute(181, "Field", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 127 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                             nameof(OperationDataViewModel.AccessTypeValue)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(182, "Title", Microsoft.AspNetCore.Components.CompilerServices.RuntimeHelpers.TypeCheck<System.String>(
#nullable restore
#line 127 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
                                                                                                      Resources.Models.Operation.AccessType

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(183, "Width", "200px");
                __builder2.CloseComponent();
            }
            );
#nullable restore
#line 130 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
            }

#line default
#line hidden
#nullable disable
            __builder.CloseElement();
            __builder.CloseElement();
            __builder.CloseElement();
        }
        #pragma warning restore 1998
#nullable restore
#line 135 "H:\MohsenPrograming\2020\CMS_WebApplication\WebApplication\03.EndPoints\WebApplication.EndPoints.BlazorApp\Pages\Operations\Index.razor"
       

    protected ViewPagingDataResult<OperationDataViewModel> data { get; set; }
    protected SearchViewModel request { get; set; }

    protected override void OnInitialized()
    {
        data = new ViewPagingDataResult<OperationDataViewModel>();
        request = new SearchViewModel();
    }

    protected async Task ReadItems(GridReadEventArgs args = null)
    {
        request.Page = args.Request.Page;
        request.TotalCount = data.TotalCount;

        await getData();
    }

    private async Task reset()
    {
        request = new SearchViewModel();
        await getData();
    }

    private async Task search() => await getData();

    private async Task getData()
    {
        var response =
            await client.PostAsJsonAsync($"Operations/GetData", request);

        data = await response.Content.ReadFromJsonAsync<ViewPagingDataResult<OperationDataViewModel>>();
    }

    private async Task remove(int operationId)
    {
        await client.DeleteAsync($"Operations?operationId={operationId}");
        await OnInitializedAsync();
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private HttpClient client { get; set; }
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IJSRuntime JSRuntime { get; set; }
    }
}
namespace __Blazor.WebApplication.EndPoints.BlazorApp.Pages.Operations.Index
{
    #line hidden
    internal static class TypeInference
    {
        public static void CreateTelerikGrid_0<TItem>(global::Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder, int seq, int __seq0, global::System.Collections.Generic.IEnumerable<TItem> __arg0, int __seq1, global::Microsoft.AspNetCore.Components.EventCallback<global::Telerik.Blazor.Components.GridReadEventArgs> __arg1, int __seq2, global::System.Int32 __arg2, int __seq3, global::System.Boolean __arg3, int __seq4, global::System.String __arg4, int __seq5, global::Microsoft.AspNetCore.Components.RenderFragment __arg5)
        {
        __builder.OpenComponent<global::Telerik.Blazor.Components.TelerikGrid<TItem>>(seq);
        __builder.AddAttribute(__seq0, "Data", __arg0);
        __builder.AddAttribute(__seq1, "OnRead", __arg1);
        __builder.AddAttribute(__seq2, "TotalCount", __arg2);
        __builder.AddAttribute(__seq3, "Pageable", __arg3);
        __builder.AddAttribute(__seq4, "Class", __arg4);
        __builder.AddAttribute(__seq5, "GridColumns", __arg5);
        __builder.CloseComponent();
        }
    }
}
#pragma warning restore 1591
