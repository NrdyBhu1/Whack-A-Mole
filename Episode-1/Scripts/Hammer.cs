using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using UnityEngine;
using Debug = UnityEngine.Debug;

public class Hammer : MonoBehaviour
{
    #region Variables
    private Camera _camera;
    private Vector2 _mousePosition;
    // private Quaternion _moveRotation;
    private float zRotation = 45f;
    public Vector2 offset;
    private Rigidbody2D _rb;
    #endregion
    
    void Start()
    {
        _camera = FindObjectOfType<Camera>();
        _rb = GetComponent<Rigidbody2D>();
        // _moveRotation = new Quaternion(0f, 0f, zRotation);
        // Debug.Log(_camera.name);

    }

    void FixedUpdate()
    {
        _mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        _rb.MovePosition(_mousePosition + offset);
        _rb.MoveRotation(new Quaternion(0f, 0f, 45f/4f, 0f));
        // transform.position = _mousePosition;
        // print(_mousePosition);
    }
}
