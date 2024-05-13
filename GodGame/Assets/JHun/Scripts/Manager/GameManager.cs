using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Manager
{
    public class GameManager : Singleton<GameManager>
    {
        public BattleManager CurrentBM;

        private void Start()
        {
            DontDestroyOnLoad(gameObject);
        }
    }
}
