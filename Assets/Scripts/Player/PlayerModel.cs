using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pang.Player
{
    [System.Serializable]
    public class PlayerModel : PlayerElement
    {
        public bool _canShoot;
        public bool _canWalk;
        [Range(0,3)] public int _playerLives;
        public Rigidbody2D _rigid2D;
        public GameObject _harpoon;
        public SpriteRenderer _spriteRenderer;
        public Player_Inteactions _inputs;
        [HideInInspector] public Vector2 _movementValue;

    }
}
