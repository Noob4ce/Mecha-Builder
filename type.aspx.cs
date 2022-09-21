using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using final_project.Models;

namespace final_project
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void createShip(object sender, EventArgs e)
        {
            string name = txtName.Text;
            string type = rblShipType.SelectedValue;

            Mecha currentShip = new Mecha(name);

            if (type == "1")
            {
                currentShip = new Hunter(name);
            } 
            else if (type == "2")
            {
                currentShip = new Coordinator(name);
            }

            if (Session["Mechas"] == null)
            {
                Dictionary<int, Mecha> mechas = new Dictionary<int, Mecha>();
                mechas.Add(currentShip.MechaId, currentShip);
                Session["Mechas"] = mechas;
            }
            else
            {
                Dictionary<int, Mecha> mechas = new Dictionary<int, Mecha>();
                mechas = (Dictionary<int, Mecha>)Session["Mechas"];
                mechas.Add(currentShip.MechaId, currentShip);
                Session["Mechas"] = mechas;
            }

            Session["currentShip"] = currentShip;


            Response.Redirect( "module.aspx");
        }

        //protected void changeImage(object sender, EventArgs e)
        //{
        //    string s = rblShipType.SelectedValue;

        //    if (s == "1")
        //    {
        //        mechaImage.ImageUrl = "App_themes/images/hunter.png";
        //    } else if (s == "2")
        //    {
        //        mechaImage.ImageUrl = "App_themes/images/coordinator.png";
        //    }
        //}
    }
}