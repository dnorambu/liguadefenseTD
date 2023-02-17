using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/// <summary>
/// Clase dummy
/// </summary>
public class Seeker : MonoBehaviour
{
    /// <summary>
    /// El objeto que tiene un testscript añadido
    /// </summary>
    public GameObject target;
    // Start is called before the first frame update
    void Start()
    {
        target.GetComponent<TestScript>().TcCaller();
    }

    
}
