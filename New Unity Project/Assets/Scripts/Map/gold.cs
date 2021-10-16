using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class gold : MonoBehaviour
{
    GameObject player, spherePhy, enemy;
    public GameObject wasteland;
    public GameObject[] sphere;
    bool exploring = false, isplayer = false;
    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindWithTag("Player");
        enemy = GameObject.FindWithTag("Enemy");
    }

    // Update is called once per frame
    void Update()
    {
        if(enemy.GetComponent<enemyPlaying>().playing == false)
        {
            int l = Random.Range(95, 105);
            if(l == 100 && exploring == false)
            {
                enemy.GetComponent<enemyPlaying>().playing = true;
                exploring = true;
                StartCoroutine(exploreGold(sphere[1]));
            }
        }
    }
    
    void OnTriggerStay(Collider other)
    {
        if(Input.GetKeyDown(KeyCode.E) && exploring == false)
        {
            isplayer = true;
            StartCoroutine(exploreGold(sphere[0]));
            exploring = true;
        }
    }
    
    IEnumerator exploreGold(GameObject sphere)
    {
        spherePhy = Instantiate(sphere);
        spherePhy.transform.SetParent(this.transform);

        if(isplayer == true)
        {
            for(int i = 0; i < 10; i++)
            {
                player.GetComponent<resources>().gold += 5.0f;
                yield return new WaitForSeconds(15);
            }
        }

        else
        {
            yield return new WaitForSeconds(60);
            enemy.GetComponent<enemyPlaying>().playing = false;
        }

        Destroy(gameObject);
        GameObject temp00 = Instantiate(wasteland);
        temp00.transform.position = this.transform.position;
        Debug.Log("teste");
    }
}