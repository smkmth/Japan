using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene2Transition : MonoBehaviour {




	
	// Update is called once per frame

	void OnTriggerEnter(Collider other)
	{
		SceneManager.LoadScene ("Scene2");	
	}

}
