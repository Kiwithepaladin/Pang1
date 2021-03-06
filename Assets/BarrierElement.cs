using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pang.Barrier
{
    public class BarrierElement : MonoBehaviour
    {
        public BarrierApplication _app { get { return GameObject.FindObjectOfType<BarrierApplication>(); }}
    }
}
