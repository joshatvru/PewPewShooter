using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class Splash : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Invoke("LoadLevel", 3f);

    }

    private void LoadLevel()
    {
        print("LoadLevel");
        SceneManager.LoadScene(1);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
