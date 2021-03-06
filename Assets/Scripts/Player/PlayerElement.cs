using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pang.Player
{
    public class PlayerElement : MonoBehaviour
    {
        public PlayerApplication _app { get { return GameObject.FindObjectOfType<PlayerApplication>(); }}
    }
}