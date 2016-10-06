using UnityEngine;
using System.Collections;

public class MenuButton : MonoBehaviour {

    //どの画面を表示するか
    public GameObject Hierarchy;
    public GameObject Menu;


	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}

    //下の階層に進む
    public void LowerHierarchy()
    {
        MenuManager.ChengeHierarchy(Hierarchy,Menu);
    }

    public void ChengeMenu()
    {
        MenuManager.ChengeMenu(Menu);
    }
}
