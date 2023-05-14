using UnityEngine;
using UnityEngine.SceneManagement;
/// <summary>
/// Class which store level data
/// </summary>
[System.Serializable]
public class LevelData
{
    public int shotCount;           //maximum shot player can take 
	public string scene;
	public void Namescene(){
		SceneManager.LoadScene (scene);
	}
}
