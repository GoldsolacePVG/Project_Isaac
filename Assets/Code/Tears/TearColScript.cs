using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearColScript : MonoBehaviour
{
    public int damage_ = 1;

    void OnCollisionEnter(Collision collision){
        EnemyController gc = null;
        RoomCollision rc = null;
        gc = collision.gameObject.GetComponent<EnemyController>();
        rc = collision.gameObject.GetComponent<RoomCollision>();

        if(gc != null){
            gc.TakeDamage(damage_);
            Destroy(gameObject);
        }
        if(rc != null){
            Destroy(gameObject);
        }
    }
}
