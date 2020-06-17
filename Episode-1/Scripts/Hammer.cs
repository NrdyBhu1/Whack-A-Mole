using UnityEngine;

public class Hammer : MonoBehaviour
{
    #region Variables
    private Camera _camera;
    private Vector2 _mousePosition;
    public Vector2 offset;
    private Rigidbody2D _rb;
    #endregion
    
    void Start()
    {
        _camera = FindObjectOfType<Camera>();
        _rb = GetComponent<Rigidbody2D>();
        // Debug.Log(_camera.name);

    }

    void FixedUpdate()
    {
        _mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        _rb.MovePosition(_mousePosition + offset);
        // transform.position = _mousePosition;
        // print(_mousePosition);
    }
}
