using System;
using UnityEngine;

public enum BallColor
{
    White,
    Red,
    Yellow,
    Green,
    Brown,
    Blue,
    Pink,
    Black
}

public class Ball : MonoBehaviour
{
    [SerializeField]
    private int point;

    [SerializeField]
    private BallColor color;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
