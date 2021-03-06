using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

namespace Pang.Player
{
    public class PlayerView : PlayerElement
    {
        public PlayerController _playerController;

        private void Update()
        {
            #if UNITY_STANDALONE_WIN
            _playerController._playerModel._movementValue = _playerController._playerModel._inputs.Player1.Move.ReadValue<Vector2>();
            #endif
        }
        private void OnCollisionEnter2D(Collision2D other)
        {
            if(other.collider.CompareTag("Ball"))
            {
                _playerController.DecressHealth(1);
            }
        }
        private void FixedUpdate()
        {
            _playerController.MovePlayer(_playerController._playerModel._movementValue);
        }
    }
}
