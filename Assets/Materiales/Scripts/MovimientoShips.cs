using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoShips : MonoBehaviour
{

    public float speed = 1;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        
        Vector2 position = transform.position;
        position.x = position.x + 0.1f * horizontal * speed;
        transform.position = position;
        
    }

    
}
