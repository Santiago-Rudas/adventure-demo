using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMoveLogic : MonoBehaviour
{
    public float speedMovement;
    public float rotateSpeed;
    public Animator anim; // Cambia el tipo de "Animation" a "Animator"
    public float x, y, mouseX, mouseY;

    public Transform playerBody;    // Referencia al cuerpo del jugador para girar
    public Transform playerCamera;  // Referencia a la cámara del jugador para girar verticalmente


    public float maxVerticalAngle = 20f;  // Ángulo máximo hacia arriba
    public float minVerticalAngle = -20f;

    float xRotation = 0f;

    // VARIABLES PARA SALTO

    public Rigidbody rb;
    public float jumpForce;
    public bool canJump;


    // Start is called before the first frame update
    void Start()
    {
        anim = GetComponent<Animator>();
    }

    private void FixedUpdate()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x = Input.GetAxis("Horizontal"); 
        y = Input.GetAxis("Vertical");
        mouseX = Input.GetAxis("Mouse X");
        mouseY = Input.GetAxis("Mouse Y");

        transform.Translate(x * Time.deltaTime * speedMovement, 0, 0);
        transform.Translate(0, 0, y * Time.deltaTime * speedMovement);
        transform.Rotate(0, mouseX * Time.deltaTime * speedMovement, 0);

        xRotation -= mouseY;
        xRotation = Mathf.Clamp(xRotation, minVerticalAngle, maxVerticalAngle);  // Limita la rotación vertical

        // Gira la cámara verticalmente dentro del rango establecido
        playerCamera.localRotation = Quaternion.Euler(xRotation, 0f, 0f);

        // Gira el jugador en el eje horizontal
        playerBody.Rotate(Vector3.up * mouseX);


        anim.SetFloat("SpeedX", x);
        anim.SetFloat("SpeedY", y);

       
    }

    
}
