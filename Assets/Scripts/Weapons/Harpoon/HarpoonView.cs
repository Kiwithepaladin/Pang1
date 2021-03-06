using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pang.Weapons.Harpoon
{
    public class HarpoonView : HarpoonElement
    {
        public HarpoonController _controller;

        private void Awake() {
             _controller.StartCoroutine("GrowthCoroutine");
        }

        private void OnCollisionEnter2D(Collision2D other) 
        {
            if(other.collider.CompareTag("Ceiling") || other.collider.CompareTag("Ball"))
            {
                _controller.DestoryHarpoon();
            }
        }
    }
}