using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyController : MonoBehaviour
{
    public int health_ = 2;
    private bool is_immortal_= false;    
    private float immortal_counter = 20.0f;

    void Update(){
        if(is_immortal_){
            immortal_counter--;
        }
        if(immortal_counter <= 0){
            is_immortal_ = false;
            immortal_counter = 20.0f;
        }
    }

    public void TakeDamage(int value){
        health_ -= value;
        if(health_ <= 0){
            health_ = 0;
            Destroy(gameObject);
        }
    }
}
