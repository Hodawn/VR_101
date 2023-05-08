using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterController : MonoBehaviour
{
    // Start is called before the first frame update
    public int Monster_Hp = 5;

    public void Damaged(int Damage)
    {
        Monster_Hp -= Damage;

        if (Monster_Hp <= 0)
        {
            GameObject temp = this.gameObject;  //나 자신을 가져와서 temp 에 입력한다.
            Destroy(temp);
        }
    }
}
