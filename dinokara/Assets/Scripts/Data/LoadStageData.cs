using System.Collections;
using System.Collections.Generic;
using DinokarA.Assets.Scripts.Data;
using UnityEngine;

// ボツ予定
namespace DinokarA.Assets.Scripts.Data
{
    public class LoadStageData : MonoBehaviour
    {
        // 現在のステージ名
        [SerializeField] private string currentStageName;

        // 外部向け現在のステージ名
        public string CurrentStage
        {
            get { return currentStageName; }
        }

        private Stage currentStageData; // 現在のステージデーター

        // 外部向け現在のステージデーター
        public Stage CurrentStageData 
        {
            get { return currentStageData; }
        }


        // JSONからステージ情報を取得
        void Start()
        {
            Stage _stage = GetStageData.GetStage();
            
            currentStageData = _stage;
        }
    }
}
