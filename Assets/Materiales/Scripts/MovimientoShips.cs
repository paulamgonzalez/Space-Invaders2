using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoShips : MonoBehaviour
{
    Vector3 myMov = Vector3.zero;
    float vertical;

    public float movSpeed = 10;

    Rigidbody2D rigidbody2d;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 500;
    }

    // Update is called once per frame
    void Update()
    {
        vertical = Input.GetAxis("Vertical");
        

        Vector2 position = rigidbody2d.position;
        position = position  * movSpeed * Time.deltaTime;
        rigidbody2d.MovePosition(position);
    }
}
