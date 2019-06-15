using UnityEngine;
using DinokarA.Assets.Scripts.Data;

namespace DinokarA.Assets.Scripts.Manager
{
    public class BlockManager : MonoBehaviour
    {
        //[SerializeField] private LoadStageData loadStageData;
        [SerializeField] private Stage stage;
        private void Update()
        {
            if (stage == null)
            {
                SetBlock();
            }
        }
        
        // ブロック生成処理
        private void SetBlock()
        {
            // Stageデーターのjsonを読み込み
            stage = this.GetComponent<LoadStageData>().CurrentStageData;
            
            // 各ブロックの生成処理（各ブロックのメソッド CreateBlockを実施（jsonに記載されている回数分実施）
            var _normalBlock = Resources.Load("Prefabs/NormalBlock");
            

        }

        
    }
}
