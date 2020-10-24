using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Board mGameBoard;
    Spawner mSpawner;

    // Start is called before the first frame update
    void Start()
    {
       // mGameBoard = GameObject.FindWithTag("Board").GetComponent<Board>();
       // mSpawner = GameObject.FindWithTag("Spawner").GetComponent<Spawner>();


       mGameBoard = GameObject.FindObjectOfType<Board>();
       mSpawner = GameObject.FindObjectOfType<Spawner>();

       if(!mGameBoard){
           Debug.LogWarning("WARNING: No game board object found!");
       }
       if(!mSpawner){
             Debug.LogWarning("WARNING: No spawner object found!");
       }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
