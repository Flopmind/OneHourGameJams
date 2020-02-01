using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{

    private GameObject player;
    private bool hasCalled;

	void Start()
    {
        hasCalled = false;
	}
	
	void Update()
    {
        if (player == null)
        {
            player = GameObject.FindGameObjectWithTag("Player");
        }
        else
        {
            transform.position = new Vector3(player.transform.position.x, player.transform.position.y, -10.0f);
        }

        if (Input.GetKeyDown(KeyCode.Space) && player && !hasCalled)
        {
            hasCalled = true;
            player.GetComponent<shipController>().Startup();
        }
	}
}
