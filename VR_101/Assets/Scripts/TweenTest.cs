using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;      //Tween을 쓰기 위해 선언

public class TweenTest : MonoBehaviour
{
    public bool isPunch = false;        //상자가 펀칭 중인지
    Sequence sequence;
    // Start is called before the first frame update
    void Start()
    {
        //transform.DOMoveX(5, 2);    //물체가 X방향으로 5만큼 2초동안 가겠다
        //transform.DORotate(new Vector3(0, 0, 180), 2);      //180초 2초 회전
        //transform.DOScale(new Vector3(3, 3, 3), 2);         //2초 동안 3배 크기

        //sequence = DOTween.Sequence();
        //sequence.Append(transform.DOMoveX(5, 2));       //setease 추가 옵션
        //sequence.Append(transform.DORotate(new Vector3(0, 0, 180), 2));     //완료되면 함수 호출
        //sequence.Append(transform.DOScale(new Vector3(3, 3, 3), 2));
        //sequence.SetLoops(-1, LoopType.Yoyo);

    }
    void SequnceEnd()
    {
        Debug.Log("회전 완료");
    }
    void EndPunch()
    {
        isPunch = false;        //펀칭이 끝났을 때 상태값을 다시 False로 변경
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (isPunch == false)
            {
                isPunch = true;
                transform.DOPunchScale(new Vector3(0.5f, 0.5f, 0.5f), 0.1f, 10, 1).OnComplete(EndPunch);

                Color color = new Color(Random.value, Random.value, Random.value);  //랜덤색을 정해서
                    
                Renderer renderer = GetComponent<Renderer>();                       //Renderer 컴포넌트에서 객체 선언
                renderer.material.DOColor(color, 0.1f);                             //Renderer Tween으로 반영
            }
        }
    }
}
