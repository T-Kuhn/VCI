﻿using System;
using System.Collections.Generic;
using VCIJSON;


namespace VCIGLTF
{
    /// <summary>
    /// https://github.com/KhronosGroup/glTF/issues/1036
    /// </summary>
    [Serializable]
    public partial class glTFMesh_extras : ExtraBase<glTFMesh_extras>
    {
        [JsonSchema(Required = true, MinItems = 1)]
        public List<string> targetNames = new List<string>();

        [JsonSerializeMembers]
        void PrimitiveMembers(GLTFJsonFormatter f)
        {
            if (targetNames.Count > 0)
            {
                f.Key("targetNames");
                f.BeginList();
                foreach (var x in targetNames)
                {
                    f.Value(x);
                }
                f.EndList();
            }
        }
    }
}
