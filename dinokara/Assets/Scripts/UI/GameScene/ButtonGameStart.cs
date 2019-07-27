using DinokarA.Assets.Scripts.Block;
using UnityEditor;
using System.Collections.Generic;
using DinokarA.Assets.Scripts.Manager;
using UnityEngine;
using UniRx;
using UniRx.Async;
using UnityEngine.UI;


namespace DinokarA.Assets.Scripts.UI
{
    public class ButtonGameStart : MonoBehaviour
    {
        private GameObject blockManager;
        // ボタン押下

        async void Start()
        {
            blockManager = GameObject.Find("Managers/BlockManager");
            blockManager.GetComponent<BlockManager>().BlockAllSetCheck.Subscribe(_ => CheckSetBlock());

//            BlockManager.BlockAllSetCheck.Subscribe(_ => CheckSetBlock());

// test
//            await UniTask.Delay(1000);
            //Debug.Log("1000㍉秒待つ");
        }

        private void CheckSetBlock()
        {
            // ブロックチェック trueのときに、ボタンを有効
            gameObject.GetComponent<Button>().interactable = blockManager.GetComponent<BlockManager>().BlockAllSetCheck.Value;
//            gameObject.GetComponent<Button>().interactable = BlockManager.BlockAllSetCheck.Value;
        }
    }
}
