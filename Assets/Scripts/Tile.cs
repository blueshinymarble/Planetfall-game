using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.EventSystems;

public class Tile : MonoBehaviour
{

    public GameObject turret;
    public GameObject powerPlant;
    public GameObject aAGun;
    public GameObject terraformer;
    public GameObject soldier;
    public GameObject ship;
    public GameObject[] terrainTiles;

    private ButtonBehavior buttonBehavior;
    public List<GameObject> collisions = new List<GameObject>();
    //private MeshRenderer[] myTileMeshes;
    //private Board board;


    // Use this for initialization
    void Start()
    {
        Board board = GameObject.Find("Board").GetComponent<Board>();
        buttonBehavior = GameObject.Find("Button Behavior").GetComponent<ButtonBehavior>();
        while (gameObject.transform.childCount < 1)
        {
            board.PopulateBoard((Board.TerrainTilesEnum)Random.Range(0, 6), transform);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    /*private void OnTriggerEnter(Collider other)
    {
        collisions.Add(other.gameObject);
    }*/

    public void OnMouseDown()
    {
        GameObject clickedUnit = GameObject.FindGameObjectWithTag("Unit Selected");
        if (!EventSystem.current.IsPointerOverGameObject() && gameObject.transform.GetChild(0).tag != "Hazard" && gameObject.transform.childCount < 2)
        {
            if (buttonBehavior.turretSelected)
            {
                GameObject spawnedTurret = Instantiate(turret, transform.position, Quaternion.identity);
                spawnedTurret.transform.parent = gameObject.transform;
                spawnedTurret.transform.rotation = gameObject.transform.rotation;
            }
            else if (buttonBehavior.powerPlantSelected)
            {
                GameObject spawnedPowerPlant = Instantiate(powerPlant, transform.position, Quaternion.identity);
                spawnedPowerPlant.transform.parent = gameObject.transform;
                spawnedPowerPlant.transform.rotation = gameObject.transform.rotation;
            }
            else if (buttonBehavior.aAGunSelected)
            {
                GameObject spawnedAAGun = Instantiate(aAGun, transform.position, Quaternion.identity);
                spawnedAAGun.transform.parent = gameObject.transform;
                spawnedAAGun.transform.rotation = gameObject.transform.rotation;
            }
            else if (buttonBehavior.terraformerSelected)
            {
                GameObject spawnedTerraformer = Instantiate(terraformer, transform.position, Quaternion.identity);
                spawnedTerraformer.transform.parent = gameObject.transform;
                spawnedTerraformer.transform.rotation = gameObject.transform.rotation;
            }
            else if (buttonBehavior.soldierSelected)
            {
                GameObject spawnedSoldier = Instantiate(soldier, transform.position, Quaternion.identity);
                spawnedSoldier.transform.parent = gameObject.transform;
                spawnedSoldier.transform.rotation = gameObject.transform.rotation;
            }
            else if (buttonBehavior.shipSelected)
            {
                GameObject spawnedShip = Instantiate(ship, transform.position, Quaternion.identity);
                spawnedShip.transform.parent = gameObject.transform;
            }
            else if (clickedUnit)            
            {
                float distanceBetweenTileAndUnit = Vector3.Distance(gameObject.transform.position, clickedUnit.transform.position);
                if (distanceBetweenTileAndUnit < 6)
                {
                    clickedUnit.transform.position = gameObject.transform.position;
                    clickedUnit.transform.parent = gameObject.transform;
                    clickedUnit.tag = "Untagged";
                }
            }
        }

    }
}