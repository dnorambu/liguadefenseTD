using System.Collections;
using System.Collections.Generic;
#if UNITY_EDITOR
using UnityEditor;
using UnityEngine;

namespace dnorambu
{
    /// <summary>
    /// Editor personalizado para la clase <see cref="TestClass"/>
    /// </summary>
    /// <returns>Un dummy</returns>
    [CustomEditor(typeof(TestClass)), CanEditMultipleObjects]
    public class TestScriptDrawer : Editor
    {
        /// <summary>
        /// Metodo de prueba para retornar un float
        /// </summary>
        /// <returns>Un dummy</returns>
        public override void OnInspectorGUI()
        {
            base.OnInspectorGUI();
            // Make a dropdown with all the methods
            TestClass tc = (TestClass)target;
            GUIContent arrayList = new GUIContent("My Methods List");
            tc._selectedMethodIndex = EditorGUILayout.Popup(arrayList, tc._selectedMethodIndex, tc._methods.ToArray());

        }
    }
}
#endif