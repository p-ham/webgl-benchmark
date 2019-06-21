using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainBehaviourPlanes : MonoBehaviour
{

    public GameObject plane;

    private List<GameObject> planes = new List<GameObject>();
    private int planesCount = 0;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (planesCount < 1000) {
            // create a copy of the cube prefab
            planes.Add(Instantiate(plane, new Vector3(0,planesCount * 0.000001f,0), Quaternion.identity));
            // change the color of the copy
            planes[planesCount].GetComponent<Renderer>().material.color = Random.ColorHSV(0f, 1f, 1f, 1f, 0.5f, 1f);
            planesCount++;
        }
    }
}
