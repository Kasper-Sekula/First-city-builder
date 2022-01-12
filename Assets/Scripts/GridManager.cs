using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GridManager : MonoBehaviour
{
    [SerializeField] int width = 1;
    [SerializeField] int height = 1;
    [SerializeField] GameObject tilePrefab;
    Grid grid;

    private void GridCreator(int width, int height)
    {
        grid = new Grid(width, height);

        for (int i=0; i< width; i++){
            for (int j=0; j< height; j++)
            {
                Instantiate(tilePrefab, new Vector3(i*10, 0, j*10), Quaternion.identity);
            }
        }

    }

    private void Start() {
        GridCreator(width, height);
    }

}
