using MyCalcTestLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using AttributeRouting.Framework.Localization;
using AttributeRouting.Web.Constraints;
using AttributeRouting.Web.Http.WebHost;
using AttributeRouting.Web.Http.Framework;
using AttributeRouting.Web;
using AttributeRouting.Web.Http;
using AttributeRouting;

namespace CalcServiceDemo.Controllers
{
    [RoutePrefix("calc")]
    public class CalcController : ApiController
    {
        private readonly ICalcUtils _lib;


        public CalcController()
            : this(new CalcUtils())
        {
        }

        public CalcController(ICalcUtils calcUtils)
        {
            _lib = calcUtils;
        }

        [GET("add/{x}/{y}")]
        public string GetAdd(int x, int y)
        {
            return string.Format("result was: {0}", _lib.Add(x, y));
        }

        [GET("sub/{x}/{y}")]
        public string GetSub(int x, int y)
        {
            // TODO: implement subract
            //return string.Format("result was: {0}", _lib.Subtract(x, y));
            return string.Empty;
        }
    }
}