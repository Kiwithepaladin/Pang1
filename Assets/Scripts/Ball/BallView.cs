using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Pang.Ball
{
    public class BallView : BallElement
    {
        public BallController _ballController;

        private void Start() {
            _ballController.OnLoadForce();
        }
        private void Update()
        {
             _ballController.UpdateLastVelocity();
        }
        private void OnCollisionEnter2D(Collision2D other) 
        {
            if(other.collider.CompareTag("Harpoon"))
            {
                _ballController.SplitIntoTwo();
            }
            else
            {
                _ballController.BounceBall(other);
            }
        }
        private void OnCollisionStay2D(Collision2D other) 
        {
            _ballController.BounceBall(other);
        }
    }
}
