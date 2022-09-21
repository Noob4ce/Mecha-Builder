using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace final_project.Models
{
    public class Coordinator : Mecha
    {
        public string mechaType = "Coordinator";
        public static double fireControlFactor { get; set; }
        public Coordinator (string name) : base(name)
        {
            this.Energy = 500;
            
        }

        public override double calculateMechaDefence()
        {
            double totalDefence = 0;
            foreach (Module m in this.MechaModules)
            {
                if (m.EnergyCost < 100)
                {
                    totalDefence += (m.Defence + (m.Defence * fireControlFactor));
                }
                else
                {
                    totalDefence += m.Defence;
                }

            }

            return totalDefence;
        }
    }
}