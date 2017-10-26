using System;
using UnityEngine;
using System.Runtime.InteropServices;
using RealtimeCSG;

namespace InternalRealtimeCSG
{
    [Serializable]
	[StructLayout(LayoutKind.Sequential, Pack = 4)]
	public struct TexGen
    {
		public Color		Color;
        public Vector2		Translation;
        public Vector2		Scale;
        public float		RotationAngle;
        public Int32		RenderMaterialIndex;		// <- index in material list of owning CSG-model
        public Int32		PhysicsMaterialIndex;		// <- index in material list of owning CSG-model
        public UInt32		SmoothingGroup;
		
		public TexGen(Int32 renderMaterialIndex = -1, Int32 physicsMaterialIndex = -1)
		{
			Color					= Color.white;
			Translation				= MathConstants.zeroVector3;
			Scale					= MathConstants.oneVector3;
			RotationAngle			= 0;
			RenderMaterialIndex		= renderMaterialIndex;
			PhysicsMaterialIndex	= physicsMaterialIndex;
			SmoothingGroup			= 0;
		}
    }
}
