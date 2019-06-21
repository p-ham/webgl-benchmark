using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBehaviour : MonoBehaviour
{
    public GameObject cube;

    private List<GameObject> cubes = new List<GameObject>();
    private int cubesCount = 0;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if (cubesCount < 10000) {
            // create a copy of the cube prefab
            cubes.Add(Instantiate(cube, getRandomPosition(), Random.rotation));
            // change the color of the copy
            cubes[cubesCount].GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            cubesCount++;
        }

    }

    Vector3 getRandomPosition() {
        int x = Random.Range(-5, 5);
        int y = Random.Range(-5, 5);
        int z = Random.Range(-5, 5);
        return new Vector3(x, y, z);
    }
}
