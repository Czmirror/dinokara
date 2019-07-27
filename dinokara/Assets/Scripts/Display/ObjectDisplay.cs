using UnityEngine;
using System.Collections.Generic;
using DinokarA.Assets.Scripts.Manager;
using DinokarA.Assets.Scripts.Status;
using UnityEngine.Analytics;
using UniRx;

namespace DinokarA.Assets.Scripts.Display
{
    public abstract class ObjectDisplay : MonoBehaviour, IDisplay
    {
        public List<GameState> activateState;

        private GameStatusManager gameStatusManager;

        private void Start()
        {
            gameStatusManager = GameObject.Find("Managers/GameStatusManager").GetComponent<GameStatusManager>();

            gameStatusManager.GameStatus.Subscribe(x =>
                ObjectActivate()
            );
        }

        public void ObjectActivate()
        {
        }
    }
}
