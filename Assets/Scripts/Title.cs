using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Title : MonoBehaviour
{

    
    void Start()
    {

    }
    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            SceneManager.LoadScene("Main");
        }
    }
    
}
