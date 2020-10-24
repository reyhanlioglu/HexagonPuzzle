using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{


    private SpriteRenderer spriteRenderer;


    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }


    public void MoveUp()
    {
        transform.position += new Vector3(0, 2, 0);
    }

    public void MoveDown()
    {
        transform.position += new Vector3(0, -2, 0);
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

    public void setColor(Color color)
    {
        spriteRenderer.color = color;
    }

    public Transform GetTransform()
    {
        return transform;
    }


}
