using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerController : MonoBehaviour
{
    public int lives_ = 3;
    public Image[] heart;
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
        for(int i = 0; i < lives_; i++){
            heart[i].enabled = true;
        }
    }

    public void TakePlayerDamage(int value){
        if(!is_immortal_){
            is_immortal_ = true;
            lives_ -= value;
            heart[lives_].enabled = false;
            if(lives_ <= 0){
                lives_ = 0;
                Destroy(gameObject);
                SceneManager.LoadScene(2);
            }
        }
    }

    public void TakePlayerBossDamage(){
        if(!is_immortal_){
            lives_ = 0;
            for(int i = 0; i < lives_; i++){
                heart[i].enabled = false;
            }
            Destroy(gameObject);
            SceneManager.LoadScene(2);
        }
    }
}
