using UnityEngine;
using System.Collections;

[System.Serializable]
public class TileStyleManager{
	public int Number;
	public Color TileColor;
	public Sprite TileSprite;
}

public class TileStyle : MonoBehaviour {

	public static TileStyle instance;

	public TileStyleManager[] TileStyles;

	void Awake(){
		instance = this;
	}
}
