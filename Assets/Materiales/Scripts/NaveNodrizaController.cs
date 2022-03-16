using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NaveNodrizaController : MonoBehaviour
{
    float speed = 30f;
    float maxLeft = -157f;
    float timer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector3.left * speed * Time.deltaTime);
        if(transform.position.x <= maxLeft)
        {
            Destroy(gameObject);
        }
    }
}
