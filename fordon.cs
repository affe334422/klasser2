using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace klasser2
{
    public class bil
    {
        private string tillverkare;
        private string model;
        private int år;
        private int vikt;

        public string Tillverkare{
            get{return tillverkare;}
            set{tillverkare = value;}
        }

        public string Model{
            get{return model;}
            set{model = value;}
        }
        
        public int År{
            get{return år;}
            set{år = value;}
        }
        
        public int Vikt{
            get{return vikt;}
            set{vikt = value;}
        }
    }

    public class testför2{

        private string tillverkare;
        private string model;
        private int år;
        private int vikt;

        public testför2(string a, string b, int c, int d){
            tillverkare = a;
            model = b;
            år = c;
            vikt = d;
        }

        public string Tillverkare{
            get{return tillverkare;}
            set{tillverkare = value;}
        }

        public string Model{
            get{return model;}
            set{model = value;}
        }
        
        public int År{
            get{return år;}
            set{år = value;}
        }
        
        public int Vikt{
            get{return vikt;}
            set{vikt = value;}
        }

    }
}