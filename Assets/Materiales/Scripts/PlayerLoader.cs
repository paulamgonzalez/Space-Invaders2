using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLoader : MonoBehaviour
{
    public void Awake()
    {
        GameObject nave = Instantiate(GameDataPersistent.instance.selectedSpaceship.prefab);
        nave.transform.localScale = new Vector3(2.474513f, 2.346004f, 0.009898051f);
        nave.transform.position = new Vector3(0f, -66.7f, 0f);
        nave.transform.rotation = Quaternion.Euler (0,0,0);
    }
}
