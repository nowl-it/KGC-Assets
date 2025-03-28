using System;
using System.Collections.Generic;
using SRDebugger.Services;
using UnityEngine;
using UnityEngine.UI;

namespace SRDebugger.UI.Controls
{
	[RequireComponent(typeof(CanvasRenderer))]
	[ExecuteInEditMode]
	[RequireComponent(typeof(RectTransform))]
	public class ProfilerGraphControl : Graphic
	{
		public enum VerticalAlignments
		{
			Top = 0,
			Bottom = 1
		}

		public VerticalAlignments VerticalAlignment;

		private static readonly float[] ScaleSteps;

		public bool FloatingScale;

		public bool TargetFpsUseApplication;

		public bool DrawAxes;

		public int TargetFps;

		public bool Clip;

		public const float DataPointMargin = 2f;

		public const float DataPointVerticalMargin = 2f;

		public const float DataPointWidth = 4f;

		public int VerticalPadding;

		public const int LineCount = 3;

		public Color[] LineColours;

		private IProfilerService _profilerService;

		private ProfilerGraphAxisLabel[] _axisLabels;

		private Rect _clipBounds;

		private readonly List<Vector3> _meshVertices;

		private readonly List<Color32> _meshVertexColors;

		private readonly List<int> _meshTriangles;

		protected override void Awake()
		{
		}

		protected override void Start()
		{
		}

		protected void Update()
		{
		}

		[Obsolete]
		protected override void OnPopulateMesh(Mesh m)
		{
		}

		protected void DrawDataPoint(float xPosition, float verticalScale, ProfilerFrame frame)
		{
		}

		protected void DrawAxis(float frameTime, float yPosition, ProfilerGraphAxisLabel label)
		{
		}

		protected void AddRect(Vector3 tl, Vector3 tr, Vector3 bl, Vector3 br, Color c)
		{
		}

		protected ProfilerFrame GetFrame(int i)
		{
			return default(ProfilerFrame);
		}

		protected int CalculateVisibleDataPointCount()
		{
			return 0;
		}

		protected int GetFrameBufferCurrentSize()
		{
			return 0;
		}

		protected int GetFrameBufferMaxSize()
		{
			return 0;
		}

		protected float CalculateMaxFrameTime()
		{
			return 0f;
		}

		private ProfilerGraphAxisLabel GetAxisLabel(int index)
		{
			return null;
		}
	}
}
