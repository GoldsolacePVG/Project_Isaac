using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class EnemyController : MonoBehaviour
{
    public int health_ = 2;
    public int boss_health = 15;
    private bool is_immortal_= false;    
    private float immortal_counter = 20.0f;
    private bool can_be_killed = true;
    public Character_script player_ = null;
    public bool is_boss = false;

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
        if(is_boss){
            boss_health -= value;
            if(boss_health <= 0){
                boss_health = 0;
                Destroy(gameObject);
                SceneManager.LoadScene(3);
            }
        }else{
            health_ -= value;
            if(health_ <= 0){
                health_ = 0;
                Destroy(gameObject);
                if(can_be_killed){
                    player_.enemy_kills++;
                    can_be_killed = false;
                }
            }
        }
    }
}
