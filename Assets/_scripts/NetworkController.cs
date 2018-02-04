using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using UnityEngine.UI;

public class NetworkController : NetworkBehaviour {
    public Button btn;
    // Use this for initialization

    public delegate void SendUpdateDelegate(Color color, HashSet<int> locs);

    [SyncEvent]
    public event SendUpdateDelegate EventSendUpdate;

    [Command]
    public void CmdDoMe()
    {
        EventSendUpdate(allVariables.getPlayerColor(), gameObject.GetComponent<Gameboard>().numset);
    }

    [SyncVar]
    private int ct = 0;

    private Hashtable confirms = new Hashtable();

    void Start () {
        //Button btn = yourButton.GetComponent<Button>();
        if (NetworkClient.active)
            EventSendUpdate += SendUpdate;
        btn.onClick.AddListener(confirmed);
        //playerColor = allVariables.getPlayerColor();
        //myID = GetComponent<Gameboard>().getID();
    }

    public void SendUpdate(Color color, HashSet<int> locs)
    {
        ct += 1;
        confirms.Add(color, locs);
    }

    // Update is called once per frame
    void Update () {
		
	}

    void confirmed ()
    {
        CmdDoMe();
    }
}
