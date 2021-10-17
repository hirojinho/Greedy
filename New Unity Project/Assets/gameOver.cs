using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class gameOver : MonoBehaviour
{
    GameObject player;
    GameObject[] wasteLands;

    void Start()
    {
        player = GameObject.FindWithTag("Player");
    }
    void Update()
    {
        wasteLands = GameObject.FindGameObjectsWithTag("Waste");

        if(gameObject.transform.position.y < -5)
        {
            player.GetComponent<Transform>().position = new Vector3(0, 2, 0);
        }

        if(wasteLands.Length > 150)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
        }
    }
}
