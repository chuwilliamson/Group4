using UnityEngine;
using System.Collections;

public class ShinyMat : MonoBehaviour {

    public Renderer rend;
	// Update is called once per frame
	void Update () {
        rend.material.SetFloat("_Shininess", Mathf.Sin(Time.deltaTime));
	}
}
