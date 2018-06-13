using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{

    public bool turretIsSelected = false;
    public bool powerPlantSelected = false;
    public bool aAGunSelected = false;
    private Image myAaGunImage;
    private Image myTurretImage;
    private Image myPowerPlantImage;
    private Board myBoard;
    private Panel panel;

	// Use this for initialization
	void Start ()
    {
        myBoard = GameObject.Find("Board").GetComponent<Board>();
        myTurretImage = GameObject.Find("Turret Button").GetComponent<Image>();
        myPowerPlantImage = GameObject.Find("Power Plant Button").GetComponent<Image>();
        myAaGunImage = GameObject.Find("AA Gun Button").GetComponent<Image>();
        panel = GameObject.Find("Panel").GetComponent<Panel>();
	}
	
	// Update is called once per frame
	void Update ()
    {
        
    }

    public void TestSwitch()
    {
        myBoard.ChooseBloomSpace((Board.BloomCards)Random.Range(0,20));
    }

    public void TestTurretButton()
    {
        if (!turretIsSelected)
        {
            GameObject.Find("Turret Button").tag = "Clicked Button";
            turretIsSelected = true;
            myTurretImage.color = Color.green;
            Button[] unclickedButtons = FindObjectsOfType<Button>();
            foreach (Button button in unclickedButtons)
            {
                if (button.tag == "Unclicked Button")
                {
                    button.interactable = false;
                }
            }
        }
        else
        {
            myTurretImage.color = Color.white;
            turretIsSelected = false;
        }
    }

    public void TestPowerPlant()
    {
        if (!powerPlantSelected)
        {
            powerPlantSelected = true;
            myPowerPlantImage.color = Color.green;
        }
        else
        {
            myPowerPlantImage.color = Color.white;
            powerPlantSelected = false;
        }
    }

    public void TestAaGun()
    {
        if (!aAGunSelected)
        {
            aAGunSelected = true;
            myAaGunImage.color = Color.green;
        }
        else
        {
            myAaGunImage.color = Color.white;
            aAGunSelected = false;
        }
    }
}
