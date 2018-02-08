using UnityEngine;
using System.Collections;

public class Player : MonoBehaviour
{
//    public float speed = 10f;

    //private float lastSynchronizationTime = 0f;
    //private float syncDelay = 0f;
    //private float syncTime = 0f;
    //private Vector3 syncStartPosition = Vector3.zero;
    //private Vector3 syncEndPosition = Vector3.zero;

    void OnSerializeNetworkView(BitStream stream, NetworkMessageInfo info)
    {
		var syncPosition = Vector3.zero;
        if (stream.isWriting)
        {
            //syncPosition = transform.position;
            //stream.Serialize(ref syncPosition);

        }
        else
        {
            stream.Serialize(ref syncPosition);
			transform.position = syncPosition;

            /*syncTime = 0f;
            syncDelay = Time.time - lastSynchronizationTime;
            lastSynchronizationTime = Time.time;

            syncEndPosition = syncPosition;
			syncStartPosition = transform.position;*/
        }
    }

    /*void Awake()
    {
        lastSynchronizationTime = Time.time;
    }*/

    /*void Update()
    {
        if (!networkView.isMine)
        {
            SyncedMovement();
        }
    }
	
    private void SyncedMovement()
    {
        syncTime += Time.deltaTime;

		transform.position = Vector3.Lerp(syncStartPosition, syncEndPosition, syncTime / syncDelay);
    }*/

	[RPC] void ChangeColorTo(Vector3 color)
	{
		renderer.material.color = new Color(color.x, color.y, color.z, 1f);
	}
}
