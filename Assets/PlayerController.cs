using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private int speed = 10;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Vector2 mousePos;
        mousePos.x = Input.mousePosition.x-5;
        mousePos.y = Camera.main.pixelHeight - Input.mousePosition.x;

        Vector3 point = Camera.main.ScreenToViewportPoint(new Vector3
        (
            mousePos.x-10,
            mousePos.y,
            Camera.main.nearClipPlane * speed
        ));

        transform.position = new Vector3(point.x * speed, transform.position.y, transform.position.z);
    }
}
