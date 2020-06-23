using UnityEngine;

public class Hammer : MonoBehaviour
{
    #region Variables
    private Camera _camera;
    private Vector2 _mousePosition;
    private Quaternion _moveRotation;
    public Vector2 offset;
    private Rigidbody2D _rb;
    #endregion
    
    void Start()
    {
        _camera = FindObjectOfType<Camera>();
        _rb = GetComponent<Rigidbody2D>();
        _moveRotation = new Quaternion(0f, 0f, 45f, 0f);
        // Debug.Log(_camera.name);

    }

    void FixedUpdate()
    {
        _mousePosition = _camera.ScreenToWorldPoint(Input.mousePosition);
        _rb.MovePosition(_mousePosition + offset);
        if (Input.GetMouseButtonDown(0))
        {
            _moveRotation.z = -150f;
        }
        else
        {
            _moveRotation.z = 45f;
        }
        // _moveRotation.z = (45f * Input.GetAxisRaw("Fire1"));
        if (transform.rotation != _moveRotation)
        {
            // StartCoroutine(Wait());
            transform.Rotate(_moveRotation.x, _moveRotation.y, _moveRotation.z);
        }
        else
        {
            return;
        }
        // transform.position = _mousePosition;
        // print(_mousePosition);
    }
    
}
