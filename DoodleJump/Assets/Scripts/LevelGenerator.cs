using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LevelGenerator : MonoBehaviour
{
    public GameObject Platforms;
    int platformnumber = 100;
    float levewidth = 5.5f;
    float miny = 1f;
    float maxy = 3f;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 spawn = new Vector3();

        for(int i=0; i< platformnumber; i++)
        {
            spawn.y += Random.Range(miny, maxy);
            spawn.x = Random.Range(-levewidth, levewidth);
            Instantiate(Platforms, spawn, Quaternion.identity); 
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
