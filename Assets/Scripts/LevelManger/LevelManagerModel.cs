using System;
using System.Collections;
using System.Collections.Generic;
using Pang.Ball;
using Pang.Player;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Pang
{
    public class LevelManagerModel : LevelManagerElement
    {
        public PlayerApplication _player;
        public GameObject _nextLevelWindow;
        public List<Transform> _healthPointsUI;
        public GameObject _gameOverWindow;
        public Text _timerText;
        public float _timer;
        public bool _isLevelOver;
    }
}
