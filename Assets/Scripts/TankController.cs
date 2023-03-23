using UnityEngine;

public class TankController
{
    private TankView tankView;

    private TankModel tankModel;

    public Rigidbody rb;

    public TankController(TankView _tankView, TankModel _tankModel)
    {
        tankModel= _tankModel;
        tankView = GameObject.Instantiate<TankView>(_tankView);

        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        rb = tankView.GetRigidbody();
        tankView.ChangeColor(tankModel.color);
    }

    public void Move(float movement, float movementSpeed)
    {
        rb.velocity = movement * movementSpeed * tankView.transform.forward;
    }
    public void Rotate(float rotation, float rotateSpeed)
    {
        Vector3 vector = new Vector3(0.0f, rotation * rotateSpeed, 0.0f);
        Quaternion deltaRotation = Quaternion.Euler(vector * Time.deltaTime);
        rb.MoveRotation(deltaRotation * rb.rotation);
    }
    public TankModel GetTankModel()
    {
        return tankModel;
    }
}
