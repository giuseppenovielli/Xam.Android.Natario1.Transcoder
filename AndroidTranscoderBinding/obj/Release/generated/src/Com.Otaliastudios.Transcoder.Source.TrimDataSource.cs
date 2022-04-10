using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder.Source {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='TrimDataSource']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/source/TrimDataSource", DoNotGenerateAcw=true)]
	public partial class TrimDataSource : global::Com.Otaliastudios.Transcoder.Source.DataSourceWrapper {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/source/TrimDataSource", typeof (TrimDataSource));

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

		protected TrimDataSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='TrimDataSource']/constructor[@name='TrimDataSource' and count(parameter)=2 and parameter[1][@type='com.otaliastudios.transcoder.source.DataSource'] and parameter[2][@type='long']]"
		[Register (".ctor", "(Lcom/otaliastudios/transcoder/source/DataSource;J)V", "")]
		public unsafe TrimDataSource (global::Com.Otaliastudios.Transcoder.Source.IDataSource source, long trimStartUs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/otaliastudios/transcoder/source/DataSource;J)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue (trimStartUs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (source);
			}
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder.source']/class[@name='TrimDataSource']/constructor[@name='TrimDataSource' and count(parameter)=3 and parameter[1][@type='com.otaliastudios.transcoder.source.DataSource'] and parameter[2][@type='long'] and parameter[3][@type='long']]"
		[Register (".ctor", "(Lcom/otaliastudios/transcoder/source/DataSource;JJ)V", "")]
		public unsafe TrimDataSource (global::Com.Otaliastudios.Transcoder.Source.IDataSource source, long trimStartUs, long trimEndUs) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/otaliastudios/transcoder/source/DataSource;JJ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [3];
				__args [0] = new JniArgumentValue ((source == null) ? IntPtr.Zero : ((global::Java.Lang.Object) source).Handle);
				__args [1] = new JniArgumentValue (trimStartUs);
				__args [2] = new JniArgumentValue (trimEndUs);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (source);
			}
		}

	}
}
