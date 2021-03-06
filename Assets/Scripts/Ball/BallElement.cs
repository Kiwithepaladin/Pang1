using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pang.Ball
{
    public class BallElement : MonoBehaviour
    {
        public BallApplication _app { get { return GameObject.FindObjectOfType<BallApplication>(); }}
    }
}