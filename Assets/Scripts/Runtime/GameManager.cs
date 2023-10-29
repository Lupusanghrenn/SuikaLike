using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager Instance { get; private set; }

    [SerializeField]
    public FruitDatabase FruitDatabase;

    public int score = 0;

    void Start()
    {
        Instance = this;
    }

    public void HandleColliding(GameObject _fruit1, GameObject _fruit2)
    {
        FruitBehavior fruit1 = _fruit1.GetComponent<FruitBehavior>();
        FruitBehavior fruit2 = _fruit2.GetComponent<FruitBehavior>();

        if(fruit1.FruitID == fruit2.FruitID)
        {
            Debug.Log("Same Fruit");
            FruitData nextFruit = FruitDatabase.GetNextFruit(fruit1.FruitID);
            if(nextFruit != null)
            {
                SpawnFruit(nextFruit, _fruit1.transform);
            }
            Destroy(_fruit1);
            Destroy(_fruit2);
            ComputeScore(fruit1.FruitID);
        }
    }

    private void SpawnFruit(FruitData _fruitData, Transform _transform)
    {
        GameObject.Instantiate(_fruitData.gameObject, _transform.position, _transform.rotation);
    }

    private void ComputeScore(string _fruitID)
    {
        score += FruitDatabase.GetFruitScore(_fruitID);
    }
}
