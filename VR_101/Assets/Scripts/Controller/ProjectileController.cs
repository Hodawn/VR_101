using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public GameObject Projectile;           //발사체 프리팹 선언

    // Start is called before the first frame update
    public void FireProjectiole()
    {
        //instantiate 함수는 오브젝트 및 프리팹 생성하는 함수
        GameObject temp = (GameObject)Instantiate(Projectile);

        //생성된 projectile을 temp에 입력

        //해당 게임 오브젝트 위치에서 생성
        temp.transform.position = this.gameObject.transform.position;

        //발사체에 발사 방향을 내 오브젝트의 앞쪽으로 설정한다.
        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;

        //Destroy는 게임 오브젝트를 없애주는 함수 (10초후 소멸)
        Destroy(temp, 10.0f);
    }
}
