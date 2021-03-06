using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Pang
{
    public class LevelManagerApplication : MonoBehaviour
    {
      public LevelManagerModel _model;
      public LevelManagerView _view;
      public LevelManagerController _controller;

      private void Start() 
      {
         Application.targetFrameRate = 60;
      }
    }
}
