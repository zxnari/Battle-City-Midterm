using System;
using UnityEngine;
using UnityEngine.SceneManagement;
namespace Chapter.Singleton
{
    public class KillManager : Singleton<KillManager>
    {
        public int kills;
        void Start()
        {
            Debug.Log("Kills: "+ kills);
        }
        void OnApplicationQuit()
        {
            Debug.Log("Final # of Kills: " + kills);
        }
    }
}
