using UnityEngine;

[RequireComponent(typeof(InputController))]
public class CameraMovement : MonoBehaviour
{
    [SerializeField] float _mouseSensitivity = 0f;
    [SerializeField] Transform _cameraAnchor = null;
    InputController _inputController = null;

    private void Awake()
    {
        _inputController = GetComponent<InputController>();
        Cursor.visible = false;
    }

    private void Update()
    {
        MouseCamera();
    }

    void MouseCamera()
    {
        Vector2 input = _inputController.MouseInput();

        transform.Rotate(Vector3.up * input.x * _mouseSensitivity * Time.deltaTime);

        Vector3 angle = _cameraAnchor.eulerAngles;
        angle.x -= input.y * _mouseSensitivity * Time.deltaTime;

        _cameraAnchor.eulerAngles = angle;
    }
}
