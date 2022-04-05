using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CapsuleManipulate : MonoBehaviour
{
    Vector3 myVector;
    Rigidbody m_Rigidbody;
    public GameObject capsule;
    float m_Speed = 2.0f;
    // Start is called before the first frame update
    void Start()
    {
        myVector = new Vector3(0.0f, 1.0f, 0.0f);
        m_Rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float horizontalInput = Input.GetAxis("Horizontal");
        float verticalInput = Input.GetAxis("Vertical");

        transform.position = transform.position + new Vector3(horizontalInput * m_Speed * Time.deltaTime, verticalInput * m_Speed * Time.deltaTime, 0.0f);
        //Debug.Log(Time.deltaTime);
    }
}
