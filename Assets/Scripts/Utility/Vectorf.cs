﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class Vectorf
{
    public static Vector2 Round(Vector2 vector)
    {
        return new Vector2(Mathf.Round(vector.x), Mathf.Round(vector.y));
    }

}
