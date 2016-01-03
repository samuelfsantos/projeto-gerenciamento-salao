using System.Web.Mvc;

namespace SFS.Salao.UI.MVC
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
            //filters.Add(new GlobalErrorHandler()); // PARA DEFINIR O FILTRO GLOBALMENTE
        }
    }
}