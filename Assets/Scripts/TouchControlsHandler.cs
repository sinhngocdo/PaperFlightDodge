using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

enum Direction
{
    Left,
    Right,
    None
}

public class TouchControlsHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
{
    [SerializeField] private Direction btnDirection = Direction.None;
    internal static bool left;
    internal static bool right;


    private void Start()
    {
        left = false;
        right = false;
    }

    public void OnPointerDown(PointerEventData eventData)
    {
        if(btnDirection == Direction.Left)
        {
            left = true;
            right = false;
        }
        else if(btnDirection == Direction.Right)
        {
            left = false;
            right = true;
        }
    }

    public void OnPointerUp(PointerEventData eventData)
    {
        left = false;
        right = false;
    }
}
