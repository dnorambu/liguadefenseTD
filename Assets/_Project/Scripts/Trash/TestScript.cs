using System.Reflection;
using UnityEngine;
namespace dnorambu
{
    /// <summary>
    /// Dummy 
    /// </summary>
    public class TestScript : MonoBehaviour
    {
        /* Constants: Counter Modes

       COUNTER_NORMAL - Causes the counter to increment normally.
       COUNTER_ODD    - Causes the counter to only increment in odd numbers.
       COUNTER_EVEN   - Causes the counter to only increment in even numbers.
        */
        const int COUNTER_NORMAL = 0;
        const int COUNTER_ODD = 1;
        const int COUNTER_EVEN = 2;
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
            Test2 test2 = new Test2();

        }
        /// <include file='player_navmesh.xml' path='MyDocs/MyMembers[@name="test"]/*' />
        class Test
        {
            static void Main()
            {
            }
        }

        /// <include file='player_navmesh.xml' path='MyDocs/MyMembers[@name="test2"]/*' />
        class Test2
        {
            public void Test()
            {
            }
        }
    }
}
