using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Map : MonoBehaviour
{
    public int[,] date =
    {
        {0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0,0},
        {3,3,3,3,3,3,0,0,0,0,0,0,0,0,3,3,3,3},
        {2,2,2,2,2,2,0,0,0,0,0,0,0,0,2,2,2,2},
        {1,1,1,1,1,1,7,7,7,7,7,7,7,7,1,1,1,1},
        {1,1,1,1,1,1,0,0,0,0,0,0,0,0,1,1,1,1},
    };

    public GameObject[] floorPrefab;

	// Use this for initialization
	void Start ()
    {
		for(int i = 0;i < date.GetLength(0); i++)
        {
            for(int j = 0;j < date.GetLength(1); j++)
            {
                int floorNum = date[i, j];
                Vector3 instancePosition = new Vector3(j, i, 0.5f);
                Instantiate(floorPrefab[floorNum], instancePosition,Quaternion.identity);
            }
        }
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
