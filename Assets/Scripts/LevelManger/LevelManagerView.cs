using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pang
{
    public class LevelManagerView : LevelManagerElement
    {
        public LevelManagerController _controller;
        private void Update() 
        {
            _controller.UpdateHealthUI();
            if(_controller.CheckForVictoy())
            {
                _controller.EnableNextLevelScreen();
            }
            _controller.CheckForDefeat();
        }
        void OnDisable()
        {
            SceneManager.sceneLoaded -= _controller.OnSceneLoaded;
        }
        void OnEnable()
        {
            SceneManager.sceneLoaded += _controller.OnSceneLoaded;
        }
    }
}
