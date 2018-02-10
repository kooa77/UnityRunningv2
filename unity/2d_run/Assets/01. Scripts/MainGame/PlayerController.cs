﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    // 유니티가 기본 제공 함수

	// Use this for initialization
	void Start ()
    {
        ChangeState(eState.RUN);
	}
	
	// Update is called once per frame
	void Update ()
    {		
	}

    public enum eState
    {
        IDLE,
        RUN,
    }

    void ChangeState(eState state)
    {
        switch(state)
        {
            case eState.IDLE:
                // 아이들 애니메이션 : 애니메이터에 isGround 패러미터를 true 만들어 주면된다.
                gameObject.GetComponent<Animator>().SetBool("isGround", true);
                break;
            case eState.RUN:
                // 달리기 애니메이션
                gameObject.GetComponent<Animator>().SetBool("isGround", true);
                gameObject.GetComponent<Animator>().SetFloat("Horizontal", 1.0f);
                break;
        }
    }
}