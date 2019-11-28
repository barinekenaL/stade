using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace stade.models {
    class Chaise {
        private string id;
        private float x;
        private float y;
        private string zone;
        private int num;

        public Chaise(float x, float y, int num) {
            this.x = x;
            this.y = y;
            this.num = num;
        }

        public string Id { get => id; set => id = value; }
        public float X { get => x; set => x = value; }
        public float Y { get => y; set => y = value; }
        public int Num { get => num; set => num = value; }
        public string Zone { get => zone; set => zone = value; }
    }
}
