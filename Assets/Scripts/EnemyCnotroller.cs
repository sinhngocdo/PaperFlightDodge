 using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyCnotroller : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 0f;//toc do di chuyen cua enemy
    [SerializeField] private float rotSpeed = 0f;//toc do xoay cua enemy
    [SerializeField] private Animator animator = null;

    internal bool isDestroyed = false;//bien trang thai cua enemy

    private Vector3 targetPos = Vector3.zero; 

    // Start is called before the first frame update
    void Start()
    {
        //khoi tao muc tieu bat dau cua enemy
        targetPos = new Vector2(Random.Range(-4, 4), Random.Range(-6, 6));
        Invoke("Disappear", Random.Range(6, 8));
    }

    // Update is called once per frame
    void Update()
    {
        //tinh khoang cach giua vi tri hien tai va vi tri muc tieu: neu nho hon 0.1f thi random lai vi tri vaf nguoc lai no se di chuyen den vi tri muc tieus

        if (!isDestroyed)
        {
            if (Vector2.Distance(transform.position, targetPos) < 0.1f)
            {
                targetPos = new Vector2(Random.Range(-4, 4), Random.Range(-6, 6));
            }
            else
            {
                transform.position = Vector2.MoveTowards(transform.position, targetPos, moveSpeed * Time.deltaTime);
            }

            transform.Rotate(Vector3.forward * rotSpeed);
        }
    }

    private void Disappear()
    {
        EnemySpawner.count--;
        animator.SetTrigger("Disappear");
        Destroy(gameObject, 3f);
    }
}
