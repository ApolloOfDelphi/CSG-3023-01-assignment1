using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cubeGO = Instantiate<GameObject>(cubePrefab);
        Material mat = cubeGO.GetComponent<Renderer>().material;
        mat.color = Random.COlorHSV(0, 1, 0.5f, 1, 0.75, 1);
    }
}
