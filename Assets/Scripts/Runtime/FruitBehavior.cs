using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FruitBehavior : MonoBehaviour
{
    public FruitID FruitID;

    public bool enableCol = true;

    void OnCollisionEnter2D(Collision2D col)
    {
        if (!enableCol)
            return;

        //TODO Improve this hack, make ManagerOwner
        Debug.Log("OnCollisionEnter2D");
        if (col.gameObject.CompareTag("Fruit"))
        {
            Debug.Log(GameManager.Instance.name);
            col.gameObject.GetComponent<FruitBehavior>().enableCol = false;
            GameManager.Instance.HandleColliding(gameObject, col.gameObject);
        }
    }
}
