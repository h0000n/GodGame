using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Character{
    public class Stat : MonoBehaviour //출력 될 스텟
    {
        public string charName;     //이름
        public int hp;              //현재체력
        public int maxhp;           //최대체력
        public int atk;             //공격력
        public int ap;              //주문력
        public int spd;             //속도
        public int equipmentCode;   //들고있는 장비
    }
    public class InputStat : MonoBehaviour  //입력 될 스텟
    {
        public string charName;     //이름
        public int hp;              //현재체력
        public int maxhp;           //최대체력
        public int atk;             //공격력
        public int ap;              //주문력
        public int spd;             //속도
        public int equipmentCode;   //들고있는 장비
    }
}
