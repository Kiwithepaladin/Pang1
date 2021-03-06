using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pang.Ball
{
    public class BallController : BallElement
    {
        public BallModel _ballModel;

        public void OnLoadForce()
        {
            float defualtValue = 9.8f * 25f;
            this._ballModel._rigid2D.AddForce(new Vector2(defualtValue,0));
        }
        public void BounceBall(Collision2D  collision)
        {  
            float speed = _ballModel._lastVelocity.magnitude;
            Vector3 direction = Vector3.Reflect(_ballModel._lastVelocity.normalized,collision.contacts[0].normal);

            _ballModel._rigid2D.velocity = direction * Mathf.Max(speed,0f);
        }
        public void UpdateLastVelocity()
        {
            _ballModel._lastVelocity.x = Mathf.Clamp(_ballModel._rigid2D.velocity.x,-6.5f,6.5f);
            _ballModel._lastVelocity.y = Mathf.Clamp(_ballModel._rigid2D.velocity.y,-6.5f,6.5f);
        }
        public void SplitIntoTwo()
        {
            if(_ballModel._ballPrefab != null && _ballModel._levelsOfDestruction > 1)
            {
                for (int i = 0; i < _ballModel._amountOfBallsToSpawn; i++)
                {
                    Vector3 randomOffset = new Vector3(Random.Range(-0.5f, 0.5f),0,0);
                    GameObject newBall = Instantiate(_ballModel._ballPrefab,this.transform.position + randomOffset, Quaternion.identity);
                    InitializeNewBall(newBall);
                }              
            }
            GameObject.Destroy(this.transform.root.gameObject);
        }
        public void InitializeNewBall(GameObject newBall)
        {
            Vector3 randomOffset = new Vector3(Random.Range(-4.5f, 4.5f),Random.Range(-4.5f, 4.5f),0);
            newBall.GetComponentInChildren<BallModel>()._rigid2D.velocity = _ballModel._rigid2D.velocity * randomOffset;
            newBall.GetComponentInChildren<BallModel>()._levelsOfDestruction = this._ballModel._levelsOfDestruction - 1;
            //Highest value - (difference between height value - smallest value) divide into the current level of destruction multipled by a small arbitrery number
            var reduceSize = 0.5f-(0.35f/(newBall.GetComponentInChildren<BallModel>()._levelsOfDestruction * 1.2f));
            newBall.GetComponentInChildren<BallView>().transform.localScale = new Vector3(reduceSize,reduceSize,reduceSize);
        }
    }
}
