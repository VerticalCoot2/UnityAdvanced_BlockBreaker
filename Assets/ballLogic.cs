using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ballLogic : MonoBehaviour
{
    [SerializeField] private int speed = 5;
    private Rigidbody rb;

    private void Awake()
    {
        rb = GetComponent<Rigidbody>();
    }

    void Start()
    {
        rb.AddForce(0, 0, - speed, ForceMode.Impulse);
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Player":
                Vector3 heading = collision.transform.position - transform.position;
                Vector3 direction = -heading / heading.magnitude;
                rb.velocity = direction * speed;
                break;
        }
    }
}
