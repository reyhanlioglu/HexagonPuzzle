using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{

    void MoveDown()
    {
        transform.position += new Vector3(0, -1, 0);
    }

    // Start is called before the first frame update
    void Start()
    {
        //InvokeRepeating("MoveDown", 0, 0.5f);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
