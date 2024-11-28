using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pointcontrol: MonoBehaviour
{

    public static int points;

        public static int Points
        {
            get
            {
                return points;
            }
            set
            {
                points = value;
                if (points < 0)
                {
                   points = 0;
                }
                Debug.Log("Pontos" + points);
            }
        }
}

