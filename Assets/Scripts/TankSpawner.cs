using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSpawner : MonoBehaviour
{
    public TankView tankView;

    [System.Serializable]

    public class Tank
    {
        public float movementSpeed;
        public float rotationSpeed;
        public TankTypes tankType;
        public Material color;
    }
    public List<Tank> tanks;

    // Start is called before the first frame update
    void Start()
    {
    }

    public void CreateTank(TankTypes tankType)
    {
        if(tankType == TankTypes.RedTank)
        {
            TankModel tankModel = new TankModel(tanks[0].movementSpeed, tanks[0].rotationSpeed, tanks[0].tankType, tanks[0].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
        if (tankType == TankTypes.BlueTank)
        {
            TankModel tankModel = new TankModel(tanks[1].movementSpeed, tanks[1].rotationSpeed, tanks[1].tankType, tanks[1].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
        if (tankType == TankTypes.GreenTank)
        {
            TankModel tankModel = new TankModel(tanks[1].movementSpeed, tanks[2].rotationSpeed, tanks[2].tankType, tanks[2].color);
            TankController tankController = new TankController(tankView, tankModel);
        }
    }
}
