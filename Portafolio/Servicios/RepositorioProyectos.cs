using Portafolio.Models;

namespace Portafolio.Servicios
{
    public interface IRepositorioProyectos
    {
        List<Proyecto> ObtenerProyectos();
    }

    public class RepositorioProyectos: IRepositorioProyectos
    {
        public List<Proyecto> ObtenerProyectos()
        {
            return new List<Proyecto>() {
                new Proyecto
            {
                Titulo = "Amazon",
                Descripcion = "Plataforma de mensajeria instantanea y chat de voz.",
                Link = "https://discord.com",
                ImagenURL = "/imagenes/discord.png"
            },
                new Proyecto
            {
                Titulo = "Facebook",
                Descripcion = "Red social para compartir en comunidades",
                Link = "https://facebook.com",
                ImagenURL = "/imagenes/facebook.jpg"
            },
                new Proyecto
            {
                Titulo = "GDLWebcamp",
                Descripcion = "Pagina para conferencias de diseño web.",
                Link = "https://aaron-proyecto-gdlwebcamp.netlify.app/",
                ImagenURL = "/imagenes/aaron-proyecto-gdlwebcamp.netlify.app.jpeg"
            },
                new Proyecto
            {
                Titulo = "Steam",
                Descripcion = "Plataforma para la distribución digital de videojuegos",
                Link = "https://store.steampowered.com",
                ImagenURL = "/imagenes/steam.jpg"
            },
                new Proyecto
            {
                Titulo = "Freelancer",
                Descripcion = "Pagina para el desarrollo y diseño Freelancer.",
                Link = "https://aaron-freelancer.netlify.app/",
                ImagenURL = "/imagenes/aaron-freelancer.netlify.app.jpeg"
            },
                new Proyecto
            {
                Titulo = "Blog de viajes",
                Descripcion = "Blog sobre viajes.",
                Link = "https://aaron-blog-viajes.netlify.app/",
                ImagenURL = "/imagenes/aaron-blog-viajes.netlify.app.jpeg"
            },
                new Proyecto
            {
                Titulo = "FrontendStore",
                Descripcion = "Pagina para una tienda de ropa en linea.",
                Link = "https://aaron-frontendstore.netlify.app/",
                ImagenURL = "/imagenes/aaron-frontendstore.netlify.app.jpeg"
            },
                new Proyecto
            {
                Titulo = "Cafe Blog",
                Descripcion = "Blog de cafe con consejos y cursos.",
                Link = "https://aaron-cafe-blog-mobilfirst.netlify.app/",
                ImagenURL = "/imagenes/aaron-cafe-blog-mobilfirst.netlify.app.jpeg"
            },
                new Proyecto
            {
                Titulo = "Bienes Raices",
                Descripcion = "Pagina para la venta de casas y departamentos de lujo.",
                Link = "https://aaron-bienes-raices-responsive.netlify.app/",
                ImagenURL = "/imagenes/aaron-bienes-raices-responsive.netlify.app.jpeg"
            },
            };
        }
    }
}
