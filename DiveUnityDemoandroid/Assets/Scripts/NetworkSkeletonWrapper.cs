using UnityEngine;
using System.Collections;

public class NetworkSkeletonWrapper : MonoBehaviour {

	public Vector3[,] bonePos;
	public GameObject Hip_Center;
	public GameObject Spine;
	public GameObject Shoulder_Center;
	public GameObject Head;
	public GameObject Shoulder_Left;
	public GameObject Elbow_Left;
	public GameObject Wrist_Left;
	public GameObject Hand_Left;
	public GameObject Shoulder_Right;
	public GameObject Elbow_Right;
	public GameObject Wrist_Right;
	public GameObject Hand_Right;
	public GameObject Hip_Left;
	public GameObject Knee_Left;
	public GameObject Ankle_Left;
	public GameObject Foot_Left;
	public GameObject Hip_Right;
	public GameObject Knee_Right;
	public GameObject Ankle_Right;
	public GameObject Foot_Right;

	public GameObject skelet_pos;
	void Start()
	{
		bonePos = new Vector3[1, 20];
	}

	// Use this for initialization
	public bool pollSkeleton () {
		if (Foot_Right == null) {
			return false;
		}
		bonePos [0, 0] = Hip_Center.transform.position;
		bonePos [0, 1] = Spine.transform.position;
		bonePos [0, 2] = Shoulder_Center.transform.position;
		bonePos [0, 3] = Head.transform.position;
		bonePos [0, 4] = Shoulder_Left.transform.position;
		bonePos [0, 5] = Elbow_Left.transform.position;
		bonePos [0, 6] = Wrist_Left.transform.position;
		bonePos [0, 7] = Hand_Left.transform.position;
		bonePos [0, 8] = Shoulder_Right.transform.position;
		bonePos [0, 9] = Elbow_Right.transform.position;
		bonePos [0, 10] = Wrist_Right.transform.position;
		bonePos [0, 11] = Hand_Right.transform.position;
		bonePos [0, 12] = Hip_Left.transform.position;
		bonePos [0, 13] = Knee_Left.transform.position;
		bonePos [0, 14] = Ankle_Left.transform.position;
		bonePos [0, 15] = Foot_Left.transform.position;
		bonePos [0, 16] = Hip_Right.transform.position;
		bonePos [0, 17] = Knee_Right.transform.position;
		bonePos [0, 18] = Ankle_Right.transform.position;
		bonePos [0, 19] = Foot_Right.transform.position;

		skelet_pos.transform.position = Hip_Center.transform.position;

		return true;
	}
}
