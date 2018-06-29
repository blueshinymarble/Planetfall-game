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
    private BloomController bloomController;
    private GameManager gameManager;
    private Animator announcer;
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
        bloomController = GameObject.Find("Bloom Controller").GetComponent<BloomController>();
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        announcer = GameObject.Find("Announcer").GetComponent<Animator>();

    }

    // Update is called once per frame
    void Update ()
    {
        
    }

    public void TestBloomPlacement()
    {
        bloomController.ChooseRandomSpaceSpawnBloom();
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
                if (button.tag == "Clicked Button" || button.tag == "Unclicked Button")
                {
                    button.interactable = true;
                    button.tag = "Unclicked Button";
                }
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
                if (button.tag == "Clicked Button" || button.tag == "Unclicked Button")
                {
                    button.interactable = true;
                    button.tag = "Unclicked Button";
                }
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
                if (button.tag == "Clicked Button" || button.tag == "Unclicked Button")
                {
                    button.interactable = true;
                    button.tag = "Unclicked Button";
                }
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
        if (!soldierSelected)
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
        if (!shipSelected)
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

    public void RotateObject()
    {
        GameObject objectToRotate = GameObject.FindGameObjectWithTag("Just Placed");
        objectToRotate.transform.Rotate(0, 60, 0);
    }

    public void Confirm()
    {
        Animator panelAnim = GameObject.Find("Object Rotate Confirm Panel").GetComponent<Animator>();
        panelAnim.Play("move panel out");//move confirmation buttons out of the way
        GameManager.readyToContinue = true;//let the next button change phase
        if (gameManager.currentState == GameManager.States.firstRound)
        {
            announcer.Play("announcer fade out");
        }
    }

    public void Cancel()
    {
        Animator panelAnim = GameObject.Find("Object Rotate Confirm Panel").GetComponent<Animator>();
        panelAnim.Play("move panel out");//move buttons out of the way
        GameObject[] destroyPowerPlants = GameObject.FindGameObjectsWithTag("Just Placed");    //let the action that was cancelled repeat
        foreach (GameObject toDestroy in destroyPowerPlants)
        {
            Tile.showCrosshair = true;
            toDestroy.transform.parent.GetComponentInChildren<Animator>().Play("Fade in");
            Destroy(toDestroy);
        }
    }

    public void ConfirmSelection()
    {
        GameObject spawnedObject = GameObject.FindGameObjectWithTag("Just Placed");
        spawnedObject.tag = "Untagged";
        Animator panelAnim = GameObject.Find("Object Rotate Confirm Panel").GetComponent<Animator>();
        panelAnim.Play("move panel out");
        Button[] allButtons = FindObjectsOfType<Button>();
        myTurretImage.color = Color.white;
        turretSelected = false;
        powerPlantSelected = false;
        aAGunSelected = false;
        terraformerSelected = false;
        soldierSelected = false;
        shipSelected = false;
        foreach (Button button in allButtons)
        {
            if (button.tag == "Clicked Button" || button.tag == "Unclicked Button")
            {
                button.interactable = true;
                button.tag = "Unclicked Button";
                button.image.color = Color.white;
            }
        }
    }

    public void NextPhase()
    {
        switch (gameManager.currentState)
        {
            case GameManager.States.firstRound:
                if (GameManager.readyToContinue == true)
                {
                    Debug.Log("first round switching to bloom placement");
                    gameManager.currentState = GameManager.States.bloom;
                    gameManager.SetBlooms();
                    GameManager.readyToContinue = false;
                }
                break;

            case GameManager.States.roundBegins:
                Debug.Log("round begins switching to first round");
                gameManager.currentState = GameManager.States.firstRound;
                gameManager.FirstTurn();
                GameManager.readyToContinue = false;
                break;

            case GameManager.States.bloom:
                announcer.Play("announcer fade out");
                gameManager.currentState = GameManager.States.actions;
                Debug.Log("place bloom");
                break;

            case GameManager.States.collection:
                Debug.Log("collection");
                break;

            case GameManager.States.actions:
                Debug.Log("actions");
                break;
        }
    }
}
