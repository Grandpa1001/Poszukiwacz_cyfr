using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;



public class Level_Manager : MonoBehaviour {
    public void LoadLevel(string name){
        Debug.Log("Level load requested for: " + name);
        Application.LoadLevel(name);

    }
    public void QuitRequest() {
        Debug.Log("Key Quit does't work");
        Application.Quit();
    }
}