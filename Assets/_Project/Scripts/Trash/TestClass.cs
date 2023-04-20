using System.Collections;
using System.Collections.Generic;
using System.Reflection;
using UnityEngine;

namespace dnorambu
{
    /// <summary>
    /// Solo una clase de prueba que servira para ver si sale documentacion
    /// </summary>
    [CreateAssetMenu(fileName = "New TestClass", menuName = "ScriptableObjects/Test Class")]

    public class TestClass : ScriptableObject
    {
        /// <summary>
        /// Selected method index
        /// </summary>
        public int _selectedMethodIndex;
        /// <summary>
        /// List of methods available by the flags
        /// </summary>
        public List<string> _methods = new();
        /// <summary>
        /// Object that holds methods definitions
        /// </summary>
        public Object cosa;
        /// <summary>
        /// Cache for selected method
        /// </summary>
        public MethodInfo _methodInfo;
        /// <summary>
        /// Flags to show methods of Object field
        /// </summary>
        public BindingFlags flags = BindingFlags.Public | BindingFlags.Static | BindingFlags.DeclaredOnly;
        private void Awake()
        {
            Debug.Log("Awake called in: " + name);
        }

        private void OnValidate()
        {
            ResetMethods();
        }
        private void ResetMethods()
        {
            _methods = new();
            var methodInfos = cosa.GetType().GetMethods(flags);
            foreach (var method in methodInfos)
            {
                _methods.Add(method.Name);
            }
        }
        private void OnEnable()
        {
#if UNITY_EDITOR
            ResetMethods();
#endif

            UpdateMethodInfo();
        }
        /// <summary>
        /// Actualiza el metodo seleccionado
        /// </summary>
        public void UpdateMethodInfo()
        {
            _methodInfo = cosa.GetType().GetMethod(_methods[_selectedMethodIndex]);
            Debug.Log("Method info: " + _methodInfo.ToString());
        }
        /// <summary>
        /// Metodo de prueba para retornar un float
        /// </summary>
        /// <returns>Un dummy</returns>
        public static float FloatReturnMethod()
        {
            Debug.Log("FloatReturnMethod");
            return 1.0f;
        }
        /// <summary>
        /// Metodo de prueba para retornar un int
        /// </summary>
        /// <returns>Un dummy</returns>
        public static int IntReturnMethod()
        {
            Debug.Log("IntReturnMethod");
            return 1;
        }
        /// <summary>
        /// Metodo de prueba para retornar un string
        /// </summary>
        /// <returns>Un dummy</returns>
        public static string StringReturnMethod()
        {
            Debug.Log("StringReturnMethod");
            return "StringReturnMethod";
        }
        /// <summary>
        /// Metodo de prueba para retornar un bool
        /// </summary>
        /// <returns>Un dummy</returns>
        public static bool BoolReturnMethod()
        {
            Debug.Log("BoolReturnMethod");
            return true;
        }
        /// <summary>
        /// Metodo de prueba con varios parametros
        /// </summary>
        public void VoidReturnMethodWithParameters(int a, float b, string c, bool d)
        {
            Debug.Log("VoidReturnMethodWithParameters");
            Debug.Log(a);
            Debug.Log(b);
            Debug.Log(c);
            Debug.Log(d);
        }
        /// <summary>
        /// Metodo de prueba con parametros para retornar un float
        /// </summary>
        /// <returns>Un dummy</returns>
        public float FloatReturnMethodWithParameters(TestClass tc, string c)
        {
            Debug.Log("FloatReturnMethodWithParameters");
            Debug.Log(tc.ToString());
            Debug.Log(c);
            return 1.0f;
        }

    }
}