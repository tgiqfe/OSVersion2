﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OSVersion2.OS
{
    internal class Arithmetic
    {
        /// <summary>
        /// インスタンスに対する番号。この値を基に計算
        /// </summary>
        public int Serial { get; set; }

        public static bool operator <(Arithmetic x, Arithmetic y)
        {
            if (x is not null && y is not null)
            {
                
            }
            return x.Serial < y.Serial;
        }
        public static bool operator <(Arithmetic x, int y) { return x.Serial < y; }
        public static bool operator <(int x, Arithmetic y) { return x < y.Serial; }

        public static bool operator >(Arithmetic x, Arithmetic y) { return x.Serial > y.Serial; }
        public static bool operator >(Arithmetic x, int y) { return x.Serial > y; }
        public static bool operator >(int x, Arithmetic y) { return x > y.Serial; }

        public static bool operator <=(Arithmetic x, Arithmetic y) { return x.Serial <= y.Serial; }
        public static bool operator <=(Arithmetic x, int y) { return x.Serial <= y; }
        public static bool operator <=(int x, Arithmetic y) { return x <= y.Serial; }

        public static bool operator >=(Arithmetic x, Arithmetic y) { return x.Serial >= y.Serial; }
        public static bool operator >=(Arithmetic x, int y) { return x.Serial >= y; }
        public static bool operator >=(int x, Arithmetic y) { return x >= y.Serial; }

        public static bool operator ==(Arithmetic x, Arithmetic y) { return x is not null && x is not null ? x.Serial == y.Serial : false; }
        public static bool operator ==(Arithmetic x, int y) { return x is not null ? x.Serial == y : false; }
        public static bool operator ==(int x, Arithmetic y) { return y is not null ? x == y.Serial : false; }

        public static bool operator !=(Arithmetic x, Arithmetic y) { return x is not null && y is not null ? x.Serial != y.Serial : true; }
        public static bool operator !=(Arithmetic x, int y) { return x is not null ? x.Serial != y : true; }
        public static bool operator !=(int x, Arithmetic y) { return y is not null ? x != y.Serial : true; }

        public override bool Equals(object obj)
        {
            return obj switch
            {
                Arithmetic aObj => this.Serial == aObj.Serial,
                int iObj => this.Serial == iObj,
                long lObj => this.Serial == lObj,
                _ => false,
            };
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
