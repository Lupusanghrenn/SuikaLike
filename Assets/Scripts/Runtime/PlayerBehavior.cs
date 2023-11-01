using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehavior : MonoBehaviour
{
    public float maxXPosition;
    public float speed = 1f;
    public float waitingTimeBetweenFruit;

    private float moveValue;
    private float currentCDForFruit;

    public void OnMove(InputAction.CallbackContext _context)
    {
        moveValue = _context.ReadValue<float>();
    }

    public void OnDropFruit(InputAction.CallbackContext _context)
    {
        if (!_context.performed)
            return;
        if (currentCDForFruit > 0)
            return;

        Debug.Log("Drop fruit");
        GameManager.Instance.PlayerRequestedFruit(transform.position + Vector3.down);
        currentCDForFruit = waitingTimeBetweenFruit;
    }

    private void Update()
    {
        //if(Mathf.Abs(transform.position.x + moveValue) > maxXPosition) 
        float value = moveValue;
        //if((transform.position.x + value) > maxXPosition) 
        //{
        //    value = maxXPosition - transform.position.x;
        //}else if((transform.position.x + value) < -maxXPosition)
        //{
        //    value = -maxXPosition + transform.position.x;
        //}
        transform.position += Vector3.right * value * Time.deltaTime * speed;
        Debug.Log(value);

        currentCDForFruit = Mathf.Clamp(currentCDForFruit - Time.deltaTime, 0, waitingTimeBetweenFruit);
    }
}
