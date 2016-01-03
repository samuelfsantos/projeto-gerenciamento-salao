using System.Web.Mvc;

namespace SFS.Salao.Infra.CrossCutting.MvcFilters
{
    public class GlobalErrorHandler : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            base.OnActionExecuting(filterContext);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // GRAVA LOG
            if (filterContext.Exception != null)
            {
                // CRIAR MÉTODO NA CONTROLLER PARA GRAVAR LOG OU GRAVAR NO BANCO
                //filterContext.Controller.TempData["ErrorMessage"] = filterContext.Exception.Message;
            }

            base.OnActionExecuted(filterContext);
        }

        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            base.OnResultExecuting(filterContext);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            base.OnResultExecuted(filterContext);
        }
    }
}