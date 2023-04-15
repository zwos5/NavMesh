using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class PlayerController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent agent;
    public ThirdPersonCharacter character;

    public GameObject rewardCube;

    public Transform[] spawnPoints;

    void Start()
    {
        agent.updateRotation = false;
        SpawnReward();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0))
        {
            Ray ray = cam.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            if(Physics.Raycast(ray, out hit))
            {
                agent.SetDestination(hit.point);
            }
        }

        if(agent.remainingDistance > agent.stoppingDistance)
        {
            character.Move(agent.desiredVelocity, false, false);
        }
        else
        {
            character.Move(Vector3.zero, false, false);
        }
        
    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Reward"))
        {
            other.gameObject.SetActive(false);

            Score.score = Score.score + 10;

            SpawnReward();
            //displayScore.text = score.ToString();
        }
    }

    void SpawnReward()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);
        Transform spawnPoint = spawnPoints[randomIndex];

        Instantiate(rewardCube, spawnPoint.position, spawnPoint.rotation);
    }
}
