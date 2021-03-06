using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pang.Player
{
    public class PlayerApplication : MonoBehaviour
    {
        public PlayerModel _model;
        public PlayerView _view;
        public PlayerController _controller;
        private void Awake()
        {
            _model._rigid2D = GetComponent<Rigidbody2D>();
            _model._inputs = new Player_Inteactions();
             
            //Hard coded and a horrible idea, will need to sort later!
            Physics2D.IgnoreLayerCollision(8,9);
        }

        private void OnEnable() {
            _model._inputs.Enable();
        }
        private void OnDisable() {
            _model._inputs.Disable();
        }
    }
}
