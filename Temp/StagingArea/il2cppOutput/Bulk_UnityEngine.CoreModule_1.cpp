﻿#include "il2cpp-config.h"

#ifndef _MSC_VER
# include <alloca.h>
#else
# include <malloc.h>
#endif

#include <cstring>
#include <string.h>
#include <stdio.h>
#include <cmath>
#include <limits>
#include <assert.h>
#include <stdint.h>

#include "il2cpp-class-internals.h"
#include "codegen/il2cpp-codegen.h"
#include "il2cpp-object-internals.h"

template <typename R, typename T1, typename T2, typename T3, typename T4, typename T5, typename T6, typename T7, typename T8>
struct VirtFuncInvoker8
{
	typedef R (*Func)(void*, T1, T2, T3, T4, T5, T6, T7, T8, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2, T3 p3, T4 p4, T5 p5, T6 p6, T7 p7, T8 p8)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, p2, p3, p4, p5, p6, p7, p8, invokeData.method);
	}
};
template <typename R>
struct VirtFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename R, typename T1>
struct VirtFuncInvoker1
{
	typedef R (*Func)(void*, T1, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		return ((Func)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct VirtActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1>
struct VirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_virtual_invoke_data(slot, obj);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct GenericVirtActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1>
struct GenericVirtActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_virtual_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename R>
struct InterfaceFuncInvoker0
{
	typedef R (*Func)(void*, const RuntimeMethod*);

	static inline R Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		return ((Func)invokeData.methodPtr)(obj, invokeData.method);
	}
};
template <typename T1, typename T2>
struct InterfaceActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1, T2 p2)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1>
struct InterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (Il2CppMethodSlot slot, RuntimeClass* declaringInterface, RuntimeObject* obj, T1 p1)
	{
		const VirtualInvokeData& invokeData = il2cpp_codegen_get_interface_invoke_data(slot, obj, declaringInterface);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};
template <typename T1, typename T2>
struct GenericInterfaceActionInvoker2
{
	typedef void (*Action)(void*, T1, T2, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1, T2 p2)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, p2, invokeData.method);
	}
};
template <typename T1>
struct GenericInterfaceActionInvoker1
{
	typedef void (*Action)(void*, T1, const RuntimeMethod*);

	static inline void Invoke (const RuntimeMethod* method, RuntimeObject* obj, T1 p1)
	{
		VirtualInvokeData invokeData;
		il2cpp_codegen_get_generic_interface_invoke_data(method, obj, &invokeData);
		((Action)invokeData.methodPtr)(obj, p1, invokeData.method);
	}
};

// System.String
struct String_t;
// UnityEngine.GameObject
struct GameObject_t1113636619;
// UnityEngine.Object
struct Object_t631007953;
// UnityEngine.Serialization.FormerlySerializedAsAttribute
struct FormerlySerializedAsAttribute_t2859083114;
// System.Attribute
struct Attribute_t861562559;
// UnityEngine.SerializeField
struct SerializeField_t3286833614;
// System.Collections.IEnumerator
struct IEnumerator_t1853284238;
// System.ArgumentException
struct ArgumentException_t132251570;
// System.Type
struct Type_t;
// UnityEngine.SpaceAttribute
struct SpaceAttribute_t3956583069;
// UnityEngine.PropertyAttribute
struct PropertyAttribute_t3677895545;
// UnityEngine.Sprite
struct Sprite_t280657092;
// UnityEngine.Texture2D
struct Texture2D_t3840446185;
// UnityEngine.SpriteRenderer
struct SpriteRenderer_t3235626157;
// System.Diagnostics.StackTrace
struct StackTrace_t1598645457;
// System.Text.StringBuilder
struct StringBuilder_t;
// System.Exception
struct Exception_t;
// System.String[]
struct StringU5BU5D_t1281789340;
// System.Char[]
struct CharU5BU5D_t3528271667;
// System.Reflection.ParameterInfo
struct ParameterInfo_t1861056598;
// UnityEngine.TextAreaAttribute
struct TextAreaAttribute_t3326046611;
// UnityEngine.TextAsset
struct TextAsset_t3022178571;
// UnityEngine.Texture
struct Texture_t3661962703;
// UnityEngine.TooltipAttribute
struct TooltipAttribute_t3957072629;
// UnityEngine.TouchScreenKeyboard
struct TouchScreenKeyboard_t731888065;
// UnityEngine.TrackedReference
struct TrackedReference_t1199777556;
// UnityEngine.Transform
struct Transform_t3600365921;
// UnityEngine.Component
struct Component_t1923634451;
// UnityEngine.Transform/Enumerator
struct Enumerator_t3442430665;
// System.Action`1<UnityEngine.U2D.SpriteAtlas>
struct Action_1_t819399007;
// System.Action`1<System.Object>
struct Action_1_t3252573759;
// UnityEngine.U2D.SpriteAtlasManager/RequestAtlasCallback
struct RequestAtlasCallback_t3100554279;
// UnityEngine.U2D.SpriteAtlas
struct SpriteAtlas_t646931412;
// System.IAsyncResult
struct IAsyncResult_t767004451;
// System.AsyncCallback
struct AsyncCallback_t3962456242;
// UnityEngine.UnityException
struct UnityException_t3598173660;
// System.Runtime.Serialization.SerializationInfo
struct SerializationInfo_t950877179;
// UnityEngine.UnityLogWriter
struct UnityLogWriter_t1374348020;
// System.IO.TextWriter
struct TextWriter_t3478189236;
// UnityEngine.UnitySynchronizationContext
struct UnitySynchronizationContext_t1887453786;
// System.Collections.Generic.Queue`1<UnityEngine.UnitySynchronizationContext/WorkRequest>
struct Queue_1_t1200778106;
// System.Threading.Thread
struct Thread_t2300836069;
// System.Threading.SynchronizationContext
struct SynchronizationContext_t2326897723;
// System.Threading.SendOrPostCallback
struct SendOrPostCallback_t2750080073;
// System.Threading.EventWaitHandle
struct EventWaitHandle_t777845177;
// System.IndexOutOfRangeException
struct IndexOutOfRangeException_t1578797820;
// System.Object[]
struct ObjectU5BU5D_t2843939325;
// UnityEngine.WaitForEndOfFrame
struct WaitForEndOfFrame_t1314943911;
// UnityEngine.YieldInstruction
struct YieldInstruction_t403091072;
// UnityEngine.WaitForSecondsRealtime
struct WaitForSecondsRealtime_t189548121;
// UnityEngine.CustomYieldInstruction
struct CustomYieldInstruction_t1895667560;
// UnityEngineInternal.GenericStack
struct GenericStack_t1310059385;
// System.Collections.Stack
struct Stack_t2329662280;
// System.Delegate
struct Delegate_t1188392813;
// System.Reflection.MethodInfo
struct MethodInfo_t;
// UnityEngineInternal.TypeInferenceRuleAttribute
struct TypeInferenceRuleAttribute_t254868554;
// System.Reflection.MethodBase
struct MethodBase_t;
// System.Runtime.Remoting.ServerIdentity
struct ServerIdentity_t2342208608;
// System.IntPtr[]
struct IntPtrU5BU5D_t4013366056;
// System.Collections.IDictionary
struct IDictionary_t1363984059;
// System.Diagnostics.StackFrame[]
struct StackFrameU5BU5D_t1997726418;
// System.Collections.Hashtable
struct Hashtable_t1853889766;
// System.Collections.ArrayList
struct ArrayList_t2718874744;
// System.Runtime.Serialization.IFormatterConverter
struct IFormatterConverter_t2171992254;
// UnityEngine.UnitySynchronizationContext/WorkRequest[]
struct WorkRequestU5BU5D_t3723878365;
// System.Globalization.CultureInfo
struct CultureInfo_t4157843068;
// System.Globalization.NumberFormatInfo
struct NumberFormatInfo_t435877138;
// System.Globalization.DateTimeFormatInfo
struct DateTimeFormatInfo_t2405853701;
// System.Globalization.TextInfo
struct TextInfo_t3810425522;
// System.Globalization.CompareInfo
struct CompareInfo_t1092934962;
// System.Globalization.Calendar[]
struct CalendarU5BU5D_t3985046076;
// System.Globalization.Calendar
struct Calendar_t1661121569;
// System.Byte[]
struct ByteU5BU5D_t4116647657;
// System.Collections.Generic.Dictionary`2<System.String,System.Int32>
struct Dictionary_2_t2736202052;
// System.Int32
struct Int32_t2950945753;
// System.Void
struct Void_t1185182177;
// System.Threading.ManualResetEvent
struct ManualResetEvent_t451242010;
// UnityEngine.Camera
struct Camera_t4157153871;
// System.Byte
struct Byte_t1134296376;
// System.Double
struct Double_t594665363;
// System.UInt16
struct UInt16_t2177724958;
// System.Boolean[]
struct BooleanU5BU5D_t2897418192;
// Microsoft.Win32.SafeHandles.SafeWaitHandle
struct SafeWaitHandle_t1972936122;
// System.DelegateData
struct DelegateData_t1677132599;
// System.Reflection.MemberInfo
struct MemberInfo_t;
// System.Reflection.Emit.UnmanagedMarshal
struct UnmanagedMarshal_t984015687;
// System.Int32[]
struct Int32U5BU5D_t385246372;
// System.Type[]
struct TypeU5BU5D_t3940880105;
// System.Reflection.MemberFilter
struct MemberFilter_t426314064;
// System.Threading.ExecutionContext
struct ExecutionContext_t1748372627;
// System.MulticastDelegate
struct MulticastDelegate_t;
// System.Security.Principal.IPrincipal
struct IPrincipal_t2343618843;
// UnityEngine.Camera/CameraCallback
struct CameraCallback_t190067161;
// UnityEngine.RectTransform/ReapplyDrivenProperties
struct ReapplyDrivenProperties_t1258266594;

extern RuntimeClass* Object_t631007953_il2cpp_TypeInfo_var;
extern const uint32_t HitInfo_op_Implicit_m665224877_MetadataUsageId;
extern const uint32_t HitInfo_Compare_m2336739674_MetadataUsageId;
extern RuntimeClass* IntPtr_t_il2cpp_TypeInfo_var;
extern RuntimeClass* ArgumentException_t132251570_il2cpp_TypeInfo_var;
extern RuntimeClass* IEnumerator_t1853284238_il2cpp_TypeInfo_var;
extern const RuntimeMethod* SetupCoroutine_InvokeMoveNext_m3199342729_RuntimeMethod_var;
extern String_t* _stringLiteral2664163362;
extern String_t* _stringLiteral696106652;
extern const uint32_t SetupCoroutine_InvokeMoveNext_m3199342729_MetadataUsageId;
extern RuntimeClass* ObjectU5BU5D_t2843939325_il2cpp_TypeInfo_var;
extern const uint32_t SetupCoroutine_InvokeMember_m2661944898_MetadataUsageId;
extern const uint32_t Sprite__ctor_m332781120_MetadataUsageId;
extern RuntimeClass* Vector4_t3319028937_il2cpp_TypeInfo_var;
extern const uint32_t Sprite_Create_m803022218_MetadataUsageId;
extern RuntimeClass* StackTraceUtility_t3465565809_il2cpp_TypeInfo_var;
extern RuntimeClass* String_t_il2cpp_TypeInfo_var;
extern String_t* _stringLiteral3452614644;
extern String_t* _stringLiteral3452614529;
extern const uint32_t StackTraceUtility_SetProjectFolder_m830524047_MetadataUsageId;
extern RuntimeClass* StackTrace_t1598645457_il2cpp_TypeInfo_var;
extern const uint32_t StackTraceUtility_ExtractStackTrace_m3279197967_MetadataUsageId;
extern String_t* _stringLiteral3155606;
extern String_t* _stringLiteral2227937992;
extern String_t* _stringLiteral547166083;
extern String_t* _stringLiteral3960313174;
extern String_t* _stringLiteral1464230170;
extern String_t* _stringLiteral1625510709;
extern const uint32_t StackTraceUtility_IsSystemStacktraceType_m299828041_MetadataUsageId;
extern RuntimeClass* Exception_t_il2cpp_TypeInfo_var;
extern RuntimeClass* StringBuilder_t_il2cpp_TypeInfo_var;
extern const RuntimeMethod* StackTraceUtility_ExtractStringFromExceptionInternal_m2686726792_RuntimeMethod_var;
extern String_t* _stringLiteral1698478619;
extern String_t* _stringLiteral2231172943;
extern String_t* _stringLiteral757602046;
extern String_t* _stringLiteral3452614566;
extern String_t* _stringLiteral3450517398;
extern String_t* _stringLiteral3264019870;
extern const uint32_t StackTraceUtility_ExtractStringFromExceptionInternal_m2686726792_MetadataUsageId;
extern RuntimeClass* CharU5BU5D_t3528271667_il2cpp_TypeInfo_var;
extern String_t* _stringLiteral1147544838;
extern String_t* _stringLiteral1974486273;
extern String_t* _stringLiteral3487100581;
extern String_t* _stringLiteral4144164017;
extern String_t* _stringLiteral3629554952;
extern String_t* _stringLiteral461147025;
extern String_t* _stringLiteral3452614645;
extern String_t* _stringLiteral3452614643;
extern String_t* _stringLiteral3791036681;
extern String_t* _stringLiteral4163537911;
extern String_t* _stringLiteral1311358384;
extern String_t* _stringLiteral4187617987;
extern String_t* _stringLiteral2177867675;
extern String_t* _stringLiteral3452614535;
extern const uint32_t StackTraceUtility_PostprocessStacktrace_m1043256299_MetadataUsageId;
extern String_t* _stringLiteral3452614530;
extern String_t* _stringLiteral3452614550;
extern String_t* _stringLiteral3452614536;
extern String_t* _stringLiteral3450517380;
extern String_t* _stringLiteral2678398999;
extern String_t* _stringLiteral1552523976;
extern String_t* _stringLiteral6580196;
extern String_t* _stringLiteral3402824819;
extern String_t* _stringLiteral1670073234;
extern String_t* _stringLiteral1200226066;
extern String_t* _stringLiteral61343007;
extern String_t* _stringLiteral681811338;
extern const uint32_t StackTraceUtility_ExtractFormattedStackTrace_m1281750362_MetadataUsageId;
extern const uint32_t StackTraceUtility__cctor_m1981266436_MetadataUsageId;
extern RuntimeClass* DateTime_t3738529785_il2cpp_TypeInfo_var;
extern const uint32_t SystemClock_get_now_m3370142516_MetadataUsageId;
extern RuntimeClass* SystemClock_t1201361285_il2cpp_TypeInfo_var;
extern const uint32_t SystemClock__cctor_m1862440887_MetadataUsageId;
extern const uint32_t Texture__ctor_m3554519797_MetadataUsageId;
extern const uint32_t Texture2D__ctor_m373113269_MetadataUsageId;
extern const uint32_t TouchScreenKeyboard_Open_m43950298_MetadataUsageId;
extern const uint32_t TouchScreenKeyboard_Open_m3325559252_MetadataUsageId;
extern const uint32_t TouchScreenKeyboard_get_text_m1797464608_MetadataUsageId;
extern const uint32_t TrackedReference_op_Equality_m3702354772_MetadataUsageId;
extern RuntimeClass* TrackedReference_t1199777556_il2cpp_TypeInfo_var;
extern const uint32_t TrackedReference_Equals_m1342350606_MetadataUsageId;
extern RuntimeClass* Quaternion_t2301928331_il2cpp_TypeInfo_var;
extern const uint32_t Transform_set_localEulerAngles_m4202601546_MetadataUsageId;
extern RuntimeClass* Vector3_t3722313464_il2cpp_TypeInfo_var;
extern const uint32_t Transform_get_up_m3972993886_MetadataUsageId;
extern const uint32_t Transform_get_forward_m747522392_MetadataUsageId;
extern RuntimeClass* RectTransform_t3704657025_il2cpp_TypeInfo_var;
extern RuntimeClass* Debug_t3317548046_il2cpp_TypeInfo_var;
extern String_t* _stringLiteral821992081;
extern const uint32_t Transform_set_parent_m786917804_MetadataUsageId;
extern const uint32_t Transform_Translate_m1990195114_MetadataUsageId;
extern const uint32_t Transform_RotateAround_m2651195670_MetadataUsageId;
extern RuntimeClass* Enumerator_t3442430665_il2cpp_TypeInfo_var;
extern const uint32_t Transform_GetEnumerator_m2717073726_MetadataUsageId;
extern RuntimeClass* SpriteAtlasManager_t3158462485_il2cpp_TypeInfo_var;
extern RuntimeClass* Action_1_t819399007_il2cpp_TypeInfo_var;
extern const RuntimeMethod* SpriteAtlasManager_Register_m2413332465_RuntimeMethod_var;
extern const RuntimeMethod* Action_1__ctor_m3325790595_RuntimeMethod_var;
extern const uint32_t SpriteAtlasManager_RequestAtlas_m455709951_MetadataUsageId;
extern const uint32_t SpriteAtlasManager__cctor_m3642741753_MetadataUsageId;
extern String_t* _stringLiteral3595826494;
extern const uint32_t UnityException__ctor_m1456865679_MetadataUsageId;
extern RuntimeClass* TextWriter_t3478189236_il2cpp_TypeInfo_var;
extern const uint32_t UnityLogWriter__ctor_m1834616883_MetadataUsageId;
extern RuntimeClass* UnityLogWriter_t1374348020_il2cpp_TypeInfo_var;
extern RuntimeClass* Console_t3208230065_il2cpp_TypeInfo_var;
extern const uint32_t UnityLogWriter_Init_m3866572946_MetadataUsageId;
extern RuntimeClass* Queue_1_t1200778106_il2cpp_TypeInfo_var;
extern RuntimeClass* Thread_t2300836069_il2cpp_TypeInfo_var;
extern const RuntimeMethod* Queue_1__ctor_m1971992302_RuntimeMethod_var;
extern const uint32_t UnitySynchronizationContext__ctor_m1707488257_MetadataUsageId;
extern const RuntimeMethod* Queue_1_Dequeue_m979967976_RuntimeMethod_var;
extern const RuntimeMethod* Queue_1_get_Count_m3368911732_RuntimeMethod_var;
extern const uint32_t UnitySynchronizationContext_Exec_m3359802660_MetadataUsageId;
extern RuntimeClass* UnitySynchronizationContext_t1887453786_il2cpp_TypeInfo_var;
extern const uint32_t UnitySynchronizationContext_InitializeSynchronizationContext_m3217591031_MetadataUsageId;
extern const uint32_t UnitySynchronizationContext_ExecuteTasks_m1310741010_MetadataUsageId;
extern RuntimeClass* IndexOutOfRangeException_t1578797820_il2cpp_TypeInfo_var;
extern const RuntimeMethod* Vector2_get_Item_m3559215723_RuntimeMethod_var;
extern String_t* _stringLiteral2662230418;
extern const uint32_t Vector2_get_Item_m3559215723_MetadataUsageId;
extern const RuntimeMethod* Vector2_set_Item_m3557490725_RuntimeMethod_var;
extern const uint32_t Vector2_set_Item_m3557490725_MetadataUsageId;
extern RuntimeClass* Mathf_t3464937446_il2cpp_TypeInfo_var;
extern const uint32_t Vector2_Lerp_m854472224_MetadataUsageId;
extern RuntimeClass* Single_t1397266774_il2cpp_TypeInfo_var;
extern String_t* _stringLiteral2738543532;
extern const uint32_t Vector2_ToString_m1205609053_MetadataUsageId;
extern RuntimeClass* Vector2_t2156229523_il2cpp_TypeInfo_var;
extern const uint32_t Vector2_Equals_m832062989_MetadataUsageId;
extern const uint32_t Vector2_op_Equality_m2303255133_MetadataUsageId;
extern const uint32_t Vector2_op_Inequality_m3858779880_MetadataUsageId;
extern const uint32_t Vector2_get_zero_m540426400_MetadataUsageId;
extern const uint32_t Vector2_get_one_m738793577_MetadataUsageId;
extern const uint32_t Vector2_get_up_m2647420593_MetadataUsageId;
extern const uint32_t Vector2_get_right_m1027081661_MetadataUsageId;
extern const uint32_t Vector2__cctor_m2108982652_MetadataUsageId;
extern const uint32_t Vector3_Lerp_m407887542_MetadataUsageId;
extern const uint32_t Vector3_MoveTowards_m2786395547_MetadataUsageId;
extern const RuntimeMethod* Vector3_get_Item_m668685504_RuntimeMethod_var;
extern String_t* _stringLiteral3966192333;
extern const uint32_t Vector3_get_Item_m668685504_MetadataUsageId;
extern const RuntimeMethod* Vector3_set_Item_m1772472431_RuntimeMethod_var;
extern const uint32_t Vector3_set_Item_m1772472431_MetadataUsageId;
extern const uint32_t Vector3_Equals_m1753054704_MetadataUsageId;
extern const uint32_t Vector3_Normalize_m2941713846_MetadataUsageId;
extern const uint32_t Vector3_Normalize_m914904454_MetadataUsageId;
extern const uint32_t Vector3_get_normalized_m2454957984_MetadataUsageId;
extern const uint32_t Vector3_Distance_m886789632_MetadataUsageId;
extern const uint32_t Vector3_Magnitude_m3447562852_MetadataUsageId;
extern const uint32_t Vector3_get_magnitude_m27958459_MetadataUsageId;
extern const uint32_t Vector3_Min_m1803158933_MetadataUsageId;
extern const uint32_t Vector3_Max_m3304052994_MetadataUsageId;
extern const uint32_t Vector3_get_zero_m1409827619_MetadataUsageId;
extern const uint32_t Vector3_get_one_m1629952498_MetadataUsageId;
extern const uint32_t Vector3_get_forward_m3100859705_MetadataUsageId;
extern const uint32_t Vector3_get_back_m4077847766_MetadataUsageId;
extern const uint32_t Vector3_get_up_m3584168373_MetadataUsageId;
extern const uint32_t Vector3_get_down_m3781355428_MetadataUsageId;
extern const uint32_t Vector3_get_left_m2428419009_MetadataUsageId;
extern const uint32_t Vector3_get_right_m1913784872_MetadataUsageId;
extern const uint32_t Vector3_op_Equality_m4231250055_MetadataUsageId;
extern const uint32_t Vector3_op_Inequality_m315980366_MetadataUsageId;
extern String_t* _stringLiteral122510266;
extern const uint32_t Vector3_ToString_m759076600_MetadataUsageId;
extern const uint32_t Vector3__cctor_m2599650684_MetadataUsageId;
extern RuntimeClass* Vector3Int_t741115188_il2cpp_TypeInfo_var;
extern const uint32_t Vector3Int_Equals_m1306183009_MetadataUsageId;
extern RuntimeClass* Int32_t2950945753_il2cpp_TypeInfo_var;
extern String_t* _stringLiteral341909834;
extern const uint32_t Vector3Int_ToString_m3033835977_MetadataUsageId;
extern const uint32_t Vector3Int__cctor_m1057449852_MetadataUsageId;
extern const RuntimeMethod* Vector4_get_Item_m2380866393_RuntimeMethod_var;
extern String_t* _stringLiteral2104486960;
extern const uint32_t Vector4_get_Item_m2380866393_MetadataUsageId;
extern const RuntimeMethod* Vector4_set_Item_m1183742235_RuntimeMethod_var;
extern const uint32_t Vector4_set_Item_m1183742235_MetadataUsageId;
extern const uint32_t Vector4_Equals_m1779210055_MetadataUsageId;
extern const uint32_t Vector4_get_sqrMagnitude_m3767723558_MetadataUsageId;
extern const uint32_t Vector4_get_zero_m1422399515_MetadataUsageId;
extern const uint32_t Vector4_op_Equality_m2403588337_MetadataUsageId;
extern String_t* _stringLiteral3651359435;
extern const uint32_t Vector4_ToString_m1596036856_MetadataUsageId;
extern const uint32_t Vector4_SqrMagnitude_m1488236336_MetadataUsageId;
extern const uint32_t Vector4__cctor_m2519631228_MetadataUsageId;
extern RuntimeClass* MathfInternal_t624072491_il2cpp_TypeInfo_var;
extern const uint32_t MathfInternal__cctor_m2622893686_MetadataUsageId;
extern RuntimeClass* TypeInferenceRules_t96689094_il2cpp_TypeInfo_var;
extern const uint32_t TypeInferenceRuleAttribute__ctor_m3137488504_MetadataUsageId;

struct ObjectU5BU5D_t2843939325;
struct ParameterModifierU5BU5D_t2943407543;
struct StringU5BU5D_t1281789340;
struct CharU5BU5D_t3528271667;
struct ParameterInfoU5BU5D_t390618515;


#ifndef RUNTIMEOBJECT_H
#define RUNTIMEOBJECT_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Object

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEOBJECT_H
#ifndef TIME_T2420636075_H
#define TIME_T2420636075_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Time
struct  Time_t2420636075  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TIME_T2420636075_H
#ifndef SYSTEMINFO_T3561985952_H
#define SYSTEMINFO_T3561985952_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.SystemInfo
struct  SystemInfo_t3561985952  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SYSTEMINFO_T3561985952_H
#ifndef STACKFRAME_T3217253059_H
#define STACKFRAME_T3217253059_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Diagnostics.StackFrame
struct  StackFrame_t3217253059  : public RuntimeObject
{
public:
	// System.Int32 System.Diagnostics.StackFrame::ilOffset
	int32_t ___ilOffset_1;
	// System.Int32 System.Diagnostics.StackFrame::nativeOffset
	int32_t ___nativeOffset_2;
	// System.Reflection.MethodBase System.Diagnostics.StackFrame::methodBase
	MethodBase_t * ___methodBase_3;
	// System.String System.Diagnostics.StackFrame::fileName
	String_t* ___fileName_4;
	// System.Int32 System.Diagnostics.StackFrame::lineNumber
	int32_t ___lineNumber_5;
	// System.Int32 System.Diagnostics.StackFrame::columnNumber
	int32_t ___columnNumber_6;
	// System.String System.Diagnostics.StackFrame::internalMethodName
	String_t* ___internalMethodName_7;

public:
	inline static int32_t get_offset_of_ilOffset_1() { return static_cast<int32_t>(offsetof(StackFrame_t3217253059, ___ilOffset_1)); }
	inline int32_t get_ilOffset_1() const { return ___ilOffset_1; }
	inline int32_t* get_address_of_ilOffset_1() { return &___ilOffset_1; }
	inline void set_ilOffset_1(int32_t value)
	{
		___ilOffset_1 = value;
	}

	inline static int32_t get_offset_of_nativeOffset_2() { return static_cast<int32_t>(offsetof(StackFrame_t3217253059, ___nativeOffset_2)); }
	inline int32_t get_nativeOffset_2() const { return ___nativeOffset_2; }
	inline int32_t* get_address_of_nativeOffset_2() { return &___nativeOffset_2; }
	inline void set_nativeOffset_2(int32_t value)
	{
		___nativeOffset_2 = value;
	}

	inline static int32_t get_offset_of_methodBase_3() { return static_cast<int32_t>(offsetof(StackFrame_t3217253059, ___methodBase_3)); }
	inline MethodBase_t * get_methodBase_3() const { return ___methodBase_3; }
	inline MethodBase_t ** get_address_of_methodBase_3() { return &___methodBase_3; }
	inline void set_methodBase_3(MethodBase_t * value)
	{
		___methodBase_3 = value;
		Il2CppCodeGenWriteBarrier((&___methodBase_3), value);
	}

	inline static int32_t get_offset_of_fileName_4() { return static_cast<int32_t>(offsetof(StackFrame_t3217253059, ___fileName_4)); }
	inline String_t* get_fileName_4() const { return ___fileName_4; }
	inline String_t** get_address_of_fileName_4() { return &___fileName_4; }
	inline void set_fileName_4(String_t* value)
	{
		___fileName_4 = value;
		Il2CppCodeGenWriteBarrier((&___fileName_4), value);
	}

	inline static int32_t get_offset_of_lineNumber_5() { return static_cast<int32_t>(offsetof(StackFrame_t3217253059, ___lineNumber_5)); }
	inline int32_t get_lineNumber_5() const { return ___lineNumber_5; }
	inline int32_t* get_address_of_lineNumber_5() { return &___lineNumber_5; }
	inline void set_lineNumber_5(int32_t value)
	{
		___lineNumber_5 = value;
	}

	inline static int32_t get_offset_of_columnNumber_6() { return static_cast<int32_t>(offsetof(StackFrame_t3217253059, ___columnNumber_6)); }
	inline int32_t get_columnNumber_6() const { return ___columnNumber_6; }
	inline int32_t* get_address_of_columnNumber_6() { return &___columnNumber_6; }
	inline void set_columnNumber_6(int32_t value)
	{
		___columnNumber_6 = value;
	}

	inline static int32_t get_offset_of_internalMethodName_7() { return static_cast<int32_t>(offsetof(StackFrame_t3217253059, ___internalMethodName_7)); }
	inline String_t* get_internalMethodName_7() const { return ___internalMethodName_7; }
	inline String_t** get_address_of_internalMethodName_7() { return &___internalMethodName_7; }
	inline void set_internalMethodName_7(String_t* value)
	{
		___internalMethodName_7 = value;
		Il2CppCodeGenWriteBarrier((&___internalMethodName_7), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STACKFRAME_T3217253059_H
#ifndef ENUMERATOR_T3442430665_H
#define ENUMERATOR_T3442430665_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Transform/Enumerator
struct  Enumerator_t3442430665  : public RuntimeObject
{
public:
	// UnityEngine.Transform UnityEngine.Transform/Enumerator::outer
	Transform_t3600365921 * ___outer_0;
	// System.Int32 UnityEngine.Transform/Enumerator::currentIndex
	int32_t ___currentIndex_1;

public:
	inline static int32_t get_offset_of_outer_0() { return static_cast<int32_t>(offsetof(Enumerator_t3442430665, ___outer_0)); }
	inline Transform_t3600365921 * get_outer_0() const { return ___outer_0; }
	inline Transform_t3600365921 ** get_address_of_outer_0() { return &___outer_0; }
	inline void set_outer_0(Transform_t3600365921 * value)
	{
		___outer_0 = value;
		Il2CppCodeGenWriteBarrier((&___outer_0), value);
	}

	inline static int32_t get_offset_of_currentIndex_1() { return static_cast<int32_t>(offsetof(Enumerator_t3442430665, ___currentIndex_1)); }
	inline int32_t get_currentIndex_1() const { return ___currentIndex_1; }
	inline int32_t* get_address_of_currentIndex_1() { return &___currentIndex_1; }
	inline void set_currentIndex_1(int32_t value)
	{
		___currentIndex_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ENUMERATOR_T3442430665_H
#ifndef TOUCHSCREENKEYBOARD_T731888065_H
#define TOUCHSCREENKEYBOARD_T731888065_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.TouchScreenKeyboard
struct  TouchScreenKeyboard_t731888065  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TOUCHSCREENKEYBOARD_T731888065_H
#ifndef MARSHALBYREFOBJECT_T2760389100_H
#define MARSHALBYREFOBJECT_T2760389100_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.MarshalByRefObject
struct  MarshalByRefObject_t2760389100  : public RuntimeObject
{
public:
	// System.Runtime.Remoting.ServerIdentity System.MarshalByRefObject::_identity
	ServerIdentity_t2342208608 * ____identity_0;

public:
	inline static int32_t get_offset_of__identity_0() { return static_cast<int32_t>(offsetof(MarshalByRefObject_t2760389100, ____identity_0)); }
	inline ServerIdentity_t2342208608 * get__identity_0() const { return ____identity_0; }
	inline ServerIdentity_t2342208608 ** get_address_of__identity_0() { return &____identity_0; }
	inline void set__identity_0(ServerIdentity_t2342208608 * value)
	{
		____identity_0 = value;
		Il2CppCodeGenWriteBarrier((&____identity_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MARSHALBYREFOBJECT_T2760389100_H
#ifndef EXCEPTION_T_H
#define EXCEPTION_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Exception
struct  Exception_t  : public RuntimeObject
{
public:
	// System.IntPtr[] System.Exception::trace_ips
	IntPtrU5BU5D_t4013366056* ___trace_ips_0;
	// System.Exception System.Exception::inner_exception
	Exception_t * ___inner_exception_1;
	// System.String System.Exception::message
	String_t* ___message_2;
	// System.String System.Exception::help_link
	String_t* ___help_link_3;
	// System.String System.Exception::class_name
	String_t* ___class_name_4;
	// System.String System.Exception::stack_trace
	String_t* ___stack_trace_5;
	// System.String System.Exception::_remoteStackTraceString
	String_t* ____remoteStackTraceString_6;
	// System.Int32 System.Exception::remote_stack_index
	int32_t ___remote_stack_index_7;
	// System.Int32 System.Exception::hresult
	int32_t ___hresult_8;
	// System.String System.Exception::source
	String_t* ___source_9;
	// System.Collections.IDictionary System.Exception::_data
	RuntimeObject* ____data_10;

public:
	inline static int32_t get_offset_of_trace_ips_0() { return static_cast<int32_t>(offsetof(Exception_t, ___trace_ips_0)); }
	inline IntPtrU5BU5D_t4013366056* get_trace_ips_0() const { return ___trace_ips_0; }
	inline IntPtrU5BU5D_t4013366056** get_address_of_trace_ips_0() { return &___trace_ips_0; }
	inline void set_trace_ips_0(IntPtrU5BU5D_t4013366056* value)
	{
		___trace_ips_0 = value;
		Il2CppCodeGenWriteBarrier((&___trace_ips_0), value);
	}

	inline static int32_t get_offset_of_inner_exception_1() { return static_cast<int32_t>(offsetof(Exception_t, ___inner_exception_1)); }
	inline Exception_t * get_inner_exception_1() const { return ___inner_exception_1; }
	inline Exception_t ** get_address_of_inner_exception_1() { return &___inner_exception_1; }
	inline void set_inner_exception_1(Exception_t * value)
	{
		___inner_exception_1 = value;
		Il2CppCodeGenWriteBarrier((&___inner_exception_1), value);
	}

	inline static int32_t get_offset_of_message_2() { return static_cast<int32_t>(offsetof(Exception_t, ___message_2)); }
	inline String_t* get_message_2() const { return ___message_2; }
	inline String_t** get_address_of_message_2() { return &___message_2; }
	inline void set_message_2(String_t* value)
	{
		___message_2 = value;
		Il2CppCodeGenWriteBarrier((&___message_2), value);
	}

	inline static int32_t get_offset_of_help_link_3() { return static_cast<int32_t>(offsetof(Exception_t, ___help_link_3)); }
	inline String_t* get_help_link_3() const { return ___help_link_3; }
	inline String_t** get_address_of_help_link_3() { return &___help_link_3; }
	inline void set_help_link_3(String_t* value)
	{
		___help_link_3 = value;
		Il2CppCodeGenWriteBarrier((&___help_link_3), value);
	}

	inline static int32_t get_offset_of_class_name_4() { return static_cast<int32_t>(offsetof(Exception_t, ___class_name_4)); }
	inline String_t* get_class_name_4() const { return ___class_name_4; }
	inline String_t** get_address_of_class_name_4() { return &___class_name_4; }
	inline void set_class_name_4(String_t* value)
	{
		___class_name_4 = value;
		Il2CppCodeGenWriteBarrier((&___class_name_4), value);
	}

	inline static int32_t get_offset_of_stack_trace_5() { return static_cast<int32_t>(offsetof(Exception_t, ___stack_trace_5)); }
	inline String_t* get_stack_trace_5() const { return ___stack_trace_5; }
	inline String_t** get_address_of_stack_trace_5() { return &___stack_trace_5; }
	inline void set_stack_trace_5(String_t* value)
	{
		___stack_trace_5 = value;
		Il2CppCodeGenWriteBarrier((&___stack_trace_5), value);
	}

	inline static int32_t get_offset_of__remoteStackTraceString_6() { return static_cast<int32_t>(offsetof(Exception_t, ____remoteStackTraceString_6)); }
	inline String_t* get__remoteStackTraceString_6() const { return ____remoteStackTraceString_6; }
	inline String_t** get_address_of__remoteStackTraceString_6() { return &____remoteStackTraceString_6; }
	inline void set__remoteStackTraceString_6(String_t* value)
	{
		____remoteStackTraceString_6 = value;
		Il2CppCodeGenWriteBarrier((&____remoteStackTraceString_6), value);
	}

	inline static int32_t get_offset_of_remote_stack_index_7() { return static_cast<int32_t>(offsetof(Exception_t, ___remote_stack_index_7)); }
	inline int32_t get_remote_stack_index_7() const { return ___remote_stack_index_7; }
	inline int32_t* get_address_of_remote_stack_index_7() { return &___remote_stack_index_7; }
	inline void set_remote_stack_index_7(int32_t value)
	{
		___remote_stack_index_7 = value;
	}

	inline static int32_t get_offset_of_hresult_8() { return static_cast<int32_t>(offsetof(Exception_t, ___hresult_8)); }
	inline int32_t get_hresult_8() const { return ___hresult_8; }
	inline int32_t* get_address_of_hresult_8() { return &___hresult_8; }
	inline void set_hresult_8(int32_t value)
	{
		___hresult_8 = value;
	}

	inline static int32_t get_offset_of_source_9() { return static_cast<int32_t>(offsetof(Exception_t, ___source_9)); }
	inline String_t* get_source_9() const { return ___source_9; }
	inline String_t** get_address_of_source_9() { return &___source_9; }
	inline void set_source_9(String_t* value)
	{
		___source_9 = value;
		Il2CppCodeGenWriteBarrier((&___source_9), value);
	}

	inline static int32_t get_offset_of__data_10() { return static_cast<int32_t>(offsetof(Exception_t, ____data_10)); }
	inline RuntimeObject* get__data_10() const { return ____data_10; }
	inline RuntimeObject** get_address_of__data_10() { return &____data_10; }
	inline void set__data_10(RuntimeObject* value)
	{
		____data_10 = value;
		Il2CppCodeGenWriteBarrier((&____data_10), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EXCEPTION_T_H
#ifndef STACKTRACE_T1598645457_H
#define STACKTRACE_T1598645457_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Diagnostics.StackTrace
struct  StackTrace_t1598645457  : public RuntimeObject
{
public:
	// System.Diagnostics.StackFrame[] System.Diagnostics.StackTrace::frames
	StackFrameU5BU5D_t1997726418* ___frames_1;
	// System.Boolean System.Diagnostics.StackTrace::debug_info
	bool ___debug_info_2;

public:
	inline static int32_t get_offset_of_frames_1() { return static_cast<int32_t>(offsetof(StackTrace_t1598645457, ___frames_1)); }
	inline StackFrameU5BU5D_t1997726418* get_frames_1() const { return ___frames_1; }
	inline StackFrameU5BU5D_t1997726418** get_address_of_frames_1() { return &___frames_1; }
	inline void set_frames_1(StackFrameU5BU5D_t1997726418* value)
	{
		___frames_1 = value;
		Il2CppCodeGenWriteBarrier((&___frames_1), value);
	}

	inline static int32_t get_offset_of_debug_info_2() { return static_cast<int32_t>(offsetof(StackTrace_t1598645457, ___debug_info_2)); }
	inline bool get_debug_info_2() const { return ___debug_info_2; }
	inline bool* get_address_of_debug_info_2() { return &___debug_info_2; }
	inline void set_debug_info_2(bool value)
	{
		___debug_info_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STACKTRACE_T1598645457_H
#ifndef STACKTRACEUTILITY_T3465565809_H
#define STACKTRACEUTILITY_T3465565809_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.StackTraceUtility
struct  StackTraceUtility_t3465565809  : public RuntimeObject
{
public:

public:
};

struct StackTraceUtility_t3465565809_StaticFields
{
public:
	// System.String UnityEngine.StackTraceUtility::projectFolder
	String_t* ___projectFolder_0;

public:
	inline static int32_t get_offset_of_projectFolder_0() { return static_cast<int32_t>(offsetof(StackTraceUtility_t3465565809_StaticFields, ___projectFolder_0)); }
	inline String_t* get_projectFolder_0() const { return ___projectFolder_0; }
	inline String_t** get_address_of_projectFolder_0() { return &___projectFolder_0; }
	inline void set_projectFolder_0(String_t* value)
	{
		___projectFolder_0 = value;
		Il2CppCodeGenWriteBarrier((&___projectFolder_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STACKTRACEUTILITY_T3465565809_H
#ifndef DATAUTILITY_T2196215967_H
#define DATAUTILITY_T2196215967_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Sprites.DataUtility
struct  DataUtility_t2196215967  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DATAUTILITY_T2196215967_H
#ifndef MEMBERINFO_T_H
#define MEMBERINFO_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.MemberInfo
struct  MemberInfo_t  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MEMBERINFO_T_H
#ifndef STRINGBUILDER_T_H
#define STRINGBUILDER_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Text.StringBuilder
struct  StringBuilder_t  : public RuntimeObject
{
public:
	// System.Int32 System.Text.StringBuilder::_length
	int32_t ____length_1;
	// System.String System.Text.StringBuilder::_str
	String_t* ____str_2;
	// System.String System.Text.StringBuilder::_cached_str
	String_t* ____cached_str_3;
	// System.Int32 System.Text.StringBuilder::_maxCapacity
	int32_t ____maxCapacity_4;

public:
	inline static int32_t get_offset_of__length_1() { return static_cast<int32_t>(offsetof(StringBuilder_t, ____length_1)); }
	inline int32_t get__length_1() const { return ____length_1; }
	inline int32_t* get_address_of__length_1() { return &____length_1; }
	inline void set__length_1(int32_t value)
	{
		____length_1 = value;
	}

	inline static int32_t get_offset_of__str_2() { return static_cast<int32_t>(offsetof(StringBuilder_t, ____str_2)); }
	inline String_t* get__str_2() const { return ____str_2; }
	inline String_t** get_address_of__str_2() { return &____str_2; }
	inline void set__str_2(String_t* value)
	{
		____str_2 = value;
		Il2CppCodeGenWriteBarrier((&____str_2), value);
	}

	inline static int32_t get_offset_of__cached_str_3() { return static_cast<int32_t>(offsetof(StringBuilder_t, ____cached_str_3)); }
	inline String_t* get__cached_str_3() const { return ____cached_str_3; }
	inline String_t** get_address_of__cached_str_3() { return &____cached_str_3; }
	inline void set__cached_str_3(String_t* value)
	{
		____cached_str_3 = value;
		Il2CppCodeGenWriteBarrier((&____cached_str_3), value);
	}

	inline static int32_t get_offset_of__maxCapacity_4() { return static_cast<int32_t>(offsetof(StringBuilder_t, ____maxCapacity_4)); }
	inline int32_t get__maxCapacity_4() const { return ____maxCapacity_4; }
	inline int32_t* get_address_of__maxCapacity_4() { return &____maxCapacity_4; }
	inline void set__maxCapacity_4(int32_t value)
	{
		____maxCapacity_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STRINGBUILDER_T_H
#ifndef NETFXCOREEXTENSIONS_T4089902045_H
#define NETFXCOREEXTENSIONS_T4089902045_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngineInternal.NetFxCoreExtensions
struct  NetFxCoreExtensions_t4089902045  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // NETFXCOREEXTENSIONS_T4089902045_H
#ifndef STACK_T2329662280_H
#define STACK_T2329662280_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Stack
struct  Stack_t2329662280  : public RuntimeObject
{
public:
	// System.Object[] System.Collections.Stack::contents
	ObjectU5BU5D_t2843939325* ___contents_0;
	// System.Int32 System.Collections.Stack::current
	int32_t ___current_1;
	// System.Int32 System.Collections.Stack::count
	int32_t ___count_2;
	// System.Int32 System.Collections.Stack::capacity
	int32_t ___capacity_3;
	// System.Int32 System.Collections.Stack::modCount
	int32_t ___modCount_4;

public:
	inline static int32_t get_offset_of_contents_0() { return static_cast<int32_t>(offsetof(Stack_t2329662280, ___contents_0)); }
	inline ObjectU5BU5D_t2843939325* get_contents_0() const { return ___contents_0; }
	inline ObjectU5BU5D_t2843939325** get_address_of_contents_0() { return &___contents_0; }
	inline void set_contents_0(ObjectU5BU5D_t2843939325* value)
	{
		___contents_0 = value;
		Il2CppCodeGenWriteBarrier((&___contents_0), value);
	}

	inline static int32_t get_offset_of_current_1() { return static_cast<int32_t>(offsetof(Stack_t2329662280, ___current_1)); }
	inline int32_t get_current_1() const { return ___current_1; }
	inline int32_t* get_address_of_current_1() { return &___current_1; }
	inline void set_current_1(int32_t value)
	{
		___current_1 = value;
	}

	inline static int32_t get_offset_of_count_2() { return static_cast<int32_t>(offsetof(Stack_t2329662280, ___count_2)); }
	inline int32_t get_count_2() const { return ___count_2; }
	inline int32_t* get_address_of_count_2() { return &___count_2; }
	inline void set_count_2(int32_t value)
	{
		___count_2 = value;
	}

	inline static int32_t get_offset_of_capacity_3() { return static_cast<int32_t>(offsetof(Stack_t2329662280, ___capacity_3)); }
	inline int32_t get_capacity_3() const { return ___capacity_3; }
	inline int32_t* get_address_of_capacity_3() { return &___capacity_3; }
	inline void set_capacity_3(int32_t value)
	{
		___capacity_3 = value;
	}

	inline static int32_t get_offset_of_modCount_4() { return static_cast<int32_t>(offsetof(Stack_t2329662280, ___modCount_4)); }
	inline int32_t get_modCount_4() const { return ___modCount_4; }
	inline int32_t* get_address_of_modCount_4() { return &___modCount_4; }
	inline void set_modCount_4(int32_t value)
	{
		___modCount_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STACK_T2329662280_H
#ifndef CUSTOMYIELDINSTRUCTION_T1895667560_H
#define CUSTOMYIELDINSTRUCTION_T1895667560_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.CustomYieldInstruction
struct  CustomYieldInstruction_t1895667560  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CUSTOMYIELDINSTRUCTION_T1895667560_H
#ifndef CRITICALFINALIZEROBJECT_T701527852_H
#define CRITICALFINALIZEROBJECT_T701527852_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Runtime.ConstrainedExecution.CriticalFinalizerObject
struct  CriticalFinalizerObject_t701527852  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CRITICALFINALIZEROBJECT_T701527852_H
#ifndef VALUETYPE_T3640485471_H
#define VALUETYPE_T3640485471_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ValueType
struct  ValueType_t3640485471  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.ValueType
struct ValueType_t3640485471_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.ValueType
struct ValueType_t3640485471_marshaled_com
{
};
#endif // VALUETYPE_T3640485471_H
#ifndef SCRIPTINGUTILS_T2624832893_H
#define SCRIPTINGUTILS_T2624832893_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngineInternal.ScriptingUtils
struct  ScriptingUtils_t2624832893  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SCRIPTINGUTILS_T2624832893_H
#ifndef TEXTWRITER_T3478189236_H
#define TEXTWRITER_T3478189236_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.IO.TextWriter
struct  TextWriter_t3478189236  : public RuntimeObject
{
public:
	// System.Char[] System.IO.TextWriter::CoreNewLine
	CharU5BU5D_t3528271667* ___CoreNewLine_0;

public:
	inline static int32_t get_offset_of_CoreNewLine_0() { return static_cast<int32_t>(offsetof(TextWriter_t3478189236, ___CoreNewLine_0)); }
	inline CharU5BU5D_t3528271667* get_CoreNewLine_0() const { return ___CoreNewLine_0; }
	inline CharU5BU5D_t3528271667** get_address_of_CoreNewLine_0() { return &___CoreNewLine_0; }
	inline void set_CoreNewLine_0(CharU5BU5D_t3528271667* value)
	{
		___CoreNewLine_0 = value;
		Il2CppCodeGenWriteBarrier((&___CoreNewLine_0), value);
	}
};

struct TextWriter_t3478189236_StaticFields
{
public:
	// System.IO.TextWriter System.IO.TextWriter::Null
	TextWriter_t3478189236 * ___Null_1;

public:
	inline static int32_t get_offset_of_Null_1() { return static_cast<int32_t>(offsetof(TextWriter_t3478189236_StaticFields, ___Null_1)); }
	inline TextWriter_t3478189236 * get_Null_1() const { return ___Null_1; }
	inline TextWriter_t3478189236 ** get_address_of_Null_1() { return &___Null_1; }
	inline void set_Null_1(TextWriter_t3478189236 * value)
	{
		___Null_1 = value;
		Il2CppCodeGenWriteBarrier((&___Null_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TEXTWRITER_T3478189236_H
#ifndef SERIALIZATIONINFO_T950877179_H
#define SERIALIZATIONINFO_T950877179_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Runtime.Serialization.SerializationInfo
struct  SerializationInfo_t950877179  : public RuntimeObject
{
public:
	// System.Collections.Hashtable System.Runtime.Serialization.SerializationInfo::serialized
	Hashtable_t1853889766 * ___serialized_0;
	// System.Collections.ArrayList System.Runtime.Serialization.SerializationInfo::values
	ArrayList_t2718874744 * ___values_1;
	// System.String System.Runtime.Serialization.SerializationInfo::assemblyName
	String_t* ___assemblyName_2;
	// System.String System.Runtime.Serialization.SerializationInfo::fullTypeName
	String_t* ___fullTypeName_3;
	// System.Runtime.Serialization.IFormatterConverter System.Runtime.Serialization.SerializationInfo::converter
	RuntimeObject* ___converter_4;

public:
	inline static int32_t get_offset_of_serialized_0() { return static_cast<int32_t>(offsetof(SerializationInfo_t950877179, ___serialized_0)); }
	inline Hashtable_t1853889766 * get_serialized_0() const { return ___serialized_0; }
	inline Hashtable_t1853889766 ** get_address_of_serialized_0() { return &___serialized_0; }
	inline void set_serialized_0(Hashtable_t1853889766 * value)
	{
		___serialized_0 = value;
		Il2CppCodeGenWriteBarrier((&___serialized_0), value);
	}

	inline static int32_t get_offset_of_values_1() { return static_cast<int32_t>(offsetof(SerializationInfo_t950877179, ___values_1)); }
	inline ArrayList_t2718874744 * get_values_1() const { return ___values_1; }
	inline ArrayList_t2718874744 ** get_address_of_values_1() { return &___values_1; }
	inline void set_values_1(ArrayList_t2718874744 * value)
	{
		___values_1 = value;
		Il2CppCodeGenWriteBarrier((&___values_1), value);
	}

	inline static int32_t get_offset_of_assemblyName_2() { return static_cast<int32_t>(offsetof(SerializationInfo_t950877179, ___assemblyName_2)); }
	inline String_t* get_assemblyName_2() const { return ___assemblyName_2; }
	inline String_t** get_address_of_assemblyName_2() { return &___assemblyName_2; }
	inline void set_assemblyName_2(String_t* value)
	{
		___assemblyName_2 = value;
		Il2CppCodeGenWriteBarrier((&___assemblyName_2), value);
	}

	inline static int32_t get_offset_of_fullTypeName_3() { return static_cast<int32_t>(offsetof(SerializationInfo_t950877179, ___fullTypeName_3)); }
	inline String_t* get_fullTypeName_3() const { return ___fullTypeName_3; }
	inline String_t** get_address_of_fullTypeName_3() { return &___fullTypeName_3; }
	inline void set_fullTypeName_3(String_t* value)
	{
		___fullTypeName_3 = value;
		Il2CppCodeGenWriteBarrier((&___fullTypeName_3), value);
	}

	inline static int32_t get_offset_of_converter_4() { return static_cast<int32_t>(offsetof(SerializationInfo_t950877179, ___converter_4)); }
	inline RuntimeObject* get_converter_4() const { return ___converter_4; }
	inline RuntimeObject** get_address_of_converter_4() { return &___converter_4; }
	inline void set_converter_4(RuntimeObject* value)
	{
		___converter_4 = value;
		Il2CppCodeGenWriteBarrier((&___converter_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SERIALIZATIONINFO_T950877179_H
#ifndef SPRITEATLASMANAGER_T3158462485_H
#define SPRITEATLASMANAGER_T3158462485_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.U2D.SpriteAtlasManager
struct  SpriteAtlasManager_t3158462485  : public RuntimeObject
{
public:

public:
};

struct SpriteAtlasManager_t3158462485_StaticFields
{
public:
	// UnityEngine.U2D.SpriteAtlasManager/RequestAtlasCallback UnityEngine.U2D.SpriteAtlasManager::atlasRequested
	RequestAtlasCallback_t3100554279 * ___atlasRequested_0;
	// System.Action`1<UnityEngine.U2D.SpriteAtlas> UnityEngine.U2D.SpriteAtlasManager::<>f__mg$cache0
	Action_1_t819399007 * ___U3CU3Ef__mgU24cache0_1;

public:
	inline static int32_t get_offset_of_atlasRequested_0() { return static_cast<int32_t>(offsetof(SpriteAtlasManager_t3158462485_StaticFields, ___atlasRequested_0)); }
	inline RequestAtlasCallback_t3100554279 * get_atlasRequested_0() const { return ___atlasRequested_0; }
	inline RequestAtlasCallback_t3100554279 ** get_address_of_atlasRequested_0() { return &___atlasRequested_0; }
	inline void set_atlasRequested_0(RequestAtlasCallback_t3100554279 * value)
	{
		___atlasRequested_0 = value;
		Il2CppCodeGenWriteBarrier((&___atlasRequested_0), value);
	}

	inline static int32_t get_offset_of_U3CU3Ef__mgU24cache0_1() { return static_cast<int32_t>(offsetof(SpriteAtlasManager_t3158462485_StaticFields, ___U3CU3Ef__mgU24cache0_1)); }
	inline Action_1_t819399007 * get_U3CU3Ef__mgU24cache0_1() const { return ___U3CU3Ef__mgU24cache0_1; }
	inline Action_1_t819399007 ** get_address_of_U3CU3Ef__mgU24cache0_1() { return &___U3CU3Ef__mgU24cache0_1; }
	inline void set_U3CU3Ef__mgU24cache0_1(Action_1_t819399007 * value)
	{
		___U3CU3Ef__mgU24cache0_1 = value;
		Il2CppCodeGenWriteBarrier((&___U3CU3Ef__mgU24cache0_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SPRITEATLASMANAGER_T3158462485_H
#ifndef YIELDINSTRUCTION_T403091072_H
#define YIELDINSTRUCTION_T403091072_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.YieldInstruction
struct  YieldInstruction_t403091072  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_t403091072_marshaled_pinvoke
{
};
// Native definition for COM marshalling of UnityEngine.YieldInstruction
struct YieldInstruction_t403091072_marshaled_com
{
};
#endif // YIELDINSTRUCTION_T403091072_H
#ifndef SYNCHRONIZATIONCONTEXT_T2326897723_H
#define SYNCHRONIZATIONCONTEXT_T2326897723_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Threading.SynchronizationContext
struct  SynchronizationContext_t2326897723  : public RuntimeObject
{
public:

public:
};

struct SynchronizationContext_t2326897723_ThreadStaticFields
{
public:
	// System.Threading.SynchronizationContext System.Threading.SynchronizationContext::currentContext
	SynchronizationContext_t2326897723 * ___currentContext_0;

public:
	inline static int32_t get_offset_of_currentContext_0() { return static_cast<int32_t>(offsetof(SynchronizationContext_t2326897723_ThreadStaticFields, ___currentContext_0)); }
	inline SynchronizationContext_t2326897723 * get_currentContext_0() const { return ___currentContext_0; }
	inline SynchronizationContext_t2326897723 ** get_address_of_currentContext_0() { return &___currentContext_0; }
	inline void set_currentContext_0(SynchronizationContext_t2326897723 * value)
	{
		___currentContext_0 = value;
		Il2CppCodeGenWriteBarrier((&___currentContext_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SYNCHRONIZATIONCONTEXT_T2326897723_H
#ifndef QUEUE_1_T1200778106_H
#define QUEUE_1_T1200778106_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Collections.Generic.Queue`1<UnityEngine.UnitySynchronizationContext/WorkRequest>
struct  Queue_1_t1200778106  : public RuntimeObject
{
public:
	// T[] System.Collections.Generic.Queue`1::_array
	WorkRequestU5BU5D_t3723878365* ____array_0;
	// System.Int32 System.Collections.Generic.Queue`1::_head
	int32_t ____head_1;
	// System.Int32 System.Collections.Generic.Queue`1::_size
	int32_t ____size_2;
	// System.Int32 System.Collections.Generic.Queue`1::_version
	int32_t ____version_3;

public:
	inline static int32_t get_offset_of__array_0() { return static_cast<int32_t>(offsetof(Queue_1_t1200778106, ____array_0)); }
	inline WorkRequestU5BU5D_t3723878365* get__array_0() const { return ____array_0; }
	inline WorkRequestU5BU5D_t3723878365** get_address_of__array_0() { return &____array_0; }
	inline void set__array_0(WorkRequestU5BU5D_t3723878365* value)
	{
		____array_0 = value;
		Il2CppCodeGenWriteBarrier((&____array_0), value);
	}

	inline static int32_t get_offset_of__head_1() { return static_cast<int32_t>(offsetof(Queue_1_t1200778106, ____head_1)); }
	inline int32_t get__head_1() const { return ____head_1; }
	inline int32_t* get_address_of__head_1() { return &____head_1; }
	inline void set__head_1(int32_t value)
	{
		____head_1 = value;
	}

	inline static int32_t get_offset_of__size_2() { return static_cast<int32_t>(offsetof(Queue_1_t1200778106, ____size_2)); }
	inline int32_t get__size_2() const { return ____size_2; }
	inline int32_t* get_address_of__size_2() { return &____size_2; }
	inline void set__size_2(int32_t value)
	{
		____size_2 = value;
	}

	inline static int32_t get_offset_of__version_3() { return static_cast<int32_t>(offsetof(Queue_1_t1200778106, ____version_3)); }
	inline int32_t get__version_3() const { return ____version_3; }
	inline int32_t* get_address_of__version_3() { return &____version_3; }
	inline void set__version_3(int32_t value)
	{
		____version_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // QUEUE_1_T1200778106_H
#ifndef STRING_T_H
#define STRING_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.String
struct  String_t  : public RuntimeObject
{
public:
	// System.Int32 System.String::length
	int32_t ___length_0;
	// System.Char System.String::start_char
	Il2CppChar ___start_char_1;

public:
	inline static int32_t get_offset_of_length_0() { return static_cast<int32_t>(offsetof(String_t, ___length_0)); }
	inline int32_t get_length_0() const { return ___length_0; }
	inline int32_t* get_address_of_length_0() { return &___length_0; }
	inline void set_length_0(int32_t value)
	{
		___length_0 = value;
	}

	inline static int32_t get_offset_of_start_char_1() { return static_cast<int32_t>(offsetof(String_t, ___start_char_1)); }
	inline Il2CppChar get_start_char_1() const { return ___start_char_1; }
	inline Il2CppChar* get_address_of_start_char_1() { return &___start_char_1; }
	inline void set_start_char_1(Il2CppChar value)
	{
		___start_char_1 = value;
	}
};

struct String_t_StaticFields
{
public:
	// System.String System.String::Empty
	String_t* ___Empty_2;
	// System.Char[] System.String::WhiteChars
	CharU5BU5D_t3528271667* ___WhiteChars_3;

public:
	inline static int32_t get_offset_of_Empty_2() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___Empty_2)); }
	inline String_t* get_Empty_2() const { return ___Empty_2; }
	inline String_t** get_address_of_Empty_2() { return &___Empty_2; }
	inline void set_Empty_2(String_t* value)
	{
		___Empty_2 = value;
		Il2CppCodeGenWriteBarrier((&___Empty_2), value);
	}

	inline static int32_t get_offset_of_WhiteChars_3() { return static_cast<int32_t>(offsetof(String_t_StaticFields, ___WhiteChars_3)); }
	inline CharU5BU5D_t3528271667* get_WhiteChars_3() const { return ___WhiteChars_3; }
	inline CharU5BU5D_t3528271667** get_address_of_WhiteChars_3() { return &___WhiteChars_3; }
	inline void set_WhiteChars_3(CharU5BU5D_t3528271667* value)
	{
		___WhiteChars_3 = value;
		Il2CppCodeGenWriteBarrier((&___WhiteChars_3), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STRING_T_H
struct Il2CppArrayBounds;
#ifndef RUNTIMEARRAY_H
#define RUNTIMEARRAY_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Array

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMEARRAY_H
#ifndef BINDER_T2999457153_H
#define BINDER_T2999457153_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.Binder
struct  Binder_t2999457153  : public RuntimeObject
{
public:

public:
};

struct Binder_t2999457153_StaticFields
{
public:
	// System.Reflection.Binder System.Reflection.Binder::default_binder
	Binder_t2999457153 * ___default_binder_0;

public:
	inline static int32_t get_offset_of_default_binder_0() { return static_cast<int32_t>(offsetof(Binder_t2999457153_StaticFields, ___default_binder_0)); }
	inline Binder_t2999457153 * get_default_binder_0() const { return ___default_binder_0; }
	inline Binder_t2999457153 ** get_address_of_default_binder_0() { return &___default_binder_0; }
	inline void set_default_binder_0(Binder_t2999457153 * value)
	{
		___default_binder_0 = value;
		Il2CppCodeGenWriteBarrier((&___default_binder_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BINDER_T2999457153_H
#ifndef SETUPCOROUTINE_T2062820429_H
#define SETUPCOROUTINE_T2062820429_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.SetupCoroutine
struct  SetupCoroutine_t2062820429  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SETUPCOROUTINE_T2062820429_H
#ifndef ATTRIBUTE_T861562559_H
#define ATTRIBUTE_T861562559_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Attribute
struct  Attribute_t861562559  : public RuntimeObject
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ATTRIBUTE_T861562559_H
#ifndef CULTUREINFO_T4157843068_H
#define CULTUREINFO_T4157843068_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Globalization.CultureInfo
struct  CultureInfo_t4157843068  : public RuntimeObject
{
public:
	// System.Boolean System.Globalization.CultureInfo::m_isReadOnly
	bool ___m_isReadOnly_7;
	// System.Int32 System.Globalization.CultureInfo::cultureID
	int32_t ___cultureID_8;
	// System.Int32 System.Globalization.CultureInfo::parent_lcid
	int32_t ___parent_lcid_9;
	// System.Int32 System.Globalization.CultureInfo::specific_lcid
	int32_t ___specific_lcid_10;
	// System.Int32 System.Globalization.CultureInfo::datetime_index
	int32_t ___datetime_index_11;
	// System.Int32 System.Globalization.CultureInfo::number_index
	int32_t ___number_index_12;
	// System.Boolean System.Globalization.CultureInfo::m_useUserOverride
	bool ___m_useUserOverride_13;
	// System.Globalization.NumberFormatInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::numInfo
	NumberFormatInfo_t435877138 * ___numInfo_14;
	// System.Globalization.DateTimeFormatInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::dateTimeInfo
	DateTimeFormatInfo_t2405853701 * ___dateTimeInfo_15;
	// System.Globalization.TextInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::textInfo
	TextInfo_t3810425522 * ___textInfo_16;
	// System.String System.Globalization.CultureInfo::m_name
	String_t* ___m_name_17;
	// System.String System.Globalization.CultureInfo::displayname
	String_t* ___displayname_18;
	// System.String System.Globalization.CultureInfo::englishname
	String_t* ___englishname_19;
	// System.String System.Globalization.CultureInfo::nativename
	String_t* ___nativename_20;
	// System.String System.Globalization.CultureInfo::iso3lang
	String_t* ___iso3lang_21;
	// System.String System.Globalization.CultureInfo::iso2lang
	String_t* ___iso2lang_22;
	// System.String System.Globalization.CultureInfo::icu_name
	String_t* ___icu_name_23;
	// System.String System.Globalization.CultureInfo::win3lang
	String_t* ___win3lang_24;
	// System.String System.Globalization.CultureInfo::territory
	String_t* ___territory_25;
	// System.Globalization.CompareInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::compareInfo
	CompareInfo_t1092934962 * ___compareInfo_26;
	// System.Int32* System.Globalization.CultureInfo::calendar_data
	int32_t* ___calendar_data_27;
	// System.Void* System.Globalization.CultureInfo::textinfo_data
	void* ___textinfo_data_28;
	// System.Globalization.Calendar[] System.Globalization.CultureInfo::optional_calendars
	CalendarU5BU5D_t3985046076* ___optional_calendars_29;
	// System.Globalization.CultureInfo System.Globalization.CultureInfo::parent_culture
	CultureInfo_t4157843068 * ___parent_culture_30;
	// System.Int32 System.Globalization.CultureInfo::m_dataItem
	int32_t ___m_dataItem_31;
	// System.Globalization.Calendar System.Globalization.CultureInfo::calendar
	Calendar_t1661121569 * ___calendar_32;
	// System.Boolean System.Globalization.CultureInfo::constructed
	bool ___constructed_33;
	// System.Byte[] System.Globalization.CultureInfo::cached_serialized_form
	ByteU5BU5D_t4116647657* ___cached_serialized_form_34;

public:
	inline static int32_t get_offset_of_m_isReadOnly_7() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___m_isReadOnly_7)); }
	inline bool get_m_isReadOnly_7() const { return ___m_isReadOnly_7; }
	inline bool* get_address_of_m_isReadOnly_7() { return &___m_isReadOnly_7; }
	inline void set_m_isReadOnly_7(bool value)
	{
		___m_isReadOnly_7 = value;
	}

	inline static int32_t get_offset_of_cultureID_8() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___cultureID_8)); }
	inline int32_t get_cultureID_8() const { return ___cultureID_8; }
	inline int32_t* get_address_of_cultureID_8() { return &___cultureID_8; }
	inline void set_cultureID_8(int32_t value)
	{
		___cultureID_8 = value;
	}

	inline static int32_t get_offset_of_parent_lcid_9() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___parent_lcid_9)); }
	inline int32_t get_parent_lcid_9() const { return ___parent_lcid_9; }
	inline int32_t* get_address_of_parent_lcid_9() { return &___parent_lcid_9; }
	inline void set_parent_lcid_9(int32_t value)
	{
		___parent_lcid_9 = value;
	}

	inline static int32_t get_offset_of_specific_lcid_10() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___specific_lcid_10)); }
	inline int32_t get_specific_lcid_10() const { return ___specific_lcid_10; }
	inline int32_t* get_address_of_specific_lcid_10() { return &___specific_lcid_10; }
	inline void set_specific_lcid_10(int32_t value)
	{
		___specific_lcid_10 = value;
	}

	inline static int32_t get_offset_of_datetime_index_11() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___datetime_index_11)); }
	inline int32_t get_datetime_index_11() const { return ___datetime_index_11; }
	inline int32_t* get_address_of_datetime_index_11() { return &___datetime_index_11; }
	inline void set_datetime_index_11(int32_t value)
	{
		___datetime_index_11 = value;
	}

	inline static int32_t get_offset_of_number_index_12() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___number_index_12)); }
	inline int32_t get_number_index_12() const { return ___number_index_12; }
	inline int32_t* get_address_of_number_index_12() { return &___number_index_12; }
	inline void set_number_index_12(int32_t value)
	{
		___number_index_12 = value;
	}

	inline static int32_t get_offset_of_m_useUserOverride_13() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___m_useUserOverride_13)); }
	inline bool get_m_useUserOverride_13() const { return ___m_useUserOverride_13; }
	inline bool* get_address_of_m_useUserOverride_13() { return &___m_useUserOverride_13; }
	inline void set_m_useUserOverride_13(bool value)
	{
		___m_useUserOverride_13 = value;
	}

	inline static int32_t get_offset_of_numInfo_14() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___numInfo_14)); }
	inline NumberFormatInfo_t435877138 * get_numInfo_14() const { return ___numInfo_14; }
	inline NumberFormatInfo_t435877138 ** get_address_of_numInfo_14() { return &___numInfo_14; }
	inline void set_numInfo_14(NumberFormatInfo_t435877138 * value)
	{
		___numInfo_14 = value;
		Il2CppCodeGenWriteBarrier((&___numInfo_14), value);
	}

	inline static int32_t get_offset_of_dateTimeInfo_15() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___dateTimeInfo_15)); }
	inline DateTimeFormatInfo_t2405853701 * get_dateTimeInfo_15() const { return ___dateTimeInfo_15; }
	inline DateTimeFormatInfo_t2405853701 ** get_address_of_dateTimeInfo_15() { return &___dateTimeInfo_15; }
	inline void set_dateTimeInfo_15(DateTimeFormatInfo_t2405853701 * value)
	{
		___dateTimeInfo_15 = value;
		Il2CppCodeGenWriteBarrier((&___dateTimeInfo_15), value);
	}

	inline static int32_t get_offset_of_textInfo_16() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___textInfo_16)); }
	inline TextInfo_t3810425522 * get_textInfo_16() const { return ___textInfo_16; }
	inline TextInfo_t3810425522 ** get_address_of_textInfo_16() { return &___textInfo_16; }
	inline void set_textInfo_16(TextInfo_t3810425522 * value)
	{
		___textInfo_16 = value;
		Il2CppCodeGenWriteBarrier((&___textInfo_16), value);
	}

	inline static int32_t get_offset_of_m_name_17() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___m_name_17)); }
	inline String_t* get_m_name_17() const { return ___m_name_17; }
	inline String_t** get_address_of_m_name_17() { return &___m_name_17; }
	inline void set_m_name_17(String_t* value)
	{
		___m_name_17 = value;
		Il2CppCodeGenWriteBarrier((&___m_name_17), value);
	}

	inline static int32_t get_offset_of_displayname_18() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___displayname_18)); }
	inline String_t* get_displayname_18() const { return ___displayname_18; }
	inline String_t** get_address_of_displayname_18() { return &___displayname_18; }
	inline void set_displayname_18(String_t* value)
	{
		___displayname_18 = value;
		Il2CppCodeGenWriteBarrier((&___displayname_18), value);
	}

	inline static int32_t get_offset_of_englishname_19() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___englishname_19)); }
	inline String_t* get_englishname_19() const { return ___englishname_19; }
	inline String_t** get_address_of_englishname_19() { return &___englishname_19; }
	inline void set_englishname_19(String_t* value)
	{
		___englishname_19 = value;
		Il2CppCodeGenWriteBarrier((&___englishname_19), value);
	}

	inline static int32_t get_offset_of_nativename_20() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___nativename_20)); }
	inline String_t* get_nativename_20() const { return ___nativename_20; }
	inline String_t** get_address_of_nativename_20() { return &___nativename_20; }
	inline void set_nativename_20(String_t* value)
	{
		___nativename_20 = value;
		Il2CppCodeGenWriteBarrier((&___nativename_20), value);
	}

	inline static int32_t get_offset_of_iso3lang_21() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___iso3lang_21)); }
	inline String_t* get_iso3lang_21() const { return ___iso3lang_21; }
	inline String_t** get_address_of_iso3lang_21() { return &___iso3lang_21; }
	inline void set_iso3lang_21(String_t* value)
	{
		___iso3lang_21 = value;
		Il2CppCodeGenWriteBarrier((&___iso3lang_21), value);
	}

	inline static int32_t get_offset_of_iso2lang_22() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___iso2lang_22)); }
	inline String_t* get_iso2lang_22() const { return ___iso2lang_22; }
	inline String_t** get_address_of_iso2lang_22() { return &___iso2lang_22; }
	inline void set_iso2lang_22(String_t* value)
	{
		___iso2lang_22 = value;
		Il2CppCodeGenWriteBarrier((&___iso2lang_22), value);
	}

	inline static int32_t get_offset_of_icu_name_23() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___icu_name_23)); }
	inline String_t* get_icu_name_23() const { return ___icu_name_23; }
	inline String_t** get_address_of_icu_name_23() { return &___icu_name_23; }
	inline void set_icu_name_23(String_t* value)
	{
		___icu_name_23 = value;
		Il2CppCodeGenWriteBarrier((&___icu_name_23), value);
	}

	inline static int32_t get_offset_of_win3lang_24() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___win3lang_24)); }
	inline String_t* get_win3lang_24() const { return ___win3lang_24; }
	inline String_t** get_address_of_win3lang_24() { return &___win3lang_24; }
	inline void set_win3lang_24(String_t* value)
	{
		___win3lang_24 = value;
		Il2CppCodeGenWriteBarrier((&___win3lang_24), value);
	}

	inline static int32_t get_offset_of_territory_25() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___territory_25)); }
	inline String_t* get_territory_25() const { return ___territory_25; }
	inline String_t** get_address_of_territory_25() { return &___territory_25; }
	inline void set_territory_25(String_t* value)
	{
		___territory_25 = value;
		Il2CppCodeGenWriteBarrier((&___territory_25), value);
	}

	inline static int32_t get_offset_of_compareInfo_26() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___compareInfo_26)); }
	inline CompareInfo_t1092934962 * get_compareInfo_26() const { return ___compareInfo_26; }
	inline CompareInfo_t1092934962 ** get_address_of_compareInfo_26() { return &___compareInfo_26; }
	inline void set_compareInfo_26(CompareInfo_t1092934962 * value)
	{
		___compareInfo_26 = value;
		Il2CppCodeGenWriteBarrier((&___compareInfo_26), value);
	}

	inline static int32_t get_offset_of_calendar_data_27() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___calendar_data_27)); }
	inline int32_t* get_calendar_data_27() const { return ___calendar_data_27; }
	inline int32_t** get_address_of_calendar_data_27() { return &___calendar_data_27; }
	inline void set_calendar_data_27(int32_t* value)
	{
		___calendar_data_27 = value;
	}

	inline static int32_t get_offset_of_textinfo_data_28() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___textinfo_data_28)); }
	inline void* get_textinfo_data_28() const { return ___textinfo_data_28; }
	inline void** get_address_of_textinfo_data_28() { return &___textinfo_data_28; }
	inline void set_textinfo_data_28(void* value)
	{
		___textinfo_data_28 = value;
	}

	inline static int32_t get_offset_of_optional_calendars_29() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___optional_calendars_29)); }
	inline CalendarU5BU5D_t3985046076* get_optional_calendars_29() const { return ___optional_calendars_29; }
	inline CalendarU5BU5D_t3985046076** get_address_of_optional_calendars_29() { return &___optional_calendars_29; }
	inline void set_optional_calendars_29(CalendarU5BU5D_t3985046076* value)
	{
		___optional_calendars_29 = value;
		Il2CppCodeGenWriteBarrier((&___optional_calendars_29), value);
	}

	inline static int32_t get_offset_of_parent_culture_30() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___parent_culture_30)); }
	inline CultureInfo_t4157843068 * get_parent_culture_30() const { return ___parent_culture_30; }
	inline CultureInfo_t4157843068 ** get_address_of_parent_culture_30() { return &___parent_culture_30; }
	inline void set_parent_culture_30(CultureInfo_t4157843068 * value)
	{
		___parent_culture_30 = value;
		Il2CppCodeGenWriteBarrier((&___parent_culture_30), value);
	}

	inline static int32_t get_offset_of_m_dataItem_31() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___m_dataItem_31)); }
	inline int32_t get_m_dataItem_31() const { return ___m_dataItem_31; }
	inline int32_t* get_address_of_m_dataItem_31() { return &___m_dataItem_31; }
	inline void set_m_dataItem_31(int32_t value)
	{
		___m_dataItem_31 = value;
	}

	inline static int32_t get_offset_of_calendar_32() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___calendar_32)); }
	inline Calendar_t1661121569 * get_calendar_32() const { return ___calendar_32; }
	inline Calendar_t1661121569 ** get_address_of_calendar_32() { return &___calendar_32; }
	inline void set_calendar_32(Calendar_t1661121569 * value)
	{
		___calendar_32 = value;
		Il2CppCodeGenWriteBarrier((&___calendar_32), value);
	}

	inline static int32_t get_offset_of_constructed_33() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___constructed_33)); }
	inline bool get_constructed_33() const { return ___constructed_33; }
	inline bool* get_address_of_constructed_33() { return &___constructed_33; }
	inline void set_constructed_33(bool value)
	{
		___constructed_33 = value;
	}

	inline static int32_t get_offset_of_cached_serialized_form_34() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068, ___cached_serialized_form_34)); }
	inline ByteU5BU5D_t4116647657* get_cached_serialized_form_34() const { return ___cached_serialized_form_34; }
	inline ByteU5BU5D_t4116647657** get_address_of_cached_serialized_form_34() { return &___cached_serialized_form_34; }
	inline void set_cached_serialized_form_34(ByteU5BU5D_t4116647657* value)
	{
		___cached_serialized_form_34 = value;
		Il2CppCodeGenWriteBarrier((&___cached_serialized_form_34), value);
	}
};

struct CultureInfo_t4157843068_StaticFields
{
public:
	// System.Globalization.CultureInfo modreq(System.Runtime.CompilerServices.IsVolatile) System.Globalization.CultureInfo::invariant_culture_info
	CultureInfo_t4157843068 * ___invariant_culture_info_4;
	// System.Object System.Globalization.CultureInfo::shared_table_lock
	RuntimeObject * ___shared_table_lock_5;
	// System.Int32 System.Globalization.CultureInfo::BootstrapCultureID
	int32_t ___BootstrapCultureID_6;
	// System.String System.Globalization.CultureInfo::MSG_READONLY
	String_t* ___MSG_READONLY_35;
	// System.Collections.Hashtable System.Globalization.CultureInfo::shared_by_number
	Hashtable_t1853889766 * ___shared_by_number_36;
	// System.Collections.Hashtable System.Globalization.CultureInfo::shared_by_name
	Hashtable_t1853889766 * ___shared_by_name_37;
	// System.Collections.Generic.Dictionary`2<System.String,System.Int32> System.Globalization.CultureInfo::<>f__switch$map19
	Dictionary_2_t2736202052 * ___U3CU3Ef__switchU24map19_38;
	// System.Collections.Generic.Dictionary`2<System.String,System.Int32> System.Globalization.CultureInfo::<>f__switch$map1A
	Dictionary_2_t2736202052 * ___U3CU3Ef__switchU24map1A_39;

public:
	inline static int32_t get_offset_of_invariant_culture_info_4() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068_StaticFields, ___invariant_culture_info_4)); }
	inline CultureInfo_t4157843068 * get_invariant_culture_info_4() const { return ___invariant_culture_info_4; }
	inline CultureInfo_t4157843068 ** get_address_of_invariant_culture_info_4() { return &___invariant_culture_info_4; }
	inline void set_invariant_culture_info_4(CultureInfo_t4157843068 * value)
	{
		___invariant_culture_info_4 = value;
		Il2CppCodeGenWriteBarrier((&___invariant_culture_info_4), value);
	}

	inline static int32_t get_offset_of_shared_table_lock_5() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068_StaticFields, ___shared_table_lock_5)); }
	inline RuntimeObject * get_shared_table_lock_5() const { return ___shared_table_lock_5; }
	inline RuntimeObject ** get_address_of_shared_table_lock_5() { return &___shared_table_lock_5; }
	inline void set_shared_table_lock_5(RuntimeObject * value)
	{
		___shared_table_lock_5 = value;
		Il2CppCodeGenWriteBarrier((&___shared_table_lock_5), value);
	}

	inline static int32_t get_offset_of_BootstrapCultureID_6() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068_StaticFields, ___BootstrapCultureID_6)); }
	inline int32_t get_BootstrapCultureID_6() const { return ___BootstrapCultureID_6; }
	inline int32_t* get_address_of_BootstrapCultureID_6() { return &___BootstrapCultureID_6; }
	inline void set_BootstrapCultureID_6(int32_t value)
	{
		___BootstrapCultureID_6 = value;
	}

	inline static int32_t get_offset_of_MSG_READONLY_35() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068_StaticFields, ___MSG_READONLY_35)); }
	inline String_t* get_MSG_READONLY_35() const { return ___MSG_READONLY_35; }
	inline String_t** get_address_of_MSG_READONLY_35() { return &___MSG_READONLY_35; }
	inline void set_MSG_READONLY_35(String_t* value)
	{
		___MSG_READONLY_35 = value;
		Il2CppCodeGenWriteBarrier((&___MSG_READONLY_35), value);
	}

	inline static int32_t get_offset_of_shared_by_number_36() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068_StaticFields, ___shared_by_number_36)); }
	inline Hashtable_t1853889766 * get_shared_by_number_36() const { return ___shared_by_number_36; }
	inline Hashtable_t1853889766 ** get_address_of_shared_by_number_36() { return &___shared_by_number_36; }
	inline void set_shared_by_number_36(Hashtable_t1853889766 * value)
	{
		___shared_by_number_36 = value;
		Il2CppCodeGenWriteBarrier((&___shared_by_number_36), value);
	}

	inline static int32_t get_offset_of_shared_by_name_37() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068_StaticFields, ___shared_by_name_37)); }
	inline Hashtable_t1853889766 * get_shared_by_name_37() const { return ___shared_by_name_37; }
	inline Hashtable_t1853889766 ** get_address_of_shared_by_name_37() { return &___shared_by_name_37; }
	inline void set_shared_by_name_37(Hashtable_t1853889766 * value)
	{
		___shared_by_name_37 = value;
		Il2CppCodeGenWriteBarrier((&___shared_by_name_37), value);
	}

	inline static int32_t get_offset_of_U3CU3Ef__switchU24map19_38() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068_StaticFields, ___U3CU3Ef__switchU24map19_38)); }
	inline Dictionary_2_t2736202052 * get_U3CU3Ef__switchU24map19_38() const { return ___U3CU3Ef__switchU24map19_38; }
	inline Dictionary_2_t2736202052 ** get_address_of_U3CU3Ef__switchU24map19_38() { return &___U3CU3Ef__switchU24map19_38; }
	inline void set_U3CU3Ef__switchU24map19_38(Dictionary_2_t2736202052 * value)
	{
		___U3CU3Ef__switchU24map19_38 = value;
		Il2CppCodeGenWriteBarrier((&___U3CU3Ef__switchU24map19_38), value);
	}

	inline static int32_t get_offset_of_U3CU3Ef__switchU24map1A_39() { return static_cast<int32_t>(offsetof(CultureInfo_t4157843068_StaticFields, ___U3CU3Ef__switchU24map1A_39)); }
	inline Dictionary_2_t2736202052 * get_U3CU3Ef__switchU24map1A_39() const { return ___U3CU3Ef__switchU24map1A_39; }
	inline Dictionary_2_t2736202052 ** get_address_of_U3CU3Ef__switchU24map1A_39() { return &___U3CU3Ef__switchU24map1A_39; }
	inline void set_U3CU3Ef__switchU24map1A_39(Dictionary_2_t2736202052 * value)
	{
		___U3CU3Ef__switchU24map1A_39 = value;
		Il2CppCodeGenWriteBarrier((&___U3CU3Ef__switchU24map1A_39), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CULTUREINFO_T4157843068_H
#ifndef VOID_T1185182177_H
#define VOID_T1185182177_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Void
struct  Void_t1185182177 
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VOID_T1185182177_H
#ifndef COLOR_T2555686324_H
#define COLOR_T2555686324_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Color
struct  Color_t2555686324 
{
public:
	// System.Single UnityEngine.Color::r
	float ___r_0;
	// System.Single UnityEngine.Color::g
	float ___g_1;
	// System.Single UnityEngine.Color::b
	float ___b_2;
	// System.Single UnityEngine.Color::a
	float ___a_3;

public:
	inline static int32_t get_offset_of_r_0() { return static_cast<int32_t>(offsetof(Color_t2555686324, ___r_0)); }
	inline float get_r_0() const { return ___r_0; }
	inline float* get_address_of_r_0() { return &___r_0; }
	inline void set_r_0(float value)
	{
		___r_0 = value;
	}

	inline static int32_t get_offset_of_g_1() { return static_cast<int32_t>(offsetof(Color_t2555686324, ___g_1)); }
	inline float get_g_1() const { return ___g_1; }
	inline float* get_address_of_g_1() { return &___g_1; }
	inline void set_g_1(float value)
	{
		___g_1 = value;
	}

	inline static int32_t get_offset_of_b_2() { return static_cast<int32_t>(offsetof(Color_t2555686324, ___b_2)); }
	inline float get_b_2() const { return ___b_2; }
	inline float* get_address_of_b_2() { return &___b_2; }
	inline void set_b_2(float value)
	{
		___b_2 = value;
	}

	inline static int32_t get_offset_of_a_3() { return static_cast<int32_t>(offsetof(Color_t2555686324, ___a_3)); }
	inline float get_a_3() const { return ___a_3; }
	inline float* get_address_of_a_3() { return &___a_3; }
	inline void set_a_3(float value)
	{
		___a_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COLOR_T2555686324_H
#ifndef SERIALIZEFIELD_T3286833614_H
#define SERIALIZEFIELD_T3286833614_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.SerializeField
struct  SerializeField_t3286833614  : public Attribute_t861562559
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SERIALIZEFIELD_T3286833614_H
#ifndef TYPEINFERENCERULEATTRIBUTE_T254868554_H
#define TYPEINFERENCERULEATTRIBUTE_T254868554_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngineInternal.TypeInferenceRuleAttribute
struct  TypeInferenceRuleAttribute_t254868554  : public Attribute_t861562559
{
public:
	// System.String UnityEngineInternal.TypeInferenceRuleAttribute::_rule
	String_t* ____rule_0;

public:
	inline static int32_t get_offset_of__rule_0() { return static_cast<int32_t>(offsetof(TypeInferenceRuleAttribute_t254868554, ____rule_0)); }
	inline String_t* get__rule_0() const { return ____rule_0; }
	inline String_t** get_address_of__rule_0() { return &____rule_0; }
	inline void set__rule_0(String_t* value)
	{
		____rule_0 = value;
		Il2CppCodeGenWriteBarrier((&____rule_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TYPEINFERENCERULEATTRIBUTE_T254868554_H
#ifndef SERIALIZEPRIVATEVARIABLES_T3872960625_H
#define SERIALIZEPRIVATEVARIABLES_T3872960625_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.SerializePrivateVariables
struct  SerializePrivateVariables_t3872960625  : public Attribute_t861562559
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SERIALIZEPRIVATEVARIABLES_T3872960625_H
#ifndef MATRIX4X4_T1817901843_H
#define MATRIX4X4_T1817901843_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Matrix4x4
struct  Matrix4x4_t1817901843 
{
public:
	// System.Single UnityEngine.Matrix4x4::m00
	float ___m00_0;
	// System.Single UnityEngine.Matrix4x4::m10
	float ___m10_1;
	// System.Single UnityEngine.Matrix4x4::m20
	float ___m20_2;
	// System.Single UnityEngine.Matrix4x4::m30
	float ___m30_3;
	// System.Single UnityEngine.Matrix4x4::m01
	float ___m01_4;
	// System.Single UnityEngine.Matrix4x4::m11
	float ___m11_5;
	// System.Single UnityEngine.Matrix4x4::m21
	float ___m21_6;
	// System.Single UnityEngine.Matrix4x4::m31
	float ___m31_7;
	// System.Single UnityEngine.Matrix4x4::m02
	float ___m02_8;
	// System.Single UnityEngine.Matrix4x4::m12
	float ___m12_9;
	// System.Single UnityEngine.Matrix4x4::m22
	float ___m22_10;
	// System.Single UnityEngine.Matrix4x4::m32
	float ___m32_11;
	// System.Single UnityEngine.Matrix4x4::m03
	float ___m03_12;
	// System.Single UnityEngine.Matrix4x4::m13
	float ___m13_13;
	// System.Single UnityEngine.Matrix4x4::m23
	float ___m23_14;
	// System.Single UnityEngine.Matrix4x4::m33
	float ___m33_15;

public:
	inline static int32_t get_offset_of_m00_0() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m00_0)); }
	inline float get_m00_0() const { return ___m00_0; }
	inline float* get_address_of_m00_0() { return &___m00_0; }
	inline void set_m00_0(float value)
	{
		___m00_0 = value;
	}

	inline static int32_t get_offset_of_m10_1() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m10_1)); }
	inline float get_m10_1() const { return ___m10_1; }
	inline float* get_address_of_m10_1() { return &___m10_1; }
	inline void set_m10_1(float value)
	{
		___m10_1 = value;
	}

	inline static int32_t get_offset_of_m20_2() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m20_2)); }
	inline float get_m20_2() const { return ___m20_2; }
	inline float* get_address_of_m20_2() { return &___m20_2; }
	inline void set_m20_2(float value)
	{
		___m20_2 = value;
	}

	inline static int32_t get_offset_of_m30_3() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m30_3)); }
	inline float get_m30_3() const { return ___m30_3; }
	inline float* get_address_of_m30_3() { return &___m30_3; }
	inline void set_m30_3(float value)
	{
		___m30_3 = value;
	}

	inline static int32_t get_offset_of_m01_4() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m01_4)); }
	inline float get_m01_4() const { return ___m01_4; }
	inline float* get_address_of_m01_4() { return &___m01_4; }
	inline void set_m01_4(float value)
	{
		___m01_4 = value;
	}

	inline static int32_t get_offset_of_m11_5() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m11_5)); }
	inline float get_m11_5() const { return ___m11_5; }
	inline float* get_address_of_m11_5() { return &___m11_5; }
	inline void set_m11_5(float value)
	{
		___m11_5 = value;
	}

	inline static int32_t get_offset_of_m21_6() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m21_6)); }
	inline float get_m21_6() const { return ___m21_6; }
	inline float* get_address_of_m21_6() { return &___m21_6; }
	inline void set_m21_6(float value)
	{
		___m21_6 = value;
	}

	inline static int32_t get_offset_of_m31_7() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m31_7)); }
	inline float get_m31_7() const { return ___m31_7; }
	inline float* get_address_of_m31_7() { return &___m31_7; }
	inline void set_m31_7(float value)
	{
		___m31_7 = value;
	}

	inline static int32_t get_offset_of_m02_8() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m02_8)); }
	inline float get_m02_8() const { return ___m02_8; }
	inline float* get_address_of_m02_8() { return &___m02_8; }
	inline void set_m02_8(float value)
	{
		___m02_8 = value;
	}

	inline static int32_t get_offset_of_m12_9() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m12_9)); }
	inline float get_m12_9() const { return ___m12_9; }
	inline float* get_address_of_m12_9() { return &___m12_9; }
	inline void set_m12_9(float value)
	{
		___m12_9 = value;
	}

	inline static int32_t get_offset_of_m22_10() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m22_10)); }
	inline float get_m22_10() const { return ___m22_10; }
	inline float* get_address_of_m22_10() { return &___m22_10; }
	inline void set_m22_10(float value)
	{
		___m22_10 = value;
	}

	inline static int32_t get_offset_of_m32_11() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m32_11)); }
	inline float get_m32_11() const { return ___m32_11; }
	inline float* get_address_of_m32_11() { return &___m32_11; }
	inline void set_m32_11(float value)
	{
		___m32_11 = value;
	}

	inline static int32_t get_offset_of_m03_12() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m03_12)); }
	inline float get_m03_12() const { return ___m03_12; }
	inline float* get_address_of_m03_12() { return &___m03_12; }
	inline void set_m03_12(float value)
	{
		___m03_12 = value;
	}

	inline static int32_t get_offset_of_m13_13() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m13_13)); }
	inline float get_m13_13() const { return ___m13_13; }
	inline float* get_address_of_m13_13() { return &___m13_13; }
	inline void set_m13_13(float value)
	{
		___m13_13 = value;
	}

	inline static int32_t get_offset_of_m23_14() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m23_14)); }
	inline float get_m23_14() const { return ___m23_14; }
	inline float* get_address_of_m23_14() { return &___m23_14; }
	inline void set_m23_14(float value)
	{
		___m23_14 = value;
	}

	inline static int32_t get_offset_of_m33_15() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843, ___m33_15)); }
	inline float get_m33_15() const { return ___m33_15; }
	inline float* get_address_of_m33_15() { return &___m33_15; }
	inline void set_m33_15(float value)
	{
		___m33_15 = value;
	}
};

struct Matrix4x4_t1817901843_StaticFields
{
public:
	// UnityEngine.Matrix4x4 UnityEngine.Matrix4x4::zeroMatrix
	Matrix4x4_t1817901843  ___zeroMatrix_16;
	// UnityEngine.Matrix4x4 UnityEngine.Matrix4x4::identityMatrix
	Matrix4x4_t1817901843  ___identityMatrix_17;

public:
	inline static int32_t get_offset_of_zeroMatrix_16() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843_StaticFields, ___zeroMatrix_16)); }
	inline Matrix4x4_t1817901843  get_zeroMatrix_16() const { return ___zeroMatrix_16; }
	inline Matrix4x4_t1817901843 * get_address_of_zeroMatrix_16() { return &___zeroMatrix_16; }
	inline void set_zeroMatrix_16(Matrix4x4_t1817901843  value)
	{
		___zeroMatrix_16 = value;
	}

	inline static int32_t get_offset_of_identityMatrix_17() { return static_cast<int32_t>(offsetof(Matrix4x4_t1817901843_StaticFields, ___identityMatrix_17)); }
	inline Matrix4x4_t1817901843  get_identityMatrix_17() const { return ___identityMatrix_17; }
	inline Matrix4x4_t1817901843 * get_address_of_identityMatrix_17() { return &___identityMatrix_17; }
	inline void set_identityMatrix_17(Matrix4x4_t1817901843  value)
	{
		___identityMatrix_17 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MATRIX4X4_T1817901843_H
#ifndef GENERICSTACK_T1310059385_H
#define GENERICSTACK_T1310059385_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngineInternal.GenericStack
struct  GenericStack_t1310059385  : public Stack_t2329662280
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // GENERICSTACK_T1310059385_H
#ifndef WAITFORSECONDSREALTIME_T189548121_H
#define WAITFORSECONDSREALTIME_T189548121_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.WaitForSecondsRealtime
struct  WaitForSecondsRealtime_t189548121  : public CustomYieldInstruction_t1895667560
{
public:
	// System.Single UnityEngine.WaitForSecondsRealtime::waitTime
	float ___waitTime_0;

public:
	inline static int32_t get_offset_of_waitTime_0() { return static_cast<int32_t>(offsetof(WaitForSecondsRealtime_t189548121, ___waitTime_0)); }
	inline float get_waitTime_0() const { return ___waitTime_0; }
	inline float* get_address_of_waitTime_0() { return &___waitTime_0; }
	inline void set_waitTime_0(float value)
	{
		___waitTime_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // WAITFORSECONDSREALTIME_T189548121_H
#ifndef VECTOR3INT_T741115188_H
#define VECTOR3INT_T741115188_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Vector3Int
struct  Vector3Int_t741115188 
{
public:
	// System.Int32 UnityEngine.Vector3Int::m_X
	int32_t ___m_X_0;
	// System.Int32 UnityEngine.Vector3Int::m_Y
	int32_t ___m_Y_1;
	// System.Int32 UnityEngine.Vector3Int::m_Z
	int32_t ___m_Z_2;

public:
	inline static int32_t get_offset_of_m_X_0() { return static_cast<int32_t>(offsetof(Vector3Int_t741115188, ___m_X_0)); }
	inline int32_t get_m_X_0() const { return ___m_X_0; }
	inline int32_t* get_address_of_m_X_0() { return &___m_X_0; }
	inline void set_m_X_0(int32_t value)
	{
		___m_X_0 = value;
	}

	inline static int32_t get_offset_of_m_Y_1() { return static_cast<int32_t>(offsetof(Vector3Int_t741115188, ___m_Y_1)); }
	inline int32_t get_m_Y_1() const { return ___m_Y_1; }
	inline int32_t* get_address_of_m_Y_1() { return &___m_Y_1; }
	inline void set_m_Y_1(int32_t value)
	{
		___m_Y_1 = value;
	}

	inline static int32_t get_offset_of_m_Z_2() { return static_cast<int32_t>(offsetof(Vector3Int_t741115188, ___m_Z_2)); }
	inline int32_t get_m_Z_2() const { return ___m_Z_2; }
	inline int32_t* get_address_of_m_Z_2() { return &___m_Z_2; }
	inline void set_m_Z_2(int32_t value)
	{
		___m_Z_2 = value;
	}
};

struct Vector3Int_t741115188_StaticFields
{
public:
	// UnityEngine.Vector3Int UnityEngine.Vector3Int::s_Zero
	Vector3Int_t741115188  ___s_Zero_3;
	// UnityEngine.Vector3Int UnityEngine.Vector3Int::s_One
	Vector3Int_t741115188  ___s_One_4;
	// UnityEngine.Vector3Int UnityEngine.Vector3Int::s_Up
	Vector3Int_t741115188  ___s_Up_5;
	// UnityEngine.Vector3Int UnityEngine.Vector3Int::s_Down
	Vector3Int_t741115188  ___s_Down_6;
	// UnityEngine.Vector3Int UnityEngine.Vector3Int::s_Left
	Vector3Int_t741115188  ___s_Left_7;
	// UnityEngine.Vector3Int UnityEngine.Vector3Int::s_Right
	Vector3Int_t741115188  ___s_Right_8;

public:
	inline static int32_t get_offset_of_s_Zero_3() { return static_cast<int32_t>(offsetof(Vector3Int_t741115188_StaticFields, ___s_Zero_3)); }
	inline Vector3Int_t741115188  get_s_Zero_3() const { return ___s_Zero_3; }
	inline Vector3Int_t741115188 * get_address_of_s_Zero_3() { return &___s_Zero_3; }
	inline void set_s_Zero_3(Vector3Int_t741115188  value)
	{
		___s_Zero_3 = value;
	}

	inline static int32_t get_offset_of_s_One_4() { return static_cast<int32_t>(offsetof(Vector3Int_t741115188_StaticFields, ___s_One_4)); }
	inline Vector3Int_t741115188  get_s_One_4() const { return ___s_One_4; }
	inline Vector3Int_t741115188 * get_address_of_s_One_4() { return &___s_One_4; }
	inline void set_s_One_4(Vector3Int_t741115188  value)
	{
		___s_One_4 = value;
	}

	inline static int32_t get_offset_of_s_Up_5() { return static_cast<int32_t>(offsetof(Vector3Int_t741115188_StaticFields, ___s_Up_5)); }
	inline Vector3Int_t741115188  get_s_Up_5() const { return ___s_Up_5; }
	inline Vector3Int_t741115188 * get_address_of_s_Up_5() { return &___s_Up_5; }
	inline void set_s_Up_5(Vector3Int_t741115188  value)
	{
		___s_Up_5 = value;
	}

	inline static int32_t get_offset_of_s_Down_6() { return static_cast<int32_t>(offsetof(Vector3Int_t741115188_StaticFields, ___s_Down_6)); }
	inline Vector3Int_t741115188  get_s_Down_6() const { return ___s_Down_6; }
	inline Vector3Int_t741115188 * get_address_of_s_Down_6() { return &___s_Down_6; }
	inline void set_s_Down_6(Vector3Int_t741115188  value)
	{
		___s_Down_6 = value;
	}

	inline static int32_t get_offset_of_s_Left_7() { return static_cast<int32_t>(offsetof(Vector3Int_t741115188_StaticFields, ___s_Left_7)); }
	inline Vector3Int_t741115188  get_s_Left_7() const { return ___s_Left_7; }
	inline Vector3Int_t741115188 * get_address_of_s_Left_7() { return &___s_Left_7; }
	inline void set_s_Left_7(Vector3Int_t741115188  value)
	{
		___s_Left_7 = value;
	}

	inline static int32_t get_offset_of_s_Right_8() { return static_cast<int32_t>(offsetof(Vector3Int_t741115188_StaticFields, ___s_Right_8)); }
	inline Vector3Int_t741115188  get_s_Right_8() const { return ___s_Right_8; }
	inline Vector3Int_t741115188 * get_address_of_s_Right_8() { return &___s_Right_8; }
	inline void set_s_Right_8(Vector3Int_t741115188  value)
	{
		___s_Right_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VECTOR3INT_T741115188_H
#ifndef RANGEINT_T2094684618_H
#define RANGEINT_T2094684618_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.RangeInt
struct  RangeInt_t2094684618 
{
public:
	// System.Int32 UnityEngine.RangeInt::start
	int32_t ___start_0;
	// System.Int32 UnityEngine.RangeInt::length
	int32_t ___length_1;

public:
	inline static int32_t get_offset_of_start_0() { return static_cast<int32_t>(offsetof(RangeInt_t2094684618, ___start_0)); }
	inline int32_t get_start_0() const { return ___start_0; }
	inline int32_t* get_address_of_start_0() { return &___start_0; }
	inline void set_start_0(int32_t value)
	{
		___start_0 = value;
	}

	inline static int32_t get_offset_of_length_1() { return static_cast<int32_t>(offsetof(RangeInt_t2094684618, ___length_1)); }
	inline int32_t get_length_1() const { return ___length_1; }
	inline int32_t* get_address_of_length_1() { return &___length_1; }
	inline void set_length_1(int32_t value)
	{
		___length_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RANGEINT_T2094684618_H
#ifndef QUATERNION_T2301928331_H
#define QUATERNION_T2301928331_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Quaternion
struct  Quaternion_t2301928331 
{
public:
	// System.Single UnityEngine.Quaternion::x
	float ___x_0;
	// System.Single UnityEngine.Quaternion::y
	float ___y_1;
	// System.Single UnityEngine.Quaternion::z
	float ___z_2;
	// System.Single UnityEngine.Quaternion::w
	float ___w_3;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(Quaternion_t2301928331, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(Quaternion_t2301928331, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}

	inline static int32_t get_offset_of_z_2() { return static_cast<int32_t>(offsetof(Quaternion_t2301928331, ___z_2)); }
	inline float get_z_2() const { return ___z_2; }
	inline float* get_address_of_z_2() { return &___z_2; }
	inline void set_z_2(float value)
	{
		___z_2 = value;
	}

	inline static int32_t get_offset_of_w_3() { return static_cast<int32_t>(offsetof(Quaternion_t2301928331, ___w_3)); }
	inline float get_w_3() const { return ___w_3; }
	inline float* get_address_of_w_3() { return &___w_3; }
	inline void set_w_3(float value)
	{
		___w_3 = value;
	}
};

struct Quaternion_t2301928331_StaticFields
{
public:
	// UnityEngine.Quaternion UnityEngine.Quaternion::identityQuaternion
	Quaternion_t2301928331  ___identityQuaternion_4;

public:
	inline static int32_t get_offset_of_identityQuaternion_4() { return static_cast<int32_t>(offsetof(Quaternion_t2301928331_StaticFields, ___identityQuaternion_4)); }
	inline Quaternion_t2301928331  get_identityQuaternion_4() const { return ___identityQuaternion_4; }
	inline Quaternion_t2301928331 * get_address_of_identityQuaternion_4() { return &___identityQuaternion_4; }
	inline void set_identityQuaternion_4(Quaternion_t2301928331  value)
	{
		___identityQuaternion_4 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // QUATERNION_T2301928331_H
#ifndef VECTOR3_T3722313464_H
#define VECTOR3_T3722313464_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Vector3
struct  Vector3_t3722313464 
{
public:
	// System.Single UnityEngine.Vector3::x
	float ___x_1;
	// System.Single UnityEngine.Vector3::y
	float ___y_2;
	// System.Single UnityEngine.Vector3::z
	float ___z_3;

public:
	inline static int32_t get_offset_of_x_1() { return static_cast<int32_t>(offsetof(Vector3_t3722313464, ___x_1)); }
	inline float get_x_1() const { return ___x_1; }
	inline float* get_address_of_x_1() { return &___x_1; }
	inline void set_x_1(float value)
	{
		___x_1 = value;
	}

	inline static int32_t get_offset_of_y_2() { return static_cast<int32_t>(offsetof(Vector3_t3722313464, ___y_2)); }
	inline float get_y_2() const { return ___y_2; }
	inline float* get_address_of_y_2() { return &___y_2; }
	inline void set_y_2(float value)
	{
		___y_2 = value;
	}

	inline static int32_t get_offset_of_z_3() { return static_cast<int32_t>(offsetof(Vector3_t3722313464, ___z_3)); }
	inline float get_z_3() const { return ___z_3; }
	inline float* get_address_of_z_3() { return &___z_3; }
	inline void set_z_3(float value)
	{
		___z_3 = value;
	}
};

struct Vector3_t3722313464_StaticFields
{
public:
	// UnityEngine.Vector3 UnityEngine.Vector3::zeroVector
	Vector3_t3722313464  ___zeroVector_4;
	// UnityEngine.Vector3 UnityEngine.Vector3::oneVector
	Vector3_t3722313464  ___oneVector_5;
	// UnityEngine.Vector3 UnityEngine.Vector3::upVector
	Vector3_t3722313464  ___upVector_6;
	// UnityEngine.Vector3 UnityEngine.Vector3::downVector
	Vector3_t3722313464  ___downVector_7;
	// UnityEngine.Vector3 UnityEngine.Vector3::leftVector
	Vector3_t3722313464  ___leftVector_8;
	// UnityEngine.Vector3 UnityEngine.Vector3::rightVector
	Vector3_t3722313464  ___rightVector_9;
	// UnityEngine.Vector3 UnityEngine.Vector3::forwardVector
	Vector3_t3722313464  ___forwardVector_10;
	// UnityEngine.Vector3 UnityEngine.Vector3::backVector
	Vector3_t3722313464  ___backVector_11;
	// UnityEngine.Vector3 UnityEngine.Vector3::positiveInfinityVector
	Vector3_t3722313464  ___positiveInfinityVector_12;
	// UnityEngine.Vector3 UnityEngine.Vector3::negativeInfinityVector
	Vector3_t3722313464  ___negativeInfinityVector_13;

public:
	inline static int32_t get_offset_of_zeroVector_4() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___zeroVector_4)); }
	inline Vector3_t3722313464  get_zeroVector_4() const { return ___zeroVector_4; }
	inline Vector3_t3722313464 * get_address_of_zeroVector_4() { return &___zeroVector_4; }
	inline void set_zeroVector_4(Vector3_t3722313464  value)
	{
		___zeroVector_4 = value;
	}

	inline static int32_t get_offset_of_oneVector_5() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___oneVector_5)); }
	inline Vector3_t3722313464  get_oneVector_5() const { return ___oneVector_5; }
	inline Vector3_t3722313464 * get_address_of_oneVector_5() { return &___oneVector_5; }
	inline void set_oneVector_5(Vector3_t3722313464  value)
	{
		___oneVector_5 = value;
	}

	inline static int32_t get_offset_of_upVector_6() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___upVector_6)); }
	inline Vector3_t3722313464  get_upVector_6() const { return ___upVector_6; }
	inline Vector3_t3722313464 * get_address_of_upVector_6() { return &___upVector_6; }
	inline void set_upVector_6(Vector3_t3722313464  value)
	{
		___upVector_6 = value;
	}

	inline static int32_t get_offset_of_downVector_7() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___downVector_7)); }
	inline Vector3_t3722313464  get_downVector_7() const { return ___downVector_7; }
	inline Vector3_t3722313464 * get_address_of_downVector_7() { return &___downVector_7; }
	inline void set_downVector_7(Vector3_t3722313464  value)
	{
		___downVector_7 = value;
	}

	inline static int32_t get_offset_of_leftVector_8() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___leftVector_8)); }
	inline Vector3_t3722313464  get_leftVector_8() const { return ___leftVector_8; }
	inline Vector3_t3722313464 * get_address_of_leftVector_8() { return &___leftVector_8; }
	inline void set_leftVector_8(Vector3_t3722313464  value)
	{
		___leftVector_8 = value;
	}

	inline static int32_t get_offset_of_rightVector_9() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___rightVector_9)); }
	inline Vector3_t3722313464  get_rightVector_9() const { return ___rightVector_9; }
	inline Vector3_t3722313464 * get_address_of_rightVector_9() { return &___rightVector_9; }
	inline void set_rightVector_9(Vector3_t3722313464  value)
	{
		___rightVector_9 = value;
	}

	inline static int32_t get_offset_of_forwardVector_10() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___forwardVector_10)); }
	inline Vector3_t3722313464  get_forwardVector_10() const { return ___forwardVector_10; }
	inline Vector3_t3722313464 * get_address_of_forwardVector_10() { return &___forwardVector_10; }
	inline void set_forwardVector_10(Vector3_t3722313464  value)
	{
		___forwardVector_10 = value;
	}

	inline static int32_t get_offset_of_backVector_11() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___backVector_11)); }
	inline Vector3_t3722313464  get_backVector_11() const { return ___backVector_11; }
	inline Vector3_t3722313464 * get_address_of_backVector_11() { return &___backVector_11; }
	inline void set_backVector_11(Vector3_t3722313464  value)
	{
		___backVector_11 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_12() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___positiveInfinityVector_12)); }
	inline Vector3_t3722313464  get_positiveInfinityVector_12() const { return ___positiveInfinityVector_12; }
	inline Vector3_t3722313464 * get_address_of_positiveInfinityVector_12() { return &___positiveInfinityVector_12; }
	inline void set_positiveInfinityVector_12(Vector3_t3722313464  value)
	{
		___positiveInfinityVector_12 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_13() { return static_cast<int32_t>(offsetof(Vector3_t3722313464_StaticFields, ___negativeInfinityVector_13)); }
	inline Vector3_t3722313464  get_negativeInfinityVector_13() const { return ___negativeInfinityVector_13; }
	inline Vector3_t3722313464 * get_address_of_negativeInfinityVector_13() { return &___negativeInfinityVector_13; }
	inline void set_negativeInfinityVector_13(Vector3_t3722313464  value)
	{
		___negativeInfinityVector_13 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VECTOR3_T3722313464_H
#ifndef WORKREQUEST_T1354518612_H
#define WORKREQUEST_T1354518612_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.UnitySynchronizationContext/WorkRequest
struct  WorkRequest_t1354518612 
{
public:
	// System.Threading.SendOrPostCallback UnityEngine.UnitySynchronizationContext/WorkRequest::m_DelagateCallback
	SendOrPostCallback_t2750080073 * ___m_DelagateCallback_0;
	// System.Object UnityEngine.UnitySynchronizationContext/WorkRequest::m_DelagateState
	RuntimeObject * ___m_DelagateState_1;
	// System.Threading.ManualResetEvent UnityEngine.UnitySynchronizationContext/WorkRequest::m_WaitHandle
	ManualResetEvent_t451242010 * ___m_WaitHandle_2;

public:
	inline static int32_t get_offset_of_m_DelagateCallback_0() { return static_cast<int32_t>(offsetof(WorkRequest_t1354518612, ___m_DelagateCallback_0)); }
	inline SendOrPostCallback_t2750080073 * get_m_DelagateCallback_0() const { return ___m_DelagateCallback_0; }
	inline SendOrPostCallback_t2750080073 ** get_address_of_m_DelagateCallback_0() { return &___m_DelagateCallback_0; }
	inline void set_m_DelagateCallback_0(SendOrPostCallback_t2750080073 * value)
	{
		___m_DelagateCallback_0 = value;
		Il2CppCodeGenWriteBarrier((&___m_DelagateCallback_0), value);
	}

	inline static int32_t get_offset_of_m_DelagateState_1() { return static_cast<int32_t>(offsetof(WorkRequest_t1354518612, ___m_DelagateState_1)); }
	inline RuntimeObject * get_m_DelagateState_1() const { return ___m_DelagateState_1; }
	inline RuntimeObject ** get_address_of_m_DelagateState_1() { return &___m_DelagateState_1; }
	inline void set_m_DelagateState_1(RuntimeObject * value)
	{
		___m_DelagateState_1 = value;
		Il2CppCodeGenWriteBarrier((&___m_DelagateState_1), value);
	}

	inline static int32_t get_offset_of_m_WaitHandle_2() { return static_cast<int32_t>(offsetof(WorkRequest_t1354518612, ___m_WaitHandle_2)); }
	inline ManualResetEvent_t451242010 * get_m_WaitHandle_2() const { return ___m_WaitHandle_2; }
	inline ManualResetEvent_t451242010 ** get_address_of_m_WaitHandle_2() { return &___m_WaitHandle_2; }
	inline void set_m_WaitHandle_2(ManualResetEvent_t451242010 * value)
	{
		___m_WaitHandle_2 = value;
		Il2CppCodeGenWriteBarrier((&___m_WaitHandle_2), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.UnitySynchronizationContext/WorkRequest
struct WorkRequest_t1354518612_marshaled_pinvoke
{
	Il2CppMethodPointer ___m_DelagateCallback_0;
	Il2CppIUnknown* ___m_DelagateState_1;
	ManualResetEvent_t451242010 * ___m_WaitHandle_2;
};
// Native definition for COM marshalling of UnityEngine.UnitySynchronizationContext/WorkRequest
struct WorkRequest_t1354518612_marshaled_com
{
	Il2CppMethodPointer ___m_DelagateCallback_0;
	Il2CppIUnknown* ___m_DelagateState_1;
	ManualResetEvent_t451242010 * ___m_WaitHandle_2;
};
#endif // WORKREQUEST_T1354518612_H
#ifndef WAITFORFIXEDUPDATE_T1634918743_H
#define WAITFORFIXEDUPDATE_T1634918743_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.WaitForFixedUpdate
struct  WaitForFixedUpdate_t1634918743  : public YieldInstruction_t403091072
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // WAITFORFIXEDUPDATE_T1634918743_H
#ifndef WAITFORSECONDS_T1699091251_H
#define WAITFORSECONDS_T1699091251_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.WaitForSeconds
struct  WaitForSeconds_t1699091251  : public YieldInstruction_t403091072
{
public:
	// System.Single UnityEngine.WaitForSeconds::m_Seconds
	float ___m_Seconds_0;

public:
	inline static int32_t get_offset_of_m_Seconds_0() { return static_cast<int32_t>(offsetof(WaitForSeconds_t1699091251, ___m_Seconds_0)); }
	inline float get_m_Seconds_0() const { return ___m_Seconds_0; }
	inline float* get_address_of_m_Seconds_0() { return &___m_Seconds_0; }
	inline void set_m_Seconds_0(float value)
	{
		___m_Seconds_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.WaitForSeconds
struct WaitForSeconds_t1699091251_marshaled_pinvoke : public YieldInstruction_t403091072_marshaled_pinvoke
{
	float ___m_Seconds_0;
};
// Native definition for COM marshalling of UnityEngine.WaitForSeconds
struct WaitForSeconds_t1699091251_marshaled_com : public YieldInstruction_t403091072_marshaled_com
{
	float ___m_Seconds_0;
};
#endif // WAITFORSECONDS_T1699091251_H
#ifndef INTPTR_T_H
#define INTPTR_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.IntPtr
struct  IntPtr_t 
{
public:
	// System.Void* System.IntPtr::m_value
	void* ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(IntPtr_t, ___m_value_0)); }
	inline void* get_m_value_0() const { return ___m_value_0; }
	inline void** get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(void* value)
	{
		___m_value_0 = value;
	}
};

struct IntPtr_t_StaticFields
{
public:
	// System.IntPtr System.IntPtr::Zero
	intptr_t ___Zero_1;

public:
	inline static int32_t get_offset_of_Zero_1() { return static_cast<int32_t>(offsetof(IntPtr_t_StaticFields, ___Zero_1)); }
	inline intptr_t get_Zero_1() const { return ___Zero_1; }
	inline intptr_t* get_address_of_Zero_1() { return &___Zero_1; }
	inline void set_Zero_1(intptr_t value)
	{
		___Zero_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INTPTR_T_H
#ifndef WAITFORENDOFFRAME_T1314943911_H
#define WAITFORENDOFFRAME_T1314943911_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.WaitForEndOfFrame
struct  WaitForEndOfFrame_t1314943911  : public YieldInstruction_t403091072
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // WAITFORENDOFFRAME_T1314943911_H
#ifndef BOOLEAN_T97287965_H
#define BOOLEAN_T97287965_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Boolean
struct  Boolean_t97287965 
{
public:
	// System.Boolean System.Boolean::m_value
	bool ___m_value_2;

public:
	inline static int32_t get_offset_of_m_value_2() { return static_cast<int32_t>(offsetof(Boolean_t97287965, ___m_value_2)); }
	inline bool get_m_value_2() const { return ___m_value_2; }
	inline bool* get_address_of_m_value_2() { return &___m_value_2; }
	inline void set_m_value_2(bool value)
	{
		___m_value_2 = value;
	}
};

struct Boolean_t97287965_StaticFields
{
public:
	// System.String System.Boolean::FalseString
	String_t* ___FalseString_0;
	// System.String System.Boolean::TrueString
	String_t* ___TrueString_1;

public:
	inline static int32_t get_offset_of_FalseString_0() { return static_cast<int32_t>(offsetof(Boolean_t97287965_StaticFields, ___FalseString_0)); }
	inline String_t* get_FalseString_0() const { return ___FalseString_0; }
	inline String_t** get_address_of_FalseString_0() { return &___FalseString_0; }
	inline void set_FalseString_0(String_t* value)
	{
		___FalseString_0 = value;
		Il2CppCodeGenWriteBarrier((&___FalseString_0), value);
	}

	inline static int32_t get_offset_of_TrueString_1() { return static_cast<int32_t>(offsetof(Boolean_t97287965_StaticFields, ___TrueString_1)); }
	inline String_t* get_TrueString_1() const { return ___TrueString_1; }
	inline String_t** get_address_of_TrueString_1() { return &___TrueString_1; }
	inline void set_TrueString_1(String_t* value)
	{
		___TrueString_1 = value;
		Il2CppCodeGenWriteBarrier((&___TrueString_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BOOLEAN_T97287965_H
#ifndef UNITYSYNCHRONIZATIONCONTEXT_T1887453786_H
#define UNITYSYNCHRONIZATIONCONTEXT_T1887453786_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.UnitySynchronizationContext
struct  UnitySynchronizationContext_t1887453786  : public SynchronizationContext_t2326897723
{
public:
	// System.Collections.Generic.Queue`1<UnityEngine.UnitySynchronizationContext/WorkRequest> UnityEngine.UnitySynchronizationContext::m_AsyncWorkQueue
	Queue_1_t1200778106 * ___m_AsyncWorkQueue_1;
	// System.Int32 UnityEngine.UnitySynchronizationContext::m_MainThreadID
	int32_t ___m_MainThreadID_2;

public:
	inline static int32_t get_offset_of_m_AsyncWorkQueue_1() { return static_cast<int32_t>(offsetof(UnitySynchronizationContext_t1887453786, ___m_AsyncWorkQueue_1)); }
	inline Queue_1_t1200778106 * get_m_AsyncWorkQueue_1() const { return ___m_AsyncWorkQueue_1; }
	inline Queue_1_t1200778106 ** get_address_of_m_AsyncWorkQueue_1() { return &___m_AsyncWorkQueue_1; }
	inline void set_m_AsyncWorkQueue_1(Queue_1_t1200778106 * value)
	{
		___m_AsyncWorkQueue_1 = value;
		Il2CppCodeGenWriteBarrier((&___m_AsyncWorkQueue_1), value);
	}

	inline static int32_t get_offset_of_m_MainThreadID_2() { return static_cast<int32_t>(offsetof(UnitySynchronizationContext_t1887453786, ___m_MainThreadID_2)); }
	inline int32_t get_m_MainThreadID_2() const { return ___m_MainThreadID_2; }
	inline int32_t* get_address_of_m_MainThreadID_2() { return &___m_MainThreadID_2; }
	inline void set_m_MainThreadID_2(int32_t value)
	{
		___m_MainThreadID_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // UNITYSYNCHRONIZATIONCONTEXT_T1887453786_H
#ifndef UNITYEXCEPTION_T3598173660_H
#define UNITYEXCEPTION_T3598173660_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.UnityException
struct  UnityException_t3598173660  : public Exception_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // UNITYEXCEPTION_T3598173660_H
#ifndef VECTOR4_T3319028937_H
#define VECTOR4_T3319028937_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Vector4
struct  Vector4_t3319028937 
{
public:
	// System.Single UnityEngine.Vector4::x
	float ___x_1;
	// System.Single UnityEngine.Vector4::y
	float ___y_2;
	// System.Single UnityEngine.Vector4::z
	float ___z_3;
	// System.Single UnityEngine.Vector4::w
	float ___w_4;

public:
	inline static int32_t get_offset_of_x_1() { return static_cast<int32_t>(offsetof(Vector4_t3319028937, ___x_1)); }
	inline float get_x_1() const { return ___x_1; }
	inline float* get_address_of_x_1() { return &___x_1; }
	inline void set_x_1(float value)
	{
		___x_1 = value;
	}

	inline static int32_t get_offset_of_y_2() { return static_cast<int32_t>(offsetof(Vector4_t3319028937, ___y_2)); }
	inline float get_y_2() const { return ___y_2; }
	inline float* get_address_of_y_2() { return &___y_2; }
	inline void set_y_2(float value)
	{
		___y_2 = value;
	}

	inline static int32_t get_offset_of_z_3() { return static_cast<int32_t>(offsetof(Vector4_t3319028937, ___z_3)); }
	inline float get_z_3() const { return ___z_3; }
	inline float* get_address_of_z_3() { return &___z_3; }
	inline void set_z_3(float value)
	{
		___z_3 = value;
	}

	inline static int32_t get_offset_of_w_4() { return static_cast<int32_t>(offsetof(Vector4_t3319028937, ___w_4)); }
	inline float get_w_4() const { return ___w_4; }
	inline float* get_address_of_w_4() { return &___w_4; }
	inline void set_w_4(float value)
	{
		___w_4 = value;
	}
};

struct Vector4_t3319028937_StaticFields
{
public:
	// UnityEngine.Vector4 UnityEngine.Vector4::zeroVector
	Vector4_t3319028937  ___zeroVector_5;
	// UnityEngine.Vector4 UnityEngine.Vector4::oneVector
	Vector4_t3319028937  ___oneVector_6;
	// UnityEngine.Vector4 UnityEngine.Vector4::positiveInfinityVector
	Vector4_t3319028937  ___positiveInfinityVector_7;
	// UnityEngine.Vector4 UnityEngine.Vector4::negativeInfinityVector
	Vector4_t3319028937  ___negativeInfinityVector_8;

public:
	inline static int32_t get_offset_of_zeroVector_5() { return static_cast<int32_t>(offsetof(Vector4_t3319028937_StaticFields, ___zeroVector_5)); }
	inline Vector4_t3319028937  get_zeroVector_5() const { return ___zeroVector_5; }
	inline Vector4_t3319028937 * get_address_of_zeroVector_5() { return &___zeroVector_5; }
	inline void set_zeroVector_5(Vector4_t3319028937  value)
	{
		___zeroVector_5 = value;
	}

	inline static int32_t get_offset_of_oneVector_6() { return static_cast<int32_t>(offsetof(Vector4_t3319028937_StaticFields, ___oneVector_6)); }
	inline Vector4_t3319028937  get_oneVector_6() const { return ___oneVector_6; }
	inline Vector4_t3319028937 * get_address_of_oneVector_6() { return &___oneVector_6; }
	inline void set_oneVector_6(Vector4_t3319028937  value)
	{
		___oneVector_6 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_7() { return static_cast<int32_t>(offsetof(Vector4_t3319028937_StaticFields, ___positiveInfinityVector_7)); }
	inline Vector4_t3319028937  get_positiveInfinityVector_7() const { return ___positiveInfinityVector_7; }
	inline Vector4_t3319028937 * get_address_of_positiveInfinityVector_7() { return &___positiveInfinityVector_7; }
	inline void set_positiveInfinityVector_7(Vector4_t3319028937  value)
	{
		___positiveInfinityVector_7 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_8() { return static_cast<int32_t>(offsetof(Vector4_t3319028937_StaticFields, ___negativeInfinityVector_8)); }
	inline Vector4_t3319028937  get_negativeInfinityVector_8() const { return ___negativeInfinityVector_8; }
	inline Vector4_t3319028937 * get_address_of_negativeInfinityVector_8() { return &___negativeInfinityVector_8; }
	inline void set_negativeInfinityVector_8(Vector4_t3319028937  value)
	{
		___negativeInfinityVector_8 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VECTOR4_T3319028937_H
#ifndef UINT32_T2560061978_H
#define UINT32_T2560061978_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.UInt32
struct  UInt32_t2560061978 
{
public:
	// System.UInt32 System.UInt32::m_value
	uint32_t ___m_value_0;

public:
	inline static int32_t get_offset_of_m_value_0() { return static_cast<int32_t>(offsetof(UInt32_t2560061978, ___m_value_0)); }
	inline uint32_t get_m_value_0() const { return ___m_value_0; }
	inline uint32_t* get_address_of_m_value_0() { return &___m_value_0; }
	inline void set_m_value_0(uint32_t value)
	{
		___m_value_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // UINT32_T2560061978_H
#ifndef SORTINGLAYER_T2251519173_H
#define SORTINGLAYER_T2251519173_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.SortingLayer
struct  SortingLayer_t2251519173 
{
public:
	// System.Int32 UnityEngine.SortingLayer::m_Id
	int32_t ___m_Id_0;

public:
	inline static int32_t get_offset_of_m_Id_0() { return static_cast<int32_t>(offsetof(SortingLayer_t2251519173, ___m_Id_0)); }
	inline int32_t get_m_Id_0() const { return ___m_Id_0; }
	inline int32_t* get_address_of_m_Id_0() { return &___m_Id_0; }
	inline void set_m_Id_0(int32_t value)
	{
		___m_Id_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SORTINGLAYER_T2251519173_H
#ifndef TIMESPAN_T881159249_H
#define TIMESPAN_T881159249_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.TimeSpan
struct  TimeSpan_t881159249 
{
public:
	// System.Int64 System.TimeSpan::_ticks
	int64_t ____ticks_3;

public:
	inline static int32_t get_offset_of__ticks_3() { return static_cast<int32_t>(offsetof(TimeSpan_t881159249, ____ticks_3)); }
	inline int64_t get__ticks_3() const { return ____ticks_3; }
	inline int64_t* get_address_of__ticks_3() { return &____ticks_3; }
	inline void set__ticks_3(int64_t value)
	{
		____ticks_3 = value;
	}
};

struct TimeSpan_t881159249_StaticFields
{
public:
	// System.TimeSpan System.TimeSpan::MaxValue
	TimeSpan_t881159249  ___MaxValue_0;
	// System.TimeSpan System.TimeSpan::MinValue
	TimeSpan_t881159249  ___MinValue_1;
	// System.TimeSpan System.TimeSpan::Zero
	TimeSpan_t881159249  ___Zero_2;

public:
	inline static int32_t get_offset_of_MaxValue_0() { return static_cast<int32_t>(offsetof(TimeSpan_t881159249_StaticFields, ___MaxValue_0)); }
	inline TimeSpan_t881159249  get_MaxValue_0() const { return ___MaxValue_0; }
	inline TimeSpan_t881159249 * get_address_of_MaxValue_0() { return &___MaxValue_0; }
	inline void set_MaxValue_0(TimeSpan_t881159249  value)
	{
		___MaxValue_0 = value;
	}

	inline static int32_t get_offset_of_MinValue_1() { return static_cast<int32_t>(offsetof(TimeSpan_t881159249_StaticFields, ___MinValue_1)); }
	inline TimeSpan_t881159249  get_MinValue_1() const { return ___MinValue_1; }
	inline TimeSpan_t881159249 * get_address_of_MinValue_1() { return &___MinValue_1; }
	inline void set_MinValue_1(TimeSpan_t881159249  value)
	{
		___MinValue_1 = value;
	}

	inline static int32_t get_offset_of_Zero_2() { return static_cast<int32_t>(offsetof(TimeSpan_t881159249_StaticFields, ___Zero_2)); }
	inline TimeSpan_t881159249  get_Zero_2() const { return ___Zero_2; }
	inline TimeSpan_t881159249 * get_address_of_Zero_2() { return &___Zero_2; }
	inline void set_Zero_2(TimeSpan_t881159249  value)
	{
		___Zero_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TIMESPAN_T881159249_H
#ifndef PROPERTYATTRIBUTE_T3677895545_H
#define PROPERTYATTRIBUTE_T3677895545_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.PropertyAttribute
struct  PropertyAttribute_t3677895545  : public Attribute_t861562559
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // PROPERTYATTRIBUTE_T3677895545_H
#ifndef UINTPTR_T_H
#define UINTPTR_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.UIntPtr
struct  UIntPtr_t 
{
public:
	// System.Void* System.UIntPtr::_pointer
	void* ____pointer_1;

public:
	inline static int32_t get_offset_of__pointer_1() { return static_cast<int32_t>(offsetof(UIntPtr_t, ____pointer_1)); }
	inline void* get__pointer_1() const { return ____pointer_1; }
	inline void** get_address_of__pointer_1() { return &____pointer_1; }
	inline void set__pointer_1(void* value)
	{
		____pointer_1 = value;
	}
};

struct UIntPtr_t_StaticFields
{
public:
	// System.UIntPtr System.UIntPtr::Zero
	uintptr_t ___Zero_0;

public:
	inline static int32_t get_offset_of_Zero_0() { return static_cast<int32_t>(offsetof(UIntPtr_t_StaticFields, ___Zero_0)); }
	inline uintptr_t get_Zero_0() const { return ___Zero_0; }
	inline uintptr_t* get_address_of_Zero_0() { return &___Zero_0; }
	inline void set_Zero_0(uintptr_t value)
	{
		___Zero_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // UINTPTR_T_H
#ifndef SINGLE_T1397266774_H
#define SINGLE_T1397266774_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Single
struct  Single_t1397266774 
{
public:
	// System.Single System.Single::m_value
	float ___m_value_7;

public:
	inline static int32_t get_offset_of_m_value_7() { return static_cast<int32_t>(offsetof(Single_t1397266774, ___m_value_7)); }
	inline float get_m_value_7() const { return ___m_value_7; }
	inline float* get_address_of_m_value_7() { return &___m_value_7; }
	inline void set_m_value_7(float value)
	{
		___m_value_7 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SINGLE_T1397266774_H
#ifndef VECTOR2_T2156229523_H
#define VECTOR2_T2156229523_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Vector2
struct  Vector2_t2156229523 
{
public:
	// System.Single UnityEngine.Vector2::x
	float ___x_0;
	// System.Single UnityEngine.Vector2::y
	float ___y_1;

public:
	inline static int32_t get_offset_of_x_0() { return static_cast<int32_t>(offsetof(Vector2_t2156229523, ___x_0)); }
	inline float get_x_0() const { return ___x_0; }
	inline float* get_address_of_x_0() { return &___x_0; }
	inline void set_x_0(float value)
	{
		___x_0 = value;
	}

	inline static int32_t get_offset_of_y_1() { return static_cast<int32_t>(offsetof(Vector2_t2156229523, ___y_1)); }
	inline float get_y_1() const { return ___y_1; }
	inline float* get_address_of_y_1() { return &___y_1; }
	inline void set_y_1(float value)
	{
		___y_1 = value;
	}
};

struct Vector2_t2156229523_StaticFields
{
public:
	// UnityEngine.Vector2 UnityEngine.Vector2::zeroVector
	Vector2_t2156229523  ___zeroVector_2;
	// UnityEngine.Vector2 UnityEngine.Vector2::oneVector
	Vector2_t2156229523  ___oneVector_3;
	// UnityEngine.Vector2 UnityEngine.Vector2::upVector
	Vector2_t2156229523  ___upVector_4;
	// UnityEngine.Vector2 UnityEngine.Vector2::downVector
	Vector2_t2156229523  ___downVector_5;
	// UnityEngine.Vector2 UnityEngine.Vector2::leftVector
	Vector2_t2156229523  ___leftVector_6;
	// UnityEngine.Vector2 UnityEngine.Vector2::rightVector
	Vector2_t2156229523  ___rightVector_7;
	// UnityEngine.Vector2 UnityEngine.Vector2::positiveInfinityVector
	Vector2_t2156229523  ___positiveInfinityVector_8;
	// UnityEngine.Vector2 UnityEngine.Vector2::negativeInfinityVector
	Vector2_t2156229523  ___negativeInfinityVector_9;

public:
	inline static int32_t get_offset_of_zeroVector_2() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___zeroVector_2)); }
	inline Vector2_t2156229523  get_zeroVector_2() const { return ___zeroVector_2; }
	inline Vector2_t2156229523 * get_address_of_zeroVector_2() { return &___zeroVector_2; }
	inline void set_zeroVector_2(Vector2_t2156229523  value)
	{
		___zeroVector_2 = value;
	}

	inline static int32_t get_offset_of_oneVector_3() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___oneVector_3)); }
	inline Vector2_t2156229523  get_oneVector_3() const { return ___oneVector_3; }
	inline Vector2_t2156229523 * get_address_of_oneVector_3() { return &___oneVector_3; }
	inline void set_oneVector_3(Vector2_t2156229523  value)
	{
		___oneVector_3 = value;
	}

	inline static int32_t get_offset_of_upVector_4() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___upVector_4)); }
	inline Vector2_t2156229523  get_upVector_4() const { return ___upVector_4; }
	inline Vector2_t2156229523 * get_address_of_upVector_4() { return &___upVector_4; }
	inline void set_upVector_4(Vector2_t2156229523  value)
	{
		___upVector_4 = value;
	}

	inline static int32_t get_offset_of_downVector_5() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___downVector_5)); }
	inline Vector2_t2156229523  get_downVector_5() const { return ___downVector_5; }
	inline Vector2_t2156229523 * get_address_of_downVector_5() { return &___downVector_5; }
	inline void set_downVector_5(Vector2_t2156229523  value)
	{
		___downVector_5 = value;
	}

	inline static int32_t get_offset_of_leftVector_6() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___leftVector_6)); }
	inline Vector2_t2156229523  get_leftVector_6() const { return ___leftVector_6; }
	inline Vector2_t2156229523 * get_address_of_leftVector_6() { return &___leftVector_6; }
	inline void set_leftVector_6(Vector2_t2156229523  value)
	{
		___leftVector_6 = value;
	}

	inline static int32_t get_offset_of_rightVector_7() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___rightVector_7)); }
	inline Vector2_t2156229523  get_rightVector_7() const { return ___rightVector_7; }
	inline Vector2_t2156229523 * get_address_of_rightVector_7() { return &___rightVector_7; }
	inline void set_rightVector_7(Vector2_t2156229523  value)
	{
		___rightVector_7 = value;
	}

	inline static int32_t get_offset_of_positiveInfinityVector_8() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___positiveInfinityVector_8)); }
	inline Vector2_t2156229523  get_positiveInfinityVector_8() const { return ___positiveInfinityVector_8; }
	inline Vector2_t2156229523 * get_address_of_positiveInfinityVector_8() { return &___positiveInfinityVector_8; }
	inline void set_positiveInfinityVector_8(Vector2_t2156229523  value)
	{
		___positiveInfinityVector_8 = value;
	}

	inline static int32_t get_offset_of_negativeInfinityVector_9() { return static_cast<int32_t>(offsetof(Vector2_t2156229523_StaticFields, ___negativeInfinityVector_9)); }
	inline Vector2_t2156229523  get_negativeInfinityVector_9() const { return ___negativeInfinityVector_9; }
	inline Vector2_t2156229523 * get_address_of_negativeInfinityVector_9() { return &___negativeInfinityVector_9; }
	inline void set_negativeInfinityVector_9(Vector2_t2156229523  value)
	{
		___negativeInfinityVector_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // VECTOR2_T2156229523_H
#ifndef RECT_T2360479859_H
#define RECT_T2360479859_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Rect
struct  Rect_t2360479859 
{
public:
	// System.Single UnityEngine.Rect::m_XMin
	float ___m_XMin_0;
	// System.Single UnityEngine.Rect::m_YMin
	float ___m_YMin_1;
	// System.Single UnityEngine.Rect::m_Width
	float ___m_Width_2;
	// System.Single UnityEngine.Rect::m_Height
	float ___m_Height_3;

public:
	inline static int32_t get_offset_of_m_XMin_0() { return static_cast<int32_t>(offsetof(Rect_t2360479859, ___m_XMin_0)); }
	inline float get_m_XMin_0() const { return ___m_XMin_0; }
	inline float* get_address_of_m_XMin_0() { return &___m_XMin_0; }
	inline void set_m_XMin_0(float value)
	{
		___m_XMin_0 = value;
	}

	inline static int32_t get_offset_of_m_YMin_1() { return static_cast<int32_t>(offsetof(Rect_t2360479859, ___m_YMin_1)); }
	inline float get_m_YMin_1() const { return ___m_YMin_1; }
	inline float* get_address_of_m_YMin_1() { return &___m_YMin_1; }
	inline void set_m_YMin_1(float value)
	{
		___m_YMin_1 = value;
	}

	inline static int32_t get_offset_of_m_Width_2() { return static_cast<int32_t>(offsetof(Rect_t2360479859, ___m_Width_2)); }
	inline float get_m_Width_2() const { return ___m_Width_2; }
	inline float* get_address_of_m_Width_2() { return &___m_Width_2; }
	inline void set_m_Width_2(float value)
	{
		___m_Width_2 = value;
	}

	inline static int32_t get_offset_of_m_Height_3() { return static_cast<int32_t>(offsetof(Rect_t2360479859, ___m_Height_3)); }
	inline float get_m_Height_3() const { return ___m_Height_3; }
	inline float* get_address_of_m_Height_3() { return &___m_Height_3; }
	inline void set_m_Height_3(float value)
	{
		___m_Height_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RECT_T2360479859_H
#ifndef SYSTEMEXCEPTION_T176217640_H
#define SYSTEMEXCEPTION_T176217640_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.SystemException
struct  SystemException_t176217640  : public Exception_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SYSTEMEXCEPTION_T176217640_H
#ifndef METHODBASE_T_H
#define METHODBASE_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.MethodBase
struct  MethodBase_t  : public MemberInfo_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // METHODBASE_T_H
#ifndef HITINFO_T3229609740_H
#define HITINFO_T3229609740_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.SendMouseEvents/HitInfo
struct  HitInfo_t3229609740 
{
public:
	// UnityEngine.GameObject UnityEngine.SendMouseEvents/HitInfo::target
	GameObject_t1113636619 * ___target_0;
	// UnityEngine.Camera UnityEngine.SendMouseEvents/HitInfo::camera
	Camera_t4157153871 * ___camera_1;

public:
	inline static int32_t get_offset_of_target_0() { return static_cast<int32_t>(offsetof(HitInfo_t3229609740, ___target_0)); }
	inline GameObject_t1113636619 * get_target_0() const { return ___target_0; }
	inline GameObject_t1113636619 ** get_address_of_target_0() { return &___target_0; }
	inline void set_target_0(GameObject_t1113636619 * value)
	{
		___target_0 = value;
		Il2CppCodeGenWriteBarrier((&___target_0), value);
	}

	inline static int32_t get_offset_of_camera_1() { return static_cast<int32_t>(offsetof(HitInfo_t3229609740, ___camera_1)); }
	inline Camera_t4157153871 * get_camera_1() const { return ___camera_1; }
	inline Camera_t4157153871 ** get_address_of_camera_1() { return &___camera_1; }
	inline void set_camera_1(Camera_t4157153871 * value)
	{
		___camera_1 = value;
		Il2CppCodeGenWriteBarrier((&___camera_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.SendMouseEvents/HitInfo
struct HitInfo_t3229609740_marshaled_pinvoke
{
	GameObject_t1113636619 * ___target_0;
	Camera_t4157153871 * ___camera_1;
};
// Native definition for COM marshalling of UnityEngine.SendMouseEvents/HitInfo
struct HitInfo_t3229609740_marshaled_com
{
	GameObject_t1113636619 * ___target_0;
	Camera_t4157153871 * ___camera_1;
};
#endif // HITINFO_T3229609740_H
#ifndef ENUM_T4135868527_H
#define ENUM_T4135868527_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Enum
struct  Enum_t4135868527  : public ValueType_t3640485471
{
public:

public:
};

struct Enum_t4135868527_StaticFields
{
public:
	// System.Char[] System.Enum::split_char
	CharU5BU5D_t3528271667* ___split_char_0;

public:
	inline static int32_t get_offset_of_split_char_0() { return static_cast<int32_t>(offsetof(Enum_t4135868527_StaticFields, ___split_char_0)); }
	inline CharU5BU5D_t3528271667* get_split_char_0() const { return ___split_char_0; }
	inline CharU5BU5D_t3528271667** get_address_of_split_char_0() { return &___split_char_0; }
	inline void set_split_char_0(CharU5BU5D_t3528271667* value)
	{
		___split_char_0 = value;
		Il2CppCodeGenWriteBarrier((&___split_char_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Enum
struct Enum_t4135868527_marshaled_pinvoke
{
};
// Native definition for COM marshalling of System.Enum
struct Enum_t4135868527_marshaled_com
{
};
#endif // ENUM_T4135868527_H
#ifndef FORMERLYSERIALIZEDASATTRIBUTE_T2859083114_H
#define FORMERLYSERIALIZEDASATTRIBUTE_T2859083114_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Serialization.FormerlySerializedAsAttribute
struct  FormerlySerializedAsAttribute_t2859083114  : public Attribute_t861562559
{
public:
	// System.String UnityEngine.Serialization.FormerlySerializedAsAttribute::m_oldName
	String_t* ___m_oldName_0;

public:
	inline static int32_t get_offset_of_m_oldName_0() { return static_cast<int32_t>(offsetof(FormerlySerializedAsAttribute_t2859083114, ___m_oldName_0)); }
	inline String_t* get_m_oldName_0() const { return ___m_oldName_0; }
	inline String_t** get_address_of_m_oldName_0() { return &___m_oldName_0; }
	inline void set_m_oldName_0(String_t* value)
	{
		___m_oldName_0 = value;
		Il2CppCodeGenWriteBarrier((&___m_oldName_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // FORMERLYSERIALIZEDASATTRIBUTE_T2859083114_H
#ifndef INT32_T2950945753_H
#define INT32_T2950945753_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Int32
struct  Int32_t2950945753 
{
public:
	// System.Int32 System.Int32::m_value
	int32_t ___m_value_2;

public:
	inline static int32_t get_offset_of_m_value_2() { return static_cast<int32_t>(offsetof(Int32_t2950945753, ___m_value_2)); }
	inline int32_t get_m_value_2() const { return ___m_value_2; }
	inline int32_t* get_address_of_m_value_2() { return &___m_value_2; }
	inline void set_m_value_2(int32_t value)
	{
		___m_value_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INT32_T2950945753_H
#ifndef UNITYLOGWRITER_T1374348020_H
#define UNITYLOGWRITER_T1374348020_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.UnityLogWriter
struct  UnityLogWriter_t1374348020  : public TextWriter_t3478189236
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // UNITYLOGWRITER_T1374348020_H
#ifndef CHAR_T3634460470_H
#define CHAR_T3634460470_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Char
struct  Char_t3634460470 
{
public:
	// System.Char System.Char::m_value
	Il2CppChar ___m_value_2;

public:
	inline static int32_t get_offset_of_m_value_2() { return static_cast<int32_t>(offsetof(Char_t3634460470, ___m_value_2)); }
	inline Il2CppChar get_m_value_2() const { return ___m_value_2; }
	inline Il2CppChar* get_address_of_m_value_2() { return &___m_value_2; }
	inline void set_m_value_2(Il2CppChar value)
	{
		___m_value_2 = value;
	}
};

struct Char_t3634460470_StaticFields
{
public:
	// System.Byte* System.Char::category_data
	uint8_t* ___category_data_3;
	// System.Byte* System.Char::numeric_data
	uint8_t* ___numeric_data_4;
	// System.Double* System.Char::numeric_data_values
	double* ___numeric_data_values_5;
	// System.UInt16* System.Char::to_lower_data_low
	uint16_t* ___to_lower_data_low_6;
	// System.UInt16* System.Char::to_lower_data_high
	uint16_t* ___to_lower_data_high_7;
	// System.UInt16* System.Char::to_upper_data_low
	uint16_t* ___to_upper_data_low_8;
	// System.UInt16* System.Char::to_upper_data_high
	uint16_t* ___to_upper_data_high_9;

public:
	inline static int32_t get_offset_of_category_data_3() { return static_cast<int32_t>(offsetof(Char_t3634460470_StaticFields, ___category_data_3)); }
	inline uint8_t* get_category_data_3() const { return ___category_data_3; }
	inline uint8_t** get_address_of_category_data_3() { return &___category_data_3; }
	inline void set_category_data_3(uint8_t* value)
	{
		___category_data_3 = value;
	}

	inline static int32_t get_offset_of_numeric_data_4() { return static_cast<int32_t>(offsetof(Char_t3634460470_StaticFields, ___numeric_data_4)); }
	inline uint8_t* get_numeric_data_4() const { return ___numeric_data_4; }
	inline uint8_t** get_address_of_numeric_data_4() { return &___numeric_data_4; }
	inline void set_numeric_data_4(uint8_t* value)
	{
		___numeric_data_4 = value;
	}

	inline static int32_t get_offset_of_numeric_data_values_5() { return static_cast<int32_t>(offsetof(Char_t3634460470_StaticFields, ___numeric_data_values_5)); }
	inline double* get_numeric_data_values_5() const { return ___numeric_data_values_5; }
	inline double** get_address_of_numeric_data_values_5() { return &___numeric_data_values_5; }
	inline void set_numeric_data_values_5(double* value)
	{
		___numeric_data_values_5 = value;
	}

	inline static int32_t get_offset_of_to_lower_data_low_6() { return static_cast<int32_t>(offsetof(Char_t3634460470_StaticFields, ___to_lower_data_low_6)); }
	inline uint16_t* get_to_lower_data_low_6() const { return ___to_lower_data_low_6; }
	inline uint16_t** get_address_of_to_lower_data_low_6() { return &___to_lower_data_low_6; }
	inline void set_to_lower_data_low_6(uint16_t* value)
	{
		___to_lower_data_low_6 = value;
	}

	inline static int32_t get_offset_of_to_lower_data_high_7() { return static_cast<int32_t>(offsetof(Char_t3634460470_StaticFields, ___to_lower_data_high_7)); }
	inline uint16_t* get_to_lower_data_high_7() const { return ___to_lower_data_high_7; }
	inline uint16_t** get_address_of_to_lower_data_high_7() { return &___to_lower_data_high_7; }
	inline void set_to_lower_data_high_7(uint16_t* value)
	{
		___to_lower_data_high_7 = value;
	}

	inline static int32_t get_offset_of_to_upper_data_low_8() { return static_cast<int32_t>(offsetof(Char_t3634460470_StaticFields, ___to_upper_data_low_8)); }
	inline uint16_t* get_to_upper_data_low_8() const { return ___to_upper_data_low_8; }
	inline uint16_t** get_address_of_to_upper_data_low_8() { return &___to_upper_data_low_8; }
	inline void set_to_upper_data_low_8(uint16_t* value)
	{
		___to_upper_data_low_8 = value;
	}

	inline static int32_t get_offset_of_to_upper_data_high_9() { return static_cast<int32_t>(offsetof(Char_t3634460470_StaticFields, ___to_upper_data_high_9)); }
	inline uint16_t* get_to_upper_data_high_9() const { return ___to_upper_data_high_9; }
	inline uint16_t** get_address_of_to_upper_data_high_9() { return &___to_upper_data_high_9; }
	inline void set_to_upper_data_high_9(uint16_t* value)
	{
		___to_upper_data_high_9 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CHAR_T3634460470_H
#ifndef PARAMETERMODIFIER_T1461694466_H
#define PARAMETERMODIFIER_T1461694466_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.ParameterModifier
struct  ParameterModifier_t1461694466 
{
public:
	// System.Boolean[] System.Reflection.ParameterModifier::_byref
	BooleanU5BU5D_t2897418192* ____byref_0;

public:
	inline static int32_t get_offset_of__byref_0() { return static_cast<int32_t>(offsetof(ParameterModifier_t1461694466, ____byref_0)); }
	inline BooleanU5BU5D_t2897418192* get__byref_0() const { return ____byref_0; }
	inline BooleanU5BU5D_t2897418192** get_address_of__byref_0() { return &____byref_0; }
	inline void set__byref_0(BooleanU5BU5D_t2897418192* value)
	{
		____byref_0 = value;
		Il2CppCodeGenWriteBarrier((&____byref_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Reflection.ParameterModifier
struct ParameterModifier_t1461694466_marshaled_pinvoke
{
	int32_t* ____byref_0;
};
// Native definition for COM marshalling of System.Reflection.ParameterModifier
struct ParameterModifier_t1461694466_marshaled_com
{
	int32_t* ____byref_0;
};
#endif // PARAMETERMODIFIER_T1461694466_H
#ifndef WAITHANDLE_T1743403487_H
#define WAITHANDLE_T1743403487_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Threading.WaitHandle
struct  WaitHandle_t1743403487  : public MarshalByRefObject_t2760389100
{
public:
	// Microsoft.Win32.SafeHandles.SafeWaitHandle System.Threading.WaitHandle::safe_wait_handle
	SafeWaitHandle_t1972936122 * ___safe_wait_handle_2;
	// System.Boolean System.Threading.WaitHandle::disposed
	bool ___disposed_4;

public:
	inline static int32_t get_offset_of_safe_wait_handle_2() { return static_cast<int32_t>(offsetof(WaitHandle_t1743403487, ___safe_wait_handle_2)); }
	inline SafeWaitHandle_t1972936122 * get_safe_wait_handle_2() const { return ___safe_wait_handle_2; }
	inline SafeWaitHandle_t1972936122 ** get_address_of_safe_wait_handle_2() { return &___safe_wait_handle_2; }
	inline void set_safe_wait_handle_2(SafeWaitHandle_t1972936122 * value)
	{
		___safe_wait_handle_2 = value;
		Il2CppCodeGenWriteBarrier((&___safe_wait_handle_2), value);
	}

	inline static int32_t get_offset_of_disposed_4() { return static_cast<int32_t>(offsetof(WaitHandle_t1743403487, ___disposed_4)); }
	inline bool get_disposed_4() const { return ___disposed_4; }
	inline bool* get_address_of_disposed_4() { return &___disposed_4; }
	inline void set_disposed_4(bool value)
	{
		___disposed_4 = value;
	}
};

struct WaitHandle_t1743403487_StaticFields
{
public:
	// System.IntPtr System.Threading.WaitHandle::InvalidHandle
	intptr_t ___InvalidHandle_3;

public:
	inline static int32_t get_offset_of_InvalidHandle_3() { return static_cast<int32_t>(offsetof(WaitHandle_t1743403487_StaticFields, ___InvalidHandle_3)); }
	inline intptr_t get_InvalidHandle_3() const { return ___InvalidHandle_3; }
	inline intptr_t* get_address_of_InvalidHandle_3() { return &___InvalidHandle_3; }
	inline void set_InvalidHandle_3(intptr_t value)
	{
		___InvalidHandle_3 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // WAITHANDLE_T1743403487_H
#ifndef OBJECT_T631007953_H
#define OBJECT_T631007953_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Object
struct  Object_t631007953  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.Object::m_CachedPtr
	intptr_t ___m_CachedPtr_0;

public:
	inline static int32_t get_offset_of_m_CachedPtr_0() { return static_cast<int32_t>(offsetof(Object_t631007953, ___m_CachedPtr_0)); }
	inline intptr_t get_m_CachedPtr_0() const { return ___m_CachedPtr_0; }
	inline intptr_t* get_address_of_m_CachedPtr_0() { return &___m_CachedPtr_0; }
	inline void set_m_CachedPtr_0(intptr_t value)
	{
		___m_CachedPtr_0 = value;
	}
};

struct Object_t631007953_StaticFields
{
public:
	// System.Int32 UnityEngine.Object::OffsetOfInstanceIDInCPlusPlusObject
	int32_t ___OffsetOfInstanceIDInCPlusPlusObject_1;

public:
	inline static int32_t get_offset_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return static_cast<int32_t>(offsetof(Object_t631007953_StaticFields, ___OffsetOfInstanceIDInCPlusPlusObject_1)); }
	inline int32_t get_OffsetOfInstanceIDInCPlusPlusObject_1() const { return ___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline int32_t* get_address_of_OffsetOfInstanceIDInCPlusPlusObject_1() { return &___OffsetOfInstanceIDInCPlusPlusObject_1; }
	inline void set_OffsetOfInstanceIDInCPlusPlusObject_1(int32_t value)
	{
		___OffsetOfInstanceIDInCPlusPlusObject_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.Object
struct Object_t631007953_marshaled_pinvoke
{
	intptr_t ___m_CachedPtr_0;
};
// Native definition for COM marshalling of UnityEngine.Object
struct Object_t631007953_marshaled_com
{
	intptr_t ___m_CachedPtr_0;
};
#endif // OBJECT_T631007953_H
#ifndef RUNTIMETYPEHANDLE_T3027515415_H
#define RUNTIMETYPEHANDLE_T3027515415_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.RuntimeTypeHandle
struct  RuntimeTypeHandle_t3027515415 
{
public:
	// System.IntPtr System.RuntimeTypeHandle::value
	intptr_t ___value_0;

public:
	inline static int32_t get_offset_of_value_0() { return static_cast<int32_t>(offsetof(RuntimeTypeHandle_t3027515415, ___value_0)); }
	inline intptr_t get_value_0() const { return ___value_0; }
	inline intptr_t* get_address_of_value_0() { return &___value_0; }
	inline void set_value_0(intptr_t value)
	{
		___value_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RUNTIMETYPEHANDLE_T3027515415_H
#ifndef TYPEINFERENCERULES_T96689094_H
#define TYPEINFERENCERULES_T96689094_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngineInternal.TypeInferenceRules
struct  TypeInferenceRules_t96689094 
{
public:
	// System.Int32 UnityEngineInternal.TypeInferenceRules::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(TypeInferenceRules_t96689094, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TYPEINFERENCERULES_T96689094_H
#ifndef PARAMETERATTRIBUTES_T1826424051_H
#define PARAMETERATTRIBUTES_T1826424051_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.ParameterAttributes
struct  ParameterAttributes_t1826424051 
{
public:
	// System.Int32 System.Reflection.ParameterAttributes::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(ParameterAttributes_t1826424051, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // PARAMETERATTRIBUTES_T1826424051_H
#ifndef THREADSTATE_T2533302383_H
#define THREADSTATE_T2533302383_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Threading.ThreadState
struct  ThreadState_t2533302383 
{
public:
	// System.Int32 System.Threading.ThreadState::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(ThreadState_t2533302383, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // THREADSTATE_T2533302383_H
#ifndef STREAMINGCONTEXTSTATES_T3580100459_H
#define STREAMINGCONTEXTSTATES_T3580100459_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Runtime.Serialization.StreamingContextStates
struct  StreamingContextStates_t3580100459 
{
public:
	// System.Int32 System.Runtime.Serialization.StreamingContextStates::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(StreamingContextStates_t3580100459, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // STREAMINGCONTEXTSTATES_T3580100459_H
#ifndef DELEGATE_T1188392813_H
#define DELEGATE_T1188392813_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Delegate
struct  Delegate_t1188392813  : public RuntimeObject
{
public:
	// System.IntPtr System.Delegate::method_ptr
	Il2CppMethodPointer ___method_ptr_0;
	// System.IntPtr System.Delegate::invoke_impl
	intptr_t ___invoke_impl_1;
	// System.Object System.Delegate::m_target
	RuntimeObject * ___m_target_2;
	// System.IntPtr System.Delegate::method
	intptr_t ___method_3;
	// System.IntPtr System.Delegate::delegate_trampoline
	intptr_t ___delegate_trampoline_4;
	// System.IntPtr System.Delegate::method_code
	intptr_t ___method_code_5;
	// System.Reflection.MethodInfo System.Delegate::method_info
	MethodInfo_t * ___method_info_6;
	// System.Reflection.MethodInfo System.Delegate::original_method_info
	MethodInfo_t * ___original_method_info_7;
	// System.DelegateData System.Delegate::data
	DelegateData_t1677132599 * ___data_8;

public:
	inline static int32_t get_offset_of_method_ptr_0() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_ptr_0)); }
	inline Il2CppMethodPointer get_method_ptr_0() const { return ___method_ptr_0; }
	inline Il2CppMethodPointer* get_address_of_method_ptr_0() { return &___method_ptr_0; }
	inline void set_method_ptr_0(Il2CppMethodPointer value)
	{
		___method_ptr_0 = value;
	}

	inline static int32_t get_offset_of_invoke_impl_1() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___invoke_impl_1)); }
	inline intptr_t get_invoke_impl_1() const { return ___invoke_impl_1; }
	inline intptr_t* get_address_of_invoke_impl_1() { return &___invoke_impl_1; }
	inline void set_invoke_impl_1(intptr_t value)
	{
		___invoke_impl_1 = value;
	}

	inline static int32_t get_offset_of_m_target_2() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___m_target_2)); }
	inline RuntimeObject * get_m_target_2() const { return ___m_target_2; }
	inline RuntimeObject ** get_address_of_m_target_2() { return &___m_target_2; }
	inline void set_m_target_2(RuntimeObject * value)
	{
		___m_target_2 = value;
		Il2CppCodeGenWriteBarrier((&___m_target_2), value);
	}

	inline static int32_t get_offset_of_method_3() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_3)); }
	inline intptr_t get_method_3() const { return ___method_3; }
	inline intptr_t* get_address_of_method_3() { return &___method_3; }
	inline void set_method_3(intptr_t value)
	{
		___method_3 = value;
	}

	inline static int32_t get_offset_of_delegate_trampoline_4() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___delegate_trampoline_4)); }
	inline intptr_t get_delegate_trampoline_4() const { return ___delegate_trampoline_4; }
	inline intptr_t* get_address_of_delegate_trampoline_4() { return &___delegate_trampoline_4; }
	inline void set_delegate_trampoline_4(intptr_t value)
	{
		___delegate_trampoline_4 = value;
	}

	inline static int32_t get_offset_of_method_code_5() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_code_5)); }
	inline intptr_t get_method_code_5() const { return ___method_code_5; }
	inline intptr_t* get_address_of_method_code_5() { return &___method_code_5; }
	inline void set_method_code_5(intptr_t value)
	{
		___method_code_5 = value;
	}

	inline static int32_t get_offset_of_method_info_6() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___method_info_6)); }
	inline MethodInfo_t * get_method_info_6() const { return ___method_info_6; }
	inline MethodInfo_t ** get_address_of_method_info_6() { return &___method_info_6; }
	inline void set_method_info_6(MethodInfo_t * value)
	{
		___method_info_6 = value;
		Il2CppCodeGenWriteBarrier((&___method_info_6), value);
	}

	inline static int32_t get_offset_of_original_method_info_7() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___original_method_info_7)); }
	inline MethodInfo_t * get_original_method_info_7() const { return ___original_method_info_7; }
	inline MethodInfo_t ** get_address_of_original_method_info_7() { return &___original_method_info_7; }
	inline void set_original_method_info_7(MethodInfo_t * value)
	{
		___original_method_info_7 = value;
		Il2CppCodeGenWriteBarrier((&___original_method_info_7), value);
	}

	inline static int32_t get_offset_of_data_8() { return static_cast<int32_t>(offsetof(Delegate_t1188392813, ___data_8)); }
	inline DelegateData_t1677132599 * get_data_8() const { return ___data_8; }
	inline DelegateData_t1677132599 ** get_address_of_data_8() { return &___data_8; }
	inline void set_data_8(DelegateData_t1677132599 * value)
	{
		___data_8 = value;
		Il2CppCodeGenWriteBarrier((&___data_8), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DELEGATE_T1188392813_H
#ifndef SENDMESSAGEOPTIONS_T3580193095_H
#define SENDMESSAGEOPTIONS_T3580193095_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.SendMessageOptions
struct  SendMessageOptions_t3580193095 
{
public:
	// System.Int32 UnityEngine.SendMessageOptions::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(SendMessageOptions_t3580193095, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SENDMESSAGEOPTIONS_T3580193095_H
#ifndef INDEXOUTOFRANGEEXCEPTION_T1578797820_H
#define INDEXOUTOFRANGEEXCEPTION_T1578797820_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.IndexOutOfRangeException
struct  IndexOutOfRangeException_t1578797820  : public SystemException_t176217640
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // INDEXOUTOFRANGEEXCEPTION_T1578797820_H
#ifndef WRAPMODE_T730450702_H
#define WRAPMODE_T730450702_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.WrapMode
struct  WrapMode_t730450702 
{
public:
	// System.Int32 UnityEngine.WrapMode::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(WrapMode_t730450702, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // WRAPMODE_T730450702_H
#ifndef METHODINFO_T_H
#define METHODINFO_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.MethodInfo
struct  MethodInfo_t  : public MethodBase_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // METHODINFO_T_H
#ifndef MATHFINTERNAL_T624072491_H
#define MATHFINTERNAL_T624072491_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngineInternal.MathfInternal
struct  MathfInternal_t624072491 
{
public:
	union
	{
		struct
		{
		};
		uint8_t MathfInternal_t624072491__padding[1];
	};

public:
};

struct MathfInternal_t624072491_StaticFields
{
public:
	// System.Single modreq(System.Runtime.CompilerServices.IsVolatile) UnityEngineInternal.MathfInternal::FloatMinNormal
	float ___FloatMinNormal_0;
	// System.Single modreq(System.Runtime.CompilerServices.IsVolatile) UnityEngineInternal.MathfInternal::FloatMinDenormal
	float ___FloatMinDenormal_1;
	// System.Boolean UnityEngineInternal.MathfInternal::IsFlushToZeroEnabled
	bool ___IsFlushToZeroEnabled_2;

public:
	inline static int32_t get_offset_of_FloatMinNormal_0() { return static_cast<int32_t>(offsetof(MathfInternal_t624072491_StaticFields, ___FloatMinNormal_0)); }
	inline float get_FloatMinNormal_0() const { return ___FloatMinNormal_0; }
	inline float* get_address_of_FloatMinNormal_0() { return &___FloatMinNormal_0; }
	inline void set_FloatMinNormal_0(float value)
	{
		___FloatMinNormal_0 = value;
	}

	inline static int32_t get_offset_of_FloatMinDenormal_1() { return static_cast<int32_t>(offsetof(MathfInternal_t624072491_StaticFields, ___FloatMinDenormal_1)); }
	inline float get_FloatMinDenormal_1() const { return ___FloatMinDenormal_1; }
	inline float* get_address_of_FloatMinDenormal_1() { return &___FloatMinDenormal_1; }
	inline void set_FloatMinDenormal_1(float value)
	{
		___FloatMinDenormal_1 = value;
	}

	inline static int32_t get_offset_of_IsFlushToZeroEnabled_2() { return static_cast<int32_t>(offsetof(MathfInternal_t624072491_StaticFields, ___IsFlushToZeroEnabled_2)); }
	inline bool get_IsFlushToZeroEnabled_2() const { return ___IsFlushToZeroEnabled_2; }
	inline bool* get_address_of_IsFlushToZeroEnabled_2() { return &___IsFlushToZeroEnabled_2; }
	inline void set_IsFlushToZeroEnabled_2(bool value)
	{
		___IsFlushToZeroEnabled_2 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MATHFINTERNAL_T624072491_H
#ifndef TOUCHTYPE_T2034578258_H
#define TOUCHTYPE_T2034578258_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.TouchType
struct  TouchType_t2034578258 
{
public:
	// System.Int32 UnityEngine.TouchType::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(TouchType_t2034578258, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TOUCHTYPE_T2034578258_H
#ifndef TOOLTIPATTRIBUTE_T3957072629_H
#define TOOLTIPATTRIBUTE_T3957072629_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.TooltipAttribute
struct  TooltipAttribute_t3957072629  : public PropertyAttribute_t3677895545
{
public:
	// System.String UnityEngine.TooltipAttribute::tooltip
	String_t* ___tooltip_0;

public:
	inline static int32_t get_offset_of_tooltip_0() { return static_cast<int32_t>(offsetof(TooltipAttribute_t3957072629, ___tooltip_0)); }
	inline String_t* get_tooltip_0() const { return ___tooltip_0; }
	inline String_t** get_address_of_tooltip_0() { return &___tooltip_0; }
	inline void set_tooltip_0(String_t* value)
	{
		___tooltip_0 = value;
		Il2CppCodeGenWriteBarrier((&___tooltip_0), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TOOLTIPATTRIBUTE_T3957072629_H
#ifndef TOUCHSCREENKEYBOARDTYPE_T1530597702_H
#define TOUCHSCREENKEYBOARDTYPE_T1530597702_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.TouchScreenKeyboardType
struct  TouchScreenKeyboardType_t1530597702 
{
public:
	// System.Int32 UnityEngine.TouchScreenKeyboardType::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(TouchScreenKeyboardType_t1530597702, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TOUCHSCREENKEYBOARDTYPE_T1530597702_H
#ifndef DEVICETYPE_T643007838_H
#define DEVICETYPE_T643007838_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.DeviceType
struct  DeviceType_t643007838 
{
public:
	// System.Int32 UnityEngine.DeviceType::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(DeviceType_t643007838, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DEVICETYPE_T643007838_H
#ifndef TRACKEDREFERENCE_T1199777556_H
#define TRACKEDREFERENCE_T1199777556_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.TrackedReference
struct  TrackedReference_t1199777556  : public RuntimeObject
{
public:
	// System.IntPtr UnityEngine.TrackedReference::m_Ptr
	intptr_t ___m_Ptr_0;

public:
	inline static int32_t get_offset_of_m_Ptr_0() { return static_cast<int32_t>(offsetof(TrackedReference_t1199777556, ___m_Ptr_0)); }
	inline intptr_t get_m_Ptr_0() const { return ___m_Ptr_0; }
	inline intptr_t* get_address_of_m_Ptr_0() { return &___m_Ptr_0; }
	inline void set_m_Ptr_0(intptr_t value)
	{
		___m_Ptr_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of UnityEngine.TrackedReference
struct TrackedReference_t1199777556_marshaled_pinvoke
{
	intptr_t ___m_Ptr_0;
};
// Native definition for COM marshalling of UnityEngine.TrackedReference
struct TrackedReference_t1199777556_marshaled_com
{
	intptr_t ___m_Ptr_0;
};
#endif // TRACKEDREFERENCE_T1199777556_H
#ifndef OPERATINGSYSTEMFAMILY_T1868066375_H
#define OPERATINGSYSTEMFAMILY_T1868066375_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.OperatingSystemFamily
struct  OperatingSystemFamily_t1868066375 
{
public:
	// System.Int32 UnityEngine.OperatingSystemFamily::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(OperatingSystemFamily_t1868066375, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // OPERATINGSYSTEMFAMILY_T1868066375_H
#ifndef TEXTAREAATTRIBUTE_T3326046611_H
#define TEXTAREAATTRIBUTE_T3326046611_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.TextAreaAttribute
struct  TextAreaAttribute_t3326046611  : public PropertyAttribute_t3677895545
{
public:
	// System.Int32 UnityEngine.TextAreaAttribute::minLines
	int32_t ___minLines_0;
	// System.Int32 UnityEngine.TextAreaAttribute::maxLines
	int32_t ___maxLines_1;

public:
	inline static int32_t get_offset_of_minLines_0() { return static_cast<int32_t>(offsetof(TextAreaAttribute_t3326046611, ___minLines_0)); }
	inline int32_t get_minLines_0() const { return ___minLines_0; }
	inline int32_t* get_address_of_minLines_0() { return &___minLines_0; }
	inline void set_minLines_0(int32_t value)
	{
		___minLines_0 = value;
	}

	inline static int32_t get_offset_of_maxLines_1() { return static_cast<int32_t>(offsetof(TextAreaAttribute_t3326046611, ___maxLines_1)); }
	inline int32_t get_maxLines_1() const { return ___maxLines_1; }
	inline int32_t* get_address_of_maxLines_1() { return &___maxLines_1; }
	inline void set_maxLines_1(int32_t value)
	{
		___maxLines_1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TEXTAREAATTRIBUTE_T3326046611_H
#ifndef TEXTUREWRAPMODE_T584250749_H
#define TEXTUREWRAPMODE_T584250749_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.TextureWrapMode
struct  TextureWrapMode_t584250749 
{
public:
	// System.Int32 UnityEngine.TextureWrapMode::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(TextureWrapMode_t584250749, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TEXTUREWRAPMODE_T584250749_H
#ifndef ARGUMENTEXCEPTION_T132251570_H
#define ARGUMENTEXCEPTION_T132251570_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.ArgumentException
struct  ArgumentException_t132251570  : public SystemException_t176217640
{
public:
	// System.String System.ArgumentException::param_name
	String_t* ___param_name_12;

public:
	inline static int32_t get_offset_of_param_name_12() { return static_cast<int32_t>(offsetof(ArgumentException_t132251570, ___param_name_12)); }
	inline String_t* get_param_name_12() const { return ___param_name_12; }
	inline String_t** get_address_of_param_name_12() { return &___param_name_12; }
	inline void set_param_name_12(String_t* value)
	{
		___param_name_12 = value;
		Il2CppCodeGenWriteBarrier((&___param_name_12), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ARGUMENTEXCEPTION_T132251570_H
#ifndef TEXTUREFORMAT_T2701165832_H
#define TEXTUREFORMAT_T2701165832_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.TextureFormat
struct  TextureFormat_t2701165832 
{
public:
	// System.Int32 UnityEngine.TextureFormat::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(TextureFormat_t2701165832, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TEXTUREFORMAT_T2701165832_H
#ifndef SPACE_T654135784_H
#define SPACE_T654135784_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Space
struct  Space_t654135784 
{
public:
	// System.Int32 UnityEngine.Space::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(Space_t654135784, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SPACE_T654135784_H
#ifndef SPACEATTRIBUTE_T3956583069_H
#define SPACEATTRIBUTE_T3956583069_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.SpaceAttribute
struct  SpaceAttribute_t3956583069  : public PropertyAttribute_t3677895545
{
public:
	// System.Single UnityEngine.SpaceAttribute::height
	float ___height_0;

public:
	inline static int32_t get_offset_of_height_0() { return static_cast<int32_t>(offsetof(SpaceAttribute_t3956583069, ___height_0)); }
	inline float get_height_0() const { return ___height_0; }
	inline float* get_address_of_height_0() { return &___height_0; }
	inline void set_height_0(float value)
	{
		___height_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SPACEATTRIBUTE_T3956583069_H
#ifndef TOUCHPHASE_T72348083_H
#define TOUCHPHASE_T72348083_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.TouchPhase
struct  TouchPhase_t72348083 
{
public:
	// System.Int32 UnityEngine.TouchPhase::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(TouchPhase_t72348083, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TOUCHPHASE_T72348083_H
#ifndef DATETIMEKIND_T3468814247_H
#define DATETIMEKIND_T3468814247_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.DateTimeKind
struct  DateTimeKind_t3468814247 
{
public:
	// System.Int32 System.DateTimeKind::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(DateTimeKind_t3468814247, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DATETIMEKIND_T3468814247_H
#ifndef SPRITEMESHTYPE_T1570978481_H
#define SPRITEMESHTYPE_T1570978481_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.SpriteMeshType
struct  SpriteMeshType_t1570978481 
{
public:
	// System.Int32 UnityEngine.SpriteMeshType::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(SpriteMeshType_t1570978481, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SPRITEMESHTYPE_T1570978481_H
#ifndef BINDINGFLAGS_T2721792723_H
#define BINDINGFLAGS_T2721792723_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.BindingFlags
struct  BindingFlags_t2721792723 
{
public:
	// System.Int32 System.Reflection.BindingFlags::value__
	int32_t ___value___1;

public:
	inline static int32_t get_offset_of_value___1() { return static_cast<int32_t>(offsetof(BindingFlags_t2721792723, ___value___1)); }
	inline int32_t get_value___1() const { return ___value___1; }
	inline int32_t* get_address_of_value___1() { return &___value___1; }
	inline void set_value___1(int32_t value)
	{
		___value___1 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BINDINGFLAGS_T2721792723_H
#ifndef GAMEOBJECT_T1113636619_H
#define GAMEOBJECT_T1113636619_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.GameObject
struct  GameObject_t1113636619  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // GAMEOBJECT_T1113636619_H
#ifndef SPRITEATLAS_T646931412_H
#define SPRITEATLAS_T646931412_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.U2D.SpriteAtlas
struct  SpriteAtlas_t646931412  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SPRITEATLAS_T646931412_H
#ifndef SPRITE_T280657092_H
#define SPRITE_T280657092_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Sprite
struct  Sprite_t280657092  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SPRITE_T280657092_H
#ifndef SHADER_T4151988712_H
#define SHADER_T4151988712_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Shader
struct  Shader_t4151988712  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SHADER_T4151988712_H
#ifndef PARAMETERINFO_T1861056598_H
#define PARAMETERINFO_T1861056598_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Reflection.ParameterInfo
struct  ParameterInfo_t1861056598  : public RuntimeObject
{
public:
	// System.Type System.Reflection.ParameterInfo::ClassImpl
	Type_t * ___ClassImpl_0;
	// System.Object System.Reflection.ParameterInfo::DefaultValueImpl
	RuntimeObject * ___DefaultValueImpl_1;
	// System.Reflection.MemberInfo System.Reflection.ParameterInfo::MemberImpl
	MemberInfo_t * ___MemberImpl_2;
	// System.String System.Reflection.ParameterInfo::NameImpl
	String_t* ___NameImpl_3;
	// System.Int32 System.Reflection.ParameterInfo::PositionImpl
	int32_t ___PositionImpl_4;
	// System.Reflection.ParameterAttributes System.Reflection.ParameterInfo::AttrsImpl
	int32_t ___AttrsImpl_5;
	// System.Reflection.Emit.UnmanagedMarshal System.Reflection.ParameterInfo::marshalAs
	UnmanagedMarshal_t984015687 * ___marshalAs_6;

public:
	inline static int32_t get_offset_of_ClassImpl_0() { return static_cast<int32_t>(offsetof(ParameterInfo_t1861056598, ___ClassImpl_0)); }
	inline Type_t * get_ClassImpl_0() const { return ___ClassImpl_0; }
	inline Type_t ** get_address_of_ClassImpl_0() { return &___ClassImpl_0; }
	inline void set_ClassImpl_0(Type_t * value)
	{
		___ClassImpl_0 = value;
		Il2CppCodeGenWriteBarrier((&___ClassImpl_0), value);
	}

	inline static int32_t get_offset_of_DefaultValueImpl_1() { return static_cast<int32_t>(offsetof(ParameterInfo_t1861056598, ___DefaultValueImpl_1)); }
	inline RuntimeObject * get_DefaultValueImpl_1() const { return ___DefaultValueImpl_1; }
	inline RuntimeObject ** get_address_of_DefaultValueImpl_1() { return &___DefaultValueImpl_1; }
	inline void set_DefaultValueImpl_1(RuntimeObject * value)
	{
		___DefaultValueImpl_1 = value;
		Il2CppCodeGenWriteBarrier((&___DefaultValueImpl_1), value);
	}

	inline static int32_t get_offset_of_MemberImpl_2() { return static_cast<int32_t>(offsetof(ParameterInfo_t1861056598, ___MemberImpl_2)); }
	inline MemberInfo_t * get_MemberImpl_2() const { return ___MemberImpl_2; }
	inline MemberInfo_t ** get_address_of_MemberImpl_2() { return &___MemberImpl_2; }
	inline void set_MemberImpl_2(MemberInfo_t * value)
	{
		___MemberImpl_2 = value;
		Il2CppCodeGenWriteBarrier((&___MemberImpl_2), value);
	}

	inline static int32_t get_offset_of_NameImpl_3() { return static_cast<int32_t>(offsetof(ParameterInfo_t1861056598, ___NameImpl_3)); }
	inline String_t* get_NameImpl_3() const { return ___NameImpl_3; }
	inline String_t** get_address_of_NameImpl_3() { return &___NameImpl_3; }
	inline void set_NameImpl_3(String_t* value)
	{
		___NameImpl_3 = value;
		Il2CppCodeGenWriteBarrier((&___NameImpl_3), value);
	}

	inline static int32_t get_offset_of_PositionImpl_4() { return static_cast<int32_t>(offsetof(ParameterInfo_t1861056598, ___PositionImpl_4)); }
	inline int32_t get_PositionImpl_4() const { return ___PositionImpl_4; }
	inline int32_t* get_address_of_PositionImpl_4() { return &___PositionImpl_4; }
	inline void set_PositionImpl_4(int32_t value)
	{
		___PositionImpl_4 = value;
	}

	inline static int32_t get_offset_of_AttrsImpl_5() { return static_cast<int32_t>(offsetof(ParameterInfo_t1861056598, ___AttrsImpl_5)); }
	inline int32_t get_AttrsImpl_5() const { return ___AttrsImpl_5; }
	inline int32_t* get_address_of_AttrsImpl_5() { return &___AttrsImpl_5; }
	inline void set_AttrsImpl_5(int32_t value)
	{
		___AttrsImpl_5 = value;
	}

	inline static int32_t get_offset_of_marshalAs_6() { return static_cast<int32_t>(offsetof(ParameterInfo_t1861056598, ___marshalAs_6)); }
	inline UnmanagedMarshal_t984015687 * get_marshalAs_6() const { return ___marshalAs_6; }
	inline UnmanagedMarshal_t984015687 ** get_address_of_marshalAs_6() { return &___marshalAs_6; }
	inline void set_marshalAs_6(UnmanagedMarshal_t984015687 * value)
	{
		___marshalAs_6 = value;
		Il2CppCodeGenWriteBarrier((&___marshalAs_6), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // PARAMETERINFO_T1861056598_H
#ifndef MULTICASTDELEGATE_T_H
#define MULTICASTDELEGATE_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.MulticastDelegate
struct  MulticastDelegate_t  : public Delegate_t1188392813
{
public:
	// System.MulticastDelegate System.MulticastDelegate::prev
	MulticastDelegate_t * ___prev_9;
	// System.MulticastDelegate System.MulticastDelegate::kpm_next
	MulticastDelegate_t * ___kpm_next_10;

public:
	inline static int32_t get_offset_of_prev_9() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___prev_9)); }
	inline MulticastDelegate_t * get_prev_9() const { return ___prev_9; }
	inline MulticastDelegate_t ** get_address_of_prev_9() { return &___prev_9; }
	inline void set_prev_9(MulticastDelegate_t * value)
	{
		___prev_9 = value;
		Il2CppCodeGenWriteBarrier((&___prev_9), value);
	}

	inline static int32_t get_offset_of_kpm_next_10() { return static_cast<int32_t>(offsetof(MulticastDelegate_t, ___kpm_next_10)); }
	inline MulticastDelegate_t * get_kpm_next_10() const { return ___kpm_next_10; }
	inline MulticastDelegate_t ** get_address_of_kpm_next_10() { return &___kpm_next_10; }
	inline void set_kpm_next_10(MulticastDelegate_t * value)
	{
		___kpm_next_10 = value;
		Il2CppCodeGenWriteBarrier((&___kpm_next_10), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MULTICASTDELEGATE_T_H
#ifndef DATETIME_T3738529785_H
#define DATETIME_T3738529785_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.DateTime
struct  DateTime_t3738529785 
{
public:
	// System.TimeSpan System.DateTime::ticks
	TimeSpan_t881159249  ___ticks_0;
	// System.DateTimeKind System.DateTime::kind
	int32_t ___kind_1;

public:
	inline static int32_t get_offset_of_ticks_0() { return static_cast<int32_t>(offsetof(DateTime_t3738529785, ___ticks_0)); }
	inline TimeSpan_t881159249  get_ticks_0() const { return ___ticks_0; }
	inline TimeSpan_t881159249 * get_address_of_ticks_0() { return &___ticks_0; }
	inline void set_ticks_0(TimeSpan_t881159249  value)
	{
		___ticks_0 = value;
	}

	inline static int32_t get_offset_of_kind_1() { return static_cast<int32_t>(offsetof(DateTime_t3738529785, ___kind_1)); }
	inline int32_t get_kind_1() const { return ___kind_1; }
	inline int32_t* get_address_of_kind_1() { return &___kind_1; }
	inline void set_kind_1(int32_t value)
	{
		___kind_1 = value;
	}
};

struct DateTime_t3738529785_StaticFields
{
public:
	// System.DateTime System.DateTime::MaxValue
	DateTime_t3738529785  ___MaxValue_2;
	// System.DateTime System.DateTime::MinValue
	DateTime_t3738529785  ___MinValue_3;
	// System.String[] System.DateTime::ParseTimeFormats
	StringU5BU5D_t1281789340* ___ParseTimeFormats_4;
	// System.String[] System.DateTime::ParseYearDayMonthFormats
	StringU5BU5D_t1281789340* ___ParseYearDayMonthFormats_5;
	// System.String[] System.DateTime::ParseYearMonthDayFormats
	StringU5BU5D_t1281789340* ___ParseYearMonthDayFormats_6;
	// System.String[] System.DateTime::ParseDayMonthYearFormats
	StringU5BU5D_t1281789340* ___ParseDayMonthYearFormats_7;
	// System.String[] System.DateTime::ParseMonthDayYearFormats
	StringU5BU5D_t1281789340* ___ParseMonthDayYearFormats_8;
	// System.String[] System.DateTime::MonthDayShortFormats
	StringU5BU5D_t1281789340* ___MonthDayShortFormats_9;
	// System.String[] System.DateTime::DayMonthShortFormats
	StringU5BU5D_t1281789340* ___DayMonthShortFormats_10;
	// System.Int32[] System.DateTime::daysmonth
	Int32U5BU5D_t385246372* ___daysmonth_11;
	// System.Int32[] System.DateTime::daysmonthleap
	Int32U5BU5D_t385246372* ___daysmonthleap_12;
	// System.Object System.DateTime::to_local_time_span_object
	RuntimeObject * ___to_local_time_span_object_13;
	// System.Int64 System.DateTime::last_now
	int64_t ___last_now_14;

public:
	inline static int32_t get_offset_of_MaxValue_2() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___MaxValue_2)); }
	inline DateTime_t3738529785  get_MaxValue_2() const { return ___MaxValue_2; }
	inline DateTime_t3738529785 * get_address_of_MaxValue_2() { return &___MaxValue_2; }
	inline void set_MaxValue_2(DateTime_t3738529785  value)
	{
		___MaxValue_2 = value;
	}

	inline static int32_t get_offset_of_MinValue_3() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___MinValue_3)); }
	inline DateTime_t3738529785  get_MinValue_3() const { return ___MinValue_3; }
	inline DateTime_t3738529785 * get_address_of_MinValue_3() { return &___MinValue_3; }
	inline void set_MinValue_3(DateTime_t3738529785  value)
	{
		___MinValue_3 = value;
	}

	inline static int32_t get_offset_of_ParseTimeFormats_4() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___ParseTimeFormats_4)); }
	inline StringU5BU5D_t1281789340* get_ParseTimeFormats_4() const { return ___ParseTimeFormats_4; }
	inline StringU5BU5D_t1281789340** get_address_of_ParseTimeFormats_4() { return &___ParseTimeFormats_4; }
	inline void set_ParseTimeFormats_4(StringU5BU5D_t1281789340* value)
	{
		___ParseTimeFormats_4 = value;
		Il2CppCodeGenWriteBarrier((&___ParseTimeFormats_4), value);
	}

	inline static int32_t get_offset_of_ParseYearDayMonthFormats_5() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___ParseYearDayMonthFormats_5)); }
	inline StringU5BU5D_t1281789340* get_ParseYearDayMonthFormats_5() const { return ___ParseYearDayMonthFormats_5; }
	inline StringU5BU5D_t1281789340** get_address_of_ParseYearDayMonthFormats_5() { return &___ParseYearDayMonthFormats_5; }
	inline void set_ParseYearDayMonthFormats_5(StringU5BU5D_t1281789340* value)
	{
		___ParseYearDayMonthFormats_5 = value;
		Il2CppCodeGenWriteBarrier((&___ParseYearDayMonthFormats_5), value);
	}

	inline static int32_t get_offset_of_ParseYearMonthDayFormats_6() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___ParseYearMonthDayFormats_6)); }
	inline StringU5BU5D_t1281789340* get_ParseYearMonthDayFormats_6() const { return ___ParseYearMonthDayFormats_6; }
	inline StringU5BU5D_t1281789340** get_address_of_ParseYearMonthDayFormats_6() { return &___ParseYearMonthDayFormats_6; }
	inline void set_ParseYearMonthDayFormats_6(StringU5BU5D_t1281789340* value)
	{
		___ParseYearMonthDayFormats_6 = value;
		Il2CppCodeGenWriteBarrier((&___ParseYearMonthDayFormats_6), value);
	}

	inline static int32_t get_offset_of_ParseDayMonthYearFormats_7() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___ParseDayMonthYearFormats_7)); }
	inline StringU5BU5D_t1281789340* get_ParseDayMonthYearFormats_7() const { return ___ParseDayMonthYearFormats_7; }
	inline StringU5BU5D_t1281789340** get_address_of_ParseDayMonthYearFormats_7() { return &___ParseDayMonthYearFormats_7; }
	inline void set_ParseDayMonthYearFormats_7(StringU5BU5D_t1281789340* value)
	{
		___ParseDayMonthYearFormats_7 = value;
		Il2CppCodeGenWriteBarrier((&___ParseDayMonthYearFormats_7), value);
	}

	inline static int32_t get_offset_of_ParseMonthDayYearFormats_8() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___ParseMonthDayYearFormats_8)); }
	inline StringU5BU5D_t1281789340* get_ParseMonthDayYearFormats_8() const { return ___ParseMonthDayYearFormats_8; }
	inline StringU5BU5D_t1281789340** get_address_of_ParseMonthDayYearFormats_8() { return &___ParseMonthDayYearFormats_8; }
	inline void set_ParseMonthDayYearFormats_8(StringU5BU5D_t1281789340* value)
	{
		___ParseMonthDayYearFormats_8 = value;
		Il2CppCodeGenWriteBarrier((&___ParseMonthDayYearFormats_8), value);
	}

	inline static int32_t get_offset_of_MonthDayShortFormats_9() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___MonthDayShortFormats_9)); }
	inline StringU5BU5D_t1281789340* get_MonthDayShortFormats_9() const { return ___MonthDayShortFormats_9; }
	inline StringU5BU5D_t1281789340** get_address_of_MonthDayShortFormats_9() { return &___MonthDayShortFormats_9; }
	inline void set_MonthDayShortFormats_9(StringU5BU5D_t1281789340* value)
	{
		___MonthDayShortFormats_9 = value;
		Il2CppCodeGenWriteBarrier((&___MonthDayShortFormats_9), value);
	}

	inline static int32_t get_offset_of_DayMonthShortFormats_10() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___DayMonthShortFormats_10)); }
	inline StringU5BU5D_t1281789340* get_DayMonthShortFormats_10() const { return ___DayMonthShortFormats_10; }
	inline StringU5BU5D_t1281789340** get_address_of_DayMonthShortFormats_10() { return &___DayMonthShortFormats_10; }
	inline void set_DayMonthShortFormats_10(StringU5BU5D_t1281789340* value)
	{
		___DayMonthShortFormats_10 = value;
		Il2CppCodeGenWriteBarrier((&___DayMonthShortFormats_10), value);
	}

	inline static int32_t get_offset_of_daysmonth_11() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___daysmonth_11)); }
	inline Int32U5BU5D_t385246372* get_daysmonth_11() const { return ___daysmonth_11; }
	inline Int32U5BU5D_t385246372** get_address_of_daysmonth_11() { return &___daysmonth_11; }
	inline void set_daysmonth_11(Int32U5BU5D_t385246372* value)
	{
		___daysmonth_11 = value;
		Il2CppCodeGenWriteBarrier((&___daysmonth_11), value);
	}

	inline static int32_t get_offset_of_daysmonthleap_12() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___daysmonthleap_12)); }
	inline Int32U5BU5D_t385246372* get_daysmonthleap_12() const { return ___daysmonthleap_12; }
	inline Int32U5BU5D_t385246372** get_address_of_daysmonthleap_12() { return &___daysmonthleap_12; }
	inline void set_daysmonthleap_12(Int32U5BU5D_t385246372* value)
	{
		___daysmonthleap_12 = value;
		Il2CppCodeGenWriteBarrier((&___daysmonthleap_12), value);
	}

	inline static int32_t get_offset_of_to_local_time_span_object_13() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___to_local_time_span_object_13)); }
	inline RuntimeObject * get_to_local_time_span_object_13() const { return ___to_local_time_span_object_13; }
	inline RuntimeObject ** get_address_of_to_local_time_span_object_13() { return &___to_local_time_span_object_13; }
	inline void set_to_local_time_span_object_13(RuntimeObject * value)
	{
		___to_local_time_span_object_13 = value;
		Il2CppCodeGenWriteBarrier((&___to_local_time_span_object_13), value);
	}

	inline static int32_t get_offset_of_last_now_14() { return static_cast<int32_t>(offsetof(DateTime_t3738529785_StaticFields, ___last_now_14)); }
	inline int64_t get_last_now_14() const { return ___last_now_14; }
	inline int64_t* get_address_of_last_now_14() { return &___last_now_14; }
	inline void set_last_now_14(int64_t value)
	{
		___last_now_14 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // DATETIME_T3738529785_H
#ifndef TYPE_T_H
#define TYPE_T_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Type
struct  Type_t  : public MemberInfo_t
{
public:
	// System.RuntimeTypeHandle System.Type::_impl
	RuntimeTypeHandle_t3027515415  ____impl_1;

public:
	inline static int32_t get_offset_of__impl_1() { return static_cast<int32_t>(offsetof(Type_t, ____impl_1)); }
	inline RuntimeTypeHandle_t3027515415  get__impl_1() const { return ____impl_1; }
	inline RuntimeTypeHandle_t3027515415 * get_address_of__impl_1() { return &____impl_1; }
	inline void set__impl_1(RuntimeTypeHandle_t3027515415  value)
	{
		____impl_1 = value;
	}
};

struct Type_t_StaticFields
{
public:
	// System.Char System.Type::Delimiter
	Il2CppChar ___Delimiter_2;
	// System.Type[] System.Type::EmptyTypes
	TypeU5BU5D_t3940880105* ___EmptyTypes_3;
	// System.Reflection.MemberFilter System.Type::FilterAttribute
	MemberFilter_t426314064 * ___FilterAttribute_4;
	// System.Reflection.MemberFilter System.Type::FilterName
	MemberFilter_t426314064 * ___FilterName_5;
	// System.Reflection.MemberFilter System.Type::FilterNameIgnoreCase
	MemberFilter_t426314064 * ___FilterNameIgnoreCase_6;
	// System.Object System.Type::Missing
	RuntimeObject * ___Missing_7;

public:
	inline static int32_t get_offset_of_Delimiter_2() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Delimiter_2)); }
	inline Il2CppChar get_Delimiter_2() const { return ___Delimiter_2; }
	inline Il2CppChar* get_address_of_Delimiter_2() { return &___Delimiter_2; }
	inline void set_Delimiter_2(Il2CppChar value)
	{
		___Delimiter_2 = value;
	}

	inline static int32_t get_offset_of_EmptyTypes_3() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___EmptyTypes_3)); }
	inline TypeU5BU5D_t3940880105* get_EmptyTypes_3() const { return ___EmptyTypes_3; }
	inline TypeU5BU5D_t3940880105** get_address_of_EmptyTypes_3() { return &___EmptyTypes_3; }
	inline void set_EmptyTypes_3(TypeU5BU5D_t3940880105* value)
	{
		___EmptyTypes_3 = value;
		Il2CppCodeGenWriteBarrier((&___EmptyTypes_3), value);
	}

	inline static int32_t get_offset_of_FilterAttribute_4() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterAttribute_4)); }
	inline MemberFilter_t426314064 * get_FilterAttribute_4() const { return ___FilterAttribute_4; }
	inline MemberFilter_t426314064 ** get_address_of_FilterAttribute_4() { return &___FilterAttribute_4; }
	inline void set_FilterAttribute_4(MemberFilter_t426314064 * value)
	{
		___FilterAttribute_4 = value;
		Il2CppCodeGenWriteBarrier((&___FilterAttribute_4), value);
	}

	inline static int32_t get_offset_of_FilterName_5() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterName_5)); }
	inline MemberFilter_t426314064 * get_FilterName_5() const { return ___FilterName_5; }
	inline MemberFilter_t426314064 ** get_address_of_FilterName_5() { return &___FilterName_5; }
	inline void set_FilterName_5(MemberFilter_t426314064 * value)
	{
		___FilterName_5 = value;
		Il2CppCodeGenWriteBarrier((&___FilterName_5), value);
	}

	inline static int32_t get_offset_of_FilterNameIgnoreCase_6() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___FilterNameIgnoreCase_6)); }
	inline MemberFilter_t426314064 * get_FilterNameIgnoreCase_6() const { return ___FilterNameIgnoreCase_6; }
	inline MemberFilter_t426314064 ** get_address_of_FilterNameIgnoreCase_6() { return &___FilterNameIgnoreCase_6; }
	inline void set_FilterNameIgnoreCase_6(MemberFilter_t426314064 * value)
	{
		___FilterNameIgnoreCase_6 = value;
		Il2CppCodeGenWriteBarrier((&___FilterNameIgnoreCase_6), value);
	}

	inline static int32_t get_offset_of_Missing_7() { return static_cast<int32_t>(offsetof(Type_t_StaticFields, ___Missing_7)); }
	inline RuntimeObject * get_Missing_7() const { return ___Missing_7; }
	inline RuntimeObject ** get_address_of_Missing_7() { return &___Missing_7; }
	inline void set_Missing_7(RuntimeObject * value)
	{
		___Missing_7 = value;
		Il2CppCodeGenWriteBarrier((&___Missing_7), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TYPE_T_H
#ifndef EVENTWAITHANDLE_T777845177_H
#define EVENTWAITHANDLE_T777845177_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Threading.EventWaitHandle
struct  EventWaitHandle_t777845177  : public WaitHandle_t1743403487
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // EVENTWAITHANDLE_T777845177_H
#ifndef THREAD_T2300836069_H
#define THREAD_T2300836069_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Threading.Thread
struct  Thread_t2300836069  : public CriticalFinalizerObject_t701527852
{
public:
	// System.Int32 System.Threading.Thread::lock_thread_id
	int32_t ___lock_thread_id_0;
	// System.IntPtr System.Threading.Thread::system_thread_handle
	intptr_t ___system_thread_handle_1;
	// System.Object System.Threading.Thread::cached_culture_info
	RuntimeObject * ___cached_culture_info_2;
	// System.IntPtr System.Threading.Thread::unused0
	intptr_t ___unused0_3;
	// System.Boolean System.Threading.Thread::threadpool_thread
	bool ___threadpool_thread_4;
	// System.IntPtr System.Threading.Thread::name
	intptr_t ___name_5;
	// System.Int32 System.Threading.Thread::name_len
	int32_t ___name_len_6;
	// System.Threading.ThreadState System.Threading.Thread::state
	int32_t ___state_7;
	// System.Object System.Threading.Thread::abort_exc
	RuntimeObject * ___abort_exc_8;
	// System.Int32 System.Threading.Thread::abort_state_handle
	int32_t ___abort_state_handle_9;
	// System.Int64 System.Threading.Thread::thread_id
	int64_t ___thread_id_10;
	// System.IntPtr System.Threading.Thread::start_notify
	intptr_t ___start_notify_11;
	// System.IntPtr System.Threading.Thread::stack_ptr
	intptr_t ___stack_ptr_12;
	// System.UIntPtr System.Threading.Thread::static_data
	uintptr_t ___static_data_13;
	// System.IntPtr System.Threading.Thread::jit_data
	intptr_t ___jit_data_14;
	// System.IntPtr System.Threading.Thread::lock_data
	intptr_t ___lock_data_15;
	// System.Object System.Threading.Thread::current_appcontext
	RuntimeObject * ___current_appcontext_16;
	// System.Int32 System.Threading.Thread::stack_size
	int32_t ___stack_size_17;
	// System.Object System.Threading.Thread::start_obj
	RuntimeObject * ___start_obj_18;
	// System.IntPtr System.Threading.Thread::appdomain_refs
	intptr_t ___appdomain_refs_19;
	// System.Int32 System.Threading.Thread::interruption_requested
	int32_t ___interruption_requested_20;
	// System.IntPtr System.Threading.Thread::suspend_event
	intptr_t ___suspend_event_21;
	// System.IntPtr System.Threading.Thread::suspended_event
	intptr_t ___suspended_event_22;
	// System.IntPtr System.Threading.Thread::resume_event
	intptr_t ___resume_event_23;
	// System.IntPtr System.Threading.Thread::synch_cs
	intptr_t ___synch_cs_24;
	// System.IntPtr System.Threading.Thread::serialized_culture_info
	intptr_t ___serialized_culture_info_25;
	// System.Int32 System.Threading.Thread::serialized_culture_info_len
	int32_t ___serialized_culture_info_len_26;
	// System.IntPtr System.Threading.Thread::serialized_ui_culture_info
	intptr_t ___serialized_ui_culture_info_27;
	// System.Int32 System.Threading.Thread::serialized_ui_culture_info_len
	int32_t ___serialized_ui_culture_info_len_28;
	// System.Boolean System.Threading.Thread::thread_dump_requested
	bool ___thread_dump_requested_29;
	// System.IntPtr System.Threading.Thread::end_stack
	intptr_t ___end_stack_30;
	// System.Boolean System.Threading.Thread::thread_interrupt_requested
	bool ___thread_interrupt_requested_31;
	// System.Byte System.Threading.Thread::apartment_state
	uint8_t ___apartment_state_32;
	// System.Int32 modreq(System.Runtime.CompilerServices.IsVolatile) System.Threading.Thread::critical_region_level
	int32_t ___critical_region_level_33;
	// System.Int32 System.Threading.Thread::small_id
	int32_t ___small_id_34;
	// System.IntPtr System.Threading.Thread::manage_callback
	intptr_t ___manage_callback_35;
	// System.Object System.Threading.Thread::pending_exception
	RuntimeObject * ___pending_exception_36;
	// System.Threading.ExecutionContext System.Threading.Thread::ec_to_set
	ExecutionContext_t1748372627 * ___ec_to_set_37;
	// System.IntPtr System.Threading.Thread::interrupt_on_stop
	intptr_t ___interrupt_on_stop_38;
	// System.IntPtr System.Threading.Thread::unused3
	intptr_t ___unused3_39;
	// System.IntPtr System.Threading.Thread::unused4
	intptr_t ___unused4_40;
	// System.IntPtr System.Threading.Thread::unused5
	intptr_t ___unused5_41;
	// System.IntPtr System.Threading.Thread::unused6
	intptr_t ___unused6_42;
	// System.MulticastDelegate System.Threading.Thread::threadstart
	MulticastDelegate_t * ___threadstart_45;
	// System.Int32 System.Threading.Thread::managed_id
	int32_t ___managed_id_46;
	// System.Security.Principal.IPrincipal System.Threading.Thread::_principal
	RuntimeObject* ____principal_47;
	// System.Boolean System.Threading.Thread::in_currentculture
	bool ___in_currentculture_50;

public:
	inline static int32_t get_offset_of_lock_thread_id_0() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___lock_thread_id_0)); }
	inline int32_t get_lock_thread_id_0() const { return ___lock_thread_id_0; }
	inline int32_t* get_address_of_lock_thread_id_0() { return &___lock_thread_id_0; }
	inline void set_lock_thread_id_0(int32_t value)
	{
		___lock_thread_id_0 = value;
	}

	inline static int32_t get_offset_of_system_thread_handle_1() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___system_thread_handle_1)); }
	inline intptr_t get_system_thread_handle_1() const { return ___system_thread_handle_1; }
	inline intptr_t* get_address_of_system_thread_handle_1() { return &___system_thread_handle_1; }
	inline void set_system_thread_handle_1(intptr_t value)
	{
		___system_thread_handle_1 = value;
	}

	inline static int32_t get_offset_of_cached_culture_info_2() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___cached_culture_info_2)); }
	inline RuntimeObject * get_cached_culture_info_2() const { return ___cached_culture_info_2; }
	inline RuntimeObject ** get_address_of_cached_culture_info_2() { return &___cached_culture_info_2; }
	inline void set_cached_culture_info_2(RuntimeObject * value)
	{
		___cached_culture_info_2 = value;
		Il2CppCodeGenWriteBarrier((&___cached_culture_info_2), value);
	}

	inline static int32_t get_offset_of_unused0_3() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___unused0_3)); }
	inline intptr_t get_unused0_3() const { return ___unused0_3; }
	inline intptr_t* get_address_of_unused0_3() { return &___unused0_3; }
	inline void set_unused0_3(intptr_t value)
	{
		___unused0_3 = value;
	}

	inline static int32_t get_offset_of_threadpool_thread_4() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___threadpool_thread_4)); }
	inline bool get_threadpool_thread_4() const { return ___threadpool_thread_4; }
	inline bool* get_address_of_threadpool_thread_4() { return &___threadpool_thread_4; }
	inline void set_threadpool_thread_4(bool value)
	{
		___threadpool_thread_4 = value;
	}

	inline static int32_t get_offset_of_name_5() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___name_5)); }
	inline intptr_t get_name_5() const { return ___name_5; }
	inline intptr_t* get_address_of_name_5() { return &___name_5; }
	inline void set_name_5(intptr_t value)
	{
		___name_5 = value;
	}

	inline static int32_t get_offset_of_name_len_6() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___name_len_6)); }
	inline int32_t get_name_len_6() const { return ___name_len_6; }
	inline int32_t* get_address_of_name_len_6() { return &___name_len_6; }
	inline void set_name_len_6(int32_t value)
	{
		___name_len_6 = value;
	}

	inline static int32_t get_offset_of_state_7() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___state_7)); }
	inline int32_t get_state_7() const { return ___state_7; }
	inline int32_t* get_address_of_state_7() { return &___state_7; }
	inline void set_state_7(int32_t value)
	{
		___state_7 = value;
	}

	inline static int32_t get_offset_of_abort_exc_8() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___abort_exc_8)); }
	inline RuntimeObject * get_abort_exc_8() const { return ___abort_exc_8; }
	inline RuntimeObject ** get_address_of_abort_exc_8() { return &___abort_exc_8; }
	inline void set_abort_exc_8(RuntimeObject * value)
	{
		___abort_exc_8 = value;
		Il2CppCodeGenWriteBarrier((&___abort_exc_8), value);
	}

	inline static int32_t get_offset_of_abort_state_handle_9() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___abort_state_handle_9)); }
	inline int32_t get_abort_state_handle_9() const { return ___abort_state_handle_9; }
	inline int32_t* get_address_of_abort_state_handle_9() { return &___abort_state_handle_9; }
	inline void set_abort_state_handle_9(int32_t value)
	{
		___abort_state_handle_9 = value;
	}

	inline static int32_t get_offset_of_thread_id_10() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___thread_id_10)); }
	inline int64_t get_thread_id_10() const { return ___thread_id_10; }
	inline int64_t* get_address_of_thread_id_10() { return &___thread_id_10; }
	inline void set_thread_id_10(int64_t value)
	{
		___thread_id_10 = value;
	}

	inline static int32_t get_offset_of_start_notify_11() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___start_notify_11)); }
	inline intptr_t get_start_notify_11() const { return ___start_notify_11; }
	inline intptr_t* get_address_of_start_notify_11() { return &___start_notify_11; }
	inline void set_start_notify_11(intptr_t value)
	{
		___start_notify_11 = value;
	}

	inline static int32_t get_offset_of_stack_ptr_12() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___stack_ptr_12)); }
	inline intptr_t get_stack_ptr_12() const { return ___stack_ptr_12; }
	inline intptr_t* get_address_of_stack_ptr_12() { return &___stack_ptr_12; }
	inline void set_stack_ptr_12(intptr_t value)
	{
		___stack_ptr_12 = value;
	}

	inline static int32_t get_offset_of_static_data_13() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___static_data_13)); }
	inline uintptr_t get_static_data_13() const { return ___static_data_13; }
	inline uintptr_t* get_address_of_static_data_13() { return &___static_data_13; }
	inline void set_static_data_13(uintptr_t value)
	{
		___static_data_13 = value;
	}

	inline static int32_t get_offset_of_jit_data_14() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___jit_data_14)); }
	inline intptr_t get_jit_data_14() const { return ___jit_data_14; }
	inline intptr_t* get_address_of_jit_data_14() { return &___jit_data_14; }
	inline void set_jit_data_14(intptr_t value)
	{
		___jit_data_14 = value;
	}

	inline static int32_t get_offset_of_lock_data_15() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___lock_data_15)); }
	inline intptr_t get_lock_data_15() const { return ___lock_data_15; }
	inline intptr_t* get_address_of_lock_data_15() { return &___lock_data_15; }
	inline void set_lock_data_15(intptr_t value)
	{
		___lock_data_15 = value;
	}

	inline static int32_t get_offset_of_current_appcontext_16() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___current_appcontext_16)); }
	inline RuntimeObject * get_current_appcontext_16() const { return ___current_appcontext_16; }
	inline RuntimeObject ** get_address_of_current_appcontext_16() { return &___current_appcontext_16; }
	inline void set_current_appcontext_16(RuntimeObject * value)
	{
		___current_appcontext_16 = value;
		Il2CppCodeGenWriteBarrier((&___current_appcontext_16), value);
	}

	inline static int32_t get_offset_of_stack_size_17() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___stack_size_17)); }
	inline int32_t get_stack_size_17() const { return ___stack_size_17; }
	inline int32_t* get_address_of_stack_size_17() { return &___stack_size_17; }
	inline void set_stack_size_17(int32_t value)
	{
		___stack_size_17 = value;
	}

	inline static int32_t get_offset_of_start_obj_18() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___start_obj_18)); }
	inline RuntimeObject * get_start_obj_18() const { return ___start_obj_18; }
	inline RuntimeObject ** get_address_of_start_obj_18() { return &___start_obj_18; }
	inline void set_start_obj_18(RuntimeObject * value)
	{
		___start_obj_18 = value;
		Il2CppCodeGenWriteBarrier((&___start_obj_18), value);
	}

	inline static int32_t get_offset_of_appdomain_refs_19() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___appdomain_refs_19)); }
	inline intptr_t get_appdomain_refs_19() const { return ___appdomain_refs_19; }
	inline intptr_t* get_address_of_appdomain_refs_19() { return &___appdomain_refs_19; }
	inline void set_appdomain_refs_19(intptr_t value)
	{
		___appdomain_refs_19 = value;
	}

	inline static int32_t get_offset_of_interruption_requested_20() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___interruption_requested_20)); }
	inline int32_t get_interruption_requested_20() const { return ___interruption_requested_20; }
	inline int32_t* get_address_of_interruption_requested_20() { return &___interruption_requested_20; }
	inline void set_interruption_requested_20(int32_t value)
	{
		___interruption_requested_20 = value;
	}

	inline static int32_t get_offset_of_suspend_event_21() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___suspend_event_21)); }
	inline intptr_t get_suspend_event_21() const { return ___suspend_event_21; }
	inline intptr_t* get_address_of_suspend_event_21() { return &___suspend_event_21; }
	inline void set_suspend_event_21(intptr_t value)
	{
		___suspend_event_21 = value;
	}

	inline static int32_t get_offset_of_suspended_event_22() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___suspended_event_22)); }
	inline intptr_t get_suspended_event_22() const { return ___suspended_event_22; }
	inline intptr_t* get_address_of_suspended_event_22() { return &___suspended_event_22; }
	inline void set_suspended_event_22(intptr_t value)
	{
		___suspended_event_22 = value;
	}

	inline static int32_t get_offset_of_resume_event_23() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___resume_event_23)); }
	inline intptr_t get_resume_event_23() const { return ___resume_event_23; }
	inline intptr_t* get_address_of_resume_event_23() { return &___resume_event_23; }
	inline void set_resume_event_23(intptr_t value)
	{
		___resume_event_23 = value;
	}

	inline static int32_t get_offset_of_synch_cs_24() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___synch_cs_24)); }
	inline intptr_t get_synch_cs_24() const { return ___synch_cs_24; }
	inline intptr_t* get_address_of_synch_cs_24() { return &___synch_cs_24; }
	inline void set_synch_cs_24(intptr_t value)
	{
		___synch_cs_24 = value;
	}

	inline static int32_t get_offset_of_serialized_culture_info_25() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___serialized_culture_info_25)); }
	inline intptr_t get_serialized_culture_info_25() const { return ___serialized_culture_info_25; }
	inline intptr_t* get_address_of_serialized_culture_info_25() { return &___serialized_culture_info_25; }
	inline void set_serialized_culture_info_25(intptr_t value)
	{
		___serialized_culture_info_25 = value;
	}

	inline static int32_t get_offset_of_serialized_culture_info_len_26() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___serialized_culture_info_len_26)); }
	inline int32_t get_serialized_culture_info_len_26() const { return ___serialized_culture_info_len_26; }
	inline int32_t* get_address_of_serialized_culture_info_len_26() { return &___serialized_culture_info_len_26; }
	inline void set_serialized_culture_info_len_26(int32_t value)
	{
		___serialized_culture_info_len_26 = value;
	}

	inline static int32_t get_offset_of_serialized_ui_culture_info_27() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___serialized_ui_culture_info_27)); }
	inline intptr_t get_serialized_ui_culture_info_27() const { return ___serialized_ui_culture_info_27; }
	inline intptr_t* get_address_of_serialized_ui_culture_info_27() { return &___serialized_ui_culture_info_27; }
	inline void set_serialized_ui_culture_info_27(intptr_t value)
	{
		___serialized_ui_culture_info_27 = value;
	}

	inline static int32_t get_offset_of_serialized_ui_culture_info_len_28() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___serialized_ui_culture_info_len_28)); }
	inline int32_t get_serialized_ui_culture_info_len_28() const { return ___serialized_ui_culture_info_len_28; }
	inline int32_t* get_address_of_serialized_ui_culture_info_len_28() { return &___serialized_ui_culture_info_len_28; }
	inline void set_serialized_ui_culture_info_len_28(int32_t value)
	{
		___serialized_ui_culture_info_len_28 = value;
	}

	inline static int32_t get_offset_of_thread_dump_requested_29() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___thread_dump_requested_29)); }
	inline bool get_thread_dump_requested_29() const { return ___thread_dump_requested_29; }
	inline bool* get_address_of_thread_dump_requested_29() { return &___thread_dump_requested_29; }
	inline void set_thread_dump_requested_29(bool value)
	{
		___thread_dump_requested_29 = value;
	}

	inline static int32_t get_offset_of_end_stack_30() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___end_stack_30)); }
	inline intptr_t get_end_stack_30() const { return ___end_stack_30; }
	inline intptr_t* get_address_of_end_stack_30() { return &___end_stack_30; }
	inline void set_end_stack_30(intptr_t value)
	{
		___end_stack_30 = value;
	}

	inline static int32_t get_offset_of_thread_interrupt_requested_31() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___thread_interrupt_requested_31)); }
	inline bool get_thread_interrupt_requested_31() const { return ___thread_interrupt_requested_31; }
	inline bool* get_address_of_thread_interrupt_requested_31() { return &___thread_interrupt_requested_31; }
	inline void set_thread_interrupt_requested_31(bool value)
	{
		___thread_interrupt_requested_31 = value;
	}

	inline static int32_t get_offset_of_apartment_state_32() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___apartment_state_32)); }
	inline uint8_t get_apartment_state_32() const { return ___apartment_state_32; }
	inline uint8_t* get_address_of_apartment_state_32() { return &___apartment_state_32; }
	inline void set_apartment_state_32(uint8_t value)
	{
		___apartment_state_32 = value;
	}

	inline static int32_t get_offset_of_critical_region_level_33() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___critical_region_level_33)); }
	inline int32_t get_critical_region_level_33() const { return ___critical_region_level_33; }
	inline int32_t* get_address_of_critical_region_level_33() { return &___critical_region_level_33; }
	inline void set_critical_region_level_33(int32_t value)
	{
		___critical_region_level_33 = value;
	}

	inline static int32_t get_offset_of_small_id_34() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___small_id_34)); }
	inline int32_t get_small_id_34() const { return ___small_id_34; }
	inline int32_t* get_address_of_small_id_34() { return &___small_id_34; }
	inline void set_small_id_34(int32_t value)
	{
		___small_id_34 = value;
	}

	inline static int32_t get_offset_of_manage_callback_35() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___manage_callback_35)); }
	inline intptr_t get_manage_callback_35() const { return ___manage_callback_35; }
	inline intptr_t* get_address_of_manage_callback_35() { return &___manage_callback_35; }
	inline void set_manage_callback_35(intptr_t value)
	{
		___manage_callback_35 = value;
	}

	inline static int32_t get_offset_of_pending_exception_36() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___pending_exception_36)); }
	inline RuntimeObject * get_pending_exception_36() const { return ___pending_exception_36; }
	inline RuntimeObject ** get_address_of_pending_exception_36() { return &___pending_exception_36; }
	inline void set_pending_exception_36(RuntimeObject * value)
	{
		___pending_exception_36 = value;
		Il2CppCodeGenWriteBarrier((&___pending_exception_36), value);
	}

	inline static int32_t get_offset_of_ec_to_set_37() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___ec_to_set_37)); }
	inline ExecutionContext_t1748372627 * get_ec_to_set_37() const { return ___ec_to_set_37; }
	inline ExecutionContext_t1748372627 ** get_address_of_ec_to_set_37() { return &___ec_to_set_37; }
	inline void set_ec_to_set_37(ExecutionContext_t1748372627 * value)
	{
		___ec_to_set_37 = value;
		Il2CppCodeGenWriteBarrier((&___ec_to_set_37), value);
	}

	inline static int32_t get_offset_of_interrupt_on_stop_38() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___interrupt_on_stop_38)); }
	inline intptr_t get_interrupt_on_stop_38() const { return ___interrupt_on_stop_38; }
	inline intptr_t* get_address_of_interrupt_on_stop_38() { return &___interrupt_on_stop_38; }
	inline void set_interrupt_on_stop_38(intptr_t value)
	{
		___interrupt_on_stop_38 = value;
	}

	inline static int32_t get_offset_of_unused3_39() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___unused3_39)); }
	inline intptr_t get_unused3_39() const { return ___unused3_39; }
	inline intptr_t* get_address_of_unused3_39() { return &___unused3_39; }
	inline void set_unused3_39(intptr_t value)
	{
		___unused3_39 = value;
	}

	inline static int32_t get_offset_of_unused4_40() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___unused4_40)); }
	inline intptr_t get_unused4_40() const { return ___unused4_40; }
	inline intptr_t* get_address_of_unused4_40() { return &___unused4_40; }
	inline void set_unused4_40(intptr_t value)
	{
		___unused4_40 = value;
	}

	inline static int32_t get_offset_of_unused5_41() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___unused5_41)); }
	inline intptr_t get_unused5_41() const { return ___unused5_41; }
	inline intptr_t* get_address_of_unused5_41() { return &___unused5_41; }
	inline void set_unused5_41(intptr_t value)
	{
		___unused5_41 = value;
	}

	inline static int32_t get_offset_of_unused6_42() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___unused6_42)); }
	inline intptr_t get_unused6_42() const { return ___unused6_42; }
	inline intptr_t* get_address_of_unused6_42() { return &___unused6_42; }
	inline void set_unused6_42(intptr_t value)
	{
		___unused6_42 = value;
	}

	inline static int32_t get_offset_of_threadstart_45() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___threadstart_45)); }
	inline MulticastDelegate_t * get_threadstart_45() const { return ___threadstart_45; }
	inline MulticastDelegate_t ** get_address_of_threadstart_45() { return &___threadstart_45; }
	inline void set_threadstart_45(MulticastDelegate_t * value)
	{
		___threadstart_45 = value;
		Il2CppCodeGenWriteBarrier((&___threadstart_45), value);
	}

	inline static int32_t get_offset_of_managed_id_46() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___managed_id_46)); }
	inline int32_t get_managed_id_46() const { return ___managed_id_46; }
	inline int32_t* get_address_of_managed_id_46() { return &___managed_id_46; }
	inline void set_managed_id_46(int32_t value)
	{
		___managed_id_46 = value;
	}

	inline static int32_t get_offset_of__principal_47() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ____principal_47)); }
	inline RuntimeObject* get__principal_47() const { return ____principal_47; }
	inline RuntimeObject** get_address_of__principal_47() { return &____principal_47; }
	inline void set__principal_47(RuntimeObject* value)
	{
		____principal_47 = value;
		Il2CppCodeGenWriteBarrier((&____principal_47), value);
	}

	inline static int32_t get_offset_of_in_currentculture_50() { return static_cast<int32_t>(offsetof(Thread_t2300836069, ___in_currentculture_50)); }
	inline bool get_in_currentculture_50() const { return ___in_currentculture_50; }
	inline bool* get_address_of_in_currentculture_50() { return &___in_currentculture_50; }
	inline void set_in_currentculture_50(bool value)
	{
		___in_currentculture_50 = value;
	}
};

struct Thread_t2300836069_StaticFields
{
public:
	// System.Collections.Hashtable System.Threading.Thread::datastorehash
	Hashtable_t1853889766 * ___datastorehash_48;
	// System.Object System.Threading.Thread::datastore_lock
	RuntimeObject * ___datastore_lock_49;
	// System.Object System.Threading.Thread::culture_lock
	RuntimeObject * ___culture_lock_51;

public:
	inline static int32_t get_offset_of_datastorehash_48() { return static_cast<int32_t>(offsetof(Thread_t2300836069_StaticFields, ___datastorehash_48)); }
	inline Hashtable_t1853889766 * get_datastorehash_48() const { return ___datastorehash_48; }
	inline Hashtable_t1853889766 ** get_address_of_datastorehash_48() { return &___datastorehash_48; }
	inline void set_datastorehash_48(Hashtable_t1853889766 * value)
	{
		___datastorehash_48 = value;
		Il2CppCodeGenWriteBarrier((&___datastorehash_48), value);
	}

	inline static int32_t get_offset_of_datastore_lock_49() { return static_cast<int32_t>(offsetof(Thread_t2300836069_StaticFields, ___datastore_lock_49)); }
	inline RuntimeObject * get_datastore_lock_49() const { return ___datastore_lock_49; }
	inline RuntimeObject ** get_address_of_datastore_lock_49() { return &___datastore_lock_49; }
	inline void set_datastore_lock_49(RuntimeObject * value)
	{
		___datastore_lock_49 = value;
		Il2CppCodeGenWriteBarrier((&___datastore_lock_49), value);
	}

	inline static int32_t get_offset_of_culture_lock_51() { return static_cast<int32_t>(offsetof(Thread_t2300836069_StaticFields, ___culture_lock_51)); }
	inline RuntimeObject * get_culture_lock_51() const { return ___culture_lock_51; }
	inline RuntimeObject ** get_address_of_culture_lock_51() { return &___culture_lock_51; }
	inline void set_culture_lock_51(RuntimeObject * value)
	{
		___culture_lock_51 = value;
		Il2CppCodeGenWriteBarrier((&___culture_lock_51), value);
	}
};

struct Thread_t2300836069_ThreadStaticFields
{
public:
	// System.Object[] System.Threading.Thread::local_slots
	ObjectU5BU5D_t2843939325* ___local_slots_43;
	// System.Threading.ExecutionContext System.Threading.Thread::_ec
	ExecutionContext_t1748372627 * ____ec_44;

public:
	inline static int32_t get_offset_of_local_slots_43() { return static_cast<int32_t>(offsetof(Thread_t2300836069_ThreadStaticFields, ___local_slots_43)); }
	inline ObjectU5BU5D_t2843939325* get_local_slots_43() const { return ___local_slots_43; }
	inline ObjectU5BU5D_t2843939325** get_address_of_local_slots_43() { return &___local_slots_43; }
	inline void set_local_slots_43(ObjectU5BU5D_t2843939325* value)
	{
		___local_slots_43 = value;
		Il2CppCodeGenWriteBarrier((&___local_slots_43), value);
	}

	inline static int32_t get_offset_of__ec_44() { return static_cast<int32_t>(offsetof(Thread_t2300836069_ThreadStaticFields, ____ec_44)); }
	inline ExecutionContext_t1748372627 * get__ec_44() const { return ____ec_44; }
	inline ExecutionContext_t1748372627 ** get_address_of__ec_44() { return &____ec_44; }
	inline void set__ec_44(ExecutionContext_t1748372627 * value)
	{
		____ec_44 = value;
		Il2CppCodeGenWriteBarrier((&____ec_44), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // THREAD_T2300836069_H
#ifndef COMPONENT_T1923634451_H
#define COMPONENT_T1923634451_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Component
struct  Component_t1923634451  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // COMPONENT_T1923634451_H
#ifndef TOUCH_T1921856868_H
#define TOUCH_T1921856868_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Touch
struct  Touch_t1921856868 
{
public:
	// System.Int32 UnityEngine.Touch::m_FingerId
	int32_t ___m_FingerId_0;
	// UnityEngine.Vector2 UnityEngine.Touch::m_Position
	Vector2_t2156229523  ___m_Position_1;
	// UnityEngine.Vector2 UnityEngine.Touch::m_RawPosition
	Vector2_t2156229523  ___m_RawPosition_2;
	// UnityEngine.Vector2 UnityEngine.Touch::m_PositionDelta
	Vector2_t2156229523  ___m_PositionDelta_3;
	// System.Single UnityEngine.Touch::m_TimeDelta
	float ___m_TimeDelta_4;
	// System.Int32 UnityEngine.Touch::m_TapCount
	int32_t ___m_TapCount_5;
	// UnityEngine.TouchPhase UnityEngine.Touch::m_Phase
	int32_t ___m_Phase_6;
	// UnityEngine.TouchType UnityEngine.Touch::m_Type
	int32_t ___m_Type_7;
	// System.Single UnityEngine.Touch::m_Pressure
	float ___m_Pressure_8;
	// System.Single UnityEngine.Touch::m_maximumPossiblePressure
	float ___m_maximumPossiblePressure_9;
	// System.Single UnityEngine.Touch::m_Radius
	float ___m_Radius_10;
	// System.Single UnityEngine.Touch::m_RadiusVariance
	float ___m_RadiusVariance_11;
	// System.Single UnityEngine.Touch::m_AltitudeAngle
	float ___m_AltitudeAngle_12;
	// System.Single UnityEngine.Touch::m_AzimuthAngle
	float ___m_AzimuthAngle_13;

public:
	inline static int32_t get_offset_of_m_FingerId_0() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_FingerId_0)); }
	inline int32_t get_m_FingerId_0() const { return ___m_FingerId_0; }
	inline int32_t* get_address_of_m_FingerId_0() { return &___m_FingerId_0; }
	inline void set_m_FingerId_0(int32_t value)
	{
		___m_FingerId_0 = value;
	}

	inline static int32_t get_offset_of_m_Position_1() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_Position_1)); }
	inline Vector2_t2156229523  get_m_Position_1() const { return ___m_Position_1; }
	inline Vector2_t2156229523 * get_address_of_m_Position_1() { return &___m_Position_1; }
	inline void set_m_Position_1(Vector2_t2156229523  value)
	{
		___m_Position_1 = value;
	}

	inline static int32_t get_offset_of_m_RawPosition_2() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_RawPosition_2)); }
	inline Vector2_t2156229523  get_m_RawPosition_2() const { return ___m_RawPosition_2; }
	inline Vector2_t2156229523 * get_address_of_m_RawPosition_2() { return &___m_RawPosition_2; }
	inline void set_m_RawPosition_2(Vector2_t2156229523  value)
	{
		___m_RawPosition_2 = value;
	}

	inline static int32_t get_offset_of_m_PositionDelta_3() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_PositionDelta_3)); }
	inline Vector2_t2156229523  get_m_PositionDelta_3() const { return ___m_PositionDelta_3; }
	inline Vector2_t2156229523 * get_address_of_m_PositionDelta_3() { return &___m_PositionDelta_3; }
	inline void set_m_PositionDelta_3(Vector2_t2156229523  value)
	{
		___m_PositionDelta_3 = value;
	}

	inline static int32_t get_offset_of_m_TimeDelta_4() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_TimeDelta_4)); }
	inline float get_m_TimeDelta_4() const { return ___m_TimeDelta_4; }
	inline float* get_address_of_m_TimeDelta_4() { return &___m_TimeDelta_4; }
	inline void set_m_TimeDelta_4(float value)
	{
		___m_TimeDelta_4 = value;
	}

	inline static int32_t get_offset_of_m_TapCount_5() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_TapCount_5)); }
	inline int32_t get_m_TapCount_5() const { return ___m_TapCount_5; }
	inline int32_t* get_address_of_m_TapCount_5() { return &___m_TapCount_5; }
	inline void set_m_TapCount_5(int32_t value)
	{
		___m_TapCount_5 = value;
	}

	inline static int32_t get_offset_of_m_Phase_6() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_Phase_6)); }
	inline int32_t get_m_Phase_6() const { return ___m_Phase_6; }
	inline int32_t* get_address_of_m_Phase_6() { return &___m_Phase_6; }
	inline void set_m_Phase_6(int32_t value)
	{
		___m_Phase_6 = value;
	}

	inline static int32_t get_offset_of_m_Type_7() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_Type_7)); }
	inline int32_t get_m_Type_7() const { return ___m_Type_7; }
	inline int32_t* get_address_of_m_Type_7() { return &___m_Type_7; }
	inline void set_m_Type_7(int32_t value)
	{
		___m_Type_7 = value;
	}

	inline static int32_t get_offset_of_m_Pressure_8() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_Pressure_8)); }
	inline float get_m_Pressure_8() const { return ___m_Pressure_8; }
	inline float* get_address_of_m_Pressure_8() { return &___m_Pressure_8; }
	inline void set_m_Pressure_8(float value)
	{
		___m_Pressure_8 = value;
	}

	inline static int32_t get_offset_of_m_maximumPossiblePressure_9() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_maximumPossiblePressure_9)); }
	inline float get_m_maximumPossiblePressure_9() const { return ___m_maximumPossiblePressure_9; }
	inline float* get_address_of_m_maximumPossiblePressure_9() { return &___m_maximumPossiblePressure_9; }
	inline void set_m_maximumPossiblePressure_9(float value)
	{
		___m_maximumPossiblePressure_9 = value;
	}

	inline static int32_t get_offset_of_m_Radius_10() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_Radius_10)); }
	inline float get_m_Radius_10() const { return ___m_Radius_10; }
	inline float* get_address_of_m_Radius_10() { return &___m_Radius_10; }
	inline void set_m_Radius_10(float value)
	{
		___m_Radius_10 = value;
	}

	inline static int32_t get_offset_of_m_RadiusVariance_11() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_RadiusVariance_11)); }
	inline float get_m_RadiusVariance_11() const { return ___m_RadiusVariance_11; }
	inline float* get_address_of_m_RadiusVariance_11() { return &___m_RadiusVariance_11; }
	inline void set_m_RadiusVariance_11(float value)
	{
		___m_RadiusVariance_11 = value;
	}

	inline static int32_t get_offset_of_m_AltitudeAngle_12() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_AltitudeAngle_12)); }
	inline float get_m_AltitudeAngle_12() const { return ___m_AltitudeAngle_12; }
	inline float* get_address_of_m_AltitudeAngle_12() { return &___m_AltitudeAngle_12; }
	inline void set_m_AltitudeAngle_12(float value)
	{
		___m_AltitudeAngle_12 = value;
	}

	inline static int32_t get_offset_of_m_AzimuthAngle_13() { return static_cast<int32_t>(offsetof(Touch_t1921856868, ___m_AzimuthAngle_13)); }
	inline float get_m_AzimuthAngle_13() const { return ___m_AzimuthAngle_13; }
	inline float* get_address_of_m_AzimuthAngle_13() { return &___m_AzimuthAngle_13; }
	inline void set_m_AzimuthAngle_13(float value)
	{
		___m_AzimuthAngle_13 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TOUCH_T1921856868_H
#ifndef TEXTASSET_T3022178571_H
#define TEXTASSET_T3022178571_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.TextAsset
struct  TextAsset_t3022178571  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TEXTASSET_T3022178571_H
#ifndef TEXTURE_T3661962703_H
#define TEXTURE_T3661962703_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Texture
struct  Texture_t3661962703  : public Object_t631007953
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TEXTURE_T3661962703_H
#ifndef STREAMINGCONTEXT_T3711869237_H
#define STREAMINGCONTEXT_T3711869237_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Runtime.Serialization.StreamingContext
struct  StreamingContext_t3711869237 
{
public:
	// System.Runtime.Serialization.StreamingContextStates System.Runtime.Serialization.StreamingContext::state
	int32_t ___state_0;
	// System.Object System.Runtime.Serialization.StreamingContext::additional
	RuntimeObject * ___additional_1;

public:
	inline static int32_t get_offset_of_state_0() { return static_cast<int32_t>(offsetof(StreamingContext_t3711869237, ___state_0)); }
	inline int32_t get_state_0() const { return ___state_0; }
	inline int32_t* get_address_of_state_0() { return &___state_0; }
	inline void set_state_0(int32_t value)
	{
		___state_0 = value;
	}

	inline static int32_t get_offset_of_additional_1() { return static_cast<int32_t>(offsetof(StreamingContext_t3711869237, ___additional_1)); }
	inline RuntimeObject * get_additional_1() const { return ___additional_1; }
	inline RuntimeObject ** get_address_of_additional_1() { return &___additional_1; }
	inline void set_additional_1(RuntimeObject * value)
	{
		___additional_1 = value;
		Il2CppCodeGenWriteBarrier((&___additional_1), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
// Native definition for P/Invoke marshalling of System.Runtime.Serialization.StreamingContext
struct StreamingContext_t3711869237_marshaled_pinvoke
{
	int32_t ___state_0;
	Il2CppIUnknown* ___additional_1;
};
// Native definition for COM marshalling of System.Runtime.Serialization.StreamingContext
struct StreamingContext_t3711869237_marshaled_com
{
	int32_t ___state_0;
	Il2CppIUnknown* ___additional_1;
};
#endif // STREAMINGCONTEXT_T3711869237_H
#ifndef ASYNCCALLBACK_T3962456242_H
#define ASYNCCALLBACK_T3962456242_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.AsyncCallback
struct  AsyncCallback_t3962456242  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ASYNCCALLBACK_T3962456242_H
#ifndef TEXTURE2D_T3840446185_H
#define TEXTURE2D_T3840446185_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Texture2D
struct  Texture2D_t3840446185  : public Texture_t3661962703
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TEXTURE2D_T3840446185_H
#ifndef ACTION_1_T819399007_H
#define ACTION_1_T819399007_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Action`1<UnityEngine.U2D.SpriteAtlas>
struct  Action_1_t819399007  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // ACTION_1_T819399007_H
#ifndef REQUESTATLASCALLBACK_T3100554279_H
#define REQUESTATLASCALLBACK_T3100554279_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.U2D.SpriteAtlasManager/RequestAtlasCallback
struct  RequestAtlasCallback_t3100554279  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // REQUESTATLASCALLBACK_T3100554279_H
#ifndef SYSTEMCLOCK_T1201361285_H
#define SYSTEMCLOCK_T1201361285_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.SystemClock
struct  SystemClock_t1201361285  : public RuntimeObject
{
public:

public:
};

struct SystemClock_t1201361285_StaticFields
{
public:
	// System.DateTime UnityEngine.SystemClock::s_Epoch
	DateTime_t3738529785  ___s_Epoch_0;

public:
	inline static int32_t get_offset_of_s_Epoch_0() { return static_cast<int32_t>(offsetof(SystemClock_t1201361285_StaticFields, ___s_Epoch_0)); }
	inline DateTime_t3738529785  get_s_Epoch_0() const { return ___s_Epoch_0; }
	inline DateTime_t3738529785 * get_address_of_s_Epoch_0() { return &___s_Epoch_0; }
	inline void set_s_Epoch_0(DateTime_t3738529785  value)
	{
		___s_Epoch_0 = value;
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SYSTEMCLOCK_T1201361285_H
#ifndef MANUALRESETEVENT_T451242010_H
#define MANUALRESETEVENT_T451242010_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Threading.ManualResetEvent
struct  ManualResetEvent_t451242010  : public EventWaitHandle_t777845177
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // MANUALRESETEVENT_T451242010_H
#ifndef TRANSFORM_T3600365921_H
#define TRANSFORM_T3600365921_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Transform
struct  Transform_t3600365921  : public Component_t1923634451
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // TRANSFORM_T3600365921_H
#ifndef BEHAVIOUR_T1437897464_H
#define BEHAVIOUR_T1437897464_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Behaviour
struct  Behaviour_t1437897464  : public Component_t1923634451
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // BEHAVIOUR_T1437897464_H
#ifndef RENDERER_T2627027031_H
#define RENDERER_T2627027031_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Renderer
struct  Renderer_t2627027031  : public Component_t1923634451
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RENDERER_T2627027031_H
#ifndef SENDORPOSTCALLBACK_T2750080073_H
#define SENDORPOSTCALLBACK_T2750080073_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// System.Threading.SendOrPostCallback
struct  SendOrPostCallback_t2750080073  : public MulticastDelegate_t
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SENDORPOSTCALLBACK_T2750080073_H
#ifndef CAMERA_T4157153871_H
#define CAMERA_T4157153871_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.Camera
struct  Camera_t4157153871  : public Behaviour_t1437897464
{
public:

public:
};

struct Camera_t4157153871_StaticFields
{
public:
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPreCull
	CameraCallback_t190067161 * ___onPreCull_2;
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPreRender
	CameraCallback_t190067161 * ___onPreRender_3;
	// UnityEngine.Camera/CameraCallback UnityEngine.Camera::onPostRender
	CameraCallback_t190067161 * ___onPostRender_4;

public:
	inline static int32_t get_offset_of_onPreCull_2() { return static_cast<int32_t>(offsetof(Camera_t4157153871_StaticFields, ___onPreCull_2)); }
	inline CameraCallback_t190067161 * get_onPreCull_2() const { return ___onPreCull_2; }
	inline CameraCallback_t190067161 ** get_address_of_onPreCull_2() { return &___onPreCull_2; }
	inline void set_onPreCull_2(CameraCallback_t190067161 * value)
	{
		___onPreCull_2 = value;
		Il2CppCodeGenWriteBarrier((&___onPreCull_2), value);
	}

	inline static int32_t get_offset_of_onPreRender_3() { return static_cast<int32_t>(offsetof(Camera_t4157153871_StaticFields, ___onPreRender_3)); }
	inline CameraCallback_t190067161 * get_onPreRender_3() const { return ___onPreRender_3; }
	inline CameraCallback_t190067161 ** get_address_of_onPreRender_3() { return &___onPreRender_3; }
	inline void set_onPreRender_3(CameraCallback_t190067161 * value)
	{
		___onPreRender_3 = value;
		Il2CppCodeGenWriteBarrier((&___onPreRender_3), value);
	}

	inline static int32_t get_offset_of_onPostRender_4() { return static_cast<int32_t>(offsetof(Camera_t4157153871_StaticFields, ___onPostRender_4)); }
	inline CameraCallback_t190067161 * get_onPostRender_4() const { return ___onPostRender_4; }
	inline CameraCallback_t190067161 ** get_address_of_onPostRender_4() { return &___onPostRender_4; }
	inline void set_onPostRender_4(CameraCallback_t190067161 * value)
	{
		___onPostRender_4 = value;
		Il2CppCodeGenWriteBarrier((&___onPostRender_4), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // CAMERA_T4157153871_H
#ifndef RECTTRANSFORM_T3704657025_H
#define RECTTRANSFORM_T3704657025_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.RectTransform
struct  RectTransform_t3704657025  : public Transform_t3600365921
{
public:

public:
};

struct RectTransform_t3704657025_StaticFields
{
public:
	// UnityEngine.RectTransform/ReapplyDrivenProperties UnityEngine.RectTransform::reapplyDrivenProperties
	ReapplyDrivenProperties_t1258266594 * ___reapplyDrivenProperties_2;

public:
	inline static int32_t get_offset_of_reapplyDrivenProperties_2() { return static_cast<int32_t>(offsetof(RectTransform_t3704657025_StaticFields, ___reapplyDrivenProperties_2)); }
	inline ReapplyDrivenProperties_t1258266594 * get_reapplyDrivenProperties_2() const { return ___reapplyDrivenProperties_2; }
	inline ReapplyDrivenProperties_t1258266594 ** get_address_of_reapplyDrivenProperties_2() { return &___reapplyDrivenProperties_2; }
	inline void set_reapplyDrivenProperties_2(ReapplyDrivenProperties_t1258266594 * value)
	{
		___reapplyDrivenProperties_2 = value;
		Il2CppCodeGenWriteBarrier((&___reapplyDrivenProperties_2), value);
	}
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // RECTTRANSFORM_T3704657025_H
#ifndef SPRITERENDERER_T3235626157_H
#define SPRITERENDERER_T3235626157_H
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif

// UnityEngine.SpriteRenderer
struct  SpriteRenderer_t3235626157  : public Renderer_t2627027031
{
public:

public:
};

#ifdef __clang__
#pragma clang diagnostic pop
#endif
#endif // SPRITERENDERER_T3235626157_H
// System.Object[]
struct ObjectU5BU5D_t2843939325  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) RuntimeObject * m_Items[1];

public:
	inline RuntimeObject * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline RuntimeObject ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, RuntimeObject * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline RuntimeObject * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline RuntimeObject ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, RuntimeObject * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// System.Reflection.ParameterModifier[]
struct ParameterModifierU5BU5D_t2943407543  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) ParameterModifier_t1461694466  m_Items[1];

public:
	inline ParameterModifier_t1461694466  GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline ParameterModifier_t1461694466 * GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, ParameterModifier_t1461694466  value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline ParameterModifier_t1461694466  GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline ParameterModifier_t1461694466 * GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, ParameterModifier_t1461694466  value)
	{
		m_Items[index] = value;
	}
};
// System.String[]
struct StringU5BU5D_t1281789340  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) String_t* m_Items[1];

public:
	inline String_t* GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline String_t** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, String_t* value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline String_t* GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline String_t** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, String_t* value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};
// System.Char[]
struct CharU5BU5D_t3528271667  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) Il2CppChar m_Items[1];

public:
	inline Il2CppChar GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, Il2CppChar value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
	}
	inline Il2CppChar GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline Il2CppChar* GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, Il2CppChar value)
	{
		m_Items[index] = value;
	}
};
// System.Reflection.ParameterInfo[]
struct ParameterInfoU5BU5D_t390618515  : public RuntimeArray
{
public:
	ALIGN_FIELD (8) ParameterInfo_t1861056598 * m_Items[1];

public:
	inline ParameterInfo_t1861056598 * GetAt(il2cpp_array_size_t index) const
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items[index];
	}
	inline ParameterInfo_t1861056598 ** GetAddressAt(il2cpp_array_size_t index)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		return m_Items + index;
	}
	inline void SetAt(il2cpp_array_size_t index, ParameterInfo_t1861056598 * value)
	{
		IL2CPP_ARRAY_BOUNDS_CHECK(index, (uint32_t)(this)->max_length);
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
	inline ParameterInfo_t1861056598 * GetAtUnchecked(il2cpp_array_size_t index) const
	{
		return m_Items[index];
	}
	inline ParameterInfo_t1861056598 ** GetAddressAtUnchecked(il2cpp_array_size_t index)
	{
		return m_Items + index;
	}
	inline void SetAtUnchecked(il2cpp_array_size_t index, ParameterInfo_t1861056598 * value)
	{
		m_Items[index] = value;
		Il2CppCodeGenWriteBarrier(m_Items + index, value);
	}
};


// System.Void System.Action`1<System.Object>::.ctor(System.Object,System.IntPtr)
extern "C"  void Action_1__ctor_m118522912_gshared (Action_1_t3252573759 * __this, RuntimeObject * p0, intptr_t p1, const RuntimeMethod* method);
// System.Void System.Collections.Generic.Queue`1<UnityEngine.UnitySynchronizationContext/WorkRequest>::.ctor(System.Int32)
extern "C"  void Queue_1__ctor_m1971992302_gshared (Queue_1_t1200778106 * __this, int32_t p0, const RuntimeMethod* method);
// !0 System.Collections.Generic.Queue`1<UnityEngine.UnitySynchronizationContext/WorkRequest>::Dequeue()
extern "C"  WorkRequest_t1354518612  Queue_1_Dequeue_m979967976_gshared (Queue_1_t1200778106 * __this, const RuntimeMethod* method);
// System.Int32 System.Collections.Generic.Queue`1<UnityEngine.UnitySynchronizationContext/WorkRequest>::get_Count()
extern "C"  int32_t Queue_1_get_Count_m3368911732_gshared (Queue_1_t1200778106 * __this, const RuntimeMethod* method);

// System.Void UnityEngine.GameObject::SendMessage(System.String,System.Object,UnityEngine.SendMessageOptions)
extern "C"  void GameObject_SendMessage_m3720186693 (GameObject_t1113636619 * __this, String_t* ___methodName0, RuntimeObject * ___value1, int32_t ___options2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.SendMouseEvents/HitInfo::SendMessage(System.String)
extern "C"  void HitInfo_SendMessage_m1343099429 (HitInfo_t3229609740 * __this, String_t* ___name0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Object::op_Inequality(UnityEngine.Object,UnityEngine.Object)
extern "C"  bool Object_op_Inequality_m4071470834 (RuntimeObject * __this /* static, unused */, Object_t631007953 * ___x0, Object_t631007953 * ___y1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Object::op_Equality(UnityEngine.Object,UnityEngine.Object)
extern "C"  bool Object_op_Equality_m1810815630 (RuntimeObject * __this /* static, unused */, Object_t631007953 * ___x0, Object_t631007953 * ___y1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Attribute::.ctor()
extern "C"  void Attribute__ctor_m1529526131 (Attribute_t861562559 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.IntPtr::op_Equality(System.IntPtr,System.IntPtr)
extern "C"  bool IntPtr_op_Equality_m408849716 (RuntimeObject * __this /* static, unused */, intptr_t p0, intptr_t p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.ArgumentException::.ctor(System.String,System.String)
extern "C"  void ArgumentException__ctor_m1216717135 (ArgumentException_t132251570 * __this, String_t* p0, String_t* p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void* System.IntPtr::op_Explicit(System.IntPtr)
extern "C"  void* IntPtr_op_Explicit_m2520637223 (RuntimeObject * __this /* static, unused */, intptr_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Type System.Object::GetType()
extern "C"  Type_t * Object_GetType_m88164663 (RuntimeObject * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.PropertyAttribute::.ctor()
extern "C"  void PropertyAttribute__ctor_m1017741868 (PropertyAttribute_t3677895545 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Object::.ctor()
extern "C"  void Object__ctor_m1087895580 (Object_t631007953 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector4 UnityEngine.Vector4::get_zero()
extern "C"  Vector4_t3319028937  Vector4_get_zero_m1422399515 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Sprite UnityEngine.Sprite::INTERNAL_CALL_Create(UnityEngine.Texture2D,UnityEngine.Rect&,UnityEngine.Vector2&,System.Single,System.UInt32,UnityEngine.SpriteMeshType,UnityEngine.Vector4&,System.Boolean)
extern "C"  Sprite_t280657092 * Sprite_INTERNAL_CALL_Create_m2945291276 (RuntimeObject * __this /* static, unused */, Texture2D_t3840446185 * ___texture0, Rect_t2360479859 * ___rect1, Vector2_t2156229523 * ___pivot2, float ___pixelsPerUnit3, uint32_t ___extrude4, int32_t ___meshType5, Vector4_t3319028937 * ___border6, bool ___generateFallbackPhysicsShape7, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Sprite::INTERNAL_get_rect(UnityEngine.Rect&)
extern "C"  void Sprite_INTERNAL_get_rect_m1600380876 (Sprite_t280657092 * __this, Rect_t2360479859 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Sprite::INTERNAL_get_textureRect(UnityEngine.Rect&)
extern "C"  void Sprite_INTERNAL_get_textureRect_m2310671861 (Sprite_t280657092 * __this, Rect_t2360479859 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Sprite::Internal_GetPivot(UnityEngine.Sprite,UnityEngine.Vector2&)
extern "C"  void Sprite_Internal_GetPivot_m3815020698 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, Vector2_t2156229523 * ___output1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Sprite::INTERNAL_get_border(UnityEngine.Vector4&)
extern "C"  void Sprite_INTERNAL_get_border_m3728071101 (Sprite_t280657092 * __this, Vector4_t3319028937 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.SpriteRenderer::SetSprite_INTERNAL(UnityEngine.Sprite)
extern "C"  void SpriteRenderer_SetSprite_INTERNAL_m957744766 (SpriteRenderer_t3235626157 * __this, Sprite_t280657092 * ___sprite0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Sprites.DataUtility::INTERNAL_CALL_GetInnerUV(UnityEngine.Sprite,UnityEngine.Vector4&)
extern "C"  void DataUtility_INTERNAL_CALL_GetInnerUV_m1230966310 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, Vector4_t3319028937 * ___value1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Sprites.DataUtility::INTERNAL_CALL_GetOuterUV(UnityEngine.Sprite,UnityEngine.Vector4&)
extern "C"  void DataUtility_INTERNAL_CALL_GetOuterUV_m2471985598 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, Vector4_t3319028937 * ___value1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Sprites.DataUtility::INTERNAL_CALL_GetPadding(UnityEngine.Sprite,UnityEngine.Vector4&)
extern "C"  void DataUtility_INTERNAL_CALL_GetPadding_m650254139 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, Vector4_t3319028937 * ___value1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Sprites.DataUtility::Internal_GetMinSize(UnityEngine.Sprite,UnityEngine.Vector2&)
extern "C"  void DataUtility_Internal_GetMinSize_m2628270685 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, Vector2_t2156229523 * ___output1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.String::IsNullOrEmpty(System.String)
extern "C"  bool String_IsNullOrEmpty_m2969720369 (RuntimeObject * __this /* static, unused */, String_t* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String System.String::Replace(System.String,System.String)
extern "C"  String_t* String_Replace_m1273907647 (String_t* __this, String_t* p0, String_t* p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Diagnostics.StackTrace::.ctor(System.Int32,System.Boolean)
extern "C"  void StackTrace__ctor_m1685176557 (StackTrace_t1598645457 * __this, int32_t p0, bool p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.StackTraceUtility::ExtractFormattedStackTrace(System.Diagnostics.StackTrace)
extern "C"  String_t* StackTraceUtility_ExtractFormattedStackTrace_m1281750362 (RuntimeObject * __this /* static, unused */, StackTrace_t1598645457 * ___stackTrace0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.String::StartsWith(System.String)
extern "C"  bool String_StartsWith_m1759067526 (String_t* __this, String_t* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.ArgumentException::.ctor(System.String)
extern "C"  void ArgumentException__ctor_m1312628991 (ArgumentException_t132251570 * __this, String_t* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.String::get_Length()
extern "C"  int32_t String_get_Length_m3847582255 (String_t* __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Text.StringBuilder::.ctor(System.Int32)
extern "C"  void StringBuilder__ctor_m2367297767 (StringBuilder_t * __this, int32_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String System.String::Concat(System.String,System.String,System.String)
extern "C"  String_t* String_Concat_m3755062657 (RuntimeObject * __this /* static, unused */, String_t* p0, String_t* p1, String_t* p2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Type System.Exception::GetType()
extern "C"  Type_t * Exception_GetType_m2227967756 (Exception_t * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String System.String::Trim()
extern "C"  String_t* String_Trim_m923598732 (String_t* __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String System.String::Concat(System.String,System.String)
extern "C"  String_t* String_Concat_m3937257545 (RuntimeObject * __this /* static, unused */, String_t* p0, String_t* p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Exception System.Exception::get_InnerException()
extern "C"  Exception_t * Exception_get_InnerException_m3836775 (Exception_t * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String System.String::Concat(System.String,System.String,System.String,System.String)
extern "C"  String_t* String_Concat_m2163913788 (RuntimeObject * __this /* static, unused */, String_t* p0, String_t* p1, String_t* p2, String_t* p3, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Text.StringBuilder System.Text.StringBuilder::Append(System.String)
extern "C"  StringBuilder_t * StringBuilder_Append_m1965104174 (StringBuilder_t * __this, String_t* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String[] System.String::Split(System.Char[])
extern "C"  StringU5BU5D_t1281789340* String_Split_m3646115398 (String_t* __this, CharU5BU5D_t3528271667* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Char System.String::get_Chars(System.Int32)
extern "C"  Il2CppChar String_get_Chars_m2986988803 (String_t* __this, int32_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.StackTraceUtility::IsSystemStacktraceType(System.Object)
extern "C"  bool StackTraceUtility_IsSystemStacktraceType_m299828041 (RuntimeObject * __this /* static, unused */, RuntimeObject * ___name0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.String::IndexOf(System.String)
extern "C"  int32_t String_IndexOf_m1977622757 (String_t* __this, String_t* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String System.String::Substring(System.Int32,System.Int32)
extern "C"  String_t* String_Substring_m1610150815 (String_t* __this, int32_t p0, int32_t p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.String::EndsWith(System.String)
extern "C"  bool String_EndsWith_m1901926500 (String_t* __this, String_t* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String System.String::Remove(System.Int32,System.Int32)
extern "C"  String_t* String_Remove_m562998446 (String_t* __this, int32_t p0, int32_t p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.String::IndexOf(System.String,System.Int32)
extern "C"  int32_t String_IndexOf_m3406607758 (String_t* __this, String_t* p0, int32_t p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String System.String::Replace(System.Char,System.Char)
extern "C"  String_t* String_Replace_m3726209165 (String_t* __this, Il2CppChar p0, Il2CppChar p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.String::LastIndexOf(System.String)
extern "C"  int32_t String_LastIndexOf_m2676535141 (String_t* __this, String_t* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String System.String::Insert(System.Int32,System.String)
extern "C"  String_t* String_Insert_m3534971326 (String_t* __this, int32_t p0, String_t* p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.String::op_Equality(System.String,System.String)
extern "C"  bool String_op_Equality_m920492651 (RuntimeObject * __this /* static, unused */, String_t* p0, String_t* p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String System.Int32::ToString()
extern "C"  String_t* Int32_ToString_m141394615 (int32_t* __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.DateTime System.DateTime::get_Now()
extern "C"  DateTime_t3738529785  DateTime_get_Now_m1277138875 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.DateTime::.ctor(System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.Int32,System.DateTimeKind)
extern "C"  void DateTime__ctor_m2956360140 (DateTime_t3738529785 * __this, int32_t p0, int32_t p1, int32_t p2, int32_t p3, int32_t p4, int32_t p5, int32_t p6, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.TextAsset::get_text()
extern "C"  String_t* TextAsset_get_text_m2027878391 (TextAsset_t3022178571 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Texture::Internal_GetWidth(UnityEngine.Texture)
extern "C"  int32_t Texture_Internal_GetWidth_m629815273 (RuntimeObject * __this /* static, unused */, Texture_t3661962703 * ___t0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Texture::Internal_GetHeight(UnityEngine.Texture)
extern "C"  int32_t Texture_Internal_GetHeight_m2885553040 (RuntimeObject * __this /* static, unused */, Texture_t3661962703 * ___t0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Texture::INTERNAL_get_texelSize(UnityEngine.Vector2&)
extern "C"  void Texture_INTERNAL_get_texelSize_m393369999 (Texture_t3661962703 * __this, Vector2_t2156229523 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Texture::.ctor()
extern "C"  void Texture__ctor_m3554519797 (Texture_t3661962703 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Texture2D::Internal_Create(UnityEngine.Texture2D,System.Int32,System.Int32,UnityEngine.TextureFormat,System.Boolean,System.Boolean,System.IntPtr)
extern "C"  void Texture2D_Internal_Create_m807587593 (RuntimeObject * __this /* static, unused */, Texture2D_t3840446185 * ___mono0, int32_t ___width1, int32_t ___height2, int32_t ___format3, bool ___mipmap4, bool ___linear5, intptr_t ___nativeTex6, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Texture2D::INTERNAL_CALL_SetPixel(UnityEngine.Texture2D,System.Int32,System.Int32,UnityEngine.Color&)
extern "C"  void Texture2D_INTERNAL_CALL_SetPixel_m4151298262 (RuntimeObject * __this /* static, unused */, Texture2D_t3840446185 * ___self0, int32_t ___x1, int32_t ___y2, Color_t2555686324 * ___color3, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Texture2D::INTERNAL_CALL_GetPixelBilinear(UnityEngine.Texture2D,System.Single,System.Single,UnityEngine.Color&)
extern "C"  void Texture2D_INTERNAL_CALL_GetPixelBilinear_m2045611222 (RuntimeObject * __this /* static, unused */, Texture2D_t3840446185 * ___self0, float ___u1, float ___v2, Color_t2555686324 * ___value3, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Texture2D::Apply(System.Boolean,System.Boolean)
extern "C"  void Texture2D_Apply_m2470606565 (Texture2D_t3840446185 * __this, bool ___updateMipmaps0, bool ___makeNoLongerReadable1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Touch::get_fingerId()
extern "C"  int32_t Touch_get_fingerId_m859576425 (Touch_t1921856868 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector2 UnityEngine.Touch::get_position()
extern "C"  Vector2_t2156229523  Touch_get_position_m3109777936 (Touch_t1921856868 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector2 UnityEngine.Touch::get_deltaPosition()
extern "C"  Vector2_t2156229523  Touch_get_deltaPosition_m2389653382 (Touch_t1921856868 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Touch::get_deltaTime()
extern "C"  float Touch_get_deltaTime_m2346246468 (Touch_t1921856868 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.TouchPhase UnityEngine.Touch::get_phase()
extern "C"  int32_t Touch_get_phase_m214549210 (Touch_t1921856868 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.TouchType UnityEngine.Touch::get_type()
extern "C"  int32_t Touch_get_type_m960232264 (Touch_t1921856868 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.TouchScreenKeyboard UnityEngine.TouchScreenKeyboard::Open(System.String,UnityEngine.TouchScreenKeyboardType,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.String)
extern "C"  TouchScreenKeyboard_t731888065 * TouchScreenKeyboard_Open_m231964201 (RuntimeObject * __this /* static, unused */, String_t* ___text0, int32_t ___keyboardType1, bool ___autocorrection2, bool ___multiline3, bool ___secure4, bool ___alert5, String_t* ___textPlaceholder6, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.RangeInt::.ctor(System.Int32,System.Int32)
extern "C"  void RangeInt__ctor_m240963897 (RangeInt_t2094684618 * __this, int32_t ___start0, int32_t ___length1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.TrackedReference::op_Equality(UnityEngine.TrackedReference,UnityEngine.TrackedReference)
extern "C"  bool TrackedReference_op_Equality_m3702354772 (RuntimeObject * __this /* static, unused */, TrackedReference_t1199777556 * ___x0, TrackedReference_t1199777556 * ___y1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.IntPtr::op_Explicit(System.IntPtr)
extern "C"  int32_t IntPtr_op_Explicit_m4220076518 (RuntimeObject * __this /* static, unused */, intptr_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Component::.ctor()
extern "C"  void Component__ctor_m1928064382 (Component_t1923634451 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_get_position(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_get_position_m1310184257 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_set_position(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_set_position_m3627767375 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_get_localPosition(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_get_localPosition_m1816167803 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_set_localPosition(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_set_localPosition_m1936358505 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Quaternion UnityEngine.Transform::get_localRotation()
extern "C"  Quaternion_t2301928331  Transform_get_localRotation_m3487911431 (Transform_t3600365921 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Quaternion::get_eulerAngles()
extern "C"  Vector3_t3722313464  Quaternion_get_eulerAngles_m3425202016 (Quaternion_t2301928331 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Quaternion UnityEngine.Quaternion::Euler(UnityEngine.Vector3)
extern "C"  Quaternion_t2301928331  Quaternion_Euler_m1803555822 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___euler0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::set_localRotation(UnityEngine.Quaternion)
extern "C"  void Transform_set_localRotation_m19445462 (Transform_t3600365921 * __this, Quaternion_t2301928331  ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Quaternion UnityEngine.Transform::get_rotation()
extern "C"  Quaternion_t2301928331  Transform_get_rotation_m3502953881 (Transform_t3600365921 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::get_up()
extern "C"  Vector3_t3722313464  Vector3_get_up_m3584168373 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Quaternion::op_Multiply(UnityEngine.Quaternion,UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Quaternion_op_Multiply_m2607404835 (RuntimeObject * __this /* static, unused */, Quaternion_t2301928331  ___rotation0, Vector3_t3722313464  ___point1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::get_forward()
extern "C"  Vector3_t3722313464  Vector3_get_forward_m3100859705 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_get_rotation(UnityEngine.Quaternion&)
extern "C"  void Transform_INTERNAL_get_rotation_m2413441996 (Transform_t3600365921 * __this, Quaternion_t2301928331 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_set_rotation(UnityEngine.Quaternion&)
extern "C"  void Transform_INTERNAL_set_rotation_m2375965701 (Transform_t3600365921 * __this, Quaternion_t2301928331 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_get_localRotation(UnityEngine.Quaternion&)
extern "C"  void Transform_INTERNAL_get_localRotation_m1111330565 (Transform_t3600365921 * __this, Quaternion_t2301928331 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_set_localRotation(UnityEngine.Quaternion&)
extern "C"  void Transform_INTERNAL_set_localRotation_m3824682417 (Transform_t3600365921 * __this, Quaternion_t2301928331 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_get_localScale(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_get_localScale_m3233655062 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_set_localScale(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_set_localScale_m1089294020 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Transform UnityEngine.Transform::get_parentInternal()
extern "C"  Transform_t3600365921 * Transform_get_parentInternal_m1494967989 (Transform_t3600365921 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Debug::LogWarning(System.Object,UnityEngine.Object)
extern "C"  void Debug_LogWarning_m831581295 (RuntimeObject * __this /* static, unused */, RuntimeObject * ___message0, Object_t631007953 * ___context1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::set_parentInternal(UnityEngine.Transform)
extern "C"  void Transform_set_parentInternal_m2066300701 (Transform_t3600365921 * __this, Transform_t3600365921 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::SetParent(UnityEngine.Transform,System.Boolean)
extern "C"  void Transform_SetParent_m273471670 (Transform_t3600365921 * __this, Transform_t3600365921 * ___parent0, bool ___worldPositionStays1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_get_worldToLocalMatrix(UnityEngine.Matrix4x4&)
extern "C"  void Transform_INTERNAL_get_worldToLocalMatrix_m2730237241 (Transform_t3600365921 * __this, Matrix4x4_t1817901843 * ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::Translate(UnityEngine.Vector3,UnityEngine.Space)
extern "C"  void Transform_Translate_m1990195114 (Transform_t3600365921 * __this, Vector3_t3722313464  ___translation0, int32_t ___relativeTo1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Transform::get_position()
extern "C"  Vector3_t3722313464  Transform_get_position_m36019626 (Transform_t3600365921 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Addition(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Vector3_op_Addition_m779775034 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___a0, Vector3_t3722313464  ___b1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
extern "C"  void Transform_set_position_m3387557959 (Transform_t3600365921 * __this, Vector3_t3722313464  ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Transform::TransformDirection(UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Transform_TransformDirection_m3784028109 (Transform_t3600365921 * __this, Vector3_t3722313464  ___direction0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_CALL_RotateAroundInternal(UnityEngine.Transform,UnityEngine.Vector3&,System.Single)
extern "C"  void Transform_INTERNAL_CALL_RotateAroundInternal_m394670328 (RuntimeObject * __this /* static, unused */, Transform_t3600365921 * ___self0, Vector3_t3722313464 * ___axis1, float ___angle2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Quaternion UnityEngine.Quaternion::AngleAxis(System.Single,UnityEngine.Vector3)
extern "C"  Quaternion_t2301928331  Quaternion_AngleAxis_m1767165696 (RuntimeObject * __this /* static, unused */, float ___angle0, Vector3_t3722313464  ___axis1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Subtraction(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Vector3_op_Subtraction_m3073674971 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___a0, Vector3_t3722313464  ___b1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::RotateAroundInternal(UnityEngine.Vector3,System.Single)
extern "C"  void Transform_RotateAroundInternal_m1612579057 (Transform_t3600365921 * __this, Vector3_t3722313464  ___axis0, float ___angle1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_CALL_TransformDirection(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_CALL_TransformDirection_m4281205641 (RuntimeObject * __this /* static, unused */, Transform_t3600365921 * ___self0, Vector3_t3722313464 * ___direction1, Vector3_t3722313464 * ___value2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_CALL_InverseTransformDirection(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_CALL_InverseTransformDirection_m4017133129 (RuntimeObject * __this /* static, unused */, Transform_t3600365921 * ___self0, Vector3_t3722313464 * ___direction1, Vector3_t3722313464 * ___value2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_CALL_TransformPoint(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_CALL_TransformPoint_m4261269221 (RuntimeObject * __this /* static, unused */, Transform_t3600365921 * ___self0, Vector3_t3722313464 * ___position1, Vector3_t3722313464 * ___value2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform::INTERNAL_CALL_InverseTransformPoint(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_CALL_InverseTransformPoint_m821776309 (RuntimeObject * __this /* static, unused */, Transform_t3600365921 * ___self0, Vector3_t3722313464 * ___position1, Vector3_t3722313464 * ___value2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Transform/Enumerator::.ctor(UnityEngine.Transform)
extern "C"  void Enumerator__ctor_m1351041375 (Enumerator_t3442430665 * __this, Transform_t3600365921 * ___outer0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Object::.ctor()
extern "C"  void Object__ctor_m297566312 (RuntimeObject * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Transform UnityEngine.Transform::GetChild(System.Int32)
extern "C"  Transform_t3600365921 * Transform_GetChild_m1092972975 (Transform_t3600365921 * __this, int32_t ___index0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Transform::get_childCount()
extern "C"  int32_t Transform_get_childCount_m3145433196 (Transform_t3600365921 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Action`1<UnityEngine.U2D.SpriteAtlas>::.ctor(System.Object,System.IntPtr)
#define Action_1__ctor_m3325790595(__this, p0, p1, method) ((  void (*) (Action_1_t819399007 *, RuntimeObject *, intptr_t, const RuntimeMethod*))Action_1__ctor_m118522912_gshared)(__this, p0, p1, method)
// System.Void UnityEngine.U2D.SpriteAtlasManager/RequestAtlasCallback::Invoke(System.String,System.Action`1<UnityEngine.U2D.SpriteAtlas>)
extern "C"  void RequestAtlasCallback_Invoke_m378128467 (RequestAtlasCallback_t3100554279 * __this, String_t* ___tag0, Action_1_t819399007 * ___action1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Exception::.ctor(System.String)
extern "C"  void Exception__ctor_m1152696503 (Exception_t * __this, String_t* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Exception::set_HResult(System.Int32)
extern "C"  void Exception_set_HResult_m3489164646 (Exception_t * __this, int32_t p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Exception::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
extern "C"  void Exception__ctor_m2499432361 (Exception_t * __this, SerializationInfo_t950877179 * p0, StreamingContext_t3711869237  p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.IO.TextWriter::.ctor()
extern "C"  void TextWriter__ctor_m2859954372 (TextWriter_t3478189236 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.UnityLogWriter::.ctor()
extern "C"  void UnityLogWriter__ctor_m1834616883 (UnityLogWriter_t1374348020 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Console::SetOut(System.IO.TextWriter)
extern "C"  void Console_SetOut_m286050082 (RuntimeObject * __this /* static, unused */, TextWriter_t3478189236 * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String System.Char::ToString()
extern "C"  String_t* Char_ToString_m3588025615 (Il2CppChar* __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.UnityLogWriter::WriteStringToUnityLog(System.String)
extern "C"  void UnityLogWriter_WriteStringToUnityLog_m2695353836 (RuntimeObject * __this /* static, unused */, String_t* ___s0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Generic.Queue`1<UnityEngine.UnitySynchronizationContext/WorkRequest>::.ctor(System.Int32)
#define Queue_1__ctor_m1971992302(__this, p0, method) ((  void (*) (Queue_1_t1200778106 *, int32_t, const RuntimeMethod*))Queue_1__ctor_m1971992302_gshared)(__this, p0, method)
// System.Threading.Thread System.Threading.Thread::get_CurrentThread()
extern "C"  Thread_t2300836069 * Thread_get_CurrentThread_m4142136012 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.Threading.Thread::get_ManagedThreadId()
extern "C"  int32_t Thread_get_ManagedThreadId_m1068113671 (Thread_t2300836069 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Threading.SynchronizationContext::.ctor()
extern "C"  void SynchronizationContext__ctor_m2514243817 (SynchronizationContext_t2326897723 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Threading.Monitor::Enter(System.Object)
extern "C"  void Monitor_Enter_m2249409497 (RuntimeObject * __this /* static, unused */, RuntimeObject * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// !0 System.Collections.Generic.Queue`1<UnityEngine.UnitySynchronizationContext/WorkRequest>::Dequeue()
#define Queue_1_Dequeue_m979967976(__this, method) ((  WorkRequest_t1354518612  (*) (Queue_1_t1200778106 *, const RuntimeMethod*))Queue_1_Dequeue_m979967976_gshared)(__this, method)
// System.Void UnityEngine.UnitySynchronizationContext/WorkRequest::Invoke()
extern "C"  void WorkRequest_Invoke_m3488164927 (WorkRequest_t1354518612 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.Collections.Generic.Queue`1<UnityEngine.UnitySynchronizationContext/WorkRequest>::get_Count()
#define Queue_1_get_Count_m3368911732(__this, method) ((  int32_t (*) (Queue_1_t1200778106 *, const RuntimeMethod*))Queue_1_get_Count_m3368911732_gshared)(__this, method)
// System.Void System.Threading.Monitor::Exit(System.Object)
extern "C"  void Monitor_Exit_m3585316909 (RuntimeObject * __this /* static, unused */, RuntimeObject * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Threading.SynchronizationContext System.Threading.SynchronizationContext::get_Current()
extern "C"  SynchronizationContext_t2326897723 * SynchronizationContext_get_Current_m3666546046 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.UnitySynchronizationContext::.ctor()
extern "C"  void UnitySynchronizationContext__ctor_m1707488257 (UnitySynchronizationContext_t1887453786 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Threading.SynchronizationContext::SetSynchronizationContext(System.Threading.SynchronizationContext)
extern "C"  void SynchronizationContext_SetSynchronizationContext_m1249070039 (RuntimeObject * __this /* static, unused */, SynchronizationContext_t2326897723 * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.UnitySynchronizationContext::Exec()
extern "C"  void UnitySynchronizationContext_Exec_m3359802660 (UnitySynchronizationContext_t1887453786 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Threading.SendOrPostCallback::Invoke(System.Object)
extern "C"  void SendOrPostCallback_Invoke_m937799800 (SendOrPostCallback_t2750080073 * __this, RuntimeObject * p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Threading.EventWaitHandle::Set()
extern "C"  bool EventWaitHandle_Set_m2445193251 (EventWaitHandle_t777845177 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Vector2::.ctor(System.Single,System.Single)
extern "C"  void Vector2__ctor_m3970636864 (Vector2_t2156229523 * __this, float ___x0, float ___y1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.IndexOutOfRangeException::.ctor(System.String)
extern "C"  void IndexOutOfRangeException__ctor_m3408750441 (IndexOutOfRangeException_t1578797820 * __this, String_t* p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Vector2::get_Item(System.Int32)
extern "C"  float Vector2_get_Item_m3559215723 (Vector2_t2156229523 * __this, int32_t ___index0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Vector2::set_Item(System.Int32,System.Single)
extern "C"  void Vector2_set_Item_m3557490725 (Vector2_t2156229523 * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Mathf::Clamp01(System.Single)
extern "C"  float Mathf_Clamp01_m56433566 (RuntimeObject * __this /* static, unused */, float ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.UnityString::Format(System.String,System.Object[])
extern "C"  String_t* UnityString_Format_m261690510 (RuntimeObject * __this /* static, unused */, String_t* p0, ObjectU5BU5D_t2843939325* p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.Vector2::ToString()
extern "C"  String_t* Vector2_ToString_m1205609053 (Vector2_t2156229523 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.Single::GetHashCode()
extern "C"  int32_t Single_GetHashCode_m1558506138 (float* __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Vector2::GetHashCode()
extern "C"  int32_t Vector2_GetHashCode_m3916089713 (Vector2_t2156229523 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean System.Single::Equals(System.Single)
extern "C"  bool Single_Equals_m1601893879 (float* __this, float p0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Vector2::Equals(System.Object)
extern "C"  bool Vector2_Equals_m832062989 (Vector2_t2156229523 * __this, RuntimeObject * ___other0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Vector2::get_sqrMagnitude()
extern "C"  float Vector2_get_sqrMagnitude_m837837635 (Vector2_t2156229523 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector2 UnityEngine.Vector2::op_Subtraction(UnityEngine.Vector2,UnityEngine.Vector2)
extern "C"  Vector2_t2156229523  Vector2_op_Subtraction_m73004381 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___a0, Vector2_t2156229523  ___b1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Vector2::op_Equality(UnityEngine.Vector2,UnityEngine.Vector2)
extern "C"  bool Vector2_op_Equality_m2303255133 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___lhs0, Vector2_t2156229523  ___rhs1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
extern "C"  void Vector3__ctor_m3353183577 (Vector3_t3722313464 * __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single)
extern "C"  void Vector3__ctor_m1719387948 (Vector3_t3722313464 * __this, float ___x0, float ___y1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Vector3::get_magnitude()
extern "C"  float Vector3_get_magnitude_m27958459 (Vector3_t3722313464 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Division(UnityEngine.Vector3,System.Single)
extern "C"  Vector3_t3722313464  Vector3_op_Division_m510815599 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___a0, float ___d1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(UnityEngine.Vector3,System.Single)
extern "C"  Vector3_t3722313464  Vector3_op_Multiply_m3376773913 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___a0, float ___d1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Vector3::get_Item(System.Int32)
extern "C"  float Vector3_get_Item_m668685504 (Vector3_t3722313464 * __this, int32_t ___index0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Vector3::set_Item(System.Int32,System.Single)
extern "C"  void Vector3_set_Item_m1772472431 (Vector3_t3722313464 * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Vector3::GetHashCode()
extern "C"  int32_t Vector3_GetHashCode_m2879461828 (Vector3_t3722313464 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Vector3::Equals(System.Object)
extern "C"  bool Vector3_Equals_m1753054704 (Vector3_t3722313464 * __this, RuntimeObject * ___other0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Vector3::Magnitude(UnityEngine.Vector3)
extern "C"  float Vector3_Magnitude_m3447562852 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___vector0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
extern "C"  Vector3_t3722313464  Vector3_get_zero_m1409827619 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Vector3::Normalize()
extern "C"  void Vector3_Normalize_m914904454 (Vector3_t3722313464 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::Normalize(UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Vector3_Normalize_m2941713846 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___value0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector3 UnityEngine.Vector3::get_normalized()
extern "C"  Vector3_t3722313464  Vector3_get_normalized_m2454957984 (Vector3_t3722313464 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Vector3::get_sqrMagnitude()
extern "C"  float Vector3_get_sqrMagnitude_m1474274574 (Vector3_t3722313464 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Mathf::Min(System.Single,System.Single)
extern "C"  float Mathf_Min_m1073399594 (RuntimeObject * __this /* static, unused */, float ___a0, float ___b1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Mathf::Max(System.Single,System.Single)
extern "C"  float Mathf_Max_m3146388979 (RuntimeObject * __this /* static, unused */, float ___a0, float ___b1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Vector3::SqrMagnitude(UnityEngine.Vector3)
extern "C"  float Vector3_SqrMagnitude_m3025115945 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___vector0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Vector3::op_Equality(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  bool Vector3_op_Equality_m4231250055 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___lhs0, Vector3_t3722313464  ___rhs1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.Vector3::ToString()
extern "C"  String_t* Vector3_ToString_m759076600 (Vector3_t3722313464 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Vector3Int::.ctor(System.Int32,System.Int32,System.Int32)
extern "C"  void Vector3Int__ctor_m2885707673 (Vector3Int_t741115188 * __this, int32_t ___x0, int32_t ___y1, int32_t ___z2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Vector3Int::get_x()
extern "C"  int32_t Vector3Int_get_x_m3022184941 (Vector3Int_t741115188 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Vector3Int::get_y()
extern "C"  int32_t Vector3Int_get_y_m3022184942 (Vector3Int_t741115188 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Vector3Int::get_z()
extern "C"  int32_t Vector3Int_get_z_m3022184939 (Vector3Int_t741115188 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Vector3Int::op_Equality(UnityEngine.Vector3Int,UnityEngine.Vector3Int)
extern "C"  bool Vector3Int_op_Equality_m4107634402 (RuntimeObject * __this /* static, unused */, Vector3Int_t741115188  ___lhs0, Vector3Int_t741115188  ___rhs1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Vector3Int::Equals(System.Object)
extern "C"  bool Vector3Int_Equals_m1306183009 (Vector3Int_t741115188 * __this, RuntimeObject * ___other0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 System.Int32::GetHashCode()
extern "C"  int32_t Int32_GetHashCode_m1876651407 (int32_t* __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Vector3Int::GetHashCode()
extern "C"  int32_t Vector3Int_GetHashCode_m59183038 (Vector3Int_t741115188 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.Vector3Int::ToString()
extern "C"  String_t* Vector3Int_ToString_m3033835977 (Vector3Int_t741115188 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Vector4::.ctor(System.Single,System.Single,System.Single,System.Single)
extern "C"  void Vector4__ctor_m2498754347 (Vector4_t3319028937 * __this, float ___x0, float ___y1, float ___z2, float ___w3, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Vector4::get_Item(System.Int32)
extern "C"  float Vector4_get_Item_m2380866393 (Vector4_t3319028937 * __this, int32_t ___index0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.Vector4::set_Item(System.Int32,System.Single)
extern "C"  void Vector4_set_Item_m1183742235 (Vector4_t3319028937 * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Int32 UnityEngine.Vector4::GetHashCode()
extern "C"  int32_t Vector4_GetHashCode_m536821243 (Vector4_t3319028937 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Boolean UnityEngine.Vector4::Equals(System.Object)
extern "C"  bool Vector4_Equals_m1779210055 (Vector4_t3319028937 * __this, RuntimeObject * ___other0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Vector4::Dot(UnityEngine.Vector4,UnityEngine.Vector4)
extern "C"  float Vector4_Dot_m3492158352 (RuntimeObject * __this /* static, unused */, Vector4_t3319028937  ___a0, Vector4_t3319028937  ___b1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Vector4::get_sqrMagnitude()
extern "C"  float Vector4_get_sqrMagnitude_m3767723558 (Vector4_t3319028937 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// UnityEngine.Vector4 UnityEngine.Vector4::op_Subtraction(UnityEngine.Vector4,UnityEngine.Vector4)
extern "C"  Vector4_t3319028937  Vector4_op_Subtraction_m1632208160 (RuntimeObject * __this /* static, unused */, Vector4_t3319028937  ___a0, Vector4_t3319028937  ___b1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Vector4::SqrMagnitude(UnityEngine.Vector4)
extern "C"  float Vector4_SqrMagnitude_m1488236336 (RuntimeObject * __this /* static, unused */, Vector4_t3319028937  ___a0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.String UnityEngine.Vector4::ToString()
extern "C"  String_t* Vector4_ToString_m1596036856 (Vector4_t3319028937 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.YieldInstruction::.ctor()
extern "C"  void YieldInstruction__ctor_m1498450609 (YieldInstruction_t403091072 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngine.CustomYieldInstruction::.ctor()
extern "C"  void CustomYieldInstruction__ctor_m3408208142 (CustomYieldInstruction_t1895667560 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single UnityEngine.Time::get_realtimeSinceStartup()
extern "C"  float Time_get_realtimeSinceStartup_m3141794964 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void System.Collections.Stack::.ctor()
extern "C"  void Stack__ctor_m2907601956 (Stack_t2329662280 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Single System.Threading.Interlocked::CompareExchange(System.Single&,System.Single,System.Single)
extern "C"  float Interlocked_CompareExchange_m4173283112 (RuntimeObject * __this /* static, unused */, float* p0, float p1, float p2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Delegate System.Delegate::CreateDelegate(System.Type,System.Object,System.Reflection.MethodInfo)
extern "C"  Delegate_t1188392813 * Delegate_CreateDelegate_m995503480 (RuntimeObject * __this /* static, unused */, Type_t * p0, RuntimeObject * p1, MethodInfo_t * p2, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Reflection.MethodInfo System.Delegate::get_Method()
extern "C"  MethodInfo_t * Delegate_get_Method_m3071622864 (Delegate_t1188392813 * __this, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Delegate System.Delegate::CreateDelegate(System.Type,System.Reflection.MethodInfo)
extern "C"  Delegate_t1188392813 * Delegate_CreateDelegate_m2396489936 (RuntimeObject * __this /* static, unused */, Type_t * p0, MethodInfo_t * p1, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
// System.Void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(System.String)
extern "C"  void TypeInferenceRuleAttribute__ctor_m2736695831 (TypeInferenceRuleAttribute_t254868554 * __this, String_t* ___rule0, const RuntimeMethod* method) IL2CPP_METHOD_ATTR;
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.SendMouseEvents/HitInfo
extern "C" void HitInfo_t3229609740_marshal_pinvoke(const HitInfo_t3229609740& unmarshaled, HitInfo_t3229609740_marshaled_pinvoke& marshaled)
{
	Exception_t* ___target_0Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'target' of type 'HitInfo': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___target_0Exception,NULL);
}
extern "C" void HitInfo_t3229609740_marshal_pinvoke_back(const HitInfo_t3229609740_marshaled_pinvoke& marshaled, HitInfo_t3229609740& unmarshaled)
{
	Exception_t* ___target_0Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'target' of type 'HitInfo': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___target_0Exception,NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.SendMouseEvents/HitInfo
extern "C" void HitInfo_t3229609740_marshal_pinvoke_cleanup(HitInfo_t3229609740_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.SendMouseEvents/HitInfo
extern "C" void HitInfo_t3229609740_marshal_com(const HitInfo_t3229609740& unmarshaled, HitInfo_t3229609740_marshaled_com& marshaled)
{
	Exception_t* ___target_0Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'target' of type 'HitInfo': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___target_0Exception,NULL);
}
extern "C" void HitInfo_t3229609740_marshal_com_back(const HitInfo_t3229609740_marshaled_com& marshaled, HitInfo_t3229609740& unmarshaled)
{
	Exception_t* ___target_0Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'target' of type 'HitInfo': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___target_0Exception,NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.SendMouseEvents/HitInfo
extern "C" void HitInfo_t3229609740_marshal_com_cleanup(HitInfo_t3229609740_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.SendMouseEvents/HitInfo::SendMessage(System.String)
extern "C"  void HitInfo_SendMessage_m1343099429 (HitInfo_t3229609740 * __this, String_t* ___name0, const RuntimeMethod* method)
{
	{
		GameObject_t1113636619 * L_0 = __this->get_target_0();
		String_t* L_1 = ___name0;
		GameObject_SendMessage_m3720186693(L_0, L_1, NULL, 1, /*hidden argument*/NULL);
		return;
	}
}
extern "C"  void HitInfo_SendMessage_m1343099429_AdjustorThunk (RuntimeObject * __this, String_t* ___name0, const RuntimeMethod* method)
{
	HitInfo_t3229609740 * _thisAdjusted = reinterpret_cast<HitInfo_t3229609740 *>(__this + 1);
	HitInfo_SendMessage_m1343099429(_thisAdjusted, ___name0, method);
}
// System.Boolean UnityEngine.SendMouseEvents/HitInfo::op_Implicit(UnityEngine.SendMouseEvents/HitInfo)
extern "C"  bool HitInfo_op_Implicit_m665224877 (RuntimeObject * __this /* static, unused */, HitInfo_t3229609740  ___exists0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (HitInfo_op_Implicit_m665224877_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t G_B3_0 = 0;
	{
		GameObject_t1113636619 * L_0 = (&___exists0)->get_target_0();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		bool L_1 = Object_op_Inequality_m4071470834(NULL /*static, unused*/, L_0, (Object_t631007953 *)NULL, /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0022;
		}
	}
	{
		Camera_t4157153871 * L_2 = (&___exists0)->get_camera_1();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		bool L_3 = Object_op_Inequality_m4071470834(NULL /*static, unused*/, L_2, (Object_t631007953 *)NULL, /*hidden argument*/NULL);
		G_B3_0 = ((int32_t)(L_3));
		goto IL_0023;
	}

IL_0022:
	{
		G_B3_0 = 0;
	}

IL_0023:
	{
		V_0 = (bool)G_B3_0;
		goto IL_0029;
	}

IL_0029:
	{
		bool L_4 = V_0;
		return L_4;
	}
}
// System.Boolean UnityEngine.SendMouseEvents/HitInfo::Compare(UnityEngine.SendMouseEvents/HitInfo,UnityEngine.SendMouseEvents/HitInfo)
extern "C"  bool HitInfo_Compare_m2336739674 (RuntimeObject * __this /* static, unused */, HitInfo_t3229609740  ___lhs0, HitInfo_t3229609740  ___rhs1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (HitInfo_Compare_m2336739674_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	int32_t G_B3_0 = 0;
	{
		GameObject_t1113636619 * L_0 = (&___lhs0)->get_target_0();
		GameObject_t1113636619 * L_1 = (&___rhs1)->get_target_0();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		bool L_2 = Object_op_Equality_m1810815630(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		if (!L_2)
		{
			goto IL_002e;
		}
	}
	{
		Camera_t4157153871 * L_3 = (&___lhs0)->get_camera_1();
		Camera_t4157153871 * L_4 = (&___rhs1)->get_camera_1();
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		bool L_5 = Object_op_Equality_m1810815630(NULL /*static, unused*/, L_3, L_4, /*hidden argument*/NULL);
		G_B3_0 = ((int32_t)(L_5));
		goto IL_002f;
	}

IL_002e:
	{
		G_B3_0 = 0;
	}

IL_002f:
	{
		V_0 = (bool)G_B3_0;
		goto IL_0035;
	}

IL_0035:
	{
		bool L_6 = V_0;
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
// System.Void UnityEngine.Serialization.FormerlySerializedAsAttribute::.ctor(System.String)
extern "C"  void FormerlySerializedAsAttribute__ctor_m520861771 (FormerlySerializedAsAttribute_t2859083114 * __this, String_t* ___oldName0, const RuntimeMethod* method)
{
	{
		Attribute__ctor_m1529526131(__this, /*hidden argument*/NULL);
		String_t* L_0 = ___oldName0;
		__this->set_m_oldName_0(L_0);
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
// System.Void UnityEngine.SerializeField::.ctor()
extern "C"  void SerializeField__ctor_m808862924 (SerializeField_t3286833614 * __this, const RuntimeMethod* method)
{
	{
		Attribute__ctor_m1529526131(__this, /*hidden argument*/NULL);
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.SetupCoroutine::InvokeMoveNext(System.Collections.IEnumerator,System.IntPtr)
extern "C"  void SetupCoroutine_InvokeMoveNext_m3199342729 (RuntimeObject * __this /* static, unused */, RuntimeObject* ___enumerator0, intptr_t ___returnValueAddress1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SetupCoroutine_InvokeMoveNext_m3199342729_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		intptr_t L_0 = ___returnValueAddress1;
		bool L_1 = IntPtr_op_Equality_m408849716(NULL /*static, unused*/, L_0, (intptr_t)(0), /*hidden argument*/NULL);
		if (!L_1)
		{
			goto IL_0021;
		}
	}
	{
		ArgumentException_t132251570 * L_2 = (ArgumentException_t132251570 *)il2cpp_codegen_object_new(ArgumentException_t132251570_il2cpp_TypeInfo_var);
		ArgumentException__ctor_m1216717135(L_2, _stringLiteral2664163362, _stringLiteral696106652, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_2,SetupCoroutine_InvokeMoveNext_m3199342729_RuntimeMethod_var);
	}

IL_0021:
	{
		intptr_t L_3 = ___returnValueAddress1;
		void* L_4 = IntPtr_op_Explicit_m2520637223(NULL /*static, unused*/, L_3, /*hidden argument*/NULL);
		RuntimeObject* L_5 = ___enumerator0;
		bool L_6 = InterfaceFuncInvoker0< bool >::Invoke(1 /* System.Boolean System.Collections.IEnumerator::MoveNext() */, IEnumerator_t1853284238_il2cpp_TypeInfo_var, L_5);
		*((int8_t*)(L_4)) = (int8_t)L_6;
		return;
	}
}
// System.Object UnityEngine.SetupCoroutine::InvokeMember(System.Object,System.String,System.Object)
extern "C"  RuntimeObject * SetupCoroutine_InvokeMember_m2661944898 (RuntimeObject * __this /* static, unused */, RuntimeObject * ___behaviour0, String_t* ___name1, RuntimeObject * ___variable2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SetupCoroutine_InvokeMember_m2661944898_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	ObjectU5BU5D_t2843939325* V_0 = NULL;
	RuntimeObject * V_1 = NULL;
	{
		V_0 = (ObjectU5BU5D_t2843939325*)NULL;
		RuntimeObject * L_0 = ___variable2;
		if (!L_0)
		{
			goto IL_0016;
		}
	}
	{
		V_0 = ((ObjectU5BU5D_t2843939325*)SZArrayNew(ObjectU5BU5D_t2843939325_il2cpp_TypeInfo_var, (uint32_t)1));
		ObjectU5BU5D_t2843939325* L_1 = V_0;
		RuntimeObject * L_2 = ___variable2;
		ArrayElementTypeCheck (L_1, L_2);
		(L_1)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_2);
	}

IL_0016:
	{
		RuntimeObject * L_3 = ___behaviour0;
		Type_t * L_4 = Object_GetType_m88164663(L_3, /*hidden argument*/NULL);
		String_t* L_5 = ___name1;
		RuntimeObject * L_6 = ___behaviour0;
		ObjectU5BU5D_t2843939325* L_7 = V_0;
		RuntimeObject * L_8 = VirtFuncInvoker8< RuntimeObject *, String_t*, int32_t, Binder_t2999457153 *, RuntimeObject *, ObjectU5BU5D_t2843939325*, ParameterModifierU5BU5D_t2943407543*, CultureInfo_t4157843068 *, StringU5BU5D_t1281789340* >::Invoke(76 /* System.Object System.Type::InvokeMember(System.String,System.Reflection.BindingFlags,System.Reflection.Binder,System.Object,System.Object[],System.Reflection.ParameterModifier[],System.Globalization.CultureInfo,System.String[]) */, L_4, L_5, ((int32_t)308), (Binder_t2999457153 *)NULL, L_6, L_7, (ParameterModifierU5BU5D_t2943407543*)(ParameterModifierU5BU5D_t2943407543*)NULL, (CultureInfo_t4157843068 *)NULL, (StringU5BU5D_t1281789340*)(StringU5BU5D_t1281789340*)NULL);
		V_1 = L_8;
		goto IL_0033;
	}

IL_0033:
	{
		RuntimeObject * L_9 = V_1;
		return L_9;
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
// System.Int32 UnityEngine.Shader::PropertyToID(System.String)
extern "C"  int32_t Shader_PropertyToID_m1030499873 (RuntimeObject * __this /* static, unused */, String_t* ___name0, const RuntimeMethod* method)
{
	typedef int32_t (*Shader_PropertyToID_m1030499873_ftn) (String_t*);
	static Shader_PropertyToID_m1030499873_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Shader_PropertyToID_m1030499873_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Shader::PropertyToID(System.String)");
	int32_t retVal = _il2cpp_icall_func(___name0);
	return retVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Int32 UnityEngine.SortingLayer::GetLayerValueFromID(System.Int32)
extern "C"  int32_t SortingLayer_GetLayerValueFromID_m1947934714 (RuntimeObject * __this /* static, unused */, int32_t ___id0, const RuntimeMethod* method)
{
	typedef int32_t (*SortingLayer_GetLayerValueFromID_m1947934714_ftn) (int32_t);
	static SortingLayer_GetLayerValueFromID_m1947934714_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (SortingLayer_GetLayerValueFromID_m1947934714_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.SortingLayer::GetLayerValueFromID(System.Int32)");
	int32_t retVal = _il2cpp_icall_func(___id0);
	return retVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.SpaceAttribute::.ctor()
extern "C"  void SpaceAttribute__ctor_m3235906033 (SpaceAttribute_t3956583069 * __this, const RuntimeMethod* method)
{
	{
		PropertyAttribute__ctor_m1017741868(__this, /*hidden argument*/NULL);
		__this->set_height_0((8.0f));
		return;
	}
}
// System.Void UnityEngine.SpaceAttribute::.ctor(System.Single)
extern "C"  void SpaceAttribute__ctor_m2972541600 (SpaceAttribute_t3956583069 * __this, float ___height0, const RuntimeMethod* method)
{
	{
		PropertyAttribute__ctor_m1017741868(__this, /*hidden argument*/NULL);
		float L_0 = ___height0;
		__this->set_height_0(L_0);
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
// System.Void UnityEngine.Sprite::.ctor()
extern "C"  void Sprite__ctor_m332781120 (Sprite_t280657092 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Sprite__ctor_m332781120_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		Object__ctor_m1087895580(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Sprite UnityEngine.Sprite::Create(UnityEngine.Texture2D,UnityEngine.Rect,UnityEngine.Vector2)
extern "C"  Sprite_t280657092 * Sprite_Create_m803022218 (RuntimeObject * __this /* static, unused */, Texture2D_t3840446185 * ___texture0, Rect_t2360479859  ___rect1, Vector2_t2156229523  ___pivot2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Sprite_Create_m803022218_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	Vector4_t3319028937  V_1;
	memset(&V_1, 0, sizeof(V_1));
	int32_t V_2 = 0;
	uint32_t V_3 = 0;
	float V_4 = 0.0f;
	Sprite_t280657092 * V_5 = NULL;
	{
		V_0 = (bool)0;
		IL2CPP_RUNTIME_CLASS_INIT(Vector4_t3319028937_il2cpp_TypeInfo_var);
		Vector4_t3319028937  L_0 = Vector4_get_zero_m1422399515(NULL /*static, unused*/, /*hidden argument*/NULL);
		V_1 = L_0;
		V_2 = 1;
		V_3 = 0;
		V_4 = (100.0f);
		Texture2D_t3840446185 * L_1 = ___texture0;
		float L_2 = V_4;
		uint32_t L_3 = V_3;
		int32_t L_4 = V_2;
		bool L_5 = V_0;
		Sprite_t280657092 * L_6 = Sprite_INTERNAL_CALL_Create_m2945291276(NULL /*static, unused*/, L_1, (&___rect1), (&___pivot2), L_2, L_3, L_4, (&V_1), L_5, /*hidden argument*/NULL);
		V_5 = L_6;
		goto IL_002c;
	}

IL_002c:
	{
		Sprite_t280657092 * L_7 = V_5;
		return L_7;
	}
}
// UnityEngine.Sprite UnityEngine.Sprite::INTERNAL_CALL_Create(UnityEngine.Texture2D,UnityEngine.Rect&,UnityEngine.Vector2&,System.Single,System.UInt32,UnityEngine.SpriteMeshType,UnityEngine.Vector4&,System.Boolean)
extern "C"  Sprite_t280657092 * Sprite_INTERNAL_CALL_Create_m2945291276 (RuntimeObject * __this /* static, unused */, Texture2D_t3840446185 * ___texture0, Rect_t2360479859 * ___rect1, Vector2_t2156229523 * ___pivot2, float ___pixelsPerUnit3, uint32_t ___extrude4, int32_t ___meshType5, Vector4_t3319028937 * ___border6, bool ___generateFallbackPhysicsShape7, const RuntimeMethod* method)
{
	typedef Sprite_t280657092 * (*Sprite_INTERNAL_CALL_Create_m2945291276_ftn) (Texture2D_t3840446185 *, Rect_t2360479859 *, Vector2_t2156229523 *, float, uint32_t, int32_t, Vector4_t3319028937 *, bool);
	static Sprite_INTERNAL_CALL_Create_m2945291276_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Sprite_INTERNAL_CALL_Create_m2945291276_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprite::INTERNAL_CALL_Create(UnityEngine.Texture2D,UnityEngine.Rect&,UnityEngine.Vector2&,System.Single,System.UInt32,UnityEngine.SpriteMeshType,UnityEngine.Vector4&,System.Boolean)");
	Sprite_t280657092 * retVal = _il2cpp_icall_func(___texture0, ___rect1, ___pivot2, ___pixelsPerUnit3, ___extrude4, ___meshType5, ___border6, ___generateFallbackPhysicsShape7);
	return retVal;
}
// UnityEngine.Rect UnityEngine.Sprite::get_rect()
extern "C"  Rect_t2360479859  Sprite_get_rect_m2575211689 (Sprite_t280657092 * __this, const RuntimeMethod* method)
{
	Rect_t2360479859  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Rect_t2360479859  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Sprite_INTERNAL_get_rect_m1600380876(__this, (&V_0), /*hidden argument*/NULL);
		Rect_t2360479859  L_0 = V_0;
		V_1 = L_0;
		goto IL_0010;
	}

IL_0010:
	{
		Rect_t2360479859  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Sprite::INTERNAL_get_rect(UnityEngine.Rect&)
extern "C"  void Sprite_INTERNAL_get_rect_m1600380876 (Sprite_t280657092 * __this, Rect_t2360479859 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Sprite_INTERNAL_get_rect_m1600380876_ftn) (Sprite_t280657092 *, Rect_t2360479859 *);
	static Sprite_INTERNAL_get_rect_m1600380876_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Sprite_INTERNAL_get_rect_m1600380876_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprite::INTERNAL_get_rect(UnityEngine.Rect&)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.Texture2D UnityEngine.Sprite::get_texture()
extern "C"  Texture2D_t3840446185 * Sprite_get_texture_m3976398399 (Sprite_t280657092 * __this, const RuntimeMethod* method)
{
	typedef Texture2D_t3840446185 * (*Sprite_get_texture_m3976398399_ftn) (Sprite_t280657092 *);
	static Sprite_get_texture_m3976398399_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Sprite_get_texture_m3976398399_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprite::get_texture()");
	Texture2D_t3840446185 * retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// UnityEngine.Texture2D UnityEngine.Sprite::get_associatedAlphaSplitTexture()
extern "C"  Texture2D_t3840446185 * Sprite_get_associatedAlphaSplitTexture_m1197622862 (Sprite_t280657092 * __this, const RuntimeMethod* method)
{
	typedef Texture2D_t3840446185 * (*Sprite_get_associatedAlphaSplitTexture_m1197622862_ftn) (Sprite_t280657092 *);
	static Sprite_get_associatedAlphaSplitTexture_m1197622862_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Sprite_get_associatedAlphaSplitTexture_m1197622862_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprite::get_associatedAlphaSplitTexture()");
	Texture2D_t3840446185 * retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// UnityEngine.Rect UnityEngine.Sprite::get_textureRect()
extern "C"  Rect_t2360479859  Sprite_get_textureRect_m3217515846 (Sprite_t280657092 * __this, const RuntimeMethod* method)
{
	Rect_t2360479859  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Rect_t2360479859  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Sprite_INTERNAL_get_textureRect_m2310671861(__this, (&V_0), /*hidden argument*/NULL);
		Rect_t2360479859  L_0 = V_0;
		V_1 = L_0;
		goto IL_0010;
	}

IL_0010:
	{
		Rect_t2360479859  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Sprite::INTERNAL_get_textureRect(UnityEngine.Rect&)
extern "C"  void Sprite_INTERNAL_get_textureRect_m2310671861 (Sprite_t280657092 * __this, Rect_t2360479859 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Sprite_INTERNAL_get_textureRect_m2310671861_ftn) (Sprite_t280657092 *, Rect_t2360479859 *);
	static Sprite_INTERNAL_get_textureRect_m2310671861_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Sprite_INTERNAL_get_textureRect_m2310671861_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprite::INTERNAL_get_textureRect(UnityEngine.Rect&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Boolean UnityEngine.Sprite::get_packed()
extern "C"  bool Sprite_get_packed_m1179604684 (Sprite_t280657092 * __this, const RuntimeMethod* method)
{
	typedef bool (*Sprite_get_packed_m1179604684_ftn) (Sprite_t280657092 *);
	static Sprite_get_packed_m1179604684_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Sprite_get_packed_m1179604684_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprite::get_packed()");
	bool retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.Sprite::Internal_GetPivot(UnityEngine.Sprite,UnityEngine.Vector2&)
extern "C"  void Sprite_Internal_GetPivot_m3815020698 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, Vector2_t2156229523 * ___output1, const RuntimeMethod* method)
{
	typedef void (*Sprite_Internal_GetPivot_m3815020698_ftn) (Sprite_t280657092 *, Vector2_t2156229523 *);
	static Sprite_Internal_GetPivot_m3815020698_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Sprite_Internal_GetPivot_m3815020698_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprite::Internal_GetPivot(UnityEngine.Sprite,UnityEngine.Vector2&)");
	_il2cpp_icall_func(___sprite0, ___output1);
}
// UnityEngine.Vector2 UnityEngine.Sprite::get_pivot()
extern "C"  Vector2_t2156229523  Sprite_get_pivot_m1066702578 (Sprite_t280657092 * __this, const RuntimeMethod* method)
{
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector2_t2156229523  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Sprite_Internal_GetPivot_m3815020698(NULL /*static, unused*/, __this, (&V_0), /*hidden argument*/NULL);
		Vector2_t2156229523  L_0 = V_0;
		V_1 = L_0;
		goto IL_0010;
	}

IL_0010:
	{
		Vector2_t2156229523  L_1 = V_1;
		return L_1;
	}
}
// UnityEngine.Vector4 UnityEngine.Sprite::get_border()
extern "C"  Vector4_t3319028937  Sprite_get_border_m2985609076 (Sprite_t280657092 * __this, const RuntimeMethod* method)
{
	Vector4_t3319028937  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector4_t3319028937  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Sprite_INTERNAL_get_border_m3728071101(__this, (&V_0), /*hidden argument*/NULL);
		Vector4_t3319028937  L_0 = V_0;
		V_1 = L_0;
		goto IL_0010;
	}

IL_0010:
	{
		Vector4_t3319028937  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Sprite::INTERNAL_get_border(UnityEngine.Vector4&)
extern "C"  void Sprite_INTERNAL_get_border_m3728071101 (Sprite_t280657092 * __this, Vector4_t3319028937 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Sprite_INTERNAL_get_border_m3728071101_ftn) (Sprite_t280657092 *, Vector4_t3319028937 *);
	static Sprite_INTERNAL_get_border_m3728071101_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Sprite_INTERNAL_get_border_m3728071101_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprite::INTERNAL_get_border(UnityEngine.Vector4&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Single UnityEngine.Sprite::get_pixelsPerUnit()
extern "C"  float Sprite_get_pixelsPerUnit_m524644775 (Sprite_t280657092 * __this, const RuntimeMethod* method)
{
	typedef float (*Sprite_get_pixelsPerUnit_m524644775_ftn) (Sprite_t280657092 *);
	static Sprite_get_pixelsPerUnit_m524644775_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Sprite_get_pixelsPerUnit_m524644775_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprite::get_pixelsPerUnit()");
	float retVal = _il2cpp_icall_func(__this);
	return retVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.SpriteRenderer::set_sprite(UnityEngine.Sprite)
extern "C"  void SpriteRenderer_set_sprite_m1286893786 (SpriteRenderer_t3235626157 * __this, Sprite_t280657092 * ___value0, const RuntimeMethod* method)
{
	{
		Sprite_t280657092 * L_0 = ___value0;
		SpriteRenderer_SetSprite_INTERNAL_m957744766(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.SpriteRenderer::SetSprite_INTERNAL(UnityEngine.Sprite)
extern "C"  void SpriteRenderer_SetSprite_INTERNAL_m957744766 (SpriteRenderer_t3235626157 * __this, Sprite_t280657092 * ___sprite0, const RuntimeMethod* method)
{
	typedef void (*SpriteRenderer_SetSprite_INTERNAL_m957744766_ftn) (SpriteRenderer_t3235626157 *, Sprite_t280657092 *);
	static SpriteRenderer_SetSprite_INTERNAL_m957744766_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (SpriteRenderer_SetSprite_INTERNAL_m957744766_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.SpriteRenderer::SetSprite_INTERNAL(UnityEngine.Sprite)");
	_il2cpp_icall_func(__this, ___sprite0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.Vector4 UnityEngine.Sprites.DataUtility::GetInnerUV(UnityEngine.Sprite)
extern "C"  Vector4_t3319028937  DataUtility_GetInnerUV_m2896140645 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, const RuntimeMethod* method)
{
	Vector4_t3319028937  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector4_t3319028937  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Sprite_t280657092 * L_0 = ___sprite0;
		DataUtility_INTERNAL_CALL_GetInnerUV_m1230966310(NULL /*static, unused*/, L_0, (&V_0), /*hidden argument*/NULL);
		Vector4_t3319028937  L_1 = V_0;
		V_1 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Vector4_t3319028937  L_2 = V_1;
		return L_2;
	}
}
// System.Void UnityEngine.Sprites.DataUtility::INTERNAL_CALL_GetInnerUV(UnityEngine.Sprite,UnityEngine.Vector4&)
extern "C"  void DataUtility_INTERNAL_CALL_GetInnerUV_m1230966310 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, Vector4_t3319028937 * ___value1, const RuntimeMethod* method)
{
	typedef void (*DataUtility_INTERNAL_CALL_GetInnerUV_m1230966310_ftn) (Sprite_t280657092 *, Vector4_t3319028937 *);
	static DataUtility_INTERNAL_CALL_GetInnerUV_m1230966310_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (DataUtility_INTERNAL_CALL_GetInnerUV_m1230966310_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprites.DataUtility::INTERNAL_CALL_GetInnerUV(UnityEngine.Sprite,UnityEngine.Vector4&)");
	_il2cpp_icall_func(___sprite0, ___value1);
}
// UnityEngine.Vector4 UnityEngine.Sprites.DataUtility::GetOuterUV(UnityEngine.Sprite)
extern "C"  Vector4_t3319028937  DataUtility_GetOuterUV_m2509686757 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, const RuntimeMethod* method)
{
	Vector4_t3319028937  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector4_t3319028937  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Sprite_t280657092 * L_0 = ___sprite0;
		DataUtility_INTERNAL_CALL_GetOuterUV_m2471985598(NULL /*static, unused*/, L_0, (&V_0), /*hidden argument*/NULL);
		Vector4_t3319028937  L_1 = V_0;
		V_1 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Vector4_t3319028937  L_2 = V_1;
		return L_2;
	}
}
// System.Void UnityEngine.Sprites.DataUtility::INTERNAL_CALL_GetOuterUV(UnityEngine.Sprite,UnityEngine.Vector4&)
extern "C"  void DataUtility_INTERNAL_CALL_GetOuterUV_m2471985598 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, Vector4_t3319028937 * ___value1, const RuntimeMethod* method)
{
	typedef void (*DataUtility_INTERNAL_CALL_GetOuterUV_m2471985598_ftn) (Sprite_t280657092 *, Vector4_t3319028937 *);
	static DataUtility_INTERNAL_CALL_GetOuterUV_m2471985598_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (DataUtility_INTERNAL_CALL_GetOuterUV_m2471985598_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprites.DataUtility::INTERNAL_CALL_GetOuterUV(UnityEngine.Sprite,UnityEngine.Vector4&)");
	_il2cpp_icall_func(___sprite0, ___value1);
}
// UnityEngine.Vector4 UnityEngine.Sprites.DataUtility::GetPadding(UnityEngine.Sprite)
extern "C"  Vector4_t3319028937  DataUtility_GetPadding_m1385423541 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, const RuntimeMethod* method)
{
	Vector4_t3319028937  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector4_t3319028937  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Sprite_t280657092 * L_0 = ___sprite0;
		DataUtility_INTERNAL_CALL_GetPadding_m650254139(NULL /*static, unused*/, L_0, (&V_0), /*hidden argument*/NULL);
		Vector4_t3319028937  L_1 = V_0;
		V_1 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Vector4_t3319028937  L_2 = V_1;
		return L_2;
	}
}
// System.Void UnityEngine.Sprites.DataUtility::INTERNAL_CALL_GetPadding(UnityEngine.Sprite,UnityEngine.Vector4&)
extern "C"  void DataUtility_INTERNAL_CALL_GetPadding_m650254139 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, Vector4_t3319028937 * ___value1, const RuntimeMethod* method)
{
	typedef void (*DataUtility_INTERNAL_CALL_GetPadding_m650254139_ftn) (Sprite_t280657092 *, Vector4_t3319028937 *);
	static DataUtility_INTERNAL_CALL_GetPadding_m650254139_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (DataUtility_INTERNAL_CALL_GetPadding_m650254139_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprites.DataUtility::INTERNAL_CALL_GetPadding(UnityEngine.Sprite,UnityEngine.Vector4&)");
	_il2cpp_icall_func(___sprite0, ___value1);
}
// UnityEngine.Vector2 UnityEngine.Sprites.DataUtility::GetMinSize(UnityEngine.Sprite)
extern "C"  Vector2_t2156229523  DataUtility_GetMinSize_m843062179 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, const RuntimeMethod* method)
{
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector2_t2156229523  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Sprite_t280657092 * L_0 = ___sprite0;
		DataUtility_Internal_GetMinSize_m2628270685(NULL /*static, unused*/, L_0, (&V_0), /*hidden argument*/NULL);
		Vector2_t2156229523  L_1 = V_0;
		V_1 = L_1;
		goto IL_0010;
	}

IL_0010:
	{
		Vector2_t2156229523  L_2 = V_1;
		return L_2;
	}
}
// System.Void UnityEngine.Sprites.DataUtility::Internal_GetMinSize(UnityEngine.Sprite,UnityEngine.Vector2&)
extern "C"  void DataUtility_Internal_GetMinSize_m2628270685 (RuntimeObject * __this /* static, unused */, Sprite_t280657092 * ___sprite0, Vector2_t2156229523 * ___output1, const RuntimeMethod* method)
{
	typedef void (*DataUtility_Internal_GetMinSize_m2628270685_ftn) (Sprite_t280657092 *, Vector2_t2156229523 *);
	static DataUtility_Internal_GetMinSize_m2628270685_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (DataUtility_Internal_GetMinSize_m2628270685_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Sprites.DataUtility::Internal_GetMinSize(UnityEngine.Sprite,UnityEngine.Vector2&)");
	_il2cpp_icall_func(___sprite0, ___output1);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.StackTraceUtility::SetProjectFolder(System.String)
extern "C"  void StackTraceUtility_SetProjectFolder_m830524047 (RuntimeObject * __this /* static, unused */, String_t* ___folder0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StackTraceUtility_SetProjectFolder_m830524047_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		String_t* L_0 = ___folder0;
		IL2CPP_RUNTIME_CLASS_INIT(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var);
		((StackTraceUtility_t3465565809_StaticFields*)il2cpp_codegen_static_fields_for(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var))->set_projectFolder_0(L_0);
		String_t* L_1 = ((StackTraceUtility_t3465565809_StaticFields*)il2cpp_codegen_static_fields_for(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var))->get_projectFolder_0();
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_2 = String_IsNullOrEmpty_m2969720369(NULL /*static, unused*/, L_1, /*hidden argument*/NULL);
		if (L_2)
		{
			goto IL_002f;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var);
		String_t* L_3 = ((StackTraceUtility_t3465565809_StaticFields*)il2cpp_codegen_static_fields_for(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var))->get_projectFolder_0();
		String_t* L_4 = String_Replace_m1273907647(L_3, _stringLiteral3452614644, _stringLiteral3452614529, /*hidden argument*/NULL);
		((StackTraceUtility_t3465565809_StaticFields*)il2cpp_codegen_static_fields_for(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var))->set_projectFolder_0(L_4);
	}

IL_002f:
	{
		return;
	}
}
// System.String UnityEngine.StackTraceUtility::ExtractStackTrace()
extern "C"  String_t* StackTraceUtility_ExtractStackTrace_m3279197967 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StackTraceUtility_ExtractStackTrace_m3279197967_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	StackTrace_t1598645457 * V_0 = NULL;
	String_t* V_1 = NULL;
	String_t* V_2 = NULL;
	{
		StackTrace_t1598645457 * L_0 = (StackTrace_t1598645457 *)il2cpp_codegen_object_new(StackTrace_t1598645457_il2cpp_TypeInfo_var);
		StackTrace__ctor_m1685176557(L_0, 1, (bool)1, /*hidden argument*/NULL);
		V_0 = L_0;
		StackTrace_t1598645457 * L_1 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var);
		String_t* L_2 = StackTraceUtility_ExtractFormattedStackTrace_m1281750362(NULL /*static, unused*/, L_1, /*hidden argument*/NULL);
		String_t* L_3 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_2);
		V_1 = L_3;
		String_t* L_4 = V_1;
		V_2 = L_4;
		goto IL_001c;
	}

IL_001c:
	{
		String_t* L_5 = V_2;
		return L_5;
	}
}
// System.Boolean UnityEngine.StackTraceUtility::IsSystemStacktraceType(System.Object)
extern "C"  bool StackTraceUtility_IsSystemStacktraceType_m299828041 (RuntimeObject * __this /* static, unused */, RuntimeObject * ___name0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StackTraceUtility_IsSystemStacktraceType_m299828041_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	bool V_1 = false;
	int32_t G_B7_0 = 0;
	{
		RuntimeObject * L_0 = ___name0;
		V_0 = ((String_t*)CastclassSealed((RuntimeObject*)L_0, String_t_il2cpp_TypeInfo_var));
		String_t* L_1 = V_0;
		bool L_2 = String_StartsWith_m1759067526(L_1, _stringLiteral3155606, /*hidden argument*/NULL);
		if (L_2)
		{
			goto IL_0065;
		}
	}
	{
		String_t* L_3 = V_0;
		bool L_4 = String_StartsWith_m1759067526(L_3, _stringLiteral2227937992, /*hidden argument*/NULL);
		if (L_4)
		{
			goto IL_0065;
		}
	}
	{
		String_t* L_5 = V_0;
		bool L_6 = String_StartsWith_m1759067526(L_5, _stringLiteral547166083, /*hidden argument*/NULL);
		if (L_6)
		{
			goto IL_0065;
		}
	}
	{
		String_t* L_7 = V_0;
		bool L_8 = String_StartsWith_m1759067526(L_7, _stringLiteral3960313174, /*hidden argument*/NULL);
		if (L_8)
		{
			goto IL_0065;
		}
	}
	{
		String_t* L_9 = V_0;
		bool L_10 = String_StartsWith_m1759067526(L_9, _stringLiteral1464230170, /*hidden argument*/NULL);
		if (L_10)
		{
			goto IL_0065;
		}
	}
	{
		String_t* L_11 = V_0;
		bool L_12 = String_StartsWith_m1759067526(L_11, _stringLiteral1625510709, /*hidden argument*/NULL);
		G_B7_0 = ((int32_t)(L_12));
		goto IL_0066;
	}

IL_0065:
	{
		G_B7_0 = 1;
	}

IL_0066:
	{
		V_1 = (bool)G_B7_0;
		goto IL_006c;
	}

IL_006c:
	{
		bool L_13 = V_1;
		return L_13;
	}
}
// System.Void UnityEngine.StackTraceUtility::ExtractStringFromExceptionInternal(System.Object,System.String&,System.String&)
extern "C"  void StackTraceUtility_ExtractStringFromExceptionInternal_m2686726792 (RuntimeObject * __this /* static, unused */, RuntimeObject * ___exceptiono0, String_t** ___message1, String_t** ___stackTrace2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StackTraceUtility_ExtractStringFromExceptionInternal_m2686726792_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Exception_t * V_0 = NULL;
	StringBuilder_t * V_1 = NULL;
	String_t* V_2 = NULL;
	String_t* V_3 = NULL;
	String_t* V_4 = NULL;
	StackTrace_t1598645457 * V_5 = NULL;
	int32_t G_B7_0 = 0;
	{
		RuntimeObject * L_0 = ___exceptiono0;
		if (L_0)
		{
			goto IL_0012;
		}
	}
	{
		ArgumentException_t132251570 * L_1 = (ArgumentException_t132251570 *)il2cpp_codegen_object_new(ArgumentException_t132251570_il2cpp_TypeInfo_var);
		ArgumentException__ctor_m1312628991(L_1, _stringLiteral1698478619, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_1,StackTraceUtility_ExtractStringFromExceptionInternal_m2686726792_RuntimeMethod_var);
	}

IL_0012:
	{
		RuntimeObject * L_2 = ___exceptiono0;
		V_0 = ((Exception_t *)IsInstClass((RuntimeObject*)L_2, Exception_t_il2cpp_TypeInfo_var));
		Exception_t * L_3 = V_0;
		if (L_3)
		{
			goto IL_002a;
		}
	}
	{
		ArgumentException_t132251570 * L_4 = (ArgumentException_t132251570 *)il2cpp_codegen_object_new(ArgumentException_t132251570_il2cpp_TypeInfo_var);
		ArgumentException__ctor_m1312628991(L_4, _stringLiteral2231172943, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4,StackTraceUtility_ExtractStringFromExceptionInternal_m2686726792_RuntimeMethod_var);
	}

IL_002a:
	{
		Exception_t * L_5 = V_0;
		String_t* L_6 = VirtFuncInvoker0< String_t* >::Invoke(10 /* System.String System.Exception::get_StackTrace() */, L_5);
		if (L_6)
		{
			goto IL_003f;
		}
	}
	{
		G_B7_0 = ((int32_t)512);
		goto IL_004c;
	}

IL_003f:
	{
		Exception_t * L_7 = V_0;
		String_t* L_8 = VirtFuncInvoker0< String_t* >::Invoke(10 /* System.String System.Exception::get_StackTrace() */, L_7);
		int32_t L_9 = String_get_Length_m3847582255(L_8, /*hidden argument*/NULL);
		G_B7_0 = ((int32_t)il2cpp_codegen_multiply((int32_t)L_9, (int32_t)2));
	}

IL_004c:
	{
		StringBuilder_t * L_10 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m2367297767(L_10, G_B7_0, /*hidden argument*/NULL);
		V_1 = L_10;
		String_t** L_11 = ___message1;
		*((RuntimeObject **)(L_11)) = (RuntimeObject *)_stringLiteral757602046;
		Il2CppCodeGenWriteBarrier((RuntimeObject **)(L_11), (RuntimeObject *)_stringLiteral757602046);
		V_2 = _stringLiteral757602046;
		goto IL_0106;
	}

IL_0064:
	{
		String_t* L_12 = V_2;
		int32_t L_13 = String_get_Length_m3847582255(L_12, /*hidden argument*/NULL);
		if (L_13)
		{
			goto IL_007c;
		}
	}
	{
		Exception_t * L_14 = V_0;
		String_t* L_15 = VirtFuncInvoker0< String_t* >::Invoke(10 /* System.String System.Exception::get_StackTrace() */, L_14);
		V_2 = L_15;
		goto IL_008e;
	}

IL_007c:
	{
		Exception_t * L_16 = V_0;
		String_t* L_17 = VirtFuncInvoker0< String_t* >::Invoke(10 /* System.String System.Exception::get_StackTrace() */, L_16);
		String_t* L_18 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_19 = String_Concat_m3755062657(NULL /*static, unused*/, L_17, _stringLiteral3452614566, L_18, /*hidden argument*/NULL);
		V_2 = L_19;
	}

IL_008e:
	{
		Exception_t * L_20 = V_0;
		Type_t * L_21 = Exception_GetType_m2227967756(L_20, /*hidden argument*/NULL);
		String_t* L_22 = VirtFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_21);
		V_3 = L_22;
		V_4 = _stringLiteral757602046;
		Exception_t * L_23 = V_0;
		String_t* L_24 = VirtFuncInvoker0< String_t* >::Invoke(7 /* System.String System.Exception::get_Message() */, L_23);
		if (!L_24)
		{
			goto IL_00b4;
		}
	}
	{
		Exception_t * L_25 = V_0;
		String_t* L_26 = VirtFuncInvoker0< String_t* >::Invoke(7 /* System.String System.Exception::get_Message() */, L_25);
		V_4 = L_26;
	}

IL_00b4:
	{
		String_t* L_27 = V_4;
		String_t* L_28 = String_Trim_m923598732(L_27, /*hidden argument*/NULL);
		int32_t L_29 = String_get_Length_m3847582255(L_28, /*hidden argument*/NULL);
		if (!L_29)
		{
			goto IL_00dc;
		}
	}
	{
		String_t* L_30 = V_3;
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_31 = String_Concat_m3937257545(NULL /*static, unused*/, L_30, _stringLiteral3450517398, /*hidden argument*/NULL);
		V_3 = L_31;
		String_t* L_32 = V_3;
		String_t* L_33 = V_4;
		String_t* L_34 = String_Concat_m3937257545(NULL /*static, unused*/, L_32, L_33, /*hidden argument*/NULL);
		V_3 = L_34;
	}

IL_00dc:
	{
		String_t** L_35 = ___message1;
		String_t* L_36 = V_3;
		*((RuntimeObject **)(L_35)) = (RuntimeObject *)L_36;
		Il2CppCodeGenWriteBarrier((RuntimeObject **)(L_35), (RuntimeObject *)L_36);
		Exception_t * L_37 = V_0;
		Exception_t * L_38 = Exception_get_InnerException_m3836775(L_37, /*hidden argument*/NULL);
		if (!L_38)
		{
			goto IL_00fe;
		}
	}
	{
		String_t* L_39 = V_3;
		String_t* L_40 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_41 = String_Concat_m2163913788(NULL /*static, unused*/, _stringLiteral3264019870, L_39, _stringLiteral3452614566, L_40, /*hidden argument*/NULL);
		V_2 = L_41;
	}

IL_00fe:
	{
		Exception_t * L_42 = V_0;
		Exception_t * L_43 = Exception_get_InnerException_m3836775(L_42, /*hidden argument*/NULL);
		V_0 = L_43;
	}

IL_0106:
	{
		Exception_t * L_44 = V_0;
		if (L_44)
		{
			goto IL_0064;
		}
	}
	{
		StringBuilder_t * L_45 = V_1;
		String_t* L_46 = V_2;
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_47 = String_Concat_m3937257545(NULL /*static, unused*/, L_46, _stringLiteral3452614566, /*hidden argument*/NULL);
		StringBuilder_Append_m1965104174(L_45, L_47, /*hidden argument*/NULL);
		StackTrace_t1598645457 * L_48 = (StackTrace_t1598645457 *)il2cpp_codegen_object_new(StackTrace_t1598645457_il2cpp_TypeInfo_var);
		StackTrace__ctor_m1685176557(L_48, 1, (bool)1, /*hidden argument*/NULL);
		V_5 = L_48;
		StringBuilder_t * L_49 = V_1;
		StackTrace_t1598645457 * L_50 = V_5;
		IL2CPP_RUNTIME_CLASS_INIT(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var);
		String_t* L_51 = StackTraceUtility_ExtractFormattedStackTrace_m1281750362(NULL /*static, unused*/, L_50, /*hidden argument*/NULL);
		StringBuilder_Append_m1965104174(L_49, L_51, /*hidden argument*/NULL);
		String_t** L_52 = ___stackTrace2;
		StringBuilder_t * L_53 = V_1;
		String_t* L_54 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_53);
		*((RuntimeObject **)(L_52)) = (RuntimeObject *)L_54;
		Il2CppCodeGenWriteBarrier((RuntimeObject **)(L_52), (RuntimeObject *)L_54);
		return;
	}
}
// System.String UnityEngine.StackTraceUtility::PostprocessStacktrace(System.String,System.Boolean)
extern "C"  String_t* StackTraceUtility_PostprocessStacktrace_m1043256299 (RuntimeObject * __this /* static, unused */, String_t* ___oldString0, bool ___stripEngineInternalInformation1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StackTraceUtility_PostprocessStacktrace_m1043256299_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	StringU5BU5D_t1281789340* V_1 = NULL;
	StringBuilder_t * V_2 = NULL;
	int32_t V_3 = 0;
	int32_t V_4 = 0;
	String_t* V_5 = NULL;
	int32_t V_6 = 0;
	int32_t V_7 = 0;
	int32_t V_8 = 0;
	int32_t V_9 = 0;
	{
		String_t* L_0 = ___oldString0;
		if (L_0)
		{
			goto IL_0012;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_1 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_2();
		V_0 = L_1;
		goto IL_02b3;
	}

IL_0012:
	{
		String_t* L_2 = ___oldString0;
		CharU5BU5D_t3528271667* L_3 = ((CharU5BU5D_t3528271667*)SZArrayNew(CharU5BU5D_t3528271667_il2cpp_TypeInfo_var, (uint32_t)1));
		(L_3)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(0), (Il2CppChar)((int32_t)10));
		StringU5BU5D_t1281789340* L_4 = String_Split_m3646115398(L_2, L_3, /*hidden argument*/NULL);
		V_1 = L_4;
		String_t* L_5 = ___oldString0;
		int32_t L_6 = String_get_Length_m3847582255(L_5, /*hidden argument*/NULL);
		StringBuilder_t * L_7 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m2367297767(L_7, L_6, /*hidden argument*/NULL);
		V_2 = L_7;
		V_3 = 0;
		goto IL_0046;
	}

IL_0037:
	{
		StringU5BU5D_t1281789340* L_8 = V_1;
		int32_t L_9 = V_3;
		StringU5BU5D_t1281789340* L_10 = V_1;
		int32_t L_11 = V_3;
		int32_t L_12 = L_11;
		String_t* L_13 = (L_10)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(L_12));
		String_t* L_14 = String_Trim_m923598732(L_13, /*hidden argument*/NULL);
		ArrayElementTypeCheck (L_8, L_14);
		(L_8)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(L_9), (String_t*)L_14);
		int32_t L_15 = V_3;
		V_3 = ((int32_t)il2cpp_codegen_add((int32_t)L_15, (int32_t)1));
	}

IL_0046:
	{
		int32_t L_16 = V_3;
		StringU5BU5D_t1281789340* L_17 = V_1;
		if ((((int32_t)L_16) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_17)->max_length)))))))
		{
			goto IL_0037;
		}
	}
	{
		V_4 = 0;
		goto IL_029d;
	}

IL_0057:
	{
		StringU5BU5D_t1281789340* L_18 = V_1;
		int32_t L_19 = V_4;
		int32_t L_20 = L_19;
		String_t* L_21 = (L_18)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(L_20));
		V_5 = L_21;
		String_t* L_22 = V_5;
		int32_t L_23 = String_get_Length_m3847582255(L_22, /*hidden argument*/NULL);
		if (!L_23)
		{
			goto IL_0079;
		}
	}
	{
		String_t* L_24 = V_5;
		Il2CppChar L_25 = String_get_Chars_m2986988803(L_24, 0, /*hidden argument*/NULL);
		if ((!(((uint32_t)L_25) == ((uint32_t)((int32_t)10)))))
		{
			goto IL_007e;
		}
	}

IL_0079:
	{
		goto IL_0297;
	}

IL_007e:
	{
		String_t* L_26 = V_5;
		bool L_27 = String_StartsWith_m1759067526(L_26, _stringLiteral1147544838, /*hidden argument*/NULL);
		if (!L_27)
		{
			goto IL_0094;
		}
	}
	{
		goto IL_0297;
	}

IL_0094:
	{
		bool L_28 = ___stripEngineInternalInformation1;
		if (!L_28)
		{
			goto IL_00b0;
		}
	}
	{
		String_t* L_29 = V_5;
		bool L_30 = String_StartsWith_m1759067526(L_29, _stringLiteral1974486273, /*hidden argument*/NULL);
		if (!L_30)
		{
			goto IL_00b0;
		}
	}
	{
		goto IL_02a7;
	}

IL_00b0:
	{
		bool L_31 = ___stripEngineInternalInformation1;
		if (!L_31)
		{
			goto IL_0107;
		}
	}
	{
		int32_t L_32 = V_4;
		StringU5BU5D_t1281789340* L_33 = V_1;
		if ((((int32_t)L_32) >= ((int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_33)->max_length)))), (int32_t)1)))))
		{
			goto IL_0107;
		}
	}
	{
		String_t* L_34 = V_5;
		IL2CPP_RUNTIME_CLASS_INIT(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var);
		bool L_35 = StackTraceUtility_IsSystemStacktraceType_m299828041(NULL /*static, unused*/, L_34, /*hidden argument*/NULL);
		if (!L_35)
		{
			goto IL_0107;
		}
	}
	{
		StringU5BU5D_t1281789340* L_36 = V_1;
		int32_t L_37 = V_4;
		int32_t L_38 = ((int32_t)il2cpp_codegen_add((int32_t)L_37, (int32_t)1));
		String_t* L_39 = (L_36)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(L_38));
		IL2CPP_RUNTIME_CLASS_INIT(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var);
		bool L_40 = StackTraceUtility_IsSystemStacktraceType_m299828041(NULL /*static, unused*/, L_39, /*hidden argument*/NULL);
		if (!L_40)
		{
			goto IL_00e4;
		}
	}
	{
		goto IL_0297;
	}

IL_00e4:
	{
		String_t* L_41 = V_5;
		int32_t L_42 = String_IndexOf_m1977622757(L_41, _stringLiteral3487100581, /*hidden argument*/NULL);
		V_6 = L_42;
		int32_t L_43 = V_6;
		if ((((int32_t)L_43) == ((int32_t)(-1))))
		{
			goto IL_0106;
		}
	}
	{
		String_t* L_44 = V_5;
		int32_t L_45 = V_6;
		String_t* L_46 = String_Substring_m1610150815(L_44, 0, L_45, /*hidden argument*/NULL);
		V_5 = L_46;
	}

IL_0106:
	{
	}

IL_0107:
	{
		String_t* L_47 = V_5;
		int32_t L_48 = String_IndexOf_m1977622757(L_47, _stringLiteral4144164017, /*hidden argument*/NULL);
		if ((((int32_t)L_48) == ((int32_t)(-1))))
		{
			goto IL_011e;
		}
	}
	{
		goto IL_0297;
	}

IL_011e:
	{
		String_t* L_49 = V_5;
		int32_t L_50 = String_IndexOf_m1977622757(L_49, _stringLiteral3629554952, /*hidden argument*/NULL);
		if ((((int32_t)L_50) == ((int32_t)(-1))))
		{
			goto IL_0135;
		}
	}
	{
		goto IL_0297;
	}

IL_0135:
	{
		String_t* L_51 = V_5;
		int32_t L_52 = String_IndexOf_m1977622757(L_51, _stringLiteral461147025, /*hidden argument*/NULL);
		if ((((int32_t)L_52) == ((int32_t)(-1))))
		{
			goto IL_014c;
		}
	}
	{
		goto IL_0297;
	}

IL_014c:
	{
		bool L_53 = ___stripEngineInternalInformation1;
		if (!L_53)
		{
			goto IL_0179;
		}
	}
	{
		String_t* L_54 = V_5;
		bool L_55 = String_StartsWith_m1759067526(L_54, _stringLiteral3452614645, /*hidden argument*/NULL);
		if (!L_55)
		{
			goto IL_0179;
		}
	}
	{
		String_t* L_56 = V_5;
		bool L_57 = String_EndsWith_m1901926500(L_56, _stringLiteral3452614643, /*hidden argument*/NULL);
		if (!L_57)
		{
			goto IL_0179;
		}
	}
	{
		goto IL_0297;
	}

IL_0179:
	{
		String_t* L_58 = V_5;
		bool L_59 = String_StartsWith_m1759067526(L_58, _stringLiteral3791036681, /*hidden argument*/NULL);
		if (!L_59)
		{
			goto IL_0197;
		}
	}
	{
		String_t* L_60 = V_5;
		String_t* L_61 = String_Remove_m562998446(L_60, 0, 3, /*hidden argument*/NULL);
		V_5 = L_61;
	}

IL_0197:
	{
		String_t* L_62 = V_5;
		int32_t L_63 = String_IndexOf_m1977622757(L_62, _stringLiteral4163537911, /*hidden argument*/NULL);
		V_7 = L_63;
		V_8 = (-1);
		int32_t L_64 = V_7;
		if ((((int32_t)L_64) == ((int32_t)(-1))))
		{
			goto IL_01c0;
		}
	}
	{
		String_t* L_65 = V_5;
		int32_t L_66 = V_7;
		int32_t L_67 = String_IndexOf_m3406607758(L_65, _stringLiteral3452614643, L_66, /*hidden argument*/NULL);
		V_8 = L_67;
	}

IL_01c0:
	{
		int32_t L_68 = V_7;
		if ((((int32_t)L_68) == ((int32_t)(-1))))
		{
			goto IL_01e5;
		}
	}
	{
		int32_t L_69 = V_8;
		int32_t L_70 = V_7;
		if ((((int32_t)L_69) <= ((int32_t)L_70)))
		{
			goto IL_01e5;
		}
	}
	{
		String_t* L_71 = V_5;
		int32_t L_72 = V_7;
		int32_t L_73 = V_8;
		int32_t L_74 = V_7;
		String_t* L_75 = String_Remove_m562998446(L_71, L_72, ((int32_t)il2cpp_codegen_add((int32_t)((int32_t)il2cpp_codegen_subtract((int32_t)L_73, (int32_t)L_74)), (int32_t)1)), /*hidden argument*/NULL);
		V_5 = L_75;
	}

IL_01e5:
	{
		String_t* L_76 = V_5;
		String_t* L_77 = String_Replace_m1273907647(L_76, _stringLiteral1311358384, _stringLiteral757602046, /*hidden argument*/NULL);
		V_5 = L_77;
		String_t* L_78 = V_5;
		String_t* L_79 = String_Replace_m1273907647(L_78, _stringLiteral3452614644, _stringLiteral3452614529, /*hidden argument*/NULL);
		V_5 = L_79;
		IL2CPP_RUNTIME_CLASS_INIT(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var);
		String_t* L_80 = ((StackTraceUtility_t3465565809_StaticFields*)il2cpp_codegen_static_fields_for(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var))->get_projectFolder_0();
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_81 = String_IsNullOrEmpty_m2969720369(NULL /*static, unused*/, L_80, /*hidden argument*/NULL);
		if (L_81)
		{
			goto IL_022d;
		}
	}
	{
		String_t* L_82 = V_5;
		IL2CPP_RUNTIME_CLASS_INIT(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var);
		String_t* L_83 = ((StackTraceUtility_t3465565809_StaticFields*)il2cpp_codegen_static_fields_for(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var))->get_projectFolder_0();
		String_t* L_84 = String_Replace_m1273907647(L_82, L_83, _stringLiteral757602046, /*hidden argument*/NULL);
		V_5 = L_84;
	}

IL_022d:
	{
		String_t* L_85 = V_5;
		String_t* L_86 = String_Replace_m3726209165(L_85, ((int32_t)92), ((int32_t)47), /*hidden argument*/NULL);
		V_5 = L_86;
		String_t* L_87 = V_5;
		int32_t L_88 = String_LastIndexOf_m2676535141(L_87, _stringLiteral4187617987, /*hidden argument*/NULL);
		V_9 = L_88;
		int32_t L_89 = V_9;
		if ((((int32_t)L_89) == ((int32_t)(-1))))
		{
			goto IL_0283;
		}
	}
	{
		String_t* L_90 = V_5;
		int32_t L_91 = V_9;
		String_t* L_92 = String_Remove_m562998446(L_90, L_91, 5, /*hidden argument*/NULL);
		V_5 = L_92;
		String_t* L_93 = V_5;
		int32_t L_94 = V_9;
		String_t* L_95 = String_Insert_m3534971326(L_93, L_94, _stringLiteral2177867675, /*hidden argument*/NULL);
		V_5 = L_95;
		String_t* L_96 = V_5;
		String_t* L_97 = V_5;
		int32_t L_98 = String_get_Length_m3847582255(L_97, /*hidden argument*/NULL);
		String_t* L_99 = String_Insert_m3534971326(L_96, L_98, _stringLiteral3452614535, /*hidden argument*/NULL);
		V_5 = L_99;
	}

IL_0283:
	{
		StringBuilder_t * L_100 = V_2;
		String_t* L_101 = V_5;
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_102 = String_Concat_m3937257545(NULL /*static, unused*/, L_101, _stringLiteral3452614566, /*hidden argument*/NULL);
		StringBuilder_Append_m1965104174(L_100, L_102, /*hidden argument*/NULL);
	}

IL_0297:
	{
		int32_t L_103 = V_4;
		V_4 = ((int32_t)il2cpp_codegen_add((int32_t)L_103, (int32_t)1));
	}

IL_029d:
	{
		int32_t L_104 = V_4;
		StringU5BU5D_t1281789340* L_105 = V_1;
		if ((((int32_t)L_104) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_105)->max_length)))))))
		{
			goto IL_0057;
		}
	}

IL_02a7:
	{
		StringBuilder_t * L_106 = V_2;
		String_t* L_107 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_106);
		V_0 = L_107;
		goto IL_02b3;
	}

IL_02b3:
	{
		String_t* L_108 = V_0;
		return L_108;
	}
}
// System.String UnityEngine.StackTraceUtility::ExtractFormattedStackTrace(System.Diagnostics.StackTrace)
extern "C"  String_t* StackTraceUtility_ExtractFormattedStackTrace_m1281750362 (RuntimeObject * __this /* static, unused */, StackTrace_t1598645457 * ___stackTrace0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StackTraceUtility_ExtractFormattedStackTrace_m1281750362_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	StringBuilder_t * V_0 = NULL;
	int32_t V_1 = 0;
	StackFrame_t3217253059 * V_2 = NULL;
	MethodBase_t * V_3 = NULL;
	Type_t * V_4 = NULL;
	String_t* V_5 = NULL;
	int32_t V_6 = 0;
	ParameterInfoU5BU5D_t390618515* V_7 = NULL;
	bool V_8 = false;
	String_t* V_9 = NULL;
	bool V_10 = false;
	int32_t V_11 = 0;
	String_t* V_12 = NULL;
	int32_t G_B27_0 = 0;
	int32_t G_B29_0 = 0;
	{
		StringBuilder_t * L_0 = (StringBuilder_t *)il2cpp_codegen_object_new(StringBuilder_t_il2cpp_TypeInfo_var);
		StringBuilder__ctor_m2367297767(L_0, ((int32_t)255), /*hidden argument*/NULL);
		V_0 = L_0;
		V_1 = 0;
		goto IL_02cb;
	}

IL_0013:
	{
		StackTrace_t1598645457 * L_1 = ___stackTrace0;
		int32_t L_2 = V_1;
		StackFrame_t3217253059 * L_3 = VirtFuncInvoker1< StackFrame_t3217253059 *, int32_t >::Invoke(5 /* System.Diagnostics.StackFrame System.Diagnostics.StackTrace::GetFrame(System.Int32) */, L_1, L_2);
		V_2 = L_3;
		StackFrame_t3217253059 * L_4 = V_2;
		MethodBase_t * L_5 = VirtFuncInvoker0< MethodBase_t * >::Invoke(7 /* System.Reflection.MethodBase System.Diagnostics.StackFrame::GetMethod() */, L_4);
		V_3 = L_5;
		MethodBase_t * L_6 = V_3;
		if (L_6)
		{
			goto IL_002e;
		}
	}
	{
		goto IL_02c7;
	}

IL_002e:
	{
		MethodBase_t * L_7 = V_3;
		Type_t * L_8 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Reflection.MemberInfo::get_DeclaringType() */, L_7);
		V_4 = L_8;
		Type_t * L_9 = V_4;
		if (L_9)
		{
			goto IL_0042;
		}
	}
	{
		goto IL_02c7;
	}

IL_0042:
	{
		Type_t * L_10 = V_4;
		String_t* L_11 = VirtFuncInvoker0< String_t* >::Invoke(34 /* System.String System.Type::get_Namespace() */, L_10);
		V_5 = L_11;
		String_t* L_12 = V_5;
		if (!L_12)
		{
			goto IL_0075;
		}
	}
	{
		String_t* L_13 = V_5;
		int32_t L_14 = String_get_Length_m3847582255(L_13, /*hidden argument*/NULL);
		if (!L_14)
		{
			goto IL_0075;
		}
	}
	{
		StringBuilder_t * L_15 = V_0;
		String_t* L_16 = V_5;
		StringBuilder_Append_m1965104174(L_15, L_16, /*hidden argument*/NULL);
		StringBuilder_t * L_17 = V_0;
		StringBuilder_Append_m1965104174(L_17, _stringLiteral3452614530, /*hidden argument*/NULL);
	}

IL_0075:
	{
		StringBuilder_t * L_18 = V_0;
		Type_t * L_19 = V_4;
		String_t* L_20 = VirtFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_19);
		StringBuilder_Append_m1965104174(L_18, L_20, /*hidden argument*/NULL);
		StringBuilder_t * L_21 = V_0;
		StringBuilder_Append_m1965104174(L_21, _stringLiteral3452614550, /*hidden argument*/NULL);
		StringBuilder_t * L_22 = V_0;
		MethodBase_t * L_23 = V_3;
		String_t* L_24 = VirtFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_23);
		StringBuilder_Append_m1965104174(L_22, L_24, /*hidden argument*/NULL);
		StringBuilder_t * L_25 = V_0;
		StringBuilder_Append_m1965104174(L_25, _stringLiteral3452614536, /*hidden argument*/NULL);
		V_6 = 0;
		MethodBase_t * L_26 = V_3;
		ParameterInfoU5BU5D_t390618515* L_27 = VirtFuncInvoker0< ParameterInfoU5BU5D_t390618515* >::Invoke(14 /* System.Reflection.ParameterInfo[] System.Reflection.MethodBase::GetParameters() */, L_26);
		V_7 = L_27;
		V_8 = (bool)1;
		goto IL_00f4;
	}

IL_00bb:
	{
		bool L_28 = V_8;
		if (L_28)
		{
			goto IL_00d4;
		}
	}
	{
		StringBuilder_t * L_29 = V_0;
		StringBuilder_Append_m1965104174(L_29, _stringLiteral3450517380, /*hidden argument*/NULL);
		goto IL_00d7;
	}

IL_00d4:
	{
		V_8 = (bool)0;
	}

IL_00d7:
	{
		StringBuilder_t * L_30 = V_0;
		ParameterInfoU5BU5D_t390618515* L_31 = V_7;
		int32_t L_32 = V_6;
		int32_t L_33 = L_32;
		ParameterInfo_t1861056598 * L_34 = (L_31)->GetAtUnchecked(static_cast<il2cpp_array_size_t>(L_33));
		Type_t * L_35 = VirtFuncInvoker0< Type_t * >::Invoke(6 /* System.Type System.Reflection.ParameterInfo::get_ParameterType() */, L_34);
		String_t* L_36 = VirtFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_35);
		StringBuilder_Append_m1965104174(L_30, L_36, /*hidden argument*/NULL);
		int32_t L_37 = V_6;
		V_6 = ((int32_t)il2cpp_codegen_add((int32_t)L_37, (int32_t)1));
	}

IL_00f4:
	{
		int32_t L_38 = V_6;
		ParameterInfoU5BU5D_t390618515* L_39 = V_7;
		if ((((int32_t)L_38) < ((int32_t)(((int32_t)((int32_t)(((RuntimeArray *)L_39)->max_length)))))))
		{
			goto IL_00bb;
		}
	}
	{
		StringBuilder_t * L_40 = V_0;
		StringBuilder_Append_m1965104174(L_40, _stringLiteral3452614535, /*hidden argument*/NULL);
		StackFrame_t3217253059 * L_41 = V_2;
		String_t* L_42 = VirtFuncInvoker0< String_t* >::Invoke(5 /* System.String System.Diagnostics.StackFrame::GetFileName() */, L_41);
		V_9 = L_42;
		String_t* L_43 = V_9;
		if (!L_43)
		{
			goto IL_02ba;
		}
	}
	{
		Type_t * L_44 = V_4;
		String_t* L_45 = VirtFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_44);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_46 = String_op_Equality_m920492651(NULL /*static, unused*/, L_45, _stringLiteral2678398999, /*hidden argument*/NULL);
		if (!L_46)
		{
			goto IL_0147;
		}
	}
	{
		Type_t * L_47 = V_4;
		String_t* L_48 = VirtFuncInvoker0< String_t* >::Invoke(34 /* System.String System.Type::get_Namespace() */, L_47);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_49 = String_op_Equality_m920492651(NULL /*static, unused*/, L_48, _stringLiteral1552523976, /*hidden argument*/NULL);
		if (L_49)
		{
			goto IL_020c;
		}
	}

IL_0147:
	{
		Type_t * L_50 = V_4;
		String_t* L_51 = VirtFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_50);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_52 = String_op_Equality_m920492651(NULL /*static, unused*/, L_51, _stringLiteral6580196, /*hidden argument*/NULL);
		if (!L_52)
		{
			goto IL_0173;
		}
	}
	{
		Type_t * L_53 = V_4;
		String_t* L_54 = VirtFuncInvoker0< String_t* >::Invoke(34 /* System.String System.Type::get_Namespace() */, L_53);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_55 = String_op_Equality_m920492651(NULL /*static, unused*/, L_54, _stringLiteral1552523976, /*hidden argument*/NULL);
		if (L_55)
		{
			goto IL_020c;
		}
	}

IL_0173:
	{
		Type_t * L_56 = V_4;
		String_t* L_57 = VirtFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_56);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_58 = String_op_Equality_m920492651(NULL /*static, unused*/, L_57, _stringLiteral3402824819, /*hidden argument*/NULL);
		if (!L_58)
		{
			goto IL_019f;
		}
	}
	{
		Type_t * L_59 = V_4;
		String_t* L_60 = VirtFuncInvoker0< String_t* >::Invoke(34 /* System.String System.Type::get_Namespace() */, L_59);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_61 = String_op_Equality_m920492651(NULL /*static, unused*/, L_60, _stringLiteral1552523976, /*hidden argument*/NULL);
		if (L_61)
		{
			goto IL_020c;
		}
	}

IL_019f:
	{
		Type_t * L_62 = V_4;
		String_t* L_63 = VirtFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_62);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_64 = String_op_Equality_m920492651(NULL /*static, unused*/, L_63, _stringLiteral1670073234, /*hidden argument*/NULL);
		if (!L_64)
		{
			goto IL_01cb;
		}
	}
	{
		Type_t * L_65 = V_4;
		String_t* L_66 = VirtFuncInvoker0< String_t* >::Invoke(34 /* System.String System.Type::get_Namespace() */, L_65);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_67 = String_op_Equality_m920492651(NULL /*static, unused*/, L_66, _stringLiteral1200226066, /*hidden argument*/NULL);
		if (L_67)
		{
			goto IL_020c;
		}
	}

IL_01cb:
	{
		MethodBase_t * L_68 = V_3;
		String_t* L_69 = VirtFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_68);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_70 = String_op_Equality_m920492651(NULL /*static, unused*/, L_69, _stringLiteral61343007, /*hidden argument*/NULL);
		if (!L_70)
		{
			goto IL_0209;
		}
	}
	{
		Type_t * L_71 = V_4;
		String_t* L_72 = VirtFuncInvoker0< String_t* >::Invoke(8 /* System.String System.Reflection.MemberInfo::get_Name() */, L_71);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_73 = String_op_Equality_m920492651(NULL /*static, unused*/, L_72, _stringLiteral681811338, /*hidden argument*/NULL);
		if (!L_73)
		{
			goto IL_0209;
		}
	}
	{
		Type_t * L_74 = V_4;
		String_t* L_75 = VirtFuncInvoker0< String_t* >::Invoke(34 /* System.String System.Type::get_Namespace() */, L_74);
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_76 = String_op_Equality_m920492651(NULL /*static, unused*/, L_75, _stringLiteral1552523976, /*hidden argument*/NULL);
		G_B27_0 = ((int32_t)(L_76));
		goto IL_020a;
	}

IL_0209:
	{
		G_B27_0 = 0;
	}

IL_020a:
	{
		G_B29_0 = G_B27_0;
		goto IL_020d;
	}

IL_020c:
	{
		G_B29_0 = 1;
	}

IL_020d:
	{
		V_10 = (bool)G_B29_0;
		bool L_77 = V_10;
		if (L_77)
		{
			goto IL_02b9;
		}
	}
	{
		StringBuilder_t * L_78 = V_0;
		StringBuilder_Append_m1965104174(L_78, _stringLiteral2177867675, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var);
		String_t* L_79 = ((StackTraceUtility_t3465565809_StaticFields*)il2cpp_codegen_static_fields_for(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var))->get_projectFolder_0();
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		bool L_80 = String_IsNullOrEmpty_m2969720369(NULL /*static, unused*/, L_79, /*hidden argument*/NULL);
		if (L_80)
		{
			goto IL_027b;
		}
	}
	{
		String_t* L_81 = V_9;
		String_t* L_82 = String_Replace_m1273907647(L_81, _stringLiteral3452614644, _stringLiteral3452614529, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var);
		String_t* L_83 = ((StackTraceUtility_t3465565809_StaticFields*)il2cpp_codegen_static_fields_for(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var))->get_projectFolder_0();
		bool L_84 = String_StartsWith_m1759067526(L_82, L_83, /*hidden argument*/NULL);
		if (!L_84)
		{
			goto IL_027a;
		}
	}
	{
		String_t* L_85 = V_9;
		IL2CPP_RUNTIME_CLASS_INIT(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var);
		String_t* L_86 = ((StackTraceUtility_t3465565809_StaticFields*)il2cpp_codegen_static_fields_for(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var))->get_projectFolder_0();
		int32_t L_87 = String_get_Length_m3847582255(L_86, /*hidden argument*/NULL);
		String_t* L_88 = V_9;
		int32_t L_89 = String_get_Length_m3847582255(L_88, /*hidden argument*/NULL);
		String_t* L_90 = ((StackTraceUtility_t3465565809_StaticFields*)il2cpp_codegen_static_fields_for(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var))->get_projectFolder_0();
		int32_t L_91 = String_get_Length_m3847582255(L_90, /*hidden argument*/NULL);
		String_t* L_92 = String_Substring_m1610150815(L_85, L_87, ((int32_t)il2cpp_codegen_subtract((int32_t)L_89, (int32_t)L_91)), /*hidden argument*/NULL);
		V_9 = L_92;
	}

IL_027a:
	{
	}

IL_027b:
	{
		StringBuilder_t * L_93 = V_0;
		String_t* L_94 = V_9;
		StringBuilder_Append_m1965104174(L_93, L_94, /*hidden argument*/NULL);
		StringBuilder_t * L_95 = V_0;
		StringBuilder_Append_m1965104174(L_95, _stringLiteral3452614550, /*hidden argument*/NULL);
		StringBuilder_t * L_96 = V_0;
		StackFrame_t3217253059 * L_97 = V_2;
		int32_t L_98 = VirtFuncInvoker0< int32_t >::Invoke(4 /* System.Int32 System.Diagnostics.StackFrame::GetFileLineNumber() */, L_97);
		V_11 = L_98;
		String_t* L_99 = Int32_ToString_m141394615((&V_11), /*hidden argument*/NULL);
		StringBuilder_Append_m1965104174(L_96, L_99, /*hidden argument*/NULL);
		StringBuilder_t * L_100 = V_0;
		StringBuilder_Append_m1965104174(L_100, _stringLiteral3452614535, /*hidden argument*/NULL);
	}

IL_02b9:
	{
	}

IL_02ba:
	{
		StringBuilder_t * L_101 = V_0;
		StringBuilder_Append_m1965104174(L_101, _stringLiteral3452614566, /*hidden argument*/NULL);
	}

IL_02c7:
	{
		int32_t L_102 = V_1;
		V_1 = ((int32_t)il2cpp_codegen_add((int32_t)L_102, (int32_t)1));
	}

IL_02cb:
	{
		int32_t L_103 = V_1;
		StackTrace_t1598645457 * L_104 = ___stackTrace0;
		int32_t L_105 = VirtFuncInvoker0< int32_t >::Invoke(4 /* System.Int32 System.Diagnostics.StackTrace::get_FrameCount() */, L_104);
		if ((((int32_t)L_103) < ((int32_t)L_105)))
		{
			goto IL_0013;
		}
	}
	{
		StringBuilder_t * L_106 = V_0;
		String_t* L_107 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_106);
		V_12 = L_107;
		goto IL_02e4;
	}

IL_02e4:
	{
		String_t* L_108 = V_12;
		return L_108;
	}
}
// System.Void UnityEngine.StackTraceUtility::.cctor()
extern "C"  void StackTraceUtility__cctor_m1981266436 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (StackTraceUtility__cctor_m1981266436_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		((StackTraceUtility_t3465565809_StaticFields*)il2cpp_codegen_static_fields_for(StackTraceUtility_t3465565809_il2cpp_TypeInfo_var))->set_projectFolder_0(_stringLiteral757602046);
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
// System.DateTime UnityEngine.SystemClock::get_now()
extern "C"  DateTime_t3738529785  SystemClock_get_now_m3370142516 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SystemClock_get_now_m3370142516_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	DateTime_t3738529785  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(DateTime_t3738529785_il2cpp_TypeInfo_var);
		DateTime_t3738529785  L_0 = DateTime_get_Now_m1277138875(NULL /*static, unused*/, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		DateTime_t3738529785  L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.SystemClock::.cctor()
extern "C"  void SystemClock__cctor_m1862440887 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SystemClock__cctor_m1862440887_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		DateTime_t3738529785  L_0;
		memset(&L_0, 0, sizeof(L_0));
		DateTime__ctor_m2956360140((&L_0), ((int32_t)1970), 1, 1, 0, 0, 0, 1, /*hidden argument*/NULL);
		((SystemClock_t1201361285_StaticFields*)il2cpp_codegen_static_fields_for(SystemClock_t1201361285_il2cpp_TypeInfo_var))->set_s_Epoch_0(L_0);
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
// UnityEngine.OperatingSystemFamily UnityEngine.SystemInfo::get_operatingSystemFamily()
extern "C"  int32_t SystemInfo_get_operatingSystemFamily_m4256884728 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	typedef int32_t (*SystemInfo_get_operatingSystemFamily_m4256884728_ftn) ();
	static SystemInfo_get_operatingSystemFamily_m4256884728_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (SystemInfo_get_operatingSystemFamily_m4256884728_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.SystemInfo::get_operatingSystemFamily()");
	int32_t retVal = _il2cpp_icall_func();
	return retVal;
}
// UnityEngine.DeviceType UnityEngine.SystemInfo::get_deviceType()
extern "C"  int32_t SystemInfo_get_deviceType_m3742504744 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	typedef int32_t (*SystemInfo_get_deviceType_m3742504744_ftn) ();
	static SystemInfo_get_deviceType_m3742504744_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (SystemInfo_get_deviceType_m3742504744_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.SystemInfo::get_deviceType()");
	int32_t retVal = _il2cpp_icall_func();
	return retVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.TextAreaAttribute::.ctor(System.Int32,System.Int32)
extern "C"  void TextAreaAttribute__ctor_m2173231689 (TextAreaAttribute_t3326046611 * __this, int32_t ___minLines0, int32_t ___maxLines1, const RuntimeMethod* method)
{
	{
		PropertyAttribute__ctor_m1017741868(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___minLines0;
		__this->set_minLines_0(L_0);
		int32_t L_1 = ___maxLines1;
		__this->set_maxLines_1(L_1);
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
// System.String UnityEngine.TextAsset::get_text()
extern "C"  String_t* TextAsset_get_text_m2027878391 (TextAsset_t3022178571 * __this, const RuntimeMethod* method)
{
	typedef String_t* (*TextAsset_get_text_m2027878391_ftn) (TextAsset_t3022178571 *);
	static TextAsset_get_text_m2027878391_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (TextAsset_get_text_m2027878391_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.TextAsset::get_text()");
	String_t* retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.String UnityEngine.TextAsset::ToString()
extern "C"  String_t* TextAsset_ToString_m2170047097 (TextAsset_t3022178571 * __this, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	{
		String_t* L_0 = TextAsset_get_text_m2027878391(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		String_t* L_1 = V_0;
		return L_1;
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
// System.Void UnityEngine.Texture::.ctor()
extern "C"  void Texture__ctor_m3554519797 (Texture_t3661962703 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Texture__ctor_m3554519797_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Object_t631007953_il2cpp_TypeInfo_var);
		Object__ctor_m1087895580(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Int32 UnityEngine.Texture::Internal_GetWidth(UnityEngine.Texture)
extern "C"  int32_t Texture_Internal_GetWidth_m629815273 (RuntimeObject * __this /* static, unused */, Texture_t3661962703 * ___t0, const RuntimeMethod* method)
{
	typedef int32_t (*Texture_Internal_GetWidth_m629815273_ftn) (Texture_t3661962703 *);
	static Texture_Internal_GetWidth_m629815273_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Texture_Internal_GetWidth_m629815273_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Texture::Internal_GetWidth(UnityEngine.Texture)");
	int32_t retVal = _il2cpp_icall_func(___t0);
	return retVal;
}
// System.Int32 UnityEngine.Texture::Internal_GetHeight(UnityEngine.Texture)
extern "C"  int32_t Texture_Internal_GetHeight_m2885553040 (RuntimeObject * __this /* static, unused */, Texture_t3661962703 * ___t0, const RuntimeMethod* method)
{
	typedef int32_t (*Texture_Internal_GetHeight_m2885553040_ftn) (Texture_t3661962703 *);
	static Texture_Internal_GetHeight_m2885553040_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Texture_Internal_GetHeight_m2885553040_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Texture::Internal_GetHeight(UnityEngine.Texture)");
	int32_t retVal = _il2cpp_icall_func(___t0);
	return retVal;
}
// System.Int32 UnityEngine.Texture::get_width()
extern "C"  int32_t Texture_get_width_m888163864 (Texture_t3661962703 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = Texture_Internal_GetWidth_m629815273(NULL /*static, unused*/, __this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
// System.Int32 UnityEngine.Texture::get_height()
extern "C"  int32_t Texture_get_height_m3786488511 (Texture_t3661962703 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = Texture_Internal_GetHeight_m2885553040(NULL /*static, unused*/, __this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.TextureWrapMode UnityEngine.Texture::get_wrapMode()
extern "C"  int32_t Texture_get_wrapMode_m2187367613 (Texture_t3661962703 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*Texture_get_wrapMode_m2187367613_ftn) (Texture_t3661962703 *);
	static Texture_get_wrapMode_m2187367613_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Texture_get_wrapMode_m2187367613_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Texture::get_wrapMode()");
	int32_t retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// UnityEngine.Vector2 UnityEngine.Texture::get_texelSize()
extern "C"  Vector2_t2156229523  Texture_get_texelSize_m2409716740 (Texture_t3661962703 * __this, const RuntimeMethod* method)
{
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector2_t2156229523  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Texture_INTERNAL_get_texelSize_m393369999(__this, (&V_0), /*hidden argument*/NULL);
		Vector2_t2156229523  L_0 = V_0;
		V_1 = L_0;
		goto IL_0010;
	}

IL_0010:
	{
		Vector2_t2156229523  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Texture::INTERNAL_get_texelSize(UnityEngine.Vector2&)
extern "C"  void Texture_INTERNAL_get_texelSize_m393369999 (Texture_t3661962703 * __this, Vector2_t2156229523 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Texture_INTERNAL_get_texelSize_m393369999_ftn) (Texture_t3661962703 *, Vector2_t2156229523 *);
	static Texture_INTERNAL_get_texelSize_m393369999_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Texture_INTERNAL_get_texelSize_m393369999_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Texture::INTERNAL_get_texelSize(UnityEngine.Vector2&)");
	_il2cpp_icall_func(__this, ___value0);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Texture2D::.ctor(System.Int32,System.Int32)
extern "C"  void Texture2D__ctor_m373113269 (Texture2D_t3840446185 * __this, int32_t ___width0, int32_t ___height1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Texture2D__ctor_m373113269_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Texture__ctor_m3554519797(__this, /*hidden argument*/NULL);
		int32_t L_0 = ___width0;
		int32_t L_1 = ___height1;
		Texture2D_Internal_Create_m807587593(NULL /*static, unused*/, __this, L_0, L_1, 4, (bool)1, (bool)0, (intptr_t)(0), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Texture2D::Internal_Create(UnityEngine.Texture2D,System.Int32,System.Int32,UnityEngine.TextureFormat,System.Boolean,System.Boolean,System.IntPtr)
extern "C"  void Texture2D_Internal_Create_m807587593 (RuntimeObject * __this /* static, unused */, Texture2D_t3840446185 * ___mono0, int32_t ___width1, int32_t ___height2, int32_t ___format3, bool ___mipmap4, bool ___linear5, intptr_t ___nativeTex6, const RuntimeMethod* method)
{
	typedef void (*Texture2D_Internal_Create_m807587593_ftn) (Texture2D_t3840446185 *, int32_t, int32_t, int32_t, bool, bool, intptr_t);
	static Texture2D_Internal_Create_m807587593_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Texture2D_Internal_Create_m807587593_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Texture2D::Internal_Create(UnityEngine.Texture2D,System.Int32,System.Int32,UnityEngine.TextureFormat,System.Boolean,System.Boolean,System.IntPtr)");
	_il2cpp_icall_func(___mono0, ___width1, ___height2, ___format3, ___mipmap4, ___linear5, ___nativeTex6);
}
// UnityEngine.Texture2D UnityEngine.Texture2D::get_whiteTexture()
extern "C"  Texture2D_t3840446185 * Texture2D_get_whiteTexture_m2176011403 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	typedef Texture2D_t3840446185 * (*Texture2D_get_whiteTexture_m2176011403_ftn) ();
	static Texture2D_get_whiteTexture_m2176011403_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Texture2D_get_whiteTexture_m2176011403_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Texture2D::get_whiteTexture()");
	Texture2D_t3840446185 * retVal = _il2cpp_icall_func();
	return retVal;
}
// System.Void UnityEngine.Texture2D::SetPixel(System.Int32,System.Int32,UnityEngine.Color)
extern "C"  void Texture2D_SetPixel_m2984741184 (Texture2D_t3840446185 * __this, int32_t ___x0, int32_t ___y1, Color_t2555686324  ___color2, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___x0;
		int32_t L_1 = ___y1;
		Texture2D_INTERNAL_CALL_SetPixel_m4151298262(NULL /*static, unused*/, __this, L_0, L_1, (&___color2), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Texture2D::INTERNAL_CALL_SetPixel(UnityEngine.Texture2D,System.Int32,System.Int32,UnityEngine.Color&)
extern "C"  void Texture2D_INTERNAL_CALL_SetPixel_m4151298262 (RuntimeObject * __this /* static, unused */, Texture2D_t3840446185 * ___self0, int32_t ___x1, int32_t ___y2, Color_t2555686324 * ___color3, const RuntimeMethod* method)
{
	typedef void (*Texture2D_INTERNAL_CALL_SetPixel_m4151298262_ftn) (Texture2D_t3840446185 *, int32_t, int32_t, Color_t2555686324 *);
	static Texture2D_INTERNAL_CALL_SetPixel_m4151298262_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Texture2D_INTERNAL_CALL_SetPixel_m4151298262_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Texture2D::INTERNAL_CALL_SetPixel(UnityEngine.Texture2D,System.Int32,System.Int32,UnityEngine.Color&)");
	_il2cpp_icall_func(___self0, ___x1, ___y2, ___color3);
}
// UnityEngine.Color UnityEngine.Texture2D::GetPixelBilinear(System.Single,System.Single)
extern "C"  Color_t2555686324  Texture2D_GetPixelBilinear_m1950540195 (Texture2D_t3840446185 * __this, float ___u0, float ___v1, const RuntimeMethod* method)
{
	Color_t2555686324  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Color_t2555686324  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		float L_0 = ___u0;
		float L_1 = ___v1;
		Texture2D_INTERNAL_CALL_GetPixelBilinear_m2045611222(NULL /*static, unused*/, __this, L_0, L_1, (&V_0), /*hidden argument*/NULL);
		Color_t2555686324  L_2 = V_0;
		V_1 = L_2;
		goto IL_0012;
	}

IL_0012:
	{
		Color_t2555686324  L_3 = V_1;
		return L_3;
	}
}
// System.Void UnityEngine.Texture2D::INTERNAL_CALL_GetPixelBilinear(UnityEngine.Texture2D,System.Single,System.Single,UnityEngine.Color&)
extern "C"  void Texture2D_INTERNAL_CALL_GetPixelBilinear_m2045611222 (RuntimeObject * __this /* static, unused */, Texture2D_t3840446185 * ___self0, float ___u1, float ___v2, Color_t2555686324 * ___value3, const RuntimeMethod* method)
{
	typedef void (*Texture2D_INTERNAL_CALL_GetPixelBilinear_m2045611222_ftn) (Texture2D_t3840446185 *, float, float, Color_t2555686324 *);
	static Texture2D_INTERNAL_CALL_GetPixelBilinear_m2045611222_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Texture2D_INTERNAL_CALL_GetPixelBilinear_m2045611222_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Texture2D::INTERNAL_CALL_GetPixelBilinear(UnityEngine.Texture2D,System.Single,System.Single,UnityEngine.Color&)");
	_il2cpp_icall_func(___self0, ___u1, ___v2, ___value3);
}
// System.Void UnityEngine.Texture2D::Apply(System.Boolean,System.Boolean)
extern "C"  void Texture2D_Apply_m2470606565 (Texture2D_t3840446185 * __this, bool ___updateMipmaps0, bool ___makeNoLongerReadable1, const RuntimeMethod* method)
{
	typedef void (*Texture2D_Apply_m2470606565_ftn) (Texture2D_t3840446185 *, bool, bool);
	static Texture2D_Apply_m2470606565_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Texture2D_Apply_m2470606565_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Texture2D::Apply(System.Boolean,System.Boolean)");
	_il2cpp_icall_func(__this, ___updateMipmaps0, ___makeNoLongerReadable1);
}
// System.Void UnityEngine.Texture2D::Apply()
extern "C"  void Texture2D_Apply_m2271746283 (Texture2D_t3840446185 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	bool V_1 = false;
	{
		V_0 = (bool)0;
		V_1 = (bool)1;
		bool L_0 = V_1;
		bool L_1 = V_0;
		Texture2D_Apply_m2470606565(__this, L_0, L_1, /*hidden argument*/NULL);
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Single UnityEngine.Time::get_time()
extern "C"  float Time_get_time_m2907476221 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	typedef float (*Time_get_time_m2907476221_ftn) ();
	static Time_get_time_m2907476221_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Time_get_time_m2907476221_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Time::get_time()");
	float retVal = _il2cpp_icall_func();
	return retVal;
}
// System.Single UnityEngine.Time::get_deltaTime()
extern "C"  float Time_get_deltaTime_m372706562 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	typedef float (*Time_get_deltaTime_m372706562_ftn) ();
	static Time_get_deltaTime_m372706562_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Time_get_deltaTime_m372706562_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Time::get_deltaTime()");
	float retVal = _il2cpp_icall_func();
	return retVal;
}
// System.Single UnityEngine.Time::get_unscaledTime()
extern "C"  float Time_get_unscaledTime_m3457564332 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	typedef float (*Time_get_unscaledTime_m3457564332_ftn) ();
	static Time_get_unscaledTime_m3457564332_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Time_get_unscaledTime_m3457564332_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Time::get_unscaledTime()");
	float retVal = _il2cpp_icall_func();
	return retVal;
}
// System.Single UnityEngine.Time::get_unscaledDeltaTime()
extern "C"  float Time_get_unscaledDeltaTime_m4270080131 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	typedef float (*Time_get_unscaledDeltaTime_m4270080131_ftn) ();
	static Time_get_unscaledDeltaTime_m4270080131_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Time_get_unscaledDeltaTime_m4270080131_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Time::get_unscaledDeltaTime()");
	float retVal = _il2cpp_icall_func();
	return retVal;
}
// System.Single UnityEngine.Time::get_fixedDeltaTime()
extern "C"  float Time_get_fixedDeltaTime_m3595802076 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	typedef float (*Time_get_fixedDeltaTime_m3595802076_ftn) ();
	static Time_get_fixedDeltaTime_m3595802076_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Time_get_fixedDeltaTime_m3595802076_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Time::get_fixedDeltaTime()");
	float retVal = _il2cpp_icall_func();
	return retVal;
}
// System.Single UnityEngine.Time::get_smoothDeltaTime()
extern "C"  float Time_get_smoothDeltaTime_m2285259559 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	typedef float (*Time_get_smoothDeltaTime_m2285259559_ftn) ();
	static Time_get_smoothDeltaTime_m2285259559_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Time_get_smoothDeltaTime_m2285259559_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Time::get_smoothDeltaTime()");
	float retVal = _il2cpp_icall_func();
	return retVal;
}
// System.Single UnityEngine.Time::get_timeScale()
extern "C"  float Time_get_timeScale_m701790074 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	typedef float (*Time_get_timeScale_m701790074_ftn) ();
	static Time_get_timeScale_m701790074_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Time_get_timeScale_m701790074_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Time::get_timeScale()");
	float retVal = _il2cpp_icall_func();
	return retVal;
}
// System.Void UnityEngine.Time::set_timeScale(System.Single)
extern "C"  void Time_set_timeScale_m1127545364 (RuntimeObject * __this /* static, unused */, float ___value0, const RuntimeMethod* method)
{
	typedef void (*Time_set_timeScale_m1127545364_ftn) (float);
	static Time_set_timeScale_m1127545364_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Time_set_timeScale_m1127545364_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Time::set_timeScale(System.Single)");
	_il2cpp_icall_func(___value0);
}
// System.Single UnityEngine.Time::get_realtimeSinceStartup()
extern "C"  float Time_get_realtimeSinceStartup_m3141794964 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	typedef float (*Time_get_realtimeSinceStartup_m3141794964_ftn) ();
	static Time_get_realtimeSinceStartup_m3141794964_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Time_get_realtimeSinceStartup_m3141794964_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Time::get_realtimeSinceStartup()");
	float retVal = _il2cpp_icall_func();
	return retVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.TooltipAttribute::.ctor(System.String)
extern "C"  void TooltipAttribute__ctor_m534364555 (TooltipAttribute_t3957072629 * __this, String_t* ___tooltip0, const RuntimeMethod* method)
{
	{
		PropertyAttribute__ctor_m1017741868(__this, /*hidden argument*/NULL);
		String_t* L_0 = ___tooltip0;
		__this->set_tooltip_0(L_0);
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
// System.Int32 UnityEngine.Touch::get_fingerId()
extern "C"  int32_t Touch_get_fingerId_m859576425 (Touch_t1921856868 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_FingerId_0();
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
extern "C"  int32_t Touch_get_fingerId_m859576425_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Touch_t1921856868 * _thisAdjusted = reinterpret_cast<Touch_t1921856868 *>(__this + 1);
	return Touch_get_fingerId_m859576425(_thisAdjusted, method);
}
// UnityEngine.Vector2 UnityEngine.Touch::get_position()
extern "C"  Vector2_t2156229523  Touch_get_position_m3109777936 (Touch_t1921856868 * __this, const RuntimeMethod* method)
{
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		Vector2_t2156229523  L_0 = __this->get_m_Position_1();
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		Vector2_t2156229523  L_1 = V_0;
		return L_1;
	}
}
extern "C"  Vector2_t2156229523  Touch_get_position_m3109777936_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Touch_t1921856868 * _thisAdjusted = reinterpret_cast<Touch_t1921856868 *>(__this + 1);
	return Touch_get_position_m3109777936(_thisAdjusted, method);
}
// UnityEngine.Vector2 UnityEngine.Touch::get_deltaPosition()
extern "C"  Vector2_t2156229523  Touch_get_deltaPosition_m2389653382 (Touch_t1921856868 * __this, const RuntimeMethod* method)
{
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		Vector2_t2156229523  L_0 = __this->get_m_PositionDelta_3();
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		Vector2_t2156229523  L_1 = V_0;
		return L_1;
	}
}
extern "C"  Vector2_t2156229523  Touch_get_deltaPosition_m2389653382_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Touch_t1921856868 * _thisAdjusted = reinterpret_cast<Touch_t1921856868 *>(__this + 1);
	return Touch_get_deltaPosition_m2389653382(_thisAdjusted, method);
}
// System.Single UnityEngine.Touch::get_deltaTime()
extern "C"  float Touch_get_deltaTime_m2346246468 (Touch_t1921856868 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_m_TimeDelta_4();
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		float L_1 = V_0;
		return L_1;
	}
}
extern "C"  float Touch_get_deltaTime_m2346246468_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Touch_t1921856868 * _thisAdjusted = reinterpret_cast<Touch_t1921856868 *>(__this + 1);
	return Touch_get_deltaTime_m2346246468(_thisAdjusted, method);
}
// UnityEngine.TouchPhase UnityEngine.Touch::get_phase()
extern "C"  int32_t Touch_get_phase_m214549210 (Touch_t1921856868 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_Phase_6();
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
extern "C"  int32_t Touch_get_phase_m214549210_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Touch_t1921856868 * _thisAdjusted = reinterpret_cast<Touch_t1921856868 *>(__this + 1);
	return Touch_get_phase_m214549210(_thisAdjusted, method);
}
// UnityEngine.TouchType UnityEngine.Touch::get_type()
extern "C"  int32_t Touch_get_type_m960232264 (Touch_t1921856868 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_Type_7();
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
extern "C"  int32_t Touch_get_type_m960232264_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Touch_t1921856868 * _thisAdjusted = reinterpret_cast<Touch_t1921856868 *>(__this + 1);
	return Touch_get_type_m960232264(_thisAdjusted, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// UnityEngine.TouchScreenKeyboard UnityEngine.TouchScreenKeyboard::Open(System.String,UnityEngine.TouchScreenKeyboardType,System.Boolean,System.Boolean,System.Boolean)
extern "C"  TouchScreenKeyboard_t731888065 * TouchScreenKeyboard_Open_m43950298 (RuntimeObject * __this /* static, unused */, String_t* ___text0, int32_t ___keyboardType1, bool ___autocorrection2, bool ___multiline3, bool ___secure4, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TouchScreenKeyboard_Open_m43950298_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	bool V_1 = false;
	TouchScreenKeyboard_t731888065 * V_2 = NULL;
	{
		V_0 = _stringLiteral757602046;
		V_1 = (bool)0;
		String_t* L_0 = ___text0;
		int32_t L_1 = ___keyboardType1;
		bool L_2 = ___autocorrection2;
		bool L_3 = ___multiline3;
		bool L_4 = ___secure4;
		bool L_5 = V_1;
		String_t* L_6 = V_0;
		TouchScreenKeyboard_t731888065 * L_7 = TouchScreenKeyboard_Open_m231964201(NULL /*static, unused*/, L_0, L_1, L_2, L_3, L_4, L_5, L_6, /*hidden argument*/NULL);
		V_2 = L_7;
		goto IL_001c;
	}

IL_001c:
	{
		TouchScreenKeyboard_t731888065 * L_8 = V_2;
		return L_8;
	}
}
// UnityEngine.TouchScreenKeyboard UnityEngine.TouchScreenKeyboard::Open(System.String,UnityEngine.TouchScreenKeyboardType,System.Boolean,System.Boolean)
extern "C"  TouchScreenKeyboard_t731888065 * TouchScreenKeyboard_Open_m3325559252 (RuntimeObject * __this /* static, unused */, String_t* ___text0, int32_t ___keyboardType1, bool ___autocorrection2, bool ___multiline3, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TouchScreenKeyboard_Open_m3325559252_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	bool V_1 = false;
	bool V_2 = false;
	TouchScreenKeyboard_t731888065 * V_3 = NULL;
	{
		V_0 = _stringLiteral757602046;
		V_1 = (bool)0;
		V_2 = (bool)0;
		String_t* L_0 = ___text0;
		int32_t L_1 = ___keyboardType1;
		bool L_2 = ___autocorrection2;
		bool L_3 = ___multiline3;
		bool L_4 = V_2;
		bool L_5 = V_1;
		String_t* L_6 = V_0;
		TouchScreenKeyboard_t731888065 * L_7 = TouchScreenKeyboard_Open_m231964201(NULL /*static, unused*/, L_0, L_1, L_2, L_3, L_4, L_5, L_6, /*hidden argument*/NULL);
		V_3 = L_7;
		goto IL_001d;
	}

IL_001d:
	{
		TouchScreenKeyboard_t731888065 * L_8 = V_3;
		return L_8;
	}
}
// UnityEngine.TouchScreenKeyboard UnityEngine.TouchScreenKeyboard::Open(System.String,UnityEngine.TouchScreenKeyboardType,System.Boolean,System.Boolean,System.Boolean,System.Boolean,System.String)
extern "C"  TouchScreenKeyboard_t731888065 * TouchScreenKeyboard_Open_m231964201 (RuntimeObject * __this /* static, unused */, String_t* ___text0, int32_t ___keyboardType1, bool ___autocorrection2, bool ___multiline3, bool ___secure4, bool ___alert5, String_t* ___textPlaceholder6, const RuntimeMethod* method)
{
	TouchScreenKeyboard_t731888065 * V_0 = NULL;
	{
		V_0 = (TouchScreenKeyboard_t731888065 *)NULL;
		goto IL_0008;
	}

IL_0008:
	{
		TouchScreenKeyboard_t731888065 * L_0 = V_0;
		return L_0;
	}
}
// System.String UnityEngine.TouchScreenKeyboard::get_text()
extern "C"  String_t* TouchScreenKeyboard_get_text_m1797464608 (TouchScreenKeyboard_t731888065 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TouchScreenKeyboard_get_text_m1797464608_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(String_t_il2cpp_TypeInfo_var);
		String_t* L_0 = ((String_t_StaticFields*)il2cpp_codegen_static_fields_for(String_t_il2cpp_TypeInfo_var))->get_Empty_2();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		String_t* L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.TouchScreenKeyboard::set_text(System.String)
extern "C"  void TouchScreenKeyboard_set_text_m107652927 (TouchScreenKeyboard_t731888065 * __this, String_t* ___value0, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Void UnityEngine.TouchScreenKeyboard::set_hideInput(System.Boolean)
extern "C"  void TouchScreenKeyboard_set_hideInput_m1428661361 (RuntimeObject * __this /* static, unused */, bool ___value0, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Boolean UnityEngine.TouchScreenKeyboard::get_active()
extern "C"  bool TouchScreenKeyboard_get_active_m4267591905 (TouchScreenKeyboard_t731888065 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		V_0 = (bool)0;
		goto IL_0008;
	}

IL_0008:
	{
		bool L_0 = V_0;
		return L_0;
	}
}
// System.Void UnityEngine.TouchScreenKeyboard::set_active(System.Boolean)
extern "C"  void TouchScreenKeyboard_set_active_m1980731296 (TouchScreenKeyboard_t731888065 * __this, bool ___value0, const RuntimeMethod* method)
{
	{
		return;
	}
}
// System.Boolean UnityEngine.TouchScreenKeyboard::get_done()
extern "C"  bool TouchScreenKeyboard_get_done_m3615485155 (TouchScreenKeyboard_t731888065 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		V_0 = (bool)1;
		goto IL_0008;
	}

IL_0008:
	{
		bool L_0 = V_0;
		return L_0;
	}
}
// System.Boolean UnityEngine.TouchScreenKeyboard::get_wasCanceled()
extern "C"  bool TouchScreenKeyboard_get_wasCanceled_m3225271241 (TouchScreenKeyboard_t731888065 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		V_0 = (bool)0;
		goto IL_0008;
	}

IL_0008:
	{
		bool L_0 = V_0;
		return L_0;
	}
}
// System.Boolean UnityEngine.TouchScreenKeyboard::get_isSupported()
extern "C"  bool TouchScreenKeyboard_get_isSupported_m1062200762 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		V_0 = (bool)0;
		goto IL_0008;
	}

IL_0008:
	{
		bool L_0 = V_0;
		return L_0;
	}
}
// System.Boolean UnityEngine.TouchScreenKeyboard::get_canGetSelection()
extern "C"  bool TouchScreenKeyboard_get_canGetSelection_m1476717240 (TouchScreenKeyboard_t731888065 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		V_0 = (bool)0;
		goto IL_0008;
	}

IL_0008:
	{
		bool L_0 = V_0;
		return L_0;
	}
}
// UnityEngine.RangeInt UnityEngine.TouchScreenKeyboard::get_selection()
extern "C"  RangeInt_t2094684618  TouchScreenKeyboard_get_selection_m3453176589 (TouchScreenKeyboard_t731888065 * __this, const RuntimeMethod* method)
{
	RangeInt_t2094684618  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		RangeInt_t2094684618  L_0;
		memset(&L_0, 0, sizeof(L_0));
		RangeInt__ctor_m240963897((&L_0), 0, 0, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000e;
	}

IL_000e:
	{
		RangeInt_t2094684618  L_1 = V_0;
		return L_1;
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.TrackedReference
extern "C" void TrackedReference_t1199777556_marshal_pinvoke(const TrackedReference_t1199777556& unmarshaled, TrackedReference_t1199777556_marshaled_pinvoke& marshaled)
{
	marshaled.___m_Ptr_0 = unmarshaled.get_m_Ptr_0();
}
extern "C" void TrackedReference_t1199777556_marshal_pinvoke_back(const TrackedReference_t1199777556_marshaled_pinvoke& marshaled, TrackedReference_t1199777556& unmarshaled)
{
	intptr_t unmarshaled_m_Ptr_temp_0;
	memset(&unmarshaled_m_Ptr_temp_0, 0, sizeof(unmarshaled_m_Ptr_temp_0));
	unmarshaled_m_Ptr_temp_0 = marshaled.___m_Ptr_0;
	unmarshaled.set_m_Ptr_0(unmarshaled_m_Ptr_temp_0);
}
// Conversion method for clean up from marshalling of: UnityEngine.TrackedReference
extern "C" void TrackedReference_t1199777556_marshal_pinvoke_cleanup(TrackedReference_t1199777556_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.TrackedReference
extern "C" void TrackedReference_t1199777556_marshal_com(const TrackedReference_t1199777556& unmarshaled, TrackedReference_t1199777556_marshaled_com& marshaled)
{
	marshaled.___m_Ptr_0 = unmarshaled.get_m_Ptr_0();
}
extern "C" void TrackedReference_t1199777556_marshal_com_back(const TrackedReference_t1199777556_marshaled_com& marshaled, TrackedReference_t1199777556& unmarshaled)
{
	intptr_t unmarshaled_m_Ptr_temp_0;
	memset(&unmarshaled_m_Ptr_temp_0, 0, sizeof(unmarshaled_m_Ptr_temp_0));
	unmarshaled_m_Ptr_temp_0 = marshaled.___m_Ptr_0;
	unmarshaled.set_m_Ptr_0(unmarshaled_m_Ptr_temp_0);
}
// Conversion method for clean up from marshalling of: UnityEngine.TrackedReference
extern "C" void TrackedReference_t1199777556_marshal_com_cleanup(TrackedReference_t1199777556_marshaled_com& marshaled)
{
}
// System.Boolean UnityEngine.TrackedReference::op_Equality(UnityEngine.TrackedReference,UnityEngine.TrackedReference)
extern "C"  bool TrackedReference_op_Equality_m3702354772 (RuntimeObject * __this /* static, unused */, TrackedReference_t1199777556 * ___x0, TrackedReference_t1199777556 * ___y1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TrackedReference_op_Equality_m3702354772_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	RuntimeObject * V_1 = NULL;
	bool V_2 = false;
	{
		TrackedReference_t1199777556 * L_0 = ___x0;
		V_0 = L_0;
		TrackedReference_t1199777556 * L_1 = ___y1;
		V_1 = L_1;
		RuntimeObject * L_2 = V_1;
		if (L_2)
		{
			goto IL_0018;
		}
	}
	{
		RuntimeObject * L_3 = V_0;
		if (L_3)
		{
			goto IL_0018;
		}
	}
	{
		V_2 = (bool)1;
		goto IL_0067;
	}

IL_0018:
	{
		RuntimeObject * L_4 = V_1;
		if (L_4)
		{
			goto IL_0034;
		}
	}
	{
		TrackedReference_t1199777556 * L_5 = ___x0;
		intptr_t L_6 = L_5->get_m_Ptr_0();
		bool L_7 = IntPtr_op_Equality_m408849716(NULL /*static, unused*/, L_6, (intptr_t)(0), /*hidden argument*/NULL);
		V_2 = L_7;
		goto IL_0067;
	}

IL_0034:
	{
		RuntimeObject * L_8 = V_0;
		if (L_8)
		{
			goto IL_0050;
		}
	}
	{
		TrackedReference_t1199777556 * L_9 = ___y1;
		intptr_t L_10 = L_9->get_m_Ptr_0();
		bool L_11 = IntPtr_op_Equality_m408849716(NULL /*static, unused*/, L_10, (intptr_t)(0), /*hidden argument*/NULL);
		V_2 = L_11;
		goto IL_0067;
	}

IL_0050:
	{
		TrackedReference_t1199777556 * L_12 = ___x0;
		intptr_t L_13 = L_12->get_m_Ptr_0();
		TrackedReference_t1199777556 * L_14 = ___y1;
		intptr_t L_15 = L_14->get_m_Ptr_0();
		bool L_16 = IntPtr_op_Equality_m408849716(NULL /*static, unused*/, L_13, L_15, /*hidden argument*/NULL);
		V_2 = L_16;
		goto IL_0067;
	}

IL_0067:
	{
		bool L_17 = V_2;
		return L_17;
	}
}
// System.Boolean UnityEngine.TrackedReference::Equals(System.Object)
extern "C"  bool TrackedReference_Equals_m1342350606 (TrackedReference_t1199777556 * __this, RuntimeObject * ___o0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TrackedReference_Equals_m1342350606_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		RuntimeObject * L_0 = ___o0;
		bool L_1 = TrackedReference_op_Equality_m3702354772(NULL /*static, unused*/, ((TrackedReference_t1199777556 *)IsInstClass((RuntimeObject*)L_0, TrackedReference_t1199777556_il2cpp_TypeInfo_var)), __this, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0013;
	}

IL_0013:
	{
		bool L_2 = V_0;
		return L_2;
	}
}
// System.Int32 UnityEngine.TrackedReference::GetHashCode()
extern "C"  int32_t TrackedReference_GetHashCode_m3645519794 (TrackedReference_t1199777556 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		intptr_t L_0 = __this->get_m_Ptr_0();
		int32_t L_1 = IntPtr_op_Explicit_m4220076518(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_0012;
	}

IL_0012:
	{
		int32_t L_2 = V_0;
		return L_2;
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
// System.Void UnityEngine.Transform::.ctor()
extern "C"  void Transform__ctor_m3470711880 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	{
		Component__ctor_m1928064382(__this, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 UnityEngine.Transform::get_position()
extern "C"  Vector3_t3722313464  Transform_get_position_m36019626 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Transform_INTERNAL_get_position_m1310184257(__this, (&V_0), /*hidden argument*/NULL);
		Vector3_t3722313464  L_0 = V_0;
		V_1 = L_0;
		goto IL_0010;
	}

IL_0010:
	{
		Vector3_t3722313464  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Transform::set_position(UnityEngine.Vector3)
extern "C"  void Transform_set_position_m3387557959 (Transform_t3600365921 * __this, Vector3_t3722313464  ___value0, const RuntimeMethod* method)
{
	{
		Transform_INTERNAL_set_position_m3627767375(__this, (&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Transform::INTERNAL_get_position(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_get_position_m1310184257 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_get_position_m1310184257_ftn) (Transform_t3600365921 *, Vector3_t3722313464 *);
	static Transform_INTERNAL_get_position_m1310184257_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_get_position_m1310184257_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_get_position(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Transform::INTERNAL_set_position(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_set_position_m3627767375 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_set_position_m3627767375_ftn) (Transform_t3600365921 *, Vector3_t3722313464 *);
	static Transform_INTERNAL_set_position_m3627767375_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_set_position_m3627767375_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_set_position(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.Vector3 UnityEngine.Transform::get_localPosition()
extern "C"  Vector3_t3722313464  Transform_get_localPosition_m4234289348 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Transform_INTERNAL_get_localPosition_m1816167803(__this, (&V_0), /*hidden argument*/NULL);
		Vector3_t3722313464  L_0 = V_0;
		V_1 = L_0;
		goto IL_0010;
	}

IL_0010:
	{
		Vector3_t3722313464  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Transform::set_localPosition(UnityEngine.Vector3)
extern "C"  void Transform_set_localPosition_m4128471975 (Transform_t3600365921 * __this, Vector3_t3722313464  ___value0, const RuntimeMethod* method)
{
	{
		Transform_INTERNAL_set_localPosition_m1936358505(__this, (&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Transform::INTERNAL_get_localPosition(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_get_localPosition_m1816167803 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_get_localPosition_m1816167803_ftn) (Transform_t3600365921 *, Vector3_t3722313464 *);
	static Transform_INTERNAL_get_localPosition_m1816167803_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_get_localPosition_m1816167803_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_get_localPosition(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Transform::INTERNAL_set_localPosition(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_set_localPosition_m1936358505 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_set_localPosition_m1936358505_ftn) (Transform_t3600365921 *, Vector3_t3722313464 *);
	static Transform_INTERNAL_set_localPosition_m1936358505_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_set_localPosition_m1936358505_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_set_localPosition(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.Vector3 UnityEngine.Transform::get_localEulerAngles()
extern "C"  Vector3_t3722313464  Transform_get_localEulerAngles_m2136926248 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	Quaternion_t2301928331  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Quaternion_t2301928331  L_0 = Transform_get_localRotation_m3487911431(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		Vector3_t3722313464  L_1 = Quaternion_get_eulerAngles_m3425202016((&V_0), /*hidden argument*/NULL);
		V_1 = L_1;
		goto IL_0015;
	}

IL_0015:
	{
		Vector3_t3722313464  L_2 = V_1;
		return L_2;
	}
}
// System.Void UnityEngine.Transform::set_localEulerAngles(UnityEngine.Vector3)
extern "C"  void Transform_set_localEulerAngles_m4202601546 (Transform_t3600365921 * __this, Vector3_t3722313464  ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Transform_set_localEulerAngles_m4202601546_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Vector3_t3722313464  L_0 = ___value0;
		IL2CPP_RUNTIME_CLASS_INIT(Quaternion_t2301928331_il2cpp_TypeInfo_var);
		Quaternion_t2301928331  L_1 = Quaternion_Euler_m1803555822(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		Transform_set_localRotation_m19445462(__this, L_1, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 UnityEngine.Transform::get_up()
extern "C"  Vector3_t3722313464  Transform_get_up_m3972993886 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Transform_get_up_m3972993886_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		Quaternion_t2301928331  L_0 = Transform_get_rotation_m3502953881(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_1 = Vector3_get_up_m3584168373(NULL /*static, unused*/, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Quaternion_t2301928331_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_2 = Quaternion_op_Multiply_m2607404835(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0017;
	}

IL_0017:
	{
		Vector3_t3722313464  L_3 = V_0;
		return L_3;
	}
}
// UnityEngine.Vector3 UnityEngine.Transform::get_forward()
extern "C"  Vector3_t3722313464  Transform_get_forward_m747522392 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Transform_get_forward_m747522392_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		Quaternion_t2301928331  L_0 = Transform_get_rotation_m3502953881(__this, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_1 = Vector3_get_forward_m3100859705(NULL /*static, unused*/, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Quaternion_t2301928331_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_2 = Quaternion_op_Multiply_m2607404835(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0017;
	}

IL_0017:
	{
		Vector3_t3722313464  L_3 = V_0;
		return L_3;
	}
}
// UnityEngine.Quaternion UnityEngine.Transform::get_rotation()
extern "C"  Quaternion_t2301928331  Transform_get_rotation_m3502953881 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	Quaternion_t2301928331  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Quaternion_t2301928331  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Transform_INTERNAL_get_rotation_m2413441996(__this, (&V_0), /*hidden argument*/NULL);
		Quaternion_t2301928331  L_0 = V_0;
		V_1 = L_0;
		goto IL_0010;
	}

IL_0010:
	{
		Quaternion_t2301928331  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Transform::set_rotation(UnityEngine.Quaternion)
extern "C"  void Transform_set_rotation_m3524318132 (Transform_t3600365921 * __this, Quaternion_t2301928331  ___value0, const RuntimeMethod* method)
{
	{
		Transform_INTERNAL_set_rotation_m2375965701(__this, (&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Transform::INTERNAL_get_rotation(UnityEngine.Quaternion&)
extern "C"  void Transform_INTERNAL_get_rotation_m2413441996 (Transform_t3600365921 * __this, Quaternion_t2301928331 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_get_rotation_m2413441996_ftn) (Transform_t3600365921 *, Quaternion_t2301928331 *);
	static Transform_INTERNAL_get_rotation_m2413441996_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_get_rotation_m2413441996_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_get_rotation(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Transform::INTERNAL_set_rotation(UnityEngine.Quaternion&)
extern "C"  void Transform_INTERNAL_set_rotation_m2375965701 (Transform_t3600365921 * __this, Quaternion_t2301928331 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_set_rotation_m2375965701_ftn) (Transform_t3600365921 *, Quaternion_t2301928331 *);
	static Transform_INTERNAL_set_rotation_m2375965701_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_set_rotation_m2375965701_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_set_rotation(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.Quaternion UnityEngine.Transform::get_localRotation()
extern "C"  Quaternion_t2301928331  Transform_get_localRotation_m3487911431 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	Quaternion_t2301928331  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Quaternion_t2301928331  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Transform_INTERNAL_get_localRotation_m1111330565(__this, (&V_0), /*hidden argument*/NULL);
		Quaternion_t2301928331  L_0 = V_0;
		V_1 = L_0;
		goto IL_0010;
	}

IL_0010:
	{
		Quaternion_t2301928331  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Transform::set_localRotation(UnityEngine.Quaternion)
extern "C"  void Transform_set_localRotation_m19445462 (Transform_t3600365921 * __this, Quaternion_t2301928331  ___value0, const RuntimeMethod* method)
{
	{
		Transform_INTERNAL_set_localRotation_m3824682417(__this, (&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Transform::INTERNAL_get_localRotation(UnityEngine.Quaternion&)
extern "C"  void Transform_INTERNAL_get_localRotation_m1111330565 (Transform_t3600365921 * __this, Quaternion_t2301928331 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_get_localRotation_m1111330565_ftn) (Transform_t3600365921 *, Quaternion_t2301928331 *);
	static Transform_INTERNAL_get_localRotation_m1111330565_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_get_localRotation_m1111330565_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_get_localRotation(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Transform::INTERNAL_set_localRotation(UnityEngine.Quaternion&)
extern "C"  void Transform_INTERNAL_set_localRotation_m3824682417 (Transform_t3600365921 * __this, Quaternion_t2301928331 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_set_localRotation_m3824682417_ftn) (Transform_t3600365921 *, Quaternion_t2301928331 *);
	static Transform_INTERNAL_set_localRotation_m3824682417_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_set_localRotation_m3824682417_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_set_localRotation(UnityEngine.Quaternion&)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.Vector3 UnityEngine.Transform::get_localScale()
extern "C"  Vector3_t3722313464  Transform_get_localScale_m129152068 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Transform_INTERNAL_get_localScale_m3233655062(__this, (&V_0), /*hidden argument*/NULL);
		Vector3_t3722313464  L_0 = V_0;
		V_1 = L_0;
		goto IL_0010;
	}

IL_0010:
	{
		Vector3_t3722313464  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Transform::set_localScale(UnityEngine.Vector3)
extern "C"  void Transform_set_localScale_m3053443106 (Transform_t3600365921 * __this, Vector3_t3722313464  ___value0, const RuntimeMethod* method)
{
	{
		Transform_INTERNAL_set_localScale_m1089294020(__this, (&___value0), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Transform::INTERNAL_get_localScale(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_get_localScale_m3233655062 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_get_localScale_m3233655062_ftn) (Transform_t3600365921 *, Vector3_t3722313464 *);
	static Transform_INTERNAL_get_localScale_m3233655062_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_get_localScale_m3233655062_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_get_localScale(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Transform::INTERNAL_set_localScale(UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_set_localScale_m1089294020 (Transform_t3600365921 * __this, Vector3_t3722313464 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_set_localScale_m1089294020_ftn) (Transform_t3600365921 *, Vector3_t3722313464 *);
	static Transform_INTERNAL_set_localScale_m1089294020_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_set_localScale_m1089294020_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_set_localScale(UnityEngine.Vector3&)");
	_il2cpp_icall_func(__this, ___value0);
}
// UnityEngine.Transform UnityEngine.Transform::get_parent()
extern "C"  Transform_t3600365921 * Transform_get_parent_m835071599 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	Transform_t3600365921 * V_0 = NULL;
	{
		Transform_t3600365921 * L_0 = Transform_get_parentInternal_m1494967989(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		Transform_t3600365921 * L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Transform::set_parent(UnityEngine.Transform)
extern "C"  void Transform_set_parent_m786917804 (Transform_t3600365921 * __this, Transform_t3600365921 * ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Transform_set_parent_m786917804_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		if (!((RectTransform_t3704657025 *)IsInstSealed((RuntimeObject*)__this, RectTransform_t3704657025_il2cpp_TypeInfo_var)))
		{
			goto IL_0017;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(Debug_t3317548046_il2cpp_TypeInfo_var);
		Debug_LogWarning_m831581295(NULL /*static, unused*/, _stringLiteral821992081, __this, /*hidden argument*/NULL);
	}

IL_0017:
	{
		Transform_t3600365921 * L_0 = ___value0;
		Transform_set_parentInternal_m2066300701(__this, L_0, /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Transform UnityEngine.Transform::get_parentInternal()
extern "C"  Transform_t3600365921 * Transform_get_parentInternal_m1494967989 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	typedef Transform_t3600365921 * (*Transform_get_parentInternal_m1494967989_ftn) (Transform_t3600365921 *);
	static Transform_get_parentInternal_m1494967989_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_get_parentInternal_m1494967989_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::get_parentInternal()");
	Transform_t3600365921 * retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.Transform::set_parentInternal(UnityEngine.Transform)
extern "C"  void Transform_set_parentInternal_m2066300701 (Transform_t3600365921 * __this, Transform_t3600365921 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_set_parentInternal_m2066300701_ftn) (Transform_t3600365921 *, Transform_t3600365921 *);
	static Transform_set_parentInternal_m2066300701_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_set_parentInternal_m2066300701_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::set_parentInternal(UnityEngine.Transform)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Transform::SetParent(UnityEngine.Transform)
extern "C"  void Transform_SetParent_m381167889 (Transform_t3600365921 * __this, Transform_t3600365921 * ___parent0, const RuntimeMethod* method)
{
	{
		Transform_t3600365921 * L_0 = ___parent0;
		Transform_SetParent_m273471670(__this, L_0, (bool)1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Transform::SetParent(UnityEngine.Transform,System.Boolean)
extern "C"  void Transform_SetParent_m273471670 (Transform_t3600365921 * __this, Transform_t3600365921 * ___parent0, bool ___worldPositionStays1, const RuntimeMethod* method)
{
	typedef void (*Transform_SetParent_m273471670_ftn) (Transform_t3600365921 *, Transform_t3600365921 *, bool);
	static Transform_SetParent_m273471670_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_SetParent_m273471670_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::SetParent(UnityEngine.Transform,System.Boolean)");
	_il2cpp_icall_func(__this, ___parent0, ___worldPositionStays1);
}
// UnityEngine.Matrix4x4 UnityEngine.Transform::get_worldToLocalMatrix()
extern "C"  Matrix4x4_t1817901843  Transform_get_worldToLocalMatrix_m399704877 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	Matrix4x4_t1817901843  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Matrix4x4_t1817901843  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Transform_INTERNAL_get_worldToLocalMatrix_m2730237241(__this, (&V_0), /*hidden argument*/NULL);
		Matrix4x4_t1817901843  L_0 = V_0;
		V_1 = L_0;
		goto IL_0010;
	}

IL_0010:
	{
		Matrix4x4_t1817901843  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Transform::INTERNAL_get_worldToLocalMatrix(UnityEngine.Matrix4x4&)
extern "C"  void Transform_INTERNAL_get_worldToLocalMatrix_m2730237241 (Transform_t3600365921 * __this, Matrix4x4_t1817901843 * ___value0, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_get_worldToLocalMatrix_m2730237241_ftn) (Transform_t3600365921 *, Matrix4x4_t1817901843 *);
	static Transform_INTERNAL_get_worldToLocalMatrix_m2730237241_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_get_worldToLocalMatrix_m2730237241_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_get_worldToLocalMatrix(UnityEngine.Matrix4x4&)");
	_il2cpp_icall_func(__this, ___value0);
}
// System.Void UnityEngine.Transform::Translate(UnityEngine.Vector3)
extern "C"  void Transform_Translate_m1810197270 (Transform_t3600365921 * __this, Vector3_t3722313464  ___translation0, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		V_0 = 1;
		Vector3_t3722313464  L_0 = ___translation0;
		int32_t L_1 = V_0;
		Transform_Translate_m1990195114(__this, L_0, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Transform::Translate(UnityEngine.Vector3,UnityEngine.Space)
extern "C"  void Transform_Translate_m1990195114 (Transform_t3600365921 * __this, Vector3_t3722313464  ___translation0, int32_t ___relativeTo1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Transform_Translate_m1990195114_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___relativeTo1;
		if (L_0)
		{
			goto IL_001e;
		}
	}
	{
		Vector3_t3722313464  L_1 = Transform_get_position_m36019626(__this, /*hidden argument*/NULL);
		Vector3_t3722313464  L_2 = ___translation0;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_3 = Vector3_op_Addition_m779775034(NULL /*static, unused*/, L_1, L_2, /*hidden argument*/NULL);
		Transform_set_position_m3387557959(__this, L_3, /*hidden argument*/NULL);
		goto IL_0036;
	}

IL_001e:
	{
		Vector3_t3722313464  L_4 = Transform_get_position_m36019626(__this, /*hidden argument*/NULL);
		Vector3_t3722313464  L_5 = ___translation0;
		Vector3_t3722313464  L_6 = Transform_TransformDirection_m3784028109(__this, L_5, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_7 = Vector3_op_Addition_m779775034(NULL /*static, unused*/, L_4, L_6, /*hidden argument*/NULL);
		Transform_set_position_m3387557959(__this, L_7, /*hidden argument*/NULL);
	}

IL_0036:
	{
		return;
	}
}
// System.Void UnityEngine.Transform::RotateAroundInternal(UnityEngine.Vector3,System.Single)
extern "C"  void Transform_RotateAroundInternal_m1612579057 (Transform_t3600365921 * __this, Vector3_t3722313464  ___axis0, float ___angle1, const RuntimeMethod* method)
{
	{
		float L_0 = ___angle1;
		Transform_INTERNAL_CALL_RotateAroundInternal_m394670328(NULL /*static, unused*/, __this, (&___axis0), L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.Transform::INTERNAL_CALL_RotateAroundInternal(UnityEngine.Transform,UnityEngine.Vector3&,System.Single)
extern "C"  void Transform_INTERNAL_CALL_RotateAroundInternal_m394670328 (RuntimeObject * __this /* static, unused */, Transform_t3600365921 * ___self0, Vector3_t3722313464 * ___axis1, float ___angle2, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_CALL_RotateAroundInternal_m394670328_ftn) (Transform_t3600365921 *, Vector3_t3722313464 *, float);
	static Transform_INTERNAL_CALL_RotateAroundInternal_m394670328_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_CALL_RotateAroundInternal_m394670328_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_CALL_RotateAroundInternal(UnityEngine.Transform,UnityEngine.Vector3&,System.Single)");
	_il2cpp_icall_func(___self0, ___axis1, ___angle2);
}
// System.Void UnityEngine.Transform::RotateAround(UnityEngine.Vector3,UnityEngine.Vector3,System.Single)
extern "C"  void Transform_RotateAround_m2651195670 (Transform_t3600365921 * __this, Vector3_t3722313464  ___point0, Vector3_t3722313464  ___axis1, float ___angle2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Transform_RotateAround_m2651195670_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Quaternion_t2301928331  V_1;
	memset(&V_1, 0, sizeof(V_1));
	Vector3_t3722313464  V_2;
	memset(&V_2, 0, sizeof(V_2));
	{
		Vector3_t3722313464  L_0 = Transform_get_position_m36019626(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		float L_1 = ___angle2;
		Vector3_t3722313464  L_2 = ___axis1;
		IL2CPP_RUNTIME_CLASS_INIT(Quaternion_t2301928331_il2cpp_TypeInfo_var);
		Quaternion_t2301928331  L_3 = Quaternion_AngleAxis_m1767165696(NULL /*static, unused*/, L_1, L_2, /*hidden argument*/NULL);
		V_1 = L_3;
		Vector3_t3722313464  L_4 = V_0;
		Vector3_t3722313464  L_5 = ___point0;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_6 = Vector3_op_Subtraction_m3073674971(NULL /*static, unused*/, L_4, L_5, /*hidden argument*/NULL);
		V_2 = L_6;
		Quaternion_t2301928331  L_7 = V_1;
		Vector3_t3722313464  L_8 = V_2;
		Vector3_t3722313464  L_9 = Quaternion_op_Multiply_m2607404835(NULL /*static, unused*/, L_7, L_8, /*hidden argument*/NULL);
		V_2 = L_9;
		Vector3_t3722313464  L_10 = ___point0;
		Vector3_t3722313464  L_11 = V_2;
		Vector3_t3722313464  L_12 = Vector3_op_Addition_m779775034(NULL /*static, unused*/, L_10, L_11, /*hidden argument*/NULL);
		V_0 = L_12;
		Vector3_t3722313464  L_13 = V_0;
		Transform_set_position_m3387557959(__this, L_13, /*hidden argument*/NULL);
		Vector3_t3722313464  L_14 = ___axis1;
		float L_15 = ___angle2;
		Transform_RotateAroundInternal_m1612579057(__this, L_14, ((float)il2cpp_codegen_multiply((float)L_15, (float)(0.0174532924f))), /*hidden argument*/NULL);
		return;
	}
}
// UnityEngine.Vector3 UnityEngine.Transform::TransformDirection(UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Transform_TransformDirection_m3784028109 (Transform_t3600365921 * __this, Vector3_t3722313464  ___direction0, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Transform_INTERNAL_CALL_TransformDirection_m4281205641(NULL /*static, unused*/, __this, (&___direction0), (&V_0), /*hidden argument*/NULL);
		Vector3_t3722313464  L_0 = V_0;
		V_1 = L_0;
		goto IL_0012;
	}

IL_0012:
	{
		Vector3_t3722313464  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Transform::INTERNAL_CALL_TransformDirection(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_CALL_TransformDirection_m4281205641 (RuntimeObject * __this /* static, unused */, Transform_t3600365921 * ___self0, Vector3_t3722313464 * ___direction1, Vector3_t3722313464 * ___value2, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_CALL_TransformDirection_m4281205641_ftn) (Transform_t3600365921 *, Vector3_t3722313464 *, Vector3_t3722313464 *);
	static Transform_INTERNAL_CALL_TransformDirection_m4281205641_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_CALL_TransformDirection_m4281205641_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_CALL_TransformDirection(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)");
	_il2cpp_icall_func(___self0, ___direction1, ___value2);
}
// UnityEngine.Vector3 UnityEngine.Transform::InverseTransformDirection(UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Transform_InverseTransformDirection_m3843238577 (Transform_t3600365921 * __this, Vector3_t3722313464  ___direction0, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Transform_INTERNAL_CALL_InverseTransformDirection_m4017133129(NULL /*static, unused*/, __this, (&___direction0), (&V_0), /*hidden argument*/NULL);
		Vector3_t3722313464  L_0 = V_0;
		V_1 = L_0;
		goto IL_0012;
	}

IL_0012:
	{
		Vector3_t3722313464  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Transform::INTERNAL_CALL_InverseTransformDirection(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_CALL_InverseTransformDirection_m4017133129 (RuntimeObject * __this /* static, unused */, Transform_t3600365921 * ___self0, Vector3_t3722313464 * ___direction1, Vector3_t3722313464 * ___value2, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_CALL_InverseTransformDirection_m4017133129_ftn) (Transform_t3600365921 *, Vector3_t3722313464 *, Vector3_t3722313464 *);
	static Transform_INTERNAL_CALL_InverseTransformDirection_m4017133129_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_CALL_InverseTransformDirection_m4017133129_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_CALL_InverseTransformDirection(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)");
	_il2cpp_icall_func(___self0, ___direction1, ___value2);
}
// UnityEngine.Vector3 UnityEngine.Transform::TransformPoint(UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Transform_TransformPoint_m226827784 (Transform_t3600365921 * __this, Vector3_t3722313464  ___position0, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Transform_INTERNAL_CALL_TransformPoint_m4261269221(NULL /*static, unused*/, __this, (&___position0), (&V_0), /*hidden argument*/NULL);
		Vector3_t3722313464  L_0 = V_0;
		V_1 = L_0;
		goto IL_0012;
	}

IL_0012:
	{
		Vector3_t3722313464  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Transform::INTERNAL_CALL_TransformPoint(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_CALL_TransformPoint_m4261269221 (RuntimeObject * __this /* static, unused */, Transform_t3600365921 * ___self0, Vector3_t3722313464 * ___position1, Vector3_t3722313464 * ___value2, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_CALL_TransformPoint_m4261269221_ftn) (Transform_t3600365921 *, Vector3_t3722313464 *, Vector3_t3722313464 *);
	static Transform_INTERNAL_CALL_TransformPoint_m4261269221_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_CALL_TransformPoint_m4261269221_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_CALL_TransformPoint(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)");
	_il2cpp_icall_func(___self0, ___position1, ___value2);
}
// UnityEngine.Vector3 UnityEngine.Transform::InverseTransformPoint(UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Transform_InverseTransformPoint_m1343916000 (Transform_t3600365921 * __this, Vector3_t3722313464  ___position0, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Transform_INTERNAL_CALL_InverseTransformPoint_m821776309(NULL /*static, unused*/, __this, (&___position0), (&V_0), /*hidden argument*/NULL);
		Vector3_t3722313464  L_0 = V_0;
		V_1 = L_0;
		goto IL_0012;
	}

IL_0012:
	{
		Vector3_t3722313464  L_1 = V_1;
		return L_1;
	}
}
// System.Void UnityEngine.Transform::INTERNAL_CALL_InverseTransformPoint(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)
extern "C"  void Transform_INTERNAL_CALL_InverseTransformPoint_m821776309 (RuntimeObject * __this /* static, unused */, Transform_t3600365921 * ___self0, Vector3_t3722313464 * ___position1, Vector3_t3722313464 * ___value2, const RuntimeMethod* method)
{
	typedef void (*Transform_INTERNAL_CALL_InverseTransformPoint_m821776309_ftn) (Transform_t3600365921 *, Vector3_t3722313464 *, Vector3_t3722313464 *);
	static Transform_INTERNAL_CALL_InverseTransformPoint_m821776309_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_INTERNAL_CALL_InverseTransformPoint_m821776309_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::INTERNAL_CALL_InverseTransformPoint(UnityEngine.Transform,UnityEngine.Vector3&,UnityEngine.Vector3&)");
	_il2cpp_icall_func(___self0, ___position1, ___value2);
}
// UnityEngine.Transform UnityEngine.Transform::get_root()
extern "C"  Transform_t3600365921 * Transform_get_root_m2450402596 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	typedef Transform_t3600365921 * (*Transform_get_root_m2450402596_ftn) (Transform_t3600365921 *);
	static Transform_get_root_m2450402596_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_get_root_m2450402596_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::get_root()");
	Transform_t3600365921 * retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Int32 UnityEngine.Transform::get_childCount()
extern "C"  int32_t Transform_get_childCount_m3145433196 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	typedef int32_t (*Transform_get_childCount_m3145433196_ftn) (Transform_t3600365921 *);
	static Transform_get_childCount_m3145433196_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_get_childCount_m3145433196_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::get_childCount()");
	int32_t retVal = _il2cpp_icall_func(__this);
	return retVal;
}
// System.Void UnityEngine.Transform::SetAsFirstSibling()
extern "C"  void Transform_SetAsFirstSibling_m253439912 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	typedef void (*Transform_SetAsFirstSibling_m253439912_ftn) (Transform_t3600365921 *);
	static Transform_SetAsFirstSibling_m253439912_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_SetAsFirstSibling_m253439912_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::SetAsFirstSibling()");
	_il2cpp_icall_func(__this);
}
// System.Boolean UnityEngine.Transform::IsChildOf(UnityEngine.Transform)
extern "C"  bool Transform_IsChildOf_m224006092 (Transform_t3600365921 * __this, Transform_t3600365921 * ___parent0, const RuntimeMethod* method)
{
	typedef bool (*Transform_IsChildOf_m224006092_ftn) (Transform_t3600365921 *, Transform_t3600365921 *);
	static Transform_IsChildOf_m224006092_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_IsChildOf_m224006092_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::IsChildOf(UnityEngine.Transform)");
	bool retVal = _il2cpp_icall_func(__this, ___parent0);
	return retVal;
}
// System.Collections.IEnumerator UnityEngine.Transform::GetEnumerator()
extern "C"  RuntimeObject* Transform_GetEnumerator_m2717073726 (Transform_t3600365921 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Transform_GetEnumerator_m2717073726_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject* V_0 = NULL;
	{
		Enumerator_t3442430665 * L_0 = (Enumerator_t3442430665 *)il2cpp_codegen_object_new(Enumerator_t3442430665_il2cpp_TypeInfo_var);
		Enumerator__ctor_m1351041375(L_0, __this, /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		RuntimeObject* L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Transform UnityEngine.Transform::GetChild(System.Int32)
extern "C"  Transform_t3600365921 * Transform_GetChild_m1092972975 (Transform_t3600365921 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	typedef Transform_t3600365921 * (*Transform_GetChild_m1092972975_ftn) (Transform_t3600365921 *, int32_t);
	static Transform_GetChild_m1092972975_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (Transform_GetChild_m1092972975_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.Transform::GetChild(System.Int32)");
	Transform_t3600365921 * retVal = _il2cpp_icall_func(__this, ___index0);
	return retVal;
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Transform/Enumerator::.ctor(UnityEngine.Transform)
extern "C"  void Enumerator__ctor_m1351041375 (Enumerator_t3442430665 * __this, Transform_t3600365921 * ___outer0, const RuntimeMethod* method)
{
	{
		__this->set_currentIndex_1((-1));
		Object__ctor_m297566312(__this, /*hidden argument*/NULL);
		Transform_t3600365921 * L_0 = ___outer0;
		__this->set_outer_0(L_0);
		return;
	}
}
// System.Object UnityEngine.Transform/Enumerator::get_Current()
extern "C"  RuntimeObject * Enumerator_get_Current_m2591725252 (Enumerator_t3442430665 * __this, const RuntimeMethod* method)
{
	RuntimeObject * V_0 = NULL;
	{
		Transform_t3600365921 * L_0 = __this->get_outer_0();
		int32_t L_1 = __this->get_currentIndex_1();
		Transform_t3600365921 * L_2 = Transform_GetChild_m1092972975(L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_0018;
	}

IL_0018:
	{
		RuntimeObject * L_3 = V_0;
		return L_3;
	}
}
// System.Boolean UnityEngine.Transform/Enumerator::MoveNext()
extern "C"  bool Enumerator_MoveNext_m4275888254 (Enumerator_t3442430665 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	bool V_2 = false;
	{
		Transform_t3600365921 * L_0 = __this->get_outer_0();
		int32_t L_1 = Transform_get_childCount_m3145433196(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		int32_t L_2 = __this->get_currentIndex_1();
		int32_t L_3 = ((int32_t)il2cpp_codegen_add((int32_t)L_2, (int32_t)1));
		V_1 = L_3;
		__this->set_currentIndex_1(L_3);
		int32_t L_4 = V_1;
		int32_t L_5 = V_0;
		V_2 = (bool)((((int32_t)L_4) < ((int32_t)L_5))? 1 : 0);
		goto IL_0027;
	}

IL_0027:
	{
		bool L_6 = V_2;
		return L_6;
	}
}
// System.Void UnityEngine.Transform/Enumerator::Reset()
extern "C"  void Enumerator_Reset_m39541243 (Enumerator_t3442430665 * __this, const RuntimeMethod* method)
{
	{
		__this->set_currentIndex_1((-1));
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Boolean UnityEngine.U2D.SpriteAtlasManager::RequestAtlas(System.String)
extern "C"  bool SpriteAtlasManager_RequestAtlas_m455709951 (RuntimeObject * __this /* static, unused */, String_t* ___tag0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SpriteAtlasManager_RequestAtlas_m455709951_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	String_t* G_B3_0 = NULL;
	RequestAtlasCallback_t3100554279 * G_B3_1 = NULL;
	String_t* G_B2_0 = NULL;
	RequestAtlasCallback_t3100554279 * G_B2_1 = NULL;
	{
		IL2CPP_RUNTIME_CLASS_INIT(SpriteAtlasManager_t3158462485_il2cpp_TypeInfo_var);
		RequestAtlasCallback_t3100554279 * L_0 = ((SpriteAtlasManager_t3158462485_StaticFields*)il2cpp_codegen_static_fields_for(SpriteAtlasManager_t3158462485_il2cpp_TypeInfo_var))->get_atlasRequested_0();
		if (!L_0)
		{
			goto IL_003b;
		}
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(SpriteAtlasManager_t3158462485_il2cpp_TypeInfo_var);
		RequestAtlasCallback_t3100554279 * L_1 = ((SpriteAtlasManager_t3158462485_StaticFields*)il2cpp_codegen_static_fields_for(SpriteAtlasManager_t3158462485_il2cpp_TypeInfo_var))->get_atlasRequested_0();
		String_t* L_2 = ___tag0;
		Action_1_t819399007 * L_3 = ((SpriteAtlasManager_t3158462485_StaticFields*)il2cpp_codegen_static_fields_for(SpriteAtlasManager_t3158462485_il2cpp_TypeInfo_var))->get_U3CU3Ef__mgU24cache0_1();
		G_B2_0 = L_2;
		G_B2_1 = L_1;
		if (L_3)
		{
			G_B3_0 = L_2;
			G_B3_1 = L_1;
			goto IL_002a;
		}
	}
	{
		intptr_t L_4 = (intptr_t)SpriteAtlasManager_Register_m2413332465_RuntimeMethod_var;
		Action_1_t819399007 * L_5 = (Action_1_t819399007 *)il2cpp_codegen_object_new(Action_1_t819399007_il2cpp_TypeInfo_var);
		Action_1__ctor_m3325790595(L_5, NULL, L_4, /*hidden argument*/Action_1__ctor_m3325790595_RuntimeMethod_var);
		IL2CPP_RUNTIME_CLASS_INIT(SpriteAtlasManager_t3158462485_il2cpp_TypeInfo_var);
		((SpriteAtlasManager_t3158462485_StaticFields*)il2cpp_codegen_static_fields_for(SpriteAtlasManager_t3158462485_il2cpp_TypeInfo_var))->set_U3CU3Ef__mgU24cache0_1(L_5);
		G_B3_0 = G_B2_0;
		G_B3_1 = G_B2_1;
	}

IL_002a:
	{
		IL2CPP_RUNTIME_CLASS_INIT(SpriteAtlasManager_t3158462485_il2cpp_TypeInfo_var);
		Action_1_t819399007 * L_6 = ((SpriteAtlasManager_t3158462485_StaticFields*)il2cpp_codegen_static_fields_for(SpriteAtlasManager_t3158462485_il2cpp_TypeInfo_var))->get_U3CU3Ef__mgU24cache0_1();
		RequestAtlasCallback_Invoke_m378128467(G_B3_1, G_B3_0, L_6, /*hidden argument*/NULL);
		V_0 = (bool)1;
		goto IL_0042;
	}

IL_003b:
	{
		V_0 = (bool)0;
		goto IL_0042;
	}

IL_0042:
	{
		bool L_7 = V_0;
		return L_7;
	}
}
// System.Void UnityEngine.U2D.SpriteAtlasManager::Register(UnityEngine.U2D.SpriteAtlas)
extern "C"  void SpriteAtlasManager_Register_m2413332465 (RuntimeObject * __this /* static, unused */, SpriteAtlas_t646931412 * ___spriteAtlas0, const RuntimeMethod* method)
{
	typedef void (*SpriteAtlasManager_Register_m2413332465_ftn) (SpriteAtlas_t646931412 *);
	static SpriteAtlasManager_Register_m2413332465_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (SpriteAtlasManager_Register_m2413332465_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.U2D.SpriteAtlasManager::Register(UnityEngine.U2D.SpriteAtlas)");
	_il2cpp_icall_func(___spriteAtlas0);
}
// System.Void UnityEngine.U2D.SpriteAtlasManager::.cctor()
extern "C"  void SpriteAtlasManager__cctor_m3642741753 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (SpriteAtlasManager__cctor_m3642741753_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		((SpriteAtlasManager_t3158462485_StaticFields*)il2cpp_codegen_static_fields_for(SpriteAtlasManager_t3158462485_il2cpp_TypeInfo_var))->set_atlasRequested_0((RequestAtlasCallback_t3100554279 *)NULL);
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
extern "C"  void DelegatePInvokeWrapper_RequestAtlasCallback_t3100554279 (RequestAtlasCallback_t3100554279 * __this, String_t* ___tag0, Action_1_t819399007 * ___action1, const RuntimeMethod* method)
{
	typedef void (STDCALL *PInvokeFunc)(char*, Il2CppMethodPointer);
	PInvokeFunc il2cppPInvokeFunc = reinterpret_cast<PInvokeFunc>(il2cpp_codegen_get_method_pointer(((RuntimeDelegate*)__this)->method));

	// Marshaling of parameter '___tag0' to native representation
	char* ____tag0_marshaled = NULL;
	____tag0_marshaled = il2cpp_codegen_marshal_string(___tag0);

	// Marshaling of parameter '___action1' to native representation
	Il2CppMethodPointer ____action1_marshaled = NULL;
	____action1_marshaled = il2cpp_codegen_marshal_delegate(reinterpret_cast<MulticastDelegate_t*>(___action1));

	// Native function invocation
	il2cppPInvokeFunc(____tag0_marshaled, ____action1_marshaled);

	// Marshaling cleanup of parameter '___tag0' native representation
	il2cpp_codegen_marshal_free(____tag0_marshaled);
	____tag0_marshaled = NULL;

}
// System.Void UnityEngine.U2D.SpriteAtlasManager/RequestAtlasCallback::.ctor(System.Object,System.IntPtr)
extern "C"  void RequestAtlasCallback__ctor_m3023745648 (RequestAtlasCallback_t3100554279 * __this, RuntimeObject * ___object0, intptr_t ___method1, const RuntimeMethod* method)
{
	__this->set_method_ptr_0(il2cpp_codegen_get_method_pointer((RuntimeMethod*)___method1));
	__this->set_method_3(___method1);
	__this->set_m_target_2(___object0);
}
// System.Void UnityEngine.U2D.SpriteAtlasManager/RequestAtlasCallback::Invoke(System.String,System.Action`1<UnityEngine.U2D.SpriteAtlas>)
extern "C"  void RequestAtlasCallback_Invoke_m378128467 (RequestAtlasCallback_t3100554279 * __this, String_t* ___tag0, Action_1_t819399007 * ___action1, const RuntimeMethod* method)
{
	if(__this->get_prev_9() != NULL)
	{
		RequestAtlasCallback_Invoke_m378128467((RequestAtlasCallback_t3100554279 *)__this->get_prev_9(), ___tag0, ___action1, method);
	}
	Il2CppMethodPointer targetMethodPointer = __this->get_method_ptr_0();
	RuntimeMethod* targetMethod = (RuntimeMethod*)(__this->get_method_3());
	RuntimeObject* targetThis = __this->get_m_target_2();
	il2cpp_codegen_raise_execution_engine_exception_if_method_is_not_found(targetMethod);
	bool ___methodIsStatic = MethodIsStatic(targetMethod);
	if (___methodIsStatic)
	{
		if (il2cpp_codegen_method_parameter_count(targetMethod) == 2)
		{
			// open
			{
				typedef void (*FunctionPointerType) (RuntimeObject *, String_t*, Action_1_t819399007 *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(NULL, ___tag0, ___action1, targetMethod);
			}
		}
		else
		{
			// closed
			{
				typedef void (*FunctionPointerType) (RuntimeObject *, void*, String_t*, Action_1_t819399007 *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(NULL, targetThis, ___tag0, ___action1, targetMethod);
			}
		}
	}
	else
	{
		if (il2cpp_codegen_method_parameter_count(targetMethod) == 2)
		{
			// closed
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker2< String_t*, Action_1_t819399007 * >::Invoke(targetMethod, targetThis, ___tag0, ___action1);
					else
						GenericVirtActionInvoker2< String_t*, Action_1_t819399007 * >::Invoke(targetMethod, targetThis, ___tag0, ___action1);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker2< String_t*, Action_1_t819399007 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), targetThis, ___tag0, ___action1);
					else
						VirtActionInvoker2< String_t*, Action_1_t819399007 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), targetThis, ___tag0, ___action1);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (void*, String_t*, Action_1_t819399007 *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(targetThis, ___tag0, ___action1, targetMethod);
			}
		}
		else
		{
			// open
			if (il2cpp_codegen_method_is_virtual(targetMethod) && !il2cpp_codegen_object_is_of_sealed_type(targetThis) && il2cpp_codegen_delegate_has_invoker((Il2CppDelegate*)__this))
			{
				if (il2cpp_codegen_method_is_generic_instance(targetMethod))
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						GenericInterfaceActionInvoker1< Action_1_t819399007 * >::Invoke(targetMethod, ___tag0, ___action1);
					else
						GenericVirtActionInvoker1< Action_1_t819399007 * >::Invoke(targetMethod, ___tag0, ___action1);
				}
				else
				{
					if (il2cpp_codegen_method_is_interface_method(targetMethod))
						InterfaceActionInvoker1< Action_1_t819399007 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), il2cpp_codegen_method_get_declaring_type(targetMethod), ___tag0, ___action1);
					else
						VirtActionInvoker1< Action_1_t819399007 * >::Invoke(il2cpp_codegen_method_get_slot(targetMethod), ___tag0, ___action1);
				}
			}
			else
			{
				typedef void (*FunctionPointerType) (String_t*, Action_1_t819399007 *, const RuntimeMethod*);
				((FunctionPointerType)targetMethodPointer)(___tag0, ___action1, targetMethod);
			}
		}
	}
}
// System.IAsyncResult UnityEngine.U2D.SpriteAtlasManager/RequestAtlasCallback::BeginInvoke(System.String,System.Action`1<UnityEngine.U2D.SpriteAtlas>,System.AsyncCallback,System.Object)
extern "C"  RuntimeObject* RequestAtlasCallback_BeginInvoke_m2655374249 (RequestAtlasCallback_t3100554279 * __this, String_t* ___tag0, Action_1_t819399007 * ___action1, AsyncCallback_t3962456242 * ___callback2, RuntimeObject * ___object3, const RuntimeMethod* method)
{
	void *__d_args[3] = {0};
	__d_args[0] = ___tag0;
	__d_args[1] = ___action1;
	return (RuntimeObject*)il2cpp_codegen_delegate_begin_invoke((RuntimeDelegate*)__this, __d_args, (RuntimeDelegate*)___callback2, (RuntimeObject*)___object3);
}
// System.Void UnityEngine.U2D.SpriteAtlasManager/RequestAtlasCallback::EndInvoke(System.IAsyncResult)
extern "C"  void RequestAtlasCallback_EndInvoke_m2592639818 (RequestAtlasCallback_t3100554279 * __this, RuntimeObject* ___result0, const RuntimeMethod* method)
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
// System.Void UnityEngine.UnityException::.ctor()
extern "C"  void UnityException__ctor_m1456865679 (UnityException_t3598173660 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (UnityException__ctor_m1456865679_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Exception__ctor_m1152696503(__this, _stringLiteral3595826494, /*hidden argument*/NULL);
		Exception_set_HResult_m3489164646(__this, ((int32_t)-2147467261), /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.UnityException::.ctor(System.Runtime.Serialization.SerializationInfo,System.Runtime.Serialization.StreamingContext)
extern "C"  void UnityException__ctor_m170038890 (UnityException_t3598173660 * __this, SerializationInfo_t950877179 * ___info0, StreamingContext_t3711869237  ___context1, const RuntimeMethod* method)
{
	{
		SerializationInfo_t950877179 * L_0 = ___info0;
		StreamingContext_t3711869237  L_1 = ___context1;
		Exception__ctor_m2499432361(__this, L_0, L_1, /*hidden argument*/NULL);
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
// System.Void UnityEngine.UnityLogWriter::.ctor()
extern "C"  void UnityLogWriter__ctor_m1834616883 (UnityLogWriter_t1374348020 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (UnityLogWriter__ctor_m1834616883_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		IL2CPP_RUNTIME_CLASS_INIT(TextWriter_t3478189236_il2cpp_TypeInfo_var);
		TextWriter__ctor_m2859954372(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.UnityLogWriter::WriteStringToUnityLog(System.String)
extern "C"  void UnityLogWriter_WriteStringToUnityLog_m2695353836 (RuntimeObject * __this /* static, unused */, String_t* ___s0, const RuntimeMethod* method)
{
	typedef void (*UnityLogWriter_WriteStringToUnityLog_m2695353836_ftn) (String_t*);
	static UnityLogWriter_WriteStringToUnityLog_m2695353836_ftn _il2cpp_icall_func;
	if (!_il2cpp_icall_func)
	_il2cpp_icall_func = (UnityLogWriter_WriteStringToUnityLog_m2695353836_ftn)il2cpp_codegen_resolve_icall ("UnityEngine.UnityLogWriter::WriteStringToUnityLog(System.String)");
	_il2cpp_icall_func(___s0);
}
// System.Void UnityEngine.UnityLogWriter::Init()
extern "C"  void UnityLogWriter_Init_m3866572946 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (UnityLogWriter_Init_m3866572946_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		UnityLogWriter_t1374348020 * L_0 = (UnityLogWriter_t1374348020 *)il2cpp_codegen_object_new(UnityLogWriter_t1374348020_il2cpp_TypeInfo_var);
		UnityLogWriter__ctor_m1834616883(L_0, /*hidden argument*/NULL);
		IL2CPP_RUNTIME_CLASS_INIT(Console_t3208230065_il2cpp_TypeInfo_var);
		Console_SetOut_m286050082(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.UnityLogWriter::Write(System.Char)
extern "C"  void UnityLogWriter_Write_m3542862483 (UnityLogWriter_t1374348020 * __this, Il2CppChar ___value0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = Char_ToString_m3588025615((&___value0), /*hidden argument*/NULL);
		UnityLogWriter_WriteStringToUnityLog_m2695353836(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.UnityLogWriter::Write(System.String)
extern "C"  void UnityLogWriter_Write_m345199408 (UnityLogWriter_t1374348020 * __this, String_t* ___s0, const RuntimeMethod* method)
{
	{
		String_t* L_0 = ___s0;
		UnityLogWriter_WriteStringToUnityLog_m2695353836(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
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
// System.Void UnityEngine.UnitySynchronizationContext::.ctor()
extern "C"  void UnitySynchronizationContext__ctor_m1707488257 (UnitySynchronizationContext_t1887453786 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (UnitySynchronizationContext__ctor_m1707488257_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Queue_1_t1200778106 * L_0 = (Queue_1_t1200778106 *)il2cpp_codegen_object_new(Queue_1_t1200778106_il2cpp_TypeInfo_var);
		Queue_1__ctor_m1971992302(L_0, ((int32_t)20), /*hidden argument*/Queue_1__ctor_m1971992302_RuntimeMethod_var);
		__this->set_m_AsyncWorkQueue_1(L_0);
		IL2CPP_RUNTIME_CLASS_INIT(Thread_t2300836069_il2cpp_TypeInfo_var);
		Thread_t2300836069 * L_1 = Thread_get_CurrentThread_m4142136012(NULL /*static, unused*/, /*hidden argument*/NULL);
		int32_t L_2 = Thread_get_ManagedThreadId_m1068113671(L_1, /*hidden argument*/NULL);
		__this->set_m_MainThreadID_2(L_2);
		SynchronizationContext__ctor_m2514243817(__this, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngine.UnitySynchronizationContext::Exec()
extern "C"  void UnitySynchronizationContext_Exec_m3359802660 (UnitySynchronizationContext_t1887453786 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (UnitySynchronizationContext_Exec_m3359802660_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	RuntimeObject * V_0 = NULL;
	WorkRequest_t1354518612  V_1;
	memset(&V_1, 0, sizeof(V_1));
	Exception_t * __last_unhandled_exception = 0;
	NO_UNUSED_WARNING (__last_unhandled_exception);
	Exception_t * __exception_local = 0;
	NO_UNUSED_WARNING (__exception_local);
	int32_t __leave_target = 0;
	NO_UNUSED_WARNING (__leave_target);
	{
		Queue_1_t1200778106 * L_0 = __this->get_m_AsyncWorkQueue_1();
		V_0 = L_0;
		RuntimeObject * L_1 = V_0;
		Monitor_Enter_m2249409497(NULL /*static, unused*/, L_1, /*hidden argument*/NULL);
	}

IL_000e:
	try
	{ // begin try (depth: 1)
		{
			goto IL_0029;
		}

IL_0014:
		{
			Queue_1_t1200778106 * L_2 = __this->get_m_AsyncWorkQueue_1();
			WorkRequest_t1354518612  L_3 = Queue_1_Dequeue_m979967976(L_2, /*hidden argument*/Queue_1_Dequeue_m979967976_RuntimeMethod_var);
			V_1 = L_3;
			WorkRequest_Invoke_m3488164927((&V_1), /*hidden argument*/NULL);
		}

IL_0029:
		{
			Queue_1_t1200778106 * L_4 = __this->get_m_AsyncWorkQueue_1();
			int32_t L_5 = Queue_1_get_Count_m3368911732(L_4, /*hidden argument*/Queue_1_get_Count_m3368911732_RuntimeMethod_var);
			if ((((int32_t)L_5) > ((int32_t)0)))
			{
				goto IL_0014;
			}
		}

IL_003a:
		{
			IL2CPP_LEAVE(0x47, FINALLY_0040);
		}
	} // end try (depth: 1)
	catch(Il2CppExceptionWrapper& e)
	{
		__last_unhandled_exception = (Exception_t *)e.ex;
		goto FINALLY_0040;
	}

FINALLY_0040:
	{ // begin finally (depth: 1)
		RuntimeObject * L_6 = V_0;
		Monitor_Exit_m3585316909(NULL /*static, unused*/, L_6, /*hidden argument*/NULL);
		IL2CPP_END_FINALLY(64)
	} // end finally (depth: 1)
	IL2CPP_CLEANUP(64)
	{
		IL2CPP_JUMP_TBL(0x47, IL_0047)
		IL2CPP_RETHROW_IF_UNHANDLED(Exception_t *)
	}

IL_0047:
	{
		return;
	}
}
// System.Void UnityEngine.UnitySynchronizationContext::InitializeSynchronizationContext()
extern "C"  void UnitySynchronizationContext_InitializeSynchronizationContext_m3217591031 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (UnitySynchronizationContext_InitializeSynchronizationContext_m3217591031_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		SynchronizationContext_t2326897723 * L_0 = SynchronizationContext_get_Current_m3666546046(NULL /*static, unused*/, /*hidden argument*/NULL);
		if (L_0)
		{
			goto IL_0015;
		}
	}
	{
		UnitySynchronizationContext_t1887453786 * L_1 = (UnitySynchronizationContext_t1887453786 *)il2cpp_codegen_object_new(UnitySynchronizationContext_t1887453786_il2cpp_TypeInfo_var);
		UnitySynchronizationContext__ctor_m1707488257(L_1, /*hidden argument*/NULL);
		SynchronizationContext_SetSynchronizationContext_m1249070039(NULL /*static, unused*/, L_1, /*hidden argument*/NULL);
	}

IL_0015:
	{
		return;
	}
}
// System.Void UnityEngine.UnitySynchronizationContext::ExecuteTasks()
extern "C"  void UnitySynchronizationContext_ExecuteTasks_m1310741010 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (UnitySynchronizationContext_ExecuteTasks_m1310741010_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	UnitySynchronizationContext_t1887453786 * V_0 = NULL;
	{
		SynchronizationContext_t2326897723 * L_0 = SynchronizationContext_get_Current_m3666546046(NULL /*static, unused*/, /*hidden argument*/NULL);
		V_0 = ((UnitySynchronizationContext_t1887453786 *)IsInstSealed((RuntimeObject*)L_0, UnitySynchronizationContext_t1887453786_il2cpp_TypeInfo_var));
		UnitySynchronizationContext_t1887453786 * L_1 = V_0;
		if (!L_1)
		{
			goto IL_0018;
		}
	}
	{
		UnitySynchronizationContext_t1887453786 * L_2 = V_0;
		UnitySynchronizationContext_Exec_m3359802660(L_2, /*hidden argument*/NULL);
	}

IL_0018:
	{
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
// Conversion methods for marshalling of: UnityEngine.UnitySynchronizationContext/WorkRequest
extern "C" void WorkRequest_t1354518612_marshal_pinvoke(const WorkRequest_t1354518612& unmarshaled, WorkRequest_t1354518612_marshaled_pinvoke& marshaled)
{
	Exception_t* ___m_WaitHandle_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_WaitHandle' of type 'WorkRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_WaitHandle_2Exception,NULL);
}
extern "C" void WorkRequest_t1354518612_marshal_pinvoke_back(const WorkRequest_t1354518612_marshaled_pinvoke& marshaled, WorkRequest_t1354518612& unmarshaled)
{
	Exception_t* ___m_WaitHandle_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_WaitHandle' of type 'WorkRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_WaitHandle_2Exception,NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.UnitySynchronizationContext/WorkRequest
extern "C" void WorkRequest_t1354518612_marshal_pinvoke_cleanup(WorkRequest_t1354518612_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.UnitySynchronizationContext/WorkRequest
extern "C" void WorkRequest_t1354518612_marshal_com(const WorkRequest_t1354518612& unmarshaled, WorkRequest_t1354518612_marshaled_com& marshaled)
{
	Exception_t* ___m_WaitHandle_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_WaitHandle' of type 'WorkRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_WaitHandle_2Exception,NULL);
}
extern "C" void WorkRequest_t1354518612_marshal_com_back(const WorkRequest_t1354518612_marshaled_com& marshaled, WorkRequest_t1354518612& unmarshaled)
{
	Exception_t* ___m_WaitHandle_2Exception = il2cpp_codegen_get_marshal_directive_exception("Cannot marshal field 'm_WaitHandle' of type 'WorkRequest': Reference type field marshaling is not supported.");
	IL2CPP_RAISE_MANAGED_EXCEPTION(___m_WaitHandle_2Exception,NULL);
}
// Conversion method for clean up from marshalling of: UnityEngine.UnitySynchronizationContext/WorkRequest
extern "C" void WorkRequest_t1354518612_marshal_com_cleanup(WorkRequest_t1354518612_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.UnitySynchronizationContext/WorkRequest::Invoke()
extern "C"  void WorkRequest_Invoke_m3488164927 (WorkRequest_t1354518612 * __this, const RuntimeMethod* method)
{
	{
		SendOrPostCallback_t2750080073 * L_0 = __this->get_m_DelagateCallback_0();
		RuntimeObject * L_1 = __this->get_m_DelagateState_1();
		SendOrPostCallback_Invoke_m937799800(L_0, L_1, /*hidden argument*/NULL);
		ManualResetEvent_t451242010 * L_2 = __this->get_m_WaitHandle_2();
		if (!L_2)
		{
			goto IL_0029;
		}
	}
	{
		ManualResetEvent_t451242010 * L_3 = __this->get_m_WaitHandle_2();
		EventWaitHandle_Set_m2445193251(L_3, /*hidden argument*/NULL);
	}

IL_0029:
	{
		return;
	}
}
extern "C"  void WorkRequest_Invoke_m3488164927_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	WorkRequest_t1354518612 * _thisAdjusted = reinterpret_cast<WorkRequest_t1354518612 *>(__this + 1);
	WorkRequest_Invoke_m3488164927(_thisAdjusted, method);
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.Vector2::.ctor(System.Single,System.Single)
extern "C"  void Vector2__ctor_m3970636864 (Vector2_t2156229523 * __this, float ___x0, float ___y1, const RuntimeMethod* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_0(L_0);
		float L_1 = ___y1;
		__this->set_y_1(L_1);
		return;
	}
}
extern "C"  void Vector2__ctor_m3970636864_AdjustorThunk (RuntimeObject * __this, float ___x0, float ___y1, const RuntimeMethod* method)
{
	Vector2_t2156229523 * _thisAdjusted = reinterpret_cast<Vector2_t2156229523 *>(__this + 1);
	Vector2__ctor_m3970636864(_thisAdjusted, ___x0, ___y1, method);
}
// System.Single UnityEngine.Vector2::get_Item(System.Int32)
extern "C"  float Vector2_get_Item_m3559215723 (Vector2_t2156229523 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2_get_Item_m3559215723_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		int32_t L_0 = ___index0;
		if (!L_0)
		{
			goto IL_0013;
		}
	}
	{
		int32_t L_1 = ___index0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_001f;
		}
	}
	{
		goto IL_002b;
	}

IL_0013:
	{
		float L_2 = __this->get_x_0();
		V_0 = L_2;
		goto IL_0036;
	}

IL_001f:
	{
		float L_3 = __this->get_y_1();
		V_0 = L_3;
		goto IL_0036;
	}

IL_002b:
	{
		IndexOutOfRangeException_t1578797820 * L_4 = (IndexOutOfRangeException_t1578797820 *)il2cpp_codegen_object_new(IndexOutOfRangeException_t1578797820_il2cpp_TypeInfo_var);
		IndexOutOfRangeException__ctor_m3408750441(L_4, _stringLiteral2662230418, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4,Vector2_get_Item_m3559215723_RuntimeMethod_var);
	}

IL_0036:
	{
		float L_5 = V_0;
		return L_5;
	}
}
extern "C"  float Vector2_get_Item_m3559215723_AdjustorThunk (RuntimeObject * __this, int32_t ___index0, const RuntimeMethod* method)
{
	Vector2_t2156229523 * _thisAdjusted = reinterpret_cast<Vector2_t2156229523 *>(__this + 1);
	return Vector2_get_Item_m3559215723(_thisAdjusted, ___index0, method);
}
// System.Void UnityEngine.Vector2::set_Item(System.Int32,System.Single)
extern "C"  void Vector2_set_Item_m3557490725 (Vector2_t2156229523 * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2_set_Item_m3557490725_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___index0;
		if (!L_0)
		{
			goto IL_0013;
		}
	}
	{
		int32_t L_1 = ___index0;
		if ((((int32_t)L_1) == ((int32_t)1)))
		{
			goto IL_001f;
		}
	}
	{
		goto IL_002b;
	}

IL_0013:
	{
		float L_2 = ___value1;
		__this->set_x_0(L_2);
		goto IL_0036;
	}

IL_001f:
	{
		float L_3 = ___value1;
		__this->set_y_1(L_3);
		goto IL_0036;
	}

IL_002b:
	{
		IndexOutOfRangeException_t1578797820 * L_4 = (IndexOutOfRangeException_t1578797820 *)il2cpp_codegen_object_new(IndexOutOfRangeException_t1578797820_il2cpp_TypeInfo_var);
		IndexOutOfRangeException__ctor_m3408750441(L_4, _stringLiteral2662230418, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4,Vector2_set_Item_m3557490725_RuntimeMethod_var);
	}

IL_0036:
	{
		return;
	}
}
extern "C"  void Vector2_set_Item_m3557490725_AdjustorThunk (RuntimeObject * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method)
{
	Vector2_t2156229523 * _thisAdjusted = reinterpret_cast<Vector2_t2156229523 *>(__this + 1);
	Vector2_set_Item_m3557490725(_thisAdjusted, ___index0, ___value1, method);
}
// UnityEngine.Vector2 UnityEngine.Vector2::Lerp(UnityEngine.Vector2,UnityEngine.Vector2,System.Single)
extern "C"  Vector2_t2156229523  Vector2_Lerp_m854472224 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___a0, Vector2_t2156229523  ___b1, float ___t2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2_Lerp_m854472224_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = ___t2;
		IL2CPP_RUNTIME_CLASS_INIT(Mathf_t3464937446_il2cpp_TypeInfo_var);
		float L_1 = Mathf_Clamp01_m56433566(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		___t2 = L_1;
		float L_2 = (&___a0)->get_x_0();
		float L_3 = (&___b1)->get_x_0();
		float L_4 = (&___a0)->get_x_0();
		float L_5 = ___t2;
		float L_6 = (&___a0)->get_y_1();
		float L_7 = (&___b1)->get_y_1();
		float L_8 = (&___a0)->get_y_1();
		float L_9 = ___t2;
		Vector2_t2156229523  L_10;
		memset(&L_10, 0, sizeof(L_10));
		Vector2__ctor_m3970636864((&L_10), ((float)il2cpp_codegen_add((float)L_2, (float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)L_3, (float)L_4)), (float)L_5)))), ((float)il2cpp_codegen_add((float)L_6, (float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)L_7, (float)L_8)), (float)L_9)))), /*hidden argument*/NULL);
		V_0 = L_10;
		goto IL_0046;
	}

IL_0046:
	{
		Vector2_t2156229523  L_11 = V_0;
		return L_11;
	}
}
// UnityEngine.Vector2 UnityEngine.Vector2::Scale(UnityEngine.Vector2,UnityEngine.Vector2)
extern "C"  Vector2_t2156229523  Vector2_Scale_m165605769 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___a0, Vector2_t2156229523  ___b1, const RuntimeMethod* method)
{
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___a0)->get_x_0();
		float L_1 = (&___b1)->get_x_0();
		float L_2 = (&___a0)->get_y_1();
		float L_3 = (&___b1)->get_y_1();
		Vector2_t2156229523  L_4;
		memset(&L_4, 0, sizeof(L_4));
		Vector2__ctor_m3970636864((&L_4), ((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), ((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)), /*hidden argument*/NULL);
		V_0 = L_4;
		goto IL_002a;
	}

IL_002a:
	{
		Vector2_t2156229523  L_5 = V_0;
		return L_5;
	}
}
// System.String UnityEngine.Vector2::ToString()
extern "C"  String_t* Vector2_ToString_m1205609053 (Vector2_t2156229523 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2_ToString_m1205609053_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		ObjectU5BU5D_t2843939325* L_0 = ((ObjectU5BU5D_t2843939325*)SZArrayNew(ObjectU5BU5D_t2843939325_il2cpp_TypeInfo_var, (uint32_t)2));
		float L_1 = __this->get_x_0();
		float L_2 = L_1;
		RuntimeObject * L_3 = Box(Single_t1397266774_il2cpp_TypeInfo_var, &L_2);
		ArrayElementTypeCheck (L_0, L_3);
		(L_0)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_3);
		ObjectU5BU5D_t2843939325* L_4 = L_0;
		float L_5 = __this->get_y_1();
		float L_6 = L_5;
		RuntimeObject * L_7 = Box(Single_t1397266774_il2cpp_TypeInfo_var, &L_6);
		ArrayElementTypeCheck (L_4, L_7);
		(L_4)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_7);
		String_t* L_8 = UnityString_Format_m261690510(NULL /*static, unused*/, _stringLiteral2738543532, L_4, /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_0033;
	}

IL_0033:
	{
		String_t* L_9 = V_0;
		return L_9;
	}
}
extern "C"  String_t* Vector2_ToString_m1205609053_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector2_t2156229523 * _thisAdjusted = reinterpret_cast<Vector2_t2156229523 *>(__this + 1);
	return Vector2_ToString_m1205609053(_thisAdjusted, method);
}
// System.Int32 UnityEngine.Vector2::GetHashCode()
extern "C"  int32_t Vector2_GetHashCode_m3916089713 (Vector2_t2156229523 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		float* L_0 = __this->get_address_of_x_0();
		int32_t L_1 = Single_GetHashCode_m1558506138(L_0, /*hidden argument*/NULL);
		float* L_2 = __this->get_address_of_y_1();
		int32_t L_3 = Single_GetHashCode_m1558506138(L_2, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)L_1^(int32_t)((int32_t)((int32_t)L_3<<(int32_t)2))));
		goto IL_002c;
	}

IL_002c:
	{
		int32_t L_4 = V_0;
		return L_4;
	}
}
extern "C"  int32_t Vector2_GetHashCode_m3916089713_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector2_t2156229523 * _thisAdjusted = reinterpret_cast<Vector2_t2156229523 *>(__this + 1);
	return Vector2_GetHashCode_m3916089713(_thisAdjusted, method);
}
// System.Boolean UnityEngine.Vector2::Equals(System.Object)
extern "C"  bool Vector2_Equals_m832062989 (Vector2_t2156229523 * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2_Equals_m832062989_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	Vector2_t2156229523  V_1;
	memset(&V_1, 0, sizeof(V_1));
	int32_t G_B5_0 = 0;
	{
		RuntimeObject * L_0 = ___other0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_0, Vector2_t2156229523_il2cpp_TypeInfo_var)))
		{
			goto IL_0013;
		}
	}
	{
		V_0 = (bool)0;
		goto IL_004c;
	}

IL_0013:
	{
		RuntimeObject * L_1 = ___other0;
		V_1 = ((*(Vector2_t2156229523 *)((Vector2_t2156229523 *)UnBox(L_1, Vector2_t2156229523_il2cpp_TypeInfo_var))));
		float* L_2 = __this->get_address_of_x_0();
		float L_3 = (&V_1)->get_x_0();
		bool L_4 = Single_Equals_m1601893879(L_2, L_3, /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_0045;
		}
	}
	{
		float* L_5 = __this->get_address_of_y_1();
		float L_6 = (&V_1)->get_y_1();
		bool L_7 = Single_Equals_m1601893879(L_5, L_6, /*hidden argument*/NULL);
		G_B5_0 = ((int32_t)(L_7));
		goto IL_0046;
	}

IL_0045:
	{
		G_B5_0 = 0;
	}

IL_0046:
	{
		V_0 = (bool)G_B5_0;
		goto IL_004c;
	}

IL_004c:
	{
		bool L_8 = V_0;
		return L_8;
	}
}
extern "C"  bool Vector2_Equals_m832062989_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	Vector2_t2156229523 * _thisAdjusted = reinterpret_cast<Vector2_t2156229523 *>(__this + 1);
	return Vector2_Equals_m832062989(_thisAdjusted, ___other0, method);
}
// System.Single UnityEngine.Vector2::Dot(UnityEngine.Vector2,UnityEngine.Vector2)
extern "C"  float Vector2_Dot_m1554553447 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___lhs0, Vector2_t2156229523  ___rhs1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = (&___lhs0)->get_x_0();
		float L_1 = (&___rhs1)->get_x_0();
		float L_2 = (&___lhs0)->get_y_1();
		float L_3 = (&___rhs1)->get_y_1();
		V_0 = ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), (float)((float)il2cpp_codegen_multiply((float)L_2, (float)L_3))));
		goto IL_0026;
	}

IL_0026:
	{
		float L_4 = V_0;
		return L_4;
	}
}
// System.Single UnityEngine.Vector2::get_sqrMagnitude()
extern "C"  float Vector2_get_sqrMagnitude_m837837635 (Vector2_t2156229523 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_x_0();
		float L_1 = __this->get_x_0();
		float L_2 = __this->get_y_1();
		float L_3 = __this->get_y_1();
		V_0 = ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), (float)((float)il2cpp_codegen_multiply((float)L_2, (float)L_3))));
		goto IL_0022;
	}

IL_0022:
	{
		float L_4 = V_0;
		return L_4;
	}
}
extern "C"  float Vector2_get_sqrMagnitude_m837837635_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector2_t2156229523 * _thisAdjusted = reinterpret_cast<Vector2_t2156229523 *>(__this + 1);
	return Vector2_get_sqrMagnitude_m837837635(_thisAdjusted, method);
}
// UnityEngine.Vector2 UnityEngine.Vector2::op_Addition(UnityEngine.Vector2,UnityEngine.Vector2)
extern "C"  Vector2_t2156229523  Vector2_op_Addition_m800700293 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___a0, Vector2_t2156229523  ___b1, const RuntimeMethod* method)
{
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___a0)->get_x_0();
		float L_1 = (&___b1)->get_x_0();
		float L_2 = (&___a0)->get_y_1();
		float L_3 = (&___b1)->get_y_1();
		Vector2_t2156229523  L_4;
		memset(&L_4, 0, sizeof(L_4));
		Vector2__ctor_m3970636864((&L_4), ((float)il2cpp_codegen_add((float)L_0, (float)L_1)), ((float)il2cpp_codegen_add((float)L_2, (float)L_3)), /*hidden argument*/NULL);
		V_0 = L_4;
		goto IL_002a;
	}

IL_002a:
	{
		Vector2_t2156229523  L_5 = V_0;
		return L_5;
	}
}
// UnityEngine.Vector2 UnityEngine.Vector2::op_Subtraction(UnityEngine.Vector2,UnityEngine.Vector2)
extern "C"  Vector2_t2156229523  Vector2_op_Subtraction_m73004381 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___a0, Vector2_t2156229523  ___b1, const RuntimeMethod* method)
{
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___a0)->get_x_0();
		float L_1 = (&___b1)->get_x_0();
		float L_2 = (&___a0)->get_y_1();
		float L_3 = (&___b1)->get_y_1();
		Vector2_t2156229523  L_4;
		memset(&L_4, 0, sizeof(L_4));
		Vector2__ctor_m3970636864((&L_4), ((float)il2cpp_codegen_subtract((float)L_0, (float)L_1)), ((float)il2cpp_codegen_subtract((float)L_2, (float)L_3)), /*hidden argument*/NULL);
		V_0 = L_4;
		goto IL_002a;
	}

IL_002a:
	{
		Vector2_t2156229523  L_5 = V_0;
		return L_5;
	}
}
// UnityEngine.Vector2 UnityEngine.Vector2::op_Multiply(UnityEngine.Vector2,System.Single)
extern "C"  Vector2_t2156229523  Vector2_op_Multiply_m2347887432 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___a0, float ___d1, const RuntimeMethod* method)
{
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___a0)->get_x_0();
		float L_1 = ___d1;
		float L_2 = (&___a0)->get_y_1();
		float L_3 = ___d1;
		Vector2_t2156229523  L_4;
		memset(&L_4, 0, sizeof(L_4));
		Vector2__ctor_m3970636864((&L_4), ((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), ((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)), /*hidden argument*/NULL);
		V_0 = L_4;
		goto IL_001e;
	}

IL_001e:
	{
		Vector2_t2156229523  L_5 = V_0;
		return L_5;
	}
}
// UnityEngine.Vector2 UnityEngine.Vector2::op_Division(UnityEngine.Vector2,System.Single)
extern "C"  Vector2_t2156229523  Vector2_op_Division_m132623573 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___a0, float ___d1, const RuntimeMethod* method)
{
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___a0)->get_x_0();
		float L_1 = ___d1;
		float L_2 = (&___a0)->get_y_1();
		float L_3 = ___d1;
		Vector2_t2156229523  L_4;
		memset(&L_4, 0, sizeof(L_4));
		Vector2__ctor_m3970636864((&L_4), ((float)((float)L_0/(float)L_1)), ((float)((float)L_2/(float)L_3)), /*hidden argument*/NULL);
		V_0 = L_4;
		goto IL_001e;
	}

IL_001e:
	{
		Vector2_t2156229523  L_5 = V_0;
		return L_5;
	}
}
// System.Boolean UnityEngine.Vector2::op_Equality(UnityEngine.Vector2,UnityEngine.Vector2)
extern "C"  bool Vector2_op_Equality_m2303255133 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___lhs0, Vector2_t2156229523  ___rhs1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2_op_Equality_m2303255133_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	bool V_1 = false;
	{
		Vector2_t2156229523  L_0 = ___lhs0;
		Vector2_t2156229523  L_1 = ___rhs1;
		IL2CPP_RUNTIME_CLASS_INIT(Vector2_t2156229523_il2cpp_TypeInfo_var);
		Vector2_t2156229523  L_2 = Vector2_op_Subtraction_m73004381(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		float L_3 = Vector2_get_sqrMagnitude_m837837635((&V_0), /*hidden argument*/NULL);
		V_1 = (bool)((((float)L_3) < ((float)(9.99999944E-11f)))? 1 : 0);
		goto IL_001d;
	}

IL_001d:
	{
		bool L_4 = V_1;
		return L_4;
	}
}
// System.Boolean UnityEngine.Vector2::op_Inequality(UnityEngine.Vector2,UnityEngine.Vector2)
extern "C"  bool Vector2_op_Inequality_m3858779880 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___lhs0, Vector2_t2156229523  ___rhs1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2_op_Inequality_m3858779880_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		Vector2_t2156229523  L_0 = ___lhs0;
		Vector2_t2156229523  L_1 = ___rhs1;
		IL2CPP_RUNTIME_CLASS_INIT(Vector2_t2156229523_il2cpp_TypeInfo_var);
		bool L_2 = Vector2_op_Equality_m2303255133(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		goto IL_0011;
	}

IL_0011:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
// UnityEngine.Vector2 UnityEngine.Vector2::op_Implicit(UnityEngine.Vector3)
extern "C"  Vector2_t2156229523  Vector2_op_Implicit_m4260192859 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___v0, const RuntimeMethod* method)
{
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___v0)->get_x_1();
		float L_1 = (&___v0)->get_y_2();
		Vector2_t2156229523  L_2;
		memset(&L_2, 0, sizeof(L_2));
		Vector2__ctor_m3970636864((&L_2), L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_001a;
	}

IL_001a:
	{
		Vector2_t2156229523  L_3 = V_0;
		return L_3;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector2::op_Implicit(UnityEngine.Vector2)
extern "C"  Vector3_t3722313464  Vector2_op_Implicit_m1860157806 (RuntimeObject * __this /* static, unused */, Vector2_t2156229523  ___v0, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___v0)->get_x_0();
		float L_1 = (&___v0)->get_y_1();
		Vector3_t3722313464  L_2;
		memset(&L_2, 0, sizeof(L_2));
		Vector3__ctor_m3353183577((&L_2), L_0, L_1, (0.0f), /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_001f;
	}

IL_001f:
	{
		Vector3_t3722313464  L_3 = V_0;
		return L_3;
	}
}
// UnityEngine.Vector2 UnityEngine.Vector2::get_zero()
extern "C"  Vector2_t2156229523  Vector2_get_zero_m540426400 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2_get_zero_m540426400_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector2_t2156229523_il2cpp_TypeInfo_var);
		Vector2_t2156229523  L_0 = ((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->get_zeroVector_2();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector2_t2156229523  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector2 UnityEngine.Vector2::get_one()
extern "C"  Vector2_t2156229523  Vector2_get_one_m738793577 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2_get_one_m738793577_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector2_t2156229523_il2cpp_TypeInfo_var);
		Vector2_t2156229523  L_0 = ((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->get_oneVector_3();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector2_t2156229523  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector2 UnityEngine.Vector2::get_up()
extern "C"  Vector2_t2156229523  Vector2_get_up_m2647420593 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2_get_up_m2647420593_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector2_t2156229523_il2cpp_TypeInfo_var);
		Vector2_t2156229523  L_0 = ((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->get_upVector_4();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector2_t2156229523  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector2 UnityEngine.Vector2::get_right()
extern "C"  Vector2_t2156229523  Vector2_get_right_m1027081661 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2_get_right_m1027081661_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector2_t2156229523  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector2_t2156229523_il2cpp_TypeInfo_var);
		Vector2_t2156229523  L_0 = ((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->get_rightVector_7();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector2_t2156229523  L_1 = V_0;
		return L_1;
	}
}
// System.Void UnityEngine.Vector2::.cctor()
extern "C"  void Vector2__cctor_m2108982652 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector2__cctor_m2108982652_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Vector2_t2156229523  L_0;
		memset(&L_0, 0, sizeof(L_0));
		Vector2__ctor_m3970636864((&L_0), (0.0f), (0.0f), /*hidden argument*/NULL);
		((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->set_zeroVector_2(L_0);
		Vector2_t2156229523  L_1;
		memset(&L_1, 0, sizeof(L_1));
		Vector2__ctor_m3970636864((&L_1), (1.0f), (1.0f), /*hidden argument*/NULL);
		((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->set_oneVector_3(L_1);
		Vector2_t2156229523  L_2;
		memset(&L_2, 0, sizeof(L_2));
		Vector2__ctor_m3970636864((&L_2), (0.0f), (1.0f), /*hidden argument*/NULL);
		((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->set_upVector_4(L_2);
		Vector2_t2156229523  L_3;
		memset(&L_3, 0, sizeof(L_3));
		Vector2__ctor_m3970636864((&L_3), (0.0f), (-1.0f), /*hidden argument*/NULL);
		((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->set_downVector_5(L_3);
		Vector2_t2156229523  L_4;
		memset(&L_4, 0, sizeof(L_4));
		Vector2__ctor_m3970636864((&L_4), (-1.0f), (0.0f), /*hidden argument*/NULL);
		((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->set_leftVector_6(L_4);
		Vector2_t2156229523  L_5;
		memset(&L_5, 0, sizeof(L_5));
		Vector2__ctor_m3970636864((&L_5), (1.0f), (0.0f), /*hidden argument*/NULL);
		((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->set_rightVector_7(L_5);
		Vector2_t2156229523  L_6;
		memset(&L_6, 0, sizeof(L_6));
		Vector2__ctor_m3970636864((&L_6), (std::numeric_limits<float>::infinity()), (std::numeric_limits<float>::infinity()), /*hidden argument*/NULL);
		((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->set_positiveInfinityVector_8(L_6);
		Vector2_t2156229523  L_7;
		memset(&L_7, 0, sizeof(L_7));
		Vector2__ctor_m3970636864((&L_7), (-std::numeric_limits<float>::infinity()), (-std::numeric_limits<float>::infinity()), /*hidden argument*/NULL);
		((Vector2_t2156229523_StaticFields*)il2cpp_codegen_static_fields_for(Vector2_t2156229523_il2cpp_TypeInfo_var))->set_negativeInfinityVector_9(L_7);
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
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single,System.Single)
extern "C"  void Vector3__ctor_m3353183577 (Vector3_t3722313464 * __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_1(L_0);
		float L_1 = ___y1;
		__this->set_y_2(L_1);
		float L_2 = ___z2;
		__this->set_z_3(L_2);
		return;
	}
}
extern "C"  void Vector3__ctor_m3353183577_AdjustorThunk (RuntimeObject * __this, float ___x0, float ___y1, float ___z2, const RuntimeMethod* method)
{
	Vector3_t3722313464 * _thisAdjusted = reinterpret_cast<Vector3_t3722313464 *>(__this + 1);
	Vector3__ctor_m3353183577(_thisAdjusted, ___x0, ___y1, ___z2, method);
}
// System.Void UnityEngine.Vector3::.ctor(System.Single,System.Single)
extern "C"  void Vector3__ctor_m1719387948 (Vector3_t3722313464 * __this, float ___x0, float ___y1, const RuntimeMethod* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_1(L_0);
		float L_1 = ___y1;
		__this->set_y_2(L_1);
		__this->set_z_3((0.0f));
		return;
	}
}
extern "C"  void Vector3__ctor_m1719387948_AdjustorThunk (RuntimeObject * __this, float ___x0, float ___y1, const RuntimeMethod* method)
{
	Vector3_t3722313464 * _thisAdjusted = reinterpret_cast<Vector3_t3722313464 *>(__this + 1);
	Vector3__ctor_m1719387948(_thisAdjusted, ___x0, ___y1, method);
}
// UnityEngine.Vector3 UnityEngine.Vector3::Lerp(UnityEngine.Vector3,UnityEngine.Vector3,System.Single)
extern "C"  Vector3_t3722313464  Vector3_Lerp_m407887542 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___a0, Vector3_t3722313464  ___b1, float ___t2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_Lerp_m407887542_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = ___t2;
		IL2CPP_RUNTIME_CLASS_INIT(Mathf_t3464937446_il2cpp_TypeInfo_var);
		float L_1 = Mathf_Clamp01_m56433566(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		___t2 = L_1;
		float L_2 = (&___a0)->get_x_1();
		float L_3 = (&___b1)->get_x_1();
		float L_4 = (&___a0)->get_x_1();
		float L_5 = ___t2;
		float L_6 = (&___a0)->get_y_2();
		float L_7 = (&___b1)->get_y_2();
		float L_8 = (&___a0)->get_y_2();
		float L_9 = ___t2;
		float L_10 = (&___a0)->get_z_3();
		float L_11 = (&___b1)->get_z_3();
		float L_12 = (&___a0)->get_z_3();
		float L_13 = ___t2;
		Vector3_t3722313464  L_14;
		memset(&L_14, 0, sizeof(L_14));
		Vector3__ctor_m3353183577((&L_14), ((float)il2cpp_codegen_add((float)L_2, (float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)L_3, (float)L_4)), (float)L_5)))), ((float)il2cpp_codegen_add((float)L_6, (float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)L_7, (float)L_8)), (float)L_9)))), ((float)il2cpp_codegen_add((float)L_10, (float)((float)il2cpp_codegen_multiply((float)((float)il2cpp_codegen_subtract((float)L_11, (float)L_12)), (float)L_13)))), /*hidden argument*/NULL);
		V_0 = L_14;
		goto IL_005f;
	}

IL_005f:
	{
		Vector3_t3722313464  L_15 = V_0;
		return L_15;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::MoveTowards(UnityEngine.Vector3,UnityEngine.Vector3,System.Single)
extern "C"  Vector3_t3722313464  Vector3_MoveTowards_m2786395547 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___current0, Vector3_t3722313464  ___target1, float ___maxDistanceDelta2, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_MoveTowards_m2786395547_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	float V_1 = 0.0f;
	Vector3_t3722313464  V_2;
	memset(&V_2, 0, sizeof(V_2));
	{
		Vector3_t3722313464  L_0 = ___target1;
		Vector3_t3722313464  L_1 = ___current0;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_2 = Vector3_op_Subtraction_m3073674971(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		float L_3 = Vector3_get_magnitude_m27958459((&V_0), /*hidden argument*/NULL);
		V_1 = L_3;
		float L_4 = V_1;
		float L_5 = ___maxDistanceDelta2;
		if ((((float)L_4) <= ((float)L_5)))
		{
			goto IL_0023;
		}
	}
	{
		float L_6 = V_1;
		if ((!(((float)L_6) < ((float)(1.401298E-45f)))))
		{
			goto IL_002a;
		}
	}

IL_0023:
	{
		Vector3_t3722313464  L_7 = ___target1;
		V_2 = L_7;
		goto IL_0043;
	}

IL_002a:
	{
		Vector3_t3722313464  L_8 = ___current0;
		Vector3_t3722313464  L_9 = V_0;
		float L_10 = V_1;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_11 = Vector3_op_Division_m510815599(NULL /*static, unused*/, L_9, L_10, /*hidden argument*/NULL);
		float L_12 = ___maxDistanceDelta2;
		Vector3_t3722313464  L_13 = Vector3_op_Multiply_m3376773913(NULL /*static, unused*/, L_11, L_12, /*hidden argument*/NULL);
		Vector3_t3722313464  L_14 = Vector3_op_Addition_m779775034(NULL /*static, unused*/, L_8, L_13, /*hidden argument*/NULL);
		V_2 = L_14;
		goto IL_0043;
	}

IL_0043:
	{
		Vector3_t3722313464  L_15 = V_2;
		return L_15;
	}
}
// System.Single UnityEngine.Vector3::get_Item(System.Int32)
extern "C"  float Vector3_get_Item_m668685504 (Vector3_t3722313464 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_get_Item_m668685504_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		int32_t L_0 = ___index0;
		switch (L_0)
		{
			case 0:
			{
				goto IL_0018;
			}
			case 1:
			{
				goto IL_0024;
			}
			case 2:
			{
				goto IL_0030;
			}
		}
	}
	{
		goto IL_003c;
	}

IL_0018:
	{
		float L_1 = __this->get_x_1();
		V_0 = L_1;
		goto IL_0047;
	}

IL_0024:
	{
		float L_2 = __this->get_y_2();
		V_0 = L_2;
		goto IL_0047;
	}

IL_0030:
	{
		float L_3 = __this->get_z_3();
		V_0 = L_3;
		goto IL_0047;
	}

IL_003c:
	{
		IndexOutOfRangeException_t1578797820 * L_4 = (IndexOutOfRangeException_t1578797820 *)il2cpp_codegen_object_new(IndexOutOfRangeException_t1578797820_il2cpp_TypeInfo_var);
		IndexOutOfRangeException__ctor_m3408750441(L_4, _stringLiteral3966192333, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4,Vector3_get_Item_m668685504_RuntimeMethod_var);
	}

IL_0047:
	{
		float L_5 = V_0;
		return L_5;
	}
}
extern "C"  float Vector3_get_Item_m668685504_AdjustorThunk (RuntimeObject * __this, int32_t ___index0, const RuntimeMethod* method)
{
	Vector3_t3722313464 * _thisAdjusted = reinterpret_cast<Vector3_t3722313464 *>(__this + 1);
	return Vector3_get_Item_m668685504(_thisAdjusted, ___index0, method);
}
// System.Void UnityEngine.Vector3::set_Item(System.Int32,System.Single)
extern "C"  void Vector3_set_Item_m1772472431 (Vector3_t3722313464 * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_set_Item_m1772472431_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___index0;
		switch (L_0)
		{
			case 0:
			{
				goto IL_0018;
			}
			case 1:
			{
				goto IL_0024;
			}
			case 2:
			{
				goto IL_0030;
			}
		}
	}
	{
		goto IL_003c;
	}

IL_0018:
	{
		float L_1 = ___value1;
		__this->set_x_1(L_1);
		goto IL_0047;
	}

IL_0024:
	{
		float L_2 = ___value1;
		__this->set_y_2(L_2);
		goto IL_0047;
	}

IL_0030:
	{
		float L_3 = ___value1;
		__this->set_z_3(L_3);
		goto IL_0047;
	}

IL_003c:
	{
		IndexOutOfRangeException_t1578797820 * L_4 = (IndexOutOfRangeException_t1578797820 *)il2cpp_codegen_object_new(IndexOutOfRangeException_t1578797820_il2cpp_TypeInfo_var);
		IndexOutOfRangeException__ctor_m3408750441(L_4, _stringLiteral3966192333, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_4,Vector3_set_Item_m1772472431_RuntimeMethod_var);
	}

IL_0047:
	{
		return;
	}
}
extern "C"  void Vector3_set_Item_m1772472431_AdjustorThunk (RuntimeObject * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method)
{
	Vector3_t3722313464 * _thisAdjusted = reinterpret_cast<Vector3_t3722313464 *>(__this + 1);
	Vector3_set_Item_m1772472431(_thisAdjusted, ___index0, ___value1, method);
}
// System.Int32 UnityEngine.Vector3::GetHashCode()
extern "C"  int32_t Vector3_GetHashCode_m2879461828 (Vector3_t3722313464 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		float* L_0 = __this->get_address_of_x_1();
		int32_t L_1 = Single_GetHashCode_m1558506138(L_0, /*hidden argument*/NULL);
		float* L_2 = __this->get_address_of_y_2();
		int32_t L_3 = Single_GetHashCode_m1558506138(L_2, /*hidden argument*/NULL);
		float* L_4 = __this->get_address_of_z_3();
		int32_t L_5 = Single_GetHashCode_m1558506138(L_4, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)((int32_t)L_1^(int32_t)((int32_t)((int32_t)L_3<<(int32_t)2))))^(int32_t)((int32_t)((int32_t)L_5>>(int32_t)2))));
		goto IL_0040;
	}

IL_0040:
	{
		int32_t L_6 = V_0;
		return L_6;
	}
}
extern "C"  int32_t Vector3_GetHashCode_m2879461828_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector3_t3722313464 * _thisAdjusted = reinterpret_cast<Vector3_t3722313464 *>(__this + 1);
	return Vector3_GetHashCode_m2879461828(_thisAdjusted, method);
}
// System.Boolean UnityEngine.Vector3::Equals(System.Object)
extern "C"  bool Vector3_Equals_m1753054704 (Vector3_t3722313464 * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_Equals_m1753054704_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	int32_t G_B6_0 = 0;
	{
		RuntimeObject * L_0 = ___other0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_0, Vector3_t3722313464_il2cpp_TypeInfo_var)))
		{
			goto IL_0013;
		}
	}
	{
		V_0 = (bool)0;
		goto IL_0063;
	}

IL_0013:
	{
		RuntimeObject * L_1 = ___other0;
		V_1 = ((*(Vector3_t3722313464 *)((Vector3_t3722313464 *)UnBox(L_1, Vector3_t3722313464_il2cpp_TypeInfo_var))));
		float* L_2 = __this->get_address_of_x_1();
		float L_3 = (&V_1)->get_x_1();
		bool L_4 = Single_Equals_m1601893879(L_2, L_3, /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_005c;
		}
	}
	{
		float* L_5 = __this->get_address_of_y_2();
		float L_6 = (&V_1)->get_y_2();
		bool L_7 = Single_Equals_m1601893879(L_5, L_6, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_005c;
		}
	}
	{
		float* L_8 = __this->get_address_of_z_3();
		float L_9 = (&V_1)->get_z_3();
		bool L_10 = Single_Equals_m1601893879(L_8, L_9, /*hidden argument*/NULL);
		G_B6_0 = ((int32_t)(L_10));
		goto IL_005d;
	}

IL_005c:
	{
		G_B6_0 = 0;
	}

IL_005d:
	{
		V_0 = (bool)G_B6_0;
		goto IL_0063;
	}

IL_0063:
	{
		bool L_11 = V_0;
		return L_11;
	}
}
extern "C"  bool Vector3_Equals_m1753054704_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	Vector3_t3722313464 * _thisAdjusted = reinterpret_cast<Vector3_t3722313464 *>(__this + 1);
	return Vector3_Equals_m1753054704(_thisAdjusted, ___other0, method);
}
// UnityEngine.Vector3 UnityEngine.Vector3::Normalize(UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Vector3_Normalize_m2941713846 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___value0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_Normalize_m2941713846_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	Vector3_t3722313464  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		Vector3_t3722313464  L_0 = ___value0;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		float L_1 = Vector3_Magnitude_m3447562852(NULL /*static, unused*/, L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		float L_2 = V_0;
		if ((!(((float)L_2) > ((float)(1.0E-05f)))))
		{
			goto IL_0020;
		}
	}
	{
		Vector3_t3722313464  L_3 = ___value0;
		float L_4 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_5 = Vector3_op_Division_m510815599(NULL /*static, unused*/, L_3, L_4, /*hidden argument*/NULL);
		V_1 = L_5;
		goto IL_002b;
	}

IL_0020:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_6 = Vector3_get_zero_m1409827619(NULL /*static, unused*/, /*hidden argument*/NULL);
		V_1 = L_6;
		goto IL_002b;
	}

IL_002b:
	{
		Vector3_t3722313464  L_7 = V_1;
		return L_7;
	}
}
// System.Void UnityEngine.Vector3::Normalize()
extern "C"  void Vector3_Normalize_m914904454 (Vector3_t3722313464 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_Normalize_m914904454_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		float L_0 = Vector3_Magnitude_m3447562852(NULL /*static, unused*/, (*(Vector3_t3722313464 *)__this), /*hidden argument*/NULL);
		V_0 = L_0;
		float L_1 = V_0;
		if ((!(((float)L_1) > ((float)(1.0E-05f)))))
		{
			goto IL_002f;
		}
	}
	{
		float L_2 = V_0;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_3 = Vector3_op_Division_m510815599(NULL /*static, unused*/, (*(Vector3_t3722313464 *)__this), L_2, /*hidden argument*/NULL);
		*(Vector3_t3722313464 *)__this = L_3;
		goto IL_003a;
	}

IL_002f:
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_4 = Vector3_get_zero_m1409827619(NULL /*static, unused*/, /*hidden argument*/NULL);
		*(Vector3_t3722313464 *)__this = L_4;
	}

IL_003a:
	{
		return;
	}
}
extern "C"  void Vector3_Normalize_m914904454_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector3_t3722313464 * _thisAdjusted = reinterpret_cast<Vector3_t3722313464 *>(__this + 1);
	Vector3_Normalize_m914904454(_thisAdjusted, method);
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_normalized()
extern "C"  Vector3_t3722313464  Vector3_get_normalized_m2454957984 (Vector3_t3722313464 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_get_normalized_m2454957984_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_0 = Vector3_Normalize_m2941713846(NULL /*static, unused*/, (*(Vector3_t3722313464 *)__this), /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_0012;
	}

IL_0012:
	{
		Vector3_t3722313464  L_1 = V_0;
		return L_1;
	}
}
extern "C"  Vector3_t3722313464  Vector3_get_normalized_m2454957984_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector3_t3722313464 * _thisAdjusted = reinterpret_cast<Vector3_t3722313464 *>(__this + 1);
	return Vector3_get_normalized_m2454957984(_thisAdjusted, method);
}
// System.Single UnityEngine.Vector3::Dot(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  float Vector3_Dot_m606404487 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___lhs0, Vector3_t3722313464  ___rhs1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = (&___lhs0)->get_x_1();
		float L_1 = (&___rhs1)->get_x_1();
		float L_2 = (&___lhs0)->get_y_2();
		float L_3 = (&___rhs1)->get_y_2();
		float L_4 = (&___lhs0)->get_z_3();
		float L_5 = (&___rhs1)->get_z_3();
		V_0 = ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), (float)((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)))), (float)((float)il2cpp_codegen_multiply((float)L_4, (float)L_5))));
		goto IL_0036;
	}

IL_0036:
	{
		float L_6 = V_0;
		return L_6;
	}
}
// System.Single UnityEngine.Vector3::Distance(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  float Vector3_Distance_m886789632 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___a0, Vector3_t3722313464  ___b1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_Distance_m886789632_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	float V_1 = 0.0f;
	{
		float L_0 = (&___a0)->get_x_1();
		float L_1 = (&___b1)->get_x_1();
		float L_2 = (&___a0)->get_y_2();
		float L_3 = (&___b1)->get_y_2();
		float L_4 = (&___a0)->get_z_3();
		float L_5 = (&___b1)->get_z_3();
		Vector3__ctor_m3353183577((&V_0), ((float)il2cpp_codegen_subtract((float)L_0, (float)L_1)), ((float)il2cpp_codegen_subtract((float)L_2, (float)L_3)), ((float)il2cpp_codegen_subtract((float)L_4, (float)L_5)), /*hidden argument*/NULL);
		float L_6 = (&V_0)->get_x_1();
		float L_7 = (&V_0)->get_x_1();
		float L_8 = (&V_0)->get_y_2();
		float L_9 = (&V_0)->get_y_2();
		float L_10 = (&V_0)->get_z_3();
		float L_11 = (&V_0)->get_z_3();
		IL2CPP_RUNTIME_CLASS_INIT(Mathf_t3464937446_il2cpp_TypeInfo_var);
		float L_12 = sqrtf(((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_6, (float)L_7)), (float)((float)il2cpp_codegen_multiply((float)L_8, (float)L_9)))), (float)((float)il2cpp_codegen_multiply((float)L_10, (float)L_11)))));
		V_1 = L_12;
		goto IL_006f;
	}

IL_006f:
	{
		float L_13 = V_1;
		return L_13;
	}
}
// System.Single UnityEngine.Vector3::Magnitude(UnityEngine.Vector3)
extern "C"  float Vector3_Magnitude_m3447562852 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___vector0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_Magnitude_m3447562852_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		float L_0 = (&___vector0)->get_x_1();
		float L_1 = (&___vector0)->get_x_1();
		float L_2 = (&___vector0)->get_y_2();
		float L_3 = (&___vector0)->get_y_2();
		float L_4 = (&___vector0)->get_z_3();
		float L_5 = (&___vector0)->get_z_3();
		IL2CPP_RUNTIME_CLASS_INIT(Mathf_t3464937446_il2cpp_TypeInfo_var);
		float L_6 = sqrtf(((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), (float)((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)))), (float)((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)))));
		V_0 = L_6;
		goto IL_003b;
	}

IL_003b:
	{
		float L_7 = V_0;
		return L_7;
	}
}
// System.Single UnityEngine.Vector3::get_magnitude()
extern "C"  float Vector3_get_magnitude_m27958459 (Vector3_t3722313464 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_get_magnitude_m27958459_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_x_1();
		float L_1 = __this->get_x_1();
		float L_2 = __this->get_y_2();
		float L_3 = __this->get_y_2();
		float L_4 = __this->get_z_3();
		float L_5 = __this->get_z_3();
		IL2CPP_RUNTIME_CLASS_INIT(Mathf_t3464937446_il2cpp_TypeInfo_var);
		float L_6 = sqrtf(((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), (float)((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)))), (float)((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)))));
		V_0 = L_6;
		goto IL_0035;
	}

IL_0035:
	{
		float L_7 = V_0;
		return L_7;
	}
}
extern "C"  float Vector3_get_magnitude_m27958459_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector3_t3722313464 * _thisAdjusted = reinterpret_cast<Vector3_t3722313464 *>(__this + 1);
	return Vector3_get_magnitude_m27958459(_thisAdjusted, method);
}
// System.Single UnityEngine.Vector3::SqrMagnitude(UnityEngine.Vector3)
extern "C"  float Vector3_SqrMagnitude_m3025115945 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___vector0, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = (&___vector0)->get_x_1();
		float L_1 = (&___vector0)->get_x_1();
		float L_2 = (&___vector0)->get_y_2();
		float L_3 = (&___vector0)->get_y_2();
		float L_4 = (&___vector0)->get_z_3();
		float L_5 = (&___vector0)->get_z_3();
		V_0 = ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), (float)((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)))), (float)((float)il2cpp_codegen_multiply((float)L_4, (float)L_5))));
		goto IL_0036;
	}

IL_0036:
	{
		float L_6 = V_0;
		return L_6;
	}
}
// System.Single UnityEngine.Vector3::get_sqrMagnitude()
extern "C"  float Vector3_get_sqrMagnitude_m1474274574 (Vector3_t3722313464 * __this, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = __this->get_x_1();
		float L_1 = __this->get_x_1();
		float L_2 = __this->get_y_2();
		float L_3 = __this->get_y_2();
		float L_4 = __this->get_z_3();
		float L_5 = __this->get_z_3();
		V_0 = ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), (float)((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)))), (float)((float)il2cpp_codegen_multiply((float)L_4, (float)L_5))));
		goto IL_0030;
	}

IL_0030:
	{
		float L_6 = V_0;
		return L_6;
	}
}
extern "C"  float Vector3_get_sqrMagnitude_m1474274574_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector3_t3722313464 * _thisAdjusted = reinterpret_cast<Vector3_t3722313464 *>(__this + 1);
	return Vector3_get_sqrMagnitude_m1474274574(_thisAdjusted, method);
}
// UnityEngine.Vector3 UnityEngine.Vector3::Min(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Vector3_Min_m1803158933 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___lhs0, Vector3_t3722313464  ___rhs1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_Min_m1803158933_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___lhs0)->get_x_1();
		float L_1 = (&___rhs1)->get_x_1();
		IL2CPP_RUNTIME_CLASS_INIT(Mathf_t3464937446_il2cpp_TypeInfo_var);
		float L_2 = Mathf_Min_m1073399594(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		float L_3 = (&___lhs0)->get_y_2();
		float L_4 = (&___rhs1)->get_y_2();
		float L_5 = Mathf_Min_m1073399594(NULL /*static, unused*/, L_3, L_4, /*hidden argument*/NULL);
		float L_6 = (&___lhs0)->get_z_3();
		float L_7 = (&___rhs1)->get_z_3();
		float L_8 = Mathf_Min_m1073399594(NULL /*static, unused*/, L_6, L_7, /*hidden argument*/NULL);
		Vector3_t3722313464  L_9;
		memset(&L_9, 0, sizeof(L_9));
		Vector3__ctor_m3353183577((&L_9), L_2, L_5, L_8, /*hidden argument*/NULL);
		V_0 = L_9;
		goto IL_0045;
	}

IL_0045:
	{
		Vector3_t3722313464  L_10 = V_0;
		return L_10;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::Max(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Vector3_Max_m3304052994 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___lhs0, Vector3_t3722313464  ___rhs1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_Max_m3304052994_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___lhs0)->get_x_1();
		float L_1 = (&___rhs1)->get_x_1();
		IL2CPP_RUNTIME_CLASS_INIT(Mathf_t3464937446_il2cpp_TypeInfo_var);
		float L_2 = Mathf_Max_m3146388979(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		float L_3 = (&___lhs0)->get_y_2();
		float L_4 = (&___rhs1)->get_y_2();
		float L_5 = Mathf_Max_m3146388979(NULL /*static, unused*/, L_3, L_4, /*hidden argument*/NULL);
		float L_6 = (&___lhs0)->get_z_3();
		float L_7 = (&___rhs1)->get_z_3();
		float L_8 = Mathf_Max_m3146388979(NULL /*static, unused*/, L_6, L_7, /*hidden argument*/NULL);
		Vector3_t3722313464  L_9;
		memset(&L_9, 0, sizeof(L_9));
		Vector3__ctor_m3353183577((&L_9), L_2, L_5, L_8, /*hidden argument*/NULL);
		V_0 = L_9;
		goto IL_0045;
	}

IL_0045:
	{
		Vector3_t3722313464  L_10 = V_0;
		return L_10;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_zero()
extern "C"  Vector3_t3722313464  Vector3_get_zero_m1409827619 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_get_zero_m1409827619_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_0 = ((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->get_zeroVector_4();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector3_t3722313464  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_one()
extern "C"  Vector3_t3722313464  Vector3_get_one_m1629952498 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_get_one_m1629952498_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_0 = ((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->get_oneVector_5();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector3_t3722313464  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_forward()
extern "C"  Vector3_t3722313464  Vector3_get_forward_m3100859705 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_get_forward_m3100859705_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_0 = ((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->get_forwardVector_10();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector3_t3722313464  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_back()
extern "C"  Vector3_t3722313464  Vector3_get_back_m4077847766 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_get_back_m4077847766_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_0 = ((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->get_backVector_11();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector3_t3722313464  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_up()
extern "C"  Vector3_t3722313464  Vector3_get_up_m3584168373 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_get_up_m3584168373_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_0 = ((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->get_upVector_6();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector3_t3722313464  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_down()
extern "C"  Vector3_t3722313464  Vector3_get_down_m3781355428 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_get_down_m3781355428_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_0 = ((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->get_downVector_7();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector3_t3722313464  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_left()
extern "C"  Vector3_t3722313464  Vector3_get_left_m2428419009 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_get_left_m2428419009_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_0 = ((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->get_leftVector_8();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector3_t3722313464  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::get_right()
extern "C"  Vector3_t3722313464  Vector3_get_right_m1913784872 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_get_right_m1913784872_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_0 = ((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->get_rightVector_9();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector3_t3722313464  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::op_Addition(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Vector3_op_Addition_m779775034 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___a0, Vector3_t3722313464  ___b1, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___a0)->get_x_1();
		float L_1 = (&___b1)->get_x_1();
		float L_2 = (&___a0)->get_y_2();
		float L_3 = (&___b1)->get_y_2();
		float L_4 = (&___a0)->get_z_3();
		float L_5 = (&___b1)->get_z_3();
		Vector3_t3722313464  L_6;
		memset(&L_6, 0, sizeof(L_6));
		Vector3__ctor_m3353183577((&L_6), ((float)il2cpp_codegen_add((float)L_0, (float)L_1)), ((float)il2cpp_codegen_add((float)L_2, (float)L_3)), ((float)il2cpp_codegen_add((float)L_4, (float)L_5)), /*hidden argument*/NULL);
		V_0 = L_6;
		goto IL_0039;
	}

IL_0039:
	{
		Vector3_t3722313464  L_7 = V_0;
		return L_7;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::op_Subtraction(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  Vector3_t3722313464  Vector3_op_Subtraction_m3073674971 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___a0, Vector3_t3722313464  ___b1, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___a0)->get_x_1();
		float L_1 = (&___b1)->get_x_1();
		float L_2 = (&___a0)->get_y_2();
		float L_3 = (&___b1)->get_y_2();
		float L_4 = (&___a0)->get_z_3();
		float L_5 = (&___b1)->get_z_3();
		Vector3_t3722313464  L_6;
		memset(&L_6, 0, sizeof(L_6));
		Vector3__ctor_m3353183577((&L_6), ((float)il2cpp_codegen_subtract((float)L_0, (float)L_1)), ((float)il2cpp_codegen_subtract((float)L_2, (float)L_3)), ((float)il2cpp_codegen_subtract((float)L_4, (float)L_5)), /*hidden argument*/NULL);
		V_0 = L_6;
		goto IL_0039;
	}

IL_0039:
	{
		Vector3_t3722313464  L_7 = V_0;
		return L_7;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::op_Multiply(UnityEngine.Vector3,System.Single)
extern "C"  Vector3_t3722313464  Vector3_op_Multiply_m3376773913 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___a0, float ___d1, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___a0)->get_x_1();
		float L_1 = ___d1;
		float L_2 = (&___a0)->get_y_2();
		float L_3 = ___d1;
		float L_4 = (&___a0)->get_z_3();
		float L_5 = ___d1;
		Vector3_t3722313464  L_6;
		memset(&L_6, 0, sizeof(L_6));
		Vector3__ctor_m3353183577((&L_6), ((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), ((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)), ((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)), /*hidden argument*/NULL);
		V_0 = L_6;
		goto IL_0027;
	}

IL_0027:
	{
		Vector3_t3722313464  L_7 = V_0;
		return L_7;
	}
}
// UnityEngine.Vector3 UnityEngine.Vector3::op_Division(UnityEngine.Vector3,System.Single)
extern "C"  Vector3_t3722313464  Vector3_op_Division_m510815599 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___a0, float ___d1, const RuntimeMethod* method)
{
	Vector3_t3722313464  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___a0)->get_x_1();
		float L_1 = ___d1;
		float L_2 = (&___a0)->get_y_2();
		float L_3 = ___d1;
		float L_4 = (&___a0)->get_z_3();
		float L_5 = ___d1;
		Vector3_t3722313464  L_6;
		memset(&L_6, 0, sizeof(L_6));
		Vector3__ctor_m3353183577((&L_6), ((float)((float)L_0/(float)L_1)), ((float)((float)L_2/(float)L_3)), ((float)((float)L_4/(float)L_5)), /*hidden argument*/NULL);
		V_0 = L_6;
		goto IL_0027;
	}

IL_0027:
	{
		Vector3_t3722313464  L_7 = V_0;
		return L_7;
	}
}
// System.Boolean UnityEngine.Vector3::op_Equality(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  bool Vector3_op_Equality_m4231250055 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___lhs0, Vector3_t3722313464  ___rhs1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_op_Equality_m4231250055_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		Vector3_t3722313464  L_0 = ___lhs0;
		Vector3_t3722313464  L_1 = ___rhs1;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		Vector3_t3722313464  L_2 = Vector3_op_Subtraction_m3073674971(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		float L_3 = Vector3_SqrMagnitude_m3025115945(NULL /*static, unused*/, L_2, /*hidden argument*/NULL);
		V_0 = (bool)((((float)L_3) < ((float)(9.99999944E-11f)))? 1 : 0);
		goto IL_001a;
	}

IL_001a:
	{
		bool L_4 = V_0;
		return L_4;
	}
}
// System.Boolean UnityEngine.Vector3::op_Inequality(UnityEngine.Vector3,UnityEngine.Vector3)
extern "C"  bool Vector3_op_Inequality_m315980366 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___lhs0, Vector3_t3722313464  ___rhs1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_op_Inequality_m315980366_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		Vector3_t3722313464  L_0 = ___lhs0;
		Vector3_t3722313464  L_1 = ___rhs1;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3_t3722313464_il2cpp_TypeInfo_var);
		bool L_2 = Vector3_op_Equality_m4231250055(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		V_0 = (bool)((((int32_t)L_2) == ((int32_t)0))? 1 : 0);
		goto IL_0011;
	}

IL_0011:
	{
		bool L_3 = V_0;
		return L_3;
	}
}
// System.String UnityEngine.Vector3::ToString()
extern "C"  String_t* Vector3_ToString_m759076600 (Vector3_t3722313464 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3_ToString_m759076600_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		ObjectU5BU5D_t2843939325* L_0 = ((ObjectU5BU5D_t2843939325*)SZArrayNew(ObjectU5BU5D_t2843939325_il2cpp_TypeInfo_var, (uint32_t)3));
		float L_1 = __this->get_x_1();
		float L_2 = L_1;
		RuntimeObject * L_3 = Box(Single_t1397266774_il2cpp_TypeInfo_var, &L_2);
		ArrayElementTypeCheck (L_0, L_3);
		(L_0)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_3);
		ObjectU5BU5D_t2843939325* L_4 = L_0;
		float L_5 = __this->get_y_2();
		float L_6 = L_5;
		RuntimeObject * L_7 = Box(Single_t1397266774_il2cpp_TypeInfo_var, &L_6);
		ArrayElementTypeCheck (L_4, L_7);
		(L_4)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_7);
		ObjectU5BU5D_t2843939325* L_8 = L_4;
		float L_9 = __this->get_z_3();
		float L_10 = L_9;
		RuntimeObject * L_11 = Box(Single_t1397266774_il2cpp_TypeInfo_var, &L_10);
		ArrayElementTypeCheck (L_8, L_11);
		(L_8)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_11);
		String_t* L_12 = UnityString_Format_m261690510(NULL /*static, unused*/, _stringLiteral122510266, L_8, /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0041;
	}

IL_0041:
	{
		String_t* L_13 = V_0;
		return L_13;
	}
}
extern "C"  String_t* Vector3_ToString_m759076600_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector3_t3722313464 * _thisAdjusted = reinterpret_cast<Vector3_t3722313464 *>(__this + 1);
	return Vector3_ToString_m759076600(_thisAdjusted, method);
}
// System.Void UnityEngine.Vector3::.cctor()
extern "C"  void Vector3__cctor_m2599650684 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3__cctor_m2599650684_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Vector3_t3722313464  L_0;
		memset(&L_0, 0, sizeof(L_0));
		Vector3__ctor_m3353183577((&L_0), (0.0f), (0.0f), (0.0f), /*hidden argument*/NULL);
		((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->set_zeroVector_4(L_0);
		Vector3_t3722313464  L_1;
		memset(&L_1, 0, sizeof(L_1));
		Vector3__ctor_m3353183577((&L_1), (1.0f), (1.0f), (1.0f), /*hidden argument*/NULL);
		((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->set_oneVector_5(L_1);
		Vector3_t3722313464  L_2;
		memset(&L_2, 0, sizeof(L_2));
		Vector3__ctor_m3353183577((&L_2), (0.0f), (1.0f), (0.0f), /*hidden argument*/NULL);
		((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->set_upVector_6(L_2);
		Vector3_t3722313464  L_3;
		memset(&L_3, 0, sizeof(L_3));
		Vector3__ctor_m3353183577((&L_3), (0.0f), (-1.0f), (0.0f), /*hidden argument*/NULL);
		((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->set_downVector_7(L_3);
		Vector3_t3722313464  L_4;
		memset(&L_4, 0, sizeof(L_4));
		Vector3__ctor_m3353183577((&L_4), (-1.0f), (0.0f), (0.0f), /*hidden argument*/NULL);
		((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->set_leftVector_8(L_4);
		Vector3_t3722313464  L_5;
		memset(&L_5, 0, sizeof(L_5));
		Vector3__ctor_m3353183577((&L_5), (1.0f), (0.0f), (0.0f), /*hidden argument*/NULL);
		((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->set_rightVector_9(L_5);
		Vector3_t3722313464  L_6;
		memset(&L_6, 0, sizeof(L_6));
		Vector3__ctor_m3353183577((&L_6), (0.0f), (0.0f), (1.0f), /*hidden argument*/NULL);
		((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->set_forwardVector_10(L_6);
		Vector3_t3722313464  L_7;
		memset(&L_7, 0, sizeof(L_7));
		Vector3__ctor_m3353183577((&L_7), (0.0f), (0.0f), (-1.0f), /*hidden argument*/NULL);
		((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->set_backVector_11(L_7);
		Vector3_t3722313464  L_8;
		memset(&L_8, 0, sizeof(L_8));
		Vector3__ctor_m3353183577((&L_8), (std::numeric_limits<float>::infinity()), (std::numeric_limits<float>::infinity()), (std::numeric_limits<float>::infinity()), /*hidden argument*/NULL);
		((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->set_positiveInfinityVector_12(L_8);
		Vector3_t3722313464  L_9;
		memset(&L_9, 0, sizeof(L_9));
		Vector3__ctor_m3353183577((&L_9), (-std::numeric_limits<float>::infinity()), (-std::numeric_limits<float>::infinity()), (-std::numeric_limits<float>::infinity()), /*hidden argument*/NULL);
		((Vector3_t3722313464_StaticFields*)il2cpp_codegen_static_fields_for(Vector3_t3722313464_il2cpp_TypeInfo_var))->set_negativeInfinityVector_13(L_9);
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
// System.Void UnityEngine.Vector3Int::.ctor(System.Int32,System.Int32,System.Int32)
extern "C"  void Vector3Int__ctor_m2885707673 (Vector3Int_t741115188 * __this, int32_t ___x0, int32_t ___y1, int32_t ___z2, const RuntimeMethod* method)
{
	{
		int32_t L_0 = ___x0;
		__this->set_m_X_0(L_0);
		int32_t L_1 = ___y1;
		__this->set_m_Y_1(L_1);
		int32_t L_2 = ___z2;
		__this->set_m_Z_2(L_2);
		return;
	}
}
extern "C"  void Vector3Int__ctor_m2885707673_AdjustorThunk (RuntimeObject * __this, int32_t ___x0, int32_t ___y1, int32_t ___z2, const RuntimeMethod* method)
{
	Vector3Int_t741115188 * _thisAdjusted = reinterpret_cast<Vector3Int_t741115188 *>(__this + 1);
	Vector3Int__ctor_m2885707673(_thisAdjusted, ___x0, ___y1, ___z2, method);
}
// System.Int32 UnityEngine.Vector3Int::get_x()
extern "C"  int32_t Vector3Int_get_x_m3022184941 (Vector3Int_t741115188 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_X_0();
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
extern "C"  int32_t Vector3Int_get_x_m3022184941_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector3Int_t741115188 * _thisAdjusted = reinterpret_cast<Vector3Int_t741115188 *>(__this + 1);
	return Vector3Int_get_x_m3022184941(_thisAdjusted, method);
}
// System.Int32 UnityEngine.Vector3Int::get_y()
extern "C"  int32_t Vector3Int_get_y_m3022184942 (Vector3Int_t741115188 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_Y_1();
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
extern "C"  int32_t Vector3Int_get_y_m3022184942_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector3Int_t741115188 * _thisAdjusted = reinterpret_cast<Vector3Int_t741115188 *>(__this + 1);
	return Vector3Int_get_y_m3022184942(_thisAdjusted, method);
}
// System.Int32 UnityEngine.Vector3Int::get_z()
extern "C"  int32_t Vector3Int_get_z_m3022184939 (Vector3Int_t741115188 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		int32_t L_0 = __this->get_m_Z_2();
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		int32_t L_1 = V_0;
		return L_1;
	}
}
extern "C"  int32_t Vector3Int_get_z_m3022184939_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector3Int_t741115188 * _thisAdjusted = reinterpret_cast<Vector3Int_t741115188 *>(__this + 1);
	return Vector3Int_get_z_m3022184939(_thisAdjusted, method);
}
// System.Boolean UnityEngine.Vector3Int::op_Equality(UnityEngine.Vector3Int,UnityEngine.Vector3Int)
extern "C"  bool Vector3Int_op_Equality_m4107634402 (RuntimeObject * __this /* static, unused */, Vector3Int_t741115188  ___lhs0, Vector3Int_t741115188  ___rhs1, const RuntimeMethod* method)
{
	bool V_0 = false;
	int32_t G_B4_0 = 0;
	{
		int32_t L_0 = Vector3Int_get_x_m3022184941((&___lhs0), /*hidden argument*/NULL);
		int32_t L_1 = Vector3Int_get_x_m3022184941((&___rhs1), /*hidden argument*/NULL);
		if ((!(((uint32_t)L_0) == ((uint32_t)L_1))))
		{
			goto IL_0039;
		}
	}
	{
		int32_t L_2 = Vector3Int_get_y_m3022184942((&___lhs0), /*hidden argument*/NULL);
		int32_t L_3 = Vector3Int_get_y_m3022184942((&___rhs1), /*hidden argument*/NULL);
		if ((!(((uint32_t)L_2) == ((uint32_t)L_3))))
		{
			goto IL_0039;
		}
	}
	{
		int32_t L_4 = Vector3Int_get_z_m3022184939((&___lhs0), /*hidden argument*/NULL);
		int32_t L_5 = Vector3Int_get_z_m3022184939((&___rhs1), /*hidden argument*/NULL);
		G_B4_0 = ((((int32_t)L_4) == ((int32_t)L_5))? 1 : 0);
		goto IL_003a;
	}

IL_0039:
	{
		G_B4_0 = 0;
	}

IL_003a:
	{
		V_0 = (bool)G_B4_0;
		goto IL_0040;
	}

IL_0040:
	{
		bool L_6 = V_0;
		return L_6;
	}
}
// System.Boolean UnityEngine.Vector3Int::Equals(System.Object)
extern "C"  bool Vector3Int_Equals_m1306183009 (Vector3Int_t741115188 * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3Int_Equals_m1306183009_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	Vector3Int_t741115188  V_1;
	memset(&V_1, 0, sizeof(V_1));
	{
		RuntimeObject * L_0 = ___other0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_0, Vector3Int_t741115188_il2cpp_TypeInfo_var)))
		{
			goto IL_0013;
		}
	}
	{
		V_0 = (bool)0;
		goto IL_002c;
	}

IL_0013:
	{
		RuntimeObject * L_1 = ___other0;
		V_1 = ((*(Vector3Int_t741115188 *)((Vector3Int_t741115188 *)UnBox(L_1, Vector3Int_t741115188_il2cpp_TypeInfo_var))));
		Vector3Int_t741115188  L_2 = V_1;
		IL2CPP_RUNTIME_CLASS_INIT(Vector3Int_t741115188_il2cpp_TypeInfo_var);
		bool L_3 = Vector3Int_op_Equality_m4107634402(NULL /*static, unused*/, (*(Vector3Int_t741115188 *)__this), L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_002c;
	}

IL_002c:
	{
		bool L_4 = V_0;
		return L_4;
	}
}
extern "C"  bool Vector3Int_Equals_m1306183009_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	Vector3Int_t741115188 * _thisAdjusted = reinterpret_cast<Vector3Int_t741115188 *>(__this + 1);
	return Vector3Int_Equals_m1306183009(_thisAdjusted, ___other0, method);
}
// System.Int32 UnityEngine.Vector3Int::GetHashCode()
extern "C"  int32_t Vector3Int_GetHashCode_m59183038 (Vector3Int_t741115188 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	int32_t V_1 = 0;
	int32_t V_2 = 0;
	int32_t V_3 = 0;
	{
		int32_t L_0 = Vector3Int_get_x_m3022184941(__this, /*hidden argument*/NULL);
		V_0 = L_0;
		int32_t L_1 = Int32_GetHashCode_m1876651407((&V_0), /*hidden argument*/NULL);
		int32_t L_2 = Vector3Int_get_y_m3022184942(__this, /*hidden argument*/NULL);
		V_1 = L_2;
		int32_t L_3 = Int32_GetHashCode_m1876651407((&V_1), /*hidden argument*/NULL);
		int32_t L_4 = Vector3Int_get_z_m3022184939(__this, /*hidden argument*/NULL);
		V_2 = L_4;
		int32_t L_5 = Int32_GetHashCode_m1876651407((&V_2), /*hidden argument*/NULL);
		V_3 = ((int32_t)((int32_t)((int32_t)((int32_t)L_1^(int32_t)((int32_t)((int32_t)L_3<<(int32_t)2))))^(int32_t)((int32_t)((int32_t)L_5>>(int32_t)2))));
		goto IL_0049;
	}

IL_0049:
	{
		int32_t L_6 = V_3;
		return L_6;
	}
}
extern "C"  int32_t Vector3Int_GetHashCode_m59183038_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector3Int_t741115188 * _thisAdjusted = reinterpret_cast<Vector3Int_t741115188 *>(__this + 1);
	return Vector3Int_GetHashCode_m59183038(_thisAdjusted, method);
}
// System.String UnityEngine.Vector3Int::ToString()
extern "C"  String_t* Vector3Int_ToString_m3033835977 (Vector3Int_t741115188 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3Int_ToString_m3033835977_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		ObjectU5BU5D_t2843939325* L_0 = ((ObjectU5BU5D_t2843939325*)SZArrayNew(ObjectU5BU5D_t2843939325_il2cpp_TypeInfo_var, (uint32_t)3));
		int32_t L_1 = Vector3Int_get_x_m3022184941(__this, /*hidden argument*/NULL);
		int32_t L_2 = L_1;
		RuntimeObject * L_3 = Box(Int32_t2950945753_il2cpp_TypeInfo_var, &L_2);
		ArrayElementTypeCheck (L_0, L_3);
		(L_0)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_3);
		ObjectU5BU5D_t2843939325* L_4 = L_0;
		int32_t L_5 = Vector3Int_get_y_m3022184942(__this, /*hidden argument*/NULL);
		int32_t L_6 = L_5;
		RuntimeObject * L_7 = Box(Int32_t2950945753_il2cpp_TypeInfo_var, &L_6);
		ArrayElementTypeCheck (L_4, L_7);
		(L_4)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_7);
		ObjectU5BU5D_t2843939325* L_8 = L_4;
		int32_t L_9 = Vector3Int_get_z_m3022184939(__this, /*hidden argument*/NULL);
		int32_t L_10 = L_9;
		RuntimeObject * L_11 = Box(Int32_t2950945753_il2cpp_TypeInfo_var, &L_10);
		ArrayElementTypeCheck (L_8, L_11);
		(L_8)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_11);
		String_t* L_12 = UnityString_Format_m261690510(NULL /*static, unused*/, _stringLiteral341909834, L_8, /*hidden argument*/NULL);
		V_0 = L_12;
		goto IL_0041;
	}

IL_0041:
	{
		String_t* L_13 = V_0;
		return L_13;
	}
}
extern "C"  String_t* Vector3Int_ToString_m3033835977_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector3Int_t741115188 * _thisAdjusted = reinterpret_cast<Vector3Int_t741115188 *>(__this + 1);
	return Vector3Int_ToString_m3033835977(_thisAdjusted, method);
}
// System.Void UnityEngine.Vector3Int::.cctor()
extern "C"  void Vector3Int__cctor_m1057449852 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector3Int__cctor_m1057449852_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Vector3Int_t741115188  L_0;
		memset(&L_0, 0, sizeof(L_0));
		Vector3Int__ctor_m2885707673((&L_0), 0, 0, 0, /*hidden argument*/NULL);
		((Vector3Int_t741115188_StaticFields*)il2cpp_codegen_static_fields_for(Vector3Int_t741115188_il2cpp_TypeInfo_var))->set_s_Zero_3(L_0);
		Vector3Int_t741115188  L_1;
		memset(&L_1, 0, sizeof(L_1));
		Vector3Int__ctor_m2885707673((&L_1), 1, 1, 1, /*hidden argument*/NULL);
		((Vector3Int_t741115188_StaticFields*)il2cpp_codegen_static_fields_for(Vector3Int_t741115188_il2cpp_TypeInfo_var))->set_s_One_4(L_1);
		Vector3Int_t741115188  L_2;
		memset(&L_2, 0, sizeof(L_2));
		Vector3Int__ctor_m2885707673((&L_2), 0, 1, 0, /*hidden argument*/NULL);
		((Vector3Int_t741115188_StaticFields*)il2cpp_codegen_static_fields_for(Vector3Int_t741115188_il2cpp_TypeInfo_var))->set_s_Up_5(L_2);
		Vector3Int_t741115188  L_3;
		memset(&L_3, 0, sizeof(L_3));
		Vector3Int__ctor_m2885707673((&L_3), 0, (-1), 0, /*hidden argument*/NULL);
		((Vector3Int_t741115188_StaticFields*)il2cpp_codegen_static_fields_for(Vector3Int_t741115188_il2cpp_TypeInfo_var))->set_s_Down_6(L_3);
		Vector3Int_t741115188  L_4;
		memset(&L_4, 0, sizeof(L_4));
		Vector3Int__ctor_m2885707673((&L_4), (-1), 0, 0, /*hidden argument*/NULL);
		((Vector3Int_t741115188_StaticFields*)il2cpp_codegen_static_fields_for(Vector3Int_t741115188_il2cpp_TypeInfo_var))->set_s_Left_7(L_4);
		Vector3Int_t741115188  L_5;
		memset(&L_5, 0, sizeof(L_5));
		Vector3Int__ctor_m2885707673((&L_5), 1, 0, 0, /*hidden argument*/NULL);
		((Vector3Int_t741115188_StaticFields*)il2cpp_codegen_static_fields_for(Vector3Int_t741115188_il2cpp_TypeInfo_var))->set_s_Right_8(L_5);
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
// System.Void UnityEngine.Vector4::.ctor(System.Single,System.Single,System.Single,System.Single)
extern "C"  void Vector4__ctor_m2498754347 (Vector4_t3319028937 * __this, float ___x0, float ___y1, float ___z2, float ___w3, const RuntimeMethod* method)
{
	{
		float L_0 = ___x0;
		__this->set_x_1(L_0);
		float L_1 = ___y1;
		__this->set_y_2(L_1);
		float L_2 = ___z2;
		__this->set_z_3(L_2);
		float L_3 = ___w3;
		__this->set_w_4(L_3);
		return;
	}
}
extern "C"  void Vector4__ctor_m2498754347_AdjustorThunk (RuntimeObject * __this, float ___x0, float ___y1, float ___z2, float ___w3, const RuntimeMethod* method)
{
	Vector4_t3319028937 * _thisAdjusted = reinterpret_cast<Vector4_t3319028937 *>(__this + 1);
	Vector4__ctor_m2498754347(_thisAdjusted, ___x0, ___y1, ___z2, ___w3, method);
}
// System.Single UnityEngine.Vector4::get_Item(System.Int32)
extern "C"  float Vector4_get_Item_m2380866393 (Vector4_t3319028937 * __this, int32_t ___index0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector4_get_Item_m2380866393_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		int32_t L_0 = ___index0;
		switch (L_0)
		{
			case 0:
			{
				goto IL_001c;
			}
			case 1:
			{
				goto IL_0028;
			}
			case 2:
			{
				goto IL_0034;
			}
			case 3:
			{
				goto IL_0040;
			}
		}
	}
	{
		goto IL_004c;
	}

IL_001c:
	{
		float L_1 = __this->get_x_1();
		V_0 = L_1;
		goto IL_0057;
	}

IL_0028:
	{
		float L_2 = __this->get_y_2();
		V_0 = L_2;
		goto IL_0057;
	}

IL_0034:
	{
		float L_3 = __this->get_z_3();
		V_0 = L_3;
		goto IL_0057;
	}

IL_0040:
	{
		float L_4 = __this->get_w_4();
		V_0 = L_4;
		goto IL_0057;
	}

IL_004c:
	{
		IndexOutOfRangeException_t1578797820 * L_5 = (IndexOutOfRangeException_t1578797820 *)il2cpp_codegen_object_new(IndexOutOfRangeException_t1578797820_il2cpp_TypeInfo_var);
		IndexOutOfRangeException__ctor_m3408750441(L_5, _stringLiteral2104486960, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5,Vector4_get_Item_m2380866393_RuntimeMethod_var);
	}

IL_0057:
	{
		float L_6 = V_0;
		return L_6;
	}
}
extern "C"  float Vector4_get_Item_m2380866393_AdjustorThunk (RuntimeObject * __this, int32_t ___index0, const RuntimeMethod* method)
{
	Vector4_t3319028937 * _thisAdjusted = reinterpret_cast<Vector4_t3319028937 *>(__this + 1);
	return Vector4_get_Item_m2380866393(_thisAdjusted, ___index0, method);
}
// System.Void UnityEngine.Vector4::set_Item(System.Int32,System.Single)
extern "C"  void Vector4_set_Item_m1183742235 (Vector4_t3319028937 * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector4_set_Item_m1183742235_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		int32_t L_0 = ___index0;
		switch (L_0)
		{
			case 0:
			{
				goto IL_001c;
			}
			case 1:
			{
				goto IL_0028;
			}
			case 2:
			{
				goto IL_0034;
			}
			case 3:
			{
				goto IL_0040;
			}
		}
	}
	{
		goto IL_004c;
	}

IL_001c:
	{
		float L_1 = ___value1;
		__this->set_x_1(L_1);
		goto IL_0057;
	}

IL_0028:
	{
		float L_2 = ___value1;
		__this->set_y_2(L_2);
		goto IL_0057;
	}

IL_0034:
	{
		float L_3 = ___value1;
		__this->set_z_3(L_3);
		goto IL_0057;
	}

IL_0040:
	{
		float L_4 = ___value1;
		__this->set_w_4(L_4);
		goto IL_0057;
	}

IL_004c:
	{
		IndexOutOfRangeException_t1578797820 * L_5 = (IndexOutOfRangeException_t1578797820 *)il2cpp_codegen_object_new(IndexOutOfRangeException_t1578797820_il2cpp_TypeInfo_var);
		IndexOutOfRangeException__ctor_m3408750441(L_5, _stringLiteral2104486960, /*hidden argument*/NULL);
		IL2CPP_RAISE_MANAGED_EXCEPTION(L_5,Vector4_set_Item_m1183742235_RuntimeMethod_var);
	}

IL_0057:
	{
		return;
	}
}
extern "C"  void Vector4_set_Item_m1183742235_AdjustorThunk (RuntimeObject * __this, int32_t ___index0, float ___value1, const RuntimeMethod* method)
{
	Vector4_t3319028937 * _thisAdjusted = reinterpret_cast<Vector4_t3319028937 *>(__this + 1);
	Vector4_set_Item_m1183742235(_thisAdjusted, ___index0, ___value1, method);
}
// System.Int32 UnityEngine.Vector4::GetHashCode()
extern "C"  int32_t Vector4_GetHashCode_m536821243 (Vector4_t3319028937 * __this, const RuntimeMethod* method)
{
	int32_t V_0 = 0;
	{
		float* L_0 = __this->get_address_of_x_1();
		int32_t L_1 = Single_GetHashCode_m1558506138(L_0, /*hidden argument*/NULL);
		float* L_2 = __this->get_address_of_y_2();
		int32_t L_3 = Single_GetHashCode_m1558506138(L_2, /*hidden argument*/NULL);
		float* L_4 = __this->get_address_of_z_3();
		int32_t L_5 = Single_GetHashCode_m1558506138(L_4, /*hidden argument*/NULL);
		float* L_6 = __this->get_address_of_w_4();
		int32_t L_7 = Single_GetHashCode_m1558506138(L_6, /*hidden argument*/NULL);
		V_0 = ((int32_t)((int32_t)((int32_t)((int32_t)((int32_t)((int32_t)L_1^(int32_t)((int32_t)((int32_t)L_3<<(int32_t)2))))^(int32_t)((int32_t)((int32_t)L_5>>(int32_t)2))))^(int32_t)((int32_t)((int32_t)L_7>>(int32_t)1))));
		goto IL_0054;
	}

IL_0054:
	{
		int32_t L_8 = V_0;
		return L_8;
	}
}
extern "C"  int32_t Vector4_GetHashCode_m536821243_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector4_t3319028937 * _thisAdjusted = reinterpret_cast<Vector4_t3319028937 *>(__this + 1);
	return Vector4_GetHashCode_m536821243(_thisAdjusted, method);
}
// System.Boolean UnityEngine.Vector4::Equals(System.Object)
extern "C"  bool Vector4_Equals_m1779210055 (Vector4_t3319028937 * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector4_Equals_m1779210055_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	Vector4_t3319028937  V_1;
	memset(&V_1, 0, sizeof(V_1));
	int32_t G_B7_0 = 0;
	{
		RuntimeObject * L_0 = ___other0;
		if (((RuntimeObject *)IsInstSealed((RuntimeObject*)L_0, Vector4_t3319028937_il2cpp_TypeInfo_var)))
		{
			goto IL_0013;
		}
	}
	{
		V_0 = (bool)0;
		goto IL_007a;
	}

IL_0013:
	{
		RuntimeObject * L_1 = ___other0;
		V_1 = ((*(Vector4_t3319028937 *)((Vector4_t3319028937 *)UnBox(L_1, Vector4_t3319028937_il2cpp_TypeInfo_var))));
		float* L_2 = __this->get_address_of_x_1();
		float L_3 = (&V_1)->get_x_1();
		bool L_4 = Single_Equals_m1601893879(L_2, L_3, /*hidden argument*/NULL);
		if (!L_4)
		{
			goto IL_0073;
		}
	}
	{
		float* L_5 = __this->get_address_of_y_2();
		float L_6 = (&V_1)->get_y_2();
		bool L_7 = Single_Equals_m1601893879(L_5, L_6, /*hidden argument*/NULL);
		if (!L_7)
		{
			goto IL_0073;
		}
	}
	{
		float* L_8 = __this->get_address_of_z_3();
		float L_9 = (&V_1)->get_z_3();
		bool L_10 = Single_Equals_m1601893879(L_8, L_9, /*hidden argument*/NULL);
		if (!L_10)
		{
			goto IL_0073;
		}
	}
	{
		float* L_11 = __this->get_address_of_w_4();
		float L_12 = (&V_1)->get_w_4();
		bool L_13 = Single_Equals_m1601893879(L_11, L_12, /*hidden argument*/NULL);
		G_B7_0 = ((int32_t)(L_13));
		goto IL_0074;
	}

IL_0073:
	{
		G_B7_0 = 0;
	}

IL_0074:
	{
		V_0 = (bool)G_B7_0;
		goto IL_007a;
	}

IL_007a:
	{
		bool L_14 = V_0;
		return L_14;
	}
}
extern "C"  bool Vector4_Equals_m1779210055_AdjustorThunk (RuntimeObject * __this, RuntimeObject * ___other0, const RuntimeMethod* method)
{
	Vector4_t3319028937 * _thisAdjusted = reinterpret_cast<Vector4_t3319028937 *>(__this + 1);
	return Vector4_Equals_m1779210055(_thisAdjusted, ___other0, method);
}
// System.Single UnityEngine.Vector4::Dot(UnityEngine.Vector4,UnityEngine.Vector4)
extern "C"  float Vector4_Dot_m3492158352 (RuntimeObject * __this /* static, unused */, Vector4_t3319028937  ___a0, Vector4_t3319028937  ___b1, const RuntimeMethod* method)
{
	float V_0 = 0.0f;
	{
		float L_0 = (&___a0)->get_x_1();
		float L_1 = (&___b1)->get_x_1();
		float L_2 = (&___a0)->get_y_2();
		float L_3 = (&___b1)->get_y_2();
		float L_4 = (&___a0)->get_z_3();
		float L_5 = (&___b1)->get_z_3();
		float L_6 = (&___a0)->get_w_4();
		float L_7 = (&___b1)->get_w_4();
		V_0 = ((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_add((float)((float)il2cpp_codegen_multiply((float)L_0, (float)L_1)), (float)((float)il2cpp_codegen_multiply((float)L_2, (float)L_3)))), (float)((float)il2cpp_codegen_multiply((float)L_4, (float)L_5)))), (float)((float)il2cpp_codegen_multiply((float)L_6, (float)L_7))));
		goto IL_0046;
	}

IL_0046:
	{
		float L_8 = V_0;
		return L_8;
	}
}
// System.Single UnityEngine.Vector4::get_sqrMagnitude()
extern "C"  float Vector4_get_sqrMagnitude_m3767723558 (Vector4_t3319028937 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector4_get_sqrMagnitude_m3767723558_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector4_t3319028937_il2cpp_TypeInfo_var);
		float L_0 = Vector4_Dot_m3492158352(NULL /*static, unused*/, (*(Vector4_t3319028937 *)__this), (*(Vector4_t3319028937 *)__this), /*hidden argument*/NULL);
		V_0 = L_0;
		goto IL_0018;
	}

IL_0018:
	{
		float L_1 = V_0;
		return L_1;
	}
}
extern "C"  float Vector4_get_sqrMagnitude_m3767723558_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector4_t3319028937 * _thisAdjusted = reinterpret_cast<Vector4_t3319028937 *>(__this + 1);
	return Vector4_get_sqrMagnitude_m3767723558(_thisAdjusted, method);
}
// UnityEngine.Vector4 UnityEngine.Vector4::get_zero()
extern "C"  Vector4_t3319028937  Vector4_get_zero_m1422399515 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector4_get_zero_m1422399515_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	Vector4_t3319028937  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		IL2CPP_RUNTIME_CLASS_INIT(Vector4_t3319028937_il2cpp_TypeInfo_var);
		Vector4_t3319028937  L_0 = ((Vector4_t3319028937_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_t3319028937_il2cpp_TypeInfo_var))->get_zeroVector_5();
		V_0 = L_0;
		goto IL_000c;
	}

IL_000c:
	{
		Vector4_t3319028937  L_1 = V_0;
		return L_1;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::op_Subtraction(UnityEngine.Vector4,UnityEngine.Vector4)
extern "C"  Vector4_t3319028937  Vector4_op_Subtraction_m1632208160 (RuntimeObject * __this /* static, unused */, Vector4_t3319028937  ___a0, Vector4_t3319028937  ___b1, const RuntimeMethod* method)
{
	Vector4_t3319028937  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___a0)->get_x_1();
		float L_1 = (&___b1)->get_x_1();
		float L_2 = (&___a0)->get_y_2();
		float L_3 = (&___b1)->get_y_2();
		float L_4 = (&___a0)->get_z_3();
		float L_5 = (&___b1)->get_z_3();
		float L_6 = (&___a0)->get_w_4();
		float L_7 = (&___b1)->get_w_4();
		Vector4_t3319028937  L_8;
		memset(&L_8, 0, sizeof(L_8));
		Vector4__ctor_m2498754347((&L_8), ((float)il2cpp_codegen_subtract((float)L_0, (float)L_1)), ((float)il2cpp_codegen_subtract((float)L_2, (float)L_3)), ((float)il2cpp_codegen_subtract((float)L_4, (float)L_5)), ((float)il2cpp_codegen_subtract((float)L_6, (float)L_7)), /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_0048;
	}

IL_0048:
	{
		Vector4_t3319028937  L_9 = V_0;
		return L_9;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::op_Division(UnityEngine.Vector4,System.Single)
extern "C"  Vector4_t3319028937  Vector4_op_Division_m264790546 (RuntimeObject * __this /* static, unused */, Vector4_t3319028937  ___a0, float ___d1, const RuntimeMethod* method)
{
	Vector4_t3319028937  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___a0)->get_x_1();
		float L_1 = ___d1;
		float L_2 = (&___a0)->get_y_2();
		float L_3 = ___d1;
		float L_4 = (&___a0)->get_z_3();
		float L_5 = ___d1;
		float L_6 = (&___a0)->get_w_4();
		float L_7 = ___d1;
		Vector4_t3319028937  L_8;
		memset(&L_8, 0, sizeof(L_8));
		Vector4__ctor_m2498754347((&L_8), ((float)((float)L_0/(float)L_1)), ((float)((float)L_2/(float)L_3)), ((float)((float)L_4/(float)L_5)), ((float)((float)L_6/(float)L_7)), /*hidden argument*/NULL);
		V_0 = L_8;
		goto IL_0030;
	}

IL_0030:
	{
		Vector4_t3319028937  L_9 = V_0;
		return L_9;
	}
}
// System.Boolean UnityEngine.Vector4::op_Equality(UnityEngine.Vector4,UnityEngine.Vector4)
extern "C"  bool Vector4_op_Equality_m2403588337 (RuntimeObject * __this /* static, unused */, Vector4_t3319028937  ___lhs0, Vector4_t3319028937  ___rhs1, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector4_op_Equality_m2403588337_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	bool V_0 = false;
	{
		Vector4_t3319028937  L_0 = ___lhs0;
		Vector4_t3319028937  L_1 = ___rhs1;
		IL2CPP_RUNTIME_CLASS_INIT(Vector4_t3319028937_il2cpp_TypeInfo_var);
		Vector4_t3319028937  L_2 = Vector4_op_Subtraction_m1632208160(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		float L_3 = Vector4_SqrMagnitude_m1488236336(NULL /*static, unused*/, L_2, /*hidden argument*/NULL);
		V_0 = (bool)((((float)L_3) < ((float)(9.99999944E-11f)))? 1 : 0);
		goto IL_001a;
	}

IL_001a:
	{
		bool L_4 = V_0;
		return L_4;
	}
}
// UnityEngine.Vector4 UnityEngine.Vector4::op_Implicit(UnityEngine.Vector3)
extern "C"  Vector4_t3319028937  Vector4_op_Implicit_m2966035112 (RuntimeObject * __this /* static, unused */, Vector3_t3722313464  ___v0, const RuntimeMethod* method)
{
	Vector4_t3319028937  V_0;
	memset(&V_0, 0, sizeof(V_0));
	{
		float L_0 = (&___v0)->get_x_1();
		float L_1 = (&___v0)->get_y_2();
		float L_2 = (&___v0)->get_z_3();
		Vector4_t3319028937  L_3;
		memset(&L_3, 0, sizeof(L_3));
		Vector4__ctor_m2498754347((&L_3), L_0, L_1, L_2, (0.0f), /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_0026;
	}

IL_0026:
	{
		Vector4_t3319028937  L_4 = V_0;
		return L_4;
	}
}
// System.String UnityEngine.Vector4::ToString()
extern "C"  String_t* Vector4_ToString_m1596036856 (Vector4_t3319028937 * __this, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector4_ToString_m1596036856_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	String_t* V_0 = NULL;
	{
		ObjectU5BU5D_t2843939325* L_0 = ((ObjectU5BU5D_t2843939325*)SZArrayNew(ObjectU5BU5D_t2843939325_il2cpp_TypeInfo_var, (uint32_t)4));
		float L_1 = __this->get_x_1();
		float L_2 = L_1;
		RuntimeObject * L_3 = Box(Single_t1397266774_il2cpp_TypeInfo_var, &L_2);
		ArrayElementTypeCheck (L_0, L_3);
		(L_0)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(0), (RuntimeObject *)L_3);
		ObjectU5BU5D_t2843939325* L_4 = L_0;
		float L_5 = __this->get_y_2();
		float L_6 = L_5;
		RuntimeObject * L_7 = Box(Single_t1397266774_il2cpp_TypeInfo_var, &L_6);
		ArrayElementTypeCheck (L_4, L_7);
		(L_4)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(1), (RuntimeObject *)L_7);
		ObjectU5BU5D_t2843939325* L_8 = L_4;
		float L_9 = __this->get_z_3();
		float L_10 = L_9;
		RuntimeObject * L_11 = Box(Single_t1397266774_il2cpp_TypeInfo_var, &L_10);
		ArrayElementTypeCheck (L_8, L_11);
		(L_8)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(2), (RuntimeObject *)L_11);
		ObjectU5BU5D_t2843939325* L_12 = L_8;
		float L_13 = __this->get_w_4();
		float L_14 = L_13;
		RuntimeObject * L_15 = Box(Single_t1397266774_il2cpp_TypeInfo_var, &L_14);
		ArrayElementTypeCheck (L_12, L_15);
		(L_12)->SetAtUnchecked(static_cast<il2cpp_array_size_t>(3), (RuntimeObject *)L_15);
		String_t* L_16 = UnityString_Format_m261690510(NULL /*static, unused*/, _stringLiteral3651359435, L_12, /*hidden argument*/NULL);
		V_0 = L_16;
		goto IL_004f;
	}

IL_004f:
	{
		String_t* L_17 = V_0;
		return L_17;
	}
}
extern "C"  String_t* Vector4_ToString_m1596036856_AdjustorThunk (RuntimeObject * __this, const RuntimeMethod* method)
{
	Vector4_t3319028937 * _thisAdjusted = reinterpret_cast<Vector4_t3319028937 *>(__this + 1);
	return Vector4_ToString_m1596036856(_thisAdjusted, method);
}
// System.Single UnityEngine.Vector4::SqrMagnitude(UnityEngine.Vector4)
extern "C"  float Vector4_SqrMagnitude_m1488236336 (RuntimeObject * __this /* static, unused */, Vector4_t3319028937  ___a0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector4_SqrMagnitude_m1488236336_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	float V_0 = 0.0f;
	{
		Vector4_t3319028937  L_0 = ___a0;
		Vector4_t3319028937  L_1 = ___a0;
		IL2CPP_RUNTIME_CLASS_INIT(Vector4_t3319028937_il2cpp_TypeInfo_var);
		float L_2 = Vector4_Dot_m3492158352(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_000e;
	}

IL_000e:
	{
		float L_3 = V_0;
		return L_3;
	}
}
// System.Void UnityEngine.Vector4::.cctor()
extern "C"  void Vector4__cctor_m2519631228 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (Vector4__cctor_m2519631228_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		Vector4_t3319028937  L_0;
		memset(&L_0, 0, sizeof(L_0));
		Vector4__ctor_m2498754347((&L_0), (0.0f), (0.0f), (0.0f), (0.0f), /*hidden argument*/NULL);
		((Vector4_t3319028937_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_t3319028937_il2cpp_TypeInfo_var))->set_zeroVector_5(L_0);
		Vector4_t3319028937  L_1;
		memset(&L_1, 0, sizeof(L_1));
		Vector4__ctor_m2498754347((&L_1), (1.0f), (1.0f), (1.0f), (1.0f), /*hidden argument*/NULL);
		((Vector4_t3319028937_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_t3319028937_il2cpp_TypeInfo_var))->set_oneVector_6(L_1);
		Vector4_t3319028937  L_2;
		memset(&L_2, 0, sizeof(L_2));
		Vector4__ctor_m2498754347((&L_2), (std::numeric_limits<float>::infinity()), (std::numeric_limits<float>::infinity()), (std::numeric_limits<float>::infinity()), (std::numeric_limits<float>::infinity()), /*hidden argument*/NULL);
		((Vector4_t3319028937_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_t3319028937_il2cpp_TypeInfo_var))->set_positiveInfinityVector_7(L_2);
		Vector4_t3319028937  L_3;
		memset(&L_3, 0, sizeof(L_3));
		Vector4__ctor_m2498754347((&L_3), (-std::numeric_limits<float>::infinity()), (-std::numeric_limits<float>::infinity()), (-std::numeric_limits<float>::infinity()), (-std::numeric_limits<float>::infinity()), /*hidden argument*/NULL);
		((Vector4_t3319028937_StaticFields*)il2cpp_codegen_static_fields_for(Vector4_t3319028937_il2cpp_TypeInfo_var))->set_negativeInfinityVector_8(L_3);
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
// System.Void UnityEngine.WaitForEndOfFrame::.ctor()
extern "C"  void WaitForEndOfFrame__ctor_m1381314187 (WaitForEndOfFrame_t1314943911 * __this, const RuntimeMethod* method)
{
	{
		YieldInstruction__ctor_m1498450609(__this, /*hidden argument*/NULL);
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.WaitForSeconds
extern "C" void WaitForSeconds_t1699091251_marshal_pinvoke(const WaitForSeconds_t1699091251& unmarshaled, WaitForSeconds_t1699091251_marshaled_pinvoke& marshaled)
{
	marshaled.___m_Seconds_0 = unmarshaled.get_m_Seconds_0();
}
extern "C" void WaitForSeconds_t1699091251_marshal_pinvoke_back(const WaitForSeconds_t1699091251_marshaled_pinvoke& marshaled, WaitForSeconds_t1699091251& unmarshaled)
{
	float unmarshaled_m_Seconds_temp_0 = 0.0f;
	unmarshaled_m_Seconds_temp_0 = marshaled.___m_Seconds_0;
	unmarshaled.set_m_Seconds_0(unmarshaled_m_Seconds_temp_0);
}
// Conversion method for clean up from marshalling of: UnityEngine.WaitForSeconds
extern "C" void WaitForSeconds_t1699091251_marshal_pinvoke_cleanup(WaitForSeconds_t1699091251_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.WaitForSeconds
extern "C" void WaitForSeconds_t1699091251_marshal_com(const WaitForSeconds_t1699091251& unmarshaled, WaitForSeconds_t1699091251_marshaled_com& marshaled)
{
	marshaled.___m_Seconds_0 = unmarshaled.get_m_Seconds_0();
}
extern "C" void WaitForSeconds_t1699091251_marshal_com_back(const WaitForSeconds_t1699091251_marshaled_com& marshaled, WaitForSeconds_t1699091251& unmarshaled)
{
	float unmarshaled_m_Seconds_temp_0 = 0.0f;
	unmarshaled_m_Seconds_temp_0 = marshaled.___m_Seconds_0;
	unmarshaled.set_m_Seconds_0(unmarshaled_m_Seconds_temp_0);
}
// Conversion method for clean up from marshalling of: UnityEngine.WaitForSeconds
extern "C" void WaitForSeconds_t1699091251_marshal_com_cleanup(WaitForSeconds_t1699091251_marshaled_com& marshaled)
{
}
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// System.Void UnityEngine.WaitForSecondsRealtime::.ctor(System.Single)
extern "C"  void WaitForSecondsRealtime__ctor_m507157904 (WaitForSecondsRealtime_t189548121 * __this, float ___time0, const RuntimeMethod* method)
{
	{
		CustomYieldInstruction__ctor_m3408208142(__this, /*hidden argument*/NULL);
		float L_0 = Time_get_realtimeSinceStartup_m3141794964(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_1 = ___time0;
		__this->set_waitTime_0(((float)il2cpp_codegen_add((float)L_0, (float)L_1)));
		return;
	}
}
// System.Boolean UnityEngine.WaitForSecondsRealtime::get_keepWaiting()
extern "C"  bool WaitForSecondsRealtime_get_keepWaiting_m846832224 (WaitForSecondsRealtime_t189548121 * __this, const RuntimeMethod* method)
{
	bool V_0 = false;
	{
		float L_0 = Time_get_realtimeSinceStartup_m3141794964(NULL /*static, unused*/, /*hidden argument*/NULL);
		float L_1 = __this->get_waitTime_0();
		V_0 = (bool)((((float)L_0) < ((float)L_1))? 1 : 0);
		goto IL_0014;
	}

IL_0014:
	{
		bool L_2 = V_0;
		return L_2;
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
#ifdef __clang__
#pragma clang diagnostic push
#pragma clang diagnostic ignored "-Winvalid-offsetof"
#pragma clang diagnostic ignored "-Wunused-variable"
#endif
// Conversion methods for marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t403091072_marshal_pinvoke(const YieldInstruction_t403091072& unmarshaled, YieldInstruction_t403091072_marshaled_pinvoke& marshaled)
{
}
extern "C" void YieldInstruction_t403091072_marshal_pinvoke_back(const YieldInstruction_t403091072_marshaled_pinvoke& marshaled, YieldInstruction_t403091072& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t403091072_marshal_pinvoke_cleanup(YieldInstruction_t403091072_marshaled_pinvoke& marshaled)
{
}
// Conversion methods for marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t403091072_marshal_com(const YieldInstruction_t403091072& unmarshaled, YieldInstruction_t403091072_marshaled_com& marshaled)
{
}
extern "C" void YieldInstruction_t403091072_marshal_com_back(const YieldInstruction_t403091072_marshaled_com& marshaled, YieldInstruction_t403091072& unmarshaled)
{
}
// Conversion method for clean up from marshalling of: UnityEngine.YieldInstruction
extern "C" void YieldInstruction_t403091072_marshal_com_cleanup(YieldInstruction_t403091072_marshaled_com& marshaled)
{
}
// System.Void UnityEngine.YieldInstruction::.ctor()
extern "C"  void YieldInstruction__ctor_m1498450609 (YieldInstruction_t403091072 * __this, const RuntimeMethod* method)
{
	{
		Object__ctor_m297566312(__this, /*hidden argument*/NULL);
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
// System.Void UnityEngineInternal.GenericStack::.ctor()
extern "C"  void GenericStack__ctor_m933681517 (GenericStack_t1310059385 * __this, const RuntimeMethod* method)
{
	{
		Stack__ctor_m2907601956(__this, /*hidden argument*/NULL);
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
// System.Void UnityEngineInternal.MathfInternal::.cctor()
extern "C"  void MathfInternal__cctor_m2622893686 (RuntimeObject * __this /* static, unused */, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (MathfInternal__cctor_m2622893686_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		il2cpp_codegen_memory_barrier();
		((MathfInternal_t624072491_StaticFields*)il2cpp_codegen_static_fields_for(MathfInternal_t624072491_il2cpp_TypeInfo_var))->set_FloatMinNormal_0((1.17549435E-38f));
		il2cpp_codegen_memory_barrier();
		((MathfInternal_t624072491_StaticFields*)il2cpp_codegen_static_fields_for(MathfInternal_t624072491_il2cpp_TypeInfo_var))->set_FloatMinDenormal_1((1.401298E-45f));
		float L_0 = ((MathfInternal_t624072491_StaticFields*)il2cpp_codegen_static_fields_for(MathfInternal_t624072491_il2cpp_TypeInfo_var))->get_FloatMinDenormal_1();
		il2cpp_codegen_memory_barrier();
		float L_1 = Interlocked_CompareExchange_m4173283112(NULL /*static, unused*/, (((MathfInternal_t624072491_StaticFields*)il2cpp_codegen_static_fields_for(MathfInternal_t624072491_il2cpp_TypeInfo_var))->get_address_of_FloatMinDenormal_1()), L_0, (0.0f), /*hidden argument*/NULL);
		((MathfInternal_t624072491_StaticFields*)il2cpp_codegen_static_fields_for(MathfInternal_t624072491_il2cpp_TypeInfo_var))->set_IsFlushToZeroEnabled_2((bool)((((float)L_1) == ((float)(0.0f)))? 1 : 0));
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
// System.Delegate UnityEngineInternal.NetFxCoreExtensions::CreateDelegate(System.Reflection.MethodInfo,System.Type,System.Object)
extern "C"  Delegate_t1188392813 * NetFxCoreExtensions_CreateDelegate_m751211712 (RuntimeObject * __this /* static, unused */, MethodInfo_t * ___self0, Type_t * ___delegateType1, RuntimeObject * ___target2, const RuntimeMethod* method)
{
	Delegate_t1188392813 * V_0 = NULL;
	{
		Type_t * L_0 = ___delegateType1;
		RuntimeObject * L_1 = ___target2;
		MethodInfo_t * L_2 = ___self0;
		Delegate_t1188392813 * L_3 = Delegate_CreateDelegate_m995503480(NULL /*static, unused*/, L_0, L_1, L_2, /*hidden argument*/NULL);
		V_0 = L_3;
		goto IL_000f;
	}

IL_000f:
	{
		Delegate_t1188392813 * L_4 = V_0;
		return L_4;
	}
}
// System.Reflection.MethodInfo UnityEngineInternal.NetFxCoreExtensions::GetMethodInfo(System.Delegate)
extern "C"  MethodInfo_t * NetFxCoreExtensions_GetMethodInfo_m444570327 (RuntimeObject * __this /* static, unused */, Delegate_t1188392813 * ___self0, const RuntimeMethod* method)
{
	MethodInfo_t * V_0 = NULL;
	{
		Delegate_t1188392813 * L_0 = ___self0;
		MethodInfo_t * L_1 = Delegate_get_Method_m3071622864(L_0, /*hidden argument*/NULL);
		V_0 = L_1;
		goto IL_000d;
	}

IL_000d:
	{
		MethodInfo_t * L_2 = V_0;
		return L_2;
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
// System.Delegate UnityEngineInternal.ScriptingUtils::CreateDelegate(System.Type,System.Reflection.MethodInfo)
extern "C"  Delegate_t1188392813 * ScriptingUtils_CreateDelegate_m650796149 (RuntimeObject * __this /* static, unused */, Type_t * ___type0, MethodInfo_t * ___methodInfo1, const RuntimeMethod* method)
{
	Delegate_t1188392813 * V_0 = NULL;
	{
		Type_t * L_0 = ___type0;
		MethodInfo_t * L_1 = ___methodInfo1;
		Delegate_t1188392813 * L_2 = Delegate_CreateDelegate_m2396489936(NULL /*static, unused*/, L_0, L_1, /*hidden argument*/NULL);
		V_0 = L_2;
		goto IL_000e;
	}

IL_000e:
	{
		Delegate_t1188392813 * L_3 = V_0;
		return L_3;
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
// System.Void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(UnityEngineInternal.TypeInferenceRules)
extern "C"  void TypeInferenceRuleAttribute__ctor_m3137488504 (TypeInferenceRuleAttribute_t254868554 * __this, int32_t ___rule0, const RuntimeMethod* method)
{
	static bool s_Il2CppMethodInitialized;
	if (!s_Il2CppMethodInitialized)
	{
		il2cpp_codegen_initialize_method (TypeInferenceRuleAttribute__ctor_m3137488504_MetadataUsageId);
		s_Il2CppMethodInitialized = true;
	}
	{
		RuntimeObject * L_0 = Box(TypeInferenceRules_t96689094_il2cpp_TypeInfo_var, (&___rule0));
		String_t* L_1 = VirtFuncInvoker0< String_t* >::Invoke(3 /* System.String System.Object::ToString() */, L_0);
		___rule0 = *(int32_t*)UnBox(L_0);
		TypeInferenceRuleAttribute__ctor_m2736695831(__this, L_1, /*hidden argument*/NULL);
		return;
	}
}
// System.Void UnityEngineInternal.TypeInferenceRuleAttribute::.ctor(System.String)
extern "C"  void TypeInferenceRuleAttribute__ctor_m2736695831 (TypeInferenceRuleAttribute_t254868554 * __this, String_t* ___rule0, const RuntimeMethod* method)
{
	{
		Attribute__ctor_m1529526131(__this, /*hidden argument*/NULL);
		String_t* L_0 = ___rule0;
		__this->set__rule_0(L_0);
		return;
	}
}
// System.String UnityEngineInternal.TypeInferenceRuleAttribute::ToString()
extern "C"  String_t* TypeInferenceRuleAttribute_ToString_m4089326196 (TypeInferenceRuleAttribute_t254868554 * __this, const RuntimeMethod* method)
{
	String_t* V_0 = NULL;
	{
		String_t* L_0 = __this->get__rule_0();
		V_0 = L_0;
		goto IL_000d;
	}

IL_000d:
	{
		String_t* L_1 = V_0;
		return L_1;
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
#ifdef __clang__
#pragma clang diagnostic pop
#endif
