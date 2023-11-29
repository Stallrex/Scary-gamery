using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{


    public GameObject prefab;
    public int count = 8;
    // Start is called before the first frame update
    void Start()
    {
        var position = new Vector3();
        for (int i = 0; i < count; i++){

            position.x = Random.Range(10, 1990);
            position.y = 300;
            position.z = Random.Range(10, 1990);


             if(Physics.Raycast(position, Vector3.down, out var hit)){

                    Instantiate(prefab, hit.point, Quaternion.EulerAngles(hit.normal));
        }

        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
