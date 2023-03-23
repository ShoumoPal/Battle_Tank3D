using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class TankView : MonoBehaviour
{
    private TankController tankController;
    private float movement;
    private float rotation;

    public MeshRenderer[] child;

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

    private void Start()
    {
        GameObject cam = GameObject.Find("Main Camera");
        cam.transform.SetParent(transform);
        cam.transform.position = new Vector3(0f, 3f, -4f);
    }
    private void Update()
    {
        Movement();
        Rotation();
        if(movement != 0)
        {
            tankController.Move(movement, tankController.GetTankModel().movementSpeed);
        }
        if(rotation != 0)
        {
            tankController.Rotate(rotation, tankController.GetTankModel().rotationSpeed);
        }
    }

    public void ChangeColor(Material color)
    {
        for(int i = 0; i< child.Length; i++)
        {
            child[i].material= color;
        }
    }
}
