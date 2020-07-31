﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonsterAnimation : MonoBehaviour
{

    public Animator anim;
    public Monster monster;

    private void Start()
    {
        anim = GetComponentInChildren<Animator>();
        monster = GetComponent<Monster>();
    }

    private void Update()
    {
        anim.SetFloat("Moving", monster.nav.speed);
        if (DebugTable.MonsterDebug)
            Debug.Log("Monster nav speed : " + monster.nav.speed);
    }

}