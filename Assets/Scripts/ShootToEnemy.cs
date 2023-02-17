using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace dnorambu
{
    /// <summary>
    /// Shooting class behaviour
    /// </summary>
    public class ShootToEnemy : MonoBehaviour
    {
        [SerializeField]
        GameObject bullet;
        // Start is called before the first frame update
        void Start()
        {
            //InvokeRepeating();
            if (bullet == null)
            {
                Debug.LogError("There is no bullte prefab");
            }
        }

        // Update is called once per frame
        void Update()
        {

        }

        //Shooting
        private void Shoot()
        {
            GameObject bulletCopy = Instantiate(bullet, transform.position, Quaternion.identity);

        }
    }
}