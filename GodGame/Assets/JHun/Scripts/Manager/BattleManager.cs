using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Battle;

namespace Manager
{
    public class BattleManager : MonoBehaviour
    {
        public int Turn = 0;
        public enum Phase
        {
            Draw,
            Card,
            Action
        };
        public PlayerDeck pDeck;
        public PlayerDraw pDraw;
        public PlayerHands pHands;

        public Phase CurrentPhase;
        private void Awake()
        {
            CurrentPhase = 0;
            GameManager.Instance.CurrentBM = this;
            Turn = 1;
        }
        
    }
}

