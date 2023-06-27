using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0f;//toc do cua nguoi choi
    [SerializeField] private float rotSpeed = 0f;//toc do xoay cua nguoi choi

    internal static bool isGameOver = false;

    private void Start()
    {
        isGameOver = false;
    }

    private void Update()
    {
        if (!isGameOver)
        {
            TouchHandler();

            PlayerReference();
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Enemy")
        {
            //enemy destroyer
            collision.gameObject.GetComponent<EnemyCnotroller>().isDestroyed = true;
            collision.gameObject.GetComponent<SpriteRenderer>().enabled = false;
            collision.gameObject.transform.GetChild(0).gameObject.SetActive(true);

            //Player destroyer
            GetComponent<SpriteRenderer>().enabled = false;
            gameObject.transform.GetChild(0).gameObject.SetActive(true);
            isGameOver = true;
        }
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
