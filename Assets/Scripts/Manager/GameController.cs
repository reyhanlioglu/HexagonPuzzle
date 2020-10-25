using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Board mGameBoard;
    Spawner mSpawner;

    float mDropInterval = 0.50f;
    float mTimeToDrop;

    HexagonBlock mActiveShape;

    // Start is called before the first frame update
    void Start()
    {
        // mGameBoard = GameObject.FindWithTag("Board").GetComponent<Board>();
        // mSpawner = GameObject.FindWithTag("Spawner").GetComponent<Spawner>();


        mGameBoard = GameObject.FindObjectOfType<Board>();
        mSpawner = GameObject.FindObjectOfType<Spawner>();

        if (mSpawner)
        {
            mActiveShape = mSpawner.getRandomShape();
            Debug.Log("ACTIVE SHAPE " + mActiveShape);
        }


        if (!mGameBoard)
        {
            Debug.LogWarning("WARNING: No game board object found!");
        }
        if (!mSpawner)
        {
            Debug.LogWarning("WARNING: No spawner object found!");
        }

    }

    // Update is called once per frame
    void Update()
    {
        if (!mGameBoard || !mSpawner)
        {
            return;
        }


        if (Time.time > mTimeToDrop)
        {
            Debug.Log("TIME");

            mTimeToDrop = Time.time + mDropInterval;

            if (mActiveShape)
            {
                Debug.Log("MOVE DOWN");

                mActiveShape.MoveDown();

                if (!mGameBoard.IsValidPosition(mActiveShape))
                {
                    mActiveShape.MoveUp();

                    if (mSpawner)
                    {
                        mActiveShape = mSpawner.getRandomShape();

                    }
                }
            }
        }
    }
}
