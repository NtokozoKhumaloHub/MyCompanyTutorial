using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyCompanyTutorial
{
    internal class Boss : Employee
    {
        public bool CompanyCar { get; set; }
    
        
        public Boss() { }

        public Boss(bool companyCar)
        {
            this.CompanyCar = companyCar;
        }

        public void Lead() { }
    
    }

}
