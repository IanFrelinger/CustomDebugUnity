using System;
using CustomDebug.Dispatchers;
using UnityEngine;

namespace CustomDebug.Data
{
    [Serializable]
    public class DebugSettings
    {
        [SerializeField] 
        private DebugMode debugMode;
        
        public DebugMode DebugMode => debugMode;
    }
}