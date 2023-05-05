using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyScript : MonoBehaviour
{
    public Transform player_tr;
    public float speed_ = 6.0f;

    // Start is called before the first frame update
    void Start(){

    }

    // Update is called once per frame
    void Update(){
        transform.LookAt(player_tr);
        transform.position = Vector3.MoveTowards(transform.position, player_tr.position, speed_ * Time.deltaTime);
    }
}
