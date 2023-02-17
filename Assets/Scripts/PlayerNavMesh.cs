using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
/// <summary>
/// Dunno
/// </summary>
public class PlayerNavMesh : MonoBehaviour
{
    /// <summary>
    /// Se ve pajero esto
    /// </summary>
    public Transform meta;
    private NavMeshAgent navMeshAgent;
    
    private void Awake()
    {
        // Get the reference of NavMeshAgent component from gameObject
        navMeshAgent = GetComponent<NavMeshAgent>();    
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        navMeshAgent.destination = meta.position;
    }
    /// <summary>
    /// Dummy method
    /// </summary>
    /// <returns></returns>
    public static float FloatReturnMethod()
    {
        Debug.Log("FloatReturnMethod");
        return 1.0f;
    }
}
