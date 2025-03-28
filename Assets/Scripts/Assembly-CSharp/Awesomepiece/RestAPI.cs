using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using Awesomepiece.Model;
using Cysharp.Threading.Tasks;
using Cysharp.Threading.Tasks.CompilerServices;

namespace Awesomepiece
{
	public class RestAPI
	{
		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAccessoryAddExp_003Ed__258 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AccessoryResultResponseModel> _003C_003Et__builder;

			public AccessoryRequestModel model;

			private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAccessoryDismantle_003Ed__256 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AccessoryResultResponseModel> _003C_003Et__builder;

			public AccessoryDismantleRequestModel model;

			private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAccessoryEquip_003Ed__253 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AccessoryResultResponseModel> _003C_003Et__builder;

			public AccessoryEquipRequestModel model;

			public bool useTicket;

			private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAccessoryEquipTutorial_003Ed__254 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AccessoryResultResponseModel> _003C_003Et__builder;

			public AccessoryEquipRequestModel model;

			private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAccessoryReleaseEquip_003Ed__255 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AccessoryResultResponseModel> _003C_003Et__builder;

			public AccessoryRequestModel model;

			private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAccessorySetState_003Ed__257 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AccessoryResultResponseModel> _003C_003Et__builder;

			public AccessorySetStateRequestModel model;

			private UniTask<AccessoryResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAccountTransfer_003Ed__105 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TransferResponseModel> _003C_003Et__builder;

			public TransferRequestModel requestModel;

			private UniTask<TransferResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAdLog_003Ed__103 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public AdRequestModel requestModel;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAddCard_003Ed__288 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAddCardExp_003Ed__289 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAddCash_003Ed__286 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAddExp_003Ed__284 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAddGold_003Ed__285 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAddHeart_003Ed__287 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAddInventoryCount_003Ed__26 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerInventoryCountResponseModel> _003C_003Et__builder;

			public InventoryCountRequestModel model;

			private UniTask<PlayerInventoryCountResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAddRanking_003Ed__290 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAddToDeck_003Ed__74 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DeckResponseModel> _003C_003Et__builder;

			public DeckRequestModel requestModel;

			private UniTask<DeckResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactCrafting_003Ed__109 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			public ArtifactRequestModel model;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactDevOptionSet_003Ed__120 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactDismantle_003Ed__111 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			public ArtifactDismantleRequestModel model;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactEquip_003Ed__118 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			public ArtifactRequestModel model;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactFetchReroll_003Ed__113 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactGachaTest_003Ed__108 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			public TestRequestModel model;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactMerge_003Ed__110 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			public ArtifactRequestModel model;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactPolish_003Ed__115 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			public ArtifactRequestModel model;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactPolish_ReplaceOptionSlotIdx_003Ed__116 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			public ArtifactRequestModel model;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactReroll_003Ed__112 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			public ArtifactRequestModel model;

			public bool useGold;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactSetFavorites_003Ed__119 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			public ArtifactRequestModel model;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CArtifactSetReroll_003Ed__114 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			public ArtifactRequestModel model;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAssignTerritoryLevelSync_003Ed__216 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryLevelSyncResponseModel> _003C_003Et__builder;

			public AssignTerritoryLevelSyncRequestModel model;

			private UniTask<TerritoryLevelSyncResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAssignUnitsToBuilding_003Ed__213 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryAssignUnitsResponseModel> _003C_003Et__builder;

			public AssignUnitsToBuildingRequestModel model;

			private UniTask<TerritoryAssignUnitsResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CAuth_003Ed__1 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AuthResponseModel> _003C_003Et__builder;

			public string id;

			public string cookie;

			private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CBanClanMember_003Ed__133 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ClanRoleRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CBuildTerritoryBuilding_003Ed__206 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryBuildBuildingResponseModel> _003C_003Et__builder;

			public TerritoryBuildBuildingRequestModel model;

			private UniTask<TerritoryBuildBuildingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CBuyBuildingPoint_003Ed__29 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<BuildingResponseModel> _003C_003Et__builder;

			private UniTask<BuildingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CBuyDeckSlot_003Ed__77 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public DeckRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CBuyIAP_003Ed__86 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<BuyResponseModel> _003C_003Et__builder;

			public IAPBuyRequestModel requestModel;

			private UniTask<BuyResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CBuyLevel_003Ed__122 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SeasonPassBuyLevelResponseModel> _003C_003Et__builder;

			private UniTask<SeasonPassBuyLevelResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CBuyShopItem_003Ed__82 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<BuyResponseModel> _003C_003Et__builder;

			public BuyRequestModel requestModel;

			private UniTask<BuyResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CBuySkin_003Ed__65 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<BuySkinResponseModel> _003C_003Et__builder;

			public BuySkinRequestModel model;

			private UniTask<BuySkinResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCanEarlyAccessMode_003Ed__38 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCanIAP_003Ed__83 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCanIAPAndAddToRestoreNeededIAPs_003Ed__85 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public CanIAPAndAddToRestoreNeededIAPsRequestModel requestModel;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCanIAP_New_003Ed__84 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public IAPBuyRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCancelColosseumMatching_003Ed__268 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CChangeClanMaster_003Ed__147 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ClanRoleRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CChangeClanMemberRole_003Ed__149 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ClanRoleRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CChangeClanRoleName_003Ed__150 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public ChangeClanRoleNameRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CChangeNickname_003Ed__102 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public ChangeNicknameRequestModel requestModel;

			private UniTask<ChangeNicknameResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CChangeProfileIconId_003Ed__18 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public ChangeProfileIconRequestModel requestModel;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCheckColosseumReenterEndGame_003Ed__233 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ColosseumEndGameReenterResponseModel> _003C_003Et__builder;

			public string gameId;

			private UniTask<ColosseumEndGameReenterResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCheckEarlyAccessModeCode_003Ed__39 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public string code;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCheckMission_003Ed__96 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<MissionResponseModel> _003C_003Et__builder;

			public List<string> condTypes;

			private UniTask<MissionResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCheckPatchVersion_003Ed__7 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public string version;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCheckRogueLikeMission_003Ed__191 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RogueLikeMissionResponseModel> _003C_003Et__builder;

			public RogueLikeMissionRequestModel model;

			private UniTask<RogueLikeMissionResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCheckRogueLikeMissionOnClear_003Ed__192 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RogueLikeMissionResponseModel> _003C_003Et__builder;

			private UniTask<RogueLikeMissionResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCheckTreasureWishListValid_003Ed__94 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public TreasureCheckWishListValidRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCheckUsePatch_003Ed__4 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public string platform;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CChoicePackageUnit_003Ed__90 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public ChoicePackageUnitRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CChoiceTreasurePickupCeil_003Ed__91 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public ChoiceTreasurePickupCeilRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CClanAttendanceCheck_003Ed__155 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanAttendanceResponseModel> _003C_003Et__builder;

			private UniTask<ClanAttendanceResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CClanChat_003Ed__138 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanChatResponseModel> _003C_003Et__builder;

			public ClanChatRequestModel model;

			private UniTask<ClanChatResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CClanNameCheck_003Ed__131 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public CreateClanRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CClanRequestSupport_003Ed__139 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ClanRequestSupportModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CClanSupport_003Ed__140 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanSupportResponseModel> _003C_003Et__builder;

			public ClanChatSeqIdRequestModel model;

			public bool all;

			private UniTask<ClanSupportResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CColosseumGetReward_003Ed__235 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public int index;

			public int gameEndRewardIndex;

			public string gameId;

			public bool upgrade;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CColosseumReceiveReward_003Ed__236 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PvPReceiveRewardResponseModel> _003C_003Et__builder;

			public PvPReceiveRewardRequestModel model;

			private UniTask<PvPReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CColosseumRecordMinimumRank_003Ed__243 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public string gameId;

			public int rank;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CColosseumReenterSucceed_003Ed__242 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public string gameId;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CColosseumReenterTried_003Ed__241 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public string gameId;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCompleteCustomEvent_003Ed__273 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public CustomEventRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCompleteKingGakReturnEvent_003Ed__22 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCompleteTutorial_003Ed__23 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public string statusKey;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCreateClan_003Ed__130 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<CreateClanResponseModel> _003C_003Et__builder;

			public CreateClanRequestModel model;

			private UniTask<CreateClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCreateColosseumCustomMatch_003Ed__269 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ColosseumCustomMatchResponseModel> _003C_003Et__builder;

			private UniTask<ColosseumCustomMatchResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CCustomEvent_003Ed__21 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerDataResponseModel> _003C_003Et__builder;

			public int id;

			private UniTask<PlayerDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDeleteClan_003Ed__134 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDeleteClanChat_003Ed__151 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanChatResponseModel> _003C_003Et__builder;

			public ClanChatSeqIdRequestModel model;

			private UniTask<ClanChatResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDeleteClanRaidDeck_003Ed__161 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanRaidDeckInfoResponseModel> _003C_003Et__builder;

			public int deckIdx;

			private UniTask<ClanRaidDeckInfoResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDeleteRogueLikeData_003Ed__183 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DeleteRogueLikeDataResponseModel> _003C_003Et__builder;

			public bool withLogging;

			private UniTask<DeleteRogueLikeDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDevAddPassMission_003Ed__315 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DevAddPassMissionResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDevDeleteAllPassMissions_003Ed__314 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDevResetCustomPickups_003Ed__316 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<CustomPickupsResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDevSetBabelStage_003Ed__318 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<BabelResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDevSetInvasionSkipCount_003Ed__317 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<GameSkipInfoResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CDevSetUnitBundlePackageUntilAt_003Ed__299 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CEndClanRaid_003Ed__159 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanRaidResponseModel> _003C_003Et__builder;

			public ClanRaidEndBattleRequestModel model;

			private UniTask<ClanRaidResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CEndRogueLikeFloor_003Ed__189 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<EndRogueLikeFloorResponseModel> _003C_003Et__builder;

			public EndRogueLikeFloorRequestModel model;

			private UniTask<EndRogueLikeFloorResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CEquipSkin_003Ed__66 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public EquipSkinRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CException_003Ed__15 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public string msg;

			public string type;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchArtifactInventory_003Ed__107 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactInventoryResponseModel> _003C_003Et__builder;

			private UniTask<ArtifactInventoryResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchChat_003Ed__154 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanChatResponseModel> _003C_003Et__builder;

			public ClanChatSeqIdRequestModel model;

			private UniTask<ClanChatResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchClan_003Ed__128 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchClanRaid_003Ed__158 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanRaidResponseModel> _003C_003Et__builder;

			private UniTask<ClanRaidResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchClanRaidBestDecks_003Ed__166 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanRaidBestDeckResponseModel> _003C_003Et__builder;

			private UniTask<ClanRaidBestDeckResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchClanRaidCurrentState_003Ed__165 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanRaidMemberDamageSumResponseModel> _003C_003Et__builder;

			private UniTask<ClanRaidMemberDamageSumResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchClanRaidSupporters_003Ed__162 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanRaidSupportResponseModel> _003C_003Et__builder;

			private UniTask<ClanRaidSupportResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchColosseumAddressByGameID_003Ed__232 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ColosseumMatchResponseModel> _003C_003Et__builder;

			public string gameId;

			private UniTask<ColosseumMatchResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchColosseumPlayersData_003Ed__231 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ColosseumPlayerDataResponseModel> _003C_003Et__builder;

			public string gameId;

			private UniTask<ColosseumPlayerDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchEquippedFlag_003Ed__174 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<FlagResponseModel> _003C_003Et__builder;

			public int targetId;

			private UniTask<FlagResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchEventPackageShopInfo_003Ed__293 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ShopResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchFlagInventory_003Ed__173 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<FlagInventoryResponseModel> _003C_003Et__builder;

			public int targetId;

			private UniTask<FlagInventoryResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchInvasionRecords_003Ed__260 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<InvasionRecordsResponseModel> _003C_003Et__builder;

			private UniTask<InvasionRecordsResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchInvasionRewardDatas_003Ed__261 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<InvasionRewardDatasResponseModel> _003C_003Et__builder;

			private UniTask<InvasionRewardDatasResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchNameTagInventory_003Ed__176 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<NameTagInventoryResponseModel> _003C_003Et__builder;

			private UniTask<NameTagInventoryResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchOtherClan_003Ed__129 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ClanRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchPlayerAccessory_003Ed__252 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AccessoryInventoryResponseModel> _003C_003Et__builder;

			private UniTask<AccessoryInventoryResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchPlayerBabel_003Ed__264 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<BabelResponseModel> _003C_003Et__builder;

			private UniTask<BabelResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchPlayerColosseum_003Ed__230 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerColosseumInfoResponseModel> _003C_003Et__builder;

			private UniTask<PlayerColosseumInfoResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchPlayerSeasonalEventData_003Ed__259 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerSeasonalEventDataResponseModel> _003C_003Et__builder;

			private UniTask<PlayerSeasonalEventDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchPlayerTerritory_003Ed__203 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerTerritoryResponseModel> _003C_003Et__builder;

			private UniTask<PlayerTerritoryResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchPlayerTreasure_003Ed__244 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureInventoryResponseModel> _003C_003Et__builder;

			private UniTask<TreasureInventoryResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchPvPDeck_003Ed__292 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PvPMatchResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchPvPInfo_003Ed__47 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PvPInfoResponseModel> _003C_003Et__builder;

			private UniTask<PvPInfoResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchPvPLatestGamesLog_003Ed__52 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PvPLogResponseModel> _003C_003Et__builder;

			private UniTask<PvPLogResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchSeasonPass_003Ed__121 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SeasonPassResponseModel> _003C_003Et__builder;

			private UniTask<SeasonPassResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchSeasonPassEventBooster_003Ed__126 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SeasonPassEventBoosterResponseModel> _003C_003Et__builder;

			private UniTask<SeasonPassEventBoosterResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchTerritoryHunting_003Ed__221 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryHuntingResponseModel> _003C_003Et__builder;

			private UniTask<TerritoryHuntingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CFetchTerritoryStatBuffs_003Ed__204 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryStatBuffPerResponseModel> _003C_003Et__builder;

			private UniTask<TerritoryStatBuffPerResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGameAdBonus_003Ed__44 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public GameAdBonusRequestModel requestModel;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGameComplete_003Ed__41 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<GameResponseModel> _003C_003Et__builder;

			public GameCompleteRequestModel requestModel;

			private UniTask<GameResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGameRevive_003Ed__43 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<GameResponseModel> _003C_003Et__builder;

			public bool useReviveCoupon;

			private UniTask<GameResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGameSkip_003Ed__42 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<GameResponseModel> _003C_003Et__builder;

			public GameSkipRequestModel requestModel;

			private UniTask<GameResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGameStart_003Ed__40 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<GameStartResponseModel> _003C_003Et__builder;

			public GameStartRequestModel requestModel;

			private UniTask<GameStartResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetAccountTransferCode_003Ed__104 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TransferCodeResponseModel> _003C_003Et__builder;

			private UniTask<TransferCodeResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetAllCards_003Ed__62 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<CardListResponseModel> _003C_003Et__builder;

			private UniTask<CardListResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetAllMissions_003Ed__95 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<MissionResponseModel> _003C_003Et__builder;

			private UniTask<MissionResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetAllPosts_003Ed__99 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PostResponseModel> _003C_003Et__builder;

			private UniTask<PostResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetAllRogueLikeMissions_003Ed__193 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RogueLikeMissionDataResponseModel> _003C_003Et__builder;

			private UniTask<RogueLikeMissionDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetAllRogueLikeMissionsStatistics_003Ed__194 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RogueLikeMissionStatisticsResponseModel> _003C_003Et__builder;

			private UniTask<RogueLikeMissionStatisticsResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetArenaWinReward_003Ed__56 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArenaWinRewardResponseModel> _003C_003Et__builder;

			public ArenaWinRewardRequestModel model;

			private UniTask<ArenaWinRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetBuildingInfo_003Ed__28 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<BuildingResponseModel> _003C_003Et__builder;

			private UniTask<BuildingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetCard_003Ed__63 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<CardResponseModel> _003C_003Et__builder;

			public int cardId;

			private UniTask<CardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetClanPointRanking_003Ed__156 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanPointRankingResponseModel> _003C_003Et__builder;

			public bool weekly;

			private UniTask<ClanPointRankingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetClanRanking_003Ed__157 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanRankingResponseModel> _003C_003Et__builder;

			private UniTask<ClanRankingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetColosseumHallOfFame_003Ed__240 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ColosseumRankingResponseModel> _003C_003Et__builder;

			public int leagueSeason;

			public bool useCache;

			private UniTask<ColosseumRankingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetColosseumLeagueRanking_003Ed__239 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<LeagueRankingResponseModel> _003C_003Et__builder;

			public int leagueSeason;

			public bool useCache;

			private UniTask<LeagueRankingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetColosseumOpenMissionReward_003Ed__237 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RewardListResponseModel> _003C_003Et__builder;

			public int rewardIdx;

			private UniTask<RewardListResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetColosseumRanking_003Ed__238 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ColosseumRankingResponseModel> _003C_003Et__builder;

			public int season;

			public bool useCache;

			private UniTask<ColosseumRankingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetCurrentSeq_003Ed__153 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanSeqResponseModel> _003C_003Et__builder;

			private UniTask<ClanSeqResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetDailyAttendanceEvents_003Ed__19 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DailyAttendanceEventsResponseModel> _003C_003Et__builder;

			private UniTask<DailyAttendanceEventsResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetDeck_003Ed__73 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DeckResponseModel> _003C_003Et__builder;

			private UniTask<DeckResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetDefaultInfraRankingServer_003Ed__323 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ServerListResponse> _003C_003Et__builder;

			public bool useReplica;

			private UniTask<ServerListResponse>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetDevServers_003Ed__322 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ServerListResponse> _003C_003Et__builder;

			private UniTask<ServerListResponse>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetEventMode_003Ed__46 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<EventModeResponseModel> _003C_003Et__builder;

			private UniTask<EventModeResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetFourthYearEventDailyAttendanceReward_003Ed__37 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<FourthYearEventReceiveRewardResponseModel> _003C_003Et__builder;

			public int day;

			private UniTask<FourthYearEventReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetFourthYearEventDailyPassReward_003Ed__36 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<FourthYearEventReceiveRewardResponseModel> _003C_003Et__builder;

			private UniTask<FourthYearEventReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetFourthYearEventPrevPassReward_003Ed__35 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<FourthYearEventReceiveRewardResponseModel> _003C_003Et__builder;

			private UniTask<FourthYearEventReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetGameSkipInformation_003Ed__27 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<GameSkipInfoResponseModel> _003C_003Et__builder;

			private UniTask<GameSkipInfoResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetInventory_003Ed__178 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<InventoryResponseModel> _003C_003Et__builder;

			private UniTask<InventoryResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetJourneyReward_003Ed__32 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<JourneyRewardResponseModel> _003C_003Et__builder;

			public JourneyRewardRequestModel requestModel;

			private UniTask<JourneyRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetLoginSceneIllustData_003Ed__14 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<LoginSceneIllustDataResponseModel> _003C_003Et__builder;

			private UniTask<LoginSceneIllustDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetMissionGoalReward_003Ed__98 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<MissionRewardResponseModel> _003C_003Et__builder;

			private UniTask<MissionRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetMissionReward_003Ed__97 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<MissionRewardResponseModel> _003C_003Et__builder;

			public MissionRewardRequestModel requestModel;

			private UniTask<MissionRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetOtherPlayerInfo_003Ed__17 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<OtherPlayerDataResponseModel> _003C_003Et__builder;

			public int targetId;

			private UniTask<OtherPlayerDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetPatchFolder_003Ed__5 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PatchFolderResponseModel> _003C_003Et__builder;

			private UniTask<PatchFolderResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetPlayerCurrencies_003Ed__12 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerCurrenciesResponseModel> _003C_003Et__builder;

			private UniTask<PlayerCurrenciesResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetPlayerDailyConsumedCurrencies_003Ed__13 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerCurrenciesResponseModel> _003C_003Et__builder;

			private UniTask<PlayerCurrenciesResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetPlayerFourthYearEvent_003Ed__34 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<FourthYearEventResponseModel> _003C_003Et__builder;

			private UniTask<FourthYearEventResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetPlayerInfo_003Ed__10 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerDataResponseModel> _003C_003Et__builder;

			private UniTask<PlayerDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetPlayerTutorialStatus_003Ed__11 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<KeyValuesResponseModel> _003C_003Et__builder;

			private UniTask<KeyValuesResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetPvPHallOfFame_003Ed__55 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PvPRankingResponseModel> _003C_003Et__builder;

			public int leagueSeason;

			public bool useCache;

			private UniTask<PvPRankingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetPvPLeagueRanking_003Ed__54 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<LeagueRankingResponseModel> _003C_003Et__builder;

			public int leagueSeason;

			public bool useCache;

			private UniTask<LeagueRankingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetPvPRanking_003Ed__51 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PvPRankingResponseModel> _003C_003Et__builder;

			public int season;

			public bool useCache;

			private UniTask<PvPRankingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetRanking_003Ed__45 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RankingResponseModel> _003C_003Et__builder;

			public int theme;

			public bool useCache;

			private UniTask<RankingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetRestoreNeededIAPs_003Ed__88 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<GetRestoreNeededIAPsResponseModel> _003C_003Et__builder;

			private UniTask<GetRestoreNeededIAPsResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetRogueLikeBuildingRanking_003Ed__185 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RogueLikeRankingResponseModel> _003C_003Et__builder;

			public int building;

			public bool useCache;

			private UniTask<RogueLikeRankingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetRogueLikeOutGameData_003Ed__190 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RogueLikeOutGameDataResponseModel> _003C_003Et__builder;

			private UniTask<RogueLikeOutGameDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetRogueLikeRanking_003Ed__184 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RogueLikeRankingResponseModel> _003C_003Et__builder;

			public int challenge;

			public bool useCache;

			private UniTask<RogueLikeRankingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetShop_003Ed__81 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ShopResponseModel> _003C_003Et__builder;

			private UniTask<ShopResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetTreasureWishList_003Ed__93 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureWishListResponseModel> _003C_003Et__builder;

			private UniTask<TreasureWishListResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetUpdatedRogueLikeMissions_003Ed__195 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RogueLikeMissionDataResponseModel> _003C_003Et__builder;

			private UniTask<RogueLikeMissionDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CGetXigncodeSeed_003Ed__8 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AuthResponseModel> _003C_003Et__builder;

			private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CInitializeJourney_003Ed__33 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<JourneyRewardResponseModel> _003C_003Et__builder;

			private UniTask<JourneyRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CJoinColosseumCustomMatch_003Ed__270 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ColosseumCustomMatchResponseModel> _003C_003Et__builder;

			public string matchId;

			private UniTask<ColosseumCustomMatchResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLeaveClan_003Ed__132 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLeftAccount_003Ed__101 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLinkAccount_003Ed__106 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TransferCodeResponseModel> _003C_003Et__builder;

			public TransferRequestModel requestModel;

			private UniTask<TransferCodeResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLoadCustomPickups_003Ed__202 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<CustomPickupsResponseModel> _003C_003Et__builder;

			public int gachaId;

			private UniTask<CustomPickupsResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLoadRogueLikeData_003Ed__182 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RogueLikeGameDataResponseModel> _003C_003Et__builder;

			public int savedVersion;

			private UniTask<RogueLikeGameDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLogClickNotice_003Ed__25 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public int version;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CLogin_003Ed__2 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AuthResponseModel> _003C_003Et__builder;

			public string cookie;

			public string token;

			private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CMandateClanMaster_003Ed__148 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ClanRoleRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CModifyClanIntro_003Ed__144 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ModifyClanRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CModifyClanJoinType_003Ed__143 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ModifyClanRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CModifyClanMark_003Ed__141 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ModifyClanRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CModifyClanName_003Ed__142 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ModifyClanRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CModifyClanNotice_003Ed__145 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ModifyClanRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CModifyClanTag_003Ed__146 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ModifyClanRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003COpenCatalystBox_003Ed__117 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ArtifactResultResponseModel> _003C_003Et__builder;

			public CatalystBoxRequestModel model;

			private UniTask<ArtifactResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPingColosseumMatchingResult_003Ed__267 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ColosseumMatchResponseModel> _003C_003Et__builder;

			private UniTask<ColosseumMatchResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CProcessRequestJoinClan_003Ed__136 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ProcessRequestJoinClanModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CProgressTutorialMission_003Ed__24 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public int number;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPvPMatching_003Ed__48 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PvPMatchResponseModel> _003C_003Et__builder;

			public ArenaMatchingRequestModel model;

			private UniTask<PvPMatchResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPvPReceiveReward_003Ed__50 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PvPReceiveRewardResponseModel> _003C_003Et__builder;

			public PvPReceiveRewardRequestModel model;

			private UniTask<PvPReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CPvpDormantProgress_003Ed__53 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CReceiveBonusReward_003Ed__125 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SeasonPassReceiveRewardResponseModel> _003C_003Et__builder;

			public SeasonPassReceiveRewardRequestModel model;

			private UniTask<SeasonPassReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CReceiveInvasionReward_003Ed__263 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ReceiveInvasionRewardResponseModel> _003C_003Et__builder;

			public ReceiveInvasionRewardRequestModel model;

			private UniTask<ReceiveInvasionRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CReceiveInvasionRewardAll_003Ed__262 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ReceiveInvasionRewardResponseModel> _003C_003Et__builder;

			public ReceiveInvasionRewardAllRequestModel model;

			private UniTask<ReceiveInvasionRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CReceivePost_003Ed__100 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PostReceiveResponseModel> _003C_003Et__builder;

			public PostReceiveRequestModel requestModel;

			private UniTask<PostReceiveResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CReceiveReward_003Ed__124 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SeasonPassReceiveRewardResponseModel> _003C_003Et__builder;

			public SeasonPassReceiveRewardRequestModel model;

			private UniTask<SeasonPassReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CReceiveSeasonPassAllRewards_003Ed__123 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SeasonPassReceiveRewardResponseModel> _003C_003Et__builder;

			public SeasonPassReceiveRewardRequestModel model;

			private UniTask<SeasonPassReceiveRewardResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRecoverHeart_003Ed__16 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerDataResponseModel> _003C_003Et__builder;

			private UniTask<PlayerDataResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRefreshClanChat_003Ed__152 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanChatResponseModel> _003C_003Et__builder;

			private UniTask<ClanChatResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRefreshDailyShop_003Ed__87 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ShopResponseModel> _003C_003Et__builder;

			private UniTask<ShopResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRefreshTerritoryBuilding_003Ed__207 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryRefreshBuildingResponseModel> _003C_003Et__builder;

			public TerritoryRefreshBuildingRequestModel model;

			private UniTask<TerritoryRefreshBuildingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRegister_003Ed__3 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AuthResponseModel> _003C_003Et__builder;

			public RegisterRequestModel requestModel;

			private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRegisterPvPDeckPool_003Ed__291 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRemoveFromDeck_003Ed__75 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DeckResponseModel> _003C_003Et__builder;

			public DeckRequestModel requestModel;

			private UniTask<DeckResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRemoveFromRestoreNeededIAPs_003Ed__89 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public RemoveFromRestoreNeededIAPsRequestModel requestModel;

			private UniTask<BuyResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRemoveTerritoryBuilding_003Ed__210 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryCurrencyResponseModel> _003C_003Et__builder;

			public int posIndex;

			private UniTask<TerritoryCurrencyResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CReplaceTerritoryBuilding_003Ed__211 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public TerritoryReplaceBuildingRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRequestColosseumMatchmaking_003Ed__234 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public ColosseumMatchRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRequestJoinClan_003Ed__135 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanResponseModel> _003C_003Et__builder;

			public ClanRequestModel model;

			private UniTask<ClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRerollPassMission_003Ed__127 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<RerollPassMissionResponseModel> _003C_003Et__builder;

			public RerollPassMissionRequestModel model;

			private UniTask<RerollPassMissionResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CResetAllRogueLikeMission_003Ed__200 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CResetBuildingPoint_003Ed__30 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<BuildingResponseModel> _003C_003Et__builder;

			public BuildingRequestModel model;

			private UniTask<BuildingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CResetLevelSync_003Ed__217 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryAssignUnitsResponseModel> _003C_003Et__builder;

			public ResetTerritoryLevelSyncTimerRequestModel model;

			private UniTask<TerritoryAssignUnitsResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CResetRogueLikeMission_003Ed__199 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public int missionId;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRogueLikeCanReviveByAd_003Ed__187 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CRogueLikeRevive_003Ed__186 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public bool useReviveCoupon;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSaveBuilding_003Ed__31 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<BuildingResponseModel> _003C_003Et__builder;

			public BuildingRequestModel requestModel;

			private UniTask<BuildingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSaveColosseumRoundData_003Ed__271 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public SaveColosseumRoundDataRequestModel model;

			public string gameId;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSaveCompleteColosseumRoundData_003Ed__272 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public SaveCompleteColosseumRoundDataRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSaveCustomPickups_003Ed__201 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public CustomPickupsRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSaveRogueLikeData_003Ed__181 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public RogueLikeGameDataRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSaveTreasureWishList_003Ed__92 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public TreasureWishListRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSearchClan_003Ed__137 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SearchClanResponseModel> _003C_003Et__builder;

			public SearchClanRequestModel model;

			private UniTask<SearchClanResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetAllCardPotential_003Ed__78 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DeckResponseModel> _003C_003Et__builder;

			public SetCardPotentialRequestModel requestModel;

			private UniTask<DeckResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetCardPotential_003Ed__79 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DeckResponseModel> _003C_003Et__builder;

			public SetCardPotentialRequestModel requestModel;

			private UniTask<DeckResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetClanRaidDeckName_003Ed__163 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanRaidDeckInfoResponseModel> _003C_003Et__builder;

			public int deckIdx;

			public string deckName;

			private UniTask<ClanRaidDeckInfoResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetClanRaidDeckPreset_003Ed__160 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public ClanRaidDeckRequestModel requestModel;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetClanRaidSupportUnit_003Ed__164 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ClanRaidSupporterSettingResponseModel> _003C_003Et__builder;

			public int unitId;

			private UniTask<ClanRaidSupporterSettingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetDeck_003Ed__76 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DeckResponseModel> _003C_003Et__builder;

			public DeckRequestModel requestModel;

			private UniTask<DeckResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetDeckSlotName_003Ed__80 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<DeckResponseModel> _003C_003Et__builder;

			public DeckNameRequestModel requestModel;

			private UniTask<DeckResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetFlag_003Ed__175 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public FlagRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSetNameTag_003Ed__177 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public NameTagRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CShakeHand_003Ed__6 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CStartRogueLikeFloor_003Ed__188 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<StartRogueLikeFloorResponseModel> _003C_003Et__builder;

			public StartRogueLikeFloorRequestModel model;

			private UniTask<StartRogueLikeFloorResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CStoreTerritoryBuilding_003Ed__208 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public int posIndex;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CSwapAssignedUnitsFromBuildings_003Ed__214 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<SwapAssignedHeroesFromBuildingsResponseModel> _003C_003Et__builder;

			public SwapAssignedUnitsFromBuildingsRequestModel model;

			private UniTask<SwapAssignedHeroesFromBuildingsResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryAddCore_003Ed__275 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryAddLabor_003Ed__274 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryAlchemy_003Ed__222 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryAlchemyResponseModel> _003C_003Et__builder;

			public TerritoryAlchemyRequestModel model;

			private UniTask<TerritoryAlchemyResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryBuildingSetTime_003Ed__276 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryBuyTradeShopItem_003Ed__229 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryBuyTradeShopItemResponseModel> _003C_003Et__builder;

			public TerritoryBuyTradeShopItemRequestModel model;

			private UniTask<TerritoryBuyTradeShopItemResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryClearTradeShopBuyLimit_003Ed__282 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryCollectLabor_003Ed__215 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryCollectLaborResponseModel> _003C_003Et__builder;

			public int amount;

			private UniTask<TerritoryCollectLaborResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryEndHunting_003Ed__219 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryEndHuntingResponseModel> _003C_003Et__builder;

			public TerritoryHuntingRequestModel model;

			private UniTask<TerritoryEndHuntingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryHuntingSetId_003Ed__278 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryHuntingSetTime_003Ed__277 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryRecoverLabor_003Ed__205 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryRecoverLaborResponseModel> _003C_003Et__builder;

			private UniTask<TerritoryRecoverLaborResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryRefreshFlagTime_003Ed__279 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryRefreshHunting_003Ed__220 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryHuntingRefreshResponseModel> _003C_003Et__builder;

			private UniTask<TerritoryHuntingRefreshResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritorySetLastLaborAt_003Ed__280 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritorySetLastTokenAt_003Ed__281 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritorySetLevelSyncUntilAt_003Ed__283 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryStartHunting_003Ed__218 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryStartHuntingResponseModel> _003C_003Et__builder;

			public TerritoryHuntingRequestModel model;

			private UniTask<TerritoryStartHuntingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryTycoonCheckAttendance_003Ed__226 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryTycoonCollectSkinToken_003Ed__227 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryTycoonTokenResponseModel> _003C_003Et__builder;

			public int amount;

			private UniTask<TerritoryTycoonTokenResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryTycoonFetchTokenEventToken_003Ed__225 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryTycoonTokenResponseModel> _003C_003Et__builder;

			private UniTask<TerritoryTycoonTokenResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryTycoonFirework_003Ed__228 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryTycoonFireworkResponseModel> _003C_003Et__builder;

			private UniTask<TerritoryTycoonFireworkResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTerritoryTycoonRecoverSeasonalEventToken_003Ed__224 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PlayerTerritoryTycoonResponseModel> _003C_003Et__builder;

			private UniTask<PlayerTerritoryTycoonResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestAccessoryCoolTime_003Ed__308 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AccessoryResultResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestAccessoryStatSave_003Ed__309 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AccessoryResultResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestAddAccessories_003Ed__306 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AccessoryResultResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestAddAllConsumable_003Ed__307 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestAddTreasure_003Ed__304 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestArenaClearWinRewardReceived_003Ed__61 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestArenaSetWinCount_003Ed__60 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestClearPvPDeckPool_003Ed__58 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestClearStarterMission_003Ed__319 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestColosseumFreeMatching_003Ed__266 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ColosseumMatchResponseModel> _003C_003Et__builder;

			public int botNum;

			private UniTask<ColosseumMatchResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestColosseumSinglePlay_003Ed__265 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ColosseumMatchResponseModel> _003C_003Et__builder;

			private UniTask<ColosseumMatchResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestPvPMatching_003Ed__49 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PvPMatchResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestRemovePvPDeck_003Ed__59 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestResetCustomGrowthPackage_003Ed__297 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestResetDailyShopRefreshCount_003Ed__298 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestResetDeckBattleCount_003Ed__171 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestResetDeckSetCount_003Ed__170 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestResetFourthYearEvent_003Ed__311 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<FourthYearEventResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestResetFourthYearEventPass_003Ed__312 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<FourthYearEventResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestResetLastLogin_003Ed__294 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestResetRemainBattleCount_003Ed__167 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestResetStarterMission_003Ed__320 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestSetArtifactPolishPoint_003Ed__300 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestSetBossKillCount_003Ed__169 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestSetClanGoldBonus_003Ed__296 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestSetClanScore_003Ed__295 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestSetDormantTimeLeft_003Ed__57 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<PvPInfoResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestSetFourthYearDay_003Ed__313 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<FourthYearEventResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestSetGoldBonus_003Ed__168 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestSetJourneyRewardRemainTime_003Ed__310 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<JourneyRewardResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestSetLastLogined_003Ed__301 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestSetReturnAttendanceDay_003Ed__302 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestSetReturnEventEnd_003Ed__303 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTestTreasureCoolTime_003Ed__305 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTreasureAddExp_003Ed__251 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

			public TreasureRequestModel model;

			private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTreasureDismantle_003Ed__249 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

			public TreasureDismantleRequestModel model;

			private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTreasureEquip_003Ed__246 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

			public TreasureRequestModel model;

			public bool useTicket;

			private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTreasureEquipTutorial_003Ed__247 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

			public TreasureRequestModel model;

			private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTreasureOvercome_003Ed__245 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

			public TreasureRequestModel model;

			private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTreasureReleaseEquip_003Ed__248 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

			public TreasureRequestModel model;

			private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CTreasureSetState_003Ed__250 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TreasureResultResponseModel> _003C_003Et__builder;

			public TreasureRequestModel model;

			private UniTask<TreasureResultResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUnStoreTerritoryBuilding_003Ed__209 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryBuildingResponseModel> _003C_003Et__builder;

			public int buildingId;

			public int posIndex;

			private UniTask<TerritoryBuildingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUpdateRogueLikeClearCount_003Ed__197 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public int clearCount;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUpdateRogueLikeMissionClearCount_003Ed__198 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public int clearCount;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUpdateRogueLikePlayCount_003Ed__196 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public int playCount;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUpgradeCard_003Ed__64 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<CardWithCandiesResponseModel> _003C_003Et__builder;

			public UpgradeCardRequestModel upgradeCardRequestModel;

			private UniTask<CardWithCandiesResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUpgradeCardPotentialTier_003Ed__72 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<CardWithCandiesResponseModel> _003C_003Et__builder;

			public UpgradeCardRequestModel upgradeCardRequestModel;

			private UniTask<CardWithCandiesResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUpgradeImmediatelyTerritoryBuilding_003Ed__223 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryBuildBuildingResponseModel> _003C_003Et__builder;

			public int posIndex;

			public int territoryType;

			private UniTask<TerritoryBuildBuildingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUpgradeTerritoryBuilding_003Ed__212 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<TerritoryBuildBuildingResponseModel> _003C_003Et__builder;

			public int posIndex;

			private UniTask<TerritoryBuildBuildingResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUseCandy_003Ed__71 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<CardWithCandiesResponseModel> _003C_003Et__builder;

			public UpgradeCardRequestModel model;

			private UniTask<CardWithCandiesResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUseCoupon_003Ed__172 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public CouponRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUseInventory_003Ed__179 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<UseInventoryResponseModel> _003C_003Et__builder;

			public UseInventoryRequestModel model;

			private UniTask<UseInventoryResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUseRewardBoxInventoryItem_003Ed__180 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<UseRewardBoxInventoryItemResponseModel> _003C_003Et__builder;

			public UseRewardBoxInventoryItemRequestModel model;

			private UniTask<UseRewardBoxInventoryItemResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUseUnitExpItem_003Ed__67 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public UseUnitExpItemRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUseUnitSoulItem_003Ed__68 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public UseUnitExpItemRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUseUnitSoulItemToExp_003Ed__70 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public UseUnitExpItemRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CUseUnitSoulToExp_003Ed__69 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public UseUnitExpItemRequestModel model;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CXigncodeReport_003Ed__20 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<ResponseModel> _003C_003Et__builder;

			public string code;

			public string info;

			private UniTask<ResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		[StructLayout(3)]
		[CompilerGenerated]
		private struct _003CXigncodeValidCheck_003Ed__9 : IAsyncStateMachine
		{
			public int _003C_003E1__state;

			public AsyncUniTaskMethodBuilder<AuthResponseModel> _003C_003Et__builder;

			public string cookie;

			private UniTask<AuthResponseModel>.Awaiter _003C_003Eu__1;

			private void MoveNext()
			{
			}

			void IAsyncStateMachine.MoveNext()
			{
				//ILSpy generated this explicit interface implementation from .override directive in MoveNext
				this.MoveNext();
			}

			[DebuggerHidden]
			private void SetStateMachine(IAsyncStateMachine stateMachine)
			{
			}

			void IAsyncStateMachine.SetStateMachine(IAsyncStateMachine stateMachine)
			{
				//ILSpy generated this explicit interface implementation from .override directive in SetStateMachine
				this.SetStateMachine(stateMachine);
			}
		}

		public static string accessToken;

		private const string INFRA_SERVER_URL = "http://10.0.1.110:8081";

		[AsyncStateMachine(typeof(_003CAuth_003Ed__1))]
		public static UniTask<AuthResponseModel> Auth(string id, string cookie = "")
		{
			return default(UniTask<AuthResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CLogin_003Ed__2))]
		public static UniTask<AuthResponseModel> Login(string token, string cookie = "")
		{
			return default(UniTask<AuthResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRegister_003Ed__3))]
		public static UniTask<AuthResponseModel> Register(RegisterRequestModel requestModel)
		{
			return default(UniTask<AuthResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCheckUsePatch_003Ed__4))]
		public static UniTask<ResponseModel> CheckUsePatch(string platform)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetPatchFolder_003Ed__5))]
		public static UniTask<PatchFolderResponseModel> GetPatchFolder()
		{
			return default(UniTask<PatchFolderResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CShakeHand_003Ed__6))]
		public static UniTask<ResponseModel> ShakeHand()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCheckPatchVersion_003Ed__7))]
		public static UniTask<ResponseModel> CheckPatchVersion(string version)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetXigncodeSeed_003Ed__8))]
		public static UniTask<AuthResponseModel> GetXigncodeSeed()
		{
			return default(UniTask<AuthResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CXigncodeValidCheck_003Ed__9))]
		public static UniTask<AuthResponseModel> XigncodeValidCheck(string cookie)
		{
			return default(UniTask<AuthResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetPlayerInfo_003Ed__10))]
		public static UniTask<PlayerDataResponseModel> GetPlayerInfo()
		{
			return default(UniTask<PlayerDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetPlayerTutorialStatus_003Ed__11))]
		public static UniTask<KeyValuesResponseModel> GetPlayerTutorialStatus()
		{
			return default(UniTask<KeyValuesResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetPlayerCurrencies_003Ed__12))]
		public static UniTask<PlayerCurrenciesResponseModel> GetPlayerCurrencies()
		{
			return default(UniTask<PlayerCurrenciesResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetPlayerDailyConsumedCurrencies_003Ed__13))]
		public static UniTask<PlayerCurrenciesResponseModel> GetPlayerDailyConsumedCurrencies()
		{
			return default(UniTask<PlayerCurrenciesResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetLoginSceneIllustData_003Ed__14))]
		public static UniTask<LoginSceneIllustDataResponseModel> GetLoginSceneIllustData()
		{
			return default(UniTask<LoginSceneIllustDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CException_003Ed__15))]
		public static UniTask<ResponseModel> Exception(string msg, string type)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRecoverHeart_003Ed__16))]
		public static UniTask<PlayerDataResponseModel> RecoverHeart()
		{
			return default(UniTask<PlayerDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetOtherPlayerInfo_003Ed__17))]
		public static UniTask<OtherPlayerDataResponseModel> GetOtherPlayerInfo(int targetId)
		{
			return default(UniTask<OtherPlayerDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CChangeProfileIconId_003Ed__18))]
		public static UniTask<ResponseModel> ChangeProfileIconId(ChangeProfileIconRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetDailyAttendanceEvents_003Ed__19))]
		public static UniTask<DailyAttendanceEventsResponseModel> GetDailyAttendanceEvents()
		{
			return default(UniTask<DailyAttendanceEventsResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CXigncodeReport_003Ed__20))]
		public static UniTask<ResponseModel> XigncodeReport(string code, string info)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCustomEvent_003Ed__21))]
		public static UniTask<PlayerDataResponseModel> CustomEvent(int id)
		{
			return default(UniTask<PlayerDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCompleteKingGakReturnEvent_003Ed__22))]
		public static UniTask<ResponseModel> CompleteKingGakReturnEvent()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCompleteTutorial_003Ed__23))]
		public static UniTask<ResponseModel> CompleteTutorial(string statusKey)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CProgressTutorialMission_003Ed__24))]
		public static UniTask<ResponseModel> ProgressTutorialMission(int number)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CLogClickNotice_003Ed__25))]
		public static UniTask<ResponseModel> LogClickNotice(int version)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAddInventoryCount_003Ed__26))]
		public static UniTask<PlayerInventoryCountResponseModel> AddInventoryCount(InventoryCountRequestModel model)
		{
			return default(UniTask<PlayerInventoryCountResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetGameSkipInformation_003Ed__27))]
		public static UniTask<GameSkipInfoResponseModel> GetGameSkipInformation()
		{
			return default(UniTask<GameSkipInfoResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetBuildingInfo_003Ed__28))]
		public static UniTask<BuildingResponseModel> GetBuildingInfo()
		{
			return default(UniTask<BuildingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CBuyBuildingPoint_003Ed__29))]
		public static UniTask<BuildingResponseModel> BuyBuildingPoint()
		{
			return default(UniTask<BuildingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CResetBuildingPoint_003Ed__30))]
		public static UniTask<BuildingResponseModel> ResetBuildingPoint(BuildingRequestModel model)
		{
			return default(UniTask<BuildingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSaveBuilding_003Ed__31))]
		public static UniTask<BuildingResponseModel> SaveBuilding(BuildingRequestModel requestModel)
		{
			return default(UniTask<BuildingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetJourneyReward_003Ed__32))]
		public static UniTask<JourneyRewardResponseModel> GetJourneyReward(JourneyRewardRequestModel requestModel)
		{
			return default(UniTask<JourneyRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CInitializeJourney_003Ed__33))]
		public static UniTask<JourneyRewardResponseModel> InitializeJourney()
		{
			return default(UniTask<JourneyRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetPlayerFourthYearEvent_003Ed__34))]
		public static UniTask<FourthYearEventResponseModel> GetPlayerFourthYearEvent()
		{
			return default(UniTask<FourthYearEventResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetFourthYearEventPrevPassReward_003Ed__35))]
		public static UniTask<FourthYearEventReceiveRewardResponseModel> GetFourthYearEventPrevPassReward()
		{
			return default(UniTask<FourthYearEventReceiveRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetFourthYearEventDailyPassReward_003Ed__36))]
		public static UniTask<FourthYearEventReceiveRewardResponseModel> GetFourthYearEventDailyPassReward()
		{
			return default(UniTask<FourthYearEventReceiveRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetFourthYearEventDailyAttendanceReward_003Ed__37))]
		public static UniTask<FourthYearEventReceiveRewardResponseModel> GetFourthYearEventDailyAttendanceReward(int day)
		{
			return default(UniTask<FourthYearEventReceiveRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCanEarlyAccessMode_003Ed__38))]
		public static UniTask<ResponseModel> CanEarlyAccessMode()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCheckEarlyAccessModeCode_003Ed__39))]
		public static UniTask<ResponseModel> CheckEarlyAccessModeCode(string code)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGameStart_003Ed__40))]
		public static UniTask<GameStartResponseModel> GameStart(GameStartRequestModel requestModel)
		{
			return default(UniTask<GameStartResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGameComplete_003Ed__41))]
		public static UniTask<GameResponseModel> GameComplete(GameCompleteRequestModel requestModel)
		{
			return default(UniTask<GameResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGameSkip_003Ed__42))]
		public static UniTask<GameResponseModel> GameSkip(GameSkipRequestModel requestModel)
		{
			return default(UniTask<GameResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGameRevive_003Ed__43))]
		public static UniTask<GameResponseModel> GameRevive(bool useReviveCoupon)
		{
			return default(UniTask<GameResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGameAdBonus_003Ed__44))]
		public static UniTask<ResponseModel> GameAdBonus(GameAdBonusRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetRanking_003Ed__45))]
		public static UniTask<RankingResponseModel> GetRanking(int theme, bool useCache = true)
		{
			return default(UniTask<RankingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetEventMode_003Ed__46))]
		public static UniTask<EventModeResponseModel> GetEventMode()
		{
			return default(UniTask<EventModeResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchPvPInfo_003Ed__47))]
		public static UniTask<PvPInfoResponseModel> FetchPvPInfo()
		{
			return default(UniTask<PvPInfoResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CPvPMatching_003Ed__48))]
		public static UniTask<PvPMatchResponseModel> PvPMatching(ArenaMatchingRequestModel model)
		{
			return default(UniTask<PvPMatchResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestPvPMatching_003Ed__49))]
		public static UniTask<PvPMatchResponseModel> TestPvPMatching()
		{
			return default(UniTask<PvPMatchResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CPvPReceiveReward_003Ed__50))]
		public static UniTask<PvPReceiveRewardResponseModel> PvPReceiveReward(PvPReceiveRewardRequestModel model)
		{
			return default(UniTask<PvPReceiveRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetPvPRanking_003Ed__51))]
		public static UniTask<PvPRankingResponseModel> GetPvPRanking(int season, bool useCache = true)
		{
			return default(UniTask<PvPRankingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchPvPLatestGamesLog_003Ed__52))]
		public static UniTask<PvPLogResponseModel> FetchPvPLatestGamesLog()
		{
			return default(UniTask<PvPLogResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CPvpDormantProgress_003Ed__53))]
		public static UniTask<ResponseModel> PvpDormantProgress()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetPvPLeagueRanking_003Ed__54))]
		public static UniTask<LeagueRankingResponseModel> GetPvPLeagueRanking(int leagueSeason, bool useCache = false)
		{
			return default(UniTask<LeagueRankingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetPvPHallOfFame_003Ed__55))]
		public static UniTask<PvPRankingResponseModel> GetPvPHallOfFame(int leagueSeason, bool useCache = false)
		{
			return default(UniTask<PvPRankingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetArenaWinReward_003Ed__56))]
		public static UniTask<ArenaWinRewardResponseModel> GetArenaWinReward(ArenaWinRewardRequestModel model)
		{
			return default(UniTask<ArenaWinRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestSetDormantTimeLeft_003Ed__57))]
		public static UniTask<PvPInfoResponseModel> TestSetDormantTimeLeft(int minuteLeft)
		{
			return default(UniTask<PvPInfoResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestClearPvPDeckPool_003Ed__58))]
		public static UniTask<ResponseModel> TestClearPvPDeckPool()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestRemovePvPDeck_003Ed__59))]
		public static UniTask<ResponseModel> TestRemovePvPDeck(int deckId)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestArenaSetWinCount_003Ed__60))]
		public static UniTask<ResponseModel> TestArenaSetWinCount(int count)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestArenaClearWinRewardReceived_003Ed__61))]
		public static UniTask<ResponseModel> TestArenaClearWinRewardReceived()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetAllCards_003Ed__62))]
		public static UniTask<CardListResponseModel> GetAllCards()
		{
			return default(UniTask<CardListResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetCard_003Ed__63))]
		public static UniTask<CardResponseModel> GetCard(int cardId)
		{
			return default(UniTask<CardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUpgradeCard_003Ed__64))]
		public static UniTask<CardWithCandiesResponseModel> UpgradeCard(UpgradeCardRequestModel upgradeCardRequestModel)
		{
			return default(UniTask<CardWithCandiesResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CBuySkin_003Ed__65))]
		public static UniTask<BuySkinResponseModel> BuySkin(BuySkinRequestModel model)
		{
			return default(UniTask<BuySkinResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CEquipSkin_003Ed__66))]
		public static UniTask<ResponseModel> EquipSkin(EquipSkinRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUseUnitExpItem_003Ed__67))]
		public static UniTask<ResponseModel> UseUnitExpItem(UseUnitExpItemRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUseUnitSoulItem_003Ed__68))]
		public static UniTask<ResponseModel> UseUnitSoulItem(UseUnitExpItemRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUseUnitSoulToExp_003Ed__69))]
		public static UniTask<ResponseModel> UseUnitSoulToExp(UseUnitExpItemRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUseUnitSoulItemToExp_003Ed__70))]
		public static UniTask<ResponseModel> UseUnitSoulItemToExp(UseUnitExpItemRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUseCandy_003Ed__71))]
		public static UniTask<CardWithCandiesResponseModel> UseCandy(UpgradeCardRequestModel model)
		{
			return default(UniTask<CardWithCandiesResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUpgradeCardPotentialTier_003Ed__72))]
		public static UniTask<CardWithCandiesResponseModel> UpgradeCardPotentialTier(UpgradeCardRequestModel upgradeCardRequestModel)
		{
			return default(UniTask<CardWithCandiesResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetDeck_003Ed__73))]
		public static UniTask<DeckResponseModel> GetDeck()
		{
			return default(UniTask<DeckResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAddToDeck_003Ed__74))]
		public static UniTask<DeckResponseModel> AddToDeck(DeckRequestModel requestModel)
		{
			return default(UniTask<DeckResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRemoveFromDeck_003Ed__75))]
		public static UniTask<DeckResponseModel> RemoveFromDeck(DeckRequestModel requestModel)
		{
			return default(UniTask<DeckResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSetDeck_003Ed__76))]
		public static UniTask<DeckResponseModel> SetDeck(DeckRequestModel requestModel)
		{
			return default(UniTask<DeckResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CBuyDeckSlot_003Ed__77))]
		public static UniTask<ResponseModel> BuyDeckSlot(DeckRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSetAllCardPotential_003Ed__78))]
		public static UniTask<DeckResponseModel> SetAllCardPotential(SetCardPotentialRequestModel requestModel)
		{
			return default(UniTask<DeckResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSetCardPotential_003Ed__79))]
		public static UniTask<DeckResponseModel> SetCardPotential(SetCardPotentialRequestModel requestModel)
		{
			return default(UniTask<DeckResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSetDeckSlotName_003Ed__80))]
		public static UniTask<DeckResponseModel> SetDeckSlotName(DeckNameRequestModel requestModel)
		{
			return default(UniTask<DeckResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetShop_003Ed__81))]
		public static UniTask<ShopResponseModel> GetShop()
		{
			return default(UniTask<ShopResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CBuyShopItem_003Ed__82))]
		public static UniTask<BuyResponseModel> BuyShopItem(BuyRequestModel requestModel)
		{
			return default(UniTask<BuyResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCanIAP_003Ed__83))]
		public static UniTask<ResponseModel> CanIAP()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCanIAP_New_003Ed__84))]
		public static UniTask<ResponseModel> CanIAP_New(IAPBuyRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCanIAPAndAddToRestoreNeededIAPs_003Ed__85))]
		public static UniTask<ResponseModel> CanIAPAndAddToRestoreNeededIAPs(CanIAPAndAddToRestoreNeededIAPsRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CBuyIAP_003Ed__86))]
		public static UniTask<BuyResponseModel> BuyIAP(IAPBuyRequestModel requestModel)
		{
			return default(UniTask<BuyResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRefreshDailyShop_003Ed__87))]
		public static UniTask<ShopResponseModel> RefreshDailyShop()
		{
			return default(UniTask<ShopResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetRestoreNeededIAPs_003Ed__88))]
		public static UniTask<GetRestoreNeededIAPsResponseModel> GetRestoreNeededIAPs()
		{
			return default(UniTask<GetRestoreNeededIAPsResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRemoveFromRestoreNeededIAPs_003Ed__89))]
		public static UniTask<ResponseModel> RemoveFromRestoreNeededIAPs(RemoveFromRestoreNeededIAPsRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CChoicePackageUnit_003Ed__90))]
		public static UniTask<ResponseModel> ChoicePackageUnit(ChoicePackageUnitRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CChoiceTreasurePickupCeil_003Ed__91))]
		public static UniTask<ResponseModel> ChoiceTreasurePickupCeil(ChoiceTreasurePickupCeilRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSaveTreasureWishList_003Ed__92))]
		public static UniTask<ResponseModel> SaveTreasureWishList(TreasureWishListRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetTreasureWishList_003Ed__93))]
		public static UniTask<TreasureWishListResponseModel> GetTreasureWishList()
		{
			return default(UniTask<TreasureWishListResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCheckTreasureWishListValid_003Ed__94))]
		public static UniTask<ResponseModel> CheckTreasureWishListValid(TreasureCheckWishListValidRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetAllMissions_003Ed__95))]
		public static UniTask<MissionResponseModel> GetAllMissions()
		{
			return default(UniTask<MissionResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCheckMission_003Ed__96))]
		public static UniTask<MissionResponseModel> CheckMission(List<string> condTypes)
		{
			return default(UniTask<MissionResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetMissionReward_003Ed__97))]
		public static UniTask<MissionRewardResponseModel> GetMissionReward(MissionRewardRequestModel requestModel)
		{
			return default(UniTask<MissionRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetMissionGoalReward_003Ed__98))]
		public static UniTask<MissionRewardResponseModel> GetMissionGoalReward()
		{
			return default(UniTask<MissionRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetAllPosts_003Ed__99))]
		public static UniTask<PostResponseModel> GetAllPosts()
		{
			return default(UniTask<PostResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CReceivePost_003Ed__100))]
		public static UniTask<PostReceiveResponseModel> ReceivePost(PostReceiveRequestModel requestModel)
		{
			return default(UniTask<PostReceiveResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CLeftAccount_003Ed__101))]
		public static UniTask<ResponseModel> LeftAccount()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CChangeNickname_003Ed__102))]
		public static UniTask<ResponseModel> ChangeNickname(ChangeNicknameRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAdLog_003Ed__103))]
		public static UniTask<ResponseModel> AdLog(AdRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetAccountTransferCode_003Ed__104))]
		public static UniTask<TransferCodeResponseModel> GetAccountTransferCode()
		{
			return default(UniTask<TransferCodeResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAccountTransfer_003Ed__105))]
		public static UniTask<TransferResponseModel> AccountTransfer(TransferRequestModel requestModel)
		{
			return default(UniTask<TransferResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CLinkAccount_003Ed__106))]
		public static UniTask<TransferCodeResponseModel> LinkAccount(TransferRequestModel requestModel)
		{
			return default(UniTask<TransferCodeResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchArtifactInventory_003Ed__107))]
		public static UniTask<ArtifactInventoryResponseModel> FetchArtifactInventory()
		{
			return default(UniTask<ArtifactInventoryResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactGachaTest_003Ed__108))]
		public static UniTask<ArtifactResultResponseModel> ArtifactGachaTest(TestRequestModel model)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactCrafting_003Ed__109))]
		public static UniTask<ArtifactResultResponseModel> ArtifactCrafting(ArtifactRequestModel model)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactMerge_003Ed__110))]
		public static UniTask<ArtifactResultResponseModel> ArtifactMerge(ArtifactRequestModel model)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactDismantle_003Ed__111))]
		public static UniTask<ArtifactResultResponseModel> ArtifactDismantle(ArtifactDismantleRequestModel model)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactReroll_003Ed__112))]
		public static UniTask<ArtifactResultResponseModel> ArtifactReroll(ArtifactRequestModel model, bool useGold)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactFetchReroll_003Ed__113))]
		public static UniTask<ArtifactResultResponseModel> ArtifactFetchReroll()
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactSetReroll_003Ed__114))]
		public static UniTask<ArtifactResultResponseModel> ArtifactSetReroll(ArtifactRequestModel model)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactPolish_003Ed__115))]
		public static UniTask<ArtifactResultResponseModel> ArtifactPolish(ArtifactRequestModel model)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactPolish_ReplaceOptionSlotIdx_003Ed__116))]
		public static UniTask<ArtifactResultResponseModel> ArtifactPolish_ReplaceOptionSlotIdx(ArtifactRequestModel model)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003COpenCatalystBox_003Ed__117))]
		public static UniTask<ArtifactResultResponseModel> OpenCatalystBox(CatalystBoxRequestModel model)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactEquip_003Ed__118))]
		public static UniTask<ArtifactResultResponseModel> ArtifactEquip(ArtifactRequestModel model)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactSetFavorites_003Ed__119))]
		public static UniTask<ArtifactResultResponseModel> ArtifactSetFavorites(ArtifactRequestModel model)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CArtifactDevOptionSet_003Ed__120))]
		public static UniTask<ArtifactResultResponseModel> ArtifactDevOptionSet(ArtifactDevOptionSetRequestModel model)
		{
			return default(UniTask<ArtifactResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchSeasonPass_003Ed__121))]
		public static UniTask<SeasonPassResponseModel> FetchSeasonPass()
		{
			return default(UniTask<SeasonPassResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CBuyLevel_003Ed__122))]
		public static UniTask<SeasonPassBuyLevelResponseModel> BuyLevel()
		{
			return default(UniTask<SeasonPassBuyLevelResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CReceiveSeasonPassAllRewards_003Ed__123))]
		public static UniTask<SeasonPassReceiveRewardResponseModel> ReceiveSeasonPassAllRewards(SeasonPassReceiveRewardRequestModel model)
		{
			return default(UniTask<SeasonPassReceiveRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CReceiveReward_003Ed__124))]
		public static UniTask<SeasonPassReceiveRewardResponseModel> ReceiveReward(SeasonPassReceiveRewardRequestModel model)
		{
			return default(UniTask<SeasonPassReceiveRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CReceiveBonusReward_003Ed__125))]
		public static UniTask<SeasonPassReceiveRewardResponseModel> ReceiveBonusReward(SeasonPassReceiveRewardRequestModel model)
		{
			return default(UniTask<SeasonPassReceiveRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchSeasonPassEventBooster_003Ed__126))]
		public static UniTask<SeasonPassEventBoosterResponseModel> FetchSeasonPassEventBooster()
		{
			return default(UniTask<SeasonPassEventBoosterResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRerollPassMission_003Ed__127))]
		public static UniTask<RerollPassMissionResponseModel> RerollPassMission(RerollPassMissionRequestModel model)
		{
			return default(UniTask<RerollPassMissionResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchClan_003Ed__128))]
		public static UniTask<ClanResponseModel> FetchClan()
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchOtherClan_003Ed__129))]
		public static UniTask<ClanResponseModel> FetchOtherClan(ClanRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCreateClan_003Ed__130))]
		public static UniTask<CreateClanResponseModel> CreateClan(CreateClanRequestModel model)
		{
			return default(UniTask<CreateClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CClanNameCheck_003Ed__131))]
		public static UniTask<ClanResponseModel> ClanNameCheck(CreateClanRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CLeaveClan_003Ed__132))]
		public static UniTask<ClanResponseModel> LeaveClan()
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CBanClanMember_003Ed__133))]
		public static UniTask<ClanResponseModel> BanClanMember(ClanRoleRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CDeleteClan_003Ed__134))]
		public static UniTask<ClanResponseModel> DeleteClan()
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRequestJoinClan_003Ed__135))]
		public static UniTask<ClanResponseModel> RequestJoinClan(ClanRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CProcessRequestJoinClan_003Ed__136))]
		public static UniTask<ClanResponseModel> ProcessRequestJoinClan(ProcessRequestJoinClanModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSearchClan_003Ed__137))]
		public static UniTask<SearchClanResponseModel> SearchClan(SearchClanRequestModel model)
		{
			return default(UniTask<SearchClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CClanChat_003Ed__138))]
		public static UniTask<ClanChatResponseModel> ClanChat(ClanChatRequestModel model)
		{
			return default(UniTask<ClanChatResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CClanRequestSupport_003Ed__139))]
		public static UniTask<ClanResponseModel> ClanRequestSupport(ClanRequestSupportModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CClanSupport_003Ed__140))]
		public static UniTask<ClanSupportResponseModel> ClanSupport(ClanChatSeqIdRequestModel model, bool all)
		{
			return default(UniTask<ClanSupportResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CModifyClanMark_003Ed__141))]
		public static UniTask<ClanResponseModel> ModifyClanMark(ModifyClanRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CModifyClanName_003Ed__142))]
		public static UniTask<ClanResponseModel> ModifyClanName(ModifyClanRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CModifyClanJoinType_003Ed__143))]
		public static UniTask<ClanResponseModel> ModifyClanJoinType(ModifyClanRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CModifyClanIntro_003Ed__144))]
		public static UniTask<ClanResponseModel> ModifyClanIntro(ModifyClanRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CModifyClanNotice_003Ed__145))]
		public static UniTask<ClanResponseModel> ModifyClanNotice(ModifyClanRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CModifyClanTag_003Ed__146))]
		public static UniTask<ClanResponseModel> ModifyClanTag(ModifyClanRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CChangeClanMaster_003Ed__147))]
		public static UniTask<ClanResponseModel> ChangeClanMaster(ClanRoleRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CMandateClanMaster_003Ed__148))]
		public static UniTask<ClanResponseModel> MandateClanMaster(ClanRoleRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CChangeClanMemberRole_003Ed__149))]
		public static UniTask<ClanResponseModel> ChangeClanMemberRole(ClanRoleRequestModel model)
		{
			return default(UniTask<ClanResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CChangeClanRoleName_003Ed__150))]
		public static UniTask<ResponseModel> ChangeClanRoleName(ChangeClanRoleNameRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CDeleteClanChat_003Ed__151))]
		public static UniTask<ClanChatResponseModel> DeleteClanChat(ClanChatSeqIdRequestModel model)
		{
			return default(UniTask<ClanChatResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRefreshClanChat_003Ed__152))]
		public static UniTask<ClanChatResponseModel> RefreshClanChat()
		{
			return default(UniTask<ClanChatResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetCurrentSeq_003Ed__153))]
		public static UniTask<ClanSeqResponseModel> GetCurrentSeq()
		{
			return default(UniTask<ClanSeqResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchChat_003Ed__154))]
		public static UniTask<ClanChatResponseModel> FetchChat(ClanChatSeqIdRequestModel model)
		{
			return default(UniTask<ClanChatResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CClanAttendanceCheck_003Ed__155))]
		public static UniTask<ClanAttendanceResponseModel> ClanAttendanceCheck()
		{
			return default(UniTask<ClanAttendanceResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetClanPointRanking_003Ed__156))]
		public static UniTask<ClanPointRankingResponseModel> GetClanPointRanking(bool weekly)
		{
			return default(UniTask<ClanPointRankingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetClanRanking_003Ed__157))]
		public static UniTask<ClanRankingResponseModel> GetClanRanking()
		{
			return default(UniTask<ClanRankingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchClanRaid_003Ed__158))]
		public static UniTask<ClanRaidResponseModel> FetchClanRaid()
		{
			return default(UniTask<ClanRaidResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CEndClanRaid_003Ed__159))]
		public static UniTask<ClanRaidResponseModel> EndClanRaid(ClanRaidEndBattleRequestModel model)
		{
			return default(UniTask<ClanRaidResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSetClanRaidDeckPreset_003Ed__160))]
		public static UniTask<ResponseModel> SetClanRaidDeckPreset(ClanRaidDeckRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CDeleteClanRaidDeck_003Ed__161))]
		public static UniTask<ClanRaidDeckInfoResponseModel> DeleteClanRaidDeck(int deckIdx)
		{
			return default(UniTask<ClanRaidDeckInfoResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchClanRaidSupporters_003Ed__162))]
		public static UniTask<ClanRaidSupportResponseModel> FetchClanRaidSupporters()
		{
			return default(UniTask<ClanRaidSupportResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSetClanRaidDeckName_003Ed__163))]
		public static UniTask<ClanRaidDeckInfoResponseModel> SetClanRaidDeckName(int deckIdx, string deckName)
		{
			return default(UniTask<ClanRaidDeckInfoResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSetClanRaidSupportUnit_003Ed__164))]
		public static UniTask<ClanRaidSupporterSettingResponseModel> SetClanRaidSupportUnit(int unitId)
		{
			return default(UniTask<ClanRaidSupporterSettingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchClanRaidCurrentState_003Ed__165))]
		public static UniTask<ClanRaidMemberDamageSumResponseModel> FetchClanRaidCurrentState()
		{
			return default(UniTask<ClanRaidMemberDamageSumResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchClanRaidBestDecks_003Ed__166))]
		public static UniTask<ClanRaidBestDeckResponseModel> FetchClanRaidBestDecks()
		{
			return default(UniTask<ClanRaidBestDeckResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestResetRemainBattleCount_003Ed__167))]
		public static UniTask<ResponseModel> TestResetRemainBattleCount()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestSetGoldBonus_003Ed__168))]
		public static UniTask<ResponseModel> TestSetGoldBonus(int goldBonusTier)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestSetBossKillCount_003Ed__169))]
		public static UniTask<ResponseModel> TestSetBossKillCount(int killCount)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestResetDeckSetCount_003Ed__170))]
		public static UniTask<ResponseModel> TestResetDeckSetCount()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestResetDeckBattleCount_003Ed__171))]
		public static UniTask<ResponseModel> TestResetDeckBattleCount(int idx)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUseCoupon_003Ed__172))]
		public static UniTask<ResponseModel> UseCoupon(CouponRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchFlagInventory_003Ed__173))]
		public static UniTask<FlagInventoryResponseModel> FetchFlagInventory(int targetId = -1)
		{
			return default(UniTask<FlagInventoryResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchEquippedFlag_003Ed__174))]
		public static UniTask<FlagResponseModel> FetchEquippedFlag(int targetId = -1)
		{
			return default(UniTask<FlagResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSetFlag_003Ed__175))]
		public static UniTask<ResponseModel> SetFlag(FlagRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchNameTagInventory_003Ed__176))]
		public static UniTask<NameTagInventoryResponseModel> FetchNameTagInventory()
		{
			return default(UniTask<NameTagInventoryResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSetNameTag_003Ed__177))]
		public static UniTask<ResponseModel> SetNameTag(NameTagRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetInventory_003Ed__178))]
		public static UniTask<InventoryResponseModel> GetInventory()
		{
			return default(UniTask<InventoryResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUseInventory_003Ed__179))]
		public static UniTask<UseInventoryResponseModel> UseInventory(UseInventoryRequestModel model)
		{
			return default(UniTask<UseInventoryResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUseRewardBoxInventoryItem_003Ed__180))]
		public static UniTask<UseRewardBoxInventoryItemResponseModel> UseRewardBoxInventoryItem(UseRewardBoxInventoryItemRequestModel model)
		{
			return default(UniTask<UseRewardBoxInventoryItemResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSaveRogueLikeData_003Ed__181))]
		public static UniTask<ResponseModel> SaveRogueLikeData(RogueLikeGameDataRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CLoadRogueLikeData_003Ed__182))]
		public static UniTask<RogueLikeGameDataResponseModel> LoadRogueLikeData(int savedVersion)
		{
			return default(UniTask<RogueLikeGameDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CDeleteRogueLikeData_003Ed__183))]
		public static UniTask<DeleteRogueLikeDataResponseModel> DeleteRogueLikeData(bool withLogging)
		{
			return default(UniTask<DeleteRogueLikeDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetRogueLikeRanking_003Ed__184))]
		public static UniTask<RogueLikeRankingResponseModel> GetRogueLikeRanking(int challenge = -1, bool useCache = true)
		{
			return default(UniTask<RogueLikeRankingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetRogueLikeBuildingRanking_003Ed__185))]
		public static UniTask<RogueLikeRankingResponseModel> GetRogueLikeBuildingRanking(int building, bool useCache = true)
		{
			return default(UniTask<RogueLikeRankingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRogueLikeRevive_003Ed__186))]
		public static UniTask<ResponseModel> RogueLikeRevive(bool useReviveCoupon)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRogueLikeCanReviveByAd_003Ed__187))]
		public static UniTask<ResponseModel> RogueLikeCanReviveByAd()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CStartRogueLikeFloor_003Ed__188))]
		public static UniTask<StartRogueLikeFloorResponseModel> StartRogueLikeFloor(StartRogueLikeFloorRequestModel model)
		{
			return default(UniTask<StartRogueLikeFloorResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CEndRogueLikeFloor_003Ed__189))]
		public static UniTask<EndRogueLikeFloorResponseModel> EndRogueLikeFloor(EndRogueLikeFloorRequestModel model)
		{
			return default(UniTask<EndRogueLikeFloorResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetRogueLikeOutGameData_003Ed__190))]
		public static UniTask<RogueLikeOutGameDataResponseModel> GetRogueLikeOutGameData()
		{
			return default(UniTask<RogueLikeOutGameDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCheckRogueLikeMission_003Ed__191))]
		public static UniTask<RogueLikeMissionResponseModel> CheckRogueLikeMission(RogueLikeMissionRequestModel model)
		{
			return default(UniTask<RogueLikeMissionResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCheckRogueLikeMissionOnClear_003Ed__192))]
		public static UniTask<RogueLikeMissionResponseModel> CheckRogueLikeMissionOnClear()
		{
			return default(UniTask<RogueLikeMissionResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetAllRogueLikeMissions_003Ed__193))]
		public static UniTask<RogueLikeMissionDataResponseModel> GetAllRogueLikeMissions()
		{
			return default(UniTask<RogueLikeMissionDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetAllRogueLikeMissionsStatistics_003Ed__194))]
		public static UniTask<RogueLikeMissionStatisticsResponseModel> GetAllRogueLikeMissionsStatistics()
		{
			return default(UniTask<RogueLikeMissionStatisticsResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetUpdatedRogueLikeMissions_003Ed__195))]
		public static UniTask<RogueLikeMissionDataResponseModel> GetUpdatedRogueLikeMissions()
		{
			return default(UniTask<RogueLikeMissionDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUpdateRogueLikePlayCount_003Ed__196))]
		public static UniTask<ResponseModel> UpdateRogueLikePlayCount(int playCount)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUpdateRogueLikeClearCount_003Ed__197))]
		public static UniTask<ResponseModel> UpdateRogueLikeClearCount(int clearCount)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUpdateRogueLikeMissionClearCount_003Ed__198))]
		public static UniTask<ResponseModel> UpdateRogueLikeMissionClearCount(int clearCount)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CResetRogueLikeMission_003Ed__199))]
		public static UniTask<ResponseModel> ResetRogueLikeMission(int missionId)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CResetAllRogueLikeMission_003Ed__200))]
		public static UniTask<ResponseModel> ResetAllRogueLikeMission()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSaveCustomPickups_003Ed__201))]
		public static UniTask<ResponseModel> SaveCustomPickups(CustomPickupsRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CLoadCustomPickups_003Ed__202))]
		public static UniTask<CustomPickupsResponseModel> LoadCustomPickups(int gachaId)
		{
			return default(UniTask<CustomPickupsResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchPlayerTerritory_003Ed__203))]
		public static UniTask<PlayerTerritoryResponseModel> FetchPlayerTerritory()
		{
			return default(UniTask<PlayerTerritoryResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchTerritoryStatBuffs_003Ed__204))]
		public static UniTask<TerritoryStatBuffPerResponseModel> FetchTerritoryStatBuffs()
		{
			return default(UniTask<TerritoryStatBuffPerResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryRecoverLabor_003Ed__205))]
		public static UniTask<TerritoryRecoverLaborResponseModel> TerritoryRecoverLabor()
		{
			return default(UniTask<TerritoryRecoverLaborResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CBuildTerritoryBuilding_003Ed__206))]
		public static UniTask<TerritoryBuildBuildingResponseModel> BuildTerritoryBuilding(TerritoryBuildBuildingRequestModel model)
		{
			return default(UniTask<TerritoryBuildBuildingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRefreshTerritoryBuilding_003Ed__207))]
		public static UniTask<TerritoryRefreshBuildingResponseModel> RefreshTerritoryBuilding(TerritoryRefreshBuildingRequestModel model)
		{
			return default(UniTask<TerritoryRefreshBuildingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CStoreTerritoryBuilding_003Ed__208))]
		public static UniTask<ResponseModel> StoreTerritoryBuilding(int posIndex)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUnStoreTerritoryBuilding_003Ed__209))]
		public static UniTask<TerritoryBuildingResponseModel> UnStoreTerritoryBuilding(int buildingId, int posIndex)
		{
			return default(UniTask<TerritoryBuildingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRemoveTerritoryBuilding_003Ed__210))]
		public static UniTask<TerritoryCurrencyResponseModel> RemoveTerritoryBuilding(int posIndex)
		{
			return default(UniTask<TerritoryCurrencyResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CReplaceTerritoryBuilding_003Ed__211))]
		public static UniTask<ResponseModel> ReplaceTerritoryBuilding(TerritoryReplaceBuildingRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUpgradeTerritoryBuilding_003Ed__212))]
		public static UniTask<TerritoryBuildBuildingResponseModel> UpgradeTerritoryBuilding(int posIndex)
		{
			return default(UniTask<TerritoryBuildBuildingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAssignUnitsToBuilding_003Ed__213))]
		public static UniTask<TerritoryAssignUnitsResponseModel> AssignUnitsToBuilding(AssignUnitsToBuildingRequestModel model)
		{
			return default(UniTask<TerritoryAssignUnitsResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSwapAssignedUnitsFromBuildings_003Ed__214))]
		public static UniTask<SwapAssignedHeroesFromBuildingsResponseModel> SwapAssignedUnitsFromBuildings(SwapAssignedUnitsFromBuildingsRequestModel model)
		{
			return default(UniTask<SwapAssignedHeroesFromBuildingsResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryCollectLabor_003Ed__215))]
		public static UniTask<TerritoryCollectLaborResponseModel> TerritoryCollectLabor(int amount)
		{
			return default(UniTask<TerritoryCollectLaborResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAssignTerritoryLevelSync_003Ed__216))]
		public static UniTask<TerritoryLevelSyncResponseModel> AssignTerritoryLevelSync(AssignTerritoryLevelSyncRequestModel model)
		{
			return default(UniTask<TerritoryLevelSyncResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CResetLevelSync_003Ed__217))]
		public static UniTask<TerritoryAssignUnitsResponseModel> ResetLevelSync(ResetTerritoryLevelSyncTimerRequestModel model)
		{
			return default(UniTask<TerritoryAssignUnitsResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryStartHunting_003Ed__218))]
		public static UniTask<TerritoryStartHuntingResponseModel> TerritoryStartHunting(TerritoryHuntingRequestModel model)
		{
			return default(UniTask<TerritoryStartHuntingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryEndHunting_003Ed__219))]
		public static UniTask<TerritoryEndHuntingResponseModel> TerritoryEndHunting(TerritoryHuntingRequestModel model)
		{
			return default(UniTask<TerritoryEndHuntingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryRefreshHunting_003Ed__220))]
		public static UniTask<TerritoryHuntingRefreshResponseModel> TerritoryRefreshHunting()
		{
			return default(UniTask<TerritoryHuntingRefreshResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchTerritoryHunting_003Ed__221))]
		public static UniTask<TerritoryHuntingResponseModel> FetchTerritoryHunting()
		{
			return default(UniTask<TerritoryHuntingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryAlchemy_003Ed__222))]
		public static UniTask<TerritoryAlchemyResponseModel> TerritoryAlchemy(TerritoryAlchemyRequestModel model)
		{
			return default(UniTask<TerritoryAlchemyResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CUpgradeImmediatelyTerritoryBuilding_003Ed__223))]
		public static UniTask<TerritoryBuildBuildingResponseModel> UpgradeImmediatelyTerritoryBuilding(int posIndex, int territoryType)
		{
			return default(UniTask<TerritoryBuildBuildingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryTycoonRecoverSeasonalEventToken_003Ed__224))]
		public static UniTask<PlayerTerritoryTycoonResponseModel> TerritoryTycoonRecoverSeasonalEventToken()
		{
			return default(UniTask<PlayerTerritoryTycoonResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryTycoonFetchTokenEventToken_003Ed__225))]
		public static UniTask<TerritoryTycoonTokenResponseModel> TerritoryTycoonFetchTokenEventToken()
		{
			return default(UniTask<TerritoryTycoonTokenResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryTycoonCheckAttendance_003Ed__226))]
		public static UniTask<ResponseModel> TerritoryTycoonCheckAttendance()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryTycoonCollectSkinToken_003Ed__227))]
		public static UniTask<TerritoryTycoonTokenResponseModel> TerritoryTycoonCollectSkinToken(int amount)
		{
			return default(UniTask<TerritoryTycoonTokenResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryTycoonFirework_003Ed__228))]
		public static UniTask<TerritoryTycoonFireworkResponseModel> TerritoryTycoonFirework()
		{
			return default(UniTask<TerritoryTycoonFireworkResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryBuyTradeShopItem_003Ed__229))]
		public static UniTask<TerritoryBuyTradeShopItemResponseModel> TerritoryBuyTradeShopItem(TerritoryBuyTradeShopItemRequestModel model)
		{
			return default(UniTask<TerritoryBuyTradeShopItemResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchPlayerColosseum_003Ed__230))]
		public static UniTask<PlayerColosseumInfoResponseModel> FetchPlayerColosseum()
		{
			return default(UniTask<PlayerColosseumInfoResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchColosseumPlayersData_003Ed__231))]
		public static UniTask<ColosseumPlayerDataResponseModel> FetchColosseumPlayersData(string gameId)
		{
			return default(UniTask<ColosseumPlayerDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchColosseumAddressByGameID_003Ed__232))]
		public static UniTask<ColosseumMatchResponseModel> FetchColosseumAddressByGameID(string gameId)
		{
			return default(UniTask<ColosseumMatchResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCheckColosseumReenterEndGame_003Ed__233))]
		public static UniTask<ColosseumEndGameReenterResponseModel> CheckColosseumReenterEndGame(string gameId)
		{
			return default(UniTask<ColosseumEndGameReenterResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRequestColosseumMatchmaking_003Ed__234))]
		public static UniTask<ResponseModel> RequestColosseumMatchmaking(ColosseumMatchRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CColosseumGetReward_003Ed__235))]
		public static UniTask<ResponseModel> ColosseumGetReward(int index, int gameEndRewardIndex, string gameId, bool upgrade)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CColosseumReceiveReward_003Ed__236))]
		public static UniTask<PvPReceiveRewardResponseModel> ColosseumReceiveReward(PvPReceiveRewardRequestModel model)
		{
			return default(UniTask<PvPReceiveRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetColosseumOpenMissionReward_003Ed__237))]
		public static UniTask<RewardListResponseModel> GetColosseumOpenMissionReward(int rewardIdx)
		{
			return default(UniTask<RewardListResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetColosseumRanking_003Ed__238))]
		public static UniTask<ColosseumRankingResponseModel> GetColosseumRanking(int season, bool useCache = false)
		{
			return default(UniTask<ColosseumRankingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetColosseumLeagueRanking_003Ed__239))]
		public static UniTask<LeagueRankingResponseModel> GetColosseumLeagueRanking(int leagueSeason, bool useCache = false)
		{
			return default(UniTask<LeagueRankingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetColosseumHallOfFame_003Ed__240))]
		public static UniTask<ColosseumRankingResponseModel> GetColosseumHallOfFame(int leagueSeason, bool useCache = false)
		{
			return default(UniTask<ColosseumRankingResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CColosseumReenterTried_003Ed__241))]
		public static UniTask<ResponseModel> ColosseumReenterTried(string gameId)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CColosseumReenterSucceed_003Ed__242))]
		public static UniTask<ResponseModel> ColosseumReenterSucceed(string gameId)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CColosseumRecordMinimumRank_003Ed__243))]
		public static UniTask<ResponseModel> ColosseumRecordMinimumRank(string gameId, int rank)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchPlayerTreasure_003Ed__244))]
		public static UniTask<TreasureInventoryResponseModel> FetchPlayerTreasure()
		{
			return default(UniTask<TreasureInventoryResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTreasureOvercome_003Ed__245))]
		public static UniTask<TreasureResultResponseModel> TreasureOvercome(TreasureRequestModel model)
		{
			return default(UniTask<TreasureResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTreasureEquip_003Ed__246))]
		public static UniTask<TreasureResultResponseModel> TreasureEquip(TreasureRequestModel model, bool useTicket)
		{
			return default(UniTask<TreasureResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTreasureEquipTutorial_003Ed__247))]
		public static UniTask<TreasureResultResponseModel> TreasureEquipTutorial(TreasureRequestModel model)
		{
			return default(UniTask<TreasureResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTreasureReleaseEquip_003Ed__248))]
		public static UniTask<TreasureResultResponseModel> TreasureReleaseEquip(TreasureRequestModel model)
		{
			return default(UniTask<TreasureResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTreasureDismantle_003Ed__249))]
		public static UniTask<TreasureResultResponseModel> TreasureDismantle(TreasureDismantleRequestModel model)
		{
			return default(UniTask<TreasureResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTreasureSetState_003Ed__250))]
		public static UniTask<TreasureResultResponseModel> TreasureSetState(TreasureRequestModel model)
		{
			return default(UniTask<TreasureResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTreasureAddExp_003Ed__251))]
		public static UniTask<TreasureResultResponseModel> TreasureAddExp(TreasureRequestModel model)
		{
			return default(UniTask<TreasureResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchPlayerAccessory_003Ed__252))]
		public static UniTask<AccessoryInventoryResponseModel> FetchPlayerAccessory()
		{
			return default(UniTask<AccessoryInventoryResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAccessoryEquip_003Ed__253))]
		public static UniTask<AccessoryResultResponseModel> AccessoryEquip(AccessoryEquipRequestModel model, bool useTicket)
		{
			return default(UniTask<AccessoryResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAccessoryEquipTutorial_003Ed__254))]
		public static UniTask<AccessoryResultResponseModel> AccessoryEquipTutorial(AccessoryEquipRequestModel model)
		{
			return default(UniTask<AccessoryResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAccessoryReleaseEquip_003Ed__255))]
		public static UniTask<AccessoryResultResponseModel> AccessoryReleaseEquip(AccessoryRequestModel model)
		{
			return default(UniTask<AccessoryResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAccessoryDismantle_003Ed__256))]
		public static UniTask<AccessoryResultResponseModel> AccessoryDismantle(AccessoryDismantleRequestModel model)
		{
			return default(UniTask<AccessoryResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAccessorySetState_003Ed__257))]
		public static UniTask<AccessoryResultResponseModel> AccessorySetState(AccessorySetStateRequestModel model)
		{
			return default(UniTask<AccessoryResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAccessoryAddExp_003Ed__258))]
		public static UniTask<AccessoryResultResponseModel> AccessoryAddExp(AccessoryRequestModel model)
		{
			return default(UniTask<AccessoryResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchPlayerSeasonalEventData_003Ed__259))]
		public static UniTask<PlayerSeasonalEventDataResponseModel> FetchPlayerSeasonalEventData()
		{
			return default(UniTask<PlayerSeasonalEventDataResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchInvasionRecords_003Ed__260))]
		public static UniTask<InvasionRecordsResponseModel> FetchInvasionRecords()
		{
			return default(UniTask<InvasionRecordsResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchInvasionRewardDatas_003Ed__261))]
		public static UniTask<InvasionRewardDatasResponseModel> FetchInvasionRewardDatas()
		{
			return default(UniTask<InvasionRewardDatasResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CReceiveInvasionRewardAll_003Ed__262))]
		public static UniTask<ReceiveInvasionRewardResponseModel> ReceiveInvasionRewardAll(ReceiveInvasionRewardAllRequestModel model)
		{
			return default(UniTask<ReceiveInvasionRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CReceiveInvasionReward_003Ed__263))]
		public static UniTask<ReceiveInvasionRewardResponseModel> ReceiveInvasionReward(ReceiveInvasionRewardRequestModel model)
		{
			return default(UniTask<ReceiveInvasionRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchPlayerBabel_003Ed__264))]
		public static UniTask<BabelResponseModel> FetchPlayerBabel()
		{
			return default(UniTask<BabelResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestColosseumSinglePlay_003Ed__265))]
		public static UniTask<ColosseumMatchResponseModel> TestColosseumSinglePlay()
		{
			return default(UniTask<ColosseumMatchResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestColosseumFreeMatching_003Ed__266))]
		public static UniTask<ColosseumMatchResponseModel> TestColosseumFreeMatching(int botNum)
		{
			return default(UniTask<ColosseumMatchResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CPingColosseumMatchingResult_003Ed__267))]
		public static UniTask<ColosseumMatchResponseModel> PingColosseumMatchingResult()
		{
			return default(UniTask<ColosseumMatchResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCancelColosseumMatching_003Ed__268))]
		public static UniTask<ResponseModel> CancelColosseumMatching()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCreateColosseumCustomMatch_003Ed__269))]
		public static UniTask<ColosseumCustomMatchResponseModel> CreateColosseumCustomMatch()
		{
			return default(UniTask<ColosseumCustomMatchResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CJoinColosseumCustomMatch_003Ed__270))]
		public static UniTask<ColosseumCustomMatchResponseModel> JoinColosseumCustomMatch(string matchId)
		{
			return default(UniTask<ColosseumCustomMatchResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSaveColosseumRoundData_003Ed__271))]
		public static UniTask<ResponseModel> SaveColosseumRoundData(SaveColosseumRoundDataRequestModel model, string gameId)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CSaveCompleteColosseumRoundData_003Ed__272))]
		public static UniTask<ResponseModel> SaveCompleteColosseumRoundData(SaveCompleteColosseumRoundDataRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CCompleteCustomEvent_003Ed__273))]
		public static UniTask<ResponseModel> CompleteCustomEvent(CustomEventRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryAddLabor_003Ed__274))]
		public static UniTask<ResponseModel> TerritoryAddLabor(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryAddCore_003Ed__275))]
		public static UniTask<ResponseModel> TerritoryAddCore(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryBuildingSetTime_003Ed__276))]
		public static UniTask<ResponseModel> TerritoryBuildingSetTime(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryHuntingSetTime_003Ed__277))]
		public static UniTask<ResponseModel> TerritoryHuntingSetTime(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryHuntingSetId_003Ed__278))]
		public static UniTask<ResponseModel> TerritoryHuntingSetId(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryRefreshFlagTime_003Ed__279))]
		public static UniTask<ResponseModel> TerritoryRefreshFlagTime()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritorySetLastLaborAt_003Ed__280))]
		public static UniTask<ResponseModel> TerritorySetLastLaborAt()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritorySetLastTokenAt_003Ed__281))]
		public static UniTask<ResponseModel> TerritorySetLastTokenAt(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritoryClearTradeShopBuyLimit_003Ed__282))]
		public static UniTask<ResponseModel> TerritoryClearTradeShopBuyLimit()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTerritorySetLevelSyncUntilAt_003Ed__283))]
		public static UniTask<ResponseModel> TerritorySetLevelSyncUntilAt(int buildingId, int posIndex, int unitId)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAddExp_003Ed__284))]
		public static UniTask<ResponseModel> AddExp(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAddGold_003Ed__285))]
		public static UniTask<ResponseModel> AddGold(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAddCash_003Ed__286))]
		public static UniTask<ResponseModel> AddCash(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAddHeart_003Ed__287))]
		public static UniTask<ResponseModel> AddHeart(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAddCard_003Ed__288))]
		public static UniTask<ResponseModel> AddCard(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAddCardExp_003Ed__289))]
		public static UniTask<ResponseModel> AddCardExp(DeckRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CAddRanking_003Ed__290))]
		public static UniTask<ResponseModel> AddRanking(TestRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CRegisterPvPDeckPool_003Ed__291))]
		public static UniTask<ResponseModel> RegisterPvPDeckPool(PvPDeckPoolRequestModel requestModel)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchPvPDeck_003Ed__292))]
		public static UniTask<PvPMatchResponseModel> FetchPvPDeck(TestRequestModel requestModel)
		{
			return default(UniTask<PvPMatchResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CFetchEventPackageShopInfo_003Ed__293))]
		public static UniTask<ShopResponseModel> FetchEventPackageShopInfo()
		{
			return default(UniTask<ShopResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestResetLastLogin_003Ed__294))]
		public static UniTask<ResponseModel> TestResetLastLogin()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestSetClanScore_003Ed__295))]
		public static UniTask<ResponseModel> TestSetClanScore(int score)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestSetClanGoldBonus_003Ed__296))]
		public static UniTask<ResponseModel> TestSetClanGoldBonus(int clanBonus, int clanV2Bonus)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestResetCustomGrowthPackage_003Ed__297))]
		public static UniTask<ResponseModel> TestResetCustomGrowthPackage()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestResetDailyShopRefreshCount_003Ed__298))]
		public static UniTask<ResponseModel> TestResetDailyShopRefreshCount()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CDevSetUnitBundlePackageUntilAt_003Ed__299))]
		public static UniTask<ResponseModel> DevSetUnitBundlePackageUntilAt()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestSetArtifactPolishPoint_003Ed__300))]
		public static UniTask<ResponseModel> TestSetArtifactPolishPoint(TestRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestSetLastLogined_003Ed__301))]
		public static UniTask<ResponseModel> TestSetLastLogined(TestRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestSetReturnAttendanceDay_003Ed__302))]
		public static UniTask<ResponseModel> TestSetReturnAttendanceDay(TestRequestModel model)
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestSetReturnEventEnd_003Ed__303))]
		public static UniTask<ResponseModel> TestSetReturnEventEnd()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestAddTreasure_003Ed__304))]
		public static UniTask<TreasureResultResponseModel> TestAddTreasure(TestRequestModel model)
		{
			return default(UniTask<TreasureResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestTreasureCoolTime_003Ed__305))]
		public static UniTask<TreasureResultResponseModel> TestTreasureCoolTime(TestRequestModel model)
		{
			return default(UniTask<TreasureResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestAddAccessories_003Ed__306))]
		public static UniTask<AccessoryResultResponseModel> TestAddAccessories(TestRequestModel model)
		{
			return default(UniTask<AccessoryResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestAddAllConsumable_003Ed__307))]
		public static UniTask<ResponseModel> TestAddAllConsumable()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestAccessoryCoolTime_003Ed__308))]
		public static UniTask<AccessoryResultResponseModel> TestAccessoryCoolTime(TestRequestModel model)
		{
			return default(UniTask<AccessoryResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestAccessoryStatSave_003Ed__309))]
		public static UniTask<AccessoryResultResponseModel> TestAccessoryStatSave(AccessoryTestStatRequestModel model)
		{
			return default(UniTask<AccessoryResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestSetJourneyRewardRemainTime_003Ed__310))]
		public static UniTask<JourneyRewardResponseModel> TestSetJourneyRewardRemainTime(TestRequestModel model)
		{
			return default(UniTask<JourneyRewardResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestResetFourthYearEvent_003Ed__311))]
		public static UniTask<FourthYearEventResponseModel> TestResetFourthYearEvent()
		{
			return default(UniTask<FourthYearEventResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestResetFourthYearEventPass_003Ed__312))]
		public static UniTask<FourthYearEventResponseModel> TestResetFourthYearEventPass()
		{
			return default(UniTask<FourthYearEventResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestSetFourthYearDay_003Ed__313))]
		public static UniTask<FourthYearEventResponseModel> TestSetFourthYearDay(bool isPassDay, int day)
		{
			return default(UniTask<FourthYearEventResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CDevDeleteAllPassMissions_003Ed__314))]
		public static UniTask<ResponseModel> DevDeleteAllPassMissions()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CDevAddPassMission_003Ed__315))]
		public static UniTask<DevAddPassMissionResponseModel> DevAddPassMission(int missionId)
		{
			return default(UniTask<DevAddPassMissionResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CDevResetCustomPickups_003Ed__316))]
		public static UniTask<CustomPickupsResponseModel> DevResetCustomPickups(int gachaId)
		{
			return default(UniTask<CustomPickupsResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CDevSetInvasionSkipCount_003Ed__317))]
		public static UniTask<GameSkipInfoResponseModel> DevSetInvasionSkipCount(TestRequestModel model)
		{
			return default(UniTask<GameSkipInfoResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CDevSetBabelStage_003Ed__318))]
		public static UniTask<BabelResponseModel> DevSetBabelStage(int babelId, int stage)
		{
			return default(UniTask<BabelResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestClearStarterMission_003Ed__319))]
		public static UniTask<TreasureResultResponseModel> TestClearStarterMission(TestRequestModel model)
		{
			return default(UniTask<TreasureResultResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CTestResetStarterMission_003Ed__320))]
		public static UniTask<ResponseModel> TestResetStarterMission()
		{
			return default(UniTask<ResponseModel>);
		}

		[AsyncStateMachine(typeof(_003CGetDevServers_003Ed__322))]
		public static UniTask<ServerListResponse> GetDevServers()
		{
			return default(UniTask<ServerListResponse>);
		}

		[AsyncStateMachine(typeof(_003CGetDefaultInfraRankingServer_003Ed__323))]
		public static UniTask<ServerListResponse> GetDefaultInfraRankingServer(bool useReplica)
		{
			return default(UniTask<ServerListResponse>);
		}
	}
}
