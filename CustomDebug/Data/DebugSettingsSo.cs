using System;
using UnityEngine;
using System.Collections.Generic;
using CustomDebug.Behaviors;
using CustomDebug.Dispatchers;
using CustomDebug.Implementations;
using CustomDebug.Templates;

namespace CustomDebug.Data
{
    [CreateAssetMenu(fileName = "DebugSettings", 
        menuName = "DebugSettings", order = 0)]
    public class DebugSettingsSo : ScriptableObject
    {
        // Instance of the DebugSettings class.
        private DebugSettings _debugSettings;
        
        public DebugMode DebugMode => _debugSettings.DebugMode;

        // Dictionary to map DebugModes to their respective strategies.
        private static readonly Dictionary<DebugMode, IDebugStrategy> DebugStrategies = new Dictionary<DebugMode, IDebugStrategy>
        {
            { DebugMode.Unset, new UnsetDebugStrategy() },
            { DebugMode.ThrowError, new ThrowErrorDebugStrategy() },
            { DebugMode.PrintMessage, new PrintMessageDebugStrategy() }
        };

        private void Awake()
        {
            _debugSettings = new DebugSettings();

            // Set the strategy for DebugSystem based on the DebugMode using the dictionary.
            if (DebugStrategies.TryGetValue(DebugMode, out var strategy))
            {
                DebugSystem.debugStrategy = strategy;
            }
            else
            {
                throw new ArgumentOutOfRangeException($"Unknown debug mode: {DebugMode}");
            }
        }
    }
}