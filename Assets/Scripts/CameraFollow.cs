using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform player;
    public Vector3 offset;

    void Start()
    {
    	// when it is public we set it in engine and there is no need to declare in start function
    	
       // player = GameObject.Find(PlayerPrefs.GetString("Player")).gameObject.transform;
      // player = GameObject.Find("Player").gameObject.transform;
    }

    void Update()
    {
        offset.x = player.forward.x * 2.5f;
        transform.position = Vector3.MoveTowards(transform.position, new Vector3(player.position.x + offset.x,
           player.position.y + offset.y, player.position.z + offset.z), 50 * Time.deltaTime);
    }
}
