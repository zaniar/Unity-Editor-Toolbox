﻿using UnityEditor;
using UnityEngine;

namespace Toolbox.Editor.Drawers
{
    public class EndIndentAttributeDrawer : ToolboxDecoratorDrawer<EndIndentAttribute>
    {
        protected override void OnGuiEndSafe(EndIndentAttribute attribute)
        {
            EditorGUI.indentLevel -= attribute.IndentToSubtract;
        }
    }
}