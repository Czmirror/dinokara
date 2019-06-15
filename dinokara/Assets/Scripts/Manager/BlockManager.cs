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
            stage = GetStageData.GetStage();

            // 各ブロックの生成処理（各ブロックのメソッド CreateBlockを実施（jsonに記載されている回数分実施）
            GameObject _block = (GameObject)Resources.Load("Prefabs/BlockNormal");
            int _blocknum = stage.block_normal;
            CreateBlock(_block, _blocknum);
        }

        // ブロックインスタンス生成処理
        private void CreateBlock(GameObject block, int blocknum)
        {
            if (blocknum <= 0)
            {
                return;
            }

            for (int i = 0; i < blocknum; i++)
            {
                Instantiate(block);
            }
        }
    }
}
