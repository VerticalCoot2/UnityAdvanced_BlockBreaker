using NUnit.Framework.Constraints;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [Range (0, 10)][SerializeField] private float speed = 1;
    void Start()
    {
        Cursor.visible = false;
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float speedModifier = Input.GetAxis("Mouse X") * speed * Time.deltaTime; //monke
        if ((transform.position.x + speedModifier >= -3.5f && transform.position.x + speedModifier <= 3.5f))
        {
            transform.position = new Vector3(transform.position.x + speedModifier, transform.position.y, transform.position.z);
        }
    }
}
