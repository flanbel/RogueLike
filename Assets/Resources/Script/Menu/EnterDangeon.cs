using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

//ダンジョンに入る
public class EnterDangeon : MonoBehaviour {
    [SerializeField]
    string DungeonCode ="";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    public void Enter()
    {
        SceneManager.LoadScene("_Dungeon");
    }
}
