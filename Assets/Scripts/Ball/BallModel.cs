using System.Collections;
using System.Collections.Generic;
using UnityEngine;


namespace Pang.Ball
{
    [System.Serializable]
    public class BallModel : BallElement
    {
        public SpriteRenderer _sprite;
        public Collider2D _circleCollider;
        public Vector2 _baseSpeed;
        public GameObject _ballPrefab;
        public int _amountOfBallsToSpawn;
        public int _levelsOfDestruction = 2;
        public Rigidbody2D _rigid2D;
        public Vector2 _lastVelocity;
    }
}
