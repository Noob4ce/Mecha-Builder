using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using final_project.Models;

namespace final_project
{
    public partial class WebForm4 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["Mechas"] != null)
                {
                    Dictionary<int, Mecha> mechas = new Dictionary<int, Mecha>();
                    mechas = (Dictionary<int, Mecha>)Session["Mechas"];

                    foreach (KeyValuePair<int, Mecha> m in mechas)
                    {
                        Mecha currentMecha = m.Value;
                        string mechaInfo = currentMecha.getFullName();
                        drplstMechas.Items.Add(new ListItem(mechaInfo, currentMecha.MechaId.ToString()));
                    }
                }

                if (Session["currentShip"] != null)
                {
                    Mecha currentMecha = (Mecha)Session["currentShip"];

                    if (currentMecha.getMechaType() == "Hunter")
                    {
                        mechaImage.ImageUrl = "App_themes/images/hunter.png";
                    }
                    else if (currentMecha.getMechaType() == "Coordinator")
                    {
                        mechaImage.ImageUrl = "App_themes/images/coordinator.png";

                    }

                    drplstMechas.SelectedValue = currentMecha.MechaId.ToString();

                    populateMecha(currentMecha);
                }
            }
        }



        protected Mecha findMecha(int id)
        {
            Dictionary<int, Mecha> mechas = new Dictionary<int, Mecha>();
            mechas = (Dictionary<int, Mecha>)Session["Mechas"];
            try
            {
                return mechas[id];
            }
            catch (KeyNotFoundException)
            {
                return null;
            }
        }

        protected void handleSeletedChange(object sender, EventArgs e)
        {
            try
            {
                int id = int.Parse(drplstMechas.SelectedValue);
                Mecha currentMecha = findMecha(id);
                if (currentMecha.getMechaType() == "Hunter")
                {
                    mechaImage.ImageUrl = "App_themes/images/hunter.png";
                }
                else if (currentMecha.getMechaType() == "Coordinator")
                {
                    mechaImage.ImageUrl = "App_themes/images/coordinator.png";

                }
                populateMecha(currentMecha);
            }
            catch (FormatException)
            {
                tblWeapon.Rows.Clear();
                tblShield.Rows.Clear();
                mechaImage.ImageUrl = "";

                TableCell weaponCell = new TableCell();
                TableCell sheildCell = new TableCell();

                TableCell attackCell = new TableCell();
                TableCell defenceCell = new TableCell();

                weaponCell.Text = "Weapon";
                sheildCell.Text = "Shield";

                attackCell.Text = "Attack";
                defenceCell.Text = "Defence";

                TableHeaderRow HeaderA = new TableHeaderRow();
                HeaderA.CssClass = "fw-bold";

                tblAttack.Rows.Add(HeaderA);
                HeaderA.Cells.Add(attackCell);

                TableHeaderRow HeaderD = new TableHeaderRow();
                HeaderD.CssClass = "fw-bold";

                tblDefence.Rows.Add(HeaderD);
                HeaderD.Cells.Add(defenceCell);


                TableHeaderRow Header1 = new TableHeaderRow();
                Header1.CssClass = "fw-bold";

                tblWeapon.Rows.Add(Header1);
                Header1.Cells.Add(weaponCell);

                TableHeaderRow Header2 = new TableHeaderRow();
                Header2.CssClass = "fw-bold";

                tblShield.Rows.Add(Header2);
                Header2.Cells.Add(sheildCell);
            }



        }

        protected void populateMecha(Mecha mecha)
        {
            tblWeapon.Rows.Clear();
            tblShield.Rows.Clear();

            tblAttack.Rows.Clear();
            tblDefence.Rows.Clear();

            TableCell weaponCell = new TableCell();
            TableCell sheildCell = new TableCell();

            TableCell attackCell = new TableCell();
            TableCell defenceCell = new TableCell();

            weaponCell.Text = "Weapon";
            sheildCell.Text = "Shield";

            attackCell.Text = "Attack";
            defenceCell.Text = "Defence";

            TableHeaderRow HeaderA = new TableHeaderRow();
            HeaderA.CssClass = "fw-bold";

            tblAttack.Rows.Add(HeaderA);
            HeaderA.Cells.Add(attackCell);

            TableHeaderRow HeaderD = new TableHeaderRow();
            HeaderD.CssClass = "fw-bold";

            tblDefence.Rows.Add(HeaderD);
            HeaderD.Cells.Add(defenceCell);


            TableHeaderRow Header1 = new TableHeaderRow();
            Header1.CssClass = "fw-bold";

            tblWeapon.Rows.Add(Header1);
            Header1.Cells.Add(weaponCell);

            TableHeaderRow Header2 = new TableHeaderRow();
            Header2.CssClass = "fw-bold";

            tblShield.Rows.Add(Header2);
            Header2.Cells.Add(sheildCell);

            foreach (Module m in mecha.MechaModules)
            {

                if (m.ModuleType == "Weapon")
                {
                    TableRow wRow = new TableRow();
                    weaponCell = new TableCell();
                    tblWeapon.Rows.Add(wRow);
                    weaponCell.Text = m.ModuleName;
                    wRow.Cells.Add(weaponCell);

                }
                else if (m.ModuleType == "Shield")
                {
                    TableRow sRow = new TableRow();
                    sheildCell = new TableCell();
                    tblShield.Rows.Add(sRow);
                    sheildCell.Text = m.ModuleName;
                    sRow.Cells.Add(sheildCell);
                }

            }
            TableRow finalRow = new TableRow();
            finalRow.CssClass = "text-warning fw-bold";
            tblAttack.Rows.Add(finalRow);
            weaponCell = new TableCell();
            weaponCell.Text = mecha.calculateMechaAttack().ToString();
            finalRow.Cells.Add(weaponCell);

            finalRow = new TableRow();
            finalRow.CssClass = "text-warning fw-bold";

            tblDefence.Rows.Add(finalRow);
            sheildCell = new TableCell();
            sheildCell.Text = mecha.calculateMechaDefence().ToString();
            finalRow.Cells.Add(sheildCell);
        }

       


        
    }
}