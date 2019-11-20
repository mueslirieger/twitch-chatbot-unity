using UnityEngine;
using WebSocketSharp;

public class TwitchInteractionManager : MonoBehaviour
{
    [SerializeField] private string serverUrl = "";

    private WebSocket _webSocket;

    // Start is called before the first frame update
    void Start()
    {
        _webSocket = new WebSocket(serverUrl);

        Debug.Log("Connected to server!");

        _webSocket.OnMessage += (sender, e) => { Debug.Log(e.Data); };
        _webSocket.OnError += (sender, e) => { Debug.Log("Error " + e.Message); };
        _webSocket.OnClose += (sender, e) => { Debug.Log("Connection closed. Clean exit: " + e.WasClean); };

        _webSocket.Connect();
    }

    // Update is called once per frame
    void Update()
    {
    }
}