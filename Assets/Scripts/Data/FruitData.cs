using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[Serializable]
public class FruitData
{
    [SerializeField]
    public string idName = string.Empty;

    public int score = 0;
    public GameObject gameObject = null;
}
