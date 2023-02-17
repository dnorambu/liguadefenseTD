using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Metodo de prueba para retornar un float
/// </summary>
[CreateAssetMenu(fileName = "New BaseTester", menuName = "ScriptableObjects/BaseTester")]
public class SO_BaseTester : ScriptableObject
{
    /// <summary>
    /// Metodo de prueba para retornar un float
    /// </summary>
    /// <returns>Un dummy</returns>
    public static float FloatMethod()
    {
        Debug.Log("FloatMethod");
        return 1.0f;
    }
}
