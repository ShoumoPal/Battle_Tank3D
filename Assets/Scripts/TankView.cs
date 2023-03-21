using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement;
    private float rotation;

    public void SetTankController(TankController _tankController)
    {
        tankController = _tankController;
    }

    public Rigidbody GetRigidbody()
    {
        return GetComponent<Rigidbody>();
    }
    private void Movement()
    {
        movement = Input.GetAxis("Vertical");
    }
    private void Rotation()
    {
        rotation = Input.GetAxis("Horizontal");
    }
    private void Update()
    {
        Movement();
        Rotation();
        if(movement != 0)
        {
            tankController.Move(movement, 30);
        }
        if(rotation != 0)
        {
            tankController.Rotate(rotation, 50);
        }
    }
}
