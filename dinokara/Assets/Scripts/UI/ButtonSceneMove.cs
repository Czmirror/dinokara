using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

namespace DinokarA.Assets.Scripts.UI
{
    public class ButtonSceneMove : MonoBehaviour
    {
        [SerializeField] private string loadScene;

        public void PushButton()
        {
            SceneManager.LoadScene(loadScene);
        }
    }
}
