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
        }

        // ブロック設置処理
        public void BlockSetup()
        {
            
        }

        // ゲーム開始処理
        public void GameReady()
        {
            Observable
                .Timer(TimeSpan.FromSeconds(5))
                .Subscribe(x => GameStateProcessor.GameState = GameStateGamePlay);
        }

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
