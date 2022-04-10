using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Internal.Utils {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='AvcSpsUtils']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/internal/utils/AvcSpsUtils", DoNotGenerateAcw=true)]
	public partial class AvcSpsUtils : global::Java.Lang.Object {
		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='AvcSpsUtils']/field[@name='PROFILE_IDC_BASELINE']"
		[Register ("PROFILE_IDC_BASELINE")]
		public const sbyte ProfileIdcBaseline = (sbyte) 66;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='AvcSpsUtils']/field[@name='PROFILE_IDC_EXTENDED']"
		[Register ("PROFILE_IDC_EXTENDED")]
		public const sbyte ProfileIdcExtended = (sbyte) 88;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='AvcSpsUtils']/field[@name='PROFILE_IDC_HIGH']"
		[Register ("PROFILE_IDC_HIGH")]
		public const sbyte ProfileIdcHigh = (sbyte) 100;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='AvcSpsUtils']/field[@name='PROFILE_IDC_MAIN']"
		[Register ("PROFILE_IDC_MAIN")]
		public const sbyte ProfileIdcMain = (sbyte) 77;

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/internal/utils/AvcSpsUtils", typeof (AvcSpsUtils));

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

		protected AvcSpsUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='AvcSpsUtils']/constructor[@name='AvcSpsUtils' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe AvcSpsUtils () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='AvcSpsUtils']/method[@name='getProfileIdc' and count(parameter)=1 and parameter[1][@type='java.nio.ByteBuffer']]"
		[Register ("getProfileIdc", "(Ljava/nio/ByteBuffer;)B", "")]
		public static unsafe sbyte GetProfileIdc (global::Java.Nio.ByteBuffer spsBuffer)
		{
			const string __id = "getProfileIdc.(Ljava/nio/ByteBuffer;)B";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((spsBuffer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) spsBuffer).Handle);
				var __rm = _members.StaticMethods.InvokeSByteMethod (__id, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (spsBuffer);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.internal.utils']/class[@name='AvcSpsUtils']/method[@name='getProfileName' and count(parameter)=1 and parameter[1][@type='byte']]"
		[Register ("getProfileName", "(B)Ljava/lang/String;", "")]
		public static unsafe string GetProfileName (sbyte profileIdc)
		{
			const string __id = "getProfileName.(B)Ljava/lang/String;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (profileIdc);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
