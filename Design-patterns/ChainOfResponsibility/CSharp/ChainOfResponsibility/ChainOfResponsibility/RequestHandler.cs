using System.Collections.Generic;
using ChainOfResponsibility.Handlers;

namespace ChainOfResponsibility
{
    public static class RequestHandler
    {
        public static void Handle(Requests request)
        {
            List<Handler> handlers = new List<Handler>
            {
                new Leader(request),
                new Manager(request),
                new Supervisor(request)
            };

            foreach (Handler handler in handlers)
            {
                if (!handler.IsApplicable) continue;

                bool isSuccess = handler.Handle();

                if (!isSuccess) break;
                if (!handler.PassToNextOnSuccess) break;
            }
        }
    }
}