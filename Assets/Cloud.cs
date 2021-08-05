using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cloud : MonoBehaviour
{
    [Header("Set in Inspector")]
    public GameObject cloudSphere;
    public int numSpheresMin = 6;
    public int numSpheresMax = 10;
    public Vector3 sphereOffsetScale = new Vector3(5,2,1);
    public Vector2 sphereScaleRangeX = new Vector2(4,8);
    public Vector2 sphereScaleRangeY = new Vector2 (3, 4);
    public Vector2 sphereScaleRangeZ = new Vector2 (2, 4);


    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
