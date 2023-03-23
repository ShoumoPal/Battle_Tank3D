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
        CreateTank();
    }

    private void CreateTank()
    {
        TankModel tankModel = new TankModel(tanks[0].movementSpeed, tanks[0].rotationSpeed, tanks[0].tankType, tanks[0].color);
        TankController tankController = new TankController(tankView, tankModel);
    }
}
