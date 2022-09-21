using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class personaje : MonoBehaviour
{
    public float velocidad=10, salto=10, rotacion=10;
    public Rigidbody rb;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        float h = Input.GetAxis("Horizontal");
        float v = Input.GetAxis("Vertical");
        
        transform.Translate(new Vector3(h,0,v) * (Time.deltaTime * velocidad));

        float mouseX = Input.GetAxis("Mouse X");
        transform.Rotate(new Vector3(0,mouseX,0) * (Time.deltaTime * rotacion));

        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb.AddForce(new Vector3(0,salto,0),ForceMode.Impulse);
        }
        
    }
}
