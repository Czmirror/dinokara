using UnityEngine;
using System.Collections;

namespace DinokarA.Assets.Scripts.Status
{
    
    // ゲームステート実行管理クラス
    public class GameStateProcessor
    {
        private GameState _GameState;

        public GameState GameState
        {
            set { _GameState = value;}
            get { return _GameState;}
        }

        public void Execute()
        {
            GameState.Execute();
        }
    }

    // ゲームステートクラス
    public abstract class GameState
    {
        public delegate void executeState();
        public executeState execDelegate;

        public virtual void Execute()
        {
            if (execDelegate != null)
            {
                execDelegate();
            }
        }

        public abstract string getStateName();
    }
    
    // ゲームステートクラス ブロックセット
    public class GameStateBlockSetup : GameState
    {
        public override string getStateName()
        {
            return "GameStateBlockSetup";
        }
    }
    
    // ゲームステートクラス ゲーム開始
    public class GameStateGameReady : GameState
    {
        
        public override string getStateName()
        {
            return "GameStateGameReady";
        }

    }
    
    // ゲームステートクラス ゲーム開始
    public class GameStateGameClear : GameState
    {
        
        public override string getStateName()
        {
            return "GameStateGameClear";
        }

    }
    
    // ゲームステートクラス ゲーム開始
    public class GameStateGameOver : GameState
    {
        
        public override string getStateName()
        {
            return "GameStateGameOver";
        }

    }
}
