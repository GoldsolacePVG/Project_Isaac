﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies1 : MonoBehaviour
{
    public GameObject EnemyPrefab;
    private Transform tr_;
    public bool is_active = false;

    // Start is called before the first frame update
    void Start(){
        tr_ = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update(){
        if(!is_active){
            CreateEnemies();
        }
    }

    void CreateEnemies(){
        GameObject en = Instantiate<GameObject>(EnemyPrefab, tr_.position, tr_.rotation);
        is_active = true;
    }
}
