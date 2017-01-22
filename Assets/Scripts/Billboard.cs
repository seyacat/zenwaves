using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Billboard : MonoBehaviour
{
    public Camera m_Camera;
    // Use this for initialization
    void Start()
    {
        m_Camera = GameObject.Find("Main Camera").GetComponent<Camera>();
            
    }

    // Update is called once per frame
    void Update()
    {
        /* Vector3 v = m_Camera.transform.position - transform.position;
         v.x = v.z = 0.0f;
         transform.LookAt(m_Camera.transform.position - v);*/

        Vector3 v = m_Camera.transform.position - transform.position;
        v.x = v.z = 0.0f;
        transform.LookAt(m_Camera.transform.position - v);
    }

}
