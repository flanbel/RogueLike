using UnityEngine;
using System.Collections;

public class ClickOnTheWorld : MonoBehaviour {

    GameObject old;

	// Use this for initialization
	void Start () {
        
	}
	
	// Update is called once per frame
	void Update () {
        //前に選択していたものの色を白に
        if(old)
        {
            old.GetComponent<Renderer>().material.color = Color.white;
        }
        //左クリック
        //if (Input.GetMouseButton(0))
        {
            //マウスのポジションからレイを飛ばす
            Vector3 screen = Input.mousePosition;
            Ray r = Camera.main.ScreenPointToRay(screen);
            RaycastHit hit = new RaycastHit();

            if (Physics.Raycast(r, out hit))
            {
                if (hit.collider.gameObject.name == "Floor(Clone)")
                {
                    old = hit.collider.gameObject;
                    old.GetComponent<Renderer>().material.color = new Color(1.0F, 0.0F, 0.0F);
                }
            }
        }
	}
}
