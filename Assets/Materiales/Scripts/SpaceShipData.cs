using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "data", menuName = "SpaceShip", order = 1)]

public class SpaceShipData : ScriptableObject
{
    public GameObject prefab;
    public string spaceshipname;
    [Range(0, 3.0f)]
    public int shield;
    [Range(0, 3.0f)]
    public int speed;
    [Range(0, 3.0f)]
    public int heat;
}
