using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileMove : MonoBehaviour
{
    public Vector3 launchDirection;

    private void OnCollisionEnter(Collision collision)
    {       //���� �浹�� �ı�
        if(collision.gameObject.name=="Wall")
        {
            Destroy(this.gameObject);
        }
        //���� �浹��
        if (collision.gameObject.name == "Monster")
        {
            //���Ϳ��� �������� �ְ� �������.
            collision.gameObject.GetComponent<MonsterController>().Damaged(1);
            Destroy(this.gameObject);
        }
    }

    private void OnTriggerEnter(Collider other)             //trigger �Լ�
    {       //���� �浹�� �ı�
        if (other.gameObject.tag == "Wall")                //Name -> Tag �� ��ȯ
        {
            Destroy(this.gameObject);
        }
        //���� �浹��
        if (other.gameObject.tag == "Monster")
        {
            //���Ϳ��� �������� �ְ� �������.
            other.gameObject.GetComponent<MonsterController>().Damaged(1);
            Destroy(this.gameObject);
        }
    }

    // Start is called before the first frame update
    private void FixedUpdate()
    {
        //�ð���� �̵� �� float ������ ����
        float moveAmount = 3 * Time.fixedDeltaTime;
        //launchDirection �������� �߻�ü �̵� (translate) �̵� ��Ű�� �Լ�
        transform.Translate(launchDirection * moveAmount);
    }
}
