﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;

public class Tile : MonoBehaviour
{

    public GameObject turret;
    public GameObject powerPlant;
    public GameObject aAGun;
    public GameObject[] terrainTiles;

    private ButtonBehavior buttonBehavior;
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

    public void OnMouseDown()
    {
        if (buttonBehavior.turretIsSelected && gameObject.transform.GetChild(0).tag != "Hazard" && gameObject.transform.childCount < 2)
        {
            GameObject spawnedTurret = Instantiate(turret, transform.position, Quaternion.identity);
            spawnedTurret.transform.parent = gameObject.transform;
            spawnedTurret.transform.rotation = gameObject.transform.rotation;
        }
        else if (buttonBehavior.powerPlantSelected && gameObject.transform.GetChild(0).tag != "Hazard" && gameObject.transform.childCount < 2)
        {
            GameObject spawnedPowerPlant = Instantiate(powerPlant, transform.position, Quaternion.identity);
            spawnedPowerPlant.transform.parent = gameObject.transform;
            spawnedPowerPlant.transform.rotation = gameObject.transform.rotation;
        }

        else if (buttonBehavior.aAGunSelected && gameObject.transform.GetChild(0).tag != "Hazard" && gameObject.transform.childCount < 2)
        {
            GameObject spawnedAAGun = Instantiate(aAGun, transform.position, Quaternion.identity);
            spawnedAAGun.transform.parent = gameObject.transform;
            spawnedAAGun.transform.rotation = gameObject.transform.rotation;
        }
    }

    
}