using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimientoShips : MonoBehaviour
{
    Vector3 myMov = Vector3.zero;
    public float movSpeed = 2;
    // Start is called before the first frame update
    void Start()
    {
        Application.targetFrameRate = 500;
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey(KeyCode.D))
        {
            myMov += Vector3.right;
            transform.eulerAngles = new Vector3(0, 0, 0);
        }
        if (Input.GetKey(KeyCode.A))
        {
            myMov += Vector3.left;
            transform.eulerAngles = new Vector3(0, 90, 0);
        }
        transform.Translate(myMov.normalized * Time.deltaTime * movSpeed, Space.World);
    }
}
