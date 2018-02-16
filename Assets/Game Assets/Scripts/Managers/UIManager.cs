using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour {

	public MusicManager MM;

	private Slider _musicSlider;

	public static GameObject menucanvas;

	public static bool MenuIsOn;

	void Awake(){

		menucanvas = transform.Find("MenuCanvas").gameObject;
		

	}
	//	void Start(){
//		_musicSlider = GameObject.Find ("Music_Slider").GetComponent<Slider> ();
//
//	}
	void Start(){
		menucanvas.gameObject.SetActive (false);

	}




	public static void TogglePauseMenu(){

	
		if (menucanvas.gameObject.activeSelf) {

			Time.timeScale = 1.0f;
			menucanvas.gameObject.SetActive (false);
			MenuIsOn = false;
		} else {
			Time.timeScale = 0.0f;
			menucanvas.gameObject.SetActive (true);
			MenuIsOn = true;
		}
		Debug.Log ("Gamemanager ::timescale" + Time.timeScale);
	}
		

//	public void OptionSliderUpdate(float val) {}
//	void SetCustomSettings(bool val){}
//	void WriteSettingsToInputText(GameSettings settings){}

	public void MusicSliderUpdate(float val){
		MM.SetVolume (val);
			}

			
			

}

