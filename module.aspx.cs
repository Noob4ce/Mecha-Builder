using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using final_project.Models;

namespace final_project
{
    public partial class WebForm3 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                Mecha currentMecha = (Mecha)Session["currentShip"];
                lblTest.Text = currentMecha.MechaName;
                lblEnergy.Text = "Total Energy: " + currentMecha.Energy.ToString();

                if (currentMecha.getMechaType() == "Hunter")
                {
                    mechaImage.ImageUrl = "App_themes/images/hunter.png";
                } 
                else if (currentMecha.getMechaType() == "Coordinator")
                {
                    mechaImage.ImageUrl = "App_themes/images/coordinator.png";
                }

                foreach (Module m in Module.GetModules())
                {
                    if (m.ModuleType == "Weapon")
                    {
                        chklstWeapons.Items.Add(new ListItem(m.ModuleName + " - Atk: " + m.Attack + " - Def: " + m.Defence +" - Cost: " + m.EnergyCost, m.ModuleId.ToString()));
                    }
                    else if (m.ModuleType == "Shield")
                    {
                        chklstShield.Items.Add(new ListItem(m.ModuleName + " - Atk: " + m.Attack + " - Def: " + m.Defence + " - Cost: " + m.EnergyCost, m.ModuleId.ToString()));
                    }
                }
            }
        }



        protected void addModule(object sender, EventArgs e)
        {
            if (IsValid)
            {
                Mecha currentShip = (Mecha)Session["currentShip"];

                foreach (ListItem li in chklstWeapons.Items)
                {
                    if (li.Selected)
                    {
                        Module m = Module.FindModule(li.Value);
                        currentShip.MechaModules.Add(m);
                    }

                }

                foreach (ListItem li in chklstShield.Items)
                {
                    if (li.Selected)
                    {
                        Module m = Module.FindModule(li.Value);
                        currentShip.MechaModules.Add(m);
                    }

                }
                Response.Redirect("summary.aspx");

            }

        }

        protected void validateChklist(object sender, ServerValidateEventArgs e)
        {
            int wCount = 0;
            int sCount = 0;

            foreach (ListItem li in chklstWeapons.Items)
            {
                if (li.Selected == true)
                {
                    wCount++;
                }
            }
            foreach (ListItem li in chklstShield.Items)
            {
                if (li.Selected == true)
                {
                    sCount++;
                }
            }

            if (wCount == 0 && sCount == 0)
            {
                e.IsValid = false;
            }
            else
            {
                e.IsValid = true;
            }
        }

        protected void validateEnergyCost(object sender, ServerValidateEventArgs e)
        {

            int totalCost = 0;
            Mecha currentMecha = (Mecha)Session["currentShip"];

            foreach (ListItem li in chklstWeapons.Items)
            {
                if (li.Selected == true)
                {
                    Module m = Module.FindModule(li.Value);
                    totalCost += m.EnergyCost;
                }

            }
            foreach (ListItem li in chklstShield.Items)
            {
                if (li.Selected == true)
                {
                    Module m = Module.FindModule(li.Value);
                    totalCost += m.EnergyCost;
                }

            }

            if (totalCost > currentMecha.Energy)
            {
                e.IsValid = false;
                cvEnerygy.ErrorMessage = "Your design has exceeded the energy supply: " + currentMecha.Energy;
            }
            else
            {
                e.IsValid = true;
            }



        }


    }
}