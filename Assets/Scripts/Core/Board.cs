﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Board : MonoBehaviour
{
    public Transform mEmptySprite;

    public int mHeight;
    public int mWeight;

    Transform[,] mGrid;

    void Avake()
    {
        mGrid = new Transform[mWeight, mHeight];
    }

    // Start is called before the first frame update
    void Start()
    {
        DrawEmptyCells();
    }

    // Update is called once per frame
    void Update()
    {

    }

    bool IsWithinBoard(int x, int y)
    {
        Debug.LogWarning("X:" + x + "Y:" + y);
        if ((x % 2 == 0 && y > 0) || (x % 2 != 0 && y > -1))
        {
            return true;
        }
        return false;
    }

    public bool IsValidPosition(Shape shape)
    {

        if (!IsWithinBoard((int)shape.GetTransform().position.x, (int)shape.GetTransform().position.y))
        {
            return false;
        }
        return true;
    }

    void DrawEmptyCells()
    {
        if (mEmptySprite != null)
        {
            for (int y = 0; y < mHeight; y++)
            {
                for (int x = 0; x < mWeight; x++)
                {

                    Transform clone;
                    if (x % 2 == 0)
                    {
                        clone = Instantiate(mEmptySprite, new Vector3(x * 2, y * 2 + 1, 0), Quaternion.identity) as Transform;
                    }
                    else
                    {
                        clone = Instantiate(mEmptySprite, new Vector3(x * 2, y * 2, 0), Quaternion.identity) as Transform;
                    }
                    clone.name = "Board Space ( x = " + x + " , y = " + y + " )";
                    clone.transform.parent = transform;
                }
            }
        }
        else
        {
            Debug.Log("WARNING! Assign the emptySprite object!");
        }
    }
}
