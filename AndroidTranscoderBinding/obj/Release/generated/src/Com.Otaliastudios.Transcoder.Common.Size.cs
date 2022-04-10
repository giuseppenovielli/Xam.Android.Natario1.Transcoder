using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='Size']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/common/Size", DoNotGenerateAcw=true)]
	public partial class Size : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/common/Size", typeof (Size));

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

		protected Size (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='Size']/constructor[@name='Size' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='int']]"
		[Register (".ctor", "(II)V", "")]
		public unsafe Size (int firstSize, int secondSize) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(II)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (firstSize);
				__args [1] = new JniArgumentValue (secondSize);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
			}
		}

		static Delegate cb_getMajor;
#pragma warning disable 0169
		static Delegate GetGetMajorHandler ()
		{
			if (cb_getMajor == null)
				cb_getMajor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMajor);
			return cb_getMajor;
		}

		static int n_GetMajor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.Size> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Major;
		}
#pragma warning restore 0169

		public virtual unsafe int Major {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='Size']/method[@name='getMajor' and count(parameter)=0]"
			[Register ("getMajor", "()I", "GetGetMajorHandler")]
			get {
				const string __id = "getMajor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		static Delegate cb_getMinor;
#pragma warning disable 0169
		static Delegate GetGetMinorHandler ()
		{
			if (cb_getMinor == null)
				cb_getMinor = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_I) n_GetMinor);
			return cb_getMinor;
		}

		static int n_GetMinor (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Common.Size> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.Minor;
		}
#pragma warning restore 0169

		public virtual unsafe int Minor {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder.common']/class[@name='Size']/method[@name='getMinor' and count(parameter)=0]"
			[Register ("getMinor", "()I", "GetGetMinorHandler")]
			get {
				const string __id = "getMinor.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeVirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

	}
}
