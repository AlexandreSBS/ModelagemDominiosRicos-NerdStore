using Microsoft.AspNetCore.Mvc;
using NerdStore.Core.Bus;
using System;


namespace NerdStore.WebApp.MVC.Controllers
{
    public abstract class ControllerBase : Controller
    {
        private readonly IMediatorHandler _mediatorHandler;

        protected Guid ClienteId = Guid.Parse("4885e451-b0e4-4490-b959-04fabc806d32");

        protected ControllerBase(IMediatorHandler mediatorHandler)
        {
            _mediatorHandler = mediatorHandler;
        }
     
    }
}
