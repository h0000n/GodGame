using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle
{
    public class PlayerDeck : MonoBehaviour
    {
        public int Deck = 50;
        // Start is called before the first frame update
        private Manager.BattleManager _BM;
        private void Start()
        {
            _BM = Manager.GameManager.Instance.CurrentBM;
            _BM.pDeck = this;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}

