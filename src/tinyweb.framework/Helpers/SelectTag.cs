using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web;
using System.Web.Routing;

namespace tinyweb.framework.Helpers
{
    public static class SelectTag
    {

               

        public static string For<T>(string value, string text)
        {

            var handler = Tinyweb.Handlers.SingleOrDefault(h => h.Type == typeof(T));
            if (handler == null)
            {
                throw new Exception("The handler {0} was not found".With(typeof(T).Name));
            }

           
            IHandlerInvoker hi = HandlerInvoker.Current;
           //Need to get the context somehow? the call the handler, returning the result for rendering 
            //ExecutionResult er = hi.Execute(handler, this._requestContext, null);
            //return er.Result.ToString();            
            
         }


    }
}
