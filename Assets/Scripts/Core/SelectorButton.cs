using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SelectorButton : MonoBehaviour
{
    [SerializeField]
    private GameObject buttonPrefab;

    public Button button;

    // Start is called before the first frame update
    void Start()
    {
        button.onClick.AddListener(HandleClick);
        Debug.Log("BUTTON LISTENER IS ADDED");
    }

    public void HandleClick()
    {
        Debug.Log("CLICKED BUTTON");
        GameObject go = Instantiate(buttonPrefab, transform.position, transform.rotation);

    }

}
