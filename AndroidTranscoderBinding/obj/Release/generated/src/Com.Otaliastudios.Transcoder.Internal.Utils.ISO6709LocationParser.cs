using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='ISO6709LocationParser']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/utils/ISO6709LocationParser", DoNotGenerateAcw=true)]
	public partial class ISO6709LocationParser : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/utils/ISO6709LocationParser", typeof (ISO6709LocationParser));

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

		protected ISO6709LocationParser (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='ISO6709LocationParser']/constructor[@name='ISO6709LocationParser' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe ISO6709LocationParser () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate cb_parse_Ljava_lang_String_;
#pragma warning disable 0169
		static Delegate GetParse_Ljava_lang_String_Handler ()
		{
			if (cb_parse_Ljava_lang_String_ == null)
				cb_parse_Ljava_lang_String_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_L) n_Parse_Ljava_lang_String_);
			return cb_parse_Ljava_lang_String_;
		}

		static IntPtr n_Parse_Ljava_lang_String_ (IntPtr jnienv, IntPtr native__this, IntPtr native_location)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Internal.Utils.ISO6709LocationParser> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			var location = JNIEnv.GetString (native_location, JniHandleOwnership.DoNotTransfer);
			IntPtr __ret = JNIEnv.NewArray (__this.Parse (location));
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='ISO6709LocationParser']/method[@name='parse' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
		[Register ("parse", "(Ljava/lang/String;)[F", "GetParse_Ljava_lang_String_Handler")]
		public virtual unsafe float[] Parse (string location)
		{
			const string __id = "parse.(Ljava/lang/String;)[F";
			IntPtr native_location = JNIEnv.NewString (location);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_location);
				var __rm = _members.InstanceMethods.InvokeVirtualObjectMethod (__id, this, __args);
				return (float[]) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (float));
			} finally {
				JNIEnv.DeleteLocalRef (native_location);
			}
		}

	}
}
