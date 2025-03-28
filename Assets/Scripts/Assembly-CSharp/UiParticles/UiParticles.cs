using UnityEngine;
using UnityEngine.Serialization;
using UnityEngine.UI;

namespace UiParticles
{
	[RequireComponent(typeof(ParticleSystem))]
	public class UiParticles : MaskableGraphic
	{
		[FormerlySerializedAs("m_ParticleSystem")]
		[SerializeField]
		private ParticleSystem m_ParticleSystem;

		[Tooltip("Render mode of particles")]
		[SerializeField]
		[FormerlySerializedAs("m_RenderMode")]
		private UiParticleRenderMode m_RenderMode;

		[SerializeField]
		[FormerlySerializedAs("m_StretchedSpeedScale")]
		[Tooltip("Speed Scale for streched billboards")]
		private float m_StretchedSpeedScale;

		[Tooltip("Speed Scale for streched billboards")]
		[FormerlySerializedAs("m_StretchedLenghScale")]
		[SerializeField]
		private float m_StretchedLenghScale;

		[FormerlySerializedAs("m_IgnoreTimescale")]
		[SerializeField]
		[Tooltip("If true, particles ignore timescale")]
		private bool m_IgnoreTimescale;

		[SerializeField]
		private Mesh m_RenderedMesh;

		private const string MainTexPropertyName = "_MainTex";

		private const string BaseMapPropertyName = "_BaseMap";

		private int m_MainTexProperty;

		private ParticleSystemRenderer m_ParticleSystemRenderer;

		private ParticleSystem.Particle[] m_Particles;

		private Mesh _cachedMesh;

		private Vector3[] m_MeshVerts;

		private int[] m_MeshTriangles;

		private Vector2[] m_MeshUvs;

		public ParticleSystem ParticleSystem
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		public override Texture mainTexture => null;

		public UiParticleRenderMode RenderMode
		{
			get
			{
				return default(UiParticleRenderMode);
			}
			set
			{
			}
		}

		public Mesh RenderedMesh
		{
			get
			{
				return null;
			}
			set
			{
			}
		}

		protected override void Awake()
		{
		}

		private void InitMeshData()
		{
		}

		public override void SetMaterialDirty()
		{
		}

		protected override void OnPopulateMesh(VertexHelper toFill)
		{
		}

		protected virtual void Update()
		{
		}

		private void InitParticlesBuffer(ParticleSystem.MainModule mainModule)
		{
		}

		private void GenerateParticlesBillboards(VertexHelper vh)
		{
		}

		private void DrawParticleMesh(ParticleSystem.Particle particle, VertexHelper vh, ParticleSystem.MinMaxCurve frameOverTime, bool isWorldSimulationSpace, ParticleSystem.TextureSheetAnimationModule textureSheetAnimationModule, Vector3[] verts, int[] triangles, Vector2[] uvs)
		{
		}

		private void DrawParticleBillboard(ParticleSystem.Particle particle, VertexHelper vh, ParticleSystem.MinMaxCurve frameOverTime, ParticleSystem.MinMaxCurve velocityOverTimeX, ParticleSystem.MinMaxCurve velocityOverTimeY, ParticleSystem.MinMaxCurve velocityOverTimeZ, bool isWorldSimulationSpace, ParticleSystem.TextureSheetAnimationModule textureSheetAnimationModule)
		{
		}

		private static void CalculateUvs(ParticleSystem.Particle particle, ParticleSystem.MinMaxCurve frameOverTime, ParticleSystem.TextureSheetAnimationModule textureSheetAnimationModule, float timeAlive, out Vector2 uv0, out Vector2 uv1, out Vector2 uv2, out Vector2 uv3)
		{
			uv0 = default(Vector2);
			uv1 = default(Vector2);
			uv2 = default(Vector2);
			uv3 = default(Vector2);
		}

		private void GetStrechedBillboardsSizeAndRotation(ParticleSystem.Particle particle, float timeAlive01, ref Vector3 size3D, out Quaternion rotation, ParticleSystem.MinMaxCurve x, ParticleSystem.MinMaxCurve y, ParticleSystem.MinMaxCurve z)
		{
			rotation = default(Quaternion);
		}
	}
}
