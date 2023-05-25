using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBoss : MonoBehaviour
{
    public GameObject BossPrefab;
    private Transform tr_;
    public bool is_active = true;

    // Start is called before the first frame update
    void Start(){
        tr_ = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update(){
        if(!is_active){
            CreateBoss();
        }
    }

    void CreateBoss(){
        GameObject gc = Instantiate<GameObject>(BossPrefab, tr_.position, tr_.rotation);
        is_active = true;
    }
}
