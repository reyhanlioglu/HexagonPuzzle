using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public Shape[] mAllHexagons;
    public int numberOfColors;

    private Color[] colorList = {
        new Color(255, 0, 0), // Red
        new Color(255, 128, 0), //Orange
        new Color(0, 102, 51),//Green
        new Color(0, 76, 153), //Blue
        new Color(51, 0, 102), //Purple
        new Color(51, 25, 0), //Brown
        new Color(255, 0, 127), //Pink
        new Color(204, 255, 153), //Light Green
        new Color(64, 64, 64), // Grey
        new Color(153, 255, 255) //Light Blue
    };

    void Awake()
    {

    }

    // Start is called before the first frame update
    void Start()
    {
        if (numberOfColors <= 0)
        {
            numberOfColors = 5;
        }


        initHexagons();

    }

    void initHexagons()
    {
        for (int i = 0; i < numberOfColors; i++)
        {
            Shape hexagon = gameObject.AddComponent<Shape>();
            hexagon.setColor(colorList[i]);
            mAllHexagons[i] = hexagon;
        }
    }

    public Shape getRandomShape()
    {
        int randomIndex = Random.Range(0, numberOfColors);
        Debug.Log("RANDOM INDEX " + randomIndex);
        return mAllHexagons[randomIndex];
    }

    // Update is called once per frame
    void Update()
    {

    }
}
