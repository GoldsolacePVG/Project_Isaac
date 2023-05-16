using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_script : MonoBehaviour{
    
    public Transform tr_ = null;
    public Rigidbody rb_ = null;
    public float speed_ = 10f;
    private Vector3 movDir_;
    public int level = 1;

    // Start is called before the first frame update
    void Start(){
        tr_ = GetComponent<Transform>();
        rb_ = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update(){
        movDir_.z = Input.GetAxis("Vertical");
        movDir_.x = Input.GetAxis("Horizontal");



        // tr_.position = tr_.position + (movDir_ * speed_ * Time.deltaTime);
        
        movDir_.Normalize();
        if(movDir_.z != 0.0f || movDir_.x != 0.0f){
            tr_.forward = movDir_;
        }

    }

    void FixedUpdate(){
        rb_.velocity = movDir_ * speed_;
    }
}
