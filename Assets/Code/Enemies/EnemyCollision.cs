using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public int damage_ = 1;

    void OnCollisionEnter(Collision collision){
        PlayerController gc = null;
        gc = collision.gameObject.GetComponent<PlayerController>();

        if(gc != null){
            gc.TakePlayerDamage(damage_);
        }
    }
}
