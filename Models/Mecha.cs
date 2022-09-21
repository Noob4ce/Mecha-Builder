using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace final_project.Models
{
    public class Mecha
    {
        public int MechaId { get; }

        public string MechaName { get;  }

        public double Attack { get; set; }

        public double Defence { get; set; }

        public int Energy { get; set; }

        public int HP { get; set; }
    
        public List<Module> MechaModules { get; set; }

        public Mecha(string name)
        {
            this.MechaId = genrateShipId();
            this.MechaName = name;
            this.MechaModules = new List<Module>();
        }

        private int genrateShipId()
        {
            Random r = new Random();
            int id = r.Next(1000, 9999);
            return id;
        }

        public virtual double calculateMechaAttack()
        {
            int totalAttack = 0;
            foreach (Module m in this.MechaModules)
            {
                totalAttack += m.Attack;
            }

            return totalAttack;
            
        }

        public virtual double calculateMechaDefence()
        {
            double totalDefence = 0;
            foreach (Module m in this.MechaModules)
            {
                totalDefence += m.Defence;
            }

            return totalDefence;
        }

        public virtual int calculateEnergyCost()
        {
            int totalCost = 0;
            foreach (Module m in this.MechaModules)
            {
                totalCost += m.EnergyCost;
            }
            if (totalCost > Energy)
            {
                throw new ArgumentException("Your design has exceeded the energy supply: {0}",Energy.ToString());
            }

            return totalCost;
        }



        public virtual string getFullName()
        {
            string name = this.MechaId + " " + "-" + " " + MechaName + " ";
            return name;
        }

        public string getMechaType()
        {
            string t = this.GetType().ToString();
            if (t == "final_project.Models.Hunter")
            {
                return "Hunter";
            } else if (t == "final_project.Models.Coordinator")
            {
                return "Coordinator";
            }
            return null;
        }

    }
}