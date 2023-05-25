using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level_change : MonoBehaviour
{
    // public Character_script player_ = null;
    public Transform spawn_tr;
    public GameObject pl_, sp1_, sp2_, sp3_;
    private bool can_pass_lvl = true;
    private int pass_counter = 0;

    void Start(){
        pl_ = GameObject.FindGameObjectWithTag("Player");
    }

    void Update(){
        if(!can_pass_lvl){
            pass_counter++;
            if(pass_counter == 20){
                can_pass_lvl = true;
            }
        }
    }

    void OnCollisionEnter(Collision collision){
        Character_script gc = null;
        gc = collision.gameObject.GetComponent<Character_script>();
        SpawnEnemies1 se1 = null, se2 = null, se3 = null;
        se1 = sp1_.GetComponent<SpawnEnemies1>();
        se2 = sp2_.GetComponent<SpawnEnemies1>();
        se3 = sp3_.GetComponent<SpawnEnemies1>();

        if(gc != null && gc.enemy_kills == 3){
            pl_.transform.position = spawn_tr.transform.position;
            if(can_pass_lvl){
                gc.level++;
                can_pass_lvl = false;
            }
            se1.is_active = false;
            se2.is_active = false;
            se3.is_active = false;
            gc.enemy_kills = 0;
        }
    }
}
