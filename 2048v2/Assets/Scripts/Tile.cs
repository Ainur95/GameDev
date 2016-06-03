using UnityEngine;
using System.Collections;
using UnityEngine.UI;	

public class Tile : MonoBehaviour {

	public bool mergedThisTurn = false;
	public int indRow, indCol;

	public int Number{
		get{ 
			return number;
		}
		set{ 
			number = value;
			if (number == 0)
				SetEmpty ();
			else {
				ApplyStyle (number);
				SetVisible ();
			}
		}
	}

	private int number;
	private Image TileImage, TileColor;
	private Animator anim;

	void Awake(){
		TileColor = transform.Find ("ColoredCell").GetComponent<Image>();
		TileImage = transform.Find ("ColoredCell").transform.Find("TileImage").GetComponentInChildren<Image>();
		anim = GetComponent<Animator> ();
	}

	public void PlayMergedAnimation(){
		anim.SetTrigger ("Merge");
	}

	public void PlayAppearAnimation(){
		anim.SetTrigger ("Appear");
	}

	void ApplyStyleFromTileStyle(int index){
		TileImage.sprite = TileStyle.instance.TileStyles [index].TileSprite;
		TileColor.color = TileStyle.instance.TileStyles [index].TileColor;
	}

	void ApplyStyle(int num){
		switch (num) {
		case 2:
			ApplyStyleFromTileStyle (0);
			break;
		case 4:
			ApplyStyleFromTileStyle (1);
			break;
		case 8:
			ApplyStyleFromTileStyle (2);
			break;
		case 16:
			ApplyStyleFromTileStyle (3);
			break;
		case 32:
			ApplyStyleFromTileStyle (4);
			break;
		case 64:
			ApplyStyleFromTileStyle (5);
			break;
		case 128:
			ApplyStyleFromTileStyle (6);
			break;
		case 256:
			ApplyStyleFromTileStyle (7);
			break;
		case 512:
			ApplyStyleFromTileStyle (8);
			break;
		case 1024:
			ApplyStyleFromTileStyle (9);
			break;
		case 2048:
			ApplyStyleFromTileStyle (10);
			break;
		default:
			Debug.LogError ("Number is out of range");
			break;
		}
	}

	private void SetVisible(){
		TileColor.enabled = true;
		TileImage.enabled = true;
	}

	private void SetEmpty(){
		TileColor.enabled = false;
		TileImage.enabled = false;
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
