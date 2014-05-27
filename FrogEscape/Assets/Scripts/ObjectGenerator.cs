//	<Credits>
//	http://blog.gamesapps4u.com/2013/11/objects-pool-manager-in-unity3d.html
//	</Credits>



using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using System;
using System.Linq;
using Rand = UnityEngine.Random;

public class ObjectGenerator : MonoBehaviour
{

    float rateOfSpawn = 1.0f;
    float nextSpawn = 2.0f;


    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        PoolType type = PoolType.frogBubble;
        string name = string.Empty;
        if (Time.time > nextSpawn)
        {
            switch (Rand.Range(0, 2))
            {
                case 0: name = "FrogBubble";
                    type = PoolType.frogBubble;
                    break;
                case 1: name = "CrocodileBubble";
                    type = PoolType.crocodileBubble;
                    break;
                default: break;
			}
			ObjectPoolManager.Instance.Spawn(type, new Vector3(Rand.Range(-2.651204f, 2.577209f), Rand.Range(-3.950922f, -0.353931f), -3));
            rateOfSpawn = Rand.Range(.1f,1f);
            nextSpawn = Time.time + rateOfSpawn;
        }
    }


}
