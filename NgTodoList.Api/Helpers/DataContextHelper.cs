using NgTodoList.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NgTodoList.Api.Helpers
{
    public class DataContextHelper
    {
        public static NgTodoListDataContext CurrentDataContext
        {
            get { return HttpContext.Current.Items["_EntityContext"] as NgTodoListDataContext; }
        }
    }
}