using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Otaliastudios.Transcoder {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions']"
	[global::Android.Runtime.Register ("com/otaliastudios/transcoder/ThumbnailerOptions", DoNotGenerateAcw=true)]
	public sealed partial class ThumbnailerOptions : global::Java.Lang.Object {
		// Metadata.xml XPath class reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']"
		[global::Android.Runtime.Register ("com/otaliastudios/transcoder/ThumbnailerOptions$Builder", DoNotGenerateAcw=true)]
		public sealed partial class Builder : global::Java.Lang.Object {
			static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/ThumbnailerOptions$Builder", typeof (Builder));

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

			internal Builder (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
			{
			}

			// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/constructor[@name='ThumbnailerOptions.Builder' and count(parameter)=0]"
			[Register (".ctor", "()V", "")]
			public unsafe Builder () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
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

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/method[@name='addDataSource' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='android.net.Uri']]"
			[Register ("addDataSource", "(Landroid/content/Context;Landroid/net/Uri;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;", "")]
			public unsafe global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder AddDataSource (global::Android.Content.Context context, global::Android.Net.Uri uri)
			{
				const string __id = "addDataSource.(Landroid/content/Context;Landroid/net/Uri;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [2];
					__args [0] = new JniArgumentValue ((context == null) ? IntPtr.Zero : ((global::Java.Lang.Object) context).Handle);
					__args [1] = new JniArgumentValue ((uri == null) ? IntPtr.Zero : ((global::Java.Lang.Object) uri).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (context);
					global::System.GC.KeepAlive (uri);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/method[@name='addDataSource' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.source.DataSource']]"
			[Register ("addDataSource", "(Lcom/otaliastudios/transcoder/source/DataSource;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;", "")]
			public unsafe global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder AddDataSource (global::Com.Otaliastudios.Transcoder.Source.IDataSource dataSource)
			{
				const string __id = "addDataSource.(Lcom/otaliastudios/transcoder/source/DataSource;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((dataSource == null) ? IntPtr.Zero : ((global::Java.Lang.Object) dataSource).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (dataSource);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/method[@name='addDataSource' and count(parameter)=1 and parameter[1][@type='java.io.FileDescriptor']]"
			[Register ("addDataSource", "(Ljava/io/FileDescriptor;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;", "")]
			public unsafe global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder AddDataSource (global::Java.IO.FileDescriptor fileDescriptor)
			{
				const string __id = "addDataSource.(Ljava/io/FileDescriptor;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((fileDescriptor == null) ? IntPtr.Zero : ((global::Java.Lang.Object) fileDescriptor).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (fileDescriptor);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/method[@name='addDataSource' and count(parameter)=1 and parameter[1][@type='java.lang.String']]"
			[Register ("addDataSource", "(Ljava/lang/String;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;", "")]
			public unsafe global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder AddDataSource (string filePath)
			{
				const string __id = "addDataSource.(Ljava/lang/String;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;";
				IntPtr native_filePath = JNIEnv.NewString (filePath);
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (native_filePath);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					JNIEnv.DeleteLocalRef (native_filePath);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/method[@name='addResizer' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.resize.Resizer']]"
			[Register ("addResizer", "(Lcom/otaliastudios/transcoder/resize/Resizer;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;", "")]
			public unsafe global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder AddResizer (global::Com.Otaliastudios.Transcoder.Resize.IResizer resizer)
			{
				const string __id = "addResizer.(Lcom/otaliastudios/transcoder/resize/Resizer;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((resizer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resizer).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (resizer);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/method[@name='addThumbnailRequest' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.thumbnail.ThumbnailRequest']]"
			[Register ("addThumbnailRequest", "(Lcom/otaliastudios/transcoder/thumbnail/ThumbnailRequest;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;", "")]
			public unsafe global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder AddThumbnailRequest (global::Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequest request)
			{
				const string __id = "addThumbnailRequest.(Lcom/otaliastudios/transcoder/thumbnail/ThumbnailRequest;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((request == null) ? IntPtr.Zero : ((global::Java.Lang.Object) request).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (request);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/method[@name='build' and count(parameter)=0]"
			[Register ("build", "()Lcom/otaliastudios/transcoder/ThumbnailerOptions;", "")]
			public unsafe global::Com.Otaliastudios.Transcoder.ThumbnailerOptions Build ()
			{
				const string __id = "build.()Lcom/otaliastudios/transcoder/ThumbnailerOptions;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ThumbnailerOptions> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/method[@name='setListener' and count(parameter)=1 and parameter[1][@type='com.otaliastudios.transcoder.ThumbnailerListener']]"
			[Register ("setListener", "(Lcom/otaliastudios/transcoder/ThumbnailerListener;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;", "")]
			public unsafe global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder SetListener (global::Com.Otaliastudios.Transcoder.IThumbnailerListener listener)
			{
				const string __id = "setListener.(Lcom/otaliastudios/transcoder/ThumbnailerListener;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (listener);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/method[@name='setListenerHandler' and count(parameter)=1 and parameter[1][@type='android.os.Handler']]"
			[Register ("setListenerHandler", "(Landroid/os/Handler;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;", "")]
			public unsafe global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder SetListenerHandler (global::Android.OS.Handler listenerHandler)
			{
				const string __id = "setListenerHandler.(Landroid/os/Handler;)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue ((listenerHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listenerHandler).Handle);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
					global::System.GC.KeepAlive (listenerHandler);
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/method[@name='setRotation' and count(parameter)=1 and parameter[1][@type='int']]"
			[Register ("setRotation", "(I)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;", "")]
			public unsafe global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder SetRotation (int rotation)
			{
				const string __id = "setRotation.(I)Lcom/otaliastudios/transcoder/ThumbnailerOptions$Builder;";
				try {
					JniArgumentValue* __args = stackalloc JniArgumentValue [1];
					__args [0] = new JniArgumentValue (rotation);
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, __args);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.ThumbnailerOptions.Builder> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions.Builder']/method[@name='thumbnails' and count(parameter)=0]"
			[Register ("thumbnails", "()Ljava/util/concurrent/Future;", "")]
			public unsafe global::Java.Util.Concurrent.IFuture Thumbnails ()
			{
				const string __id = "thumbnails.()Ljava/util/concurrent/Future;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Concurrent.IFuture> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}

		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/otaliastudios/transcoder/ThumbnailerOptions", typeof (ThumbnailerOptions));

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

		internal ThumbnailerOptions (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions']/constructor[@name='ThumbnailerOptions' and count(parameter)=6 and parameter[1][@type='java.util.List&lt;? extends com.otaliastudios.transcoder.source.DataSource&gt;'] and parameter[2][@type='com.otaliastudios.transcoder.resize.Resizer'] and parameter[3][@type='int'] and parameter[4][@type='java.util.List&lt;? extends com.otaliastudios.transcoder.thumbnail.ThumbnailRequest&gt;'] and parameter[5][@type='com.otaliastudios.transcoder.ThumbnailerListener'] and parameter[6][@type='android.os.Handler']]"
		[Register (".ctor", "(Ljava/util/List;Lcom/otaliastudios/transcoder/resize/Resizer;ILjava/util/List;Lcom/otaliastudios/transcoder/ThumbnailerListener;Landroid/os/Handler;)V", "")]
		public unsafe ThumbnailerOptions (global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Source.IDataSource> dataSources, global::Com.Otaliastudios.Transcoder.Resize.IResizer resizer, int rotation, global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequest> thumbnailRequests, global::Com.Otaliastudios.Transcoder.IThumbnailerListener listener, global::Android.OS.Handler listenerHandler) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/util/List;Lcom/otaliastudios/transcoder/resize/Resizer;ILjava/util/List;Lcom/otaliastudios/transcoder/ThumbnailerListener;Landroid/os/Handler;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_dataSources = global::Android.Runtime.JavaList<global::Com.Otaliastudios.Transcoder.Source.IDataSource>.ToLocalJniHandle (dataSources);
			IntPtr native_thumbnailRequests = global::Android.Runtime.JavaList<global::Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequest>.ToLocalJniHandle (thumbnailRequests);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [6];
				__args [0] = new JniArgumentValue (native_dataSources);
				__args [1] = new JniArgumentValue ((resizer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) resizer).Handle);
				__args [2] = new JniArgumentValue (rotation);
				__args [3] = new JniArgumentValue (native_thumbnailRequests);
				__args [4] = new JniArgumentValue ((listener == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listener).Handle);
				__args [5] = new JniArgumentValue ((listenerHandler == null) ? IntPtr.Zero : ((global::Java.Lang.Object) listenerHandler).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_dataSources);
				JNIEnv.DeleteLocalRef (native_thumbnailRequests);
				global::System.GC.KeepAlive (dataSources);
				global::System.GC.KeepAlive (resizer);
				global::System.GC.KeepAlive (thumbnailRequests);
				global::System.GC.KeepAlive (listener);
				global::System.GC.KeepAlive (listenerHandler);
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Source.IDataSource> DataSources {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions']/method[@name='getDataSources' and count(parameter)=0]"
			[Register ("getDataSources", "()Ljava/util/List;", "")]
			get {
				const string __id = "getDataSources.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Otaliastudios.Transcoder.Source.IDataSource>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Otaliastudios.Transcoder.IThumbnailerListener Listener {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions']/method[@name='getListener' and count(parameter)=0]"
			[Register ("getListener", "()Lcom/otaliastudios/transcoder/ThumbnailerListener;", "")]
			get {
				const string __id = "getListener.()Lcom/otaliastudios/transcoder/ThumbnailerListener;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.IThumbnailerListener> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Android.OS.Handler ListenerHandler {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions']/method[@name='getListenerHandler' and count(parameter)=0]"
			[Register ("getListenerHandler", "()Landroid/os/Handler;", "")]
			get {
				const string __id = "getListenerHandler.()Landroid/os/Handler;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Android.OS.Handler> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Com.Otaliastudios.Transcoder.Resize.IResizer Resizer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions']/method[@name='getResizer' and count(parameter)=0]"
			[Register ("getResizer", "()Lcom/otaliastudios/transcoder/resize/Resizer;", "")]
			get {
				const string __id = "getResizer.()Lcom/otaliastudios/transcoder/resize/Resizer;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Otaliastudios.Transcoder.Resize.IResizer> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int Rotation {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions']/method[@name='getRotation' and count(parameter)=0]"
			[Register ("getRotation", "()I", "")]
			get {
				const string __id = "getRotation.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe global::System.Collections.Generic.IList<global::Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequest> ThumbnailRequests {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.otaliastudios.transcoder']/class[@name='ThumbnailerOptions']/method[@name='getThumbnailRequests' and count(parameter)=0]"
			[Register ("getThumbnailRequests", "()Ljava/util/List;", "")]
			get {
				const string __id = "getThumbnailRequests.()Ljava/util/List;";
				try {
					var __rm = _members.InstanceMethods.InvokeNonvirtualObjectMethod (__id, this, null);
					return global::Android.Runtime.JavaList<global::Com.Otaliastudios.Transcoder.Thumbnail.IThumbnailRequest>.FromJniHandle (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
