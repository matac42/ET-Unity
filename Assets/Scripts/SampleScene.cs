using Photon.Pun;
using Photon.Realtime;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;

// MonoBehaviourではなくMonoBehaviourPunCallbacksを継承して、Photonのコールバックを受け取れるようにする
public class SampleScene : MonoBehaviourPunCallbacks
{
    private void Start() {
        // PhotonServerSettingsに設定した内容を使ってマスターサーバーへ接続する
        PhotonNetwork.ConnectUsingSettings();
    }

    // マスターサーバーへの接続が成功した時に呼ばれるコールバック
    public override void OnConnectedToMaster() {
        // "room"という名前のルームに参加する（ルームが無ければ作成してから参加する）
        PhotonNetwork.JoinOrCreateRoom("room", new RoomOptions(), TypedLobby.Default);
    }

    // マッチングが成功した時に呼ばれるコールバック
    public override void OnJoinedRoom() {
        // マッチング後、ランダムな位置に自分自身のネットワークオブジェクトを生成する
        var v = new Vector3(Random.Range(50f, 150f), 20, Random.Range(50f, 150f));
        // var v = new Vector3(50,0,50);
        GameObject player = PhotonNetwork.Instantiate("Car", v, Quaternion.identity);

        player.GetComponent<CarUserControl>().enabled = true;
        player.GetComponent<CarController>().enabled = true;


    }
}