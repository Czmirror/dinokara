using UnityEngine;

namespace DinokarA.Assets.Scripts.Block
{
    // ブロックインタフェース
    public interface IBlock
    {
        void CreateBlock();
    }

    // ブロック基幹クラス
    public abstract class BlockBase : MonoBehaviour, IBlock
    {
        // ブロック生成処理
        public void CreateBlock()
        {
        }
    }
}
