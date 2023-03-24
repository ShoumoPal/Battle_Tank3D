using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankSelection : MonoBehaviour
{
    public TankSpawner tankSpawner;
    public void RedTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.RedTank);
        Debug.Log("Red Tank Selected");
        this.gameObject.SetActive(false);
    }
    public void GreenTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.GreenTank);
        Debug.Log("Green Tank Selected");
        this.gameObject.SetActive(false);
    }
    public void BlueTankSelected()
    {
        tankSpawner.CreateTank(TankTypes.BlueTank);
        Debug.Log("Blue Tank Selected");
        this.gameObject.SetActive(false);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
