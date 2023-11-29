using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Jumpscare : MonoBehaviour
{


    public GameObject jumpscare;
    public static Jumpscare instance;

    public float duration = 3;

    // Start is called before the first frame update
    void Start()
    {
     if(instance == null) instance = this;
     else Destroy(gameObject);   
    }



    public void Show(){

        jumpscare.SetActive(true);
        Invoke(nameof(Restart), duration);

    }

    void Restart(){

        SceneManager.LoadScene(SceneManager.GetActiveScene().name);

    }


    // Update is called once per frame
    void Update()
    {
        
    }
}
