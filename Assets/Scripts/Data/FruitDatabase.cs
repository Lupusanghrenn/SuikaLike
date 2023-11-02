using System.Collections;
using System.Collections.Generic;
using System.Xml;
using UnityEngine;

[CreateAssetMenu]
public class FruitDatabase : ScriptableObject
{
    [SerializeField]
    public List<FruitData> fruitDatabase;

    public int GetFruitScore(FruitID _fruitID)
    {
        int index = GetFruitIndex(_fruitID);
        if (index < 0)
            return 0;
        return fruitDatabase[index].score;
    }

    public FruitData GetNextFruit(FruitID _fruitID)
    {
        int index = GetFruitIndex(_fruitID);
        if (index < 0 || index+1 >= fruitDatabase.Count)
            return null;
        return fruitDatabase[index + 1];
    }

    private int GetFruitIndex(FruitID _fruitID)
    {
        for(int i = 0; i < fruitDatabase.Count; i++)
        {
            if (fruitDatabase[i].idName == _fruitID)
                return i;
        }
        return -1;
    }
}
