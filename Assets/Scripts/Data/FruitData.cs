using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FruitData
{
    [SerializeField]
    public FruitID idName;

    public int score = 0;
    public GameObject gameObject = null;
}
