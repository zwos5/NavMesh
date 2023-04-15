using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RewardSpawner : MonoBehaviour
{
    public static GameObject rewardCube;

    public static Transform[] spawnPoints;

    public static void SpawnReward()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(rewardCube, spawnPoint.position, spawnPoint.rotation);
    }
}
