using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManagerX : MonoBehaviour
{
    public GameObject[] ballPrefabs;

    private float spawnLimitXLeft = -22;
    private float spawnLimitXRight = 7;
    private float spawnPosY = 30;
    private float startDelay = 3.0f;
    private float spawnInterval = 2f;
    private int spawnindexmax = 0;
    private int spawnindexmin = 0;



    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomBall", startDelay, spawnInterval);
    }

    // Spawn random ball at random x position at top of play area
    void SpawnRandomBall()
    {
        // Generate random ball index and random spawn position
        Vector3 spawnPos = new Vector3(Random.Range(spawnLimitXLeft, spawnLimitXRight), spawnPosY, 0);
        spawnindexmax = ballPrefabs.Length;
        int ballindex = Random.Range(spawnindexmin, spawnindexmax);
        // instantiate ball at random spawn location
        Instantiate(ballPrefabs[ballindex], spawnPos, ballPrefabs[ballindex].transform.rotation);
    }

}
