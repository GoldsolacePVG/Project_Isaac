using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform enemy_tr;
    public Transform player_tr;
    public float speed_ = 6.0f;
    private Vector3 distance_;

    // Start is called before the first frame update
    void Start(){
        enemy_tr = GetComponent<Transform>();
        player_tr = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update(){
        distance_ = enemy_tr.position - player_tr.position;
    }
}
