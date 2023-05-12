using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearColScript : MonoBehaviour
{
    public int damage_ = 1;

    void OnCollisionEnter(Collision collision){
        EnemyController gc = null;
        gc = collision.gameObject.GetComponent<EnemyController>();

        if(gc != null){
            gc.TakeDamage(damage_);
            Destroy(gameObject);
        }
        if(collision.gameObject.CompareTag("Wall")){
            Destroy(gameObject);
        }
    }
}
