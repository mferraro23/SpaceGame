using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AsteroidFieldGenerator : MonoBehaviour
{
    public int asteroidCount = 200;
    public float distance = 50.0f;

    public List<GameObject> asteroids;


    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < asteroidCount; i++)
        {
            int which = Random.Range(0, asteroids.Count);

            var pos = Random.insideUnitSphere * distance;
            var rot = Random.rotation;
            Instantiate(asteroids[which], pos, rot);


        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
