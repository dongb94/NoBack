using UnityEngine;

namespace Script.System.MapEditor
{
    public class TileSelector : MonoBehaviour
    {
        public Tile.TileShape Shape;
        public Tile.TileColor Color;

        public void SetTile()
        {
            TilePointer.GetInstance.SetSampleTile(Shape,Color);
        }
    }
}