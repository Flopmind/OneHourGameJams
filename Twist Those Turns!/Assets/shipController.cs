using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class shipController : MonoBehaviour
{

    [SerializeField]
    private Vector3 startVelocity;
    [SerializeField]
    private float veloTimerLength;

    private Vector3 velocity;
    private bool veloChanged;
    private float veloTimer;

    public Vector3 Velocity
    {
        get { return velocity; }
        set
        {
            velocity = value;
            return;
            if (veloChanged)
            {
                return;
            }
            else
            {
                veloChanged = true;
                veloTimer = veloTimerLength;
                Debug.Log("HI " + velocity.ToString());
            }
        }
    }

	void Start()
    {
        veloTimer = veloTimerLength;
        veloChanged = false;
	}
	
	void Update()
    {
		transform.position = transform.position + (Time.deltaTime * velocity);
        veloTimer -= Time.deltaTime;
        if (veloTimer <= 0)
        {
            veloChanged = false;
        }

	}

    public void Startup()
    {
        velocity = startVelocity;
    }

    public void AddForce(Vector3 force)
    {
        Velocity += force;
    }
}
