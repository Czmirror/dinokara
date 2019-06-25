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

        private IReadOnlyReactiveProperty<string> _gameStatus;

        public IReadOnlyReactiveProperty<string> GameStatus
        {
            get { return _gameStatus; }
        }
        
        public GameStateProcessor GameStateProcessor = new GameStateProcessor();
        public GameStateBlockSetup GameStateBlockSetup = new GameStateBlockSetup();
        public GameStateGameReady GameStateGameReady = new GameStateGameReady();
        public GameStateGameClear GameStateGameClear = new GameStateGameClear();
        public GameStateGameOver GameStateGameOver = new GameStateGameOver();

        void Start()
        {
            GameStateProcessor.GameState = GameStateBlockSetup;
        }

    }

}
