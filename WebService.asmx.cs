using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Encosia.Samples.ASMX_CORS {
  [System.Web.Script.Services.ScriptService]
  public class WebService : System.Web.Services.WebService {
    [WebMethod]
    public string HelloWorld() {
      return "Hello World";
    }
  }
}
