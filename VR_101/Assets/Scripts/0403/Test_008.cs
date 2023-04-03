using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Player
{
    private int hp = 100;                                   //hp �� �������� 100�� ���� �Է�
    private int Power = 50;                                 //power�� ������ �� 50�� ���� �Է�

    public void Attack()
    {
        Debug.Log(this.Power + "�������� ������.");        //this�� player Ŭ������ �̾߱��Ѵ�.
    }

    public void Demage(int damage)                          //Demage �Լ��� int ���·� ���� ������ �μ��� �޴´�.
    {
        this.hp -= damage;
        Debug.Log(damage + "�������� �Ծ���.");
    }
    public int GetHp()
    {
        return this.hp;
    }
}
public class Test_008 : MonoBehaviour
{
    Player player_01 = new Player();                    //���� ���� �÷��̾� Ŭ������ �����Ѵ�.
    Player player_02 = new Player();                    //���� ���� �÷��̾� Ŭ������ �����Ѵ�.
    public Text player01HP;                             //�÷��̾� HP�� �����ִ� UI ����
    public Text player02HP;                             //�÷��̾� HP�� �����ִ� UI ����
    // Start is called before the first frame update
    void Start()
    {
        
        player_01.Attack();                                 //������ player_01 �� attack �Լ��� �����Ų��.
        player_01.Demage(30);                               //������ player_01 �� Demage �Լ��� �����Ų��. (�μ� 30�� �־��ش�)
    }

    // Update is called once per frame
    void Update()
    {
        player01HP.text = "Player 01 HP :" + player_01.GetHp().ToString();          //GetHP() �Լ��� ȣ���ϰ� ToString���� ���ڿ��� ��ȯ
        player02HP.text = "Player 02 HP :" + player_02.GetHp().ToString();          //GetHP() �Լ��� ȣ���ϰ� ToString���� ���ڿ��� ��ȯ

        if(Input.GetMouseButtonDown(0))     //���� ���콺�� ��������
        {
            player_01.Demage(1);            //player_01�� ��ü�� �Լ� Damage�� ���� (�Ķ���ͷδ� 1�� ����)
        }
        if (Input.GetMouseButtonDown(1))    //������ ���콺�� ��������
        {
            player_02.Demage(1);             //player_02�� ��ü�� �Լ� Damage�� ���� (�Ķ���ͷδ� 1�� ����)
        }
    }
}
