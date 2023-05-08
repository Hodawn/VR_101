using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public float speed = 5.0f;
    private Rigidbody rb;       //리지드 바디 선언 
    private Transform player;   //플레이어 위치 선언 

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();     //자기 자신의 리지드 바디 값 입력 
        player = GameObject.FindGameObjectWithTag("Player").transform;      //플레이어의 위치 값 입력 
    }

    // Update is called once per frame
    void Update()
    {
       if(Vector3.Distance(player.position, transform.position)>5.0f)
        {
            Vector3 direction = (player.position - transform.position).normalized;
            rb.MovePosition(transform.position + direction *speed*Time.deltaTime);
        }
    }
}
