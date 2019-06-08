using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

namespace DinokarA.Assets.Scripts.UI
{
    public class SceneMove
    {
        static public void Movement(string scene)
        {
            SceneManager.LoadScene(scene);
        }
    }
}
