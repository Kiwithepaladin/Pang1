using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pang.Barrier
{
    public class BarrierController : BarrierElement
    {
        public BarrierModel _model;

        public void TakeHit()
        {
            _model._hitsUntillDesturction--;
        }
        public void DestoryBarrier()
        {
            if(_model ._hitsUntillDesturction <= 0)
            {
                GameObject.Destroy(this.transform.root.gameObject);
            }
        }
    }
}
