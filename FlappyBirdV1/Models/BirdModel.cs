using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FlappyBirdV1.Models
{
    public class BirdModel
    {
        public int DistanceFromGround { get; set; } = 100;


        public void Fall(int gravity)
        {
            DistanceFromGround -= gravity;

        }
    }
}
