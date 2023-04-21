using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Start_game : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void StartGame(int sceneValue){
        SceneManager.LoadScene(sceneValue);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
