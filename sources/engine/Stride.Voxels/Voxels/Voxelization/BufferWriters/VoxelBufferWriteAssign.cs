﻿using System;
using System.Collections.Generic;
using System.Text;
using Stride.Core;
using Stride.Shaders;
using Stride.Rendering.Materials;

namespace Stride.Rendering.Voxels
{
    //[DataContract("VoxelFlickerReductionNone")]
    [DataContract(DefaultMemberMode = DataMemberMode.Default)]
    [Display("None")]
    public class VoxelBufferWriteAssign : IVoxelBufferWriter
    {
        ShaderSource source = new ShaderClassSource("VoxelBufferWriteAssign");
        public ShaderSource GetShader()
        {
            return source;
        }
    }
}
