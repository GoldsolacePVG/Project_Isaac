using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies1 : MonoBehaviour
{
    public GameObject EnemyPrefab;
    private Transform tr_;
    public bool next = false;
    private bool is_active = false;
    private int count_down = 100;

    // Start is called before the first frame update
    void Start()
    {
        tr_ = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update(){
        // Character_script player = null;
        if(!is_active){
            CreateEnemies();
            count_down--;
            if(count_down <= 0){
                next = true;
                count_down = 0;
            }
        }
    }

    void CreateEnemies(){
        GameObject en = Instantiate<GameObject>(EnemyPrefab, tr_.position, tr_.rotation);
        is_active = true;
    }
}
