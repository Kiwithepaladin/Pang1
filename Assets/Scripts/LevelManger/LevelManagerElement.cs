using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pang
{
    public class LevelManagerElement : MonoBehaviour
    {
        public LevelManagerApplication _app { get { return GameObject.FindObjectOfType<LevelManagerApplication>(); }}
    }
}