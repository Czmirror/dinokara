using System;

using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UniRx;
using DinokarA.Assets.Scripts.Status;
using UnityEngine.Analytics;

namespace DinokarA.Assets.Scripts.Manager
{
    // 現在のゲーム状態を管理
    public class GameStatusManager : MonoBehaviour
    {

        private IReadOnlyReactiveProperty<string> _gameStatus;

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
            
        }

        // ゲーム開始処理
        public void GameReady()
        {
            // 5秒後にゲームプレイ処理へ遷移
            Observable
                .Timer(TimeSpan.FromSeconds(5))
                .Subscribe(x => GameStateProcessor.GameState = GameStateGamePlay);
        }

        // ゲームプレイ処理
        public void GamePlay()
        {
            
        }

        // ゲームクリア処理
        public void GameClear()
        {
            
        }

        // ゲームオーバー処理
        public void GameOver()
        {
            
        }
    }

}
