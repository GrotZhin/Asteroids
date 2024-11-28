using System.Collections;
using System.Collections.Generic;

using UnityEngine;

public class Utility : MonoBehaviour
{
public static Vector3 Position(Vector3 pos){
if (pos.x >= 11)
        {
            pos.x = -11;
            
        }
        else if (pos.x <= -11)
        {
            pos.x = 11;
           

        }
        else if (pos.y >= 6)
        {
            pos.y = -6;
            
        }
        else if (pos.y <= -6)
        {
            pos.y = 6;
            
        }
        return pos;
}
}
