using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonBehavior : MonoBehaviour
{

    public bool turretIsSelected = false;
    public bool powerPlantSelected = false;
    public bool aAGunSelected = false;
    public bool terraformerSelected = false;
    private Image myAaGunImage;
    private Image myTurretImage;
    private Image myPowerPlantImage;
    private Image myTerraformerImage;
    private Board myBoard;
    private Panel panel;

	// Use this for initialization
	void Start ()
    {
        myBoard = GameObject.Find("Board").GetComponent<Board>();
        myTurretImage = GameObject.Find("Turret Button").GetComponent<Image>();
        myPowerPlantImage = GameObject.Find("Power Plant Button").GetComponent<Image>();
        myAaGunImage = GameObject.Find("AA Gun Button").GetComponent<Image>();
        myTerraformerImage = GameObject.Find("Terraformer Button").GetComponent<Image>();
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
            Button[] allButtons = FindObjectsOfType<Button>(); 
            myTurretImage.color = Color.white;
            turretIsSelected = false;
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
}
