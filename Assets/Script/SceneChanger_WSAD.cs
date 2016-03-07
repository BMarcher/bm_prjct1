using UnityEngine;
using System.Collections;

public class SceneChanger_WSAD : MonoBehaviour
{

    public string nextScene = "game_wsad";

    public void ChangeScene()
    {
        Application.LoadLevel(nextScene);
    }
}
