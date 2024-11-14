using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBack : MonoBehaviour
{
    private float speed = 30.0f;
    private float backBound = -2.0f;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        {
            transform.Translate(Vector3.left * -1 * Time.deltaTime * speed);
        }

        if (transform.position.y < backBound && gameObject.CompareTag("Obstacle"))

        {
            Destroy(gameObject);
        }
    } 
}