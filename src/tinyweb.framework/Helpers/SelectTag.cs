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
            return string.Empty;
            //ExecutionResult er = hi.Execute(handler, this._requestContext, null);
            //return er.Result.ToString();            
            
         }

        public static string BuildOption(string value, string text)
        {
            return "<option value='" + value + "'>" + text + "</option>";
        }

    }
}
