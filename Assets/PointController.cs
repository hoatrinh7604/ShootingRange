using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PointController : MonoBehaviour
{
    [SerializeField] Vector3[] piecesOfCircle;
    [SerializeField] int[] pointOfPieces;
    [SerializeField] float radius;

    [SerializeField] Transform tempTran;

    [SerializeField] float centerRadius;
    [SerializeField] int centerPoint;
    [SerializeField] float centerRadius2;
    [SerializeField] int centerPoint2;

    [SerializeField] float[] listRadius;
    [SerializeField] int[] listPoint;
    public int GetPointOfPosition(Vector3 point)
    {
        int checkPoint = CheckCenter(point);
        if(checkPoint > 0)
        {
            return checkPoint;
        }

        return 0;
    }

    private int CheckCenter(Vector3 point)
    {
        float rad = point.magnitude;
        for(int i  = 0; i < listRadius.Length; i++)
        {
            if(rad < listRadius[i])
            {
                return listPoint[i];
            }
        }

        return 0;
    }

    private bool CheckOutSide(Vector3 point)
    {
        if(point.magnitude > radius)
        {
            return true;
        }

        if(point.magnitude < 5)
        {

        }

        return false;
    }

    public float IsLeft(Vector3 a, Vector3 b, Vector3 c)
    {
        return ((b.x - a.x) * (c.y - a.y) - (b.y - a.y) * (c.x - a.x));
    }

}
