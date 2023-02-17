using System.Reflection;
using UnityEngine;
/// <summary>
/// Dummy
/// </summary>
public class TestScript : MonoBehaviour
{
    /// <summary>
    /// TestClass es la referencia a la clase que implementa los metodos
    /// que quiero mostrar en el inspector
    /// </summary>
    public TestClass tc;
    /// <summary>
    /// Dummy method for TestScript
    /// </summary>
    public void TcCaller()
    {
        tc._methodInfo.Invoke(tc, null);
    }

}