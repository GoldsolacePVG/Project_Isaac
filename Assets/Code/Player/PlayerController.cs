using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public int lives_ = 3;
    private bool is_immortal_ = false;
    private float immortal_counter = 100.0f;

    void Update(){
        if(is_immortal_){
            immortal_counter--;
        }
        if(immortal_counter <= 0){
            immortal_counter = 100.0f;
            is_immortal_ = false;
        }
    }

    public void TakeDamage(int value){
        if(!is_immortal_){
            is_immortal_ = true;
            Debug.Log(gameObject.name + " says: OUCH! I received " + value + " damage, and I have " + lives_ + " lives");
            lives_ -= value;
            if(lives_ <= 0){
                lives_ = 0;
                Destroy(gameObject);
            }
        }
    }
}
