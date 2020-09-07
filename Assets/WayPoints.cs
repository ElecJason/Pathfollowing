using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    [SerializeField] private GameObject[] waypoints;
    [SerializeField] private GameObject player;
    [SerializeField] private float speed = 5;
    [SerializeField] private int waypointIndex;


    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
        
        for (int i = 0; i < waypoints.Length; i++)
        {
            gameObject.transform.position = new Vector3(transform.position.x, 0, transform.position.z);
        }

    }

    // Update is called once per frame
    void Update()
    {
       
            Vector3 start = new Vector3(player.transform.position.x, 1, player.transform.position.z);
            player.transform.position = Vector3.MoveTowards(start, waypoints[waypointIndex].gameObject.transform.position, Time.deltaTime * speed);

            if (player.transform.position == waypoints[waypointIndex].gameObject.transform.position)
            {
                Debug.Log("Waypoint" +waypointIndex);
                waypointIndex++;
            }
        }
    }

