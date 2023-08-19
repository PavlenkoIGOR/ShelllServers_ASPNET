using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Routing;
using Microsoft.VisualBasic;
using System.Globalization;
using System.IO;
using System.Net;
using System.Text;

namespace ShelllServers_ASPNET
{
    public static class EndpointsMapper
    {
        //подключение домашней страницы
        public static void MapHTML(this IEndpointRouteBuilder routeBuilder)
        {
            routeBuilder.MapGet("/", async context =>
            {
                var viewPath = Path.Combine(Directory.GetCurrentDirectory(), "Views", "Index.html");
                var html = new StringBuilder(await File.ReadAllTextAsync(viewPath));
                //.Replace("<!--SIDEBAR-->", sidebarHTML)
                //.Replace("<!--FOOTER-->", footerHTML);
                await context.Response.WriteAsync(html.ToString());
            });
        }

        //подключение всех стилей
        public static void MapCSS (this IEndpointRouteBuilder routeBuilder)
        {
            string[] styles = { "IndexStyles.scss" };
            foreach (var styleFile in styles)
            {
                routeBuilder.MapGet($"wwwroot/CSS/{styleFile}", async context =>
                {
                    var viewCSS = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "CSS", $"{styleFile}");
                    var css = new StringBuilder(await File.ReadAllTextAsync(viewCSS));
                    //.Replace("<!--SIDEBAR-->", sidebarHTML)
                    //.Replace("<!--FOOTER-->", footerHTML);
                    await context.Response.WriteAsync(css.ToString());
                });
            }
        }

        //подключение всех JS-файлов
        public static void MapJS(this IEndpointRouteBuilder routeBuilder)
        {
            string[] jscripts = { "Index.js" };
            foreach (var scriptFile in jscripts)
            {
                routeBuilder.MapGet($"wwwroot/JS/{scriptFile}", async context =>
                {
                    var viewJS = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "JS", $"{scriptFile}");
                    var js = new StringBuilder(await File.ReadAllTextAsync(viewJS));
                    //.Replace("<!--SIDEBAR-->", sidebarHTML)
                    //.Replace("<!--FOOTER-->", footerHTML);
                    await context.Response.WriteAsync(js.ToString());
                });
            }
        }

        //подключение всех изображений
        public static void MapIMG(this IEndpointRouteBuilder routeBuilder)
        {
            string[] imgs = { "logo.png", "layer-1.jpg", "layer-2.png", "layer-5.png" }; //имеет значение названия  файлов. ППЦ...
            foreach (var picFile in imgs)
            {
                routeBuilder.MapGet($"wwwroot/IMG/{picFile}", async context =>
                {
                    var viewIMG = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", "IMG", $"{picFile}");
                    var img = await File.ReadAllBytesAsync(viewIMG);
                    //.Replace("<!--SIDEBAR-->", sidebarHTML)
                    //.Replace("<!--FOOTER-->", footerHTML);
                    await context.Response.Body.WriteAsync(img);
                });
            }
        }
    }
}
