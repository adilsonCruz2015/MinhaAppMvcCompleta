using DevIO.Business.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace DevIO.App.Controllers.Comum
{
    public class BaseController : Controller
    {
        public BaseController(INotificador notificador)
        {
            _notificador = notificador;
        }

        private readonly INotificador _notificador;

        protected bool OperacaoValida()
        {
            return !_notificador.TemNotificacao();
        }
    }
}
