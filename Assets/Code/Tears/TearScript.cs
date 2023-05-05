using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TearScript : MonoBehaviour
{
    public GameObject TearPrefab_;
    public int impulse_ = 50;
    private Transform tr_;
    // Start is called before the first frame update
    void Start(){
        tr_ = GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update(){
        if(Input.GetButtonDown("Fire2")){
            Fire();
        }
    }

    void Fire(){
        GameObject go = Instantiate<GameObject>(TearPrefab_, tr_.position, tr_.rotation);

        Rigidbody rb = go.GetComponent<Rigidbody>();
        rb.AddForce(tr_.forward * impulse_, ForceMode.Impulse);
    }
}
