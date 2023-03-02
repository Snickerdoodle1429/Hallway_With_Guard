using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class MazeEnemy : MonoBehaviour
{
    NavMeshAgent enemy;
    GameObject player;
    [SerializeField]
    private Transform[] points;

    [SerializeField]
    private float minRemainingDistance = 0.5f;

    private int destinationPoint = 0;



    // Start is called before the first frame update
    void Start()
    {
        enemy = GetComponent<NavMeshAgent>();
        player = GameObject.FindWithTag("Player");
        enemy.autoBraking = false;
        GoToNextPoint();
    }

    void OnTriggerEnter (Collider hit)
    {
        //if game tag is stun
            //disable movement
            //set stun flag to true
    }

    void GoToNextPoint()
    {
        if(points.Length == 0)
        {
            Debug.LogError("You need at least one point set up!");
            enabled = false;
            return;
        }

        enemy.destination = points[destinationPoint].position;
        destinationPoint = (destinationPoint + 1) % points.Length;
    }

    IEnumerator stunned()
    {
        yield return new WaitForSeconds(3);
    }

    // Update is called once per frame
    void Update()
    {
        if(!enemy.pathPending && enemy.remainingDistance < minRemainingDistance)
        {
            GoToNextPoint();
        }

        //if enemy is in sight
        //enemy.SetDestination(player.transform.position);

        if(Input.GetKeyDown("space")) //Using Q just to test it works
        {
            stunned();
        }
        //if(Input.GetKeyUp ("Q"));
    }
}