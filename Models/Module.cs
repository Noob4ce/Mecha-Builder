using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace final_project.Models
{
    public class Module
    {
        public string ModuleId { get; }

        public string ModuleType { get; }

        public string ModuleName { get; set; }

        public int Attack { get; set; }

        public int Defence { get; set; }

        public int EnergyCost { get; set; }

        public Module (string id, string moduleType, string name)
        {
            this.ModuleId = id;
            this.ModuleType = moduleType;
            this.ModuleName = name;
            this.Attack = 0;
            this.Defence = 0;
            

        }   
        
        private int genrateModuleId()
        {
            Random r = new Random();
            int id = r.Next(10, 99);
            return id;
        } 


        public static List<Module> GetModules()
        {
            List<Module> modules = new List<Module>();

            Module m = new Module("W1", "Weapon", "Missile");
            m.Attack = 80;
            m.Defence = 20;
            m.EnergyCost = 100;
            modules.Add(m);

            m = new Module("W2", "Weapon", "Slugs");
            m.Attack = 55;
            m.Defence = 75;
            m.EnergyCost = 100;
            modules.Add(m);

            m = new Module("W3", "Weapon", "Mining Laser");
            m.Attack = 100;
            m.Defence = 25;
            m.EnergyCost = 130;
            modules.Add(m);

            m = new Module("W4", "Weapon", "Particle Launcher");
            m.Attack = 200;
            m.Defence = 0;
            m.EnergyCost = 150;
            modules.Add(m);

            m = new Module("S1", "Shield", "Plasteel");
            m.Attack = 0;
            m.Defence = 75;
            m.EnergyCost = 80;
            modules.Add(m);

            m = new Module("S2", "Shield", "Hyper Shields");
            m.Attack = 0;
            m.Defence = 95;
            m.EnergyCost = 100;
            modules.Add(m);           

            m = new Module("S3", "Shield", "Psionic");
            m.Attack = 0;
            m.Defence = 200;
            m.EnergyCost = 150;
            modules.Add(m);

            m = new Module("S4", "Shield", "Neutronium");
            m.Attack = 0;
            m.Defence = 225;
            m.EnergyCost = 170;
            modules.Add(m);

            m = new Module("S5", "Shield", "Dragonscale");
            m.Attack = 50;
            m.Defence = 175;
            m.EnergyCost = 200;
            modules.Add(m);

            return modules;
        }

        public static Module FindModule(string id)
        {
            foreach(Module m in GetModules())
            {
                if (m.ModuleId == id)
                {
                    return m;
                }
            }
            return null;
        }

    }
}