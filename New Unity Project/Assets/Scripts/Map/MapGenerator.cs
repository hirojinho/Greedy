using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MapGenerator : MonoBehaviour
{

    public GameObject[] hexTileMap;

    GameObject player;

    public int mapWidth = 25, mapHeight = 25;

    float tileXOffset = 3.75f, tileZOffset = 4.4f;

    // Start is called before the first frame update
    void Start()
    {
        createHexTileMap();
        player = GameObject.FindWithTag("Player");
    }

    void createHexTileMap()
    {
        for(int x = 0; x <= mapWidth; x += 1)
        {
            for(int z = 0; z <= mapHeight; z += 1)
            {
                int r = Random.Range(0, 11);

                GameObject temp00 = Instantiate(hexTileMap[r]);
                temp00.transform.SetParent(this.transform);

                if(x % 2 == 0)
                {
                    temp00.transform.position = new Vector3(x * tileXOffset, 0, z * tileZOffset);
                }

                else
                {
                    temp00.transform.position = new Vector3(x * tileXOffset, 0, z * tileZOffset + tileZOffset / 2);
                }
            }
        }
    }
}
