using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace final_project.Models
{
 
    public class Hunter : Mecha
    {

        public static double coreExposureFactor { get; set; }


        public Hunter (string name) : base(name)
        {
            this.Energy = 400;
            
        }

        public override double calculateMechaAttack()
        {
            int count = 0;
            double attack = 0;

            foreach(Module m in this.MechaModules)
            {
                if (m.ModuleType == "Shield")
                {
                    count ++;
                } 
            }

            if (count == 0)
            {
               attack = base.calculateMechaAttack() * 1.35;
            }
            else if (count < coreExposureFactor)
            {
                attack = base.calculateMechaAttack() * 1.25;
            }
            else if (count <= coreExposureFactor)
            {
                attack = base.calculateMechaAttack() * 1.20;
            }

            return Math.Round(attack);

        }
    }
}