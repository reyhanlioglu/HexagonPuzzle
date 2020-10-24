using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    Board mGameBoard;
    Spawner mSpawner;

    float mDropInterval = 0.50f;
    float mTimeToDrop;

    Shape mActiveShape;

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

            mTimeToDrop = Time.time + mDropInterval;

            if (mActiveShape)
            {

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
