using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ScoreTracker : MonoBehaviour {

	private int score;
	public static ScoreTracker Instance;
	public Text ScoreText, RecordText;

	public int Score{
		get{ 
			return score;
		}
		set{ 
			score = value;
			ScoreText.text = score.ToString ();

			if (PlayerPrefs.GetInt ("Record") < score) {
				PlayerPrefs.SetInt ("Record", score);
				RecordText.text = score.ToString ();
			}
		}
	}

	void Awake(){

		Instance = this;

		if (!PlayerPrefs.HasKey ("Record"))
			PlayerPrefs.SetInt ("Record", 0);

		ScoreText.text = "0";
		RecordText.text = PlayerPrefs.GetInt ("Record").ToString();
	}
}
