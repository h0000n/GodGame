using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Battle
{
    public class PlayerHands : MonoBehaviour
    {
        public int Cards = 0;
        // Start is called before the first frame update
        private Manager.BattleManager _BM;
        private void Start()
        {
            _BM = Manager.GameManager.Instance.CurrentBM;
            _BM.pHands = this;
        }

        // Update is called once per frame
        void Update()
        {

        }
    }
}
