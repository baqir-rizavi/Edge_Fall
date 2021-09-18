using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlatformCreator : MonoBehaviour
{
    public Transform player;
    public Transform[] platformTypes;
    public Transform currentPlatformNextPoint;
    public float initialDistance;


    private void Start()
    {
        initialDistance = Vector3.Distance(player.position, currentPlatformNextPoint.position);
    }

    private void Update()
    {
        if (player == null)
        {
            player = GameMaster.instance.playerManager.GetPlayerTransform();
        }

        if (platformIsRequired())
            createPlatform();
    }

    bool platformIsRequired()
    {
        if (Vector3.Distance(player.position, currentPlatformNextPoint.position) < initialDistance)
            return true;
        else
            return false;
    }

    void resetOnplayerDead()
    {
        throw new System.NotImplementedException();
        //TODO: implement function 
    }

    void removePreviousPlatform()
    {
        throw new System.NotImplementedException();
        //TODO: implement function 
    }

    void createPlatform()
    {
        Transform newPlaform =  Instantiate(platformTypes[Random.Range(0, platformTypes.Length)], currentPlatformNextPoint.position, Quaternion.identity);
        currentPlatformNextPoint = newPlaform.GetChild(6);
    }
}
