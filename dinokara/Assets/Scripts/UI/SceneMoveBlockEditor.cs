using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace DinokarA.Assets.Scripts.UI
{
    public class SceneMoveBlockEditor : MonoBehaviour
    {
        public void MoveGameScene()
        {
            // ボタンの名前を取得（遷移後のステージ名）
            var stage_name = gameObject.name;
            PlayerPrefs.SetString("CurrentStage", stage_name);
            PlayerPrefs.Save();
            
            var loadScene = "GameScene";
            SceneMove.Movement(loadScene);

        }
    }
}
