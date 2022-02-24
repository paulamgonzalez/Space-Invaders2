using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    public void Awake()
    {
        GameObject nave = Instantiate(GameDataPersistent.instance.selectedSpaceship.prefab);
        nave.transform.localScale = new Vector3(0.40f, 0.40f, 0.40f);
        nave.transform.position = new Vector3(2.9f, -67.3f, 0);
        nave.transform.rotation = Quaternion.Euler (0,0,0);
    }
}
