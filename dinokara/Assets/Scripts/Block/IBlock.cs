using System.Xml.Linq;
using UnityEngine;
using UniRx;
using UniRx.Triggers;
using UniRx.Async;

namespace DinokarA.Assets.Scripts.Block
{
    // ブロックインタフェース
    public interface IBlock
    {
        
    }

    // ブロック基幹クラス
    public abstract class BlockBase : MonoBehaviour, IBlock
    {
        // BlockSetAreaにブロックが格納されているかチェック
        //BoolReactiveProperty BlockSetAreaInside = new BoolReactiveProperty(false);

        private BoolReactiveProperty blockSetAreaInside = new BoolReactiveProperty();

        public IReadOnlyReactiveProperty<bool> BlockSetAreaInside
        {
            get { return blockSetAreaInside; }
        }

        private string blockAreaName = "BlockSetArea";

        private void Start()
        {
            //WarpZoneに侵入したらフラグを有効にする
            this.OnTriggerEnterAsObservable()
                .Where(x => x.gameObject.name == blockAreaName)
                .Subscribe(_ => blockSetAreaInside.Value = true);

            //WarpZoneから出たらフラグを無効にする
            this.OnTriggerExitAsObservable()
                .Where(x => x.gameObject.name == blockAreaName)
                .Subscribe(_ => blockSetAreaInside.Value = false);
        }
    }
}
