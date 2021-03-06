using System.Collections;
using System.Collections.Generic;
using Pang.Ball;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Pang
{
    public class LevelManagerController : LevelManagerElement
    {
        public LevelManagerModel _model;
        public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
        {
            StartCoroutine("StartGame");
        }
        public IEnumerator StartGame()
        {
            
            Time.timeScale = 0;
            _model._timerText.gameObject.SetActive(true);
            while(_model._timer > 0)
            {
                yield return new WaitForSecondsRealtime(1f);
                DecressTimer(_model._timerText);
            }
            Time.timeScale = 1;
            _model._timerText.gameObject.SetActive(false);
            yield return null;
        
        }
        public void EnableNextLevelScreen()
        {
            _model._nextLevelWindow.SetActive(true);
        }
        public void DecressTimer(Text timerText)
        {
            _model._timer--;
            timerText.text = _model._timer.ToString();
        }
        public void UpdateHealthUI()
        {
        
            for (int i = 0; i < _model._healthPointsUI.Count; i++)
            {
                if(_model._player._model._playerLives > i)
                {
                    HealthGainUI(i);
                }
                else
                {
                    HealthLostUI(i);
                }
            }
        } 
        //Horrible name
        public void HealthGainUI(int index)
        {
            _model._healthPointsUI[index].gameObject.SetActive(true);
        }
        public void HealthLostUI(int index)
        {
            _model._healthPointsUI[index].gameObject.SetActive(false);
        }
        public void CheckForDefeat()
        {
            if(!_model._player._controller.IsAlive)
            {
                _model._gameOverWindow.SetActive(true);
                Time.timeScale = 0;
                return;
            }
            return;
        }
        public bool CheckForVictoy()
        {
            //Not Best performance wise!
            BallApplication[] balls = FindObjectsOfType<BallApplication>();
            if(balls.Length <= 0)
            {
                return _model._isLevelOver = true;
            }
            return _model._isLevelOver = false;
        }
    }
}
