using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileController : MonoBehaviour
{
    public GameObject Projectile;           //�߻�ü ������ ����

    // Start is called before the first frame update
    public void FireProjectiole()
    {
        //instantiate �Լ��� ������Ʈ �� ������ �����ϴ� �Լ�
        GameObject temp = (GameObject)Instantiate(Projectile);

        //������ projectile�� temp�� �Է�

        //�ش� ���� ������Ʈ ��ġ���� ����
        temp.transform.position = this.gameObject.transform.position;

        //�߻�ü�� �߻� ������ �� ������Ʈ�� �������� �����Ѵ�.
        temp.GetComponent<ProjectileMove>().launchDirection = transform.forward;

        //Destroy�� ���� ������Ʈ�� �����ִ� �Լ� (10���� �Ҹ�)
        Destroy(temp, 10.0f);
    }
}
