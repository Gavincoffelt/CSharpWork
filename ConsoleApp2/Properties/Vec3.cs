using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    struct Vec3
    {
        
      public float x, y, z;
        public Vec3 Sum(Vec3 vec)
        {

            x = x + vec.x;
            y = y + vec.y;
            z = z + vec.z;

            return vec;

        }
        public Vec3 Difference(Vec3 vec)
        {
            x = x - vec.x;
            y = y - vec.y;
            z = z - vec.z;
            return vec;

        }
        public float Mag
        {
            get
            {
                return x * x + y * y + z * z;
            }
        }
        public Vec3 Normalize
        {
            get
            {
                float mag = Mag;
                Vec3 normal;
                normal.x = x / mag;
                normal.y = y / mag;
                normal.z = z / mag;
                return normal;
            }
            
        }
        public float Dot(Vec3 vec)
        {
            return (x * vec.x) + (y + vec.y) + (z * vec.z);
        }
    }
}
