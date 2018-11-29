using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Botherer : MonoBehaviour {

    [SerializeField] int ScreenWidthInUnits = 16;
    [SerializeField] float BothererYPos = 0.57f;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        float CurrentMousePosition = Input.mousePosition.x / Screen.width * ScreenWidthInUnits;
        gameObject.transform.position = new Vector2(CurrentMousePosition, BothererYPos);
	}
}
