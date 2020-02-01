using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class blackholeController : MonoBehaviour
{

    [SerializeField]
    private GameObject player;
    [SerializeField]
    private float tetherRange;
    [SerializeField]
    private float forceMag;

    void Start()
    {
		
	}
	

	void Update()
    {
        if (WithinRange())
        {
            GetComponent<SpriteRenderer>().color = Color.black;
            if (Input.GetButton("Fire1"))
            {
                AddForce();
            }
        }
        else
        {
            GetComponent<SpriteRenderer>().color = Color.white;
        }
	}

    private bool WithinRange()
    {
        return Mathf.Abs((player.transform.position - transform.position).magnitude) <= tetherRange;
    }

    private void AddForce()
    {
        Vector3 direction = (transform.position - player.transform.position).normalized;
        player.GetComponent<shipController>().AddForce(forceMag * direction);
    }
}
