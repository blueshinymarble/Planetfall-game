using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using System.Linq;

public class Board : MonoBehaviour
{
    private Animator myAnim;
    public static int myForestOneInt = 6;
    public static int myForestTwoInt = 10;
    public static int myForestThreeInt = 4;
    public static int myMountainOneInt = 12;
    public static int myMountainTwoInt = 8;
    public static int myHazardInt = 5;
    public GameObject forest01;
    public GameObject forest02;
    public GameObject forest03;
    public GameObject mountain01;
    public GameObject mountain02;
    public GameObject hazard;
    public bool isTwoPlayersOnly;
    public enum TerrainTilesEnum {forest1, forest2, forest3, mountain1, mountain2, hazard };
	
    // Use this for initialization
	void Start ()
    {
        myAnim = GetComponent<Animator>();
        myAnim.Play("Board Spawning Tiles");
    }
	
	// Update is called once per frame
	void Update ()
    {
           
	}

    public void PopulateBoard(TerrainTilesEnum tile, Transform child)
    {
            switch (tile)
            {
                case TerrainTilesEnum.forest1:
                    if (myForestOneInt > 0)
                    {
                        GameObject newForest01 = Instantiate(forest01, child.transform.position, Quaternion.identity);
                        newForest01.transform.parent = child;
                        myForestOneInt--;
                    }
                    break;

                case TerrainTilesEnum.forest2:
                    if (myForestTwoInt > 0)
                    {
                        GameObject newForest02 = Instantiate(forest02, child.transform.position, Quaternion.identity);
                        newForest02.transform.parent = child;
                        myForestTwoInt--;
                    }
                    break;

                case TerrainTilesEnum.forest3:
                if (myForestThreeInt > 0)
                {
                    GameObject newForest03 = Instantiate(forest03, child.transform.position, Quaternion.identity);
                    newForest03.transform.parent = child;
                    myForestThreeInt--;
                }
                    break;

                case TerrainTilesEnum.mountain1:
                if (myMountainOneInt > 0)
                {
                    GameObject newMountain01 = Instantiate(mountain01, child.transform.position, Quaternion.identity);
                    newMountain01.transform.parent = child;
                    myMountainOneInt--;
                }
                    break;

                case TerrainTilesEnum.mountain2:
                if (myMountainTwoInt > 0)
                {
                    GameObject newMountain02 = Instantiate(mountain02, child.transform.position, Quaternion.identity);
                    newMountain02.transform.parent = child;
                    myMountainTwoInt--;
                }
                    break;

                case TerrainTilesEnum.hazard:
                if (myHazardInt > 0)
                {
                    GameObject newHazard = Instantiate(hazard, child.transform.position, Quaternion.identity);
                    newHazard.transform.parent = child;
                    myHazardInt--;
                }
                    break;
            } 
    }
}
