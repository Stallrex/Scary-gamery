using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//[[RequireComponent(typeof(NavMeshAgent))]]
public class Enemy : MonoBehaviour
{


    public Animator animator;
    public Transform target;

    public float followDistance = 10f;

    public float forgetDistance = 60f;
    UnityEngine.AI.NavMeshAgent agent;

    bool isFollowing;
    // Start is called before the first frame update
    void Start()
    {
        agent = GetComponent<UnityEngine.AI.NavMeshAgent>();

        InvokeRepeating(nameof(Wonder), 0, 15);
    }

    // Update is called once per frame
    void Update()
    {
    var distance = Vector3.Distance(transform.position, target.position);


    if(distance <= forgetDistance){
        isFollowing = true;
        
    }
    else if(distance >= forgetDistance){
        isFollowing = false;
    }

    if (isFollowing){
        agent.SetDestination(target.position);
    }
    
    animator.SetFloat("speed", agent.velocity.magnitude);
        
    }

    void Wonder(){
        if (isFollowing) return;
        var position = new Vector3();
        position.x = Random.Range(10, 1990);
        position.y = 500;
        position.z = Random.Range(10, 1990);

        if(Physics.Raycast(position, Vector3.down, out var hit)){

            agent.SetDestination(hit.point);
        }
    }

    private void OnCollisionEnter(Collision other) {
        if(other.gameObject.CompareTag("Player")){

            Jumpscare.instance.Show();

        }
    }
}
