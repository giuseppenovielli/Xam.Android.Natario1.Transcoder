using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Source {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='AssetFileDescriptorDataSource']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/source/AssetFileDescriptorDataSource", DoNotGenerateAcw=true)]
	public partial class AssetFileDescriptorDataSource : global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/source/AssetFileDescriptorDataSource", typeof (AssetFileDescriptorDataSource));

		internal static new IntPtr class_ref {
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

		protected AssetFileDescriptorDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='AssetFileDescriptorDataSource']/constructor[@name='AssetFileDescriptorDataSource' and count(parameter)=1 and parameter[1][@type='android.content.res.AssetFileDescriptor']]"
		[Register (".ctor", "(Landroid/content/res/AssetFileDescriptor;)V", "")]
		public unsafe AssetFileDescriptorDataSource (global::Android.Content.Res.AssetFileDescriptor assetFileDescriptor) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Landroid/content/res/AssetFileDescriptor;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((assetFileDescriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) assetFileDescriptor).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (assetFileDescriptor);
			}
		}

	}
}
