using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Character_script : MonoBehaviour{

    public int health = 100;
    public Transform tr_ = null;
    public float speed_ = 5f;
    private Vector3 movDir_;

    // Start is called before the first frame update
    void Start(){
        tr_ = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update(){
        movDir_.z = Input.GetAxis("Vertical");
        movDir_.x = Input.GetAxis("Horizontal");
        // movDir_.y = 0.0f;
        // movDir_.Normalize();

        tr_.Translate(movDir_ * speed_ * Time.deltaTime);
    }
}
