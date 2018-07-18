﻿using System;
using System.Linq;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

namespace Waypoints
{
    [CreateAssetMenu(fileName = "GraphName", menuName = "Waypoints/New Graph")]
    public class Graph : ScriptableObject
    {
        public List<Node> AllNodes;

        public Node GetNode(int index)
        {
            return AllNodes.ElementAtOrDefault(index);
        }
    }
}