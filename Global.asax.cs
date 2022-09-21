using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Security;
using System.Web.SessionState;

namespace final_project
{
    public class Global : System.Web.HttpApplication
    {
        protected void Application_Start(object sender, EventArgs e)
        {
            final_project.Models.Hunter.coreExposureFactor = 2;
            final_project.Models.Coordinator.fireControlFactor = 1.2;
        }
    }
}