using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int numberOfColors;

    [SerializeField]
    private GameObject hexagonPrefab;

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


    }

    public HexagonBlock getRandomShape()
    {
        int randomIndex = Random.Range(0, numberOfColors);
        Debug.Log("RANDOM INDEX " + randomIndex);


        GameObject go = Instantiate(hexagonPrefab, transform.position, transform.rotation);

        Renderer rend = go.GetComponent<Renderer>();
        rend.material.color = colorList[randomIndex];

        HexagonBlock component = go.GetComponent<HexagonBlock>();
        if (component != null)
        {
            Debug.Log("Component " + component);
        }

        return component;
    }

    // Update is called once per frame
    void Update()
    {

    }
}
