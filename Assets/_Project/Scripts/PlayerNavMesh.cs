using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using static UnityEngine.GraphicsBuffer;

namespace dnorambu
{
    
    public class PlayerNavMesh : MonoBehaviour
    {
        
        public Transform meta;

        public GameObject Dummy;
        private NavMeshAgent navMeshAgent;
        
        private NavMeshHit hitInfo;
        private GameObject temp;
        [SerializeField]
        private float _walkRadius = 10f;
        public float distance;

        private void Awake()
        {
            // Get the reference of NavMeshAgent component from gameObject
            navMeshAgent = GetComponent<NavMeshAgent>();
        }
        [ContextMenu("Set Destination")]
        public void GetNewRandomPosition()
        {
            // New random direction
            Vector3 randomDirection = Random.insideUnitSphere * _walkRadius + transform.position;
            // Get a new random point from the navmesh
            if (NavMesh.SamplePosition(randomDirection, out hitInfo, _walkRadius, NavMesh.AllAreas))
            {
                Debug.Log("New random position: " + hitInfo.position);
                temp = Instantiate(Dummy, hitInfo.position, Quaternion.identity);
                Destroy(temp, 3);
                navMeshAgent.SetDestination(hitInfo.position);
                StartCoroutine(CheckDestinationCompleted(navMeshAgent));
            }
            else
            {
                Debug.Log("No new random position found");
            }
        }
        private IEnumerator CheckDestinationCompleted(NavMeshAgent navMeshAgent)
        {
            while (!AgentReachedDestination(navMeshAgent))
            {
                yield return null;
            }
            Debug.Log("Done");

        }
        private bool AgentReachedDestination(NavMeshAgent agent)
        {
            if (!agent.pathPending)
            {
                if (agent.remainingDistance <= agent.stoppingDistance)
                {
                    if (!agent.hasPath || agent.velocity.sqrMagnitude == 0f)
                    {
                        return true;
                    }
                }
            }
            return false;
        }
        // Update is called once per frame
        void Update()
        {
            //navMeshAgent.destination = meta.position;

        }
        public void SetAgentDestination()
        {
            // Get the position of the target object
            Vector3 targetPos = meta.position;

            // Calculate the direction from the target to the agent's current position
            Vector3 direction = transform.position - targetPos;

            // Normalize the direction and multiply it by the desired distance
            Vector3 destinationOffset = direction.normalized * distance;

            // Add the destination offset to the target position to get the desired destination point
            Vector3 destination = targetPos + destinationOffset;

            // Set the NavMeshAgent's destination to the calculated point
            navMeshAgent.SetDestination(destination);
        }
        ///// <summary>
        ///// Dummy method
        ///// </summary>
        ///// <returns></returns>
        //public static float FloatReturnMethod()
        //{
        //    Debug.Log("FloatReturnMethod");
        //    return 1.0f;
        //}
    }
}