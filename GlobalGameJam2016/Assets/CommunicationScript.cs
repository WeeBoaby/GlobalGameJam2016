﻿using UnityEngine;
using System.Collections;

public class CommunicationScript : MonoBehaviour 
{

	public bool messageShowing = false;
	public Vector2 objectPos;
	public GUISkin mySkin;
	public bool alignLeft;
	public Texture villagetex, strengthtex, effecttex;

	// Use this for initialization
	void Start () 
	{
		objectPos = Camera.main.WorldToScreenPoint (this.gameObject.transform.position);
	}
	
	// Update is called once per frame
	void Update () 
	{

	}

	void OnMouseOver()
	{
		Debug.Log ("mouse over villager");
		//mouse hovering, display message
		messageShowing = true;
	}

	void OnMouseExit()
	{
		//mouse left, dinnae show message anymore
		messageShowing = false;
	}

	void OnGUI()
	{
		GUI.skin = mySkin;
		if (messageShowing) 
		{

			if (alignLeft)
			{
				GUI.Box (new Rect (objectPos.x - 75, (Screen.height - objectPos.y - 175), 250, 100), "some text");
				GUI.DrawTexture (new Rect(objectPos.x - 50, (Screen.height - objectPos.y - 155), 50, 50), villagetex);
				GUI.DrawTexture (new Rect(objectPos.x + 10, (Screen.height - objectPos.y - 155), 50, 50), effecttex);
				GUI.DrawTexture (new Rect(objectPos.x + 70, (Screen.height - objectPos.y - 155), 50, 50), strengthtex);
			} 
			else
			{
				GUI.Box (new Rect (objectPos.x - 175, (Screen.height - objectPos.y - 175), 250, 100), "some text");
				GUI.DrawTexture (new Rect(objectPos.x - 155, (Screen.height - objectPos.y - 155), 50, 50), villagetex);
				GUI.DrawTexture (new Rect(objectPos.x - 95, (Screen.height - objectPos.y - 155), 50, 50), effecttex);
				GUI.DrawTexture (new Rect(objectPos.x - 35, (Screen.height - objectPos.y - 155), 50, 50), strengthtex);
			}
		}
	}
}