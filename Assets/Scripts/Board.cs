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
    public GameObject bloom;
    public GameObject forest01;
    public GameObject forest02;
    public GameObject forest03;
    public GameObject mountain01;
    public GameObject mountain02;
    public GameObject hazard;
    public bool isTwoPlayersOnly;
    public enum BloomCards {card01, card02, card03, card04, card05, card06, card07, card08, card09, card10, card11, card12, card13, card14, card15, card16, card17, card18, card19, card20 };
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

    Transform SpaceToSpawnBloom(string spaceName)
    {
        Transform transform = GameObject.Find(spaceName).GetComponent<Transform>();
        return transform;
    }

    void SpawnBloomAtSpace(string spaceName)
    {
        GameObject instantiatedBloom = Instantiate((bloom), SpaceToSpawnBloom(spaceName));
        instantiatedBloom.transform.parent = SpaceToSpawnBloom(spaceName);
    }

    public void ChooseBloomSpace(BloomCards selectedCard)
    {
        GameObject[] bloomPointsToDestroy = GameObject.FindGameObjectsWithTag("Bloom"); 

        foreach (GameObject toDestroy in bloomPointsToDestroy)
        {
            Destroy(toDestroy);
        }

        switch (selectedCard)
        {
            case BloomCards.card01:
                SpawnBloomAtSpace("Space06");
                print("Card 01 was chosen");
                break;

            case BloomCards.card02:
                SpawnBloomAtSpace("Space17");
                print("Card 02 was chosen");
                break;

            case BloomCards.card03:
                SpawnBloomAtSpace("Space27");
                print("Card 03 was chosen");
                break;

            case BloomCards.card04:
                SpawnBloomAtSpace("Space08");
                print("Card 04 was chosen");
                break;

            case BloomCards.card05:
                SpawnBloomAtSpace("Space12");
                print("Card 05 was chosen");
                break;

            case BloomCards.card06:
                SpawnBloomAtSpace("Space18");
                print("Card 06 was chosen");
                break;

            case BloomCards.card07:
                SpawnBloomAtSpace("Space26");
                print("Card 07 was chosen");
                break;

            case BloomCards.card08:
                SpawnBloomAtSpace("Space13");
                print("Card 08 was chosen");
                break;

            case BloomCards.card09:
                SpawnBloomAtSpace("Space26");
                print("Card 09 was chosen");
                break;

            case BloomCards.card10:
                SpawnBloomAtSpace("Space15");
                SpawnBloomAtSpace("Space30");
                print("Card 10 was chosen");
                break;

            case BloomCards.card11:
                SpawnBloomAtSpace("Space13");
                SpawnBloomAtSpace("Space31");
                print("Card 11 was chosen");
                break;

            case BloomCards.card12:
                SpawnBloomAtSpace("Space07");
                SpawnBloomAtSpace("Space24");
                print("Card 12 was chosen");
                break;

            case BloomCards.card13:
                SpawnBloomAtSpace("Space19");
                SpawnBloomAtSpace("Space32");
                print("Card 13 was chosen");
                break;

            case BloomCards.card14:
                SpawnBloomAtSpace("Space06");
                SpawnBloomAtSpace("Space27");
                print("Card 14 was chosen");
                break;

            case BloomCards.card15:
                SpawnBloomAtSpace("Space06");
                SpawnBloomAtSpace("Space21");
                SpawnBloomAtSpace("Space32");
                print("Card 15 was chosen");
                break;

            case BloomCards.card16:
                SpawnBloomAtSpace("Space12");
                SpawnBloomAtSpace("Space14");
                SpawnBloomAtSpace("Space26");
                print("Card 16 was chosen");
                break;

            case BloomCards.card17:
                SpawnBloomAtSpace("Space11");
                SpawnBloomAtSpace("Space19");
                SpawnBloomAtSpace("Space31");
                print("Card 17 was chosen");
                break;

            case BloomCards.card18:
                SpawnBloomAtSpace("Space13");
                SpawnBloomAtSpace("Space24");
                SpawnBloomAtSpace("Space25");
                print("Card 18 was chosen");
                break;

            case BloomCards.card19:
                SpawnBloomAtSpace("Space08");
                SpawnBloomAtSpace("Space18");
                SpawnBloomAtSpace("Space30");
                print("Card 19 was chosen");
                break;

            case BloomCards.card20:
                SpawnBloomAtSpace("Space07");
                SpawnBloomAtSpace("Space17");
                SpawnBloomAtSpace("Space20");
                print("Card 20 was chosen");
                break;

        }
    }

    Transform FreePosition()
    {
        foreach (Transform freePosition in transform)
        {
            if (freePosition.childCount == 0)
            {
                return freePosition;
            }
        }
        return null;
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
