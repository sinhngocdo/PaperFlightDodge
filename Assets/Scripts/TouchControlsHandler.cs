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

public class TouchControlsHandler : MonoBehaviour, IPointerDownHandler, IPointerUpHandler //interface xu ly giao dien 
{
    [SerializeField] private Direction btnDirection = Direction.None;
    internal static bool left;
    internal static bool right;


    private void Start()
    {
        left = false;
        right = false;
    }
    /// <summary>
    /// IPointerUpHandler cho phep cac tap lenh goi lai khi mot con tro/cam ung duoc nhan tren phan tu giao dien nguoi dung duoc dinh kem
    /// 
    /// Method OnpoiterDown duoc tao de kiem tra su kien xac dinh huong duoc lien ket voi nut duoc nhan
    /// </summary>
    /// <param name="eventData"></param>
    public void OnPointerDown(PointerEventData eventData)
    {
        //neu duco nhan la ben trai thi xac dinh left=true va nguoc lai
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
