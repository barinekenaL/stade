using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {
    class Zone {
        private string id;
        private string stade;
        private string des;
        private string points;
        private int num1;
        private string dir;
        private string sens;
        private float lngCh;
        private float largCh;
        private float espAv;
        private float espCote;
        private string categ;
        public List<Chaise> chaises = new List<Chaise>();

        public void AddChaise(Chaise ch) {
            chaises.Add(ch);
        }

        public Zone() { }
        public Zone(string stade, string des, string points, int num1, string dir, string sens, float lngCh, float largCh, float espAv, float espCote) {
            this.stade = stade;
            this.des = des;
            this.points = points;
            this.num1 = num1;
            this.dir = dir;
            this.sens = sens;
            this.lngCh = lngCh;
            this.largCh = largCh;
            this.espAv = espAv;
            this.espCote = espCote;
        }

        public string Id { get => id; set => id = value; }
        public string Stade { get => stade; set => stade = value; }
        public string Des { get => des; set => des = value; }
        public string Points { get => points; set => points = value; }
        public int Num1 { get => num1; set => num1 = value; }
        public string Dir { get => dir; set => dir = value; }
        public string Sens { get => sens; set => sens = value; }
        public float LngCh { get => lngCh; set => lngCh = value; }
        public float LargCh { get => largCh; set => largCh = value; }
        public float EspAv { get => espAv; set => espAv = value; }
        public float EspCote { get => espCote; set => espCote = value; }
        public string Categ { get => categ; set => categ = value; }
    }
}
