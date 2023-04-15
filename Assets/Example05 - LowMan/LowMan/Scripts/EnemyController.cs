using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityStandardAssets.Characters.ThirdPerson;

public class EnemyController : MonoBehaviour
{
    public Camera cam;
    public NavMeshAgent enemy;
    public ThirdPersonCharacter character;
    public GameObject player;
    

    // Start is called before the first frame update
    void Start()
    {
        enemy.updateRotation = false;
        enemy = GetComponent<NavMeshAgent>();
    }

    // Update is called once per frame
    void Update()
    {

        enemy.SetDestination(player.transform.position);

    }

    void OnTriggerEnter(Collider other)
    {

        if (other.gameObject.CompareTag("Player"))
        {
            Lives.livesCount = Lives.livesCount - 1;
        }
    }
}
