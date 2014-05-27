//	<Credits>
//	http://blog.gamesapps4u.com/2013/11/objects-pool-manager-in-unity3d.html
//	</Credits>



using UnityEngine;
using System.Collections;

public class ObjectPoolsInitializers : MonoBehaviour
{
    public GameObject frogBubbles;
    public GameObject crocodileBubbles;

    public int frogBubblePoolSize = 1;
    public int crocodileBubblePoolSize = 1;

    public static ObjectPoolsInitializers Instance;

    void Awake()
    {
        //InitializeObjectPools();
        Instance = this;
        InitializeObjectPools();
    }

    private void InitializeObjectPools()
    {
        ObjectPoolManager.Instance.CreatePool(PoolType.frogBubble, GetPool(frogBubbles, frogBubblePoolSize));
        ObjectPoolManager.Instance.CreatePool(PoolType.crocodileBubble, GetPool(crocodileBubbles, crocodileBubblePoolSize));
    }

    public ObjectPool GetPool(GameObject poolGameObject, int poolSize)
    {
        ObjectPool pool = new ObjectPool(poolGameObject, poolSize, (go) =>
        {
        });

        return pool;
    }
}

public enum PoolType
{
    frogBubble,
    crocodileBubble
}