#pragma checksum "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "376995ae2b8c86202a1b76315667018bf6e884b4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_TimeArrivalBus__TimeArrivalBus), @"mvc.1.0.view", @"/Views/Shared/TimeArrivalBus/_TimeArrivalBus.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\_ViewImports.cshtml"
using MásMovilidad;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\_ViewImports.cshtml"
using MásMovilidad.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
using MásMovilidad.Models.Bus;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"376995ae2b8c86202a1b76315667018bf6e884b4", @"/Views/Shared/TimeArrivalBus/_TimeArrivalBus.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"35b7af54ffd9d4d479c1f315ad6a4e6a077d5ba8", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_TimeArrivalBus__TimeArrivalBus : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BusTimeArrive>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
 if (Model.code.Equals("00"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row\">\r\n");
#nullable restore
#line 7 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
         foreach (var line in Model.data[0].Arrive)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <div class=\"col-12 col-sm-12 col-md-6 mt-3\">\r\n                <div class=\"card text-center mt-3\">\r\n                    <div class=\"card-body\">\r\n                        <h5 class=\"card-title\">Información Línea ");
#nullable restore
#line 12 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                                                            Write(line.line);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <hr>\r\n\r\n                        <label><strong>Destino</strong></label>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 16 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                                        Write(line.destination);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                        <label><strong>Tiempo De Llegada</strong></label>\r\n\r\n");
#nullable restore
#line 20 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                          
                            var tiempoLlegadaMin = line.estimateArrive / 60;                        
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        <p class=\"card-text\">");
#nullable restore
#line 24 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                                        Write(tiempoLlegadaMin);

#line default
#line hidden
#nullable disable
            WriteLiteral(" minutos</p>\r\n\r\n                        <label><strong>Distancia Bus</strong></label>\r\n                        <p class=\"card-text\">");
#nullable restore
#line 27 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                                        Write(line.DistanceBus);

#line default
#line hidden
#nullable disable
            WriteLiteral(" metros</p>\r\n\r\n                        <label><strong>¿Es Cabecera?</strong></label>\r\n");
#nullable restore
#line 30 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                         if (@line.isHead != "False")
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"card-text\">Si</p>\r\n");
#nullable restore
#line 33 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <p class=\"card-text\">No</p>\r\n");
#nullable restore
#line 37 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                    </div>\r\n                </div>\r\n            </div>\r\n");
#nullable restore
#line 41 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </div>\r\n");
#nullable restore
#line 44 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
     if (Model.data[0].Incident.ListaIncident.data.Count > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"row mt-3\">\r\n            <div class=\"col-md-12\">\r\n                <h1 class=\"display-4 text-center\">Información De Incidentes</h1>\r\n            </div>\r\n        </div>\r\n");
            WriteLiteral("        <div class=\"row\">\r\n");
#nullable restore
#line 53 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
             foreach (var incidente in Model.data[0].Incident.ListaIncident.data)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 col-sm-12 col-md-12 mt-3\">\r\n                    <div class=\"card text-center\">\r\n                        <h5 class=\"card-header\">");
#nullable restore
#line 57 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                                           Write(incidente.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                        <div class=\"card-body\">\r\n                            <h6 class=\"card-title\">Fecha Publicación</h6>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 60 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                                            Write(incidente.pubDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <h6 class=\"card-title\">Desde</h6>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 63 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                                            Write(incidente.rssFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <h6 class=\"card-title\">Dirección</h6>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 66 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                                            Write(incidente.rssTo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                            \r\n                            <h6 class=\"card-title\">Causa</h6>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 69 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                                            Write(incidente.cause);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <h6 class=\"card-title\">Causa</h6>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 72 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                                            Write(incidente.effect);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n                            <h6 class=\"card-title\">Descripción</h6>\r\n                            <p class=\"card-text\">");
#nullable restore
#line 75 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
                                            Write(Html.Raw(incidente.description));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                        </div>                \r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 79 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 81 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"alert alert-info mt-3 text-center\" role=\"alert\">\r\n            No existen incidencias\r\n        </div>\r\n");
#nullable restore
#line 87 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 87 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
     
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"row mt-3\">\r\n        <div class=\"col-md-12\">\r\n            <div class=\"alert alert-danger text-center\" role=\"alert\">\r\n                No se han encontrado resultados\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 98 "c:\Users\hiberus.dacn\Desktop\MásMovilidad\Views\Shared\TimeArrivalBus\_TimeArrivalBus.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BusTimeArrive> Html { get; private set; }
    }
}
#pragma warning restore 1591
