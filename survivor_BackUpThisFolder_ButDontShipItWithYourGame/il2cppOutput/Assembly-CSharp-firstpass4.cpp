#include "pch-cpp.hpp"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif


#include <limits>
#include <stdint.h>


struct InvokerActionInvoker0
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj)
	{
		method->invoker_method(methodPtr, method, obj, NULL, NULL);
	}
};
template <typename T1>
struct InvokerActionInvoker1;
template <typename T1>
struct InvokerActionInvoker1<T1*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1)
	{
		void* params[1] = { p1 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};
template <typename T1, typename T2>
struct InvokerActionInvoker2;
template <typename T1, typename T2>
struct InvokerActionInvoker2<T1*, T2*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2)
	{
		void* params[2] = { p1, p2 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};
template <typename T1, typename T2, typename T3>
struct InvokerActionInvoker3;
template <typename T1, typename T2, typename T3>
struct InvokerActionInvoker3<T1*, T2*, T3*>
{
	static inline void Invoke (Il2CppMethodPointer methodPtr, const RuntimeMethod* method, void* obj, T1* p1, T2* p2, T3* p3)
	{
		void* params[3] = { p1, p2, p3 };
		method->invoker_method(methodPtr, method, obj, params, NULL);
	}
};

// System.Collections.Generic.Dictionary`2<UnityEngine.AudioSource,System.Double>
struct Dictionary_2_t236C8C5505A81CEF6C8899F3236FD5FA3FCD1B34;
// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.Dictionary`2<DarkTonic.MasterAudio.ICustomEventReceiver,UnityEngine.Transform>>
struct Dictionary_2_t331F4B207DC254D36ACB961A0A9EAECAB8756AA4;
// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>>
struct Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341;
// System.Collections.Generic.Dictionary`2<System.String,DarkTonic.MasterAudio.DuckGroupInfo>
struct Dictionary_2_tC787C52A6EEA9600C99DCF36A3312103B4BB2DD3;
// System.Collections.Generic.Dictionary`2<System.String,DarkTonic.MasterAudio.PlaylistController>
struct Dictionary_2_tB3C963DAC18787740A7F6E0AB620CBFE4A00A48B;
// System.Collections.Generic.Dictionary`2<System.String,DarkTonic.MasterAudio.MasterAudio/AudioGroupInfo>
struct Dictionary_2_t653F2A87D06D3C44171928C93E124BBFB5DBF0A4;
// System.Collections.Generic.Dictionary`2<System.String,DarkTonic.MasterAudio.MasterAudio/SoundGroupRefillInfo>
struct Dictionary_2_tE1AC22D7C8D1919312A8248A19586F6F696A6D5D;
// System.Collections.Generic.HashSet`1<System.Int32>
struct HashSet_1_t4A2F2B74276D0AD3ED0F873045BD61E9504ECAE2;
// System.Collections.Generic.IList`1<DarkTonic.MasterAudio.AudioEventGroup>
struct IList_1_tB1F44C79662E0C6979277E18B3F73D61CB37ECA8;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.AmbientSoundToTriggerInfo>
struct List_1_tA143A459DB11541564964D118D17881AF5AC0F81;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.AudioEvent>
struct List_1_t9A64F4AC09E4FE4AE5E89DD013492B9C4FEBC3CB;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.AudioEventGroup>
struct List_1_t34522BBE1CA284958723F996311B012983B30D2B;
// System.Collections.Generic.List`1<UnityEngine.AudioSource>
struct List_1_t0EDD1795F87849390F5CA17CBABE75183BE4E235;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.BusDuckInfo>
struct List_1_t4E85B0D46307B1B7D2E01394EFCB4EF8478E6048;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.BusFadeInfo>
struct List_1_tF1DD45D0D84375C6DB14D5C04969497C77E5D47B;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.BusPitchGlideInfo>
struct List_1_tB76EBB877F18C7C240CB26BC0FBC9FB792107FFC;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.CustomEvent>
struct List_1_tD3A8C581E25B2E07CE926E9AF765150DAF77D141;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.CustomEventCategory>
struct List_1_t148EBB8E073798AB5AF07804D9E567AB1320D0BC;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.DuckGroupInfo>
struct List_1_tE0BEE1CBE27E6FDCABCECDABBE144DC388B59692;
// System.Collections.Generic.List`1<UnityEngine.GameObject>
struct List_1_tB951CE80B58D1BF9650862451D8DAD8C231F207B;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.GroupBus>
struct List_1_t51CDEFF7CE3C500BC2A0B91F1F8F79A405812083;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.GroupFadeInfo>
struct List_1_t8A061A03AFBEE095AE1AC17C594F9E8F3E4B6353;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.GroupPitchGlideInfo>
struct List_1_tCE4016530FFAB572C7A2BC760B90BA65C1BBDA5E;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.ICustomEventReceiver>
struct List_1_t1C72E807760F1F86D2E72CCFB7B7E97EECF82BC8;
// System.Collections.Generic.List`1<System.Int32>
struct List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MasterAudioGroup>
struct List_1_t2A8E597C2110CD2D0CF5A5AAAC6C906545F78BC8;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MusicSetting>
struct List_1_t514ED2374039EA31FAA604B843F3706C43576C4C;
// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.OcclusionFreqChangeInfo>
struct List_1_t73FEEFFA5D873C807DDB2334CF32815519532AB0;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController>
struct List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SongMetadataBoolValue>
struct List_1_t764B3318C9BDE224AAFBAC7C1AD5C1A98756F7CB;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SongMetadataFloatValue>
struct List_1_tC3830A044518C3CA656B72DC48917082F964D5D5;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SongMetadataIntValue>
struct List_1_t3295E6807A06F6BE3E1A8F50B5D6C5098A3EC627;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SongMetadataStringValue>
struct List_1_t276F3FFB58A7A906339403BC623085CD16E2289F;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SoundGroupVariation>
struct List_1_t0DF2EE0CA3814256E39537F560D0B8BE7ADEA258;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SoundGroupVariationUpdater>
struct List_1_tF19310A6F7A43D81B39CFDAB360194B2712C5BBE;
// System.Collections.Generic.List`1<System.String>
struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD;
// System.Collections.Generic.List`1<UnityEngine.SystemLanguage>
struct List_1_t8CC720FCDC45DA24733B888EA21D38A58C71A516;
// System.Collections.Generic.List`1<TransformFollower>
struct List_1_tF7CEA64906A8DB0EF3F400307E2678D2FA686FD8;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MasterAudio/AudioInfo>
struct List_1_t89A671920E5A4C32C65F8CF2F608849CF6B085D3;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MasterAudio/CustomEventCandidate>
struct List_1_t6171BB0B43CB8F27D0D9790F346895B57BFF45C8;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MasterAudio/Playlist>
struct List_1_t19AA6BC54785CD8C9D8290529CB22BFD06B5DCB2;
// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MasterAudio/SoundGroupCommand>
struct List_1_tE5C5C7B7F0D76393E51AF8EEC349693AF78222E7;
// System.Collections.Generic.Queue`1<DarkTonic.MasterAudio.CustomEventToFireInfo>
struct Queue_1_tB56B6EB1E312C083BDA3ED2EC142DF70556BD7CD;
// System.Collections.Generic.Queue`1<DarkTonic.MasterAudio.SoundGroupVariationUpdater>
struct Queue_1_tDA922A4DF99D23BE627D0930913AA4FD11F141DD;
// System.Collections.Generic.Queue`1<TransformFollower>
struct Queue_1_tEE30610AD17F1BC5F5DB780E1992BF6BC21455A1;
// DarkTonic.MasterAudio.AudioEventGroup[]
struct AudioEventGroupU5BU5D_tC6AD8E0FA8B493C0B8C35DDD4857D1A24F6D2AB6;
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;
// System.String[]
struct StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248;
// System.Action
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07;
// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C;
// UnityEngine.AudioClip
struct AudioClip_t5D272C4EB4F2D3ED49F1C346DEA373CF6D585F20;
// DarkTonic.MasterAudio.AudioEventGroup
struct AudioEventGroup_t953D8966F454589B710B23F387F5D1B5E9B73E2A;
// UnityEngine.Audio.AudioMixerGroup
struct AudioMixerGroup_tD29AC8336F7425DF007944F8195CEABF34FC3311;
// UnityEngine.AudioSource
struct AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299;
// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3;
// UnityEngine.Coroutine
struct Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B;
// System.Delegate
struct Delegate_t;
// System.DelegateData
struct DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E;
// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F;
// System.IAsyncResult
struct IAsyncResult_t7B9B5A0ECB35DCEC31B8A8122C37D687369253B5;
// DarkTonic.MasterAudio.ICustomEventReceiver
struct ICustomEventReceiver_tC7D68759ECAD9DBD71EA41759A46950654A4E206;
// DarkTonic.MasterAudio.Examples.MA_Bootstrapper
struct MA_Bootstrapper_t3C33A30BC81199B87CF3B8B066BFF092AF052887;
// DarkTonic.MasterAudio.Examples.MA_DestroyFinishedParticle
struct MA_DestroyFinishedParticle_tBD633205873167544519D41760934A254D47B8CB;
// DarkTonic.MasterAudio.Examples.MA_EnemyOne
struct MA_EnemyOne_t7D3293CA87F514A361A57200B85C47D7BC5A00D6;
// DarkTonic.MasterAudio.Examples.MA_EnemySpawner
struct MA_EnemySpawner_t21E3F60FD5616FE485106C6880615D53C44AC9A1;
// DarkTonic.MasterAudio.Examples.MA_GameScene
struct MA_GameScene_tFA5987AFF419EF0C0BBDBB2611D19045C146B97C;
// DarkTonic.MasterAudio.Examples.MA_Laser
struct MA_Laser_t8DE63150FD4B0E65D8772D9F6812D78B392544FC;
// DarkTonic.MasterAudio.Examples.MA_LocalizationUI
struct MA_LocalizationUI_t99D3717E29D5024181A096A0A13590D653FDA07E;
// DarkTonic.MasterAudio.Examples.MA_PlayerControl
struct MA_PlayerControl_tFA26225B0C306D27C50F028D7542C1300CF00BA2;
// DarkTonic.MasterAudio.Examples.MA_PlayerSpawnerControl
struct MA_PlayerSpawnerControl_t87E7E9177332BA2683259C0211587134DE637203;
// DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver
struct MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9;
// DarkTonic.MasterAudio.Examples.MA_TestUI
struct MA_TestUI_t938B2C6124B2D23E707E3F661D34922A49CE71E0;
// DarkTonic.MasterAudio.MasterAudio
struct MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558;
// DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter
struct MasterAudioMultiplayerAdapter_t41A811EE167500BE05C8479E0BFFEA15617E924D;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71;
// DarkTonic.MasterAudio.MusicSetting
struct MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9;
// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C;
// UnityEngine.ParticleSystem
struct ParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1;
// DarkTonic.MasterAudio.PlaySoundResult
struct PlaySoundResult_tC80DDE04F4A72B80791A0E79DB78708E1160BF96;
// DarkTonic.MasterAudio.PlaylistController
struct PlaylistController_t618C24E8D5BC20CD24B0640C396C9AD8E88B0806;
// DarkTonic.MasterAudio.SoundGroupVariation
struct SoundGroupVariation_tD53F3B1B9896DEF7C90FA02CC56EC7324AC27216;
// DarkTonic.MasterAudio.SoundGroupVariationUpdater
struct SoundGroupVariationUpdater_t080206521A9418F8FE225088E7EA25B10841F6A3;
// System.String
struct String_t;
// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1;
// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915;
// UnityEngine.YieldInstruction
struct YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D;
// DarkTonic.MasterAudio.MasterAudio/Playlist
struct Playlist_tBE0842A2F765478743625A0E7A04ED6D0ADE76B6;
// DarkTonic.MasterAudio.PlaylistController/<>c__DisplayClass162_0
struct U3CU3Ec__DisplayClass162_0_tB41B59BF810A20A1FE45E4D5C3EE93BD3CFC047D;
// DarkTonic.MasterAudio.PlaylistController/PlaylistEndedEventHandler
struct PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016;
// DarkTonic.MasterAudio.PlaylistController/SongChangedEventHandler
struct SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519;
// DarkTonic.MasterAudio.PlaylistController/SongEndedEventHandler
struct SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC;
// DarkTonic.MasterAudio.PlaylistController/SongLoopedEventHandler
struct SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE;

IL2CPP_EXTERN_C RuntimeClass* AudioEventGroup_t953D8966F454589B710B23F387F5D1B5E9B73E2A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* GUI_tA9CDB3D69DB13D51AD83ABDB587EF95947EC2D2A_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_t34522BBE1CA284958723F996311B012983B30D2B_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* String_t_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C RuntimeClass* Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var;
IL2CPP_EXTERN_C String_t* _stringLiteral041EF461B1D24087E20E486F69C26300E6C9CF42;
IL2CPP_EXTERN_C String_t* _stringLiteral0C1FBCAE463347B711E91243B552C4DF38EEC101;
IL2CPP_EXTERN_C String_t* _stringLiteral202D5AEF51C14B19CFE144337C7FDB3B9A7C7387;
IL2CPP_EXTERN_C String_t* _stringLiteral28BBF187EFC0EB9AC3DE8C16254DF67E7E5F2900;
IL2CPP_EXTERN_C String_t* _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D;
IL2CPP_EXTERN_C String_t* _stringLiteral51C7EFB6A66483A5AA139697DB8CB829FB7812CB;
IL2CPP_EXTERN_C String_t* _stringLiteral59277FD87F18D3F23F7A5D0613FDC39A2408C52A;
IL2CPP_EXTERN_C String_t* _stringLiteral606CE144FC64CABEF1C61843BE8A54F4B200825B;
IL2CPP_EXTERN_C String_t* _stringLiteral6346B05F30B85515CEFB378F9FD91DE3CA795F8F;
IL2CPP_EXTERN_C String_t* _stringLiteral686B7818A6E2392E96BCAA71A7E192E00BB7A28E;
IL2CPP_EXTERN_C String_t* _stringLiteral757810A415ACB10E11E552227E9550C547BD2F30;
IL2CPP_EXTERN_C String_t* _stringLiteral7D1D873639CF2E3E067098025366EC97849B26D0;
IL2CPP_EXTERN_C String_t* _stringLiteral7F8C014BD4810CC276D0F9F81A1E759C7B098B1E;
IL2CPP_EXTERN_C String_t* _stringLiteral81FECCD01231D97EE6D7C17B8F5531FE1A6D533E;
IL2CPP_EXTERN_C String_t* _stringLiteral851FE7EC40426AD18D17EBACAF13563372EF070E;
IL2CPP_EXTERN_C String_t* _stringLiteral85CAF10C9031702FC59B676CDC3EA8B9070CAEA9;
IL2CPP_EXTERN_C String_t* _stringLiteral8D004CCFB2C7F7062B882865483FF7F4DC36E04E;
IL2CPP_EXTERN_C String_t* _stringLiteral91321AEBDB5ADCB1C9C9DC650B29278499540212;
IL2CPP_EXTERN_C String_t* _stringLiteral98B033ED2637444093F303078F4135295C4D524A;
IL2CPP_EXTERN_C String_t* _stringLiteralBB2DB99551FBBC9B6B35D6F17FC03ADE79129C56;
IL2CPP_EXTERN_C String_t* _stringLiteralBD9B2524802405F9A25B14B9B72939E1D989D0E7;
IL2CPP_EXTERN_C String_t* _stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677;
IL2CPP_EXTERN_C String_t* _stringLiteralC7A7939E82BEFEF8DDB755713442AA62963F09F8;
IL2CPP_EXTERN_C String_t* _stringLiteralC7AFC69BFA0D3853573E4A41A19EBA2C80E84642;
IL2CPP_EXTERN_C String_t* _stringLiteralE16EA2DE18E0BDCE9015254D0CDB37021DCB24BB;
IL2CPP_EXTERN_C const RuntimeMethod* Component_GetComponent_TisParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1_mF2B700ECAEEEDBCC076CC66C9592C6DDFA0D36F9_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_m4315CBA28DB215575A4D8CDE10EA0E53B33A6667_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_Contains_m359254483BE42CAD4DCA8FBAFB87473FB4CF00E1_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_m155CDF1F26D1E859CC8AC03003C6BEA2EBF017F6_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var;
IL2CPP_EXTERN_C const RuntimeMethod* Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4_RuntimeMethod_var;
struct Delegate_t_marshaled_com;
struct Delegate_t_marshaled_pinvoke;

struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771;
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918;

IL2CPP_EXTERN_C_BEGIN
IL2CPP_EXTERN_C_END

#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.List`1<DarkTonic.MasterAudio.AudioEventGroup>
struct List_1_t34522BBE1CA284958723F996311B012983B30D2B  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	AudioEventGroupU5BU5D_tC6AD8E0FA8B493C0B8C35DDD4857D1A24F6D2AB6* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_t34522BBE1CA284958723F996311B012983B30D2B_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	AudioEventGroupU5BU5D_tC6AD8E0FA8B493C0B8C35DDD4857D1A24F6D2AB6* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.Object>
struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* ___s_emptyArray_5;
};

// System.Collections.Generic.List`1<System.String>
struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD  : public RuntimeObject
{
	// T[] System.Collections.Generic.List`1::_items
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ____items_1;
	// System.Int32 System.Collections.Generic.List`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.List`1::_version
	int32_t ____version_3;
	// System.Object System.Collections.Generic.List`1::_syncRoot
	RuntimeObject* ____syncRoot_4;
};

struct List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_StaticFields
{
	// T[] System.Collections.Generic.List`1::s_emptyArray
	StringU5BU5D_t7674CD946EC0CE7B3AE0BE70E6EE85F2ECD9F248* ___s_emptyArray_5;
};
struct Il2CppArrayBounds;

// DarkTonic.MasterAudio.AudioEventGroup
struct AudioEventGroup_t953D8966F454589B710B23F387F5D1B5E9B73E2A  : public RuntimeObject
{
	// System.Boolean DarkTonic.MasterAudio.AudioEventGroup::isExpanded
	bool ___isExpanded_0;
	// System.Boolean DarkTonic.MasterAudio.AudioEventGroup::multiplayerBroadcast
	bool ___multiplayerBroadcast_1;
	// System.Boolean DarkTonic.MasterAudio.AudioEventGroup::useLayerFilter
	bool ___useLayerFilter_2;
	// System.Boolean DarkTonic.MasterAudio.AudioEventGroup::useTagFilter
	bool ___useTagFilter_3;
	// System.Collections.Generic.List`1<System.Int32> DarkTonic.MasterAudio.AudioEventGroup::matchingLayers
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ___matchingLayers_4;
	// System.Collections.Generic.List`1<System.String> DarkTonic.MasterAudio.AudioEventGroup::matchingTags
	List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ___matchingTags_5;
	// System.Boolean DarkTonic.MasterAudio.AudioEventGroup::customSoundActive
	bool ___customSoundActive_6;
	// System.Boolean DarkTonic.MasterAudio.AudioEventGroup::isCustomEvent
	bool ___isCustomEvent_7;
	// System.String DarkTonic.MasterAudio.AudioEventGroup::customEventName
	String_t* ___customEventName_8;
	// System.Boolean DarkTonic.MasterAudio.AudioEventGroup::mechanimEventActive
	bool ___mechanimEventActive_9;
	// System.Boolean DarkTonic.MasterAudio.AudioEventGroup::isMechanimStateCheckEvent
	bool ___isMechanimStateCheckEvent_10;
	// System.String DarkTonic.MasterAudio.AudioEventGroup::mechanimStateName
	String_t* ___mechanimStateName_11;
	// System.Boolean DarkTonic.MasterAudio.AudioEventGroup::mechEventPlayedForState
	bool ___mechEventPlayedForState_12;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.AudioEvent> DarkTonic.MasterAudio.AudioEventGroup::SoundEvents
	List_1_t9A64F4AC09E4FE4AE5E89DD013492B9C4FEBC3CB* ___SoundEvents_13;
	// DarkTonic.MasterAudio.EventSounds/PreviousSoundStopMode DarkTonic.MasterAudio.AudioEventGroup::mouseDragStopMode
	int32_t ___mouseDragStopMode_14;
	// System.Single DarkTonic.MasterAudio.AudioEventGroup::mouseDragFadeOutTime
	float ___mouseDragFadeOutTime_15;
	// DarkTonic.MasterAudio.EventSounds/RetriggerLimMode DarkTonic.MasterAudio.AudioEventGroup::retriggerLimitMode
	int32_t ___retriggerLimitMode_16;
	// System.Int32 DarkTonic.MasterAudio.AudioEventGroup::limitPerXFrm
	int32_t ___limitPerXFrm_17;
	// System.Single DarkTonic.MasterAudio.AudioEventGroup::limitPerXSec
	float ___limitPerXSec_18;
	// System.Int32 DarkTonic.MasterAudio.AudioEventGroup::triggeredLastFrame
	int32_t ___triggeredLastFrame_19;
	// System.Single DarkTonic.MasterAudio.AudioEventGroup::triggeredLastTime
	float ___triggeredLastTime_20;
	// System.Single DarkTonic.MasterAudio.AudioEventGroup::triggerStayForTime
	float ___triggerStayForTime_21;
	// System.Boolean DarkTonic.MasterAudio.AudioEventGroup::doesTriggerStayRepeat
	bool ___doesTriggerStayRepeat_22;
	// System.Single DarkTonic.MasterAudio.AudioEventGroup::sliderValue
	float ___sliderValue_23;
};

// DarkTonic.MasterAudio.MusicSetting
struct MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9  : public RuntimeObject
{
	// System.String DarkTonic.MasterAudio.MusicSetting::alias
	String_t* ___alias_0;
	// DarkTonic.MasterAudio.MasterAudio/AudioLocation DarkTonic.MasterAudio.MusicSetting::audLocation
	int32_t ___audLocation_1;
	// UnityEngine.AudioClip DarkTonic.MasterAudio.MusicSetting::clip
	AudioClip_t5D272C4EB4F2D3ED49F1C346DEA373CF6D585F20* ___clip_2;
	// System.String DarkTonic.MasterAudio.MusicSetting::songName
	String_t* ___songName_3;
	// System.String DarkTonic.MasterAudio.MusicSetting::resourceFileName
	String_t* ___resourceFileName_4;
	// System.Single DarkTonic.MasterAudio.MusicSetting::volume
	float ___volume_5;
	// System.Single DarkTonic.MasterAudio.MusicSetting::pitch
	float ___pitch_6;
	// System.Boolean DarkTonic.MasterAudio.MusicSetting::isExpanded
	bool ___isExpanded_7;
	// System.Boolean DarkTonic.MasterAudio.MusicSetting::isLoop
	bool ___isLoop_8;
	// System.Boolean DarkTonic.MasterAudio.MusicSetting::isChecked
	bool ___isChecked_9;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SongMetadataStringValue> DarkTonic.MasterAudio.MusicSetting::metadataStringValues
	List_1_t276F3FFB58A7A906339403BC623085CD16E2289F* ___metadataStringValues_10;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SongMetadataBoolValue> DarkTonic.MasterAudio.MusicSetting::metadataBoolValues
	List_1_t764B3318C9BDE224AAFBAC7C1AD5C1A98756F7CB* ___metadataBoolValues_11;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SongMetadataIntValue> DarkTonic.MasterAudio.MusicSetting::metadataIntValues
	List_1_t3295E6807A06F6BE3E1A8F50B5D6C5098A3EC627* ___metadataIntValues_12;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SongMetadataFloatValue> DarkTonic.MasterAudio.MusicSetting::metadataFloatValues
	List_1_tC3830A044518C3CA656B72DC48917082F964D5D5* ___metadataFloatValues_13;
	// System.Boolean DarkTonic.MasterAudio.MusicSetting::metadataExpanded
	bool ___metadataExpanded_14;
	// DarkTonic.MasterAudio.MasterAudio/CustomSongStartTimeMode DarkTonic.MasterAudio.MusicSetting::songStartTimeMode
	int32_t ___songStartTimeMode_15;
	// System.Single DarkTonic.MasterAudio.MusicSetting::customStartTime
	float ___customStartTime_16;
	// System.Single DarkTonic.MasterAudio.MusicSetting::customStartTimeMax
	float ___customStartTimeMax_17;
	// System.Int32 DarkTonic.MasterAudio.MusicSetting::lastKnownTimePoint
	int32_t ___lastKnownTimePoint_18;
	// System.Boolean DarkTonic.MasterAudio.MusicSetting::wasLastKnownTimePointSet
	bool ___wasLastKnownTimePointSet_19;
	// System.Int32 DarkTonic.MasterAudio.MusicSetting::songIndex
	int32_t ___songIndex_20;
	// System.Single DarkTonic.MasterAudio.MusicSetting::sectionStartTime
	float ___sectionStartTime_21;
	// System.Single DarkTonic.MasterAudio.MusicSetting::sectionEndTime
	float ___sectionEndTime_22;
	// System.Boolean DarkTonic.MasterAudio.MusicSetting::songStartedEventExpanded
	bool ___songStartedEventExpanded_23;
	// System.String DarkTonic.MasterAudio.MusicSetting::songStartedCustomEvent
	String_t* ___songStartedCustomEvent_24;
	// System.Boolean DarkTonic.MasterAudio.MusicSetting::songChangedEventExpanded
	bool ___songChangedEventExpanded_25;
	// System.String DarkTonic.MasterAudio.MusicSetting::songChangedCustomEvent
	String_t* ___songChangedCustomEvent_26;
};

// DarkTonic.MasterAudio.PlaySoundResult
struct PlaySoundResult_tC80DDE04F4A72B80791A0E79DB78708E1160BF96  : public RuntimeObject
{
	// System.Boolean DarkTonic.MasterAudio.PlaySoundResult::<SoundPlayed>k__BackingField
	bool ___U3CSoundPlayedU3Ek__BackingField_0;
	// System.Boolean DarkTonic.MasterAudio.PlaySoundResult::<SoundScheduled>k__BackingField
	bool ___U3CSoundScheduledU3Ek__BackingField_1;
	// DarkTonic.MasterAudio.SoundGroupVariation DarkTonic.MasterAudio.PlaySoundResult::<ActingVariation>k__BackingField
	SoundGroupVariation_tD53F3B1B9896DEF7C90FA02CC56EC7324AC27216* ___U3CActingVariationU3Ek__BackingField_2;
};

// DarkTonic.MasterAudio.SpatializerHelper
struct SpatializerHelper_t7BA6D101A99790F9028E62BD8932EDCD9BBC1D3C  : public RuntimeObject
{
};

// System.String
struct String_t  : public RuntimeObject
{
	// System.Int32 System.String::_stringLength
	int32_t ____stringLength_4;
	// System.Char System.String::_firstChar
	Il2CppChar ____firstChar_5;
};

struct String_t_StaticFields
{
	// System.String System.String::Empty
	String_t* ___Empty_6;
};

// DarkTonic.MasterAudio.UtilStrings
struct UtilStrings_t4A80BC4FFCF64C3C7D81006880AB283B26B8511F  : public RuntimeObject
{
};

// System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F  : public RuntimeObject
{
};
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t6D9B272BD21782F0A9A14F2E41F85A50E97A986F_marshaled_com
{
};

// DarkTonic.MasterAudio.PlaylistController/<>c__DisplayClass162_0
struct U3CU3Ec__DisplayClass162_0_tB41B59BF810A20A1FE45E4D5C3EE93BD3CFC047D  : public RuntimeObject
{
	// DarkTonic.MasterAudio.PlaylistController DarkTonic.MasterAudio.PlaylistController/<>c__DisplayClass162_0::<>4__this
	PlaylistController_t618C24E8D5BC20CD24B0640C396C9AD8E88B0806* ___U3CU3E4__this_0;
	// System.Single DarkTonic.MasterAudio.PlaylistController/<>c__DisplayClass162_0::volumeBeforeFade
	float ___volumeBeforeFade_1;
};

// System.Nullable`1<System.Double>
struct Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	double ___value_1;
};

// System.Nullable`1<System.Int32>
struct Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	int32_t ___value_1;
};

// System.Nullable`1<System.Single>
struct Nullable_1_t3D746CBB6123D4569FF4DEA60BC4240F32C6FE75 
{
	// System.Boolean System.Nullable`1::hasValue
	bool ___hasValue_0;
	// T System.Nullable`1::value
	float ___value_1;
};

// System.Boolean
struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22 
{
	// System.Boolean System.Boolean::m_value
	bool ___m_value_0;
};

struct Boolean_t09A6377A54BE2F9E6985A8149F19234FD7DDFE22_StaticFields
{
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_5;
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_6;
};

// UnityEngine.Color
struct Color_tD001788D726C3A7F1379BEED0260B9591F440C1F 
{
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;
};

// System.Int32
struct Int32_t680FF22E76F6EFAD4375103CBBFFA0421349384C 
{
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_0;
};

// System.IntPtr
struct IntPtr_t 
{
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;
};

struct IntPtr_t_StaticFields
{
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;
};

// UnityEngine.LayerMask
struct LayerMask_t97CB6BDADEDC3D6423C7BCFEA7F86DA2EC6241DB 
{
	// System.Int32 UnityEngine.LayerMask::m_Mask
	int32_t ___m_Mask_0;
};

// UnityEngine.Quaternion
struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 
{
	// System.Single UnityEngine.Quaternion::x
	float ___x_0;
	// System.Single UnityEngine.Quaternion::y
	float ___y_1;
	// System.Single UnityEngine.Quaternion::z
	float ___z_2;
	// System.Single UnityEngine.Quaternion::w
	float ___w_3;
};

struct Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974_StaticFields
{
	// UnityEngine.Quaternion UnityEngine.Quaternion::identityQuaternion
	Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___identityQuaternion_4;
};

// UnityEngine.Rect
struct Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D 
{
	// System.Single UnityEngine.Rect::m_XMin
	float ___m_XMin_0;
	// System.Single UnityEngine.Rect::m_YMin
	float ___m_YMin_1;
	// System.Single UnityEngine.Rect::m_Width
	float ___m_Width_2;
	// System.Single UnityEngine.Rect::m_Height
	float ___m_Height_3;
};

// System.Single
struct Single_t4530F2FF86FCB0DC29F35385CA1BD21BE294761C 
{
	// System.Single System.Single::m_value
	float ___m_value_0;
};

// UnityEngine.Vector3
struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 
{
	// System.Single UnityEngine.Vector3::x
	float ___x_2;
	// System.Single UnityEngine.Vector3::y
	float ___y_3;
	// System.Single UnityEngine.Vector3::z
	float ___z_4;
};

struct Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields
{
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___zeroVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___oneVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___upVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___downVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___leftVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___rightVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___forwardVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___backVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___positiveInfinityVector_13;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___negativeInfinityVector_14;
};

// System.Void
struct Void_t4861ACF8F4594C3437BB48B6E56783494B843915 
{
	union
	{
		struct
		{
		};
		uint8_t Void_t4861ACF8F4594C3437BB48B6E56783494B843915__padding[1];
	};
};

// System.Delegate
struct Delegate_t  : public RuntimeObject
{
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject* ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::extra_arg
	intptr_t ___extra_arg_5;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_6;
	// System.IntPtr System.Delegate::interp_method
	intptr_t ___interp_method_7;
	// System.IntPtr System.Delegate::interp_invoke_impl
	intptr_t ___interp_invoke_impl_8;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t* ___method_info_9;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t* ___original_method_info_10;
	// System.DelegateData System.Delegate::data
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	// System.Boolean System.Delegate::method_is_virtual
	bool ___method_is_virtual_12;
};
// Native definition for P/Invoke marshalling of System.Delegate
struct Delegate_t_marshaled_pinvoke
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};
// Native definition for COM marshalling of System.Delegate
struct Delegate_t_marshaled_com
{
	intptr_t ___method_ptr_0;
	intptr_t ___invoke_impl_1;
	Il2CppIUnknown* ___m_target_2;
	intptr_t ___method_3;
	intptr_t ___delegate_trampoline_4;
	intptr_t ___extra_arg_5;
	intptr_t ___method_code_6;
	intptr_t ___interp_method_7;
	intptr_t ___interp_invoke_impl_8;
	MethodInfo_t* ___method_info_9;
	MethodInfo_t* ___original_method_info_10;
	DelegateData_t9B286B493293CD2D23A5B2B5EF0E5B1324C2B77E* ___data_11;
	int32_t ___method_is_virtual_12;
};

// UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C  : public RuntimeObject
{
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;
};

struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_StaticFields
{
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;
};
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};

// UnityEngine.Component
struct Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// UnityEngine.GameObject
struct GameObject_t76FEDD663AB33C991A9C9A23129337651094216F  : public Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C
{
};

// System.MulticastDelegate
struct MulticastDelegate_t  : public Delegate_t
{
	// System.Delegate[] System.MulticastDelegate::delegates
	DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771* ___delegates_13;
};
// Native definition for P/Invoke marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_pinvoke : public Delegate_t_marshaled_pinvoke
{
	Delegate_t_marshaled_pinvoke** ___delegates_13;
};
// Native definition for COM marshalling of System.MulticastDelegate
struct MulticastDelegate_t_marshaled_com : public Delegate_t_marshaled_com
{
	Delegate_t_marshaled_com** ___delegates_13;
};

// System.Action
struct Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07  : public MulticastDelegate_t
{
};

// System.AsyncCallback
struct AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C  : public MulticastDelegate_t
{
};

// UnityEngine.Behaviour
struct Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.ParticleSystem
struct ParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// UnityEngine.Transform
struct Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1  : public Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3
{
};

// DarkTonic.MasterAudio.PlaylistController/PlaylistEndedEventHandler
struct PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016  : public MulticastDelegate_t
{
};

// DarkTonic.MasterAudio.PlaylistController/SongChangedEventHandler
struct SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519  : public MulticastDelegate_t
{
};

// DarkTonic.MasterAudio.PlaylistController/SongEndedEventHandler
struct SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC  : public MulticastDelegate_t
{
};

// DarkTonic.MasterAudio.PlaylistController/SongLoopedEventHandler
struct SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE  : public MulticastDelegate_t
{
};

// UnityEngine.AudioBehaviour
struct AudioBehaviour_t2DC0BEF7B020C952F3D2DA5AAAC88501C7EEB941  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// UnityEngine.MonoBehaviour
struct MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71  : public Behaviour_t01970CFBBA658497AE30F311C447DB0440BAB7FA
{
};

// UnityEngine.AudioSource
struct AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299  : public AudioBehaviour_t2DC0BEF7B020C952F3D2DA5AAAC88501C7EEB941
{
};

// DarkTonic.MasterAudio.Examples.MA_Bootstrapper
struct MA_Bootstrapper_t3C33A30BC81199B87CF3B8B066BFF092AF052887  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// DarkTonic.MasterAudio.Examples.MA_DestroyFinishedParticle
struct MA_DestroyFinishedParticle_tBD633205873167544519D41760934A254D47B8CB  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.ParticleSystem DarkTonic.MasterAudio.Examples.MA_DestroyFinishedParticle::particles
	ParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1* ___particles_4;
};

// DarkTonic.MasterAudio.Examples.MA_EnemyOne
struct MA_EnemyOne_t7D3293CA87F514A361A57200B85C47D7BC5A00D6  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.GameObject DarkTonic.MasterAudio.Examples.MA_EnemyOne::ExplosionParticlePrefab
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___ExplosionParticlePrefab_4;
	// UnityEngine.Transform DarkTonic.MasterAudio.Examples.MA_EnemyOne::_trans
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____trans_5;
	// System.Single DarkTonic.MasterAudio.Examples.MA_EnemyOne::_speed
	float ____speed_6;
	// System.Single DarkTonic.MasterAudio.Examples.MA_EnemyOne::_horizSpeed
	float ____horizSpeed_7;
};

// DarkTonic.MasterAudio.Examples.MA_EnemySpawner
struct MA_EnemySpawner_t21E3F60FD5616FE485106C6880615D53C44AC9A1  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.GameObject DarkTonic.MasterAudio.Examples.MA_EnemySpawner::Enemy
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___Enemy_4;
	// System.Boolean DarkTonic.MasterAudio.Examples.MA_EnemySpawner::spawnerEnabled
	bool ___spawnerEnabled_5;
	// UnityEngine.Transform DarkTonic.MasterAudio.Examples.MA_EnemySpawner::trans
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans_6;
	// System.Single DarkTonic.MasterAudio.Examples.MA_EnemySpawner::nextSpawnTime
	float ___nextSpawnTime_7;
};

// DarkTonic.MasterAudio.Examples.MA_GameScene
struct MA_GameScene_tFA5987AFF419EF0C0BBDBB2611D19045C146B97C  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// DarkTonic.MasterAudio.Examples.MA_Laser
struct MA_Laser_t8DE63150FD4B0E65D8772D9F6812D78B392544FC  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.Transform DarkTonic.MasterAudio.Examples.MA_Laser::_trans
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____trans_4;
};

// DarkTonic.MasterAudio.Examples.MA_LocalizationUI
struct MA_LocalizationUI_t99D3717E29D5024181A096A0A13590D653FDA07E  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// DarkTonic.MasterAudio.Examples.MA_PlayerControl
struct MA_PlayerControl_tFA26225B0C306D27C50F028D7542C1300CF00BA2  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.GameObject DarkTonic.MasterAudio.Examples.MA_PlayerControl::ProjectilePrefab
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___ProjectilePrefab_4;
	// System.Boolean DarkTonic.MasterAudio.Examples.MA_PlayerControl::canShoot
	bool ___canShoot_5;
	// UnityEngine.Transform DarkTonic.MasterAudio.Examples.MA_PlayerControl::_trans
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____trans_7;
	// System.Single DarkTonic.MasterAudio.Examples.MA_PlayerControl::_lastMoveAmt
	float ____lastMoveAmt_8;
};

// DarkTonic.MasterAudio.Examples.MA_PlayerSpawnerControl
struct MA_PlayerSpawnerControl_t87E7E9177332BA2683259C0211587134DE637203  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// UnityEngine.GameObject DarkTonic.MasterAudio.Examples.MA_PlayerSpawnerControl::Player
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___Player_4;
	// System.Single DarkTonic.MasterAudio.Examples.MA_PlayerSpawnerControl::nextSpawnTime
	float ___nextSpawnTime_5;
};

// DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver
struct MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// System.Collections.Generic.List`1<System.String> DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::_eventsSubscribedTo
	List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ____eventsSubscribedTo_4;
};

// DarkTonic.MasterAudio.Examples.MA_TestUI
struct MA_TestUI_t938B2C6124B2D23E707E3F661D34922A49CE71E0  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// DarkTonic.MasterAudio.MasterAudio
struct MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// DarkTonic.MasterAudio.MasterAudio/AudioLocation DarkTonic.MasterAudio.MasterAudio::bulkLocationMode
	int32_t ___bulkLocationMode_35;
	// System.String DarkTonic.MasterAudio.MasterAudio::groupTemplateName
	String_t* ___groupTemplateName_36;
	// System.String DarkTonic.MasterAudio.MasterAudio::audioSourceTemplateName
	String_t* ___audioSourceTemplateName_37;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showGroupCreation
	bool ___showGroupCreation_38;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::useGroupTemplates
	bool ___useGroupTemplates_39;
	// DarkTonic.MasterAudio.MasterAudio/DragGroupMode DarkTonic.MasterAudio.MasterAudio::curDragGroupMode
	int32_t ___curDragGroupMode_40;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> DarkTonic.MasterAudio.MasterAudio::groupTemplates
	List_1_tB951CE80B58D1BF9650862451D8DAD8C231F207B* ___groupTemplates_41;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> DarkTonic.MasterAudio.MasterAudio::audioSourceTemplates
	List_1_tB951CE80B58D1BF9650862451D8DAD8C231F207B* ___audioSourceTemplates_42;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::mixerMuted
	bool ___mixerMuted_43;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::playlistsMuted
	bool ___playlistsMuted_44;
	// DarkTonic.MasterAudio.MasterAudio/LanguageMode DarkTonic.MasterAudio.MasterAudio::langMode
	int32_t ___langMode_45;
	// UnityEngine.SystemLanguage DarkTonic.MasterAudio.MasterAudio::testLanguage
	int32_t ___testLanguage_46;
	// UnityEngine.SystemLanguage DarkTonic.MasterAudio.MasterAudio::defaultLanguage
	int32_t ___defaultLanguage_47;
	// System.Collections.Generic.List`1<UnityEngine.SystemLanguage> DarkTonic.MasterAudio.MasterAudio::supportedLanguages
	List_1_t8CC720FCDC45DA24733B888EA21D38A58C71A516* ___supportedLanguages_48;
	// System.String DarkTonic.MasterAudio.MasterAudio::busFilter
	String_t* ___busFilter_49;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::useTextGroupFilter
	bool ___useTextGroupFilter_50;
	// System.String DarkTonic.MasterAudio.MasterAudio::textGroupFilter
	String_t* ___textGroupFilter_51;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::resourceClipsPauseDoNotUnload
	bool ___resourceClipsPauseDoNotUnload_52;
	// UnityEngine.Transform DarkTonic.MasterAudio.MasterAudio::playlistControllerPrefab
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___playlistControllerPrefab_53;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::persistBetweenScenes
	bool ___persistBetweenScenes_54;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::shouldLogDestroys
	bool ___shouldLogDestroys_55;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showBusColors
	bool ___showBusColors_56;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showGroupImportance
	bool ___showGroupImportance_57;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::areGroupsExpanded
	bool ___areGroupsExpanded_58;
	// UnityEngine.Transform DarkTonic.MasterAudio.MasterAudio::soundGroupTemplate
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___soundGroupTemplate_59;
	// UnityEngine.Transform DarkTonic.MasterAudio.MasterAudio::soundGroupVariationTemplate
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___soundGroupVariationTemplate_60;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.GroupBus> DarkTonic.MasterAudio.MasterAudio::groupBuses
	List_1_t51CDEFF7CE3C500BC2A0B91F1F8F79A405812083* ___groupBuses_61;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::groupByBus
	bool ___groupByBus_62;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::sortAlpha
	bool ___sortAlpha_63;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showRangeSoundGizmos
	bool ___showRangeSoundGizmos_64;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showSelectedRangeSoundGizmos
	bool ___showSelectedRangeSoundGizmos_65;
	// UnityEngine.Color DarkTonic.MasterAudio.MasterAudio::rangeGizmoColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___rangeGizmoColor_66;
	// UnityEngine.Color DarkTonic.MasterAudio.MasterAudio::selectedRangeGizmoColor
	Color_tD001788D726C3A7F1379BEED0260B9591F440C1F ___selectedRangeGizmoColor_67;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showAdvancedSettings
	bool ___showAdvancedSettings_68;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showLocalization
	bool ___showLocalization_69;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showVideoPlayerSettings
	bool ___showVideoPlayerSettings_70;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::useTextPlaylistFilter
	bool ___useTextPlaylistFilter_71;
	// System.String DarkTonic.MasterAudio.MasterAudio::textPlaylistFilter
	String_t* ___textPlaylistFilter_72;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::playListExpanded
	bool ___playListExpanded_73;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::playlistsExpanded
	bool ___playlistsExpanded_74;
	// DarkTonic.MasterAudio.MasterAudio/AllMusicSpatialBlendType DarkTonic.MasterAudio.MasterAudio::musicSpatialBlendType
	int32_t ___musicSpatialBlendType_75;
	// System.Single DarkTonic.MasterAudio.MasterAudio::musicSpatialBlend
	float ___musicSpatialBlend_76;
	// DarkTonic.MasterAudio.MasterAudio/AllMixerSpatialBlendType DarkTonic.MasterAudio.MasterAudio::mixerSpatialBlendType
	int32_t ___mixerSpatialBlendType_77;
	// System.Single DarkTonic.MasterAudio.MasterAudio::mixerSpatialBlend
	float ___mixerSpatialBlend_78;
	// DarkTonic.MasterAudio.MasterAudio/GroupPlayType DarkTonic.MasterAudio.MasterAudio::groupPlayType
	int32_t ___groupPlayType_79;
	// DarkTonic.MasterAudio.MasterAudio/DefaultGroupPlayType DarkTonic.MasterAudio.MasterAudio::defaultGroupPlayType
	int32_t ___defaultGroupPlayType_80;
	// DarkTonic.MasterAudio.MasterAudio/ItemSpatialBlendType DarkTonic.MasterAudio.MasterAudio::newGroupSpatialType
	int32_t ___newGroupSpatialType_81;
	// System.Single DarkTonic.MasterAudio.MasterAudio::newGroupSpatialBlend
	float ___newGroupSpatialBlend_82;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MasterAudio/Playlist> DarkTonic.MasterAudio.MasterAudio::musicPlaylists
	List_1_t19AA6BC54785CD8C9D8290529CB22BFD06B5DCB2* ___musicPlaylists_83;
	// System.Single DarkTonic.MasterAudio.MasterAudio::_masterAudioVolume
	float ____masterAudioVolume_84;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::vrSettingsExpanded
	bool ___vrSettingsExpanded_85;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::useSpatializer
	bool ___useSpatializer_86;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::useSpatializerPostFX
	bool ___useSpatializerPostFX_87;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::addOculusAudioSources
	bool ___addOculusAudioSources_88;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::addResonanceAudioSources
	bool ___addResonanceAudioSources_89;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::ignoreTimeScale
	bool ___ignoreTimeScale_90;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::useGaplessPlaylists
	bool ___useGaplessPlaylists_91;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::useGaplessAutoReschedule
	bool ___useGaplessAutoReschedule_92;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::saveRuntimeChanges
	bool ___saveRuntimeChanges_93;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::prioritizeOnDistance
	bool ___prioritizeOnDistance_94;
	// System.Int32 DarkTonic.MasterAudio.MasterAudio::rePrioritizeEverySecIndex
	int32_t ___rePrioritizeEverySecIndex_95;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::useOcclusion
	bool ___useOcclusion_96;
	// System.Single DarkTonic.MasterAudio.MasterAudio::occlusionMaxCutoffFreq
	float ___occlusionMaxCutoffFreq_97;
	// System.Single DarkTonic.MasterAudio.MasterAudio::occlusionMinCutoffFreq
	float ___occlusionMinCutoffFreq_98;
	// System.Single DarkTonic.MasterAudio.MasterAudio::occlusionFreqChangeSeconds
	float ___occlusionFreqChangeSeconds_99;
	// DarkTonic.MasterAudio.MasterAudio/OcclusionSelectionType DarkTonic.MasterAudio.MasterAudio::occlusionSelectType
	int32_t ___occlusionSelectType_100;
	// System.Int32 DarkTonic.MasterAudio.MasterAudio::occlusionMaxRayCastsPerFrame
	int32_t ___occlusionMaxRayCastsPerFrame_101;
	// System.Single DarkTonic.MasterAudio.MasterAudio::occlusionRayCastOffset
	float ___occlusionRayCastOffset_102;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::occlusionUseLayerMask
	bool ___occlusionUseLayerMask_103;
	// UnityEngine.LayerMask DarkTonic.MasterAudio.MasterAudio::occlusionLayerMask
	LayerMask_t97CB6BDADEDC3D6423C7BCFEA7F86DA2EC6241DB ___occlusionLayerMask_104;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::occlusionShowRaycasts
	bool ___occlusionShowRaycasts_105;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::occlusionShowCategories
	bool ___occlusionShowCategories_106;
	// DarkTonic.MasterAudio.MasterAudio/RaycastMode DarkTonic.MasterAudio.MasterAudio::occlusionRaycastMode
	int32_t ___occlusionRaycastMode_107;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::occlusionIncludeStartRaycast2DCollider
	bool ___occlusionIncludeStartRaycast2DCollider_108;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::occlusionRaycastsHitTriggers
	bool ___occlusionRaycastsHitTriggers_109;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::ambientAdvancedExpanded
	bool ___ambientAdvancedExpanded_110;
	// System.Int32 DarkTonic.MasterAudio.MasterAudio::ambientMaxRecalcsPerFrame
	int32_t ___ambientMaxRecalcsPerFrame_111;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::visualAdvancedExpanded
	bool ___visualAdvancedExpanded_112;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::logAdvancedExpanded
	bool ___logAdvancedExpanded_113;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::listenerAdvancedExpanded
	bool ___listenerAdvancedExpanded_114;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::listenerFollowerHasRigidBody
	bool ___listenerFollowerHasRigidBody_115;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::deletePreviewerAudioSourceWhenPlaying
	bool ___deletePreviewerAudioSourceWhenPlaying_116;
	// DarkTonic.MasterAudio.MasterAudio/VariationFollowerType DarkTonic.MasterAudio.MasterAudio::variationFollowerType
	int32_t ___variationFollowerType_117;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showFadingSettings
	bool ___showFadingSettings_118;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::stopZeroVolumeGroups
	bool ___stopZeroVolumeGroups_119;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::stopZeroVolumeBuses
	bool ___stopZeroVolumeBuses_120;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::stopZeroVolumePlaylists
	bool ___stopZeroVolumePlaylists_121;
	// System.Single DarkTonic.MasterAudio.MasterAudio::stopOldestBusFadeTime
	float ___stopOldestBusFadeTime_122;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::resourceAdvancedExpanded
	bool ___resourceAdvancedExpanded_123;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::useClipAgePriority
	bool ___useClipAgePriority_124;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::logOutOfVoices
	bool ___logOutOfVoices_125;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::LogSounds
	bool ___LogSounds_126;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::logCustomEvents
	bool ___logCustomEvents_127;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::disableLogging
	bool ___disableLogging_128;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showMusicDucking
	bool ___showMusicDucking_129;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::enableMusicDucking
	bool ___enableMusicDucking_130;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.DuckGroupInfo> DarkTonic.MasterAudio.MasterAudio::musicDuckingSounds
	List_1_tE0BEE1CBE27E6FDCABCECDABBE144DC388B59692* ___musicDuckingSounds_131;
	// System.Single DarkTonic.MasterAudio.MasterAudio::defaultRiseVolStart
	float ___defaultRiseVolStart_132;
	// System.Single DarkTonic.MasterAudio.MasterAudio::defaultUnduckTime
	float ___defaultUnduckTime_133;
	// System.Single DarkTonic.MasterAudio.MasterAudio::defaultDuckedVolumeCut
	float ___defaultDuckedVolumeCut_134;
	// System.Single DarkTonic.MasterAudio.MasterAudio::crossFadeTime
	float ___crossFadeTime_135;
	// System.Single DarkTonic.MasterAudio.MasterAudio::_masterPlaylistVolume
	float ____masterPlaylistVolume_136;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showGroupSelect
	bool ___showGroupSelect_137;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::hideGroupsWithNoActiveVars
	bool ___hideGroupsWithNoActiveVars_138;
	// DarkTonic.MasterAudio.MasterAudio/JukeBoxDisplayMode DarkTonic.MasterAudio.MasterAudio::jukeBoxDisplayMode
	int32_t ___jukeBoxDisplayMode_139;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::logPerfExpanded
	bool ___logPerfExpanded_140;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::willWarm
	bool ___willWarm_141;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::mixerSettingsExpanded
	bool ___mixerSettingsExpanded_142;
	// UnityEngine.Audio.AudioMixerUpdateMode DarkTonic.MasterAudio.MasterAudio::mixerUpdateMode
	int32_t ___mixerUpdateMode_143;
	// System.String DarkTonic.MasterAudio.MasterAudio::newEventName
	String_t* ___newEventName_144;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showCustomEvents
	bool ___showCustomEvents_145;
	// System.String DarkTonic.MasterAudio.MasterAudio::newCustomEventCategoryName
	String_t* ___newCustomEventCategoryName_146;
	// System.String DarkTonic.MasterAudio.MasterAudio::addToCustomEventCategoryName
	String_t* ___addToCustomEventCategoryName_147;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.CustomEvent> DarkTonic.MasterAudio.MasterAudio::customEvents
	List_1_tD3A8C581E25B2E07CE926E9AF765150DAF77D141* ___customEvents_148;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.CustomEventCategory> DarkTonic.MasterAudio.MasterAudio::customEventCategories
	List_1_t148EBB8E073798AB5AF07804D9E567AB1320D0BC* ___customEventCategories_149;
	// System.Collections.Generic.Dictionary`2<System.String,DarkTonic.MasterAudio.DuckGroupInfo> DarkTonic.MasterAudio.MasterAudio::duckingBySoundType
	Dictionary_2_tC787C52A6EEA9600C99DCF36A3312103B4BB2DD3* ___duckingBySoundType_150;
	// System.Int32 DarkTonic.MasterAudio.MasterAudio::frames
	int32_t ___frames_151;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::showUnityMixerGroupAssignment
	bool ___showUnityMixerGroupAssignment_152;
	// System.Collections.Generic.Dictionary`2<System.String,DarkTonic.MasterAudio.MasterAudio/AudioGroupInfo> DarkTonic.MasterAudio.MasterAudio::AudioSourcesBySoundType
	Dictionary_2_t653F2A87D06D3C44171928C93E124BBFB5DBF0A4* ___AudioSourcesBySoundType_155;
	// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>> DarkTonic.MasterAudio.MasterAudio::_randomizer
	Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* ____randomizer_156;
	// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>> DarkTonic.MasterAudio.MasterAudio::_randomizerOrigin
	Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* ____randomizerOrigin_157;
	// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>> DarkTonic.MasterAudio.MasterAudio::_randomizerLeftovers
	Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* ____randomizerLeftovers_158;
	// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>> DarkTonic.MasterAudio.MasterAudio::_nonRandomChoices
	Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* ____nonRandomChoices_159;
	// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.List`1<System.Int32>> DarkTonic.MasterAudio.MasterAudio::_clipsPlayedBySoundTypeOldestFirst
	Dictionary_2_t6FFAD029BB474A5257D9A441504B633831AF5341* ____clipsPlayedBySoundTypeOldestFirst_160;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SoundGroupVariationUpdater> DarkTonic.MasterAudio.MasterAudio::ActiveVariationUpdaters
	List_1_tF19310A6F7A43D81B39CFDAB360194B2712C5BBE* ___ActiveVariationUpdaters_161;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SoundGroupVariationUpdater> DarkTonic.MasterAudio.MasterAudio::ActiveUpdatersToRemove
	List_1_tF19310A6F7A43D81B39CFDAB360194B2712C5BBE* ___ActiveUpdatersToRemove_162;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.ICustomEventReceiver> DarkTonic.MasterAudio.MasterAudio::ValidReceivers
	List_1_t1C72E807760F1F86D2E72CCFB7B7E97EECF82BC8* ___ValidReceivers_163;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MasterAudio/CustomEventCandidate> DarkTonic.MasterAudio.MasterAudio::ValidReceiverCandidates
	List_1_t6171BB0B43CB8F27D0D9790F346895B57BFF45C8* ___ValidReceiverCandidates_164;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MasterAudioGroup> DarkTonic.MasterAudio.MasterAudio::SoloedGroups
	List_1_t2A8E597C2110CD2D0CF5A5AAAC6C906545F78BC8* ___SoloedGroups_165;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.AmbientSoundToTriggerInfo> DarkTonic.MasterAudio.MasterAudio::AmbientsToDelayedTrigger
	List_1_tA143A459DB11541564964D118D17881AF5AC0F81* ___AmbientsToDelayedTrigger_166;
	// System.Collections.Generic.Queue`1<DarkTonic.MasterAudio.CustomEventToFireInfo> DarkTonic.MasterAudio.MasterAudio::CustomEventsToFire
	Queue_1_tB56B6EB1E312C083BDA3ED2EC142DF70556BD7CD* ___CustomEventsToFire_167;
	// System.Collections.Generic.Queue`1<TransformFollower> DarkTonic.MasterAudio.MasterAudio::TransFollowerColliderPositionRecalcs
	Queue_1_tEE30610AD17F1BC5F5DB780E1992BF6BC21455A1* ___TransFollowerColliderPositionRecalcs_168;
	// System.Collections.Generic.List`1<TransformFollower> DarkTonic.MasterAudio.MasterAudio::ProcessedColliderPositionRecalcs
	List_1_tF7CEA64906A8DB0EF3F400307E2678D2FA686FD8* ___ProcessedColliderPositionRecalcs_169;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.BusFadeInfo> DarkTonic.MasterAudio.MasterAudio::BusFades
	List_1_tF1DD45D0D84375C6DB14D5C04969497C77E5D47B* ___BusFades_170;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.GroupFadeInfo> DarkTonic.MasterAudio.MasterAudio::GroupFades
	List_1_t8A061A03AFBEE095AE1AC17C594F9E8F3E4B6353* ___GroupFades_171;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.GroupPitchGlideInfo> DarkTonic.MasterAudio.MasterAudio::GroupPitchGlides
	List_1_tCE4016530FFAB572C7A2BC760B90BA65C1BBDA5E* ___GroupPitchGlides_172;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.BusPitchGlideInfo> DarkTonic.MasterAudio.MasterAudio::BusPitchGlides
	List_1_tB76EBB877F18C7C240CB26BC0FBC9FB792107FFC* ___BusPitchGlides_173;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.OcclusionFreqChangeInfo> DarkTonic.MasterAudio.MasterAudio::VariationOcclusionFreqChanges
	List_1_t73FEEFFA5D873C807DDB2334CF32815519532AB0* ___VariationOcclusionFreqChanges_174;
	// System.Collections.Generic.List`1<UnityEngine.AudioSource> DarkTonic.MasterAudio.MasterAudio::AllAudioSources
	List_1_t0EDD1795F87849390F5CA17CBABE75183BE4E235* ___AllAudioSources_175;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.BusDuckInfo> DarkTonic.MasterAudio.MasterAudio::BusDucks
	List_1_t4E85B0D46307B1B7D2E01394EFCB4EF8478E6048* ___BusDucks_176;
	// System.Collections.Generic.Dictionary`2<System.String,System.Collections.Generic.Dictionary`2<DarkTonic.MasterAudio.ICustomEventReceiver,UnityEngine.Transform>> DarkTonic.MasterAudio.MasterAudio::ReceiversByEventName
	Dictionary_2_t331F4B207DC254D36ACB961A0A9EAECAB8756AA4* ___ReceiversByEventName_177;
	// System.Collections.Generic.Dictionary`2<System.String,DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.MasterAudio::PlaylistControllersByName
	Dictionary_2_tB3C963DAC18787740A7F6E0AB620CBFE4A00A48B* ___PlaylistControllersByName_178;
	// System.Collections.Generic.Dictionary`2<System.String,DarkTonic.MasterAudio.MasterAudio/SoundGroupRefillInfo> DarkTonic.MasterAudio.MasterAudio::LastTimeSoundGroupPlayed
	Dictionary_2_tE1AC22D7C8D1919312A8248A19586F6F696A6D5D* ___LastTimeSoundGroupPlayed_179;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> DarkTonic.MasterAudio.MasterAudio::OcclusionSourcesInRange
	List_1_tB951CE80B58D1BF9650862451D8DAD8C231F207B* ___OcclusionSourcesInRange_180;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> DarkTonic.MasterAudio.MasterAudio::OcclusionSourcesOutOfRange
	List_1_tB951CE80B58D1BF9650862451D8DAD8C231F207B* ___OcclusionSourcesOutOfRange_181;
	// System.Collections.Generic.List`1<UnityEngine.GameObject> DarkTonic.MasterAudio.MasterAudio::OcclusionSourcesBlocked
	List_1_tB951CE80B58D1BF9650862451D8DAD8C231F207B* ___OcclusionSourcesBlocked_182;
	// System.Collections.Generic.Queue`1<DarkTonic.MasterAudio.SoundGroupVariationUpdater> DarkTonic.MasterAudio.MasterAudio::QueuedOcclusionRays
	Queue_1_tDA922A4DF99D23BE627D0930913AA4FD11F141DD* ___QueuedOcclusionRays_183;
	// System.Collections.Generic.List`1<System.String> DarkTonic.MasterAudio.MasterAudio::AllSoundGroupNames
	List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ___AllSoundGroupNames_184;
	// System.Collections.Generic.List`1<System.String> DarkTonic.MasterAudio.MasterAudio::AllBusNames
	List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ___AllBusNames_185;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MasterAudio/AudioInfo> DarkTonic.MasterAudio.MasterAudio::GroupsToDelete
	List_1_t89A671920E5A4C32C65F8CF2F608849CF6B085D3* ___GroupsToDelete_186;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.SoundGroupVariation> DarkTonic.MasterAudio.MasterAudio::VariationsStartedDuringMultiStop
	List_1_t0DF2EE0CA3814256E39537F560D0B8BE7ADEA258* ___VariationsStartedDuringMultiStop_187;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.MasterAudio::ControllersToPause
	List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C* ___ControllersToPause_188;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.MasterAudio::ControllersToUnpause
	List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C* ___ControllersToUnpause_189;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.MasterAudio::ControllersToMute
	List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C* ___ControllersToMute_190;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.MasterAudio::ControllersToUnmute
	List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C* ___ControllersToUnmute_191;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.MasterAudio::ControllersToToggleMute
	List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C* ___ControllersToToggleMute_192;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.MasterAudio::ControllersToStop
	List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C* ___ControllersToStop_193;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.MasterAudio::ControllersToFade
	List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C* ___ControllersToFade_194;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.MasterAudio::ControllersToTrigNext
	List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C* ___ControllersToTrigNext_195;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.MasterAudio::ControllersToTrigRandom
	List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C* ___ControllersToTrigRandom_196;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.MasterAudio::ControllersToStart
	List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C* ___ControllersToStart_197;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.AmbientSoundToTriggerInfo> DarkTonic.MasterAudio.MasterAudio::AmbientsToTriggerNow
	List_1_tA143A459DB11541564964D118D17881AF5AC0F81* ___AmbientsToTriggerNow_198;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::_isStoppingMultiple
	bool ____isStoppingMultiple_199;
	// System.Single DarkTonic.MasterAudio.MasterAudio::_repriTime
	float ____repriTime_200;
	// System.Collections.Generic.List`1<System.String> DarkTonic.MasterAudio.MasterAudio::_groupsToRemove
	List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ____groupsToRemove_201;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::_mustRescanGroups
	bool ____mustRescanGroups_202;
	// UnityEngine.Transform DarkTonic.MasterAudio.MasterAudio::_trans
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____trans_203;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::_soundsLoaded
	bool ____soundsLoaded_204;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::_warming
	bool ____warming_205;
};

struct MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_StaticFields
{
	// UnityEngine.YieldInstruction DarkTonic.MasterAudio.MasterAudio::EndOfFrameDelay
	YieldInstruction_tFCE35FD0907950EFEE9BC2890AC664E41C53728D* ___EndOfFrameDelay_21;
	// System.Collections.Generic.List`1<System.String> DarkTonic.MasterAudio.MasterAudio::ExemptChildNames
	List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ___ExemptChildNames_22;
	// System.Collections.Generic.HashSet`1<System.Int32> DarkTonic.MasterAudio.MasterAudio::ErrorNumbersLogged
	HashSet_1_t4A2F2B74276D0AD3ED0F873045BD61E9504ECAE2* ___ErrorNumbersLogged_23;
	// System.Collections.Generic.List`1<System.String> DarkTonic.MasterAudio.MasterAudio::ImportanceChoices
	List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* ___ImportanceChoices_24;
	// System.Action DarkTonic.MasterAudio.MasterAudio::NumberOfAudioSourcesChanged
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___NumberOfAudioSourcesChanged_25;
	// DarkTonic.MasterAudio.PlaySoundResult DarkTonic.MasterAudio.MasterAudio::AndForgetSuccessResult
	PlaySoundResult_tC80DDE04F4A72B80791A0E79DB78708E1160BF96* ___AndForgetSuccessResult_153;
	// DarkTonic.MasterAudio.PlaySoundResult DarkTonic.MasterAudio.MasterAudio::failedResultDuringInit
	PlaySoundResult_tC80DDE04F4A72B80791A0E79DB78708E1160BF96* ___failedResultDuringInit_154;
	// DarkTonic.MasterAudio.MasterAudio DarkTonic.MasterAudio.MasterAudio::_instance
	MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558* ____instance_206;
	// System.String DarkTonic.MasterAudio.MasterAudio::_prospectiveMAFolder
	String_t* ____prospectiveMAFolder_207;
	// UnityEngine.Transform DarkTonic.MasterAudio.MasterAudio::_listenerTrans
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____listenerTrans_208;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MasterAudio/SoundGroupCommand> DarkTonic.MasterAudio.MasterAudio::GroupCommandsWithNoGroupSelector
	List_1_tE5C5C7B7F0D76393E51AF8EEC349693AF78222E7* ___GroupCommandsWithNoGroupSelector_209;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MasterAudio/SoundGroupCommand> DarkTonic.MasterAudio.MasterAudio::GroupCommandsWithNoAllGroupSelector
	List_1_tE5C5C7B7F0D76393E51AF8EEC349693AF78222E7* ___GroupCommandsWithNoAllGroupSelector_210;
	// System.Boolean DarkTonic.MasterAudio.MasterAudio::<AppIsShuttingDown>k__BackingField
	bool ___U3CAppIsShuttingDownU3Ek__BackingField_211;
};

// DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter
struct MasterAudioMultiplayerAdapter_t41A811EE167500BE05C8479E0BFFEA15617E924D  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
};

// DarkTonic.MasterAudio.PlaylistController
struct PlaylistController_t618C24E8D5BC20CD24B0640C396C9AD8E88B0806  : public MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71
{
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::startPlaylistOnAwake
	bool ___startPlaylistOnAwake_11;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::isShuffle
	bool ___isShuffle_12;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::isAutoAdvance
	bool ___isAutoAdvance_13;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::loopPlaylist
	bool ___loopPlaylist_14;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_playlistVolume
	float ____playlistVolume_15;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::isMuted
	bool ___isMuted_16;
	// System.String DarkTonic.MasterAudio.PlaylistController::startPlaylistName
	String_t* ___startPlaylistName_17;
	// System.Int32 DarkTonic.MasterAudio.PlaylistController::syncGroupNum
	int32_t ___syncGroupNum_18;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::ignoreListenerPause
	bool ___ignoreListenerPause_19;
	// UnityEngine.Audio.AudioMixerGroup DarkTonic.MasterAudio.PlaylistController::mixerChannel
	AudioMixerGroup_tD29AC8336F7425DF007944F8195CEABF34FC3311* ___mixerChannel_20;
	// DarkTonic.MasterAudio.MasterAudio/ItemSpatialBlendType DarkTonic.MasterAudio.PlaylistController::spatialBlendType
	int32_t ___spatialBlendType_21;
	// System.Single DarkTonic.MasterAudio.PlaylistController::spatialBlend
	float ___spatialBlend_22;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::initializedEventExpanded
	bool ___initializedEventExpanded_23;
	// System.String DarkTonic.MasterAudio.PlaylistController::initializedCustomEvent
	String_t* ___initializedCustomEvent_24;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::crossfadeStartedExpanded
	bool ___crossfadeStartedExpanded_25;
	// System.String DarkTonic.MasterAudio.PlaylistController::crossfadeStartedCustomEvent
	String_t* ___crossfadeStartedCustomEvent_26;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::songChangedEventExpanded
	bool ___songChangedEventExpanded_27;
	// System.String DarkTonic.MasterAudio.PlaylistController::songChangedCustomEvent
	String_t* ___songChangedCustomEvent_28;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::songEndedEventExpanded
	bool ___songEndedEventExpanded_29;
	// System.String DarkTonic.MasterAudio.PlaylistController::songEndedCustomEvent
	String_t* ___songEndedCustomEvent_30;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::songLoopedEventExpanded
	bool ___songLoopedEventExpanded_31;
	// System.String DarkTonic.MasterAudio.PlaylistController::songLoopedCustomEvent
	String_t* ___songLoopedCustomEvent_32;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::playlistStartedEventExpanded
	bool ___playlistStartedEventExpanded_33;
	// System.String DarkTonic.MasterAudio.PlaylistController::playlistStartedCustomEvent
	String_t* ___playlistStartedCustomEvent_34;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::playlistEndedEventExpanded
	bool ___playlistEndedEventExpanded_35;
	// System.String DarkTonic.MasterAudio.PlaylistController::playlistEndedCustomEvent
	String_t* ___playlistEndedCustomEvent_36;
	// UnityEngine.AudioSource DarkTonic.MasterAudio.PlaylistController::_activeAudio
	AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* ____activeAudio_37;
	// UnityEngine.AudioSource DarkTonic.MasterAudio.PlaylistController::_transitioningAudio
	AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* ____transitioningAudio_38;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_activeAudioEndVolume
	float ____activeAudioEndVolume_39;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_transitioningAudioStartVolume
	float ____transitioningAudioStartVolume_40;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_crossFadeStartTime
	float ____crossFadeStartTime_41;
	// System.Collections.Generic.List`1<System.Int32> DarkTonic.MasterAudio.PlaylistController::_clipsRemaining
	List_1_t05915E9237850A58106982B7FE4BC5DA4E872E73* ____clipsRemaining_42;
	// System.Int32 DarkTonic.MasterAudio.PlaylistController::_currentSequentialClipIndex
	int32_t ____currentSequentialClipIndex_43;
	// DarkTonic.MasterAudio.PlaylistController/AudioDuckingMode DarkTonic.MasterAudio.PlaylistController::_duckingMode
	int32_t ____duckingMode_44;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_timeToStartUnducking
	float ____timeToStartUnducking_45;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_timeToFinishUnducking
	float ____timeToFinishUnducking_46;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_originalMusicVolume
	float ____originalMusicVolume_47;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_initialDuckVolume
	float ____initialDuckVolume_48;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_duckRange
	float ____duckRange_49;
	// DarkTonic.MasterAudio.SoundGroupVariationUpdater DarkTonic.MasterAudio.PlaylistController::_actorUpdater
	SoundGroupVariationUpdater_t080206521A9418F8FE225088E7EA25B10841F6A3* ____actorUpdater_50;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_unduckTime
	float ____unduckTime_51;
	// DarkTonic.MasterAudio.MusicSetting DarkTonic.MasterAudio.PlaylistController::_currentSong
	MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9* ____currentSong_52;
	// UnityEngine.GameObject DarkTonic.MasterAudio.PlaylistController::_go
	GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ____go_53;
	// System.String DarkTonic.MasterAudio.PlaylistController::_name
	String_t* ____name_54;
	// DarkTonic.MasterAudio.PlaylistController/FadeMode DarkTonic.MasterAudio.PlaylistController::_curFadeMode
	int32_t ____curFadeMode_55;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_slowFadeStartTime
	float ____slowFadeStartTime_56;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_slowFadeCompletionTime
	float ____slowFadeCompletionTime_57;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_slowFadeStartVolume
	float ____slowFadeStartVolume_58;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_slowFadeTargetVolume
	float ____slowFadeTargetVolume_59;
	// DarkTonic.MasterAudio.MasterAudio/Playlist DarkTonic.MasterAudio.PlaylistController::_currentPlaylist
	Playlist_tBE0842A2F765478743625A0E7A04ED6D0ADE76B6* ____currentPlaylist_60;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_lastTimeMissingPlaylistLogged
	float ____lastTimeMissingPlaylistLogged_61;
	// System.Action DarkTonic.MasterAudio.PlaylistController::_fadeCompleteCallback
	Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ____fadeCompleteCallback_62;
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.MusicSetting> DarkTonic.MasterAudio.PlaylistController::_queuedSongs
	List_1_t514ED2374039EA31FAA604B843F3706C43576C4C* ____queuedSongs_63;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::_lostFocus
	bool ____lostFocus_64;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::_autoStartedPlaylist
	bool ____autoStartedPlaylist_65;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::_isLoopSectionSchedule
	bool ____isLoopSectionSchedule_66;
	// System.Nullable`1<System.Double> DarkTonic.MasterAudio.PlaylistController::_loopSectionNextStartTime
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ____loopSectionNextStartTime_67;
	// UnityEngine.AudioSource DarkTonic.MasterAudio.PlaylistController::_audioClip
	AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* ____audioClip_68;
	// UnityEngine.AudioSource DarkTonic.MasterAudio.PlaylistController::_transClip
	AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* ____transClip_69;
	// DarkTonic.MasterAudio.MusicSetting DarkTonic.MasterAudio.PlaylistController::_newSongSetting
	MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9* ____newSongSetting_70;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::_nextSongRequested
	bool ____nextSongRequested_71;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::_nextSongScheduled
	bool ____nextSongScheduled_72;
	// System.Int32 DarkTonic.MasterAudio.PlaylistController::_lastRandomClipIndex
	int32_t ____lastRandomClipIndex_73;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_lastTimeSongRequested
	float ____lastTimeSongRequested_74;
	// System.Single DarkTonic.MasterAudio.PlaylistController::_currentDuckVolCut
	float ____currentDuckVolCut_75;
	// System.Nullable`1<System.Int32> DarkTonic.MasterAudio.PlaylistController::_lastSongPosition
	Nullable_1_tCF32C56A2641879C053C86F273C0C6EC1B40BC28 ____lastSongPosition_76;
	// System.Nullable`1<System.Double> DarkTonic.MasterAudio.PlaylistController::_currentSchedSongDspStartTime
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ____currentSchedSongDspStartTime_77;
	// System.Nullable`1<System.Double> DarkTonic.MasterAudio.PlaylistController::_currentSchedSongDspEndTime
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ____currentSchedSongDspEndTime_78;
	// System.Int32 DarkTonic.MasterAudio.PlaylistController::_lastFrameSongPosition
	int32_t ____lastFrameSongPosition_79;
	// System.Int32 DarkTonic.MasterAudio.PlaylistController::_nextScheduleTimeRecalcDifferentFirstFrameNum
	int32_t ____nextScheduleTimeRecalcDifferentFirstFrameNum_80;
	// System.Nullable`1<System.Double> DarkTonic.MasterAudio.PlaylistController::_nextScheduledTimeRecalcStart
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ____nextScheduledTimeRecalcStart_81;
	// System.Collections.Generic.Dictionary`2<UnityEngine.AudioSource,System.Double> DarkTonic.MasterAudio.PlaylistController::_scheduledSongOffsetByAudioSource
	Dictionary_2_t236C8C5505A81CEF6C8899F3236FD5FA3FCD1B34* ____scheduledSongOffsetByAudioSource_82;
	// System.Collections.Generic.Dictionary`2<UnityEngine.AudioSource,System.Double> DarkTonic.MasterAudio.PlaylistController::_scheduledSongStartTimeByAudioSource
	Dictionary_2_t236C8C5505A81CEF6C8899F3236FD5FA3FCD1B34* ____scheduledSongStartTimeByAudioSource_83;
	// System.Collections.Generic.Dictionary`2<UnityEngine.AudioSource,System.Double> DarkTonic.MasterAudio.PlaylistController::_scheduledSongEndTimeByAudioSource
	Dictionary_2_t236C8C5505A81CEF6C8899F3236FD5FA3FCD1B34* ____scheduledSongEndTimeByAudioSource_84;
	// System.Int32 DarkTonic.MasterAudio.PlaylistController::_frames
	int32_t ____frames_85;
	// UnityEngine.Coroutine DarkTonic.MasterAudio.PlaylistController::_resourceCoroutine
	Coroutine_t85EA685566A254C23F3FD77AB5BDFFFF8799596B* ____resourceCoroutine_87;
	// System.Int32 DarkTonic.MasterAudio.PlaylistController::_songsPlayedFromPlaylist
	int32_t ____songsPlayedFromPlaylist_88;
	// UnityEngine.AudioSource DarkTonic.MasterAudio.PlaylistController::_audio1
	AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* ____audio1_89;
	// UnityEngine.AudioSource DarkTonic.MasterAudio.PlaylistController::_audio2
	AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* ____audio2_90;
	// System.String DarkTonic.MasterAudio.PlaylistController::_activeSongAlias
	String_t* ____activeSongAlias_91;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::_isPlayingQueuedSong
	bool ____isPlayingQueuedSong_92;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::_isSongReplacingScheduledTrack
	bool ____isSongReplacingScheduledTrack_93;
	// UnityEngine.Transform DarkTonic.MasterAudio.PlaylistController::_trans
	Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____trans_94;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::_willPersist
	bool ____willPersist_95;
	// System.Nullable`1<System.Double> DarkTonic.MasterAudio.PlaylistController::_songPauseTime
	Nullable_1_t6E154519A812D040E3016229CD7638843A2CC165 ____songPauseTime_96;
	// System.Int32 DarkTonic.MasterAudio.PlaylistController::framesOfSongPlayed
	int32_t ___framesOfSongPlayed_97;
	// DarkTonic.MasterAudio.PlaylistController/SongChangedEventHandler DarkTonic.MasterAudio.PlaylistController::SongChanged
	SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519* ___SongChanged_98;
	// DarkTonic.MasterAudio.PlaylistController/SongEndedEventHandler DarkTonic.MasterAudio.PlaylistController::SongEnded
	SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* ___SongEnded_99;
	// DarkTonic.MasterAudio.PlaylistController/SongLoopedEventHandler DarkTonic.MasterAudio.PlaylistController::SongLooped
	SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* ___SongLooped_100;
	// DarkTonic.MasterAudio.PlaylistController/PlaylistEndedEventHandler DarkTonic.MasterAudio.PlaylistController::PlaylistEnded
	PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* ___PlaylistEnded_101;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::<ControllerIsReady>k__BackingField
	bool ___U3CControllerIsReadyU3Ek__BackingField_102;
	// System.Boolean DarkTonic.MasterAudio.PlaylistController::<IsCrossFading>k__BackingField
	bool ___U3CIsCrossFadingU3Ek__BackingField_103;
};

struct PlaylistController_t618C24E8D5BC20CD24B0640C396C9AD8E88B0806_StaticFields
{
	// System.Collections.Generic.List`1<DarkTonic.MasterAudio.PlaylistController> DarkTonic.MasterAudio.PlaylistController::_instances
	List_1_t44CBDD95588683E79B7413BF72121D1BD8FAF14C* ____instances_86;
};
#ifdef __clang__
#pragma clang diagnostic pop
#endif
// System.Delegate[]
struct DelegateU5BU5D_tC5AB7E8F745616680F337909D3A8E6C722CDF771  : public RuntimeArray
{
	ALIGN_FIELD (8) Delegate_t* m_Items[1];

	inline Delegate_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Delegate_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline Delegate_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Delegate_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Delegate_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};
// System.Object[]
struct ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918  : public RuntimeArray
{
	ALIGN_FIELD (8) RuntimeObject* m_Items[1];

	inline RuntimeObject* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
	inline RuntimeObject* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier((void**)m_Items + index, (void*)value);
	}
};


// T UnityEngine.Component::GetComponent<System.Object>()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// T UnityEngine.Object::Instantiate<System.Object>(T,UnityEngine.Vector3,UnityEngine.Quaternion)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* Object_Instantiate_TisRuntimeObject_m249A6BA4F2F19C2D3CE217D4D31847DF0EF03EFE_gshared (RuntimeObject* ___original0, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___position1, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___rotation2, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.Object>::get_Item(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, int32_t ___index0, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<System.Object>::get_Count()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.List`1<System.Object>::Contains(T)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool List_1_Contains_m4C9139C2A6B23E9343D3F87807B32C6E2CFE660D_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___item0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<System.Object>::Add(T)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___item0, const RuntimeMethod* method) ;

// System.Void System.Object::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2 (RuntimeObject* __this, const RuntimeMethod* method) ;
// System.Void DarkTonic.MasterAudio.PlaylistController::StopPlaylist(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlaylistController_StopPlaylist_m506AE387CD3A9A3B7ACE1FF161A7BBF49546BCBC (PlaylistController_t618C24E8D5BC20CD24B0640C396C9AD8E88B0806* __this, bool ___onlyFadingClip0, const RuntimeMethod* method) ;
// System.String DarkTonic.MasterAudio.SpatializerHelper::get_SelectedSpatializer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* SpatializerHelper_get_SelectedSpatializer_mB52A6D2150B333FC3DD6599DAE874105AEC6A0EC (const RuntimeMethod* method) ;
// System.Boolean System.String::op_Equality(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1 (String_t* ___a0, String_t* ___b1, const RuntimeMethod* method) ;
// System.String UnityEngine.AudioSettings::GetSpatializerPluginName()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* AudioSettings_GetSpatializerPluginName_m60C2C3FA09CB0422D1EDAE5185F20BF01689BF00 (const RuntimeMethod* method) ;
// DarkTonic.MasterAudio.MasterAudio DarkTonic.MasterAudio.MasterAudio::get_SafeInstance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558* MasterAudio_get_SafeInstance_m032232A242182E424132E6CB8C80BA00D9CC091A (const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___x0, Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___y1, const RuntimeMethod* method) ;
// System.Void DarkTonic.MasterAudio.SpatializerHelper::SetSpatializerToggleOnSource(UnityEngine.AudioSource,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SpatializerHelper_SetSpatializerToggleOnSource_m21F992B71E092C0CB3255A2B5F1B185C623A6E52 (AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* ___source0, bool ___enabled1, const RuntimeMethod* method) ;
// DarkTonic.MasterAudio.MasterAudio DarkTonic.MasterAudio.MasterAudio::get_Instance()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558* MasterAudio_get_Instance_mB49DFB52492BA4B3F6960CCFF67F985A6C892F14 (const RuntimeMethod* method) ;
// System.Boolean ResonanceAudioHelper::get_ResonanceAudioOptionExists()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ResonanceAudioHelper_get_ResonanceAudioOptionExists_m81BCE075CFF4C788AE27E3CEC30B2E67AD5BA1A0 (const RuntimeMethod* method) ;
// System.Void UnityEngine.AudioSource::set_spatializePostEffects(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_spatializePostEffects_m7CC219B7790E27667D49F4A36C8F62FFF399DA54 (AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Single UnityEngine.AudioSource::get_spatialBlend()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioSource_get_spatialBlend_m06E7948B2813AA3EAE031BD4D1DE61A29416B1CE (AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.AudioSource::set_spatialize(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioSource_set_spatialize_mDFA357EDCB0C59EF11F53C845F7ACBF6BF7F7B3C (AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Boolean System.String::IsNullOrEmpty(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478 (String_t* ___value0, const RuntimeMethod* method) ;
// System.String System.String::Trim()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Trim_mCD6D8C6D4CFD15225D12DB7D3E0544CA80FB8DA5 (String_t* __this, const RuntimeMethod* method) ;
// System.String System.String::Replace(System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166 (String_t* __this, String_t* ___oldValue0, String_t* ___newValue1, const RuntimeMethod* method) ;
// System.Void UnityEngine.Debug::LogError(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2 (RuntimeObject* ___message0, const RuntimeMethod* method) ;
// System.Void UnityEngine.MonoBehaviour::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E (MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Rect::.ctor(System.Single,System.Single,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23 (Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D* __this, float ___x0, float ___y1, float ___width2, float ___height3, const RuntimeMethod* method) ;
// System.Void UnityEngine.GUI::Label(UnityEngine.Rect,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GUI_Label_m4A951E57C7DCCF95A0306240144CA2713F546526 (Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D ___position0, String_t* ___text1, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.GUI::Button(UnityEngine.Rect,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GUI_Button_m26D18B144D3116398B9E9BECB0C4014F57DBE44B (Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D ___position0, String_t* ___text1, const RuntimeMethod* method) ;
// System.Void UnityEngine.SceneManagement.SceneManager::LoadScene(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SceneManager_LoadScene_m0957E62F2A0A0243C79394E5B74E8EFA86BE5ED1 (int32_t ___sceneBuildIndex0, const RuntimeMethod* method) ;
// System.Void UnityEngine.MonoBehaviour::set_useGUILayout(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MonoBehaviour_set_useGUILayout_m56F0C62F4B6889D7472074ECCB56EBA462285134 (MonoBehaviour_t532A11E69716D348D8AA7F854AFCBFCB8AD17F71* __this, bool ___value0, const RuntimeMethod* method) ;
// T UnityEngine.Component::GetComponent<UnityEngine.ParticleSystem>()
inline ParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1* Component_GetComponent_TisParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1_mF2B700ECAEEEDBCC076CC66C9592C6DDFA0D36F9 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method)
{
	return ((  ParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1* (*) (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3*, const RuntimeMethod*))Component_GetComponent_TisRuntimeObject_m7181F81CAEC2CF53F5D2BC79B7425C16E1F80D33_gshared)(__this, method);
}
// System.Boolean UnityEngine.ParticleSystem::IsAlive()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool ParticleSystem_IsAlive_mF1B0F10ED9EDCB5D971471DDEB0C55C9638FAE56 (ParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1* __this, const RuntimeMethod* method) ;
// UnityEngine.GameObject UnityEngine.Component::get_gameObject()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Object::Destroy(UnityEngine.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Object_Destroy_mE97D0A766419A81296E8D4E5C23D01D3FE91ACBB (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* ___obj0, const RuntimeMethod* method) ;
// UnityEngine.Transform UnityEngine.Component::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371 (Component_t39FBE53E5EFCF4409111FB22C15FF73717632EC3* __this, const RuntimeMethod* method) ;
// System.Int32 UnityEngine.Random::Range(System.Int32,System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR int32_t Random_Range_m6763D9767F033357F88B6637F048F4ACA4123B68 (int32_t ___minInclusive0, int32_t ___maxExclusive1, const RuntimeMethod* method) ;
// System.Single DarkTonic.MasterAudio.AudioUtil::get_FrameTime()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioUtil_get_FrameTime_m51FB868DF9ACC0EA6F681F00863762E399FD6109 (const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Transform::get_position()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Transform_get_position_m69CD5FA214FDAE7BB701552943674846C220FDE1 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___value0, const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::get_down()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_down_mF62B2AE7C5AC31EAC9CB62797C7190C90A7A8599_inline (const RuntimeMethod* method) ;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(UnityEngine.Vector3,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___a0, float ___d1, const RuntimeMethod* method) ;
// System.Void UnityEngine.Transform::Rotate(UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Transform_Rotate_m2A308205498AFEEA3DF784B1C86E4F7C126CA2EE (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___eulers0, const RuntimeMethod* method) ;
// System.Single DarkTonic.MasterAudio.AudioUtil::get_Time()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float AudioUtil_get_Time_mEA625F0CBC286EC5E4C34679D77B8E17DC82839E (const RuntimeMethod* method) ;
// System.Single UnityEngine.Random::Range(System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Random_Range_m5236C99A7D8AE6AC9190592DC66016652A2D2494 (float ___minInclusive0, float ___maxInclusive1, const RuntimeMethod* method) ;
// System.Single UnityEngine.Time::get_time()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Time_get_time_m3A271BB1B20041144AC5B7863B71AB1F0150374B (const RuntimeMethod* method) ;
// UnityEngine.Transform UnityEngine.GameObject::get_transform()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// UnityEngine.Quaternion UnityEngine.Transform::get_rotation()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 Transform_get_rotation_m32AF40CA0D50C797DA639A696F8EAEC7524C179C (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* __this, const RuntimeMethod* method) ;
// T UnityEngine.Object::Instantiate<UnityEngine.GameObject>(T,UnityEngine.Vector3,UnityEngine.Quaternion)
inline GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* ___original0, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___position1, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 ___rotation2, const RuntimeMethod* method)
{
	return ((  GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* (*) (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F*, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2, Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974, const RuntimeMethod*))Object_Instantiate_TisRuntimeObject_m249A6BA4F2F19C2D3CE217D4D31847DF0EF03EFE_gshared)(___original0, ___position1, ___rotation2, method);
}
// System.Single UnityEngine.Input::GetAxis(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR float Input_GetAxis_m10372E6C5FF591668D2DC5F58C58D213CC598A62 (String_t* ___axisName0, const RuntimeMethod* method) ;
// System.Void DarkTonic.MasterAudio.MasterAudio::FireCustomEvent(System.String,UnityEngine.Transform,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudio_FireCustomEvent_m3D277358BC73AC8D3DBB9A9594719A87119F6B5F (String_t* ___customEventName0, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___originObject1, bool ___logDupe2, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.Input::GetMouseButtonDown(System.Int32)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool Input_GetMouseButtonDown_m8DFC792D15FFF15D311614D5CC6C5D055E5A1DE3 (int32_t ___button0, const RuntimeMethod* method) ;
// System.Boolean UnityEngine.GameObject::get_activeInHierarchy()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool GameObject_get_activeInHierarchy_m49250F4F168DCC5388D5BE4F6A5681386907B109 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, const RuntimeMethod* method) ;
// System.Boolean DarkTonic.MasterAudio.Examples.MA_PlayerSpawnerControl::get_PlayerActive()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MA_PlayerSpawnerControl_get_PlayerActive_m239B8337058895E2D014A39265B2646DC3B7C233 (MA_PlayerSpawnerControl_t87E7E9177332BA2683259C0211587134DE637203* __this, const RuntimeMethod* method) ;
// System.Void UnityEngine.GameObject::SetActive(System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92 (GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* __this, bool ___value0, const RuntimeMethod* method) ;
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::CheckForIllegalCustomEvents()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver_CheckForIllegalCustomEvents_m6E97F9677A4657A53E47360DA7A41AD235EC06C0 (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) ;
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::RegisterReceiver()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver_RegisterReceiver_m94BA1A4835992D0BEFC9E50BE6487B183154AD1F (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) ;
// System.Boolean DarkTonic.MasterAudio.MasterAudio::get_AppIsShuttingDown()
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool MasterAudio_get_AppIsShuttingDown_mEBDB3FB0D99F5F9D975987AEC59296E89CC895BA_inline (const RuntimeMethod* method) ;
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::UnregisterReceiver()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver_UnregisterReceiver_m2E63F344FCB2A51A2AB252CEED577996D1CF135A (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) ;
// T System.Collections.Generic.List`1<System.String>::get_Item(System.Int32)
inline String_t* List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8 (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, int32_t ___index0, const RuntimeMethod* method)
{
	return ((  String_t* (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, int32_t, const RuntimeMethod*))List_1_get_Item_m33561245D64798C2AB07584C0EC4F240E4839A38_gshared)(__this, ___index0, method);
}
// System.Boolean DarkTonic.MasterAudio.MasterAudio::CustomEventExists(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MasterAudio_CustomEventExists_m74F6AC571151BF71BA0B3DEECE67838AA6FF6AB6 (String_t* ___customEventName0, const RuntimeMethod* method) ;
// System.String UnityEngine.Object::get_name()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392 (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C* __this, const RuntimeMethod* method) ;
// System.String System.String::Concat(System.String,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B (String_t* ___str00, String_t* ___str11, String_t* ___str22, const RuntimeMethod* method) ;
// System.Int32 System.Collections.Generic.List`1<System.String>::get_Count()
inline int32_t List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_inline (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, const RuntimeMethod* method)
{
	return ((  int32_t (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, const RuntimeMethod*))List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline)(__this, method);
}
// System.Void UnityEngine.Debug::Log(System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB (RuntimeObject* ___message0, const RuntimeMethod* method) ;
// System.Boolean System.Collections.Generic.List`1<System.String>::Contains(T)
inline bool List_1_Contains_m359254483BE42CAD4DCA8FBAFB87473FB4CF00E1 (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, String_t* ___item0, const RuntimeMethod* method)
{
	return ((  bool (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, String_t*, const RuntimeMethod*))List_1_Contains_m4C9139C2A6B23E9343D3F87807B32C6E2CFE660D_gshared)(__this, ___item0, method);
}
// System.Void DarkTonic.MasterAudio.MasterAudio::AddCustomEventReceiver(DarkTonic.MasterAudio.ICustomEventReceiver,UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudio_AddCustomEventReceiver_m07576CE44E027C26E39C7AAB1FCB61488D3CC97F (RuntimeObject* ___receiver0, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___receiverTrans1, const RuntimeMethod* method) ;
// System.Void DarkTonic.MasterAudio.MasterAudio::RemoveCustomEventReceiver(DarkTonic.MasterAudio.ICustomEventReceiver)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudio_RemoveCustomEventReceiver_m4606FA61C2967F6F292758A97D5B03AA86583561 (RuntimeObject* ___receiver0, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<DarkTonic.MasterAudio.AudioEventGroup>::.ctor()
inline void List_1__ctor_m155CDF1F26D1E859CC8AC03003C6BEA2EBF017F6 (List_1_t34522BBE1CA284958723F996311B012983B30D2B* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_t34522BBE1CA284958723F996311B012983B30D2B*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
// System.Void DarkTonic.MasterAudio.AudioEventGroup::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void AudioEventGroup__ctor_mD407DF047241D4169A05E375709006910595AD52 (AudioEventGroup_t953D8966F454589B710B23F387F5D1B5E9B73E2A* __this, const RuntimeMethod* method) ;
// System.Void System.Collections.Generic.List`1<DarkTonic.MasterAudio.AudioEventGroup>::Add(T)
inline void List_1_Add_m4315CBA28DB215575A4D8CDE10EA0E53B33A6667_inline (List_1_t34522BBE1CA284958723F996311B012983B30D2B* __this, AudioEventGroup_t953D8966F454589B710B23F387F5D1B5E9B73E2A* ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_t34522BBE1CA284958723F996311B012983B30D2B*, AudioEventGroup_t953D8966F454589B710B23F387F5D1B5E9B73E2A*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___item0, method);
}
// System.Void System.Collections.Generic.List`1<System.String>::.ctor()
inline void List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, const RuntimeMethod* method)
{
	((  void (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, const RuntimeMethod*))List_1__ctor_m7F078BB342729BDF11327FD89D7872265328F690_gshared)(__this, method);
}
// System.Void System.Collections.Generic.List`1<System.String>::Add(T)
inline void List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_inline (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* __this, String_t* ___item0, const RuntimeMethod* method)
{
	((  void (*) (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*, String_t*, const RuntimeMethod*))List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline)(__this, ___item0, method);
}
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method) ;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void SongChangedEventHandler_Invoke_mD3E7CC1B8BD1C1463575DB83CEE7013C0F05C43D_Multicast(SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519* __this, String_t* ___newSongName0, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9* ___song1, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519* currentDelegate = reinterpret_cast<SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, ___newSongName0, ___song1, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void SongChangedEventHandler_Invoke_mD3E7CC1B8BD1C1463575DB83CEE7013C0F05C43D_OpenInst(SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519* __this, String_t* ___newSongName0, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9* ___song1, const RuntimeMethod* method)
{
	NullCheck(___newSongName0);
	typedef void (*FunctionPointerType) (String_t*, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___newSongName0, ___song1, method);
}
void SongChangedEventHandler_Invoke_mD3E7CC1B8BD1C1463575DB83CEE7013C0F05C43D_OpenStatic(SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519* __this, String_t* ___newSongName0, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9* ___song1, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (String_t*, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___newSongName0, ___song1, method);
}
void SongChangedEventHandler_Invoke_mD3E7CC1B8BD1C1463575DB83CEE7013C0F05C43D_OpenStaticInvoker(SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519* __this, String_t* ___newSongName0, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9* ___song1, const RuntimeMethod* method)
{
	InvokerActionInvoker2< String_t*, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9* >::Invoke(__this->___method_ptr_0, method, NULL, ___newSongName0, ___song1);
}
void SongChangedEventHandler_Invoke_mD3E7CC1B8BD1C1463575DB83CEE7013C0F05C43D_ClosedStaticInvoker(SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519* __this, String_t* ___newSongName0, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9* ___song1, const RuntimeMethod* method)
{
	InvokerActionInvoker3< RuntimeObject*, String_t*, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9* >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2, ___newSongName0, ___song1);
}
// System.Void DarkTonic.MasterAudio.PlaylistController/SongChangedEventHandler::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SongChangedEventHandler__ctor_mABD86C7FF78447FAEAA29C499F298ED2A715FF93 (SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___method1);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___method1))
	{
		bool isOpen = parameterCount == 2;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___method1))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&SongChangedEventHandler_Invoke_mD3E7CC1B8BD1C1463575DB83CEE7013C0F05C43D_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&SongChangedEventHandler_Invoke_mD3E7CC1B8BD1C1463575DB83CEE7013C0F05C43D_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&SongChangedEventHandler_Invoke_mD3E7CC1B8BD1C1463575DB83CEE7013C0F05C43D_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		bool isOpen = parameterCount == 1;
		if (isOpen)
		{
			__this->___invoke_impl_1 = (intptr_t)&SongChangedEventHandler_Invoke_mD3E7CC1B8BD1C1463575DB83CEE7013C0F05C43D_OpenInst;
		}
		else
		{
			if (___object0 == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
			__this->___method_code_6 = (intptr_t)__this->___m_target_2;
		}
	}
	__this->___extra_arg_5 = (intptr_t)&SongChangedEventHandler_Invoke_mD3E7CC1B8BD1C1463575DB83CEE7013C0F05C43D_Multicast;
}
// System.Void DarkTonic.MasterAudio.PlaylistController/SongChangedEventHandler::Invoke(System.String,DarkTonic.MasterAudio.MusicSetting)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SongChangedEventHandler_Invoke_mD3E7CC1B8BD1C1463575DB83CEE7013C0F05C43D (SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519* __this, String_t* ___newSongName0, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9* ___song1, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___newSongName0, ___song1, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
// System.IAsyncResult DarkTonic.MasterAudio.PlaylistController/SongChangedEventHandler::BeginInvoke(System.String,DarkTonic.MasterAudio.MusicSetting,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* SongChangedEventHandler_BeginInvoke_mCB870514EE3255AC094A267CD5AE50F55C9B2B3A (SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519* __this, String_t* ___newSongName0, MusicSetting_t2C7D3207B461E2D9F425C39D2FF370065F8B4BE9* ___song1, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___callback2, RuntimeObject* ___object3, const RuntimeMethod* method) 
{
	void *__d_args[3] = {0};
	__d_args[0] = ___newSongName0;
	__d_args[1] = ___song1;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback2, (RuntimeObject*)___object3);
}
// System.Void DarkTonic.MasterAudio.PlaylistController/SongChangedEventHandler::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SongChangedEventHandler_EndInvoke_mB14D84E769EF94E6D2DCFE53E16167681AF2A309 (SongChangedEventHandler_t0418A7E179A791AE2512D806366367BF74A98519* __this, RuntimeObject* ___result0, const RuntimeMethod* method) 
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void SongEndedEventHandler_Invoke_mED944E36357AB6C615BF8CF2458AF59DF25F0D8B_Multicast(SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* currentDelegate = reinterpret_cast<SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, ___songName0, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void SongEndedEventHandler_Invoke_mED944E36357AB6C615BF8CF2458AF59DF25F0D8B_OpenInst(SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	NullCheck(___songName0);
	typedef void (*FunctionPointerType) (String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___songName0, method);
}
void SongEndedEventHandler_Invoke_mED944E36357AB6C615BF8CF2458AF59DF25F0D8B_OpenStatic(SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___songName0, method);
}
void SongEndedEventHandler_Invoke_mED944E36357AB6C615BF8CF2458AF59DF25F0D8B_OpenStaticInvoker(SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	InvokerActionInvoker1< String_t* >::Invoke(__this->___method_ptr_0, method, NULL, ___songName0);
}
void SongEndedEventHandler_Invoke_mED944E36357AB6C615BF8CF2458AF59DF25F0D8B_ClosedStaticInvoker(SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	InvokerActionInvoker2< RuntimeObject*, String_t* >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2, ___songName0);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC (SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(char*);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Marshaling of parameter '___songName0' to native representation
	char* ____songName0_marshaled = NULL;
	____songName0_marshaled = il2cpp_codegen_marshal_string(___songName0);

	// Native function invocation
	il2cppPInvokeFunc(____songName0_marshaled);

	// Marshaling cleanup of parameter '___songName0' native representation
	il2cpp_codegen_marshal_free(____songName0_marshaled);
	____songName0_marshaled = NULL;

}
// System.Void DarkTonic.MasterAudio.PlaylistController/SongEndedEventHandler::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SongEndedEventHandler__ctor_mF905275E2FEC9E2E1C5AD0BD35B54EB02D31AD63 (SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___method1);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___method1))
	{
		bool isOpen = parameterCount == 1;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___method1))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&SongEndedEventHandler_Invoke_mED944E36357AB6C615BF8CF2458AF59DF25F0D8B_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&SongEndedEventHandler_Invoke_mED944E36357AB6C615BF8CF2458AF59DF25F0D8B_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&SongEndedEventHandler_Invoke_mED944E36357AB6C615BF8CF2458AF59DF25F0D8B_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		bool isOpen = parameterCount == 0;
		if (isOpen)
		{
			__this->___invoke_impl_1 = (intptr_t)&SongEndedEventHandler_Invoke_mED944E36357AB6C615BF8CF2458AF59DF25F0D8B_OpenInst;
		}
		else
		{
			if (___object0 == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
			__this->___method_code_6 = (intptr_t)__this->___m_target_2;
		}
	}
	__this->___extra_arg_5 = (intptr_t)&SongEndedEventHandler_Invoke_mED944E36357AB6C615BF8CF2458AF59DF25F0D8B_Multicast;
}
// System.Void DarkTonic.MasterAudio.PlaylistController/SongEndedEventHandler::Invoke(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SongEndedEventHandler_Invoke_mED944E36357AB6C615BF8CF2458AF59DF25F0D8B (SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* __this, String_t* ___songName0, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___songName0, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
// System.IAsyncResult DarkTonic.MasterAudio.PlaylistController/SongEndedEventHandler::BeginInvoke(System.String,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* SongEndedEventHandler_BeginInvoke_mD82A881F610DACA7FE95F3DA912928C3BEC5AA46 (SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* __this, String_t* ___songName0, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___callback1, RuntimeObject* ___object2, const RuntimeMethod* method) 
{
	void *__d_args[2] = {0};
	__d_args[0] = ___songName0;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);
}
// System.Void DarkTonic.MasterAudio.PlaylistController/SongEndedEventHandler::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SongEndedEventHandler_EndInvoke_m2F87B31BAAA1A3F0AE114426FC04F28657FFC3B9 (SongEndedEventHandler_t0F42D7F8FF294D0CA6761D0D7FC22B1FA48056EC* __this, RuntimeObject* ___result0, const RuntimeMethod* method) 
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void SongLoopedEventHandler_Invoke_mD3D83D112D1F2DE94C98649E0C95221351D5FE83_Multicast(SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* currentDelegate = reinterpret_cast<SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, ___songName0, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void SongLoopedEventHandler_Invoke_mD3D83D112D1F2DE94C98649E0C95221351D5FE83_OpenInst(SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	NullCheck(___songName0);
	typedef void (*FunctionPointerType) (String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___songName0, method);
}
void SongLoopedEventHandler_Invoke_mD3D83D112D1F2DE94C98649E0C95221351D5FE83_OpenStatic(SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(___songName0, method);
}
void SongLoopedEventHandler_Invoke_mD3D83D112D1F2DE94C98649E0C95221351D5FE83_OpenStaticInvoker(SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	InvokerActionInvoker1< String_t* >::Invoke(__this->___method_ptr_0, method, NULL, ___songName0);
}
void SongLoopedEventHandler_Invoke_mD3D83D112D1F2DE94C98649E0C95221351D5FE83_ClosedStaticInvoker(SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	InvokerActionInvoker2< RuntimeObject*, String_t* >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2, ___songName0);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE (SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* __this, String_t* ___songName0, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)(char*);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Marshaling of parameter '___songName0' to native representation
	char* ____songName0_marshaled = NULL;
	____songName0_marshaled = il2cpp_codegen_marshal_string(___songName0);

	// Native function invocation
	il2cppPInvokeFunc(____songName0_marshaled);

	// Marshaling cleanup of parameter '___songName0' native representation
	il2cpp_codegen_marshal_free(____songName0_marshaled);
	____songName0_marshaled = NULL;

}
// System.Void DarkTonic.MasterAudio.PlaylistController/SongLoopedEventHandler::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SongLoopedEventHandler__ctor_mAECDB3520FE8C417550330779CB8DC12863C2AB4 (SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___method1);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___method1))
	{
		bool isOpen = parameterCount == 1;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___method1))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&SongLoopedEventHandler_Invoke_mD3D83D112D1F2DE94C98649E0C95221351D5FE83_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&SongLoopedEventHandler_Invoke_mD3D83D112D1F2DE94C98649E0C95221351D5FE83_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&SongLoopedEventHandler_Invoke_mD3D83D112D1F2DE94C98649E0C95221351D5FE83_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		bool isOpen = parameterCount == 0;
		if (isOpen)
		{
			__this->___invoke_impl_1 = (intptr_t)&SongLoopedEventHandler_Invoke_mD3D83D112D1F2DE94C98649E0C95221351D5FE83_OpenInst;
		}
		else
		{
			if (___object0 == NULL)
				il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
			__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
			__this->___method_code_6 = (intptr_t)__this->___m_target_2;
		}
	}
	__this->___extra_arg_5 = (intptr_t)&SongLoopedEventHandler_Invoke_mD3D83D112D1F2DE94C98649E0C95221351D5FE83_Multicast;
}
// System.Void DarkTonic.MasterAudio.PlaylistController/SongLoopedEventHandler::Invoke(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SongLoopedEventHandler_Invoke_mD3D83D112D1F2DE94C98649E0C95221351D5FE83 (SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* __this, String_t* ___songName0, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, String_t*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, ___songName0, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
// System.IAsyncResult DarkTonic.MasterAudio.PlaylistController/SongLoopedEventHandler::BeginInvoke(System.String,System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* SongLoopedEventHandler_BeginInvoke_m9EDFE2769E5563C3DAD5657469FAC880B553A3E6 (SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* __this, String_t* ___songName0, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___callback1, RuntimeObject* ___object2, const RuntimeMethod* method) 
{
	void *__d_args[2] = {0};
	__d_args[0] = ___songName0;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback1, (RuntimeObject*)___object2);
}
// System.Void DarkTonic.MasterAudio.PlaylistController/SongLoopedEventHandler::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SongLoopedEventHandler_EndInvoke_m66C655454B35CAF256B31ABC201D4C04AA41AA33 (SongLoopedEventHandler_t170EC3B36EF16B2D4FB40D28365B08393293C6DE* __this, RuntimeObject* ___result0, const RuntimeMethod* method) 
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
void PlaylistEndedEventHandler_Invoke_mB3CF91CD92174610EEE65AB16C1288E6BBD14387_Multicast(PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* __this, const RuntimeMethod* method)
{
	il2cpp_array_size_t length = __this->___delegates_13->max_length;
	Delegate_t** delegatesToInvoke = reinterpret_cast<Delegate_t**>(__this->___delegates_13->GetAddressAtUnchecked(0));
	for (il2cpp_array_size_t i = 0; i < length; i++)
	{
		PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* currentDelegate = reinterpret_cast<PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016*>(delegatesToInvoke[i]);
		typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
		((FunctionPointerType)currentDelegate->___invoke_impl_1)((Il2CppObject*)currentDelegate->___method_code_6, reinterpret_cast<RuntimeMethod*>(currentDelegate->___method_3));
	}
}
void PlaylistEndedEventHandler_Invoke_mB3CF91CD92174610EEE65AB16C1288E6BBD14387_OpenInst(PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* __this, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(method);
}
void PlaylistEndedEventHandler_Invoke_mB3CF91CD92174610EEE65AB16C1288E6BBD14387_OpenStatic(PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* __this, const RuntimeMethod* method)
{
	typedef void (*FunctionPointerType) (const RuntimeMethod*);
	((FunctionPointerType)__this->___method_ptr_0)(method);
}
void PlaylistEndedEventHandler_Invoke_mB3CF91CD92174610EEE65AB16C1288E6BBD14387_OpenStaticInvoker(PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker0::Invoke(__this->___method_ptr_0, method, NULL);
}
void PlaylistEndedEventHandler_Invoke_mB3CF91CD92174610EEE65AB16C1288E6BBD14387_ClosedStaticInvoker(PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* __this, const RuntimeMethod* method)
{
	InvokerActionInvoker1< RuntimeObject* >::Invoke(__this->___method_ptr_0, method, NULL, __this->___m_target_2);
}
IL2CPP_EXTERN_C  void DelegatePInvokeWrapper_PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016 (PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* __this, const RuntimeMethod* method)
{
	typedef void (DEFAULT_CALL *PInvokeFunc)();
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_reverse_pinvoke_function_ptr(__this));
	// Native function invocation
	il2cppPInvokeFunc();

}
// System.Void DarkTonic.MasterAudio.PlaylistController/PlaylistEndedEventHandler::.ctor(System.Object,System.IntPtr)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlaylistEndedEventHandler__ctor_m82FA9071463CC1D775134A083FC427D2A5A1E209 (PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* __this, RuntimeObject* ___object0, intptr_t ___method1, const RuntimeMethod* method) 
{
	__this->___method_ptr_0 = il2cpp_codegen_get_virtual_call_method_pointer((RuntimeMethod*)___method1);
	__this->___method_3 = ___method1;
	__this->___m_target_2 = ___object0;
	Il2CppCodeGenWriteBarrier((void**)(&__this->___m_target_2), (void*)___object0);
	int parameterCount = il2cpp_codegen_method_parameter_count((RuntimeMethod*)___method1);
	__this->___method_code_6 = (intptr_t)__this;
	if (MethodIsStatic((RuntimeMethod*)___method1))
	{
		bool isOpen = parameterCount == 0;
		if (il2cpp_codegen_call_method_via_invoker((RuntimeMethod*)___method1))
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&PlaylistEndedEventHandler_Invoke_mB3CF91CD92174610EEE65AB16C1288E6BBD14387_OpenStaticInvoker;
			else
				__this->___invoke_impl_1 = (intptr_t)&PlaylistEndedEventHandler_Invoke_mB3CF91CD92174610EEE65AB16C1288E6BBD14387_ClosedStaticInvoker;
		else
			if (isOpen)
				__this->___invoke_impl_1 = (intptr_t)&PlaylistEndedEventHandler_Invoke_mB3CF91CD92174610EEE65AB16C1288E6BBD14387_OpenStatic;
			else
				{
					__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
					__this->___method_code_6 = (intptr_t)__this->___m_target_2;
				}
	}
	else
	{
		if (___object0 == NULL)
			il2cpp_codegen_raise_exception(il2cpp_codegen_get_argument_exception(NULL, "Delegate to an instance method cannot have null 'this'."), NULL);
		__this->___invoke_impl_1 = (intptr_t)__this->___method_ptr_0;
		__this->___method_code_6 = (intptr_t)__this->___m_target_2;
	}
	__this->___extra_arg_5 = (intptr_t)&PlaylistEndedEventHandler_Invoke_mB3CF91CD92174610EEE65AB16C1288E6BBD14387_Multicast;
}
// System.Void DarkTonic.MasterAudio.PlaylistController/PlaylistEndedEventHandler::Invoke()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlaylistEndedEventHandler_Invoke_mB3CF91CD92174610EEE65AB16C1288E6BBD14387 (PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* __this, const RuntimeMethod* method) 
{
	typedef void (*FunctionPointerType) (RuntimeObject*, const RuntimeMethod*);
	((FunctionPointerType)__this->___invoke_impl_1)((Il2CppObject*)__this->___method_code_6, reinterpret_cast<RuntimeMethod*>(__this->___method_3));
}
// System.IAsyncResult DarkTonic.MasterAudio.PlaylistController/PlaylistEndedEventHandler::BeginInvoke(System.AsyncCallback,System.Object)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* PlaylistEndedEventHandler_BeginInvoke_m1E21FF883F5771963311D0E6F88AFD9BE66C6B4B (PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* __this, AsyncCallback_t7FEF460CBDCFB9C5FA2EF776984778B9A4145F4C* ___callback0, RuntimeObject* ___object1, const RuntimeMethod* method) 
{
	void *__d_args[1] = {0};
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback0, (RuntimeObject*)___object1);
}
// System.Void DarkTonic.MasterAudio.PlaylistController/PlaylistEndedEventHandler::EndInvoke(System.IAsyncResult)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void PlaylistEndedEventHandler_EndInvoke_m540259C735F2419F213D56515F97E6B428BBC99E (PlaylistEndedEventHandler_tD39C209479D15AB80BD5A1F1EA27596F26698016* __this, RuntimeObject* ___result0, const RuntimeMethod* method) 
{
	il2cpp_codegen_delegate_end_invoke((Il2CppAsyncResult*) ___result0, 0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.PlaylistController/<>c__DisplayClass162_0::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass162_0__ctor_m4C931C663672FEE225E5AC74AD26361C5409291F (U3CU3Ec__DisplayClass162_0_tB41B59BF810A20A1FE45E4D5C3EE93BD3CFC047D* __this, const RuntimeMethod* method) 
{
	{
		Object__ctor_mE837C6B9FA8C6D5D109F4B2EC885D79919AC0EA2(__this, NULL);
		return;
	}
}
// System.Void DarkTonic.MasterAudio.PlaylistController/<>c__DisplayClass162_0::<FadeOutPlaylist>b__0()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void U3CU3Ec__DisplayClass162_0_U3CFadeOutPlaylistU3Eb__0_m5D8E0FB5B2C0144D9D665A8A184F19551FBD22EC (U3CU3Ec__DisplayClass162_0_tB41B59BF810A20A1FE45E4D5C3EE93BD3CFC047D* __this, const RuntimeMethod* method) 
{
	{
		// StopPlaylist();
		PlaylistController_t618C24E8D5BC20CD24B0640C396C9AD8E88B0806* L_0 = __this->___U3CU3E4__this_0;
		NullCheck(L_0);
		PlaylistController_StopPlaylist_m506AE387CD3A9A3B7ACE1FF161A7BBF49546BCBC(L_0, (bool)0, NULL);
		// _playlistVolume = volumeBeforeFade;
		PlaylistController_t618C24E8D5BC20CD24B0640C396C9AD8E88B0806* L_1 = __this->___U3CU3E4__this_0;
		float L_2 = __this->___volumeBeforeFade_1;
		NullCheck(L_1);
		L_1->____playlistVolume_15 = L_2;
		// });
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean DarkTonic.MasterAudio.SpatializerHelper::get_IsSupportedSpatializer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SpatializerHelper_get_IsSupportedSpatializer_mDFFB7E83183E1BB3C62E58CFA6257951C33A2052 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0C1FBCAE463347B711E91243B552C4DF38EEC101);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral98B033ED2637444093F303078F4135295C4D524A);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		// switch (SelectedSpatializer) {
		String_t* L_0;
		L_0 = SpatializerHelper_get_SelectedSpatializer_mB52A6D2150B333FC3DD6599DAE874105AEC6A0EC(NULL);
		V_0 = L_0;
		String_t* L_1 = V_0;
		bool L_2;
		L_2 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_1, _stringLiteral98B033ED2637444093F303078F4135295C4D524A, NULL);
		if (L_2)
		{
			goto IL_0022;
		}
	}
	{
		String_t* L_3 = V_0;
		bool L_4;
		L_4 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_3, _stringLiteral0C1FBCAE463347B711E91243B552C4DF38EEC101, NULL);
		if (L_4)
		{
			goto IL_0024;
		}
	}
	{
		goto IL_0026;
	}

IL_0022:
	{
		// return true;
		return (bool)1;
	}

IL_0024:
	{
		// return true;
		return (bool)1;
	}

IL_0026:
	{
		// return false;
		return (bool)0;
	}
}
// System.Boolean DarkTonic.MasterAudio.SpatializerHelper::get_IsOculusAudioSpatializer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SpatializerHelper_get_IsOculusAudioSpatializer_m274A90FD2DCDCA6CC83E28A84473B99962B3A2F6 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral98B033ED2637444093F303078F4135295C4D524A);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return SelectedSpatializer == OculusSpatializer;
		String_t* L_0;
		L_0 = SpatializerHelper_get_SelectedSpatializer_mB52A6D2150B333FC3DD6599DAE874105AEC6A0EC(NULL);
		bool L_1;
		L_1 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_0, _stringLiteral98B033ED2637444093F303078F4135295C4D524A, NULL);
		return L_1;
	}
}
// System.Boolean DarkTonic.MasterAudio.SpatializerHelper::get_IsResonanceAudioSpatializer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool SpatializerHelper_get_IsResonanceAudioSpatializer_mD1C8AD9A84CEF3700DA5AD1C9B3E23275F0970B1 (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral0C1FBCAE463347B711E91243B552C4DF38EEC101);
		s_Il2CppMethodInitialized = true;
	}
	{
		// return SelectedSpatializer == ResonanceAudioSpatializer;
		String_t* L_0;
		L_0 = SpatializerHelper_get_SelectedSpatializer_mB52A6D2150B333FC3DD6599DAE874105AEC6A0EC(NULL);
		bool L_1;
		L_1 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_0, _stringLiteral0C1FBCAE463347B711E91243B552C4DF38EEC101, NULL);
		return L_1;
	}
}
// System.String DarkTonic.MasterAudio.SpatializerHelper::get_SelectedSpatializer()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* SpatializerHelper_get_SelectedSpatializer_mB52A6D2150B333FC3DD6599DAE874105AEC6A0EC (const RuntimeMethod* method) 
{
	{
		// return AudioSettings.GetSpatializerPluginName();
		String_t* L_0;
		L_0 = AudioSettings_GetSpatializerPluginName_m60C2C3FA09CB0422D1EDAE5185F20BF01689BF00(NULL);
		return L_0;
	}
}
// System.Void DarkTonic.MasterAudio.SpatializerHelper::TurnOnSpatializerIfEnabled(UnityEngine.AudioSource)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SpatializerHelper_TurnOnSpatializerIfEnabled_m7095289E4B50FC25986DDE6D97CC8272263860C7 (AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* ___source0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (MasterAudio.SafeInstance == null) {
		il2cpp_codegen_runtime_class_init_inline(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558* L_0;
		L_0 = MasterAudio_get_SafeInstance_m032232A242182E424132E6CB8C80BA00D9CC091A(NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (!L_1)
		{
			goto IL_0015;
		}
	}
	{
		// SetSpatializerToggleOnSource(source, false);
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_2 = ___source0;
		SpatializerHelper_SetSpatializerToggleOnSource_m21F992B71E092C0CB3255A2B5F1B185C623A6E52(L_2, (bool)0, NULL);
		// return;
		return;
	}

IL_0015:
	{
		// if (!MasterAudio.Instance.useSpatializer) {
		il2cpp_codegen_runtime_class_init_inline(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558* L_3;
		L_3 = MasterAudio_get_Instance_mB49DFB52492BA4B3F6960CCFF67F985A6C892F14(NULL);
		NullCheck(L_3);
		bool L_4 = L_3->___useSpatializer_86;
		if (L_4)
		{
			goto IL_0029;
		}
	}
	{
		// SetSpatializerToggleOnSource(source, false);
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_5 = ___source0;
		SpatializerHelper_SetSpatializerToggleOnSource_m21F992B71E092C0CB3255A2B5F1B185C623A6E52(L_5, (bool)0, NULL);
		// return;
		return;
	}

IL_0029:
	{
		// SetSpatializerToggleOnSource(source, true);
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_6 = ___source0;
		SpatializerHelper_SetSpatializerToggleOnSource_m21F992B71E092C0CB3255A2B5F1B185C623A6E52(L_6, (bool)1, NULL);
		// if (!ResonanceAudioHelper.ResonanceAudioOptionExists) {
		bool L_7;
		L_7 = ResonanceAudioHelper_get_ResonanceAudioOptionExists_m81BCE075CFF4C788AE27E3CEC30B2E67AD5BA1A0(NULL);
		if (L_7)
		{
			goto IL_0038;
		}
	}
	{
		// return;
		return;
	}

IL_0038:
	{
		// if (!MasterAudio.Instance.useSpatializerPostFX) {
		il2cpp_codegen_runtime_class_init_inline(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558* L_8;
		L_8 = MasterAudio_get_Instance_mB49DFB52492BA4B3F6960CCFF67F985A6C892F14(NULL);
		NullCheck(L_8);
		bool L_9 = L_8->___useSpatializerPostFX_87;
		if (L_9)
		{
			goto IL_0045;
		}
	}
	{
		// return;
		return;
	}

IL_0045:
	{
		// source.spatializePostEffects = true;
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_10 = ___source0;
		NullCheck(L_10);
		AudioSource_set_spatializePostEffects_m7CC219B7790E27667D49F4A36C8F62FFF399DA54(L_10, (bool)1, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.SpatializerHelper::SetSpatializerToggleOnSource(UnityEngine.AudioSource,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void SpatializerHelper_SetSpatializerToggleOnSource_m21F992B71E092C0CB3255A2B5F1B185C623A6E52 (AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* ___source0, bool ___enabled1, const RuntimeMethod* method) 
{
	{
		// if (enabled) {
		bool L_0 = ___enabled1;
		if (!L_0)
		{
			goto IL_0015;
		}
	}
	{
		// enabled = source.spatialBlend != 0;
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_1 = ___source0;
		NullCheck(L_1);
		float L_2;
		L_2 = AudioSource_get_spatialBlend_m06E7948B2813AA3EAE031BD4D1DE61A29416B1CE(L_1, NULL);
		___enabled1 = (bool)((((int32_t)((((float)L_2) == ((float)(0.0f)))? 1 : 0)) == ((int32_t)0))? 1 : 0);
	}

IL_0015:
	{
		// source.spatialize = enabled;
		AudioSource_t871AC2272F896738252F04EE949AEF5B241D3299* L_3 = ___source0;
		bool L_4 = ___enabled1;
		NullCheck(L_3);
		AudioSource_set_spatialize_mDFA357EDCB0C59EF11F53C845F7ACBF6BF7F7B3C(L_3, L_4, NULL);
		// }
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.String DarkTonic.MasterAudio.UtilStrings::TrimSpace(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UtilStrings_TrimSpace_m2C154BCACBB0462F143FF824DADD63C26D18E9E3 (String_t* ___untrimmed0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&String_t_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (string.IsNullOrEmpty(untrimmed)) {
		String_t* L_0 = ___untrimmed0;
		bool L_1;
		L_1 = String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478(L_0, NULL);
		if (!L_1)
		{
			goto IL_000e;
		}
	}
	{
		// return string.Empty;
		String_t* L_2 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->___Empty_6;
		return L_2;
	}

IL_000e:
	{
		// return untrimmed.Trim();
		String_t* L_3 = ___untrimmed0;
		NullCheck(L_3);
		String_t* L_4;
		L_4 = String_Trim_mCD6D8C6D4CFD15225D12DB7D3E0544CA80FB8DA5(L_3, NULL);
		return L_4;
	}
}
// System.String DarkTonic.MasterAudio.UtilStrings::ReplaceUnsafeChars(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR String_t* UtilStrings_ReplaceUnsafeChars_m39A7700249D31AF4EF6E3D5AE7773CD539DCD247 (String_t* ___source0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral202D5AEF51C14B19CFE144337C7FDB3B9A7C7387);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral81FECCD01231D97EE6D7C17B8F5531FE1A6D533E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral8D004CCFB2C7F7062B882865483FF7F4DC36E04E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC7AFC69BFA0D3853573E4A41A19EBA2C80E84642);
		s_Il2CppMethodInitialized = true;
	}
	{
		// source = source.Replace("'", "&apos;");
		String_t* L_0 = ___source0;
		NullCheck(L_0);
		String_t* L_1;
		L_1 = String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166(L_0, _stringLiteral42646B33B50B6AA15E22733C8900716F0FE19E1D, _stringLiteralC7AFC69BFA0D3853573E4A41A19EBA2C80E84642, NULL);
		___source0 = L_1;
		// source = source.Replace("\"", "&quot;");
		String_t* L_2 = ___source0;
		NullCheck(L_2);
		String_t* L_3;
		L_3 = String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166(L_2, _stringLiteralC62C64F00567C5368CAE37F4E64E1E82FF785677, _stringLiteral81FECCD01231D97EE6D7C17B8F5531FE1A6D533E, NULL);
		___source0 = L_3;
		// source = source.Replace("&", "&amp;");
		String_t* L_4 = ___source0;
		NullCheck(L_4);
		String_t* L_5;
		L_5 = String_Replace_mABDB7003A1D0AEDCAE9FF85E3DFFFBA752D2A166(L_4, _stringLiteral8D004CCFB2C7F7062B882865483FF7F4DC36E04E, _stringLiteral202D5AEF51C14B19CFE144337C7FDB3B9A7C7387, NULL);
		___source0 = L_5;
		// return source;
		String_t* L_6 = ___source0;
		return L_6;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_Awake_m6F09E7960E68FCEFCF9E53806BAA77C711DD67F7 (MasterAudioMultiplayerAdapter_t41A811EE167500BE05C8479E0BFFEA15617E924D* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBB2DB99551FBBC9B6B35D6F17FC03ADE79129C56);
		s_Il2CppMethodInitialized = true;
	}
	{
		// Debug.LogError("You must install one of the multiplayer packages in order for MAM to work. The default can compile but doesn't do anything.");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(_stringLiteralBB2DB99551FBBC9B6B35D6F17FC03ADE79129C56, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::FireCustomEvent(System.String,UnityEngine.Transform,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_FireCustomEvent_mDE6498F7A0D08B2EEA2547E801FD4B459B6B7917 (String_t* ___enterCustomEvent0, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____actorTrans1, bool ___logDupeEventFiring2, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::AudioListenerPause(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_AudioListenerPause_mA691A2242ED27A4CCCCA3D43F94E962369365F39 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____actorTrans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::AudioListenerUnpause(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_AudioListenerUnpause_mAF3B7B340958B7DA7200309EB2479BC565D153CB (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____actorTrans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopSoundGroupOfTransform(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopSoundGroupOfTransform_mD0D6B40AB138845531E529BC9002E97BAFA85EC7 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____actorTrans0, String_t* ___timedSoundGroup1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PlaySound3DFollowTransformAndForget(System.String,UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PlaySound3DFollowTransformAndForget_mB1968EBD6F3F5A1BA3F8C48E74AC4207D8B77CFE (String_t* ___enterSoundGroup0, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____actorTrans1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PlaySound3DFollowTransformAndForget(System.String,UnityEngine.Transform,System.Single,System.Nullable`1<System.Single>,System.Single,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PlaySound3DFollowTransformAndForget_m102A4036062A60596FFAC6CCFCF40AB3ED30824A (String_t* ___enterSoundGroup0, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____actorTrans1, float ___volume2, Nullable_1_t3D746CBB6123D4569FF4DEA60BC4240F32C6FE75 ___pitch3, float ___delay4, String_t* ___varName5, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PlaySound3DAtTransformAndForget(System.String,UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PlaySound3DAtTransformAndForget_m5B54C9382E4A72B9D9F1998C4F89E1F4C3F75C39 (String_t* ___enterSoundGroup0, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____actorTrans1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PlaySound3DAtTransformAndForget(System.String,UnityEngine.Transform,System.Single,System.Nullable`1<System.Single>,System.Single,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PlaySound3DAtTransformAndForget_mA4440432E6F25F3E1E2382826F6839C035057892 (String_t* ___enterSoundGroup0, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ____actorTrans1, float ___volume2, Nullable_1_t3D746CBB6123D4569FF4DEA60BC4240F32C6FE75 ___pitch3, float ___delay4, String_t* ___varName5, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// DarkTonic.MasterAudio.PlaySoundResult DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PlaySound3DAtTransform(System.String,UnityEngine.Transform,System.Single,System.Nullable`1<System.Single>,System.Single,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlaySoundResult_tC80DDE04F4A72B80791A0E79DB78708E1160BF96* MasterAudioMultiplayerAdapter_PlaySound3DAtTransform_mCFFC546514FDFE4E732EA5D1ACF1D4A5C85C24D6 (String_t* ___sType0, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans1, float ___volume2, Nullable_1_t3D746CBB6123D4569FF4DEA60BC4240F32C6FE75 ___pitch3, float ___delay4, String_t* ___variationName5, const RuntimeMethod* method) 
{
	{
		// return null;
		return (PlaySoundResult_tC80DDE04F4A72B80791A0E79DB78708E1160BF96*)NULL;
	}
}
// DarkTonic.MasterAudio.PlaySoundResult DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PlaySound3DFollowTransform(System.String,UnityEngine.Transform,System.Single,System.Nullable`1<System.Single>,System.Single,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlaySoundResult_tC80DDE04F4A72B80791A0E79DB78708E1160BF96* MasterAudioMultiplayerAdapter_PlaySound3DFollowTransform_m5E81A8D7EADF18D38A67704BDE9D8EB89E53952B (String_t* ___sType0, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans1, float ___volume2, Nullable_1_t3D746CBB6123D4569FF4DEA60BC4240F32C6FE75 ___pitch3, float ___delay4, String_t* ___variationName5, const RuntimeMethod* method) 
{
	{
		// return null;
		return (PlaySoundResult_tC80DDE04F4A72B80791A0E79DB78708E1160BF96*)NULL;
	}
}
// DarkTonic.MasterAudio.PlaySoundResult DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PlaySound(UnityEngine.Transform,System.String,System.Single,System.Nullable`1<System.Single>,System.Single,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR PlaySoundResult_tC80DDE04F4A72B80791A0E79DB78708E1160BF96* MasterAudioMultiplayerAdapter_PlaySound_m2583959095A001458119B5D54D6346DDDF6C1EAD (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___sType1, float ___volume2, Nullable_1_t3D746CBB6123D4569FF4DEA60BC4240F32C6FE75 ___pitch3, float ___delay4, String_t* ___variationName5, const RuntimeMethod* method) 
{
	{
		// return null;
		return (PlaySoundResult_tC80DDE04F4A72B80791A0E79DB78708E1160BF96*)NULL;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::FadeOutAllOfSound(UnityEngine.Transform,System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_FadeOutAllOfSound_mB0D68D1CFC58B6D7F96E8037B41E9441FD9B553D (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, float ___fadeTime2, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PlaySound3DAtTransformAndForget(System.String,UnityEngine.Transform,System.Single,System.Nullable`1<System.Single>,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PlaySound3DAtTransformAndForget_mC9341902EB89F2029E376A7B8C044BFD40E00100 (String_t* ___sType0, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans1, float ___volume2, Nullable_1_t3D746CBB6123D4569FF4DEA60BC4240F32C6FE75 ___pitch3, float ___delaySound4, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PlaySound3DFollowTransformAndForget(System.String,UnityEngine.Transform,System.Single,System.Nullable`1<System.Single>,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PlaySound3DFollowTransformAndForget_m5F9796626B953B9C6BF264F83A0688B45F22F62D (String_t* ___sType0, Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans1, float ___volume2, Nullable_1_t3D746CBB6123D4569FF4DEA60BC4240F32C6FE75 ___pitch3, float ___delaySound4, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PlaySoundAndForget(UnityEngine.Transform,System.String,System.Single,System.Nullable`1<System.Single>,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PlaySoundAndForget_m1D5866A2D8CEA66F818A1F3F8AE7589D837AA648 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___sType1, float ___volume2, Nullable_1_t3D746CBB6123D4569FF4DEA60BC4240F32C6FE75 ___pitch3, float ___delaySound4, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PlaySoundAndForget(UnityEngine.Transform,System.String,System.Single,System.Nullable`1<System.Single>,System.Single,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PlaySoundAndForget_m54430B4A6567AB0251BE4979DC3D232E4E7253AD (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___sType1, float ___volume2, Nullable_1_t3D746CBB6123D4569FF4DEA60BC4240F32C6FE75 ___pitch3, float ___delay4, String_t* ___variationName5, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::FadeOutSoundGroupOfTransform(UnityEngine.Transform,System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_FadeOutSoundGroupOfTransform_mEC0A41B5C7D94389F16D47A6A69A03FF04250EB8 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, float ___fadeTime2, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::FadeSoundGroupOfTransformToVolume(UnityEngine.Transform,System.String,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_FadeSoundGroupOfTransformToVolume_m8220F85E1024C5DE43BCF53042AAB895D9443AA7 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, float ___fadeTime2, float ___fadeVolume3, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::RefillSoundGroupPool(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_RefillSoundGroupPool_mC05E808A926E1C1F56A0C6DE706BB22D27007D54 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::FadeSoundGroupToVolume(UnityEngine.Transform,System.String,System.Single,System.Single,System.Action,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_FadeSoundGroupToVolume_mF54B4196C318610EF7E51B9AF613F3D9BD3AEAA1 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, float ___targetVol2, float ___fadeTime3, Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___completionCallback4, bool ___stopAfterFade5, bool ___restoreVolumeAfterFade6, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::MuteGroup(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_MuteGroup_m71A408F14943F76B40B30C4D750A03985DD79F2A (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PauseSoundGroup(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PauseSoundGroup_m43FAAEAB42A42580A54A378DFF5A4811CEA2E6B3 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::SoloGroup(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_SoloGroup_m264C7BF10BA6AE188B2383CA7DCA7971E2678333 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopAllOfSound(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopAllOfSound_mB1DBB2BC2D9DEA7296EEBB465CAA2906E86B7781 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnmuteGroup(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnmuteGroup_mC72646C9E23DD889EF5EC0BB1BF9E17AAC0D4F7C (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnpauseSoundGroup(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnpauseSoundGroup_m3073F6A269C733381A5051234F165F6E2BE4CCC9 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnsoloGroup(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnsoloGroup_m4FEB9DDC67D291089AF6BF306F139B8CDF7E7ADF (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopAllSoundsOfTransform(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopAllSoundsOfTransform_m1D377EC4CBEE273D35A85B3070C59143D481F5C4 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PauseAllSoundsOfTransform(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PauseAllSoundsOfTransform_m8F8038B59D5E8B608E19DB6DC5AF834741331C00 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PauseSoundGroupOfTransform(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PauseSoundGroupOfTransform_m938052EECB25D5BA7024584641B33F4A859B7C14 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnpauseAllSoundsOfTransform(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnpauseAllSoundsOfTransform_mD4728E9C5A353C02F3B5DD278CEE795DE4A22601 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnpauseSoundGroupOfTransform(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnpauseSoundGroupOfTransform_m99EE872E590B68C124342C0C38F1F529F3360B9F (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::FadeOutAllSoundsOfTransform(UnityEngine.Transform,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_FadeOutAllSoundsOfTransform_m32D01145FBE6B7B94D61CD7DD84ECC8AF0ED1CF1 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, float ___fadeTime1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::RouteGroupToBus(UnityEngine.Transform,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_RouteGroupToBus_mBC334C5274B32EDF961BA3CCFD18B8B8F1C16D26 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, String_t* ___busName2, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::GlideSoundGroupByPitch(UnityEngine.Transform,System.String,System.Single,System.Single,System.Action)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_GlideSoundGroupByPitch_mD0F446118CA5A69139ABD8D737F1D81CCD33822F (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, float ___targetGlidePitch2, float ___pitchGlideTime3, Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___completionCallback4, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopOldSoundGroupVoices(UnityEngine.Transform,System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopOldSoundGroupVoices_m4F879A21543179BA13404CAABF44DC7F76133E60 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, float ___minAge2, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::FadeOutOldSoundGroupVoices(UnityEngine.Transform,System.String,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_FadeOutOldSoundGroupVoices_m7E6B04FD5A2A0F3403194588EC06613953226703 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___soundType1, float ___minAge2, float ___fadeTime3, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::FadeBusToVolume(UnityEngine.Transform,System.String,System.Single,System.Single,System.Action,System.Boolean,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_FadeBusToVolume_m8A3783C29D2C2269520B9D378D2F7F1C6AFDB190 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, float ___targetVol2, float ___fadeTime3, Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___completionCallback4, bool ___stopAfterFade5, bool ___restoreVolumeAfterFade6, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::GlideBusByPitch(UnityEngine.Transform,System.String,System.Single,System.Single,System.Action)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_GlideBusByPitch_mFD04DF405E6212F126A8CE5304F89D54E896857D (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, float ___targetGlidePitch2, float ___pitchGlideTime3, Action_tD00B0A84D7945E50C2DFFC28EFEE6ED44ED2AD07* ___completionCallback4, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PauseBus(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PauseBus_m8F1C0AD563BF2DF0BD5D83AC172E6DFEC01BB46D (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopBus(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopBus_m1591A03301CB78DC3EAFB18E89AD1763541CBB28 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnpauseBus(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnpauseBus_m4DE6428D22B78D06F3BB14B47331300C3A9BBB26 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::MuteBus(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_MuteBus_m25314C688D9C32C5FBB02A03A1BEA1A0B1C1DB0F (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnmuteBus(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnmuteBus_mCCA582FF67D4DF84C4EBA72A01219C9F867973B5 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::ToggleMuteBus(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_ToggleMuteBus_m8F37593F77A72C858248197C6B842A01AB271EE5 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::SoloBus(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_SoloBus_mA9D9CE56C52B5F499D0E2B79FFDEFD95E1B111C5 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnsoloBus(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnsoloBus_m2F008004A0EC9BC1E4B4815CEB940D094DA172A9 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::ChangeBusPitch(UnityEngine.Transform,System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_ChangeBusPitch_mE456C0A5BCC5EBEE6D92469E2DC64AE6110DE915 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, float ___pitch2, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PauseBusOfTransform(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PauseBusOfTransform_m09C870C48F9F18D58F751A7723F5ECC93B21AF3C (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnpauseBusOfTransform(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnpauseBusOfTransform_m129D4CD9967DB089EB07F4B9B7EA8C9078D49B44 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::RestartAllPlaylists(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_RestartAllPlaylists_m718BF4972A585E141F4C10ACF6A76DB88A64DA78 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopBusOfTransform(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopBusOfTransform_mF7FAF934EE09D4576DD6A1E401B3DCE43B4C8022 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopOldBusVoices(UnityEngine.Transform,System.String,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopOldBusVoices_mAEDACA6F60A0E1381B40731CE9DB017824031A49 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, float ___minAge2, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::FadeOutOldBusVoices(UnityEngine.Transform,System.String,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_FadeOutOldBusVoices_m72B6C707DED25CD3D481A4D04CE15225AE323697 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___busName1, float ___minAge2, float ___fadeTime3, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::SetMasterMixerVolume(UnityEngine.Transform,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_SetMasterMixerVolume_m0E45223DB5C3F0EB01E42F7BB7A521AD3446862A (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, float ___targetVol1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::SetPlaylistMasterVolume(UnityEngine.Transform,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_SetPlaylistMasterVolume_mE50F0DFC8B4CCA902F2AC0138F7CB3958C62E6E4 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, float ___tgtVol1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PauseMixer(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PauseMixer_m7E0728276A6C6CDBFF7B6C4EF41D17176F72612A (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnpauseMixer(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnpauseMixer_mC3AAA6184D02A0EF09B3C005D0220C6426DC7EF5 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopMixer(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopMixer_m88C82F1D430D4341074E65AA4CCE12AB16AA2BA9 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::MuteEverything(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_MuteEverything_m3C9979B4D9E3578076034930B1BBD90B6171BE24 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnmuteEverything(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnmuteEverything_m64AB9E2393ED2C102A250708D02B393C91DF04FE (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PauseEverything(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PauseEverything_m6652547E7546EAEEECB1F02640186F16DF4E06C5 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnpauseEverything(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnpauseEverything_m619ADF0C4AF867BB99D8CC551CD6E6222C9832DF (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopEverything(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopEverything_m50454EF7BD1C601259CAA1931DC8D1BE4DD10815 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::RestartPlaylist(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_RestartPlaylist_m90FC71AB70C136B16BA4E1B3F4DCB2CFC37579C6 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StartPlaylist(UnityEngine.Transform,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StartPlaylist_m3B74F6F4D9B4B2D9EA28D1EDD6B6353CB8BAA8AF (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, String_t* ___playlistName2, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::ChangePlaylistByName(UnityEngine.Transform,System.String,System.String,System.Boolean)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_ChangePlaylistByName_mA2080A85DE22E4913B181A32BFB67E37A141C811 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, String_t* ___playlistName2, bool ___startPlaylist3, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopLoopingAllCurrentSongs(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopLoopingAllCurrentSongs_mA43379CC10D87A76A39F5271475891197A148921 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopLoopingCurrentSong(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopLoopingCurrentSong_m907A623E50D7E258A0F78E6D32FAF93F7A3A10B7 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopAllPlaylistsAfterCurrentSongs(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopAllPlaylistsAfterCurrentSongs_m39A4FB413B8043964B8B251DE099DC5497BDC930 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopPlaylistAfterCurrentSong(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopPlaylistAfterCurrentSong_m2F06925E9E6E748417A50C9186BD09258B51292A (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::FadeAllPlaylistsToVolume(UnityEngine.Transform,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_FadeAllPlaylistsToVolume_m7BB238172D583E919BB3B659FA16464F59639243 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, float ___targetVol1, float ___fadeTime2, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::FadePlaylistToVolume(UnityEngine.Transform,System.String,System.Single,System.Single)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_FadePlaylistToVolume_m0DD08335A57A12FAAC64462FEA6CBC80B2B97C63 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, float ___targetVol2, float ___fadeTime3, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::MuteAllPlaylists(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_MuteAllPlaylists_mC113C42B6814B3C16FEFA8C02B4414187D1EC5CC (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::MutePlaylist(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_MutePlaylist_m378E66C0C28A057A20CF37C49ACB48BFF5F49903 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnmuteAllPlaylists(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnmuteAllPlaylists_m4865E40ED6DEA13FD117193579625CB933C602DE (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnmutePlaylist(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnmutePlaylist_m1E5CAC27D7DF573AE930A1BF70E255E531E69568 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::ToggleMuteAllPlaylists(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_ToggleMuteAllPlaylists_m6CF6E262EF8E1F1C71A1C5509474B07DB8496304 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::ToggleMutePlaylist(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_ToggleMutePlaylist_m0CC27464B8F15B2E9F6566A62BA8B5B6BD354D46 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Boolean DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::TriggerPlaylistClip(UnityEngine.Transform,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MasterAudioMultiplayerAdapter_TriggerPlaylistClip_mD503CE3A3CDEDEA5D643D29BD2471900F2F4784F (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, String_t* ___clipName2, const RuntimeMethod* method) 
{
	{
		// return false;
		return (bool)0;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::QueuePlaylistClip(UnityEngine.Transform,System.String,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_QueuePlaylistClip_m40CA4A11E6FA024CB629ADE622539D786AD62D95 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, String_t* ___clipName2, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::TriggerRandomClipAllPlaylists(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_TriggerRandomClipAllPlaylists_m5055204130F02483DBFDDD370968CAC0B58B0226 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::TriggerRandomPlaylistClip(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_TriggerRandomPlaylistClip_mA167D9630E628F32AFCA9DA46368D18EB786D8C9 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::TriggerNextClipAllPlaylists(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_TriggerNextClipAllPlaylists_m10EA80FB5AFDF2EB5F71CCAD90E617D76BF0F639 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::TriggerNextPlaylistClip(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_TriggerNextPlaylistClip_m9101A7B3071086687F88D559951B51195C08BCA7 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PauseAllPlaylists(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PauseAllPlaylists_mC32EC9563E0B214EC2359BF57ADFB255AE816B7C (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::PausePlaylist(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_PausePlaylist_m4CD4753603D00D70243117696EAADC76DFBB63BA (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopAllPlaylists(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopAllPlaylists_m6748DFD319E89FBBB6A94F7240E9A5D834F7F5FA (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::StopPlaylist(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_StopPlaylist_m524966AB7A5957DBBC6E43E653FDE848873915A9 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnpauseAllPlaylists(UnityEngine.Transform)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnpauseAllPlaylists_m774F91F9DAAE21548EDCD29231C3CFE281079917 (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::UnpausePlaylist(UnityEngine.Transform,System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter_UnpausePlaylist_m83A7F26B5FA8E63C6F7B173A4295CE7E55D1350B (Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* ___trans0, String_t* ___playlistControllerName1, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Boolean DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::get_CanSendRPCs()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MasterAudioMultiplayerAdapter_get_CanSendRPCs_mB5D0C0282FCCFD6202E7DE5DAF564137631AF3B0 (const RuntimeMethod* method) 
{
	{
		// return false;
		return (bool)0;
	}
}
// System.Void DarkTonic.MasterAudio.Multiplayer.MasterAudioMultiplayerAdapter::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MasterAudioMultiplayerAdapter__ctor_m0F390D0BB48102B9342779275BF118D19D618D40 (MasterAudioMultiplayerAdapter_t41A811EE167500BE05C8479E0BFFEA15617E924D* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Examples.MA_Bootstrapper::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_Bootstrapper_Awake_m5EA46AD245231D1CF68EE064C1BA93ECD8048E5C (MA_Bootstrapper_t3C33A30BC81199B87CF3B8B066BFF092AF052887* __this, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_Bootstrapper::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_Bootstrapper_OnGUI_mE4D980A361080EA2D94AFD8566CF29AA3A7133B8 (MA_Bootstrapper_t3C33A30BC81199B87CF3B8B066BFF092AF052887* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tA9CDB3D69DB13D51AD83ABDB587EF95947EC2D2A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral6346B05F30B85515CEFB378F9FD91DE3CA795F8F);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral85CAF10C9031702FC59B676CDC3EA8B9070CAEA9);
		s_Il2CppMethodInitialized = true;
	}
	{
		// GUI.Label(new Rect(20, 40, 640, 190), "This is the Bootstrapper Scene. Set it up in BuildSettings as the first Scene. Then add '_AfterBootstrapperScene' as the second Scene. Hit play. Master Audio is configured in 'persist between Scenes' mode. "
		//     + "Finally, click 'Load Game Scene' button and notice how the music doesn't get interruped even though we're changing Scenes. Normally a Bootstrapper Scene would not be seen. We are illustrating how to set up though. Notice that no Sound Groups are set up in Master Audio. Sample music provided by Alchemy Studios. This music 'The Epic Trailer' (longer version) is available on the Asset Store!");
		Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D L_0;
		memset((&L_0), 0, sizeof(L_0));
		Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23((&L_0), (20.0f), (40.0f), (640.0f), (190.0f), /*hidden argument*/NULL);
		il2cpp_codegen_runtime_class_init_inline(GUI_tA9CDB3D69DB13D51AD83ABDB587EF95947EC2D2A_il2cpp_TypeInfo_var);
		GUI_Label_m4A951E57C7DCCF95A0306240144CA2713F546526(L_0, _stringLiteral6346B05F30B85515CEFB378F9FD91DE3CA795F8F, NULL);
		// if (GUI.Button(new Rect(100, 150, 150, 100), "Load Game Scene"))
		Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D L_1;
		memset((&L_1), 0, sizeof(L_1));
		Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23((&L_1), (100.0f), (150.0f), (150.0f), (100.0f), /*hidden argument*/NULL);
		bool L_2;
		L_2 = GUI_Button_m26D18B144D3116398B9E9BECB0C4014F57DBE44B(L_1, _stringLiteral85CAF10C9031702FC59B676CDC3EA8B9070CAEA9, NULL);
		if (!L_2)
		{
			goto IL_004e;
		}
	}
	{
		// UnityEngine.SceneManagement.SceneManager.LoadScene(1);
		il2cpp_codegen_runtime_class_init_inline(SceneManager_tA0EF56A88ACA4A15731AF7FDC10A869FA4C698FA_il2cpp_TypeInfo_var);
		SceneManager_LoadScene_m0957E62F2A0A0243C79394E5B74E8EFA86BE5ED1(1, NULL);
	}

IL_004e:
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_Bootstrapper::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_Bootstrapper__ctor_mD2E61AF67C08D4E2AE26455E4A79A9EF4A4C7973 (MA_Bootstrapper_t3C33A30BC81199B87CF3B8B066BFF092AF052887* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Examples.MA_DestroyFinishedParticle::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_DestroyFinishedParticle_Awake_m344C41FE68BB382B95BAB955B6C2654C33267E2B (MA_DestroyFinishedParticle_tBD633205873167544519D41760934A254D47B8CB* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Component_GetComponent_TisParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1_mF2B700ECAEEEDBCC076CC66C9592C6DDFA0D36F9_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// this.useGUILayout = false;
		MonoBehaviour_set_useGUILayout_m56F0C62F4B6889D7472074ECCB56EBA462285134(__this, (bool)0, NULL);
		// this.particles = this.GetComponent<ParticleSystem>();
		ParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1* L_0;
		L_0 = Component_GetComponent_TisParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1_mF2B700ECAEEEDBCC076CC66C9592C6DDFA0D36F9(__this, Component_GetComponent_TisParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1_mF2B700ECAEEEDBCC076CC66C9592C6DDFA0D36F9_RuntimeMethod_var);
		__this->___particles_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___particles_4), (void*)L_0);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_DestroyFinishedParticle::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_DestroyFinishedParticle_Update_m42D7C2C63278824F7D6C5B91EE68565EB49F26BD (MA_DestroyFinishedParticle_tBD633205873167544519D41760934A254D47B8CB* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (!this.particles.IsAlive())
		ParticleSystem_tB19986EE308BD63D36FB6025EEEAFBEDB97C67C1* L_0 = __this->___particles_4;
		NullCheck(L_0);
		bool L_1;
		L_1 = ParticleSystem_IsAlive_mF1B0F10ED9EDCB5D971471DDEB0C55C9638FAE56(L_0, NULL);
		if (L_1)
		{
			goto IL_0018;
		}
	}
	{
		// Destroy(this.gameObject);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_2;
		L_2 = Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_Destroy_mE97D0A766419A81296E8D4E5C23D01D3FE91ACBB(L_2, NULL);
	}

IL_0018:
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_DestroyFinishedParticle::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_DestroyFinishedParticle__ctor_m7F7CC06BA9C43372F6FB30D45965884AD4305366 (MA_DestroyFinishedParticle_tBD633205873167544519D41760934A254D47B8CB* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Examples.MA_EnemyOne::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_EnemyOne_Awake_m79F36D6BEBBBA1DDB71A6D3DEB099C2DFF83065A (MA_EnemyOne_t7D3293CA87F514A361A57200B85C47D7BC5A00D6* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral606CE144FC64CABEF1C61843BE8A54F4B200825B);
		s_Il2CppMethodInitialized = true;
	}
	{
		// useGUILayout = false;
		MonoBehaviour_set_useGUILayout_m56F0C62F4B6889D7472074ECCB56EBA462285134(__this, (bool)0, NULL);
		// _trans = transform;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_0;
		L_0 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(__this, NULL);
		__this->____trans_5 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____trans_5), (void*)L_0);
		// _speed = Random.Range(-3, -8) * AudioUtil.FrameTime;
		int32_t L_1;
		L_1 = Random_Range_m6763D9767F033357F88B6637F048F4ACA4123B68(((int32_t)-3), ((int32_t)-8), NULL);
		float L_2;
		L_2 = AudioUtil_get_FrameTime_m51FB868DF9ACC0EA6F681F00863762E399FD6109(NULL);
		__this->____speed_6 = ((float)il2cpp_codegen_multiply(((float)L_1), L_2));
		// _horizSpeed = Random.Range(-3, 3) * AudioUtil.FrameTime;
		int32_t L_3;
		L_3 = Random_Range_m6763D9767F033357F88B6637F048F4ACA4123B68(((int32_t)-3), 3, NULL);
		float L_4;
		L_4 = AudioUtil_get_FrameTime_m51FB868DF9ACC0EA6F681F00863762E399FD6109(NULL);
		__this->____horizSpeed_7 = ((float)il2cpp_codegen_multiply(((float)L_3), L_4));
		// Debug.LogError("MA_EnemyOne and this example Scene will not work properly without Physics3D package installed. Please enable it in the Master Audio Welcome Window if it's already installed.");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(_stringLiteral606CE144FC64CABEF1C61843BE8A54F4B200825B, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_EnemyOne::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_EnemyOne_Update_mA017B5F34BC3B2DE55A7C70C23BF1831C62B7276 (MA_EnemyOne_t7D3293CA87F514A361A57200B85C47D7BC5A00D6* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		// var pos = _trans.position;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_0 = __this->____trans_5;
		NullCheck(L_0);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1;
		L_1 = Transform_get_position_m69CD5FA214FDAE7BB701552943674846C220FDE1(L_0, NULL);
		V_0 = L_1;
		// pos.x += _horizSpeed;
		float* L_2 = (&(&V_0)->___x_2);
		float* L_3 = L_2;
		float L_4 = *((float*)L_3);
		float L_5 = __this->____horizSpeed_7;
		*((float*)L_3) = (float)((float)il2cpp_codegen_add(L_4, L_5));
		// pos.y += _speed;
		float* L_6 = (&(&V_0)->___y_3);
		float* L_7 = L_6;
		float L_8 = *((float*)L_7);
		float L_9 = __this->____speed_6;
		*((float*)L_7) = (float)((float)il2cpp_codegen_add(L_8, L_9));
		// _trans.position = pos;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_10 = __this->____trans_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_11 = V_0;
		NullCheck(L_10);
		Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156(L_10, L_11, NULL);
		// _trans.Rotate(Vector3.down * 300 * AudioUtil.FrameTime);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_12 = __this->____trans_5;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_13;
		L_13 = Vector3_get_down_mF62B2AE7C5AC31EAC9CB62797C7190C90A7A8599_inline(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_14;
		L_14 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_13, (300.0f), NULL);
		float L_15;
		L_15 = AudioUtil_get_FrameTime_m51FB868DF9ACC0EA6F681F00863762E399FD6109(NULL);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_16;
		L_16 = Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline(L_14, L_15, NULL);
		NullCheck(L_12);
		Transform_Rotate_m2A308205498AFEEA3DF784B1C86E4F7C126CA2EE(L_12, L_16, NULL);
		// if (_trans.position.y < -5)
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_17 = __this->____trans_5;
		NullCheck(L_17);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_18;
		L_18 = Transform_get_position_m69CD5FA214FDAE7BB701552943674846C220FDE1(L_17, NULL);
		float L_19 = L_18.___y_3;
		if ((!(((float)L_19) < ((float)(-5.0f)))))
		{
			goto IL_0080;
		}
	}
	{
		// Destroy(gameObject);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_20;
		L_20 = Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_Destroy_mE97D0A766419A81296E8D4E5C23D01D3FE91ACBB(L_20, NULL);
	}

IL_0080:
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_EnemyOne::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_EnemyOne__ctor_m38E429E35EF1E24F630F67755A718040A49B2A3C (MA_EnemyOne_t7D3293CA87F514A361A57200B85C47D7BC5A00D6* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Examples.MA_EnemySpawner::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_EnemySpawner_Awake_m9752260163C334D12F6062A077363D921B9D8B2A (MA_EnemySpawner_t21E3F60FD5616FE485106C6880615D53C44AC9A1* __this, const RuntimeMethod* method) 
{
	{
		// this.useGUILayout = false;
		MonoBehaviour_set_useGUILayout_m56F0C62F4B6889D7472074ECCB56EBA462285134(__this, (bool)0, NULL);
		// this.trans = this.transform;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_0;
		L_0 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(__this, NULL);
		__this->___trans_6 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->___trans_6), (void*)L_0);
		// this.nextSpawnTime = AudioUtil.Time + Random.Range(.3f, .7f);
		float L_1;
		L_1 = AudioUtil_get_Time_mEA625F0CBC286EC5E4C34679D77B8E17DC82839E(NULL);
		float L_2;
		L_2 = Random_Range_m5236C99A7D8AE6AC9190592DC66016652A2D2494((0.300000012f), (0.699999988f), NULL);
		__this->___nextSpawnTime_7 = ((float)il2cpp_codegen_add(L_1, L_2));
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_EnemySpawner::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_EnemySpawner_Update_mF30B20EB0C07E991D23AC6ADDB293ED25854A042 (MA_EnemySpawner_t21E3F60FD5616FE485106C6880615D53C44AC9A1* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	{
		// if (!spawnerEnabled)
		bool L_0 = __this->___spawnerEnabled_5;
		if (L_0)
		{
			goto IL_0009;
		}
	}
	{
		// return;
		return;
	}

IL_0009:
	{
		// if (Time.time >= this.nextSpawnTime)
		float L_1;
		L_1 = Time_get_time_m3A271BB1B20041144AC5B7863B71AB1F0150374B(NULL);
		float L_2 = __this->___nextSpawnTime_7;
		if ((!(((float)L_1) >= ((float)L_2))))
		{
			goto IL_0092;
		}
	}
	{
		// var spawnPos = this.trans.position;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_3 = __this->___trans_6;
		NullCheck(L_3);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_4;
		L_4 = Transform_get_position_m69CD5FA214FDAE7BB701552943674846C220FDE1(L_3, NULL);
		V_0 = L_4;
		// var numToSpawn = Random.Range(1, 3);
		int32_t L_5;
		L_5 = Random_Range_m6763D9767F033357F88B6637F048F4ACA4123B68(1, 3, NULL);
		V_1 = L_5;
		// for (var i = 0; i < numToSpawn; i++)
		V_2 = 0;
		goto IL_0073;
	}

IL_002e:
	{
		// spawnPos.x = Random.Range(spawnPos.x - 6, spawnPos.x + 6);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = V_0;
		float L_7 = L_6.___x_2;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = V_0;
		float L_9 = L_8.___x_2;
		float L_10;
		L_10 = Random_Range_m5236C99A7D8AE6AC9190592DC66016652A2D2494(((float)il2cpp_codegen_subtract(L_7, (6.0f))), ((float)il2cpp_codegen_add(L_9, (6.0f))), NULL);
		(&V_0)->___x_2 = L_10;
		// Instantiate(Enemy, spawnPos, Enemy.transform.rotation);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_11 = __this->___Enemy_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_12 = V_0;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_13 = __this->___Enemy_4;
		NullCheck(L_13);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_14;
		L_14 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_13, NULL);
		NullCheck(L_14);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_15;
		L_15 = Transform_get_rotation_m32AF40CA0D50C797DA639A696F8EAEC7524C179C(L_14, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_16;
		L_16 = Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4(L_11, L_12, L_15, Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4_RuntimeMethod_var);
		// for (var i = 0; i < numToSpawn; i++)
		int32_t L_17 = V_2;
		V_2 = ((int32_t)il2cpp_codegen_add(L_17, 1));
	}

IL_0073:
	{
		// for (var i = 0; i < numToSpawn; i++)
		int32_t L_18 = V_2;
		int32_t L_19 = V_1;
		if ((((int32_t)L_18) < ((int32_t)L_19)))
		{
			goto IL_002e;
		}
	}
	{
		// this.nextSpawnTime = AudioUtil.Time + Random.Range(.3f, .7f);
		float L_20;
		L_20 = AudioUtil_get_Time_mEA625F0CBC286EC5E4C34679D77B8E17DC82839E(NULL);
		float L_21;
		L_21 = Random_Range_m5236C99A7D8AE6AC9190592DC66016652A2D2494((0.300000012f), (0.699999988f), NULL);
		__this->___nextSpawnTime_7 = ((float)il2cpp_codegen_add(L_20, L_21));
	}

IL_0092:
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_EnemySpawner::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_EnemySpawner__ctor_mEC29ECBC8659A987E7344B19E0FFA36BD8AA2445 (MA_EnemySpawner_t21E3F60FD5616FE485106C6880615D53C44AC9A1* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Examples.MA_GameScene::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_GameScene_OnGUI_mF40A67CF68853BF81F9DA71DB88A38769F93571C (MA_GameScene_tFA5987AFF419EF0C0BBDBB2611D19045C146B97C* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tA9CDB3D69DB13D51AD83ABDB587EF95947EC2D2A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral91321AEBDB5ADCB1C9C9DC650B29278499540212);
		s_Il2CppMethodInitialized = true;
	}
	{
		// GUI.Label(new Rect(20, 40, 640, 190), "This is the Game Scene. We have used a Dynamic Sound Group Creator prefab to populate temporary Sound Groups into Master Audio as soon as that prefab becomes enabled (on Scene change for us). If we were to load a different Scene now, those sounds would vanish from the mixer.");
		Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D L_0;
		memset((&L_0), 0, sizeof(L_0));
		Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23((&L_0), (20.0f), (40.0f), (640.0f), (190.0f), /*hidden argument*/NULL);
		il2cpp_codegen_runtime_class_init_inline(GUI_tA9CDB3D69DB13D51AD83ABDB587EF95947EC2D2A_il2cpp_TypeInfo_var);
		GUI_Label_m4A951E57C7DCCF95A0306240144CA2713F546526(L_0, _stringLiteral91321AEBDB5ADCB1C9C9DC650B29278499540212, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_GameScene::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_GameScene__ctor_m1B855568A937F253CF6791AE52A55B54D3480CB6 (MA_GameScene_tFA5987AFF419EF0C0BBDBB2611D19045C146B97C* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Examples.MA_Laser::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_Laser_Awake_mD5EFE4A6A4B0A0DDAA8EAAB1AD4AE671BB68EDCD (MA_Laser_t8DE63150FD4B0E65D8772D9F6812D78B392544FC* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7D1D873639CF2E3E067098025366EC97849B26D0);
		s_Il2CppMethodInitialized = true;
	}
	{
		// useGUILayout = false;
		MonoBehaviour_set_useGUILayout_m56F0C62F4B6889D7472074ECCB56EBA462285134(__this, (bool)0, NULL);
		// _trans = transform;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_0;
		L_0 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(__this, NULL);
		__this->____trans_4 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____trans_4), (void*)L_0);
		// Debug.LogError("MA_Laser and this example Scene will not work properly without Physics3D package installed. Please enable it in the Master Audio Welcome Window if it's already installed.");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(_stringLiteral7D1D873639CF2E3E067098025366EC97849B26D0, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_Laser::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_Laser_Update_m1332FECCC093FC3E4EB448ABC401A98355CB97A1 (MA_Laser_t8DE63150FD4B0E65D8772D9F6812D78B392544FC* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	{
		// var moveAmt = 10f * AudioUtil.FrameTime;
		float L_0;
		L_0 = AudioUtil_get_FrameTime_m51FB868DF9ACC0EA6F681F00863762E399FD6109(NULL);
		V_0 = ((float)il2cpp_codegen_multiply((10.0f), L_0));
		// var pos = _trans.position;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_1 = __this->____trans_4;
		NullCheck(L_1);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_2;
		L_2 = Transform_get_position_m69CD5FA214FDAE7BB701552943674846C220FDE1(L_1, NULL);
		V_1 = L_2;
		// pos.y += moveAmt;
		float* L_3 = (&(&V_1)->___y_3);
		float* L_4 = L_3;
		float L_5 = *((float*)L_4);
		float L_6 = V_0;
		*((float*)L_4) = (float)((float)il2cpp_codegen_add(L_5, L_6));
		// _trans.position = pos;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_7 = __this->____trans_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_8 = V_1;
		NullCheck(L_7);
		Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156(L_7, L_8, NULL);
		// if (_trans.position.y > 7)
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_9 = __this->____trans_4;
		NullCheck(L_9);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10;
		L_10 = Transform_get_position_m69CD5FA214FDAE7BB701552943674846C220FDE1(L_9, NULL);
		float L_11 = L_10.___y_3;
		if ((!(((float)L_11) > ((float)(7.0f)))))
		{
			goto IL_0052;
		}
	}
	{
		// Destroy(gameObject);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_12;
		L_12 = Component_get_gameObject_m57AEFBB14DB39EC476F740BA000E170355DE691B(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		Object_Destroy_mE97D0A766419A81296E8D4E5C23D01D3FE91ACBB(L_12, NULL);
	}

IL_0052:
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_Laser::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_Laser__ctor_m86DA95CA4CFAB97B0A5EA2BF064039E3EE512CDB (MA_Laser_t8DE63150FD4B0E65D8772D9F6812D78B392544FC* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Examples.MA_LocalizationUI::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_LocalizationUI_OnGUI_m9211D61FFF02CF34426616EFCEF8401A27F4B35E (MA_LocalizationUI_t99D3717E29D5024181A096A0A13590D653FDA07E* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tA9CDB3D69DB13D51AD83ABDB587EF95947EC2D2A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral041EF461B1D24087E20E486F69C26300E6C9CF42);
		s_Il2CppMethodInitialized = true;
	}
	{
		// GUI.Label(new Rect(20, 40, 640, 200), "This scene shows the automatic Localization of Resource files. Preview the 'hello' sound from the mixer, which will be in Spanish first. Then press stop, and change the 'Use Specific Language' language to another language up in the top section of the Master Audio prefab's Inspector, hit play and hear the difference! The correct folder's audio file will be loaded automatically according to your language settings.");
		Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D L_0;
		memset((&L_0), 0, sizeof(L_0));
		Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23((&L_0), (20.0f), (40.0f), (640.0f), (200.0f), /*hidden argument*/NULL);
		il2cpp_codegen_runtime_class_init_inline(GUI_tA9CDB3D69DB13D51AD83ABDB587EF95947EC2D2A_il2cpp_TypeInfo_var);
		GUI_Label_m4A951E57C7DCCF95A0306240144CA2713F546526(L_0, _stringLiteral041EF461B1D24087E20E486F69C26300E6C9CF42, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_LocalizationUI::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_LocalizationUI__ctor_m7ED07F344B7C181126D89BA2C73924111170CF19 (MA_LocalizationUI_t99D3717E29D5024181A096A0A13590D653FDA07E* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Examples.MA_PlayerControl::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_PlayerControl_Awake_m6FA33E571AB4BE6095BDEF87374B323BB011B374 (MA_PlayerControl_tFA26225B0C306D27C50F028D7542C1300CF00BA2* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralE16EA2DE18E0BDCE9015254D0CDB37021DCB24BB);
		s_Il2CppMethodInitialized = true;
	}
	{
		// useGUILayout = false;
		MonoBehaviour_set_useGUILayout_m56F0C62F4B6889D7472074ECCB56EBA462285134(__this, (bool)0, NULL);
		// _trans = transform;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_0;
		L_0 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(__this, NULL);
		__this->____trans_7 = L_0;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____trans_7), (void*)L_0);
		// Debug.LogError("MA_PlayerControl and this example Scene will not work properly without Physics3D package installed. Please enable it in the Master Audio Welcome Window if it's already installed.");
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(_stringLiteralE16EA2DE18E0BDCE9015254D0CDB37021DCB24BB, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_PlayerControl::OnDisable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_PlayerControl_OnDisable_mBD13B398D87D31D2B02CF3988B3E656DC1D8F91E (MA_PlayerControl_tFA26225B0C306D27C50F028D7542C1300CF00BA2* __this, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_PlayerControl::OnBecameInvisible()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_PlayerControl_OnBecameInvisible_m64E6C48E0E32942ED55E51769041E7EFEABF3F45 (MA_PlayerControl_tFA26225B0C306D27C50F028D7542C1300CF00BA2* __this, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_PlayerControl::OnBecameVisible()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_PlayerControl_OnBecameVisible_m907F1A3F4CB439CAE7E15A58D0D63301033DAA4D (MA_PlayerControl_tFA26225B0C306D27C50F028D7542C1300CF00BA2* __this, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_PlayerControl::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_PlayerControl_Update_m63A5A97032EF2D709A0319C93CD3C325454C9D60 (MA_PlayerControl_tFA26225B0C306D27C50F028D7542C1300CF00BA2* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral686B7818A6E2392E96BCAA71A7E192E00BB7A28E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral757810A415ACB10E11E552227E9550C547BD2F30);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral7F8C014BD4810CC276D0F9F81A1E759C7B098B1E);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_1;
	memset((&V_1), 0, sizeof(V_1));
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_2;
	memset((&V_2), 0, sizeof(V_2));
	{
		// var moveAmt = Input.GetAxis("Horizontal") * MoveSpeed * AudioUtil.FrameTime;
		float L_0;
		L_0 = Input_GetAxis_m10372E6C5FF591668D2DC5F58C58D213CC598A62(_stringLiteral7F8C014BD4810CC276D0F9F81A1E759C7B098B1E, NULL);
		float L_1;
		L_1 = AudioUtil_get_FrameTime_m51FB868DF9ACC0EA6F681F00863762E399FD6109(NULL);
		V_0 = ((float)il2cpp_codegen_multiply(((float)il2cpp_codegen_multiply(L_0, (10.0f))), L_1));
		// if (moveAmt != 0f)
		float L_2 = V_0;
		if ((((float)L_2) == ((float)(0.0f))))
		{
			goto IL_003f;
		}
	}
	{
		// if (_lastMoveAmt == 0f)
		float L_3 = __this->____lastMoveAmt_8;
		if ((!(((float)L_3) == ((float)(0.0f)))))
		{
			goto IL_005d;
		}
	}
	{
		// MasterAudio.FireCustomEvent("PlayerMoved", _trans);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_4 = __this->____trans_7;
		il2cpp_codegen_runtime_class_init_inline(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		MasterAudio_FireCustomEvent_m3D277358BC73AC8D3DBB9A9594719A87119F6B5F(_stringLiteral757810A415ACB10E11E552227E9550C547BD2F30, L_4, (bool)1, NULL);
		goto IL_005d;
	}

IL_003f:
	{
		// if (_lastMoveAmt != 0f)
		float L_5 = __this->____lastMoveAmt_8;
		if ((((float)L_5) == ((float)(0.0f))))
		{
			goto IL_005d;
		}
	}
	{
		// MasterAudio.FireCustomEvent("PlayerStoppedMoving", _trans);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_6 = __this->____trans_7;
		il2cpp_codegen_runtime_class_init_inline(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		MasterAudio_FireCustomEvent_m3D277358BC73AC8D3DBB9A9594719A87119F6B5F(_stringLiteral686B7818A6E2392E96BCAA71A7E192E00BB7A28E, L_6, (bool)1, NULL);
	}

IL_005d:
	{
		// _lastMoveAmt = moveAmt;
		float L_7 = V_0;
		__this->____lastMoveAmt_8 = L_7;
		// var pos = _trans.position;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_8 = __this->____trans_7;
		NullCheck(L_8);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		L_9 = Transform_get_position_m69CD5FA214FDAE7BB701552943674846C220FDE1(L_8, NULL);
		V_1 = L_9;
		// pos.x += moveAmt;
		float* L_10 = (&(&V_1)->___x_2);
		float* L_11 = L_10;
		float L_12 = *((float*)L_11);
		float L_13 = V_0;
		*((float*)L_11) = (float)((float)il2cpp_codegen_add(L_12, L_13));
		// _trans.position = pos;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_14 = __this->____trans_7;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_15 = V_1;
		NullCheck(L_14);
		Transform_set_position_mA1A817124BB41B685043DED2A9BA48CDF37C4156(L_14, L_15, NULL);
		// if (!canShoot || !Input.GetMouseButtonDown(0))
		bool L_16 = __this->___canShoot_5;
		if (!L_16)
		{
			goto IL_0098;
		}
	}
	{
		bool L_17;
		L_17 = Input_GetMouseButtonDown_m8DFC792D15FFF15D311614D5CC6C5D055E5A1DE3(0, NULL);
		if (L_17)
		{
			goto IL_0099;
		}
	}

IL_0098:
	{
		// return;
		return;
	}

IL_0099:
	{
		// var spawnPos = _trans.position;
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_18 = __this->____trans_7;
		NullCheck(L_18);
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_19;
		L_19 = Transform_get_position_m69CD5FA214FDAE7BB701552943674846C220FDE1(L_18, NULL);
		V_2 = L_19;
		// spawnPos.y += 1;
		float* L_20 = (&(&V_2)->___y_3);
		float* L_21 = L_20;
		float L_22 = *((float*)L_21);
		*((float*)L_21) = (float)((float)il2cpp_codegen_add(L_22, (1.0f)));
		// Instantiate(ProjectilePrefab, spawnPos, ProjectilePrefab.transform.rotation);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_23 = __this->___ProjectilePrefab_4;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_24 = V_2;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_25 = __this->___ProjectilePrefab_4;
		NullCheck(L_25);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_26;
		L_26 = GameObject_get_transform_m0BC10ADFA1632166AE5544BDF9038A2650C2AE56(L_25, NULL);
		NullCheck(L_26);
		Quaternion_tDA59F214EF07D7700B26E40E562F267AF7306974 L_27;
		L_27 = Transform_get_rotation_m32AF40CA0D50C797DA639A696F8EAEC7524C179C(L_26, NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_28;
		L_28 = Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4(L_23, L_24, L_27, Object_Instantiate_TisGameObject_t76FEDD663AB33C991A9C9A23129337651094216F_m831D2F71DF2AA6C93AFDFEFA04CF2CFC5FBBCDB4_RuntimeMethod_var);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_PlayerControl::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_PlayerControl__ctor_mF5DFC8FAF9FA0F82E44629CD9C8523309AE9126A (MA_PlayerControl_tFA26225B0C306D27C50F028D7542C1300CF00BA2* __this, const RuntimeMethod* method) 
{
	{
		// public bool canShoot = true;
		__this->___canShoot_5 = (bool)1;
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Examples.MA_PlayerSpawnerControl::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_PlayerSpawnerControl_Awake_m5BC46FDA8D3455B1EC13CED1BC38C50F4688A5D9 (MA_PlayerSpawnerControl_t87E7E9177332BA2683259C0211587134DE637203* __this, const RuntimeMethod* method) 
{
	{
		// this.useGUILayout = false;
		MonoBehaviour_set_useGUILayout_m56F0C62F4B6889D7472074ECCB56EBA462285134(__this, (bool)0, NULL);
		// this.nextSpawnTime = -1f;
		__this->___nextSpawnTime_5 = (-1.0f);
		// }
		return;
	}
}
// System.Boolean DarkTonic.MasterAudio.Examples.MA_PlayerSpawnerControl::get_PlayerActive()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MA_PlayerSpawnerControl_get_PlayerActive_m239B8337058895E2D014A39265B2646DC3B7C233 (MA_PlayerSpawnerControl_t87E7E9177332BA2683259C0211587134DE637203* __this, const RuntimeMethod* method) 
{
	{
		// return Player.activeInHierarchy;
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_0 = __this->___Player_4;
		NullCheck(L_0);
		bool L_1;
		L_1 = GameObject_get_activeInHierarchy_m49250F4F168DCC5388D5BE4F6A5681386907B109(L_0, NULL);
		return L_1;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_PlayerSpawnerControl::Update()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_PlayerSpawnerControl_Update_m5882BCB0B69060C82D65068929E53CFCD90359F9 (MA_PlayerSpawnerControl_t87E7E9177332BA2683259C0211587134DE637203* __this, const RuntimeMethod* method) 
{
	{
		// if (!PlayerActive)
		bool L_0;
		L_0 = MA_PlayerSpawnerControl_get_PlayerActive_m239B8337058895E2D014A39265B2646DC3B7C233(__this, NULL);
		if (L_0)
		{
			goto IL_004a;
		}
	}
	{
		// if (nextSpawnTime < 0)
		float L_1 = __this->___nextSpawnTime_5;
		if ((!(((float)L_1) < ((float)(0.0f)))))
		{
			goto IL_0026;
		}
	}
	{
		// nextSpawnTime = AudioUtil.Time + 1;
		float L_2;
		L_2 = AudioUtil_get_Time_mEA625F0CBC286EC5E4C34679D77B8E17DC82839E(NULL);
		__this->___nextSpawnTime_5 = ((float)il2cpp_codegen_add(L_2, (1.0f)));
	}

IL_0026:
	{
		// if (Time.time >= this.nextSpawnTime)
		float L_3;
		L_3 = Time_get_time_m3A271BB1B20041144AC5B7863B71AB1F0150374B(NULL);
		float L_4 = __this->___nextSpawnTime_5;
		if ((!(((float)L_3) >= ((float)L_4))))
		{
			goto IL_004a;
		}
	}
	{
		// Player.SetActive(true);
		GameObject_t76FEDD663AB33C991A9C9A23129337651094216F* L_5 = __this->___Player_4;
		NullCheck(L_5);
		GameObject_SetActive_m638E92E1E75E519E5B24CF150B08CA8E0CDFAB92(L_5, (bool)1, NULL);
		// nextSpawnTime = -1;
		__this->___nextSpawnTime_5 = (-1.0f);
	}

IL_004a:
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_PlayerSpawnerControl::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_PlayerSpawnerControl__ctor_m0FFDD8887AE091D7796A61434682A6F6C286F637 (MA_PlayerSpawnerControl_t87E7E9177332BA2683259C0211587134DE637203* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::Awake()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver_Awake_mABF3777C0B6AE466E7F3273EA0F6E9EAE1547FBE (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) 
{
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::Start()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver_Start_m1EC13FC9240E3F1DE6C0FE75FC1A950DC5BEC2B5 (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) 
{
	{
		// CheckForIllegalCustomEvents();
		MA_SampleICustomEventReceiver_CheckForIllegalCustomEvents_m6E97F9677A4657A53E47360DA7A41AD235EC06C0(__this, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::OnEnable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver_OnEnable_m3BCEC490D09B5D90D7644DC4FEAEA74F65EC7A1B (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) 
{
	{
		// RegisterReceiver();
		MA_SampleICustomEventReceiver_RegisterReceiver_m94BA1A4835992D0BEFC9E50BE6487B183154AD1F(__this, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::OnDisable()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver_OnDisable_m89C179BB1E18CBAA0CAC68212867AEA71B80E98D (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (MasterAudio.SafeInstance == null || MasterAudio.AppIsShuttingDown)
		il2cpp_codegen_runtime_class_init_inline(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558* L_0;
		L_0 = MasterAudio_get_SafeInstance_m032232A242182E424132E6CB8C80BA00D9CC091A(NULL);
		il2cpp_codegen_runtime_class_init_inline(Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C_il2cpp_TypeInfo_var);
		bool L_1;
		L_1 = Object_op_Equality_mB6120F782D83091EF56A198FCEBCF066DB4A9605(L_0, (Object_tC12DECB6760A7F2CBF65D9DCF18D044C2D97152C*)NULL, NULL);
		if (L_1)
		{
			goto IL_0014;
		}
	}
	{
		il2cpp_codegen_runtime_class_init_inline(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		bool L_2;
		L_2 = MasterAudio_get_AppIsShuttingDown_mEBDB3FB0D99F5F9D975987AEC59296E89CC895BA_inline(NULL);
		if (!L_2)
		{
			goto IL_0015;
		}
	}

IL_0014:
	{
		// return;
		return;
	}

IL_0015:
	{
		// UnregisterReceiver();
		MA_SampleICustomEventReceiver_UnregisterReceiver_m2E63F344FCB2A51A2AB252CEED577996D1CF135A(__this, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::CheckForIllegalCustomEvents()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver_CheckForIllegalCustomEvents_m6E97F9677A4657A53E47360DA7A41AD235EC06C0 (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral851FE7EC40426AD18D17EBACAF13563372EF070E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralBD9B2524802405F9A25B14B9B72939E1D989D0E7);
		s_Il2CppMethodInitialized = true;
	}
	int32_t V_0 = 0;
	{
		// for (var i = 0; i < _eventsSubscribedTo.Count; i++)
		V_0 = 0;
		goto IL_0035;
	}

IL_0004:
	{
		// var eventName = _eventsSubscribedTo[i];
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_0 = __this->____eventsSubscribedTo_4;
		int32_t L_1 = V_0;
		NullCheck(L_0);
		String_t* L_2;
		L_2 = List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8(L_0, L_1, List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var);
		// if (!MasterAudio.CustomEventExists(eventName))
		il2cpp_codegen_runtime_class_init_inline(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		bool L_3;
		L_3 = MasterAudio_CustomEventExists_m74F6AC571151BF71BA0B3DEECE67838AA6FF6AB6(L_2, NULL);
		if (L_3)
		{
			goto IL_0031;
		}
	}
	{
		// Debug.LogError("Custom Event, listened to by '" + name + "', could not be found in MasterAudio.");
		String_t* L_4;
		L_4 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(__this, NULL);
		String_t* L_5;
		L_5 = String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B(_stringLiteralBD9B2524802405F9A25B14B9B72939E1D989D0E7, L_4, _stringLiteral851FE7EC40426AD18D17EBACAF13563372EF070E, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_LogError_mB00B2B4468EF3CAF041B038D840820FB84C924B2(L_5, NULL);
	}

IL_0031:
	{
		// for (var i = 0; i < _eventsSubscribedTo.Count; i++)
		int32_t L_6 = V_0;
		V_0 = ((int32_t)il2cpp_codegen_add(L_6, 1));
	}

IL_0035:
	{
		// for (var i = 0; i < _eventsSubscribedTo.Count; i++)
		int32_t L_7 = V_0;
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_8 = __this->____eventsSubscribedTo_4;
		NullCheck(L_8);
		int32_t L_9;
		L_9 = List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_inline(L_8, List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var);
		if ((((int32_t)L_7) < ((int32_t)L_9)))
		{
			goto IL_0004;
		}
	}
	{
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::ReceiveEvent(System.String,UnityEngine.Vector3)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver_ReceiveEvent_mB63A7031BC053A59C7D81602BDFD03E741EF369E (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, String_t* ___customEventName0, Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___originPoint1, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral28BBF187EFC0EB9AC3DE8C16254DF67E7E5F2900);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral59277FD87F18D3F23F7A5D0613FDC39A2408C52A);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral686B7818A6E2392E96BCAA71A7E192E00BB7A28E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral757810A415ACB10E11E552227E9550C547BD2F30);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteralC7A7939E82BEFEF8DDB755713442AA62963F09F8);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___customEventName0;
		bool L_1;
		L_1 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_0, _stringLiteral757810A415ACB10E11E552227E9550C547BD2F30, NULL);
		if (L_1)
		{
			goto IL_001b;
		}
	}
	{
		String_t* L_2 = ___customEventName0;
		bool L_3;
		L_3 = String_op_Equality_m030E1B219352228970A076136E455C4E568C02C1(L_2, _stringLiteral686B7818A6E2392E96BCAA71A7E192E00BB7A28E, NULL);
		if (L_3)
		{
			goto IL_0036;
		}
	}
	{
		return;
	}

IL_001b:
	{
		// Debug.Log("PlayerMoved event recieved by '" + name + "'.");
		String_t* L_4;
		L_4 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(__this, NULL);
		String_t* L_5;
		L_5 = String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B(_stringLiteral28BBF187EFC0EB9AC3DE8C16254DF67E7E5F2900, L_4, _stringLiteralC7A7939E82BEFEF8DDB755713442AA62963F09F8, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(L_5, NULL);
		// break;
		return;
	}

IL_0036:
	{
		// Debug.Log("PlayerStoppedMoving event recieved by '" + name + "'.");
		String_t* L_6;
		L_6 = Object_get_name_mAC2F6B897CF1303BA4249B4CB55271AFACBB6392(__this, NULL);
		String_t* L_7;
		L_7 = String_Concat_m8855A6DE10F84DA7F4EC113CADDB59873A25573B(_stringLiteral59277FD87F18D3F23F7A5D0613FDC39A2408C52A, L_6, _stringLiteralC7A7939E82BEFEF8DDB755713442AA62963F09F8, NULL);
		il2cpp_codegen_runtime_class_init_inline(Debug_t8394C7EEAECA3689C2C9B9DE9C7166D73596276F_il2cpp_TypeInfo_var);
		Debug_Log_m87A9A3C761FF5C43ED8A53B16190A53D08F818BB(L_7, NULL);
		// }
		return;
	}
}
// System.Boolean DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::SubscribesToEvent(System.String)
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR bool MA_SampleICustomEventReceiver_SubscribesToEvent_m032DB53BE57BA2616474418672F3AF5A0929FDEF (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, String_t* ___customEventName0, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Contains_m359254483BE42CAD4DCA8FBAFB87473FB4CF00E1_RuntimeMethod_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// if (string.IsNullOrEmpty(customEventName))
		String_t* L_0 = ___customEventName0;
		bool L_1;
		L_1 = String_IsNullOrEmpty_mEA9E3FB005AC28FE02E69FCF95A7B8456192B478(L_0, NULL);
		if (!L_1)
		{
			goto IL_000a;
		}
	}
	{
		// return false;
		return (bool)0;
	}

IL_000a:
	{
		// return _eventsSubscribedTo.Contains(customEventName);
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_2 = __this->____eventsSubscribedTo_4;
		String_t* L_3 = ___customEventName0;
		NullCheck(L_2);
		bool L_4;
		L_4 = List_1_Contains_m359254483BE42CAD4DCA8FBAFB87473FB4CF00E1(L_2, L_3, List_1_Contains_m359254483BE42CAD4DCA8FBAFB87473FB4CF00E1_RuntimeMethod_var);
		return L_4;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::RegisterReceiver()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver_RegisterReceiver_m94BA1A4835992D0BEFC9E50BE6487B183154AD1F (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// MasterAudio.AddCustomEventReceiver(this, transform);
		Transform_tB27202C6F4E36D225EE28A13E4D662BF99785DB1* L_0;
		L_0 = Component_get_transform_m2919A1D81931E6932C7F06D4C2F0AB8DDA9A5371(__this, NULL);
		il2cpp_codegen_runtime_class_init_inline(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		MasterAudio_AddCustomEventReceiver_m07576CE44E027C26E39C7AAB1FCB61488D3CC97F(__this, L_0, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::UnregisterReceiver()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver_UnregisterReceiver_m2E63F344FCB2A51A2AB252CEED577996D1CF135A (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// MasterAudio.RemoveCustomEventReceiver(this);
		il2cpp_codegen_runtime_class_init_inline(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		MasterAudio_RemoveCustomEventReceiver_m4606FA61C2967F6F292758A97D5B03AA86583561(__this, NULL);
		// }
		return;
	}
}
// System.Collections.Generic.IList`1<DarkTonic.MasterAudio.AudioEventGroup> DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::GetAllEvents()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR RuntimeObject* MA_SampleICustomEventReceiver_GetAllEvents_m04FB03AE37D85341B2A5DB5D519E33D422072019 (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&AudioEventGroup_t953D8966F454589B710B23F387F5D1B5E9B73E2A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_m4315CBA28DB215575A4D8CDE10EA0E53B33A6667_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_m155CDF1F26D1E859CC8AC03003C6BEA2EBF017F6_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_t34522BBE1CA284958723F996311B012983B30D2B_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	List_1_t34522BBE1CA284958723F996311B012983B30D2B* V_0 = NULL;
	int32_t V_1 = 0;
	{
		// var events = new List<AudioEventGroup>();
		List_1_t34522BBE1CA284958723F996311B012983B30D2B* L_0 = (List_1_t34522BBE1CA284958723F996311B012983B30D2B*)il2cpp_codegen_object_new(List_1_t34522BBE1CA284958723F996311B012983B30D2B_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		List_1__ctor_m155CDF1F26D1E859CC8AC03003C6BEA2EBF017F6(L_0, List_1__ctor_m155CDF1F26D1E859CC8AC03003C6BEA2EBF017F6_RuntimeMethod_var);
		V_0 = L_0;
		// for (var i = 0; i < _eventsSubscribedTo.Count; i++)
		V_1 = 0;
		goto IL_002b;
	}

IL_000a:
	{
		// events.Add(new AudioEventGroup
		// {
		//     customEventName = _eventsSubscribedTo[i]
		// });
		List_1_t34522BBE1CA284958723F996311B012983B30D2B* L_1 = V_0;
		AudioEventGroup_t953D8966F454589B710B23F387F5D1B5E9B73E2A* L_2 = (AudioEventGroup_t953D8966F454589B710B23F387F5D1B5E9B73E2A*)il2cpp_codegen_object_new(AudioEventGroup_t953D8966F454589B710B23F387F5D1B5E9B73E2A_il2cpp_TypeInfo_var);
		NullCheck(L_2);
		AudioEventGroup__ctor_mD407DF047241D4169A05E375709006910595AD52(L_2, NULL);
		AudioEventGroup_t953D8966F454589B710B23F387F5D1B5E9B73E2A* L_3 = L_2;
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_4 = __this->____eventsSubscribedTo_4;
		int32_t L_5 = V_1;
		NullCheck(L_4);
		String_t* L_6;
		L_6 = List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8(L_4, L_5, List_1_get_Item_m21AEC50E791371101DC22ABCF96A2E46800811F8_RuntimeMethod_var);
		NullCheck(L_3);
		L_3->___customEventName_8 = L_6;
		Il2CppCodeGenWriteBarrier((void**)(&L_3->___customEventName_8), (void*)L_6);
		NullCheck(L_1);
		List_1_Add_m4315CBA28DB215575A4D8CDE10EA0E53B33A6667_inline(L_1, L_3, List_1_Add_m4315CBA28DB215575A4D8CDE10EA0E53B33A6667_RuntimeMethod_var);
		// for (var i = 0; i < _eventsSubscribedTo.Count; i++)
		int32_t L_7 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add(L_7, 1));
	}

IL_002b:
	{
		// for (var i = 0; i < _eventsSubscribedTo.Count; i++)
		int32_t L_8 = V_1;
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_9 = __this->____eventsSubscribedTo_4;
		NullCheck(L_9);
		int32_t L_10;
		L_10 = List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_inline(L_9, List_1_get_Count_mB63183A9151F4345A9DD444A7CBE0D6E03F77C7C_RuntimeMethod_var);
		if ((((int32_t)L_8) < ((int32_t)L_10)))
		{
			goto IL_000a;
		}
	}
	{
		// return events;
		List_1_t34522BBE1CA284958723F996311B012983B30D2B* L_11 = V_0;
		return L_11;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_SampleICustomEventReceiver::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_SampleICustomEventReceiver__ctor_m6F1645478C7F7E8A0EAB1E8C30015986B4BDB7D3 (MA_SampleICustomEventReceiver_t75159B34437565EBA8ADF399CF2C77FBA8CAF7E9* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E_RuntimeMethod_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral686B7818A6E2392E96BCAA71A7E192E00BB7A28E);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral757810A415ACB10E11E552227E9550C547BD2F30);
		s_Il2CppMethodInitialized = true;
	}
	{
		//     private readonly List<string> _eventsSubscribedTo = new List<string>() {
		//     "PlayerMoved",
		//     "PlayerStoppedMoving"
		// };
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_0 = (List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD*)il2cpp_codegen_object_new(List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD_il2cpp_TypeInfo_var);
		NullCheck(L_0);
		List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E(L_0, List_1__ctor_mCA8DD57EAC70C2B5923DBB9D5A77CEAC22E7068E_RuntimeMethod_var);
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_1 = L_0;
		NullCheck(L_1);
		List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_inline(L_1, _stringLiteral757810A415ACB10E11E552227E9550C547BD2F30, List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var);
		List_1_tF470A3BE5C1B5B68E1325EF3F109D172E60BD7CD* L_2 = L_1;
		NullCheck(L_2);
		List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_inline(L_2, _stringLiteral686B7818A6E2392E96BCAA71A7E192E00BB7A28E, List_1_Add_mF10DB1D3CBB0B14215F0E4F8AB4934A1955E5351_RuntimeMethod_var);
		__this->____eventsSubscribedTo_4 = L_2;
		Il2CppCodeGenWriteBarrier((void**)(&__this->____eventsSubscribedTo_4), (void*)L_2);
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void DarkTonic.MasterAudio.Examples.MA_TestUI::OnGUI()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_TestUI_OnGUI_m319C7F320BEFD0262FB0ED358AC36CCE4FA0F2D6 (MA_TestUI_t938B2C6124B2D23E707E3F661D34922A49CE71E0* __this, const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&GUI_tA9CDB3D69DB13D51AD83ABDB587EF95947EC2D2A_il2cpp_TypeInfo_var);
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&_stringLiteral51C7EFB6A66483A5AA139697DB8CB829FB7812CB);
		s_Il2CppMethodInitialized = true;
	}
	{
		// GUI.Label(new Rect(20, 40, 640, 260), "Use left/right arrow keys and left mouse button to play. " +
		//     "Music ducks (gets quieter) for Screams, then ramps back up soon after. Sound FX have " +
		//     "variations. No code needed to be written for any of the sound triggering or ducking. See ReadMe.pdf for more information on how to set things up. " +
		//     "Note the Jukebox control that handles the Playlist Controller in the scene! " +
		//     "It's in the Master Audio prefab's Inspector. Also, take note of the DynamicSoundGroupCreator prefab, which adds a new temporary Sound Group during the current Scene only! " +
		//     "Go ahead and click on the 'Enemy Spawner' script and turn on the checkbox for 'Spawner Enabled' for enemies! There's one Custom Event 'PlayerOffscreen' that gets triggered from EventSounds on the Player " +
		//     "when you move offscreen. The EventSounds script on PlayerSpawner receives that event and plays an arrow sound when it happens. " +
		//     "We've also implemented a sample class 'MA_SampleICustomEventReceiver' that implements the ICustomEventReciever class if you wish to see how to do that. It's attached to the main camera prefab. " +
		//     "A linked group of Blast is set up in the Scream Group, take a look! Sample music provided by Alchemy Studios. " +
		//     "\n\nHappy gaming - DarkTonic, Inc.");
		Rect_tA04E0F8A1830E767F40FB27ECD8D309303571F0D L_0;
		memset((&L_0), 0, sizeof(L_0));
		Rect__ctor_m18C3033D135097BEE424AAA68D91C706D2647F23((&L_0), (20.0f), (40.0f), (640.0f), (260.0f), /*hidden argument*/NULL);
		il2cpp_codegen_runtime_class_init_inline(GUI_tA9CDB3D69DB13D51AD83ABDB587EF95947EC2D2A_il2cpp_TypeInfo_var);
		GUI_Label_m4A951E57C7DCCF95A0306240144CA2713F546526(L_0, _stringLiteral51C7EFB6A66483A5AA139697DB8CB829FB7812CB, NULL);
		// }
		return;
	}
}
// System.Void DarkTonic.MasterAudio.Examples.MA_TestUI::.ctor()
IL2CPP_EXTERN_C IL2CPP_METHOD_ATTR void MA_TestUI__ctor_m8D8D7BF1A8ED39F2AF1EE23D04821B8777644AC9 (MA_TestUI_t938B2C6124B2D23E707E3F661D34922A49CE71E0* __this, const RuntimeMethod* method) 
{
	{
		MonoBehaviour__ctor_m592DB0105CA0BC97AA1C5F4AD27B12D68A3B7C1E(__this, NULL);
		return;
	}
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_get_down_mF62B2AE7C5AC31EAC9CB62797C7190C90A7A8599_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ((Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2_il2cpp_TypeInfo_var))->___downVector_8;
		V_0 = L_0;
		goto IL_0009;
	}

IL_0009:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_1 = V_0;
		return L_1;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 Vector3_op_Multiply_m87BA7C578F96C8E49BB07088DAAC4649F83B0353_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 ___a0, float ___d1, const RuntimeMethod* method) 
{
	Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 V_0;
	memset((&V_0), 0, sizeof(V_0));
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_0 = ___a0;
		float L_1 = L_0.___x_2;
		float L_2 = ___d1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_3 = ___a0;
		float L_4 = L_3.___y_3;
		float L_5 = ___d1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_6 = ___a0;
		float L_7 = L_6.___z_4;
		float L_8 = ___d1;
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_9;
		memset((&L_9), 0, sizeof(L_9));
		Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline((&L_9), ((float)il2cpp_codegen_multiply(L_1, L_2)), ((float)il2cpp_codegen_multiply(L_4, L_5)), ((float)il2cpp_codegen_multiply(L_7, L_8)), /*hidden argument*/NULL);
		V_0 = L_9;
		goto IL_0021;
	}

IL_0021:
	{
		Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2 L_10 = V_0;
		return L_10;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR bool MasterAudio_get_AppIsShuttingDown_mEBDB3FB0D99F5F9D975987AEC59296E89CC895BA_inline (const RuntimeMethod* method) 
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_runtime_metadata((uintptr_t*)&MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		s_Il2CppMethodInitialized = true;
	}
	{
		// public static bool AppIsShuttingDown { get; set; }
		il2cpp_codegen_runtime_class_init_inline(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var);
		bool L_0 = ((MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_StaticFields*)il2cpp_codegen_static_fields_for(MasterAudio_t386A3B5779ECA59929AA170F6649E76FBB0EE558_il2cpp_TypeInfo_var))->___U3CAppIsShuttingDownU3Ek__BackingField_211;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR int32_t List_1_get_Count_m4407E4C389F22B8CEC282C15D56516658746C383_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, const RuntimeMethod* method) 
{
	{
		int32_t L_0 = (int32_t)__this->____size_2;
		return L_0;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void List_1_Add_mEBCF994CC3814631017F46A387B1A192ED6C85C7_gshared_inline (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D* __this, RuntimeObject* ___item0, const RuntimeMethod* method) 
{
	ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* V_0 = NULL;
	int32_t V_1 = 0;
	{
		int32_t L_0 = (int32_t)__this->____version_3;
		__this->____version_3 = ((int32_t)il2cpp_codegen_add(L_0, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_1 = (ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918*)__this->____items_1;
		V_0 = L_1;
		int32_t L_2 = (int32_t)__this->____size_2;
		V_1 = L_2;
		int32_t L_3 = V_1;
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_4 = V_0;
		NullCheck(L_4);
		if ((!(((uint32_t)L_3) < ((uint32_t)((int32_t)(((RuntimeArray*)L_4)->max_length))))))
		{
			goto IL_0034;
		}
	}
	{
		int32_t L_5 = V_1;
		__this->____size_2 = ((int32_t)il2cpp_codegen_add(L_5, 1));
		ObjectU5BU5D_t8061030B0A12A55D5AD8652A20C922FE99450918* L_6 = V_0;
		int32_t L_7 = V_1;
		RuntimeObject* L_8 = ___item0;
		NullCheck(L_6);
		(L_6)->SetAt(static_cast<il2cpp_array_size_t>(L_7), (RuntimeObject*)L_8);
		return;
	}

IL_0034:
	{
		RuntimeObject* L_9 = ___item0;
		((  void (*) (List_1_tA239CB83DE5615F348BB0507E45F490F4F7C9A8D*, RuntimeObject*, const RuntimeMethod*))il2cpp_codegen_get_method_pointer(il2cpp_rgctx_method(method->klass->rgctx_data, 11)))(__this, L_9, il2cpp_rgctx_method(method->klass->rgctx_data, 11));
		return;
	}
}
IL2CPP_MANAGED_FORCE_INLINE IL2CPP_METHOD_ATTR void Vector3__ctor_m376936E6B999EF1ECBE57D990A386303E2283DE0_inline (Vector3_t24C512C7B96BBABAD472002D0BA2BDA40A5A80B2* __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method) 
{
	{
		float L_0 = ___x0;
		__this->___x_2 = L_0;
		float L_1 = ___y1;
		__this->___y_3 = L_1;
		float L_2 = ___z2;
		__this->___z_4 = L_2;
		return;
	}
}
