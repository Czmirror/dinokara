using UnityEngine;
using System.Collections;

namespace DinokarA.Assets.Scripts.UI
{
    public class ButtonSceneMove : MonoBehaviour
    {
        [SerializeField] private string loadScene;

        public void PushButton()
        {
            SceneMove.Movement(loadScene);
        }
    }
}
