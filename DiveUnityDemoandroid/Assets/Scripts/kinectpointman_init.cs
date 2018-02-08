using UnityEngine;
using System.Collections;

public class kinectpointman_init : MonoBehaviour {

	// Use this for initialization
	public NetworkSkeletonWrapper kin;
	public GameObject _kinectPrefab;
	
	void Start()
	{
		_kinectPrefab = GameObject.FindGameObjectWithTag("network_c");

		kin = _kinectPrefab.GetComponent<NetworkSkeletonWrapper>();

		kin.Hip_Center = this.transform.FindChild ("00_Hip_Center").gameObject;
		kin.Shoulder_Center = this.transform.FindChild ("02_Shoulder_Center").gameObject;
		kin.Spine = this.transform.FindChild ("01_Spine").gameObject;
		kin.Head = this.transform.FindChild ("03_Head").gameObject;
		kin.Shoulder_Left = this.transform.FindChild ("10_Shoulder_Left").gameObject;
		kin.Elbow_Left = this.transform.FindChild ("11_Elbow_Left").gameObject;
		kin.Elbow_Right = this.transform.FindChild ("21_Elbow_Right").gameObject;
		kin.Wrist_Left = this.transform.FindChild ("12_Wrist_Left").gameObject;
		kin.Wrist_Right = this.transform.FindChild ("22_Wrist_Right").gameObject;
		kin.Hand_Left = this.transform.FindChild ("13_Hand_Left").gameObject;
		kin.Hand_Right = this.transform.FindChild ("23_Hand_Right").gameObject;
		kin.Shoulder_Right = this.transform.FindChild ("20_Shoulder_Right").gameObject;
		kin.Hip_Left = this.transform.FindChild ("30_Hip_Left").gameObject;
		kin.Hip_Right = this.transform.FindChild ("40_Hip_Right").gameObject;
		kin.Knee_Left = this.transform.FindChild ("31_Knee_Left").gameObject;
		kin.Knee_Right = this.transform.FindChild ("41_Knee_Right").gameObject;
		kin.Ankle_Left = this.transform.FindChild ("32_Ankle_Left").gameObject;
		kin.Ankle_Right = this.transform.FindChild ("42_Ankle_Right").gameObject;
		kin.Foot_Left = this.transform.FindChild ("33_Foot_Left").gameObject;
		kin.Foot_Right = this.transform.FindChild ("43_Foot_Right").gameObject;

		//this.gameObject.transform.position = new Vector3 (-2.022f, 1.428f, 0.023f);
		kin.enabled = true;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
