using UnityEngine;
using System.Collections;

public class IwasiRigid : MonoBehaviour {
	public bool mizuwoeta;

	void Update() {
		Rigidbody rigid = GetComponent<Rigidbody> ();
		rigid.AddForce (Vector3.up * 5f + Vector3.forward * 2f, ForceMode.Impulse);
	}
}
