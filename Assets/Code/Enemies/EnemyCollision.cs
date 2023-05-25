using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCollision : MonoBehaviour
{
    public int damage_ = 1;
    public bool is_boss = false;

    void OnCollisionEnter(Collision collision){
        PlayerController gc = null;
        gc = collision.gameObject.GetComponent<PlayerController>();

        if(gc != null && !is_boss){
            gc.TakePlayerDamage(damage_);
        }else if(gc != null && is_boss){
            gc.TakePlayerBossDamage();
        }
    }
}
