using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

[CreateAssetMenu]
public class FruitIDList : ScriptableSingleton<FruitIDList>
{
    public List<string> FruitIDs;
}
