using UnityEngine;
using UnityEngine.Tilemaps;

public class NewMonoBehaviourScript : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    [SerializeField] Tilemap tm;
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0)){
            Vector3 mouspos = Input.mousePosition;
            Vector3 worldpos = Camera.main.ScreenToWorldPoint(mouspos);
            Vector3Int cellpos = tm.WorldToCell(worldpos);
            tm.SetTileFlags(cellpos, TileFlags.None);
            tm.SetColor(cellpos, Color.red);
            Debug.Log($" mouspos {mouspos}");
            Debug.Log($" worldpos {worldpos}" );
            Debug.Log($" cellpos {cellpos}");

        }
    }
}
