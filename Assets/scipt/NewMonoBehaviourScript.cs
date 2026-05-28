using UnityEngine;
using UnityEngine.Tilemaps;
using UnityEngine.UIElements;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Tilemap tm;
    BoundsInt bounds;
    
    void Start()
    {
        bounds = tm.cellBounds;
        Debug.Log(bounds);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)){
            Vector3 mouspos2 = Input.mousePosition;
            Vector3 worldpos2 = Camera.main.ScreenToWorldPoint(mouspos2);
            Vector3Int cellpos3 = tm.WorldToCell(worldpos2);
            Debug.Log($" mouspos {mouspos2}");
            Debug.Log($" worldpos {worldpos2}" );
            Debug.Log($" cellpos {cellpos3}");

        }
        Vector3 mouspos = Input.mousePosition;
        Vector3 worldpos = Camera.main.ScreenToWorldPoint(mouspos);
        Vector3Int cellpos = tm.WorldToCell(worldpos);
        //tm.SetTileFlags(cellpos, TileFlags.None);
        //tm.SetColor(cellpos, Color.red);
        for (int i = 0 + bounds.position.x; i < bounds.size.x; i++)
        {
            for (int j = 0 + bounds.position.y; j < bounds.size.y; j++)
            {

                Vector3Int cellpos2 = new Vector3Int(i, j, 0);
                tm.SetTileFlags(cellpos2, TileFlags.None);
                if (cellpos2 == cellpos)
                {

                    tm.SetColor(cellpos2, Color.red);


                }
                else
                {
                    tm.SetColor(cellpos2, Color.white);
                }
            }
        }
    }
}
