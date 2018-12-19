using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Tilemaps;

public class TileSetting : MonoBehaviour
{
    public Vector3Int tilePosition = new Vector3Int(4, 4, 1);
    public Tilemap highlightTileMap;
    public Tile highlightTile;

    void Start()
    {
        highlightTileMap.SetTile(tilePosition, highlightTile);
    }

    void Update()
    {

    }
}