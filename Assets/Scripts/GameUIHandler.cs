using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameUIHandler : MonoBehaviour
{
    internal static bool startGame = false;
    [SerializeField] private PlayerController pc = null;
    [SerializeField] private EnemySpawner es = null;
    // Start is called before the first frame update
    void Start()
    {
        startGame = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StartGameBtn()
    {
        startGame = true;
        pc.enabled = true;
        es.enabled = true;
    }
}
