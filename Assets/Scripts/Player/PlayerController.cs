using System.Collections;
using System.Collections.Generic;
using Pang.Weapons.Harpoon.Interfaces;
using UnityEngine;

namespace Pang.Player
{
    public class PlayerController : PlayerElement,IHasWeapon
    {
        public PlayerModel _playerModel;

        public bool IsAlive => _playerModel._playerLives > 0;
        public void DecressHealth(int amount)
        {
            _playerModel._playerLives -= amount;
        }
        public void MovePlayer(Vector2 moveBy)
        {
            if(_playerModel._canWalk)
            {
                //5 is a placeholder variable! can be replaced with a field in the playermodel class
                _playerModel._rigid2D.velocity = new Vector2(moveBy.x,0) * 5f;
                return;
            }
            _playerModel._rigid2D.velocity = Vector2.zero;
            return;
        }
        public void ChangeValueWithButton(int value)
        {
            StartCoroutine("ChangeMoveValue",value);
        }
        public IEnumerator ChangeMoveValue(int value)
        {
            _playerModel._movementValue = new Vector2(value,0);
            yield return new WaitForSeconds(0.1f);
        }
        public void SimpleShooting()
        {
            if(_playerModel._canShoot && Time.timeScale >= 1)
            {
                StartCoroutine("ShootCoroutine");
            }
            return;
        }
        public IEnumerator ShootCoroutine()
        {
            _playerModel._canShoot = false;
            _playerModel._canWalk = false;
            var shootingObject = Instantiate(_playerModel._harpoon,(Vector2)this.transform.position + Vector2.up,Quaternion.identity);
            yield return new WaitForSeconds(0.5f);
            _playerModel._canWalk = true;
            yield return new WaitForSeconds(0.8f);
            _playerModel._canShoot = true;
            
        }
    }
}
