// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See LICENSE in the project root for license information.

using Microsoft.MixedReality.Toolkit.SDK.Utilities.Solvers;
using UnityEditor;
using UnityEngine;

namespace Microsoft.MixedReality.Toolkit.SDK.Inspectors.Utilities.Solvers
{
    [CustomEditor(typeof(ControllerFinder))]
    public abstract class ControllerFinderInspector : Editor
    {
        private SerializedProperty handednessProperty;

        protected virtual void OnEnable()
        {
            handednessProperty = serializedObject.FindProperty("handedness");
        }

        public override void OnInspectorGUI()
        {
            serializedObject.Update();

            EditorGUILayout.Space();
            EditorGUILayout.LabelField("Controller Options", new GUIStyle("Label") { fontStyle = FontStyle.Bold });
            EditorGUILayout.Space();
            EditorGUI.indentLevel++;

            EditorGUILayout.PropertyField(handednessProperty);

            EditorGUI.indentLevel--;
            serializedObject.ApplyModifiedProperties();
        }
    }
}
