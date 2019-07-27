using UnityEngine;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using DinokarA.Assets.Scripts.Block;
using DinokarA.Assets.Scripts.Data;
using UniRx;

namespace DinokarA.Assets.Scripts.Manager
{
    public class BlockManager : MonoBehaviour
    {
        //[SerializeField] private LoadStageData loadStageData;
        [SerializeField] private Stage stage;

        // 生成されたブロックのリスト
        private List<GameObject> blockList = new List<GameObject>();

        public List<GameObject> BlockList
        {
            get { return blockList; }
        }

        // 全てのブロックがセットされているかをチェックするプロパティ
        private BoolReactiveProperty blockAllSetCheck = new BoolReactiveProperty();

        public IReadOnlyReactiveProperty<bool> BlockAllSetCheck
        {
            get { return blockAllSetCheck; }
        }

        private void Start()
        {
            SetBlock();
        }

        // ブロック生成処理
        private void SetBlock()
        {
            // Stageデーターのjsonを読み込み
            stage = GetStageData.GetStage();

            // プロトタイプ（他のブロック生成処理をのちに追加）
            // 各ブロックの生成処理（各ブロックのメソッド CreateBlockを実施（jsonに記載されている回数分実施）
            GameObject _block = (GameObject) Resources.Load("Prefabs/BlockNormal");
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
                var _block = Instantiate(block);

                // 生成したブロックをUniRxで購読
                _block.GetComponent<BlockBase>().BlockSetAreaInside.Subscribe(_ => CheckSetBlock());
                
                // CheckSetBlockで全てのブロックをチェックするために、配列に格納
                blockList.Add(_block);
            }
        }

        // 全てのブロックが設置されているか判定するためのフラグ取得
        private void CheckSetBlock()
        {
            bool BlockAllInside = true;
            
            foreach (var block in blockList)
            {
                var _block = block.GetComponent<BlockBase>().BlockSetAreaInside.Value;
                if (!_block)
                {
                    BlockAllInside = false;
                }
            }

            blockAllSetCheck.Value = BlockAllInside;
        }
    }
}
