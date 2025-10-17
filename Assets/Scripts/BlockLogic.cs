using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlockLogic : MonoBehaviour
{
    public int health = 4;
    private double life = 0.5;

    Renderer r;

    private void Awake()
    {
        r = GetComponent<Renderer>();
        
    }

    private Color[] colors =
    {
        new Color (1,0,0,1), //red
        new Color(1, 0.5f, 0, 1), //orange
        new Color(1,1,0,1), //yellow
        new Color(0,1,0,0)//green?
        
    };

    void Start()
    {
        r.material.color = colors[3];
    }

    private void OnCollisionEnter(Collision collision)
    {
        switch(collision.gameObject.tag)
        {
            case "Ball":
                health--;
                if (health > 0) r.material.color = colors[health - 1];
                else if (health <= 0) Destroy(gameObject);
                break;
        }
    }

    public void Recolor()
    {
        //GetComponent<Renderer>().material.color = Random.ColorHSV();
    }
}
