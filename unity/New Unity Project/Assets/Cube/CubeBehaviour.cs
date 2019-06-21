using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeBehaviour : MonoBehaviour
{
    public float speed = 10f;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(Vector3.right, speed * Time.deltaTime * 1);
        transform.Rotate(Vector3.up, speed * Time.deltaTime * 3);
    }
}
