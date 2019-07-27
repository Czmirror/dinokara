using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using DinokarA.Assets.Scripts.Status;

namespace DinokarA.Assets.Scripts.Manager
{
    // 現在のゲーム状態を管理
    public class GameStatusManager : MonoBehaviour
    {
        private IReactiveProperty<string> _gameStatus;

        public IReadOnlyReactiveProperty<string> GameStatus
        {
            get { return _gameStatus; }
        }

        public GameStateProcessor GameStateProcessor = new GameStateProcessor();
        public GameStateBlockSetup GameStateBlockSetup = new GameStateBlockSetup();
        public GameStateGameReady GameStateGameReady = new GameStateGameReady();
        public GameStateGamePlay GameStateGamePlay = new GameStateGamePlay();
        public GameStateGameClear GameStateGameClear = new GameStateGameClear();
        public GameStateGameOver GameStateGameOver = new GameStateGameOver();

        void Start()
        {
            GameStateProcessor.GameState = GameStateBlockSetup;
            GameStateBlockSetup.execDelegate = BlockSetup;
            GameStateGameReady.execDelegate = GameReady;
            GameStateGamePlay.execDelegate = GamePlay;
            GameStateGameClear.execDelegate = GameClear;
            GameStateGameOver.execDelegate = GameOver;
        }

        // ブロック設置処理
        public void BlockSetup()
        {
            var _test = GameStatus;
            Debug.Log(_test);
            //_gameStatus = GameStateBlockSetup.getStateName();
            //_gameStatus = GameStateBlockSetup.getStateName();
            // 必要なオブジェクトの表示処理
        }

        // ゲーム開始処理
        public void GameReady()
        {
            _gameStatus.Value = GameStateGameReady.getStateName();
            // 必要なオブジェクトの表示処理

            // 必要なオブジェクトの非表示処理

            // 5秒後にゲームプレイ処理へ遷移
            Observable
                .Timer(TimeSpan.FromSeconds(5))
                .Subscribe(x => GameStateProcessor.GameState = GameStateGamePlay);
        }

        // ゲームプレイ処理
        public void GamePlay()
        {
            // 必要なオブジェクトの表示処理

            // 必要なオブジェクトの非表示処理
        }

        // ゲームクリア処理
        public void GameClear()
        {
            // 必要なオブジェクトの表示処理

            // 必要なオブジェクトの非表示処理
        }

        // ゲームオーバー処理
        public void GameOver()
        {
            // 必要なオブジェクトの表示処理

            // 必要なオブジェクトの非表示処理
        }
    }
}
