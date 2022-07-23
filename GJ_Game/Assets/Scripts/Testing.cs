using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CodeMonkey.Utils;

public class Testing : MonoBehaviour
{
    private Grid grid;

    private void Start()
    {
        grid = new Grid(4, 4, 10f, new Vector3(0, 0));
        new Grid(2, 2, 5f, new Vector3(-10, -10));
    }

    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            grid.SetValue(UtilsClass.GetMouseWorldPosition(), 56);
        }

        if (Input.GetMouseButtonDown(1))
        {
            Debug.Log(grid.GetValue(UtilsClass.GetMouseWorldPosition()));
        }
    }

    // private class HeatMapVisual
    // {
    //     private Grid grid;

    //     public HeatMapVisual(Grid grid)
    //     {
    //         this.grid = grid;

    //         Vector3[] vertices;
    //         Vector2[] uv;
    //         int[] triangles;


    //         for (int x = 0; x < grid.GetWidth(); x++)
    //         {
    //             for (int y = 0; y < grid.GetHeight(); y++)
    //             {

    //             }
    //         }
    //     }
    // }
}
