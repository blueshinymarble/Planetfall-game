using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{

    public bool turretSelected = false;
    public bool powerPlantSelected = false;
    public bool aAGunSelected = false;
    public bool terraformerSelected = false;
    public bool soldierSelected = false;
    public bool shipSelected;
    private Image myAaGunImage;
    private Image myTurretImage;
    private Image myPowerPlantImage;
    private Image myTerraformerImage;
    private Image mySoldierImage;
    private Image myShipImage;
    private Board myBoard;

	// Use this for initialization
	void Start ()
    {
        myBoard = GameObject.Find("Board").GetComponent<Board>();
        myTurretImage = GameObject.Find("Turret Button").GetComponent<Image>();
        myPowerPlantImage = GameObject.Find("Power Plant Button").GetComponent<Image>();
        myAaGunImage = GameObject.Find("AA Gun Button").GetComponent<Image>();
        myTerraformerImage = GameObject.Find("Terraformer Button").GetComponent<Image>();
        mySoldierImage = GameObject.Find("Soldier Button").GetComponent<Image>();
        myShipImage = GameObject.Find("Ship Button").GetComponent<Image>();
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
        if (!turretSelected)
        {
            GameObject.Find("Turret Button").tag = "Clicked Button";
            turretSelected = true;
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
            Button[] allButtons = FindObjectsOfType<Button>(); 
            myTurretImage.color = Color.white;
            turretSelected = false;
            foreach (Button button in allButtons)
            {
                button.interactable = true;
                button.tag = "Unclicked Button";
            }

        }
    }

    public void TestPowerPlant()
    {
        if (!powerPlantSelected)
        {
            GameObject.Find("Power Plant Button").tag = "Clicked Button";
            powerPlantSelected = true;
            myPowerPlantImage.color = Color.green;
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
            Button[] allButtons = GameObject.FindObjectsOfType<Button>();
            myPowerPlantImage.color = Color.white;
            powerPlantSelected = false;
            foreach (Button button in allButtons)
            {
                button.interactable = true;
                button.tag = "Unclicked Button";
            }
        }
    }

    public void TestAaGun()
    {
        if (!aAGunSelected)
        {
            GameObject.Find("AA Gun Button").tag = "Clicked Button";
            aAGunSelected = true;
            myAaGunImage.color = Color.green;
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
            Button[] allButtons = GameObject.FindObjectsOfType<Button>();
            myAaGunImage.color = Color.white;
            aAGunSelected = false;
            foreach (Button button in allButtons)
            {
                button.interactable = true;
                button.tag = "Unclicked Button";
            }
        }
    }

    public void TestTerraformer()
    {
        if (!terraformerSelected)
        {
            GameObject.Find("Terraformer Button").tag = "Clicked Button";
            terraformerSelected = true;
            myTerraformerImage.color = Color.green;
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
            Button[] allButtons = GameObject.FindObjectsOfType<Button>();
            myTerraformerImage.color = Color.white;
            terraformerSelected = false;
            foreach (Button button in allButtons)
            {
                button.interactable = true;
                button.tag = "Unclicked Button";
            }
        }
    }

    public void TestSoldier()
    {
        if (!turretSelected)
        {
            GameObject.Find("Soldier Button").tag = "Clicked Button";
            soldierSelected = true;
            mySoldierImage.color = Color.green;
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
            Button[] allButtons = FindObjectsOfType<Button>();
            mySoldierImage.color = Color.white;
            soldierSelected = false;
            foreach (Button button in allButtons)
            {
                button.interactable = true;
                button.tag = "Unclicked Button";
            }
        }
    }

    public void TestShip()
    {
        if (!turretSelected)
        {
            GameObject.Find("Ship Button").tag = "Clicked Button";
            shipSelected = true;
            myShipImage.color = Color.green;
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
            Button[] allButtons = FindObjectsOfType<Button>();
            myShipImage.color = Color.white;
            shipSelected = false;
            foreach (Button button in allButtons)
            {
                button.interactable = true;
                button.tag = "Unclicked Button";
            }
        }

    }
}
