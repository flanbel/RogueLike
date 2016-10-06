using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class MenuManager : MonoBehaviour {
    //自分より上の階層を保持
    static Stack<GameObject> HierarchyStack = new Stack<GameObject>();
    static GameObject NowHierarchy;
    static GameObject NowMenu;

    // Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
	static void Update () {
        
	}

    //階層切り替え
    static public void ChengeHierarchy(GameObject hierarchy,GameObject menu)
    {
        //前回の階層をファルスに
        if (NowHierarchy)
        {
            NowHierarchy.SetActive(false);
            //追加
            HierarchyStack.Push(NowHierarchy);
        }

        //メインメニューが選択されたなら
        if (hierarchy.tag == "MainMenu")
        {
            //スタックの中身を全て消す
            HierarchyStack.Clear();
        }

        hierarchy.SetActive(true);
        NowHierarchy = hierarchy;

        ChengeMenu(menu);
    }

    static public void ChengeMenu(GameObject menu)
    {
        //前回のメニューをファルスに
        if (NowMenu)
        {
            NowMenu.SetActive(false);
        }

        if (menu)
        {
            menu.SetActive(true);
        }
        NowMenu = menu;
    }

    //一つ前の階層に戻る
    public void BackHierarchy()
    {
        //一つ以上スタックされている
        if (HierarchyStack.Count > 0)
        {
            //メニューを消して
            ChengeMenu(null);
            //今の階層を消して
            NowHierarchy.SetActive(false);
            //一つ前の階層を取得
            NowHierarchy = HierarchyStack.Pop();
            NowHierarchy.SetActive(true);
        }
    }
}
