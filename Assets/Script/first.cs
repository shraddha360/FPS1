using UnityEngine;
using System.Collections;

public class first : MonoBehaviour 
{
	public void GoToLevel(string Level1)
	{
		Application.LoadLevel (Level1);
	}   
}