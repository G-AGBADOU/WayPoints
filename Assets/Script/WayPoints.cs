using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WayPoints : MonoBehaviour
{
    public Vector3 scale = new Vector3(1, 1, 1);

    void OnDrawGizmos()
    {
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, 0.5f);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

   
}
