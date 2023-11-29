using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class Collector : MonoBehaviour
{

    private AudioSource audioSource;
    public int collected;
    public AudioClip pickup;
    public TMP_Text counter;
    public GameObject flashlight;

    private void OnCollisionEnter(Collision other) {
        if (other.gameObject.CompareTag("Collectable")){

            Destroy(other.gameObject);
            collected++;
            audioSource.PlayOneShot(pickup);
            counter.text = collected.ToString();

        }
    }


    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKey(KeyCode.Mouse1)){

            flashlight.SetActive(true);
            
        }
        else{

            flashlight.SetActive(false);
        }
    }
}
