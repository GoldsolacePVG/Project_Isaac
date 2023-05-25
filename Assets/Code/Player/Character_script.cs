using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class Character_script : MonoBehaviour{
    
    public Transform tr_ = null;
    public Rigidbody rb_ = null;
    public GameObject go, pause_menu, tear_launcher;
    private Vector3 movDir_;
    public TearScript tears_;
    public float speed_ = 10f;
    public int level = 1;
    public int enemy_kills = 0;
    public int impulse_ = 100;

    // Start is called before the first frame update
    void Start(){
        tr_ = GetComponent<Transform>();
        rb_ = GetComponent<Rigidbody>();
        tears_ = tear_launcher.GetComponent<TearScript>();
        EnemyController ec = go.GetComponent<EnemyController>();
        ec.player_ = this;
    }

    // Update is called once per frame
    void Update(){
        movDir_.z = Input.GetAxis("Vertical");
        movDir_.x = Input.GetAxis("Horizontal");
        
        movDir_.Normalize();
        if(movDir_.z != 0.0f || movDir_.x != 0.0f){
            tr_.forward = movDir_;
        }

        if(Input.GetKeyDown(KeyCode.F)){
            rb_.AddForce(tr_.forward * impulse_, ForceMode.Impulse);
        }

        if(Input.GetKeyDown(KeyCode.P)){
            Time.timeScale = 0f;
            pause_menu.SetActive(true);
            tears_.enabled = false;
        }
    }

    void FixedUpdate(){
        rb_.velocity = movDir_ * speed_;
    }
}
