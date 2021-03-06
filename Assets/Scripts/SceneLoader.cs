using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

namespace Pang
{
    public class SceneLoader : MonoBehaviour
    {
        public void LoadNewScene(int sceneID)
        {
            SceneManager.LoadScene(sceneID);
        }
        public void LoadCurrentScene()
        {
             int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
             SceneManager.LoadScene(currentSceneIndex);
        }
        public void LoadMainMenu()
        {
            SceneManager.LoadScene(0);
        }
    }
}
