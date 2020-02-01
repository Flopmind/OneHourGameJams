using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class goalPost : MonoBehaviour {

    [SerializeField]
    private int levelNum;
    [SerializeField]
    private float range;

    private GameObject player;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player");
    }

    private void Update()
    {
        if ((player.transform.position - transform.position).magnitude <= range)
        {
            Debug.Log("AAAAAAAAAAAAAAAhhh");
            SceneManager.LoadScene(levelNum);
        }
        if (Input.GetKeyDown(KeyCode.R))
        {
            SceneManager.LoadScene(levelNum - 1);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
        }
    }

}
