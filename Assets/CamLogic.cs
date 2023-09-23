using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamLogic : MonoBehaviour
{
    private Vector2 angle = new Vector2(90 * Mathf.Rad2Deg, 0);

    public Transform follow;
    public float distanceCamera;

    // variables para girar con el raton

    public float sensitivity = 2f;  // Sensibilidad del giro del ratón
    public Transform playerBody;    // Referencia al cuerpo del jugador para girar
    public Transform playerCamera;  // Referencia a la cámara del jugador para girar verticalmente

    float xRotation = 0f;


    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;  // Bloquea el cursor en el centro de la pantalla
    }

    void Update()
    {
        float mouseX = Input.GetAxis("Mouse X") * sensitivity;
        float mouseY = Input.GetAxis("Mouse Y") * sensitivity;

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, -90f, 90f);  // Limita la rotación vertical

        // Gira la cámara verticalmente
        playerCamera.localRotation = Quaternion.Euler(0f, xRotation, 0f);

        // Gira el jugador en el eje vertical
        playerBody.Rotate(Vector3.up * mouseX);


    }


    void LateUpdate()
    {}

}

