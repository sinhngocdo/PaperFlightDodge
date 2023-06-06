using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0f;
    [SerializeField] private float rotSpeed = 0f;

    private void Update()
    {
        TouchHandler();

        PlayerReference();
    }

    private void TouchHandler()
    {
        transform.Translate(Vector3.up * Time.deltaTime * moveSpeed);
        if (TouchControlsHandler.left)
        {
            transform.Rotate(Vector3.forward * rotSpeed);
        }
        else if (TouchControlsHandler.right)
        {
            transform.Rotate(-Vector3.forward * rotSpeed);
        }
    }

    private void PlayerReference()
    {
        if (transform.position.x > 3.4 || transform.position.x < -3.4)
        {
            transform.position = new Vector2(-transform.position.x, transform.position.y);
        }
        if (transform.position.y > 5.5 || transform.position.y < -5.5)
        {
            transform.position = new Vector2(transform.position.x, -transform.position.y);
        }
    }
}
