using UnityEngine;

public class TankController
{
    private TankView tankView;

    private TankModel tankModel;
    
    public TankController(TankView _tankView, TankModel _tankModel)
    {
        tankModel= _tankModel;
        tankView = _tankView;
        tankModel.SetTankController(this);
        tankView.SetTankController(this);

        GameObject.Instantiate(tankView.gameObject);
    }
}
