using UnityEngine;
using System.Collections;

public class NetworkManager : MonoBehaviour
{
    private const string typeName = "UniqueGameName_robin";
    private const string gameName = "RoomName_robin";

    private bool isRefreshingHostList = false;
    private HostData[] hostList;

    public GameObject KinectPointMan;

    void OnGUI()
    {
        if (!Network.isClient && !Network.isServer)
        {
            if (GUI.Button(new Rect(30, 30, 150, 30), "Start Server"))
                StartServer();

            if (GUI.Button(new Rect(30, 75, 150, 30), "Refresh Hosts"))
                RefreshHostList();

            if (hostList != null)
            {
                for (int i = 0; i < hostList.Length; i++)
                {
                    if (GUI.Button(new Rect(195, 30 + (35 * i), 150, 30), hostList[i].gameName))
                        JoinServer(hostList[i]);
                }
            }
        }
    }

    private void StartServer()
    {
		Network.InitializeServer(3, 25001, !Network.HavePublicAddress());
        MasterServer.RegisterHost(typeName, gameName);
    }


    void Update()
    {
        if (isRefreshingHostList && MasterServer.PollHostList().Length > 0)
        {
            isRefreshingHostList = false;
            hostList = MasterServer.PollHostList();
        }
    }

    private void RefreshHostList()
    {
        if (!isRefreshingHostList)
        {
            isRefreshingHostList = true;
            MasterServer.RequestHostList(typeName);
        }
    }


    private void JoinServer(HostData hostData)
    {
        Network.Connect(hostData);
    }

	void OnServerInitialized()
	{
		//SpawnPlayer();
	}
	
	void OnConnectedToServer()
	{
		//SpawnPlayer();
	}
	
	
	private void SpawnPlayer()
	{
		Network.Instantiate(KinectPointMan, Vector3.zero, Quaternion.identity, 0);
	}
	
}
