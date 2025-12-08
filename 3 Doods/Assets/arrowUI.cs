using NUnit.Framework;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class arrowUI : MonoBehaviour
{
    private int Count = 3;
    [SerializeField] private GameObject arrow1, arrow2, arrow3, arrow4, arrow5;
    private List<GameObject> arrows = new List<GameObject> { };
    private void Start()
    {
        arrows.Add(arrow1);
        arrows.Add(arrow2);
        arrows.Add(arrow3);
        arrows.Add(arrow4);
        arrows.Add(arrow5);
    }
    private void Update()
    {
        if (Mouse.current.leftButton.wasPressedThisFrame)
        {
            arrowCount(ref Count);
        }
    }
    private void arrowCount(ref int Count)
    {
        arrows[Count - 1].SetActive(false);
        Count--;
    }
}
