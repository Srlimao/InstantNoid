using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class MouseMover : MonoBehaviour
{
    Rigidbody2D rb = null;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        rb.MovePosition(Camera.main.ScreenToWorldPoint(Mouse.current.position.ReadValue()));
    }
}
