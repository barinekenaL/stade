using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {
    class Stade {
        string id;
        string des;
        string points;

        public Stade(string des, string points) {
            this.des = des;
            this.points = points;
        }

        public string Id { get => id; set => id = value; }
        public string Des { get => des; set => des = value; }
        public string Points { get => points; set => points = value; }
    }
}
