using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pang.Barrier
{
    public class BarrierView : BarrierElement
    {
        public BarrierController _controller;

        private void OnCollisionEnter2D(Collision2D other) 
        {
            if(other.collider.CompareTag("Harpoon"))
            {
                _controller.TakeHit();
                _controller.DestoryBarrier();
            }
        }
    }
}