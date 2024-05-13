using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Manager;

namespace Battle
{
    public class PlayerDraw : MonoBehaviour
    {
        private Manager.BattleManager _BM;
        private void Start()
        {
            _BM = GameManager.Instance.CurrentBM;
            _BM.pDraw = this;
        }

        public void Draw()
        {
            if(_BM.CurrentPhase.ToString() == "Draw")
            {
                _BM.CurrentPhase = BattleManager.Phase.Card;
                _BM.pDeck.Deck -= 5;
                _BM.pHands.Cards += 5;
            }
            else
            {
                Debug.Log("현재 드로우 페이즈가 아닙니다!");
            }
        }
    }
}

