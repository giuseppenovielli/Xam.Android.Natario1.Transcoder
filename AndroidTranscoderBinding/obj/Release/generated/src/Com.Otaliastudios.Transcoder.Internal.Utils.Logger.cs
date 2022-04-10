using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/utils/Logger", DoNotGenerateAcw=true)]
	public partial class Logger : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/field[@name='LEVEL_ERROR']"
		[Register ("LEVEL_ERROR")]
		public const int LevelError = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/field[@name='LEVEL_INFO']"
		[Register ("LEVEL_INFO")]
		public const int LevelInfo = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/field[@name='LEVEL_VERBOSE']"
		[Register ("LEVEL_VERBOSE")]
		public const int LevelVerbose = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/field[@name='LEVEL_WARNING']"
		[Register ("LEVEL_WARNING")]
		public const int LevelWarning = (int) 2;

		// Metadata.xml XPath interface reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/interface[@name='Logger.LogLevel']"
		[Register ("com/otaliastudios/transcoder/internal/utils/Logger$LogLevel", "", "Com.Otaliastudios.Transcoder.Internal.Utils.Logger/ILogLevelInvoker")]
		public partial interface ILogLevel : global::Java.Lang.Annotation.IAnnotation {
		}

		[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/utils/Logger$LogLevel", DoNotGenerateAcw=true)]
		internal partial class ILogLevelInvoker : global::Java.Lang.Object, ILogLevel {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/utils/Logger$LogLevel", typeof (ILogLevelInvoker));

			static IntPtr java_class_ref {
				get { return _members.JniPeerType.PeerReference.Handle; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			public override global::Java.Interop.JniPeerMembers JniPeerMembers {
				get { return _members; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override IntPtr ThresholdClass {
				get { return class_ref; }
			}

			[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
			[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
			protected override global::System.Type ThresholdType {
				get { return _members.ManagedPeerType; }
			}

			IntPtr class_ref;

			public static ILogLevel GetObject (IntPtr handle, JniHandleOwnership transfer)
			{
				return global::Java.Lang.Object.GetObject<ILogLevel> (handle, transfer);
			}

			static IntPtr Validate (IntPtr handle)
			{
				if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
					throw new InvalidCastException ($"Unable to convert instance of type '{JNIEnv.GetClassNameFromInstance (handle)}' to type 'com.otaliastudios.transcoder.internal.utils.Logger.LogLevel'.");
				return handle;
			}

			protected override void Dispose (bool disposing)
			{
				if (this.class_ref != IntPtr.Zero)
					JNIEnv.DeleteGlobalRef (this.class_ref);
				this.class_ref = IntPtr.Zero;
				base.Dispose (disposing);
			}

			public ILogLevelInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
			{
				IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
				this.class_ref = JNIEnv.NewGlobalRef (local_ref);
				JNIEnv.DeleteLocalRef (local_ref);
			}

			static Delegate cb_annotationType;
#pragma warning disable 0169
			static Delegate GetAnnotationTypeHandler ()
			{
				if (cb_annotationType == null)
					cb_annotationType = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_AnnotationType);
				return cb_annotationType;
			}

			static IntPtr n_AnnotationType (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger.ILogLevel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.ToLocalJniHandle (__this.AnnotationType ());
			}
#pragma warning restore 0169

			IntPtr id_annotationType;
			public unsafe global::Java.Lang.Class AnnotationType ()
			{
				if (id_annotationType == IntPtr.Zero)
					id_annotationType = JNIEnv.GetMethodID (class_ref, "annotationType", "()Ljava/lang/Class;");
				return global::Java.Lang.Object.GetObject<global::Java.Lang.Class> (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_annotationType), JniHandleOwnership.TransferLocalRef);
			}

			static Delegate cb_equals_Ljava_lang_Object_;
#pragma warning disable 0169
			static Delegate GetEquals_Ljava_lang_Object_Handler ()
			{
				if (cb_equals_Ljava_lang_Object_ == null)
					cb_equals_Ljava_lang_Object_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_Z) n_Equals_Ljava_lang_Object_);
				return cb_equals_Ljava_lang_Object_;
			}

			static bool n_Equals_Ljava_lang_Object_ (IntPtr jnienv, IntPtr native__this, IntPtr native_obj)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger.ILogLevel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				var obj = global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (native_obj, JniHandleOwnership.DoNotTransfer);
				bool __ret = __this.Equals (obj);
				return __ret;
			}
#pragma warning restore 0169

			IntPtr id_equals_Ljava_lang_Object_;
			public unsafe global::System.Boolean Equals (global::Java.Lang.Object obj)
			{
				if (id_equals_Ljava_lang_Object_ == IntPtr.Zero)
					id_equals_Ljava_lang_Object_ = JNIEnv.GetMethodID (class_ref, "equals", "(Ljava/lang/Object;)Z");
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue ((obj == null) ? IntPtr.Zero : ((global::Java.Lang.Object) obj).Handle);
				var __ret = JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_equals_Ljava_lang_Object_, __args);
				return __ret;
			}

			static Delegate cb_hashCode;
#pragma warning disable 0169
			static Delegate GetGetHashCodeHandler ()
			{
				if (cb_hashCode == null)
					cb_hashCode = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetHashCode);
				return cb_hashCode;
			}

			static int n_GetHashCode (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger.ILogLevel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return __this.GetHashCode ();
			}
#pragma warning restore 0169

			IntPtr id_hashCode;
			public unsafe global::System.Int32 GetHashCode ()
			{
				if (id_hashCode == IntPtr.Zero)
					id_hashCode = JNIEnv.GetMethodID (class_ref, "hashCode", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_hashCode);
			}

			static Delegate cb_toString;
#pragma warning disable 0169
			static Delegate GetToStringHandler ()
			{
				if (cb_toString == null)
					cb_toString = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_L) n_ToString);
				return cb_toString;
			}

			static IntPtr n_ToString (IntPtr jnienv, IntPtr native__this)
			{
				var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger.ILogLevel> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
				return JNIEnv.NewString (__this.ToString ());
			}
#pragma warning restore 0169

			IntPtr id_toString;
			public unsafe global::System.String ToString ()
			{
				if (id_toString == IntPtr.Zero)
					id_toString = JNIEnv.GetMethodID (class_ref, "toString", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_toString), JniHandleOwnership.TransferLocalRef);
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/utils/Logger", typeof (Logger));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected Logger (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/constructor[@name='Logger' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;)V", "")]
		public unsafe Logger (string tag) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_tag = JNIEnv.NewString (tag);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_tag);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_tag);
			}
		}

		static Delegate cb_e_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Handler ()
		{
			if (cb_e_Ljava_lang_String_ == null)
				cb_e_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_E_Ljava_lang_String_);
			return cb_e_Ljava_lang_String_;
		}

		static void n_E_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.E (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/method[@name='e' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("e", "(Ljava/lang/String;)V", "GetE_Ljava_lang_String_Handler")]
		public virtual unsafe void E (string message)
		{
			const string __id = "e.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_e_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetE_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_e_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_e_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_E_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_e_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_E_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.E (message, error);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/method[@name='e' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("e", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetE_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void E (string message, global::Java.Lang.Throwable error)
		{
			const string __id = "e.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (error);
			}
		}

		static Delegate cb_i_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Handler ()
		{
			if (cb_i_Ljava_lang_String_ == null)
				cb_i_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_I_Ljava_lang_String_);
			return cb_i_Ljava_lang_String_;
		}

		static void n_I_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.I (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/method[@name='i' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("i", "(Ljava/lang/String;)V", "GetI_Ljava_lang_String_Handler")]
		public virtual unsafe void I (string message)
		{
			const string __id = "i.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_i_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetI_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_i_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_i_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_I_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_i_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_I_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.I (message, error);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/method[@name='i' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("i", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetI_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void I (string message, global::Java.Lang.Throwable error)
		{
			const string __id = "i.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (error);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/method[@name='setLogLevel' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("setLogLevel", "(I)V", "")]
		public static unsafe void SetLogLevel (int logLevel)
		{
			const string __id = "setLogLevel.(I)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (logLevel);
				_members.StaticMethods.InvokeVoidMethod (__id, __args);
			} finally {
			}
		}

		static Delegate cb_v_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetV_Ljava_lang_String_Handler ()
		{
			if (cb_v_Ljava_lang_String_ == null)
				cb_v_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_V_Ljava_lang_String_);
			return cb_v_Ljava_lang_String_;
		}

		static void n_V_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.V (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/method[@name='v' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("v", "(Ljava/lang/String;)V", "GetV_Ljava_lang_String_Handler")]
		public virtual unsafe void V (string message)
		{
			const string __id = "v.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_v_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetV_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_v_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_v_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_V_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_v_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_V_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.V (message, error);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/method[@name='v' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("v", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetV_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void V (string message, global::Java.Lang.Throwable error)
		{
			const string __id = "v.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (error);
			}
		}

		static Delegate cb_w_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Handler ()
		{
			if (cb_w_Ljava_lang_String_ == null)
				cb_w_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_W_Ljava_lang_String_);
			return cb_w_Ljava_lang_String_;
		}

		static void n_W_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			__this.W (message);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/method[@name='w' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("w", "(Ljava/lang/String;)V", "GetW_Ljava_lang_String_Handler")]
		public virtual unsafe void W (string message)
		{
			const string __id = "w.(Ljava/lang/String;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_message);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
			}
		}

		static Delegate cb_w_Ljava_lang_String_Ljava_lang_Throwable_;
#pragma warning disable 0169
		static Delegate GetW_Ljava_lang_String_Ljava_lang_Throwable_Handler ()
		{
			if (cb_w_Ljava_lang_String_Ljava_lang_Throwable_ == null)
				cb_w_Ljava_lang_String_Ljava_lang_Throwable_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_W_Ljava_lang_String_Ljava_lang_Throwable_);
			return cb_w_Ljava_lang_String_Ljava_lang_Throwable_;
		}

		static void n_W_Ljava_lang_String_Ljava_lang_Throwable_ (IntPtr jnienv, IntPtr native__this, IntPtr native_message, IntPtr native_error)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.Logger> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var message = JNIEnv.GetString (native_message, JniHandleOwnership.DoNotTransfer);
			var error = global::Java.Lang.Object.GetObject<global::Java.Lang.Throwable> (native_error, JniHandleOwnership.DoNotTransfer);
			__this.W (message, error);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='Logger']/method[@name='w' and count(parameter)=2 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.Throwable']]"
		[Register ("w", "(Ljava/lang/String;Ljava/lang/Throwable;)V", "GetW_Ljava_lang_String_Ljava_lang_Throwable_Handler")]
		public virtual unsafe void W (string message, global::Java.Lang.Throwable error)
		{
			const string __id = "w.(Ljava/lang/String;Ljava/lang/Throwable;)V";
			IntPtr native_message = JNIEnv.NewString (message);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_message);
				__args [1] = new JniArgumentValue ((error == null) ? IntPtr.Zero : ((global::Java.Lang.Throwable) error).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_message);
				global::System.GC.KeepAlive (error);
			}
		}

	}
}
