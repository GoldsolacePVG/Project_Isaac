using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PauseScript : MonoBehaviour
{
    public GameObject pause_menu, tear_launcher;
    public TearScript tears_;

    public void Start(){
        tears_ = tear_launcher.GetComponent<TearScript>();
    }

    public void Resume(){
        Time.timeScale = 1f;
        pause_menu.SetActive(false);
        tears_.enabled = true;
    }

    public void ReturnMenu(int sceneValue){
        Time.timeScale = 1f;
        SceneManager.LoadScene(sceneValue);
        tears_.enabled = true;
    }
}
