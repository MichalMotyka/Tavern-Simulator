using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] public Camera Camera;
    public float sensitivity;
    public float rotationsensitivity;

    // Update is called once per frame
    void Update()
    {
        MoveCamera();
    }

    private void MoveCamera()
    {
        if (Input.GetKey(KeyCode.W))
        {
            Camera.transform.Translate(Vector3.forward * sensitivity);
        }
        else if (Input.GetKey(KeyCode.S))
        {
            Camera.transform.Translate(Vector3.back * sensitivity);
        }

        if (Input.GetKey(KeyCode.A))
        {
            Camera.transform.Translate(Vector3.left * sensitivity);
        }
        else if (Input.GetKey(KeyCode.D))
        {
            Camera.transform.Translate(Vector3.right * sensitivity);
        }

        if (Input.GetKey(KeyCode.E))
        {
            Camera.transform.Rotate(new Vector3(0, rotationsensitivity, 0));
        }
        else if (Input.GetKey(KeyCode.Q))
        {
            Camera.transform.Rotate(new Vector3(0, -rotationsensitivity, 0));
        }

        // if (Input.GetMouseButton(1))
        // {
        //     float mouseX = Input.GetAxis("Mouse X");
        //     float mouseY = Input.GetAxis("Mouse Y");
        //     Camera.transform.Rotate(new Vector3(mouseY*rotationsensitivity,-mouseX*rotationsensitivity,0));
        // }
    }
}