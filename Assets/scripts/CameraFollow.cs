using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{

    public Transform target;
    public Vector3 offset;
    public float camSpeed = 2f;
    public float rotationSpeed = 2f;

    void Update()
    {
        if (target == null)
        {
            target = GameMaster.instance.playerManager.GetPlayerTransform();
        }
        transform.position = Vector3.Lerp(transform.position, new Vector3(0f, target.position.y, target.position.z) + offset, Time.deltaTime * camSpeed);
        //transform.LookAt(target);

        // TODO: set camera rotation / "transform.LookAt(target);" is jerky 
    }
}
